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

namespace BTL_LTTQ
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

       
        private void dangnhap_Load(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = false;
        }

        private void butThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butDN_Click_1(object sender, EventArgs e)
        {

            txtTK.Focus();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MEETM40\SQLEXPRESS;Initial Catalog=qlrapphim;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string sql = "select * from NguoiDung where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    //MessageBox.Show("Đăng nhập thành công", "Thông báo");
                   // this.Hide();
                    Form1 Dn = new Form1();
                    Dn.Show();
                }

                else
                {
                    MessageBox.Show("Nhập sai tài khoản hoặc mât khẩu", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

       
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
                if (checkBox1.Checked)
                {
                    txtMK.UseSystemPasswordChar = true;
                }
                else
                {
                    txtMK.UseSystemPasswordChar = false;
                }
            
        }
    }
}
