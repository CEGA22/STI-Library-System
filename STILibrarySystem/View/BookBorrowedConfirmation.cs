using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STILibrarySystem
{
    public partial class BookBorrowedConfirmation : Form
    {
        public BookBorrowedConfirmation()
        {
            InitializeComponent();
        }

        private void BookBorrowedConfirmation_Load(object sender, EventArgs e)
        {

           
            txtbooktitle.Text = bookBorrow.booktitle;
            lblborrowedDate.Text = bookBorrow.borrowedDate;
            lblDateReturned.Text = bookBorrow.datereturned;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
