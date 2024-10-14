<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertStationeryPage.aspx.cs" Inherits="RAiso.Views.InsertStationeryPage" %>

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
            <a href="AdminHomePage.aspx">Back</a>
        </div>
        <div>
            <br />
            <asp:GridView ID="AdminGridview" runat="server" OnRowDeleting="AdminGridview_RowDeleting" DataKeyNames="StationeryId" OnSelectedIndexChanged="AdminGridview_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Update" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <h3>Insert New Stationery</h3>
            <asp:Label ID="Label_STName" runat="server" Text="Stationery Name"></asp:Label><br />
            <asp:TextBox ID="TextBox_STName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_STPrice" runat="server" Text="Stationery Price"></asp:Label><br />
            <asp:TextBox ID="TextBox_STPrice" runat="server"></asp:TextBox>
        </div>
        <div>
            <br />
            <asp:Button ID="Button_Insert" runat="server" Text="Add New Stationery" Onclick="Button_Insert_Click" />
            <asp:Label ID="Label_error" runat="server" Text="" Forecolor="Red" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
