<!-- default file list -->
*Files to look at*:

* [MyObject.cs](./CS/WebSite/App_Code/MyObject.cs) (VB: [MyObject.vb](./VB/WebSite/App_Code/MyObject.vb))
* [XpoHelper.cs](./CS/WebSite/App_Code/XpoHelper.cs) (VB: [XpoHelper.vb](./VB/WebSite/App_Code/XpoHelper.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to perform ASPxGridView instant updating using different editors in the DataItem template


<p><strong>UPDATED:</strong><br /><br />Starting with version 13.2, the ASPxGridView control offers the basic "Batch Editing Mode" functionality that allows accomplishing a similar task with less effort and does not require so much extra code. See the <a href="https://community.devexpress.com/blogs/aspnet/archive/2013/12/16/asp-net-webforms-amp-mvc-gridview-batch-edit-what-39-s-new-in-13-2.aspx">ASP.NET WebForms & MVC: GridView Batch Edit </a>blog post to learn more about this new functionality.<br /><br />Starting with version 14.1, the ASPxGridView control offers advanced "Batch Editing Mode" programming options.<br /><br />You can find a standalone DB-independent solution in our Code Examples base at:<br /><a href="https://www.devexpress.com/Support/Center/p/E5045">ASPxGridView - A simple Batch Editing implementation</a><br /><br />If you have version v14.1+ available, consider using the built-in functionality instead of the approach detailed below.<br />If you need further assistance with this functionality, please create a new ticket in our Support Center.<br /><br />The sample demonstrates how to send individual callbacks to the database to perform instant editing of the datatable without switching the grid to Edit mode. The XPO is used for demonstrating purposes only. If the SqlDataSource is used, it will be enough to create corresponding SQL statements and perform partial updating manually.</p>
<p><strong>See Also:</strong><br /> <a href="https://www.devexpress.com/Support/Center/p/E129">Implement on-demand data posting (batch data update)</a><br /> <a href="https://www.devexpress.com/Support/Center/p/E2313">How to update a Boolean field using the ASPxCheckBox in a DataItem template</a><br /> <a href="https://www.devexpress.com/Support/Center/p/K18282">The general technique of using the Init/Load event handler</a><br /> <a href="https://www.devexpress.com/Support/Center/p/E324">How to implement the multi-row editing feature in the ASPxGridView</a><br /> <a href="https://www.devexpress.com/Support/Center/p/E1468">Custom client-side logic implementation in the grid with multi-row editing</a></p>

<br/>


