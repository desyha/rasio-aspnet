<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="RAiso.Views.AdminHomePage" %>

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
            <a href="AdminHomePage.aspx">Home</a>
            <a href="Report.aspx">Transaction</a>
            <a href="UpdateProfileAdminPage.aspx">Update Profile</a>
            <a href="LogOutPage.aspx">Logout</a>
        </div>
        <div>
            <br />
            <asp:GridView ID="GridView_Admin" runat="server"></asp:GridView>
        </div>
        <div>
            <br />
            <asp:Button ID="Button_Insert" runat="server" Text="Insert" OnClick="Button_Insert_Click" />
        </div>
    </form>
</body>
</html>
