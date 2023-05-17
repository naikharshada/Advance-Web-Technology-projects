<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Book.aspx.cs" Inherits="CookieDemo.Book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Cookie Demo</h2>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Select your Book"></asp:Label>
        <div>
        </div>
        &nbsp;&nbsp;&nbsp;
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Bold="True" Height="40px" Width="98px">
        </asp:RadioButtonList>
        <p>
            <asp:Button ID="BtnAdd" runat="server" Font-Bold="True" Text="Add" OnClick="BtnAdd_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnView" runat="server" Font-Bold="True" Text="View Details" OnClick="BtnView_Click" style="margin-bottom: 0px" />
        </p>
        <p>
            <asp:Label ID="Lblerr" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
