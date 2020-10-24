namespace PTcsdl
{
    partial class frmBODE
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label cAUHOILabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label mAGVLabel;
            this.tN_CSDLPTDS = new PTcsdl.TN_CSDLPTDS();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager();
            this.gIAOVIENTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.GIAOVIENTableAdapter();
            this.mONHOCTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.MONHOCTableAdapter();
            this.bODEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAMHTextBox = new System.Windows.Forms.TextBox();
            this.cAUHOITextBox = new System.Windows.Forms.TextBox();
            this.tRINHDOTextBox = new System.Windows.Forms.TextBox();
            this.nOIDUNGTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.dAP_ANTextBox = new System.Windows.Forms.TextBox();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mAMHLabel = new System.Windows.Forms.Label();
            cAUHOILabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(29, 291);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(43, 13);
            mAMHLabel.TabIndex = 1;
            mAMHLabel.Text = "MAMH:";
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Location = new System.Drawing.Point(21, 244);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(51, 13);
            cAUHOILabel.TabIndex = 3;
            cAUHOILabel.Text = "CAUHOI:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(12, 341);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(60, 13);
            tRINHDOLabel.TabIndex = 5;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(11, 391);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(61, 13);
            nOIDUNGLabel.TabIndex = 7;
            nOIDUNGLabel.Text = "NOIDUNG:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Location = new System.Drawing.Point(236, 244);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(17, 13);
            aLabel.TabIndex = 9;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(236, 283);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(17, 13);
            bLabel.TabIndex = 11;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Location = new System.Drawing.Point(236, 319);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(17, 13);
            cLabel.TabIndex = 13;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new System.Drawing.Point(235, 349);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(18, 13);
            dLabel.TabIndex = 15;
            dLabel.Text = "D:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Location = new System.Drawing.Point(417, 247);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(50, 13);
            dAP_ANLabel.TabIndex = 17;
            dAP_ANLabel.Text = "DAP AN:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(426, 287);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(41, 13);
            mAGVLabel.TabIndex = 19;
            mAGVLabel.Text = "MAGV:";
            // 
            // tN_CSDLPTDS
            // 
            this.tN_CSDLPTDS.DataSetName = "TN_CSDLPTDS";
            this.tN_CSDLPTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bODEBindingSource
            // 
            this.bODEBindingSource.DataMember = "BODE";
            this.bODEBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // bODEDataGridView
            // 
            this.bODEDataGridView.AutoGenerateColumns = false;
            this.bODEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bODEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.bODEDataGridView.DataSource = this.bODEBindingSource;
            this.bODEDataGridView.Location = new System.Drawing.Point(42, -1);
            this.bODEDataGridView.Name = "bODEDataGridView";
            this.bODEDataGridView.Size = new System.Drawing.Size(1014, 220);
            this.bODEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CAUHOI";
            this.dataGridViewTextBoxColumn1.HeaderText = "CAUHOI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAMH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TRINHDO";
            this.dataGridViewTextBoxColumn3.HeaderText = "TRINHDO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NOIDUNG";
            this.dataGridViewTextBoxColumn4.HeaderText = "NOIDUNG";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "A";
            this.dataGridViewTextBoxColumn5.HeaderText = "A";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "B";
            this.dataGridViewTextBoxColumn6.HeaderText = "B";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "C";
            this.dataGridViewTextBoxColumn7.HeaderText = "C";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "D";
            this.dataGridViewTextBoxColumn8.HeaderText = "D";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DAP_AN";
            this.dataGridViewTextBoxColumn9.HeaderText = "DAP_AN";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MAGV";
            this.dataGridViewTextBoxColumn10.HeaderText = "MAGV";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // mAMHTextBox
            // 
            this.mAMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "MAMH", true));
            this.mAMHTextBox.Location = new System.Drawing.Point(78, 288);
            this.mAMHTextBox.Name = "mAMHTextBox";
            this.mAMHTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAMHTextBox.TabIndex = 2;
            // 
            // cAUHOITextBox
            // 
            this.cAUHOITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "CAUHOI", true));
            this.cAUHOITextBox.Location = new System.Drawing.Point(78, 241);
            this.cAUHOITextBox.Name = "cAUHOITextBox";
            this.cAUHOITextBox.Size = new System.Drawing.Size(100, 20);
            this.cAUHOITextBox.TabIndex = 4;
            // 
            // tRINHDOTextBox
            // 
            this.tRINHDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "TRINHDO", true));
            this.tRINHDOTextBox.Location = new System.Drawing.Point(78, 338);
            this.tRINHDOTextBox.Name = "tRINHDOTextBox";
            this.tRINHDOTextBox.Size = new System.Drawing.Size(100, 20);
            this.tRINHDOTextBox.TabIndex = 6;
            // 
            // nOIDUNGTextBox
            // 
            this.nOIDUNGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "NOIDUNG", true));
            this.nOIDUNGTextBox.Location = new System.Drawing.Point(78, 388);
            this.nOIDUNGTextBox.Name = "nOIDUNGTextBox";
            this.nOIDUNGTextBox.Size = new System.Drawing.Size(327, 20);
            this.nOIDUNGTextBox.TabIndex = 8;
            // 
            // aTextBox
            // 
            this.aTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "A", true));
            this.aTextBox.Location = new System.Drawing.Point(259, 241);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 20);
            this.aTextBox.TabIndex = 10;
            // 
            // bTextBox
            // 
            this.bTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "B", true));
            this.bTextBox.Location = new System.Drawing.Point(259, 280);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 12;
            this.bTextBox.TextChanged += new System.EventHandler(this.bTextBox_TextChanged);
            // 
            // cTextBox
            // 
            this.cTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "C", true));
            this.cTextBox.Location = new System.Drawing.Point(259, 316);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(100, 20);
            this.cTextBox.TabIndex = 14;
            // 
            // dTextBox
            // 
            this.dTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "D", true));
            this.dTextBox.Location = new System.Drawing.Point(259, 346);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(100, 20);
            this.dTextBox.TabIndex = 16;
            // 
            // dAP_ANTextBox
            // 
            this.dAP_ANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "DAP_AN", true));
            this.dAP_ANTextBox.Location = new System.Drawing.Point(473, 244);
            this.dAP_ANTextBox.Name = "dAP_ANTextBox";
            this.dAP_ANTextBox.Size = new System.Drawing.Size(100, 20);
            this.dAP_ANTextBox.TabIndex = 18;
            // 
            // txtMAGV
            // 
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bODEBindingSource, "MAGV", true));
            this.txtMAGV.Location = new System.Drawing.Point(473, 284);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(100, 20);
            this.txtMAGV.TabIndex = 20;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(667, 247);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(667, 291);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(75, 23);
            this.btnGhi.TabIndex = 22;
            this.btnGhi.Text = "ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(667, 339);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // frmBODE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 612);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(mAGVLabel);
            this.Controls.Add(this.txtMAGV);
            this.Controls.Add(dAP_ANLabel);
            this.Controls.Add(this.dAP_ANTextBox);
            this.Controls.Add(dLabel);
            this.Controls.Add(this.dTextBox);
            this.Controls.Add(cLabel);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(bLabel);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(aLabel);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(nOIDUNGLabel);
            this.Controls.Add(this.nOIDUNGTextBox);
            this.Controls.Add(tRINHDOLabel);
            this.Controls.Add(this.tRINHDOTextBox);
            this.Controls.Add(cAUHOILabel);
            this.Controls.Add(this.cAUHOITextBox);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.mAMHTextBox);
            this.Controls.Add(this.bODEDataGridView);
            this.Name = "frmBODE";
            this.Text = "frmBODE";
            this.Load += new System.EventHandler(this.frmBODE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPTDS tN_CSDLPTDS;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private TN_CSDLPTDSTableAdapters.BODETableAdapter bODETableAdapter;
        private TN_CSDLPTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bODEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox mAMHTextBox;
        private System.Windows.Forms.TextBox cAUHOITextBox;
        private System.Windows.Forms.TextBox tRINHDOTextBox;
        private System.Windows.Forms.TextBox nOIDUNGTextBox;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.TextBox dAP_ANTextBox;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnXoa;
        private TN_CSDLPTDSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private TN_CSDLPTDSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
    }
}