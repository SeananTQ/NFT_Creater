// <copyright file="MainForm.cs" company="Tedeschi">
// Copyright (c) Tedeschi. All rights reserved.
// </copyright>

namespace NFTCreater.NFT.View
{
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Windows.Forms;
    using NFTCreater.NFT.Event;
    using NFTCreater.NFT.Exception;
    using NFTCreater.NFT.Properties;
    using NFTCreater.NFT.Resources;
    using NFTCreater.NFT.Services.Collection;
    using NFTCreater.NFT.Services.Layer;
    using NFTCreater.NFT.Services.Metadata;
    using NFTCreater.NFT.Util;

    public partial class MainForm : Form
    {
        private readonly ILayerService layerService;
        private readonly ICollectionService collectionService;
        private readonly IMetadataService metadataService;

        private int nftCount;
        private int nftInitialNumber;
        private string namePrefix;




        public MainForm(ILayerService layerService, ICollectionService collectionService, IMetadataService metadataService)
        {
            this.InitializeComponent();

            this.layerService = layerService;
            this.collectionService = collectionService;
            this.metadataService = metadataService;

            this.Text = $"{Application.ProductName} v{Application.ProductVersion}";
        }

        private void MainForm_OnLoad(object sender, EventArgs e)
        {
            // Folders
            this.textBoxLayersFolder.Text = Properties.Settings.Default.LayersFolder;
            this.textBoxOutputFolder.Text = Properties.Settings.Default.OutputFolder;

            // Metadata
            this.comboBoxMetadataType.SelectedIndex = Properties.Settings.Default.MetadataType;
            this.textBoxMetadataDescription.Text = Properties.Settings.Default.MetadataDescription;
            this.textBoxMetadataImageBaseURI.Text = Properties.Settings.Default.MetadataImageBaseURI;
            this.textBoxMetadataExternalUrl.Text = Properties.Settings.Default.MetadataExternalUrl;
            this.checkBoxMetadataUseFileExtension.Checked = Properties.Settings.Default.MetadataUseFileExtension;

            // Collection
            this.TB_nftCount.Text = Properties.Settings.Default.CollectionSize;
            this.TB_nftInitialNumber.Text = Properties.Settings.Default.CollectionInitialNumber;
            this.TB_namePrefix.Text = Properties.Settings.Default.CollectionImageNamePrefix;
        }

        private void MainForm_OnFormClosed(object sender, FormClosedEventArgs e)
        {
            // Folders
            Properties.Settings.Default.LayersFolder = this.textBoxLayersFolder.Text;
            Properties.Settings.Default.OutputFolder = this.textBoxOutputFolder.Text;

            // Metadata
            Properties.Settings.Default.MetadataType = this.comboBoxMetadataType.SelectedIndex;
            Properties.Settings.Default.MetadataDescription = this.textBoxMetadataDescription.Text;
            Properties.Settings.Default.MetadataImageBaseURI = this.textBoxMetadataImageBaseURI.Text;
            Properties.Settings.Default.MetadataExternalUrl = this.textBoxMetadataExternalUrl.Text;
            Properties.Settings.Default.MetadataUseFileExtension = this.checkBoxMetadataUseFileExtension.Checked;

            // Collection
            Properties.Settings.Default.CollectionSize = this.TB_nftCount.Text;
            Properties.Settings.Default.CollectionInitialNumber = this.TB_nftInitialNumber.Text;
            Properties.Settings.Default.CollectionImageNamePrefix = this.TB_namePrefix.Text;

            Properties.Settings.Default.Save();
        }

        private void AboutMenuItemOnClick(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.Show();
        }

        private void UpdateMetadataImageBaseURIToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(Resource.CONFIRM_METADATA_UPDATE, Application.ProductName, MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var outputFolder = this.textBoxOutputFolder.Text;
                var metadataImageBaseUri = this.textBoxMetadataImageBaseURI.Text;
                var metadataType = this.comboBoxMetadataType.SelectedIndex;
                var metadataUseFileExtension = this.checkBoxMetadataUseFileExtension.Checked;

                try
                {
                    this.ValidateForUpdateMetadata(outputFolder, metadataImageBaseUri);
                    this.metadataService.Update(outputFolder, metadataImageBaseUri, metadataType, metadataUseFileExtension);

                    MessageBox.Show(Resource.METADATA_UPDATED_SUCCESSFULLY);
                }
                catch (InvalidSettingException ex)
                {
                    MessageBox.Show(string.Format(Resource.INVALID_SETTING_ERROR, ex.Message), Resource.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(Resource.UNKNOWN_ERROR, ex), Resource.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckTraitWeightsToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            try
            {
                var layersFolder = this.textBoxLayersFolder.Text;

                this.ValidateForCheckTraitWeights(layersFolder);

                var layers = this.layerService.Load(layersFolder);

                var weightedForm = new WeightedForm();
                weightedForm.Process(layers);
                weightedForm.ShowDialog();
            }
            catch (InvalidSettingException ex)
            {
                MessageBox.Show(string.Format(Resource.INVALID_SETTING_ERROR, ex.Message), Resource.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(Resource.UNKNOWN_ERROR, ex), Resource.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonLayersFolderOnClick(object sender, EventArgs e)
        {
            if (this.layersFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBoxLayersFolder.Text = this.layersFolderBrowserDialog.SelectedPath;
                //将路径保存到配置文件
                Properties.Settings.Default.LayersFolder = this.textBoxLayersFolder.Text;
                Properties.Settings.Default.Save();
                
            }
        }

        private void ButtonOutputFolderOnClick(object sender, EventArgs e)
        {
            if (this.outputFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBoxOutputFolder.Text = this.outputFolderBrowserDialog.SelectedPath;
                //将路径保存到配置文件
                Properties.Settings.Default.OutputFolder = this.outputFolderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void ButtonGenerateOnClick(object sender, EventArgs e)
        {
            // Remove focus from others
            this.ActiveControl = null;

            var layersFolder = this.textBoxLayersFolder.Text;
            var outputFolder = this.textBoxOutputFolder.Text;

            var metadataType = this.comboBoxMetadataType.SelectedIndex;
            var metadataDescription = this.textBoxMetadataDescription.Text;
            var metadataImageBaseUri = this.textBoxMetadataImageBaseURI.Text;
            var metadataExternalUrl = this.textBoxMetadataExternalUrl.Text;
            var metadataUseFileExtension = this.checkBoxMetadataUseFileExtension.Checked;

            var collectionSize = this.TB_nftCount.Text;
            var collectionInitialNumber = this.TB_nftInitialNumber.Text;
            var collectionImagePrefix = this.TB_namePrefix.Text;

            var bgw = new BackgroundWorker();
            bgw.DoWork += (_, __) =>
            {
                try
                {
                    this.ValidateForGeneration(layersFolder, outputFolder, metadataImageBaseUri, collectionSize, collectionInitialNumber);
                    this.collectionService.CollectionItemStatus += new EventHandler<ImageEventArgs>(this.OnCollectionItemProcessed);
                    this.collectionService.Create(layersFolder, outputFolder, metadataType, metadataDescription, metadataImageBaseUri, metadataExternalUrl, metadataUseFileExtension, this.nftCount, this.nftInitialNumber, this.namePrefix);

                    MessageBox.Show(Resource.COLLECTION_CREATED_SUCCESSFULLY);
                }
                catch (InvalidSettingException ex)
                {
                    MessageBox.Show(string.Format(Resource.INVALID_SETTING_ERROR, ex.Message), Resource.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidLayerNamingException ex)
                {
                    MessageBox.Show(string.Format(Resource.INVALID_LAYER_NAMING_ERROR, ex.Message), Resource.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DifferentLayerSizeException ex)
                {
                    MessageBox.Show(string.Format(Resource.DIFFERENT_LAYERS_DIMENSION_ERROR, ex.Message), Resource.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DuplicateDnaAttemptsException)
                {
                    MessageBox.Show(Resource.DUPLICATED_DNA_MAX_ATTEMPT_ERROR, Resource.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(Resource.UNKNOWN_ERROR, ex), Resource.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            bgw.RunWorkerCompleted += (_, __) =>
            {
                this.Cursor = Cursors.Default;
                ((Button)sender).Enabled = true;

                this.statusStrip.Text = string.Empty;
                this.toolStripProgressBar.Value = 0;

                this.Invoke(new Action(() =>
                {
                    this.toolStripStatus.Text = string.Empty;
                    this.toolStripProgressBar.Value = 0;
                }));

                // Remove focus from others
                this.ActiveControl = null;
            };

            this.Cursor = Cursors.WaitCursor;
            ((Button)sender).Enabled = false;

            bgw.RunWorkerAsync();
        }

        private void OnCollectionItemProcessed(object sender, ImageEventArgs e)
        {
            var status = string.Format(Resource.PROCESSING_COLLECTION_ITEM, e.CompleteCount, e.TotalCount);

            this.Invoke(new Action(() =>
            {
                this.toolStripStatus.Text = status;
                this.toolStripProgressBar.Value = e.Percentage;
              
            }));
        }

        private void ValidateForGeneration(string layersFolder, string outputFolder, string imageBaseUri, string collectionSize, string collectionInitialNumber)
        {
            if (!Directory.Exists(layersFolder))
            {
                throw new InvalidSettingException("Layer folder");
            }

            if (!Directory.Exists(outputFolder))
            {
                throw new InvalidSettingException("Output folder");
            }

            if (!ValidationUtil.IsUri(imageBaseUri))
            {
                throw new InvalidSettingException("Image Base URI");
            }

            if (!ValidationUtil.IsNumeric(collectionSize) || int.Parse(collectionSize) <= 0)
            {
                throw new InvalidSettingException("Collection size");
            }

            if (!ValidationUtil.IsNumeric(collectionInitialNumber) || int.Parse(collectionInitialNumber) < 0)
            {
                throw new InvalidSettingException("Collection initial number");
            }
        }

        private void ValidateForUpdateMetadata(string outputFolder, string imageBaseUri)
        {
            if (!Directory.Exists(outputFolder))
            {
                throw new InvalidSettingException("Output folder");
            }

            if (!ValidationUtil.IsUri(imageBaseUri))
            {
                throw new InvalidSettingException("Image Base URI");
            }
        }

        private void ValidateForCheckTraitWeights(string layersFolder)
        {
            if (!Directory.Exists(layersFolder))
            {
                throw new InvalidSettingException("Layers folder");
            }
        }

        private void Tb_nftCount_TextChanged(object sender, EventArgs e)
        {
            // 使用tryParse将string转换为int
            if (int.TryParse(this.TB_nftCount.Text, out this.nftCount))
            {
                if (this.nftCount < 0)
                {
                    this.nftCount = 0;
                    this.TB_nftCount.Text = "0";
                }
            }
            else
            {
                this.nftCount = 0;
                this.TB_nftCount.Text = "0";
            }
        }

        private void TB_nftInitialNumber_TextChanged(object sender, EventArgs e)
        {
            // 使用tryParse将string装换为int，如果不能转换或转换后的int小于1，则设置为1
            if (int.TryParse(this.TB_nftInitialNumber.Text, out this.nftInitialNumber) && this.nftInitialNumber >= 1)
            {
                this.nftInitialNumber = this.nftInitialNumber;
            }
            else
            {
                this.nftInitialNumber = 1;
                this.TB_nftInitialNumber.Text = "1";
            }

        }

        private void TB_namePrefix_TextChanged(object sender, EventArgs e)
        {
            this.namePrefix = this.TB_namePrefix.Text;
        }

        private void TB_nftCount_Click(object sender, EventArgs e)
        {
            //textBox被点击后选中所有文本
            this.TB_nftCount.SelectAll();
        }

        private void TB_nftInitialNumber_Click(object sender, EventArgs e)
        {
            //textBox被点击后选中所有文本
            this.TB_nftInitialNumber.SelectAll();
        }

        private void BTN_openOutputFolder_Click(object sender, EventArgs e)
        {
            // 根据路径打开文件
            System.Diagnostics.Process.Start("explorer.exe", Settings.Default.OutputFolder+"\\"+ Constants.ImagesFolderName+"\\");

        }

        private void BTN_openLayerFolder_Click(object sender, EventArgs e)
        {
            // 根据路径打开文件
            System.Diagnostics.Process.Start("explorer.exe", Settings.Default.LayersFolder);
        }

        private void MENU_help_Click(object sender, EventArgs e)
        {
            // 在屏幕中间弹出帮助窗口
            HelpForm helpForm = new HelpForm();
            helpForm.StartPosition = FormStartPosition.CenterScreen;
            helpForm.ShowDialog();
            
        }
    }
}
