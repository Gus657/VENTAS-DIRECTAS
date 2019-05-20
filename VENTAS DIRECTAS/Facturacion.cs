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
	
	public partial class Facturacion : Form
	{
		MySqlConnection databaseConnection = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username =root; password =; database =ventasdirectas");


		public Facturacion()
		{
			InitializeComponent();
			textBox1.Enabled = false;
			llenartabla();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy-MM-dd";

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
			MySqlCommand code = new MySqlCommand();
			code.Connection = databaseConnection;
			code.CommandText = ("SELECT * FROM Factura");
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
				MySqlCommand code2 = new MySqlCommand();
				code2.Connection = databaseConnection;
				code2.CommandText = ("SELECT * FROM detalle");
				MySqlDataAdapter ejecutar = new MySqlDataAdapter();
				ejecutar.SelectCommand = code2;
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
				comboBox1.Text = "Sucursal";
				comboBox1.Items.Clear();

				databaseConnection.Open();
				MySqlCommand command = new MySqlCommand("SELECT * FROM sucursales", databaseConnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox1.Refresh();
					comboBox1.Items.Add(reader.GetValue(1).ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			databaseConnection.Close();

			try
			{
				comboBox2.Text = "Venta";
				comboBox2.Items.Clear();

				databaseConnection.Open();
				MySqlCommand command = new MySqlCommand("SELECT * FROM Ventas", databaseConnection);
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

			try
			{
				comboBox3.Text = "Productos";
				comboBox3.Items.Clear();

				databaseConnection.Open();
				MySqlCommand command = new MySqlCommand("SELECT * FROM Productos", databaseConnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox3.Refresh();
					comboBox3.Items.Add(reader.GetValue(1).ToString() );
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			databaseConnection.Close();
		}

		void llenartabla2()
		{
			MySqlCommand code = new MySqlCommand();
			code.Connection = databaseConnection;
			code.CommandText = ("SELECT * FROM detalle where encabezado = " + textBox4.Text);
			try
			{
				MySqlDataAdapter ejecutar = new MySqlDataAdapter();
				ejecutar.SelectCommand = code;
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
		}
			string noFac(string sucursal, char venta)
		{
			string nofact = "";
			string consulta = "SELECT * FROM encabezado where sucursal='"+ sucursal +"' AND codigo_venta= "+ venta;

			try
			{
				databaseConnection.Open();
				MySqlCommand command = new MySqlCommand(consulta, databaseConnection);
				MySqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					nofact = reader.GetValue(0).ToString();
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			databaseConnection.Close();

			return nofact;
		}



		private void button3_Click(object sender, EventArgs e)
		{
			string query = "UPDATE existencias SET "
				+ "cantidad = " + ""
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
				+ " VALUES (" + "" + "," + ""+ ",'" + "" + "',"
				+ "" + ",'" + "" + "','" + "" + "')";
			databaseConnection.Open();
			MySqlCommand consulta2 = new MySqlCommand(query2, databaseConnection);
			try
			{
				if (/*comboBox5.Text != "Producto" && comboBox6.Text != "Bodega" &&*/ textBox4.Text != "")
				{
					consulta2.ExecuteNonQuery();
					textBox1.Text = "";
					textBox3.Text = "";
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
			textBox3.Text = "0";
			textBox8.Text = "1";
			int log = 0;
			string query = "SELECT * FROM encabezado WHERE sucursal = '" + comboBox1.Text +"' AND Codigo_Venta= " +comboBox2.Text[0] ;
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

					MessageBox.Show("La Factura ingresada ya esta registrada");
					databaseConnection.Close();

				}
				else
				{
					
					databaseConnection.Close();


					string query2 = "INSERT INTO encabezado(sucursal, codigo_venta, fecha, nombre, nit, direccion)"
						+ " VALUES ('" + comboBox1.Text + "'," + comboBox2.Text[0] + ",'" + dateTimePicker1.Text + "','" 
						+ textBox2.Text + "','" + textBox7.Text + "','" + textBox6.Text + "')";
					databaseConnection.Open();
					MySqlCommand consulta2 = new MySqlCommand(query2, databaseConnection);
					try
					{
						if (comboBox2.Text != "Sucursal" && comboBox1.Text != "Venta" && textBox2.Text != "")
						{
							consulta2.ExecuteNonQuery();
							MessageBox.Show("Encabezado guradado");
							databaseConnection.Close();
							textBox4.Text = noFac(comboBox1.Text, comboBox2.Text[0]);
							textBox1.Text = "";
							
							llenartabla();
							llenartabla2();

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
			//comboBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			//comboBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			tabControl1.SelectedIndex = 3;
			button3.Enabled = true; button3.BackColor = System.Drawing.Color.White;
			button1.Enabled = false; button1.BackColor = System.Drawing.Color.Gray;

			//comboBox5.Enabled = false;
			//comboBox6.Enabled = false;
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
				//comboBox8.Text = "Documento";
				//comboBox8.Items.Clear();

				databaseConnection.Open();
				MySqlCommand command = new MySqlCommand("SELECT * FROM " + "" + "", databaseConnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					//comboBox8.Refresh();
					//comboBox8.Items.Add(reader.GetValue(0).ToString());
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

		private void button8_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO detalle(encabezado, producto, cantidad, precio )"
				+ " VALUES (" + textBox4.Text + ",'" + comboBox3.Text + "'," + textBox8.Text + "," + textBox9.Text + ")";
			databaseConnection.Open();
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{
				if (comboBox3.Text != "Productos" && textBox8.Text != "" && textBox8.Text != "0")
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("INGRSO CORRECTO");

					textBox3.Text = ((Convert.ToInt32(textBox3.Text)) + ((Convert.ToInt32(textBox9.Text))* (Convert.ToInt32(textBox8.Text)))).ToString();
					
					textBox8.Text = "";
					databaseConnection.Close();
					llenartabla2();
				}
				else { MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS.\n\tGRACIAS!!"); databaseConnection.Close(); }
			}
			catch (Exception ex)
			{
				MessageBox.Show("\tERROR!!\nVerifique: Los datos.\n\tGRACIAS!!" + ex.Message);
				databaseConnection.Close();
			}
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			
				string consulta = "SELECT * FROM productos where nombre='" + comboBox3.Text+ "'" ;

				try
				{
					databaseConnection.Open();
					MySqlCommand command = new MySqlCommand(consulta, databaseConnection);
					MySqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						textBox9.Text = reader.GetValue(3).ToString();
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				databaseConnection.Close();

			
			
		}

		private void button9_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO factura(encabezado, estado, total )"
				+ " VALUES (" + textBox4.Text + ",'Cancelada'," + textBox3.Text + ")";
			databaseConnection.Open();
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{
				if (textBox3.Text != "0")
				{
					consulta.ExecuteNonQuery();
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
}
