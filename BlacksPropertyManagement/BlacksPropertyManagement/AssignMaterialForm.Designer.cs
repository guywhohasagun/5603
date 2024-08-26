
namespace BlacksPropertyManagement
{
    partial class AssignMaterialForm
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
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAssignMaterial = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.dgvJobMaterial = new System.Windows.Forms.DataGridView();
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobMaterial)).BeginInit();
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
            this.dgvJobs.Location = new System.Drawing.Point(12, 34);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.RowTemplate.Height = 24;
            this.dgvJobs.Size = new System.Drawing.Size(752, 150);
            this.dgvJobs.TabIndex = 0;
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
            // dgvMaterial
            // 
            this.dgvMaterial.AutoGenerateColumns = false;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialID,
            this.MaterialDescription,
            this.Cost});
            this.dgvMaterial.DataMember = "MATERIAL";
            this.dgvMaterial.DataSource = this.blacksPropertyDataSetBindingSource;
            this.dgvMaterial.Location = new System.Drawing.Point(12, 387);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.ReadOnly = true;
            this.dgvMaterial.RowHeadersWidth = 51;
            this.dgvMaterial.RowTemplate.Height = 24;
            this.dgvMaterial.Size = new System.Drawing.Size(353, 150);
            this.dgvMaterial.TabIndex = 2;
            // 
            // MaterialID
            // 
            this.MaterialID.DataPropertyName = "MaterialID";
            this.MaterialID.HeaderText = "MaterialID";
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.ReadOnly = true;
            // 
            // MaterialDescription
            // 
            this.MaterialDescription.DataPropertyName = "MaterialDescription";
            this.MaterialDescription.HeaderText = "MaterialDescription";
            this.MaterialDescription.Name = "MaterialDescription";
            this.MaterialDescription.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // btnAssignMaterial
            // 
            this.btnAssignMaterial.Location = new System.Drawing.Point(81, 581);
            this.btnAssignMaterial.Name = "btnAssignMaterial";
            this.btnAssignMaterial.Size = new System.Drawing.Size(182, 53);
            this.btnAssignMaterial.TabIndex = 3;
            this.btnAssignMaterial.Text = "Assign Material";
            this.btnAssignMaterial.UseVisualStyleBackColor = true;
            this.btnAssignMaterial.Click += new System.EventHandler(this.btnAssignMaterial_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(732, 581);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(182, 53);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(728, 446);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 19);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(803, 444);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(60, 27);
            this.nudQuantity.TabIndex = 6;
            // 
            // dgvJobMaterial
            // 
            this.dgvJobMaterial.AutoGenerateColumns = false;
            this.dgvJobMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobIDDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvJobMaterial.DataMember = "JOBMATERIAL";
            this.dgvJobMaterial.DataSource = this.blacksPropertyDataSetBindingSource;
            this.dgvJobMaterial.Location = new System.Drawing.Point(12, 209);
            this.dgvJobMaterial.Name = "dgvJobMaterial";
            this.dgvJobMaterial.ReadOnly = true;
            this.dgvJobMaterial.Size = new System.Drawing.Size(342, 150);
            this.dgvJobMaterial.TabIndex = 7;
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "JobID";
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            this.jobIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AssignMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.dgvJobMaterial);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAssignMaterial);
            this.Controls.Add(this.dgvMaterial);
            this.Controls.Add(this.dgvJobs);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssignMaterialForm";
            this.Text = "AssignMaterialForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blacksPropertyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.Button btnAssignMaterial;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradesmanID;
        private System.Windows.Forms.BindingSource blacksPropertyDataSetBindingSource;
        private BlacksPropertyDataSet blacksPropertyDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridView dgvJobMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}