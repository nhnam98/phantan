using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTcsdl
{
    public partial class frmDKTHI : Form
    {
        private int vitri;
        public frmDKTHI()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDS);

        }

        private void frmDKTHI_Load(object sender, EventArgs e)
        {
           tN_CSDLPTDS.EnforceConstraints = false;
         
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_CSDLPTDS.GIAOVIEN_DANGKY);

        }

        private void lANLabel_Click(object sender, EventArgs e)
        {

        }

        private void lANSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            vitri = gIAOVIEN_DANGKYBindingSource.Position;
            gIAOVIEN_DANGKYBindingSource.AddNew();
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
               gIAOVIEN_DANGKYBindingSource.EndEdit();
                gIAOVIEN_DANGKYBindingSource.ResetCurrentItem();
                this.gIAOVIEN_DANGKYTableAdapter.Update(this.tN_CSDLPTDS.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn xóa???", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    gIAOVIEN_DANGKYBindingSource.RemoveCurrent();
                   // this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.tN_CSDLPTDS.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa", string.Empty, MessageBoxButtons.OK);
                }
            }
        }

        private void gIAOVIEN_DANGKYGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
