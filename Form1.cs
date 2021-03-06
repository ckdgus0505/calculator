﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        bool equation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            if (equation_pressed == true)
            {
                if (operation_pressed == false)
                {
                    result.Text = "";
                    equation_pressed = false;
                }
            }
            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {   
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            equation.Text = value + " " + operation;
            operation_pressed = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
            }
            operation_pressed = false;
            equation_pressed = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            equation.Text = "";
            value = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }
    }
}
