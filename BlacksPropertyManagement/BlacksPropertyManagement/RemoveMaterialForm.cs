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
    public partial class RemoveMaterialForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public RemoveMaterialForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();

        }
    }
}
