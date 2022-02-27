using System;
using System.Windows.Forms;

namespace WinForms.CaesarCipher
{
    public partial class Form1 : Form
    {
        private CaesarCipher caesarCipher;
        public Form1()
        {
            InitializeComponent();
            caesarCipher = new CaesarCipher();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxPlain.Clear();
            tbxCipher.Clear();
            tbxPlain.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Exit?", "Exit", MessageBoxButtons.YesNo))
            {
                Application.Exit();
            }
        }

        private void btnEcrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPlain.Text))
            {
                MessageBox.Show("Please input text.");
                return;
            }

            tbxCipher.Text = caesarCipher.Encode(tbxPlain.Text.Trim(), (int)shiftKey.Value);
        }

        private void btnDecryption_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxCipher.Text))
            {
                MessageBox.Show("Please input text.");
                return;
            }

            tbxPlain.Text = caesarCipher.Decode(tbxCipher.Text.Trim(), (int)shiftKey.Value);
        }
    }
}
