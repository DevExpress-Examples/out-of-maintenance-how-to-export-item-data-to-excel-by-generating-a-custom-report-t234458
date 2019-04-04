<!-- default file list -->
*Files to look at*:

* [DashboardScripts.js](./CS/AspProject/DashboardScripts.js) (VB: [DashboardScripts.js](./VB/AspProject/DashboardScripts.js))
* [Default.aspx](./CS/AspProject/Default.aspx) (VB: [Default.aspx](./VB/AspProject/Default.aspx))
* [Default.aspx.cs](./CS/AspProject/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/AspProject/Default.aspx.vb))
* [XtraReport1.cs](./CS/AspProject/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/AspProject/XtraReport1.vb))
<!-- default file list end -->
# How to export item data to Excel by generating a custom report


<p>Udpate: The ASPxDashboardViewer version 15.2 supports the Export To Excel functionality out of the box: <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument15183">Exporting Dashboard Items</a><br><br>In this example, you will find how to export item data using the report suite. The export is performed in three steps:<br>1. We request data displayed in a specific dashboard item using a client-side script provided in the <a href="https://www.devexpress.com/Support/Center/p/T182186">T182186: How to get visible data from a certain dashboard item on the client side and process it on the server side</a> example and send this data to the server in the form of a JSON string. Also information about actual dashboard parameters is requested using the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardViewer_GetParameterstopic">ASPxClientDashboardViewer.GetParameters Method</a>.<br>2. The JSON string is parsed on the server side. Based on the retrieved data, we generate a report containing a simple table displaying item's data and add information about actual parameter values to the report header. <br>3. Finally, it is necessary to export the report to an Excel document and write this document to the response. It is possible to use the same approach to export the resultant report to other file types. </p>

<br/>


