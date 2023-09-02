<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="MasterContentApp.Page1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
    <asp:ListItem>C</asp:ListItem>
    <asp:ListItem>C++</asp:ListItem>
    <asp:ListItem>Java</asp:ListItem>
    <asp:ListItem>Python</asp:ListItem>
    <asp:ListItem>C#</asp:ListItem>
</asp:CheckBoxList>
</asp:Content>
