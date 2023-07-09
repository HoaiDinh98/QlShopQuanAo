namespace QuanLyShopQuanAo
{
    partial class frm_KhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_DiaChiKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SDTKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbox_DSKH = new System.Windows.Forms.GroupBox();
            this.dtgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.btn_Thêm = new System.Windows.Forms.Button();
            this.btn_Xoá = new System.Windows.Forms.Button();
            this.btn_Sửa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpbox_DSKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(451, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_DiaChiKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_SDTKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_TenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MaKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txt_DiaChiKH
            // 
            this.txt_DiaChiKH.Location = new System.Drawing.Point(740, 104);
            this.txt_DiaChiKH.Name = "txt_DiaChiKH";
            this.txt_DiaChiKH.Size = new System.Drawing.Size(308, 27);
            this.txt_DiaChiKH.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "ĐỊA CHỈ";
            // 
            // txt_SDTKH
            // 
            this.txt_SDTKH.Location = new System.Drawing.Point(740, 50);
            this.txt_SDTKH.Name = "txt_SDTKH";
            this.txt_SDTKH.Size = new System.Drawing.Size(308, 27);
            this.txt_SDTKH.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "SỐ ĐIỆN THOẠI";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(200, 109);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(304, 27);
            this.txt_TenKH.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "TÊN KHÁCH HÀNG ";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(200, 50);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(304, 27);
            this.txt_MaKH.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "MÃ KHÁCH HÀNG";
            // 
            // grpbox_DSKH
            // 
            this.grpbox_DSKH.Controls.Add(this.dtgv_KhachHang);
            this.grpbox_DSKH.Location = new System.Drawing.Point(24, 358);
            this.grpbox_DSKH.Name = "grpbox_DSKH";
            this.grpbox_DSKH.Size = new System.Drawing.Size(1060, 333);
            this.grpbox_DSKH.TabIndex = 2;
            this.grpbox_DSKH.TabStop = false;
            this.grpbox_DSKH.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // dtgv_KhachHang
            // 
            this.dtgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_KhachHang.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dtgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_KhachHang.Location = new System.Drawing.Point(6, 26);
            this.dtgv_KhachHang.Name = "dtgv_KhachHang";
            this.dtgv_KhachHang.RowHeadersWidth = 51;
            this.dtgv_KhachHang.RowTemplate.Height = 24;
            this.dtgv_KhachHang.Size = new System.Drawing.Size(1048, 289);
            this.dtgv_KhachHang.TabIndex = 0;
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Thêm.Location = new System.Drawing.Point(253, 281);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(101, 67);
            this.btn_Thêm.TabIndex = 3;
            this.btn_Thêm.Text = "THÊM";
            this.btn_Thêm.UseVisualStyleBackColor = false;
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // btn_Xoá
            // 
            this.btn_Xoá.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Xoá.Location = new System.Drawing.Point(497, 281);
            this.btn_Xoá.Name = "btn_Xoá";
            this.btn_Xoá.Size = new System.Drawing.Size(99, 67);
            this.btn_Xoá.TabIndex = 4;
            this.btn_Xoá.Text = "XOÁ";
            this.btn_Xoá.UseVisualStyleBackColor = false;
            this.btn_Xoá.Click += new System.EventHandler(this.btn_Xoá_Click);
            // 
            // btn_Sửa
            // 
            this.btn_Sửa.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Sửa.Location = new System.Drawing.Point(730, 281);
            this.btn_Sửa.Name = "btn_Sửa";
            this.btn_Sửa.Size = new System.Drawing.Size(94, 71);
            this.btn_Sửa.TabIndex = 5;
            this.btn_Sửa.Text = "SỬA";
            this.btn_Sửa.UseVisualStyleBackColor = false;
            this.btn_Sửa.Click += new System.EventHandler(this.btn_Sửa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Location = new System.Drawing.Point(932, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm Kiếm ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1194, 734);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Sửa);
            this.Controls.Add(this.btn_Xoá);
            this.Controls.Add(this.btn_Thêm);
            this.Controls.Add(this.grpbox_DSKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_KhachHang";
            this.Text = "Quản lý khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_KhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbox_DSKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbox_DSKH;
        private System.Windows.Forms.DataGridView dtgv_KhachHang;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.Button btn_Xoá;
        private System.Windows.Forms.Button btn_Sửa;
        private System.Windows.Forms.TextBox txt_DiaChiKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SDTKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}