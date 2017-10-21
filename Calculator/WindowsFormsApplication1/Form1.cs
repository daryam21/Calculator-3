using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string temp1;
        string temp2;
        int result;
        string operators;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (answer.Text == null) {
                answer.Text = one.Text;
            }
            
            answer.Text = answer.Text + one.Text;
        }

        private void answer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (answer.Text == null)
            {
                answer.Text = two.Text;
            }

            answer.Text = answer.Text + two.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (answer.Text == null) {
                answer.Text = three.Text;
            }
            answer.Text = answer.Text + three.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(answer.Text==null){
                answer.Text=four.Text;
        }
            answer.Text = answer.Text+four.Text;

        }
        private void five_Click(object sender, EventArgs e)
        {
            if (answer.Text == null)
            {
                answer.Text = five.Text;
            }
            answer.Text = answer.Text + five.Text;
        }
        private void six_Click(object sender, EventArgs e)
        {
            if (answer.Text == null)
            {
                answer.Text = six.Text;
            }
            answer.Text = answer.Text + six.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (answer.Text == null)
            {
                answer.Text = seven.Text;
            }
            answer.Text = answer.Text + seven.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (answer.Text == null)
            {
                answer.Text = eight.Text;
            }
            answer.Text = answer.Text + eight.Text;
        
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (answer.Text == null)
            {
                answer.Text = nine.Text;
            }
            answer.Text = answer.Text + nine.Text;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (answer.Text == null)
            {
                answer.Text = zero.Text;
            }
            answer.Text = answer.Text + zero.Text;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            temp1 = answer.Text;
            answer.Text = null;
            operators = multiply.Name;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            temp2 = answer.Text;
            if (operators == "multiply") {
                result = Int16.Parse(temp1) * Int16.Parse(temp2);
                answer.Text = result.ToString();
            }
            if (operators == "divide") { 
                result = Convert.ToInt16(temp1)/Convert.ToInt16(temp2);
                answer.Text = result.ToString();
            }
            if (operators == "add") {
                result = Convert.ToInt16(temp1) + Convert.ToInt16(temp2);
                answer.Text = result.ToString();
            }
            if (operators == "sub") {
                result = Convert.ToInt16(temp1) - Convert.ToInt16(temp2);
                answer.Text = result.ToString();
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            temp1 = answer.Text;
            answer.Text = null;
            operators = divide.Name;
        }

        private void add_Click(object sender, EventArgs e)
        {
            temp1 = answer.Text;
            answer.Text = null;
            operators = add.Name;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            temp1 = answer.Text;
            answer.Text = null;
            operators = sub.Name;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            temp1 = null;
            temp2 = null;
            answer.Text = null;
        }

    }
}
