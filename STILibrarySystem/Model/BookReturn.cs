using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STILibrarySystem
{
    public class BookReturn
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");
        public void issuedBook(string booknumber)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Returned this Book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {

                    var command1 = new SqlCommand("UPDATE List_of_books SET copies = copies + 1 WHERE book_number = " + booknumber, con);


                    con.Open();
                    command1.ExecuteNonQuery();
                    con.Close();


                    SqlCommand command = new SqlCommand("DELETE FROM borrow_books WHERE book_no = " + booknumber, con);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Returned Book Successfully", "Successfully Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }

            else
            {
                //Do Somethins
            }
        }
    }
}
