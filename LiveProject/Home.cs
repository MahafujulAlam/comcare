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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pACKSETUPToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tYPESETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyProfile dlg = new CompanyProfile();
            dlg.ShowDialog();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADMIN dlg = new ADMIN();
            dlg.ShowDialog();
        }

        private void uSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User dlg = new User();
            dlg.ShowDialog();
        }

        private void cURRENCYSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencySetup dlg = new CurrencySetup();
            dlg.ShowDialog();
        }

        private void tAXSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaxSetup dlg = new TaxSetup();
            dlg.ShowDialog();
        }

        private void eXPENSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses dlg = new Expenses();
            dlg.ShowDialog();
        }

        private void homepictureBox_Click(object sender, EventArgs e)
        {

        }

        private void cUSTOMERPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPayment DLG = new CustomerPayment();
            DLG.ShowDialog();
        }

        private void pARTYPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartyPayment dlg = new PartyPayment();
            dlg.ShowDialog();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eMPLOYEESALARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalary dlg = new EmployeeSalary();
            dlg.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void sALARYSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User dlg = new User();
            dlg.ShowDialog();
        }

        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DashBoard a = new DashBoard();
            //a.Show();
        }

        private void homeimage_Click(object sender, EventArgs e)
        {

        }

        private void cOLORSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorSetup dlg = new ColorSetup();
            dlg.ShowDialog();
        }
    }
}
