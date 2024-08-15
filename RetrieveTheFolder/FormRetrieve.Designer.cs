
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbFolder = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.colFolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolderSizeG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolderPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbGroupFolder = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择路径：";
            // 
            // txbFolder
            // 
            this.txbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFolder.Location = new System.Drawing.Point(84, 6);
            this.txbFolder.Name = "txbFolder";
            this.txbFolder.Size = new System.Drawing.Size(761, 21);
            this.txbFolder.TabIndex = 1;
            this.txbFolder.Text = "C:\\";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetrieve.Location = new System.Drawing.Point(770, 38);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 2;
            this.btnRetrieve.Text = "检索文件夹";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.dgvData);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 565);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索结果";
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
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFolderName,
            this.colFolderSizeG,
            this.colFolderLevel,
            this.colFolderPath});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 17);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 20;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(911, 545);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseDoubleClick);
            // 
            // colFolderName
            // 
            this.colFolderName.DataPropertyName = "DirectoryName";
            this.colFolderName.HeaderText = "文件夹名称";
            this.colFolderName.Name = "colFolderName";
            this.colFolderName.Width = 200;
            // 
            // colFolderSizeG
            // 
            this.colFolderSizeG.DataPropertyName = "SizeG";
            this.colFolderSizeG.HeaderText = "文件夹大小（G）";
            this.colFolderSizeG.Name = "colFolderSizeG";
            this.colFolderSizeG.Width = 120;
            // 
            // colFolderLevel
            // 
            this.colFolderLevel.DataPropertyName = "Level";
            this.colFolderLevel.HeaderText = "目录级次";
            this.colFolderLevel.Name = "colFolderLevel";
            this.colFolderLevel.Width = 120;
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
            this.btnSelect.Location = new System.Drawing.Point(851, 4);
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
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件大于：";
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(84, 35);
            this.nudValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(96, 21);
            this.nudValue.TabIndex = 6;
            this.nudValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "G";
            // 
            // ckbGroupFolder
            // 
            this.ckbGroupFolder.AutoSize = true;
            this.ckbGroupFolder.Location = new System.Drawing.Point(220, 40);
            this.ckbGroupFolder.Name = "ckbGroupFolder";
            this.ckbGroupFolder.Size = new System.Drawing.Size(144, 16);
            this.ckbGroupFolder.TabIndex = 9;
            this.ckbGroupFolder.Text = "是否按文件夹分组显示";
            this.ckbGroupFolder.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(851, 38);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "过滤";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // FormRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 639);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.ckbGroupFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.txbFolder);
            this.Controls.Add(this.label1);
            this.Name = "FormRetrieve";
            this.Text = "检索文件夹大小";
            this.Shown += new System.EventHandler(this.FormRetrieve_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFolder;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbGroupFolder;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolderSizeG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolderLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolderPath;
    }
}

