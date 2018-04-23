using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace AspProject {
    public partial class TableReport1 : DevExpress.XtraReports.UI.XtraReport {
        int TableWidth { get { return PageWidth - Margins.Left - Margins.Right; } }
        public TableReport1(DataTable table, dynamic parameters) {
            InitializeComponent();

            for (int i = 0; i < parameters.Length; i++) {
                var label = new XRLabel() { WidthF = TableWidth, Text = string.Format("{0}: {1}", parameters[i].Name, parameters[i].Value) };
                label.LocationF = new PointF(0, label.HeightF * i);
                ReportHeader.Controls.Add(label);
                if (i == 0)
                    ReportHeader.HeightF = label.HeightF * parameters.Length;
            }


            AddContent(table);

        }
        private void AddHeaders(DataTable table) {
            XRTable headers = XRTable.CreateTable(new Rectangle(0, 0, TableWidth, 35), 1, 0);
            headers.BeginInit();
            foreach (DataColumn dc in table.Columns) {
                XRTableCell cell = new XRTableCell();
                cell.HeightF = 35f;
                cell.CanGrow = false;
                cell.Text = dc.ColumnName;
                cell.BackColor = Color.LightGray;
                headers.Rows.FirstRow.Cells.Add(cell);
            }
            headers.HeightF = 35f;
            headers.EndInit();
            ReportHeader.Controls.Add(headers);
        }

        private void AddContent(DataTable table) {

            DataSource = table;

            int colCount = table.Columns.Count;
            int colWidth = (PageWidth - (Margins.Left + Margins.Right)) / colCount;


            XRTable tableHeader = new XRTable();
            tableHeader.Width = (PageWidth - (Margins.Left + Margins.Right));
            tableHeader.HeightF = 35;
            tableHeader.LocationF = new PointF(0, ReportHeader.HeightF);
            ReportHeader.HeightF = ReportHeader.HeightF + tableHeader.HeightF;

            XRTableRow headerRow = new XRTableRow();
            tableHeader.Width = tableHeader.Width;
            tableHeader.Rows.Add(headerRow);
            tableHeader.BeginInit();
            
            // Create a table to display data
            XRTable tableDetail = new XRTable();
            tableDetail.Width = (PageWidth - (Margins.Left + Margins.Right));

            XRTableRow detailRow = new XRTableRow();
            detailRow.Width = tableDetail.Width;
            tableDetail.Rows.Add(detailRow);
            tableDetail.BeginInit();

           

            // Create table cells, fill the header cells with text, bind the cells to data
            for (int i = 0; i < colCount; i++) {
                XRTableCell headerCell = new XRTableCell();
                headerCell.Width = colWidth;
                headerCell.Text = table.Columns[i].Caption;
                headerCell.BackColor = Color.LightGray;
                headerRow.Cells.Add(headerCell);
                

                XRTableCell detailCell = new XRTableCell();

                detailCell.Width = colWidth;
                detailCell.DataBindings.Add("Text", null, table.Columns[i].Caption);
                if (i == 0) {
                    headerCell.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom;
                    detailCell.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom;
                }
                else {
                    headerCell.Borders = DevExpress.XtraPrinting.BorderSide.All;
                    detailCell.Borders = DevExpress.XtraPrinting.BorderSide.All;
                }

                // Place the cells into the corresponding tables
                detailRow.Cells.Add(detailCell);
            }

            tableHeader.EndInit();
            tableDetail.EndInit();
            ReportHeader.Controls.Add(tableHeader);
            Detail.Controls.Add(tableDetail);
            Detail.HeightF = 23; //minimal XRTableRow Height
        }
    }
}
