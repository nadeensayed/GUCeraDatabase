<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addmobile.aspx.cs" Inherits="WebApplication1.addmobile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please enter your phone number:<br />
            <asp:TextBox ID="mobile" runat="server" MaxLength="11"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="submit" runat="server" Text="submit" OnClick="submit_Click" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Back to home" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
