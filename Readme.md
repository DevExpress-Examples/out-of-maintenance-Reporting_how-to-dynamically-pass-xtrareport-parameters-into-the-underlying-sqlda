# How to dynamically pass XtraReport parameters into the underlying SqlDataSource to perform server-side filtering


<p>This example shows how to dynamically add a parameter to XtraReport, compose FilterString in the SqlDataSource and use XtraReport's parameters to filter data in the SqlDataSource.</p>


<h3>Description</h3>

<p>Starting with v16.1.4, the TableQuery class is no longer used (see&nbsp;<a href="https://www.devexpress.com/Support/WhatsNew/DXperience/files/16.1.2.bc.xml">BC3458</a>). So, it's necessary to use the&nbsp;<strong>SelectQuery</strong>&nbsp;class instead.</p>

<br/>


