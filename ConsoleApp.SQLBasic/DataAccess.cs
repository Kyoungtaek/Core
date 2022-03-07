using System;
using System.Text;
using System.Data.SqlClient;

namespace ConsoleApp.SQLBasic
{
    public class DataAccess
    {
        private string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string GetAll()
        {
            using(var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Customer";

                var result = new StringBuilder();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string customer = $"{sdr["Id"]} | {sdr["Name"]} | {sdr["Phone"]} {Environment.NewLine}";
                    result.Append(customer);
                }
                sdr.Close();

                return result.ToString();
            }
        }

        public bool Insert(Customer customer)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Customer VALUES(@Id, @Name, @Phone)";
                    cmd.Parameters.AddWithValue("@Id", customer.Id);
                    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    return false;
                }
            }
        }

        public bool Update(string newPhone, string name)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = String.Format($"UPDATE Customer SET Phone=@Phone WHERE Name=@Name;");
                cmd.Parameters.AddWithValue("@Phone", newPhone);
                var paramName = new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50);
                paramName.Value = name;
                cmd.Parameters.Add(paramName);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;

                }

                return false;
            }
        }

        public int Delete(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = String.Format($"DELETE Customer WHERE Id=@Id");
                cmd.Parameters.AddWithValue("@Id", id);
                int resultCount = cmd.ExecuteNonQuery();

                return resultCount;
            }
        }
    }
}
