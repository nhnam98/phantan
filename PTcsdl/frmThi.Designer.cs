namespace PTcsdl
{
    partial class frmThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBatdau = new System.Windows.Forms.Button();
            this.btnCausau = new System.Windows.Forms.Button();
            this.btnCautruoc = new System.Windows.Forms.Button();
            this.tN_CSDLPTDS = new PTcsdl.TN_CSDLPTDS();
            this.bODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new PTcsdl.TN_CSDLPTDSTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbND = new System.Windows.Forms.Label();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "00 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "00 ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "00 ";
            // 
            // btnBatdau
            // 
            this.btnBatdau.Location = new System.Drawing.Point(417, 59);
            this.btnBatdau.Name = "btnBatdau";
            this.btnBatdau.Size = new System.Drawing.Size(75, 23);
            this.btnBatdau.TabIndex = 3;
            this.btnBatdau.Text = "bắt đầu";
            this.btnBatdau.UseVisualStyleBackColor = true;
            this.btnBatdau.Click += new System.EventHandler(this.btnBatdau_Click);
            // 
            // btnCausau
            // 
            this.btnCausau.Location = new System.Drawing.Point(499, 108);
            this.btnCausau.Name = "btnCausau";
            this.btnCausau.Size = new System.Drawing.Size(75, 23);
            this.btnCausau.TabIndex = 6;
            this.btnCausau.Text = "câu sau >";
            this.btnCausau.UseVisualStyleBackColor = true;
            this.btnCausau.Click += new System.EventHandler(this.btnCausau_Click_1);
            // 
            // btnCautruoc
            // 
            this.btnCautruoc.Location = new System.Drawing.Point(418, 108);
            this.btnCautruoc.Name = "btnCautruoc";
            this.btnCautruoc.Size = new System.Drawing.Size(75, 23);
            this.btnCautruoc.TabIndex = 7;
            this.btnCautruoc.Text = " < câu trước";
            this.btnCautruoc.UseVisualStyleBackColor = true;
            this.btnCautruoc.Click += new System.EventHandler(this.btnCautruoc_Click_1);
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
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTcsdl.TN_CSDLPTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Location = new System.Drawing.Point(42, 270);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(14, 13);
            this.radioA.TabIndex = 8;
            this.radioA.TabStop = true;
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(435, 270);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(14, 13);
            this.radioB.TabIndex = 9;
            this.radioB.TabStop = true;
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(42, 408);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(14, 13);
            this.radioC.TabIndex = 10;
            this.radioC.TabStop = true;
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Location = new System.Drawing.Point(446, 408);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(14, 13);
            this.radioD.TabIndex = 11;
            this.radioD.TabStop = true;
            this.radioD.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbND
            // 
            this.lbND.AutoSize = true;
            this.lbND.Location = new System.Drawing.Point(39, 196);
            this.lbND.Name = "lbND";
            this.lbND.Size = new System.Drawing.Size(35, 13);
            this.lbND.TabIndex = 12;
            this.lbND.Text = "label4";
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Location = new System.Drawing.Point(498, 59);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetthuc.TabIndex = 13;
            this.btnKetthuc.Text = "kết thúc";
            this.btnKetthuc.UseVisualStyleBackColor = true;
            this.btnKetthuc.Click += new System.EventHandler(this.btnKetthuc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "THỜI GIAN THI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(453, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "LỰA CHỌN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "B";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(425, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "D";
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.lbND);
            this.Controls.Add(this.radioD);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.radioB);
            this.Controls.Add(this.radioA);
            this.Controls.Add(this.btnCautruoc);
            this.Controls.Add(this.btnCausau);
            this.Controls.Add(this.btnBatdau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThi";
            this.Text = "frmThi";
            this.Load += new System.EventHandler(this.frmThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bODEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBatdau;
        private System.Windows.Forms.Button btnCausau;
        private System.Windows.Forms.Button btnCautruoc;
        private TN_CSDLPTDS tN_CSDLPTDS;
        private System.Windows.Forms.BindingSource bODEBindingSource;
        private TN_CSDLPTDSTableAdapters.BODETableAdapter bODETableAdapter;
        private TN_CSDLPTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbND;
        private System.Windows.Forms.Button btnKetthuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}