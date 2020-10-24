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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.Text = "TÀI KHOẢN";
            lbMasv.Visible = false;
            txtMasv.Visible = false;
            string chuoiketnoi = "Data Source=DESKTOP-DM1IMNQ;Initial Catalog=TN_CSDLPT;Persist Security Info=True;User ID=sa;Password=123456";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cmbTENSERVER.DataSource = dt;
            cmbTENSERVER.DisplayMember = "TENCN";
            cmbTENSERVER.ValueMember = "TENSERVER";
            cmbTENSERVER.SelectedIndex = -1;
            btnDangnhap.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tENSERVERComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Program.servername = cmbTENSERVER.SelectedValue.ToString();
                
            }
            catch (Exception)
            {

            }
        }

        private void tENSERVERLabel_Click(object sender, EventArgs e)
        {

        }

        private void radGV_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "TÀI KHOẢN";
            txtPASSWORD.Visible = true;
            lbPassword.Visible = true;
            txtTAIKHOAN.Visible = true;
            label1.Visible = true;
            lbMasv.Visible = false;
            txtMasv.Visible = false;
            btnDangnhap.Enabled = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {


            /*string strLenh1 = string.Format("EXEC sp_KiemTraMaSinhVienTonTai '" + Program.maSV + "'");
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            Program.myReader.Read();
            int a = Program.myReader.GetInt32(0);

            if (a == 0)
            {
                txtMasv.Focus();
                MessageBox.Show("nhap lai:" + a);
                Program.myReader.Close();
                return;

            }
            else
            {

                Program.mHoten = " ";
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                MessageBox.Show("Nhom : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);
                frmDuthi f = new frmDuthi();
                f.Show();
                this.Hide();
                f.FormClosed += (o, w) => this.Show();

            }*/

        }

        private void radSV_CheckedChanged(object sender, EventArgs e)
        {
           
            label1.Visible=false;
            txtPASSWORD.Visible = false;
            txtPASSWORD.Text="123456";
            txtTAIKHOAN.Text = "SV";
            txtTAIKHOAN.Visible = false;
            lbPassword.Visible =false;
            lbMasv.Text = "MÃ SV";
            lbMasv.Visible = true;
            txtMasv.Visible = true;
            btnDangnhap.Enabled = true;
        }
       
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTAIKHOAN.Text.Trim() == " " || txtPASSWORD.Text.Trim() == " ")
            {
                MessageBox.Show("Login name và mật mã không đúng", " ", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtTAIKHOAN.Text;
            Program.password = txtPASSWORD.Text;
            Program.maSV = txtMasv.Text;
          
            if (Program.KetNoi() == 0)
            {
               
                return;
            }
            else
            {
                //MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG", " ", MessageBoxButtons.OK);
            }






           
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC sp_Dangnhap '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            // khi no là sv
            if (Program.mloginDN.Equals("SV"))
            {

                /* Program.mHoten = " ";
                 Program.mGroup = Program.myReader.GetString(2);
                 Program.myReader.Close();
                 Program.conn.Close();
                 MessageBox.Show("Nhom : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);
                 frmDuthi f = new frmDuthi();
                 f.Show();
                 this.Hide();
                 f.FormClosed += (o, w) => this.Show();

     */
            }
            else if (Program.mloginDN.Equals("PVH") || Program.mloginDN.Equals("VNT"))
            {
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                MessageBox.Show("Nhan vien - Nhom : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);
                frmMain f = new frmMain();
                f.Show();
                this.Hide();
                f.FormClosed += (o, w) => this.Show();

            }
            else if (Program.mloginDN.Equals("PHN") || Program.mloginDN.Equals("DVT"))
            {
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                MessageBox.Show("Nhan vien - Nhom : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);
                frmMainGV f = new frmMainGV();
                f.Show();
                this.Hide();
                f.FormClosed += (o, w) => this.Show();
            }
            else
            {
                // Program.mHoten = Program.myReader.GetString(1);
                // Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();

                //MessageBox.Show("Nhan vien - Nhom : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);
            }

            Program.myReader.Close();
            Program.conn.Close();


            if (Program.mloginDN.Equals("SV"))
            {
                string strLenh1 = string.Format("EXEC sp_KiemTraMaSinhVienTonTai '" + Program.maSV + "'");
                Program.myReader = Program.ExecSqlDataReader(strLenh1);
                Program.myReader.Read();
                int a = Program.myReader.GetInt32(0);

                if (a == 0)
                {
                    txtMasv.Focus();
                    MessageBox.Show("KHÔNG TỒN TẠI MÃ SINH VIÊN NÀY", "", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    return;

                }
                else
                {

                    //  Program.mHoten = " ";
                    //  Program.mGroup = Program.myReader.GetString(2);
                    Program.myReader.Close();
                    Program.conn.Close();
                    MessageBox.Show("SINH VIÊN MÃ " + Program.maSV, " ĐÃ ĐĂNG NHẬP", MessageBoxButtons.OK);
                    frmDuthi f = new frmDuthi();
                    f.Show();
                    this.Hide();
                    f.FormClosed += (o, w) => this.Show();

                }
            }
           
            


        }

        private void txtTAIKHOAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbMasv_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
