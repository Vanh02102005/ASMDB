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
    public partial class Statistics : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        private object gvCustomer;
        private object ex;
        private object txtOrderId;
        private object txtSearch;
        public Statistics()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tbQuantity_Click(object sender, EventArgs e)
        {

        }
        private void LoadStatisticsData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM DetailedOrders", con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    gvSatistics.DataSource = dt;
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
                    int orderID = int.Parse(txtID.Text);
                    int bookID = int.Parse(txtBookID.Text);
                    using (SqlCommand checkOrderCmd = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE OrderID = @OrderID", con))
                    {
                        checkOrderCmd.Parameters.AddWithValue("@OrderID", orderID);
                        int orderExists = (int)checkOrderCmd.ExecuteScalar();
                        if (orderExists == 0)
                        {
                            MessageBox.Show("Order ID không tồn tại.");
                            return;
                        }
                    }
                    using (SqlCommand checkBookCmd = new SqlCommand("SELECT COUNT(*) FROM Book WHERE BookID = @BookID", con))
                    {
                        checkBookCmd.Parameters.AddWithValue("@BookID", bookID);
                        int bookExists = (int)checkBookCmd.ExecuteScalar();
                        if (bookExists == 0)
                        {
                            MessageBox.Show("Book ID không tồn tại.");
                            return;
                        }
                    }
                    int quantity = int.Parse(txtQuantity.Text);
                    decimal price = decimal.Parse(txtPrice.Text);

                    if (quantity <= 0)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0.");
                        return;
                    }

                    if (price < 0)
                    {
                        MessageBox.Show("Giá phải là số không âm.");
                        return;
                    }
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO DetailedOrders (OrderID, BookID, Quantity, Date, Price) VALUES (@OrderID, @BookID, @Quantity, @Date, @Price)", con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderID);
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Date", txtDate.Text);
                        cmd.Parameters.AddWithValue("@Price", price);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã thêm chi tiết đơn hàng thành công!");
                    LoadStatisticsData();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Định dạng đầu vào không hợp lệ: " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    int orderID = int.Parse(txtID.Text);
                    int bookID = int.Parse(txtBookID.Text);
                    int quantity = int.Parse(txtQuantity.Text);
                    decimal price = decimal.Parse(txtPrice.Text);
                    using (SqlCommand checkExistsCmd = new SqlCommand("SELECT COUNT(*) FROM DetailedOrders WHERE OrderID = @OrderID AND BookID = @BookID", con))
                    {
                        checkExistsCmd.Parameters.AddWithValue("@OrderID", orderID);
                        checkExistsCmd.Parameters.AddWithValue("@BookID", bookID);
                        int exists = (int)checkExistsCmd.ExecuteScalar();

                        if (exists == 0)
                        {
                            MessageBox.Show("Chi tiết đơn hàng không tồn tại.");
                            return;
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("UPDATE DetailedOrders SET Quantity = @Quantity, Date = @Date, Price = @Price WHERE OrderID = @OrderID AND BookID = @BookID", con))
                    {
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Date", txtDate.Text);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@OrderID", orderID);
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã sửa chi tiết đơn hàng thành công!");
                    LoadStatisticsData();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Định dạng đầu vào không hợp lệ: " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    int orderID = int.Parse(txtID.Text);
                    int bookID = int.Parse(txtBookID.Text);
                    using (SqlCommand checkExistsCmd = new SqlCommand("SELECT COUNT(*) FROM DetailedOrders WHERE OrderID = @OrderID AND BookID = @BookID", con))
                    {
                        checkExistsCmd.Parameters.AddWithValue("@OrderID", orderID);
                        checkExistsCmd.Parameters.AddWithValue("@BookID", bookID);
                        int exists = (int)checkExistsCmd.ExecuteScalar();
                        if (exists == 0)
                        {
                            MessageBox.Show("Chi tiết đơn hàng không tồn tại.");
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM DetailedOrders WHERE OrderID = @OrderID AND BookID = @BookID", con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderID);
                        cmd.Parameters.AddWithValue("@BookID", bookID);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa chi tiết đơn hàng thành công!");
                    LoadStatisticsData();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Định dạng đầu vào không hợp lệ: " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM DetailedOrders WHERE OrderID LIKE @SearchTerm OR CAST(OrderID AS NVARCHAR) LIKE @SearchTerm";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + txtID.Text + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gvSatistics.DataSource = dt;
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
