using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormCalc : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;

        public FormCalc()
        {
            InitializeComponent();
        }

        private void FormCalc_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0")||(operationPressed))
                txtResult.Clear();
            operationPressed = false;
            Button b = (Button)sender;
            txtResult.Text = txtResult.Text + b.Text;
        }
               
        private void btn_Ce(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(txtResult.Text);
            operationPressed = true;
            equation.Text = value + "" + operation;
        }

        private void equals_click(object sender, EventArgs e)
        {           
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    txtResult.Text = (value + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (value - double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (value * double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (value / double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            operationPressed = false;
        }

       

        private void clear_click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
        }
    }
}
