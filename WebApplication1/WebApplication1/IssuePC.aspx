<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssuePC.aspx.cs" Inherits="WebApplication1.IssuePC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                Student ID<br />
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Number" required="required"></asp:TextBox>
        <br />
        PromoCode (Max 6)<br />
        <asp:TextBox ID="TextBox2" runat="server" MaxLength="6" required="required"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Issue" />
        </div>
    </form>
</body>
</html>
