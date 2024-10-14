<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCartPage.aspx.cs" Inherits="RAiso.Views.UpdateCartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Data</h2>
        </div>
        <div>
            <br />
            <asp:Label ID="Label_Name" runat="server" Text="Old Name"></asp:Label><br />
            <asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_Price" runat="server" Text="Old Price"></asp:Label><br />
            <asp:TextBox ID="TextBox_Price" runat="server"></asp:TextBox><br />
        </div>
        <div>
            <h3>Input new Quantity :</h3>
        </div>
        <div>
            <asp:Label ID="Label_Quantity" runat="server" Text="Quantity"></asp:Label><br />
            <asp:TextBox ID="TextBox_Quantity" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button_Update" runat="server" Text="Update" OnClick="Button_Update_Click"/>
            <asp:Label ID="Label_Error" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
