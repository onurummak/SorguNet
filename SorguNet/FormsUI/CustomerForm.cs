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
    public partial class CustomerForm : Form
    {
        ICustomerManager _customerManager;
        public CustomerForm(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
            InitializeComponent();
        }
        void GetCustomerList()
        {
            dataGridView1.Rows.Clear();
            List<Customer> list = _customerManager.GetList();
            foreach (var item in list)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = item.TC;
                row.Cells[1].Value = item.AdSoyad;
                row.Cells[2].Value = item.Telefon;
                row.Cells[3].Value = "Sil";
                dataGridView1.Rows.Add(row);
            }

        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            GetCustomerList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text != null && tbTc.Text != null && tbPhone.Text != null)
            {
                try
                {
                    Customer customer = new Customer();
                    customer.AdSoyad = tbName.Text;
                    customer.TC = tbTc.Text;
                    customer.Telefon = tbPhone.Text;
                    _customerManager.SaveCustomer(customer);
                    GetCustomerList();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata oluştu!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm alanları doldurunuz!");
            }

        }
        public void ClearForm()
        {
            tbName.Text = null; tbTc.Text = null;  tbPhone.Text = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex==3 &&
                e.RowIndex >= 0&&e.RowIndex<dataGridView1.Rows.Count-1)
            {
                string tc = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                _customerManager.DeleteCustomer(tc);
                GetCustomerList();
            }
        }
    }
}
