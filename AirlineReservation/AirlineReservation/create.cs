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
    public partial class create: Form
    {
        public create()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-J8VIM1H\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True");
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string passportNo = textBox8.Text;
            string fname = textBox7.Text;
            string mname = textBox6.Text;
            string lname = textBox5.Text;
            string passcode = textBox4.Text;
            string age = textBox1.Text;
            string gender = textBox2.Text;
            string pAddress = textBox9.Text;
            string TAID = textBox10.Text;

            con.Open();
            string firstQuery = "INSERT INTO Passenger(passportNo, passcode, fname, mname, lname, age, gender, pAddress, TAID ) values(@a, @b, @c, @d, @e, @f, @g, @h, @i)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            cmd.Parameters.AddWithValue("@a", passportNo);
            cmd.Parameters.AddWithValue("@b", passcode);
            cmd.Parameters.AddWithValue("@c", fname);
            cmd.Parameters.AddWithValue("@d", mname);
            cmd.Parameters.AddWithValue("@e", lname);
            cmd.Parameters.AddWithValue("@f", age);
            cmd.Parameters.AddWithValue("@g", gender);
            cmd.Parameters.AddWithValue("@h", pAddress);
            cmd.Parameters.AddWithValue("@i", TAID);
            cmd.ExecuteNonQuery();
            con.Close();

            new login().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
