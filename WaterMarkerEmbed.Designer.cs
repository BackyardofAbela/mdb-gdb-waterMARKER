namespace WaterMarkerAE
{
    partial class WaterMarkerEmbed
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterMarkerEmbed));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.btnDelFile = new System.Windows.Forms.Button();
            this.btnSelFile = new System.Windows.Forms.Button();
            this.listFile = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmbeded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxFileType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxOutPath = new System.Windows.Forms.TextBox();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.group1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "水印信息：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 21);
            this.textBox1.TabIndex = 1;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(620, 6);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "编码信息";
            this.btnEncode.UseVisualStyleBackColor = true;
            // 
            // group1
            // 
            this.group1.Controls.Add(this.btnDelFile);
            this.group1.Controls.Add(this.btnSelFile);
            this.group1.Location = new System.Drawing.Point(13, 40);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(200, 66);
            this.group1.TabIndex = 3;
            this.group1.TabStop = false;
            this.group1.Text = "文件操作";
            // 
            // btnDelFile
            // 
            this.btnDelFile.Location = new System.Drawing.Point(97, 28);
            this.btnDelFile.Name = "btnDelFile";
            this.btnDelFile.Size = new System.Drawing.Size(75, 23);
            this.btnDelFile.TabIndex = 4;
            this.btnDelFile.Text = "删除文件";
            this.btnDelFile.UseVisualStyleBackColor = true;
            // 
            // btnSelFile
            // 
            this.btnSelFile.Location = new System.Drawing.Point(7, 28);
            this.btnSelFile.Name = "btnSelFile";
            this.btnSelFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelFile.TabIndex = 4;
            this.btnSelFile.Text = "文件加载";
            this.btnSelFile.UseVisualStyleBackColor = true;
            // 
            // listFile
            // 
            this.listFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colEmbeded});
            this.listFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listFile.GridLines = true;
            this.listFile.Location = new System.Drawing.Point(14, 122);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(681, 297);
            this.listFile.TabIndex = 4;
            this.listFile.UseCompatibleStateImageBehavior = false;
            this.listFile.View = System.Windows.Forms.View.Details;
            // 
            // colFileName
            // 
            this.colFileName.Text = "文件名称";
            this.colFileName.Width = 600;
            // 
            // colEmbeded
            // 
            this.colEmbeded.Text = "嵌入标志";
            this.colEmbeded.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxUnit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxFileType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(239, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件信息设置";
            // 
            // cbxUnit
            // 
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.Items.AddRange(new object[] {
            "米",
            "秒"});
            this.cbxUnit.Location = new System.Drawing.Point(199, 29);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(60, 20);
            this.cbxUnit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "单位：";
            // 
            // cbxFileType
            // 
            this.cbxFileType.FormattingEnabled = true;
            this.cbxFileType.Items.AddRange(new object[] {
            ".mdb",
            ".gdb"});
            this.cbxFileType.Location = new System.Drawing.Point(76, 28);
            this.cbxFileType.Name = "cbxFileType";
            this.cbxFileType.Size = new System.Drawing.Size(60, 20);
            this.cbxFileType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "输出路径：";
            // 
            // tbxOutPath
            // 
            this.tbxOutPath.Location = new System.Drawing.Point(73, 435);
            this.tbxOutPath.Name = "tbxOutPath";
            this.tbxOutPath.Size = new System.Drawing.Size(532, 21);
            this.tbxOutPath.TabIndex = 7;
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Location = new System.Drawing.Point(620, 433);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(75, 23);
            this.btnSearchFile.TabIndex = 8;
            this.btnSearchFile.Text = "浏览";
            this.btnSearchFile.UseVisualStyleBackColor = true;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(325, 463);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(53, 12);
            this.lblProgress.TabIndex = 9;
            this.lblProgress.Text = "进度信息";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 486);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(681, 23);
            this.progressBar.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(263, 517);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(365, 517);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(593, 515);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 13;
            // 
            // WaterMarkerEmbed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 545);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnSearchFile);
            this.Controls.Add(this.tbxOutPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaterMarkerEmbed";
            this.Text = "Arcgis矢量数据水印嵌入";
            this.group1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Button btnSelFile;
        private System.Windows.Forms.Button btnDelFile;
        private System.Windows.Forms.ListView listFile;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colEmbeded;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxFileType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxOutPath;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
    }
}

