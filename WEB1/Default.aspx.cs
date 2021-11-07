using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
		LabelPost.Text = "";
		LabelGet.Text = "";
		//if (!string.IsNullOrEmpty(Request.Form["ImePost"]))
		//{
			LabelPost.Text = Request.Form["ImePost"] + " " + Request.Form["PrezimePost"] + "\n" + Request.Form["SelectPost"];
		//}
		//else if (!string.IsNullOrEmpty(Request.QueryString["ImeGet"]))
		//{
			LabelGet.Text = (Request.QueryString["ImeGet"] + " " + Request.QueryString["PrezimeGet"] + "\n" + Request.QueryString["Selectget"] + "\n" + Request.QueryString["RadioGet"]) as string;
		//}
    }
}