<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="RAiso.Views.CartPage" %>

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
            <br />
            <asp:GridView ID="GridView_Cart" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView_Cart_SelectedIndexChanged" OnRowDeleting="GridView_Cart_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="CartId" HeaderText="Id" SortExpression="CartId" />
                    <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="Name" SortExpression="MsStationery.StationeryName" />
                    <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="Price" SortExpression="MsStationery.StationeryPrice" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Update" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <br />
            <asp:Button ID="Button_CheckOut" runat="server" Text="Check Out" OnClick="Button_CheckOut_Click" />
            <asp:Label ID="Label_Error" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
