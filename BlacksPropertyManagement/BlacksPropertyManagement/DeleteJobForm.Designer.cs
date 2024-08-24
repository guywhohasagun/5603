
namespace BlacksPropertyManagement
{
    partial class DeleteJobForm
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
            this.dgvJob = new System.Windows.Forms.DataGridView();
            this.blacksPropertyDataSet = new BlacksPropertyManagement.BlacksPropertyDataSet();
            this.blacksPropertyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblJobID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradesmanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJob
            // 
            this.dgvJob.AutoGenerateColumns = false;
            this.dgvJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobID,
            this.JobDescription,
            this.JobDate,
            this.JobStatus,
            this.JobFee,
            this.PropertyID,
            this.TradesmanID});
            this.dgvJob.DataMember = "JOB";
            this.dgvJob.DataSource = this.blacksPropertyDataSetBindingSource;
            this.dgvJob.Location = new System.Drawing.Point(133, 12);
            this.dgvJob.Name = "dgvJob";
            this.dgvJob.ReadOnly = true;
            this.dgvJob.Size = new System.Drawing.Size(743, 207);
            this.dgvJob.TabIndex = 0;
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
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(126, 290);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(52, 19);
            this.lblJobID.TabIndex = 1;
            this.lblJobID.Text = "Job ID:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(66, 334);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 19);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Job Description:";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(117, 381);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(61, 19);
            this.lblFee.TabIndex = 3;
            this.lblFee.Text = "Job Fee:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(109, 422);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 19);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Job Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(100, 467);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 19);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Job Status:";
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(184, 287);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.ReadOnly = true;
            this.txtJobID.Size = new System.Drawing.Size(100, 27);
            this.txtJobID.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(184, 331);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(692, 27);
            this.txtDescription.TabIndex = 7;
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(184, 378);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(100, 27);
            this.txtFee.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(184, 419);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(100, 27);
            this.txtDate.TabIndex = 9;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(184, 464);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 27);
            this.txtStatus.TabIndex = 10;
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(133, 564);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(149, 58);
            this.btnDeleteJob.TabIndex = 11;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(727, 564);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(149, 58);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            // DeleteJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.dgvJob);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteJobForm";
            this.Text = "Delete Job";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJob;
        private System.Windows.Forms.BindingSource blacksPropertyDataSetBindingSource;
        private BlacksPropertyDataSet blacksPropertyDataSet;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradesmanID;
    }
}