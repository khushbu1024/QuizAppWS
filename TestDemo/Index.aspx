<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TestDemo.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Welcome !!!!"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Enter Your Name "></asp:Label>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <asp:Button ID="btn_start" runat="server" Text="Start Quiz" OnClick="btn_start_Click" />
    </div>
    </form>
</body>
</html>
