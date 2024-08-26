
namespace BlacksPropertyManagement
{
    partial class TradesmenReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradesmenReportForm));
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printJobs = new System.Drawing.Printing.PrintDocument();
            this.prvJobs = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(54, 138);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(216, 70);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(329, 138);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(216, 70);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printJobs
            // 
            this.printJobs.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printJobs_PrintPage);
            // 
            // prvJobs
            // 
            this.prvJobs.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvJobs.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvJobs.ClientSize = new System.Drawing.Size(400, 300);
            this.prvJobs.Document = this.printJobs;
            this.prvJobs.Enabled = true;
            this.prvJobs.Icon = ((System.Drawing.Icon)(resources.GetObject("prvJobs.Icon")));
            this.prvJobs.Name = "prvJobs";
            this.prvJobs.Visible = false;
            // 
            // TradesmenReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrint);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TradesmenReportForm";
            this.Text = "Tradesmen Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printJobs;
        private System.Windows.Forms.PrintPreviewDialog prvJobs;
    }
}