namespace LiveProject
{
    partial class BankSetupNew
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.acno = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.remark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.actype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.avlbal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.openingbal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.micrcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ifsccode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bankname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.textBox1.Size = new System.Drawing.Size(509, 29);
            this.textBox1.TabIndex = 93;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "  BANK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "ACCOUNT NAME :";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(183, 39);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(282, 20);
            this.name.TabIndex = 0;
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "ACCOUNT NO :";
            // 
            // acno
            // 
            this.acno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.acno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acno.Location = new System.Drawing.Point(183, 65);
            this.acno.Name = "acno";
            this.acno.Size = new System.Drawing.Size(282, 20);
            this.acno.TabIndex = 1;
            this.acno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.status.Location = new System.Drawing.Point(183, 277);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(282, 26);
            this.status.TabIndex = 9;
            this.status.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // remark
            // 
            this.remark.BackColor = System.Drawing.SystemColors.ControlLight;
            this.remark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remark.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remark.Location = new System.Drawing.Point(183, 309);
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(282, 20);
            this.remark.TabIndex = 10;
            this.remark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 68;
            this.label9.Text = "STATUS :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 69;
            this.label10.Text = "REMARK :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.actype);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.avlbal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.openingbal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.micrcode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ifsccode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.branch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bankname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.acno);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.remark);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 350);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Bank";
            // 
            // actype
            // 
            this.actype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actype.FormattingEnabled = true;
            this.actype.Items.AddRange(new object[] {
            "SAVING",
            "CURRENT",
            "CC"});
            this.actype.Location = new System.Drawing.Point(183, 91);
            this.actype.Name = "actype";
            this.actype.Size = new System.Drawing.Size(282, 24);
            this.actype.TabIndex = 2;
            this.actype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 18);
            this.label8.TabIndex = 84;
            this.label8.Text = "AVAILABLE BALANCE :";
            // 
            // avlbal
            // 
            this.avlbal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.avlbal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avlbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avlbal.Location = new System.Drawing.Point(183, 251);
            this.avlbal.Name = "avlbal";
            this.avlbal.Size = new System.Drawing.Size(282, 20);
            this.avlbal.TabIndex = 8;
            this.avlbal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 18);
            this.label11.TabIndex = 83;
            this.label11.Text = "OPENING BALANCE :";
            // 
            // openingbal
            // 
            this.openingbal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openingbal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.openingbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openingbal.Location = new System.Drawing.Point(183, 225);
            this.openingbal.Name = "openingbal";
            this.openingbal.Size = new System.Drawing.Size(282, 20);
            this.openingbal.TabIndex = 7;
            this.openingbal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 80;
            this.label5.Text = "MICR CODE :";
            // 
            // micrcode
            // 
            this.micrcode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.micrcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.micrcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.micrcode.Location = new System.Drawing.Point(183, 199);
            this.micrcode.Name = "micrcode";
            this.micrcode.Size = new System.Drawing.Size(282, 20);
            this.micrcode.TabIndex = 6;
            this.micrcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 78;
            this.label4.Text = "IFSC CODE :";
            // 
            // ifsccode
            // 
            this.ifsccode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ifsccode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ifsccode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifsccode.Location = new System.Drawing.Point(183, 173);
            this.ifsccode.Name = "ifsccode";
            this.ifsccode.Size = new System.Drawing.Size(282, 20);
            this.ifsccode.TabIndex = 5;
            this.ifsccode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 76;
            this.label3.Text = "BRANCH :";
            // 
            // branch
            // 
            this.branch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.branch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch.Location = new System.Drawing.Point(183, 147);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(282, 20);
            this.branch.TabIndex = 4;
            this.branch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 74;
            this.label2.Text = "BANK NAME :";
            // 
            // bankname
            // 
            this.bankname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bankname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bankname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankname.Location = new System.Drawing.Point(183, 121);
            this.bankname.Name = "bankname";
            this.bankname.Size = new System.Drawing.Size(282, 20);
            this.bankname.TabIndex = 3;
            this.bankname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "ACCOUNT TYPE :";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 15);
            this.panel1.TabIndex = 0;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Snow;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Image = global::LiveProject.Properties.Resources.save34;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(289, 411);
            this.save.Name = "save";
            this.save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save.Size = new System.Drawing.Size(100, 30);
            this.save.TabIndex = 0;
            this.save.Text = "SAVE";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            this.save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Snow;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Image = global::LiveProject.Properties.Resources.cancel;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(395, 411);
            this.close.Name = "close";
            this.close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.close.Size = new System.Drawing.Size(100, 30);
            this.close.TabIndex = 1;
            this.close.Text = "CANCEL";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 10);
            this.panel2.TabIndex = 96;
            // 
            // BankSetupNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(509, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankSetupNew";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankSetupNew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankSetupNew_FormClosing);
            this.Load += new System.EventHandler(this.BankSetupNew_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSetupNew_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox acno;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.TextBox remark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ifsccode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox branch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bankname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox micrcode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox avlbal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox openingbal;
        private System.Windows.Forms.ComboBox actype;
    }
}