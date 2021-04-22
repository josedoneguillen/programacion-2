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

namespace creacionDeLaBaseDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=Abcd1234.;database=programacion2;sslMode=none");
                MySqlCommand cmd;
                MySqlDataAdapter da;
                DataTable dt;


                try
                {
                    con.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Select * FROM usuario";
                    da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["ID"].ToString());
                        listitem.SubItems.Add(dr["Usuario"].ToString());
                        listitem.SubItems.Add(dr["Clave"].ToString());
                        listitem.SubItems.Add(dr["Nombre"].ToString());
                        listitem.SubItems.Add(dr["Apellido"].ToString());
                        listitem.SubItems.Add(dr["Correo"].ToString());
                        listitem.SubItems.Add(dr["Estatus"].ToString());
                        listitem.SubItems.Add(dr["Fecha_Creado"].ToString());
                        listitem.SubItems.Add(dr["Foto"].ToString());
                        listitem.SubItems.Add(dr["Imagen"].ToString());
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
        }
    }
}
