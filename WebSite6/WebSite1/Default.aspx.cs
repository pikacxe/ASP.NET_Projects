using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
		Response.Write(Request.QueryString["txt1"]);
		Response.Write(Request.QueryString["txt2"]);
		Response.Write(Request.QueryString["txt3"]);
		



	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		int n = int.Parse(TextBox1.Text);
		Response.Write("<ul>");
		for(int i = 0; i < n; i++)
		{
			Response.Write("<li>Element" + i + "</li>");
		}
		Response.Write("</ul>");
	}
	public class Poker
	{
		public string znak;
		public int broj;

		public Poker(string znak, int broj)
		{
			this.znak = znak;
			this.broj = broj;
		}
	}
}