
namespace WinForms.CaesarCipher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPlain = new System.Windows.Forms.TextBox();
            this.tbxCipher = new System.Windows.Forms.TextBox();
            this.btnEcrypt = new System.Windows.Forms.Button();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.shiftKey = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.shiftKey)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plain Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cipher Text";
            // 
            // tbxPlain
            // 
            this.tbxPlain.Location = new System.Drawing.Point(143, 12);
            this.tbxPlain.Multiline = true;
            this.tbxPlain.Name = "tbxPlain";
            this.tbxPlain.Size = new System.Drawing.Size(645, 89);
            this.tbxPlain.TabIndex = 2;
            // 
            // tbxCipher
            // 
            this.tbxCipher.Location = new System.Drawing.Point(143, 222);
            this.tbxCipher.Multiline = true;
            this.tbxCipher.Name = "tbxCipher";
            this.tbxCipher.Size = new System.Drawing.Size(645, 89);
            this.tbxCipher.TabIndex = 3;
            // 
            // btnEcrypt
            // 
            this.btnEcrypt.Location = new System.Drawing.Point(143, 134);
            this.btnEcrypt.Name = "btnEcrypt";
            this.btnEcrypt.Size = new System.Drawing.Size(153, 40);
            this.btnEcrypt.TabIndex = 4;
            this.btnEcrypt.Text = "Encryption";
            this.btnEcrypt.UseVisualStyleBackColor = true;
            this.btnEcrypt.Click += new System.EventHandler(this.btnEcrypt_Click);
            // 
            // btnDecryption
            // 
            this.btnDecryption.Location = new System.Drawing.Point(635, 134);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(153, 40);
            this.btnDecryption.TabIndex = 5;
            this.btnDecryption.Text = "Decryption";
            this.btnDecryption.UseVisualStyleBackColor = true;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(143, 384);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(153, 40);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(635, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Shift Key";
            // 
            // shiftKey
            // 
            this.shiftKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shiftKey.Location = new System.Drawing.Point(450, 138);
            this.shiftKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shiftKey.Name = "shiftKey";
            this.shiftKey.Size = new System.Drawing.Size(123, 31);
            this.shiftKey.TabIndex = 9;
            this.shiftKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shiftKey.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shiftKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDecryption);
            this.Controls.Add(this.btnEcrypt);
            this.Controls.Add(this.tbxCipher);
            this.Controls.Add(this.tbxPlain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caesar Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.shiftKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPlain;
        private System.Windows.Forms.TextBox tbxCipher;
        private System.Windows.Forms.Button btnEcrypt;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown shiftKey;
    }
}
