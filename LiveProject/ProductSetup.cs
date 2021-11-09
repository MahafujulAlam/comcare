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
    public partial class ProductSetup : Form
    {
        public ProductSetup()
        {
            InitializeComponent();
        }

        private void ProductSetup_Load(object sender, EventArgs e)
        {

        }

        private void addCF_Click(object sender, EventArgs e)
        {
            ProductSetupNew a = new ProductSetupNew();
            a.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductSetup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
