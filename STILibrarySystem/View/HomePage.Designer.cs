namespace STILibrarySystem
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblaccount = new System.Windows.Forms.Label();
            this.panelBorrowedHistory = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panelAddBook = new System.Windows.Forms.Panel();
            this.panelListOfBooks = new System.Windows.Forms.Panel();
            this.btn_ListofBooks = new System.Windows.Forms.Button();
            this.panelReturnBook = new System.Windows.Forms.Panel();
            this.btn_ReturnBook = new System.Windows.Forms.Button();
            this.panelBorrowBook = new System.Windows.Forms.Panel();
            this.btn_BorrowBook = new System.Windows.Forms.Button();
            this.btn_Student = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPendingBooks = new System.Windows.Forms.Button();
            this.btnTotalStudents = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnTotalBooks = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnMinimized);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 85);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1002, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 38);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Image = global::STILibrarySystem.Properties.Resources.Minimized_Icon_16px;
            this.btnMinimized.Location = new System.Drawing.Point(971, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(36, 28);
            this.btnMinimized.TabIndex = 15;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(398, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "LIBRARY MANAGEMENT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::STILibrarySystem.Properties.Resources.sti_logo2;
            this.pictureBox1.Location = new System.Drawing.Point(8, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblaccount
            // 
            this.lblaccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblaccount.AutoSize = true;
            this.lblaccount.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccount.ForeColor = System.Drawing.Color.White;
            this.lblaccount.Location = new System.Drawing.Point(63, 135);
            this.lblaccount.Name = "lblaccount";
            this.lblaccount.Size = new System.Drawing.Size(0, 28);
            this.lblaccount.TabIndex = 2;
            this.lblaccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelBorrowedHistory
            // 
            this.panelBorrowedHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBorrowedHistory.BackColor = System.Drawing.Color.White;
            this.panelBorrowedHistory.Location = new System.Drawing.Point(0, 261);
            this.panelBorrowedHistory.Name = "panelBorrowedHistory";
            this.panelBorrowedHistory.Size = new System.Drawing.Size(270, 1);
            this.panelBorrowedHistory.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.panelAddBook);
            this.panel1.Controls.Add(this.panelListOfBooks);
            this.panel1.Controls.Add(this.btn_ListofBooks);
            this.panel1.Controls.Add(this.panelReturnBook);
            this.panel1.Controls.Add(this.btn_ReturnBook);
            this.panel1.Controls.Add(this.panelBorrowBook);
            this.panel1.Controls.Add(this.btn_BorrowBook);
            this.panel1.Controls.Add(this.panelBorrowedHistory);
            this.panel1.Controls.Add(this.btn_Student);
            this.panel1.Controls.Add(this.lblaccount);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 668);
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_logout.AutoSize = true;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::STILibrarySystem.Properties.Resources.exit;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(15, 497);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(223, 46);
            this.btn_logout.TabIndex = 18;
            this.btn_logout.Text = "LOG OUT";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            this.btn_logout.MouseEnter += new System.EventHandler(this.button6_MouseEnter);
            this.btn_logout.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            // 
            // panelAddBook
            // 
            this.panelAddBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAddBook.AutoSize = true;
            this.panelAddBook.BackColor = System.Drawing.Color.White;
            this.panelAddBook.Location = new System.Drawing.Point(3, 553);
            this.panelAddBook.Name = "panelAddBook";
            this.panelAddBook.Size = new System.Drawing.Size(270, 1);
            this.panelAddBook.TabIndex = 17;
            // 
            // panelListOfBooks
            // 
            this.panelListOfBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelListOfBooks.BackColor = System.Drawing.Color.White;
            this.panelListOfBooks.Location = new System.Drawing.Point(3, 480);
            this.panelListOfBooks.Name = "panelListOfBooks";
            this.panelListOfBooks.Size = new System.Drawing.Size(270, 1);
            this.panelListOfBooks.TabIndex = 15;
            // 
            // btn_ListofBooks
            // 
            this.btn_ListofBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ListofBooks.AutoSize = true;
            this.btn_ListofBooks.FlatAppearance.BorderSize = 0;
            this.btn_ListofBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_ListofBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_ListofBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListofBooks.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListofBooks.ForeColor = System.Drawing.Color.White;
            this.btn_ListofBooks.Image = global::STILibrarySystem.Properties.Resources.check_mark;
            this.btn_ListofBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListofBooks.Location = new System.Drawing.Point(10, 345);
            this.btn_ListofBooks.Name = "btn_ListofBooks";
            this.btn_ListofBooks.Size = new System.Drawing.Size(223, 46);
            this.btn_ListofBooks.TabIndex = 14;
            this.btn_ListofBooks.Text = "LIST OF BOOKS";
            this.btn_ListofBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListofBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ListofBooks.UseVisualStyleBackColor = true;
            this.btn_ListofBooks.Click += new System.EventHandler(this.button4_Click);
            this.btn_ListofBooks.MouseEnter += new System.EventHandler(this.btn_ListofBooks_MouseEnter);
            this.btn_ListofBooks.MouseLeave += new System.EventHandler(this.btn_ListofBooks_MouseLeave);
            // 
            // panelReturnBook
            // 
            this.panelReturnBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelReturnBook.BackColor = System.Drawing.Color.White;
            this.panelReturnBook.Location = new System.Drawing.Point(0, 406);
            this.panelReturnBook.Name = "panelReturnBook";
            this.panelReturnBook.Size = new System.Drawing.Size(270, 1);
            this.panelReturnBook.TabIndex = 13;
            // 
            // btn_ReturnBook
            // 
            this.btn_ReturnBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ReturnBook.AutoSize = true;
            this.btn_ReturnBook.FlatAppearance.BorderSize = 0;
            this.btn_ReturnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_ReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_ReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReturnBook.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReturnBook.ForeColor = System.Drawing.Color.White;
            this.btn_ReturnBook.Image = global::STILibrarySystem.Properties.Resources.left_arrow;
            this.btn_ReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ReturnBook.Location = new System.Drawing.Point(13, 273);
            this.btn_ReturnBook.Name = "btn_ReturnBook";
            this.btn_ReturnBook.Size = new System.Drawing.Size(267, 46);
            this.btn_ReturnBook.TabIndex = 12;
            this.btn_ReturnBook.Text = "RETURN BOOK";
            this.btn_ReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ReturnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ReturnBook.UseVisualStyleBackColor = true;
            this.btn_ReturnBook.Click += new System.EventHandler(this.btn_ReturnBook_Click);
            this.btn_ReturnBook.MouseEnter += new System.EventHandler(this.btn_ReturnBook_MouseEnter);
            this.btn_ReturnBook.MouseLeave += new System.EventHandler(this.btn_ReturnBook_MouseLeave);
            // 
            // panelBorrowBook
            // 
            this.panelBorrowBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBorrowBook.BackColor = System.Drawing.Color.White;
            this.panelBorrowBook.Location = new System.Drawing.Point(0, 333);
            this.panelBorrowBook.Name = "panelBorrowBook";
            this.panelBorrowBook.Size = new System.Drawing.Size(270, 1);
            this.panelBorrowBook.TabIndex = 11;
            // 
            // btn_BorrowBook
            // 
            this.btn_BorrowBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BorrowBook.AutoSize = true;
            this.btn_BorrowBook.FlatAppearance.BorderSize = 0;
            this.btn_BorrowBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_BorrowBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_BorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorrowBook.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BorrowBook.ForeColor = System.Drawing.Color.White;
            this.btn_BorrowBook.Image = global::STILibrarySystem.Properties.Resources.open_book;
            this.btn_BorrowBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BorrowBook.Location = new System.Drawing.Point(15, 204);
            this.btn_BorrowBook.Name = "btn_BorrowBook";
            this.btn_BorrowBook.Size = new System.Drawing.Size(267, 46);
            this.btn_BorrowBook.TabIndex = 10;
            this.btn_BorrowBook.Text = "BORROW BOOK";
            this.btn_BorrowBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BorrowBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_BorrowBook.UseVisualStyleBackColor = true;
            this.btn_BorrowBook.Click += new System.EventHandler(this.btn_BorrowBook_Click);
            this.btn_BorrowBook.MouseEnter += new System.EventHandler(this.btn_BorrowBook_MouseEnter);
            this.btn_BorrowBook.MouseLeave += new System.EventHandler(this.btn_BorrowBook_MouseLeave);
            // 
            // btn_Student
            // 
            this.btn_Student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Student.AutoSize = true;
            this.btn_Student.FlatAppearance.BorderSize = 0;
            this.btn_Student.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_Student.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Student.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.ForeColor = System.Drawing.Color.White;
            this.btn_Student.Image = global::STILibrarySystem.Properties.Resources._class;
            this.btn_Student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Student.Location = new System.Drawing.Point(14, 419);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(267, 46);
            this.btn_Student.TabIndex = 8;
            this.btn_Student.Text = "STUDENTS";
            this.btn_Student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Student.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Student.UseVisualStyleBackColor = true;
            this.btn_Student.Click += new System.EventHandler(this.btn_borrowedHistory_Click);
            this.btn_Student.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btn_Student.MouseLeave += new System.EventHandler(this.btn_borrowedHistory_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::STILibrarySystem.Properties.Resources.man;
            this.pictureBox2.Location = new System.Drawing.Point(111, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.label4.Location = new System.Drawing.Point(293, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 43);
            this.label4.TabIndex = 2;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lbl_date.Location = new System.Drawing.Point(293, 88);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(84, 40);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Date";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(305, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(659, 93);
            this.label5.TabIndex = 4;
            this.label5.Text = "STI Library management system (SLMS) is a software that is \r\ndeveloped to handle " +
    "at least the most basic housekeeping\r\nfunctions of a library. ";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel3.Location = new System.Drawing.Point(305, 526);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 5);
            this.panel3.TabIndex = 12;
            // 
            // btnPendingBooks
            // 
            this.btnPendingBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(88)))));
            this.btnPendingBooks.FlatAppearance.BorderSize = 0;
            this.btnPendingBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingBooks.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingBooks.ForeColor = System.Drawing.Color.White;
            this.btnPendingBooks.Location = new System.Drawing.Point(301, 320);
            this.btnPendingBooks.Name = "btnPendingBooks";
            this.btnPendingBooks.Size = new System.Drawing.Size(495, 186);
            this.btnPendingBooks.TabIndex = 24;
            this.btnPendingBooks.Text = "Pending Books\r\n10";
            this.btnPendingBooks.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPendingBooks.UseVisualStyleBackColor = false;
            this.btnPendingBooks.Click += new System.EventHandler(this.btnPendingBooks_Click);
            // 
            // btnTotalStudents
            // 
            this.btnTotalStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(198)))), ((int)(((byte)(149)))));
            this.btnTotalStudents.FlatAppearance.BorderSize = 0;
            this.btnTotalStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalStudents.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalStudents.ForeColor = System.Drawing.Color.White;
            this.btnTotalStudents.Location = new System.Drawing.Point(812, 320);
            this.btnTotalStudents.Name = "btnTotalStudents";
            this.btnTotalStudents.Size = new System.Drawing.Size(501, 186);
            this.btnTotalStudents.TabIndex = 25;
            this.btnTotalStudents.Text = "Total Students";
            this.btnTotalStudents.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTotalStudents.UseVisualStyleBackColor = false;
            this.btnTotalStudents.Click += new System.EventHandler(this.btnTotalStudents_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(53)))));
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pictureBox7);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(301, 485);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(495, 21);
            this.panel5.TabIndex = 26;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = global::STILibrarySystem.Properties.Resources.open_book1;
            this.pictureBox6.Location = new System.Drawing.Point(-72, -243);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(632, 112);
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-14, -96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 43);
            this.label2.TabIndex = 19;
            this.label2.Text = "lbltotalBooks";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = global::STILibrarySystem.Properties.Resources.open_book1;
            this.pictureBox7.Location = new System.Drawing.Point(-75, -243);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(632, 112);
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-17, -96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 43);
            this.label7.TabIndex = 19;
            this.label7.Text = "lbltotalBooks";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.label12.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-13, -53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 40);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total books";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(215, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "More info";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            this.label13.MouseEnter += new System.EventHandler(this.label13_MouseEnter);
            this.label13.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.label14.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(-16, -53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 40);
            this.label14.TabIndex = 18;
            this.label14.Text = "Total books";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.panel7.Controls.Add(this.pictureBox8);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.pictureBox9);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Location = new System.Drawing.Point(812, 485);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(501, 21);
            this.panel7.TabIndex = 27;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.Image = global::STILibrarySystem.Properties.Resources.open_book1;
            this.pictureBox8.Location = new System.Drawing.Point(-72, -243);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(638, 112);
            this.pictureBox8.TabIndex = 20;
            this.pictureBox8.TabStop = false;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.label15.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-11, -96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(207, 43);
            this.label15.TabIndex = 19;
            this.label15.Text = "lbltotalBooks";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.Image = global::STILibrarySystem.Properties.Resources.open_book1;
            this.pictureBox9.Location = new System.Drawing.Point(-75, -243);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(638, 112);
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.label16.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(-14, -96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(207, 43);
            this.label16.TabIndex = 19;
            this.label16.Text = "lbltotalBooks";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.label17.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(-10, -53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(187, 40);
            this.label17.TabIndex = 18;
            this.label17.Text = "Total books";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(218, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "More info";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            this.label18.MouseEnter += new System.EventHandler(this.label18_MouseEnter);
            this.label18.MouseLeave += new System.EventHandler(this.label18_MouseLeave);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.label19.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(-13, -53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(187, 40);
            this.label19.TabIndex = 18;
            this.label19.Text = "Total books";
            // 
            // btnTotalBooks
            // 
            this.btnTotalBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnTotalBooks.FlatAppearance.BorderSize = 0;
            this.btnTotalBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalBooks.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalBooks.ForeColor = System.Drawing.Color.White;
            this.btnTotalBooks.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTotalBooks.Location = new System.Drawing.Point(301, 135);
            this.btnTotalBooks.Name = "btnTotalBooks";
            this.btnTotalBooks.Size = new System.Drawing.Size(1012, 167);
            this.btnTotalBooks.TabIndex = 21;
            this.btnTotalBooks.Text = "Total Books";
            this.btnTotalBooks.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTotalBooks.UseVisualStyleBackColor = false;
            this.btnTotalBooks.Click += new System.EventHandler(this.btnTotalBooks_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(217)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(301, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1012, 21);
            this.panel4.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(460, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "More info";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter_1);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave_1);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1325, 666);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnTotalBooks);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnTotalStudents);
            this.Controls.Add(this.btnPendingBooks);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblaccount;
        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Panel panelBorrowedHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panelAddBook;
        private System.Windows.Forms.Panel panelListOfBooks;
        private System.Windows.Forms.Button btn_ListofBooks;
        private System.Windows.Forms.Panel panelReturnBook;
        private System.Windows.Forms.Button btn_ReturnBook;
        private System.Windows.Forms.Panel panelBorrowBook;
        private System.Windows.Forms.Button btn_BorrowBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPendingBooks;
        private System.Windows.Forms.Button btnTotalStudents;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnTotalBooks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
    }
}