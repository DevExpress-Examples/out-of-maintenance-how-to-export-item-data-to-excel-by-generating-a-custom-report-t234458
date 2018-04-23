Namespace Dashboard_SetParameterValues_Web
    Partial Public Class Dashboard1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

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

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
            Dim gridDimensionColumn2 As New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim measure2 As New DevExpress.DashboardCommon.Measure()
            Dim gridMeasureColumn2 As New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
            Dim measure3 As New DevExpress.DashboardCommon.Measure()
            Dim measure4 As New DevExpress.DashboardCommon.Measure()
            Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension6 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension7 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension8 As New DevExpress.DashboardCommon.Dimension()
            Dim measure5 As New DevExpress.DashboardCommon.Measure()
            Dim measure6 As New DevExpress.DashboardCommon.Measure()
            Dim measure7 As New DevExpress.DashboardCommon.Measure()
            Dim measure8 As New DevExpress.DashboardCommon.Measure()
            Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
            Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
            Dim simpleSeries2 As New DevExpress.DashboardCommon.SimpleSeries()
            Dim access97ConnectionParameters1 As New DevExpress.DataAccess.ConnectionParameters.Access97ConnectionParameters()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column12 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim queryParameter1 As New DevExpress.DataAccess.Sql.QueryParameter()
            Dim queryParameter2 As New DevExpress.DataAccess.Sql.QueryParameter()
            Dim selectQuery2 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column13 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As New DevExpress.DataAccess.Sql.Table()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardParameter1 As New DevExpress.DashboardCommon.DashboardParameter()
            Dim dynamicListLookUpSettings1 As New DevExpress.DashboardCommon.DynamicListLookUpSettings()
            Dim dashboardParameter2 As New DevExpress.DashboardCommon.DashboardParameter()
            Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.dataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure8, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' gridDashboardItem1
            ' 
            dimension1.DataMember = "Country"
            gridDimensionColumn1.Weight = 85.72563559322036R
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridDimensionColumn1.AddDataItem("Dimension", dimension1)
            dimension2.DataMember = "Sales Person"
            gridDimensionColumn2.Weight = 83.580508474576277R
            gridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridDimensionColumn2.AddDataItem("Dimension", dimension2)
            measure1.DataMember = "Extended Price"
            measure1.Name = "Extended Price"
            gridMeasureColumn1.Weight = 87.870762711864415R
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridMeasureColumn1.AddDataItem("Measure", measure1)
            measure2.DataMember = "Quantity"
            gridMeasureColumn2.Weight = 85.725635593220346R
            gridMeasureColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridMeasureColumn2.AddDataItem("Measure", measure2)
            Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridDimensionColumn2, gridMeasureColumn1, gridMeasureColumn2})
            Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
            Me.gridDashboardItem1.DataItemRepository.Clear()
            Me.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem3")
            Me.gridDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0")
            Me.gridDashboardItem1.DataItemRepository.Add(measure2, "DataItem1")
            Me.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem2")
            Me.gridDashboardItem1.DataMember = "Query 1"
            Me.gridDashboardItem1.DataSource = Me.dataSource1
            Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.gridDashboardItem1.Name = "Grid 1"
            Me.gridDashboardItem1.ShowCaption = False
            ' 
            ' pivotDashboardItem1
            ' 
            dimension3.DataMember = "CategoryName"
            dimension4.DataMember = "ProductName"
            Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3, dimension4})
            Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
            measure3.DataMember = "UnitPrice"
            measure4.DataMember = "Quantity"
            dimension5.DataMember = "OrderDate"
            dimension6.DataMember = "OrderDate"
            dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            dimension7.DataMember = "OrderDate"
            dimension7.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Quarter
            dimension7.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.pivotDashboardItem1.DataItemRepository.Clear()
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem0")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension4, "DataItem2")
            Me.pivotDashboardItem1.DataItemRepository.Add(measure3, "DataItem6")
            Me.pivotDashboardItem1.DataItemRepository.Add(measure4, "DataItem7")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension5, "DataItem3")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension6, "DataItem1")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension7, "DataItem4")
            Me.pivotDashboardItem1.DataMember = "Query 1"
            Me.pivotDashboardItem1.DataSource = Me.dataSource1
            Me.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pivotDashboardItem1.Name = "Pivot 1"
            Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5, dimension7, dimension6})
            Me.pivotDashboardItem1.ShowCaption = True
            Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure3, measure4})
            ' 
            ' chartDashboardItem1
            ' 
            dimension8.DataMember = "OrderDate"
            dimension8.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension8})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            measure5.DataMember = "UnitPrice"
            measure6.DataMember = "Extended Price"
            measure7.DataMember = "Discount"
            measure8.DataMember = "Quantity"
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(measure5, "DataItem6")
            Me.chartDashboardItem1.DataItemRepository.Add(dimension8, "DataItem4")
            Me.chartDashboardItem1.DataItemRepository.Add(measure6, "DataItem0")
            Me.chartDashboardItem1.DataItemRepository.Add(measure7, "DataItem1")
            Me.chartDashboardItem1.DataItemRepository.Add(measure8, "DataItem2")
            Me.chartDashboardItem1.DataMember = "Query 1"
            Me.chartDashboardItem1.DataSource = Me.dataSource1
            Me.chartDashboardItem1.HiddenMeasures.AddRange(New DevExpress.DashboardCommon.Measure() { measure7, measure8})
            Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem1.Name = "Chart 1"
            chartPane1.Name = "Pane 1"
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            chartPane1.PrimaryAxisY.ShowGridLines = True
            chartPane1.PrimaryAxisY.TitleVisible = True
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            chartPane1.SecondaryAxisY.ShowGridLines = False
            chartPane1.SecondaryAxisY.TitleVisible = True
            simpleSeries1.AddDataItem("Value", measure5)
            simpleSeries2.AddDataItem("Value", measure6)
            chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1, simpleSeries2})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
            Me.chartDashboardItem1.ShowCaption = True
            ' 
            ' dataSource1
            ' 
            Me.dataSource1.ComponentName = "dataSource1"
            Me.dataSource1.ConnectionName = "nwindConnection"
            access97ConnectionParameters1.FileName = "../../../nwind.mdb"
            Me.dataSource1.ConnectionParameters = access97ConnectionParameters1
            Me.dataSource1.Name = "SQL Data Source 1"
            columnExpression1.ColumnName = "OrderID"
            table1.Name = "SalesPerson"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Country"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "FirstName"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "LastName"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "ProductName"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "CategoryName"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "OrderDate"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "UnitPrice"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "Quantity"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Discount"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "Extended Price"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "Sales Person"
            columnExpression12.Table = table1
            column12.Expression = columnExpression12
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Columns.Add(column9)
            selectQuery1.Columns.Add(column10)
            selectQuery1.Columns.Add(column11)
            selectQuery1.Columns.Add(column12)
            selectQuery1.FilterString = "[SalesPerson.CategoryName] = ?category1 And [SalesPerson.OrderDate] >= ?startDate" & "1"
            selectQuery1.Name = "Query 1"
            queryParameter1.Name = "category1"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.Category]", GetType(String))
            queryParameter2.Name = "startDate1"
            queryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.StartDate]", GetType(Date))
            selectQuery1.Parameters.Add(queryParameter1)
            selectQuery1.Parameters.Add(queryParameter2)
            selectQuery1.Tables.Add(table1)
            columnExpression13.ColumnName = "CategoryName"
            table2.Name = "Categories"
            columnExpression13.Table = table2
            column13.Expression = columnExpression13
            selectQuery2.Columns.Add(column13)
            selectQuery2.Name = "Query 2"
            selectQuery2.Tables.Add(table2)
            Me.dataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1, selectQuery2})
            Me.dataSource1.ResultSchemaSerializable = resources.GetString("dataSource1.ResultSchemaSerializable")
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.gridDashboardItem1, Me.pivotDashboardItem1, Me.chartDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.gridDashboardItem1
            dashboardLayoutItem1.Weight = 50.033579583613161R
            dashboardLayoutItem2.DashboardItem = Me.chartDashboardItem1
            dashboardLayoutItem2.Weight = 49.966420416386839R
            dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup2.DashboardItem = Nothing
            dashboardLayoutGroup2.Weight = 44.498777506112468R
            dashboardLayoutItem3.DashboardItem = Me.pivotDashboardItem1
            dashboardLayoutItem3.Weight = 55.501222493887532R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem3})
            dashboardLayoutGroup1.DashboardItem = Nothing
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = dashboardLayoutGroup1
            dashboardParameter1.Description = "Category:"
            dynamicListLookUpSettings1.DataMember = "Query 2"
            dynamicListLookUpSettings1.DataSourceName = "dataSource1"
            dynamicListLookUpSettings1.DisplayMember = "CategoryName"
            dynamicListLookUpSettings1.ValueMember = "CategoryName"
            dashboardParameter1.LookUpSettings = dynamicListLookUpSettings1
            dashboardParameter1.Name = "Category"
            dashboardParameter1.Type = GetType(String)
            dashboardParameter1.Value = "Beverages"
            dashboardParameter2.Description = "Start date:"
            dashboardParameter2.Name = "StartDate"
            dashboardParameter2.Type = GetType(Date)
            dashboardParameter2.Value = New Date(1994, 1, 1, 0, 0, 0, 0)
            Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() { dashboardParameter1, dashboardParameter2})
            Me.Title.Text = "Dashboard"
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension8, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure8, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Private dataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
        Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
    End Class
End Namespace
