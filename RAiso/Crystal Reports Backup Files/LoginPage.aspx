<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="RAiso.Views.LoginPage" %>

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
            <a href="GuestHomePage.aspx">Home</a>
        </div>
        <h2>Login Page</h2>
        <div>
            <asp:Label ID="Label_Name" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_Password" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="TextBox_Password" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="CheckBox_remember" runat="server" Text="Remember Me" />
        </div>
        <div>
            <asp:Button ID="Button_Login" runat="server" Text="Login" OnClick="Button_Login_Click" />
        </div>
        <div>
            <asp:Label ID="Label_Error" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label>
        </div>

        <div>
            <br />
            <a>Don't have an account ?</a><br />
            <asp:Button ID="Button_Register" runat="server" Text="Register" OnClick="Button_Register_Click" />
        </div>
    </form>
</body>
</html>
