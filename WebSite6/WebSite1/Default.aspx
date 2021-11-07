<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
    <%
        Poker p1 = new Poker("Herc", 1);
        Poker p2 = new Poker("Karo",10);
        Poker p3 = new Poker("Pik",4);
        Poker p4 = new Poker("Tref",7);
        Response.Write(p1.broj);
        Response.Write("<br>" + p1.znak);

        %>




</body>
</html>
