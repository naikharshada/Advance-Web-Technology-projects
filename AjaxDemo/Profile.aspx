<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="AjaxDemo.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Ajax Demo</h2>
        <div>
            <asp:Image ID="Image1" runat="server" Height="160px" ImageUrl="~/lotus.jpg" Width="135px" />
        <p>
            <asp:Label ID="lblname" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Harshada Naik"></asp:Label>
        </p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Good in SQL"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="MCA"></asp:Label>
        </p>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Reading, Acting"></asp:Label>
        <br />
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:UpdatePanel ID="Update1" runat="server">
            <ContentTemplate>Quote of the Day : 
                <asp:Label ID="lblquote" Font-Size="X-Large" runat="server" BackColor="Teal"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
        </asp:UpdatePanel>
            <br />
                    </div>
        <asp:Timer ID="Timer1" runat="server" Interval="1500" OnTick="Timer1_Tick"></asp:Timer>
        <br />

        <asp:UpdatePanel ID="Update2" runat="server">
            <ContentTemplate> Time is :
                <asp:Label ID ="lbltime" runat="server" Font-Bold="true" Font-Size="Large"></asp:Label>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>

         <asp:Timer ID="Timer2" runat="server" Interval="2000" OnTick="Timer2_Tick"></asp:Timer>
    </form>
</body>
</html>
