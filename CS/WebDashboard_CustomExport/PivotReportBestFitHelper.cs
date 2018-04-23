using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Dashboard_SetParameterValues_Web
{
    public class PivotReportBestFitHelper
    {
        private static Dictionary<XRControl, float> cellColumnWidthCollection;
        public static XtraReport InitReport(DevExpress.XtraReports.UI.XtraReport report)
        {
            cellColumnWidthCollection = new Dictionary<XRControl, float>();
            report.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            report.PageWidth = 1000;
            CreateReportDocument(report);

            FillColumnCellWidthCollection(report);
            ApplyNewWidthToReportCells(report);
            CreateReportDocument(report);
            return report;
        }
        private static void CreateReportDocument(DevExpress.XtraReports.UI.XtraReport report)
        {
            report.CreateDocument();
        }
        private static void ApplyNewWidthToReportCells(XtraReport report)
        {
            
            IEnumerable<XRTableCell> cells = report.AllControls<XRTableCell>();
            foreach (XRTableCell c in cells)
            {
                c.WidthF = (float)cellColumnWidthCollection[c];                
            }

        }
        private static void FillColumnCellWidthCollection(XtraReport report)
        {
            foreach (PSPage page in report.Pages)
            {
                NestedBrickIterator iterator = new NestedBrickIterator(page.InnerBricks);
                while (iterator.MoveNext())
                {
                    if (iterator.CurrentBrick is VisualBrick && ((VisualBrick)iterator.CurrentBrick).BrickOwner is XRTableCell)
                    {
                        string text = ((VisualBrick)iterator.CurrentBrick).Text;
                        XRTableCell cell = ((VisualBrick)iterator.CurrentBrick).BrickOwner as XRTableCell;
                        float actualWidth = report.PrintingSystem.Graph.MeasureString(text).Width;
                        switch (report.ReportUnit)
                        {
                            case DevExpress.XtraReports.UI.ReportUnit.HundredthsOfAnInch:
                                actualWidth = GraphicsUnitConverter.Convert(actualWidth, GraphicsUnit.Document, GraphicsUnit.Inch) * 100;
                                break;
                            case DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter:
                                actualWidth = GraphicsUnitConverter.Convert(actualWidth, GraphicsUnit.Document, GraphicsUnit.Millimeter) * 10;
                                break;
                        }

                        if (!cellColumnWidthCollection.ContainsKey(cell))
                        {
                            cellColumnWidthCollection.Add(cell, actualWidth);
                        }
                        else
                        {
                            float value = cellColumnWidthCollection[cell];
                            if (actualWidth > value)
                            {
                                cellColumnWidthCollection[cell] = actualWidth;
                            }
                        }
                    }
                }
            }
        }
    }
}