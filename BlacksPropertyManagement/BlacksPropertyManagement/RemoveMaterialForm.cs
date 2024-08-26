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
    public partial class RemoveMaterialForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmMaterial;
        private CurrencyManager cmJob;
        private CurrencyManager cmJobMaterial;
        private CurrencyManager cmJob_JobMaterial;


        public RemoveMaterialForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();

        }

        public void BindControls()
        {
            cmMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "MATERIAL"];
            cmJob = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "JOB"];
            cmJobMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "JOBMATERIAL"];
            cmJob_JobMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "JOB.JOB_JOBMATERIAL"];
            dgvJob.DataMember = "JOB";
            dgvJob.DataSource = DC.dsBlacksProperty;
            dgvJobMaterial.DataSource = DC.dsBlacksProperty;
            dgvJobMaterial.DataMember = "JOB.JOB_JOBMATERIAL";
        }

        public void ClearFields()
        {
            txtDescription.Text = "";
            txtCost.Text = "";
        }


        private void RemoveMaterialForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if ((dgvJob["JobStatus", cmJob.Position].Value).ToString() == "Current")
            {
                int aJobID = Convert.ToInt32(dgvJobMaterial["JobID", cmJob_JobMaterial.Position].Value);
                int aMaterialID = Convert.ToInt32(dgvJobMaterial["MaterialID", cmJob_JobMaterial.Position].Value);
                object[] primaryKey = new object[2];
                primaryKey[0] = aJobID;
                primaryKey[1] = aMaterialID;
                cmJobMaterial.Position = DC.jobMaterialView.Find(primaryKey);
                DataRow deleteJobMaterialRow = DC.dtJobMaterial.Rows[cmJobMaterial.Position];
                deleteJobMaterialRow.Delete();
                DC.UpdateJobMaterial();
                MessageBox.Show("Material removed successfully", "Acknowledgement", MessageBoxButtons.OK);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Cannot remove materials from a paid repair.", "Error");
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void dgvJobMaterial_Click(object sender, EventArgs e)
        {
            int aMaterialID = Convert.ToInt32(dgvJobMaterial["MaterialID", cmJob_JobMaterial.Position].Value);
            cmMaterial.Position = DC.materialView.Find(aMaterialID);
            DataRow drMaterial = DC.dtMaterial.Rows[cmMaterial.Position];
            txtDescription.Text = drMaterial["MaterialDescription"].ToString();
            txtCost.Text = drMaterial["Cost"].ToString();
        }
    }
}
