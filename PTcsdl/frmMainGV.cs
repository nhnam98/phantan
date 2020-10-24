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
    public partial class frmMainGV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMainGV()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBODE f = new frmBODE();
            f.Show();
            this.Hide();
            f.FormClosed += (o, w) => this.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDKTHI f = new frmDKTHI();
            f.Show();
            this.Hide();
            f.FormClosed += (o, w) => this.Show();
        }
    }
}