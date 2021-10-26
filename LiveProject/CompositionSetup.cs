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
    public partial class CompositionSetup : Form
    {
        public CompositionSetup()
        {
            InitializeComponent();
        }

        private void addCF_Click(object sender, EventArgs e)
        {
            CompositionSetupNew a = new CompositionSetupNew();
            a.ShowDialog();
        }
    }
}
