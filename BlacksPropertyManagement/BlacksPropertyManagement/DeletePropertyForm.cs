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
    public partial class DeletePropertyForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmProperty;
        private CurrencyManager cmLandlord;


        public DeletePropertyForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }
        public void BindControls()
        {
            cmProperty = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "PROPERTY"];
            cmLandlord = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "LANDLORD"];
            txtPropertyID.DataBindings.Add("Text", DC.dsBlacksProperty, "Property.PropertyID");
            txtStreetAddress.DataBindings.Add("Text", DC.dsBlacksProperty, "Property.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DC.dsBlacksProperty, "Property.Suburb");
            dgvProperty.DataSource = DC.dsBlacksProperty;
            dgvProperty.DataMember = "PROPERTY";
        }

        public void ClearFields()
        {
            txtPropertyID.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void dgvProperty_Click(object sender, EventArgs e)
        {
            if (cmProperty.Position != -1)
            {
                DataRow drProperty = DC.dtProperty.Rows[cmProperty.Position];
                int anLandlordID = Convert.ToInt32(dgvProperty["LandlordID", cmProperty.Position].Value);
                cmLandlord.Position = DC.landlordView.Find(anLandlordID);
                DataRow drLandlord = DC.dtLandlord.Rows[cmLandlord.Position];
                txtLastName.Text = drLandlord["LandlordLastName"].ToString();
                txtFirstName.Text = drLandlord["LandlordFirstName"].ToString();
            }

        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            DataRow deletePropertyRow = DC.dtProperty.Rows[cmProperty.Position];
            DataRow[] drPropertyJobs = deletePropertyRow.GetChildRows(DC.dtProperty.ChildRelations["PROPERTY_JOB"]);
            if (drPropertyJobs.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Property?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deletePropertyRow.Delete();
                    DC.UpdateProperty();
                    MessageBox.Show("Property deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Propertys with repairs cannot be deleted", "Error");
            }

        }
    }
}
