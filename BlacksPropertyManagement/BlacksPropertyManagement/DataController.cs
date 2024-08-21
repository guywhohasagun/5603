using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BlacksPropertyManagement
{
    public partial class DataController : Form
    {
        public DataTable dtProperty;
        public DataTable dtTradesman;
        public DataTable dtMaterial;
        public DataTable dtLandlord;
        public DataTable dtJob;
        public DataTable dtJobMaterial;
        public DataView propertyView;
        public DataView tradesmanView;
        public DataView materialView;
        public DataView landlordView;
        public DataView jobView;
        public DataView jobMaterialView;

        public DataController()
        {
            InitializeComponent();
            dsBlacksProperty.EnforceConstraints = false;
            daProperty.Fill(dsBlacksProperty);
            daTradesman.Fill(dsBlacksProperty);
            daMaterial.Fill(dsBlacksProperty);
            daLandlord.Fill(dsBlacksProperty);
            daJob.Fill(dsBlacksProperty);
            daJobMaterial.Fill(dsBlacksProperty);
            dtProperty = dsBlacksProperty.Tables["PROPERTY"];
            dtTradesman = dsBlacksProperty.Tables["TRADESMAN"];
            dtMaterial = dsBlacksProperty.Tables["MATERIAL"];
            dtLandlord = dsBlacksProperty.Tables["LANDLORD"];
            dtJob = dsBlacksProperty.Tables["JOB"];
            dtJobMaterial = dsBlacksProperty.Tables["JOBMATERIAL"];
            propertyView = new DataView(dtProperty);
            propertyView.Sort = "PropertyID";
            tradesmanView = new DataView(dtTradesman);
            tradesmanView.Sort = "TradesmanID";
            materialView = new DataView(dtMaterial);
            materialView.Sort = "MaterialID";
            landlordView = new DataView(dtLandlord);
            landlordView.Sort = "LandlordID";
            jobView = new DataView(dtJob);
            jobView.Sort = "JobID";
            jobMaterialView = new DataView(dtJobMaterial);
            jobMaterialView.Sort = "JobID,MaterialID";
            dsBlacksProperty.EnforceConstraints = true;
            

        }
        public void UpdateProperty()
        {
            daProperty.Update(dsBlacksProperty, "Property");
        }

        private void daProperty_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBlackProperty);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["PropertyID"] = newID;
            }

        }
    }
}
