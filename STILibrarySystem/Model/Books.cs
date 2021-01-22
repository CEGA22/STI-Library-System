using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STILibrarySystem
{
   public class Books
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");
         public int TotalBooks;

         public void totalbooks()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM List_of_Books";
                con.Open();                
                 TotalBooks = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

            }

            catch (Exception e)
            {

            }
        }

        
        
    }
}
