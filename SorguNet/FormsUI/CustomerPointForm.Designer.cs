
namespace SorguNet
{
    partial class CustomerPointForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTc = new System.Windows.Forms.TextBox();
            this.btnSorgu = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-320, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1120, 68);
            this.label1.TabIndex = 6;
            this.label1.Text = "SORGU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "TC veya Telefon Giriniz";
            // 
            // tbTc
            // 
            this.tbTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTc.Location = new System.Drawing.Point(115, 106);
            this.tbTc.Name = "tbTc";
            this.tbTc.Size = new System.Drawing.Size(268, 30);
            this.tbTc.TabIndex = 10;
            // 
            // btnSorgu
            // 
            this.btnSorgu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSorgu.ForeColor = System.Drawing.Color.White;
            this.btnSorgu.Location = new System.Drawing.Point(293, 142);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(90, 39);
            this.btnSorgu.TabIndex = 13;
            this.btnSorgu.Text = "Sorgula";
            this.btnSorgu.UseVisualStyleBackColor = false;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.Color.White;
            this.lblSonuc.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.White;
            this.lblSonuc.Location = new System.Drawing.Point(-3, 204);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(481, 72);
            this.lblSonuc.TabIndex = 14;
            this.lblSonuc.Text = "SORGU";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 278);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTc);
            this.Controls.Add(this.label1);
            this.Name = "CustomerPointForm";
            this.Text = "Sorgu Ekranı";
            this.Load += new System.EventHandler(this.CustomerPointForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTc;
        private System.Windows.Forms.Button btnSorgu;
        private System.Windows.Forms.Label lblSonuc;
    }
}