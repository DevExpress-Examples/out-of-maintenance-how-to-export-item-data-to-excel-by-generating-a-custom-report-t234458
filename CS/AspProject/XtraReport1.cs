using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace AspProject
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        int TableWidth { get { return PageWidth - Margins.Left - Margins.Right; } }

        public XtraReport1(DataTable table)
        {
            InitializeComponent();

            DataSource = table;
            AddHeaders(table);
            AddContent(table);

        }
        private void AddHeaders(DataTable table)
        {
            XRTable headers = XRTable.CreateTable(
                                new Rectangle(0,
                                                0,
                                                TableWidth,
                                                20),
                                                1,
                                                0);
            headers.BeginInit();
            foreach (DataColumn dc in table.Columns)
            {
                XRTableCell cell = new XRTableCell();
                cell.CanGrow = false;
                cell.Width = 100;
                cell.Text = dc.ColumnName;
                cell.BackColor = Color.LightGray;
                headers.Rows.FirstRow.Cells.Add(cell);
            }
            headers.HeightF = 100f;
            headers.EndInit();
            ReportHeader.Controls.Add(headers);
        }

        private void AddContent(DataTable table)
        {
            XRTable dynamicTable = XRTable.CreateTable(
                                            new Rectangle(0,
                                                            0,
                                                            TableWidth,
                                                            20),
                                                            1,
                                                            0);

            dynamicTable.Width = TableWidth;
            dynamicTable.Rows.FirstRow.Width = TableWidth;
            dynamicTable.Borders = DevExpress.XtraPrinting.BorderSide.All;
            dynamicTable.BorderWidth = 1;
            int i = 0;
            dynamicTable.BeginInit();
            foreach (DataColumn dc in table.Columns)
            {

                XRTableCell cell = new XRTableCell();

                XRBinding binding = new XRBinding("Text", table, table.Columns[i].ColumnName);
                cell.DataBindings.Add(binding);
                cell.CanGrow = false;
                cell.Width = 100;
                cell.Text = dc.ColumnName;
                dynamicTable.Rows.FirstRow.Cells.Add(cell);
                i++;
            }
            dynamicTable.Font = new Font("Verdana", 8F);
            dynamicTable.EndInit();
            Detail.HeightF = 20f;
            Detail.Controls.Add(dynamicTable);
        }
    }
}
