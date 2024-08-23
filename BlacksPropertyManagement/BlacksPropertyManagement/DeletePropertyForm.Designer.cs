
namespace BlacksPropertyManagement
{
    partial class DeletePropertyForm
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
            this.dgvProperty = new System.Windows.Forms.DataGridView();
            this.blacksPropertyDataSet = new BlacksPropertyManagement.BlacksPropertyDataSet();
            this.blacksPropertyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suburb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearBuilt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LandlordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProperty
            // 
            this.dgvProperty.AutoGenerateColumns = false;
            this.dgvProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyID,
            this.StreetAddress,
            this.Suburb,
            this.Status,
            this.YearBuilt,
            this.LandlordID});
            this.dgvProperty.DataMember = "PROPERTY";
            this.dgvProperty.DataSource = this.blacksPropertyDataSetBindingSource;
            this.dgvProperty.Location = new System.Drawing.Point(162, 51);
            this.dgvProperty.Name = "dgvProperty";
            this.dgvProperty.ReadOnly = true;
            this.dgvProperty.Size = new System.Drawing.Size(643, 150);
            this.dgvProperty.TabIndex = 0;
            this.dgvProperty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvProperty.Click += new System.EventHandler(this.dgvProperty_Click);
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
            // PropertyID
            // 
            this.PropertyID.DataPropertyName = "PropertyID";
            this.PropertyID.HeaderText = "PropertyID";
            this.PropertyID.Name = "PropertyID";
            this.PropertyID.ReadOnly = true;
            // 
            // StreetAddress
            // 
            this.StreetAddress.DataPropertyName = "StreetAddress";
            this.StreetAddress.HeaderText = "StreetAddress";
            this.StreetAddress.Name = "StreetAddress";
            this.StreetAddress.ReadOnly = true;
            // 
            // Suburb
            // 
            this.Suburb.DataPropertyName = "Suburb";
            this.Suburb.HeaderText = "Suburb";
            this.Suburb.Name = "Suburb";
            this.Suburb.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // YearBuilt
            // 
            this.YearBuilt.DataPropertyName = "YearBuilt";
            this.YearBuilt.HeaderText = "YearBuilt";
            this.YearBuilt.Name = "YearBuilt";
            this.YearBuilt.ReadOnly = true;
            // 
            // LandlordID
            // 
            this.LandlordID.DataPropertyName = "LandlordID";
            this.LandlordID.HeaderText = "LandlordID";
            this.LandlordID.Name = "LandlordID";
            this.LandlordID.ReadOnly = true;
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.AutoSize = true;
            this.lblPropertyID.Location = new System.Drawing.Point(247, 270);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(85, 19);
            this.lblPropertyID.TabIndex = 1;
            this.lblPropertyID.Text = "Property ID:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(276, 344);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(57, 19);
            this.lblSuburb.TabIndex = 2;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(226, 313);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(107, 19);
            this.lblStreetAddress.TabIndex = 3;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(191, 381);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(142, 19);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Landlord Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(190, 412);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(143, 19);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "Landlord First Name:";
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(88, 544);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(260, 97);
            this.btnDeleteProperty.TabIndex = 6;
            this.btnDeleteProperty.Text = "Delete Property:";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(641, 544);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(260, 97);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Location = new System.Drawing.Point(338, 267);
            this.txtPropertyID.MaxLength = 5;
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(100, 27);
            this.txtPropertyID.TabIndex = 8;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(338, 310);
            this.txtStreetAddress.MaxLength = 60;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(412, 27);
            this.txtStreetAddress.TabIndex = 9;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(338, 341);
            this.txtSuburb.MaxLength = 20;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            this.txtSuburb.Size = new System.Drawing.Size(412, 27);
            this.txtSuburb.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(338, 378);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(288, 27);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(338, 412);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(288, 27);
            this.txtFirstName.TabIndex = 12;
            // 
            // DeletePropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblPropertyID);
            this.Controls.Add(this.dgvProperty);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeletePropertyForm";
            this.Text = "Delete Property";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suburb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearBuilt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LandlordID;
        private System.Windows.Forms.BindingSource blacksPropertyDataSetBindingSource;
        private BlacksPropertyDataSet blacksPropertyDataSet;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}