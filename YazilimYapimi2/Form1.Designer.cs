namespace YazilimYapimi2
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.rdb8x8 = new System.Windows.Forms.RadioButton();
            this.rdb9x9 = new System.Windows.Forms.RadioButton();
            this.rdb7x7 = new System.Windows.Forms.RadioButton();
            this.rdb6x6 = new System.Windows.Forms.RadioButton();
            this.rdb5x5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(82, 188);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(94, 42);
            this.btnBasla.TabIndex = 11;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // rdb8x8
            // 
            this.rdb8x8.AutoSize = true;
            this.rdb8x8.Location = new System.Drawing.Point(161, 94);
            this.rdb8x8.Name = "rdb8x8";
            this.rdb8x8.Size = new System.Drawing.Size(59, 21);
            this.rdb8x8.TabIndex = 10;
            this.rdb8x8.TabStop = true;
            this.rdb8x8.Text = "8 x 8";
            this.rdb8x8.UseVisualStyleBackColor = true;
            // 
            // rdb9x9
            // 
            this.rdb9x9.AutoSize = true;
            this.rdb9x9.Location = new System.Drawing.Point(91, 131);
            this.rdb9x9.Name = "rdb9x9";
            this.rdb9x9.Size = new System.Drawing.Size(63, 21);
            this.rdb9x9.TabIndex = 9;
            this.rdb9x9.TabStop = true;
            this.rdb9x9.Text = "9 x 9 ";
            this.rdb9x9.UseVisualStyleBackColor = true;
            // 
            // rdb7x7
            // 
            this.rdb7x7.AutoSize = true;
            this.rdb7x7.Location = new System.Drawing.Point(37, 94);
            this.rdb7x7.Name = "rdb7x7";
            this.rdb7x7.Size = new System.Drawing.Size(59, 21);
            this.rdb7x7.TabIndex = 8;
            this.rdb7x7.TabStop = true;
            this.rdb7x7.Text = "7 x 7";
            this.rdb7x7.UseVisualStyleBackColor = true;
            // 
            // rdb6x6
            // 
            this.rdb6x6.AutoSize = true;
            this.rdb6x6.Location = new System.Drawing.Point(161, 50);
            this.rdb6x6.Name = "rdb6x6";
            this.rdb6x6.Size = new System.Drawing.Size(59, 21);
            this.rdb6x6.TabIndex = 7;
            this.rdb6x6.TabStop = true;
            this.rdb6x6.Text = "6 x 6";
            this.rdb6x6.UseVisualStyleBackColor = true;
            // 
            // rdb5x5
            // 
            this.rdb5x5.AutoSize = true;
            this.rdb5x5.Location = new System.Drawing.Point(37, 50);
            this.rdb5x5.Name = "rdb5x5";
            this.rdb5x5.Size = new System.Drawing.Size(59, 21);
            this.rdb5x5.TabIndex = 6;
            this.rdb5x5.TabStop = true;
            this.rdb5x5.Text = "5 x 5";
            this.rdb5x5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 265);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.rdb8x8);
            this.Controls.Add(this.rdb9x9);
            this.Controls.Add(this.rdb7x7);
            this.Controls.Add(this.rdb6x6);
            this.Controls.Add(this.rdb5x5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.RadioButton rdb8x8;
        private System.Windows.Forms.RadioButton rdb9x9;
        private System.Windows.Forms.RadioButton rdb7x7;
        private System.Windows.Forms.RadioButton rdb6x6;
        private System.Windows.Forms.RadioButton rdb5x5;
    }
}

