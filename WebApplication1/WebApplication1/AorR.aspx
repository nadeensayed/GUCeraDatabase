<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AorR.aspx.cs" Inherits="WebApplication1.AorR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Course ID</div>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Number" required="required" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Accept Course" OnClick="Button1_Click" />
    </form>
</body>
</html>
