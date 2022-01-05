<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePC.aspx.cs" Inherits="WebApplication1.CreatePC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             Code
             <br />
&nbsp;<asp:TextBox ID="TextBox1" runat="server"  required="required" MaxLength="6"></asp:TextBox>
        <br />
             Issue Date <br />
        <asp:TextBox type="date"  ID="TextBox3" runat="server" TextMode="Date" required="required"></asp:TextBox>
        <br />
             Expiry Date <br />
        <asp:TextBox type="date" ID="TextBox2" runat="server" TextMode="Date" required="required"></asp:TextBox>
        <br />
        Discount
        <br />
        <asp:TextBox ID="TextBox4" runat="server" required="required" MaxLength="5"></asp:TextBox>
        <br />
        &nbsp;<br />
        <asp:Button ID="Button1" runat="server" Text="Create" OnClick="Button1_Click" />
        <br />
             </div>
    </form>
</body>
</html>
