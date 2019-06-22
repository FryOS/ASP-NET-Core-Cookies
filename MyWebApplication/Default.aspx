<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" 
    Inherits="MyWebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
            Введите Текст
            <asp:TextBox ID="Name" runat="server" Width="109px"></asp:TextBox>
        <br /><asp:Button ID="GetResult" runat="server" Text="Button" style="height: 25px" OnClick="GetResult_Click"/>
            
        <br />       
            <asp:Label ID="Result" runat="server" Text="Result" ForeColor="#FF0066"></asp:Label>
        
        
    </form>
</body>
</html>
