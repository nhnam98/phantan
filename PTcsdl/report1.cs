using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
namespace PTcsdl
{
    public partial class report1 : DevExpress.XtraEditors.XtraForm
    {

        String malop, mamh;
        int lan;
        public report1()
        {
            InitializeComponent();
           
        }

        private void report1_Load(object sender, EventArgs e)
        {
            tN_CSDLPTDS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDS.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDS.LOP);
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_CSDLPTDS.GIAOVIEN_DANGKY);
            cbTenlop.SelectedIndex = -1;
            cbTenMH.SelectedIndex = -1;


        }



        private void btnBaocao_Click(object sender, EventArgs e)
  
        {
          
         
             lan = Convert.ToInt32(txtLan.Text); ;
            XtraReport1 rp = new XtraReport1(malop,mamh,lan);
            rp.ShowPreviewDialog();
        }

        private void mASVLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mamh = "AVCB";
                mamh = cbTenMH.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void cbTenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                malop = "TH04";
                malop = cbTenlop.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}