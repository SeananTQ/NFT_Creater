// <copyright file="CollectionService.cs" company="Tedeschi">
// Copyright (c) Tedeschi. All rights reserved.
// </copyright>

namespace NFTCreater.NFT.Services.Collection
{
    using System;
    using System.Collections.Generic;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using NFTCreater.NFT.Event;
    using NFTCreater.NFT.Model;
    using NFTCreater.NFT.Services.Generator;
    using NFTCreater.NFT.Services.Image;
    using NFTCreater.NFT.Services.Layer;
    using NFTCreater.NFT.Services.Metadata;

    internal class CollectionService : ICollectionService
    {
        private readonly ILayerService layerService;
        private readonly IGeneratorService generatorService;
        private readonly IImageService imageService;
        private readonly IMetadataService metadataService;
        private readonly IRarityService rarityService;

        public CollectionService(ILayerService layerService, IGeneratorService generatorService, IImageService imageService, IMetadataService metadataService, IRarityService rarityService)
        {
            this.layerService = layerService;
            this.generatorService = generatorService;
            this.imageService = imageService;
            this.metadataService = metadataService;
            this.rarityService = rarityService;
        }

        public event EventHandler<ImageEventArgs> CollectionItemStatus;

        
        public void Create(string layersFolder, string outputFolder, int metadataType, string metadataDescription, string metadataImageBaseUri, string metadataExternalUrl, bool metadataUseFileExtension, int collectionSize, int collectionInitialNumber, string collectionImagePrefix)
        {
            var layers = this.layerService.Load(layersFolder);

            var imageDescriptors = this.generatorService.Create(layers, collectionSize, layersFolder);
            var currentNumber = collectionInitialNumber;
            var metadataList = new List<Metadata>();
            //百分比
            int percentage = 0;
            // Handle Images folder
            var imagesFoder = $"{outputFolder}{Path.DirectorySeparatorChar}{Constants.ImagesFolderName}";


            //如果文件夹已存在删除文件夹，并新建文件夹
            if (Directory.Exists(imagesFoder))
            {
                Directory.Delete(imagesFoder, true);
            }
            Directory.CreateDirectory(imagesFoder);

            // Handle Metadata folder
            var metadataLocation = $"{outputFolder}{Path.DirectorySeparatorChar}{Constants.MetadataDefault.FolderName}";

            if (Directory.Exists(metadataLocation))
            {
                Directory.Delete(metadataLocation, true);
            }

            // Handle Rarity folder
            var rarityLocation = $"{outputFolder}{Path.DirectorySeparatorChar}{Constants.RarityDefault.FolderName}";

            if (Directory.Exists(rarityLocation))
            {
                Directory.Delete(rarityLocation, true);
            }

            //开始循环
            foreach (var item in imageDescriptors)
            {
                var combinedImages = this.imageService.Combine(item.Files.ToArray());
                var filename = $"{currentNumber}{Constants.FileExtension.Png}";
                var name = $"{currentNumber}";

                //文件名与NFT在JSON中的名字
                if (!string.IsNullOrWhiteSpace(collectionImagePrefix))
                {
                    name = $"{collectionImagePrefix}{currentNumber}";
                    filename = $"{collectionImagePrefix}{currentNumber}{Constants.FileExtension.Png}";
                }

                var metadata = new Metadata
                {
                    Id = currentNumber,
                    Dna = item.Dna,
                    Name = name,
                    Filename = Uri.EscapeDataString(filename),
                    Description = metadataDescription,
                    Image = $"{metadataImageBaseUri}/{Uri.EscapeDataString(filename)}",
                    ExternalUrl = metadataExternalUrl,
                    Attributes = item.Attributes.Select(i => new Model.Attribute { Layer = i.Layer, Value = i.Value }).ToList(),
                };

                metadataList.Add(metadata);

                combinedImages.Save($"{imagesFoder}{Path.DirectorySeparatorChar}{filename}", ImageFormat.Png);

                var args = new ImageEventArgs
                {
                    CollectionItemId = currentNumber,
                    CompleteCount=metadataList.Count,
                    TotalCount =imageDescriptors.Count,
                    Percentage = (int)(((metadataList.Count / imageDescriptors.Count) + 0.005f) * 100),
                };

                this.OnCollectionItemProcessed(args);

                // Disposing image
                combinedImages?.Dispose();

                currentNumber++;
            }

            this.metadataService.Generate(outputFolder, metadataList, metadataType, metadataUseFileExtension);

            this.rarityService.Generate(outputFolder, metadataList, metadataType);
        }

        private void OnCollectionItemProcessed(ImageEventArgs eventArgs)
        {
            this.CollectionItemStatus?.Invoke(this, eventArgs);
        }
    }
}
