﻿namespace WindowsFormsApplication1
{
    partial class frmFlappyBird
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
            this.lblBird = new System.Windows.Forms.Label();
            this.lblCotTren1 = new System.Windows.Forms.Label();
            this.lblCotDuoi1 = new System.Windows.Forms.Label();
            this.lblCotDuoi2 = new System.Windows.Forms.Label();
            this.lblCotTren2 = new System.Windows.Forms.Label();
            this.lblCotTren3 = new System.Windows.Forms.Label();
            this.lblCotDuoi3 = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBird
            // 
            this.lblBird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBird.Location = new System.Drawing.Point(207, 190);
            this.lblBird.Name = "lblBird";
            this.lblBird.Size = new System.Drawing.Size(29, 23);
            this.lblBird.TabIndex = 0;
            this.lblBird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCotTren1
            // 
            this.lblCotTren1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotTren1.Location = new System.Drawing.Point(149, -91);
            this.lblCotTren1.Name = "lblCotTren1";
            this.lblCotTren1.Size = new System.Drawing.Size(40, 250);
            this.lblCotTren1.TabIndex = 1;
            // 
            // lblCotDuoi1
            // 
            this.lblCotDuoi1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotDuoi1.Location = new System.Drawing.Point(149, 227);
            this.lblCotDuoi1.Name = "lblCotDuoi1";
            this.lblCotDuoi1.Size = new System.Drawing.Size(40, 250);
            this.lblCotDuoi1.TabIndex = 2;
            // 
            // lblCotDuoi2
            // 
            this.lblCotDuoi2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotDuoi2.Location = new System.Drawing.Point(287, 227);
            this.lblCotDuoi2.Name = "lblCotDuoi2";
            this.lblCotDuoi2.Size = new System.Drawing.Size(40, 250);
            this.lblCotDuoi2.TabIndex = 4;
            // 
            // lblCotTren2
            // 
            this.lblCotTren2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotTren2.Location = new System.Drawing.Point(287, -91);
            this.lblCotTren2.Name = "lblCotTren2";
            this.lblCotTren2.Size = new System.Drawing.Size(40, 250);
            this.lblCotTren2.TabIndex = 3;
            // 
            // lblCotTren3
            // 
            this.lblCotTren3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotTren3.Location = new System.Drawing.Point(436, -91);
            this.lblCotTren3.Name = "lblCotTren3";
            this.lblCotTren3.Size = new System.Drawing.Size(40, 250);
            this.lblCotTren3.TabIndex = 3;
            // 
            // lblCotDuoi3
            // 
            this.lblCotDuoi3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCotDuoi3.Location = new System.Drawing.Point(436, 227);
            this.lblCotDuoi3.Name = "lblCotDuoi3";
            this.lblCotDuoi3.Size = new System.Drawing.Size(40, 250);
            this.lblCotDuoi3.TabIndex = 4;
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBatDau.Location = new System.Drawing.Point(9, 178);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(97, 45);
            this.btnBatDau.TabIndex = 5;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kí tự";
            // 
            // txtTu
            // 
            this.txtTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTu.Location = new System.Drawing.Point(49, 6);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(33, 22);
            this.txtTu.TabIndex = 0;
            this.txtTu.Text = "a";
            // 
            // txtDen
            // 
            this.txtDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDen.Location = new System.Drawing.Point(99, 6);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(30, 22);
            this.txtDen.TabIndex = 1;
            this.txtDen.Text = "z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Điểm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = ":";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(70, 100);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(32, 24);
            this.lblPoint.TabIndex = 14;
            this.lblPoint.Text = "00";
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnChoiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChoiLai.Location = new System.Drawing.Point(11, 178);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(97, 45);
            this.btnChoiLai.TabIndex = 15;
            this.btnChoiLai.Text = "Chơi lại";
            this.btnChoiLai.UseVisualStyleBackColor = false;
            this.btnChoiLai.Visible = false;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(11, 314);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 35);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmFlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(487, 361);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDen);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.lblCotDuoi3);
            this.Controls.Add(this.lblCotDuoi2);
            this.Controls.Add(this.lblCotTren3);
            this.Controls.Add(this.lblCotTren2);
            this.Controls.Add(this.lblCotDuoi1);
            this.Controls.Add(this.lblCotTren1);
            this.Controls.Add(this.lblBird);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frmFlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFlappyBird";
            this.Load += new System.EventHandler(this.frmFlappyBird_Load_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFlappyBird_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBird;
        private System.Windows.Forms.Label lblCotTren1;
        private System.Windows.Forms.Label lblCotDuoi1;
        private System.Windows.Forms.Label lblCotDuoi2;
        private System.Windows.Forms.Label lblCotTren2;
        private System.Windows.Forms.Label lblCotTren3;
        private System.Windows.Forms.Label lblCotDuoi3;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Button btnThoat;
    }
}