﻿// <copyright file="CollectionService.cs" company="Tedeschi">
// Copyright (c) Tedeschi. All rights reserved.
// </copyright>

namespace Tedeschi.NFT.Services.Collection
{
    using System.Collections.Generic;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using Tedeschi.NFT.Model;
    using Tedeschi.NFT.Services.Generator;
    using Tedeschi.NFT.Services.Image;
    using Tedeschi.NFT.Services.Layer;
    using Tedeschi.NFT.Services.Metadata;

    internal class CollectionService : ICollectionService
    {
        private readonly ILayerService layerService;
        private readonly IGeneratorService generatorService;
        private readonly IImageService imageService;
        private readonly IMetadataService metadataService;

        public CollectionService(ILayerService layerService, IGeneratorService generatorService, IImageService imageService, IMetadataService metadataService)
        {
            this.layerService = layerService;
            this.generatorService = generatorService;
            this.imageService = imageService;
            this.metadataService = metadataService;
        }

        public void Create(string layersFolder, string outputFolder, int metadataType, string metadataDescription, string metadataImageBaseUri, int collectionSize, int collectionInitialNumber, string collectionImagePrefix)
        {
            var layers = this.layerService.Load(layersFolder);

            var imageDescriptors = this.generatorService.Create(layers, collectionSize);
            var collectionNumber = collectionInitialNumber;
            var metadataList = new List<Metadata>();

            var imagesFoder = $"{outputFolder}\\{Constants.ImagesFolderName}";

            if (!Directory.Exists(imagesFoder))
            {
                Directory.CreateDirectory(imagesFoder);
            }

            foreach (var item in imageDescriptors)
            {
                var combinedImages = this.imageService.Combine(item.Files.ToArray());
                var filename = $"{collectionNumber}{Constants.FileExtension.Png}";
                var filenameWithoutExtension = $"{collectionNumber}";

                if (!string.IsNullOrWhiteSpace(collectionImagePrefix))
                {
                    filename = $"{collectionImagePrefix}{collectionNumber}{Constants.FileExtension.Png}";
                    filenameWithoutExtension = $"{collectionImagePrefix}{collectionNumber}";
                }

                var metadata = new Metadata
                {
                    Id = collectionNumber,
                    Dna = item.Dna,
                    Name = filenameWithoutExtension,
                    Filename = System.Uri.EscapeDataString(filename),
                    Description = metadataDescription,
                    Image = $"{metadataImageBaseUri}/{System.Uri.EscapeDataString(filename)}",
                    Attributes = item.Attributes.Select(i => new Attribute { Layer = i.Layer, Value = i.Value }).ToList(),
                };

                metadataList.Add(metadata);

                combinedImages.Save($"{imagesFoder}\\{filename}", ImageFormat.Png);

                // Disposing image
                combinedImages?.Dispose();

                collectionNumber++;
            }

            this.metadataService.Generate(outputFolder, metadataList, metadataType);
        }
    }
}