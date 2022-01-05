<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreditCard.aspx.cs" Inherits="WebApplication1.CreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Credit Card Number<br />
            <asp:TextBox ID="CardNumber" runat="server" MaxLength="15" required="required"></asp:TextBox>
            <br />
            Name
            <br />
            <asp:TextBox ID="Name" runat="server" MaxLength="16" required="required"></asp:TextBox>
            <br />
            Expiry Date<br />
            <asp:TextBox ID="ExpiryDate" runat="server" TextMode="Date" required="required"></asp:TextBox>
            <br />
            Cvv<br />
            <asp:TextBox ID="Cvv" runat="server" MaxLength="3" required="required"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="GO" runat="server" OnClick="Submit" Text="Submit" />
            <br />
    </form>
</body>
</html>
