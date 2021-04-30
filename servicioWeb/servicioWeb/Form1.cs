using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servicioWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempConvert.TempConvertSoapClient client = new tempConvert.TempConvertSoapClient();
            string temp = "";

            if (radioButton1.Checked) {

                temp = client.CelsiusToFahrenheit(textBox1.Text);

            } else if (radioButton2.Checked) {

                temp = client.FahrenheitToCelsius(textBox1.Text);

            }

            textBox2.Text = temp.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Celsius";
            label4.Text = "Fahrenheit";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Fahrenheit";
            label4.Text = "Celsius";
        }
    }
}
