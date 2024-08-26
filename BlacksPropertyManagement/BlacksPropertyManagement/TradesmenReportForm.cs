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
    public partial class TradesmenReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private int amountOfTradesmanPrinted, pagesAmountExpected;
        private DataRow[] tradesmanForPrint;


        public TradesmenReportForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();

        }

        private void printJobs_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            int linesSoFar = 0;

            Font textFont = new Font("Courier New", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Courier New", 10, FontStyle.Regular);
            Font headingFont = new Font("Courier New", 16, FontStyle.Bold);

            DataRow drTradesman = tradesmanForPrint[amountOfTradesmanPrinted];

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

            string headingText = "Black's Property Management";

            int centre = (e.PageBounds.Width - headingText.Length) / 2;

            g.DrawString(headingText, headingFont, brush, centre - leftMargin, topMargin + headingFont.Height * linesSoFar);

            linesSoFar++;

            headingText = "     Tradesmen Report      ";

            g.DrawString(headingText, headingFont, brush, centre - leftMargin, topMargin + headingFont.Height * linesSoFar);
            linesSoFar = linesSoFar + 2;

            linesSoFar = linesSoFar + 3;

            g.DrawString("Tradesman ID: " + drTradesman["TradesmanID"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            linesSoFar++;
            g.DrawString("Name: " + drTradesman["TradesmanLastName"] + ", " + drTradesman["TradesmanFirstName"] + "             Fee:  $" + drTradesman["Fee"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            linesSoFar++;
            g.DrawString("Phone number " + drTradesman["PhoneNumber"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));

            DataRow[] drTradesmans = drTradesman.GetChildRows(DC.dtTradesman.ChildRelations["TRADESMANJOB"]);

            linesSoFar = linesSoFar + 2;

            if (drTradesmans.Length == 0)
            {
                g.DrawString("This Trademan has no jobs assigned currently", textFont, brush,
                               leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            }
            else
            {
                foreach (DataRow drJobs in drTradesmans)
                {
                    int aPropertyID = Convert.ToInt32(drJobs["PropertyID"]);
                    cmProperty.Position = DC.propertyView.Find(aPropertyID);
                    DataRow drProperty = DC.dtProperty.Rows[cmProperty.Position];

                    g.DrawString("Job ID: " + drJobs["JobID"] + "        Date: " + drJobs["JobDate"] + "        Job Status: " + drJobs["JobStatus"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar *
                                             textFont.Height));
                    linesSoFar++;

                    g.DrawString("Description: " + drJobs["JobDescription"] + "        Fee: $" + drJobs["JobFee"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));

                    linesSoFar = linesSoFar + 2;

                    g.DrawString("Property ID:" + drProperty["PropertyID"] + "   Address: " + drProperty["StreetAddress"] + ", " + drProperty["Suburb"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));

                    linesSoFar++;

                    g.DrawString("Year Built: " + drProperty["YearBuilt"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));

                    linesSoFar = linesSoFar + 2;

                    double materialsTotal = 0;

                    g.DrawString("ID  Description    Cost     Quantity        Price", textFont, brush,
                                               leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;

                    DataRow[] drJobMaterials = drJobs.GetChildRows(DC.dtJob.ChildRelations["JOB_JOBMATERIAL"]);
                                
                                
                    if (drJobMaterials.Length == 0)
                    {
                        g.DrawString("This Job has no Materials assigned currently", textFont, brush,
                               leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
                    }
                    else
                    {
                        foreach (DataRow drJobMaterial in drJobMaterials)
                        {
                            int aMaterialID = Convert.ToInt32(drJobMaterial["MaterialID"]);
                            cmMaterial.Position = DC.materialView.Find(aMaterialID);
                            DataRow drMaterial = DC.dtMaterial.Rows[cmMaterial.Position];
                            string materialText = "";
                            double materialPrice = Convert.ToDouble(drMaterial["Cost"]) * Convert.ToInt32(drJobMaterial["Quantity"]);
                            materialsTotal += materialPrice;
                            materialText = drJobMaterial["MaterialID"].ToString() + "  " + drMaterial["MaterialDescription"] + "    $" + drMaterial["Cost"] + "     " + drJobMaterial["Quantity"] + "       $" + string.Format("{0:#,##0.00}", materialPrice);
                            g.DrawString(materialText, textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
                            linesSoFar++;
                        }
                    }
                    linesSoFar = linesSoFar + 3;
                }
            }

            amountOfTradesmanPrinted++;
            if (!(amountOfTradesmanPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu.Show();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            amountOfTradesmanPrinted = 0;
            string strFilter = "";
            string strSort = "TradesmanID";
            tradesmanForPrint = DC.dsBlacksProperty.Tables["TRADESMAN"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = tradesmanForPrint.Length;
            prvJobs.Show();

        }
    }
}
