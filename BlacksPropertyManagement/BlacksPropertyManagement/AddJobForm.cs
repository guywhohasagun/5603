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

        private void loadOwners()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
