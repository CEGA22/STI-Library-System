
namespace STILibrarySystem
{
    partial class BookBorrowedConfirmation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblborrowedDate = new System.Windows.Forms.Label();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.txtbooktitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(53)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(770, 383);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(138, 55);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::STILibrarySystem.Properties.Resources.open_book__1_;
            this.pictureBox1.Location = new System.Drawing.Point(76, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrowed Book\r\n Successfully";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(415, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Title: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(416, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Borrowed Date: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(415, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date Returned: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblborrowedDate
            // 
            this.lblborrowedDate.AutoSize = true;
            this.lblborrowedDate.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblborrowedDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblborrowedDate.Location = new System.Drawing.Point(593, 196);
            this.lblborrowedDate.Name = "lblborrowedDate";
            this.lblborrowedDate.Size = new System.Drawing.Size(118, 28);
            this.lblborrowedDate.TabIndex = 6;
            this.lblborrowedDate.Text = "Book Title: ";
            this.lblborrowedDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturned.ForeColor = System.Drawing.Color.DimGray;
            this.lblDateReturned.Location = new System.Drawing.Point(592, 293);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(118, 28);
            this.lblDateReturned.TabIndex = 7;
            this.lblDateReturned.Text = "Book Title: ";
            this.lblDateReturned.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbooktitle
            // 
            this.txtbooktitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.txtbooktitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbooktitle.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbooktitle.ForeColor = System.Drawing.Color.DimGray;
            this.txtbooktitle.Location = new System.Drawing.Point(539, 81);
            this.txtbooktitle.Multiline = true;
            this.txtbooktitle.Name = "txtbooktitle";
            this.txtbooktitle.Size = new System.Drawing.Size(353, 56);
            this.txtbooktitle.TabIndex = 8;
            // 
            // BookBorrowedConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.txtbooktitle);
            this.Controls.Add(this.lblDateReturned);
            this.Controls.Add(this.lblborrowedDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookBorrowedConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookBorrowedConfirmation";
            this.Load += new System.EventHandler(this.BookBorrowedConfirmation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblborrowedDate;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.TextBox txtbooktitle;
    }
}