<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addfeedback.aspx.cs" Inherits="WebApplication1.addfeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Feedback:<br />
            <br />
            Comment:<br />
            <asp:TextBox ID="comment" runat="server"  required="required"></asp:TextBox>
            <br />
            <br />
            Course ID:<br />
            <asp:TextBox ID="cid" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
