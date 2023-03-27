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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-G4UC9H3I\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
            this.msgBox.Text = "";
           loadAirplanes();
            loadCities();
            loadroutes();
        }
        public void loadAirplanes()
        {
            con.Open();

            this.comboBox6.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select planeRegNo from Airplane", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                this.comboBox6.Items.Add(id);
            }
            con.Close();
        }
        public void loadCities()
        {
            con.Open();

            this.comboBox4.Items.Clear();
            this.comboBox5.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select city from Airport", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string city = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                this.comboBox4.Items.Add(city);
                this.comboBox5.Items.Add(city);
            }
            con.Close();
        }
        public void loadroutes()
        {
            con.Open();

            this.comboBox1.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select routeNo from Flight_Route", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string route = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                this.comboBox1.Items.Add(route);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string F_ID = textBox10.Text;
            string F_CD = comboBox4.Text;
            string F_CA = comboBox5.Text;
            string departureTime = textBox9.Text + ":" + textBox8.Text + ":00";
            string arrivalTime = textBox7.Text + ":" + textBox6.Text + ":00";
            string DD = dateTimePicker4.Text;
            string AD = dateTimePicker3.Text;
            string A_ID = comboBox6.Text;
            string rr = comboBox1.Text;

            con.Open();
            string firstQuery = "INSERT INTO FLIGHT(flightNo, fSource, destination,departureTime, arrivalTime, departuteDate, arrivalDate, alineCode,routeNo) values(@fi, @CF, @CT, @DT, @AT, @AD, @DD, @ai,@r)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            cmd.Parameters.AddWithValue("@fi", F_ID);
            cmd.Parameters.AddWithValue("@CF", F_CD);
            cmd.Parameters.AddWithValue("@CT", F_CA);
            cmd.Parameters.AddWithValue("@DT", departureTime);
            cmd.Parameters.AddWithValue("@AT", arrivalTime);
            cmd.Parameters.AddWithValue("@AD", DD);
            cmd.Parameters.AddWithValue("@DD", AD);
            cmd.Parameters.AddWithValue("@ai", A_ID);
            cmd.Parameters.AddWithValue("@r", rr);
            cmd.ExecuteNonQuery();
            this.msgBox.Text = "Your Data has been saved😊";


            con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }
        
        private void backBtn_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
