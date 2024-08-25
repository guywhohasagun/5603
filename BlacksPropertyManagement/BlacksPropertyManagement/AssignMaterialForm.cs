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
    public partial class AssignMaterialForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmMaterial;
        private CurrencyManager cmJob;
        private CurrencyManager cmJobMaterial;


        public AssignMaterialForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();

        }
        public void BindControls()
        {
            cmMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "MATERIAL"];
            cmJob = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "JOB"];
            cmJobMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "JOB.JOB_JOBMATERIAL"];

            dgvMaterial.DataSource = DC.dsBlacksProperty;
            dgvMaterial.DataMember = "MATERIAL";
            dgvJobs.DataSource = DC.dsBlacksProperty;
            dgvJobs.DataMember = "JOB";
            dgvJobMaterial.DataSource = DC.dsBlacksProperty;
            dgvJobMaterial.DataMember = "JOB.JOB_JOBMATERIAL";
        }

        private void btnAssignMaterial_Click(object sender, EventArgs e)
        {
            if ((dgvJobs["JobStatus", cmJob.Position].Value).ToString() == "Current")
            {
                try
                {
                    DataRow newJobItem = DC.dtJobMaterial.NewRow();
                    newJobItem["JobID"] = dgvJobs["JobID", cmJob.Position].Value;
                    newJobItem["MaterialID"] = dgvMaterial["MaterialID", cmMaterial.Position].Value;
                    newJobItem["Quantity"] = nudQuantity.Value;
                    DC.dsBlacksProperty.Tables["JobMaterial"].Rows.Add(newJobItem);
                    DC.UpdateJobMaterial();
                    MessageBox.Show("Material assigned to job", "Acknowledgement", MessageBoxButtons.OK);
                }
                catch (System.Data.ConstraintException)
                {
                    MessageBox.Show("Material is already assigned to that job.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Cannot assign materials to a paid repair.", "Error");
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();

        }
    }
}
