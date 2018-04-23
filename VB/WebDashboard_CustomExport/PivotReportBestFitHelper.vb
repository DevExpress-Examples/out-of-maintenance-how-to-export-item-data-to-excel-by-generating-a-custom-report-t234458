Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Web

Namespace Dashboard_SetParameterValues_Web
    Public Class PivotReportBestFitHelper
        Private Shared cellColumnWidthCollection As Dictionary(Of XRControl, Single)
        Public Shared Function InitReport(ByVal report As DevExpress.XtraReports.UI.XtraReport) As XtraReport
            cellColumnWidthCollection = New Dictionary(Of XRControl, Single)()
            report.PaperKind = System.Drawing.Printing.PaperKind.Custom
            report.PageWidth = 1000
            CreateReportDocument(report)

            FillColumnCellWidthCollection(report)
            ApplyNewWidthToReportCells(report)
            CreateReportDocument(report)
            Return report
        End Function
        Private Shared Sub CreateReportDocument(ByVal report As DevExpress.XtraReports.UI.XtraReport)
            report.CreateDocument()
        End Sub
        Private Shared Sub ApplyNewWidthToReportCells(ByVal report As XtraReport)

            Dim cells As IEnumerable(Of XRTableCell) = report.AllControls(Of XRTableCell)()
            For Each c As XRTableCell In cells
                c.WidthF = CSng(cellColumnWidthCollection(c))
            Next c

        End Sub
        Private Shared Sub FillColumnCellWidthCollection(ByVal report As XtraReport)
            For Each page As PSPage In report.Pages
                Dim [iterator] As New NestedBrickIterator(page.InnerBricks)
                Do While [iterator].MoveNext()
                    If TypeOf [iterator].CurrentBrick Is VisualBrick AndAlso TypeOf CType([iterator].CurrentBrick, VisualBrick).BrickOwner Is XRTableCell Then
                        Dim text As String = CType([iterator].CurrentBrick, VisualBrick).Text
                        Dim cell As XRTableCell = TryCast(CType([iterator].CurrentBrick, VisualBrick).BrickOwner, XRTableCell)
                        Dim actualWidth As Single = report.PrintingSystem.Graph.MeasureString(text).Width
                        Select Case report.ReportUnit
                            Case DevExpress.XtraReports.UI.ReportUnit.HundredthsOfAnInch
                                actualWidth = GraphicsUnitConverter.Convert(actualWidth, GraphicsUnit.Document, GraphicsUnit.Inch) * 100
                            Case DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
                                actualWidth = GraphicsUnitConverter.Convert(actualWidth, GraphicsUnit.Document, GraphicsUnit.Millimeter) * 10
                        End Select

                        If Not cellColumnWidthCollection.ContainsKey(cell) Then
                            cellColumnWidthCollection.Add(cell, actualWidth)
                        Else
                            Dim value As Single = cellColumnWidthCollection(cell)
                            If actualWidth > value Then
                                cellColumnWidthCollection(cell) = actualWidth
                            End If
                        End If
                    End If
                Loop
            Next page
        End Sub
    End Class
End Namespace