<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication1.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please enter your information below:<br />
            <br />
            First Name:<br />
            <asp:TextBox ID="firstname" runat="server" MaxLength="10" ></asp:TextBox>
            <br />
            Last Name:<br />
            <asp:TextBox ID="lastname" runat="server" MaxLength="10" ></asp:TextBox>
            <br />
            Password:<br />
            <asp:TextBox ID="password" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            Email:<br />
            <asp:TextBox ID="email" runat="server" MaxLength="10" TextMode="Email"></asp:TextBox>
            <br />
            Gender:(male/female)<br />
            <asp:TextBox ID="gender" runat="server" ></asp:TextBox>
            <br />
            Address:<br />
            <asp:TextBox ID="address" runat="server" MaxLength="10" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="student" runat="server" Text="Register as a student" OnClick="student_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="instructor" runat="server" Text="Register as an instructor" OnClick="instructor_Click" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
