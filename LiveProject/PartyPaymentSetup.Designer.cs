namespace LiveProject
{
    partial class PartyPaymentSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            this.clearCF = new System.Windows.Forms.Button();
            this.deleteCF = new System.Windows.Forms.Button();
            this.addCF = new System.Windows.Forms.Button();
            this.updateCF = new System.Windows.Forms.Button();
            this.partyid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ifsccode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.micrcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 60);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search / Edit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::LiveProject.Properties.Resources.search1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(555, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "SEARCH";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyPaymentSetup_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(543, 24);
            this.textBox2.TabIndex = 0;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyPaymentSetup_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1200, 29);
            this.textBox1.TabIndex = 100;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "  PARTY PAYMENT DETAILS";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1200, 15);
            this.panel4.TabIndex = 94;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partyid,
            this.partyname,
            this.paymentmode,
            this.paymentby,
            this.accno,
            this.bankname,
            this.branchname,
            this.ifsccode,
            this.micrcode,
            this.status,
            this.remark});
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1176, 366);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyPaymentSetup_KeyDown);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Snow;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Image = global::LiveProject.Properties.Resources.close;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(1088, 488);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(100, 30);
            this.close.TabIndex = 4;
            this.close.Text = "CLOSE";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyPaymentSetup_KeyDown);
            // 
            // clearCF
            // 
            this.clearCF.BackColor = System.Drawing.Color.Snow;
            this.clearCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCF.Image = global::LiveProject.Properties.Resources.update;
            this.clearCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearCF.Location = new System.Drawing.Point(876, 488);
            this.clearCF.Name = "clearCF";
            this.clearCF.Size = new System.Drawing.Size(100, 30);
            this.clearCF.TabIndex = 2;
            this.clearCF.Text = "CLEAR";
            this.clearCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearCF.UseVisualStyleBackColor = false;
            this.clearCF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyPaymentSetup_KeyDown);
            // 
            // deleteCF
            // 
            this.deleteCF.BackColor = System.Drawing.Color.Snow;
            this.deleteCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCF.Image = global::LiveProject.Properties.Resources.delete;
            this.deleteCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteCF.Location = new System.Drawing.Point(982, 488);
            this.deleteCF.Name = "deleteCF";
            this.deleteCF.Size = new System.Drawing.Size(100, 30);
            this.deleteCF.TabIndex = 3;
            this.deleteCF.Text = "DELETE";
            this.deleteCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteCF.UseVisualStyleBackColor = false;
            this.deleteCF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyPaymentSetup_KeyDown);
            // 
            // addCF
            // 
            this.addCF.BackColor = System.Drawing.Color.Snow;
            this.addCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCF.Image = global::LiveProject.Properties.Resources.add11;
            this.addCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCF.Location = new System.Drawing.Point(666, 488);
            this.addCF.Name = "addCF";
            this.addCF.Size = new System.Drawing.Size(100, 30);
            this.addCF.TabIndex = 0;
            this.addCF.Text = "ADD";
            this.addCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addCF.UseVisualStyleBackColor = false;
            this.addCF.Click += new System.EventHandler(this.addCF_Click);
            this.addCF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyPaymentSetup_KeyDown);
            // 
            // updateCF
            // 
            this.updateCF.BackColor = System.Drawing.Color.Snow;
            this.updateCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCF.Image = global::LiveProject.Properties.Resources.updatet112;
            this.updateCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateCF.Location = new System.Drawing.Point(770, 488);
            this.updateCF.Name = "updateCF";
            this.updateCF.Size = new System.Drawing.Size(100, 30);
            this.updateCF.TabIndex = 1;
            this.updateCF.Text = "UPDATE";
            this.updateCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateCF.UseVisualStyleBackColor = false;
            this.updateCF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyPaymentSetup_KeyDown);
            // 
            // partyid
            // 
            this.partyid.HeaderText = "PartyId";
            this.partyid.Name = "partyid";
            this.partyid.ReadOnly = true;
            // 
            // partyname
            // 
            this.partyname.HeaderText = "PartyName";
            this.partyname.Name = "partyname";
            this.partyname.ReadOnly = true;
            // 
            // paymentmode
            // 
            this.paymentmode.HeaderText = "Payment Mode";
            this.paymentmode.Name = "paymentmode";
            this.paymentmode.ReadOnly = true;
            // 
            // paymentby
            // 
            this.paymentby.HeaderText = "Payment By";
            this.paymentby.Name = "paymentby";
            this.paymentby.ReadOnly = true;
            // 
            // accno
            // 
            this.accno.HeaderText = "Account No";
            this.accno.Name = "accno";
            this.accno.ReadOnly = true;
            // 
            // bankname
            // 
            this.bankname.HeaderText = "Bank Name";
            this.bankname.Name = "bankname";
            this.bankname.ReadOnly = true;
            // 
            // branchname
            // 
            this.branchname.HeaderText = "Branch Name";
            this.branchname.Name = "branchname";
            this.branchname.ReadOnly = true;
            // 
            // ifsccode
            // 
            this.ifsccode.HeaderText = "IFSC Code";
            this.ifsccode.Name = "ifsccode";
            this.ifsccode.ReadOnly = true;
            // 
            // micrcode
            // 
            this.micrcode.HeaderText = "MICR Code";
            this.micrcode.Name = "micrcode";
            this.micrcode.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.HeaderText = "Remark";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 131;
            // 
            // PartyPaymentSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.clearCF);
            this.Controls.Add(this.deleteCF);
            this.Controls.Add(this.addCF);
            this.Controls.Add(this.updateCF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PartyPaymentSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartySetup";
            this.Load += new System.EventHandler(this.PartyPaymentSetup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyPaymentSetup_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button clearCF;
        private System.Windows.Forms.Button deleteCF;
        private System.Windows.Forms.Button addCF;
        private System.Windows.Forms.Button updateCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmode;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentby;
        private System.Windows.Forms.DataGridViewTextBoxColumn accno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankname;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ifsccode;
        private System.Windows.Forms.DataGridViewTextBoxColumn micrcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}