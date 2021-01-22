using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STILibrarySystem
{
    public class AddStudent
    {
       

        public void SaveAddStudent(string StudentID, string Firstname, string Lastname, string Middlename, string Program, string Program_short, string Gender, string PatronType)
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO student_information VALUES(@student_id, @firstname, @lastname, @middlename, @program, @program_short , @gender , @patrontype)";
                    cmd.Parameters.AddWithValue("@student_id", StudentID);
                    cmd.Parameters.AddWithValue("@firstname", Firstname);
                    cmd.Parameters.AddWithValue("@lastname", Lastname);
                    cmd.Parameters.AddWithValue("@middlename", Middlename);
                    cmd.Parameters.AddWithValue("@program", Program);
                    cmd.Parameters.AddWithValue("@program_short", Program_short);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@patrontype", PatronType);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Added New Student Successfully!\n Check the newly added Student in List of Students tab", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                catch (Exception e1)
                {
                MessageBox.Show("Please Fill all the details or You Entered Existing Student.No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
        }
    
}
