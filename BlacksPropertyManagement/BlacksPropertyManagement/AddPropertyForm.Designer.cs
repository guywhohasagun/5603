
namespace BlacksPropertyManagement
{
    partial class AddPropertyForm
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
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLandlordSuburb = new System.Windows.Forms.TextBox();
            this.txtLandlordStreetAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblYearBuilt = new System.Windows.Forms.Label();
            this.lblLandlord = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLandlordStreetAddress = new System.Windows.Forms.Label();
            this.lblLandlordSuburb = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboLandlord = new System.Windows.Forms.ComboBox();
            this.cboFirstName = new System.Windows.Forms.ComboBox();
            this.cboLastName = new System.Windows.Forms.ComboBox();
            this.nudYearBuilt = new System.Windows.Forms.NumericUpDown();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddProperty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(237, 35);
            this.txtStreetAddress.MaxLength = 60;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(616, 27);
            this.txtStreetAddress.TabIndex = 0;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(60, 38);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(107, 19);
            this.lblStreetAddress.TabIndex = 5;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(237, 85);
            this.txtSuburb.MaxLength = 20;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(616, 27);
            this.txtSuburb.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(237, 329);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(616, 27);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLandlordSuburb
            // 
            this.txtLandlordSuburb.Location = new System.Drawing.Point(237, 432);
            this.txtLandlordSuburb.Name = "txtLandlordSuburb";
            this.txtLandlordSuburb.ReadOnly = true;
            this.txtLandlordSuburb.Size = new System.Drawing.Size(616, 27);
            this.txtLandlordSuburb.TabIndex = 8;
            // 
            // txtLandlordStreetAddress
            // 
            this.txtLandlordStreetAddress.Location = new System.Drawing.Point(237, 374);
            this.txtLandlordStreetAddress.Name = "txtLandlordStreetAddress";
            this.txtLandlordStreetAddress.ReadOnly = true;
            this.txtLandlordStreetAddress.Size = new System.Drawing.Size(616, 27);
            this.txtLandlordStreetAddress.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(237, 280);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(616, 27);
            this.txtLastName.TabIndex = 10;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(60, 88);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(57, 19);
            this.lblSuburb.TabIndex = 11;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(60, 134);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.Location = new System.Drawing.Point(60, 180);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(75, 19);
            this.lblYearBuilt.TabIndex = 13;
            this.lblYearBuilt.Text = "Year Built:";
            // 
            // lblLandlord
            // 
            this.lblLandlord.AutoSize = true;
            this.lblLandlord.Location = new System.Drawing.Point(60, 233);
            this.lblLandlord.Name = "lblLandlord";
            this.lblLandlord.Size = new System.Drawing.Size(76, 19);
            this.lblLandlord.TabIndex = 14;
            this.lblLandlord.Text = "Landlords:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(60, 283);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(142, 19);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Landlord Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(60, 332);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(143, 19);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "Landlord First Name:";
            // 
            // lblLandlordStreetAddress
            // 
            this.lblLandlordStreetAddress.AutoSize = true;
            this.lblLandlordStreetAddress.Location = new System.Drawing.Point(60, 377);
            this.lblLandlordStreetAddress.Name = "lblLandlordStreetAddress";
            this.lblLandlordStreetAddress.Size = new System.Drawing.Size(107, 19);
            this.lblLandlordStreetAddress.TabIndex = 17;
            this.lblLandlordStreetAddress.Text = "Street Address:";
            this.lblLandlordStreetAddress.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblLandlordSuburb
            // 
            this.lblLandlordSuburb.AutoSize = true;
            this.lblLandlordSuburb.Location = new System.Drawing.Point(60, 432);
            this.lblLandlordSuburb.Name = "lblLandlordSuburb";
            this.lblLandlordSuburb.Size = new System.Drawing.Size(57, 19);
            this.lblLandlordSuburb.TabIndex = 18;
            this.lblLandlordSuburb.Text = "Suburb:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Occupied",
            "Unoccupied"});
            this.cboStatus.Location = new System.Drawing.Point(237, 131);
            this.cboStatus.MaxLength = 10;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(130, 27);
            this.cboStatus.TabIndex = 19;
            this.cboStatus.Text = "Occupied";
            // 
            // cboLandlord
            // 
            this.cboLandlord.FormattingEnabled = true;
            this.cboLandlord.Location = new System.Drawing.Point(237, 230);
            this.cboLandlord.Name = "cboLandlord";
            this.cboLandlord.Size = new System.Drawing.Size(194, 27);
            this.cboLandlord.TabIndex = 20;
            // 
            // cboFirstName
            // 
            this.cboFirstName.FormattingEnabled = true;
            this.cboFirstName.Location = new System.Drawing.Point(681, 230);
            this.cboFirstName.Name = "cboFirstName";
            this.cboFirstName.Size = new System.Drawing.Size(172, 27);
            this.cboFirstName.TabIndex = 21;
            // 
            // cboLastName
            // 
            this.cboLastName.FormattingEnabled = true;
            this.cboLastName.Location = new System.Drawing.Point(448, 230);
            this.cboLastName.Name = "cboLastName";
            this.cboLastName.Size = new System.Drawing.Size(212, 27);
            this.cboLastName.TabIndex = 22;
            // 
            // nudYearBuilt
            // 
            this.nudYearBuilt.Location = new System.Drawing.Point(237, 178);
            this.nudYearBuilt.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudYearBuilt.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYearBuilt.Name = "nudYearBuilt";
            this.nudYearBuilt.Size = new System.Drawing.Size(130, 27);
            this.nudYearBuilt.TabIndex = 23;
            this.nudYearBuilt.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(634, 532);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(219, 74);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(237, 532);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(219, 74);
            this.btnAddProperty.TabIndex = 25;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            // 
            // AddPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.nudYearBuilt);
            this.Controls.Add(this.cboLastName);
            this.Controls.Add(this.cboFirstName);
            this.Controls.Add(this.cboLandlord);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblLandlordSuburb);
            this.Controls.Add(this.lblLandlordStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblLandlord);
            this.Controls.Add(this.lblYearBuilt);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtLandlordStreetAddress);
            this.Controls.Add(this.txtLandlordSuburb);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.txtStreetAddress);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPropertyForm";
            this.Text = "Add a Property";
            this.Load += new System.EventHandler(this.AddPropertyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLandlordSuburb;
        private System.Windows.Forms.TextBox txtLandlordStreetAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblYearBuilt;
        private System.Windows.Forms.Label lblLandlord;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLandlordStreetAddress;
        private System.Windows.Forms.Label lblLandlordSuburb;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboLandlord;
        private System.Windows.Forms.ComboBox cboFirstName;
        private System.Windows.Forms.ComboBox cboLastName;
        private System.Windows.Forms.NumericUpDown nudYearBuilt;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddProperty;
    }
}