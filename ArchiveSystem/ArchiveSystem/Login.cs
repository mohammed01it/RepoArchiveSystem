using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveSystem
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string _user;
        public static string _userID;
        public static string _depID;
        public static string _permitionTYpeID;
        public static string _con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con = new SqlConnection(_con);


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = TXT_User.Text;
                string password = TXT_pass.Text;

                string query = string.Format(@"SELECT   [UserID]
      ,[Username]
      ,[Password]
      ,[FullName]
      ,[DepartmentID]
      ,[PermitionTypeID]
      ,[PhoneNumber]
  FROM [ArchiveSystem].[dbo].[Users_TBL] where username=N'{0}' and password='{1}'", username, password ,con);




                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Close();
                adp.Fill(dt);
                if (dt.Rows.Count >0)
                {
                    string userID = dt.Rows[0]["UserID"].ToString();
                    string depID = dt.Rows[0]["DepartmentID"].ToString();
                     
                    string user = dt.Rows[0]["Username"].ToString();
                    string permitiontypeID = dt.Rows[0]["PermitionTypeID"].ToString();



                    Login login = new Login();
                    login.Hide();

                  
                       _user=user.ToString();
                     _userID=userID.ToString();
                    _depID = depID.ToString();
                    _permitionTYpeID = permitiontypeID.ToString();

                    Form1 f1 = new Form1();
                    f1.Show();

                }
                else
                {
                    MessageBox.Show("اسم المستخدم او الرمز  غير صحيح");
                }
               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          


        }
    }
}
