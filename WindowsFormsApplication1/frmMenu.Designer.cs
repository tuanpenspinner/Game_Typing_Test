namespace WindowsFormsApplication1
{
    partial class frmMenu
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
            this.btnSpeedTest = new System.Windows.Forms.Button();
            this.btnTyPingGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTestABC = new System.Windows.Forms.Button();
            this.btnTextPractice = new System.Windows.Forms.Button();
            this.btnFlappyBird = new System.Windows.Forms.Button();
            this.btnCharFallOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpeedTest
            // 
            this.btnSpeedTest.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSpeedTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedTest.ForeColor = System.Drawing.Color.Navy;
            this.btnSpeedTest.Location = new System.Drawing.Point(47, 125);
            this.btnSpeedTest.Name = "btnSpeedTest";
            this.btnSpeedTest.Size = new System.Drawing.Size(263, 47);
            this.btnSpeedTest.TabIndex = 0;
            this.btnSpeedTest.Text = "Speed Test";
            this.btnSpeedTest.UseVisualStyleBackColor = false;
            this.btnSpeedTest.Click += new System.EventHandler(this.btnSpeedTest_Click);
            // 
            // btnTyPingGame
            // 
            this.btnTyPingGame.AutoSize = true;
            this.btnTyPingGame.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTyPingGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyPingGame.ForeColor = System.Drawing.Color.Navy;
            this.btnTyPingGame.Location = new System.Drawing.Point(47, 310);
            this.btnTyPingGame.Name = "btnTyPingGame";
            this.btnTyPingGame.Size = new System.Drawing.Size(263, 52);
            this.btnTyPingGame.TabIndex = 1;
            this.btnTyPingGame.Text = "Typing Game";
            this.btnTyPingGame.UseVisualStyleBackColor = false;
            this.btnTyPingGame.Click += new System.EventHandler(this.btnTyPingGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(285, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Typing Game";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSize = true;
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Navy;
            this.btnDangXuat.Location = new System.Drawing.Point(685, 396);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(208, 53);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTestABC
            // 
            this.btnTestABC.AutoSize = true;
            this.btnTestABC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTestABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestABC.Location = new System.Drawing.Point(340, 125);
            this.btnTestABC.Name = "btnTestABC";
            this.btnTestABC.Size = new System.Drawing.Size(142, 47);
            this.btnTestABC.TabIndex = 4;
            this.btnTestABC.Text = "TestABC";
            this.btnTestABC.UseVisualStyleBackColor = false;
            this.btnTestABC.Click += new System.EventHandler(this.btnTestABC_Click);
            // 
            // btnTextPractice
            // 
            this.btnTextPractice.AutoSize = true;
            this.btnTextPractice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTextPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextPractice.Location = new System.Drawing.Point(340, 195);
            this.btnTextPractice.Name = "btnTextPractice";
            this.btnTextPractice.Size = new System.Drawing.Size(142, 47);
            this.btnTextPractice.TabIndex = 5;
            this.btnTextPractice.Text = "Text Practice";
            this.btnTextPractice.UseVisualStyleBackColor = false;
            this.btnTextPractice.Click += new System.EventHandler(this.btnTextPractice_Click);
            // 
            // btnFlappyBird
            // 
            this.btnFlappyBird.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFlappyBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlappyBird.Location = new System.Drawing.Point(340, 316);
            this.btnFlappyBird.Name = "btnFlappyBird";
            this.btnFlappyBird.Size = new System.Drawing.Size(142, 47);
            this.btnFlappyBird.TabIndex = 6;
            this.btnFlappyBird.Text = "FlappyBird";
            this.btnFlappyBird.UseVisualStyleBackColor = false;
            this.btnFlappyBird.Click += new System.EventHandler(this.btnFlappyBird_Click);
            // 
            // btnCharFallOut
            // 
            this.btnCharFallOut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCharFallOut.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnCharFallOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharFallOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCharFallOut.Location = new System.Drawing.Point(340, 385);
            this.btnCharFallOut.Name = "btnCharFallOut";
            this.btnCharFallOut.Size = new System.Drawing.Size(142, 47);
            this.btnCharFallOut.TabIndex = 7;
            this.btnCharFallOut.Text = "CharFallOut";
            this.btnCharFallOut.UseVisualStyleBackColor = false;
            this.btnCharFallOut.Click += new System.EventHandler(this.btnCharFallOut_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 470);
            this.Controls.Add(this.btnCharFallOut);
            this.Controls.Add(this.btnFlappyBird);
            this.Controls.Add(this.btnTextPractice);
            this.Controls.Add(this.btnTestABC);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTyPingGame);
            this.Controls.Add(this.btnSpeedTest);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeedTest;
        private System.Windows.Forms.Button btnTyPingGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTestABC;
        private System.Windows.Forms.Button btnTextPractice;
        private System.Windows.Forms.Button btnFlappyBird;
        private System.Windows.Forms.Button btnCharFallOut;
    }
}