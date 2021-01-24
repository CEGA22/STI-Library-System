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
    public partial class Students : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1C2I03;Initial Catalog=STILibrarySystem;Integrated Security=True");
        HomePage HP;

        public Students()
        {
            InitializeComponent();
            Studentlist();
            btnDelete.Hide();
            btnSaveUpdate.Hide();
            HP = new HomePage();
        }

        public void ClearListStudentInfo()
        {
            StudentID.Text = "";
            Firstname.Text = "";
            Lastname.Text = "";
            Middlename.Text = "";
            cbGender.Text = "";
            PatronType.Text = "";
            Program.Text = "";
            Programshort.Text = "";
        }
        public void ClearAddStudentInfo()
        {
            txtStudentID.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtMiddlename.Text = "";
            Gender.Text = "";
            txtPatronType.Text = "";
            cbProgram.Text = "";
            txtProgram.Text = "";
        }

        public void Studentlist()
        {


            var cmd = new SqlCommand("SELECT student_id as 'Student ID', firstname as 'Firstname', lastname as 'Lastname', middlename as 'Middlename', program as 'Program', program_short as 'Program short', sex as 'Gender', patron_type as 'Patron type' FROM student_information", con);
            var dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();
            listofStudentsView.DataSource = dt;

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

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudent US = new UpdateStudent();
            US.SaveUpdateStudent(StudentID.Text, Firstname.Text, Lastname.Text, Middlename.Text, cbGender.Text, PatronType.Text, Program.Text, Programshort.Text);
            Studentlist();
            btnSaveUpdate.Hide();
            btnDelete.Hide();
            btnEdit.Show();
            ClearListStudentInfo();    
        }

        private void listofStudentsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.listofStudentsView.Rows[e.RowIndex];

                    StudentID.Text = row.Cells["Student ID"].Value.ToString();
                    Firstname.Text = row.Cells["Firstname"].Value.ToString();
                    Lastname.Text = row.Cells["Lastname"].Value.ToString();
                    Middlename.Text = row.Cells["Middlename"].Value.ToString();
                    cbGender.Text = row.Cells["Gender"].Value.ToString();
                    Program.Text = row.Cells["Program"].Value.ToString();
                    Programshort.Text = row.Cells["Program Short"].Value.ToString();
                    PatronType.Text = row.Cells["Patron type"].Value.ToString();
                }
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT student_id as 'Student ID', firstname as 'Firstname', lastname as 'Lastname', middlename as 'Middlename', program as 'Program', program_short as 'Program Short', sex as 'Gender', patron_type as 'Patron type' FROM student_information WHERE student_id LIKE '%" + txtSearch.Text + "%'", con);
                con.Open();
                var dt = new DataTable();
                adapt.Fill(dt);
                listofStudentsView.DataSource = dt;
                con.Close();
            }

            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(StudentID.Text == string.Empty)
            {
                MessageBox.Show("Please select student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                btnEdit.Hide();
                btnDelete.Show();
                btnSaveUpdate.Show();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HP.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent DS = new DeleteStudent();
            DS.DeleteStudentInfo(StudentID.Text);
            Studentlist();
            btnDelete.Hide();
            btnSaveUpdate.Hide();
            btnEdit.Show();
            ClearListStudentInfo();


        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(txtStudentID.Text == string.Empty)
            {
                MessageBox.Show("Please Fill all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                AddStudent AS = new AddStudent();
                AS.SaveAddStudent(txtStudentID.Text, txtFirstname.Text, txtLastname.Text, txtMiddlename.Text, cbProgram.Text, txtProgram.Text, Gender.Text, txtPatronType.Text);
                Studentlist();
                ClearAddStudentInfo();
            }
              
        }

        private void label21_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
            this.Hide();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            string position = login.position;

            if (position.Equals("librarian"))
            {
                tabControl1.TabPages.Remove(tabPage2);
                btnEdit.Hide();
            }
        }

        private void cbProgram_TextChanged(object sender, EventArgs e)
        {
            if (cbProgram.Text.Equals("BS Information Technology"))
            {
                txtProgram.Text = "BSIT";
            }

            else if (cbProgram.Text.Equals("BS Computer Science"))
            {
                txtProgram.Text = "BSCS";
            }

            else if (cbProgram.Text.Equals("BS Information Systems"))
            {
                txtProgram.Text = "BSIS";
            }

            else if (cbProgram.Text.Equals("BS in Accountancy"))
            {
                txtProgram.Text = "BSA";
            }

            else if (cbProgram.Text.Equals("BS in Hospitality Management"))
            {
                txtProgram.Text = "BSHM";
            }

            else if (cbProgram.Text.Equals("BS in Tourism Management"))
            {
                txtProgram.Text = "BSTM";
            }
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void StudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Program_TextChanged(object sender, EventArgs e)
        {
            if (Program.Text.Equals("BS Information Technology"))
            {
                Programshort.Text = "BSIT";
            }

            else if (Program.Text.Equals("BS Computer Science"))
            {
                Programshort.Text = "BSCS";
            }

            else if (Program.Text.Equals("BS Information Systems"))
            {
                Programshort.Text = "BSIS";
            }

            else if (Program.Text.Equals("BS in Accountancy"))
            {
                Programshort.Text = "BSA";
            }

            else if (Program.Text.Equals("BS in Hospitality Management"))
            {
                Programshort.Text = "BSHM";
            }

            else if (Program.Text.Equals("BS in Tourism Management"))
            {
                Programshort.Text = "BSTM";
            }
        }
    }
}
