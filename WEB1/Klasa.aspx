<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Klasa.aspx.cs" Inherits="Klasa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Klasa</title>
    <link rel="stylesheet" href="StyleSheet.css" type="text/css" />
</head>
<body>
        <div id="main">

            <div id="SlikaDiv">
                <asp:Image ID="Image1" runat="server" />
            </div>
            <form runat="server" id="form">
            <asp:Button ID="Previous" runat="server" Text="Previous" OnClick="Previous_Click" />
            <asp:Button ID="Next" runat="server" Text="Next" OnClick="Next_Click" /><br />
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
            </form>
        </div>
</body>
</html>
