using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace homework02
{
    public partial class Form1 : Form
    {
        double tempC = 0;
        double tempF = 0;
        string inputText = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void btnConvert_Click_Click(object sender, EventArgs e)
        {
            if (radioCtoF.Checked == true)
            {
                tempC = double.Parse(inputText);
                tempF = (tempC * 9 / 5) + 32;
                label1.Text = "結果: " + tempF.ToString();


            }
            else if (radioFtoC.Checked == true)
            {
                tempF = double.Parse(inputText);
                tempC = (tempF - 32) * 5 / 9;
                label1.Text = "結果: " + tempC.ToString();
            }
            else
            {
                MessageBox.Show("請選擇一個選項");
                return;
            }

        }

        private void btnClear_Click_Click(object sender, EventArgs e)
        {
            // clear
            inputText = string.Empty;
            textBox1.Text = string.Empty;
            label1.Text = string.Empty;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputText = inputText + "1";
            textBox1.Text = inputText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputText = inputText + "2";
            textBox1.Text = inputText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputText = inputText + "3";
            textBox1.Text = inputText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputText = inputText + "4";
            textBox1.Text = inputText;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputText = inputText + "5";
            textBox1.Text = inputText;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputText = inputText + "6";
            textBox1.Text = inputText;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputText = inputText + "7";
            textBox1.Text = inputText;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputText = inputText + "8";
            textBox1.Text = inputText;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputText = inputText + "9";
            textBox1.Text = inputText;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputText = inputText + "0";
            textBox1.Text = inputText;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            inputText = inputText + ".";
            textBox1.Text = inputText;
        }
    }
}
