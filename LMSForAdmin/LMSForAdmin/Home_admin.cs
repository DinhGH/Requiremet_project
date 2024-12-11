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
            frm_sodophong frm_Sodophong = new frm_sodophong();
            frm_Sodophong.MdiParent = this;
            frm_Sodophong.Show();
        }

        private void Home_admin_Load(object sender, EventArgs e)
        {

        }

        private void imageEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_phongcandondep frm_Phongcandondep = new frm_phongcandondep();
            frm_Phongcandondep.MdiParent = this;
            frm_Phongcandondep.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_dsycdv frm_Dsycdv = new frm_dsycdv();
            frm_Dsycdv.MdiParent = this;
            frm_Dsycdv.Show();

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_quanlibcsc frm_Quanlibcsc = new frm_quanlibcsc();
            frm_Quanlibcsc.MdiParent = this;
            frm_Quanlibcsc.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_xuathang frm_Xuathang = new frm_xuathang();
            frm_Xuathang.MdiParent = this;
            frm_Xuathang.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabbedMdiManager1.MdiParent = this;
            frm_nhaphang frm_Nhaphang = new frm_nhaphang();
            frm_Nhaphang.MdiParent = this;
            frm_Nhaphang.Show();
        }
    }
}