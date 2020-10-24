using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace PTcsdl
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKHGV f = new frmKHGV();
            f.Show();
            this.Hide();
            f.FormClosed += (o, w) => this.Show();
        }

        private void lopsv_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLOPSV f = new frmLOPSV();
            f.Show();
            this.Hide();
            f.FormClosed += (o, w) => this.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTaologin f = new frmTaologin();
            f.Show();
            this.Hide();
            f.FormClosed += (o, w) => this.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            report1 f = new report1();
            f.Show();
            this.Hide();
            f.FormClosed += (o, w) => this.Show();
        }
    }
}