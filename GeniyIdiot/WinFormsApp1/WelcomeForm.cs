﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.OK;
        }

        //private void WelcomeForm_Load(object sender, EventArgs e)
        //{
        //    if (DialogResult == DialogResult.Cancel)
        //    {
        //        Application.Exit();
        //    }
        //}
    }
}
