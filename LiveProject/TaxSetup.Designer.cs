namespace LiveProject
{
    partial class TaxSetup
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
            this.statustaxsetup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nametaxsetup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ratetaxsetup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.remarktaxsetup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.submitTS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statustaxsetup
            // 
            this.statustaxsetup.Location = new System.Drawing.Point(251, 189);
            this.statustaxsetup.Name = "statustaxsetup";
            this.statustaxsetup.Size = new System.Drawing.Size(251, 20);
            this.statustaxsetup.TabIndex = 20;
            this.statustaxsetup.TextChanged += new System.EventHandler(this.statustaxsetup_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "STATUS :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nametaxsetup
            // 
            this.nametaxsetup.Location = new System.Drawing.Point(251, 119);
            this.nametaxsetup.Name = "nametaxsetup";
            this.nametaxsetup.Size = new System.Drawing.Size(251, 20);
            this.nametaxsetup.TabIndex = 18;
            this.nametaxsetup.TextChanged += new System.EventHandler(this.nametaxsetup_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "NAME :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orchid;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(268, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "TAX SETUP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ratetaxsetup
            // 
            this.ratetaxsetup.Location = new System.Drawing.Point(251, 154);
            this.ratetaxsetup.Name = "ratetaxsetup";
            this.ratetaxsetup.Size = new System.Drawing.Size(251, 20);
            this.ratetaxsetup.TabIndex = 22;
            this.ratetaxsetup.TextChanged += new System.EventHandler(this.ratetaxsetup_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "RATE :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // remarktaxsetup
            // 
            this.remarktaxsetup.Location = new System.Drawing.Point(251, 220);
            this.remarktaxsetup.Name = "remarktaxsetup";
            this.remarktaxsetup.Size = new System.Drawing.Size(251, 20);
            this.remarktaxsetup.TabIndex = 24;
            this.remarktaxsetup.TextChanged += new System.EventHandler(this.remarktaxsetup_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "REMARK :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // submitTS
            // 
            this.submitTS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.submitTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTS.Location = new System.Drawing.Point(300, 272);
            this.submitTS.Name = "submitTS";
            this.submitTS.Size = new System.Drawing.Size(88, 35);
            this.submitTS.TabIndex = 48;
            this.submitTS.Text = "SUBMIT";
            this.submitTS.UseVisualStyleBackColor = false;
            // 
            // TaxSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 366);
            this.Controls.Add(this.submitTS);
            this.Controls.Add(this.remarktaxsetup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ratetaxsetup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statustaxsetup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nametaxsetup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaxSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaxSetup";
            this.Load += new System.EventHandler(this.TaxSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statustaxsetup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametaxsetup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ratetaxsetup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox remarktaxsetup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitTS;
    }
}