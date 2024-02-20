
namespace BTL_LTTQ
{
    partial class Formdoanhthuphim
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpden = new System.Windows.Forms.DateTimePicker();
            this.dtptu = new System.Windows.Forms.DateTimePicker();
            this.cbchon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdoanhthu = new System.Windows.Forms.DataGridView();
            this.textBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttongve = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoanhthu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtpden);
            this.groupBox2.Controls.Add(this.dtptu);
            this.groupBox2.Controls.Add(this.cbchon);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1287, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtpden
            // 
            this.dtpden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpden.Location = new System.Drawing.Point(819, 108);
            this.dtpden.Name = "dtpden";
            this.dtpden.Size = new System.Drawing.Size(218, 28);
            this.dtpden.TabIndex = 8;
            // 
            // dtptu
            // 
            this.dtptu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtptu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptu.Location = new System.Drawing.Point(324, 108);
            this.dtptu.Name = "dtptu";
            this.dtptu.Size = new System.Drawing.Size(227, 28);
            this.dtptu.TabIndex = 7;
            this.dtptu.Value = new System.DateTime(2021, 11, 28, 21, 28, 0, 0);
            // 
            // cbchon
            // 
            this.cbchon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbchon.FormattingEnabled = true;
            this.cbchon.Items.AddRange(new object[] {
            "Phim",
            "Rạp"});
            this.cbchon.Location = new System.Drawing.Point(600, 27);
            this.cbchon.Name = "cbchon";
            this.cbchon.Size = new System.Drawing.Size(248, 30);
            this.cbchon.TabIndex = 5;
            this.cbchon.SelectedIndexChanged += new System.EventHandler(this.cbchon_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đến Ngày";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ Ngày";
            // 
            // dgvdoanhthu
            // 
            this.dgvdoanhthu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdoanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdoanhthu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvdoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoanhthu.Location = new System.Drawing.Point(49, 183);
            this.dgvdoanhthu.Name = "dgvdoanhthu";
            this.dgvdoanhthu.RowHeadersWidth = 51;
            this.dgvdoanhthu.Size = new System.Drawing.Size(1236, 310);
            this.dgvdoanhthu.TabIndex = 2;
            this.dgvdoanhthu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdoanhthu_CellClick);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(418, 35);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(200, 39);
            this.textBox.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txttongve);
            this.groupBox3.Controls.Add(this.textBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(665, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 90);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng Doanh Thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tổng vé";
            // 
            // txttongve
            // 
            this.txttongve.Location = new System.Drawing.Point(134, 35);
            this.txttongve.Multiline = true;
            this.txttongve.Name = "txttongve";
            this.txttongve.ReadOnly = true;
            this.txttongve.Size = new System.Drawing.Size(77, 39);
            this.txttongve.TabIndex = 10;
            // 
            // Formdoanhthuphim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1322, 605);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvdoanhthu);
            this.Controls.Add(this.groupBox2);
            this.Name = "Formdoanhthuphim";
            this.Text = "Doanh Thu Phim";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoanhthu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvdoanhthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpden;
        private System.Windows.Forms.DateTimePicker dtptu;
        private System.Windows.Forms.ComboBox cbchon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttongve;
    }
}