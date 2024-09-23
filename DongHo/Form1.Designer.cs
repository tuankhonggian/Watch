namespace DongHo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DangKy = new System.Windows.Forms.LinkLabel();
            this.textBox_TaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.button_DangNhap = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.comboBox_ChucVu = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Nhập Hệ Thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(417, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(417, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu";
            // 
            // linkLabel_QuenMatKhau
            // 
            this.linkLabel_QuenMatKhau.AutoSize = true;
            this.linkLabel_QuenMatKhau.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel_QuenMatKhau.Location = new System.Drawing.Point(488, 247);
            this.linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            this.linkLabel_QuenMatKhau.Size = new System.Drawing.Size(104, 16);
            this.linkLabel_QuenMatKhau.TabIndex = 4;
            this.linkLabel_QuenMatKhau.TabStop = true;
            this.linkLabel_QuenMatKhau.Text = "Quên Mật Khẩu?";
            this.linkLabel_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_QuenMatKhau_LinkClicked);
            // 
            // linkLabel_DangKy
            // 
            this.linkLabel_DangKy.AutoSize = true;
            this.linkLabel_DangKy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel_DangKy.Location = new System.Drawing.Point(677, 247);
            this.linkLabel_DangKy.Name = "linkLabel_DangKy";
            this.linkLabel_DangKy.Size = new System.Drawing.Size(57, 16);
            this.linkLabel_DangKy.TabIndex = 5;
            this.linkLabel_DangKy.TabStop = true;
            this.linkLabel_DangKy.Text = "Đăng Ký";
            this.linkLabel_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DangKy_LinkClicked);
            // 
            // textBox_TaiKhoan
            // 
            this.textBox_TaiKhoan.Location = new System.Drawing.Point(491, 151);
            this.textBox_TaiKhoan.Name = "textBox_TaiKhoan";
            this.textBox_TaiKhoan.Size = new System.Drawing.Size(243, 22);
            this.textBox_TaiKhoan.TabIndex = 6;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(491, 192);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(243, 22);
            this.textBox_MatKhau.TabIndex = 7;
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.BackColor = System.Drawing.Color.DarkCyan;
            this.button_DangNhap.ForeColor = System.Drawing.Color.White;
            this.button_DangNhap.Location = new System.Drawing.Point(488, 325);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Size = new System.Drawing.Size(104, 38);
            this.button_DangNhap.TabIndex = 8;
            this.button_DangNhap.Text = "Đăng Nhập";
            this.button_DangNhap.UseVisualStyleBackColor = false;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Thoat.ForeColor = System.Drawing.Color.White;
            this.button_Thoat.Location = new System.Drawing.Point(664, 325);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(96, 38);
            this.button_Thoat.TabIndex = 9;
            this.button_Thoat.Text = "Cancel";
            this.button_Thoat.UseVisualStyleBackColor = false;
            // 
            // comboBox_ChucVu
            // 
            this.comboBox_ChucVu.ForeColor = System.Drawing.Color.Gray;
            this.comboBox_ChucVu.FormattingEnabled = true;
            this.comboBox_ChucVu.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.comboBox_ChucVu.Location = new System.Drawing.Point(491, 92);
            this.comboBox_ChucVu.Name = "comboBox_ChucVu";
            this.comboBox_ChucVu.Size = new System.Drawing.Size(243, 24);
            this.comboBox_ChucVu.TabIndex = 10;
            this.comboBox_ChucVu.Text = "Vui lòng chọn chức vụ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DongHo.Properties.Resources.tranh_treo_trang_tri_tuong_phong_ngu_gaming;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(832, 480);
            this.Controls.Add(this.comboBox_ChucVu);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_DangNhap);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_TaiKhoan);
            this.Controls.Add(this.linkLabel_DangKy);
            this.Controls.Add(this.linkLabel_QuenMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel_QuenMatKhau;
        private System.Windows.Forms.LinkLabel linkLabel_DangKy;
        private System.Windows.Forms.TextBox textBox_TaiKhoan;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Button button_DangNhap;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.ComboBox comboBox_ChucVu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

