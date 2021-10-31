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
            this.name = new System.Windows.Forms.TextBox();
            this.usertype = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(495, 29);
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
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "UOM NAME :";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(135, 42);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(282, 20);
            this.name.TabIndex = 0;
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackSetupNew_KeyDown);
            // 
            // usertype
            // 
            this.usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usertype.FormattingEnabled = true;
            this.usertype.Items.AddRange(new object[] {
            "SELECT",
            "CASHIER",
            "STAFF",
            "ACCOUNTANT"});
            this.usertype.Location = new System.Drawing.Point(135, 68);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(282, 26);
            this.usertype.TabIndex = 1;
            this.usertype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackSetupNew_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(135, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(282, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackSetupNew_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 68;
            this.label9.Text = "STATUS :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 102);
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
            this.save.Location = new System.Drawing.Point(277, 224);
            this.save.Name = "save";
            this.save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save.Size = new System.Drawing.Size(100, 30);
            this.save.TabIndex = 2;
            this.save.Text = "SAVE";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.UseVisualStyleBackColor = false;
            this.save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackSetupNew_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.usertype);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Pack";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Snow;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Image = global::LiveProject.Properties.Resources.cancel;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(383, 224);
            this.close.Name = "close";
            this.close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.close.Size = new System.Drawing.Size(100, 30);
            this.close.TabIndex = 3;
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
            this.panel1.Size = new System.Drawing.Size(495, 15);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 10);
            this.panel2.TabIndex = 96;
            // 
            // PackSetupNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(495, 274);
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
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox usertype;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}