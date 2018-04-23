<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="AspProject.Default" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Dashboard.v14.2.Web, Version=14.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="DashboardScripts.js" type="text/javascript"></script>
    <script type="text/javascript">
        function PerformExport(s,e) {
            var itemData = GetDashboardItemData(dashboardViewer, 'gridDashboardItem1');            
            __doPostBack('buttonExportItem', itemData);
        }
    </script>
    <style type="text/css">
        .padded-table td {
            padding: 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%">
                <tr>
                    <td style="vertical-align: top">
                        <dx:ASPxButton ID="ASPxButton1" ClientInstanceName="buttonExportItem" runat="server" Text="Export to Excel" AutoPostBack="False" OnClick="ASPxButton1_Click">
                            <ClientSideEvents Click="PerformExport" />
                        </dx:ASPxButton>
                    </td>
                    <td style="width: 100%">                        
                        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" DashboardSource="~/Dashboards/Invoices.xml"
                            FullscreenMode="True" OnConfigureDataConnection="ASPxDashboardViewer1_ConfigureDataConnection"
                            RegisterJQuery="True" ClientInstanceName="dashboardViewer" UseDataAccessApi="true">
                        </dx:ASPxDashboardViewer>
                    </td>
                </tr>
            </table>
        </div>


    </form>
</body>
</html>