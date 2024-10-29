using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calc
{
    public partial class Form1 : Form
    {
        double numb1 = 0, numb2 = 0, itog = 0;
        string tip;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // 0
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        // 1
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        // 2
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        // 3
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        // 4
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        // 5
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        // 6
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        // 7
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        // 8
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        // 9
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        // ,
        private void button17_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text).Contains(",")) // Проверяем, нет ли уже запятой
            {
                textBox1.Text += ","; // Если нет, добавляем запятую
            }
        }
        // clear
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        // delenie
        private void button15_Click(object sender, EventArgs e)
        {
            tip = "delenie";
            try
            {
                numb1 = Convert.ToDouble(textBox1.Text);
            }
            catch { }
            textBox1.Text = "";
        }
        // umnojenie
        private void button11_Click(object sender, EventArgs e)
        {
            tip = "umnoj";
            try
            {
                numb1 = Convert.ToDouble(textBox1.Text);
            }
            catch { }
            textBox1.Text = "";
        }

        // plus
        private void button13_Click(object sender, EventArgs e)
        {
            tip = "plus";
            try
            {
                numb1 = Convert.ToDouble(textBox1.Text);
            }
            catch { }
            
            textBox1.Text = "";
        }
        // minus
        private void button12_Click(object sender, EventArgs e)
        {
            tip = "minus";
            try
            {
                numb1 = Convert.ToDouble(textBox1.Text);
            }
            catch { }
            textBox1.Text = "";
        }
        // ravno
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                numb2 = Convert.ToDouble(textBox1.Text);
            }
            catch { }
            if (tip == "plus") itog = numb1 + numb2;
            else if (tip == "minus") itog = numb1 - numb2;
            else if (tip == "delenie") itog = numb1 / numb2;
            else if (tip == "umnoj") itog = numb1 * numb2;
            textBox1.Text = Convert.ToString(itog);
            itog = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 24.0f);
            textBox1.Font = myfont;

        }
        private void button18_Click(object sender, EventArgs e)
        {
            tip = "minus";
            numb1 = Convert.ToDouble(textBox1.Text);

        }
    }
}
