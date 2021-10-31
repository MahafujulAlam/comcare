namespace LiveProject
{
    partial class EmployeeSalarySetupNew
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
            this.save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.branchname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ifsccode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.acno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bankname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fixedsal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.empid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.paymode = new System.Windows.Forms.ComboBox();
            this.remark = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Snow;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Image = global::LiveProject.Properties.Resources.save34;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(357, 437);
            this.save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save.Name = "save";
            this.save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save.Size = new System.Drawing.Size(133, 37);
            this.save.TabIndex = 0;
            this.save.Text = "SAVE";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            this.save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(652, 34);
            this.textBox1.TabIndex = 93;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "  EMPLOYEE SALARY";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.branchname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ifsccode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.acno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bankname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fixedsal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.empid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Controls.Add(this.paymode);
            this.groupBox1.Controls.Add(this.remark);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(616, 362);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Employee Salary Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 80;
            this.label5.Text = "IFSC CODE :";
            // 
            // branchname
            // 
            this.branchname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.branchname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.branchname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchname.Location = new System.Drawing.Point(201, 245);
            this.branchname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.branchname.Name = "branchname";
            this.branchname.Size = new System.Drawing.Size(376, 27);
            this.branchname.TabIndex = 6;
            this.branchname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 24);
            this.label8.TabIndex = 82;
            this.label8.Text = "BRANCH NAME :";
            // 
            // ifsccode
            // 
            this.ifsccode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ifsccode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ifsccode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifsccode.Location = new System.Drawing.Point(201, 279);
            this.ifsccode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ifsccode.Name = "ifsccode";
            this.ifsccode.Size = new System.Drawing.Size(376, 27);
            this.ifsccode.TabIndex = 7;
            this.ifsccode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "ACCOUNT NO :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // acno
            // 
            this.acno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.acno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acno.Location = new System.Drawing.Point(201, 176);
            this.acno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acno.Name = "acno";
            this.acno.Size = new System.Drawing.Size(376, 27);
            this.acno.TabIndex = 4;
            this.acno.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.acno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 78;
            this.label4.Text = "BANK NAME :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bankname
            // 
            this.bankname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bankname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bankname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankname.Location = new System.Drawing.Point(201, 210);
            this.bankname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bankname.Name = "bankname";
            this.bankname.Size = new System.Drawing.Size(376, 27);
            this.bankname.TabIndex = 5;
            this.bankname.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.bankname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "FIXED SALARY :";
            // 
            // fixedsal
            // 
            this.fixedsal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fixedsal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fixedsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixedsal.Location = new System.Drawing.Point(201, 105);
            this.fixedsal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fixedsal.Name = "fixedsal";
            this.fixedsal.Size = new System.Drawing.Size(376, 27);
            this.fixedsal.TabIndex = 2;
            this.fixedsal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 74;
            this.label2.Text = "PAYING MODE :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 62;
            this.label7.Text = "EMPLOYEE ID :";
            // 
            // empid
            // 
            this.empid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.empid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid.Location = new System.Drawing.Point(201, 36);
            this.empid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(376, 27);
            this.empid.TabIndex = 0;
            this.empid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 64;
            this.label6.Text = "NAME :";
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(201, 70);
            this.contact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(376, 27);
            this.contact.TabIndex = 1;
            this.contact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            // 
            // paymode
            // 
            this.paymode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.paymode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paymode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymode.FormattingEnabled = true;
            this.paymode.Items.AddRange(new object[] {
            "SELECT",
            "GPAY",
            "NEFRTS"});
            this.paymode.Location = new System.Drawing.Point(201, 139);
            this.paymode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paymode.Name = "paymode";
            this.paymode.Size = new System.Drawing.Size(375, 28);
            this.paymode.TabIndex = 3;
            this.paymode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            // 
            // remark
            // 
            this.remark.BackColor = System.Drawing.SystemColors.ControlLight;
            this.remark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remark.Location = new System.Drawing.Point(201, 314);
            this.remark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remark.Name = "remark";
            this.remark.PasswordChar = '*';
            this.remark.Size = new System.Drawing.Size(376, 27);
            this.remark.TabIndex = 8;
            this.remark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 318);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 24);
            this.label10.TabIndex = 69;
            this.label10.Text = "REMARK :";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Snow;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Image = global::LiveProject.Properties.Resources.cancel;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(499, 437);
            this.close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close.Name = "close";
            this.close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.close.Size = new System.Drawing.Size(133, 37);
            this.close.TabIndex = 1;
            this.close.Text = "CANCEL";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 18);
            this.panel1.TabIndex = 91;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 482);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 12);
            this.panel2.TabIndex = 96;
            // 
            // EmployeeSalarySetupNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(652, 494);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeSalarySetupNew";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeSalaryNew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeSalarySetupNew_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeSalarySetupNew_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeSalarySetupNew_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.ComboBox paymode;
        private System.Windows.Forms.TextBox remark;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox acno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bankname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fixedsal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox branchname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ifsccode;
        private System.Windows.Forms.Panel panel2;
    }
}