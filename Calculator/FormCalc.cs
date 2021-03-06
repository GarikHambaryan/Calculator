﻿using System;
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
            if(b.Text == ".")
            {
                if(!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + b.Text;
            }
            else
            {
                txtResult.Text = txtResult.Text + b.Text;
            }
           
        }
               
        private void btn_Ce(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                if (b.Text == "Sqrt")
                    txtResult.Text = Operators.Sqrt(double.Parse(txtResult.Text)).ToString();
                btn_equal.PerformClick();
                operationPressed = true;
                operation = b.Text;
                equation.Text = value + "" + operation;
            }
            else if (b.Text == "Sqrt")
            {
                txtResult.Text = Operators.Sqrt(double.Parse(txtResult.Text)).ToString();
                value = Math.Sqrt(double.Parse(txtResult.Text));
            }
            else
            {
                operation = b.Text;
                value = double.Parse(txtResult.Text);
                operationPressed = true;
                equation.Text = value + "" + operation;

            }
            
        }

        private void equals_click(object sender, EventArgs e)
        {           
            equation.Text = "";
            switch (operation)
            {
                case "+":                   
                    txtResult.Text = Operators.Add(value, double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = Operators.Sub(value, double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = Operators.Mult(value, double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = Operators.Div(value, double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }

            value = Int32.Parse(txtResult.Text);
            operation = "";
        }

       

        private void clear_click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void FormCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
            switch(e.KeyChar.ToString())
            {
                case "0":
                    btn_0.PerformClick();
                    break;
                case "1":
                    btn_1.PerformClick();
                    break;
                case "2":
                    btn_2.PerformClick();
                    break;
                case "3":
                    btn_3.PerformClick();
                    break;
                case "4":
                    btn_4.PerformClick();
                    break;
                case "5":
                    btn_5.PerformClick();
                    break;
                case "6":
                    btn_6.PerformClick();
                    break;
                case "7":
                    btn_7.PerformClick();
                    break;
                case "8":
                    btn_8.PerformClick();
                    break;
                case "9":
                    btn_9.PerformClick();
                    break;
                case "+":
                    btn_add.PerformClick();
                    break;
                case "-":
                    btn_sub.PerformClick();
                    break;
                case "*":
                    btn_mul.PerformClick();
                    break;
                case "/":
                    btn_div.PerformClick();
                    break;
                case "=":
                    btn_equal.PerformClick();
                    break;
                case "ENTER":
                    btn_1.PerformClick();
                    break;



                default:
                    break;              
                  
            }
        }
    }
}
