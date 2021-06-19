
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
            this.tbTc = new System.Windows.Forms.TextBox();
            this.btnSorgu = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
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
            // tbTc
            // 
            this.tbTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTc.Location = new System.Drawing.Point(109, 164);
            this.tbTc.Name = "tbTc";
            this.tbTc.Size = new System.Drawing.Size(268, 30);
            this.tbTc.TabIndex = 10;
            // 
            // btnSorgu
            // 
            this.btnSorgu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSorgu.ForeColor = System.Drawing.Color.White;
            this.btnSorgu.Location = new System.Drawing.Point(287, 200);
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
            this.lblSonuc.Location = new System.Drawing.Point(-1, 249);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(481, 72);
            this.lblSonuc.TabIndex = 14;
            this.lblSonuc.Text = "SORGU";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(109, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 64);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Seçeneği";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tcye Göre";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(158, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tele Göre";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // CustomerPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.tbTc);
            this.Controls.Add(this.label1);
            this.Name = "CustomerPointForm";
            this.Text = "Sorgu Ekranı";
            this.Load += new System.EventHandler(this.CustomerPointForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTc;
        private System.Windows.Forms.Button btnSorgu;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}