
namespace NFTCreater.NFT.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonLayersFolder = new System.Windows.Forms.Button();
            this.textBoxLayersFolder = new System.Windows.Forms.TextBox();
            this.textBoxOutputFolder = new System.Windows.Forms.TextBox();
            this.buttonOutputFolder = new System.Windows.Forms.Button();
            this.layersFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_nftCount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_namePrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_nftInitialNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxMetadataUseFileExtension = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMetadataExternalUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMetadataImageBaseURI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMetadataDescription = new System.Windows.Forms.TextBox();
            this.comboBoxMetadataType = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTraitWeightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMetadataImageBaseURIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_help = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_openOutputFolder = new System.Windows.Forms.Button();
            this.BTN_openLayerFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLayersFolder
            // 
            this.buttonLayersFolder.Location = new System.Drawing.Point(598, 27);
            this.buttonLayersFolder.Margin = new System.Windows.Forms.Padding(5);
            this.buttonLayersFolder.Name = "buttonLayersFolder";
            this.buttonLayersFolder.Size = new System.Drawing.Size(118, 37);
            this.buttonLayersFolder.TabIndex = 2;
            this.buttonLayersFolder.Text = "图素路径...";
            this.buttonLayersFolder.UseVisualStyleBackColor = true;
            this.buttonLayersFolder.Click += new System.EventHandler(this.ButtonLayersFolderOnClick);
            // 
            // textBoxLayersFolder
            // 
            this.textBoxLayersFolder.Location = new System.Drawing.Point(10, 32);
            this.textBoxLayersFolder.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxLayersFolder.Name = "textBoxLayersFolder";
            this.textBoxLayersFolder.Size = new System.Drawing.Size(579, 30);
            this.textBoxLayersFolder.TabIndex = 1;
            // 
            // textBoxOutputFolder
            // 
            this.textBoxOutputFolder.Location = new System.Drawing.Point(10, 70);
            this.textBoxOutputFolder.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxOutputFolder.Name = "textBoxOutputFolder";
            this.textBoxOutputFolder.Size = new System.Drawing.Size(579, 30);
            this.textBoxOutputFolder.TabIndex = 3;
            // 
            // buttonOutputFolder
            // 
            this.buttonOutputFolder.Location = new System.Drawing.Point(598, 65);
            this.buttonOutputFolder.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOutputFolder.Name = "buttonOutputFolder";
            this.buttonOutputFolder.Size = new System.Drawing.Size(118, 37);
            this.buttonOutputFolder.TabIndex = 4;
            this.buttonOutputFolder.Text = "导出路径...";
            this.buttonOutputFolder.UseVisualStyleBackColor = true;
            this.buttonOutputFolder.Click += new System.EventHandler(this.ButtonOutputFolderOnClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLayersFolder);
            this.groupBox1.Controls.Add(this.textBoxOutputFolder);
            this.groupBox1.Controls.Add(this.buttonLayersFolder);
            this.groupBox1.Controls.Add(this.buttonOutputFolder);
            this.groupBox1.Location = new System.Drawing.Point(19, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(731, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入输出路径";
            // 
            // TB_nftCount
            // 
            this.TB_nftCount.Location = new System.Drawing.Point(185, 32);
            this.TB_nftCount.Margin = new System.Windows.Forms.Padding(5);
            this.TB_nftCount.Name = "TB_nftCount";
            this.TB_nftCount.Size = new System.Drawing.Size(188, 30);
            this.TB_nftCount.TabIndex = 10;
            this.TB_nftCount.Click += new System.EventHandler(this.TB_nftCount_Click);
            this.TB_nftCount.TextChanged += new System.EventHandler(this.Tb_nftCount_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_namePrefix);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TB_nftInitialNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TB_nftCount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(760, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(403, 159);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成参数";
            // 
            // TB_namePrefix
            // 
            this.TB_namePrefix.Location = new System.Drawing.Point(185, 107);
            this.TB_namePrefix.Margin = new System.Windows.Forms.Padding(5);
            this.TB_namePrefix.Name = "TB_namePrefix";
            this.TB_namePrefix.Size = new System.Drawing.Size(188, 30);
            this.TB_namePrefix.TabIndex = 12;
            this.TB_namePrefix.TextChanged += new System.EventHandler(this.TB_namePrefix_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "NFT前缀";
            // 
            // TB_nftInitialNumber
            // 
            this.TB_nftInitialNumber.Location = new System.Drawing.Point(185, 70);
            this.TB_nftInitialNumber.Margin = new System.Windows.Forms.Padding(5);
            this.TB_nftInitialNumber.Name = "TB_nftInitialNumber";
            this.TB_nftInitialNumber.Size = new System.Drawing.Size(188, 30);
            this.TB_nftInitialNumber.TabIndex = 11;
            this.TB_nftInitialNumber.Click += new System.EventHandler(this.TB_nftInitialNumber_Click);
            this.TB_nftInitialNumber.TextChanged += new System.EventHandler(this.TB_nftInitialNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "起始编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "生成数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "数据生成模式";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(760, 453);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(180, 48);
            this.buttonGenerate.TabIndex = 13;
            this.buttonGenerate.Text = "开始生成";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerateOnClick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(206, 370);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 30);
            this.textBox1.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxMetadataUseFileExtension);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxMetadataExternalUrl);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxMetadataImageBaseURI);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxMetadataDescription);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBoxMetadataType);
            this.groupBox3.Location = new System.Drawing.Point(19, 228);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(731, 273);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "元数据文件_非程序员人士用不到这块，请忽略";
            // 
            // checkBoxMetadataUseFileExtension
            // 
            this.checkBoxMetadataUseFileExtension.AutoSize = true;
            this.checkBoxMetadataUseFileExtension.Location = new System.Drawing.Point(546, 34);
            this.checkBoxMetadataUseFileExtension.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxMetadataUseFileExtension.Name = "checkBoxMetadataUseFileExtension";
            this.checkBoxMetadataUseFileExtension.Size = new System.Drawing.Size(170, 28);
            this.checkBoxMetadataUseFileExtension.TabIndex = 20;
            this.checkBoxMetadataUseFileExtension.Text = "以 .json为后缀名";
            this.checkBoxMetadataUseFileExtension.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "外部URL";
            // 
            // textBoxMetadataExternalUrl
            // 
            this.textBoxMetadataExternalUrl.Location = new System.Drawing.Point(197, 227);
            this.textBoxMetadataExternalUrl.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMetadataExternalUrl.Name = "textBoxMetadataExternalUrl";
            this.textBoxMetadataExternalUrl.Size = new System.Drawing.Size(496, 30);
            this.textBoxMetadataExternalUrl.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(22, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 53);
            this.label6.TabIndex = 16;
            this.label6.Text = "图片存放在IPFS服务器上的URL";
            // 
            // textBoxMetadataImageBaseURI
            // 
            this.textBoxMetadataImageBaseURI.Location = new System.Drawing.Point(197, 179);
            this.textBoxMetadataImageBaseURI.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMetadataImageBaseURI.Name = "textBoxMetadataImageBaseURI";
            this.textBoxMetadataImageBaseURI.Size = new System.Drawing.Size(496, 30);
            this.textBoxMetadataImageBaseURI.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "NFT的描述使劲吹吧";
            // 
            // textBoxMetadataDescription
            // 
            this.textBoxMetadataDescription.Location = new System.Drawing.Point(197, 78);
            this.textBoxMetadataDescription.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMetadataDescription.Multiline = true;
            this.textBoxMetadataDescription.Name = "textBoxMetadataDescription";
            this.textBoxMetadataDescription.Size = new System.Drawing.Size(496, 82);
            this.textBoxMetadataDescription.TabIndex = 7;
            // 
            // comboBoxMetadataType
            // 
            this.comboBoxMetadataType.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxMetadataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMetadataType.FormattingEnabled = true;
            this.comboBoxMetadataType.Items.AddRange(new object[] {
            "1 不生成元数据文件",
            "2 合并所有元数据为一个文件",
            "3 每个NFT一个文件",
            "2+3模式"});
            this.comboBoxMetadataType.Location = new System.Drawing.Point(197, 32);
            this.comboBoxMetadataType.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxMetadataType.Name = "comboBoxMetadataType";
            this.comboBoxMetadataType.Size = new System.Drawing.Size(303, 32);
            this.comboBoxMetadataType.TabIndex = 6;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 520);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 22, 0);
            this.statusStrip.Size = new System.Drawing.Size(1200, 30);
            this.statusStrip.TabIndex = 10;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(157, 22);
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(0, 23);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.MENU_help,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1200, 34);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkTraitWeightsToolStripMenuItem,
            this.updateMetadataImageBaseURIToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.toolsToolStripMenuItem.Text = "工具";
            // 
            // checkTraitWeightsToolStripMenuItem
            // 
            this.checkTraitWeightsToolStripMenuItem.Name = "checkTraitWeightsToolStripMenuItem";
            this.checkTraitWeightsToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.checkTraitWeightsToolStripMenuItem.Text = "查看部件概率表";
            this.checkTraitWeightsToolStripMenuItem.Click += new System.EventHandler(this.CheckTraitWeightsToolStripMenuItemOnClick);
            // 
            // updateMetadataImageBaseURIToolStripMenuItem
            // 
            this.updateMetadataImageBaseURIToolStripMenuItem.Name = "updateMetadataImageBaseURIToolStripMenuItem";
            this.updateMetadataImageBaseURIToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.updateMetadataImageBaseURIToolStripMenuItem.Text = "更新图片根URL";
            this.updateMetadataImageBaseURIToolStripMenuItem.Click += new System.EventHandler(this.UpdateMetadataImageBaseURIToolStripMenuItemOnClick);
            // 
            // MENU_help
            // 
            this.MENU_help.Name = "MENU_help";
            this.MENU_help.Size = new System.Drawing.Size(62, 28);
            this.MENU_help.Text = "帮助";
            this.MENU_help.Click += new System.EventHandler(this.MENU_help_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.helpToolStripMenuItem.Text = "关于";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutMenuItemOnClick);
            // 
            // BTN_openOutputFolder
            // 
            this.BTN_openOutputFolder.Location = new System.Drawing.Point(983, 453);
            this.BTN_openOutputFolder.Name = "BTN_openOutputFolder";
            this.BTN_openOutputFolder.Size = new System.Drawing.Size(180, 48);
            this.BTN_openOutputFolder.TabIndex = 14;
            this.BTN_openOutputFolder.Text = "查看生成的NFT";
            this.BTN_openOutputFolder.UseVisualStyleBackColor = true;
            this.BTN_openOutputFolder.Click += new System.EventHandler(this.BTN_openOutputFolder_Click);
            // 
            // BTN_openLayerFolder
            // 
            this.BTN_openLayerFolder.Location = new System.Drawing.Point(261, 160);
            this.BTN_openLayerFolder.Name = "BTN_openLayerFolder";
            this.BTN_openLayerFolder.Size = new System.Drawing.Size(180, 48);
            this.BTN_openLayerFolder.TabIndex = 15;
            this.BTN_openLayerFolder.Text = "查看图素";
            this.BTN_openLayerFolder.UseVisualStyleBackColor = true;
            this.BTN_openLayerFolder.Click += new System.EventHandler(this.BTN_openLayerFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.BTN_openLayerFolder);
            this.Controls.Add(this.BTN_openOutputFolder);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1628, 1035);
            this.MinimumSize = new System.Drawing.Size(1086, 523);
            this.Name = "MainForm";
            this.Text = "NFT_Creater";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_OnFormClosed);
            this.Load += new System.EventHandler(this.MainForm_OnLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLayersFolder;
        private System.Windows.Forms.TextBox textBoxLayersFolder;
        private System.Windows.Forms.TextBox textBoxOutputFolder;
        private System.Windows.Forms.Button buttonOutputFolder;
        private System.Windows.Forms.FolderBrowserDialog layersFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog outputFolderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_nftCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_namePrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_nftInitialNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMetadataImageBaseURIToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem checkTraitWeightsToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxMetadataUseFileExtension;
        private System.Windows.Forms.Button BTN_openOutputFolder;
        private System.Windows.Forms.Button BTN_openLayerFolder;
        private System.Windows.Forms.ToolStripMenuItem MENU_help;
        private System.Windows.Forms.TextBox textBoxMetadataExternalUrl;
        private System.Windows.Forms.TextBox textBoxMetadataImageBaseURI;
        private System.Windows.Forms.TextBox textBoxMetadataDescription;
        private System.Windows.Forms.ComboBox comboBoxMetadataType;
    }
}
