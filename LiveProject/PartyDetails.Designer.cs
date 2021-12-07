namespace LiveProject
{
    partial class PartyDetails
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
            this.close = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clearCF = new System.Windows.Forms.Button();
            this.deleteCF = new System.Windows.Forms.Button();
            this.addCF = new System.Windows.Forms.Button();
            this.updateCF = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partyid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.village = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flicenceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfglicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Size = new System.Drawing.Size(1143, 60);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search / Edit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::LiveProject.Properties.Resources.search1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(393, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "SEARCH";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyDetails_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(381, 24);
            this.textBox2.TabIndex = 0;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyDetails_KeyDown);
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
            this.textBox1.Size = new System.Drawing.Size(1167, 29);
            this.textBox1.TabIndex = 100;
            this.textBox1.TabStop = false;
            this.textBox1.Text = " PARTY DETAILS";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Snow;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Image = global::LiveProject.Properties.Resources.close;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(1055, 512);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(100, 30);
            this.close.TabIndex = 4;
            this.close.Text = "CLOSE";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            this.close.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyDetails_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1167, 15);
            this.panel4.TabIndex = 94;
            // 
            // clearCF
            // 
            this.clearCF.BackColor = System.Drawing.Color.Snow;
            this.clearCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCF.Image = global::LiveProject.Properties.Resources.update;
            this.clearCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearCF.Location = new System.Drawing.Point(843, 512);
            this.clearCF.Name = "clearCF";
            this.clearCF.Size = new System.Drawing.Size(100, 30);
            this.clearCF.TabIndex = 2;
            this.clearCF.Text = "CLEAR";
            this.clearCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearCF.UseVisualStyleBackColor = false;
            this.clearCF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyDetails_KeyDown);
            // 
            // deleteCF
            // 
            this.deleteCF.BackColor = System.Drawing.Color.Snow;
            this.deleteCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCF.Image = global::LiveProject.Properties.Resources.delete;
            this.deleteCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteCF.Location = new System.Drawing.Point(949, 512);
            this.deleteCF.Name = "deleteCF";
            this.deleteCF.Size = new System.Drawing.Size(100, 30);
            this.deleteCF.TabIndex = 3;
            this.deleteCF.Text = "DELETE";
            this.deleteCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteCF.UseVisualStyleBackColor = false;
            this.deleteCF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyDetails_KeyDown);
            // 
            // addCF
            // 
            this.addCF.BackColor = System.Drawing.Color.Snow;
            this.addCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCF.Image = global::LiveProject.Properties.Resources.add11;
            this.addCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCF.Location = new System.Drawing.Point(633, 512);
            this.addCF.Name = "addCF";
            this.addCF.Size = new System.Drawing.Size(100, 30);
            this.addCF.TabIndex = 0;
            this.addCF.Text = "ADD";
            this.addCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addCF.UseVisualStyleBackColor = false;
            this.addCF.Click += new System.EventHandler(this.addCF_Click_1);
            this.addCF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyDetails_KeyDown);
            // 
            // updateCF
            // 
            this.updateCF.BackColor = System.Drawing.Color.Snow;
            this.updateCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCF.Image = global::LiveProject.Properties.Resources.updatet112;
            this.updateCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateCF.Location = new System.Drawing.Point(737, 512);
            this.updateCF.Name = "updateCF";
            this.updateCF.Size = new System.Drawing.Size(100, 30);
            this.updateCF.TabIndex = 1;
            this.updateCF.Text = "UPDATE";
            this.updateCF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateCF.UseVisualStyleBackColor = false;
            this.updateCF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyDetails_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partyid,
            this.name,
            this.type,
            this.contact,
            this.country,
            this.state,
            this.dist,
            this.ps,
            this.village,
            this.pin,
            this.pan,
            this.gst,
            this.cin,
            this.licence,
            this.statecode,
            this.email,
            this.website,
            this.dlno,
            this.flicenceno,
            this.mfglicence});
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 385);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyDetails_KeyDown);
            // 
            // partyid
            // 
            this.partyid.HeaderText = "PartyId";
            this.partyid.Name = "partyid";
            this.partyid.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.HeaderText = "Contact No";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // country
            // 
            this.country.HeaderText = "Country";
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // dist
            // 
            this.dist.HeaderText = "Dist";
            this.dist.Name = "dist";
            this.dist.ReadOnly = true;
            // 
            // ps
            // 
            this.ps.HeaderText = "PS";
            this.ps.Name = "ps";
            this.ps.ReadOnly = true;
            // 
            // village
            // 
            this.village.HeaderText = "Village";
            this.village.Name = "village";
            this.village.ReadOnly = true;
            // 
            // pin
            // 
            this.pin.HeaderText = "PIN";
            this.pin.Name = "pin";
            this.pin.ReadOnly = true;
            // 
            // pan
            // 
            this.pan.HeaderText = "PAN";
            this.pan.Name = "pan";
            this.pan.ReadOnly = true;
            // 
            // gst
            // 
            this.gst.HeaderText = "GST";
            this.gst.Name = "gst";
            this.gst.ReadOnly = true;
            // 
            // cin
            // 
            this.cin.HeaderText = "CIN No";
            this.cin.Name = "cin";
            this.cin.ReadOnly = true;
            // 
            // licence
            // 
            this.licence.HeaderText = "Linence No";
            this.licence.Name = "licence";
            this.licence.ReadOnly = true;
            // 
            // statecode
            // 
            this.statecode.HeaderText = "State Code";
            this.statecode.Name = "statecode";
            this.statecode.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // website
            // 
            this.website.HeaderText = "Website";
            this.website.Name = "website";
            this.website.ReadOnly = true;
            // 
            // dlno
            // 
            this.dlno.HeaderText = "DL No";
            this.dlno.Name = "dlno";
            this.dlno.ReadOnly = true;
            // 
            // flicenceno
            // 
            this.flicenceno.HeaderText = "Food Licence No";
            this.flicenceno.Name = "flicenceno";
            this.flicenceno.ReadOnly = true;
            // 
            // mfglicence
            // 
            this.mfglicence.HeaderText = "MFG Licence No";
            this.mfglicence.Name = "mfglicence";
            this.mfglicence.ReadOnly = true;
            // 
            // PartyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1167, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.clearCF);
            this.Controls.Add(this.deleteCF);
            this.Controls.Add(this.addCF);
            this.Controls.Add(this.updateCF);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartyDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartySetup";
            this.Load += new System.EventHandler(this.PartyDetails_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyDetails_KeyDown);
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
        private System.Windows.Forms.Button deleteCF;
        private System.Windows.Forms.Button addCF;
        private System.Windows.Forms.Button updateCF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps;
        private System.Windows.Forms.DataGridViewTextBoxColumn village;
        private System.Windows.Forms.DataGridViewTextBoxColumn pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn pan;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst;
        private System.Windows.Forms.DataGridViewTextBoxColumn cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn licence;
        private System.Windows.Forms.DataGridViewTextBoxColumn statecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn website;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlno;
        private System.Windows.Forms.DataGridViewTextBoxColumn flicenceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfglicence;
    }
}