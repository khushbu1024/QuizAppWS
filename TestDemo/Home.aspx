<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TestDemo.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .btncss{
            background-color:bisque;
            font-family:'Times New Roman', Times, serif;
            font-size:medium;
            color:black;
          

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <table>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblQue" runat="server" Text="Question :"></asp:Label>
                        <asp:Label ID="lblQueNo" runat="server" Text=""></asp:Label></td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="txtQue" runat="server" ReadOnly="True" Width="487px" Height="62px" Rows="3" TextMode="MultiLine"></asp:TextBox></td>
                    <td></td>

                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="rbtnA" runat="server" GroupName="ans" Text="" />
                    </td>
                    <td>
                        <asp:RadioButton ID="rbtnB" runat="server" GroupName="ans" Text="" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:RadioButton ID="rbtnC" runat="server" GroupName="ans" Text="" />
                    </td>
                    <td>
                        <asp:RadioButton ID="rbtnD" runat="server" GroupName="ans" Text="" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnNextQue" runat="server" Text="Next" align="right" OnClick="btnNextQue_Click" CssClass="btncss" ToolTip="Click for Next Question" /></td>
                    <td></td>

                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblc" runat="server" Text="Correct Answer:"></asp:Label>
                        <asp:Label ID="lblcorrect" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>

            </table>




        </div>
    </form>
</body>
</html>
