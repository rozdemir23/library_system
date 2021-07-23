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
    public partial class Sorting : Form
    {
        public Sorting()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-MVS791K;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daSet = new DataSet();

       
        private void Sorting_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Member order by borrowBooks desc ", connect);
            adapter.Fill(daSet, "Member");
            dataGridView1.DataSource = daSet.Tables["Member"];
            connect.Close();
            label2.Text = "";
            label2.Text = daSet.Tables["Member"].Rows[0]["name"].ToString();
            label3.Text = daSet.Tables["Member"].Rows[0]["surname"].ToString() + " =";
            label3.Text += daSet.Tables["Member"].Rows[0]["borrowBooks"].ToString();


        }
    }
}
