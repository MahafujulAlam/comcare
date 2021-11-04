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
        private Login parent1;
        public Home(Login parent)
        {
            this.parent1 = parent;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            parent1.Visible = false;
        }

        private void pACKSETUPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PackSetup a = new PackSetup();
            a.ShowDialog();
        }

        private void tYPESETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyProfile dlg = new CompanyProfile();
            dlg.ShowDialog();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin dlg = new Admin();
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
            SellerPayment dlg = new SellerPayment();
            dlg.ShowDialog();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void eMPLOYEESALARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }        

        private void sALARYSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalarySetup a = new EmployeeSalarySetup();
            a.ShowDialog();
        }

        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoard a = new DashBoard();
            a.ShowDialog();
        }

        private void homeimage_Click(object sender, EventArgs e)
        {

        }

        private void cOLORSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorSetup dlg = new ColorSetup();
            dlg.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }  
        }

        private void pACKSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankSetup a = new BankSetup();
            a.ShowDialog();
        }

        private void tYPESETUPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TypeSetup a = new TypeSetup();
            a.ShowDialog();
        }

        private void gROUPSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupSetup a = new GroupSetup();
            a.ShowDialog();
        }

        private void cOMPOSITIONSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionSetup a = new CompositionSetup();
            a.ShowDialog();
        }

        private void pRODUCTSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductSetup a = new ProductSetup();
            a.ShowDialog();
        }

        private void dETAILSSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartyDetails a = new PartyDetails();
            a.ShowDialog();
        }

        private void pAYMENTSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartyPaymentSetup a = new PartyPaymentSetup();
            a.ShowDialog();
        }

        private void dETAILSSETUPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeDetailsNew a = new EmployeeDetailsNew();
            a.ShowDialog();
        }

        private void tAXCONDITIONSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermCond a = new TermCond();
            a.ShowDialog();
        }

        private void rACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RackSetup a = new RackSetup();
            a.ShowDialog();
        }

        private void pURCHASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase a = new Purchase();
            a.ShowDialog();
        }

        private void sALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale a = new Sale();
            a.ShowDialog();
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderN a = new OrderN();
            a.ShowDialog();
        }

        private void pREVIOUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderP a = new OrderP();
            a.ShowDialog();
        }

        private void pURCHASERETURNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnPurchase a = new ReturnPurchase();
            a.ShowDialog();
        }

        private void sALERETURNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnSale a = new ReturnSale();
            a.ShowDialog();
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock a = new Stock();
            a.ShowDialog();
        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NearExpiry a = new NearExpiry();
            a.ShowDialog();
        }

        private void rEPORTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report a = new Report();
            a.ShowDialog();
        }

        private void sALARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalaryPay dlg = new EmployeeSalaryPay();
            dlg.ShowDialog();
        }

        private void dUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalaryDue dlg = new EmployeeSalaryDue();
            dlg.ShowDialog();
        }

        private void mASTERSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hOMEDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeDp dlg = new HomeDp();
            dlg.ShowDialog();
        }

        private void iNDEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Index DLG = new Index();
            DLG.ShowDialog();
        }

        private void puchase_Click(object sender, EventArgs e)
        {
            Purchase dlg = new Purchase();
            dlg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sale dlg = new Sale();
            dlg.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stock dlg = new Stock();
            dlg.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderN dlg = new OrderN();
            dlg.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderP dlg = new OrderP();
            dlg.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CustomerPayment dlg = new CustomerPayment();
            dlg.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PartyPaymentSetup dlg = new PartyPaymentSetup();
            dlg.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NearExpiry dlg = new NearExpiry();
            dlg.ShowDialog();
        }
       
    }
}
