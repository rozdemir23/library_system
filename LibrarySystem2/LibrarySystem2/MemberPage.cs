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
    public partial class MemberPage : Form
    {
        public MemberPage()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-MVS791K;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daSet = new DataSet();
        private void MemberPage_Load(object sender, EventArgs e)
        {
            listBooks2();
        }
        private void listBooks2()
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Books", connect);
            adapter.Fill(daSet, "Books");
            dataGridView1.DataSource = daSet.Tables["Books"];
            connect.Close();


        }

        private void txtBarcodeSearch_TextChanged(object sender, EventArgs e)
        {
            daSet.Tables["Books"].Clear();
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Books where bookName like '%" + txtBarcodeSearch.Text + "%'", connect);
            adapter.Fill(daSet, "Books");
            dataGridView1.DataSource = daSet.Tables["Books"];
            connect.Close();
        }
    }
}
