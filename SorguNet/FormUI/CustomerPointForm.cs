using SorguNet.Business.Abstract;
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
    public partial class CustomerPointForm : Form
    {
        ICustomerManager _customerManager;
        public CustomerPointForm(ICustomerManager customerManager)
        {
            InitializeComponent();
            _customerManager = customerManager;
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            var customer = _customerManager.GetCustomer(tbTc.Text,radioButton1.Checked?1:2);
            if (customer == null)
            {
                lblSonuc.Text = "Tc kimlik numarasına ait sonuc bulunamadı.";
                lblSonuc.ForeColor = Color.Black;
            }
            else
            {
                lblSonuc.Text = customer.AdSoyad + " müşterisinin kredi notu = " + customer.KrediNot;
                lblSonuc.ForeColor = Color.Black;
            }
        }

        private void CustomerPointForm_Load(object sender, EventArgs e)
        {

        }
    }
}
