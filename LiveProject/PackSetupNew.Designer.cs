namespace LiveProject
{
    partial class PackSetupNew
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
            this.pname = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.remark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.psize = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.textBox1.Size = new System.Drawing.Size(453, 29);
            this.textBox1.TabIndex = 93;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "  PACK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "PACK NAME :";
            // 
            // pname
            // 
            this.pname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.Location = new System.Drawing.Point(135, 42);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(282, 20);
            this.pname.TabIndex = 0;
            this.pname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackSetupNew_KeyDown);
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.status.Location = new System.Drawing.Point(135, 94);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(282, 26);
            this.status.TabIndex = 2;
            this.status.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackSetupNew_KeyDown);
            // 
            // remark
            // 
            this.remark.BackColor = System.Drawing.SystemColors.ControlLight;
            this.remark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remark.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remark.Location = new System.Drawing.Point(135, 127);
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(282, 20);
            this.remark.TabIndex = 3;
            this.remark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackSetupNew_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 68;
            this.label9.Text = "STATUS :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 69;
            this.label10.Text = "REMARK :";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Snow;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Image = global::LiveProject.Properties.Resources.save34;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(234, 221);
            this.save.Name = "save";
            this.save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save.Size = new System.Drawing.Size(100, 30);
            this.save.TabIndex = 0;
            this.save.Text = "SAVE";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            this.save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackSetupNew_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.psize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pname);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.remark);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Pack";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "PACK SIZE :";
            // 
            // psize
            // 
            this.psize.BackColor = System.Drawing.SystemColors.ControlLight;
            this.psize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.psize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psize.Location = new System.Drawing.Point(135, 68);
            this.psize.Name = "psize";
            this.psize.Size = new System.Drawing.Size(282, 20);
            this.psize.TabIndex = 1;
            this.psize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackSetupNew_KeyDown);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Snow;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Image = global::LiveProject.Properties.Resources.cancel;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(340, 221);
            this.close.Name = "close";
            this.close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.close.Size = new System.Drawing.Size(100, 30);
            this.close.TabIndex = 1;
            this.close.Text = "CANCEL";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackSetupNew_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 15);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 10);
            this.panel2.TabIndex = 96;
            // 
            // PackSetupNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(453, 271);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackSetupNew";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PackSetupNew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PackSetupNew_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackSetupNew_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.TextBox remark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox psize;
    }
}