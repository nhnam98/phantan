namespace PTcsdl
{
    partial class frmTaologin
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            this.tN_CSDLPTDS = new PTcsdl.TN_CSDLPTDS();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager();
            this.kHOATableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.KHOATableAdapter();
            this.gIAOVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.txtMAKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLOGIN = new System.Windows.Forms.TextBox();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.cbROLE = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.tENTextBox = new System.Windows.Forms.TextBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            mAGVLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(43, 267);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(41, 13);
            mAGVLabel.TabIndex = 1;
            mAGVLabel.Text = "MAGV:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(43, 314);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(41, 13);
            mAKHLabel.TabIndex = 3;
            mAKHLabel.Text = "MAKH:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(250, 267);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 13;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(244, 310);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(32, 13);
            tENLabel.TabIndex = 15;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(230, 336);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(46, 13);
            dIACHILabel.TabIndex = 17;
            dIACHILabel.Text = "DIACHI:";
            // 
            // tN_CSDLPTDS
            // 
            this.tN_CSDLPTDS.DataSetName = "TN_CSDLPTDS";
            this.tN_CSDLPTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
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
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIENDataGridView
            // 
            this.gIAOVIENDataGridView.AutoGenerateColumns = false;
            this.gIAOVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gIAOVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gIAOVIENDataGridView.DataSource = this.gIAOVIENBindingSource;
            this.gIAOVIENDataGridView.Location = new System.Drawing.Point(23, 12);
            this.gIAOVIENDataGridView.Name = "gIAOVIENDataGridView";
            this.gIAOVIENDataGridView.Size = new System.Drawing.Size(544, 220);
            this.gIAOVIENDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAGV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAGV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HO";
            this.dataGridViewTextBoxColumn2.HeaderText = "HO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn5.HeaderText = "MAKH";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // txtMAGV
            // 
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "MAGV", true));
            this.txtMAGV.Location = new System.Drawing.Point(90, 264);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(100, 20);
            this.txtMAGV.TabIndex = 2;
            // 
            // txtMAKH
            // 
            this.txtMAKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "MAKH", true));
            this.txtMAKH.Location = new System.Drawing.Point(90, 307);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(100, 20);
            this.txtMAKH.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Role";
            // 
            // txtLOGIN
            // 
            this.txtLOGIN.Location = new System.Drawing.Point(90, 343);
            this.txtLOGIN.Name = "txtLOGIN";
            this.txtLOGIN.Size = new System.Drawing.Size(100, 20);
            this.txtLOGIN.TabIndex = 8;
            // 
            // txtPASS
            // 
            this.txtPASS.Location = new System.Drawing.Point(90, 382);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.Size = new System.Drawing.Size(100, 20);
            this.txtPASS.TabIndex = 9;
            // 
            // cbROLE
            // 
            this.cbROLE.FormattingEnabled = true;
            this.cbROLE.Location = new System.Drawing.Point(90, 417);
            this.cbROLE.Name = "cbROLE";
            this.cbROLE.Size = new System.Drawing.Size(100, 21);
            this.cbROLE.TabIndex = 10;
            this.cbROLE.SelectedIndexChanged += new System.EventHandler(this.cbROLE_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(457, 267);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // hOTextBox
            // 
            this.hOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "HO", true));
            this.hOTextBox.Location = new System.Drawing.Point(282, 264);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.Size = new System.Drawing.Size(100, 20);
            this.hOTextBox.TabIndex = 14;
            // 
            // tENTextBox
            // 
            this.tENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "TEN", true));
            this.tENTextBox.Location = new System.Drawing.Point(282, 303);
            this.tENTextBox.Name = "tENTextBox";
            this.tENTextBox.Size = new System.Drawing.Size(100, 20);
            this.tENTextBox.TabIndex = 16;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(282, 333);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(100, 20);
            this.dIACHITextBox.TabIndex = 18;
            // 
            // frmTaologin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(dIACHILabel);
            this.Controls.Add(this.dIACHITextBox);
            this.Controls.Add(tENLabel);
            this.Controls.Add(this.tENTextBox);
            this.Controls.Add(hOLabel);
            this.Controls.Add(this.hOTextBox);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbROLE);
            this.Controls.Add(this.txtPASS);
            this.Controls.Add(this.txtLOGIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(mAKHLabel);
            this.Controls.Add(this.txtMAKH);
            this.Controls.Add(mAGVLabel);
            this.Controls.Add(this.txtMAGV);
            this.Controls.Add(this.gIAOVIENDataGridView);
            this.Name = "frmTaologin";
            this.Text = "frmTaologin";
            this.Load += new System.EventHandler(this.frmTaologin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPTDS tN_CSDLPTDS;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private TN_CSDLPTDSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private TN_CSDLPTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gIAOVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.TextBox txtMAKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLOGIN;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.ComboBox cbROLE;
        private System.Windows.Forms.Button btnThem;
        private TN_CSDLPTDSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private System.Windows.Forms.TextBox hOTextBox;
        private System.Windows.Forms.TextBox tENTextBox;
        private System.Windows.Forms.TextBox dIACHITextBox;
    }
}