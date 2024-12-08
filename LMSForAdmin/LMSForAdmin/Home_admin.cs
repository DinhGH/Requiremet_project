using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace LMSForAdmin
{
    public partial class Home_admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Home_admin()
        {
            InitializeComponent();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_dangnhap frm_Dangnhap = new frm_dangnhap();
            frm_Dangnhap.MdiParent = this;
            frm_Dangnhap.Show();
        }

        private void Home_admin_Load(object sender, EventArgs e)
        {

        }

        private void imageEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}