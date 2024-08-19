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
        }
    }
}
