<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="choosecer.aspx.cs" Inherits="WebApplication1.choosecer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            Please choose the course you would like to view its certificate:<br />
            <br />
            <asp:TextBox ID="course" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="choose" OnClick="Button1_Click" />
        </p>
        </div>
    </form>
</body>
</html>
