
namespace BlacksPropertyManagement
{
    partial class RemoveMaterialForm
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
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradesmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blacksPropertyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blacksPropertyDataSet = new BlacksPropertyManagement.BlacksPropertyDataSet();
            this.dgvJobMaterial = new System.Windows.Forms.DataGridView();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJob
            // 
            this.dgvJob.AutoGenerateColumns = false;
            this.dgvJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobIDDataGridViewTextBoxColumn,
            this.jobDescriptionDataGridViewTextBoxColumn,
            this.jobDateDataGridViewTextBoxColumn,
            this.JobStatus,
            this.jobFeeDataGridViewTextBoxColumn,
            this.propertyIDDataGridViewTextBoxColumn,
            this.tradesmanIDDataGridViewTextBoxColumn});
            this.dgvJob.DataMember = "JOB";
            this.dgvJob.DataSource = this.blacksPropertyDataSetBindingSource;
            this.dgvJob.Location = new System.Drawing.Point(12, 12);
            this.dgvJob.Name = "dgvJob";
            this.dgvJob.ReadOnly = true;
            this.dgvJob.RowHeadersWidth = 51;
            this.dgvJob.RowTemplate.Height = 24;
            this.dgvJob.Size = new System.Drawing.Size(929, 263);
            this.dgvJob.TabIndex = 0;
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "JobID";
            this.jobIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            this.jobIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobDescriptionDataGridViewTextBoxColumn
            // 
            this.jobDescriptionDataGridViewTextBoxColumn.DataPropertyName = "JobDescription";
            this.jobDescriptionDataGridViewTextBoxColumn.HeaderText = "JobDescription";
            this.jobDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobDescriptionDataGridViewTextBoxColumn.Name = "jobDescriptionDataGridViewTextBoxColumn";
            this.jobDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobDateDataGridViewTextBoxColumn
            // 
            this.jobDateDataGridViewTextBoxColumn.DataPropertyName = "JobDate";
            this.jobDateDataGridViewTextBoxColumn.HeaderText = "JobDate";
            this.jobDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobDateDataGridViewTextBoxColumn.Name = "jobDateDataGridViewTextBoxColumn";
            this.jobDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // JobStatus
            // 
            this.JobStatus.DataPropertyName = "JobStatus";
            this.JobStatus.HeaderText = "JobStatus";
            this.JobStatus.MinimumWidth = 6;
            this.JobStatus.Name = "JobStatus";
            this.JobStatus.ReadOnly = true;
            this.JobStatus.Width = 125;
            // 
            // jobFeeDataGridViewTextBoxColumn
            // 
            this.jobFeeDataGridViewTextBoxColumn.DataPropertyName = "JobFee";
            this.jobFeeDataGridViewTextBoxColumn.HeaderText = "JobFee";
            this.jobFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobFeeDataGridViewTextBoxColumn.Name = "jobFeeDataGridViewTextBoxColumn";
            this.jobFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobFeeDataGridViewTextBoxColumn.Width = 125;
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
            // tradesmanIDDataGridViewTextBoxColumn
            // 
            this.tradesmanIDDataGridViewTextBoxColumn.DataPropertyName = "TradesmanID";
            this.tradesmanIDDataGridViewTextBoxColumn.HeaderText = "TradesmanID";
            this.tradesmanIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tradesmanIDDataGridViewTextBoxColumn.Name = "tradesmanIDDataGridViewTextBoxColumn";
            this.tradesmanIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tradesmanIDDataGridViewTextBoxColumn.Width = 125;
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
            // dgvJobMaterial
            // 
            this.dgvJobMaterial.AutoGenerateColumns = false;
            this.dgvJobMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobID,
            this.MaterialID,
            this.Quantity});
            this.dgvJobMaterial.DataMember = "JOBMATERIAL";
            this.dgvJobMaterial.DataSource = this.blacksPropertyDataSetBindingSource;
            this.dgvJobMaterial.Location = new System.Drawing.Point(12, 294);
            this.dgvJobMaterial.Name = "dgvJobMaterial";
            this.dgvJobMaterial.ReadOnly = true;
            this.dgvJobMaterial.RowHeadersWidth = 51;
            this.dgvJobMaterial.RowTemplate.Height = 24;
            this.dgvJobMaterial.Size = new System.Drawing.Size(428, 258);
            this.dgvJobMaterial.TabIndex = 1;
            this.dgvJobMaterial.Click += new System.EventHandler(this.dgvJobMaterial_Click);
            // 
            // JobID
            // 
            this.JobID.DataPropertyName = "JobID";
            this.JobID.HeaderText = "JobID";
            this.JobID.MinimumWidth = 6;
            this.JobID.Name = "JobID";
            this.JobID.ReadOnly = true;
            this.JobID.Width = 125;
            // 
            // MaterialID
            // 
            this.MaterialID.DataPropertyName = "MaterialID";
            this.MaterialID.HeaderText = "MaterialID";
            this.MaterialID.MinimumWidth = 6;
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.ReadOnly = true;
            this.MaterialID.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 579);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(198, 84);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Material";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(790, 579);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(198, 84);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(637, 294);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(304, 27);
            this.txtDescription.TabIndex = 4;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(637, 354);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 27);
            this.txtCost.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(446, 297);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 19);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Material Description:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(503, 357);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(101, 19);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Material Cost:";
            // 
            // RemoveMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvJobMaterial);
            this.Controls.Add(this.dgvJob);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveMaterialForm";
            this.Text = "Remove Material";
            this.Load += new System.EventHandler(this.RemoveMaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJob;
        private System.Windows.Forms.BindingSource blacksPropertyDataSetBindingSource;
        private BlacksPropertyDataSet blacksPropertyDataSet;
        private System.Windows.Forms.DataGridView dgvJobMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradesmanIDDataGridViewTextBoxColumn;
    }
}