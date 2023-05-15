<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AdRotatorProject.form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            <h1>Adrotator  program</h1>
        
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Advertisement.xml" OnAdCreated="AdRotator1_AdCreated" />
        
           
        
    </form>
</body>
</html>
