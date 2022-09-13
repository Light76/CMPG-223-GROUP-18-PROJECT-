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

                DG_Flights.DataSource = DS;
                DG_Flights.DataMember = "FLIGHTS";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------

        private void FrmManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
