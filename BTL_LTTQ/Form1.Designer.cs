
namespace BTL_LTTQ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.véToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBuổiChiềuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nướcSảnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hãngSảnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giờChiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rạpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngChiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.doanhThuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(644, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.véToolStripMenuItem,
            this.showBuổiChiềuToolStripMenuItem,
            this.nướcSảnXuấtToolStripMenuItem,
            this.thểLoạiToolStripMenuItem,
            this.hãngSảnXuấtToolStripMenuItem,
            this.giờChiếuToolStripMenuItem,
            this.rạpToolStripMenuItem,
            this.phimToolStripMenuItem,
            this.phòngChiếuToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            this.danhMụcToolStripMenuItem.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // véToolStripMenuItem
            // 
            this.véToolStripMenuItem.Name = "véToolStripMenuItem";
            this.véToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.véToolStripMenuItem.Text = "Vé";
            this.véToolStripMenuItem.Click += new System.EventHandler(this.véToolStripMenuItem_Click);
            // 
            // showBuổiChiềuToolStripMenuItem
            // 
            this.showBuổiChiềuToolStripMenuItem.Name = "showBuổiChiềuToolStripMenuItem";
            this.showBuổiChiềuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.showBuổiChiềuToolStripMenuItem.Text = "Show buổi chiếu";
            this.showBuổiChiềuToolStripMenuItem.Click += new System.EventHandler(this.showBuổiChiềuToolStripMenuItem_Click);
            // 
            // nướcSảnXuấtToolStripMenuItem
            // 
            this.nướcSảnXuấtToolStripMenuItem.Name = "nướcSảnXuấtToolStripMenuItem";
            this.nướcSảnXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nướcSảnXuấtToolStripMenuItem.Text = "Nước sản xuất";
            this.nướcSảnXuấtToolStripMenuItem.Click += new System.EventHandler(this.nướcSảnXuấtToolStripMenuItem_Click);
            // 
            // thểLoạiToolStripMenuItem
            // 
            this.thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            this.thểLoạiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thểLoạiToolStripMenuItem.Text = "Thể loại";
            this.thểLoạiToolStripMenuItem.Click += new System.EventHandler(this.thểLoạiToolStripMenuItem_Click);
            // 
            // hãngSảnXuấtToolStripMenuItem
            // 
            this.hãngSảnXuấtToolStripMenuItem.Name = "hãngSảnXuấtToolStripMenuItem";
            this.hãngSảnXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hãngSảnXuấtToolStripMenuItem.Text = "Hãng sản xuất";
            this.hãngSảnXuấtToolStripMenuItem.Click += new System.EventHandler(this.hãngSảnXuấtToolStripMenuItem_Click);
            // 
            // giờChiếuToolStripMenuItem
            // 
            this.giờChiếuToolStripMenuItem.Name = "giờChiếuToolStripMenuItem";
            this.giờChiếuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.giờChiếuToolStripMenuItem.Text = "Giờ chiếu";
            this.giờChiếuToolStripMenuItem.Click += new System.EventHandler(this.giờChiếuToolStripMenuItem_Click);
            // 
            // rạpToolStripMenuItem
            // 
            this.rạpToolStripMenuItem.Name = "rạpToolStripMenuItem";
            this.rạpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rạpToolStripMenuItem.Text = "Rạp";
            this.rạpToolStripMenuItem.Click += new System.EventHandler(this.rạpToolStripMenuItem_Click);
            // 
            // phimToolStripMenuItem
            // 
            this.phimToolStripMenuItem.Name = "phimToolStripMenuItem";
            this.phimToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phimToolStripMenuItem.Text = "Phim";
            this.phimToolStripMenuItem.Click += new System.EventHandler(this.phimToolStripMenuItem_Click);
            // 
            // phòngChiếuToolStripMenuItem
            // 
            this.phòngChiếuToolStripMenuItem.Name = "phòngChiếuToolStripMenuItem";
            this.phòngChiếuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phòngChiếuToolStripMenuItem.Text = "Phòng chiếu";
            this.phòngChiếuToolStripMenuItem.Click += new System.EventHandler(this.phòngChiếuToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lavender;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(0, 368);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(644, 48);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "        WELL    COME    TO    DHD    CINEMA      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_LTTQ.Properties.Resources.bgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "QL RẠP CHIẾU PHIM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem véToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBuổiChiềuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nướcSảnXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hãngSảnXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giờChiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rạpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngChiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
    }
}

