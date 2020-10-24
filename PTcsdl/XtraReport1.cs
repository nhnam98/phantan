using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PTcsdl
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1(String malop, String mamh,int lan)
        {
            InitializeComponent();
           
            tN_CSDLPTDS1.EnforceConstraints = false;
            this.sp_GetTranscriptTableAdapter.Fill(this.tN_CSDLPTDS1.sp_GetTranscript, malop, mamh, lan);
            lbgv.Text = Program.mHoten;
        }
      

    }
}
