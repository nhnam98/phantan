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
    public partial class frmDuthi : Form
    {

        public frmDuthi()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDS);

        }

        private void frmDuthi_Load(object sender, EventArgs e)
        {
           
            tN_CSDLPTDS.EnforceConstraints = false;
          
            this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDS.MONHOC);
         
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tN_CSDLPTDS.GIAOVIEN_DANGKY);
        
            this.sINHVIENTableAdapter.Fill(this.tN_CSDLPTDS.SINHVIEN);
            getSinhVien(Program.maSV);
            cbMAMH.SelectedIndex=-1;
        }
        private void getSinhVien(string id)
        {
            using (var connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                string strLenh = string.Format("EXEC sp_timmalop '" + id + "'");
                using (var command = new SqlCommand(strLenh, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string result = reader.GetString(0);
                            lbhoten.Text = result;
                            string result1 = reader.GetString(1);
                            lbmalop.Text = result1;
                            string result2 = reader.GetString(2);
                            lbtenlop.Text = result2;

                        }
                    }
                }
                connection.Close();
            }
        }
        private bool checkGVDK(string malop, string mamh, string ngaythi, string lan)
        {
            Program.maMH = cbMAMH.SelectedValue.ToString();
         
            string strLenh = string.Format("EXEC sp_timbode '{0}', '{1}',{2},'{3}'", mamh, ngaythi, lan, malop);

            bool exist = false;
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlcmd = new SqlCommand(strLenh, connection);
                sqlcmd.CommandType = CommandType.Text;
                try
                {
                    SqlDataReader myreader = sqlcmd.ExecuteReader();
                    using (myreader)
                    {
                        while (myreader.Read())
                        {
                            string result = myreader.GetString(1);
                           
                            Program.trinhdo1 = result;
                            if (Program.trinhdo1 == "A")
                            {
                                Program.trinhdo2 = "B";
                            }
                            else if (Program.trinhdo1 == "B")
                            {
                                Program.trinhdo2 = "C";
                            }
                            else
                            {
                                Program.trinhdo2 = "C";
                            }
                        }
                    }
                    exist = true;
                }
                catch (SqlException)
                {
                    exist = false;
                }
            }
            return exist;
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            Program.maLop = lbmalop.Text;
            Program.ngay = deNGAYTHI.Text;
            Program.lan = Convert.ToInt32(seLAN.Value);
          
            if (checkGVDK(lbmalop.Text,Program.maMH , deNGAYTHI.Text, Convert.ToString(seLAN.Value)) == true)
            {

                frmThi f = new frmThi();
                f.Show();
                this.Hide();
                f.FormClosed += (o, w) => this.Show();

            }
            else
            {
                MessageBox.Show("loi", string.Empty, MessageBoxButtons.OK);
                return;
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
       

        private void nGAYTHIDateEdit_EditValueChanged(object sender, EventArgs e)
        {
           // Program.maMH = cbMAMH.SelectedValue.ToString();
        }

        private void tENMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.maMH = "AVCB";
                Program.maMH = cbMAMH.SelectedValue.ToString();
            }catch(Exception )
            {

            }
          

        }
    }
}
