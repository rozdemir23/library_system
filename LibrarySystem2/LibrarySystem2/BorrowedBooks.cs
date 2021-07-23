using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySystem2
{
    public partial class BorrowedBooks : Form
    {
        public BorrowedBooks()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-MVS791K;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daSet = new DataSet();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BorrowedBooks_Load(object sender, EventArgs e)
        {
            BorrowedBooksList();
            comboBox1.SelectedIndex = 0;

        }

        private void BorrowedBooksList()
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks", connect);
            adapter.Fill(daSet, "EscrowBooks");
            dataGridView1.DataSource = daSet.Tables["EscrowBooks"];
            connect.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daSet.Tables["EscrowBooks"].Clear();
            if (comboBox1.SelectedIndex==0)

            {
                BorrowedBooksList();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks where'"+DateTime.Now.ToShortDateString()+"'>returnDate", connect);
                adapter.Fill(daSet, "EscrowBooks");
                dataGridView1.DataSource = daSet.Tables["EscrowBooks"];
                connect.Close();

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks where'" + DateTime.Now.ToShortDateString() + "'<=returnDate", connect);
                adapter.Fill(daSet, "EscrowBooks");
                dataGridView1.DataSource = daSet.Tables["EscrowBooks"];
                connect.Close();

            }

        }
    }
}
