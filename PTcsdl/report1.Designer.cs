namespace PTcsdl
{
    partial class report1
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
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.tN_CSDLPTDS = new PTcsdl.TN_CSDLPTDS();
            this.sp_GetTranscriptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetTranscriptTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.sp_GetTranscriptTableAdapter();
            this.tableAdapterManager = new PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager();
            this.gIAOVIEN_DANGKYTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.lOPTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.MONHOCTableAdapter();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLan = new System.Windows.Forms.TextBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTenlop = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTenMH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetTranscriptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(76, 169);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(70, 13);
            lANLabel.TabIndex = 5;
            lANLabel.Text = "SỐ LẦN THI :";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(76, 75);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(55, 13);
            tENLOPLabel.TabIndex = 6;
            tENLOPLabel.Text = "TÊN LỚP :";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(76, 121);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(84, 13);
            tENMHLabel.TabIndex = 7;
            tENMHLabel.Text = "TÊN MÔN HỌC :";
            // 
            // tN_CSDLPTDS
            // 
            this.tN_CSDLPTDS.DataSetName = "TN_CSDLPTDS";
            this.tN_CSDLPTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GetTranscriptBindingSource
            // 
            this.sp_GetTranscriptBindingSource.DataMember = "sp_GetTranscript";
            this.sp_GetTranscriptBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // sp_GetTranscriptTableAdapter
            // 
            this.sp_GetTranscriptTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(194, 249);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(106, 23);
            this.btnBaocao.TabIndex = 2;
            this.btnBaocao.Text = "TẠO BÁO CÁO";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // txtLan
            // 
            this.txtLan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIEN_DANGKYBindingSource, "LAN", true));
            this.txtLan.Location = new System.Drawing.Point(171, 169);
            this.txtLan.Name = "txtLan";
            this.txtLan.Size = new System.Drawing.Size(182, 21);
            this.txtLan.TabIndex = 6;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // cbTenlop
            // 
            this.cbTenlop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.cbTenlop.DataSource = this.lOPBindingSource;
            this.cbTenlop.DisplayMember = "TENLOP";
            this.cbTenlop.FormattingEnabled = true;
            this.cbTenlop.Location = new System.Drawing.Point(171, 72);
            this.cbTenlop.Name = "cbTenlop";
            this.cbTenlop.Size = new System.Drawing.Size(182, 21);
            this.cbTenlop.TabIndex = 7;
            this.cbTenlop.ValueMember = "MALOP";
            this.cbTenlop.SelectedIndexChanged += new System.EventHandler(this.cbTenlop_SelectedIndexChanged);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.tN_CSDLPTDS;
            // 
            // cbTenMH
            // 
            this.cbTenMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.cbTenMH.DataSource = this.mONHOCBindingSource;
            this.cbTenMH.DisplayMember = "TENMH";
            this.cbTenMH.FormattingEnabled = true;
            this.cbTenMH.Location = new System.Drawing.Point(171, 121);
            this.cbTenMH.Name = "cbTenMH";
            this.cbTenMH.Size = new System.Drawing.Size(182, 21);
            this.cbTenMH.TabIndex = 8;
            this.cbTenMH.ValueMember = "MAMH";
            this.cbTenMH.SelectedIndexChanged += new System.EventHandler(this.tENMHComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "TẠO BÁO CÁO";
            // 
            // report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cbTenMH);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.cbTenlop);
            this.Controls.Add(lANLabel);
            this.Controls.Add(this.txtLan);
            this.Controls.Add(this.btnBaocao);
            this.Name = "report1";
            this.Text = "report1";
            this.Load += new System.EventHandler(this.report1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetTranscriptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPTDS tN_CSDLPTDS;
        private System.Windows.Forms.BindingSource sp_GetTranscriptBindingSource;
        private TN_CSDLPTDSTableAdapters.sp_GetTranscriptTableAdapter sp_GetTranscriptTableAdapter;
        private TN_CSDLPTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnBaocao;
        private TN_CSDLPTDSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private TN_CSDLPTDSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.TextBox txtLan;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private TN_CSDLPTDSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cbTenlop;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.ComboBox cbTenMH;
        private System.Windows.Forms.Label label1;
    }
}