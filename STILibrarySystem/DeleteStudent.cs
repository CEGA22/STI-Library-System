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
    public class DeleteStudent
    {
        public void DeleteStudentInfo(string Student)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");

            try
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to Delete this Student Information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var cmd = new SqlCommand("DELETE FROM  student_information WHERE student_id = @student_id", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@student_id", Student);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Deleted Successfully", "Delete Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    //Do Something
                }



            }

            catch (Exception)
            {

            }
        }
    }
}
