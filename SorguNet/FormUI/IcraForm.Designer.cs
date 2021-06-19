
namespace SorguNet.FormUI
{
    partial class IcraForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.gbKrediKapat = new System.Windows.Forms.GroupBox();
            this.btnIcraKapat = new System.Windows.Forms.Button();
            this.gbKrediVerme = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIcraAc = new System.Windows.Forms.Button();
            this.btnSorgu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itirazli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IcraTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KapatmaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbKrediKapat.SuspendLayout();
            this.gbKrediVerme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "SORGUNET";
            // 
            // gbKrediKapat
            // 
            this.gbKrediKapat.Controls.Add(this.btnIcraKapat);
            this.gbKrediKapat.Location = new System.Drawing.Point(489, 274);
            this.gbKrediKapat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbKrediKapat.Name = "gbKrediKapat";
            this.gbKrediKapat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbKrediKapat.Size = new System.Drawing.Size(208, 118);
            this.gbKrediKapat.TabIndex = 36;
            this.gbKrediKapat.TabStop = false;
            this.gbKrediKapat.Text = "İcra Kapatma";
            // 
            // btnIcraKapat
            // 
            this.btnIcraKapat.BackColor = System.Drawing.Color.DarkRed;
            this.btnIcraKapat.ForeColor = System.Drawing.Color.White;
            this.btnIcraKapat.Location = new System.Drawing.Point(19, 62);
            this.btnIcraKapat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIcraKapat.Name = "btnIcraKapat";
            this.btnIcraKapat.Size = new System.Drawing.Size(173, 43);
            this.btnIcraKapat.TabIndex = 23;
            this.btnIcraKapat.Text = "İcra Kapat";
            this.btnIcraKapat.UseVisualStyleBackColor = false;
            this.btnIcraKapat.Click += new System.EventHandler(this.btnIcraKapat_Click);
            // 
            // gbKrediVerme
            // 
            this.gbKrediVerme.Controls.Add(this.comboBox1);
            this.gbKrediVerme.Controls.Add(this.label2);
            this.gbKrediVerme.Controls.Add(this.btnIcraAc);
            this.gbKrediVerme.Location = new System.Drawing.Point(8, 274);
            this.gbKrediVerme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbKrediVerme.Name = "gbKrediVerme";
            this.gbKrediVerme.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbKrediVerme.Size = new System.Drawing.Size(211, 119);
            this.gbKrediVerme.TabIndex = 35;
            this.gbKrediVerme.TabStop = false;
            this.gbKrediVerme.Text = "İcra Açma";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İtirazlı",
            "İtiraz Yok"});
            this.comboBox1.Location = new System.Drawing.Point(22, 41);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "İtirazlı Mı?";
            // 
            // btnIcraAc
            // 
            this.btnIcraAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIcraAc.ForeColor = System.Drawing.Color.White;
            this.btnIcraAc.Location = new System.Drawing.Point(19, 63);
            this.btnIcraAc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIcraAc.Name = "btnIcraAc";
            this.btnIcraAc.Size = new System.Drawing.Size(173, 43);
            this.btnIcraAc.TabIndex = 20;
            this.btnIcraAc.Text = "İcra Aç";
            this.btnIcraAc.UseVisualStyleBackColor = false;
            this.btnIcraAc.Click += new System.EventHandler(this.btnIcraAc_Click);
            // 
            // btnSorgu
            // 
            this.btnSorgu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSorgu.ForeColor = System.Drawing.Color.White;
            this.btnSorgu.Location = new System.Drawing.Point(361, 84);
            this.btnSorgu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(82, 25);
            this.btnSorgu.TabIndex = 33;
            this.btnSorgu.Text = "Bilgi Getir";
            this.btnSorgu.UseVisualStyleBackColor = false;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "TC veya Telefon Giriniz";
            // 
            // tbTc
            // 
            this.tbTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTc.Location = new System.Drawing.Point(264, 61);
            this.tbTc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTc.Name = "tbTc";
            this.tbTc.Size = new System.Drawing.Size(180, 23);
            this.tbTc.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-18, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 44);
            this.label1.TabIndex = 30;
            this.label1.Text = "ICRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.Color.White;
            this.lblSonuc.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.White;
            this.lblSonuc.Location = new System.Drawing.Point(-17, 115);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(713, 36);
            this.lblSonuc.TabIndex = 34;
            this.lblSonuc.Text = "SORGU";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TcNo,
            this.Itirazli,
            this.IcraTarihi,
            this.KapatmaTarihi,
            this.Durum,
            this.Id,
            this.Sil});
            this.dataGridView1.Location = new System.Drawing.Point(1, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(695, 120);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TcNo
            // 
            this.TcNo.HeaderText = "Müşteri Tc";
            this.TcNo.MinimumWidth = 8;
            this.TcNo.Name = "TcNo";
            this.TcNo.Width = 150;
            // 
            // Itirazli
            // 
            this.Itirazli.HeaderText = "İtirazlı Mı";
            this.Itirazli.MinimumWidth = 8;
            this.Itirazli.Name = "Itirazli";
            this.Itirazli.Width = 150;
            // 
            // IcraTarihi
            // 
            this.IcraTarihi.HeaderText = "İcra Tarihi";
            this.IcraTarihi.MinimumWidth = 8;
            this.IcraTarihi.Name = "IcraTarihi";
            this.IcraTarihi.Width = 150;
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
            // Sil
            // 
            this.Sil.HeaderText = "Sil";
            this.Sil.Name = "Sil";
            // 
            // IcraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 401);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbKrediKapat);
            this.Controls.Add(this.gbKrediVerme);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSonuc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IcraForm";
            this.Text = "IcraForm";
            this.gbKrediKapat.ResumeLayout(false);
            this.gbKrediVerme.ResumeLayout(false);
            this.gbKrediVerme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbKrediKapat;
        private System.Windows.Forms.Button btnIcraKapat;
        private System.Windows.Forms.GroupBox gbKrediVerme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIcraAc;
        private System.Windows.Forms.Button btnSorgu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itirazli;
        private System.Windows.Forms.DataGridViewTextBoxColumn IcraTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KapatmaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;
    }
}