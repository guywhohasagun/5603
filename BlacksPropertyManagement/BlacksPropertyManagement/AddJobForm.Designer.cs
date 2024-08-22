
namespace BlacksPropertyManagement
{
    partial class AddJobForm
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
            this.lblSelectLandlord = new System.Windows.Forms.Label();
            this.lstLandlord = new System.Windows.Forms.ListBox();
            this.lstProperty = new System.Windows.Forms.ListBox();
            this.lblDiscription = new System.Windows.Forms.Label();
            this.cboTradesman = new System.Windows.Forms.ComboBox();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.cboFirstName = new System.Windows.Forms.ComboBox();
            this.cboLastName = new System.Windows.Forms.ComboBox();
            this.lblSelectProperty = new System.Windows.Forms.Label();
            this.lblTradesman = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.nudFee = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectLandlord
            // 
            this.lblSelectLandlord.AutoSize = true;
            this.lblSelectLandlord.Location = new System.Drawing.Point(43, 24);
            this.lblSelectLandlord.Name = "lblSelectLandlord";
            this.lblSelectLandlord.Size = new System.Drawing.Size(158, 24);
            this.lblSelectLandlord.TabIndex = 0;
            this.lblSelectLandlord.Text = "Select a Landlord:";
            // 
            // lstLandlord
            // 
            this.lstLandlord.FormattingEnabled = true;
            this.lstLandlord.ItemHeight = 24;
            this.lstLandlord.Location = new System.Drawing.Point(47, 51);
            this.lstLandlord.Name = "lstLandlord";
            this.lstLandlord.Size = new System.Drawing.Size(910, 100);
            this.lstLandlord.TabIndex = 1;
            this.lstLandlord.SelectedIndexChanged += new System.EventHandler(this.lstLandlord_SelectedIndexChanged);
            // 
            // lstProperty
            // 
            this.lstProperty.FormattingEnabled = true;
            this.lstProperty.ItemHeight = 24;
            this.lstProperty.Location = new System.Drawing.Point(47, 229);
            this.lstProperty.Name = "lstProperty";
            this.lstProperty.Size = new System.Drawing.Size(910, 100);
            this.lstProperty.TabIndex = 3;
            this.lstProperty.SelectedIndexChanged += new System.EventHandler(this.lstProperty_SelectedIndexChanged);
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.Location = new System.Drawing.Point(43, 378);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(142, 24);
            this.lblDiscription.TabIndex = 2;
            this.lblDiscription.Text = "Job Description:";
            // 
            // cboTradesman
            // 
            this.cboTradesman.FormattingEnabled = true;
            this.cboTradesman.Location = new System.Drawing.Point(191, 428);
            this.cboTradesman.Name = "cboTradesman";
            this.cboTradesman.Size = new System.Drawing.Size(120, 32);
            this.cboTradesman.TabIndex = 4;
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(191, 375);
            this.txtDiscription.MaxLength = 100;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(766, 32);
            this.txtDiscription.TabIndex = 5;
            // 
            // cboFirstName
            // 
            this.cboFirstName.FormattingEnabled = true;
            this.cboFirstName.Location = new System.Drawing.Point(649, 428);
            this.cboFirstName.Name = "cboFirstName";
            this.cboFirstName.Size = new System.Drawing.Size(308, 32);
            this.cboFirstName.TabIndex = 6;
            // 
            // cboLastName
            // 
            this.cboLastName.FormattingEnabled = true;
            this.cboLastName.Location = new System.Drawing.Point(326, 428);
            this.cboLastName.Name = "cboLastName";
            this.cboLastName.Size = new System.Drawing.Size(308, 32);
            this.cboLastName.TabIndex = 7;
            // 
            // lblSelectProperty
            // 
            this.lblSelectProperty.AutoSize = true;
            this.lblSelectProperty.Location = new System.Drawing.Point(43, 202);
            this.lblSelectProperty.Name = "lblSelectProperty";
            this.lblSelectProperty.Size = new System.Drawing.Size(156, 24);
            this.lblSelectProperty.TabIndex = 8;
            this.lblSelectProperty.Text = "Select a Property:";
            // 
            // lblTradesman
            // 
            this.lblTradesman.AutoSize = true;
            this.lblTradesman.Location = new System.Drawing.Point(78, 431);
            this.lblTradesman.Name = "lblTradesman";
            this.lblTradesman.Size = new System.Drawing.Size(107, 24);
            this.lblTradesman.TabIndex = 9;
            this.lblTradesman.Text = "Tradesman:";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(108, 485);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(77, 24);
            this.lblFee.TabIndex = 10;
            this.lblFee.Text = "Job Fee:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(98, 543);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 24);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Job Date:";
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(47, 586);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(155, 64);
            this.btnAddJob.TabIndex = 12;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(802, 586);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(155, 64);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // nudFee
            // 
            this.nudFee.DecimalPlaces = 2;
            this.nudFee.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudFee.Location = new System.Drawing.Point(191, 483);
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
            this.nudFee.Size = new System.Drawing.Size(120, 32);
            this.nudFee.TabIndex = 14;
            this.nudFee.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(191, 537);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 32);
            this.dtpDate.TabIndex = 15;
            // 
            // AddJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.nudFee);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblTradesman);
            this.Controls.Add(this.lblSelectProperty);
            this.Controls.Add(this.cboLastName);
            this.Controls.Add(this.cboFirstName);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.cboTradesman);
            this.Controls.Add(this.lstProperty);
            this.Controls.Add(this.lblDiscription);
            this.Controls.Add(this.lstLandlord);
            this.Controls.Add(this.lblSelectLandlord);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddJobForm";
            this.Text = "AddJob";
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectLandlord;
        private System.Windows.Forms.ListBox lstLandlord;
        private System.Windows.Forms.ListBox lstProperty;
        private System.Windows.Forms.Label lblDiscription;
        private System.Windows.Forms.ComboBox cboTradesman;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.ComboBox cboFirstName;
        private System.Windows.Forms.ComboBox cboLastName;
        private System.Windows.Forms.Label lblSelectProperty;
        private System.Windows.Forms.Label lblTradesman;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.NumericUpDown nudFee;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}