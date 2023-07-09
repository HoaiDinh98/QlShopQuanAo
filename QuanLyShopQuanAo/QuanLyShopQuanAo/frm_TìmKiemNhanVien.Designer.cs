
namespace QuanLyShopQuanAo
{
    partial class frm_TìmKiemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TìmKiemNhanVien));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLichLamViec = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.pboTimKiem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRefresh.Location = new System.Drawing.Point(858, 108);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 34);
            this.btnRefresh.TabIndex = 138;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 27);
            this.label1.TabIndex = 137;
            this.label1.Text = "Nhập họ và tên Nhân Viên";
            // 
            // lblLichLamViec
            // 
            this.lblLichLamViec.AutoSize = true;
            this.lblLichLamViec.BackColor = System.Drawing.Color.Transparent;
            this.lblLichLamViec.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichLamViec.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblLichLamViec.Location = new System.Drawing.Point(280, 26);
            this.lblLichLamViec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLichLamViec.Name = "lblLichLamViec";
            this.lblLichLamViec.Size = new System.Drawing.Size(569, 45);
            this.lblLichLamViec.TabIndex = 136;
            this.lblLichLamViec.Text = "Tìm Kiếm Thông Tin Nhân Viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(440, 105);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(337, 37);
            this.txtTenNV.TabIndex = 134;
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Location = new System.Drawing.Point(130, 171);
            this.dtgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.RowHeadersWidth = 51;
            this.dtgvNhanVien.Size = new System.Drawing.Size(931, 308);
            this.dtgvNhanVien.TabIndex = 133;
            // 
            // pboTimKiem
            // 
            this.pboTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboTimKiem.BackgroundImage")));
            this.pboTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboTimKiem.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pboTimKiem.ErrorImage")));
            this.pboTimKiem.Location = new System.Drawing.Point(793, 105);
            this.pboTimKiem.Name = "pboTimKiem";
            this.pboTimKiem.Size = new System.Drawing.Size(30, 37);
            this.pboTimKiem.TabIndex = 135;
            this.pboTimKiem.TabStop = false;
            this.pboTimKiem.Click += new System.EventHandler(this.pboTimKiem_Click);
            // 
            // frm_TìmKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 505);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLichLamViec);
            this.Controls.Add(this.pboTimKiem);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.dtgvNhanVien);
            this.Name = "frm_TìmKiemNhanVien";
            this.Text = "frm_TìmKiemNhanVien";
            this.Load += new System.EventHandler(this.frm_TìmKiemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLichLamViec;
        private System.Windows.Forms.PictureBox pboTimKiem;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
    }
}