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
    public partial class UpdateJobForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmJob;
        private CurrencyManager cmProperty;
        private CurrencyManager cmLandlord;
        private string jobStatus;


        public UpdateJobForm(DataController dc, MainForm mnu)
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
            cmProperty = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "PROPERTY"];
            cmLandlord = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "LANDLORD"];
            dgvJobs.DataSource = DC.dsBlacksProperty;
            dgvJobs.DataMember = "JOB";
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void UpdateJobForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();

        }

        private void dgvJobs_Click(object sender, EventArgs e)
        {
            if (cmJob.Position != -1)
            {
                DataRow drJob = DC.dtJob.Rows[cmJob.Position];
                txtJobID.Text = drJob["JobID"].ToString();
                txtDescription.Text = drJob["JobDescription"].ToString();
                nudFee.Value = Convert.ToInt32(drJob["JobFee"].ToString());
                dtpDate.Value = Convert.ToDateTime(drJob["JobDate"]);
                jobStatus = drJob["JobStatus"].ToString();
                if (jobStatus == "Current")
                {
                    rbnCurrent.Checked = true;
                    rbnPaid.Checked = false;
                }
                else
                {
                    rbnCurrent.Checked = false;
                    rbnPaid.Checked = true;
                }
                int aPropertyID = Convert.ToInt32(dgvJobs["PropertyID", cmJob.Position].Value);
                cmProperty.Position = DC.propertyView.Find(aPropertyID);
                DataRow drProperty = DC.dtProperty.Rows[cmProperty.Position];
                txtStreetAddress.Text = drProperty["StreetAddress"].ToString();
                txtSuburb.Text = drProperty["Suburb"].ToString();
                txtLandlordID.Text = drProperty["LandlordID"].ToString();
                int aLandlordID = Convert.ToInt32(drProperty["LandlordID"]);
                cmLandlord.Position = DC.landlordView.Find(aLandlordID);
                DataRow drLandlord = DC.dtLandlord.Rows[cmLandlord.Position];
                txtLastname.Text = drLandlord["LandlordLastName"].ToString();
                txtFirstname.Text = drLandlord["LandlordFirstName"].ToString();
            }

        }

        private void btnUpdateJob_Click(object sender, EventArgs e)
        {
            string newStatus;
            DataRow updateJobRow = DC.dtJob.Rows[cmJob.Position];
            if ((txtDescription.Text == "") || (nudFee.Text == "") ||
                (dtpDate.Value == null))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                if (jobStatus == "Current")
                {
                    updateJobRow["JobDescription"] = txtDescription.Text;
                    updateJobRow["JobFee"] = nudFee.Value;
                    updateJobRow["JobDate"] = dtpDate.Value;
                    if (rbnCurrent.Checked == true)
                    {
                        newStatus = "Current";
                    }
                    else
                    {
                        newStatus = "Paid";
                    }
                    updateJobRow["JobStatus"] = newStatus;
                    cmJob.EndCurrentEdit();
                    DC.UpdateJob();
                    MessageBox.Show("Job updated successfully", "Success");
                }
                else
                {
                    MessageBox.Show("Paid Jobs cannot be updated", "Error");
                }
            }

        }
    }
}
