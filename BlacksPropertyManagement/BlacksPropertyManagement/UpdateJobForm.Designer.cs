
namespace BlacksPropertyManagement
{
    partial class UpdateJobForm
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
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradesmanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blacksPropertyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blacksPropertyDataSet = new BlacksPropertyManagement.BlacksPropertyDataSet();
            this.lblJobID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLandlordID = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLandlordID = new System.Windows.Forms.TextBox();
            this.rbnPaid = new System.Windows.Forms.RadioButton();
            this.rbnCurrent = new System.Windows.Forms.RadioButton();
            this.nudFee = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rgbStatus = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).BeginInit();
            this.rgbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJobs
            // 
            this.dgvJobs.AutoGenerateColumns = false;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobID,
            this.JobDescription,
            this.JobDate,
            this.JobStatus,
            this.JobFee,
            this.PropertyID,
            this.TradesmanID});
            this.dgvJobs.DataMember = "JOB";
            this.dgvJobs.DataSource = this.blacksPropertyDataSetBindingSource;
            this.dgvJobs.Location = new System.Drawing.Point(127, 12);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.Size = new System.Drawing.Size(743, 150);
            this.dgvJobs.TabIndex = 0;
            this.dgvJobs.Click += new System.EventHandler(this.dgvJobs_Click);
            // 
            // JobID
            // 
            this.JobID.DataPropertyName = "JobID";
            this.JobID.HeaderText = "JobID";
            this.JobID.Name = "JobID";
            this.JobID.ReadOnly = true;
            // 
            // JobDescription
            // 
            this.JobDescription.DataPropertyName = "JobDescription";
            this.JobDescription.HeaderText = "JobDescription";
            this.JobDescription.Name = "JobDescription";
            this.JobDescription.ReadOnly = true;
            // 
            // JobDate
            // 
            this.JobDate.DataPropertyName = "JobDate";
            this.JobDate.HeaderText = "JobDate";
            this.JobDate.Name = "JobDate";
            this.JobDate.ReadOnly = true;
            // 
            // JobStatus
            // 
            this.JobStatus.DataPropertyName = "JobStatus";
            this.JobStatus.HeaderText = "JobStatus";
            this.JobStatus.Name = "JobStatus";
            this.JobStatus.ReadOnly = true;
            // 
            // JobFee
            // 
            this.JobFee.DataPropertyName = "JobFee";
            this.JobFee.HeaderText = "JobFee";
            this.JobFee.Name = "JobFee";
            this.JobFee.ReadOnly = true;
            // 
            // PropertyID
            // 
            this.PropertyID.DataPropertyName = "PropertyID";
            this.PropertyID.HeaderText = "PropertyID";
            this.PropertyID.Name = "PropertyID";
            this.PropertyID.ReadOnly = true;
            // 
            // TradesmanID
            // 
            this.TradesmanID.DataPropertyName = "TradesmanID";
            this.TradesmanID.HeaderText = "TradesmanID";
            this.TradesmanID.Name = "TradesmanID";
            this.TradesmanID.ReadOnly = true;
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
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(125, 220);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(52, 19);
            this.lblJobID.TabIndex = 1;
            this.lblJobID.Text = "Job ID:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(65, 258);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 19);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Job Description:";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(116, 300);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(61, 19);
            this.lblFee.TabIndex = 3;
            this.lblFee.Text = "Job Fee:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(108, 348);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 19);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Job Date:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(12, 386);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(165, 19);
            this.lblStreetAddress.TabIndex = 5;
            this.lblStreetAddress.Text = "Property Street Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Property Suburb:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(477, 300);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 19);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Job Status:";
            // 
            // lblLandlordID
            // 
            this.lblLandlordID.AutoSize = true;
            this.lblLandlordID.Location = new System.Drawing.Point(532, 386);
            this.lblLandlordID.Name = "lblLandlordID";
            this.lblLandlordID.Size = new System.Drawing.Size(87, 19);
            this.lblLandlordID.TabIndex = 8;
            this.lblLandlordID.Text = "Landlord ID:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(477, 428);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(142, 19);
            this.lblLastname.TabIndex = 9;
            this.lblLastname.Text = "Landlord Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(477, 470);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(143, 19);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "Landlord First Name:";
            this.lblFirstName.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(183, 217);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.ReadOnly = true;
            this.txtJobID.Size = new System.Drawing.Size(74, 27);
            this.txtJobID.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(183, 255);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(687, 27);
            this.txtDescription.TabIndex = 12;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(183, 383);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(271, 27);
            this.txtStreetAddress.TabIndex = 13;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(183, 425);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            this.txtSuburb.Size = new System.Drawing.Size(271, 27);
            this.txtSuburb.TabIndex = 14;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(625, 425);
            this.txtLastname.MaxLength = 25;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.ReadOnly = true;
            this.txtLastname.Size = new System.Drawing.Size(271, 27);
            this.txtLastname.TabIndex = 15;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(626, 467);
            this.txtFirstname.MaxLength = 25;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.ReadOnly = true;
            this.txtFirstname.Size = new System.Drawing.Size(271, 27);
            this.txtFirstname.TabIndex = 16;
            // 
            // txtLandlordID
            // 
            this.txtLandlordID.Location = new System.Drawing.Point(626, 383);
            this.txtLandlordID.MaxLength = 5;
            this.txtLandlordID.Name = "txtLandlordID";
            this.txtLandlordID.ReadOnly = true;
            this.txtLandlordID.Size = new System.Drawing.Size(74, 27);
            this.txtLandlordID.TabIndex = 17;
            // 
            // rbnPaid
            // 
            this.rbnPaid.AutoSize = true;
            this.rbnPaid.Location = new System.Drawing.Point(6, 43);
            this.rbnPaid.Name = "rbnPaid";
            this.rbnPaid.Size = new System.Drawing.Size(55, 23);
            this.rbnPaid.TabIndex = 18;
            this.rbnPaid.TabStop = true;
            this.rbnPaid.Text = "Paid";
            this.rbnPaid.UseVisualStyleBackColor = true;
            // 
            // rbnCurrent
            // 
            this.rbnCurrent.AutoSize = true;
            this.rbnCurrent.Location = new System.Drawing.Point(6, 14);
            this.rbnCurrent.Name = "rbnCurrent";
            this.rbnCurrent.Size = new System.Drawing.Size(75, 23);
            this.rbnCurrent.TabIndex = 19;
            this.rbnCurrent.TabStop = true;
            this.rbnCurrent.Text = "Current";
            this.rbnCurrent.UseVisualStyleBackColor = true;
            // 
            // nudFee
            // 
            this.nudFee.Location = new System.Drawing.Point(183, 298);
            this.nudFee.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudFee.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFee.Name = "nudFee";
            this.nudFee.Size = new System.Drawing.Size(120, 27);
            this.nudFee.TabIndex = 20;
            this.nudFee.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(183, 342);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 27);
            this.dtpDate.TabIndex = 21;
            // 
            // rgbStatus
            // 
            this.rgbStatus.Controls.Add(this.rbnPaid);
            this.rgbStatus.Controls.Add(this.rbnCurrent);
            this.rgbStatus.Location = new System.Drawing.Point(561, 288);
            this.rgbStatus.Name = "rgbStatus";
            this.rgbStatus.Size = new System.Drawing.Size(126, 79);
            this.rgbStatus.TabIndex = 22;
            this.rgbStatus.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(669, 542);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(201, 81);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateJob
            // 
            this.btnUpdateJob.Location = new System.Drawing.Point(127, 542);
            this.btnUpdateJob.Name = "btnUpdateJob";
            this.btnUpdateJob.Size = new System.Drawing.Size(201, 81);
            this.btnUpdateJob.TabIndex = 24;
            this.btnUpdateJob.Text = "Update Job";
            this.btnUpdateJob.UseVisualStyleBackColor = true;
            this.btnUpdateJob.Click += new System.EventHandler(this.btnUpdateJob_Click);
            // 
            // UpdateJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.btnUpdateJob);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.rgbStatus);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.nudFee);
            this.Controls.Add(this.txtLandlordID);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblLandlordID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.dgvJobs);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateJobForm";
            this.Text = "Update Job";
            this.Load += new System.EventHandler(this.UpdateJobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).EndInit();
            this.rgbStatus.ResumeLayout(false);
            this.rgbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradesmanID;
        private System.Windows.Forms.BindingSource blacksPropertyDataSetBindingSource;
        private BlacksPropertyDataSet blacksPropertyDataSet;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLandlordID;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLandlordID;
        private System.Windows.Forms.RadioButton rbnPaid;
        private System.Windows.Forms.RadioButton rbnCurrent;
        private System.Windows.Forms.NumericUpDown nudFee;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox rgbStatus;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateJob;
    }
}