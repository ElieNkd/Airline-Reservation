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

namespace AirlineReservation
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-G4UC9H3I\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;

            string logQuery = "select * from Passenger where passportNo = @id and  passcode= @pin";

            SqlCommand logCmd = new SqlCommand(logQuery, con);
            logCmd.Parameters.AddWithValue("@id", user);
            logCmd.Parameters.AddWithValue("@pin", pass);

            SqlDataAdapter LogAdpater = new SqlDataAdapter(logCmd);
            DataSet LogSet = new DataSet();
            LogAdpater.Fill(LogSet);

            if ((LogSet.Tables[0].Rows.Count) > 0)
            {
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credientials are incorrect. Try Again :)");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new create().Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
