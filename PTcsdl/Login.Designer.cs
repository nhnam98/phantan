namespace PTcsdl
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tENSERVERLabel;
            this.tN_CSDLPTDS = new PTcsdl.TN_CSDLPTDS();
            this.bds_dspm = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager();
            this.cmbTENSERVER = new System.Windows.Forms.ComboBox();
            this.radGV = new System.Windows.Forms.RadioButton();
            this.radSV = new System.Windows.Forms.RadioButton();
            this.txtTAIKHOAN = new System.Windows.Forms.TextBox();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbTK = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.lbMasv = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            tENSERVERLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_dspm)).BeginInit();
            this.SuspendLayout();
            // 
            // tENSERVERLabel
            // 
            tENSERVERLabel.AutoSize = true;
            tENSERVERLabel.Location = new System.Drawing.Point(77, 148);
            tENSERVERLabel.Name = "tENSERVERLabel";
            tENSERVERLabel.Size = new System.Drawing.Size(43, 13);
            tENSERVERLabel.TabIndex = 0;
            tENSERVERLabel.Text = "CƠ SỞ:";
            tENSERVERLabel.Click += new System.EventHandler(this.tENSERVERLabel_Click);
            // 
            // tN_CSDLPTDS
            // 
            this.tN_CSDLPTDS.DataSetName = "TN_CSDLPTDS";
            this.tN_CSDLPTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_dspm
            // 
            this.bds_dspm.DataMember = "V_DS_PHANMANH";
            this.bds_dspm.DataSource = this.tN_CSDLPTDS;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BANGDIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbTENSERVER
            // 
            this.cmbTENSERVER.DataSource = this.bds_dspm;
            this.cmbTENSERVER.DisplayMember = "TENCN";
            this.cmbTENSERVER.FormattingEnabled = true;
            this.cmbTENSERVER.Location = new System.Drawing.Point(171, 140);
            this.cmbTENSERVER.Name = "cmbTENSERVER";
            this.cmbTENSERVER.Size = new System.Drawing.Size(200, 21);
            this.cmbTENSERVER.TabIndex = 1;
            this.cmbTENSERVER.ValueMember = "TENSERVER";
            this.cmbTENSERVER.SelectedIndexChanged += new System.EventHandler(this.tENSERVERComboBox_SelectedIndexChanged);
            // 
            // radGV
            // 
            this.radGV.AutoSize = true;
            this.radGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGV.Location = new System.Drawing.Point(80, 87);
            this.radGV.Name = "radGV";
            this.radGV.Size = new System.Drawing.Size(122, 24);
            this.radGV.TabIndex = 2;
            this.radGV.TabStop = true;
            this.radGV.Text = "GIẢNG VIÊN";
            this.radGV.UseVisualStyleBackColor = true;
            this.radGV.CheckedChanged += new System.EventHandler(this.radGV_CheckedChanged);
            // 
            // radSV
            // 
            this.radSV.AutoSize = true;
            this.radSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSV.Location = new System.Drawing.Point(288, 87);
            this.radSV.Name = "radSV";
            this.radSV.Size = new System.Drawing.Size(108, 24);
            this.radSV.TabIndex = 3;
            this.radSV.TabStop = true;
            this.radSV.Text = "SINH VIÊN";
            this.radSV.UseVisualStyleBackColor = true;
            this.radSV.CheckedChanged += new System.EventHandler(this.radSV_CheckedChanged);
            // 
            // txtTAIKHOAN
            // 
            this.txtTAIKHOAN.Location = new System.Drawing.Point(171, 192);
            this.txtTAIKHOAN.Name = "txtTAIKHOAN";
            this.txtTAIKHOAN.Size = new System.Drawing.Size(200, 20);
            this.txtTAIKHOAN.TabIndex = 4;
            this.txtTAIKHOAN.TextChanged += new System.EventHandler(this.txtTAIKHOAN_TextChanged);
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Location = new System.Drawing.Point(171, 241);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(200, 20);
            this.txtPASSWORD.TabIndex = 5;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(77, 248);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 13);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "PASSWORD";
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Location = new System.Drawing.Point(98, 114);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(0, 13);
            this.lbTK.TabIndex = 9;
            this.lbTK.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(80, 322);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(117, 23);
            this.btnDangnhap.TabIndex = 10;
            this.btnDangnhap.Text = "ĐĂNG NHẬP";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(171, 185);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(200, 20);
            this.txtMasv.TabIndex = 11;
            // 
            // lbMasv
            // 
            this.lbMasv.AutoSize = true;
            this.lbMasv.Location = new System.Drawing.Point(86, 195);
            this.lbMasv.Name = "lbMasv";
            this.lbMasv.Size = new System.Drawing.Size(41, 13);
            this.lbMasv.TabIndex = 12;
            this.lbMasv.Text = "lbMasv";
            this.lbMasv.Click += new System.EventHandler(this.lbMasv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(190, 26);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(153, 29);
            this.labe.TabIndex = 15;
            this.labe.Text = "ĐĂNG NHẬP";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbMasv);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.txtTAIKHOAN);
            this.Controls.Add(this.radSV);
            this.Controls.Add(this.radGV);
            this.Controls.Add(tENSERVERLabel);
            this.Controls.Add(this.cmbTENSERVER);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_dspm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPTDS tN_CSDLPTDS;
        private System.Windows.Forms.BindingSource bds_dspm;
        private TN_CSDLPTDSTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private TN_CSDLPTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTENSERVER;
        private System.Windows.Forms.RadioButton radGV;
        private System.Windows.Forms.RadioButton radSV;
        private System.Windows.Forms.TextBox txtTAIKHOAN;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label lbMasv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labe;
    }
}