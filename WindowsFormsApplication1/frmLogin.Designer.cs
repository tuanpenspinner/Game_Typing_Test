namespace WindowsFormsApplication1
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsename = new System.Windows.Forms.Label();
            this.txtUsename = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btlDangNhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRememberPass = new System.Windows.Forms.CheckBox();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsename
            // 
            this.lblUsename.BackColor = System.Drawing.Color.DimGray;
            this.lblUsename.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsename.Image = ((System.Drawing.Image)(resources.GetObject("lblUsename.Image")));
            this.lblUsename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsename.Location = new System.Drawing.Point(30, 41);
            this.lblUsename.Name = "lblUsename";
            this.lblUsename.Size = new System.Drawing.Size(105, 20);
            this.lblUsename.TabIndex = 1;
            this.lblUsename.Text = "Usename\r\n";
            this.lblUsename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsename
            // 
            this.txtUsename.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsename.Location = new System.Drawing.Point(141, 41);
            this.txtUsename.Name = "txtUsename";
            this.txtUsename.Size = new System.Drawing.Size(183, 23);
            this.txtUsename.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(141, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(338, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btlDangNhap
            // 
            this.btlDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btlDangNhap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btlDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btlDangNhap.Image")));
            this.btlDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlDangNhap.Location = new System.Drawing.Point(211, 239);
            this.btlDangNhap.Name = "btlDangNhap";
            this.btlDangNhap.Size = new System.Drawing.Size(102, 43);
            this.btlDangNhap.TabIndex = 3;
            this.btlDangNhap.Text = "Đăng nhập";
            this.btlDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlDangNhap.UseVisualStyleBackColor = false;
            this.btlDangNhap.Click += new System.EventHandler(this.btlDangNhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsename);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUsename);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // chkRememberPass
            // 
            this.chkRememberPass.AutoSize = true;
            this.chkRememberPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberPass.Location = new System.Drawing.Point(86, 191);
            this.chkRememberPass.Name = "chkRememberPass";
            this.chkRememberPass.Size = new System.Drawing.Size(152, 29);
            this.chkRememberPass.TabIndex = 1;
            this.chkRememberPass.Text = "Nhớ mật khẩu";
            this.chkRememberPass.UseVisualStyleBackColor = true;
            // 
            // btnDangKi
            // 
            this.btnDangKi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDangKi.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKi.Image")));
            this.btnDangKi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKi.Location = new System.Drawing.Point(103, 239);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(102, 43);
            this.btnDangKi.TabIndex = 2;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = false;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 330);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.chkRememberPass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btlDangNhap);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlDangNhap;
        private System.Windows.Forms.Label lblUsename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsename;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRememberPass;
        private System.Windows.Forms.Button btnDangKi;
    }
}

