namespace DongHo
{
    partial class ThongKe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_dsdh = new System.Windows.Forms.DataGridView();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.button_XemChiTietDonHang = new System.Windows.Forms.Button();
            this.button_XuatExcel = new System.Windows.Forms.Button();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dsdh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_dsdh);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sach Cac Hoa Don Tai Cua Hang";
            // 
            // dataGridView_dsdh
            // 
            this.dataGridView_dsdh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dsdh.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_dsdh.Name = "dataGridView_dsdh";
            this.dataGridView_dsdh.RowHeadersWidth = 51;
            this.dataGridView_dsdh.RowTemplate.Height = 24;
            this.dataGridView_dsdh.Size = new System.Drawing.Size(1030, 371);
            this.dataGridView_dsdh.TabIndex = 0;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackColor = System.Drawing.Color.DarkCyan;
            this.button_TimKiem.ForeColor = System.Drawing.Color.White;
            this.button_TimKiem.Location = new System.Drawing.Point(453, 467);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(75, 34);
            this.button_TimKiem.TabIndex = 1;
            this.button_TimKiem.Text = "Tim Kiem";
            this.button_TimKiem.UseVisualStyleBackColor = false;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // button_XemChiTietDonHang
            // 
            this.button_XemChiTietDonHang.BackColor = System.Drawing.Color.DarkCyan;
            this.button_XemChiTietDonHang.ForeColor = System.Drawing.Color.White;
            this.button_XemChiTietDonHang.Location = new System.Drawing.Point(584, 466);
            this.button_XemChiTietDonHang.Name = "button_XemChiTietDonHang";
            this.button_XemChiTietDonHang.Size = new System.Drawing.Size(190, 35);
            this.button_XemChiTietDonHang.TabIndex = 2;
            this.button_XemChiTietDonHang.Text = "Xem Chi Tiet Don Hang";
            this.button_XemChiTietDonHang.UseVisualStyleBackColor = false;
            this.button_XemChiTietDonHang.Click += new System.EventHandler(this.button_XemChiTietDonHang_Click);
            // 
            // button_XuatExcel
            // 
            this.button_XuatExcel.BackColor = System.Drawing.Color.DarkCyan;
            this.button_XuatExcel.ForeColor = System.Drawing.Color.White;
            this.button_XuatExcel.Location = new System.Drawing.Point(815, 466);
            this.button_XuatExcel.Name = "button_XuatExcel";
            this.button_XuatExcel.Size = new System.Drawing.Size(132, 35);
            this.button_XuatExcel.TabIndex = 3;
            this.button_XuatExcel.Text = "Xuất ALL ra Excel";
            this.button_XuatExcel.UseVisualStyleBackColor = false;
            this.button_XuatExcel.Click += new System.EventHandler(this.button_XuatExcel_Click);
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(93, 473);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(354, 22);
            this.textBox_TimKiem.TabIndex = 5;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1066, 608);
            this.Controls.Add(this.textBox_TimKiem);
            this.Controls.Add(this.button_XuatExcel);
            this.Controls.Add(this.button_XemChiTietDonHang);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dsdh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Button button_XemChiTietDonHang;
        private System.Windows.Forms.Button button_XuatExcel;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.DataGridView dataGridView_dsdh;
    }
}