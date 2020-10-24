using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTcsdl
{
    public partial class frmLOPSV : Form
    {
        private int vitri;
        private string makh;
        public frmLOPSV()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDS);

        }

        private void frmLOPSV_Load(object sender, EventArgs e)
        {
            tN_CSDLPTDS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Fill(this.tN_CSDLPTDS.BANGDIEM);
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.tN_CSDLPTDS.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.tN_CSDLPTDS.SINHVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDS.LOP);
            loadTable();

        }
        private void loadTable()
        {
            try
            {
                makh = ((DataRowView)lOPBindingSource[0])["MAKH"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bthThemLop_Click(object sender, EventArgs e)
        {
            vitri = lOPBindingSource.Position;
            lOPBindingSource.AddNew();
            txtMaKhoa.Text = makh;
        }

        private void btnGHILOP_Click(object sender, EventArgs e)
        {
            if (txtMALOP.Text.Trim() == null && txtTenLOP.Text.Trim() == null)
            {
                MessageBox.Show("Không được để trống !!!", string.Empty, MessageBoxButtons.OK);
                txtMALOP.Focus();
                return;
            }
            if (checkExist(txtMALOP.Text) == true)
            {
                MessageBox.Show("Mã lớp bị trùng, vui lòng nhập lại!!!", string.Empty, MessageBoxButtons.OK);
                txtMALOP.Focus();
                return;
            }
            try
            {
                lOPBindingSource.EndEdit();
                kHOABindingSource.ResetCurrentItem();
                sINHVIENDataGridView.Refresh();
                this.lOPTableAdapter.Update(this.tN_CSDLPTDS.LOP);
                MessageBox.Show("Ghi dữ liệu thành công!!!", string.Empty, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool checkExist(string id)
        {
            string strLenh = string.Format("EXEC sp_timlop '" + id + "'");
            bool exist = false;
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlcmd = new SqlCommand(strLenh, connection);
                sqlcmd.CommandType = CommandType.Text;
                try
                {
                    SqlDataReader reader = sqlcmd.ExecuteReader();
                    exist = true;
                }
                catch (SqlException)
                {
                    exist = false;
                }
            }
            return exist;
        }

        private void btnXOALOP_Click(object sender, EventArgs e)
        {
            if (sINHVIENBindingSource.Count != 0)
            {
                MessageBox.Show("Không thể xóa!!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn thật sự có muốn xóa???", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        lOPBindingSource.RemoveCurrent();

                        this.lOPTableAdapter.Update(this.tN_CSDLPTDS.LOP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa", string.Empty, MessageBoxButtons.OK);
                    }
                }
            }
        }

       
       
        private bool IsExist1(string id)
        {
            string strLenh = string.Format("EXEC sp_timSV '" + id + "'");
            bool exist = false;
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlcmd = new SqlCommand(strLenh, connection);
                sqlcmd.CommandType = CommandType.Text;
                try
                {
                    SqlDataReader reader = sqlcmd.ExecuteReader();
                    exist = true;
                }
                catch (SqlException)

                {
                    exist = false;
                }
            }
            return exist;
        }

       

        private void tHEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitri = sINHVIENBindingSource.Position;
            sINHVIENBindingSource.AddNew();
        }

        private void gHIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Text1 =sINHVIENDataGridView.CurrentRow.Cells[0].Value.ToString();
            if (IsExist1(Text1))
            {
                MessageBox.Show("Mã sinh viên bị trùng !", string.Empty, MessageBoxButtons.OK);
                return;
            }
            try
            {
                MessageBox.Show("Ghi dư liệu thành công.");
                sINHVIENBindingSource.EndEdit();
                sINHVIENDataGridView.Refresh();
                this.sINHVIENTableAdapter.Update(this.tN_CSDLPTDS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void xÓAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView current = (DataRowView)sINHVIENBindingSource.Current;
                if (bANGDIEMBindingSource.Count != 0)
                {
                    MessageBox.Show("khong xoa duoc", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(
                        current.Row.ItemArray.ToString(), "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            sINHVIENBindingSource.RemoveCurrent();
                            sINHVIENDataGridView.Refresh();
                            this.sINHVIENTableAdapter.Update(this.tN_CSDLPTDS.SINHVIEN);
                            MessageBox.Show("xoa duoc", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("khong xoa duoc", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
