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
	
	public partial class Bodegas : Form
	{
		MySqlConnection databaseConnection = new MySqlConnection("datasource = 192.168.1.5; port = 3306; username =repl; password =slavepassword; database =ventasdirectas");


		public Bodegas()
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
			codigo.CommandText = ("SELECT * FROM bodega");
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

			MySqlCommand codigo2 = new MySqlCommand();
			codigo2.Connection = databaseConnection;
			codigo2.CommandText = ("SELECT * FROM existencias");
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
				comboBox1.Text = "Sucursales";
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
				comboBox2.Text = "Bodegas";
				comboBox2.Items.Clear();

				databaseConnection.Open();
				MySqlCommand command = new MySqlCommand("SELECT * FROM bodega", databaseConnection);
				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox2.Refresh();
					comboBox2.Items.Add(reader.GetValue(0).ToString()+" "+ reader.GetValue(1).ToString());
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
			string query = "UPDATE bodega SET sucursal ='" + comboBox1.Text + "', telefono = '" + textBox3.Text 
				+ "', direccion='" + textBox4.Text +"', encargado='" + textBox5.Text + "', estado='" + textBox6.Text + "' WHERE  codigo =" + textBox1.Text;
			databaseConnection.Open();
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{
				if (textBox1.Text != "" && comboBox1.Text != "Sucursales" && textBox3.Text != "")
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("Actualizado");
					databaseConnection.Close();
					llenartabla();
					textBox1.Text = "";
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
			string query = "INSERT INTO bodega(sucursal,telefono,direccion,encargado,estado )"
				+" VALUES ('" + comboBox1.Text + "','" + textBox3.Text + "',"
				+ "'"+ textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
			databaseConnection.Open();
			MySqlCommand consulta = new MySqlCommand(query, databaseConnection);
			try
			{
				if ( comboBox1.Text != "Sucursales" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
				{
					consulta.ExecuteNonQuery();
					MessageBox.Show("INGRSO CORRECTO");
					textBox1.Text = "";
					textBox3.Text = "";
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
			string query = "DELETE FROM bodega WHERE  codigo =" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
			comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
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

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			MySqlCommand codigo2 = new MySqlCommand();
			codigo2.Connection = databaseConnection;
			codigo2.CommandText = ("SELECT * FROM existencias where codigo_bodega = "+ comboBox2.Text[0]);
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
