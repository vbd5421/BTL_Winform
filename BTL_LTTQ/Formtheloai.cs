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
    public partial class Formtheloai : Form
    {
        dataaccess dtbase = new dataaccess();
        bool hp;
        public Formtheloai()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra đủ dữ liệu
            if (txtmatl.Text == "" || txttentl.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                txtmatl.Focus();
                return;
            }


            //kiểm tra mã có trùng ko trc khi thêm vào csdl
            string matl = txttentl.Text;
            DataTable dtnuocsx = dtbase.DocBang("select * from Theloai where matheloai = '" + matl + "'");
            if (dtnuocsx.Rows.Count > 0)
            {
                MessageBox.Show(" đã có tên thể loai vs mã " + matl + " vui lòng nhập mã khác");
                txtmatl.Focus();
                return;
            }

            //tạo câu lệnh sql
            string SqlInsert = "insert into Theloai values(N'" + txtmatl.Text + "', N'" + txttentl.Text + "')";

            dtbase.Capnhatdulieu(SqlInsert);
            //load
            loaddata();
            ResetValue();
            txtmatl.Focus();
        }
        void ResetValue()
        {
            txtmatl.Text = "";
            txttentl.Text = "";
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

        private void txttentl_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void dgvtheloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatl.Text = dgvtheloai.CurrentRow.Cells[0].Value.ToString();
            txttentl.Text = dgvtheloai.CurrentRow.Cells[1].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }
        void loaddata()
        {
            DataTable dttheloai = new DataTable();
            dttheloai = dtbase.DocBang("select* from Theloai");
            dgvtheloai.DataSource = dttheloai;// gắn dl vào datagridview

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string matheloai = txtmatl.Text;
            string tentheloai = txttentl.Text;
            if (matheloai == "")
            {
                MessageBox.Show("Bạn phải nhập mã theloai", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmatl.Focus();
            }
            else
            {
                dtbase.Capnhatdulieu("update Theloai set tentheloai= N'" + tentheloai + "' where matheloai= N'" + matheloai + "'");
                ResetValue();//Xóa dữ liệu ở các ô nhập TextBox
                             //Sau khi update cần lấy lại dữ liệu để hiển thị lên lưới
                dgvtheloai.DataSource = dtbase.DocBang("select * from Theloai");


            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtmatl.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmatl.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá  " + " mã thể loại là " + txtmatl.Text + " có tên là : " + txttentl.Text + " không?",
                 "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.Capnhatdulieu("delete Theloai where matheloai ='" +
                txtmatl.Text + "'");
                loaddata();
            }
            ResetValue();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtmatl.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Formtheloai_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnThem.Enabled = true;
            txtmatl.Focus();

        }

        private void Formtheloai_Load(object sender, EventArgs e)
        {
            loaddata();
            dgvtheloai.Columns[0].HeaderText = "Mã thể loại";
            dgvtheloai.Columns[1].HeaderText = "Tên thể loại";
            dgvtheloai.Columns[0].Width = 150;
            dgvtheloai.Columns[1].Width = 150;
            dgvtheloai.BackgroundColor = Color.Gray;
            txtmatl.Focus();
        }
    }
}
