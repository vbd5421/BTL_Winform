
namespace BTL_LTTQ
{
    partial class dangnhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butThoat = new System.Windows.Forms.Button();
            this.butDN = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(16, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 403);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butThoat);
            this.groupBox1.Controls.Add(this.butDN);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 392);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(146, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đăng Nhập Tài Khoản";
            // 
            // butThoat
            // 
            this.butThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butThoat.Location = new System.Drawing.Point(375, 289);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(161, 56);
            this.butThoat.TabIndex = 7;
            this.butThoat.Text = "Thoát";
            this.butThoat.UseVisualStyleBackColor = true;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click_1);
            // 
            // butDN
            // 
            this.butDN.BackColor = System.Drawing.Color.Transparent;
            this.butDN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDN.Location = new System.Drawing.Point(75, 289);
            this.butDN.Name = "butDN";
            this.butDN.Size = new System.Drawing.Size(161, 56);
            this.butDN.TabIndex = 6;
            this.butDN.Text = "Đăng Nhập";
            this.butDN.UseVisualStyleBackColor = false;
            this.butDN.Click += new System.EventHandler(this.butDN_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(246, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(237, 30);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Hiển Thị Mật Khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(88, 186);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 26);
            this.label.TabIndex = 4;
            this.label.Text = "Mật Khẩu";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(246, 173);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.ShortcutsEnabled = false;
            this.txtMK.Size = new System.Drawing.Size(290, 39);
            this.txtMK.TabIndex = 2;
            this.txtMK.TabStop = false;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(246, 99);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(290, 35);
            this.txtTK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 456);
            this.Controls.Add(this.panel1);
            this.Name = "dangnhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butThoat;
        private System.Windows.Forms.Button butDN;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label1;
    }
}