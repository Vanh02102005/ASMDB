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
namespace asm1_db
{
    public partial class Product_Management : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        private object gvCustomer;
        private object ex;
        private object txtProductId;
        private object txtSearch;

        public Product_Management()
        {
            InitializeComponent();
        }
        private void Product_Management_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }


        private void LoadProductData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Book", con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    gvProduct.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Book (BookID, BookName, BookPrice, BookDescription, BookQuantity) VALUES (@ID, @Name, @Price, @Description, @Quantity)", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtProductID.Text);
                        cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@Price", txtProductPrice.Text);
                        cmd.Parameters.AddWithValue("Description", txtProductDescription.Text);
                        cmd.Parameters.AddWithValue("@Quantity", txtProductQuantity.Text);
                        //cmd.Parameters.AddWithValue("@Productphoto", pbProduct.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Đã thêm sản phẩm thành công!");
                    LoadProductData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Book SET BookDescription=@Description,BookQuantity=@Quantity, BookName=@Name, BookPrice=@Price WHERE BookID=@ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtProductID.Text);
                        cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@Price", txtProductPrice.Text);
                        cmd.Parameters.AddWithValue("Description", txtProductDescription.Text);
                        cmd.Parameters.AddWithValue("@Quantity", txtProductQuantity.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin sản phẩm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm với ID này.");
                        }
                    }
                    LoadProductData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Book WHERE BookID=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", txtProductID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa sản phẩm thành công!");
                    LoadProductData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM Book WHERE BookName LIKE @SearchTerm OR CAST(BookID AS NVARCHAR) LIKE @SearchTerm";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + txtProductID.Text + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gvProduct.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
