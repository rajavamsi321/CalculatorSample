using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSample
{

    public partial class Form1 : Form
    {
       

        bool plus = false;
        bool minus = false;
        bool multiply = false;
        bool divide = false;
        bool square = false;
        bool squareRoot = false;
        double resultValue;

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text += "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text.Contains("."))
            {
                return;
            }
            else
            {
                txtBoxValue.Text += ".";            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            plus = true;
            minus = false;
            multiply = false;
            divide = false;
            square = false;
            squareRoot = false;
            resultValue = Convert.ToInt32(txtBoxValue.Text);
            txtBoxValue.Text = "";
        } 
        private void btn9_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text += "9";
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text += "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text += "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text += "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text += "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text += "4";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEqualTo_Click(object sender, EventArgs e)
        {
            string comment = string.Empty;
            if (plus == true)
            {
                comment = resultValue.ToString() + "+" + txtBoxValue.Text;
                resultValue += Convert.ToInt32(txtBoxValue.Text);
                txtBoxValue.Text = resultValue.ToString();   
                
               
            }
            else if (minus == true)
            {
                comment = resultValue.ToString() + "-" + txtBoxValue.Text;
                resultValue -= Convert.ToInt32(txtBoxValue.Text);
                txtBoxValue.Text = resultValue.ToString();
                

            }
            else if (multiply == true)
            {
                comment = resultValue.ToString() + "*" + txtBoxValue.Text;
                resultValue *= Convert.ToInt32(txtBoxValue.Text);
                txtBoxValue.Text = resultValue.ToString();
                
            }
            else if (divide == true)
            {
                comment = resultValue.ToString() + "/" + txtBoxValue.Text;
                resultValue /= Convert.ToInt32(txtBoxValue.Text);
                txtBoxValue.Text = resultValue.ToString();
               

            }
            else if (square == true)
            {
                comment = "Square of " + resultValue.ToString() + " is " + txtBoxValue.Text;
                resultValue = Convert.ToInt32(Math.Pow(resultValue, 2));
                txtBoxValue.Text = resultValue.ToString();
                

            }
            else if (squareRoot == true)
            {
                comment = "Square root of " + resultValue.ToString() +  " is" + txtBoxValue.Text;
                resultValue = Math.Sqrt(resultValue);
                txtBoxValue.Text = resultValue.ToString("n2");
               

            }
            WriteToFile res = new WriteToFile();
            res.path = @"C:/Users/pavan/Desktop/NewRandom/CalculatorSample.txt";
            res.fileInfo = comment + "=" + txtBoxValue.Text;
            res.writeFile();


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            minus = true;
            plus = false;
            multiply = false;
            divide = false;
            square = false;
            squareRoot = false;
            resultValue = Convert.ToInt32(txtBoxValue.Text);
            txtBoxValue.Text = "";
           
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            multiply = true;
            plus = false;
            minus = false;
            divide = false;
            square = false;
            squareRoot = false;
            resultValue = Convert.ToInt32(txtBoxValue.Text);
            txtBoxValue.Text = "";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text += "1";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text += "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text += "2";

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            divide = true;
            plus = false;
            minus = false;
            multiply = false;
            square = false;
            squareRoot = false;
            resultValue = Convert.ToInt32(txtBoxValue.Text);
            txtBoxValue.Text = "";
                
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text = string.Empty;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            square = true;
            plus = false;
            minus = false;
            multiply = false;
            divide = false;
            squareRoot = false;
            resultValue = Convert.ToInt32(txtBoxValue.Text);
            txtBoxValue.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            squareRoot = true;
            plus = false;
            minus = false;
            multiply = false;
            divide = false;
            square= false;
            resultValue = Convert.ToInt32(txtBoxValue.Text);
            txtBoxValue.Text = "";
        }
    }

    public class WriteToFile
    {
        public string path;
        public string fileInfo;
        public void writeFile()
        {
            StreamWriter wFile = File.AppendText(path);
            string a = fileInfo;
            wFile.WriteLine(a);
            wFile.Close();

        }
    }
}
