﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LMSForAdmin
{
    public partial class frm_dangnhap : DevExpress.XtraEditors.XtraForm
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            RibbonForm1 frm = new RibbonForm1();
            frm.Show();
        }
    }
}