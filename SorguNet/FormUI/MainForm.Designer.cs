
namespace SorguNet
{
    partial class MainForm
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
            this.btnBanka = new System.Windows.Forms.Button();
            this.btnIcra = new System.Windows.Forms.Button();
            this.btnSorgu = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBanka
            // 
            this.btnBanka.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanka.Location = new System.Drawing.Point(64, 184);
            this.btnBanka.Name = "btnBanka";
            this.btnBanka.Size = new System.Drawing.Size(456, 177);
            this.btnBanka.TabIndex = 0;
            this.btnBanka.Text = "BANKA";
            this.btnBanka.UseVisualStyleBackColor = true;
            this.btnBanka.Click += new System.EventHandler(this.btnBanka_Click);
            // 
            // btnIcra
            // 
            this.btnIcra.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIcra.Location = new System.Drawing.Point(590, 184);
            this.btnIcra.Name = "btnIcra";
            this.btnIcra.Size = new System.Drawing.Size(456, 177);
            this.btnIcra.TabIndex = 1;
            this.btnIcra.Text = "İCRA";
            this.btnIcra.UseVisualStyleBackColor = true;
            this.btnIcra.Click += new System.EventHandler(this.btnIcra_Click);
            // 
            // btnSorgu
            // 
            this.btnSorgu.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgu.Location = new System.Drawing.Point(64, 378);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(456, 177);
            this.btnSorgu.TabIndex = 2;
            this.btnSorgu.Text = "SORGU";
            this.btnSorgu.UseVisualStyleBackColor = true;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.Location = new System.Drawing.Point(590, 378);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(456, 177);
            this.btnMusteri.TabIndex = 3;
            this.btnMusteri.Text = "MÜŞTERİ";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-14, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1120, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "SORGUNET";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1096, 662);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.btnIcra);
            this.Controls.Add(this.btnBanka);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SorguNet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBanka;
        private System.Windows.Forms.Button btnIcra;
        private System.Windows.Forms.Button btnSorgu;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Label label1;
    }
}

