<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
    </form>
    <br /><br /><br /><br />
    <form method="post" action="Default.aspx">
        Post<br />
        Ime:<br />
        <input id="Text1" type="text" name="txtIme"/><br />
        Prezime:<br />
        <input id="Text2" type="text" name="txtPrezime"/><br />
        <input id="Hidden1" type="hidden" name="hidden" value="2"/>
        <input id="Submit1" type="submit" value="Posalji" />
    </form>
        <form method="get" action="Default.aspx">
        Get<br />
        Ime:<br />
        <input id="Text3" type="text" name="txtIme"/><br />
        Prezime:<br />
        <input id="Text4" type="text" name="txtPrezime"/><br />
        <input id="Hidden2" type="hidden" name="hidden" value="1"/>
        <input id="Submit2" type="submit" value="Posalji" />
    </form>



</body>
</html>
