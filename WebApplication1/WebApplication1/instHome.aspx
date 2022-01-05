<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instHome.aspx.cs" Inherits="WebApplication1.instHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Add Mobile" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Add Course" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Define Assignments" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="View Assignments" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="Grade Assignments" OnClick="Button5_Click" />
            <asp:Button ID="Button6" runat="server" Text="Issue Certificate" OnClick="Button6_Click" />
            <asp:Button ID="Button7" runat="server" Text="View Feedbacks" OnClick="Button7_Click" />
            <br />
            <br />
        </div>
        <asp:Button ID="Button8" runat="server" Text="Log Out" OnClick="Button8_Click" />
    </form>
</body>
</html>
