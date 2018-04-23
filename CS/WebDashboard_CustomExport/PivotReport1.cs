using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


/// <summary>
/// Summary description for PivotReport1
/// </summary>
public class PivotReport1 : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public PivotReport1()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }


    public PivotReport1(DataTable table, dynamic parameters)
        : this()
    {
        PaperKind = System.Drawing.Printing.PaperKind.Custom;
        PageWidth = 10000;
        for (int i = 0; i < parameters.Length; i++)
        {
            var label = new XRLabel() { WidthF = TableWidth, Text = string.Format("{0}: {1}", parameters[i].Name, parameters[i].Value) };
            label.LocationF = new PointF(0, label.HeightF * i);
            ReportHeader.Controls.Add(label);
            if (i == 0)
                ReportHeader.HeightF = label.HeightF * parameters.Length;
        }


        AddContent(table);
    }

    int TableWidth = 800;

    private void AddContent(DataTable table)
    {
        DataSource = table;
        int colCount = table.Columns.Count;
        int colWidth = (PageWidth - (Margins.Left + Margins.Right)) / colCount;

        // Create a table to display data
        XRTable tableDetail = new XRTable();
        tableDetail.Width = (PageWidth - (Margins.Left + Margins.Right));

        XRTableRow detailRow = new XRTableRow();
        detailRow.Width = tableDetail.Width;
        tableDetail.Rows.Add(detailRow);
        tableDetail.BeginInit();

        // Create table cells, fill the header cells with text, bind the cells to data
        for (int i = 0; i < colCount; i++)
        {
            XRTableCell headerCell = new XRTableCell();
            headerCell.Width = colWidth;
            headerCell.Text = table.Columns[i].Caption;

            XRTableCell detailCell = new XRTableCell();
            
            detailCell.Width = colWidth;
            detailCell.DataBindings.Add("Text", null, table.Columns[i].Caption);
            if (i == 0)
            {
                headerCell.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom;
                detailCell.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom;
            }
            else
            {
                headerCell.Borders = DevExpress.XtraPrinting.BorderSide.All;
                detailCell.Borders = DevExpress.XtraPrinting.BorderSide.All;
            }

            // Place the cells into the corresponding tables
            detailRow.Cells.Add(detailCell);
        }
        tableDetail.EndInit();
        Detail.Controls.Add(tableDetail);
        Detail.HeightF = 23; //minimal XRTableRow Height
    }





    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 100F;
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 100F;
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Dpi = 100F;
            this.ReportHeader.HeightF = 58.33333F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PivotReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.Version = "16.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
