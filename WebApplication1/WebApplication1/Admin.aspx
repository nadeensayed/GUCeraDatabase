<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication1.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View All Courses"  />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="View Non-Accepeted Courses" />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Issue PromoCode"  />
        <br />
        <asp:Button ID="Button6" runat="server" Text="Accept Course" OnClick="Button6_Click" />
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Create PromoCode" />
        
            <br />
            <asp:Button ID="Button7" runat="server" Text="Add Mobile" OnClick="Button7_Click" />
        
            <p>
                <asp:Button ID="Button8" runat="server" Text="Log Out" OnClick="Button8_Click" />
            </p>
        
    </form>
</body>
</html>
