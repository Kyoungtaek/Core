using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.DataInputCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetField();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPassportNo.Text) || string.IsNullOrWhiteSpace(tbxName.Text))
            {
                MessageBox.Show("Passport Number and Name are requirement!");
                return;
            }

            string passportNo = tbxPassportNo.Text.Trim();
            string name = tbxName.Text.Trim();
            string dob = dtpDateOfBirth.Value.ToShortDateString();
            string personData = $"{passportNo},{name},{dob}";

            WriteData(personData);
        }

        private void WriteData(string personData)
        {
            string path = ConfigurationManager.AppSettings["Output"];
            Debug.WriteLine(path);

            var write = new StreamWriter(path, append: true);
            write.WriteLine(personData);
            write.Close();
            MessageBox.Show("Saved Successfully!");

            ResetField();
        }

        private void ResetField()
        {
            tbxPassportNo.Clear();
            tbxName.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            tbxPassportNo.Focus();
        }
    }
}
