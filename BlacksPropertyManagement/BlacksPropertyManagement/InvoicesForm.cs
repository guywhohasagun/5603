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
    public partial class InvoicesForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private int amountOfInvoicesPrinted, pagesAmountExpected;
        private DataRow[] invoicesForPrint;
        private int linesSoFar;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            amountOfInvoicesPrinted = 0;
            string strFilter = "JobStatus = 'Current'";
            string strSort = "JobID";
            invoicesForPrint = DC.dsBlacksProperty.Tables["JOB"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = invoicesForPrint.Length;
            prvInvoices.Show();

        }

        private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            linesSoFar = 0;
            Font textFont = new Font("Courier New", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Courier New", 10, FontStyle.Regular);
            Font headingFont = new Font("Courier New", 16, FontStyle.Bold);
            DataRow drJob = invoicesForPrint[amountOfInvoicesPrinted];
            CurrencyManager cmProperty, cmLandlord, cmTradesman, cmMaterial;
            cmProperty = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "PROPERTY"];
            cmTradesman = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "TRADESMAN"];
            cmLandlord = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "LANDLORD"];
            cmMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacksProperty, "MATERIAL"];
            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            double jobTotal = 0;
            jobTotal += Convert.ToDouble(drJob["JobFee"]);
            string headingText = "Black's Property Management";
            int centre = (e.PageBounds.Width - headingText.Length) / 2;
            g.DrawString(headingText, headingFont, brush, centre - leftMargin, topMargin + headingFont.Height * linesSoFar);
            linesSoFar++;
            headingText = "         Invoice      ";
            g.DrawString(headingText, headingFont, brush, centre - leftMargin, topMargin + headingFont.Height * linesSoFar);
            linesSoFar = linesSoFar + 2;
            string jobText = "";
            int aPropertyID = Convert.ToInt32(drJob["PropertyID"]);
            cmProperty.Position = DC.propertyView.Find(aPropertyID);
            DataRow drProperty = DC.dtProperty.Rows[cmProperty.Position];
            int aLandlordID = Convert.ToInt32(drProperty["LandlordID"]);
            cmLandlord.Position = DC.landlordView.Find(aPropertyID);
            DataRow drLandlord = DC.dtLandlord.Rows[cmLandlord.Position];
            linesSoFar++;

            g.DrawString(drLandlord["LandlordFirstName"] + " " + drLandlord["LandlordLastName"], textFont, brush, leftMargin + headingLeftMargin,
                         topMargin + (linesSoFar * textFont.Height));
            linesSoFar++;
            g.DrawString(drLandlord["StreetAddress"].ToString(), textFont, brush, leftMargin + headingLeftMargin, topMargin +
                            (linesSoFar * textFont.Height));
            linesSoFar++;
            g.DrawString(drLandlord["Suburb"].ToString(), textFont, brush, leftMargin + headingLeftMargin, topMargin +
                            (linesSoFar * textFont.Height));
            linesSoFar = linesSoFar + 2;
            g.DrawString("Landlord ID: " + drLandlord["LandlordID"].ToString(), textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                       (linesSoFar * textFont.Height));
            linesSoFar = linesSoFar + 2;
            jobText = "Job ID: " + drJob["JobID"] + "                                                   Job Date: " +
                        ((DateTime)drJob["JobDate"]).ToShortDateString();
            g.DrawString(jobText, textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                       (linesSoFar * textFont.Height));
            linesSoFar = linesSoFar + 2;
            string propertyText = "";
            propertyText = "Property ID: " + drProperty["PropertyID"]
                                      + "    Address: " + drProperty["StreetAddress"] + ", " + drProperty["Suburb"];
            g.DrawString(propertyText, textFont, brush, leftMargin + headingLeftMargin, topMargin +
                            (linesSoFar * textFont.Height));
            linesSoFar = linesSoFar + 2;
            int aTradesmanID = Convert.ToInt32(drJob["TradesmanID"]);
            cmTradesman.Position = DC.tradesmanView.Find(aTradesmanID);
            DataRow drTradesman = DC.dtTradesman.Rows[cmTradesman.Position];
            g.DrawString("Tradesman: " + drTradesman["TradesmanFirstName"] + " " +
                           drTradesman["TradesmanLastName"] + "          $" + string.Format("{0:#,##0.00}", drTradesman["Fee"]),
                           textFont, brush, leftMargin + headingLeftMargin, topMargin +
                           (linesSoFar * textFont.Height));
            jobTotal += Convert.ToDouble(drTradesman["Fee"]);



            linesSoFar = linesSoFar + 1;

            jobText = "Description: " + drJob["JobDescription"] +
                      "             $" + string.Format("{0:#,##0.00}", drJob["JobFee"]);
            g.DrawString(jobText, textFont, brush, leftMargin + headingLeftMargin, topMargin +
                               (linesSoFar * textFont.Height));
            linesSoFar = linesSoFar + 2;

            g.DrawString("Materials:", textFont, brush,
                               leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            linesSoFar = linesSoFar + 1;
            g.DrawString("ID  Description    Cost     Quantity        Price", textFont, brush,
                               leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            linesSoFar = linesSoFar + 1;
            DataRow[] drJobMaterials = drJob.GetChildRows(DC.dtJob.ChildRelations["JOB_JOBMATERIAL"]);
            if (drJobMaterials.Length == 0)
            {
                g.DrawString("This job has no materials assigned currently", textFont, brush,
                               leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            }
            else
            {
                double materialsTotal = 0;
                foreach (DataRow drJobMaterial in drJobMaterials)
                {
                    int aMaterialID = Convert.ToInt32(drJobMaterial["MaterialID"]);
                    cmMaterial.Position = DC.materialView.Find(aMaterialID);
                    DataRow drMaterial = DC.dtMaterial.Rows[cmMaterial.Position];
                    string materialText = "";
                    double materialPrice = Convert.ToDouble(drMaterial["Cost"]) * Convert.ToInt32(drJobMaterial["Quantity"]);
                    materialsTotal += materialPrice;
                    materialText = drJobMaterial["MaterialID"].ToString() + "  " + drMaterial["MaterialDescription"] + "    $" + drMaterial["Cost"] +
                            "     " + drJobMaterial["Quantity"] + "       $" + string.Format("{0:#,##0.00}", materialPrice);
                    g.DrawString(materialText, textFont, brush, leftMargin + headingLeftMargin,
                                 topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;
                }
                jobTotal += materialsTotal;
                g.DrawString("Materials Total: $" + string.Format("{0:#,##0.00}", materialsTotal), textFont, brush, leftMargin +
                               headingLeftMargin + 300, topMargin + (linesSoFar * textFont.Height));
            }
            linesSoFar = linesSoFar + 3;
            g.DrawString("Job Total: $" + string.Format("{0:#,##0.00}", jobTotal), textFont, brush, leftMargin +
                            headingLeftMargin + 300, topMargin + (linesSoFar * textFont.Height));

            amountOfInvoicesPrinted++;
            if (!(amountOfInvoicesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();

        }

        public InvoicesForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();

        }
    }
}
