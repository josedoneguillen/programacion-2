using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UsandoControlesContenedores
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBoxOption1.Enabled = false;
            linkLabel1.Enabled = false;
            textBoxOption2.Enabled = false;
            linkLabel2.Enabled = false;
            textBoxOption3.Enabled = false;
            linkLabel3.Enabled = false;
            textBoxOption4.Enabled = false;
            linkLabel4.Enabled = false;
            textBoxOption5.Enabled = false;
            linkLabel5.Enabled = false;

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                switch (itemChecked.ToString()) 
                {
                    case "Opcion 1":
                        textBoxOption1.Enabled = true;
                        linkLabel1.Enabled = true;
                        break;

                    case "Opcion 2":
                        textBoxOption2.Enabled = true;
                        linkLabel2.Enabled = true;
                    break;

                    case "Opcion 3":
                        textBoxOption3.Enabled = true;
                        linkLabel3.Enabled = true;
                    break;

                    case "Opcion 4":
                        textBoxOption4.Enabled = true;
                        linkLabel4.Enabled = true;
                    break;

                    case "Opcion 5":
                        textBoxOption5.Enabled = true;
                        linkLabel5.Enabled = true;
                    break;


                }
                
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(textBoxOption1.Text);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(textBoxOption2.Text);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(textBoxOption3.Text);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(textBoxOption4.Text);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(textBoxOption5.Text);
        }
    }
}
