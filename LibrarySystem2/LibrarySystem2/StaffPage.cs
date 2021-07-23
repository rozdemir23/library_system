using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem2
{
    public partial class StaffPage : Form
    {
        public StaffPage()
        {
            InitializeComponent();
        }

        private void buttonAddM_Click(object sender, EventArgs e)
        {
            AddingMembers fr = new AddingMembers();
            fr.Show();

        }

        private void buttonDelM_Click(object sender, EventArgs e)
        {
            MemberDelete fr = new MemberDelete();
            fr.Show();
        }

        private void buttonAddB_Click(object sender, EventArgs e)
        {
            AddingBooks addBook = new AddingBooks();
            addBook.ShowDialog();
        }

        private void buttonDelB_Click(object sender, EventArgs e)
        {
            DeletingBooks delBook = new DeletingBooks();
            delBook.ShowDialog();
        }

        private void buttonBookBor_Click(object sender, EventArgs e)
        {
            BookBorrowing borBook = new BookBorrowing();
            borBook.ShowDialog();
        }

        private void buttonBorBook_Click(object sender, EventArgs e)
        {
            BorrowedBooks list = new BorrowedBooks();
            list.ShowDialog();
        }

        private void btnEscrowBook_Click(object sender, EventArgs e)
        {
          EscrowBooksReturn rtrn = new EscrowBooksReturn();
          rtrn.ShowDialog();

        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            Sorting sort = new Sorting();
            sort.ShowDialog();
        }
    }
}
