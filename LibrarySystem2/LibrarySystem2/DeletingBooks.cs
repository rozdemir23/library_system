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
    public partial class DeletingBooks : Form
    {
        public DeletingBooks()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-MVS791K;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daSet = new DataSet();
        private void listBooks()
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Books", connect);
            adapter.Fill(daSet, "Books");
            dataGridView1.DataSource = daSet.Tables["Books"];
            connect.Close();


        }

        private void DeletingBooks_Load(object sender, EventArgs e)
        {
            listBooks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("update Books set bookName=@book,writer=@writer,publisher=@publisher,pageNo=@page,type=@type,stocksNo=@stocks,shelfNo=@shelf,explanation=@explain where barcodeNo=@barcode", connect);
            
            cmd.Parameters.AddWithValue("@barcode", txtBarcodeNo.Text);
            cmd.Parameters.AddWithValue("@book", txtBookName.Text);
            cmd.Parameters.AddWithValue("@writer", txtWriter.Text);
            cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text);
            cmd.Parameters.AddWithValue("@page", txtPageNo.Text);
            cmd.Parameters.AddWithValue("@type", comboType.Text);
            cmd.Parameters.AddWithValue("@stocks", txtStocks.Text);
            cmd.Parameters.AddWithValue("@shelf", txtShelfNo.Text);
            cmd.Parameters.AddWithValue("@explain", txtExplan.Text);          
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Updated");
            daSet.Tables["Books"].Clear();
            listBooks();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }


            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Do you want to delete this book ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("delete from Books where barcodeno=@barcodeno", connect);
                cmd.Parameters.AddWithValue("@barcodeno", dataGridView1.CurrentRow.Cells["barcodeno"].Value.ToString());
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Deleted");
                daSet.Tables["Books"].Clear();
                listBooks();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }


                }


            }

        }

        private void txtBarcodeNo_TextChanged(object sender, EventArgs e)
        {

            connect.Open();
            SqlCommand cmd = new SqlCommand("select *from Books where barcodeNo like '" + txtBarcodeNo.Text + "'", connect);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtBookName.Text = read["bookName"].ToString();
                txtWriter.Text = read["writer"].ToString();
                txtPublisher.Text = read["publisher"].ToString();
                txtPageNo.Text = read["pageNo"].ToString();
                comboType.Text = read["type"].ToString();
                txtStocks.Text = read["stocksNo"].ToString();
                txtShelfNo.Text = read["shelfNo"].ToString();
                txtExplan.Text = read["explanation"].ToString();



            }
            connect.Close();

        }

        private void txtBarcodeSearch_TextChanged(object sender, EventArgs e)
        {
            daSet.Tables["Books"].Clear();
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Books where barcodeNo like '%" + txtBarcodeSearch.Text + "%'", connect);
            adapter.Fill(daSet, "Books");
            dataGridView1.DataSource = daSet.Tables["Books"];
            connect.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
    }


