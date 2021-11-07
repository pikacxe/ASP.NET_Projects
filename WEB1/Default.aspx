<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MasterPage</title>
    <link  rel="Stylesheet" type="text/css" href="StyleSheet.css"  />
</head>
<body>
   
    <div id="holder">
        <div id="blank">
            <br />
        </div>
        <div id="navigation">
            <table>
            <tr>
            <th><a href="GET.html"><h1>GET</h1></a></th>
            <th><a href="POST.html"><h1>POST</h1></a></th>
            <th><a href="Klasa.aspx"><h1>KLASA</h1></a></th></tr>
            </table>

        </div>
        <div id="result">
            <div class="result" style="background-color:red">
               <h2>GET</h2>
                <asp:Label ID="LabelGet" runat="server" Text="Label"></asp:Label>
            </div>
            <div class="result">
                <h2>POST</h2>
                <asp:Label ID="LabelPost" runat="server" Text="Label"></asp:Label>
            </div>
        </div>

    
    </div>

</body>
</html>
