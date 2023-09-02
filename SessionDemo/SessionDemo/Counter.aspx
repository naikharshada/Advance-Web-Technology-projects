<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Counter.aspx.cs" Inherits="SessionDemo.Counter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Counter Demo</h2>
        <div>
            <asp:Label ID="Label1" runat="server" Text="LblCounter" Font-Bold></asp:Label>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Height="23px" Text="Increment" Width="80px" Font-Bold OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
