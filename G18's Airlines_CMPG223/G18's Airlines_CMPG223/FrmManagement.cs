//Created By: Jacques Nel - 31986595:
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
    public partial class FrmManagement : Form
    {
        //Variables:
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-MH1J1TG;Initial Catalog=AIRPORT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand Comm;
        SqlDataAdapter Adapt;
        SqlDataReader Reading;
        DataSet DS;

        public FrmManagement()
        {
            InitializeComponent();
        }

        //Function To Update DataBase: For FLIGHTS:
        private void Update_Database_Flights()
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

                DG_Flights.DataSource = DS;
                DG_Flights.DataMember = "FLIGHTS";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        // Function To Update ComboBox:
        private void Update_ComboBox_Flights()
        {
            //Updating With Flight_Number values:
            try
            {
                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT DISTINCT Flight_Number FROM FLIGHTS";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "FLIGHTS");

                CB_Flights.DisplayMember = "Flight_Number";
                CB_Flights.ValueMember = "Flight_Number";
                CB_Flights.DataSource = DS.Tables["FLIGHTS"];

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Function To Update DataBase: FOr Bookings:
        private void Update_Bookings()
        {
            //Updating BOOKING Table:
            try
            {
                Conn.Open();

                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT * FROM BOOKING";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "BOOKING");

                DG_Booking.DataSource = DS;
                DG_Booking.DataMember = "BOOKING";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        // Function To Update ComboBox Booking Number:
        private void Update_ComboBox_BookingNum()
        {
            //Updating With Booking_Number values:
            try
            {
                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT DISTINCT Booking_Number FROM BOOKING";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "BOOKING");

                CB_Booking.DisplayMember = "Booking_Number";
                CB_Booking.ValueMember = "Booking_Number";
                CB_Booking.DataSource = DS.Tables["BOOKING"];

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Update_Member()
        {
            //Updating Member Table:
            try
            {
                Conn.Open();

                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT * FROM MEMBER";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "MEMBER");

                DG_Member.DataSource = DS;
                DG_Member.DataMember = "MEMBER";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        // Function To Update ComboBox Member:
        private void Update_ComboBox_Member()
        {
            //Updating With Booking_Number values:
            try
            {
                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT DISTINCT Member_ID FROM MEMBER";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "MEMBER");

                CB_Members.DisplayMember = "Member_ID";
                CB_Members.ValueMember = "Member_ID";
                CB_Members.DataSource = DS.Tables["MEMBER"];

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------

        private void FrmManagement_Load(object sender, EventArgs e)
        {
            //Displaying Flights In DataGrid View On Program Load:
            try
            {
                Conn.Open();

                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT * FROM FLIGHTS";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "FLIGHTS");

                DG_Flights.DataSource = DS;
                DG_Flights.DataMember = "FLIGHTS";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            //Functions:
            Update_Database_Flights();
            Update_ComboBox_Flights();
            Update_Bookings();
            Update_ComboBox_BookingNum();
            Update_Member();
            Update_ComboBox_Member();

            //Displaying Bookings In DataGrid View On Program Load:
            try
            {
                //Conn = new SqlConnection(Connstring);
                Conn.Open();

                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT * FROM BOOKING";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "BOOKING");

                DG_Booking.DataSource = DS;
                DG_Booking.DataMember = "BOOKING";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnDeleteFlight_Click(object sender, EventArgs e)
        {
            //Deleting Flights Based On Flight Number:
            string ComboBox_Val = CB_Flights.Text;

            try
            {
                Conn.Open();

                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL_2 = $"DELETE FROM FLIGHTS WHERE Flight_Number = '{ComboBox_Val}'";
                Comm = new SqlCommand(SQL_2, Conn);
                Comm.ExecuteNonQuery();

                Conn.Close();

                Update_Database_Flights();
                Update_ComboBox_Flights();
                MessageBox.Show("Flight Deleted");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Btn_DeleteBooking_Click(object sender, EventArgs e)
        {
            //Deleting Bookings:
            //Deleting Bookings Based On Booking Number:
            string ComboBox_Val = CB_Booking.Text;

            try
            {
                Conn.Open();

                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL_2 = $"DELETE FROM BOOKING WHERE Booking_Number = '{ComboBox_Val}'";
                Comm = new SqlCommand(SQL_2, Conn);
                Comm.ExecuteNonQuery();

                Conn.Close();

                Update_Bookings();
                Update_ComboBox_BookingNum();

                MessageBox.Show("BOOKING Deleted");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Btn_DeleteMembers_Click(object sender, EventArgs e)
        {
            //Deleting Member:
            //Deleting Member Based On Member ID:
            string ComboBox_Val = CB_Members.Text;

            try
            {
                Conn.Open();

                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL_2 = $"DELETE FROM MEMBER WHERE Member_ID = '{ComboBox_Val}'";
                Comm = new SqlCommand(SQL_2, Conn);
                Comm.ExecuteNonQuery();

                Conn.Close();

                Update_Member();
                Update_ComboBox_Member();

                MessageBox.Show("Member Deleted");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
