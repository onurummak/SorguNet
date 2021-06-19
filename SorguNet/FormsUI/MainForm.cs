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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (LoginInfo.user.Rol == 2)
            {
                btnBanka.Enabled = false;
                btnIcra.Enabled = false;
                btnMusteri.Enabled = false;
                btnSorgu.Enabled = true;
            }
            else
            {
                btnBanka.Enabled = true;
                btnIcra.Enabled = true;
                btnMusteri.Enabled = true;
                btnSorgu.Enabled = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            var child = Program.container.GetInstance<CustomerForm>();
            child.ShowDialog();
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            var child = Program.container.GetInstance<CustomerPointForm>();
            child.ShowDialog();
        }

        private void btnBanka_Click(object sender, EventArgs e)
        {
            var child = Program.container.GetInstance<BankForm>();
            child.ShowDialog();
        }
    }
}
