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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.msgBox.Text = "";
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-G4UC9H3I\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string A_ID = textBox4.Text;
            string A_rn = textBox6.Text;
            string A_seats = textBox5.Text;
            string A_AID = textBox1.Text;

            con.Open();
            string firstQuery = "INSERT INTO Airplane(planeRegNo, planeType, noOfSeat,alineCode) values(@id, @rg, @seats, @airlineID)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            cmd.Parameters.AddWithValue("@id", A_ID);
            cmd.Parameters.AddWithValue("@rg", A_rn);
            cmd.Parameters.AddWithValue("@seats", A_seats);
            cmd.Parameters.AddWithValue("@airlineID", A_AID);
            cmd.ExecuteNonQuery();
            this.msgBox.Text = "Your Data has been saved😊";
            textBox5.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";

            con.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
