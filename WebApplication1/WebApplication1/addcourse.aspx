<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addcourse.aspx.cs" Inherits="WebApplication1.addcourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please add course details:<br />
            credit hours:<br />
            <asp:TextBox ID="credithours" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            name:<br />
            <asp:TextBox ID="name" runat="server" MaxLength="10" required="required"></asp:TextBox>
            <br />
            price:<br />
            <asp:TextBox ID="price" runat="server" MaxLength="7" TextMode="Number" required="required"></asp:TextBox>
            <br />
        </div>
        <p>
            <asp:Button ID="add" runat="server" Text="add" OnClick="add_Click" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Back to home" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
