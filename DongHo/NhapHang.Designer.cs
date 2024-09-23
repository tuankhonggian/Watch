namespace DongHo
{
    partial class NhapHang
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
            this.dataGridView_danhsachsanphamnhap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.button_Nhap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhsachsanphamnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.dataGridView_danhsachsanphamnhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "danh sach san pham";
            // 
            // dataGridView_danhsachsanphamnhap
            // 
            this.dataGridView_danhsachsanphamnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_danhsachsanphamnhap.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_danhsachsanphamnhap.Name = "dataGridView_danhsachsanphamnhap";
            this.dataGridView_danhsachsanphamnhap.RowHeadersWidth = 51;
            this.dataGridView_danhsachsanphamnhap.RowTemplate.Height = 24;
            this.dataGridView_danhsachsanphamnhap.Size = new System.Drawing.Size(764, 307);
            this.dataGridView_danhsachsanphamnhap.TabIndex = 0;
            this.dataGridView_danhsachsanphamnhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_danhsachsanphamnhap_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số lượng nhập";
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.Location = new System.Drawing.Point(356, 379);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(166, 22);
            this.textBox_SoLuong.TabIndex = 2;
            // 
            // button_Nhap
            // 
            this.button_Nhap.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Nhap.ForeColor = System.Drawing.Color.White;
            this.button_Nhap.Location = new System.Drawing.Point(528, 378);
            this.button_Nhap.Name = "button_Nhap";
            this.button_Nhap.Size = new System.Drawing.Size(75, 23);
            this.button_Nhap.TabIndex = 3;
            this.button_Nhap.Text = "Nhap";
            this.button_Nhap.UseVisualStyleBackColor = false;
            this.button_Nhap.Click += new System.EventHandler(this.button_Nhap_Click);
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Nhap);
            this.Controls.Add(this.textBox_SoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhsachsanphamnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_danhsachsanphamnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.Button button_Nhap;
    }
}