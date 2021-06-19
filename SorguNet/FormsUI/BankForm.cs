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

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            customerTc = tbTc.Text;

            var customer = _customerManager.GetCustomer(tbTc.Text);
            if (customer == null)
            {
                lblSonuc.Text = "Tc kimlik numarasına ait sonuc bulunamadı.";
                lblSonuc.ForeColor = Color.Black;
            }
            else
            {
                lblSonuc.Text = customer.AdSoyad + " müşterisinin kredi notu = " + customer.KrediNot;
                if (customer.KrediNot >= 1000)
                {
                    lblSonuc.Text += "\n Müşterinin kredi çekmesi uygundur.";
                    gbKrediVerme.Enabled = true;
                }
                else
                {
                    lblSonuc.Text += "\n Müşterinin kredi çekmesi uygun değildir.";
                    gbKrediVerme.Enabled = false;
                }
                lblSonuc.ForeColor = Color.Black;
                GetCustomerKrediList();
            }

        }

        private void GetCustomerKrediList()
        {
            dataGridView1.Rows.Clear();
            List<BankKredi> list = _bankManager.GetKredi(tbTc.Text);
            foreach (var item in list)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = item.CustomerTC;
                row.Cells[1].Value = item.VadeTarihi;
                row.Cells[2].Value = item.KapanmaTarihi;
                row.Cells[3].Value = item.Status==1?"Açık":"Kapalı";
                row.Cells[4].Value = item.Id;
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnKrediVer_Click(object sender, EventArgs e)
        {
            BankKredi bankKredi = new BankKredi();
            bankKredi.CustomerTC = customerTc;
            bankKredi.VadeTarihi = dateTimePicker1.Value;
            bankKredi.Status = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {

            }
            else
            {
                MessageBox.Show("Kapanacak krediyi listeden seçiniz!");
            }
        }
    }
}
