﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnTestABC_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmSpeedTestABC frm = new frmSpeedTestABC();
            frm.ShowDialog();
         
        }

        private void btnTextPractice_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmTypingTest frm = new frmTypingTest();
            frm.ShowDialog();
           
        }

        private void btnFlappyBird_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmFlappyBird frm = new frmFlappyBird();
            frm.ShowDialog();
           
        }

        private void btnCharFallOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmCharFallOut frm = new frmCharFallOut();
            frm.ShowDialog();
            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            btnCharFallOut.Visible = false;
            btnFlappyBird.Visible = false;

            btnTestABC.Visible = false;
            btnTextPractice.Visible = false;
        }

        private void btnSpeedTest_Click(object sender, EventArgs e)
        {
            btnTestABC.Visible = true;
            btnTextPractice.Visible = true;

            btnCharFallOut.Visible = false;
            btnFlappyBird.Visible = false;

        }

        private void btnTyPingGame_Click(object sender, EventArgs e)
        {
            btnTestABC.Visible = false;
            btnTextPractice.Visible = false;

            btnCharFallOut.Visible = true;
            btnFlappyBird.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
