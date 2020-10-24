namespace PTcsdl
{
    partial class frmDKTHI
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            this.tN_CSDLPTDS = new PTcsdl.TN_CSDLPTDS();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager();
            this.gIAOVIEN_DANGKYGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMalop = new DevExpress.XtraEditors.TextEdit();
            this.txtTrinhdo = new DevExpress.XtraEditors.TextEdit();
            this.dtNgaythi = new DevExpress.XtraEditors.DateEdit();
            this.seLan = new DevExpress.XtraEditors.SpinEdit();
            this.seSolanthi = new DevExpress.XtraEditors.SpinEdit();
            this.seThoigian = new DevExpress.XtraEditors.SpinEdit();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            mAGVLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrinhdo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaythi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaythi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seLan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSolanthi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seThoigian.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(25, 257);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(41, 13);
            mAGVLabel.TabIndex = 1;
            mAGVLabel.Text = "MAGV:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(23, 303);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(43, 13);
            mAMHLabel.TabIndex = 3;
            mAMHLabel.Text = "MAMH:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(19, 347);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(47, 13);
            mALOPLabel.TabIndex = 5;
            mALOPLabel.Text = "MALOP:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(12, 389);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(60, 13);
            tRINHDOLabel.TabIndex = 7;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(283, 261);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(58, 13);
            nGAYTHILabel.TabIndex = 9;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(283, 303);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(31, 13);
            lANLabel.TabIndex = 11;
            lANLabel.Text = "LAN:";
            lANLabel.Click += new System.EventHandler(this.lANLabel_Click);
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(283, 339);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(65, 13);
            sOCAUTHILabel.TabIndex = 13;
            sOCAUTHILabel.Text = "SOCAUTHI:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(292, 385);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(62, 13);
            tHOIGIANLabel.TabIndex = 15;
            tHOIGIANLabel.Text = "THOIGIAN:";
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
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIEN_DANGKYGridControl
            // 
            this.gIAOVIEN_DANGKYGridControl.DataSource = this.gIAOVIEN_DANGKYBindingSource;
            this.gIAOVIEN_DANGKYGridControl.Location = new System.Drawing.Point(-1, 0);
            this.gIAOVIEN_DANGKYGridControl.MainView = this.gridView1;
            this.gIAOVIEN_DANGKYGridControl.Name = "gIAOVIEN_DANGKYGridControl";
            this.gIAOVIEN_DANGKYGridControl.Size = new System.Drawing.Size(895, 220);
            this.gIAOVIEN_DANGKYGridControl.TabIndex = 0;
            this.gIAOVIEN_DANGKYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gIAOVIEN_DANGKYGridControl.Click += new System.EventHandler(this.gIAOVIEN_DANGKYGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.GridControl = this.gIAOVIEN_DANGKYGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "MAGV", true));
            this.txtMaGV.Location = new System.Drawing.Point(92, 254);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(100, 20);
            this.txtMaGV.TabIndex = 2;
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "MAMH", true));
            this.txtMaMH.Location = new System.Drawing.Point(92, 300);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(100, 20);
            this.txtMaMH.TabIndex = 4;
            // 
            // txtMalop
            // 
            this.txtMalop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "MALOP", true));
            this.txtMalop.Location = new System.Drawing.Point(92, 336);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(100, 20);
            this.txtMalop.TabIndex = 6;
            // 
            // txtTrinhdo
            // 
            this.txtTrinhdo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "TRINHDO", true));
            this.txtTrinhdo.Location = new System.Drawing.Point(92, 382);
            this.txtTrinhdo.Name = "txtTrinhdo";
            this.txtTrinhdo.Size = new System.Drawing.Size(100, 20);
            this.txtTrinhdo.TabIndex = 8;
            // 
            // dtNgaythi
            // 
            this.dtNgaythi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "NGAYTHI", true));
            this.dtNgaythi.EditValue = null;
            this.dtNgaythi.Location = new System.Drawing.Point(360, 258);
            this.dtNgaythi.Name = "dtNgaythi";
            this.dtNgaythi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaythi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaythi.Size = new System.Drawing.Size(100, 20);
            this.dtNgaythi.TabIndex = 10;
            // 
            // seLan
            // 
            this.seLan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "LAN", true));
            this.seLan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seLan.Location = new System.Drawing.Point(360, 300);
            this.seLan.Name = "seLan";
            this.seLan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seLan.Size = new System.Drawing.Size(100, 20);
            this.seLan.TabIndex = 12;
            this.seLan.EditValueChanged += new System.EventHandler(this.lANSpinEdit_EditValueChanged);
            // 
            // seSolanthi
            // 
            this.seSolanthi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "SOCAUTHI", true));
            this.seSolanthi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSolanthi.Location = new System.Drawing.Point(360, 336);
            this.seSolanthi.Name = "seSolanthi";
            this.seSolanthi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSolanthi.Size = new System.Drawing.Size(100, 20);
            this.seSolanthi.TabIndex = 14;
            // 
            // seThoigian
            // 
            this.seThoigian.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "THOIGIAN", true));
            this.seThoigian.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seThoigian.Location = new System.Drawing.Point(360, 382);
            this.seThoigian.Name = "seThoigian";
            this.seThoigian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seThoigian.Size = new System.Drawing.Size(100, 20);
            this.seThoigian.TabIndex = 16;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(519, 252);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(519, 290);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(519, 329);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "XOÁ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmDKTHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(tHOIGIANLabel);
            this.Controls.Add(this.seThoigian);
            this.Controls.Add(sOCAUTHILabel);
            this.Controls.Add(this.seSolanthi);
            this.Controls.Add(lANLabel);
            this.Controls.Add(this.seLan);
            this.Controls.Add(nGAYTHILabel);
            this.Controls.Add(this.dtNgaythi);
            this.Controls.Add(tRINHDOLabel);
            this.Controls.Add(this.txtTrinhdo);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.txtMalop);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(mAGVLabel);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.gIAOVIEN_DANGKYGridControl);
            this.Name = "frmDKTHI";
            this.Text = "frmDKTHI";
            this.Load += new System.EventHandler(this.frmDKTHI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrinhdo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaythi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaythi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seLan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSolanthi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seThoigian.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPTDS tN_CSDLPTDS;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private TN_CSDLPTDSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private TN_CSDLPTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIAOVIEN_DANGKYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.TextEdit txtMalop;
        private DevExpress.XtraEditors.TextEdit txtTrinhdo;
        private DevExpress.XtraEditors.DateEdit dtNgaythi;
        private DevExpress.XtraEditors.SpinEdit seLan;
        private DevExpress.XtraEditors.SpinEdit seSolanthi;
        private DevExpress.XtraEditors.SpinEdit seThoigian;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
    }
}