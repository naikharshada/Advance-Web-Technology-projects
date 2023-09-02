<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="SessionDemo.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Session Demo</h2>
        <asp:Label ID="Label1" runat="server" Text="Enter Name : " Font-Bold></asp:Label>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        <div>
        </div><br />
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" Font-Bold OnClick="BtnSubmit_Click"/>
    </form>
</body>
</html>
