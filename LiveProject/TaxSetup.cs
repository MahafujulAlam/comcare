using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveProject
{
    public partial class TaxSetup : Form
    {
        public TaxSetup()
        {
            InitializeComponent();
        }

        private void TaxSetup_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ratetaxsetup_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametaxsetup_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void statustaxsetup_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void remarktaxsetup_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCF_Click(object sender, EventArgs e)
        {
            TaxSetupNew a = new TaxSetupNew();
            a.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
