﻿//Created By : Jacques Nel - 31986595:
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


namespace G18_s_Airlines_CMPG223
{
    public partial class Form1 : Form
    {
        //Variables:
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-MH1J1TG;Initial Catalog=AIRPORT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand Comm;
        SqlDataAdapter Adapt;
        SqlDataReader Reading;
        DataSet DS;

        public Form1()
        {
            InitializeComponent();
        }

        //Function To Update DataBase:
        private void Update_Database()
        {
            //Updating FLIGHTS Table:
            try
            {
                Conn.Open();

                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT * FROM FLIGHTS";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "FLIGHTS");

                DG_View.DataSource = DS;
                DG_View.DataMember = "FLIGHTS";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        // Function To Update ComboBox:
        private void Update_ComboBox()
        {
            try
            {
                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT DISTINCT Flight_Number FROM FLIGHTS";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "FLIGHTS");

                ComboBox_Flights.DisplayMember = "Flight_Number";
                ComboBox_Flights.ValueMember = "Flight_Number";
                ComboBox_Flights.DataSource = DS.Tables["FLIGHTS"];

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Displaying Flights In DataGrid View:
            try
            {
                Conn.Open();

                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT * FROM FLIGHTS";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "FLIGHTS");

                DG_View.DataSource = DS;
                DG_View.DataMember = "FLIGHTS";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            //Populating Combo_Box On Form Load:
            Update_ComboBox();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
