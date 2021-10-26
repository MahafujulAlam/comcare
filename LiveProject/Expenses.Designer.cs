namespace LiveProject
{
    partial class Expenses
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
            this.remarkexpenses = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.amountexpenses = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameexpenses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateexpenses = new System.Windows.Forms.DateTimePicker();
            this.submitexpenses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remarkexpenses
            // 
            this.remarkexpenses.Location = new System.Drawing.Point(281, 242);
            this.remarkexpenses.Name = "remarkexpenses";
            this.remarkexpenses.Size = new System.Drawing.Size(251, 20);
            this.remarkexpenses.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "REMARK :";
            // 
            // amountexpenses
            // 
            this.amountexpenses.Location = new System.Drawing.Point(281, 176);
            this.amountexpenses.Name = "amountexpenses";
            this.amountexpenses.Size = new System.Drawing.Size(251, 20);
            this.amountexpenses.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "AMOUNT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "DATE :";
            // 
            // nameexpenses
            // 
            this.nameexpenses.Location = new System.Drawing.Point(281, 141);
            this.nameexpenses.Name = "nameexpenses";
            this.nameexpenses.Size = new System.Drawing.Size(251, 20);
            this.nameexpenses.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "DETAILS : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orchid;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(302, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "EXPENSES";
            // 
            // dateexpenses
            // 
            this.dateexpenses.Location = new System.Drawing.Point(281, 210);
            this.dateexpenses.Name = "dateexpenses";
            this.dateexpenses.Size = new System.Drawing.Size(251, 20);
            this.dateexpenses.TabIndex = 34;
            // 
            // submitexpenses
            // 
            this.submitexpenses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.submitexpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitexpenses.Location = new System.Drawing.Point(347, 299);
            this.submitexpenses.Name = "submitexpenses";
            this.submitexpenses.Size = new System.Drawing.Size(88, 35);
            this.submitexpenses.TabIndex = 48;
            this.submitexpenses.Text = "SUBMIT";
            this.submitexpenses.UseVisualStyleBackColor = false;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.submitexpenses);
            this.Controls.Add(this.dateexpenses);
            this.Controls.Add(this.remarkexpenses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountexpenses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameexpenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Expenses";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remarkexpenses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amountexpenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameexpenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateexpenses;
        private System.Windows.Forms.Button submitexpenses;
    }
}