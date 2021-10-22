namespace LiveProject
{
    partial class CurrencySetup
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusCS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameCS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitCSetup = new System.Windows.Forms.Button();
            this.remarkCS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orchid;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(197, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CURRENCY SETUP";
            // 
            // statusCS
            // 
            this.statusCS.Location = new System.Drawing.Point(218, 137);
            this.statusCS.Name = "statusCS";
            this.statusCS.Size = new System.Drawing.Size(251, 20);
            this.statusCS.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "STATUS :";
            // 
            // nameCS
            // 
            this.nameCS.Location = new System.Drawing.Point(218, 103);
            this.nameCS.Name = "nameCS";
            this.nameCS.Size = new System.Drawing.Size(251, 20);
            this.nameCS.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "NAME :";
            // 
            // submitCSetup
            // 
            this.submitCSetup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.submitCSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitCSetup.Location = new System.Drawing.Point(273, 222);
            this.submitCSetup.Name = "submitCSetup";
            this.submitCSetup.Size = new System.Drawing.Size(88, 35);
            this.submitCSetup.TabIndex = 48;
            this.submitCSetup.Text = "SUBMIT";
            this.submitCSetup.UseVisualStyleBackColor = false;
            // 
            // remarkCS
            // 
            this.remarkCS.Location = new System.Drawing.Point(218, 171);
            this.remarkCS.Name = "remarkCS";
            this.remarkCS.Size = new System.Drawing.Size(251, 20);
            this.remarkCS.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "REMARK :";
            // 
            // CurrencySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 363);
            this.Controls.Add(this.remarkCS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitCSetup);
            this.Controls.Add(this.statusCS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameCS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CurrencySetup";
            this.Text = "CurrencySetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox statusCS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameCS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitCSetup;
        private System.Windows.Forms.TextBox remarkCS;
        private System.Windows.Forms.Label label4;
    }
}