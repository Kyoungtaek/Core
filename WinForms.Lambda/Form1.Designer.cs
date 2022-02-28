
namespace WinForms.Lambda
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
            this.tbxContent = new System.Windows.Forms.TextBox();
            this.tbFontSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMousePosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRemainder = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxContent
            // 
            this.tbxContent.Location = new System.Drawing.Point(12, 12);
            this.tbxContent.Multiline = true;
            this.tbxContent.Name = "tbxContent";
            this.tbxContent.Size = new System.Drawing.Size(776, 150);
            this.tbxContent.TabIndex = 0;
            // 
            // tbFontSize
            // 
            this.tbFontSize.Location = new System.Drawing.Point(12, 180);
            this.tbFontSize.Name = "tbFontSize";
            this.tbFontSize.Size = new System.Drawing.Size(182, 80);
            this.tbFontSize.TabIndex = 1;
            this.tbFontSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mouse";
            // 
            // lbMousePosition
            // 
            this.lbMousePosition.AutoSize = true;
            this.lbMousePosition.Location = new System.Drawing.Point(309, 180);
            this.lbMousePosition.Name = "lbMousePosition";
            this.lbMousePosition.Size = new System.Drawing.Size(52, 30);
            this.lbMousePosition.TabIndex = 3;
            this.lbMousePosition.Text = "(0,0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remainder";
            // 
            // lbRemainder
            // 
            this.lbRemainder.AutoSize = true;
            this.lbRemainder.Location = new System.Drawing.Point(517, 180);
            this.lbRemainder.Name = "lbRemainder";
            this.lbRemainder.Size = new System.Drawing.Size(46, 30);
            this.lbRemainder.TabIndex = 5;
            this.lbRemainder.Text = "100";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(657, 175);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 40);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 232);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbRemainder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMousePosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFontSize);
            this.Controls.Add(this.tbxContent);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compose";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxContent;
        private System.Windows.Forms.TrackBar tbFontSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMousePosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRemainder;
        private System.Windows.Forms.Button btnSubmit;
    }
}
