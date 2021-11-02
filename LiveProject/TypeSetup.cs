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
    public partial class TypeSetup : Form
    {
        public TypeSetup()
        {
            InitializeComponent();
        }

        private void addCF_Click(object sender, EventArgs e)
        {
            TypeSetupNew a = new TypeSetupNew();
            a.ShowDialog();
        }

        private void TypeSetup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
