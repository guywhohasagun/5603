
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
            this.blacksPropertyDataSet = new BlacksPropertyManagement.BlacksPropertyDataSet();
            this.blacksPropertyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suburbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearBuiltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landlordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProperty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgProperty
            // 
            this.dvgProperty.AutoGenerateColumns = false;
            this.dvgProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProperty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propertyIDDataGridViewTextBoxColumn,
            this.streetAddressDataGridViewTextBoxColumn,
            this.suburbDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.yearBuiltDataGridViewTextBoxColumn,
            this.landlordIDDataGridViewTextBoxColumn});
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
            // 
            // blacksPropertyDataSet
            // 
            this.blacksPropertyDataSet.DataSetName = "BlacksPropertyDataSet";
            this.blacksPropertyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blacksPropertyDataSetBindingSource
            // 
            this.blacksPropertyDataSetBindingSource.DataSource = this.blacksPropertyDataSet;
            this.blacksPropertyDataSetBindingSource.Position = 0;
            // 
            // propertyIDDataGridViewTextBoxColumn
            // 
            this.propertyIDDataGridViewTextBoxColumn.DataPropertyName = "PropertyID";
            this.propertyIDDataGridViewTextBoxColumn.HeaderText = "PropertyID";
            this.propertyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.propertyIDDataGridViewTextBoxColumn.Name = "propertyIDDataGridViewTextBoxColumn";
            this.propertyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.propertyIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            this.streetAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // suburbDataGridViewTextBoxColumn
            // 
            this.suburbDataGridViewTextBoxColumn.DataPropertyName = "Suburb";
            this.suburbDataGridViewTextBoxColumn.HeaderText = "Suburb";
            this.suburbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suburbDataGridViewTextBoxColumn.Name = "suburbDataGridViewTextBoxColumn";
            this.suburbDataGridViewTextBoxColumn.ReadOnly = true;
            this.suburbDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearBuiltDataGridViewTextBoxColumn
            // 
            this.yearBuiltDataGridViewTextBoxColumn.DataPropertyName = "YearBuilt";
            this.yearBuiltDataGridViewTextBoxColumn.HeaderText = "YearBuilt";
            this.yearBuiltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearBuiltDataGridViewTextBoxColumn.Name = "yearBuiltDataGridViewTextBoxColumn";
            this.yearBuiltDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearBuiltDataGridViewTextBoxColumn.Width = 125;
            // 
            // landlordIDDataGridViewTextBoxColumn
            // 
            this.landlordIDDataGridViewTextBoxColumn.DataPropertyName = "LandlordID";
            this.landlordIDDataGridViewTextBoxColumn.HeaderText = "LandlordID";
            this.landlordIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.landlordIDDataGridViewTextBoxColumn.Name = "landlordIDDataGridViewTextBoxColumn";
            this.landlordIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.landlordIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.AutoSize = true;
            this.lblPropertyID.Location = new System.Drawing.Point(98, 191);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(109, 24);
            this.lblPropertyID.TabIndex = 1;
            this.lblPropertyID.Text = "Property ID:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(70, 245);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(137, 24);
            this.lblStreetAddress.TabIndex = 2;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(132, 296);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(75, 24);
            this.lblSuburb.TabIndex = 3;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(83, 355);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(124, 24);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "House Status:";
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.Location = new System.Drawing.Point(115, 415);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(95, 24);
            this.lblYearBuilt.TabIndex = 5;
            this.lblYearBuilt.Text = "Year Built:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(33, 471);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(174, 24);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "Landlord Lastname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(33, 523);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(177, 24);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "Landlord Firstname:";
            // 
            // txtProperty
            // 
            this.txtProperty.Location = new System.Drawing.Point(213, 188);
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.ReadOnly = true;
            this.txtProperty.Size = new System.Drawing.Size(130, 32);
            this.txtProperty.TabIndex = 8;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(213, 242);
            this.txtStreetAddress.MaxLength = 60;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(603, 32);
            this.txtStreetAddress.TabIndex = 9;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(213, 296);
            this.txtSuburb.MaxLength = 20;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(603, 32);
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
            this.cboStatus.Size = new System.Drawing.Size(197, 32);
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
            this.nudYearBuilt.Size = new System.Drawing.Size(120, 32);
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
            this.txtLastname.Size = new System.Drawing.Size(217, 32);
            this.txtLastname.TabIndex = 13;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(213, 520);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.ReadOnly = true;
            this.txtFirstname.Size = new System.Drawing.Size(220, 32);
            this.txtFirstname.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 61);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 61);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UpdatePropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suburbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearBuiltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn landlordIDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}