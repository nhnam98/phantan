namespace PTcsdl
{
    partial class frmKHGV
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            this.tN_CSDLPTDS = new PTcsdl.TN_CSDLPTDS();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager();
            this.bODETableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.BODETableAdapter();
            this.gIAOVIENTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.GIAOVIENTableAdapter();
            this.kHOADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aSASAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xÓAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gHIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMAKH = new System.Windows.Forms.TextBox();
            this.txtTENKH = new System.Windows.Forms.TextBox();
            this.txtMACS = new System.Windows.Forms.TextBox();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnGhiKH = new System.Windows.Forms.Button();
            this.btnxoaKH = new System.Windows.Forms.Button();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(6, 328);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(41, 13);
            mAKHLabel.TabIndex = 2;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(6, 358);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(47, 13);
            tENKHLabel.TabIndex = 4;
            tENKHLabel.Text = "TENKH:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(6, 393);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(40, 13);
            mACSLabel.TabIndex = 6;
            mACSLabel.Text = "MACS:";
            // 
            // tN_CSDLPTDS
            // 
            this.tN_CSDLPTDS.DataSetName = "TN_CSDLPTDS";
            this.tN_CSDLPTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BANGDIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // kHOADataGridView
            // 
            this.kHOADataGridView.AutoGenerateColumns = false;
            this.kHOADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHOADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.kHOADataGridView.DataSource = this.kHOABindingSource;
            this.kHOADataGridView.Location = new System.Drawing.Point(1, 1);
            this.kHOADataGridView.Name = "kHOADataGridView";
            this.kHOADataGridView.Size = new System.Drawing.Size(345, 148);
            this.kHOADataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAKH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENKH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MACS";
            this.dataGridViewTextBoxColumn3.HeaderText = "MACS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // gIAOVIENDataGridView
            // 
            this.gIAOVIENDataGridView.AutoGenerateColumns = false;
            this.gIAOVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gIAOVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gIAOVIENDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.gIAOVIENDataGridView.DataSource = this.gIAOVIENBindingSource;
            this.gIAOVIENDataGridView.Location = new System.Drawing.Point(351, 1);
            this.gIAOVIENDataGridView.Name = "gIAOVIENDataGridView";
            this.gIAOVIENDataGridView.Size = new System.Drawing.Size(544, 148);
            this.gIAOVIENDataGridView.TabIndex = 1;
            this.gIAOVIENDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gIAOVIENDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MAGV";
            this.dataGridViewTextBoxColumn4.HeaderText = "MAGV";
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
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn7.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn8.HeaderText = "MAKH";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSASAToolStripMenuItem,
            this.xÓAToolStripMenuItem,
            this.gHIToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 70);
            // 
            // aSASAToolStripMenuItem
            // 
            this.aSASAToolStripMenuItem.Name = "aSASAToolStripMenuItem";
            this.aSASAToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.aSASAToolStripMenuItem.Text = "THÊM";
            this.aSASAToolStripMenuItem.Click += new System.EventHandler(this.aSASAToolStripMenuItem_Click);
            // 
            // xÓAToolStripMenuItem
            // 
            this.xÓAToolStripMenuItem.Name = "xÓAToolStripMenuItem";
            this.xÓAToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.xÓAToolStripMenuItem.Text = "XÓA";
            this.xÓAToolStripMenuItem.Click += new System.EventHandler(this.xÓAToolStripMenuItem_Click);
            // 
            // gHIToolStripMenuItem
            // 
            this.gHIToolStripMenuItem.Name = "gHIToolStripMenuItem";
            this.gHIToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.gHIToolStripMenuItem.Text = "GHI";
            this.gHIToolStripMenuItem.Click += new System.EventHandler(this.gHIToolStripMenuItem_Click);
            // 
            // txtMAKH
            // 
            this.txtMAKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOABindingSource, "MAKH", true));
            this.txtMAKH.Location = new System.Drawing.Point(73, 320);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(100, 20);
            this.txtMAKH.TabIndex = 3;
            // 
            // txtTENKH
            // 
            this.txtTENKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOABindingSource, "TENKH", true));
            this.txtTENKH.Location = new System.Drawing.Point(73, 351);
            this.txtTENKH.Name = "txtTENKH";
            this.txtTENKH.Size = new System.Drawing.Size(100, 20);
            this.txtTENKH.TabIndex = 5;
            // 
            // txtMACS
            // 
            this.txtMACS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOABindingSource, "MACS", true));
            this.txtMACS.Location = new System.Drawing.Point(73, 386);
            this.txtMACS.Name = "txtMACS";
            this.txtMACS.Size = new System.Drawing.Size(100, 20);
            this.txtMACS.TabIndex = 7;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(219, 318);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(75, 23);
            this.btnThemKH.TabIndex = 8;
            this.btnThemKH.Text = "THEM";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnGhiKH
            // 
            this.btnGhiKH.Location = new System.Drawing.Point(219, 353);
            this.btnGhiKH.Name = "btnGhiKH";
            this.btnGhiKH.Size = new System.Drawing.Size(75, 23);
            this.btnGhiKH.TabIndex = 9;
            this.btnGhiKH.Text = "GHI";
            this.btnGhiKH.UseVisualStyleBackColor = true;
            this.btnGhiKH.Click += new System.EventHandler(this.btnGhiKH_Click);
            // 
            // btnxoaKH
            // 
            this.btnxoaKH.Location = new System.Drawing.Point(219, 386);
            this.btnxoaKH.Name = "btnxoaKH";
            this.btnxoaKH.Size = new System.Drawing.Size(75, 23);
            this.btnxoaKH.TabIndex = 10;
            this.btnxoaKH.Text = "XÓA";
            this.btnxoaKH.UseVisualStyleBackColor = true;
            this.btnxoaKH.Click += new System.EventHandler(this.btnxoaKH_Click);
            // 
            // bODEBindingSource
            // 
            this.bODEBindingSource.DataMember = "BODE";
            this.bODEBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // frmKHGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 475);
            this.Controls.Add(this.btnxoaKH);
            this.Controls.Add(this.btnGhiKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(mACSLabel);
            this.Controls.Add(this.txtMACS);
            this.Controls.Add(tENKHLabel);
            this.Controls.Add(this.txtTENKH);
            this.Controls.Add(mAKHLabel);
            this.Controls.Add(this.txtMAKH);
            this.Controls.Add(this.gIAOVIENDataGridView);
            this.Controls.Add(this.kHOADataGridView);
            this.Name = "frmKHGV";
            this.Text = "frmKHGV";
            this.Load += new System.EventHandler(this.frmKHGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPTDS tN_CSDLPTDS;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private TN_CSDLPTDSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private TN_CSDLPTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kHOADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private TN_CSDLPTDSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private System.Windows.Forms.DataGridView gIAOVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txtMAKH;
        private System.Windows.Forms.TextBox txtTENKH;
        private System.Windows.Forms.TextBox txtMACS;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnGhiKH;
        private System.Windows.Forms.Button btnxoaKH;
        private TN_CSDLPTDSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aSASAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xÓAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gHIToolStripMenuItem;
    }
}