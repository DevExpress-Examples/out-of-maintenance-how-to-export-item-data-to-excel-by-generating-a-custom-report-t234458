Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardCommon
Imports DevExpress.Web
Imports System.Web.UI.HtmlControls
Imports System.Web.Helpers
Imports System.Data
Imports DevExpress.XtraPrinting
Imports System.Diagnostics
Imports System.IO

Namespace AspProject
    Partial Public Class [Default]
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If (Not IsPostBack) AndAlso (Not IsCallback) Then
                Dim dashboard As New Dashboard()

                If TypeOf ASPxDashboardViewer1.DashboardSource Is String Then
                    dashboard.LoadFromXml(Server.MapPath(CStr(ASPxDashboardViewer1.DashboardSource)))
                End If
            End If
        End Sub

        Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object, ByVal e As DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs)
            Select Case e.ConnectionName
                Case "nwindConnection"
                    Dim access As Access97ConnectionParameters = TryCast(e.ConnectionParameters, Access97ConnectionParameters)
                    If access IsNot Nothing Then
                        access.FileName = Server.MapPath("~/App_Data/nwind.mdb")
                    End If
            End Select
        End Sub


        Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim result As Object = Json.Decode(Me.Request("__EVENTARGUMENT"))
            Dim table As DataTable = CreateTable(result)
            Dim xtraReport As New XtraReport1(table)
            Using stream As New MemoryStream()
                xtraReport.ExportToXls(stream)
                Response.Clear()
                Response.Buffer = False
                Response.AppendHeader("Content-Type", "application/ms-excel")
                Response.AppendHeader("Content-Transfer-Encoding", "binary")
                Response.AppendHeader("Content-Disposition", "attachment; filename=ItemData.xls")
                Response.BinaryWrite(stream.GetBuffer())
                Response.End()
            End Using
        End Sub

        Private Shared Function CreateTable(ByVal result As Object) As DataTable
            Dim table As New DataTable()

            For Each cell In result.D(0)
                table.Columns.Add(New DataColumn(Convert.ToString(cell)))
            Next cell

            For i As Integer = 1 To result.D.Length - 1

                Dim dataRow As DataRow = table.NewRow()
                For j As Integer = 0 To (result.D(i).Length) - 1
                    dataRow(j) = Convert.ToString(result.D(i)(j))
                Next j
                table.Rows.Add(dataRow)
            Next i
            Return table
        End Function




    End Class
End Namespace