using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbStoreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\triosstudent\documents\visual studio 2015\Projects\dbStoreApp\dbStoreApp\store.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand CmdSql = new SqlCommand("INSERT INTO people (fname, lname, phone) VALUES (@fname, @lname, @phone)", conn);
                conn.Open();
                CmdSql.Parameters.AddWithValue("@fname", textBox1.Text);
                CmdSql.Parameters.AddWithValue("@lname", textBox2.Text);
                CmdSql.Parameters.AddWithValue("@phone", textBox3.Text);
                CmdSql.ExecuteNonQuery();
                conn.Close();
            }



        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
