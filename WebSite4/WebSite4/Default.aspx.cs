using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
	public enum Boje
	{
		Red = 1,
		Green = 2,
		Blue = 3,
		Yellow = 4
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		//string[] boje = new string[] { "red", "green", "blue","yellow"};
		//for(int i = 0; i < 4; i++)
		//{
		//	string s = "<h"+(i+1)+" style=\"color:"+boje[i]+"\">H"+(i+1)+"</h"+(i+1)+">";
		//	Response.Write(s);
		//}
		//for(int i = 0; i < 4; i++)
		//{
		//	Boje a = (Boje)(i+1);//a = Boje.Red.ToString()="Red"
		//	string s = "<h" + (i+1) + " style=\"color:" +a.ToString() + "\">H" + (i + 1) + "</h" + (i + 1) + ">";
		//	Response.Write(s);
		//}
		//Image1.ImageUrl = "./Slike/Gugutka.jpg";
		//Image2.ImageUrl = "./Slike/Papagaj.jpg";
		//Image3.ImageUrl = "./Slike/Sova.jpg";
		if (Request.QueryString["hidden"]=="1")
		{
			Response.Write("Get<br>"+Request.QueryString["txt1"]);
		}
		if (Request.Form["hidden"] == "2")
		{
			Response.Write("Post<br>" + Request.Form["txt1"]);
		}






	}
	static string pom, pom1;
	protected void Button1_Click(object sender, EventArgs e)
	{
		
		//pom = Image1.ImageUrl;
		//pom1 = Image2.ImageUrl;
		//Image1.ImageUrl = Image3.ImageUrl;
		//Image2.ImageUrl = pom;
		//Image3.ImageUrl = pom1;
	}
}