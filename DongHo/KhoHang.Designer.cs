namespace DongHo
{
    partial class KhoHang
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
            this.dataGridView_DanhSachSPtrongKho = new System.Windows.Forms.DataGridView();
            this.button_Refesh = new System.Windows.Forms.Button();
            this.button_NhapHang = new System.Windows.Forms.Button();
            this.button_XuatExcel = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachSPtrongKho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_DanhSachSPtrongKho);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "San Pham Co Trong Kho";
            // 
            // dataGridView_DanhSachSPtrongKho
            // 
            this.dataGridView_DanhSachSPtrongKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhSachSPtrongKho.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_DanhSachSPtrongKho.Name = "dataGridView_DanhSachSPtrongKho";
            this.dataGridView_DanhSachSPtrongKho.RowHeadersWidth = 51;
            this.dataGridView_DanhSachSPtrongKho.RowTemplate.Height = 24;
            this.dataGridView_DanhSachSPtrongKho.Size = new System.Drawing.Size(704, 387);
            this.dataGridView_DanhSachSPtrongKho.TabIndex = 0;
            // 
            // button_Refesh
            // 
            this.button_Refesh.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Refesh.ForeColor = System.Drawing.Color.White;
            this.button_Refesh.Location = new System.Drawing.Point(76, 459);
            this.button_Refesh.Name = "button_Refesh";
            this.button_Refesh.Size = new System.Drawing.Size(101, 38);
            this.button_Refesh.TabIndex = 1;
            this.button_Refesh.Text = "Refesh";
            this.button_Refesh.UseVisualStyleBackColor = false;
            this.button_Refesh.Click += new System.EventHandler(this.button_Refesh_Click);
            // 
            // button_NhapHang
            // 
            this.button_NhapHang.BackColor = System.Drawing.Color.DarkCyan;
            this.button_NhapHang.ForeColor = System.Drawing.Color.White;
            this.button_NhapHang.Location = new System.Drawing.Point(216, 459);
            this.button_NhapHang.Name = "button_NhapHang";
            this.button_NhapHang.Size = new System.Drawing.Size(108, 38);
            this.button_NhapHang.TabIndex = 2;
            this.button_NhapHang.Text = "Nhap Hang";
            this.button_NhapHang.UseVisualStyleBackColor = false;
            this.button_NhapHang.Click += new System.EventHandler(this.button_NhapHang_Click);
            // 
            // button_XuatExcel
            // 
            this.button_XuatExcel.BackColor = System.Drawing.Color.DarkCyan;
            this.button_XuatExcel.ForeColor = System.Drawing.Color.White;
            this.button_XuatExcel.Location = new System.Drawing.Point(357, 459);
            this.button_XuatExcel.Name = "button_XuatExcel";
            this.button_XuatExcel.Size = new System.Drawing.Size(102, 38);
            this.button_XuatExcel.TabIndex = 3;
            this.button_XuatExcel.Text = "Xuat Excel";
            this.button_XuatExcel.UseVisualStyleBackColor = false;
            this.button_XuatExcel.Click += new System.EventHandler(this.button_XuatExcel_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Xoa.ForeColor = System.Drawing.Color.White;
            this.button_Xoa.Location = new System.Drawing.Point(505, 459);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(184, 38);
            this.button_Xoa.TabIndex = 4;
            this.button_Xoa.Text = "Xoa San Pham Trong Kho";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(744, 509);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_XuatExcel);
            this.Controls.Add(this.button_NhapHang);
            this.Controls.Add(this.button_Refesh);
            this.Controls.Add(this.groupBox1);
            this.Name = "KhoHang";
            this.Text = "KhoHang";
            this.Load += new System.EventHandler(this.KhoHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachSPtrongKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_DanhSachSPtrongKho;
        private System.Windows.Forms.Button button_Refesh;
        private System.Windows.Forms.Button button_NhapHang;
        private System.Windows.Forms.Button button_XuatExcel;
        private System.Windows.Forms.Button button_Xoa;
    }
}