namespace DongHo
{
    partial class ChiTietHD
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
            this.dataGridView_ttkh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_dssp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_HuyDH = new System.Windows.Forms.Button();
            this.button_in = new System.Windows.Forms.Button();
            this.button_Lưu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ttkh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dssp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_ttkh);
            this.groupBox1.Location = new System.Drawing.Point(15, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(970, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // dataGridView_ttkh
            // 
            this.dataGridView_ttkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ttkh.Location = new System.Drawing.Point(8, 26);
            this.dataGridView_ttkh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_ttkh.Name = "dataGridView_ttkh";
            this.dataGridView_ttkh.RowHeadersWidth = 51;
            this.dataGridView_ttkh.RowTemplate.Height = 24;
            this.dataGridView_ttkh.Size = new System.Drawing.Size(955, 276);
            this.dataGridView_ttkh.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_dssp);
            this.groupBox2.Location = new System.Drawing.Point(23, 356);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(955, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách San Phẩm";
            // 
            // dataGridView_dssp
            // 
            this.dataGridView_dssp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dssp.Location = new System.Drawing.Point(8, 26);
            this.dataGridView_dssp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_dssp.Name = "dataGridView_dssp";
            this.dataGridView_dssp.RowHeadersWidth = 51;
            this.dataGridView_dssp.RowTemplate.Height = 24;
            this.dataGridView_dssp.Size = new System.Drawing.Size(940, 238);
            this.dataGridView_dssp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(326, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN HÓA ĐƠN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_HuyDH
            // 
            this.button_HuyDH.BackColor = System.Drawing.Color.DarkCyan;
            this.button_HuyDH.Location = new System.Drawing.Point(141, 628);
            this.button_HuyDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_HuyDH.Name = "button_HuyDH";
            this.button_HuyDH.Size = new System.Drawing.Size(168, 44);
            this.button_HuyDH.TabIndex = 3;
            this.button_HuyDH.Text = "Hủy Đơn Hàng";
            this.button_HuyDH.UseVisualStyleBackColor = false;
            this.button_HuyDH.Click += new System.EventHandler(this.button_HuyDH_Click);
            // 
            // button_in
            // 
            this.button_in.BackColor = System.Drawing.Color.DarkCyan;
            this.button_in.Location = new System.Drawing.Point(677, 628);
            this.button_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(168, 44);
            this.button_in.TabIndex = 4;
            this.button_in.Text = "In";
            this.button_in.UseVisualStyleBackColor = false;
            this.button_in.Click += new System.EventHandler(this.button_in_Click);
            // 
            // button_Lưu
            // 
            this.button_Lưu.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Lưu.Location = new System.Drawing.Point(447, 628);
            this.button_Lưu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Lưu.Name = "button_Lưu";
            this.button_Lưu.Size = new System.Drawing.Size(138, 44);
            this.button_Lưu.TabIndex = 5;
            this.button_Lưu.Text = "Lưu";
            this.button_Lưu.UseVisualStyleBackColor = false;
            this.button_Lưu.Click += new System.EventHandler(this.button_Lưu_Click);
            // 
            // ChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1000, 759);
            this.Controls.Add(this.button_Lưu);
            this.Controls.Add(this.button_in);
            this.Controls.Add(this.button_HuyDH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChiTietHD";
            this.Text = "ChiTietHD";
            this.Load += new System.EventHandler(this.ChiTietHD_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ttkh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dssp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_ttkh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_dssp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_HuyDH;
        private System.Windows.Forms.Button button_in;
        private System.Windows.Forms.Button button_Lưu;
    }
}