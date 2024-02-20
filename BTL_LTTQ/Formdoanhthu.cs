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
    public partial class Formdoanhthuphim : Form
    {
        dataaccess dtbase = new dataaccess();
        public Formdoanhthuphim()
        {
            InitializeComponent();
        }
        void loaddataphim()
        {
            DataTable dtthuphim = new DataTable();

            dtthuphim = dtbase.DocBang("  select'Mã Rạp'= Phim.maphim,'Tên Phim'=tenphim, 'Tổng Vé Bán'= sum(sovedaban) , 'Doanh Thu'=  sum(tongtien) from Showbuoichieu, Phim where Phim.maphim = Showbuoichieu.maphim and ngaychieu BETWEEN '" + dtptu.Value.ToString("yyyy/MM/dd") + "' AND '" + dtpden.Value.ToString("yyyy/MM/dd") + "'group by Phim.maphim, tenphim") ;
            dgvdoanhthu.DataSource = dtthuphim;// gắn dl vào datagridview
        }
        void loaddatarap()
        {
            DataTable dtthurap = new DataTable();
            dtthurap = dtbase.DocBang(" select 'Mã Rạp'=Rap.marap,'Tên Phim'=tenrap,'Tổng Vé Bán'= sum(sovedaban) , 'Doanh Thu'=  sum(tongtien)  from Showbuoichieu, Rap where  Showbuoichieu.marap = Rap.marap and ngaychieu BETWEEN '" + dtptu.Value.ToString("yyyy/MM/dd") + "' AND '" + dtpden.Value.ToString("yyyy/MM/dd") + "' group by Rap.marap, tenrap");
            dgvdoanhthu.DataSource = dtthurap;
        }
        void ResetValue()
        {
            txttongve.Text = "";
            textBox.Text = "";
            cbchon.Text = "";         
            dtpden.Value = DateTime.Today;
            dtptu.Value = DateTime.Today;
        }

        private void cbchon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbchon.SelectedItem == "Phim")
            {
                loaddataphim();
            }
            if (cbchon.SelectedItem=="Rạp")
            {
                loaddatarap();
            }    
        }

        private void dgvdoanhthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txttongve.Text = dgvdoanhthu.CurrentRow.Cells[2].Value.ToString();
            textBox.Text = dgvdoanhthu.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
