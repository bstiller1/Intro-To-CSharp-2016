using System;
using System.Windows.Forms;

namespace TextForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void calculate(string symbol)
        {
            try
            {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);
            int answer = 0;
            switch (symbol)
            {
                case "+":
                answer = number1 + number2;
                break;
                case "-":
                answer = number1 - number2;
                break;
                case "*":
                answer = number1 * number2;
                break;
                case "/":
                        if (number2 == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        answer = number1 / number2;
                        break;
                }
                label3.Text = answer.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("You submitted a character instead of a number.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            calculate(btn.Text);
        }

    }
}
