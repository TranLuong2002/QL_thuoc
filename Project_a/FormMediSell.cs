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
    public partial class FormMediSell : Form
    {
        public FormMediSell()
        {
            InitializeComponent();
            txtbBarcode.Enabled = false;
            txtbTenThuoc.Enabled = false;
            txtbDonGia.Enabled = false;
            dtpNSX.Enabled = false;
            dtpNHH.Enabled = false;
            txtbSoHoaDon.Enabled = false;
            txtbTSTD.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
