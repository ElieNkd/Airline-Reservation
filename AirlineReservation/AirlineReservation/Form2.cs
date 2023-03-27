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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.msgBox.Text = "";
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-G4UC9H3I\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
        }
        public void save()
        {
            string A_ID = airlineID.Text;
            string A_Name = airlineName.Text;
            string A_Crafts = crafts.Text;

            con.Open();
            string firstQuery = "INSERT INTO Airline(alineCode, alineAddress, alineName) values(@id, @name, @crft)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            cmd.Parameters.AddWithValue("@name", A_Name);
            cmd.Parameters.AddWithValue("@id", A_ID);
            cmd.Parameters.AddWithValue("@crft", A_Crafts);
            cmd.ExecuteNonQuery();
            this.msgBox.Text = "Your Data has been saved😊";
            airlineID.Text = "";
            airlineName.Text = "";
            crafts.Text = "";

            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
