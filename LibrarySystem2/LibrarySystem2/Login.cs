using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySystem2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-MVS791K;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        private void buttonLoginS_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sql = "Select *from StaffLogin where staffName= @ad AND staffPassword=@sifre";
                SqlParameter prm1 = new SqlParameter("ad", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", textBox2.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    StaffPage fr = new StaffPage();
                    fr.Show();




                }

            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Entry");

            }
        }


        private void buttonLoginM_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sql = "Select *from Member where name= @name AND id=@id";
                SqlParameter prm1 = new SqlParameter("name", txtMemberName.Text.Trim());
                SqlParameter prm2 = new SqlParameter("id", txtID.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MemberPage fr = new MemberPage();
                    fr.Show();




                }

            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Entry");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

}