<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XSS3.aspx.cs" Inherits="_03_CrossSiteScripting.XSS3" %>

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
        <asp:TextBox runat="server" ID="RichTextBox" TextMode="MultiLine" Columns="40" Rows="5"/>
        <asp:Button runat="server" ID="SubmitButton" OnClick="SubmitButton_Click" Text="Submit"/>
        <asp:Literal runat="server" ID="XSSLiteral"/>
    </div>
    </form>
    </div>
    <script src="scripts/jquery-1.10.2.js"></script>
    <script src="scripts/bootstrap.js"></script>
    <script src="scripts/tinymce/tinymce.js"></script>
    <script>
        tinymce.init({ selector: 'textarea' });
    </script>
</body>
</html>
