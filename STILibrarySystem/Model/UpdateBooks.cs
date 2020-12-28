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
    public class UpdateBooks
    {
        public void SaveUpdateBooks(string TitleOfBook, string CategoryCode, string Author, string CallNumber, string Copyrights, string Copies, string textBox1, string booknumber)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");

            try
            {
                var cmd = new SqlCommand("UPDATE List_of_Books SET title_of_book =  @title_of_book, category_code = @category_code, author = @author, call_number = @call_number, copyrights = @copyrights, copies = @copies, days_of_return = @days_of_return WHERE book_number = @book_number", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@title_of_book", TitleOfBook);
                cmd.Parameters.AddWithValue("@category_code", CategoryCode);
                cmd.Parameters.AddWithValue("@author", Author);
                cmd.Parameters.AddWithValue("@call_number", CallNumber);
                cmd.Parameters.AddWithValue("@copyrights", Copyrights);
                cmd.Parameters.AddWithValue("@copies", Copies);
                cmd.Parameters.AddWithValue("@days_of_return", textBox1);
                cmd.Parameters.AddWithValue("@book_number", booknumber);
               

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
