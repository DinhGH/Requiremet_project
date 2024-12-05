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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            passwordForm.Properties.UseSystemPasswordChar = true;
        }
    }
}