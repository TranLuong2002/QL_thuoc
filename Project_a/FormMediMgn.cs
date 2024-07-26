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
    public partial class FormMediMgn : Form
    {
        public FormMediMgn()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
        private void cmbChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChucNang.SelectedIndex == 1)
            {
                txtbBarcode.Enabled = false;
                txtbMaNCC.Enabled = false;
            }
            else
            {
                txtbBarcode.Enabled = true;
                txtbMaNCC.Enabled = true;
            }
        }

        private void rdThuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThuoc.Checked == true)
            {
                gbNCC.Enabled = false;
                gbThuoc.Enabled = true;
            }
            else if (rdThuoc.Checked == false)
            {
                gbThuoc.Enabled = false;
                gbNCC.Enabled = true;
            }
        }
    }
}
