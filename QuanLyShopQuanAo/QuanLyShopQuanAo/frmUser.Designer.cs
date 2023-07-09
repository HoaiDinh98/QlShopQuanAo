namespace QuanLyShopQuanAo
{
    partial class frmUser
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_kh = new Guna.UI2.WinForms.Guna2Button();
            this.btn_hanghoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dangxuat = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_logo = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_banhang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel_body1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Indigo;
            this.guna2Panel1.Controls.Add(this.Panel_logo);
            this.guna2Panel1.Controls.Add(this.btn_kh);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.btn_hanghoa);
            this.guna2Panel1.Controls.Add(this.btn_dangxuat);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(233, 662);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btn_kh
            // 
            this.btn_kh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_kh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_kh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_kh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_kh.FillColor = System.Drawing.Color.Indigo;
            this.btn_kh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kh.ForeColor = System.Drawing.Color.White;
            this.btn_kh.Location = new System.Drawing.Point(3, 316);
            this.btn_kh.Name = "btn_kh";
            this.btn_kh.Size = new System.Drawing.Size(226, 85);
            this.btn_kh.TabIndex = 1;
            this.btn_kh.Text = "Khách Hàng";
            this.btn_kh.Click += new System.EventHandler(this.btn_kh_Click);
            // 
            // btn_hanghoa
            // 
            this.btn_hanghoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hanghoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hanghoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hanghoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hanghoa.FillColor = System.Drawing.Color.Indigo;
            this.btn_hanghoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hanghoa.ForeColor = System.Drawing.Color.White;
            this.btn_hanghoa.Location = new System.Drawing.Point(0, 238);
            this.btn_hanghoa.Name = "btn_hanghoa";
            this.btn_hanghoa.Size = new System.Drawing.Size(229, 72);
            this.btn_hanghoa.TabIndex = 0;
            this.btn_hanghoa.Text = "Hàng Hóa";
            this.btn_hanghoa.Click += new System.EventHandler(this.btn_hanghoa_Click);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangxuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangxuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dangxuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dangxuat.FillColor = System.Drawing.Color.Indigo;
            this.btn_dangxuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dangxuat.ForeColor = System.Drawing.Color.White;
            this.btn_dangxuat.Location = new System.Drawing.Point(20, 480);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(180, 45);
            this.btn_dangxuat.TabIndex = 8;
            this.btn_dangxuat.Text = "Đăng Xuất";
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // Panel_logo
            // 
            this.Panel_logo.BackColor = System.Drawing.Color.Indigo;
            this.Panel_logo.BackgroundImage = global::QuanLyShopQuanAo.Properties.Resources.icon_banHang;
            this.Panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_logo.Name = "Panel_logo";
            this.Panel_logo.Size = new System.Drawing.Size(233, 130);
            this.Panel_logo.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btn_banhang);
            this.guna2Panel2.Controls.Add(this.guna2Button2);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 150);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(229, 82);
            this.guna2Panel2.TabIndex = 8;
            // 
            // btn_banhang
            // 
            this.btn_banhang.BackColor = System.Drawing.Color.Indigo;
            this.btn_banhang.BorderColor = System.Drawing.Color.White;
            this.btn_banhang.FillColor = System.Drawing.Color.Transparent;
            this.btn_banhang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_banhang.ForeColor = System.Drawing.Color.White;
            this.btn_banhang.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_banhang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_banhang.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_banhang.Location = new System.Drawing.Point(0, -12);
            this.btn_banhang.Margin = new System.Windows.Forms.Padding(5);
            this.btn_banhang.Name = "btn_banhang";
            this.btn_banhang.PressedColor = System.Drawing.Color.Transparent;
            this.btn_banhang.PressedDepth = 40;
            this.btn_banhang.Size = new System.Drawing.Size(229, 82);
            this.btn_banhang.TabIndex = 4;
            this.btn_banhang.Text = "Bán hàng";
            this.btn_banhang.Click += new System.EventHandler(this.btn_banhang_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Indigo;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button2.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.Location = new System.Drawing.Point(0, 0);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button2.PressedDepth = 40;
            this.guna2Button2.Size = new System.Drawing.Size(229, 82);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Bán hàng";
            // 
            // panel_body1
            // 
            this.panel_body1.BackgroundImage = global::QuanLyShopQuanAo.Properties.Resources.tao_logo_shop_quan_ao_ny;
            this.panel_body1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_body1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body1.Location = new System.Drawing.Point(242, 3);
            this.panel_body1.Name = "panel_body1";
            this.panel_body1.Size = new System.Drawing.Size(1106, 662);
            this.panel_body1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.76462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.23538F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_body1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1351, 668);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 668);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel_logo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btn_banhang;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btn_kh;
        private Guna.UI2.WinForms.Guna2Button btn_hanghoa;
        private Guna.UI2.WinForms.Guna2Button btn_dangxuat;
        private Guna.UI2.WinForms.Guna2Panel panel_body1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}