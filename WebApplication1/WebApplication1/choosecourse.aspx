<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="choosecourse.aspx.cs" Inherits="WebApplication1.choosecourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please choose the course you would like to view its assignments:<br />
            <br />
            <asp:TextBox ID="course" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="choose" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Back to home" OnClick="Button2_Click" />
        </p>
    </form>
</body>
</html>
