<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StationeryDetailPage.aspx.cs" Inherits="RAiso.Views.StationeryDetailPage" %>

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
            <a href="HomePage.aspx">Back</a>
        </div>
        <div>
            <asp:Label ID="Label_Name" runat="server" Text="Name"></asp:Label><br />
            <asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_Price" runat="server" Text="Price"></asp:Label><br />
            <asp:TextBox ID="TextBox_Price" runat="server"></asp:TextBox>
        </div>
        <div>
            <h3>Insert Quantity</h3>
        </div>
        <div>
            <asp:Label ID="Label_Quantity" runat="server" Text="Quantity"></asp:Label><br />
            <asp:TextBox ID="TextBox_Quantity" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button_AddCart" runat="server" Text="Add To Cart" OnClick="Button_AddCart_Click" />
            <asp:Label ID="Label_Error" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
