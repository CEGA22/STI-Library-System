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
    public class DeleteBook
    {
        public void DeleteBookItem(string booknumber)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");

            try
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to Delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var cmd = new SqlCommand("DELETE FROM  List_of_Books WHERE book_number = @book_number", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@book_number", booknumber);

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
