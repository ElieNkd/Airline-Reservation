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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-G4UC9H3I\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
            this.label26.Text = "";
            loadflights();
        }
        public void loadflights()
        {
            con.Open();

            this.comboBox1.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select flightNo from Flight", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                this.comboBox1.Items.Add(id);
            }
            con.Close();

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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label26.Text = "Your Flight has been booked😊";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string found = comboBox1.Text;
            this.comboBox12.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select ticketNo from Flight inner join Flight_Route on Flight.routeNo = Flight_Route.routeNo AND FlightNo= @a ", con);
            cmd.Parameters.AddWithValue("@a", found);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                this.comboBox12.Items.Add(id);
            }
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string found = comboBox12.Text;
            SqlCommand cmd = new SqlCommand("Select paymentMethod from Fair where ticketNo = @a", con);
            cmd.Parameters.AddWithValue("@a", found);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string c = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                this.comboBox10.Items.Add(c);

            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string found = comboBox1.Text;
            SqlCommand cmd = new SqlCommand("Select TAID from Booking where FlightNo = @a", con);
            cmd.Parameters.AddWithValue("@a", found);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            textBox2.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            con.Close();
            con.Open();
            string found1 = comboBox12.Text;
            SqlCommand cmd1 = new SqlCommand("Select amount from Fair where ticketNo = @aa", con);
            cmd1.Parameters.AddWithValue("@aa", found1);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1);
            textBox1.Text = ds1.Tables[0].Rows[1].ItemArray[0].ToString()+" L.L.";
            con.Close();
        }
    }
}
