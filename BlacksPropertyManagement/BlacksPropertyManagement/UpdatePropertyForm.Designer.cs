
namespace BlacksPropertyManagement
{
    partial class UpdatePropertyForm
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
            this.components = new System.ComponentModel.Container();
            this.dvgProperty = new System.Windows.Forms.DataGridView();
            this.blacksPropertyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blacksPropertyDataSet = new BlacksPropertyManagement.BlacksPropertyDataSet();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblYearBuilt = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtProperty = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.nudYearBuilt = new System.Windows.Forms.NumericUpDown();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.PropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suburb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearBuilt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LandlordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProperty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgProperty
            // 
            this.dvgProperty.AutoGenerateColumns = false;
            this.dvgProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProperty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyID,
            this.StreetAddress,
            this.Suburb,
            this.Status,
            this.YearBuilt,
            this.LandlordID});
            this.dvgProperty.DataMember = "PROPERTY";
            this.dvgProperty.DataSource = this.blacksPropertyDataSetBindingSource;
            this.dvgProperty.Location = new System.Drawing.Point(102, 12);
            this.dvgProperty.Name = "dvgProperty";
            this.dvgProperty.ReadOnly = true;
            this.dvgProperty.RowHeadersWidth = 51;
            this.dvgProperty.RowTemplate.Height = 24;
            this.dvgProperty.Size = new System.Drawing.Size(804, 150);
            this.dvgProperty.TabIndex = 0;
            this.dvgProperty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProperty_CellContentClick);
            this.dvgProperty.Click += new System.EventHandler(this.dvgProperty_Click);
            // 
            // blacksPropertyDataSetBindingSource
            // 
            this.blacksPropertyDataSetBindingSource.DataSource = this.blacksPropertyDataSet;
            this.blacksPropertyDataSetBindingSource.Position = 0;
            // 
            // blacksPropertyDataSet
            // 
            this.blacksPropertyDataSet.DataSetName = "BlacksPropertyDataSet";
            this.blacksPropertyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.AutoSize = true;
            this.lblPropertyID.Location = new System.Drawing.Point(98, 191);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(85, 19);
            this.lblPropertyID.TabIndex = 1;
            this.lblPropertyID.Text = "Property ID:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(70, 245);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(107, 19);
            this.lblStreetAddress.TabIndex = 2;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(132, 296);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(57, 19);
            this.lblSuburb.TabIndex = 3;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(83, 355);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 19);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "House Status:";
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.Location = new System.Drawing.Point(115, 415);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(75, 19);
            this.lblYearBuilt.TabIndex = 5;
            this.lblYearBuilt.Text = "Year Built:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(33, 471);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(136, 19);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "Landlord Lastname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(33, 523);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(137, 19);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "Landlord Firstname:";
            // 
            // txtProperty
            // 
            this.txtProperty.Location = new System.Drawing.Point(213, 188);
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.ReadOnly = true;
            this.txtProperty.Size = new System.Drawing.Size(130, 27);
            this.txtProperty.TabIndex = 8;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(213, 242);
            this.txtStreetAddress.MaxLength = 60;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(603, 27);
            this.txtStreetAddress.TabIndex = 9;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(213, 296);
            this.txtSuburb.MaxLength = 20;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(603, 27);
            this.txtSuburb.TabIndex = 10;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Occupied",
            "Unoccupied"});
            this.cboStatus.Location = new System.Drawing.Point(213, 352);
            this.cboStatus.MaxLength = 8;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(197, 27);
            this.cboStatus.TabIndex = 11;
            this.cboStatus.Text = "Occupied";
            // 
            // nudYearBuilt
            // 
            this.nudYearBuilt.Location = new System.Drawing.Point(216, 413);
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
            this.nudYearBuilt.Size = new System.Drawing.Size(120, 27);
            this.nudYearBuilt.TabIndex = 12;
            this.nudYearBuilt.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYearBuilt.ValueChanged += new System.EventHandler(this.nudYearBuilt_ValueChanged);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(216, 468);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.ReadOnly = true;
            this.txtLastname.Size = new System.Drawing.Size(217, 27);
            this.txtLastname.TabIndex = 13;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(213, 520);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.ReadOnly = true;
            this.txtFirstname.Size = new System.Drawing.Size(220, 27);
            this.txtFirstname.TabIndex = 14;
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(102, 578);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(164, 61);
            this.btnUpdateProperty.TabIndex = 15;
            this.btnUpdateProperty.Text = "Update Property";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            this.btnUpdateProperty.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(742, 578);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(164, 61);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // PropertyID
            // 
            this.PropertyID.DataPropertyName = "PropertyID";
            this.PropertyID.HeaderText = "PropertyID";
            this.PropertyID.MinimumWidth = 6;
            this.PropertyID.Name = "PropertyID";
            this.PropertyID.ReadOnly = true;
            this.PropertyID.Width = 125;
            // 
            // StreetAddress
            // 
            this.StreetAddress.DataPropertyName = "StreetAddress";
            this.StreetAddress.HeaderText = "StreetAddress";
            this.StreetAddress.MinimumWidth = 6;
            this.StreetAddress.Name = "StreetAddress";
            this.StreetAddress.ReadOnly = true;
            this.StreetAddress.Width = 125;
            // 
            // Suburb
            // 
            this.Suburb.DataPropertyName = "Suburb";
            this.Suburb.HeaderText = "Suburb";
            this.Suburb.MinimumWidth = 6;
            this.Suburb.Name = "Suburb";
            this.Suburb.ReadOnly = true;
            this.Suburb.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // YearBuilt
            // 
            this.YearBuilt.DataPropertyName = "YearBuilt";
            this.YearBuilt.HeaderText = "YearBuilt";
            this.YearBuilt.MinimumWidth = 6;
            this.YearBuilt.Name = "YearBuilt";
            this.YearBuilt.ReadOnly = true;
            this.YearBuilt.Width = 125;
            // 
            // LandlordID
            // 
            this.LandlordID.DataPropertyName = "LandlordID";
            this.LandlordID.HeaderText = "LandlordID";
            this.LandlordID.MinimumWidth = 6;
            this.LandlordID.Name = "LandlordID";
            this.LandlordID.ReadOnly = true;
            this.LandlordID.Width = 125;
            // 
            // UpdatePropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateProperty);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.nudYearBuilt);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtProperty);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblYearBuilt);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblPropertyID);
            this.Controls.Add(this.dvgProperty);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdatePropertyForm";
            this.Text = "Update Property";
            ((System.ComponentModel.ISupportInitialize)(this.dvgProperty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgProperty;
        private System.Windows.Forms.BindingSource blacksPropertyDataSetBindingSource;
        private BlacksPropertyDataSet blacksPropertyDataSet;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblYearBuilt;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtProperty;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.NumericUpDown nudYearBuilt;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Button btnUpdateProperty;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suburb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearBuilt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LandlordID;
    }
}