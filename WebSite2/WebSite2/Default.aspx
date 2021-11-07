<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <%
          //Response.Write("<table style=\"width: 100%;border:2px solid red\"><tr><td>1</td><td>2</td><td>3</td></tr><tr> <td>A</td><td>B</td><td>C</td> </tr></table>");

          %>
        <a href="Post.html">Post</a>
        <a href="Get.html">Get</a><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><br />
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="Event1"></asp:TextBox>

        <asp:Image ID="Image1" runat="server" Width="800px" Height="600px" /><br />
        <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" /><br />
        <asp:Button ID="Button2" runat="server" Text="Previous" OnClick="Button2_Click" />
 </div>
    </form>
</body>
</html>
