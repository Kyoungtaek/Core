using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Await.Models;

namespace WinForms.Await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLast5Orders();
            LoadTotalPrice();
            LoadOrderTotalQty();
        }

        private async void LoadOrderTotalQty()
        {
            var api = new DemoAPI();
            Task<decimal> task = Task.Run(() => api.GetOrderTotalQty());
            decimal result = await task;

            tbxTotalQuantity.Text = result.ToString();
        }

        private async void LoadTotalPrice()
        {
            var api = new DemoAPI();
            Task<decimal> task = Task.Run(() => api.GetOrderTotalPrice());
            decimal result = await task;

            tbxTotalPrice.Text = result.ToString();
        }

        private async void LoadLast5Orders()
        {
            var api = new DemoAPI();
            List<Order> result = await Task.Run(() => api.GetLast5Orders());
            //decimal result = await task;

            dgvOrderList.DataSource = result;
        }
    }
}
