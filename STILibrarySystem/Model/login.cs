using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace STILibrarySystem
{
    public class login
    {
        public static string position;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");
        public void UserCredentials(string username, string password)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM account WHERE username=@username AND password=@password";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader dr = cmd.ExecuteReader(); 

            if (dr.Read())
            {
                string firstname = Convert.ToString(dr["firstname"]);
                string lastname = Convert.ToString(dr["lastname"]);
                position = Convert.ToString(dr["username"]);
                DateTime date = DateTime.Now;
                HomePage HP = new HomePage();
                HP.Show(); 
               
                //For Popup Notification
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Successfully Logged In to STI Library System";
                popup.ContentText = "Name: " + firstname + " " + lastname + "\n" + "Time Logged In: " + " " + date.ToString("dddd MMMM dd, yyyy hh:mm:tt");
                popup.AnimationDuration = 2000;
                popup.BodyColor = System.Drawing.Color.FromArgb(228, 241, 254);
                popup.ContentFont = new System.Drawing.Font("AvantGarde Bk BT", 8F);
                popup.TitleFont = new System.Drawing.Font("AvantGarde Bk BT", 10F);
                popup.TitleColor = System.Drawing.Color.FromArgb(52, 152, 219);
                popup.HeaderColor = System.Drawing.Color.FromArgb(245, 215, 110);
                popup.Popup();

               
            }

            else
            {
                MessageBox.Show("The password or username you've entered is incorrect.", "Failed login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }


        public void UserInfo(string username)
        {
           
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT firstname, lastname FROM account WHERE username= @username";
            cmd.Parameters.AddWithValue("@username", username);
        }
    }
}
