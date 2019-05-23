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
	public partial class LogIn_Users : Form
	{
		MySqlConnection databaseConnection = new MySqlConnection("datasource = 192.168.1.5; port = 3306; username =repl; password =slavepassword; database =ventasdirectas"); int log;
		public LogIn_Users()
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
				MessageBox.Show(ex.ToString());
			}
		}

		string nivel()
		{
			string nivel = "";
			MySqlConnection databaseConnection2 = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username =root; password =; database =ventasdirectas");
			string query = "SELECT * FROM `usuarios` WHERE Usuario = '" + textBox1.Text + "' AND Password = MD5('" + textBox2.Text + "')";
			MySqlCommand consultanivel = new MySqlCommand(query, databaseConnection2);
			consultanivel.CommandTimeout = 60;
			try
			{
				databaseConnection2.Open();
				MySqlDataReader Reader = consultanivel.ExecuteReader();
				if (Reader.HasRows)
				{
					while (Reader.Read())
					{
						nivel = Reader.GetString(2);
					}
				}
				else { MessageBox.Show("ERROR"); }
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR" + ex.ToString());

			}
			databaseConnection.Close();
			return nivel;
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
				if (log == 1 && nivel() == "0")
				{

					string IP = "";
					IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
					foreach (IPAddress addr in localIPs)
					{
						IP += "   |   " + addr.ToString();
					}
					databaseConnection.Close();
					databaseConnection.Open();
					Bitacora("LOG IN USUARIOS",IP);
					
					Usuarios menu = new Usuarios(textBox1.Text); menu.Show(); 
					this.Hide();

					databaseConnection.Close();

				}else
				{
					MessageBox.Show("Permisos insuficientes...");
					databaseConnection.Close();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR" + ex.ToString());
				databaseConnection.Close();
			}
			

		}

		private void LogIn_Users_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}
	}
}
