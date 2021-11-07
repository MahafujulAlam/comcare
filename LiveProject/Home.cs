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

            //HomeBG dlg = new HomeBG();
            //dlg.MdiParent = this;
            //dlg.Dock = DockStyle.Fill;
            //dlg.Show();
        }

        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "DashBoard")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    DashBoard dlg = new DashBoard();
            //    dlg.MdiParent = this;
            //    dlg.ShowDiolog();
            //}

            DashBoard dlg = new DashBoard();
            dlg.ShowDialog();
        }

        private void sALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleA dlg = new SaleA();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "SaleA")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    SaleA dlg = new SaleA();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}

        }

        private void cOMPANYPROFILESETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyProfile dlg = new CompanyProfile();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "CompanyProfile")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    CompanyProfile dlg = new CompanyProfile();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void bANKSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankSetup dlg = new BankSetup();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "BankSetup")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    BankSetup dlg = new BankSetup();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void cURRENCYSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencySetup dlg = new CurrencySetup();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen = false)
            //{
            //    CurrencySetup dlg = new CurrencySetup();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void tAXSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaxSetup dlg = new TaxSetup();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "TaxSetup")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    TaxSetup dlg = new TaxSetup();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void tYPESETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeSetup dlg = new TypeSetup();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "TypeSetup")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    TypeSetup dlg = new TypeSetup();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void pACKSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackSetup dlg = new PackSetup();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "PackSetup")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    PackSetup dlg = new PackSetup();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void cOLORSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorSetup dlg = new ColorSetup();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "ColorSetup")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    ColorSetup dlg = new ColorSetup();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void gROUPSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupSetup dlg = new GroupSetup();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "GroupSetup")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    GroupSetup dlg = new GroupSetup();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void cOMPOSITIONSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositionSetup dlg = new CompositionSetup();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "CompositionSetup")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    CompositionSetup dlg = new CompositionSetup();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void pRODUCTSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductSetup dlg = new ProductSetup();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "ProductSetup")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    ProductSetup dlg = new ProductSetup();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void dETAILSSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartyDetails dlg = new PartyDetails();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "PartyDetails")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    PartyDetails dlg = new PartyDetails();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void pAYMENTSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartyPaymentSetup dlg = new PartyPaymentSetup();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "PartyPaymentSetup")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    PartyPaymentSetup dlg = new PartyPaymentSetup();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void dETAILSSETUPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeDetails dlg = new EmployeeDetails();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "EmployeeDetails")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    EmployeeDetails dlg = new EmployeeDetails();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void sALARYSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalarySetup dlg = new EmployeeSalarySetup();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "EmployeeSalarySetup")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen = false)
            //{
            //    EmployeeSalarySetup dlg = new EmployeeSalarySetup();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void pURCHASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase dlg = new Purchase();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "Purchase")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen = false)
            //{
            //    Purchase dlg = new Purchase();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void nEWORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderN dlg = new OrderN();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "OrderN")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    OrderN dlg = new OrderN();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void pREVIOUSORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderP dlg = new OrderP();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "OrderP")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    OrderP dlg = new OrderP();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void sTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock dlg = new Stock();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "Stock")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    Stock dlg = new Stock();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void nEAREXPIRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NearExpiry dlg = new NearExpiry();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "NearExpiry")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    NearExpiry dlg = new NearExpiry();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void cUSTOMERPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPayment dlg = new CustomerPayment();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "CustomerPayment")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    CustomerPayment dlg = new CustomerPayment();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void sELLERPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerPayment dlg = new SellerPayment();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "SellerPayment")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    SellerPayment dlg = new SellerPayment();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void eXPENSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses dlg = new Expenses();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "Expenses")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    Expenses dlg = new Expenses();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void dUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalaryDue dlg = new EmployeeSalaryDue();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    EmployeeSalaryDue dlg = new EmployeeSalaryDue();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void pAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalaryPay dlg = new EmployeeSalaryPay();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "EmployeeSalaryPay")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    EmployeeSalaryPay dlg = new EmployeeSalaryPay();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Admin dlg = new Admin();
            //dlg.Show();
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
                //dlg.MdiParent = this;
                dlg.Show();
            }
        }

        private void uSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User dlg = new User();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "User")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    User dlg = new User();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void iNDEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Index dlg = new Index();
            dlg.ShowDialog();
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "Index")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //}
            //if (IsOpen == false)
            //{
            //    Index dlg = new Index();
            //    dlg.MdiParent = this;
            //    dlg.Show();
            //}
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //foreach (Form f in Application.OpenForms)
            //{
            //    this.Close();
            //}
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to cancel ?", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                //Application.Exit();
                e.Cancel = true;
                foreach (Form f in Application.OpenForms)
                {
                    f.Close();
                }
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
            Stock dlg = new Stock();
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
    }
}
