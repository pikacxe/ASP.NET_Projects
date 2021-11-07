<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Klasa.aspx.cs" Inherits="Klasa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Klasa</title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" style="height:600px;width:800px;"/><br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="Previous" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Next" OnClick="ADC"/>
        </div>
    </form>
</body>
</html>
