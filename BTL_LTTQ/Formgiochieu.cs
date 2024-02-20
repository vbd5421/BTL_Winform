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
    public partial class Formgiochieu : Form
    {
        dataaccess dtbase = new dataaccess();
        //string dongia;
        public Formgiochieu()
        {
            InitializeComponent();
        }

        private void dgvgiochieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            cbthoigian.Text = dgvgiochieu.CurrentRow.Cells[1].Value.ToString();
            txtdongia.Text = dgvgiochieu.CurrentRow.Cells[2].Value.ToString();
            txtmagiochieu.Text = dgvgiochieu.CurrentRow.Cells[0].Value.ToString();         
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
           
        }
        void loaddata()
        {
            DataTable dtgiochieu = new DataTable();

            dtgiochieu = dtbase.DocBang("select * from Giochieu");
            dgvgiochieu.DataSource = dtgiochieu;// gắn dl vào datagridview

        }

        private void Formgiochieu_Load(object sender, EventArgs e)
        {
            loaddata();
            dgvgiochieu.Columns[0].HeaderText = "Mã Giờ chiếu";
            dgvgiochieu.Columns[1].HeaderText = "Thời gian";
            dgvgiochieu.Columns[2].HeaderText = " Đơn giá ";
            dgvgiochieu.Columns[0].Width = 200;
            dgvgiochieu.Columns[1].Width = 200;
            
            dgvgiochieu.BackgroundColor = Color.LightGoldenrodYellow;
        }
        void ResetValue()
       {
            txtmagiochieu.Text = "";
            txtdongia.Text = "";
            cbthoigian.Text = "";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            //kiểm tra đủ dữ liệu
            if ( txtmagiochieu.Text=="" || txtdongia.Text=="")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                txtmagiochieu.Focus();
                return;
            }
            
            //kiểm tra mã có trùng ko trc khi thêm vào csdl
            string magiochieu = txtmagiochieu.Text;
            DataTable dtgiochieu = dtbase.DocBang("select * from Giochieu where magiochieu= '" + magiochieu + "'");
            if (dtgiochieu.Rows.Count > 0)
            {
                MessageBox.Show(" đã có giờ chiếu vs mã " + magiochieu + " vui lòng nhập mã khác");
                txtmagiochieu.Focus();
                return;
            }

            //tạo câu lệnh sql
            string SqlInsertgiochieu = "insert into Giochieu values(N'" + txtmagiochieu.Text + "',N'" + cbthoigian.Text + "', " + txtdongia.Text + ")";

            dtbase.Capnhatdulieu(SqlInsertgiochieu);
            //load
            loaddata();
            ResetValue();
            txtmagiochieu.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmagiochieu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã giờ chiếu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmagiochieu.Focus();
            }
            else
            {
                dtbase.Capnhatdulieu("update Giochieu set thoigian=N'"+cbthoigian.Text+"', dongia="+txtdongia.Text+" where magiochieu= N'" + txtmagiochieu.Text + "'");
                ResetValue();//Xóa dữ liệu ở các ô nhập TextBox
                             //Sau khi update cần lấy lại dữ liệu để hiển thị lên lưới
                dgvgiochieu.DataSource = dtbase.DocBang("select * from Giochieu");


            }
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmagiochieu.Text=="")
            {
                MessageBox.Show("Bạn phải chọn mã để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá  " + " mã giờ là " + txtmagiochieu.Text +" có đơn giá : " + txtdongia.Text + " không?",
                 "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                dtbase.Capnhatdulieu("delete Giochieu where magiochieu ='" +
                txtmagiochieu.Text + "'");
                loaddata();
            }
            ResetValue();
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

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            txtmagiochieu.Text = "";
            txtdongia.Text = "";
            btnthem.Enabled = true;
            txtmagiochieu.Focus();
            cbthoigian.Text = "";
        }

        private void cbthoigian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbthoigian.SelectedIndex == -1)
            {
                txtdongia.Text = "";
                return;
            }
            
            if (cbthoigian.SelectedIndex == 0)
            {
                txtdongia.Text = "60000";
            }
            if (cbthoigian.SelectedIndex == 1)
            {
                txtdongia.Text = "70000";
            }
            if (cbthoigian.SelectedIndex== 2)
            {
                txtdongia.Text = "100000";
            }
            if(cbthoigian.SelectedIndex==3)
            {
                txtdongia.Text = "110000";
            }    
        }
    }
}
