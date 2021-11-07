<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<%--        <asp:Image ID="Image1" runat="server" Width="400" Height="400" />
        <asp:Image ID="Image2" runat="server" Width="400" Height="400"/>
        <asp:Image ID="Image3" runat="server" Width="400" Height="400"/>
        <asp:Button ID="Button1" runat="server" Text="Menjaj" OnClick="Button1_Click"/>--%><br /><br /><br />
        <form method="get" action="Default.aspx">
            Ime<br />
            <input id="Text1" type="text" name="txt1"/><br />
            <input id="Hidden1" type="hidden" value="1" name="hidden"/>
            <input id="Submit1" type="submit" value="submit" />
        </form>
        <form method="post" action="Default.aspx">
            Ime<br />
            <input id="Text2" type="text" name="txt1"/><br />
            <input id="Hidden2" type="hidden" value="2" name="hidden"/>
            <input id="Submit2" type="submit" value="submit" />
    </form>
</body>
</html>
