using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ListTreeCalendarTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

                //Store your database DateTime value into a variable
                DateTime yourDate = DateTime.Parse(DateTime.Now.ToString());

                //Use the DateTime.ToString() method to store the value of the DateTime into your TextBox
                dateTime.Text = yourDate.ToString("MM/dd/yyyy h:m:s");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem.ToString());

        }
    }
}
