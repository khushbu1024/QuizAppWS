<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="TestDemo.result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        

        
        <p><asp:Label ID="lblname" runat="server" Text=""></asp:Label> Thank you for Quiz </p>
        <p>
            Your Score is <asp:Label ID="lblscore" runat="server" Text=""></asp:Label>
        </p>
        <br />
    </div>
    </form>
</body>
</html>
