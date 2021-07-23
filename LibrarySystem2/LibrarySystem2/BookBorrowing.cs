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
    public partial class BookBorrowing : Form
    {
        public BookBorrowing()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-MVS791K;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daSet = new DataSet();

        private void booksNo()

        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select sum(bookNo) from Sepet", connect);
            lblKitapSayısı.Text = cmd.ExecuteScalar().ToString();
            connect.Close();


        }

        private void BookBorrowing_Load(object sender, EventArgs e)
        {
            sepetList();
            booksNo();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sepetList()
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Sepet", connect);
            adapter.Fill(daSet, "Sepet");
            dataGridView1.DataSource = daSet.Tables["Sepet"];
            connect.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("insert into Sepet(barcodeNo,bookName,writer,publisher,pageNo,bookNo,deliveryDate,returnDate) values(@barcodeNo,@bookName,@writer,@publisher,@pageNo,@bookNo,@deliveryDate,@returnDate)", connect);

            cmd.Parameters.AddWithValue("@barcodeNo", txtBarcode.Text);
            cmd.Parameters.AddWithValue("@bookName", txtBookName.Text);
            cmd.Parameters.AddWithValue("@writer", txtWriter.Text);
            cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text);
            cmd.Parameters.AddWithValue("@pageNo", txtPageNo.Text);
            cmd.Parameters.AddWithValue("@bookNo", int.Parse(txtBookNo.Text));
            cmd.Parameters.AddWithValue("@deliveryDate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@returnDate", dateTimePicker2.Text);
            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Book Added to Cart", "Adding Process");
            daSet.Tables["Sepet"].Clear();
            sepetList();
            lblKitapSayısı.Text = "";
            booksNo();


            foreach (Control item in groupBook.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtBookName)
                    {
                        item.Text = "";
                    }
                }

            }
            

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select *from Member where id like'" + txtID.Text + "'", connect);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtName.Text = read["name"].ToString();
                txtSurname.Text = read["surname"].ToString();
                txtAge.Text = read["age"].ToString();

            }
            connect.Close();

            connect.Open();
            SqlCommand cmd2 = new SqlCommand("select sum(bookNo) from EscrowBooks where id='"+txtID.Text+"'", connect);
            lblKayıtlıKitapSayi.Text = cmd2.ExecuteScalar().ToString();
            connect.Close();

            if(txtID.Text == "")
            {
                foreach(Control item in groupMember.Controls)
                {
                    if (item is TextBox)

                    {
                        item.Text = "";
                        
                    }
                }
                lblKitapSayısı.Text = "";
            }


        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select *from Books where barcodeNo like '" + txtBarcode.Text + "'", connect);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtBookName.Text = read["bookName"].ToString();
                txtWriter.Text = read["writer"].ToString();
                txtPublisher.Text = read["publisher"].ToString();
                txtPageNo.Text = read["pageNo"].ToString();


            }
            connect.Close();

            if(txtBarcode.Text=="")

            {
                foreach (Control item in groupBook.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtBookNo)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Unregister ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialog == DialogResult.Yes)
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("delete from Sepet where barcodeNo='" + dataGridView1.CurrentRow.Cells["barcodeNo"].Value.ToString() + "'", connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("The deletion has been done.", "Deletion Process");
                daSet.Tables["sepet"].Clear();
                sepetList();
                lblKitapSayısı.Text = "";
                booksNo();
            }

            

        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSayısı.Text!= "")
            {
                if (lblKayıtlıKitapSayi.Text=="" && int.Parse(lblKitapSayısı.Text) <=3 || lblKitapSayısı.Text!="" && int.Parse(lblKayıtlıKitapSayi.Text)+int.Parse(lblKayıtlıKitapSayi.Text)<=3)
                    
                {
                    
                    if (txtID.Text!="" && txtName.Text!="" && txtSurname.Text!="" && txtAge.Text!="")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {

                            connect.Open();
                            SqlCommand cmd = new SqlCommand("insert into EscrowBooks(id,name,surname,age,barcodeNo,bookName,writer,publisher,pageNo,bookNo,deliveryDate,returnDate) values(@id,@name,@surname,@age,@barcodeNo,@bookName,@writer,@publisher,@pageNo,@bookNo,@deliveryDate,@returnDate) ", connect);
                            cmd.Parameters.AddWithValue("@id", txtID.Text);
                            cmd.Parameters.AddWithValue("@name", txtName.Text);
                            cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                            cmd.Parameters.AddWithValue("@age", txtAge.Text);
                            cmd.Parameters.AddWithValue("barcodeNo", dataGridView1.Rows[i].Cells["barcodeNo"].Value.ToString());
                            cmd.Parameters.AddWithValue("bookName", dataGridView1.Rows[i].Cells["bookName"].Value.ToString());
                            cmd.Parameters.AddWithValue("writer", dataGridView1.Rows[i].Cells["writer"].Value.ToString());
                            cmd.Parameters.AddWithValue("publisher", dataGridView1.Rows[i].Cells["publisher"].Value.ToString());
                            cmd.Parameters.AddWithValue("pageNo", dataGridView1.Rows[i].Cells["pageNo"].Value.ToString());
                            cmd.Parameters.AddWithValue("bookNo", int.Parse(dataGridView1.Rows[i].Cells["bookNo"].Value.ToString()));
                            cmd.Parameters.AddWithValue("deliveryDate", dataGridView1.Rows[i].Cells["deliveryDate"].Value.ToString());
                            cmd.Parameters.AddWithValue("returnDate", dataGridView1.Rows[i].Cells["returnDate"].Value.ToString());
                            cmd.ExecuteNonQuery();
                            SqlCommand cmd2 = new SqlCommand("update Member set borrowBooks=borrowBooks+'" + int.Parse(dataGridView1.Rows[i].Cells["bookNo"].Value.ToString())+ "'where id ='"+txtID.Text+"' ",connect);
                            cmd2.ExecuteNonQuery();
                            SqlCommand cmd3 = new SqlCommand("update Books set stocksNo=stocksNo-'" + int.Parse(dataGridView1.Rows[i].Cells["bookNo"].Value.ToString()) + "'where barcodeNo ='" + dataGridView1.Rows[i].Cells["barcodeNo"].Value.ToString() + "' ", connect);
                            cmd3.ExecuteNonQuery();

                            connect.Close();

                        }
                        connect.Open();
                        SqlCommand cmd4 = new SqlCommand("delete from Sepet", connect);
                        cmd4.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Kitaplar Emanet Edildi");
                        daSet.Tables["Sepet"].Clear();
                        sepetList();
                        txtID.Text = "";
                        lblKitapSayısı.Text = "";
                        booksNo();
                        lblKayıtlıKitapSayi.Text = "";





                    }
                    else 
                    {
                        MessageBox.Show("First you need to choose a member name !", "WARNING");

                    }

                    lblKitapSayısı.Text = "";
                    booksNo();

                }
                else
                {
                    MessageBox.Show("The number of escrow books cannot be more than 3 !", "WARNING");

                }
            }
            else
            {
                MessageBox.Show("You must add the book to the cart first ! ", "WARNING");

            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

