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
    public partial class ve : Form
    {
        dataaccess dtbase = new dataaccess();
        public ve()
        {
            InitializeComponent();
        }

        private void ve_Load(object sender, EventArgs e)
        {
            txtmave.Focus();
            //đưa dl ra combobox
            cbshow.DataSource = dtbase.DocBang("select mashow,  soghe from Phongchieu, Showbuoichieu, Rap, Phim where Phongchieu.maphong = Showbuoichieu.maphong  and Rap.marap = Showbuoichieu.marap and Showbuoichieu.maphim = Phim.maphim  ");
            cbshow.ValueMember = "mashow";
            cbshow.SelectedItem.ToString();
            cbshow.Text = "";
           
            loaddata();
            dgvve.Columns[0].HeaderText = "Mã Vé";
            dgvve.Columns[1].HeaderText = " Mã Show ";
            dgvve.Columns[2].HeaderText = "Hàng Ghế";
            dgvve.Columns[3].HeaderText = "Số Ghế";
            dgvve.BackgroundColor = Color.LightBlue;
        }
        
        void loaddata()
        {
            // DataTable dtphongchieu = new DataTable();
            //SELECT mave , Showbuoichieu.mashow ,hangghe , soghe FROM Showbuoichieu, Ve WHERE Showbuoichieu.mashow = Ve.mashow
            dgvve.DataSource = dtbase.DocBang(" SELECT mave , Showbuoichieu.mashow ,hangghe , soghe FROM Showbuoichieu, Ve WHERE Showbuoichieu.mashow = Ve.mashow ");
        }
        void ResetValue()
        {
            txtmave.Text = "";
            txtsoghe.Text = "";
            cbshow.Text = "";
            cbhangghe.Text = "";
            
        }
        private void dgvve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtmave.Text = dgvve.CurrentRow.Cells[0].Value.ToString();
            //giá trị đc chọn là mã hiện tên
            cbshow.SelectedValue = dgvve.CurrentRow.Cells[1].Value.ToString();
            txtsoghe.Text = dgvve.CurrentRow.Cells[3].Value.ToString();
            cbhangghe.Text = dgvve.CurrentRow.Cells[2].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            
            //kiểm tra đủ dữ liệu
            if (txtmave.Text == "" || txtsoghe.Text == "" || cbhangghe.Text == "" || cbshow.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
                txtmave.Focus();
                return;
            }

            //kiểm tra mã có trùng ko trc khi thêm vào csdl
            string mave = txtmave.Text;
            DataTable dtve = dtbase.DocBang("select * from Ve where mave= '" + mave + "'");
            if (dtve.Rows.Count > 0)
            {
                MessageBox.Show("Đã có vé với mã " + mave + " vui lòng nhập mã khác");
                txtmave.Focus();
                return;
            }
             
            // kiểm tra số ghế có trùng hay ko
            string soghe = txtsoghe.Text;
            DataTable dtsoghe = dtbase.DocBang("select * from Ve where soghe= '" + soghe + "'and mashow='"+cbshow.Text+ "'" );
            if (dtsoghe.Rows.Count > 0)
            {
                MessageBox.Show(" Đã có số ghế với tên là: " + soghe + " ở trong show "+cbshow.Text+" vui lòng nhập số ghế khác");
                txtsoghe.Focus();
                return;
            }
            // số vé ko nhiều hơn số ghế
            //dtbase.Capnhatdulieu(" update Showbuoichieu set sovedaban = (select count(*) from Ve where mashow ='" + cbshow.Text + "') where mashow = '" + cbshow.Text + "'");
            string tongghe = cbshow.Text;
            DataTable dttongghe = dtbase.DocBang(" select Ve.mave,Ve.mashow, Phongchieu.soghe , sovedaban  from Phongchieu, Showbuoichieu, Ve  where  Showbuoichieu.maphong = Phongchieu.maphong and Ve.mashow = Showbuoichieu.mashow and  Phongchieu.soghe <= sovedaban and Showbuoichieu.mashow = '"+tongghe+"'");
           if(dttongghe.Rows.Count>0)
            {
               if( MessageBox.Show("Số vé nhiều hơn số ghế ở Show với mã là: " + tongghe + " vui lòng xem lại ","Thông Báo" ,MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes);
                {
                    ResetValue();
                    txtmave.Focus();               
                    return;
                }
            }
            //tạo câu lệnh sql
            string SqlInsertve = "insert into Ve  values(N'" + txtmave.Text + "', N'" + cbshow.SelectedValue.ToString() + "', N'" + cbhangghe.Text + "', N'" + txtsoghe.Text + "')";

            dtbase.Capnhatdulieu(SqlInsertve);
            //load
            loaddata();
            ResetValue();
            txtmave.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmave.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã vé", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmave.Focus();
            }
            else
            {
                dtbase.Capnhatdulieu("update Ve set mashow = N'"
              + cbshow.SelectedValue.ToString() + "',hangghe=N'" +cbhangghe.Text + "',soghe=N'" + txtsoghe.Text + "' where mave= N'" + txtmave.Text + "'");
                ResetValue();//Xóa dữ liệu ở các ô nhập TextBox
                             //Sau khi update cần lấy lại dữ liệu để hiển thị lên lưới                        
                loaddata();
            }
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
            txtmave.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmave.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá  " + " mã vé là " + txtmave.Text + " không?",
                 "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtbase.Capnhatdulieu("delete Ve where mave ='" +
                txtmave.Text + "'");
                loaddata();
            }
            ResetValue();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn Có Muốn Thoát Không ? ", "Lựa chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtsoghe_KeyPress(object sender, KeyPressEventArgs e)
        { }
        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtmave.Focus();
            btnthem.Enabled = true;
            btnsua.Enabled=true;
            btnxoa.Enabled = true;          
        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            Formshowbuoichieu open = new Formshowbuoichieu();
            open.ShowDialog();
        }

        private void cbshow_SelectedIndexChanged(object sender, EventArgs e)
        {       }
        
    }
}
