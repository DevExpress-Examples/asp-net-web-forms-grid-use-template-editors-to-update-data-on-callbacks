<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128541910/10.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2333)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-use-template-editors-to-update-data-on-callbacks&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-use-template-editors-to-update-data-on-callbacks&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
