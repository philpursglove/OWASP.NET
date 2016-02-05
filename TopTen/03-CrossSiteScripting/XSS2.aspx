<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XSS2.aspx.cs" Inherits="_03_CrossSiteScripting.XSS2" ValidateRequest="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
<div class="container body-content">
    <div class="jumbotron">
        <h1>3 - Cross Site Scripting</h1>
    </div>
    <form id="form1" runat="server">
    <div>
    Enter your attack here:
    <asp:TextBox runat="server" ID="XSSTargetTextbox" />
        <asp:Button runat="server" ID="SubmitButton" Text="Submit" OnClick="SubmitButton_Click" />
        <asp:Literal runat="server" ID="XSSLiteral" />
    </div>
    </form>
    </div>
    <script src="scripts/jquery-1.10.2.js"></script>
    <script src="scripts/bootstrap.js"></script>
</body>
</html>
