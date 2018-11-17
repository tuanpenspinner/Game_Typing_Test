namespace WindowsFormsApplication1
{
    partial class frmCharFallOut
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnChoi = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.lblChar = new System.Windows.Forms.Label();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(139, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 13);
            this.lblText.TabIndex = 0;
            // 
            // btnChoi
            // 
            this.btnChoi.AutoSize = true;
            this.btnChoi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoi.Location = new System.Drawing.Point(45, 386);
            this.btnChoi.Name = "btnChoi";
            this.btnChoi.Size = new System.Drawing.Size(75, 35);
            this.btnChoi.TabIndex = 1;
            this.btnChoi.Text = "Chơi";
            this.btnChoi.UseVisualStyleBackColor = false;
            this.btnChoi.Click += new System.EventHandler(this.btnChoi_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.lblChar);
            this.panel.Controls.Add(this.lblText);
            this.panel.Location = new System.Drawing.Point(101, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(444, 330);
            this.panel.TabIndex = 2;
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChar.Location = new System.Drawing.Point(205, -1);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(38, 55);
            this.lblChar.TabIndex = 1;
            this.lblChar.Text = "f";
            this.lblChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.AutoSize = true;
            this.btnChoiLai.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChoiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiLai.Location = new System.Drawing.Point(150, 386);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(102, 35);
            this.btnChoiLai.TabIndex = 3;
            this.btnChoiLai.Text = "Chơi lại";
            this.btnChoiLai.UseVisualStyleBackColor = false;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm:";
            // 
            // lblDiem
            // 
            this.lblDiem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.Location = new System.Drawing.Point(633, 68);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(36, 25);
            this.lblDiem.TabIndex = 5;
            this.lblDiem.Text = "00";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(580, 386);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 35);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(403, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 49);
            this.textBox1.TabIndex = 7;
            // 
            // frmCharFallOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 433);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnChoi);
            this.Name = "frmCharFallOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextFallOut";
            this.Load += new System.EventHandler(this.frmTextFallOut_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnChoi;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}