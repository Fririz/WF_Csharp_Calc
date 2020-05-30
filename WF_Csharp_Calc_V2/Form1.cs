using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Csharp_Calc_V2
{
    public partial class Form1 : Form
    {
        public string FirstNumber;
        public string SecondNumber;
        public string action;

        public Form1()
        {
            InitializeComponent();
        }


       void assignment(string number)
        {
            if (action == null)
            {
                FirstNumber += number;
            }
            else
            {
                SecondNumber += number;
            }
            textBox1.Text = FirstNumber + action + SecondNumber;
        }



        private void button_0_Click(object sender, EventArgs e)
        {
            assignment("0");
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            assignment("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            assignment("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            assignment("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            assignment("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            assignment("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            assignment("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            assignment("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            assignment("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            assignment("9");
        }



        //plus
        private void Button11_Click(object sender, EventArgs e)
        {
            action = "plus";
        }
        //minus
        private void button_minus_Click(object sender, EventArgs e)
        {
            action = "minus";
        }

        //multiply
        private void button_multiply_Click(object sender, EventArgs e)
        {
            action = "multiply";
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            action = "division";
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            int FirstNumberReady = Convert.ToInt32(FirstNumber);
            int SecondNumberReady = Convert.ToInt32(SecondNumber);
        }
    }
}
