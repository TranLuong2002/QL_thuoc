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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQLT_Click(object sender, EventArgs e)
        {
            FormMediMgn formMediMgn = new FormMediMgn();
            formMediMgn.Show();
            this.Hide();
        }

        private void btnQLDH_Click(object sender, EventArgs e)
        {
            FormMediSell formMediSell = new FormMediSell();
            formMediSell.Show();
            this.Hide();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            FormStockMgn form  = new FormStockMgn();
            form.Show();
            this.Hide();
        }
    }
}
