
namespace LibrarySystem2
{
    partial class StaffPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelM = new System.Windows.Forms.Button();
            this.buttonAddM = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEscrowBook = new System.Windows.Forms.Button();
            this.buttonBorBook = new System.Windows.Forms.Button();
            this.buttonBookBor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDelB = new System.Windows.Forms.Button();
            this.buttonAddB = new System.Windows.Forms.Button();
            this.btnSorting = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDelM);
            this.groupBox1.Controls.Add(this.buttonAddM);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(371, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEMBER TRANSACTIONS";
            // 
            // buttonDelM
            // 
            this.buttonDelM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelM.Location = new System.Drawing.Point(36, 113);
            this.buttonDelM.Name = "buttonDelM";
            this.buttonDelM.Size = new System.Drawing.Size(293, 42);
            this.buttonDelM.TabIndex = 1;
            this.buttonDelM.Text = "Member Deletion";
            this.buttonDelM.UseVisualStyleBackColor = true;
            this.buttonDelM.Click += new System.EventHandler(this.buttonDelM_Click);
            // 
            // buttonAddM
            // 
            this.buttonAddM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonAddM.Location = new System.Drawing.Point(36, 43);
            this.buttonAddM.Name = "buttonAddM";
            this.buttonAddM.Size = new System.Drawing.Size(293, 42);
            this.buttonAddM.TabIndex = 0;
            this.buttonAddM.Text = "Adding Members ";
            this.buttonAddM.UseVisualStyleBackColor = true;
            this.buttonAddM.Click += new System.EventHandler(this.buttonAddM_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEscrowBook);
            this.groupBox2.Controls.Add(this.buttonBorBook);
            this.groupBox2.Controls.Add(this.buttonBookBor);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(738, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BORROWING TRANSACTIONS";
            // 
            // btnEscrowBook
            // 
            this.btnEscrowBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEscrowBook.Location = new System.Drawing.Point(36, 176);
            this.btnEscrowBook.Name = "btnEscrowBook";
            this.btnEscrowBook.Size = new System.Drawing.Size(293, 42);
            this.btnEscrowBook.TabIndex = 2;
            this.btnEscrowBook.Text = "Escrow Books Return";
            this.btnEscrowBook.UseVisualStyleBackColor = true;
            this.btnEscrowBook.Click += new System.EventHandler(this.btnEscrowBook_Click);
            // 
            // buttonBorBook
            // 
            this.buttonBorBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonBorBook.Location = new System.Drawing.Point(36, 111);
            this.buttonBorBook.Name = "buttonBorBook";
            this.buttonBorBook.Size = new System.Drawing.Size(293, 42);
            this.buttonBorBook.TabIndex = 1;
            this.buttonBorBook.Text = "Borrowed Books";
            this.buttonBorBook.UseVisualStyleBackColor = true;
            this.buttonBorBook.Click += new System.EventHandler(this.buttonBorBook_Click);
            // 
            // buttonBookBor
            // 
            this.buttonBookBor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonBookBor.Location = new System.Drawing.Point(36, 46);
            this.buttonBookBor.Name = "buttonBookBor";
            this.buttonBookBor.Size = new System.Drawing.Size(293, 42);
            this.buttonBookBor.TabIndex = 0;
            this.buttonBookBor.Text = "Book Borrowing";
            this.buttonBookBor.UseVisualStyleBackColor = true;
            this.buttonBookBor.Click += new System.EventHandler(this.buttonBookBor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDelB);
            this.groupBox3.Controls.Add(this.buttonAddB);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(105, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 198);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BOOK TRANSACTIONS";
            // 
            // buttonDelB
            // 
            this.buttonDelB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelB.Location = new System.Drawing.Point(36, 113);
            this.buttonDelB.Name = "buttonDelB";
            this.buttonDelB.Size = new System.Drawing.Size(293, 42);
            this.buttonDelB.TabIndex = 1;
            this.buttonDelB.Text = "Deleting A Book";
            this.buttonDelB.UseVisualStyleBackColor = true;
            this.buttonDelB.Click += new System.EventHandler(this.buttonDelB_Click);
            // 
            // buttonAddB
            // 
            this.buttonAddB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonAddB.Location = new System.Drawing.Point(36, 43);
            this.buttonAddB.Name = "buttonAddB";
            this.buttonAddB.Size = new System.Drawing.Size(293, 42);
            this.buttonAddB.TabIndex = 0;
            this.buttonAddB.Text = "Adding Books";
            this.buttonAddB.UseVisualStyleBackColor = true;
            this.buttonAddB.Click += new System.EventHandler(this.buttonAddB_Click);
            // 
            // btnSorting
            // 
            this.btnSorting.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSorting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSorting.Location = new System.Drawing.Point(904, 171);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Size = new System.Drawing.Size(202, 42);
            this.btnSorting.TabIndex = 3;
            this.btnSorting.Text = "SORTING";
            this.btnSorting.UseVisualStyleBackColor = true;
            this.btnSorting.Click += new System.EventHandler(this.btnSorting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibrarySystem2.Properties.Resources.grafik1;
            this.pictureBox1.Location = new System.Drawing.Point(904, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibrarySystem2.Properties.Resources.book;
            this.pictureBox2.Location = new System.Drawing.Point(479, 340);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 195);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibrarySystem2.Properties.Resources.admin;
            this.pictureBox3.Location = new System.Drawing.Point(141, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // StaffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1166, 673);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSorting);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StaffPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StaffPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDelM;
        private System.Windows.Forms.Button buttonAddM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBorBook;
        private System.Windows.Forms.Button buttonBookBor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDelB;
        private System.Windows.Forms.Button buttonAddB;
        private System.Windows.Forms.Button btnEscrowBook;
        private System.Windows.Forms.Button btnSorting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}