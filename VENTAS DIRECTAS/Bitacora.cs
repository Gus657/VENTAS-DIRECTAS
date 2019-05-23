using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;

namespace VENTAS_DIRECTAS
{
	
	public partial class Bitacora : Form
	{
		MySqlConnection databaseConnection = new MySqlConnection("datasource = 192.168.1.5; port = 3306; username =repl; password =slavepassword; database =ventasdirectas");


		public Bitacora()
		{
			InitializeComponent();
			llenartabla();

		}

		void llenartabla()
		{

			MySqlCommand codigo2 = new MySqlCommand();
			codigo2.Connection = databaseConnection;
			codigo2.CommandText = ("SELECT * FROM bitacora order by numero DESC");
			try
			{
				MySqlDataAdapter ejecutar = new MySqlDataAdapter();
				ejecutar.SelectCommand = codigo2;
				DataTable datostabla = new DataTable();
				ejecutar.Fill(datostabla);
				dataGridView2.DataSource = datostabla;
				ejecutar.Update(datostabla);
				databaseConnection.Close();

			}
			catch (Exception e)
			{
				MessageBox.Show("ERROR" + e.ToString());
				databaseConnection.Close();
			}

			try
			{
				comboBox2.Text = "Usuarios";
				comboBox2.Items.Clear();

				databaseConnection.Open();
				MySqlCommand command = new MySqlCommand("SELECT * FROM usuarios  ", databaseConnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox2.Refresh();
					comboBox2.Items.Add(reader.GetValue(0).ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			databaseConnection.Close();
		}

	

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}


		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			MySqlCommand codigo2 = new MySqlCommand();
			codigo2.Connection = databaseConnection;
			codigo2.CommandText = ("SELECT * FROM bitacora where usuario = '"+ comboBox2.Text+ "' order by numero DESC");
			try
			{
				MySqlDataAdapter ejecutar = new MySqlDataAdapter();
				ejecutar.SelectCommand = codigo2;
				DataTable datostabla = new DataTable();
				ejecutar.Fill(datostabla);
				dataGridView2.DataSource = datostabla;
				ejecutar.Update(datostabla);
				databaseConnection.Close();

			}
			catch (Exception exx)
			{
				MessageBox.Show("ERROR" + exx.ToString());
				databaseConnection.Close();
			}
		}
	}
}
