using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_a
{
    public partial class FormStockMgn : Form
    {
        public FormStockMgn()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnBackThuoc_Click(object sender, EventArgs e)
        {
            FormMediMgn mainForm = new FormMediMgn();
            mainForm.Show();
            this.Hide();
        }
    }
}
