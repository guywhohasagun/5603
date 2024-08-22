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
    public partial class UpdatePropertyForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmProperty;
        private CurrencyManager cmLandlord;


        public UpdatePropertyForm(DataController dc, MainForm mnu)
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
            dvgProperty.DataSource = DC.dsBlacksProperty;
            dvgProperty.DataMember = "PROPERTY";
        }

        private void dvgProperty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudYearBuilt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void dvgProperty_Click(object sender, EventArgs e)
        {
            if (cmProperty.Position != -1)
            {
                txtProperty.Text = dvgProperty["PropertyID", cmProperty.Position].Value.ToString();
                txtStreetAddress.Text = dvgProperty["StreetAddress", cmProperty.Position].Value.ToString();
                txtSuburb.Text = dvgProperty["Suburb", cmProperty.Position].Value.ToString();
                cboStatus.Text = dvgProperty["Status", cmProperty.Position].Value.ToString();
                nudYearBuilt.Value = Convert.ToInt32(dvgProperty["YearBuilt", cmProperty.Position].Value);
                int anLandlordID = Convert.ToInt32(dvgProperty["LandlordID", cmProperty.Position].Value);
                cmProperty.Position = DC.landlordView.Find(anLandlordID);
                DataRow drLandlord = DC.dtLandlord.Rows[cmProperty.Position];
                txtLastname.Text = drLandlord["LandlordLastName"].ToString();
                txtFirstname.Text = drLandlord["LandlordFirstName"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow updatePropertyRow = DC.dtProperty.Rows[cmProperty.Position];
            if ((txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (nudYearBuilt.Text == "") ||
                (cboStatus.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error");
            }
            else
            {
                updatePropertyRow["StreetAddress"] = txtStreetAddress.Text;
                updatePropertyRow["Suburb"] = txtSuburb.Text;
                updatePropertyRow["YearBuilt"] = nudYearBuilt.Value;
                updatePropertyRow["Status"] = cboStatus.Text;
                cmProperty.EndCurrentEdit();
                DC.UpdateProperty();
                MessageBox.Show("Property updated successfully", "Success");
            }

        }
    }
}
