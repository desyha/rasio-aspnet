<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStationeryPage.aspx.cs" Inherits="RAiso.Views.UpdateStationeryPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Old Data</h2>
        </div>
        <div>
            <asp:Label ID="Label_Id" runat="server" Text="Stationery ID  "></asp:Label><br />
            <asp:TextBox ID="TextBox_Id" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_OldName" runat="server" Text="Old Name"></asp:Label><br />
            <asp:TextBox ID="TextBox_OldName" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label_OldPrice" runat="server" Text="Old Price"></asp:Label><br />
            <asp:TextBox ID="TextBox_OldPrice" runat="server"></asp:TextBox><br />
        </div>
        <h3>Input Change Below :</h3>
        <div>
            <asp:Label ID="Label_NewName" runat="server" Text="New Name"></asp:Label><br />
            <asp:TextBox ID="TextBox_NewName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_NewPrice" runat="server" Text="New Price"></asp:Label><br />
            <asp:TextBox ID="TextBox_NewPrice" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button_Update" runat="server" Text="Update" OnClick="Button_Update_Click" />
            <asp:Label ID="Label_Error" runat="server" Text=" " Visible="false" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
