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
	
	public partial class Clientes : Form
	{
		MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username =root; password =; database =ventasdirectas");


		public Clientes()
		{
			InitializeComponent();
		}

		void llenartabla()
		{

			MySqlCommand codigo = new MySqlCommand();
			codigo.Connection = databaseConnection;
			codigo.CommandText = ("SELECT * FROM talleres");
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

		private void button3_Click(object sender, EventArgs e)
		{
			string query = "UPDATE Talleres SET encargado ='" + textBox1.Text + "', nombre_taller = '" + textBox2.Text + "', direccion='" + textBox3.Text + "' WHERE  cod_taller =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
			databaseConnection.Open();
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{
				if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Actualizado");
					databaseConnection.Close();
					llenartabla();
					databaseConnection.Open();
					textBox1.Text = "";
					textBox2.Text = "";
					textBox3.Text = "";

				}
				else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); databaseConnection.Close(); }
			}
			catch (Exception ex)
			{
				MessageBox.Show("\tERROR!!\nVerifique:\n-Codigo no repetido.\n-Dpi No repetido.\n\tGRACIAS!!" + ex.ToString());
				databaseConnection.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO Talleres(encargado, nombre_taller, direccion) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
			databaseConnection.Open();
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{
				if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("INGRSO CORRECTO");
					textBox1.Text = "";
					textBox3.Text = "";
					textBox2.Text = "";
					databaseConnection.Close();
					llenartabla();

				}
				else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); databaseConnection.Close(); }
			}
			catch (Exception ex)
			{
				MessageBox.Show("\tERROR!!\nVerifique: Los datos.\n\tGRACIAS!!" + ex.ToString());
				databaseConnection.Close();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			string query = "DELETE FROM Talleres  WHERE  cod_taller =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
					databaseConnection.Open(); 

				}
				else { MessageBox.Show("Por favor Seleccione un registro"); databaseConnection.Close(); }
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR" + ex.ToString());
				databaseConnection.Close();
			}
		}
	}
}
