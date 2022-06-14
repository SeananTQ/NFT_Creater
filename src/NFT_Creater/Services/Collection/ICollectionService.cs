// <copyright file="ICollectionService.cs" company="Tedeschi">
// Copyright (c) Tedeschi. All rights reserved.
// </copyright>

namespace NFTCreater.NFT.Services.Collection
{
    using System;
    using NFTCreater.NFT.Event;

    public interface ICollectionService
    {
        event EventHandler<ImageEventArgs> CollectionItemStatus;

        void Create(string layersFolder, string outputFolder, int metadataType, string metadataDescription, string metadataImageBaseUri, string metadataExternalUrl, bool metadataUseFileExtension, int collectionSize, int collectionInitialNumber, string collectionImagePrefix);
    }
}
