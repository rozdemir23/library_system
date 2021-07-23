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
    public partial class AddingMembers : Form
    {
        public AddingMembers()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-MVS791K;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("insert into Member (id,name,surname,gender,age,phoneNumber,borrowBooks) values(@id,@name,@surname,@gender,@age,@phoneNumber,@borrowBooks)", connect);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
            cmd.Parameters.AddWithValue("@gender", comboGender.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", txtPhone.Text);
            cmd.Parameters.AddWithValue("@borrowBooks", txtBorrow.Text);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Succesfully ! ");

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtBorrow)
                    {
                        item.Text = " ";

                    }

                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddingMembers_Load(object sender, EventArgs e)
        {

        }
    }
}
