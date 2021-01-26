using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STILibrarySystem
{
    public class TotalStudents
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");
        public int Totalstudents;

        public void students()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM student_information";
                con.Open();
                Totalstudents = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

            }

            catch (Exception e)
            {

            }
        }
    }
}
