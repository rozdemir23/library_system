using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem2
{
    public partial class EscrowBooksReturn : Form
    {
        public EscrowBooksReturn()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-MVS791K;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daSet = new DataSet();

        private void BorrowedBooksList()
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks", connect);
            adapter.Fill(daSet, "EscrowBooks");
            dataGridView1.DataSource = daSet.Tables["EscrowBooks"];
            connect.Close();
        }
        private void EscrowBooksReturn_Load(object sender, EventArgs e)
        {
            BorrowedBooksList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtIdSearch_TextChanged(object sender, EventArgs e)
        {
            daSet.Tables["EscrowBooks"].Clear();
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks where id like '%" + txtIdSearch.Text + "%' ", connect);
            adapter.Fill(daSet,"EsrowBooks");
            connect.Close();
            if (txtIdSearch.Text=="")
            {
                daSet.Tables["EscrowBooks"].Clear();
                BorrowedBooksList();


            }



        }

        private void txtBarcodeSearch_TextChanged(object sender, EventArgs e)
        {
            daSet.Tables["EscrowBooks"].Clear();
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks where barcodeNo like '%" + txtBarcodeSearch.Text + "%' ", connect);
            adapter.Fill(daSet, "EsrowBooks");
            connect.Close();
            if (txtBarcodeSearch.Text == "")
            {
                daSet.Tables["EscrowBooks"].Clear();
                BorrowedBooksList();


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("delete from EscrowBooks where id=@id and barcodeNo=@barcodeNo ", connect);
            cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            cmd.Parameters.AddWithValue("@barcodeNo", dataGridView1.CurrentRow.Cells["barcodeNo"].Value.ToString());
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("update Books set stocksNo=stocksNo+'"+dataGridView1.CurrentRow.Cells["bookNo"].Value.ToString()+"' where barcodeNo=@barcodeNo",connect);
            cmd2.Parameters.AddWithValue("@barcodeNo", dataGridView1.CurrentRow.Cells["barcodeNo"].Value.ToString());
            cmd2.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Book(s) Returned");

            daSet.Tables["EscrowBooks"].Clear();
            BorrowedBooksList();
        }
    }
}
