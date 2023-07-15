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


namespace Solaroz
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = this.UserNameBox.Text;
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=databasename;Data Source=WINDOWS-0UQCBNS\\SQLEXPRESS\r\n";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sqlQuery = "SELECT password FROM connection where username='"+UserName+"'";
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                string value = reader.GetString(0);
                PasswordBox.Text=value;
                
            }

            reader.Close();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            managerForm form2 = new managerForm();

            // Show Form2
            form2.Show();

            // Hide or close Form1 if desired
            this.Hide(); // or this.Close();
        }
    }
}
