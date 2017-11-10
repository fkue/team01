using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GitTestForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            SqlConnection con = new SqlConnection("server = (localdb)\\MSSQLLocalDb; Integrated Security = yes; Database = Login;");

            SqlCommand cmd = new SqlCommand("SELECT count (*) as cnt from Users where username=@usr and password=@pwd", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usr", textBox1.Text);
            cmd.Parameters.AddWithValue("@pwd", textBox2.Text);
            try
            {
                con.Open();
                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    MessageBox.Show("Logged In");
                }
                else
                {
                    MessageBox.Show("Failed");
                }

                con.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
