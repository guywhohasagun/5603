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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
    }
}
