using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiveProject
{
    public partial class Home : Form
    {
        private  Login log1;
        public Home(Login log)
        {
            this.log1 = log;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            log1.Visible = false;
        }

        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoard dlg = new DashBoard();
            dlg.ShowDialog();
        }

        private void sALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleA dlg = new SaleA();
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

        private void tYPESETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeSetup dlg = new TypeSetup();
            dlg.ShowDialog();
        }

        private void pACKSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackSetup dlg = new PackSetup();
            dlg.ShowDialog();
        }

        private void cOLORSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorSetup dlg = new ColorSetup();
            dlg.ShowDialog();
        }

        private void gROUPSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupSetup dlg = new GroupSetup();
            dlg.ShowDialog();
        }

        private void cOMPOSITIONSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionSetup dlg = new CompositionSetup();
            dlg.ShowDialog();
        }

        private void pRODUCTSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductSetup dlg = new ProductSetup();
            dlg.ShowDialog();
        }

        private void dETAILSSETUPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeDetails dlg = new EmployeeDetails();
            dlg.ShowDialog();
        }

        private void sALARYSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalarySetup dlg = new EmployeeSalarySetup();
            dlg.ShowDialog();
        }

        private void pURCHASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase dlg = new Purchase();
            dlg.ShowDialog();
        }

        private void nEWORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderN dlg = new OrderN();
            dlg.ShowDialog();
        }

        private void pREVIOUSORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderP dlg = new OrderP();
            dlg.ShowDialog();
        }

        private void nEAREXPIRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NearExpiry dlg = new NearExpiry();
            dlg.ShowDialog();
        }

        private void cUSTOMERPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPayment dlg = new CustomerPayment();
            dlg.ShowDialog();
        }

        private void sELLERPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerPayment dlg = new SellerPayment();
            dlg.ShowDialog();
        }

        private void eXPENSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses dlg = new Expenses();
            dlg.ShowDialog();
        }

        private void dUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalaryDue dlg = new EmployeeSalaryDue();
            dlg.ShowDialog();
        }

        private void pAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalaryPay dlg = new EmployeeSalaryPay();
            dlg.ShowDialog();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Admin")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                Admin dlg = new Admin();
                dlg.Show();
            }
        }

        private void uSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User dlg = new User();
            dlg.ShowDialog();
        }

        private void iNDEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Index dlg = new Index();
            dlg.ShowDialog();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to cancel ?", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                //Application.Exit();
                e.Cancel = true;
                //foreach (Form f in Application.OpenForms)
                //{
                //    f.Close();
                //}
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Purchase dlg = new Purchase();
            dlg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaleA dlg = new SaleA();
            dlg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockFresh dlg = new StockFresh();
            dlg.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderN dlg = new OrderN();
            dlg.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderP dlg = new OrderP();
            dlg.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin dlg = new Admin();
            dlg.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            User dlg = new User();
            dlg.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            CustomerPayment dlg = new CustomerPayment();
            dlg.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            SellerPayment dlg = new SellerPayment();
            dlg.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NearExpiry dlg = new NearExpiry();
            dlg.ShowDialog();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            SaleA sc = new SaleA();
            sc.ShowDialog();
        }

        private void aCCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyProfile dlg = new CompanyProfile();
            dlg.ShowDialog();
        }

        private void bANKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankSetup dlg = new BankSetup();
            dlg.ShowDialog();
        }

        private void dETAILSSETUPToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PartyDetails dlg = new PartyDetails();
            dlg.ShowDialog();
        }

        private void pAYMENTSETUPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PartyPaymentSetup dlg = new PartyPaymentSetup();
            dlg.ShowDialog();
        }

        private void fRESHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockFresh dlg = new StockFresh();
            dlg.ShowDialog();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineCompanySetup dlg = new MedicineCompanySetup();
            dlg.ShowDialog();
        }

        private void dAMAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDamage dlg = new StockDamage();
            dlg.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homepageimg_Click(object sender, EventArgs e)
        {

        }

        private void uNITSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitSetup dlg = new UnitSetup();
            dlg.ShowDialog();
        }

        private void cASHSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashSetup dlg = new CashSetup();
            dlg.ShowDialog();
        }

        private void fINANCIALYEARSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialYearSetup dlg = new FinancialYearSetup();
            dlg.ShowDialog();
        }

        private void tRANSFERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer dlg = new Transfer();
            dlg.ShowDialog();
        }

        private void bILLSETTINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillSetting dlg = new BillSetting();
            dlg.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SaleB a = new SaleB();
            a.ShowDialog();
        }

        private void sALERETURNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnSale alg = new ReturnSale();
            alg.ShowDialog();
        }

        private void pURCHASEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReturnPurchase alg = new ReturnPurchase();
            alg.ShowDialog();
        }

        private void rEPORTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report alg = new Report();
            alg.ShowDialog();
        }
    }
}
