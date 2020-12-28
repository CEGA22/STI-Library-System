﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STILibrarySystem
{
    public partial class BorrowBook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");
        public BorrowBook()
        {
            InitializeComponent();
            bookdetailsdisabled(); 
        }

        public void bookdetailsdisabled()
        {
            txtBookNumber.Enabled = false;
            txtTitleofBook.Enabled = false;
            txtAuthor.Enabled = false;
            btnSearchBook.Enabled = false;
            btnProceed.Hide();
        }

        public void bookdetailsEnabled()
        {
            txtBookNumber.Enabled = true;
            txtTitleofBook.Enabled = true;
            txtAuthor.Enabled = true;
            btnSearchBook.Enabled = true;
            btnProceed.Show();
        }

        public void studentbookInfoCleared()
        {
            txtStudentNo.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            txtBookNumber.Text = "";
            txtTitleofBook.Text = "";
            txtAuthor.Text = "";
            txtPatronType.Text = "";
            txtDepartment.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM student_information WHERE student_id = " + int.Parse(txtStudentNo.Text), con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    txtFirstName.Text = (sdr["firstname"].ToString());
                    txtLastName.Text = (sdr["lastname"].ToString());
                    txtMiddleName.Text = (sdr["middlename"].ToString());
                    txtPatronType.Text = (sdr["patron_type"].ToString());
                    txtDepartment.Text = (sdr["program_short"].ToString());
                    bookdetailsEnabled();
                }

                else
                {
                    MessageBox.Show("Student No. Not in the List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }

            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT book_number, title_of_book, category_code, author, call_number, copyrights, copies, days_of_return FROM List_of_Books WHERE book_number = " + int.Parse(txtBookNumber.Text), con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                
                if (sdr.Read())
                {
                    var copies = (Convert.ToInt32(sdr["copies"]));
                    if (copies <= 0)
                    {
                        MessageBox.Show("Sorry this Book Is Not Availabel Right Now", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bookdetailsdisabled();
                        txtBookNumber.Text = "";
                    }

                    else
                    {
                        txtTitleofBook.Text = (sdr["title_of_book"].ToString());
                        txtAuthor.Text = (sdr["Author"].ToString());
                    }
                   
                }

                else
                {
                    MessageBox.Show("Book No. Not in the List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();

            }

            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
           
        }

        private void lbl_exit_MouseEnter(object sender, EventArgs e)
        {
            lbl_exit.BackColor = Color.FromArgb(217, 30, 24);
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

            else
            {
                //Do Something
            }
        }

        private void lbl_exit_MouseLeave(object sender, EventArgs e)
        {
            lbl_exit.BackColor = Color.FromArgb(37, 116, 169);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //List<string> datelist = new List<string>();
            //DialogResult result = MessageBox.Show("Are You Sure You Want To Borrow this Book? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            //if (result == DialogResult.Yes)
            //{
            //    try
            //    {
            //        var command1 = new SqlCommand("UPDATE List_of_books SET copies = copies - 1 WHERE book_number = " + int.Parse(txtBookNumber.Text), con);
            //        con.Open();
            //        command1.ExecuteNonQuery();
            //        con.Close();


            //        var cmd = new SqlCommand("SELECT days_of_return FROM List_of_books WHERE book_number = " + int.Parse(txtBookNumber.Text), con);
            //        con.Open();
            //        SqlDataReader sdr = cmd.ExecuteReader();

            //        if (sdr.Read())
            //        {
            //            var returnedday = Convert.ToInt32((sdr["days_of_return"]));

            //            DateTime start = DateTime.Now;
            //            DateTime sdate = start;
            //            int i = 1;
                        
                       

            //            while (i <= returnedday)
            //            {
            //                sdate = sdate.AddDays(1);
            //                if (sdate.DayOfWeek != DayOfWeek.Sunday)
            //                {
            //                    i++;
            //                    string date = sdate.ToString("yyyy-MM-dd");
            //                    datelist.Add(date);


            //                    Console.WriteLine(date);
            //                }
            //                else
            //                {
            //                }
            //            }
            //        }
            //        con.Close();

            //        DateTime datetoday = DateTime.Now;
            //        var command = new SqlCommand("INSERT INTO borrow_books VALUES (@student_no, @firstname, @lastname, @middlename, @patron_type, @department, @book_no, @title_of_book, @author, @borrowed_date, @borrow_returned)", con);
            //        command.CommandType = CommandType.Text;
            //        command.Parameters.AddWithValue("@student_no", txtStudentNo.Text);
            //        command.Parameters.AddWithValue("@firstname", txtFirstName.Text);
            //        command.Parameters.AddWithValue("@lastname", txtLastName.Text);
            //        command.Parameters.AddWithValue("@middlename", txtMiddleName.Text);
            //        command.Parameters.AddWithValue("@patron_type", txtPatronType.Text);
            //        command.Parameters.AddWithValue("@department", txtDepartment.Text);
            //        command.Parameters.AddWithValue("@book_no", txtBookNumber.Text);
            //        command.Parameters.AddWithValue("@title_of_book", txtTitleofBook.Text);
            //        command.Parameters.AddWithValue("@author", txtAuthor.Text);
            //        command.Parameters.AddWithValue("@borrowed_date", datetoday.ToString("yyyy-MM-dd"));
            //        command.Parameters.AddWithValue("@borrow_returned", datelist.Last());
            //        con.Open();
            //        command.ExecuteNonQuery();
            //        con.Close();
                    
            //        MessageBox.Show("Borrowed Book Successfully \nBook Title: " + txtTitleofBook.Text + "\nBook Borrowed: " + datetoday.ToString("yyyy-MM-dd") + "\nBook Returned: " + datelist.Last(), "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        bookdetailsdisabled();
            //        studentbookInfoCleared();
            //    }

            //    catch (Exception e1)
            //    {
            //        MessageBox.Show(e1.Message);
            //    }


            //}

            //else
            //{
            //    //Do Something  
            //}

            bookBorrow BookBorrow = new bookBorrow();
            BookBorrow.book_Borrow(txtStudentNo.Text, txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, txtPatronType.Text, txtDepartment.Text, txtBookNumber.Text,  txtTitleofBook.Text, txtAuthor.Text);
            bookdetailsdisabled();
            studentbookInfoCleared();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
            this.Hide();
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {

        }

        private void txtStudentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBookNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
