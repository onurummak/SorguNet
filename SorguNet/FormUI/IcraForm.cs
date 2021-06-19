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

namespace SorguNet.FormUI
{
    public partial class IcraForm : Form
    {
        ICustomerManager _customerManager;
        IIcraManager _icraManager;
        public IcraForm(ICustomerManager customerManager, IIcraManager icraManager)
        {
            InitializeComponent();
            _customerManager = customerManager;
            _icraManager = icraManager;
        }
        string customerTc;
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
                    lblSonuc.Text += "\n Müşterinin kredi çekmesi uygundur.";
                }
                else
                {
                    lblSonuc.Text += "\n Müşterinin kredi çekmesi uygun değildir.";
                }
                lblSonuc.ForeColor = Color.Black;
                GetCustomerIcraList();
            }

        }
        private void GetCustomerIcraList()
        {
            dataGridView1.Rows.Clear();
            List<Icra> list = _icraManager.GetIcra(customerTc);
            foreach (var item in list)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = item.CustomerTC;
                row.Cells[1].Value = item.Itirazli == 1 ? "İtirazlı" : "Itiraz Yok";
                row.Cells[2].Value = item.AçılmaTarihi;
                row.Cells[3].Value = item.KapanmaTarihi;
                row.Cells[4].Value = item.Status == 1 ? "Açık" : "Kapalı";
                row.Cells[5].Value = item.Id;
                row.Cells[6].Value = "Sil";
                dataGridView1.Rows.Add(row);
            }
        }
        private void btnSorgu_Click(object sender, EventArgs e)
        {
            GetMusteri();
        }

        private void btnIcraAc_Click(object sender, EventArgs e)
        {
            int itirazliMi = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                itirazliMi = 1;
            }
            if (customerTc != null)
            {
                Icra icra = new Icra();
                icra.CustomerTC = customerTc;
                icra.Itirazli = itirazliMi;
                _icraManager.SaveIcra(icra);
                GetCustomerIcraList();
                if (itirazliMi == 1)
                    _customerManager.UpdatePoint(icra.CustomerTC, 0);
                else
                    _customerManager.UpdatePoint(icra.CustomerTC, -50);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tc giriniz!");
            }
        }

        private void btnIcraKapat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "Kapalı")
                {
                    MessageBox.Show("İcra zaten kapatılmıştır.");
                    return;
                }
                Icra icra = new Icra();
                icra.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
                icra.CustomerTC = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                icra.Itirazli = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == "İtirazlı" ? 1 : 0;
                icra.AçılmaTarihi = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value);
                _icraManager.ClosedIcra(icra);

                _customerManager.UpdatePoint(icra.CustomerTC, 50);
                GetCustomerIcraList();
                GetMusteri();
                MessageBox.Show("İcra kapatılmıştır...");
            }
            else
            {
                MessageBox.Show("Kapanacak krediyi listeden seçiniz!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == 6 &&
                e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                _icraManager.DeleteIcra(id);
                MessageBox.Show("Silme işlemi başarılı.");
                GetCustomerIcraList();
            }
        }
    }
}
