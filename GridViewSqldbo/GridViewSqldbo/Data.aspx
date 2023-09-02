<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="GridViewSqldbo.Data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Employee" DataSourceID="SqlDataSource3">
            <Columns>
                <asp:BoundField DataField="Employee" HeaderText="Employee" ReadOnly="True" SortExpression="Employee" />
                <asp:BoundField DataField="Ename" HeaderText="Ename" SortExpression="Ename" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:MyDbConnectionString %>" SelectCommand="SELECT * FROM [Emp_data]"></asp:SqlDataSource>
        <div>
        </div><br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView><br />
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="Employee" DataSourceID="SqlDataSource3">
            <EditItemTemplate>
                Employee:
                <asp:Label ID="EmployeeLabel1" runat="server" Text='<%# Eval("Employee") %>' />
                <br />
                Ename:
                <asp:TextBox ID="EnameTextBox" runat="server" Text='<%# Bind("Ename") %>' />
                <br />
                City:
                <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                Employee:
                <asp:TextBox ID="EmployeeTextBox" runat="server" Text='<%# Bind("Employee") %>' />
                <br />
                Ename:
                <asp:TextBox ID="EnameTextBox" runat="server" Text='<%# Bind("Ename") %>' />
                <br />
                City:
                <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                Employee:
                <asp:Label ID="EmployeeLabel" runat="server" Text='<%# Eval("Employee") %>' />
                <br />
                Ename:
                <asp:Label ID="EnameLabel" runat="server" Text='<%# Bind("Ename") %>' />
                <br />
                City:
                <asp:Label ID="CityLabel" runat="server" Text='<%# Bind("City") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView><br />
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="Roll No" DataSourceID="SqlDataSource1">
            <Fields>
                <asp:BoundField DataField="Roll No" HeaderText="Roll No" ReadOnly="True" SortExpression="Roll No" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Class" HeaderText="Class" SortExpression="Class" />
                <asp:BoundField DataField="Div" HeaderText="Div" SortExpression="Div" />
                <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoConnectionString2 %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
    </form>
</body>
</html>
