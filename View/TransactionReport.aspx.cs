using Kpop_Ztation.Dataset;
using Kpop_Ztation.Handler;
using Kpop_Ztation.Model;
using Kpop_Ztation.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            KpopZtationDataset data = getData(TransactionHandler.getTransaction());
            report.SetDataSource(data);
        }

        private KpopZtationDataset getData(List<TransactionHeader> transaction)
        {
            KpopZtationDataset data = new KpopZtationDataset();
            var headerTable = data.TransactionHeader;
            var detailTable = data.TransactionDetail;
            
            int grandTotal = 0;
            
            foreach(TransactionHeader th in transaction)
            {
                var Header_Row = headerTable.NewRow();
                Header_Row["TransactionID"] = th.TransactionID;
                Header_Row["CustomerID"] = th.CustomerID;
                Header_Row["TransactionDate"] = th.TransactionDate;
                Header_Row["GrandTotal"] = grandTotal;
                headerTable.Rows.Add(Header_Row);

                int subTotal = 0;
                foreach (TransactionDetail td in th.TransactionDetails)
                {
                    var Detail_Row = detailTable.NewRow();
                    Detail_Row["TransactionID"] = td.TransactionID;
                    Detail_Row["AlbumName"] = td.Album.AlbumName;
                    Detail_Row["Qty"] = td.Qty;
                    Detail_Row["AlbumPrice"] = td.Qty * td.Album.AlbumPrice;
                    Detail_Row["SubTotal"] = subTotal;

                    subTotal += td.Qty * td.Album.AlbumPrice;
                    detailTable.Rows.Add(Detail_Row);
                }
                /*
                var subTotal_Row = detailTable.NewRow();
                subTotal_Row["SubTotal"] = subTotal;
                grandTotal += subTotal;
                detailTable.Rows.Add(subTotal_Row);
                */
            }
            /*
            var grandTotal_Row = headerTable.NewRow();
            grandTotal_Row["GrandTotal"] = grandTotal;
            headerTable.Rows.Add(grandTotal_Row);
            */
            return data;
        }
    }
}