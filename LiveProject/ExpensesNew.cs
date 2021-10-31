﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiveProject
{
    public partial class ExpensesNew : Form
    {
        public ExpensesNew()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
           
                this.Close();
          
        }

        private void ExpensesNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExpensesNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
