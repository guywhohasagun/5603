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
    public partial class AddPropertyForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public AddPropertyForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }

        private void LoadLandlord()
        {
            cboLastName.DataSource = DC.dsBlacksProperty;
            cboLastName.DisplayMember = "Landlord.LandlordLastName";
            cboLastName.ValueMember = "Landlord.LandlordLastName";
            cboFirstName.DataSource = DC.dsBlacksProperty;
            cboFirstName.DisplayMember = "Landlord.LandlordFirstName";
            cboFirstName.ValueMember = "Landlord.LandlordFirstName";
            cboLandlord.DataSource = DC.dsBlacksProperty;
            cboLandlord.DisplayMember = "Landlord.LandlordID";
            cboLandlord.ValueMember = "Landlord.LandlordID";
        }

        private void clearFields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtLandlordStreetAddress.Text = "";
            txtLandlordSuburb.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            nudYearBuilt.Value = 2020;
            cboStatus.Text = "Occupied";
        }

        public void BindControls()
        {
            txtLastName.DataBindings.Add("Text", DC.dsBlacksProperty, "Landlord.LandlordLastName");
            txtFirstName.DataBindings.Add("Text", DC.dsBlacksProperty, "Landlord.LandlordFirstName");
            txtLandlordStreetAddress.DataBindings.Add("Text", DC.dsBlacksProperty, "Landlord.StreetAddress");
            txtLandlordSuburb.DataBindings.Add("Text", DC.dsBlacksProperty, "Landlord.Suburb");
            currencyManager = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "LANDLORD"];
        }
        private void AddPropertyForm_Load(object sender, EventArgs e)
        {
            LoadLandlord();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (txtStreetAddress.Text == "" || txtSuburb.Text == "" || cboStatus.Text == "")
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newPropertyRow = DC.dtProperty.NewRow();
                newPropertyRow["StreetAddress"] = txtStreetAddress.Text;
                newPropertyRow["Suburb"] = txtSuburb.Text;
                newPropertyRow["Status"] = cboStatus.Text;
                newPropertyRow["YearBuilt"] = nudYearBuilt.Text;
                newPropertyRow["LandlordID"] = cboLandlord.Text;
                DC.dsBlacksProperty.Tables["PROPERTY"].Rows.Add(newPropertyRow);
                DC.UpdateProperty();
                MessageBox.Show("Property added successfully", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
        }
    }
}
