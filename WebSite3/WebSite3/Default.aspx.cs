using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
	enum Boje
	{
		Red=1,
		Blue=2,
		Green=3,
		Yellow=4,

	}
	string[] boje = new string[] { "red", "green", "blue" , "yellow"};


	public class Nije
	{
		int b;
		int c;
		public Nije(int b,int c)
		{
			this.b = b;
			this.c = c;
		}
	}


	protected void Page_Load(object sender, EventArgs e)
	{
		//for(int i = 0; i < boje.Length; i++)
		//{

		//	string s = "<h"+(i+1)+" style=\"color:"+boje[i]+"\">H"+(i+1)+"</h"+(i+1)+">";
		//	Response.Write(s);
		//}
		//for (int i = 0; i < 4; i++)
		//{
		//	Boje a = (Boje)(i+1);
		//	string s = "<h" + (i + 1) + " style=\"color:" +a.ToString() + "\">H" + (i + 1) + "</h" + (i + 1) + ">";
		//	Response.Write(s);
		//}
		if (Request.QueryString["hidden"] == "1")
		{
			Response.Write("Get<br>");
			Response.Write(Request.QueryString["txtIme"]);
		}
		else if (Request.Form["hidden"] == "2")
		{
			Response.Write("Post<br>");
			Response.Write(Request.Form["txtIme"]);
		}
		Nije A = new Nije(2, 6);
		
	}



}