namespace LiveProject
{
    partial class PackSetup
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
            this.submitpacksetup = new System.Windows.Forms.Button();
            this.remarkpacksetup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.namepacksetup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitpacksetup
            // 
            this.submitpacksetup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.submitpacksetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitpacksetup.Location = new System.Drawing.Point(298, 184);
            this.submitpacksetup.Name = "submitpacksetup";
            this.submitpacksetup.Size = new System.Drawing.Size(88, 35);
            this.submitpacksetup.TabIndex = 58;
            this.submitpacksetup.Text = "SUBMIT";
            this.submitpacksetup.UseVisualStyleBackColor = false;
            this.submitpacksetup.Click += new System.EventHandler(this.submitTS_Click);
            // 
            // remarkpacksetup
            // 
            this.remarkpacksetup.Location = new System.Drawing.Point(254, 136);
            this.remarkpacksetup.Name = "remarkpacksetup";
            this.remarkpacksetup.Size = new System.Drawing.Size(251, 20);
            this.remarkpacksetup.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "REMARK :";
            // 
            // namepacksetup
            // 
            this.namepacksetup.Location = new System.Drawing.Point(254, 98);
            this.namepacksetup.Name = "namepacksetup";
            this.namepacksetup.Size = new System.Drawing.Size(251, 20);
            this.namepacksetup.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "UOM NAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orchid;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(271, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "PACK SETUP";
            // 
            // PackSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitpacksetup);
            this.Controls.Add(this.remarkpacksetup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.namepacksetup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PackSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PackSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitpacksetup;
        private System.Windows.Forms.TextBox remarkpacksetup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox namepacksetup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}