//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Windows.Forms;

namespace MVPAPP
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        public Form1() { InitializeComponent(); }

        private void simpleButton1_Click(object sender, EventArgs e) { MessageBox.Show("1"); }

        private void simpleButton2_Click(object sender, EventArgs e) { MessageBox.Show("2"); }

        private void simpleButton3_Click(object sender, EventArgs e) { MessageBox.Show("3"); }
    }
}
