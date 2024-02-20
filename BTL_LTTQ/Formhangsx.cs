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
    public partial class Formhangsx : Form
    {
        dataaccess dtbase = new dataaccess();
        public Formhangsx()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                    dtbase.Capnhatdulieu("Delete Hangsx where mahngsx=N'" + txtmahang.Text + "'");
                    LoadData();
                    btnsua.Enabled = false;
                    btnthem.Enabled = true;
                    btnxoa.Enabled = false;
                    ResetValue();
                    txtmahang.Focus();
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(textBox1.Text.Length - 1, 1) + textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void Formhangsx_Load(object sender, EventArgs e)
        {
            txtmahang.Focus();
            LoadData();
            dgvHangsanxuat.Columns[0].HeaderText = "Mã hãng sản xuất ";
            dgvHangsanxuat.Columns[1].HeaderText = "Tên hãng sản xuất ";
            dgvHangsanxuat.BackgroundColor = Color.LightSkyBlue;
        }
        void LoadData()
        {
            DataTable dthangsx = new DataTable();

            dthangsx = dtbase.DocBang("select* from Hangsx");
            dgvHangsanxuat.DataSource = dthangsx;// gắn dl vào datagridview;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmahang.Text.Trim() == "" || txttenhang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                return;
            }
            string MaHang = txtmahang.Text;
            DataTable dtHangsx = dtbase.DocBang("Select * from Hangsx where mahangsx='" + MaHang + "'");
            if (dtHangsx.Rows.Count > 0)
            {
                MessageBox.Show("Mã hãng này đã tồn tại, mời nhập mã khác");
                txtmahang.Focus();
                return;
            }
            //Thêm 
             
            dtbase.Capnhatdulieu("insert into Hangsx values('" + MaHang + "',N'" + txttenhang.Text + "')");
            LoadData();
            ResetValue();
            txtmahang.Focus();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void dgvHangsanxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmahang.Text = dgvHangsanxuat.CurrentRow.Cells[0].Value.ToString();
            txttenhang.Text = dgvHangsanxuat.CurrentRow.Cells[1].Value.ToString();
            btnthem.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
        }
        void ResetValue()
        {
            txttenhang.Text = "";
            txtmahang.Text = "";  
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmahang.Text.Trim() == "" || txttenhang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                return;
            }
            dtbase.Capnhatdulieu("update Hangsx set tenhangsx =N'" + txttenhang.Text + "' where mahangsx='" + txtmahang.Text + "'");
            LoadData();
            ResetValue();
            txtmahang.Focus();
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnthem.Enabled = true;
        }

        private void Formhangsx_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtmahang.Focus();
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            
        }

        private void dgvHangsanxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
