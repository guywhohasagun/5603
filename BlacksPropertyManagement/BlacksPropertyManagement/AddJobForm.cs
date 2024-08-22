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
    public partial class AddJobForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmLandlord;
        private CurrencyManager cmTradesman;
        private int propertyID;

        public AddJobForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            bindControls();
            loadLandlords();

        }

        private void loadLandlords()
        {
            string landlordText = "";
            foreach (DataRow drLandlord in DC.dtLandlord.Rows)
            {
                if (drLandlord["CreditStatus"].ToString() == "Valid")
                {
                    landlordText = drLandlord["LandlordID"] + ", ";
                    landlordText += drLandlord["LandlordLastName"] + ", ";
                    landlordText += drLandlord["LandlordFirstName"];
                    lstLandlord.Items.Add(landlordText);
                }
                
            }
        }

        private void bindControls()
        {
            cmLandlord = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "LANDLORD"];
            cmTradesman = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "TRADESMAN"];
            cboLastName.DataSource = DC.dsBlacksProperty;
            cboLastName.DisplayMember = "Tradesman.TradesmanLastName";
            cboLastName.ValueMember = "Tradesman.TradesmanLastName";
            cboFirstName.DataSource = DC.dsBlacksProperty;
            cboFirstName.DisplayMember = "Tradesman.TradesmanFirstName";
            cboFirstName.ValueMember = "Tradesman.TradesmanFirstName";
            cboTradesman.DataSource = DC.dsBlacksProperty;
            cboTradesman.DisplayMember = "Tradesman.TradesmanID";
            cboTradesman.ValueMember = "Tradesman.TradesmanID";
        }

        private void ClearFields()
        {
            txtDiscription.Text = "";
            nudFee.Value = 80;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            if (txtDiscription.Text == "" || nudFee.Text == "" || cboTradesman.Text == "")
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newJobRow = DC.dtJob.NewRow();
                newJobRow["JobDescription"] = txtDiscription.Text;
                newJobRow["JobFee"] = nudFee.Value;
                newJobRow["JobDate"] = dtpDate.Value;
                newJobRow["TradesmanID"] = cboTradesman.Text;
                newJobRow["JobStatus"] = "Current";
                newJobRow["PropertyID"] = propertyID;
                DC.dsBlacksProperty.Tables["JOB"].Rows.Add(newJobRow);
                DC.UpdateProperty();
                MessageBox.Show("Repair added successfully", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void lstLandlord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLandlord.SelectedItem != null)
            {
                string landlord, propertyText = "";
                lstProperty.Items.Clear();
                landlord = lstLandlord.SelectedItem.ToString();
                string[] parts = landlord.Split(',');
                int landlordID = Convert.ToInt32(parts[0]);
                cmLandlord.Position = DC.landlordView.Find(landlordID);
                DataRow drLandlord = DC.dtLandlord.Rows[cmLandlord.Position];
                DataRow[] drPropertys = drLandlord.GetChildRows(DC.dtLandlord.ChildRelations["LANDLORD_PROPERTY"]);
                foreach (DataRow drProperty in drPropertys)
                {
                    propertyText = drProperty["PropertyID"] + ", " + drProperty["StreetAddress"].ToString() + ", " + drProperty["Suburb"].ToString();
                    lstProperty.Items.Add(propertyText);
                }

            }
        }

        private void lstProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProperty.SelectedItem != null)
            {
                string property = lstProperty.SelectedItem.ToString();
                string[] parts = property.Split(',');
                propertyID = Convert.ToInt32(parts[0]);
            }
        }
    }
}
