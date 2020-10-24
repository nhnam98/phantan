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
    public partial class frmTaologin : Form
    {
        private string mLogin, mPass, mRole, mUsername, maKH;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CreateLogin(txtLOGIN.Text, txtLOGIN.Text, txtMAGV.Text, cbROLE.Text) == true)
            {
                MessageBox.Show("Ghi Thành công!!!", string.Empty, MessageBoxButtons.OK);
            }
        }

        private void cbROLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            mRole = cbROLE.SelectedItem.ToString();
        }

        public frmTaologin()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDS);

        }

        private void frmTaologin_Load(object sender, EventArgs e)
        {
            tN_CSDLPTDS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.tN_CSDLPTDS.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPTDS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.tN_CSDLPTDS.GIAOVIEN);
            cbROLE.Items.Add("CoSo");
            cbROLE.Items.Add("GiaoVien");
            loadTable();

        }
        private void loadTable()
        {
            try
            {
                maKH = ((DataRowView)gIAOVIENBindingSource[0])["MAKH"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!", string.Empty, MessageBoxButtons.OK);
            }
        }
        private bool CreateLogin(string login, string pass, string username, string role)
        {
            bool result = true;
            string strLenh = string.Format("EXEC sp_createlogin {0},{1},{2},{3}", login, pass, username, role);
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlcmd = new SqlCommand(strLenh, connection);
                sqlcmd.CommandType = CommandType.Text;
                try
                {
                    sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    result = false;
                }
            }
            return result;
        }
    }
        
            
    
    
}
