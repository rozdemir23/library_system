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
    public partial class AddingBooks : Form
    {
        public AddingBooks()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-MVS791K;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        private void AddingBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("insert into Books(barcodeNo,bookName,writer,publisher,pageNo,type,stocksNo,shelfNo,explanation,dateOfRegistration) values(@barcode,@name,@writer,@publisher,@page,@type,@stocks,@shelf,@explanation,@date)", connect);
            cmd.Parameters.AddWithValue("@barcode", txtBarcodeNo.Text);
            cmd.Parameters.AddWithValue("@name", txtBookName.Text);
            cmd.Parameters.AddWithValue("@writer", txtWriter.Text);
            cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text);
            cmd.Parameters.AddWithValue("@page", txtPageNo.Text);
            cmd.Parameters.AddWithValue("@type", comboType.Text);
            cmd.Parameters.AddWithValue("@stocks", txtStocks.Text);
            cmd.Parameters.AddWithValue("@shelf", txtShelfNo.Text);
            cmd.Parameters.AddWithValue("@explanation", txtExplan.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Book Registered");

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }

            }
        }
    }
}
