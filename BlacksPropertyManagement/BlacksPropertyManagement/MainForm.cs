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
            frmPropertyAdd = new AddPropertyForm(DC, this);
            frmPropertyAdd.ShowDialog();

        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            frmJobAdd = new AddJobForm(DC, this);
            frmJobAdd.ShowDialog();
        }

        private void btnAssignMaterial_Click(object sender, EventArgs e)
        {
            frmMaterialAdd = new AssignMaterialForm(DC, this);
            frmMaterialAdd.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            frmInvoicesReport = new InvoicesForm(DC, this);
            frmInvoicesReport.ShowDialog();
        }

        private void btnUpdateProperty_Click(object sender, EventArgs e)
        {
            frmPropertyUpdate = new UpdatePropertyForm(DC, this);
            frmPropertyUpdate.ShowDialog();
        }

        private void btnUpdateJob_Click(object sender, EventArgs e)
        {
            frmJobUpdate = new UpdateJobForm(DC, this);
            frmJobUpdate.ShowDialog();
        }

        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            frmMaterialDelete = new RemoveMaterialForm(DC, this);
            frmMaterialDelete.ShowDialog();
        }

        private void btnTradesmenReport_Click(object sender, EventArgs e)
        {
            frmTradesmenReport = new TradesmenReportForm(DC, this);
            frmTradesmenReport.ShowDialog();
        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            frmPropertyDelete = new DeletePropertyForm(DC, this);
            frmPropertyDelete.ShowDialog();
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            frmJobDelete = new DeleteJobForm(DC, this);
            frmJobDelete.ShowDialog();
        }
    }
}
