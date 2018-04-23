Imports System
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters
Imports AspProject
Imports System.IO
Imports System.Data
Imports System.Web.Helpers

Namespace Dashboard_SetParameterValues_Web
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionWebEventArgs)
            If e.DataSourceName = "SQL Data Source 1" Then
                ' Gets connection parameters used to establish a connection to the database.
                Dim parameters As Access97ConnectionParameters = CType(e.ConnectionParameters, Access97ConnectionParameters)
                Dim databasePath As String = Server.MapPath("App_Data/nwind.mdb")

                ' Specifies the path to a database file.                    
                parameters.FileName = databasePath
            End If
        End Sub

        Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim result As Object = Json.Decode(Me.Request("__EVENTARGUMENT"))
            Dim table As DataTable = CreateTable(result)
            Dim tableResport As New TableReport1(table, result.Parameters)
            Using stream As New MemoryStream()
                tableResport.ExportToXls(stream)
                Response.Clear()
                Response.Buffer = False
                Response.AppendHeader("Content-Type", "application/ms-excel")
                Response.AppendHeader("Content-Transfer-Encoding", "binary")
                Response.AppendHeader("Content-Disposition", "attachment; filename=ItemData.xls")
                Response.BinaryWrite(stream.GetBuffer())
                Response.End()
            End Using
        End Sub
        Protected Sub ASPxButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim result As Object = Json.Decode(Me.Request("__EVENTARGUMENT"))
            Dim table As DataTable = CreatePivotTable(result)
            Dim pivotReport As New PivotReport1(table, result.Parameters)
            PivotReportBestFitHelper.InitReport(pivotReport)
            Using stream As New MemoryStream()
                pivotReport.ExportToXls(stream)
                Response.Clear()
                Response.Buffer = False
                Response.AppendHeader("Content-Type", "application/ms-excel")
                Response.AppendHeader("Content-Transfer-Encoding", "binary")
                Response.AppendHeader("Content-Disposition", "attachment; filename=ItemData.xls")
                Response.BinaryWrite(stream.GetBuffer())
                Response.End()
            End Using
        End Sub

        Private Shared Function CreatePivotTable(ByVal result As Object) As DataTable
            Dim table As New DataTable()

            For i As Integer = 0 To result.D(0).Length - 1
                table.Columns.Add(New DataColumn("C" & i, GetType(Object)))
            Next i

            For i As Integer = 0 To result.D.Length - 1
                Dim dataRow As DataRow = table.NewRow()
                For j As Integer = 0 To result.D(i).Length - 1
                    dataRow(j) = result.D(i)(j)
                Next j
                table.Rows.Add(dataRow)
            Next i
            Return table
        End Function

        Private Shared Function CreateTable(ByVal result As Object) As DataTable
            Dim table As New DataTable()

            For Each cell In result.D(0)
                table.Columns.Add(New DataColumn(Convert.ToString(cell), GetType(Object)))
            Next cell

            For i As Integer = 1 To result.D.Length - 1

                Dim dataRow As DataRow = table.NewRow()
                For j As Integer = 0 To (result.D(i).Length) - 1
                    dataRow(j) = result.D(i)(j)
                Next j
                table.Rows.Add(dataRow)
            Next i
            Return table
        End Function
    End Class
End Namespace