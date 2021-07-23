
namespace LibrarySystem2
{
    partial class BookBorrowing
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupMember = new System.Windows.Forms.GroupBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBook = new System.Windows.Forms.GroupBox();
            this.lblBookNo = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPageNo = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.txtBookNo = new System.Windows.Forms.TextBox();
            this.txtPageNo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblKayıtlıKitapSayi = new System.Windows.Forms.Label();
            this.lblKitapSayısı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupMember.SuspendLayout();
            this.groupBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(461, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(769, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupMember
            // 
            this.groupMember.Controls.Add(this.lblAge);
            this.groupMember.Controls.Add(this.lblSurname);
            this.groupMember.Controls.Add(this.lblName);
            this.groupMember.Controls.Add(this.lblID);
            this.groupMember.Controls.Add(this.txtAge);
            this.groupMember.Controls.Add(this.txtSurname);
            this.groupMember.Controls.Add(this.txtName);
            this.groupMember.Controls.Add(this.txtID);
            this.groupMember.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupMember.Location = new System.Drawing.Point(36, 12);
            this.groupMember.Name = "groupMember";
            this.groupMember.Size = new System.Drawing.Size(399, 225);
            this.groupMember.TabIndex = 1;
            this.groupMember.TabStop = false;
            this.groupMember.Text = "Member Information";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(100, 172);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 23);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(61, 131);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 23);
            this.lblSurname.TabIndex = 11;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(85, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 23);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(58, 49);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(84, 23);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "Id Search";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(156, 165);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(193, 30);
            this.txtAge.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(156, 124);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(193, 30);
            this.txtSurname.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 30);
            this.txtName.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(156, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 30);
            this.txtID.TabIndex = 3;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // groupBook
            // 
            this.groupBook.Controls.Add(this.lblBookNo);
            this.groupBook.Controls.Add(this.txtPublisher);
            this.groupBook.Controls.Add(this.dateTimePicker2);
            this.groupBook.Controls.Add(this.dateTimePicker1);
            this.groupBook.Controls.Add(this.label1);
            this.groupBook.Controls.Add(this.label2);
            this.groupBook.Controls.Add(this.lblPageNo);
            this.groupBook.Controls.Add(this.lblPublisher);
            this.groupBook.Controls.Add(this.lblWriter);
            this.groupBook.Controls.Add(this.lblBookName);
            this.groupBook.Controls.Add(this.lblBarcode);
            this.groupBook.Controls.Add(this.txtBarcode);
            this.groupBook.Controls.Add(this.txtBookName);
            this.groupBook.Controls.Add(this.txtWriter);
            this.groupBook.Controls.Add(this.txtBookNo);
            this.groupBook.Controls.Add(this.txtPageNo);
            this.groupBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBook.Location = new System.Drawing.Point(36, 243);
            this.groupBook.Name = "groupBook";
            this.groupBook.Size = new System.Drawing.Size(399, 363);
            this.groupBook.TabIndex = 2;
            this.groupBook.TabStop = false;
            this.groupBook.Text = "Book Information";
            // 
            // lblBookNo
            // 
            this.lblBookNo.AutoSize = true;
            this.lblBookNo.Location = new System.Drawing.Point(64, 226);
            this.lblBookNo.Name = "lblBookNo";
            this.lblBookNo.Size = new System.Drawing.Size(79, 23);
            this.lblBookNo.TabIndex = 15;
            this.lblBookNo.Text = "Book No";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(156, 146);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(193, 30);
            this.txtPublisher.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(159, 302);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(193, 30);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 30);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Return Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Delivery Date";
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.Location = new System.Drawing.Point(66, 188);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(77, 23);
            this.lblPageNo.TabIndex = 14;
            this.lblPageNo.Text = "Page No";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(59, 150);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(84, 23);
            this.lblPublisher.TabIndex = 13;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(81, 112);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(62, 23);
            this.lblWriter.TabIndex = 12;
            this.lblWriter.Text = "Writer";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(40, 74);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(103, 23);
            this.lblBookName.TabIndex = 11;
            this.lblBookName.Text = "Book Name";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(40, 36);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(103, 23);
            this.lblBarcode.TabIndex = 10;
            this.lblBarcode.Text = "Barcode No";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(156, 29);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(193, 30);
            this.txtBarcode.TabIndex = 8;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(156, 68);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(193, 30);
            this.txtBookName.TabIndex = 7;
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(156, 107);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(193, 30);
            this.txtWriter.TabIndex = 6;
            // 
            // txtBookNo
            // 
            this.txtBookNo.Location = new System.Drawing.Point(159, 224);
            this.txtBookNo.Name = "txtBookNo";
            this.txtBookNo.Size = new System.Drawing.Size(193, 30);
            this.txtBookNo.TabIndex = 5;
            this.txtBookNo.Text = "1";
            this.txtBookNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPageNo
            // 
            this.txtPageNo.Location = new System.Drawing.Point(156, 185);
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.Size = new System.Drawing.Size(193, 30);
            this.txtPageNo.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(441, 577);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(1246, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTeslimEt.Location = new System.Drawing.Point(1108, 456);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(122, 29);
            this.btnTeslimEt.TabIndex = 5;
            this.btnTeslimEt.Text = "DELIVER";
            this.btnTeslimEt.UseVisualStyleBackColor = true;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(1108, 505);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(531, 472);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(242, 23);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Number of Registered Books";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(835, 472);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(79, 23);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Book No";
            // 
            // lblKayıtlıKitapSayi
            // 
            this.lblKayıtlıKitapSayi.AutoSize = true;
            this.lblKayıtlıKitapSayi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKayıtlıKitapSayi.Location = new System.Drawing.Point(790, 472);
            this.lblKayıtlıKitapSayi.Name = "lblKayıtlıKitapSayi";
            this.lblKayıtlıKitapSayi.Size = new System.Drawing.Size(0, 23);
            this.lblKayıtlıKitapSayi.TabIndex = 9;
            // 
            // lblKitapSayısı
            // 
            this.lblKitapSayısı.AutoSize = true;
            this.lblKitapSayısı.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKitapSayısı.Location = new System.Drawing.Point(933, 472);
            this.lblKitapSayısı.Name = "lblKitapSayısı";
            this.lblKitapSayısı.Size = new System.Drawing.Size(0, 23);
            this.lblKitapSayısı.TabIndex = 10;
            // 
            // BookBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1362, 618);
            this.Controls.Add(this.lblKitapSayısı);
            this.Controls.Add(this.lblKayıtlıKitapSayi);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTeslimEt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBook);
            this.Controls.Add(this.groupMember);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookBorrowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookBorrowing";
            this.Load += new System.EventHandler(this.BookBorrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupMember.ResumeLayout(false);
            this.groupMember.PerformLayout();
            this.groupBook.ResumeLayout(false);
            this.groupBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupMember;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBook;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.TextBox txtBookNo;
        private System.Windows.Forms.TextBox txtPageNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTeslimEt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblBookNo;
        private System.Windows.Forms.Label lblKayıtlıKitapSayi;
        private System.Windows.Forms.Label lblKitapSayısı;
    }
}