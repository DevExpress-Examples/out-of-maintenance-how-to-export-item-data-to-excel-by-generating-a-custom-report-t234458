using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DashboardCommon;
using DevExpress.Web;
using System.Web.UI.HtmlControls;
using System.Web.Helpers;
using System.Data;
using DevExpress.XtraPrinting;
using System.Diagnostics;
using System.IO;

namespace AspProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                Dashboard dashboard = new Dashboard(); ;
                if (ASPxDashboardViewer1.DashboardSource is string)
                    dashboard.LoadFromXml(Server.MapPath((string)ASPxDashboardViewer1.DashboardSource));
            }
        }

        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs e)
        {
            switch (e.ConnectionName)
            {
                case "nwindConnection":
                    Access97ConnectionParameters access = e.ConnectionParameters as Access97ConnectionParameters;
                    if (access != null)
                        access.FileName = Server.MapPath(@"~/App_Data/nwind.mdb");
                    break;
            }
        }


        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            dynamic result = Json.Decode(this.Request["__EVENTARGUMENT"]);
            DataTable table = CreateTable(result);
            XtraReport1 xtraReport = new XtraReport1(table);
            using (MemoryStream stream = new MemoryStream())
            {
                xtraReport.ExportToXls(stream);
                Response.Clear();
                Response.Buffer = false;
                Response.AppendHeader("Content-Type", "application/ms-excel");
                Response.AppendHeader("Content-Transfer-Encoding", "binary");
                Response.AppendHeader("Content-Disposition", "attachment; filename=ItemData.xls");
                Response.BinaryWrite(stream.GetBuffer());
                Response.End();
            }
        }

        private static DataTable CreateTable(dynamic result)
        {
            DataTable table = new DataTable();

            foreach (var cell in result.D[0])
                table.Columns.Add(new DataColumn(Convert.ToString(cell)));

            for (int i = 1; i < result.D.Length; i++)
            {

                DataRow dataRow = table.NewRow();
                for (int j = 0; j < result.D[i].Length; j++)
                    dataRow[j] = Convert.ToString(result.D[i][j]);
                table.Rows.Add(dataRow);
            }
            return table;
        }




    }
}