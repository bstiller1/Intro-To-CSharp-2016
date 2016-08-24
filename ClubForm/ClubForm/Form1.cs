using System;
using System.Windows.Forms;

namespace ClubForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstBxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = " ";
            foreach (string activity in lstBxEvents.SelectedItems)
            {
                result += activity +"    ";
            }
            this.txtBxResult.Text = result;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstBxEvents.Items.Add(txtBxAddNew.Text);
            txtBxAddNew.Clear();
        }

    }
}
