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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void véToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ve bangve = new ve();
            bangve.Show();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        { }
        private void showBuổiChiềuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formshowbuoichieu showbuoichieu = new Formshowbuoichieu();
            showbuoichieu.Show();
        }

        private void nướcSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuocsx nuocsx = new Nuocsx();
            nuocsx.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formtheloai theloai = new Formtheloai();
            theloai.Show();
        }

        private void hãngSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formhangsx hangsx = new Formhangsx();
            hangsx.Show();
        }

        private void giờChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formgiochieu giochieu = new Formgiochieu();
            giochieu.Show();
        }

        private void rạpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formrap rap = new Formrap();
            rap.Show();
        }

        private void phimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formphim phim = new Formphim();
            phim.Show();
        }

        private void phòngChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formphongchieu phongchieu = new Formphongchieu();
            phongchieu.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn Có Muốn Thoát Không ? ", "lựa chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(textBox1.Text.Length - 1, 1) + textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void ghếToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formdoanhthuphim thu = new Formdoanhthuphim();
            thu.Show();
        }

    }
}
