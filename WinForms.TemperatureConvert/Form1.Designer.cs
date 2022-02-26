
namespace WinForms.TemperatureConvert
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
            this.tbxInputCelsius = new System.Windows.Forms.TextBox();
            this.btnToFahrenheit = new System.Windows.Forms.Button();
            this.tbxOutputFahrenheit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOutputCelsius = new System.Windows.Forms.TextBox();
            this.btnToCelsius = new System.Windows.Forms.Button();
            this.tbxInputFahrenheit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // tbxInputCelsius
            // 
            this.tbxInputCelsius.Location = new System.Drawing.Point(34, 80);
            this.tbxInputCelsius.Name = "tbxInputCelsius";
            this.tbxInputCelsius.Size = new System.Drawing.Size(175, 35);
            this.tbxInputCelsius.TabIndex = 1;
            this.tbxInputCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnToFahrenheit
            // 
            this.btnToFahrenheit.Location = new System.Drawing.Point(233, 80);
            this.btnToFahrenheit.Name = "btnToFahrenheit";
            this.btnToFahrenheit.Size = new System.Drawing.Size(175, 35);
            this.btnToFahrenheit.TabIndex = 2;
            this.btnToFahrenheit.Text = "To Fahrenheit";
            this.btnToFahrenheit.UseVisualStyleBackColor = true;
            this.btnToFahrenheit.Click += new System.EventHandler(this.btnToFahrenheit_Click);
            // 
            // tbxOutputFahrenheit
            // 
            this.tbxOutputFahrenheit.Location = new System.Drawing.Point(432, 80);
            this.tbxOutputFahrenheit.Name = "tbxOutputFahrenheit";
            this.tbxOutputFahrenheit.ReadOnly = true;
            this.tbxOutputFahrenheit.Size = new System.Drawing.Size(175, 35);
            this.tbxOutputFahrenheit.TabIndex = 3;
            this.tbxOutputFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fahrenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Celsius";
            // 
            // tbxOutputCelsius
            // 
            this.tbxOutputCelsius.Location = new System.Drawing.Point(436, 224);
            this.tbxOutputCelsius.Name = "tbxOutputCelsius";
            this.tbxOutputCelsius.ReadOnly = true;
            this.tbxOutputCelsius.Size = new System.Drawing.Size(175, 35);
            this.tbxOutputCelsius.TabIndex = 8;
            this.tbxOutputCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnToCelsius
            // 
            this.btnToCelsius.Location = new System.Drawing.Point(237, 224);
            this.btnToCelsius.Name = "btnToCelsius";
            this.btnToCelsius.Size = new System.Drawing.Size(175, 35);
            this.btnToCelsius.TabIndex = 7;
            this.btnToCelsius.Text = "To Celsius";
            this.btnToCelsius.UseVisualStyleBackColor = true;
            this.btnToCelsius.Click += new System.EventHandler(this.btnToCelsius_Click);
            // 
            // tbxInputFahrenheit
            // 
            this.tbxInputFahrenheit.Location = new System.Drawing.Point(38, 224);
            this.tbxInputFahrenheit.Name = "tbxInputFahrenheit";
            this.tbxInputFahrenheit.Size = new System.Drawing.Size(175, 35);
            this.tbxInputFahrenheit.TabIndex = 6;
            this.tbxInputFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fahrenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxOutputCelsius);
            this.Controls.Add(this.btnToCelsius);
            this.Controls.Add(this.tbxInputFahrenheit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxOutputFahrenheit);
            this.Controls.Add(this.btnToFahrenheit);
            this.Controls.Add(this.tbxInputCelsius);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInputCelsius;
        private System.Windows.Forms.Button btnToFahrenheit;
        private System.Windows.Forms.TextBox tbxOutputFahrenheit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOutputCelsius;
        private System.Windows.Forms.Button btnToCelsius;
        private System.Windows.Forms.TextBox tbxInputFahrenheit;
        private System.Windows.Forms.Label label4;
    }
}
