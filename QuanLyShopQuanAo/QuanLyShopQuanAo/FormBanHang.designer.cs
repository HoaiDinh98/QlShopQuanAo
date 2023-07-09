namespace QuanLyShopQuanAo
{
    partial class FormBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Button_XacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_DSSP = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgv_cthd = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ComboBox_SPs = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Button_SP = new Guna.UI2.WinForms.Guna2Button();
            this.NumericUpDown_SLSP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_hd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComboBox_MaHd = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_DSSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cthd)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_SLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_XacNhan
            // 
            this.Button_XacNhan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_XacNhan.BorderColor = System.Drawing.Color.Transparent;
            this.Button_XacNhan.BorderRadius = 10;
            this.Button_XacNhan.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_XacNhan.FillColor = System.Drawing.Color.SlateBlue;
            this.Button_XacNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_XacNhan.ForeColor = System.Drawing.Color.White;
            this.Button_XacNhan.Location = new System.Drawing.Point(1013, 0);
            this.Button_XacNhan.Name = "Button_XacNhan";
            this.Button_XacNhan.Size = new System.Drawing.Size(118, 41);
            this.Button_XacNhan.TabIndex = 27;
            this.Button_XacNhan.Text = "Xác nhận";
            this.Button_XacNhan.Click += new System.EventHandler(this.Button_XacNhan_Click);
            // 
            // Panel_DSSP
            // 
            this.Panel_DSSP.Controls.Add(this.dtgv_cthd);
            this.Panel_DSSP.Controls.Add(this.guna2Panel2);
            this.Panel_DSSP.Controls.Add(this.guna2Panel1);
            this.Panel_DSSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_DSSP.Location = new System.Drawing.Point(0, 301);
            this.Panel_DSSP.Name = "Panel_DSSP";
            this.Panel_DSSP.Size = new System.Drawing.Size(1131, 333);
            this.Panel_DSSP.TabIndex = 29;
            // 
            // dtgv_cthd
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_cthd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_cthd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_cthd.ColumnHeadersHeight = 19;
            this.dtgv_cthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_cthd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_cthd.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_cthd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_cthd.Location = new System.Drawing.Point(9, 0);
            this.dtgv_cthd.Name = "dtgv_cthd";
            this.dtgv_cthd.RowHeadersVisible = false;
            this.dtgv_cthd.RowHeadersWidth = 51;
            this.dtgv_cthd.RowTemplate.Height = 24;
            this.dtgv_cthd.Size = new System.Drawing.Size(1122, 273);
            this.dtgv_cthd.TabIndex = 31;
            this.dtgv_cthd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_cthd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_cthd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_cthd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_cthd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_cthd.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_cthd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_cthd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgv_cthd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_cthd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_cthd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_cthd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_cthd.ThemeStyle.HeaderStyle.Height = 19;
            this.dtgv_cthd.ThemeStyle.ReadOnly = false;
            this.dtgv_cthd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_cthd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_cthd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_cthd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgv_cthd.ThemeStyle.RowsStyle.Height = 24;
            this.dtgv_cthd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_cthd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHD";
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MASP";
            this.Column2.HeaderText = "Mã Sản Phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SOLUONG";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DONGIA";
            this.Column4.HeaderText = "Đơn Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 282);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1131, 10);
            this.guna2Panel2.TabIndex = 30;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.Button_XacNhan);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 292);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1131, 41);
            this.guna2Panel1.TabIndex = 29;
            // 
            // ComboBox_SPs
            // 
            this.ComboBox_SPs.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_SPs.BorderRadius = 10;
            this.ComboBox_SPs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_SPs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_SPs.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox_SPs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_SPs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_SPs.FormattingEnabled = true;
            this.ComboBox_SPs.ItemHeight = 30;
            this.ComboBox_SPs.Location = new System.Drawing.Point(9, 209);
            this.ComboBox_SPs.Name = "ComboBox_SPs";
            this.ComboBox_SPs.Size = new System.Drawing.Size(336, 36);
            this.ComboBox_SPs.TabIndex = 30;
            this.ComboBox_SPs.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SPs_SelectedIndexChanged);
            // 
            // Button_SP
            // 
            this.Button_SP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_SP.BorderColor = System.Drawing.Color.Transparent;
            this.Button_SP.BorderRadius = 10;
            this.Button_SP.FillColor = System.Drawing.Color.SlateBlue;
            this.Button_SP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_SP.ForeColor = System.Drawing.Color.White;
            this.Button_SP.Location = new System.Drawing.Point(12, 171);
            this.Button_SP.Name = "Button_SP";
            this.Button_SP.Size = new System.Drawing.Size(118, 32);
            this.Button_SP.TabIndex = 31;
            this.Button_SP.Text = "Sản phẩm";
            // 
            // NumericUpDown_SLSP
            // 
            this.NumericUpDown_SLSP.BackColor = System.Drawing.Color.Transparent;
            this.NumericUpDown_SLSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericUpDown_SLSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumericUpDown_SLSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumericUpDown_SLSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumericUpDown_SLSP.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.NumericUpDown_SLSP.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.NumericUpDown_SLSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumericUpDown_SLSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown_SLSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NumericUpDown_SLSP.Location = new System.Drawing.Point(447, 103);
            this.NumericUpDown_SLSP.Name = "NumericUpDown_SLSP";
            this.NumericUpDown_SLSP.Size = new System.Drawing.Size(100, 36);
            this.NumericUpDown_SLSP.TabIndex = 33;
            this.NumericUpDown_SLSP.ValueChanged += new System.EventHandler(this.NumericUpDown_SLSP_ValueChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Them.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Them.BorderRadius = 10;
            this.btn_Them.FillColor = System.Drawing.Color.SlateBlue;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(429, 171);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(118, 36);
            this.btn_Them.TabIndex = 34;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.Button_Them_Click);
            // 
            // lbl_hd
            // 
            this.lbl_hd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hd.Location = new System.Drawing.Point(13, 50);
            this.lbl_hd.Name = "lbl_hd";
            this.lbl_hd.Size = new System.Drawing.Size(3, 2);
            this.lbl_hd.TabIndex = 36;
            this.lbl_hd.Text = null;
            // 
            // ComboBox_MaHd
            // 
            this.ComboBox_MaHd.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_MaHd.BorderRadius = 10;
            this.ComboBox_MaHd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_MaHd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_MaHd.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox_MaHd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_MaHd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_MaHd.FormattingEnabled = true;
            this.ComboBox_MaHd.ItemHeight = 30;
            this.ComboBox_MaHd.Location = new System.Drawing.Point(0, 103);
            this.ComboBox_MaHd.Name = "ComboBox_MaHd";
            this.ComboBox_MaHd.Size = new System.Drawing.Size(336, 36);
            this.ComboBox_MaHd.TabIndex = 38;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(12, 58);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(118, 32);
            this.guna2Button1.TabIndex = 39;
            this.guna2Button1.Text = "Hóa Đơn";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Xoa.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.BorderRadius = 10;
            this.btn_Xoa.FillColor = System.Drawing.Color.SlateBlue;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(637, 171);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(118, 36);
            this.btn_Xoa.TabIndex = 40;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Sua.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Sua.BorderRadius = 10;
            this.btn_Sua.FillColor = System.Drawing.Color.SlateBlue;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(850, 171);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(118, 36);
            this.btn_Sua.TabIndex = 41;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2Button4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(429, 58);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(118, 32);
            this.guna2Button4.TabIndex = 42;
            this.guna2Button4.Text = "Số Lượng";
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 634);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ComboBox_MaHd);
            this.Controls.Add(this.lbl_hd);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.NumericUpDown_SLSP);
            this.Controls.Add(this.Button_SP);
            this.Controls.Add(this.ComboBox_SPs);
            this.Controls.Add(this.Panel_DSSP);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.Panel_DSSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cthd)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_SLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Button_XacNhan;
        private Guna.UI2.WinForms.Guna2Panel Panel_DSSP;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_SPs;
        private Guna.UI2.WinForms.Guna2Button Button_SP;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericUpDown_SLSP;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_cthd;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_hd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_MaHd;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_Sua;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}