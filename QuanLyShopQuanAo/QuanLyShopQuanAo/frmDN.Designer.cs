
namespace QuanLyShopQuanAo
{
    partial class frmDN
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
            this.txt_tenDN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.chk_pass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_thoat = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // txt_tenDN
            // 
            this.txt_tenDN.BorderRadius = 6;
            this.txt_tenDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenDN.DefaultText = "chau";
            this.txt_tenDN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenDN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenDN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenDN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tenDN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenDN.Location = new System.Drawing.Point(93, 207);
            this.txt_tenDN.Name = "txt_tenDN";
            this.txt_tenDN.PasswordChar = '\0';
            this.txt_tenDN.PlaceholderText = "";
            this.txt_tenDN.SelectedText = "";
            this.txt_tenDN.Size = new System.Drawing.Size(200, 36);
            this.txt_tenDN.TabIndex = 3;
            this.txt_tenDN.TextChanged += new System.EventHandler(this.txt_tenDN_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.BorderRadius = 6;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.DefaultText = "123";
            this.txt_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.Location = new System.Drawing.Point(93, 317);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.PlaceholderText = "";
            this.txt_pass.SelectedText = "";
            this.txt_pass.Size = new System.Drawing.Size(200, 36);
            this.txt_pass.TabIndex = 4;
            // 
            // chk_pass
            // 
            this.chk_pass.AutoSize = true;
            this.chk_pass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_pass.CheckedState.BorderRadius = 0;
            this.chk_pass.CheckedState.BorderThickness = 0;
            this.chk_pass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.chk_pass.ForeColor = System.Drawing.Color.Black;
            this.chk_pass.Location = new System.Drawing.Point(93, 387);
            this.chk_pass.Name = "chk_pass";
            this.chk_pass.Size = new System.Drawing.Size(137, 20);
            this.chk_pass.TabIndex = 5;
            this.chk_pass.Text = "Hiển Thị Mật Khẩu";
            this.chk_pass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chk_pass.UncheckedState.BorderRadius = 0;
            this.chk_pass.UncheckedState.BorderThickness = 0;
            this.chk_pass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_pass.CheckedChanged += new System.EventHandler(this.chk_pass_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BorderColor = System.Drawing.Color.SlateBlue;
            this.btn_login.BorderRadius = 6;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.FillColor = System.Drawing.Color.SlateBlue;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(102, 518);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(200, 47);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(94, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "    LOG IN       ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label2.Location = new System.Drawing.Point(89, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label3.Location = new System.Drawing.Point(89, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "UserName:";
            // 
            // lbl_thoat
            // 
            this.lbl_thoat.AutoSize = true;
            this.lbl_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thoat.Location = new System.Drawing.Point(424, 0);
            this.lbl_thoat.Name = "lbl_thoat";
            this.lbl_thoat.Size = new System.Drawing.Size(24, 29);
            this.lbl_thoat.TabIndex = 10;
            this.lbl_thoat.Text = "x";
            this.lbl_thoat.Click += new System.EventHandler(this.lbl_thoat_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(28, 448);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(115, 18);
            this.guna2HtmlLabel1.TabIndex = 11;
            this.guna2HtmlLabel1.Text = "Quên Mật Khẩu";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(249, 448);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(140, 18);
            this.guna2HtmlLabel2.TabIndex = 12;
            this.guna2HtmlLabel2.Text = "Đăng Ký  Tài Khoản";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // frmDN
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 660);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lbl_thoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.chk_pass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_tenDN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 600);
            this.Name = "frmDN";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R";
            this.Load += new System.EventHandler(this.frmDN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_tenDN;
        private Guna.UI2.WinForms.Guna2TextBox txt_pass;
        private Guna.UI2.WinForms.Guna2CheckBox chk_pass;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_thoat;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}

