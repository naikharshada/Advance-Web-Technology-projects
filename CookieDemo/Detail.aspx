<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="CookieDemo.Detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="LblSelect" runat="server" Font-Bold="True" Text="you have selected :"></asp:Label>
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Font-Bold="True"></asp:ListBox>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" PostBackUrl="~/Book.aspx">Go Back, select another Book</asp:LinkButton>
        </p>
    </form>
</body>
</html>
