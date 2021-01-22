using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STILibrarySystem
{
   public class UpdateStudent
    {
        public void SaveUpdateStudent(string StudentID, string Firstname, string Lastname, string Middlename, string Gender, string Patrontype, string Program, string ProgramShort)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");

            try
            {
                var cmd = new SqlCommand("UPDATE student_information SET student_id =  @student_id, firstname = @firstname, lastname = @lastname, middlename = @middlename, program = @program , program_short = @program_short, sex = @gender,  patron_type = @patron_type WHERE student_id = @student_id", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@student_id", StudentID);
                cmd.Parameters.AddWithValue("@firstname", Firstname);
                cmd.Parameters.AddWithValue("@lastname", Lastname);
                cmd.Parameters.AddWithValue("@middlename", Middlename);
                cmd.Parameters.AddWithValue("@program", Program);
                cmd.Parameters.AddWithValue("@program_short", ProgramShort);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@patron_type", Patrontype);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Updated Successfully", "Update Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
