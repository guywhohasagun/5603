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
    public partial class MainForm : Form
    {
        private DataController      DC;
        private AddJobForm          frmJobAdd;
        private AddPropertyForm     frmPropertyAdd;
        private AssignMaterialForm  frmMaterialAdd;
        private DeleteJobForm       frmJobDelete;
        private DeletePropertyForm  frmPropertyDelete;
        private InvoicesForm        frmInvoicesReport;
        private RemoveMaterialForm  frmMaterialDelete;
        private TradesmenReportForm frmTradesmenReport;
        private UpdateJobForm       frmJobUpdate;
        private UpdatePropertyForm  frmPropertyUpdate;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
   
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignMaterial_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
