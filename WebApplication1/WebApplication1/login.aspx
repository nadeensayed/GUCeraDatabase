<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please enter your id and password:<br />
            <br />
            ID :<br />
            <asp:TextBox ID="id" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            <br />
            Password:</div>
        <asp:TextBox ID="password" runat="server" TextMode="Password" required="required"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="log" runat="server" Text="Login" OnClick="log_Click" />
        <br />
        <br />
        Dont have an account?<br />
        <p>
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
