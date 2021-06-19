using SorguNet.Business.Abstract;
using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorguNet
{
    public partial class BankForm : Form
    {
        ICustomerManager _customerManager;
        IBankManager _bankManager;
        public BankForm(ICustomerManager customerManager, IBankManager bankManager)
        {
            InitializeComponent();
            _customerManager = customerManager;
            _bankManager = bankManager;
        }
        string customerTc;
        private void BankForm_Load(object sender, EventArgs e)
        {

        }
        void GetMusteri()
        {
            var customer = _customerManager.GetCustomer(tbTc.Text);
            if (customer == null)
            {
                lblSonuc.Text = "Tc kimlik numarasına ait sonuc bulunamadı.";
                lblSonuc.ForeColor = Color.Black;
                customerTc = null;
            }
            else
            {
                customerTc = customer.TC;
                lblSonuc.Text = customer.AdSoyad + " müşterisinin kredi notu = " + customer.KrediNot;
                if (customer.KrediNot >= 1000)
                {
                    gbKrediVerme.Enabled = true;
                    lblSonuc.Text += "\n Müşterinin kredi çekmesi uygundur.";
                }
                else
                {
                    gbKrediVerme.Enabled = false;
                    lblSonuc.Text += "\n Müşterinin kredi çekmesi uygun değildir.";
                }
                lblSonuc.ForeColor = Color.Black;
                GetCustomerKrediList();
            }

        }
        private void btnSorgu_Click(object sender, EventArgs e)
        {

            GetMusteri();
        }

        private void GetCustomerKrediList()
        {
            dataGridView1.Rows.Clear();
            List<BankKredi> list = _bankManager.GetKredi(customerTc);
            foreach (var item in list)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = item.CustomerTC;
                row.Cells[1].Value = item.VadeTarihi;
                row.Cells[2].Value = item.KapanmaTarihi;
                row.Cells[3].Value = item.Status == 1 ? "Açık" : "Kapalı";
                row.Cells[4].Value = item.Id;
                row.Cells[5].Value = "Sil";
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnKrediVer_Click(object sender, EventArgs e)
        {
            if (customerTc != null)
            {
                BankKredi bankKredi = new BankKredi();
                bankKredi.CustomerTC = customerTc;
                bankKredi.VadeTarihi = dateTimePicker1.Value;
                bankKredi.Status = 1;
                _bankManager.SaveKredi(bankKredi);
                GetCustomerKrediList();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tc giriniz!");
            }
        }

        private void btnKrediKapat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "Kapalı")
                {
                    MessageBox.Show("Kredi zaten kapatılmıştır.");
                    return;
                }
                BankKredi bankKredi = new BankKredi();
                bankKredi.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                bankKredi.CustomerTC = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                bankKredi.VadeTarihi = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[1].Value);
                bankKredi.KapanmaTarihi = dateTimePicker2.Value;
                _bankManager.ClosedKredi(bankKredi);
                int point;
                if (bankKredi.VadeTarihi < bankKredi.KapanmaTarihi)
                    point = -50;
                else
                    point = 50;
                _customerManager.UpdatePoint(bankKredi.CustomerTC, point);
                GetCustomerKrediList();
                GetMusteri();
                MessageBox.Show("Kredi kapatılmıştır...");
            }
            else
            {
                MessageBox.Show("Kapanacak krediyi listeden seçiniz!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex ==5 &&
                e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                int id =Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                _bankManager.DeleteKredi(id);
                MessageBox.Show("Silme işlemi başarılı.");
                GetCustomerKrediList();
            }
        }
    }
}
