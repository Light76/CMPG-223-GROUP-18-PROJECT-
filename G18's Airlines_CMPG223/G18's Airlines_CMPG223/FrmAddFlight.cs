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
    public partial class FrmAddFlight : Form
    {
        //Variables:
        SqlConnection Conn;
        string Connstring = @"Data Source=DESKTOP-MH1J1TG;Initial Catalog=AIRPORT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlCommand Comm;
        SqlDataAdapter Adapt;
        SqlDataReader Reading;
        DataSet DS;

        public FrmAddFlight()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddFlight_Load(object sender, EventArgs e)
        {

        }

        private void Btn_InsertFlight_Click(object sender, EventArgs e)
        {   
            //Connection String:
            Conn = new SqlConnection(Connstring);

            //Error Providers When Fields Are Empty:
            try
            {
                if (Txt_FlightNumber.Text == string.Empty)
                {
                    ErrorProvider.SetError(Txt_FlightNumber, "Please Enter A Flight Number");
                }
                else if (Txt_DestinationID.Text == string.Empty)
                {
                    ErrorProvider.SetError(Txt_DestinationID, "Please Enter A Destination ID");
                }
                else if (Txt_DepartureDate.Text == string.Empty)
                {
                    ErrorProvider.SetError(Txt_DepartureDate, "Please Enter A Departue Date");
                }
                else if (Txt_PlaneNumber.Text == string.Empty)
                {
                    ErrorProvider.SetError(Txt_PlaneNumber, "Please Enter A Plane Number");
                }
                else if (Txt_GateNumber.Text == string.Empty)
                {
                    ErrorProvider.SetError(Txt_GateNumber, "Please Enter A Gate Number");
                }
                else if (Txt_Status.Text == string.Empty)
                {
                    ErrorProvider.SetError(Txt_Status, "Please Enter The Status Of The Flight");
                }
                else if (Txt_Price.Text == string.Empty)
                {
                    ErrorProvider.SetError(Txt_Price, "Please Enter A Price For The Flight");
                }
                //If Entries Are Valid, Add Records To Database:
                else
                {
                    Conn.Open();

                    string SQL = "INSERT INTO FLIGHTS (Flight_Number, Destination_ID, Departure_Date, Plane_Number, Gate_Number, Status, Price) VALUES(@Flight_Number, @Destination_ID, @Departure_Date, @Plane_Number, @Gate_Number, @Status, @Price)";

                    //Recording User Input:
                    Comm = new SqlCommand(SQL, Conn);
                    Comm.Parameters.AddWithValue("@Flight_Number", Txt_FlightNumber.Text);
                    Comm.Parameters.AddWithValue("@Destination_ID", Txt_DestinationID.Text);
                    Comm.Parameters.AddWithValue("@Departure_Date", Txt_DepartureDate.Text);
                    Comm.Parameters.AddWithValue("@Plane_Number", Txt_PlaneNumber.Text);
                    Comm.Parameters.AddWithValue("@Gate_Number", Txt_GateNumber.Text);
                    Comm.Parameters.AddWithValue("@Status", Txt_Status.Text);
                    Comm.Parameters.AddWithValue("@Price", Txt_Price.Text);

                    Comm.ExecuteNonQuery();
                    Conn.Close();
                    MessageBox.Show("Flight Added");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
