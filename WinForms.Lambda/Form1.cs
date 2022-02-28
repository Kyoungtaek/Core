using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinForms.Lambda
{
    public partial class Form1 : Form
    {
        private int total = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxContent.MaxLength = this.total;

            // TODO: To Lambda
            //tbxContent.TextChanged += TbxContent_TextChanged;
            tbxContent.TextChanged += (sender, e) =>
            {
                int remainder = total - tbxContent.Text.Length;
                lbRemainder.Text = remainder.ToString();
            };

            // TODO: To Lambda
            //tbxContent.MouseMove += TbxConTent_MouseMove;

            tbxContent.MouseMove += (sender, e) =>
            {
                lbMousePosition.Text = string.Format("({0},{1})", e.X, e.Y);
            };

            // TODO: To Lambda
            //tbFontSize.Scroll += delegate (object sender, EventArgs e)
            //{
            //    int newSize = tbFontSize.Value + (int)this.Font.Size;
            //    tbxContent.Font = new Font(this.Font.FontFamily, newSize);
            //};

            tbFontSize.Scroll += (sender, e) =>
            {
                int newSize = tbFontSize.Value + (int)this.Font.Size;
                tbxContent.Font = new Font(this.Font.FontFamily, newSize);
            };

            // TODO: To Lambda
            //btnSubmit.Click += delegate (object sender, EventArgs e)
            //{
            //    using (var writer = new StreamWriter(@"output.txt"))
            //    {
            //        writer.Write(tbxContent.Text);
            //    }
            //};

            btnSubmit.Click += (sender, e) =>
            {
                using (var writer = new StreamWriter(@"output.txt"))
                {
                    writer.Write(tbxContent.Text);
                }

                MessageBox.Show("Contents Saved!");
            };
        }

        //private void TbxConTent_MouseMove(object sender, MouseEventArgs e)
        //{
        //    lbMousePosition.Text = string.Format("({0},{1})", e.X, e.Y);
        //}

        //private void TbxContent_TextChanged(object sender, EventArgs e)
        //{
        //    int remainder = total - tbxContent.Text.Length;
        //    lbRemainder.Text = remainder.ToString();
        //}
    }
}
