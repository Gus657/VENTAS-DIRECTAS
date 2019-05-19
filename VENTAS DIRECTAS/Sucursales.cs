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
	
	public partial class Sucursales : Form
	{
		MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username =root; password =; database =ventasdirectas");


		public Sucursales()
		{
			InitializeComponent();
			textBox1.Enabled = false;
			llenartabla();

			if (tabControl1.SelectedIndex.Equals(0))
			{
				button1.Enabled = false; button1.BackColor = System.Drawing.Color.Gray;
				button3.Enabled = false; button3.BackColor = System.Drawing.Color.Gray;
				button4.Enabled = false; button4.BackColor = System.Drawing.Color.Gray;

				button2.Enabled = true; button2.BackColor = System.Drawing.Color.White;
				button5.Enabled = true; button5.BackColor = System.Drawing.Color.White;
				button6.Enabled = true; button6.BackColor = System.Drawing.Color.White;
			}
			else
			{
				button2.Enabled = false; button2.BackColor = System.Drawing.Color.Gray;
				button5.Enabled = false; button5.BackColor = System.Drawing.Color.Gray;
				button6.Enabled = false; button6.BackColor = System.Drawing.Color.Gray;
				button3.Enabled = false; button3.BackColor = System.Drawing.Color.Gray;


				button1.Enabled = true; button1.BackColor = System.Drawing.Color.White;
				button4.Enabled = true; button4.BackColor = System.Drawing.Color.White;

			}

		}

		void llenartabla()
		{

			MySqlCommand codigo = new MySqlCommand();
			codigo.Connection = databaseConnection;
			codigo.CommandText = ("SELECT * FROM sucursales");
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
			string query = "UPDATE sucursales SET nombre ='" + textBox2.Text + "', telefono = '" + textBox3.Text 
				+ "', direccion='" + textBox4.Text +"', encargado='" + textBox5.Text + "', estado='" + textBox6.Text + "' WHERE  codigo =" + textBox1.Text;
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
					textBox1.Text = "";
					textBox2.Text = "";
					textBox3.Text = "";
					textBox4.Text = "";
					textBox5.Text = "";
					textBox6.Text = "";

					tabControl1.SelectedIndex = 0;
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
			string query = "INSERT INTO sucursales(nombre,telefono,direccion,encargado,estado )"
				+" VALUES ('" + textBox2.Text + "','" + textBox3.Text + "',"
				+ "'"+ textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
			databaseConnection.Open();
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{
				if ( textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("INGRSO CORRECTO");
					textBox1.Text = "";
					textBox3.Text = "";
					textBox2.Text = "";
					textBox4.Text = "";
					textBox5.Text = "";
					textBox6.Text = "";
					databaseConnection.Close();
					llenartabla();
					tabControl1.SelectedIndex = 0;

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
			string query = "DELETE FROM sucursales WHERE  codigo =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
				button3.Enabled = false; button3.BackColor = System.Drawing.Color.Gray;
				button4.Enabled = false; button4.BackColor = System.Drawing.Color.Gray;

				button2.Enabled = true; button2.BackColor = System.Drawing.Color.White;
				button5.Enabled = true; button5.BackColor = System.Drawing.Color.White;
				button6.Enabled = true; button6.BackColor = System.Drawing.Color.White;
			}
			else
			{
				button2.Enabled = false; button2.BackColor = System.Drawing.Color.Gray;
				button5.Enabled = false; button5.BackColor = System.Drawing.Color.Gray;
				button6.Enabled = false; button6.BackColor = System.Drawing.Color.Gray;
				button3.Enabled = false; button3.BackColor = System.Drawing.Color.Gray;


				button1.Enabled = true; button1.BackColor = System.Drawing.Color.White;
				button4.Enabled = true; button4.BackColor = System.Drawing.Color.White;

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			tabControl1.SelectedIndex = 1;
			button3.Enabled = true; button3.BackColor = System.Drawing.Color.White;
			button1.Enabled = false; button1.BackColor = System.Drawing.Color.Gray;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
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
	}
}
