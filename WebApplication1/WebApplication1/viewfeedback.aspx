<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewfeedback.aspx.cs" Inherits="WebApplication1.viewfeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="direction: ltr">
            <br />
            Feedbacks:<br />
            <br />
            <asp:Table ID="Table1" runat="server">
            </asp:Table>
            <asp:Table ID="Table2" runat="server">
            </asp:Table>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
            <br />
        </div>
    </form>
</body>
</html>
