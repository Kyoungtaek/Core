using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.TemperatureConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToFahrenheit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxInputCelsius.Text))
            {
                MessageBox.Show("Please enter temperature. ( Celsius )", "Error");
                tbxInputCelsius.Focus();
            }
            else
            {
                if (Double.TryParse(tbxInputCelsius.Text, out double celsius))
                {
                    double result = (celsius * 1.8) + 32;
                    result = Math.Round(result, 1);

                    tbxOutputFahrenheit.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter only numbers.", "Error");
                    tbxInputCelsius.Clear();
                    tbxInputCelsius.Focus();
                }
            }
        }

        private void btnToCelsius_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxInputFahrenheit.Text))
            {
                MessageBox.Show("Please enter temperature. ( Fahrenheit )", "Error");
                tbxInputFahrenheit.Focus();
            }
            else
            {
                if (Double.TryParse(tbxInputFahrenheit.Text, out double fahrenheit))
                {
                    double result = (fahrenheit - 31) / 1.8;
                    result = Math.Round(result, 1);

                    tbxOutputCelsius.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter only numbers.", "Error");
                    tbxInputFahrenheit.Clear();
                    tbxInputFahrenheit.Focus();
                }
            }
        }
    }
}
