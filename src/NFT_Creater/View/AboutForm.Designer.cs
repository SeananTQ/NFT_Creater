
namespace NFTCreater.NFT.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelDevelopedBy = new System.Windows.Forms.Label();
            this.labelSite = new System.Windows.Forms.Label();
            this.buttonCopyWalletAddress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LK_mySide = new System.Windows.Forms.LinkLabel();
            this.linkLabelSiteUrl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NFTCreater.NFT.Resources.Resource.logo;
            this.pictureBox1.Location = new System.Drawing.Point(46, 140);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(339, 62);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "<app>";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(380, 529);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(190, 48);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkOnClick);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.Location = new System.Drawing.Point(549, 62);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(100, 25);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "<version>";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDevelopedBy
            // 
            this.labelDevelopedBy.AutoSize = true;
            this.labelDevelopedBy.Location = new System.Drawing.Point(339, 96);
            this.labelDevelopedBy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDevelopedBy.Name = "labelDevelopedBy";
            this.labelDevelopedBy.Size = new System.Drawing.Size(154, 24);
            this.labelDevelopedBy.TabIndex = 4;
            this.labelDevelopedBy.Text = "<developed by>";
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(339, 155);
            this.labelSite.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(0, 24);
            this.labelSite.TabIndex = 5;
            // 
            // buttonCopyWalletAddress
            // 
            this.buttonCopyWalletAddress.BackgroundImage = global::NFTCreater.NFT.Resources.Resource.copy;
            this.buttonCopyWalletAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCopyWalletAddress.Location = new System.Drawing.Point(715, 382);
            this.buttonCopyWalletAddress.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCopyWalletAddress.Name = "buttonCopyWalletAddress";
            this.buttonCopyWalletAddress.Size = new System.Drawing.Size(101, 83);
            this.buttonCopyWalletAddress.TabIndex = 9;
            this.buttonCopyWalletAddress.UseVisualStyleBackColor = true;
            this.buttonCopyWalletAddress.Click += new System.EventHandler(this.ButtonCopyWalletAddressOnClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(339, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 83);
            this.label1.TabIndex = 10;
            this.label1.Text = "右边那个按钮是原作者的以太坊钱包地址，想捐助的可以点，虽然到目前为止没有一个人捐赠过";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "如果你对国内NFT感兴趣,可以关注这个UP主";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(339, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 59);
            this.label3.TabIndex = 12;
            this.label3.Text = "至于我的网站...还在建设中,确切的说我还没开始学习如何建站,但是总有一天会建好的,对吧 : )";
            // 
            // LK_mySide
            // 
            this.LK_mySide.AutoSize = true;
            this.LK_mySide.Location = new System.Drawing.Point(339, 292);
            this.LK_mySide.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LK_mySide.Name = "LK_mySide";
            this.LK_mySide.Size = new System.Drawing.Size(103, 24);
            this.LK_mySide.TabIndex = 13;
            this.LK_mySide.TabStop = true;
            this.LK_mySide.Text = "<my side>";
            this.LK_mySide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LK_mySide_LinkClicked);
            // 
            // linkLabelSiteUrl
            // 
            this.linkLabelSiteUrl.AutoSize = true;
            this.linkLabelSiteUrl.Location = new System.Drawing.Point(339, 177);
            this.linkLabelSiteUrl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabelSiteUrl.Name = "linkLabelSiteUrl";
            this.linkLabelSiteUrl.Size = new System.Drawing.Size(130, 24);
            this.linkLabelSiteUrl.TabIndex = 6;
            this.linkLabelSiteUrl.TabStop = true;
            this.linkLabelSiteUrl.Text = "<bilibili side>";
            this.linkLabelSiteUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSiteUrlOnClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(946, 602);
            this.ControlBox = false;
            this.Controls.Add(this.LK_mySide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCopyWalletAddress);
            this.Controls.Add(this.linkLabelSiteUrl);
            this.Controls.Add(this.labelSite);
            this.Controls.Add(this.labelDevelopedBy);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelDevelopedBy;
        private System.Windows.Forms.Label labelSite;
        private System.Windows.Forms.Button buttonCopyWalletAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LK_mySide;
        private System.Windows.Forms.LinkLabel linkLabelSiteUrl;
    }
}