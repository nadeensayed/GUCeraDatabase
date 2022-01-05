<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewassignmentInst.aspx.cs" Inherits="WebApplication1.viewassignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Student Assignments:<br />
            <br />
            <asp:Table ID="Table1" runat="server">
            </asp:Table>
            <asp:Table ID="Table2" runat="server">
            </asp:Table>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
