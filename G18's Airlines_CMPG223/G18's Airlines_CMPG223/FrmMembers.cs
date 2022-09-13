//Created By : Jacques Nel - 31986595:
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
    public partial class FrmMembers : Form
    {
        //Variables:
        SqlConnection Conn;
        string Connstring = @"Data Source=DESKTOP-MH1J1TG;Initial Catalog=AIRPORT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlCommand Comm;
        SqlDataAdapter Adapt;
        SqlDataReader Reading;
        DataSet DS;

        public FrmMembers()
        {
            InitializeComponent();
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

                DG_Members.DataSource = DS;
                DG_Members.DataMember = "MEMBER";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------

        private void FrmMembers_Load(object sender, EventArgs e)
        {
            //Displaying Members In DataGrid View On Program Load:
            try
            {
                Conn.Open();

                Adapt = new SqlDataAdapter();
                DS = new DataSet();

                string SQL = "SELECT * FROM MEMBER";

                Comm = new SqlCommand(SQL, Conn);
                Adapt.SelectCommand = Comm;
                Adapt.Fill(DS, "MEMBER");

                DG_Members.DataSource = DS;
                DG_Members.DataMember = "MEMBER";

                Conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Btn_AddMember_Click(object sender, EventArgs e)
        {
            //Connection String:
            Conn = new SqlConnection(Connstring);

            try
            {
                if (Txt_MemberID.Text == string.Empty)
                {
                    ErrProvider.SetError(Txt_MemberID, "Please Enter A Member ID");
                }
                else if (Txt_FirstName.Text == string.Empty)
                {
                    ErrProvider.SetError(Txt_FirstName, "Please Enter A First Name");
                }
                else if (Txt_LastName.Text == string.Empty)
                {
                    ErrProvider.SetError(Txt_LastName, "Please Enter A Last Name");
                }
                else if (Txt_Email.Text == string.Empty)
                {
                    ErrProvider.SetError(Txt_Email, "Please Enter An Email Address");
                }
                else if (Txt_IDNumber.Text == string.Empty)
                {
                    ErrProvider.SetError(Txt_IDNumber, "Please Enter An ID Number");
                }
                else
                {
                    Conn.Open();

                    string SQL = "INSERT INTO MEMBER (Member_ID, First_Name, Last_Name, Email, ID_Number) VALUES (@Member_ID, @First_Name, @Last_Name, @Email, @ID_Number)";

                    //Recording User Input:
                    Comm = new SqlCommand(SQL, Conn);

                    Comm.Parameters.AddWithValue("@Member_ID", Txt_MemberID.Text);
                    Comm.Parameters.AddWithValue("@First_Name", Txt_FirstName.Text);
                    Comm.Parameters.AddWithValue("@Last_Name", Txt_LastName.Text);
                    Comm.Parameters.AddWithValue("@Email", Txt_Email.Text);
                    Comm.Parameters.AddWithValue("@ID_Number", Txt_IDNumber.Text);

                    Comm.ExecuteNonQuery();
                    Conn.Close();
                    MessageBox.Show("Member Added");
                    Update_Member();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
