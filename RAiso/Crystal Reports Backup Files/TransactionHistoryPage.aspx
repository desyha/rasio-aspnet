<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="RAiso.Views.TransactionHistoryPage" %>

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
        <h2>Transaction Detail</h2>
        <div>
            <asp:GridView ID="GridView_TH" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView_TH_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="TansactionId" HeaderText="Id" SortExpression="TansactionId" />
                    <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
                    <asp:BoundField DataField="MsUser.UserName" HeaderText="Customer Name" SortExpression="MsUser.UserName" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Detail" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
