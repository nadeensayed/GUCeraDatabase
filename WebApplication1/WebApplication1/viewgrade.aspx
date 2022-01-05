<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewgrade.aspx.cs" Inherits="WebApplication1.viewgrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please enter the assignment details:<br />
            <br />
            Course Id:<br />
            <asp:TextBox ID="course" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            <br />
            Assignment Number:<br />
            <asp:TextBox ID="number" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            <br />
            Assignment Type:<br />
            <asp:TextBox ID="type" runat="server" MaxLength="10" required="required"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="view" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
