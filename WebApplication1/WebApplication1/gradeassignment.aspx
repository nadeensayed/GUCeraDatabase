<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gradeassignment.aspx.cs" Inherits="WebApplication1.gradeassignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please enter the student and assignment details:<br />
            <br />
            Student Id:<br />
            <asp:TextBox ID="student" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            <br />
            Course Id:<br />
            <asp:TextBox ID="course" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            <br />
            Assignment Number:<br />
            <asp:TextBox ID="number" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            <br />
            Assignment Type:<br />
            <asp:TextBox ID="type" runat="server" MaxLength="10" required="required"></asp:TextBox>
            <br />
            <br />
            Grade:<br />
            <asp:TextBox ID="grade" runat="server" MaxLength="6" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="add" OnClick="Button1_Click" />
        </div>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Back to home" OnClick="Button2_Click" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
