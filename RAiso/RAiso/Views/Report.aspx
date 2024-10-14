<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="RAiso.Views.Report" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

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
            <a href="AdminHomePage.aspx">Home</a>
        </div>
        <div>
            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
        </div>
    </form>
</body>
</html>
