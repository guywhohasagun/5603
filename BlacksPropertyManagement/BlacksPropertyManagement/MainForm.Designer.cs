
namespace BlacksPropertyManagement
{
    partial class MainForm
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
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.btnUpdateJob = new System.Windows.Forms.Button();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnTradesmenReport = new System.Windows.Forms.Button();
            this.btnAssignMaterial = new System.Windows.Forms.Button();
            this.btnRemoveMaterial = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(97, 231);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(180, 41);
            this.btnAddProperty.TabIndex = 0;
            this.btnAddProperty.Text = "Add a Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(97, 294);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(180, 41);
            this.btnUpdateProperty.TabIndex = 1;
            this.btnUpdateProperty.Text = "Update a Property";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(97, 358);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(180, 41);
            this.btnDeleteProperty.TabIndex = 2;
            this.btnDeleteProperty.Text = "Delete a Property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(300, 231);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(180, 41);
            this.btnAddJob.TabIndex = 3;
            this.btnAddJob.Text = "Add a Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // btnUpdateJob
            // 
            this.btnUpdateJob.Location = new System.Drawing.Point(300, 294);
            this.btnUpdateJob.Name = "btnUpdateJob";
            this.btnUpdateJob.Size = new System.Drawing.Size(180, 41);
            this.btnUpdateJob.TabIndex = 4;
            this.btnUpdateJob.Text = "Update a Job";
            this.btnUpdateJob.UseVisualStyleBackColor = true;
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(300, 358);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(180, 41);
            this.btnDeleteJob.TabIndex = 5;
            this.btnDeleteJob.Text = "Delete a Job";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(698, 231);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(180, 41);
            this.btnInvoices.TabIndex = 6;
            this.btnInvoices.Text = "Print Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            // 
            // btnTradesmenReport
            // 
            this.btnTradesmenReport.Location = new System.Drawing.Point(698, 294);
            this.btnTradesmenReport.Name = "btnTradesmenReport";
            this.btnTradesmenReport.Size = new System.Drawing.Size(180, 41);
            this.btnTradesmenReport.TabIndex = 7;
            this.btnTradesmenReport.Text = "Print Tradesmen Report";
            this.btnTradesmenReport.UseVisualStyleBackColor = true;
            // 
            // btnAssignMaterial
            // 
            this.btnAssignMaterial.Location = new System.Drawing.Point(500, 231);
            this.btnAssignMaterial.Name = "btnAssignMaterial";
            this.btnAssignMaterial.Size = new System.Drawing.Size(180, 41);
            this.btnAssignMaterial.TabIndex = 8;
            this.btnAssignMaterial.Text = "Assign Material";
            this.btnAssignMaterial.UseVisualStyleBackColor = true;
            this.btnAssignMaterial.Click += new System.EventHandler(this.btnAssignMaterial_Click);
            // 
            // btnRemoveMaterial
            // 
            this.btnRemoveMaterial.Location = new System.Drawing.Point(500, 294);
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.Size = new System.Drawing.Size(180, 41);
            this.btnRemoveMaterial.TabIndex = 9;
            this.btnRemoveMaterial.Text = "Remove Material";
            this.btnRemoveMaterial.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(400, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 41);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveMaterial);
            this.Controls.Add(this.btnAssignMaterial);
            this.Controls.Add(this.btnTradesmenReport);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.btnUpdateJob);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.btnUpdateProperty);
            this.Controls.Add(this.btnAddProperty);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Maintenance Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnUpdateProperty;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Button btnUpdateJob;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnTradesmenReport;
        private System.Windows.Forms.Button btnAssignMaterial;
        private System.Windows.Forms.Button btnRemoveMaterial;
        private System.Windows.Forms.Button btnExit;
    }
}

