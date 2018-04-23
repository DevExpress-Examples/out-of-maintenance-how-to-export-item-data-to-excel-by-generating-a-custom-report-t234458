Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Data


''' <summary>
''' Summary description for PivotReport1
''' </summary>
Public Class PivotReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private Detail As DevExpress.XtraReports.UI.DetailBand
    Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Private ReportHeader As ReportHeaderBand
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
        '
        ' TODO: Add constructor logic here
        '
    End Sub


    Public Sub New(ByVal table As DataTable, ByVal parameters As Object)
        Me.New()
        PaperKind = System.Drawing.Printing.PaperKind.Custom
        PageWidth = 10000
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

    Private TableWidth As Integer = 800

    Private Sub AddContent(ByVal table As DataTable)
        DataSource = table
        Dim colCount As Integer = table.Columns.Count
        Dim colWidth As Integer = (PageWidth - (Margins.Left + Margins.Right)) / colCount

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
        tableDetail.EndInit()
        Detail.Controls.Add(tableDetail)
        Detail.HeightF = 23 'minimal XRTableRow Height
    End Sub





    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    #Region "Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Dpi = 100F
            Me.Detail.HeightF = 100F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Dpi = 100F
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Dpi = 100F
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Dpi = 100F
            Me.ReportHeader.HeightF = 58.33333F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' PivotReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
            Me.Version = "16.2"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    #End Region
End Class
