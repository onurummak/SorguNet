
namespace SorguNet
{
    partial class BankForm
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnSorgu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKrediVer = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.gbKrediVerme = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VadeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KapatmaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbKrediVerme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.Color.White;
            this.lblSonuc.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.White;
            this.lblSonuc.Location = new System.Drawing.Point(-3, 177);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(820, 72);
            this.lblSonuc.TabIndex = 19;
            this.lblSonuc.Text = "SORGU";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSorgu
            // 
            this.btnSorgu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSorgu.ForeColor = System.Drawing.Color.White;
            this.btnSorgu.Location = new System.Drawing.Point(419, 135);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(123, 39);
            this.btnSorgu.TabIndex = 18;
            this.btnSorgu.Text = "Bilgi Getir";
            this.btnSorgu.UseVisualStyleBackColor = false;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "TC veya Telefon Giriniz";
            // 
            // tbTc
            // 
            this.tbTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTc.Location = new System.Drawing.Point(274, 99);
            this.tbTc.Name = "tbTc";
            this.tbTc.Size = new System.Drawing.Size(268, 30);
            this.tbTc.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-164, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1120, 68);
            this.label1.TabIndex = 15;
            this.label1.Text = "BANKA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKrediVer
            // 
            this.btnKrediVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKrediVer.ForeColor = System.Drawing.Color.White;
            this.btnKrediVer.Location = new System.Drawing.Point(29, 97);
            this.btnKrediVer.Name = "btnKrediVer";
            this.btnKrediVer.Size = new System.Drawing.Size(259, 66);
            this.btnKrediVer.TabIndex = 20;
            this.btnKrediVer.Text = "Kredi Ver";
            this.btnKrediVer.UseVisualStyleBackColor = false;
            this.btnKrediVer.Click += new System.EventHandler(this.btnKrediVer_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 26);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Vade Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kredi Kapama Tarihi";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(32, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(255, 26);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(28, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 66);
            this.button2.TabIndex = 23;
            this.button2.Text = "Kredi Kapat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbKrediVerme
            // 
            this.gbKrediVerme.Controls.Add(this.label2);
            this.gbKrediVerme.Controls.Add(this.dateTimePicker1);
            this.gbKrediVerme.Controls.Add(this.btnKrediVer);
            this.gbKrediVerme.Enabled = false;
            this.gbKrediVerme.Location = new System.Drawing.Point(4, 373);
            this.gbKrediVerme.Name = "gbKrediVerme";
            this.gbKrediVerme.Size = new System.Drawing.Size(316, 183);
            this.gbKrediVerme.TabIndex = 26;
            this.gbKrediVerme.TabStop = false;
            this.gbKrediVerme.Text = "Kredi Verme";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(477, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 181);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kredi Kapatma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "SORGUNET";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerTc,
            this.VadeTarihi,
            this.KapatmaTarihi,
            this.Durum,
            this.Id});
            this.dataGridView1.Location = new System.Drawing.Point(2, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 105);
            this.dataGridView1.TabIndex = 29;
            // 
            // CustomerTc
            // 
            this.CustomerTc.HeaderText = "Müşteri Tc";
            this.CustomerTc.MinimumWidth = 8;
            this.CustomerTc.Name = "CustomerTc";
            this.CustomerTc.Width = 150;
            // 
            // VadeTarihi
            // 
            this.VadeTarihi.HeaderText = "Vade Tarihi";
            this.VadeTarihi.MinimumWidth = 8;
            this.VadeTarihi.Name = "VadeTarihi";
            this.VadeTarihi.Width = 150;
            // 
            // KapatmaTarihi
            // 
            this.KapatmaTarihi.HeaderText = "Kapatma Tarihi";
            this.KapatmaTarihi.MinimumWidth = 8;
            this.KapatmaTarihi.Name = "KapatmaTarihi";
            this.KapatmaTarihi.Width = 150;
            // 
            // Durum
            // 
            this.Durum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Durum.HeaderText = "Durum";
            this.Durum.MinimumWidth = 8;
            this.Durum.Name = "Durum";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbKrediVerme);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTc);
            this.Controls.Add(this.label1);
            this.Name = "BankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankForm";
            this.Load += new System.EventHandler(this.BankForm_Load);
            this.gbKrediVerme.ResumeLayout(false);
            this.gbKrediVerme.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnSorgu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKrediVer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbKrediVerme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn VadeTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KapatmaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}