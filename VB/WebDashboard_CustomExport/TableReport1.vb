Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Data

Namespace AspProject
    Partial Public Class TableReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private ReadOnly Property TableWidth() As Integer
            Get
                Return PageWidth - Margins.Left - Margins.Right
            End Get
        End Property
        Public Sub New(ByVal table As DataTable, ByVal parameters As Object)
            InitializeComponent()

            For i As Integer = 0 To parameters.Length - 1
                Dim label = New XRLabel() With {.WidthF = TableWidth, .Text = String.Format("{0}: {1}", parameters(i).Name, parameters(i).Value)}
                label.LocationF = New PointF(0, label.HeightF * i)
                ReportHeader.Controls.Add(label)
                If i = 0 Then
                    ReportHeader.HeightF = label.HeightF * parameters.Length
                End If
            Next i


            AddContent(table)

        End Sub
        Private Sub AddHeaders(ByVal table As DataTable)
            Dim headers As XRTable = XRTable.CreateTable(New Rectangle(0, 0, TableWidth, 35), 1, 0)
            headers.BeginInit()
            For Each dc As DataColumn In table.Columns
                Dim cell As New XRTableCell()
                cell.HeightF = 35F
                cell.CanGrow = False
                cell.Text = dc.ColumnName
                cell.BackColor = Color.LightGray
                headers.Rows.FirstRow.Cells.Add(cell)
            Next dc
            headers.HeightF = 35F
            headers.EndInit()
            ReportHeader.Controls.Add(headers)
        End Sub

        Private Sub AddContent(ByVal table As DataTable)

            DataSource = table

            Dim colCount As Integer = table.Columns.Count
            Dim colWidth As Integer = (PageWidth - (Margins.Left + Margins.Right)) / colCount


            Dim tableHeader As New XRTable()
            tableHeader.Width = (PageWidth - (Margins.Left + Margins.Right))
            tableHeader.HeightF = 35
            tableHeader.LocationF = New PointF(0, ReportHeader.HeightF)
            ReportHeader.HeightF = ReportHeader.HeightF + tableHeader.HeightF

            Dim headerRow As New XRTableRow()
            tableHeader.Width = tableHeader.Width
            tableHeader.Rows.Add(headerRow)
            tableHeader.BeginInit()

            ' Create a table to display data
            Dim tableDetail As New XRTable()
            tableDetail.Width = (PageWidth - (Margins.Left + Margins.Right))

            Dim detailRow As New XRTableRow()
            detailRow.Width = tableDetail.Width
            tableDetail.Rows.Add(detailRow)
            tableDetail.BeginInit()



            ' Create table cells, fill the header cells with text, bind the cells to data
            For i As Integer = 0 To colCount - 1
                Dim headerCell As New XRTableCell()
                headerCell.Width = colWidth
                headerCell.Text = table.Columns(i).Caption
                headerCell.BackColor = Color.LightGray
                headerRow.Cells.Add(headerCell)


                Dim detailCell As New XRTableCell()

                detailCell.Width = colWidth
                detailCell.DataBindings.Add("Text", Nothing, table.Columns(i).Caption)
                If i = 0 Then
                    headerCell.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom
                    detailCell.Borders = DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom
                Else
                    headerCell.Borders = DevExpress.XtraPrinting.BorderSide.All
                    detailCell.Borders = DevExpress.XtraPrinting.BorderSide.All
                End If

                ' Place the cells into the corresponding tables
                detailRow.Cells.Add(detailCell)
            Next i

            tableHeader.EndInit()
            tableDetail.EndInit()
            ReportHeader.Controls.Add(tableHeader)
            Detail.Controls.Add(tableDetail)
            Detail.HeightF = 23 'minimal XRTableRow Height
        End Sub
    End Class
End Namespace
