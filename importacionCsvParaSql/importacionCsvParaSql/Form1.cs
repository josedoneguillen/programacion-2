using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace importacionCsvParaSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Abcd1234.;database=articulos;sslMode=none");
            MySqlCommand cmd;
            MySqlDataAdapter da;
            DataTable dt;


            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * FROM articulos";
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                listView1.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["ID"].ToString());
                    listitem.SubItems.Add(dr["ARTICULO"].ToString());
                    listitem.SubItems.Add(dr["CANTIDAD"].ToString());
                    listitem.SubItems.Add(dr["PRECIO"].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {

            string archivo = File.ReadAllText(@"C:\Users\JDONE_LAPTOP\source\repos\UNICARIBE\programacion-2\importacionCsvParaSql\datos.csv");
            string query = "INSERT INTO `articulos` (`ARTICULO`, `CANTIDAD`, `PRECIO`) VALUES ";
            int n_fila = 0;
            int t_filas = archivo.Split('\n').Length;
            int t_registro = 0;
            int n_registro = 0;

            foreach (string fila in archivo.Split('\n'))
            {
                if (!string.IsNullOrEmpty(fila)) 
                {
                   
                    t_registro = fila.Split(',').Length;
                    n_registro = 0;

                    query += "( ";

                    foreach (string registro in fila.Split(','))
                    {
                        query += "'" + registro + "'";

                        if (n_registro < (t_registro - 1))
                        {
                            query += ", ";
                        }

                        n_registro++;

                    }

                    query += ") ";

                    if (n_fila < (t_filas - 1) ) 
                    {
                        query += ", ";
                    }

                    n_fila++;
                }
            }

            MySqlConnection MyConn = new MySqlConnection("server=localhost;user id=root;password=Abcd1234.;database=articulos;sslMode=none");


            try
            {

                MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn);
                MySqlDataReader MyReader2;

                MyConn.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                }

                MessageBox.Show("Informacion Agregada");

                loadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConn.Close();
            }

        }
    }
}
