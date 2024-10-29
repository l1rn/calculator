using System.Diagnostics.Metrics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double counter1 = 0, counter2 = 0, itog = 0;
        string tip;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        // Плюс
        private void button13_Click(object sender, EventArgs e)
        {
            tip = "plus";
            try
            {
                counter1 = Convert.ToDouble(textBox1.Text);
            }
            catch { }
            textBox1.Text = "";

        }

        // Равно
        private void button16_Click(object sender, EventArgs e)
        {
            counter2 = Convert.ToDouble(textBox1.Text);
            if (tip == "plus") itog = counter1 + counter2;
            else if (tip == "minus") itog = counter1 - counter2;
            else if (tip == "del") itog = counter1 / counter2;
            else if (tip == "umn") itog = counter1 * counter2;
            textBox1.Text = Convert.ToString(itog);
            itog = 0;
        }

        // Умножение
        private void button14_Click(object sender, EventArgs e)
        {
            tip = "umn";
            try
            {
                counter1 = Convert.ToDouble(textBox1.Text);
            }
            catch { }
            textBox1.Text = "";
        }
        
        // Деление
        private void button11_Click(object sender, EventArgs e)
        {
            tip = "del";
            try
            {
                counter1 = Convert.ToDouble(textBox1.Text);
            }
            catch { }
            textBox1.Text = "";
        }

        // Очистка
        private void button10_Click(object sender, EventArgs e)
        {
            tip = "";
            counter1 = counter2 = 0;
            textBox1.Text = "";
        }

        //Минус
        private void button12_Click(object sender, EventArgs e)
        {
            tip = "minus";
            try
            {
                counter1 = Convert.ToDouble(textBox1.Text);
            }
            catch { }
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}