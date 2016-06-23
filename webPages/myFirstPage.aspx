<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myFirstPage.aspx.cs" Inherits="WebApplication2.webPages.myFirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <button id="btn" class="btn btn-primary"onclick="testAjax()">PageLoad</button>
    <button id="btn" class="btn btn-primary" onclick="testAjax()">Webservice</button>
    <button id="btn" class="btn btn-primary" onclick="testAjax()">PageLoad</button>
    </div>
    </form>
</body>
</html>
