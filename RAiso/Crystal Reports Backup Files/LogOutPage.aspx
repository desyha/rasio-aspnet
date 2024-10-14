<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOutPage.aspx.cs" Inherits="RAiso.Views.LogOutPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <h3>Are you sure want to Logout ?</h3>
                <asp:Button ID="Button_yes" runat="server" Text="Yes" Onclick="Button_yes_Click"/><a>   </a>
                <asp:Button ID="Button_No" runat="server" Text="No" OnClick="Button_No_Click" />
            </div>
        </div>
    </form>
</body>
</html>
