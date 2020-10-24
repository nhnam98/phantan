namespace PTcsdl
{
    partial class frmDuthi
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
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.tN_CSDLPTDS = new PTcsdl.TN_CSDLPTDS();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.MONHOCTableAdapter();
            this.sINHVIENTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.SINHVIENTableAdapter();
            this.deNGAYTHI = new DevExpress.XtraEditors.DateEdit();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.seLAN = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            this.lbmalop = new System.Windows.Forms.Label();
            this.lbtenlop = new System.Windows.Forms.Label();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbMAMH = new System.Windows.Forms.ComboBox();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seLAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(252, 186);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(58, 13);
            nGAYTHILabel.TabIndex = 1;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(485, 185);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(31, 13);
            lANLabel.TabIndex = 4;
            lANLabel.Text = "LAN:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(33, 184);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(49, 13);
            tENMHLabel.TabIndex = 13;
            tENMHLabel.Text = "TENMH:";
            // 
            // tN_CSDLPTDS
            // 
            this.tN_CSDLPTDS.DataSetName = "TN_CSDLPTDS";
            this.tN_CSDLPTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BANGDIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // deNGAYTHI
            // 
            this.deNGAYTHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "NGAYTHI", true));
            this.deNGAYTHI.EditValue = null;
            this.deNGAYTHI.Location = new System.Drawing.Point(338, 183);
            this.deNGAYTHI.Name = "deNGAYTHI";
            this.deNGAYTHI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYTHI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYTHI.Size = new System.Drawing.Size(100, 20);
            this.deNGAYTHI.TabIndex = 2;
            this.deNGAYTHI.EditValueChanged += new System.EventHandler(this.nGAYTHIDateEdit_EditValueChanged);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // gIAOVIEN_DANGKYBindingSource1
            // 
            this.gIAOVIEN_DANGKYBindingSource1.DataMember = "FK_GIAOVIEN_DANGKY_MONHOC1";
            this.gIAOVIEN_DANGKYBindingSource1.DataSource = this.mONHOCBindingSource;
            // 
            // seLAN
            // 
            this.seLAN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource1, "LAN", true));
            this.seLAN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seLAN.Location = new System.Drawing.Point(522, 182);
            this.seLAN.Name = "seLAN";
            this.seLAN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seLAN.Size = new System.Drawing.Size(100, 20);
            this.seLAN.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Lớp";
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.Location = new System.Drawing.Point(73, 13);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(35, 13);
            this.lbhoten.TabIndex = 9;
            this.lbhoten.Text = "label4";
            // 
            // lbmalop
            // 
            this.lbmalop.AutoSize = true;
            this.lbmalop.Location = new System.Drawing.Point(73, 57);
            this.lbmalop.Name = "lbmalop";
            this.lbmalop.Size = new System.Drawing.Size(35, 13);
            this.lbmalop.TabIndex = 10;
            this.lbmalop.Text = "label5";
            // 
            // lbtenlop
            // 
            this.lbtenlop.AutoSize = true;
            this.lbtenlop.Location = new System.Drawing.Point(73, 101);
            this.lbtenlop.Name = "lbtenlop";
            this.lbtenlop.Size = new System.Drawing.Size(35, 13);
            this.lbtenlop.TabIndex = 11;
            this.lbtenlop.Text = "label6";
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // btnThi
            // 
            this.btnThi.Location = new System.Drawing.Point(147, 263);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(103, 23);
            this.btnThi.TabIndex = 12;
            this.btnThi.Text = "Thi";
            this.btnThi.UseVisualStyleBackColor = true;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(324, 263);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // cbMAMH
            // 
            this.cbMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.cbMAMH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gIAOVIEN_DANGKYBindingSource, "MAMH", true));
            this.cbMAMH.DataSource = this.mONHOCBindingSource;
            this.cbMAMH.DisplayMember = "TENMH";
            this.cbMAMH.FormattingEnabled = true;
            this.cbMAMH.Location = new System.Drawing.Point(88, 181);
            this.cbMAMH.Name = "cbMAMH";
            this.cbMAMH.Size = new System.Drawing.Size(138, 21);
            this.cbMAMH.TabIndex = 14;
            this.cbMAMH.ValueMember = "MAMH";
            this.cbMAMH.SelectedIndexChanged += new System.EventHandler(this.tENMHComboBox_SelectedIndexChanged);
            // 
            // frmDuthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cbMAMH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.lbtenlop);
            this.Controls.Add(this.lbmalop);
            this.Controls.Add(this.lbhoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(lANLabel);
            this.Controls.Add(this.seLAN);
            this.Controls.Add(nGAYTHILabel);
            this.Controls.Add(this.deNGAYTHI);
            this.Name = "frmDuthi";
            this.Text = "frmDuthi";
            this.Load += new System.EventHandler(this.frmDuthi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seLAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPTDS tN_CSDLPTDS;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private TN_CSDLPTDSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private TN_CSDLPTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.DateEdit deNGAYTHI;
        private TN_CSDLPTDSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource1;
        private DevExpress.XtraEditors.SpinEdit seLAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.Label lbmalop;
        private System.Windows.Forms.Label lbtenlop;
        private TN_CSDLPTDSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbMAMH;
    }
}