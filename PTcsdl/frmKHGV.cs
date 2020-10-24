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
    public partial class frmKHGV : Form
    {
        private int vitri;
        private string macs;
        public frmKHGV()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDS);

        }

        private void frmKHGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.BODE' table. You can move, or remove it, as needed.
           
            tN_CSDLPTDS.EnforceConstraints = false;
            //this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.tN_CSDLPTDS.GIAOVIEN);
         //   this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.tN_CSDLPTDS.KHOA);
           // this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.tN_CSDLPTDS.BODE);
            loadTable();

        }

        private void loadTable()
        {
            try
            {
                macs = ((DataRowView)kHOABindingSource[0])["MACS"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            vitri = kHOABindingSource.Position;
           
            kHOABindingSource.AddNew();
            txtMACS.Text = macs;
        }

        private void btnGhiKH_Click(object sender, EventArgs e)
        {
            if (txtMAKH.Text.Trim() == null)
            {
                MessageBox.Show("Mã khoa không được thiếu!!!", string.Empty, MessageBoxButtons.OK);
                txtMAKH.Focus();
                return;
            }
            if (txtTENKH.Text.Trim() == null)
            {
                MessageBox.Show("Tên Khoa không được thiếu!!!", string.Empty, MessageBoxButtons.OK);
                txtTENKH.Focus();
                return;
            }
            if (checkIsExist(txtMAKH.Text) == true)
            {
                MessageBox.Show("Mã khoa đã tồn tại, vui lòng nhập lại!!!", string.Empty, MessageBoxButtons.OK);
                txtMAKH.Focus();
                return;
            }
            try
            {
                MessageBox.Show("Thêm thành công!!!", string.Empty, MessageBoxButtons.OK);
                kHOABindingSource.EndEdit();
                kHOABindingSource.ResetCurrentItem();
               // this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Update(this.tN_CSDLPTDS.KHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi " + ex.Message);
                return;
            }

        }
        private bool checkIsExist(string id)
        {
            string strLenh = string.Format("EXEC sp_timkhoa '" + id + "'");
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

        private void btnxoaKH_Click(object sender, EventArgs e)
        {
            if (gIAOVIENBindingSource.Count > 0)
            {
                MessageBox.Show("Trong Khoa đang tồn tại giáo viên, vui lòng không được xóa!!!", string.Empty, MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn thật sự có muốn xóa???", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        kHOABindingSource.RemoveCurrent();
                       // this.TAKH.Connection.ConnectionString = Program.connstr;
                        this.kHOATableAdapter.Update(this.tN_CSDLPTDS.KHOA);
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
            string strLenh = string.Format("EXEC sp_timgiaovien '" + id + "'");
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
       

        private void gIAOVIENDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void aSASAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gIAOVIENBindingSource.AddNew();
        }

        private void xÓAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView current = (DataRowView)gIAOVIENBindingSource.Current;
                if (bODEBindingSource.Count != 0)
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
                            gIAOVIENBindingSource.RemoveCurrent();
                            gIAOVIENDataGridView.Refresh();
                            this.gIAOVIENTableAdapter.Update(this.tN_CSDLPTDS.GIAOVIEN);
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

        private void gHIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Text1 = gIAOVIENDataGridView.CurrentRow.Cells[0].Value.ToString();
            if (IsExist1(Text1))
            {
                MessageBox.Show("Tên mã giáo viên bị trùng !", string.Empty, MessageBoxButtons.OK);
                return;
            }
            try
            {
                gIAOVIENBindingSource.EndEdit();
                gIAOVIENDataGridView.Refresh();
                this.gIAOVIENTableAdapter.Update(this.tN_CSDLPTDS.GIAOVIEN);

                MessageBox.Show("Ghi dư liệu thành công.");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MALOP"))
                    MessageBox.Show("Mã lop không được trùng", "", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Lỗi ghi Lopn học. " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
    }

}
