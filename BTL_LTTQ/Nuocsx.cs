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
    public partial class Nuocsx : Form
    {
        dataaccess dtbase = new dataaccess();
        bool hp;
        public Nuocsx()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //kiểm tra đủ dữ liệu
            if (txtmanuoc.Text == "" || txttennuoc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                txtmanuoc.Focus();
                return;
            }


            //kiểm tra mã có trùng ko trc khi thêm vào csdl
            string manuocsx = txtmanuoc.Text;
            DataTable dtnuocsx = dtbase.DocBang("select * from Nuoxsx where manuocsx = '" + manuocsx + "'");
            if (dtnuocsx.Rows.Count > 0)
            {
                MessageBox.Show(" đã có nước vs mã " + manuocsx + " vui lòng nhập mã khác");
                txtmanuoc.Focus();
                return;
            }

            //tạo câu lệnh sql
            string SqlInsert = "insert into Nuoxsx values(N'" + txtmanuoc.Text + "', N'" + txttennuoc.Text + "')";

            dtbase.Capnhatdulieu(SqlInsert);
            //load
            loaddata();
            ResetValue();
            txtmanuoc.Focus();
        }

        private void Nuocsx_Load(object sender, EventArgs e)
        {
            loaddata();
            dgvnuocsx.Columns[0].HeaderText = "Mã nước sản xuất";
            dgvnuocsx.Columns[1].HeaderText = "Tên nước sản xuất";
            dgvnuocsx.Columns[0].Width = 200;
            dgvnuocsx.Columns[1].Width = 200;
            dgvnuocsx.BackgroundColor = Color.Gray;
        }

        private void dgvnuocsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanuoc.Text = dgvnuocsx.CurrentRow.Cells[0].Value.ToString();
            txttennuoc.Text = dgvnuocsx.CurrentRow.Cells[1].Value.ToString();

            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
        }
        void loaddata()
        {
            DataTable dtgiochieu = new DataTable();

            dtgiochieu = dtbase.DocBang("select* from Nuoxsx");
            dgvnuocsx.DataSource = dtgiochieu;// gắn dl vào datagridview

        }
        void ResetValue()
        {
            txttennuoc.Text = "";
            txtmanuoc.Text = "";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmanuoc.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá  " + " mã nước là " + txtmanuoc.Text + " có tên là : " + txttennuoc.Text + " không?",
                 "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.Capnhatdulieu("delete Nuoxsx where manuocsx ='" +
                txtmanuoc.Text + "'");
                loaddata();
            }
            ResetValue();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
            txtmanuoc.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string manuocsx = txtmanuoc.Text;
            string tennuoc = txttennuoc.Text;
            if (manuocsx == "")
            {
                MessageBox.Show("Bạn phải nhập mã giờ chiếu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanuoc.Focus();
            }
            else
            {
                dtbase.Capnhatdulieu("update Nuoxsx set tennuocsx= N'"
              + tennuoc + "' where manuocsx= N'" + manuocsx + "'");
                ResetValue();//Xóa dữ liệu ở các ô nhập TextBox
                             //Sau khi update cần lấy lại dữ liệu để hiển thị lên lưới
                dgvnuocsx.DataSource = dtbase.DocBang("select * from Nuoxsx");


            }
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn Có Muốn Thoát Không ? ", "lựa chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Nuocsx_Click(object sender, EventArgs e)
        {
            txtmanuoc.Text = "";
            txttennuoc.Text = "";
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            txtmanuoc.Focus();
        }

        private void txttennuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hp)
            {
                if ((lbl1.Left + lbl1.Width) < this.Width)
                    lbl1.Left = lbl1.Left + 10;
                else
                    hp = false;
            }
            else
            {
                if (lbl1.Left > 0)
                    lbl1.Left = lbl1.Left - 10;
                else
                    hp = true;
            }
        }
    }
}
