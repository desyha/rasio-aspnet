<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="RAiso.Views.TransactionDetailPage" %>

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
            <a href="TransactionHistoryPage.aspx">Back</a>
        </div>
        <h2>Transaction Detail</h2>
        <div>
            <asp:GridView ID="GridView_TransactionDetail" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="Stationery Name" SortExpression="MsStationery.StationeryName" />
                    <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="Price" SortExpression="MsStationery.StationeryPrice" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
