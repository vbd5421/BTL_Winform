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
    public partial class Formphongchieu : Form
    {
        dataaccess dtbase = new dataaccess();
        public Formphongchieu()
        {
            InitializeComponent();
        }

        private void Formphongchieu_Load(object sender, EventArgs e)
        {
            txtmaphong.Focus();
            //đưa dl ra combobox
            cbmarap.DataSource = dtbase.DocBang("Select marap,tenrap from Rap ");
            cbmarap.ValueMember = "marap";
            cbmarap.DisplayMember = "tenrap";
            cbmarap.Text = "";
            
              loaddata();
            dgvphongchieu.Columns[0].HeaderText = "Mã Phòng";
            dgvphongchieu.Columns[1].HeaderText = " Rạp ";
            dgvphongchieu.Columns[2].HeaderText = "Tên Phòng";
            dgvphongchieu.Columns[3].HeaderText = "Số Ghế";
            dgvphongchieu.BackgroundColor = Color.LightYellow;
        }
        void loaddata()
        {
           // DataTable dtphongchieu = new DataTable();

            dgvphongchieu.DataSource = dtbase.DocBang("SELECT maphong , Rap.marap ,tenphong , soghe FROM Rap, Phongchieu WHERE Phongchieu.marap = Rap.marap");            
        }

        private void dgvphongchieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaphong.Text = dgvphongchieu.CurrentRow.Cells[0].Value.ToString();
            //giá trị đc chọn là mã hiện tên
            cbmarap.SelectedValue= dgvphongchieu.CurrentRow.Cells[1].Value.ToString();
            //ele
            txtsoghe.Text = dgvphongchieu.CurrentRow.Cells[3].Value.ToString();
            txttenphong.Text = dgvphongchieu.CurrentRow.Cells[2].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
        }
        void ResetValue()
        {
            txttenphong.Text = "";
            txtsoghe.Text = "";
            txtmaphong.Text = "";
            cbmarap.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //kiểm tra đủ dữ liệu
            if (txtmaphong.Text == "" || txttenphong.Text == ""||txtsoghe.Text==""||cbmarap.Text=="")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                txtmaphong.Focus();
                return;
            }

            //kiểm tra mã có trùng ko trc khi thêm vào csdl
            string maphong = txtmaphong.Text;
            DataTable dtphongchieu = dtbase.DocBang("select * from Phongchieu where maphong= '" + maphong + "'");
            if (dtphongchieu.Rows.Count > 0)
            {
                MessageBox.Show(" đã có phòng chiếu với mã " + maphong + " vui lòng nhập mã khác");
                txtmaphong.Focus();
                return;
            }
           // string rap;
            //tạo câu lệnh sql
            string SqlInsertphong = "insert into Phongchieu  values(N'"+txtmaphong.Text+"', N'"+cbmarap.SelectedValue.ToString()+"', N'"+txttenphong.Text+"', "+txtsoghe.Text+")";

            dtbase.Capnhatdulieu(SqlInsertphong);
            //load
            loaddata();
            ResetValue();
            txtmaphong.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmaphong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá  " + " mã phòng chiếu là " + txtmaphong.Text + " không?",
                 "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.Capnhatdulieu("delete Phongchieu where maphong ='" +
                txtmaphong.Text + "'");
                loaddata();
            }
            ResetValue();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmaphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phòng chiếu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaphong.Focus();
            }
            else
            {
                dtbase.Capnhatdulieu("update Phongchieu set marap = N'"
              + cbmarap.SelectedValue.ToString() + "',tenphong=N'"+txttenphong.Text+"',soghe=N'"+txtsoghe.Text+"' where maphong= N'" + txtmaphong.Text + "'");
                ResetValue();//Xóa dữ liệu ở các ô nhập TextBox
                             //Sau khi update cần lấy lại dữ liệu để hiển thị lên lưới                        
                loaddata();
            }
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
            txtmaphong.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn Có Muốn Thoát Không ? ", "Lựa chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Formphongchieu_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtmaphong.Focus();
            btnthem.Enabled = true;
        }

        private void txtsoghe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbmarap_SelectedIndexChanged(object sender, EventArgs e)
        {   }
    }
}
