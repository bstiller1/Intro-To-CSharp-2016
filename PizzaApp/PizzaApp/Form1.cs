using System;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class Form1 : Form
    {
        private string order;
        private double totalCost;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmboSize.SelectedIndex = 0;
            cmboCrust.SelectedIndex = 0;
            cmboSpecialty.SelectedIndex = 0;
            txtBxSodaQty.Text = "0";
            txtBxWaterQty.Text = "0";
            order = "";
            totalCost = 0;
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double drinkCost, pizzaCost, specialtyCost;
            order = " ";
            order += cmboCrust.SelectedItem.ToString() + " - ";
            order += cmboSize.SelectedItem.ToString() + "\n";
            if(ckBxItems.SelectedItems.Count > 0)
            {
                order += "Toppings: ";
                foreach(string s in ckBxItems.CheckedItems)
                {
                    order += "\n" + s;
                }
            }
            pizzaCost = DeterminePizzaCost();
            if(pizzaCost != 0)
            {
                order += "\nPizza Total: " + pizzaCost.ToString("C");
            }
            drinkCost = DetermineDrinkCost();
            if (drinkCost != 0)
            {
                order += "\nDrink Total: " + drinkCost;
            }
                specialtyCost = DetermineSpecialtyCost();
                if(specialtyCost != 0)
                {
                    order += "\n\nSpecialty Items:\n" + cmboSpecialty.SelectedItem.ToString();
                }
                order += "\n\nAmount Due: " + (pizzaCost + drinkCost + specialtyCost).ToString("C");
                MessageBox.Show(order, "B & D Pizza Express Order\n");
            }
            private double DetermineDrinkCost()
        {
            double sodaCnt, waterCnt;
            totalCost = 0;
            if(txtBxSodaQty.Text != " ")
            {
                while(double.TryParse(txtBxSodaQty.Text, out sodaCnt) == false)
                {
                    MessageBox.Show("Quantity must be numeric", "Error");
                    txtBxSodaQty.Text = "0";
                }
                order += "\n\nDrink Selections:\n" + sodaCnt + " soda(s)";
                totalCost = sodaCnt * 1.75;
            }
            if(txtBxWaterQty.Text != " ")
            {
                while(double.TryParse(txtBxWaterQty.Text, out waterCnt) == false)
                {
                    MessageBox.Show("Quantity must be numeric", "Error");
                    txtBxWaterQty.Text = "0";
                }
                order += "\n" + waterCnt + " water(s)";
            }
            return totalCost;
        }
        public double DeterminePizzaCost()
        {
            double cost;
            if(cmboSize.SelectedIndex == 0)
            {
                cost = 9.95;
            }
            else if (cmboSize.SelectedIndex == 0)
            {
                cost = 12.95;
            }
            else
            {
                cost = 15.95;
            }
            return cost + (ckBxItems.CheckedItems.Count * 1.50);
        }
        public double DetermineSpecialtyCost()
        {
            double cost;
            if(cmboSpecialty.SelectedIndex == 1)
            {
                cost = 5.00;
            }
            else if (cmboSpecialty.SelectedIndex == 2)
            {
                cost = 4.00;
            }
            else if (cmboSpecialty.SelectedIndex == 3)
            {
                cost = 3.00;
            }
            else
            {
                cost = 0;
            }
            return cost;
        }
      }
    }

