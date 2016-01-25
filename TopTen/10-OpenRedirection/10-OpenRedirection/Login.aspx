<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OpenRedirection.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" type="text/css" rel="stylesheet" />

</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <div class="jumbotron">
                <h1>10 - Open Redirection</h1>
            </div>
            <div class="row">
                <div class="form_group">
                    <label for="UsernameTextBox">Username:</label>
                    <asp:TextBox runat="server" ID="UsernameTextBox" />


                    <label for="PasswordTextBox">
                        Password:</label>
                    <asp:TextBox runat="server" ID="PasswordTextBox" TextMode="Password" />

                    <asp:Button runat="server" ID="LoginButton" Text="Login" OnClick="LoginButton_Click" CssClass="btn btn-default" />
                </div>
            </div>
        </form>
    </div>

    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
