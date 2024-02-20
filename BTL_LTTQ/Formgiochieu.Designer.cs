
namespace BTL_LTTQ
{
    partial class Formgiochieu
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
            this.dgvgiochieu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbthoigian = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtmagiochieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgiochieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvgiochieu
            // 
            this.dgvgiochieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvgiochieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvgiochieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvgiochieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgiochieu.Location = new System.Drawing.Point(37, 217);
            this.dgvgiochieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvgiochieu.Name = "dgvgiochieu";
            this.dgvgiochieu.ReadOnly = true;
            this.dgvgiochieu.RowHeadersWidth = 51;
            this.dgvgiochieu.Size = new System.Drawing.Size(1094, 553);
            this.dgvgiochieu.TabIndex = 0;
            this.dgvgiochieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgiochieu_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbthoigian);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.txtmagiochieu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1442, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời gian";
            // 
            // cbthoigian
            // 
            this.cbthoigian.FormattingEnabled = true;
            this.cbthoigian.Items.AddRange(new object[] {
            "Thứ 2-3-4-5-6           từ 8h-17h",
            "Thứ 2-3-4-5-6           từ 17h-23h",
            "Thứ 7-CN-Ngày Lễ    từ 8h-17h",
            "Thứ 7-CN-Ngày Lễ    từ 17h-23h"});
            this.cbthoigian.Location = new System.Drawing.Point(651, 41);
            this.cbthoigian.Name = "cbthoigian";
            this.cbthoigian.Size = new System.Drawing.Size(330, 28);
            this.cbthoigian.TabIndex = 5;
            this.cbthoigian.SelectedIndexChanged += new System.EventHandler(this.cbthoigian_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1374, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "VND";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(1200, 42);
            this.txtdongia.Margin = new System.Windows.Forms.Padding(4);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.ReadOnly = true;
            this.txtdongia.Size = new System.Drawing.Size(167, 27);
            this.txtdongia.TabIndex = 3;
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // txtmagiochieu
            // 
            this.txtmagiochieu.Location = new System.Drawing.Point(231, 41);
            this.txtmagiochieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtmagiochieu.Name = "txtmagiochieu";
            this.txtmagiochieu.Size = new System.Drawing.Size(169, 27);
            this.txtmagiochieu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1116, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giờ chiếu";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnboqua);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1193, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(264, 653);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(47, 451);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(4);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(175, 58);
            this.btnboqua.TabIndex = 4;
            this.btnboqua.Text = "Bỏ Qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(47, 586);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(175, 54);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(47, 318);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(175, 54);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(47, 185);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(175, 55);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(47, 55);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(175, 57);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BTL_LTTQ.Properties.Resources._9752a51005f2cdac94e31;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Formgiochieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1477, 863);
            this.Controls.Add(this.dgvgiochieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formgiochieu";
            this.Text = "Giờ Chiếu";
            this.Load += new System.EventHandler(this.Formgiochieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgiochieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgiochieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtmagiochieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbthoigian;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}