using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlacksPropertyManagement
{
    public partial class DeleteJobForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmJob;

        public DeleteJobForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();

        }
        public void BindControls()
        {
            cmJob = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "JOB"];

            txtJobID.DataBindings.Add("Text", DC.dsBlacksProperty, "Job.JobID");
            txtDescription.DataBindings.Add("Text", DC.dsBlacksProperty, "Job.JobDescription");
            txtFee.DataBindings.Add("Text", DC.dsBlacksProperty, "Job.JobFee");
            txtDate.DataBindings.Add("Text", DC.dsBlacksProperty, "Job.JobDate");
            txtStatus.DataBindings.Add("Text", DC.dsBlacksProperty, "Job.JobStatus");
            dgvJob.DataSource = DC.dsBlacksProperty;
            dgvJob.DataMember = "JOB";
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            DataRow deleteJobRow = DC.dtJob.Rows[cmJob.Position];
            if (deleteJobRow["JobStatus"].ToString() == "Paid")
            {
                if (MessageBox.Show("Are you sure you want to delete this Job?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataRow[] drJobMaterials = deleteJobRow.GetChildRows(DC.dtJob.ChildRelations["JOB_JOBMATERIAL"]);
                    foreach (DataRow drJobMaterial in drJobMaterials)
                    {
                        drJobMaterial.Delete();
                    }
                    DC.UpdateJob();
                    deleteJobRow.Delete();
                    DC.UpdateJob();
                    MessageBox.Show("Job deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Current job cannot be deleted", "Error");
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();

        }
    }
}
