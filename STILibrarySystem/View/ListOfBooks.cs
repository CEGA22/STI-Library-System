using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace STILibrarySystem
{
    public partial class ListOfBooks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");
        public int booknumber;
        HomePage HP;
       
        
        public ListOfBooks()
        {
            InitializeComponent();
            HP = new HomePage();
            booklist();
            btnDelete.Hide();
            btnSaveUpdate.Hide();
           
        }

        public void TxtboxClear()
        {
            txtBookNumber.Text = "";
            txtTitleofBook.Text = "";
            txtCategoryCode.Text = "";
            txtAuthor.Text = "";
            txtCallNumber.Text = "";
            txtCopyrights.Text = "";
            txtCopies.Text = "";
            txtDaysReturn.Text = "";
            txtbook.Text = "";

            TitleOfBook.Text = "";
            CategoryCode.Text = "";
            Author.Text = "";
            CallNumber.Text = "";
            Copyrights.Text = "";
            Copies.Text = "";
            textBox1.Text = "";
        }

        public void ReadOnlyFalse()
        {
            TitleOfBook.ReadOnly = false;
            CategoryCode.ReadOnly = false;
            Author.ReadOnly = false;
            CallNumber.ReadOnly = false;
            Copyrights.ReadOnly = false;
            Copies.ReadOnly = false;
        }
        

        public void booklist()
        {
            var cmd = new SqlCommand("SELECT book_number as 'Book Number', title_of_book as 'Title of Book', category_code as 'Category Code', author as 'Author', call_number as 'Call Number', copyrights as 'Copyrights', copies as 'Copies', days_of_return as 'Days of Return' FROM List_of_Books", con);
            var dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();
            listofBooksView.DataSource = dt;
        }

       

        private void lbl_exit_Click(object sender, EventArgs e)
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

        private void listofBooksView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.listofBooksView.Rows[e.RowIndex];

                    txtbook.Text =row.Cells["Book Number"].Value.ToString();
                    TitleOfBook.Text = row.Cells["Title of Book"].Value.ToString();
                    CategoryCode.Text = row.Cells["Category Code"].Value.ToString();
                    Author.Text = row.Cells["Author"].Value.ToString();
                    CallNumber.Text = row.Cells["Call Number"].Value.ToString();
                    Copyrights.Text = row.Cells["Copyrights"].Value.ToString();
                    Copies.Text = row.Cells["Copies"].Value.ToString();
                    textBox1.Text = row.Cells["Days of Return"].Value.ToString();
                }
            }

            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
                AddBooks AB = new AddBooks();
                AB.SaveAddBooks(txtBookNumber.Text, txtTitleofBook.Text, txtCategoryCode.Text, txtAuthor.Text, txtCallNumber.Text, txtCopyrights.Text, txtCopies.Text, txtDaysReturn.Text);
                booklist();
                TxtboxClear(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HP.Show();
            this.Hide();
        }

      
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT book_number as 'Book Number', title_of_book as 'Title of Book', category_code as 'Category Code', author as 'Author', call_number as 'Call Number', copyrights as 'Copyrights', copies as 'Copies' FROM List_of_Books WHERE title_of_book LIKE '%" + txtSearch.Text + "%'", con);
            con.Open();
            var dt = new DataTable();
            adapt.Fill(dt);
            listofBooksView.DataSource = dt;
            con.Close();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            HP.Show();
            this.Hide();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            UpdateBooks UB = new UpdateBooks();
            UB.SaveUpdateBooks(TitleOfBook.Text, CategoryCode.Text, Author.Text, CallNumber.Text, Copyrights.Text, Copies.Text, textBox1.Text, txtbook.Text);
            booklist();
            btnSaveUpdate.Hide();
            btnDelete.Hide();
            btnEdit.Show();
            TxtboxClear();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(217, 30, 24);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Transparent;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBook DB = new DeleteBook();
            DB.DeleteBookItem(txtbook.Text);
            booklist();
            btnDelete.Hide();
            btnEdit.Show();
            btnSaveUpdate.Hide();
            TxtboxClear();
        }

        private void ListOfBooks_Load(object sender, EventArgs e)
        {
            string position = login.position;

            if (position.Equals("librarian"))
            {
                tabControl1.TabPages.Remove(tabPage2);
                btnEdit.Hide();
                
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtbook.Text == string.Empty)
            {
                MessageBox.Show("Please select book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnEdit.Hide();
                btnDelete.Show();
                btnSaveUpdate.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimized1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void Copyrights_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Copies_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCopyrights_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDaysReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }  
    }
}
