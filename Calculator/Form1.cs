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
    public partial class Form1 : Form
    {
        public decimal Result {  get; set; }
        public decimal Value { get; set; }
        private Operations SelectedOperation {  get; set; }

        private enum Operations
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }


        public Form1() 
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "0") textBox1.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else { textBox1.Text += "1"; }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else 
            { 
                textBox1.Text += "2"; 
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else 
            { 
                textBox1.Text += "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else 
            { 
                textBox1.Text += "4"; 
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else 
            { 
                textBox1.Text += "5"; 
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else 
            { 
                textBox1.Text += "6"; 
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else 
            { 
                textBox1.Text += "7"; 
            }
        }

        private void btnEigth_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else 
            { 
                textBox1.Text += "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else 
            { 
                textBox1.Text += "9"; 
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            SelectedOperation = Operations.Addition;
            Value = Convert.ToDecimal(textBox1.Text);
            textBox2.Text += $"{textBox1.Text:F4}" + " + ";
            textBox1.Text = "0";
 
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            SelectedOperation = Operations.Subtraction; 
            Value = Convert.ToDecimal(textBox1.Text);
            textBox2.Text += $"{textBox1.Text:F4}" + " - ";
            textBox1.Text = "0"; 
            
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            SelectedOperation = Operations.Multiplication;
            Value = Convert.ToDecimal(textBox1.Text);
            textBox2.Text += $"{textBox1.Text:F4}" + " X ";
            textBox1.Text = "0"; 
            
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            SelectedOperation = Operations.Division;
            Value = Convert.ToDecimal(textBox1.Text);
            textBox2.Text += $"{textBox1.Text:F4}" + " ÷ ";
            textBox1.Text = "0"; 
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch(SelectedOperation) 
            {
                case Operations.Addition:
                    Result = Value + Convert.ToDecimal(textBox1.Text);
                    textBox2.Text = $"{Value} + {textBox1.Text} = ";
                    break;
                case Operations.Subtraction:
                    Result = Value - Convert.ToDecimal(textBox1.Text);
                    textBox2.Text = $"{Value} - {textBox1.Text} = ";
                    break; 
                case Operations.Multiplication:
                    Result = Value * Convert.ToDecimal(textBox1.Text);
                    textBox2.Text = $"{Value} X {textBox1.Text} = ";
                    break; 
                case Operations.Division:
                    Result = Value / Convert.ToDecimal(textBox1.Text);
                    textBox2.Text = $"{Value} ÷ {textBox1.Text} = ";
                    break;
                default: 
                    break;
            }
            textBox1.Text = Convert.ToString(Result);
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            
            if(!textBox1.Text.Contains(",")) textBox1.Text += ",";
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Count() > 1) textBox1.Text = "0";
            textBox2.Text = "";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            Value = Convert.ToDecimal(textBox1.Text);
            Result = Value / 100;
            textBox1.Text = Convert.ToString(Result);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0) 
            {
                string text = textBox1.Text;
                textBox1.Text = text.Substring(1);
            }
            
        }

        private void btnSignals_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }
            else
            {
                textBox1.Text = textBox1.Text.Insert(0, "-");
            }
        }

    }
}
