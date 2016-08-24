using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

private void ComputeCost_CheckedChanged(object sender, EventArgs e)
        {
            decimal cost = 0;
            this.lblMsg.Text = "  ";
            if (this.ckBxSwim.Checked)
            {
                cost += 50;
            }
            if (this.ckBxSnorkel.Checked)
            {
                cost += 25;
            }
            if (this.ckBxDive.Checked)
            {
                cost += 100;
            }
            if (this.radBeginner.Checked)
            {
                cost += 10;
                this.lblMsg.Text = "Beginner -- Extra $10 charge";
            }
            else
            {
                if (this.radAdvanc.Checked)
                {
                    cost -= 15;
                    this.lblMsg.Text = "Advanced -- Discount $15";
                }
                else
                {
                    this.lblMsg.Text = "  ";
                }
                this.txtBxResult.Text = cost.ToString("C");
            }
        }
    }
}
