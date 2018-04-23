Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Data

Namespace AspProject
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private ReadOnly Property TableWidth() As Integer
            Get
                Return PageWidth - Margins.Left - Margins.Right
            End Get
        End Property

        Public Sub New(ByVal table As DataTable)
            InitializeComponent()

            DataSource = table
            AddHeaders(table)
            AddContent(table)

        End Sub
        Private Sub AddHeaders(ByVal table As DataTable)
            Dim headers As XRTable = XRTable.CreateTable(New Rectangle(0, 0, TableWidth, 20), 1, 0)
            headers.BeginInit()
            For Each dc As DataColumn In table.Columns
                Dim cell As New XRTableCell()
                cell.CanGrow = False
                cell.Width = 100
                cell.Text = dc.ColumnName
                cell.BackColor = Color.LightGray
                headers.Rows.FirstRow.Cells.Add(cell)
            Next dc
            headers.HeightF = 100F
            headers.EndInit()
            ReportHeader.Controls.Add(headers)
        End Sub

        Private Sub AddContent(ByVal table As DataTable)
            Dim dynamicTable As XRTable = XRTable.CreateTable(New Rectangle(0, 0, TableWidth, 20), 1, 0)

            dynamicTable.Width = TableWidth
            dynamicTable.Rows.FirstRow.Width = TableWidth
            dynamicTable.Borders = DevExpress.XtraPrinting.BorderSide.All
            dynamicTable.BorderWidth = 1
            Dim i As Integer = 0
            dynamicTable.BeginInit()
            For Each dc As DataColumn In table.Columns

                Dim cell As New XRTableCell()

                Dim binding As New XRBinding("Text", table, table.Columns(i).ColumnName)
                cell.DataBindings.Add(binding)
                cell.CanGrow = False
                cell.Width = 100
                cell.Text = dc.ColumnName
                dynamicTable.Rows.FirstRow.Cells.Add(cell)
                i += 1
            Next dc
            dynamicTable.Font = New Font("Verdana", 8F)
            dynamicTable.EndInit()
            Detail.HeightF = 20F
            Detail.Controls.Add(dynamicTable)
        End Sub
    End Class
End Namespace
