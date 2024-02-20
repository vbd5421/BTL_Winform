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
    public partial class Formshowbuoichieu : Form
    {
        dataaccess dtbase = new dataaccess();

        public Formshowbuoichieu()
        {
            InitializeComponent();
        }

        private void dgvshowbuoichieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
        void loaddata()
        {
            DataTable dtbuoichieu = new DataTable();

            dtbuoichieu = dtbase.DocBang("select* from Showbuoichieu");
            dgvshowbuoichieu.DataSource = dtbuoichieu;// gắn dl vào datagridview
        }
        private void Formshowbuoichieu_Load(object sender, EventArgs e)
        {

            txtsoveban.Text = "0";
            txtmashow.Focus();
            //đưa dl ra combobox
            cbmarap.DataSource = dtbase.DocBang("Select marap,tenrap from Rap ");
            cbmarap.ValueMember = "marap";
            cbmarap.DisplayMember = "tenrap";
            cbmarap.Text = "";
            //phim
            cbmaphim.DataSource = dtbase.DocBang("Select maphim, tenphim from Phim");
            cbmaphim.ValueMember = "maphim";
            cbmaphim.DisplayMember = "tenphim";
            cbmaphim.Text = "";
            //phòng
            cbmaphong.DataSource = dtbase.DocBang("Select maphong,tenphong from Phongchieu");
            cbmaphong.ValueMember = "maphong";
            cbmaphong.DisplayMember = "tenphong";
            cbmaphong.Text = "";
            //giờ chiếu
            cbmagiochieu.DataSource = dtbase.DocBang("Select magiochieu,thoigian  from Giochieu ");
            cbmagiochieu.ValueMember = "magiochieu";
            cbmagiochieu.DisplayMember = "thoigian";
            cbmagiochieu.Text = "";
            loaddata();
            dgvshowbuoichieu.Columns[0].HeaderText = "Mã Show";
            dgvshowbuoichieu.Columns[1].HeaderText = " Mã Phim ";
            dgvshowbuoichieu.Columns[2].HeaderText = "Mã Rạp";
            dgvshowbuoichieu.Columns[3].HeaderText = "Mã Phòng";
            dgvshowbuoichieu.Columns[4].HeaderText = "Mã Giờ chiếu";
            dgvshowbuoichieu.Columns[5].HeaderText = "Ngày Chiếu";
            dgvshowbuoichieu.Columns[6].HeaderText = "Số Vé Đã Bán";
            dgvshowbuoichieu.Columns[7].HeaderText = "Tổng Tiền";
            dgvshowbuoichieu.BackgroundColor = Color.LightYellow;
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmashow.Text == "" || cbmagiochieu.Text == "" || cbmaphim.Text == "" || cbmaphong.Text == "" || cbmarap.Text == ""  || txtsoveban.Text == ""
                 || txttongtien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu!", "Thông Báo");
                txtmashow.Focus();
                return;
            }
            //kiểm tra mã show
             string mashow = txtmashow.Text;
             DataTable dtbuoichieu = dtbase.DocBang("select * from Showbuoichieu where mashow= '" + mashow + "'");
             if (dtbuoichieu.Rows.Count > 0)
             {
                 MessageBox.Show(" Đã có mã phim : " + mashow + " vui lòng nhập mã khác");
                 txtmashow.Focus();
                 return;
             }

            // ktra giờ chiếu
            string thoigian = cbmagiochieu.Text;
            DataTable dt = dtbase.DocBang("select * from Showbuoichieu where magiochieu= '" + thoigian + "' and mashow= '"+txtmashow.Text+"'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(" Đã có mã phim : " + thoigian + " vui lòng nhập mã khác");
                txtmashow.Focus();
                return;
            }

            // thêm dl
            string SqlInsertshow = "insert into Showbuoichieu values ('" + txtmashow.Text + "', N'" + cbmaphim.SelectedValue.ToString() + "',N'" + cbmarap.SelectedValue.ToString() + "',N'" + cbmaphong.SelectedValue.ToString() + "'" +
                ",N'" + cbmagiochieu.SelectedValue.ToString() + "','" + dtpngaychieu.Value.ToString("yyyy/MM/dd") + "','" + txtsoveban.Text + "','" + txttongtien.Text + "')";

            dtbase.Capnhatdulieu(SqlInsertshow);
            //load
            loaddata();
            ResetValue();
            txtmashow.Focus();
            txtsoveban.Text = "0";
        }
        void ResetValue()
        {
            txtmashow.Text = "";
            txtsoveban.Text = "";
            txttongtien.Text = "";
            cbmagiochieu.Text = "";
            cbmaphim.Text = "";
            cbmaphong.Text = "";
            cbmarap.Text = "";
            dtpngaychieu.Value = DateTime.Today;
        }

        private void dgvshowbuoichieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmashow.Text = dgvshowbuoichieu.CurrentRow.Cells[0].Value.ToString();
            txtsoveban.Text = dgvshowbuoichieu.CurrentRow.Cells[6].Value.ToString();
            txttongtien.Text = dgvshowbuoichieu.CurrentRow.Cells[7].Value.ToString();
            cbmagiochieu.SelectedValue = dgvshowbuoichieu.CurrentRow.Cells[4].Value.ToString();
            cbmaphim.SelectedValue = dgvshowbuoichieu.CurrentRow.Cells[1].Value.ToString();
            cbmaphong.SelectedValue = dgvshowbuoichieu.CurrentRow.Cells[3].Value.ToString();
            cbmarap.SelectedValue = dgvshowbuoichieu.CurrentRow.Cells[2].Value.ToString();
            dtpngaychieu.Text = dgvshowbuoichieu.CurrentRow.Cells[5].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
        }

        private void Formshowbuoichieu_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtmashow.Focus();
            btnthem.Enabled = true;
            btncapnhat.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            txtsoveban.Text = "0";
            txttongtien.Text = "0";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (txtmashow.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá  " + " mã show là " + txtmashow.Text + " không?",
                 "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.Capnhatdulieu("delete Showbuoichieu where mashow ='" +
                txtmashow.Text + "'");
                loaddata();
            }
            ResetValue();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            dtbase.Capnhatdulieu("update Showbuoichieu set maphim =N'" + cbmaphim.SelectedValue.ToString() + "',marap=N'" + cbmarap.SelectedValue.ToString() + "'," +
                "maphong=N'" + cbmaphong.SelectedValue.ToString() + "',magiochieu=N'" + cbmagiochieu.SelectedValue.ToString() + "',ngaychieu='" + dtpngaychieu.Value.ToString("yyyy/MM/dd") + "'," +
                "sovedaban=" + txtsoveban.Text + ",tongtien=" + txttongtien.Text + " Where mashow =N'" + txtmashow.Text + "'");         
            MessageBox.Show("Sửa thành công");
            loaddata();
            ResetValue();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }

        private void cbmagiochieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            float x;
            if (cbmagiochieu.SelectedIndex == 0)
            {
                x = 60000;
                txttongtien.Text = (float.Parse(txtsoveban.Text) * x).ToString();
            }
            if (cbmagiochieu.SelectedIndex == 1)
            {

                x = 70000;
                txttongtien.Text = (float.Parse(txtsoveban.Text) * x).ToString();
            }
            if (cbmagiochieu.SelectedIndex == 2)
            {

                x = 100000;
                txttongtien.Text = (float.Parse(txtsoveban.Text) * x).ToString();
            }
            if (cbmagiochieu.SelectedIndex == 3)
            {
                x = 110000;
                txttongtien.Text = (float.Parse(txtsoveban.Text) * x).ToString();
            }
        }
        private void txtsoveban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtsoveban_TextChanged(object sender, EventArgs e)
        {  }
        private void label9_Click(object sender, EventArgs e)
        {}
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            dtbase.Capnhatdulieu(" update Showbuoichieu set sovedaban = (select count(*) from ve where mashow ='" + txtmashow.Text + "') where mashow = '" + txtmashow.Text + "'");

            loaddata();
           /* float x;
            if (cbmagiochieu.SelectedIndex == 0)
            {
                x = 60000;
                txttongtien.Text = (float.Parse(txtsoveban.Text) * x).ToString();
            }
            if (cbmagiochieu.SelectedIndex == 1)
            {
                x = 70000;
                txttongtien.Text = (float.Parse(txtsoveban.Text) * x).ToString();
            }
            if (cbmagiochieu.SelectedIndex == 2)
            {
                x = 100000;
                txttongtien.Text = (float.Parse(txtsoveban.Text) * x).ToString();
            }
            if (cbmagiochieu.SelectedIndex == 3)
            {
                x = 110000;
                txttongtien.Text = (float.Parse(txtsoveban.Text) * x).ToString();
            }*/
            //loaddata();
            dgvshowbuoichieu.Columns[0].HeaderText = "Mã Show";
            dgvshowbuoichieu.Columns[1].HeaderText = " Mã Phim ";
            dgvshowbuoichieu.Columns[2].HeaderText = "Mã Rạp";
            dgvshowbuoichieu.Columns[3].HeaderText = "Mã Phòng";
            dgvshowbuoichieu.Columns[4].HeaderText = "Mã Giờ chiếu";
            dgvshowbuoichieu.Columns[5].HeaderText = "Ngày Chiếu";
            dgvshowbuoichieu.Columns[6].HeaderText = "Số Vé Đã Bán";
            dgvshowbuoichieu.Columns[7].HeaderText = "Tổng Tiền";
            dgvshowbuoichieu.BackgroundColor = Color.LightYellow;
        }       
    }
    }

