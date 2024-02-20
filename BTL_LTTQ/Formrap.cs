using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ
{
    public partial class Formrap : Form
    {
        dataaccess dtbase = new dataaccess();
        
        public Formrap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtmarap.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá" + " mã rạp là " + txtmarap.Text + " có tên là : " + txttenrap.Text + " không?",
                 "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.Capnhatdulieu("delete Rap where marap ='" +
                txtmarap.Text + "'");
                loaddata();
                txtmarap.Focus();
            }
            ResetValue();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
            txtmarap.Focus();
        }
        void loaddata()
        {
            DataTable dtrap = new DataTable();

            dtrap = dtbase.DocBang("select* from Rap");
            dgvrap.DataSource = dtrap;// gắn dl vào datagridview

        }
        void ResetValue()
        {
            txtdiachi.Text = "";
            txtmarap.Text = "";
            txtsdt.Text = "";
            txtsophong.Text = "";
            txttenrap.Text = "";
            txttongsoghe.Text = "";

        }

        private void dgvrap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdiachi.Text = dgvrap.CurrentRow.Cells[2].Value.ToString();
            txtmarap.Text = dgvrap.CurrentRow.Cells[0].Value.ToString();
            txttenrap.Text = dgvrap.CurrentRow.Cells[1].Value.ToString();
            txtsdt.Text = dgvrap.CurrentRow.Cells[3].Value.ToString();
            txtsophong.Text = dgvrap.CurrentRow.Cells[4].Value.ToString();
            txttongsoghe.Text = dgvrap.CurrentRow.Cells[5].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;

        }

        private void Formrap_Load(object sender, EventArgs e)
        {
            loaddata();
            dgvrap.Columns[0].HeaderText = "Mã Rạp ";
            dgvrap.Columns[1].HeaderText = "Tên Rạp ";
            dgvrap.Columns[2].HeaderText = "Địa chỉ ";
            dgvrap.Columns[3].HeaderText = "SĐT";
            dgvrap.Columns[4].HeaderText = "Số Phòng";
            dgvrap.Columns[5].HeaderText = "Tổng Số Ghế ";
            dgvrap.BackgroundColor = Color.LightSkyBlue;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //kiểm tra đủ dữ liệu
            if (txtdiachi.Text == "" || txtmarap.Text == ""|| txtsdt.Text==""||txtsophong.Text==""||txttenrap.Text==""||txttongsoghe.Text=="")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                txtmarap.Focus();
                return;
            }

            //kiểm tra mã có trùng ko trc khi thêm vào csdl
            string marap = txtmarap.Text;
            string tenrap = txttenrap.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string sophong = txtsophong.Text;
            string tongsoghe = txttongsoghe.Text;
            DataTable dtrap = dtbase.DocBang("select * from Rap where marap= '" +marap + "'");
            if (dtrap.Rows.Count > 0)
            {
                MessageBox.Show(" đã có rạp vs mã " + marap + " vui lòng nhập mã khác");
               txtmarap.Focus();
                return;
            }

            //tạo câu lệnh sql
            string SqlInsert = "insert into Rap values( N'"+marap+ "', N'"+tenrap+"', N'"+diachi+"', N'"+sdt+"', "+sophong+", "+tongsoghe+" )";

            dtbase.Capnhatdulieu(SqlInsert);
            //load
            loaddata();
            ResetValue();
           txtmarap.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmarap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã rạp ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmarap.Focus();
            }
            else
            {
                dtbase.Capnhatdulieu("update Rap set tenrap=N'"+ txttenrap.Text+"',diachi=N'"+ txtdiachi.Text+"',dienthoai=N'"+ txtsdt.Text+"',sophong='" 
                                         + txtsophong.Text+"',tongsoghe='" + txttongsoghe.Text +"' where marap =N'"+txtmarap.Text+"'");
                ResetValue();//Xóa dữ liệu ở các ô nhập TextBox
                             //Sau khi update cần lấy lại dữ liệu để hiển thị lên lưới
                dgvrap.DataSource = dtbase.DocBang("select * from Rap");
            }
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
            txtmarap.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn Có Muốn Thoát Không ? ", "Lựa chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnthem.Enabled = true;
            txtmarap.Focus();
        }

        private void txttenrap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
