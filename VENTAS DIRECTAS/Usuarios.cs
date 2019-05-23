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
	
	public partial class Usuarios : Form
	{
		MySqlConnection databaseConnection = new MySqlConnection("datasource = 192.168.1.5; port = 3306; username =repl; password =slavepassword; database =ventasdirectas");

		string usuario;
		public Usuarios(string user)
		{
			InitializeComponent();
			usuario = user;
			llenartabla();
			
			if (tabControl1.SelectedIndex.Equals(0))
			{
				button1.Enabled = false; button1.BackColor = System.Drawing.Color.Gray;
				
				button4.Enabled = false; button4.BackColor = System.Drawing.Color.Gray;

				
				button5.Enabled = true; button5.BackColor = System.Drawing.Color.White;
				button6.Enabled = true; button6.BackColor = System.Drawing.Color.White;
			}
			else
			{
				
				button5.Enabled = false; button5.BackColor = System.Drawing.Color.Gray;
				button6.Enabled = false; button6.BackColor = System.Drawing.Color.Gray;
		


				button1.Enabled = true; button1.BackColor = System.Drawing.Color.White;
				button4.Enabled = true; button4.BackColor = System.Drawing.Color.White;

			}

		}

		void Bitacora(string Accion, string ip)
		{
			string query = "INSERT INTO bitacora (USUARIO,ACCION,IP,FECHA_HORA) VALUES ('" + usuario + "','" + Accion + "','" + ip + "','" + DateTime.Now.ToString("G") + "')";
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{

				consulta.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
			}
		}

		void llenartabla()
		{

			MySqlCommand codigo = new MySqlCommand();
			codigo.Connection = databaseConnection;
			codigo.CommandText = ("SELECT * FROM usuarios");
			try
			{
				MySqlDataAdapter ejecutar = new MySqlDataAdapter();
				ejecutar.SelectCommand = codigo;
				DataTable datostabla = new DataTable();
				ejecutar.Fill(datostabla);
				dataGridView1.DataSource = datostabla;
				ejecutar.Update(datostabla);
				databaseConnection.Close();

			}
			catch (Exception e)
			{
				MessageBox.Show("ERROR" + e.ToString());
				databaseConnection.Close();
			}

		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO usuarios(Usuario, password, nivel )"
				+" VALUES ('" + textBox2.Text + "',MD5('" + textBox1.Text + "')," + comboBox2.Text + ")";
			databaseConnection.Open();
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{
				if (comboBox2.Text != "Nivel" && textBox1.Text != "" && textBox2.Text != "")
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("INGRSO CORRECTO");
					textBox1.Text = "";
					textBox2.Text = "";
					databaseConnection.Close();
					llenartabla();
					tabControl1.SelectedIndex = 0;

				}
				else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); databaseConnection.Close(); }
			}
			catch (Exception ex)
			{
				MessageBox.Show("usuario Ya Registrado");
				databaseConnection.Close();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			string query = "DELETE FROM usuarios WHERE  usuario ='" + dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'";
			databaseConnection.Open();
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{
				if (dataGridView1.SelectedRows.Count == 1)
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Eliminado");
					databaseConnection.Close();
					llenartabla();

				}
				else { MessageBox.Show("Por favor Seleccione un registro"); databaseConnection.Close(); }
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR" + ex.ToString());
				databaseConnection.Close();
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedIndex.Equals(0))
			{
				button1.Enabled = false; button1.BackColor = System.Drawing.Color.Gray;
				
				button4.Enabled = false; button4.BackColor = System.Drawing.Color.Gray;

				button5.Enabled = true; button5.BackColor = System.Drawing.Color.White;
				button6.Enabled = true; button6.BackColor = System.Drawing.Color.White;
			}
			else
			{
				
				button5.Enabled = false; button5.BackColor = System.Drawing.Color.Gray;
				button6.Enabled = false; button6.BackColor = System.Drawing.Color.Gray;



				button1.Enabled = true; button1.BackColor = System.Drawing.Color.White;
				button4.Enabled = true; button4.BackColor = System.Drawing.Color.White;

			}
		}


		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			tabControl1.SelectedIndex = 0;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			llenartabla();
		}
		private void button7_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Usuarios_FormClosed(object sender, FormClosedEventArgs e)
		{
			string IP = "";
			IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
			foreach (IPAddress addr in localIPs)
			{
				IP += "\n" + addr.ToString();
			}
			databaseConnection.Open();
			Bitacora("LOG OUT USUARIOS", IP);databaseConnection.Close();
		}
	}
}
