<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfileAdminPage.aspx.cs" Inherits="RAiso.Views.UpdateProfileAdminPage" %>

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
            <a href="AdminHomePage.aspx">back</a>
        </div>

        <div>
            <asp:GridView ID="GridView_AdminData" runat="server"></asp:GridView>
        </div>
        <br />
        <div>
            <a>Insert new profile below :</a>
        </div>
        <br />
        <div>
            <asp:Label ID="Label_Name" runat="server" Text="Name"></asp:Label><br />
            <asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_DOB" runat="server" Text="Date Of Birth"></asp:Label><br />
            <asp:TextBox ID="TextBox_DOB" runat="server" placeholder="DD/MM/YYYY"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_Gender" runat="server" Text="Gender"></asp:Label><br />
            <asp:RadioButtonList ID="Radio_Gender" runat="server">
                <asp:ListItem Value="Male">Male</asp:ListItem>
                <asp:ListItem Value="Female">Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="Label_Address" runat="server" Text="Address"></asp:Label><br />
            <asp:TextBox ID="TextBox_Address" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_Password" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="TextBox_Password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_PhoneNumber" runat="server" Text="Phone Number"></asp:Label><br />
            <asp:TextBox ID="TextBox_PhoneNumber" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button_Update" runat="server" Text="Submit Update" OnClick="Button_Update_Click" />
            <asp:Label ID="Label_Error" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label>
        </div>

    </form>
</body>
</html>
