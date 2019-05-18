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
	public partial class LogIn : Form
	{
		MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username =root; password =; database =ventasdirectas");
		int log;
		public LogIn()
		{
			InitializeComponent();
		}

		void Bitacora(string Accion, string ip )
		{
			string query = "INSERT INTO bitacora (USUARIO,ACCION,IP,FECHA_HORA) VALUES ('" + textBox1.Text + "','" + Accion + "','" + ip + "','" + DateTime.Now.ToString("G") + "')";
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{

				consulta.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			log = 0;
			string query = "SELECT * FROM usuarios WHERE Usuario = '" + textBox1.Text + "' AND Password = MD5('" + textBox2.Text + "')";
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);

			try
			{
				databaseConnection.Open();
				consulta.ExecuteNonQuery();
				DataTable respuesta = new DataTable();
				MySqlDataAdapter datos = new MySqlDataAdapter(consulta);
				datos.Fill(respuesta);
				log = Convert.ToInt32(respuesta.Rows.Count.ToString());
				if (log == 1)
				{
					string IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "\n" + addr.ToString();
					}
					Bitacora("LOG IN",IP);
					
					Main menu = new Main(textBox1.Text); menu.Show(); 
					this.Hide();

					databaseConnection.Close();

				}else
				{
					MessageBox.Show("INGRSO INCORRECTO");
					databaseConnection.Close();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR" + ex.ToString());
				databaseConnection.Close();
			}
			

		}

		private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
