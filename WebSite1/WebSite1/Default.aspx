<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FORM</title>
    <style type="text/css">
        div.Spacer {
            position:relative;
            height:15%;
            width:100%;
            top:0px;
            left:0px;
            background-color:gray;
        
        }
        table{
            position:inherit;
            width:100%;
            height:100%;
            font-size:50px;
            background-color:yellow;
            text-decoration:none;
            text-align:center;
        }
        div.Navigation{
            position:relative;
            top:15%;
            left:0px;
            width:100%;
            height:20%;
            background-color:yellow;

            
        }
        div.POST{
            position:absolute;
            top:35%;
            left:0;
            height:65%;
            width:50%;
            background-color:royalblue;
            float:left;
            color:white;
            font-size:30px;
        }
        div.GET{
            position:absolute;
            top:35%;
            right:0;
            height:65%;
            width:50%;
            background-color:green;
            color:white;
            font-size:30px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div class="Spacer">
            <p> <br /></p>
         </div>
        <div class="Navigation">
            <table>
            <tr>
                <td><a href="GET.html">GET</a></td>
                <td><a href="POST.html">POST</a></td>
                <td><a href="Klasa.aspx">KLASA</a></td>
            </tr>   
            </table>

        </div>
        <div class="POST">
            <asp:Label ID="lblImePost" runat="server" Text="Label"></asp:Label><br />
            <asp:Label ID="lblPrezimePost" runat="server" Text="Label"></asp:Label><br />
            <asp:Label ID="lblSkolaPost" runat="server" Text="Label"></asp:Label><br />
        </div>
        <div class="GET">
            <asp:Label ID="lblImeGet" runat="server" Text="Label"></asp:Label><br />
            <asp:Label ID="lblPrezimeGet" runat="server" Text="Label"></asp:Label><br />
            <asp:Label ID="lblGradGet" runat="server" Text="Label"></asp:Label><br />
        </div>

    </div>
    </form>
</body>
</html>
