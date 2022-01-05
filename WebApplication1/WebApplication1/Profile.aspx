<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebApplication1.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div>
            <asp:Button ID="GO" runat="server" Text="View Courses" OnClick="Button1_Click" />&nbsp;<asp:Button ID="GO2" runat="server" Text="Enroll in course" OnClick="GO2_Click" />
        &nbsp;<asp:Button ID="GO3" runat="server" Text="Add Credit Card" OnClick="GO3_Click" />
        &nbsp;<asp:Button ID="GO4" runat="server" Text="View Issued PromoCode" OnClick="GO4_Click" />
        &nbsp;<asp:Button ID="Button1" runat="server" Text="Add Mobile" OnClick="Button1_Click1" />
              <br />
              <br />
        
          <asp:Button ID="Button2" runat="server" Text="Go To Home 2" OnClick="Button2_Click" />
          <asp:Button ID="Button3" runat="server" Text="Log Out" OnClick="Button3_Click" />
          <br />
          <br />
              </div>
          My Profile:<br />
    </form>
</body>
</html>
