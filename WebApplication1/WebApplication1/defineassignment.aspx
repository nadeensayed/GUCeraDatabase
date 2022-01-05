<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="defineassignment.aspx.cs" Inherits="WebApplication1.defineassignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please enter assignment details:<br />
            <br />
            Course id:<br />
            <asp:TextBox ID="course" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            Assignment number:<br />
            <asp:TextBox ID="number" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            Assignment type :<br />
            <asp:TextBox ID="type" runat="server" MaxLength="10" required="required"></asp:TextBox>
            <br />
            Full grade:<br />
            <asp:TextBox ID="fullgrade" runat="server" TextMode="Number" required="required"></asp:TextBox>
            <br />
            Weight:<br />
            <asp:TextBox ID="weight" runat="server" MaxLength="5" required="required" ></asp:TextBox>
            <br />
            Deadline(MM/DD/YYYY):<br />
            <asp:TextBox ID="deadline" runat="server" MaxLength="10" TextMode="Date" required="required"></asp:TextBox>
            <br />
            Content:<br />
            <asp:TextBox ID="content" runat="server" MaxLength="200"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="add" OnClick="Button1_Click" />
            <br />
            <br />
        </div>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Back to home" OnClick="Button2_Click" />
        </p>
    </form>
</body>
</html>
