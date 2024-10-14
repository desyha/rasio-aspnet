using RAiso.Dataset;
using RAiso.Handler;
using RAiso.Models;
using RAiso.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 d = GetData(TransactionHandler.GetTransactionsData());
            report.SetDataSource(d);
         
        }

        private DataSet1 GetData(List<TransactionHeader> tr)
        {
            DataSet1 ds = new DataSet1();
            var headerTable = ds.TransactionHeader;
            var detailTable = ds.TransactionDetail;

            int grand = 0;
            foreach (TransactionHeader t in tr)
            {
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = t.TansactionId;
                hrow["User_id"] = t.UserId;
                hrow["Transaction_Date"] = t.TransactionDate;

                int total = 0;
               
                foreach (TransactionDetail d in t.TransactionDetails)
                {
                    MsStationery m = TransactionHandler.GetStationeryData((int)d.StationeryId).FirstOrDefault();
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = d.TransactionId;
                    drow["StationeryName"] = m.StationeryName;
                    drow["Quantity"] = d.Quantity;
                    drow["Price"] = m.StationeryPrice;
                    total += d.Quantity * m.StationeryPrice;
                    drow["Sub_Total"] = d.Quantity * m.StationeryPrice;
                    detailTable.Rows.Add(drow);
                }
                hrow["Grand Total Value"] = total;
                grand += total;
                headerTable.Rows.Add(hrow);
            }
            return ds;
        }

    }
}