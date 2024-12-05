using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LMSForCustomer
{
    public partial class frm_dangnhap : DevExpress.XtraEditors.XtraForm
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            frm_dangky frm = new frm_dangky();
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           Trangchu frm = new Trangchu();
            frm.Show();
        }
    }
}