
namespace QuanLyShopQuanAo
{
    partial class frm_TìmKiemKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TìmKiemKhachHang));
            this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
            this.pboTimKiem = new System.Windows.Forms.PictureBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLichLamViec = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvKhachHang
            // 
            this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachHang.Location = new System.Drawing.Point(31, 163);
            this.dtgvKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvKhachHang.Name = "dtgvKhachHang";
            this.dtgvKhachHang.RowHeadersWidth = 51;
            this.dtgvKhachHang.Size = new System.Drawing.Size(931, 308);
            this.dtgvKhachHang.TabIndex = 55;
            // 
            // pboTimKiem
            // 
            this.pboTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboTimKiem.BackgroundImage")));
            this.pboTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboTimKiem.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pboTimKiem.ErrorImage")));
            this.pboTimKiem.Location = new System.Drawing.Point(694, 97);
            this.pboTimKiem.Name = "pboTimKiem";
            this.pboTimKiem.Size = new System.Drawing.Size(30, 37);
            this.pboTimKiem.TabIndex = 129;
            this.pboTimKiem.TabStop = false;
            this.pboTimKiem.Click += new System.EventHandler(this.pboTimKiem_Click);
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhach.Location = new System.Drawing.Point(341, 97);
            this.txtTenKhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhach.Multiline = true;
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(337, 37);
            this.txtTenKhach.TabIndex = 128;
            this.txtTenKhach.TextChanged += new System.EventHandler(this.txtTenKhach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 27);
            this.label1.TabIndex = 131;
            this.label1.Text = "Nhập họ và tên khách hàng";
            // 
            // lblLichLamViec
            // 
            this.lblLichLamViec.AutoSize = true;
            this.lblLichLamViec.BackColor = System.Drawing.Color.Transparent;
            this.lblLichLamViec.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichLamViec.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblLichLamViec.Location = new System.Drawing.Point(181, 18);
            this.lblLichLamViec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLichLamViec.Name = "lblLichLamViec";
            this.lblLichLamViec.Size = new System.Drawing.Size(604, 45);
            this.lblLichLamViec.TabIndex = 130;
            this.lblLichLamViec.Text = "Tìm Kiếm Thông Tin Khách Hàng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRefresh.Location = new System.Drawing.Point(759, 100);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 34);
            this.btnRefresh.TabIndex = 132;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frm_TìmKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1044, 569);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLichLamViec);
            this.Controls.Add(this.pboTimKiem);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.dtgvKhachHang);
            this.Name = "frm_TìmKiemKhachHang";
            this.Text = "frm_TimKiemKhachHang";
            this.Load += new System.EventHandler(this.frm_TìmKiemKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvKhachHang;
        private System.Windows.Forms.PictureBox pboTimKiem;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLichLamViec;
        private System.Windows.Forms.Button btnRefresh;
    }
}