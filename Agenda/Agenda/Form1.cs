using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData() 
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Abcd1234.;database=Agenda;sslMode=none");
            MySqlCommand cmd;
            MySqlDataAdapter da;
            DataTable dt;


            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * FROM contactos";
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                listView1.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["nombre"].ToString());
                    listitem.SubItems.Add(dr["apellido"].ToString());
                    listitem.SubItems.Add(dr["sexo"].ToString());
                    listitem.SubItems.Add(dr["celular"].ToString());
                    listitem.SubItems.Add(dr["direccion"].ToString());
                    listitem.SubItems.Add(dr["email"].ToString());
                    listitem.SubItems.Add(dr["fecha_creado"].ToString());
                    listView1.Items.Add(listitem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection MyConn2 = new MySqlConnection("server=localhost;user id=root;password=Abcd1234.;database=Agenda;sslMode=none");


            try
            {

                string Query = "INSERT INTO contactos " +
                    "(nombre, apellido, sexo, celular, direccion, email) " +
                    "VALUES ('" +
                    textBoxNombre.Text + "', '" +
                    textBoxApellido.Text + "', '" +
                    comboBoxSexo.Text + "', '" +
                    textBoxCelular.Text + "', '" +
                    textBoxDireccion.Text + "', '" +
                    textBoxEmail.Text + "')";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;

                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                }

                MessageBox.Show("Contacto Agregado");

                loadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConn2.Close();
            }
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            comboBoxSexo.ResetText();
            textBoxCelular.Clear();
            textBoxDireccion.Clear();
            textBoxEmail.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Abcd1234.;database=Agenda;sslMode=none");
            MySqlCommand cmd;
            MySqlDataAdapter da;
            DataTable dt;


            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM contactos WHERE " +
                    "nombre LIKE '%" + textBoxNombre.Text + "%'" +
                    " AND apellido LIKE '%" + textBoxApellido.Text + "%'" +
                    " AND sexo LIKE '%" + comboBoxSexo.Text + "%'" +
                    " AND celular LIKE '%" + textBoxCelular.Text + "%'" +
                    " AND direccion LIKE '%" + textBoxDireccion.Text + "%'" +
                    " AND email LIKE '%" + textBoxEmail.Text + "%'";
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                listView1.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["nombre"].ToString());
                    listitem.SubItems.Add(dr["apellido"].ToString());
                    listitem.SubItems.Add(dr["sexo"].ToString());
                    listitem.SubItems.Add(dr["celular"].ToString());
                    listitem.SubItems.Add(dr["direccion"].ToString());
                    listitem.SubItems.Add(dr["email"].ToString());
                    listitem.SubItems.Add(dr["fecha_creado"].ToString());
                    listView1.Items.Add(listitem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection MyConn2 = new MySqlConnection("server=localhost;user id=root;password=Abcd1234.;database=Agenda;sslMode=none");


            try
            {

                string Query = "DELETE FROM contactos WHERE " +
                    "nombre LIKE '%" + textBoxNombre.Text + "%'" +
                    " AND apellido LIKE '%" + textBoxApellido.Text + "%'" +
                    " AND sexo LIKE '%" + comboBoxSexo.Text + "%'" +
                    " AND celular LIKE '%" + textBoxCelular.Text + "%'" +
                    " AND direccion LIKE '%" + textBoxDireccion.Text + "%'" +
                    " AND email LIKE '%" + textBoxEmail.Text + "%'";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;

                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                }

                MessageBox.Show("Contacto Eliminado");

                loadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConn2.Close();
            }
        }
    }
}
