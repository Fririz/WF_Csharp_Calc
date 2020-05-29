using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Csharp_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            switch (comboBox1.Text)
            {
                case "+":
                    textBox3.Text = Convert.ToString(a + b);
                    break;

                case "-":
                    textBox3.Text = Convert.ToString(a - b);
                    break;

                case "*":
                    textBox3.Text = Convert.ToString(a * b);
                    break;

                case "/":
                    textBox3.Text = Convert.ToString(a / b);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            comboBox1.Text = null;
        }
    }
}
