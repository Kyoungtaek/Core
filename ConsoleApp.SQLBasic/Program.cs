using System;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp.SQLBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var da = new DataAccess(GetConnectionString());

            Customer[] customers = new Customer[]
            {
                new Customer { Id = 11, Name = "Kim", Phone = "010" },
                new Customer { Id = 21, Name = "Lee", Phone = "010-511-4342" },
                new Customer { Id = 3, Name = "Park", Phone = "010-532-2232" },
                new Customer { Id = 41, Name = "Oh", Phone = "010-532-3232" },
                new Customer { Id = 51, Name="','') DELETE Customer --"} // Wrong Data
             };

            Console.WriteLine("----- Insert");
            foreach (var customer in customers)
            {
                Console.WriteLine(da.Insert(customer) ? "Success" : "Fail");
            }
            Console.WriteLine();

            Console.WriteLine("----- Update");
            Console.WriteLine(da.Update("010-222-3333", "Kim") ? "Updated Successfully!" : "Update Failed");
            Console.WriteLine();

            Console.WriteLine("----- Delete");
            int targetId = 3;
            Console.WriteLine($"{da.Delete(targetId)} row(s) deleted.");
            Console.WriteLine();


            Console.WriteLine("----- Select");
            Console.WriteLine(da.GetAll());
        }

        private static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build().GetConnectionString("KTConnection");
        }
    }
}
