using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Global FileName field
        public string fileName;
        public Form1()
        {
            InitializeComponent();
        }
        // Implement Event Listeners
        // Open File Dialog
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It worked!");
        }
        // Save File Dialog
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It worked!");
        }
        // Save As File Dialog
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It worked!");
        }
        // Close File
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
        // Exit Program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //  About Dialog and Link
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my text file editor.\n ver. 1.001 \n 2015");
        }
        // Help
        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For help with this application. \n me@blakestiller.com");
        }

        
    }
}
