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
           Home_admin home_Admin = new Home_admin();
            home_Admin.Show();
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}