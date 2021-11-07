using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public static string connectionString = @"Data Source=ILIJA\SQLEXPRESS;Initial Catalog=BikeStores;Integrated Security=True";
		SqlConnection con = new SqlConnection(connectionString);
		public DataSet data = new DataSet();
		public void TestConnection()
		{
			try
			{
				con.Open();
				MessageBox.Show("Test connection executed succesfully");
			}
			catch(Exception e)
			{
				MessageBox.Show("Eror:" + e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		public void Query(string command)
		{
			SqlCommand com;
			try
			{
				richTextBox1.Clear();
				con.Open();
				com = new SqlCommand(command, con);
				SqlDataReader r = com.ExecuteReader();
				while (r.Read())
				{
					for (int i = 0; i < r.FieldCount; i++)
					{
						richTextBox1.AppendText(r[i].ToString() + " ");

					}
					richTextBox1.AppendText("\n");
				}
				r.Close();
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		public void GridView(string command,char c)
		{
			try
			{
				con.Open();
				if (c == 's')
				{
					DataTable table = new DataTable();
					SqlDataAdapter adp = new SqlDataAdapter(new SqlCommand(command, con));
					adp.Fill(table);
					dataGridView1.DataSource = table;
					dataGridView1.Refresh();
				}
				if(c == 'u')
				{
					SqlCommand cmd = new SqlCommand(command, con);
					cmd.ExecuteNonQuery();
					
					dataGridView1.Refresh();
					dataGridView1.Update();
					
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				con.Close();
			}
		}

		public void Load_Data()
		{
			try
			{
				con.Open();
				DataTable table = new DataTable();
				SqlDataAdapter adp = new SqlDataAdapter("select * from production.brands", con);
				adp.Fill(table); data.Tables.Add(table); table = new DataTable();
				adp = new SqlDataAdapter("select * from production.categories", con);
				adp.Fill(table); data.Tables.Add(table); table = new DataTable();
				adp = new SqlDataAdapter("select * from production.products", con);
				adp.Fill(table); data.Tables.Add(table); table = new DataTable();
				adp = new SqlDataAdapter("select * from production.stocks", con);
				adp.Fill(table); data.Tables.Add(table); table = new DataTable();
				adp = new SqlDataAdapter("select * from sales.customers", con);
				adp.Fill(table); data.Tables.Add(table); table = new DataTable();
				adp = new SqlDataAdapter("select * from sales.order_items", con);
				adp.Fill(table); data.Tables.Add(table); table = new DataTable();
				adp = new SqlDataAdapter("select * from sales.orders", con);
				adp.Fill(table); data.Tables.Add(table); table = new DataTable();
				adp = new SqlDataAdapter("select * from sales.staffs", con);
				adp.Fill(table); data.Tables.Add(table); table = new DataTable();
				adp = new SqlDataAdapter("select * from sales.stores", con);
				adp.Fill(table); data.Tables.Add(table); table = new DataTable();
			}
			catch(Exception e) { MessageBox.Show(e.Message); }
			finally
			{
				con.Close();
			}
		}

		public Form1()
		{
			InitializeComponent();
			TestConnection();
			Load_Data();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text != "")
			{
				Query(textBox1.Text);
				textBox1.Text = "";
			}
			else
			{
				MessageBox.Show("Please insert query!");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				GridView(textBox1.Text,'s');
				
			}
			else
			{
				MessageBox.Show("Please insert query!");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				GridView(textBox1.Text,'u');
				
			}
			else
			{
				MessageBox.Show("Please insert query!");
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindingSource b = new BindingSource();
			b.DataSource = data.Tables[((ComboBox)sender).SelectedIndex];
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = b;
		}
	}
}
