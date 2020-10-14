<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs"
    Inherits="Dashboard_SetParameterValues_Web.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Dashboard.v16.2.Web, Version=16.2.17.0, 
                                                       Culture=neutral, 
                                                       PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.DashboardWeb"
    TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"  
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="Scripts/DashboardScripts.js"></script>
    <script type="text/javascript">
        function PerformExport(s, e) {
            var itemData = GetDashboardItemData(webViewer, 'gridDashboardItem1');
            itemData.Parameters = GetParameterValues(webViewer);
            __doPostBack('buttonExportItem', JSON.stringify(itemData));
        }
        function PerformExportPivot(s, e) {
            var itemData = GetDashboardItemData(webViewer, 'pivotDashboardItem1');
            itemData.Parameters = GetParameterValues(webViewer);
            __doPostBack('buttonExportPivot', JSON.stringify(itemData));
        }
        function PerformExportChart(s, e) {
            var itemData = GetDashboardItemData(webViewer, 'chartDashboardItem1');
            itemData.Parameters = GetParameterValues(webViewer);
            __doPostBack('buttonExportChart', JSON.stringify(itemData));
        }        
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxButton ID="ASPxButton1" ClientInstanceName="buttonExportItem" runat="server" Text="Export Grid" AutoPostBack="False" OnClick="ASPxButton1_Click">
            <ClientSideEvents Click="PerformExport" />
        </dx:ASPxButton>
        <dx:ASPxButton ID="ASPxButton2" ClientInstanceName="buttonExportPivot" runat="server" Text="Export Pivot" AutoPostBack="False" OnClick="ASPxButton2_Click">
            <ClientSideEvents Click="PerformExportPivot" />
        </dx:ASPxButton>
        <dx:ASPxButton ID="ASPxButton3" ClientInstanceName="buttonExportChart" runat="server" Text="Export Chart" AutoPostBack="False" OnClick="ASPxButton2_Click">
            <ClientSideEvents Click="PerformExportChart" />
        </dx:ASPxButton>

        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server"
            DashboardSource="Dashboard_SetParameterValues_Web.Dashboard1"
            OnConfigureDataConnection="ASPxDashboardViewer1_ConfigureDataConnection"
            ClientInstanceName="webViewer"            
            Width="100%" Height="1000px">
        </dx:ASPxDashboardViewer>
    </form>
</body>
</html>
</script>
