using System;
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
    public partial class Return_Book : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");
        public Return_Book()
        {
            InitializeComponent();
            btnProceed.Enabled = false;
            ReturnedBookList.Hide();


        }


       
        public void clear()
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

        



        public void booklist()
        {
            try
            {
                var cmd = new SqlCommand("SELECT student_no as 'Student No.', firstname as 'Firstname', lastname as 'Lastname', middlename as 'Middlename', patron_type as 'Patron Type', department as 'Department', book_no as 'Book No', title_of_book as 'Title of Book', author as 'Author', borrowed_date as 'Borrowed Date', borrow_returned as 'Borrowed Return'  FROM borrow_books WHERE student_no = " + int.Parse(txtStudentNo.Text), con);
                var dt = new DataTable();
                con.Open();
                SqlDataReader sdr1 = cmd.ExecuteReader();
                dt.Load(sdr1);

                con.Close();
                ReturnedBookList.DataSource = dt;

            }

            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
        }
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentNo.Text == String.Empty)
            {
                MessageBox.Show("Enter Your Student No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                booklist();
                ReturnedBookList.Show();
                try
                {


                    SqlCommand command = new SqlCommand("SELECT * FROM borrow_books WHERE student_no = " + int.Parse(txtStudentNo.Text), con);
                    con.Open();
                    SqlDataReader sdr = command.ExecuteReader();

                    if (sdr.Read())
                    {
                        txtFirstName.Text = (sdr["firstname"].ToString());
                        txtLastName.Text = (sdr["lastname"].ToString());
                        txtMiddleName.Text = (sdr["middlename"].ToString());
                        txtPatronType.Text = (sdr["patron_type"].ToString());
                        txtDepartment.Text = (sdr["department"].ToString());
                        btnProceed.Enabled = true;
                        txtStudentNo.ReadOnly = true;

                    }



                    else
                    {
                        ReturnedBookList.Hide();
                        MessageBox.Show("Book is not borrowed with this student no. or Invalid Student No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStudentNo.Text = "";

                    }



                    con.Close();

                }


                catch (Exception e1)
                {
                    MessageBox.Show("Invalid Student No.");
                }
            }

           
        }

      


        private void ReturnedBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ReturnedBookList.Rows[e.RowIndex];

                txtBookNumber.Text = row.Cells["Book No"].Value.ToString();
                txtTitleofBook.Text = row.Cells["Title of Book"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
            this.Hide();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Returned this Book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {

                    var command1 = new SqlCommand("UPDATE List_of_books SET copies = copies + 1 WHERE book_number = " + int.Parse(txtBookNumber.Text), con);


                    con.Open();
                    command1.ExecuteNonQuery();
                    con.Close();


                    SqlCommand command = new SqlCommand("DELETE FROM borrow_books WHERE book_no = " + int.Parse(txtBookNumber.Text), con);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Returned Book Successfully", "Successfully Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnedBookList.Hide();
                    clear();
                    txtStudentNo.ReadOnly = false;



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

        private void lbl_exit_MouseEnter(object sender, EventArgs e)
        {
            lbl_exit.BackColor = Color.FromArgb(217, 30, 24);
        }

        private void lbl_exit_MouseLeave(object sender, EventArgs e)
        {
            lbl_exit.BackColor = Color.FromArgb(37, 116, 169);
        }

        private void Return_Book_Load(object sender, EventArgs e)
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

        private void btnMinimized1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
