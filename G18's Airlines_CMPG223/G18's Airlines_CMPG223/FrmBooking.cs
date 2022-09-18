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
    public partial class FrmBooking : Form
    {
        //Variables:
        SqlConnection Conn;
        string Connstring = @"Data Source=DESKTOP-MH1J1TG;Initial Catalog=AIRPORT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlCommand Comm;
        SqlDataAdapter Adapt;
        SqlDataReader Reading;
        DataSet DS;

        public FrmBooking()
        {
            InitializeComponent();
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

                Dg_Bookings.DataSource = DS;
                Dg_Bookings.DataMember = "BOOKING";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }







        private void FrmBooking_Load(object sender, EventArgs e)
        {

           
            //Displaying Bookings In DataGrid View On Program Load:
            try
            {
                Conn = new SqlConnection(Connstring);
                Conn.Open();

                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT * FROM BOOKING";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "BOOKING");

                Dg_Bookings.DataSource = DS;
                Dg_Bookings.DataMember = "BOOKING";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            Update_Bookings();
        }

        private void Btn_Booking_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(Connstring);

            //Error Providers When Certian Fields Are Empty:
            try
            {
                if (Txt_BookingNumber.Text == string.Empty)
                {
                    ErrProvider.SetError(Txt_BookingNumber, "Please Enter A Booking Number");
                }
                else if (Txt_MemberID.Text == string.Empty)
                {
                    ErrProvider.SetError(Txt_MemberID, "Please Enter A Member ID");
                }
                else if (Txt_FLNumber.Text == string.Empty)
                {
                    ErrProvider.SetError(Txt_FLNumber, "Please Enter A Flight Number");
                }
                else if (Txt_BookingDate.Text == string.Empty)
                {
                    ErrProvider.SetError(Txt_BookingDate, "Please Enter A Booking Date");
                }
                else
                {
                    Conn.Open();

                    string SQL = "INSERT INTO BOOKING (Booking_Number, Member_ID, Flight_Number, Booking_Date) VALUES(@Booking_Number, @Member_ID, @Flight_Number, @Booking_Date)";


                    //Recording User Input:
                    Comm = new SqlCommand(SQL, Conn);
                    Comm.Parameters.AddWithValue("@Booking_Number", Txt_BookingNumber.Text);
                    Comm.Parameters.AddWithValue("@Member_ID", Txt_MemberID.Text);
                    Comm.Parameters.AddWithValue("@Flight_Number", Txt_FLNumber.Text);
                    Comm.Parameters.AddWithValue("@Booking_Date", Txt_BookingDate.Text);


                    Comm.ExecuteNonQuery();
                    Conn.Close();
                    MessageBox.Show("Booking Added");
                    Update_Bookings();

                }
                


                
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_AddMember_Click(object sender, EventArgs e)
        {
            FrmMembers MemForm = new FrmMembers();
            MemForm.FormClosed += MemForm_FormClosed;
            MemForm.ShowDialog();
        }

        private void MemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Form loaded");
        }
    }
}
