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
    public partial class DeleteJobForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public DeleteJobForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();

        }
    }
}
