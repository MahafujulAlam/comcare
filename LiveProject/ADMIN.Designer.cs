namespace LiveProject
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.retypepass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 26);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(12, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 57;
            this.label1.Text = "ADMIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.retypepass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.newpass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.currpass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // retypepass
            // 
            this.retypepass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.retypepass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.retypepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypepass.Location = new System.Drawing.Point(207, 95);
            this.retypepass.MaxLength = 15;
            this.retypepass.Name = "retypepass";
            this.retypepass.PasswordChar = '*';
            this.retypepass.Size = new System.Drawing.Size(235, 20);
            this.retypepass.TabIndex = 63;
            this.retypepass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "RETYPE PASSWORD :";
            // 
            // newpass
            // 
            this.newpass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(207, 69);
            this.newpass.MaxLength = 15;
            this.newpass.Name = "newpass";
            this.newpass.PasswordChar = '*';
            this.newpass.Size = new System.Drawing.Size(235, 20);
            this.newpass.TabIndex = 61;
            this.newpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "NEW PASSWORD :";
            // 
            // currpass
            // 
            this.currpass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.currpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currpass.Location = new System.Drawing.Point(207, 43);
            this.currpass.MaxLength = 15;
            this.currpass.Name = "currpass";
            this.currpass.PasswordChar = '*';
            this.currpass.Size = new System.Drawing.Size(235, 20);
            this.currpass.TabIndex = 59;
            this.currpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "CURRENT PASSWORD :";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Snow;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Image = global::LiveProject.Properties.Resources.save34;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(265, 214);
            this.save.Name = "save";
            this.save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save.Size = new System.Drawing.Size(100, 30);
            this.save.TabIndex = 96;
            this.save.Text = "SAVE";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.UseVisualStyleBackColor = false;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Snow;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Image = global::LiveProject.Properties.Resources.close;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(371, 214);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(100, 30);
            this.close.TabIndex = 100;
            this.close.Text = "CLOSE";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(484, 264);
            this.Controls.Add(this.close);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Admin_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox retypepass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
    }
}