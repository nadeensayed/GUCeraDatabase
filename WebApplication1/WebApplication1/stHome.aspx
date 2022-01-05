<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stHome.aspx.cs" Inherits="WebApplication1.stHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="View Assignment" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Submit Assignment" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="View Assignmnet Grade" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Add Feedback" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="List Certificate" OnClick="Button5_Click" />
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Go to Home 1" OnClick="Button6_Click" />
            <br />
        </div>
    </form>
</body>
</html>
