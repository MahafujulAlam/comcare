﻿namespace LiveProject
{
    partial class ColorSetup
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.clearCF = new System.Windows.Forms.Button();
            this.deleteCF = new System.Windows.Forms.Button();
            this.addCF = new System.Windows.Forms.Button();
            this.updateCF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 219);
            this.dataGridView1.TabIndex = 93;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchbtn);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 60);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search / Edit";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Snow;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.Image = global::LiveProject.Properties.Resources.search1;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(232, 20);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(100, 30);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "SEARCH";
            this.searchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(6, 23);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(220, 24);
            this.search.TabIndex = 0;
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
            this.textBox1.Size = new System.Drawing.Size(690, 29);
            this.textBox1.TabIndex = 91;
            this.textBox1.Text = "  COLOR DETAILS";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(690, 15);
            this.panel4.TabIndex = 85;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Snow;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Image = global::LiveProject.Properties.Resources.close;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(583, 346);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(100, 30);
            this.close.TabIndex = 90;
            this.close.Text = "CLOSE";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // clearCF
            // 
            this.clearCF.BackColor = System.Drawing.Color.Snow;
            this.clearCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCF.Image = global::LiveProject.Properties.Resources.update;
            this.clearCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearCF.Location = new System.Drawing.Point(371, 346);
            this.clearCF.Name = "clearCF";
            this.clearCF.Size = new System.Drawing.Size(100, 30);
            this.clearCF.TabIndex = 88;
            this.clearCF.Text = "CLEAR";
            this.clearCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearCF.UseVisualStyleBackColor = false;
            // 
            // deleteCF
            // 
            this.deleteCF.BackColor = System.Drawing.Color.Snow;
            this.deleteCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCF.Image = global::LiveProject.Properties.Resources.delete;
            this.deleteCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteCF.Location = new System.Drawing.Point(477, 346);
            this.deleteCF.Name = "deleteCF";
            this.deleteCF.Size = new System.Drawing.Size(100, 30);
            this.deleteCF.TabIndex = 89;
            this.deleteCF.Text = "DELETE";
            this.deleteCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteCF.UseVisualStyleBackColor = false;
            // 
            // addCF
            // 
            this.addCF.BackColor = System.Drawing.Color.Snow;
            this.addCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCF.Image = global::LiveProject.Properties.Resources.add11;
            this.addCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCF.Location = new System.Drawing.Point(159, 346);
            this.addCF.Name = "addCF";
            this.addCF.Size = new System.Drawing.Size(100, 30);
            this.addCF.TabIndex = 86;
            this.addCF.Text = "ADD";
            this.addCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addCF.UseVisualStyleBackColor = false;
            this.addCF.Click += new System.EventHandler(this.addCF_Click);
            // 
            // updateCF
            // 
            this.updateCF.BackColor = System.Drawing.Color.Snow;
            this.updateCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCF.Image = global::LiveProject.Properties.Resources.updatet112;
            this.updateCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateCF.Location = new System.Drawing.Point(265, 346);
            this.updateCF.Name = "updateCF";
            this.updateCF.Size = new System.Drawing.Size(100, 30);
            this.updateCF.TabIndex = 87;
            this.updateCF.Text = "UPDATE";
            this.updateCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateCF.UseVisualStyleBackColor = false;
            // 
            // ColorSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.clearCF);
            this.Controls.Add(this.deleteCF);
            this.Controls.Add(this.addCF);
            this.Controls.Add(this.updateCF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorSetup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorSetup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button clearCF;
        private System.Windows.Forms.Button deleteCF;
        private System.Windows.Forms.Button addCF;
        private System.Windows.Forms.Button updateCF;
    }
}