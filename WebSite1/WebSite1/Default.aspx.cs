using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
		lblGradGet.Text = "";
		lblImeGet.Text = "";
		lblImePost.Text = "";
		lblPrezimeGet.Text = "";
		lblPrezimePost.Text = "";
		lblSkolaPost.Text = "";
		if(!string.IsNullOrEmpty(Request.QueryString["txtIme"]))
		{
			Load_Get();
		}
		else if(!string.IsNullOrEmpty(Request.Form["txtIme"]))
		{
			Load_Post();
		}
	}

	private void Load_Get()
	{
		lblImePost.Text = Request.QueryString["txtIme"];
		lblPrezimePost.Text = Request.QueryString["txtPrezime"];
		lblSkolaPost.Text = Request.QueryString["SelectOption"];
	}

	private void Load_Post()
	{
		lblImeGet.Text = Request.Form["txtIme"];
		lblPrezimeGet.Text = Request.Form["txtPrezime"];
		lblGradGet.Text = Request.Form["SelectGrad"];
	}
}