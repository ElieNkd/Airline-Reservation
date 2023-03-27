﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-G4UC9H3I\\SQLEXPRESS;Initial Catalog=AirlineReservation;Integrated Security=True");
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteButtonCon_Click(object sender, EventArgs e)
        {
            string A_ID = airportID.Text;
            string A_Name = airportName.Text;
            string A_City = city.Text;
            string A_Country = country.Text;

            con.Open();
            string firstQuery = "INSERT INTO Airport(airportCode, airportName, city, country) values(@id, @name, @city, @country)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            cmd.Parameters.AddWithValue("@id", A_ID);
            cmd.Parameters.AddWithValue("@name", A_Name);
            cmd.Parameters.AddWithValue("@city", A_City);
            cmd.Parameters.AddWithValue("@country", A_Country);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Data has been saved😊");

            airportID.Text = "";
            airportName.Text = "";
            city.Text = "";
            country.Text = "";

            con.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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
    }
}
