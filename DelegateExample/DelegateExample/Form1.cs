using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateExample
{
    delegate string ReturnsSimpleString();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int age = 44;
            ReturnsSimpleString saying1 = new ReturnsSimpleString(AHeading);
            ReturnsSimpleString saying2 = new ReturnsSimpleString((age + 10).ToString);
            ReturnsSimpleString saying3 = new ReturnsSimpleString(EndStatement);
            MessageBox.Show(saying1() + saying2() + saying3());


        }
        static string AHeading()
        {
            return "Your age will be ";
        }
        static string EndStatement()
        {
            return " in 10 years.";
        }
    }
}
