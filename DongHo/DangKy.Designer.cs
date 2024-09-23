namespace DongHo
{
    partial class DangKy
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
            this.textBox_TK = new System.Windows.Forms.TextBox();
            this.textBox_MK = new System.Windows.Forms.TextBox();
            this.textBox_XNMK = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_DangKy = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_TK
            // 
            this.textBox_TK.Location = new System.Drawing.Point(192, 223);
            this.textBox_TK.Name = "textBox_TK";
            this.textBox_TK.Size = new System.Drawing.Size(291, 22);
            this.textBox_TK.TabIndex = 0;
            // 
            // textBox_MK
            // 
            this.textBox_MK.Location = new System.Drawing.Point(192, 271);
            this.textBox_MK.Name = "textBox_MK";
            this.textBox_MK.Size = new System.Drawing.Size(291, 22);
            this.textBox_MK.TabIndex = 1;
            // 
            // textBox_XNMK
            // 
            this.textBox_XNMK.Location = new System.Drawing.Point(192, 316);
            this.textBox_XNMK.Name = "textBox_XNMK";
            this.textBox_XNMK.Size = new System.Drawing.Size(291, 22);
            this.textBox_XNMK.TabIndex = 2;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(192, 363);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(291, 22);
            this.textBox_Email.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Xác Nhận Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // button_DangKy
            // 
            this.button_DangKy.BackColor = System.Drawing.Color.DarkCyan;
            this.button_DangKy.Location = new System.Drawing.Point(192, 415);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(114, 40);
            this.button_DangKy.TabIndex = 8;
            this.button_DangKy.Text = "Đăng Ký";
            this.button_DangKy.UseVisualStyleBackColor = false;
            this.button_DangKy.Click += new System.EventHandler(this.button_DangKy_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.button_cancel.Location = new System.Drawing.Point(369, 415);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(114, 40);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Trở Về";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DongHo.Properties.Resources.tranh_treo_trang_tri_tuong_phong_ngu_gaming;
            this.pictureBox1.Location = new System.Drawing.Point(56, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(540, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_DangKy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_XNMK);
            this.Controls.Add(this.textBox_MK);
            this.Controls.Add(this.textBox_TK);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox_MK;
        private System.Windows.Forms.TextBox textBox_XNMK;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_DangKy;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}