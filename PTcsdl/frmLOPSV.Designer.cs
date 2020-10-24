namespace PTcsdl
{
    partial class frmLOPSV
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            this.tN_CSDLPTDS = new PTcsdl.TN_CSDLPTDS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager();
            this.bANGDIEMTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.BANGDIEMTableAdapter();
            this.kHOATableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.KHOATableAdapter();
            this.sINHVIENTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.SINHVIENTableAdapter();
            this.lOPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMALOP = new System.Windows.Forms.TextBox();
            this.txtTenLOP = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.bthThemLop = new System.Windows.Forms.Button();
            this.btnGHILOP = new System.Windows.Forms.Button();
            this.btnXOALOP = new System.Windows.Forms.Button();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANGDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tHEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gHIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xÓAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(9, 254);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(47, 13);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(3, 307);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(53, 13);
            tENLOPLabel.TabIndex = 4;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(15, 360);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(41, 13);
            mAKHLabel.TabIndex = 6;
            mAKHLabel.Text = "MAKH:";
            // 
            // tN_CSDLPTDS
            // 
            this.tN_CSDLPTDS.DataSetName = "TN_CSDLPTDS";
            this.tN_CSDLPTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BANGDIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lOPDataGridView
            // 
            this.lOPDataGridView.AutoGenerateColumns = false;
            this.lOPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.lOPDataGridView.DataSource = this.lOPBindingSource;
            this.lOPDataGridView.Location = new System.Drawing.Point(3, 3);
            this.lOPDataGridView.Name = "lOPDataGridView";
            this.lOPDataGridView.Size = new System.Drawing.Size(344, 220);
            this.lOPDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MALOP";
            this.dataGridViewTextBoxColumn1.HeaderText = "MALOP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENLOP";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENLOP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn3.HeaderText = "MAKH";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "FK_SINHVIEN_LOP";
            this.sINHVIENBindingSource.DataSource = this.lOPBindingSource;
            // 
            // sINHVIENDataGridView
            // 
            this.sINHVIENDataGridView.AutoGenerateColumns = false;
            this.sINHVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sINHVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.sINHVIENDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.sINHVIENDataGridView.DataSource = this.sINHVIENBindingSource;
            this.sINHVIENDataGridView.Location = new System.Drawing.Point(353, 3);
            this.sINHVIENDataGridView.Name = "sINHVIENDataGridView";
            this.sINHVIENDataGridView.Size = new System.Drawing.Size(644, 220);
            this.sINHVIENDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MASV";
            this.dataGridViewTextBoxColumn4.HeaderText = "MASV";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HO";
            this.dataGridViewTextBoxColumn5.HeaderText = "HO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn6.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NGAYSINH";
            this.dataGridViewTextBoxColumn7.HeaderText = "NGAYSINH";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn8.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MALOP";
            this.dataGridViewTextBoxColumn9.HeaderText = "MALOP";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.txtMALOP.Location = new System.Drawing.Point(62, 251);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(100, 20);
            this.txtMALOP.TabIndex = 3;
            // 
            // txtTenLOP
            // 
            this.txtTenLOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.txtTenLOP.Location = new System.Drawing.Point(62, 304);
            this.txtTenLOP.Name = "txtTenLOP";
            this.txtTenLOP.Size = new System.Drawing.Size(100, 20);
            this.txtTenLOP.TabIndex = 5;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MAKH", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(62, 357);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtMaKhoa.TabIndex = 7;
            // 
            // bthThemLop
            // 
            this.bthThemLop.Location = new System.Drawing.Point(227, 251);
            this.bthThemLop.Name = "bthThemLop";
            this.bthThemLop.Size = new System.Drawing.Size(75, 23);
            this.bthThemLop.TabIndex = 20;
            this.bthThemLop.Text = "THÊM";
            this.bthThemLop.UseVisualStyleBackColor = true;
            this.bthThemLop.Click += new System.EventHandler(this.bthThemLop_Click);
            // 
            // btnGHILOP
            // 
            this.btnGHILOP.Location = new System.Drawing.Point(227, 302);
            this.btnGHILOP.Name = "btnGHILOP";
            this.btnGHILOP.Size = new System.Drawing.Size(75, 23);
            this.btnGHILOP.TabIndex = 21;
            this.btnGHILOP.Text = "GHI";
            this.btnGHILOP.UseVisualStyleBackColor = true;
            this.btnGHILOP.Click += new System.EventHandler(this.btnGHILOP_Click);
            // 
            // btnXOALOP
            // 
            this.btnXOALOP.Location = new System.Drawing.Point(226, 346);
            this.btnXOALOP.Name = "btnXOALOP";
            this.btnXOALOP.Size = new System.Drawing.Size(75, 23);
            this.btnXOALOP.TabIndex = 22;
            this.btnXOALOP.Text = "XÓA";
            this.btnXOALOP.UseVisualStyleBackColor = true;
            this.btnXOALOP.Click += new System.EventHandler(this.btnXOALOP_Click);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // bANGDIEMBindingSource
            // 
            this.bANGDIEMBindingSource.DataMember = "BANGDIEM";
            this.bANGDIEMBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHEMToolStripMenuItem,
            this.gHIToolStripMenuItem,
            this.xÓAToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 70);
            // 
            // tHEMToolStripMenuItem
            // 
            this.tHEMToolStripMenuItem.Name = "tHEMToolStripMenuItem";
            this.tHEMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tHEMToolStripMenuItem.Text = "THÊM";
            this.tHEMToolStripMenuItem.Click += new System.EventHandler(this.tHEMToolStripMenuItem_Click);
            // 
            // gHIToolStripMenuItem
            // 
            this.gHIToolStripMenuItem.Name = "gHIToolStripMenuItem";
            this.gHIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gHIToolStripMenuItem.Text = "GHI";
            this.gHIToolStripMenuItem.Click += new System.EventHandler(this.gHIToolStripMenuItem_Click);
            // 
            // xÓAToolStripMenuItem
            // 
            this.xÓAToolStripMenuItem.Name = "xÓAToolStripMenuItem";
            this.xÓAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xÓAToolStripMenuItem.Text = "XÓA";
            this.xÓAToolStripMenuItem.Click += new System.EventHandler(this.xÓAToolStripMenuItem_Click);
            // 
            // frmLOPSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 617);
            this.Controls.Add(this.btnXOALOP);
            this.Controls.Add(this.btnGHILOP);
            this.Controls.Add(this.bthThemLop);
            this.Controls.Add(mAKHLabel);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.txtTenLOP);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.txtMALOP);
            this.Controls.Add(this.sINHVIENDataGridView);
            this.Controls.Add(this.lOPDataGridView);
            this.Name = "frmLOPSV";
            this.Text = "frmLOPSV";
            this.Load += new System.EventHandler(this.frmLOPSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPTDS tN_CSDLPTDS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private TN_CSDLPTDSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private TN_CSDLPTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lOPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private TN_CSDLPTDSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private TN_CSDLPTDSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.DataGridView sINHVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox txtMALOP;
        private System.Windows.Forms.TextBox txtTenLOP;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Button bthThemLop;
        private System.Windows.Forms.Button btnGHILOP;
        private System.Windows.Forms.Button btnXOALOP;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private TN_CSDLPTDSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private System.Windows.Forms.BindingSource bANGDIEMBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tHEMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gHIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xÓAToolStripMenuItem;
    }
}