using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
namespace asm1_db
{
    public partial class Employee : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        private object gvCustomer;
        private object ex;
        private object txtEmployeeId;
        private object txtSearch;
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }


        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Staff", con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    gvEmployee.DataSource = dt;
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
                    string hashedPassword = HashPassword(txtPassword.Text);
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Staff (StaffID, StaffEmail, StaffName, StaffAddress, StaffPhone, StaffUserName, StaffPassword, StaffPosition) VALUES (@ID, @Email, @Name, @Address, @Phone, @Username, @Password, @Position)", con))
                    {

                        cmd.Parameters.AddWithValue("@ID", txtEmployeeID.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text);
                        cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                        cmd.Parameters.AddWithValue("@Address", txtEmployeeAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtEmployeePhone.Text);
                        cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@PassWord", hashedPassword);
                        cmd.Parameters.AddWithValue("@Position", cbPosition.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Đã thêm nhân viên thành công!");
                    LoadEmployeeData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Chuyển mật khẩu thành mảng byte
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Chuyển mảng byte thành chuỗi hex
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

                private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Staff SET StaffUsername=@UserName, StaffPassword=@Password, StaffEmail=@Email, StaffName=@Name, StaffAddress=@Address,StaffPosition=@Position, StaffPhone=@Phone WHERE StaffID=@ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtEmployeeID.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text);
                        cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                        cmd.Parameters.AddWithValue("@Address", txtEmployeeAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtEmployeePhone.Text);
                        cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Position", cbPosition.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên với ID này.");
                        }
                    }
                    LoadEmployeeData();
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
                    cmd = new SqlCommand("DELETE FROM Staff WHERE StaffID=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", txtEmployeeID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa nhân viên thành công!");
                    LoadEmployeeData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM Staff WHERE StaffName LIKE @SearchTerm OR CAST(StaffID AS NVARCHAR) LIKE @SearchTerm";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + txtEmployeeID.Text + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gvEmployee.DataSource = dt;
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
