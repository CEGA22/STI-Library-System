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
using Tulpep.NotificationWindow;

namespace STILibrarySystem
{
    public partial class LoginPage : Form
    {
        public  string username, password;
      
        public LoginPage()
        {
            InitializeComponent();
            lbl_Hide.Hide();
            btnRestore.Hide();
        }
     
        private void txt_username_MouseClick(object sender, MouseEventArgs e)
        {
            txt_username.Clear();
        }

        private void txt_password_MouseClick(object sender, MouseEventArgs e)
        {
            txt_password.Clear();
        }

       

        private void label3_Click(object sender, EventArgs e)
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txt_username.Text;
            password = txt_password.Text;
           
            if(txt_username.Text == string.Empty || txt_username.Text.Equals("Enter Username"))
            { 
                MessageBox.Show("Enter Username", "" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                PanelUsername.BackColor = Color.Red;
            }

            else if (txt_password.Text == string.Empty || txt_password.Text.Equals("********"))
            {
                MessageBox.Show("Enter Password", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PanelPassword.BackColor = Color.Red;
            }

            else if(txt_username.Text == string.Empty && txt_password.Text == string.Empty)
            {
                PanelUsername.BackColor = Color.Red;
                PanelPassword.BackColor = Color.Red;
                MessageBox.Show("Enter Username and Password", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PanelUsername.BackColor = Color.FromArgb(25, 181, 254);
                PanelPassword.BackColor = Color.FromArgb(25, 181, 254);
            }

            else
            {
                login lg = new login();
                lg.UserCredentials(txt_username.Text, txt_password.Text);
                this.Hide();
            }
        }

        private void lbl_Show_Click(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '\0';
            lbl_Hide.Show();
            lbl_Show.Hide();
        }

        private void lbl_Hide_Click(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
            lbl_Show.Show();
            lbl_Hide.Hide();
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if(txt_username.Text == "Enter Username")
            {
                txt_username.Text = "";
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "********")
            {
                txt_password.Text = "";

            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "********";
            }
        }

        private void btn_Maximized(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestore.Show();
            button1.Hide();
           
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            button1.Show();
            btnRestore.Hide();
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

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if(txt_username.Text == "")
            {
                txt_username.Text = "Enter Username";
            }
        }

        
    }
}
