<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <a href="HtmlPage.html">Post</a><br />
            POST:<br />
    <form method="post" action="Default.aspx">
        Ime:<input id="Text1" type="text" name="i1"/><br />
        Prezime:<input id="Text2" type="text" name="i2"/><br />
        <input id="Submit1" type="submit" value="submit" />
        <input id="Hidden1" type="hidden" value="123" name="hidden1"/>
    </form><br />
    GET:<br />
    <form method="get" action="Default.aspx">
        Pol:<br /><input id="Radio1" type="radio" name="radio1" value="Musko" />
                  <input id="Radio1" type="radio" name="radio1" value="Zensko"/>
              Godine:<input id="Text1" type="text" name="god"/>
              <input id="Submit1" type="submit" value="submit" />
              <input id="Hidden1" type="hidden" value="Get" name="hidden1" />
    </form>
    </div>
    </form>
</body>
</html>
