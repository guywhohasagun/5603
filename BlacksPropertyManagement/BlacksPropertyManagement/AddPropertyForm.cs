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
        private CurrencyManager currency;

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

        private void AddPropertyForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
