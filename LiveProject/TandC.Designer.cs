namespace LiveProject
{
    partial class TandC
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
            this.saveTAC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsTAC = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.remarksTAC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveTAC
            // 
            this.saveTAC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveTAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTAC.Location = new System.Drawing.Point(354, 384);
            this.saveTAC.Name = "saveTAC";
            this.saveTAC.Size = new System.Drawing.Size(88, 35);
            this.saveTAC.TabIndex = 51;
            this.saveTAC.Text = "SAVE";
            this.saveTAC.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "DETAILS : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orchid;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(240, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "TERMS AND CONDITIONS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // detailsTAC
            // 
            this.detailsTAC.Location = new System.Drawing.Point(136, 83);
            this.detailsTAC.Name = "detailsTAC";
            this.detailsTAC.Size = new System.Drawing.Size(634, 224);
            this.detailsTAC.TabIndex = 52;
            this.detailsTAC.Text = "";
            this.detailsTAC.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "REMARKS : ";
            // 
            // remarksTAC
            // 
            this.remarksTAC.Location = new System.Drawing.Point(136, 331);
            this.remarksTAC.Multiline = true;
            this.remarksTAC.Name = "remarksTAC";
            this.remarksTAC.Size = new System.Drawing.Size(341, 20);
            this.remarksTAC.TabIndex = 54;
            // 
            // TandC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.remarksTAC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detailsTAC);
            this.Controls.Add(this.saveTAC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TandC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TandC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveTAC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox detailsTAC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remarksTAC;
    }
}