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
    public class bookBorrow
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");

        public void book_Borrow(string studentNo, string firstname, string lastname, string middlename, string patronType, string Department, string bookNumber, string titleofBook, string author)
        {

            List<string> datelist = new List<string>();
            DialogResult result = MessageBox.Show("Are You Sure You Want To Borrow this Book? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var command1 = new SqlCommand("UPDATE List_of_books SET copies = copies - 1 WHERE book_number = " + int.Parse(bookNumber), con);
                    con.Open();
                    command1.ExecuteNonQuery();
                    con.Close();


                    var cmd = new SqlCommand("SELECT days_of_return FROM List_of_books WHERE book_number = " + int.Parse(bookNumber), con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                        var returnedday = Convert.ToInt32((sdr["days_of_return"]));

                        DateTime start = DateTime.Now;
                        DateTime sdate = start;
                        int i = 1;

                        while (i <= returnedday)
                        {
                            sdate = sdate.AddDays(1);
                            if (sdate.DayOfWeek != DayOfWeek.Sunday)
                            {
                                i++;
                                string date = sdate.ToString("yyyy-MM-dd");
                                datelist.Add(date);


                                Console.WriteLine(date);
                            }
                            else
                            {
                            }
                        }
                    }
                    con.Close();

                    DateTime datetoday = DateTime.Now;
                    var command = new SqlCommand("INSERT INTO borrow_books VALUES (@student_no, @firstname, @lastname, @middlename, @patron_type, @department, @book_no, @title_of_book, @author, @borrowed_date, @borrow_returned)", con);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@student_no", studentNo);
                    command.Parameters.AddWithValue("@firstname", firstname);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@middlename", middlename);
                    command.Parameters.AddWithValue("@patron_type", patronType);
                    command.Parameters.AddWithValue("@department", Department);
                    command.Parameters.AddWithValue("@book_no", bookNumber);
                    command.Parameters.AddWithValue("@title_of_book", titleofBook);
                    command.Parameters.AddWithValue("@author", author);
                    command.Parameters.AddWithValue("@borrowed_date", datetoday.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@borrow_returned", datelist.Last());
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Borrowed Book Successfully \nBook Title: " + titleofBook + "\nBook Borrowed: " + datetoday.ToString("yyyy-MM-dd") + "\nBook Returned: " + datelist.Last(), "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }

            else
            {
                //Do Something  
            }
        }

    }
    }



