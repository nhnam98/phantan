using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace PTcsdl
{
    public partial class frmThi : Form
    {
        public List<String> cauhoi = new List<String>();
        private int vitri, baithi;
        private double diem;
        private int a, b, c;
       
        BindingSource source = new BindingSource();

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDS);

        }

        public frmThi()
        {
            InitializeComponent();
        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            tN_CSDLPTDS.EnforceConstraints = false;
      
            this.bODETableAdapter.Fill(this.tN_CSDLPTDS.BODE);
            getBoDe(Program.trinhdo1, Program.trinhdo2, Program.maMH,Program.makhoa1,Program.makhoa2,Program.socau);
            label3.Text = "20";
            Random _r = new Random();
            baithi = _r.Next(1,100);
            radioA.Enabled = radioB.Enabled = radioC.Enabled = radioD.Enabled = btnKetthuc.Enabled = btnCausau.Enabled=btnCautruoc.Enabled=false;

        }
        private void getBoDe(string trinhdo1, string trinhdo2, string mamh,string makhoa1,string makhoa2,int socau)
        {


            string strLenh = string.Format("EXEC SP_THI '{0}','{1}','{2}','{3}','{4}','{5}'", trinhdo1, trinhdo2, mamh,makhoa1,makhoa2,socau);
            source.DataSource = Program.ExecSqlDataTable(strLenh);
           
            vitri = source.Position;
           
            string result = ((DataRowView)source[vitri])["NOIDUNG"].ToString();
            lbND.Text = result;
            string result1 = ((DataRowView)source[vitri])["A"].ToString();
            radioA.Text = result1;
            string result2 = ((DataRowView)source[vitri])["B"].ToString();
            radioB.Text = result2;
            string result3 = ((DataRowView)source[vitri])["C"].ToString();
            radioC.Text = result3;
            string result4 = ((DataRowView)source[vitri])["D"].ToString();
            radioD.Text = result4;
            string result5 = ((DataRowView)source[vitri])["DAP_AN"].ToString();
            string answer = "";

            for (int i = 0; i <Program.socau; i++)
            {
               
                cauhoi.Add("");
            }


        }
        private void btnCausau_Click(object sender, EventArgs e)
        {
            
        }
        private void btnCautruoc_Click(object sender, EventArgs e)
        {
          
        }

        private void gbCauHoi_Enter(object sender, EventArgs e)
        {

        }

        private void btnCausau_Click_1(object sender, EventArgs e)
        {
            if (radioA.Checked == true)
            {
                cauhoi[vitri] = "A";
            }
            else if (radioB.Checked == true)
            {
                cauhoi[vitri] = "B";
            }
            else if (radioC.Checked == true)
            {
                cauhoi[vitri] = "C";
            }
            else if (radioD.Checked == true)
            {
                cauhoi[vitri] = "D";
            }
            else
            {
                cauhoi[vitri] = "";
            }
       
         

            source.MoveNext();

            vitri = source.Position;
            string result = ((DataRowView)source[vitri])["NOIDUNG"].ToString();
            lbND.Text = result;
            string result1 = ((DataRowView)source[vitri])["A"].ToString();
            radioA.Text = result1;
            string result2 = ((DataRowView)source[vitri])["B"].ToString();
            radioB.Text = result2;
            string result3 = ((DataRowView)source[vitri])["C"].ToString();
            radioC.Text = result3;
            string result4 = ((DataRowView)source[vitri])["D"].ToString();
            radioD.Text = result4;
            string result5 = ((DataRowView)source[vitri])["DAP_AN"].ToString();
            string cautrc = ((DataRowView)source[vitri-1])["DAP_AN"].ToString();
            //  MessageBox.Show(cautrc);
            String result6 = cauhoi[vitri];
          
            if (result6.Equals("A"))
            {
                radioA.Checked = true;
            }
            else if (result6.Equals("B"))
            {
                radioB.Checked = true;
            }
            else if (result6.Equals("C"))
            {
                radioC.Checked = true;
            }
            else if (result6.Equals("D"))
            {
                radioD.Checked = true;
            }
            else
            {
                //cauhoi.Add("");
                radioA.Checked = radioB.Checked = radioC.Checked = radioD.Checked = false;
            }
            if (cauhoi[vitri - 1] == cautrc)
            {
                diem = diem + 0.25;
            }
           



        }

        private void btnCautruoc_Click_1(object sender, EventArgs e)
        {
            if (radioA.Checked == true)
            {
                cauhoi[vitri] = "A";
            }
            else if (radioB.Checked == true)
            {
                cauhoi[vitri] = "B";
            }
            else if (radioC.Checked == true)
            {
                cauhoi[vitri] = "C";
            }
            else if (radioD.Checked == true)
            {
                cauhoi[vitri] = "D";
            }
            else
            {
                cauhoi[vitri] = "";
            }
            source.MovePrevious();
            vitri = source.Position;
            string result = ((DataRowView)source[vitri])["NOIDUNG"].ToString();
            lbND.Text = result;
            string result1 = ((DataRowView)source[vitri])["A"].ToString();
            radioA.Text = result1;
            string result2 = ((DataRowView)source[vitri])["B"].ToString();
            radioB.Text = result2;
            string result3 = ((DataRowView)source[vitri])["C"].ToString();
            radioC.Text = result3;
            string result4 = ((DataRowView)source[vitri])["D"].ToString();
            string cautrc = ((DataRowView)source[vitri + 1])["DAP_AN"].ToString();
            radioD.Text = result4;
            String result6 = cauhoi[vitri];

            if (result6.Equals("A"))
            {
                radioA.Checked = true;
            }
            else if (result6.Equals("B"))
            {
                radioB.Checked = true;
            }
            else if (result6.Equals("C"))
            {
                radioC.Checked = true;
            }
            else if (result6.Equals("D"))
            {
                radioD.Checked = true;
            }
            else
            {
                //cauhoi.Add("");
                radioA.Checked = radioB.Checked = radioC.Checked = radioD.Checked = false;
            }
            if (cauhoi[vitri + 1] == cautrc)
            {
                diem = diem + 0.25;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = Int32.Parse(label2.Text); 
            b = Int32.Parse(label1.Text); 
            c = Int32.Parse(label3.Text); 
            a--;
            if (a < 0)
            {
                a = 59;
                b--;
                if (b < 0)
                {
                    b = 59;
                    c--;
                }
            }
            if (a < 10)
            {
                label2.Text = "0" + a;
            }
            else
                label2.Text = a + "";
            if (b < 10)
            {
                label1.Text = "0" + b;
            }
            else
                label1.Text = b + "";
            if (c < 10)
            {
                label3.Text = "0" + c;
            }
            else
                label3.Text = c + "";

            if (a == 0 && b == 0 && c == 0)
            {
                timer1.Stop();
               // SoundPlayer sound = new SoundPlayer(@".\reng.wav");

                //sound.Play(); // can also use soundPlayer.PlaySync()

                MessageBox.Show("Hết giờ");
                MessageBox.Show("ĐIỂM CỦA SINH VIÊN " + Program.maSV + " : " + diem.ToString());
                ghiDiem();
            }
        }

       


      
        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            radioA.Enabled = radioB.Enabled = radioC.Enabled = radioD.Enabled = btnKetthuc.Enabled = btnCausau.Enabled = btnCautruoc.Enabled = false;
            MessageBox.Show("ĐIỂM CỦA SINH VIÊN "+Program.maSV+" : "+ diem.ToString());
            ghiDiem();
      
        }

        private void btnBatdau_Click(object sender, EventArgs e)
        {
            timer1.Start();
            radioA.Enabled = radioB.Enabled = radioC.Enabled = radioD.Enabled = btnKetthuc.Enabled =btnCautruoc.Enabled=btnCausau.Enabled= true;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

        

       
        }
        private void ghiDiem()
        {
            string strLenh = string.Format("EXEC sp_GhiDiem'{0}','{1}','{2}','{3}','{4}','{5}'", Program.maSV, Program.maMH, Program.lan ,Program.ngay,diem,baithi);
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();

           

        }
        }


    
}
