using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Copy button method to copy text box results to clipboard
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDisplay.Text);
        }

        // Reset button method to clear text box results 
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
        // Delete button method to erease the last number
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0) {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
        }
        // Global number button method to get every number button
        private void btnNum_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += (sender as Button).Text;
        }
    }
}
