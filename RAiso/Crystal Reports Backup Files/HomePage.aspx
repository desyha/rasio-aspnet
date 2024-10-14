<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="RAiso.Views.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RAISO</title>
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
            <a href="HomePage.aspx">Home</a>
            <a href="CartPage.aspx">Cart</a>
            <a href="TransactionHistoryPage.aspx">Transaction</a>
            <a href="UpdateProfileAdminPage.aspx">Update Profile</a>
            <a href="LogOutPage.aspx">Logout</a>
        </div>
        <div>
            <br />
            <asp:GridView ID="GridView_User" runat="server" OnSelectedIndexChanged="GridView_User_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Detail" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
