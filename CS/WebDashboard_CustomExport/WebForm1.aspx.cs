using System;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;
using AspProject;
using System.IO;
using System.Data;
using System.Web.Helpers;

namespace Dashboard_SetParameterValues_Web {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, 
            ConfigureDataConnectionWebEventArgs e) {
            if (e.DataSourceName == "SQL Data Source 1") {
                // Gets connection parameters used to establish a connection to the database.
                Access97ConnectionParameters parameters =
                    (Access97ConnectionParameters)e.ConnectionParameters;
                string databasePath = Server.MapPath("App_Data/nwind.mdb");

                // Specifies the path to a database file.                    
                parameters.FileName = databasePath;
            }
        }

        protected void ASPxButton1_Click(object sender, EventArgs e) {
            dynamic result = Json.Decode(this.Request["__EVENTARGUMENT"]);
            DataTable table = CreateTable(result);
            TableReport1 tableResport = new TableReport1(table, result.Parameters);
            using (MemoryStream stream = new MemoryStream()) {
                tableResport.ExportToXls(stream);
                Response.Clear();
                Response.Buffer = false;
                Response.AppendHeader("Content-Type", "application/ms-excel");
                Response.AppendHeader("Content-Transfer-Encoding", "binary");
                Response.AppendHeader("Content-Disposition", "attachment; filename=ItemData.xls");
                Response.BinaryWrite(stream.GetBuffer());
                Response.End();
            }
        }
        protected void ASPxButton2_Click(object sender, EventArgs e) {
            dynamic result = Json.Decode(this.Request["__EVENTARGUMENT"]);
            DataTable table = CreatePivotTable(result);
            PivotReport1 pivotReport = new PivotReport1(table, result.Parameters);
            PivotReportBestFitHelper.InitReport(pivotReport);
            using (MemoryStream stream = new MemoryStream()) {
                pivotReport.ExportToXls(stream);
                Response.Clear();
                Response.Buffer = false;
                Response.AppendHeader("Content-Type", "application/ms-excel");
                Response.AppendHeader("Content-Transfer-Encoding", "binary");
                Response.AppendHeader("Content-Disposition", "attachment; filename=ItemData.xls");
                Response.BinaryWrite(stream.GetBuffer());
                Response.End();
            }
        }

        private static DataTable CreatePivotTable(dynamic result) {
            DataTable table = new DataTable();

            for (int i = 0; i <= result.D[0].Length - 1; i++) {
                table.Columns.Add(new DataColumn("C" + i, typeof(object)));
            }

            for (int i = 0; i <= result.D.Length - 1; i++) {
                DataRow dataRow = table.NewRow();
                for (int j = 0; j <= result.D[i].Length - 1; j++) {
                    dataRow[j] = result.D[i][j];
                }
                table.Rows.Add(dataRow);
            }
            return table;
        }

        private static DataTable CreateTable(dynamic result) {
            DataTable table = new DataTable();

            foreach (var cell in result.D[0])
                table.Columns.Add(new DataColumn(Convert.ToString(cell), typeof(object)));

            for (int i = 1; i < result.D.Length; i++) {

                DataRow dataRow = table.NewRow();
                for (int j = 0; j < result.D[i].Length; j++)
                    dataRow[j] = result.D[i][j];
                table.Rows.Add(dataRow);
            }
            return table;
        }
    }
}