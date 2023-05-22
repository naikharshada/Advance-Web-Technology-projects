<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uploader.aspx.cs" Inherits="FileUploder.Uploader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>File Uploader</h2>
        <div>
             <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
      
          <p>  <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />  </p>
           <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
            
    </form>
</body>
</html>
      
                 
            
      
      
   
