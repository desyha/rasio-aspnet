<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuestHomePage.aspx.cs" Inherits="RAiso.Views.GuestHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .navbar {
            overflow: hidden;
            background-color: #333;
        }

            .navbar a {
                float: left;
                display: block;
                color: #f2f2f2;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
            }

                .navbar a:hover {
                    background-color: #ddd;
                    color: black;
                }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            <a href="GuestHomePage.aspx">Home</a>
            <a href="LoginPage.aspx">Login</a>
            <a href="RegisterPage.aspx">Register</a>
        </div>
        <div>
            <br />
            <asp:GridView ID="GridView_Guest" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
