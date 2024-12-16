namespace CircleProgram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTradius = new System.Windows.Forms.TextBox();
            this.TXTdiameter = new System.Windows.Forms.TextBox();
            this.TXTarea = new System.Windows.Forms.TextBox();
            this.TXTcircumfrence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTradius
            // 
            this.TXTradius.Location = new System.Drawing.Point(12, 12);
            this.TXTradius.Name = "TXTradius";
            this.TXTradius.Size = new System.Drawing.Size(99, 20);
            this.TXTradius.TabIndex = 0;
            this.TXTradius.TextChanged += new System.EventHandler(this.TXTradius_TextChanged);
            // 
            // TXTdiameter
            // 
            this.TXTdiameter.Location = new System.Drawing.Point(188, 12);
            this.TXTdiameter.Name = "TXTdiameter";
            this.TXTdiameter.Size = new System.Drawing.Size(331, 20);
            this.TXTdiameter.TabIndex = 1;
            // 
            // TXTarea
            // 
            this.TXTarea.Location = new System.Drawing.Point(188, 38);
            this.TXTarea.Name = "TXTarea";
            this.TXTarea.Size = new System.Drawing.Size(331, 20);
            this.TXTarea.TabIndex = 2;
            // 
            // TXTcircumfrence
            // 
            this.TXTcircumfrence.BackColor = System.Drawing.SystemColors.Window;
            this.TXTcircumfrence.Location = new System.Drawing.Point(188, 64);
            this.TXTcircumfrence.Name = "TXTcircumfrence";
            this.TXTcircumfrence.Size = new System.Drawing.Size(331, 20);
            this.TXTcircumfrence.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Input Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bill Barg 2020";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 101);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTcircumfrence);
            this.Controls.Add(this.TXTarea);
            this.Controls.Add(this.TXTdiameter);
            this.Controls.Add(this.TXTradius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTradius;
        private System.Windows.Forms.TextBox TXTdiameter;
        private System.Windows.Forms.TextBox TXTarea;
        private System.Windows.Forms.TextBox TXTcircumfrence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

