namespace LiveProject
{
    partial class FinancialYearSetup
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
            this.addCF = new System.Windows.Forms.Button();
            this.updateCF = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 62);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search / Edit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::LiveProject.Properties.Resources.search1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(468, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "SEARCH";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 24);
            this.textBox2.TabIndex = 0;
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
            this.textBox1.Size = new System.Drawing.Size(608, 29);
            this.textBox1.TabIndex = 109;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "  FINANCIAL DETAILS";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 15);
            this.panel4.TabIndex = 108;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 274);
            this.dataGridView1.TabIndex = 107;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Snow;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Image = global::LiveProject.Properties.Resources.close;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(496, 401);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(100, 32);
            this.close.TabIndex = 106;
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
            this.clearCF.Location = new System.Drawing.Point(390, 401);
            this.clearCF.Name = "clearCF";
            this.clearCF.Size = new System.Drawing.Size(100, 32);
            this.clearCF.TabIndex = 104;
            this.clearCF.Text = "CLEAR";
            this.clearCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearCF.UseVisualStyleBackColor = false;
            // 
            // addCF
            // 
            this.addCF.BackColor = System.Drawing.Color.Snow;
            this.addCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCF.Image = global::LiveProject.Properties.Resources.add11;
            this.addCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCF.Location = new System.Drawing.Point(180, 401);
            this.addCF.Name = "addCF";
            this.addCF.Size = new System.Drawing.Size(100, 32);
            this.addCF.TabIndex = 102;
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
            this.updateCF.Image = global::LiveProject.Properties.Resources.change;
            this.updateCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateCF.Location = new System.Drawing.Point(284, 401);
            this.updateCF.Name = "updateCF";
            this.updateCF.Size = new System.Drawing.Size(100, 32);
            this.updateCF.TabIndex = 103;
            this.updateCF.Text = "SWAP";
            this.updateCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateCF.UseVisualStyleBackColor = false;
            // 
            // FinancialYearSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.clearCF);
            this.Controls.Add(this.addCF);
            this.Controls.Add(this.updateCF);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinancialYearSetup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinancialYearSetup";
            this.Load += new System.EventHandler(this.FinancialYearSetup_Load);
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
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button clearCF;
        private System.Windows.Forms.Button addCF;
        private System.Windows.Forms.Button updateCF;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}