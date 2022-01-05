<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnrollCourse.aspx.cs" Inherits="WebApplication1.EnrollCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Course ID<br />
            <asp:TextBox ID="CourseID" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            Instructor ID<br />
            <asp:TextBox ID="InstructorID" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="Enroll" runat="server" OnClick="Button1_Click" Text="Enroll" />
    </form>
</body>
</html>
