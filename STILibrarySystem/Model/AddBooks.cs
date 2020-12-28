using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STILibrarySystem
{
    public class AddBooks
    {
        public void SaveAddBooks(string Booknumber, string titleofbook, string categorycode, string author, string callnumber, string copyrights, string copies, string daysofReturn)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO List_of_Books VALUES(@book_number, @title_of_book, @category_code, @author, @call_number, @copyrights, @copies, @days_of_return)";
                cmd.Parameters.AddWithValue("@book_number", Booknumber);
                cmd.Parameters.AddWithValue("@title_of_book", titleofbook);
                cmd.Parameters.AddWithValue("@category_code", categorycode);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@call_number", callnumber);
                cmd.Parameters.AddWithValue("@copyrights", copyrights);
                cmd.Parameters.AddWithValue("@copies",copies);
                cmd.Parameters.AddWithValue("@days_of_return", daysofReturn);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Added New Book Successfully!\n Check the newly added book in List of Books tab", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }

            catch(Exception e1)
            {
                MessageBox.Show("Please Fill all the details or You Entered Existing Book.No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
    }
}
