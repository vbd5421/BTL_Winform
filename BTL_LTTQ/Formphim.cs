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

namespace BTL_LTTQ
{
    public partial class Formphim : Form
    {
        
        dataaccess dtbase = new dataaccess();
        public Formphim()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                txtMaP.Text = dgvphim.CurrentRow.Cells[0].Value.ToString();
                txtTenP.Text = dgvphim.CurrentRow.Cells[1].Value.ToString();
                cbbnuocsx.SelectedValue = dgvphim.CurrentRow.Cells[2].Value.ToString();
                cbbhangsx.SelectedValue = dgvphim.CurrentRow.Cells[3].Value.ToString();
                cbbtheloai.SelectedValue = dgvphim.CurrentRow.Cells[5].Value.ToString();
                txtDaodien.Text = dgvphim.CurrentRow.Cells[4].Value.ToString();
                dtpngaychieu.Text = dgvphim.CurrentRow.Cells[6].Value.ToString();
                dtpngayketthuc.Text =dgvphim.CurrentRow.Cells[7].Value.ToString();
               // dtpngaychieu.Text = dgvphim.Rows[dgvphim.CurrentRow.Index].Cells[6].Value.ToString();
               // dtpngayketthuc.Text= dgvphim.Rows[dgvphim.CurrentRow.Index].Cells[7].Value.ToString();
                txtNu.Text = dgvphim.CurrentRow.Cells[8].Value.ToString();
                txtNam.Text = dgvphim.CurrentRow.Cells[9].Value.ToString();
                rtbNoidung.Text = dgvphim.CurrentRow.Cells[10].Value.ToString();
                txtChiphi.Text = dgvphim.CurrentRow.Cells[11].Value.ToString();
                txtDoanhthu.Text = dgvphim.CurrentRow.Cells[12].Value.ToString();
            
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }
        void loaddata()
        {
            DataTable dtphim = new DataTable();

            dtphim = dtbase.DocBang(" SELECT maphim,tenphim,Nuoxsx.manuocsx,Hangsx.mahangsx,daodien,Theloai.matheloai,ngaykhoichieu,ngayketthuc,nuchinh,namchinh,noidungchinh,tongchiphi,tongthu FROM Phim, Theloai, Hangsx, Nuoxsx WHERE Theloai.matheloai = Phim.matheloai AND  Hangsx.mahangsx = Phim.mahangsx AND Nuoxsx.manuocsx = Phim.manuocsx");
            dgvphim.DataSource = dtphim;// gắn dl vào datagridview
        }
        
        private void Formphim_Load(object sender, EventArgs e)
        {
            
            //đưa dl ra cbb
            // bảng nước sản xuất
            cbbnuocsx.DataSource = dtbase.DocBang("Select manuocsx, tennuocsx from Nuoxsx");
            cbbnuocsx.DisplayMember ="tennuocsx";
            cbbnuocsx.ValueMember = "manuocsx";
            cbbnuocsx.Text = "";
            //bảng hãng sx
            cbbhangsx.DataSource = dtbase.DocBang("Select mahangsx, tenhangsx from Hangsx");
            cbbhangsx.ValueMember = "mahangsx";
            cbbhangsx.DisplayMember = "tenhangsx";
            cbbhangsx.Text ="";
            // bảng thể loại 
            cbbtheloai.DataSource = dtbase.DocBang("Select matheloai,tentheloai from Theloai");
            cbbtheloai.ValueMember = "matheloai";
            cbbtheloai.DisplayMember = "tentheloai";
            cbbtheloai.Text ="";
            loaddata();
            dgvphim.Columns[0].HeaderText = "Mã phim";
            dgvphim.Columns[1].HeaderText = "Tên phim";
            dgvphim.Columns[2].HeaderText = "Nước sản xuất";
            dgvphim.Columns[3].HeaderText = "Hãng sản xuất";
            dgvphim.Columns[4].HeaderText = "Đạo diễn";
            dgvphim.Columns[5].HeaderText = "Thể loại";
            dgvphim.Columns[6].HeaderText = "Ngày khởi chiếu ";
            dgvphim.Columns[7].HeaderText = "Ngày kết thúc";
            dgvphim.Columns[8].HeaderText = "Nữ diễn viên chính ";
            dgvphim.Columns[9].HeaderText = "Nam diễn viên chính";
            dgvphim.Columns[10].HeaderText = "Nội dung chính";
            dgvphim.Columns[11].HeaderText = "Tổng chi phí";
            dgvphim.Columns[12].HeaderText = "Tổng thu";
            dgvphim.BackgroundColor = Color.SeaShell;
            txtMaP.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn Có Muốn Thoát Không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra đủ dữ liệu
            if (txtMaP.Text == "" || txtTenP.Text == "" || cbbhangsx.Text == "" || cbbnuocsx.Text == "" || txtDaodien.Text == "" || cbbtheloai.Text == "" 
                 || txtNu.Text == "" || txtNam.Text == ""|| rtbNoidung.Text=="") 
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                txtMaP.Focus();
                return;
            }
            
            //kiểm tra mã có trùng ko trc khi thêm vào csdl
            string maphim = txtMaP.Text;
            DataTable dtphim = dtbase.DocBang("select * from Phim where maphim= '" + maphim + "'");
            if (dtphim.Rows.Count > 0)
            {
                MessageBox.Show(" Đã có mã phim : " + maphim + " vui lòng nhập mã khác");
                txtMaP.Focus();
                return;
            }
            //ktra ngày
            if (dtpngaychieu.Value > dtpngayketthuc.Value)
            {
                MessageBox.Show("Không hợp lệ", "Thông báo");
                return;
            }
           float chiphi, doanhthu;
            chiphi = float.Parse(txtChiphi.Text);
            doanhthu = float.Parse(txtDoanhthu.Text);
            if(chiphi>doanhthu)
            {
                if (MessageBox.Show("Doanh thu nhỏ hơn chi phí. Bạn có muốn thêm phim không?", "TB",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }    
            //tạo câu lệnh sql
            string SqlInsertphim = "insert into Phim values ('" + txtMaP.Text + "', N'" + txtTenP.Text + "',N'" + cbbnuocsx.SelectedValue.ToString() + "',N'" +cbbhangsx.SelectedValue.ToString() + "',N'" + txtDaodien.Text + "'" +
                ",N'" +cbbtheloai.SelectedValue.ToString() + "','" +dtpngaychieu.Value.ToString("yyyy/MM/dd") + "','" + dtpngayketthuc.Value.ToString("yyyy/MM/dd")+ "',N'" + txtNu.Text + "',N'" + txtNam.Text + "',N'" + rtbNoidung.Text + "','" +txtChiphi.Text+ "','" +txtDoanhthu.Text+ "')";
            
            dtbase.Capnhatdulieu(SqlInsertphim);
            //load
            loaddata();
            ResetValue();
            txtMaP.Focus();
        }
        private void ResetValue()
        {
            txtMaP.Text = "";
            txtTenP.Text = "";
            cbbtheloai.Text = "";
            cbbnuocsx.Text = "";
            txtDaodien.Text = "";
            cbbhangsx.Text = "";
            txtNu.Text = "";
            txtNam.Text = "";
            rtbNoidung.Text = "";
            txtChiphi.Text = "";
            txtDoanhthu.Text = "";
            dtpngayketthuc.Value = DateTime.Today;
            dtpngaychieu.Value = DateTime.Today;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Formphim_Click(object sender, EventArgs e)
        {
            loaddata();
            ResetValue();
            txtMaP.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaP.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá  " + " mã phim là " + txtMaP.Text + " không?",
                 "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.Capnhatdulieu("delete Phim where maphim ='" + txtMaP.Text + "'");
                loaddata();
            }
            ResetValue();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaP.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phòng chiếu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaP.Focus();
            }
            else
            {
                dtbase.Capnhatdulieu("update Phim set tenphim=N'" + txtTenP.Text + "',manuocsx=N'" + cbbnuocsx.SelectedValue.ToString() + "',mahangsx=N'" + cbbhangsx.SelectedValue.ToString() + "',daodien=N'" + txtDaodien.Text + "'" +
                ",matheloai=N'" + cbbtheloai.SelectedValue.ToString() + "',ngaykhoichieu='" + dtpngaychieu.Value.ToString("yyyy/MM/dd") + "' ,ngayketthuc= '" + dtpngayketthuc.Value.ToString("yyyy/MM/dd") + "'," +
                "nuchinh=N'" + txtNu.Text + "',namchinh=N'" + txtNam.Text + "',noidungchinh=N'" + rtbNoidung.Text + "',tongchiphi=" + txtChiphi.Text + ",tongthu=" + txtDoanhthu.Text + " Where maphim =N'" + txtMaP.Text + "'");
               
                ResetValue();//Xóa dữ liệu ở các ô nhập TextBox
                             //Sau khi update cần lấy lại dữ liệu để hiển thị lên lưới
                loaddata();
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtMaP.Focus();
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtChiphi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtfim;
          
            dtfim = dtbase.DocBang("select * from Phim where tenphim like N'%" +txtTenP.Text+ "%'");
        
               dgvphim.DataSource = dtfim;
           
        }

        private void txtDoanhthu_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
