using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
		Nesto n1 = new Nesto(2, 3);
		nestoDrugo n2 = new nestoDrugo(2, 3, 4, 5);
		Nova n3 = new Nova();
		INesto n4 = new Nova();
		n1.a = n1.b + n2.c;
		


		if (Request.Form["hidden1"] == "123")
		{
			Response.Write(Request.Form["i1"]);
			Response.Write(Request.Form["i2"]);
		}
		else if (Request.QueryString["hidden1"] == "Get")
		{
			Response.Write(Request.QueryString["radio1"]);
			Response.Write(Request.QueryString["god"]);
			
		}
		string[] boje = new string[] { "red", "green", "blue", "yellow" };
		for(int i = 1; i < 5; i++)
		{
			string s = "<h"+i+" style=\"color:"+boje[i-1]+"\">H"+i+"</h"+i+">";
			Response.Write(s);
		}

		for (int i = 1; i < 5; i++)
		{
			
			Boje a = (Boje)i;
			string s = "<h" + i + " style=\"color:" + a.ToString() + "\">"+i+"</h" + i + ">";
			Response.Write(s);
		}

	}
	public enum Boje
	{
		Yellow=1,
		Blue=2,
		Red=3,
		Green=4
	}

	public class Nova : INesto
	{
		public string naziv { get { return naziv; } set { naziv = value; } }
		public string Stampa()
		{
			return naziv;
		}
		public int broj;
	}




	public interface INesto
	{
		 string naziv { get; set; }
		 string Stampa();
	}

	public class Nesto {
		 public int a;
		public int b;

		public Nesto(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
	}
	public class nestoDrugo : Nesto
	{
		public int c;
		public int d;
		public nestoDrugo(int a,int b,int c,int d) : base(a, b)
		{
			this.c = c;
			this.d = d;
		}
	}




}