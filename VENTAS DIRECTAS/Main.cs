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
	public partial class Main : Form
	{
		MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username =root; password =; database =ventasdirectas");
		string usuario;
		public Main(string user)
		{
			InitializeComponent();
			 usuario = user;
			
		}


		void Bitacora(string Accion, string ip, string user)
		{
			string query = "INSERT INTO bitacora (USUARIO,ACCION,IP,FECHA_HORA) VALUES ('" + user + "','" + Accion + "','" + ip + "','" + DateTime.Now.ToString("G") + "')";
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

		private void Main_Load(object sender, EventArgs e)
		{

		}

		private void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			string IP = "";
			IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
			foreach (IPAddress addr in localIPs)
			{
				IP += "\n" + addr.ToString();
			}
			databaseConnection.Open();
			Bitacora("LOG OUT", IP, usuario);
			databaseConnection.Close();
			LogIn nuevo = new LogIn();
			nuevo.Show();
			this.Hide();
		}

		private void aRCHIVOToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clientes nuevo = new Clientes();
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Proveedores nuevo = new Proveedores();
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Sucursales nuevo = new Sucursales();
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void productosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Productos nuevo = new Productos();
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Ventas nuevo = new Ventas();
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Compras nuevo = new Compras();
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bodegas nuevo = new Bodegas();
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Existencias nuevo = new Existencias();
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void catalogosToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			LogIn_Users nuevo = new LogIn_Users();
			nuevo.MdiParent = this;
			nuevo.Show();
		}
	}
}
