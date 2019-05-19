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
	
	public partial class Existencias : Form
	{
		MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username =root; password =; database =ventasdirectas");


		public Existencias()
		{
			InitializeComponent();
			textBox1.Enabled = false;
			llenartabla();
			dateTimePicker2.Format = DateTimePickerFormat.Custom;
			dateTimePicker2.CustomFormat = "yyyy-MM-dd";

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

		string newexi(string concepto) {
			int n1 = 0;
			int n2 = 0;
			int res = 0;

			n1 = Convert.ToInt32(textBox4.Text);
			n2 = Convert.ToInt32(textBox5.Text);
			if (concepto == "Ventas")
			{
				res = n1 - n2;
			} else
			{
				res = n1 + n2;
			}
			return res.ToString();
		}
		void llenartabla()
		{

			MySqlCommand codigo = new MySqlCommand();
			codigo.Connection = databaseConnection;
			codigo.CommandText = ("SELECT * FROM entradas_salidas");
			try
			{
				MySqlDataAdapter ejecutar = new MySqlDataAdapter();
				ejecutar.SelectCommand = codigo;
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

			MySqlCommand code = new MySqlCommand();
			code.Connection = databaseConnection;
			code.CommandText = ("SELECT * FROM existencias");
			try
			{
				MySqlDataAdapter ejecutar = new MySqlDataAdapter();
				ejecutar.SelectCommand = code;
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

			try
			{
				comboBox1.Text = "Producto";
				comboBox1.Items.Clear();

				databaseConnection.Open();
				MySqlCommand command = new MySqlCommand("SELECT * FROM productos", databaseConnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox1.Refresh();
					comboBox1.Items.Add(reader.GetValue(0).ToString() +" " +reader.GetValue(1).ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			databaseConnection.Close();

			try
			{
				comboBox2.Text = "Bodega";
				comboBox2.Items.Clear();

				databaseConnection.Open();
				MySqlCommand command = new MySqlCommand("SELECT * FROM Bodega", databaseConnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox2.Refresh();
					comboBox2.Items.Add(reader.GetValue(0).ToString() + " " +reader.GetValue(1).ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			databaseConnection.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string query = "UPDATE existencias SET "
				+ "cantidad = " + newexi(comboBox7.Text)
				+ " WHERE  codigo =" + textBox3.Text;
			databaseConnection.Open();
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{
				if (comboBox2.Text != "Bodegas" && comboBox1.Text != "Productos" )
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Actualizado");
					databaseConnection.Close();
					llenartabla();
				}
				else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); databaseConnection.Close(); }
			}
			catch (Exception ex)
			{
				MessageBox.Show("\tERROR!!\nVerifique:\n-Codigo no repetido.\n-Dpi No repetido.\n\tGRACIAS!!" + ex.ToString());
				databaseConnection.Close();
			}

			string query2 = "INSERT INTO entradas_salidas(producto, bodega, fecha, cantidad, concepto, documento)"
				+ " VALUES (" + comboBox5.Text[0] + "," + comboBox6.Text[0] + ",'" + dateTimePicker2.Text + "',"
				+ textBox5.Text + ",'" + comboBox7.Text + "','" + comboBox8.Text[0] + "')";
			databaseConnection.Open();
			MySqlCommand consulta2 = new MySqlCommand(query2, databaseConnection);
			try
			{
				if (comboBox5.Text != "Producto" && comboBox6.Text != "Bodega" && textBox4.Text != "")
				{
					consulta2.ExecuteNonQuery();
					textBox1.Text = "";
					textBox3.Text = "";
					textBox5.Text = "";
					textBox4.Text = "";
					databaseConnection.Close();
					llenartabla();
					tabControl1.SelectedIndex = 2;

				}
				else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); databaseConnection.Close(); }
			}
			catch (Exception ex)
			{
				MessageBox.Show("\tERROR!!\nVerifique: Los datos.\n\tGRACIAS!!" + ex.ToString());
				databaseConnection.Close();
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{

			int log = 0;
			string query = "SELECT * FROM existencias WHERE codigo_producto = '" + comboBox1.Text + "' AND codigo_bodega = '" + comboBox2.Text + "'";
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);

			try
			{
				databaseConnection.Open();
				consulta.ExecuteNonQuery();
				DataTable respuesta = new DataTable();
				MySqlDataAdapter datos = new MySqlDataAdapter(consulta);
				datos.Fill(respuesta);
				log = Convert.ToInt32(respuesta.Rows.Count.ToString());
				if (log == 1 || log > 1)
				{

					MessageBox.Show("La existencia ingresada ya esta registrada");
					databaseConnection.Close();

				}
				else
				{
					
					databaseConnection.Close();


					string query2 = "INSERT INTO existencias(codigo_producto, codigo_bodega, cantidad)"
						+ " VALUES (" + comboBox1.Text[0] + "," + comboBox2.Text[0] + "," + textBox2.Text + ")";
					databaseConnection.Open();
					MySqlCommand consulta2 = new MySqlCommand(query2, databaseConnection);
					try
					{
						if (comboBox2.Text != "Producto" && comboBox1.Text != "Bodega" && textBox2.Text != "")
						{
							consulta2.ExecuteNonQuery();
							MessageBox.Show("INGRSO CORRECTO");
							textBox1.Text = "";
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

			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR" + ex.ToString());
				databaseConnection.Close();
			}



		}

		private void button5_Click(object sender, EventArgs e)
		{
			string query = "DELETE FROM existencias WHERE  codigo =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
			
			textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			comboBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			comboBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			tabControl1.SelectedIndex = 3;
			button3.Enabled = true; button3.BackColor = System.Drawing.Color.White;
			button1.Enabled = false; button1.BackColor = System.Drawing.Color.Gray;

			comboBox5.Enabled = false;
			comboBox6.Enabled = false;
			textBox4.Enabled = false;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
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

		private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				comboBox8.Text = "Documento";
				comboBox8.Items.Clear();

				databaseConnection.Open();
				MySqlCommand command = new MySqlCommand("SELECT * FROM " + comboBox7.Text + "", databaseConnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox8.Refresh();
					comboBox8.Items.Add(reader.GetValue(0).ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			databaseConnection.Close();
		}

		private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
