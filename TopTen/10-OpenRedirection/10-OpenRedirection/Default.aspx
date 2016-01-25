<%@ Page Language="C#" Inherits="OpenRedirection.Default" CodeFile="Default.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Title</title>
    <link href="Content/bootstrap.min.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <form id="HtmlForm" runat="server">
            <div class="jumbotron">
                <h1>10 - Open Redirection</h1>
            </div>

            <div>
                <asp:Button runat="server" ID="LogOutButton" Text="Log Out" OnClick="LogOutButton_Click" />
            </div>
        </form>
    </div>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
