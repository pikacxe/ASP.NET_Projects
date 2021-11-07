using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{

	public string[] paths = new string[]
	{
		"./Slike/0.jpg","~/Slike/1.jpg","~/Slike/2.jpg","./Slike/3.jpg"
	};
	public static int index = 0;
	public class Osoba
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string Grad { get; set; }
		public string Adresa { get; set; }

		public Osoba(string Ime, string Prezime, string Grad, string Adresa)
		{

			this.Ime = Ime;
			this.Prezime = Prezime;
			this.Grad = Grad;
			this.Adresa = Adresa;


			//
			// TODO: Add constructor logic here
			//
		}
	}




	protected void Page_Load(object sender, EventArgs e)
    {




		string[] boje = new string[] { "red", "blue", "green" };
		string[] reci = new string[] { "Mikica", "Relja", "Pilke" };
		//string c = "<p style=\"color:" + boje[1] + "\">" + reci[1] + "</p>";
		for (int i = 0; i < boje.Length; i++)
		{
			string s = "<p style=\"color:" + boje[i] + "\"><br>" + reci[i] + "</p>";
			string c = "<p>" + reci[i] + "</p>";
			Response.Write(s);
		}
		if (!string.IsNullOrEmpty(Request.Form["txtIme"]))
		{
			string txtIme = Request.Form["txtIme"];
			string txtPrezime = Request.Form["txtPrezime"].ToString();
			Response.Write(txtIme+"<br>");
			Response.Write(txtPrezime+"<br>");
			Response.Write("Post");
		}
		else if (!string.IsNullOrEmpty(Request.QueryString["txtIme"]))
		{
			string txtIme = Request.QueryString["txtIme"];
			string txtPrezime = Request.QueryString["txtPrezime"].ToString();
			Response.Write(txtIme);
			Response.Write(txtPrezime);
			Response.Write("Get");
		}





	}

	protected void Event1(object sender, EventArgs e)
	{
		for(int i  = 0; i < 10; i++)
		{
			Response.Write(i + 1);
		}
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		if (index > 0)
		{
			Image1.ImageUrl = paths[--index];
		}
		else
		{
			index = paths.Length - 1;
		}
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		if(index < paths.Length-2)
		{
			Image1.ImageUrl = paths[++index];
		}
		else
		{
			index = 0;
		}
	}
}