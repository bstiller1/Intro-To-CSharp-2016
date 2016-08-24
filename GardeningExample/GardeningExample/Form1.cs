using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardeningExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmboFlowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBxResultFlowers.Text = cmboFlowers.Text;
        }
        private void cmboFlowers_KeyPress(object sender, EventArgs e)
        {
            txtBxResultFlowers.Text = cmboFlowers.Text;
        }

        private void lstBxTrees_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBxResultTrees.Text = " ";
            foreach (int i in lstBxTrees.SelectedIndices)
            {
                txtBxResultTrees.Text += lstBxTrees.Items[i] + " ";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gardening Guide Application\nVersion 1.0", "About Gardening");
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = lblOutput.Font;
            
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblOutput.Font = fontDialog1.Font;
                label1.Font = fontDialog1.Font;
                label2.Font = fontDialog1.Font;
                label3.Font = fontDialog1.Font;
                label4.Font = fontDialog1.Font;

            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblOutput.ForeColor;
            if(colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblOutput.ForeColor = colorDialog1.Color;
                label1.ForeColor = colorDialog1.Color;
                label2.ForeColor = colorDialog1.Color;
                label3.ForeColor = colorDialog1.Color;
                label4.ForeColor = colorDialog1.Color;

            }
        }
    }
}
