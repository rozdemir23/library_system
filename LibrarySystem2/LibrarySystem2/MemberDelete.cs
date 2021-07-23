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
    public partial class MemberDelete : Form
    {
        public MemberDelete()
        {
            InitializeComponent();
        }

        private void MemberDelete_Load(object sender, EventArgs e)
        {
            listMembers();



        }

        private void txtBorrow_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("update Member set name=@name,surname=@surname,gender=@gender,age=@age,phoneNumber=@phone,borrowBooks=@borrow where id=@id", connect);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
            cmd.Parameters.AddWithValue("@gender", comboGender.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@borrow", int.Parse(txtBorrow.Text));
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Updated");
            daSet.Tables["Member"].Clear();
            listMembers();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }


            }



        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-MVS791K;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select *from Member where id like '" + txtID.Text+"'", connect);                                                  
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtName.Text = read["name"].ToString();
                txtSurname.Text = read["surname"].ToString();
                comboGender.Text = read["gender"].ToString();
                txtAge.Text = read["age"].ToString();
                txtPhone.Text = read["phoneNumber"].ToString();
                txtBorrow.Text = read["borrowBooks"].ToString();

            }
            connect.Close();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
        }
        DataSet daSet = new DataSet();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            daSet.Tables["Member"].Clear();
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Member where id like '%" + txtSearch.Text + "%'", connect);
            adapter.Fill(daSet,"Member");
            dataGridView1.DataSource = daSet.Tables["Member"];
            connect.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Do you want to delete this member ?", "Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Information);            
            if(dialog==DialogResult.Yes)
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("delete from Member where id=@id", connect);
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Deleted");
                daSet.Tables["Member"].Clear();
                listMembers();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }


                }


            }

            
        }
        private void listMembers()
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Member", connect);
            adapter.Fill(daSet, "Member");
            dataGridView1.DataSource = daSet.Tables["Member"];
            connect.Close();


        }

    }
}
