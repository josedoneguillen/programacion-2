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
            previousOperation = Operation.None;
            txtDisplay.Clear();
        }
        // Delete button method to erease the last number
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0) 
            {
                double d;
                if (!double.TryParse(txtDisplay.Text[txtDisplay.Text.Length - 1].ToString(), out d))
                {
                    previousOperation = Operation.None;
                }

                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
        }
        // Global number button method to get every number button
        private void btnNum_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }
        // Calulation method
        private void PerformCalculation(Operation previousOperation) 
        {
            List<double> lstNums = new List<double>();
            double total = 0.00;

            switch (previousOperation)
            {
                case Operation.Div:
                    try
                    {
                        lstNums = txtDisplay.Text.Split('/').Select(double.Parse).ToList();
                        lstNums.ForEach(delegate (double value)
                        {
                            total /= value;
                        });

                        txtDisplay.Text = total.ToString();
                    }
                    catch (DivideByZeroException) 
                    {
                        txtDisplay.Text = "ERROR";
                    }
                    break;
                case Operation.Mul:

                    lstNums = txtDisplay.Text.Split('*').Select(double.Parse).ToList();
                    lstNums.ForEach(delegate (double value)
                    {
                        total *= value;
                    });

                    txtDisplay.Text = total.ToString();

                    break;
                case Operation.Sub:
                    
                    lstNums = txtDisplay.Text.Split('-').Select(double.Parse).ToList();
                    lstNums.ForEach(delegate (double value)
                    {
                        total -= value;
                    });

                    txtDisplay.Text = total.ToString();

                    break;
                case Operation.Add:

                    lstNums = txtDisplay.Text.Split('+').Select(double.Parse).ToList();
                    lstNums.ForEach(delegate (double value)
                    {
                        total += value;
                    });
                    
                    txtDisplay.Text = total.ToString();

                    break;
                case Operation.None:
                    break;
                default:
                    break;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            previousOperation = Operation.None;

            if (previousOperation != Operation.None)
            {
                PerformCalculation(previousOperation);
            }

            previousOperation = Operation.Div;    
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            previousOperation = Operation.None;

            if (previousOperation != Operation.None)
            {
                PerformCalculation(previousOperation);
            }
            
            previousOperation = Operation.Mul;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            previousOperation = Operation.None;

            if (previousOperation != Operation.None)
            {
                PerformCalculation(previousOperation);
            }

            previousOperation = Operation.Sub;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            previousOperation = Operation.None;

            if (previousOperation != Operation.None)
            {
                PerformCalculation(previousOperation);
            }

            previousOperation = Operation.Add;
            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
            {
                PerformCalculation(previousOperation);
            }
            return;
        }

        enum Operation 
        { 
            Div,
            Mul,
            Sub,
            Add,
            None
        }

        static Operation previousOperation =  Operation.None;
    }
}
