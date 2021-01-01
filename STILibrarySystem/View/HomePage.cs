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
            btn_borrowedHistory.ForeColor = Color.FromArgb(250, 216, 89);
        }

        private void btn_borrowedHistory_MouseLeave(object sender, EventArgs e)
        {
            btn_borrowedHistory.ForeColor = Color.White;
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

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(217, 30, 24);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void HomePage_Load(object sender, EventArgs e)
        {
            Books books = new Books();
            books.totalbooks();
            lbltotalBooks.Text = books.TotalBooks.ToString();

            DateTime date = DateTime.Now;
            lbl_date.Text = date.ToString("dddd MMMM dd,yyyy hh:mm tt");
            lblaccount.Text = login.position.ToUpper();

            if(lblaccount.Text.Equals("LIBRARIAN"))
            {
                btn_borrowedHistory.Hide();
                panelBorrowedHistory.Hide();
                lblaccount.Left = 90;

            }

           



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

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
