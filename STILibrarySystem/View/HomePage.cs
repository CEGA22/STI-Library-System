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
    public partial class HomePage : Form
    {
        public static string account;
        public HomePage()
        {
            InitializeComponent(); 
        }


        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6OVOGVC4\SQLEXPRESS;Initial Catalog=STILibrarySystem;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            ListOfBooks lb = new ListOfBooks();
            lb.Show();
            this.Hide();
        }
 
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btn_Student.ForeColor = Color.FromArgb(250, 216, 89);
        }

        private void btn_borrowedHistory_MouseLeave(object sender, EventArgs e)
        {
            btn_Student.ForeColor = Color.White;
        }

        private void btn_BorrowBook_MouseEnter(object sender, EventArgs e)
        {
            btn_BorrowBook.ForeColor = Color.FromArgb(250, 216, 89);
        }

        private void btn_BorrowBook_MouseLeave(object sender, EventArgs e)
        {
            btn_BorrowBook.ForeColor = Color.White;
        }

        private void btn_ReturnBook_MouseEnter(object sender, EventArgs e)
        {
            btn_ReturnBook.ForeColor = Color.FromArgb(250, 216, 89);
        }

        private void btn_ReturnBook_MouseLeave(object sender, EventArgs e)
        {
            btn_ReturnBook.ForeColor = Color.White;
        }

        private void btn_ListofBooks_MouseEnter(object sender, EventArgs e)
        {
           btn_ListofBooks.ForeColor = Color.FromArgb(250, 216, 89);
        }

        private void btn_ListofBooks_MouseLeave(object sender, EventArgs e)
        {
            btn_ListofBooks.ForeColor = Color.White;
        }

       

        private void button6_MouseEnter(object sender, EventArgs e)
        {
           btn_logout.ForeColor = Color.FromArgb(250, 216, 89);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.ForeColor = Color.White;
        }

       

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Books books = new Books();
            books.totalbooks();
            btnTotalBooks.Text = "Total Books\n" + books.TotalBooks.ToString();
            PendingBooks pendingbooks = new PendingBooks();
            pendingbooks.TotalPendingBooks();
            btnPendingBooks.Text = "Pending Books\n" + pendingbooks.totalpending.ToString();
            TotalStudents ts = new TotalStudents();
            ts.students();
            btnTotalStudents.Text = "Total Students\n" + ts.Totalstudents.ToString();
           
            DateTime date = DateTime.Now;
            lbl_date.Text = date.ToString("dddd MMMM dd,yyyy hh:mm tt");
            lblaccount.Text = login.position.ToUpper();
            lblaccount.TextAlign = ContentAlignment.TopCenter;
            lblaccountname.Text = login.firstname.ToUpper() + " " + login.lastname.ToUpper();
            lblaccountname.TextAlign = ContentAlignment.TopCenter;

           
        }

        private void btn_BorrowBook_Click(object sender, EventArgs e)
        {
            BorrowBook br = new BorrowBook();
            br.Show();
            this.Close();
        }

        private void btn_ReturnBook_Click(object sender, EventArgs e)
        {
            Return_Book RB = new Return_Book();
            RB.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Log Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                LoginPage f1 = new LoginPage();
                f1.Show();
                this.Hide();
            }
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

            else
            {
                //Do Something
            }
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(250, 216, 89);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ListOfBooks LOB = new ListOfBooks();
            LOB.Show();
            this.Hide();
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
           label3.ForeColor = Color.White;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            ListOfBooks LOB = new ListOfBooks();
            LOB.Show();
            this.Hide();
        }

        private void btn_borrowedHistory_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ListOfBooks LOB = new ListOfBooks();
            LOB.Show();
            this.Hide();
        }

       

        private void label13_Click(object sender, EventArgs e)
        {
            Return_Book RB = new Return_Book();
            RB.Show();
            this.Hide();
        }

        private void btnPendingBooks_Click(object sender, EventArgs e)
        {
            Return_Book RB = new Return_Book();
            RB.Show();
            this.Hide();
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = Color.FromArgb(250, 216, 89);
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = Color.White;
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label18.ForeColor = Color.FromArgb(250, 216, 89);
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = Color.White;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            BorrowBook BR = new BorrowBook();
            BR.Show();
            this.Hide();
        }

        private void label3_MouseEnter_1(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(250, 216, 89);
        }

        private void label3_MouseLeave_1(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void btnTotalStudents_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Hide();
        }

        private void btnTotalBooks_Click(object sender, EventArgs e)
        {
            ListOfBooks LB = new ListOfBooks();
            LB.Show();
            this.Hide();
        }
    }
}
