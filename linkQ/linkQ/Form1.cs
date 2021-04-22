using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linkQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] valores = { 10, 9, 5, 0, 3, 20, 1, 4, 8, 5, 18, 22, 25 };

            var v_valores = from valor in valores select valor;
            var vm_valores = from valor in valores where valor > 15 select valor;

            foreach (var v_valor in v_valores)
            {
                richTextBox1.Text += v_valor.ToString() + System.Environment.NewLine;
            }

            foreach (var vm_valor in vm_valores)
            {
                richTextBox2.Text += vm_valor.ToString() + System.Environment.NewLine;
            }
        }
    }
}
