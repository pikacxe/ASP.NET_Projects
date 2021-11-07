using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Klasa : System.Web.UI.Page
{

	public class Ptica
	{
		public string Vrsta { get; set; }
		public string Slika { get; set; }
		public int Tezina { get; set; }
		public Ptica(string vrsta, string slika, int tezina)
		{
			Vrsta = vrsta;
			Slika = slika;
			Tezina = tezina;
		}


	}
	public static int index = 0;

	public static Ptica[] ptice = new Ptica[]{
		new Ptica("Gugutka","./Slike/Gugutka.jpg",400),
		new Ptica("Papagaj","./Slike/Papagaj.jpg",200),
		new Ptica("Sova","./Slike/Sova.jpg",1500)
		};

	protected void Page_Load(object sender, EventArgs e)
	{
		Load_Class(0);
	}
	public void Load_Class(int i)
	{
		Image1.ImageUrl = ptice[i].Slika;
		Label1.Text = ptice[i].Vrsta;
	}


	protected void Button1_Click(object sender, EventArgs e)
	{

		if (index == 0)
		{
			index = ptice.Length-1;
		}
		else
		{
			index--;
		}
		Load_Class(index);
	}

	protected void ADC(object sender, EventArgs e)
	{
		if(index < ptice.Length - 1)
		{
			++index;
		}
		else
		{
			index = 0;
		}
		Load_Class(index);
	}
}