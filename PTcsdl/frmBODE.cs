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
    public partial class frmBODE : Form
    {
        private int vitri;
        private string magv;
        public frmBODE()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDS);

        }

        private void frmBODE_Load(object sender, EventArgs e)
        {

            tN_CSDLPTDS.EnforceConstraints = false;
          
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDS.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.tN_CSDLPTDS.GIAOVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.tN_CSDLPTDS.BODE);

        }

        private void bTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            vitri = bODEBindingSource.Position;
            bODEBindingSource.AddNew();
            txtMAGV.Text = Program.username;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Ghi thành công!!!", string.Empty, MessageBoxButtons.OK);
                bODEBindingSource.EndEdit();
                bODEBindingSource.ResetCurrentItem();
              
                this.bODETableAdapter.Update(this.tN_CSDLPTDS.BODE);
            }
            catch
            {
                MessageBox.Show("Lỗi ghi!!!", string.Empty, MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn xóa???", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bODEBindingSource.RemoveCurrent();
                   
                    this.bODETableAdapter.Update(this.tN_CSDLPTDS.BODE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa", string.Empty, MessageBoxButtons.OK);
                }
            }
        }
    }
}
