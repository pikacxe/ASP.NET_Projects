using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Klasa : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{


		Animal[] niz = new Animal[4]
		{
		new Bird("Papagaj","~/Slike/Papagaj.jpg",false,200),
		new Bird("Soko","~/Slike/Soko.jpg",false,5000),
		new SeaAnimal("Delfin","~/Slike/Delfin.jpg",true),
		new SeaAnimal("Ajkula","~/Slike/Ajkula.jpg",false)
		};
		Niz = niz;
		Image1.ImageUrl = niz[0].SlikaUrl;
		TextBox1.Text = FormatDescription(0);

	}

	
	public class Animal
{
	public string type;
	public string SlikaUrl;

	public Animal(string type, string slikaUrl)
	{
		this.type = type;
		SlikaUrl = slikaUrl;
	}
}
	public class Bird : Animal
{
	public bool selica;
	public int tezina;

	public Bird(string type, string SlikaUrl, bool selica, int tezina) : base(type, SlikaUrl)
	{
		this.selica = selica;
		this.tezina = tezina;
	}
}
	public class SeaAnimal : Animal
{
	public bool sisar;

	public SeaAnimal(string type, string slikaUrl, bool sisar) : base(type, slikaUrl)
	{
		this.sisar = sisar;
	}
}

	public Animal[] Niz = new Animal[4];
	public static int counter = 0;
	protected void Previous_Click(object sender, EventArgs e)
	{
		if(counter == 0)
		{
			ChangeImage(3);
			TextBox1.Text = FormatDescription(3);
		
		}
		else
		{
			ChangeImage(counter--);
			TextBox1.Text = FormatDescription(counter);
		}
	}
	protected void Next_Click(object sender,EventArgs e)
	{
		if(counter < 3)
		{
			ChangeImage(counter++);
			TextBox1.Text = FormatDescription(counter);
		}
		else
		{
			ChangeImage(0);
			TextBox1.Text = FormatDescription(0);
		}
	
	}
	public void ChangeImage(int index)
	{
		switch (index)
		{
			case 0:Image1.ImageUrl = Niz[0].SlikaUrl;break;
			case 1:Image1.ImageUrl = Niz[1].SlikaUrl;break;
			case 2: Image1.ImageUrl = Niz[2].SlikaUrl; break;
			case 3: Image1.ImageUrl = Niz[3].SlikaUrl; break;
		}
	}
	public string FormatDescription(int index)
	{
		if(Niz[index] is Bird)
		{
			return "Ptica vrste:"+Niz[index].type;
		}
		else
		{
			return "Vodena zivotinja vrste:" + Niz[index].type; 
		}
	}
}