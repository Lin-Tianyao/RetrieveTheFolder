
namespace RetrieveTheFolder
{
    partial class FormRetrieve
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbFolder = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.gbxRetrieveResult = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.RowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolderSizeG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolderPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.ckbGroupFolder = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.ckbOnlyBaseFolder = new System.Windows.Forms.CheckBox();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.cmbUnitFilter = new System.Windows.Forms.ComboBox();
            this.gbxRetrieveResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.gbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbFolder
            // 
            this.txbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFolder.Location = new System.Drawing.Point(84, 5);
            this.txbFolder.Name = "txbFolder";
            this.txbFolder.Size = new System.Drawing.Size(766, 21);
            this.txbFolder.TabIndex = 1;
            this.txbFolder.Text = "E:\\";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetrieve.Location = new System.Drawing.Point(861, 4);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 2;
            this.btnRetrieve.Text = "检索文件夹";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // gbxRetrieveResult
            // 
            this.gbxRetrieveResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRetrieveResult.Controls.Add(this.progressBar1);
            this.gbxRetrieveResult.Controls.Add(this.dgvData);
            this.gbxRetrieveResult.Location = new System.Drawing.Point(3, 134);
            this.gbxRetrieveResult.Name = "gbxRetrieveResult";
            this.gbxRetrieveResult.Size = new System.Drawing.Size(936, 493);
            this.gbxRetrieveResult.TabIndex = 3;
            this.gbxRetrieveResult.TabStop = false;
            this.gbxRetrieveResult.Text = "检索结果";
            this.gbxRetrieveResult.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(307, 207);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // dgvData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNo,
            this.colFolderName,
            this.colFolderSizeG,
            this.colFolderLevel,
            this.colFolderPath});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 17);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 20;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(930, 473);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseDoubleClick);
            // 
            // RowNo
            // 
            this.RowNo.DataPropertyName = "No";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RowNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.RowNo.HeaderText = "序号";
            this.RowNo.Name = "RowNo";
            this.RowNo.Width = 60;
            // 
            // colFolderName
            // 
            this.colFolderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFolderName.DataPropertyName = "DirectoryName";
            this.colFolderName.FillWeight = 50F;
            this.colFolderName.HeaderText = "文件夹名称";
            this.colFolderName.Name = "colFolderName";
            // 
            // colFolderSizeG
            // 
            this.colFolderSizeG.DataPropertyName = "SizeDisplay";
            this.colFolderSizeG.HeaderText = "文件夹大小";
            this.colFolderSizeG.Name = "colFolderSizeG";
            this.colFolderSizeG.Width = 90;
            // 
            // colFolderLevel
            // 
            this.colFolderLevel.DataPropertyName = "Level";
            this.colFolderLevel.HeaderText = "目录级次";
            this.colFolderLevel.Name = "colFolderLevel";
            this.colFolderLevel.Width = 80;
            // 
            // colFolderPath
            // 
            this.colFolderPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFolderPath.DataPropertyName = "DirectoryPath";
            this.colFolderPath.HeaderText = "文件夹路径";
            this.colFolderPath.Name = "colFolderPath";
            this.colFolderPath.ReadOnly = true;
            this.colFolderPath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "选择路径";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件大于：";
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(81, 19);
            this.nudValue.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(62, 21);
            this.nudValue.TabIndex = 6;
            this.nudValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbGroupFolder
            // 
            this.ckbGroupFolder.AutoSize = true;
            this.ckbGroupFolder.Location = new System.Drawing.Point(24, 70);
            this.ckbGroupFolder.Name = "ckbGroupFolder";
            this.ckbGroupFolder.Size = new System.Drawing.Size(144, 16);
            this.ckbGroupFolder.TabIndex = 9;
            this.ckbGroupFolder.Text = "是否按文件夹分组显示";
            this.ckbGroupFolder.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(249, 73);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "过滤";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Visible = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ckbOnlyBaseFolder
            // 
            this.ckbOnlyBaseFolder.AutoSize = true;
            this.ckbOnlyBaseFolder.Checked = true;
            this.ckbOnlyBaseFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbOnlyBaseFolder.Location = new System.Drawing.Point(24, 47);
            this.ckbOnlyBaseFolder.Name = "ckbOnlyBaseFolder";
            this.ckbOnlyBaseFolder.Size = new System.Drawing.Size(132, 16);
            this.ckbOnlyBaseFolder.TabIndex = 9;
            this.ckbOnlyBaseFolder.Text = "仅显示第一层文件夹";
            this.ckbOnlyBaseFolder.UseVisualStyleBackColor = true;
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.cmbUnitFilter);
            this.gbxFilter.Controls.Add(this.ckbOnlyBaseFolder);
            this.gbxFilter.Controls.Add(this.ckbGroupFolder);
            this.gbxFilter.Controls.Add(this.nudValue);
            this.gbxFilter.Controls.Add(this.label2);
            this.gbxFilter.Location = new System.Drawing.Point(6, 33);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(222, 95);
            this.gbxFilter.TabIndex = 11;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "过滤条件";
            // 
            // cmbUnitFilter
            // 
            this.cmbUnitFilter.FormattingEnabled = true;
            this.cmbUnitFilter.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB",
            "TB"});
            this.cmbUnitFilter.Location = new System.Drawing.Point(146, 19);
            this.cmbUnitFilter.Name = "cmbUnitFilter";
            this.cmbUnitFilter.Size = new System.Drawing.Size(38, 20);
            this.cmbUnitFilter.TabIndex = 10;
            // 
            // FormRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 639);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.gbxRetrieveResult);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.txbFolder);
            this.Name = "FormRetrieve";
            this.Text = "检索文件夹大小";
            this.Load += new System.EventHandler(this.FormRetrieve_Load);
            this.Shown += new System.EventHandler(this.FormRetrieve_Shown);
            this.gbxRetrieveResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbFolder;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.GroupBox gbxRetrieveResult;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.CheckBox ckbGroupFolder;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox ckbOnlyBaseFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolderSizeG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolderLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolderPath;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.ComboBox cmbUnitFilter;
    }
}

