// <copyright file="IMetadataService.cs" company="Tedeschi">
// Copyright (c) Tedeschi. All rights reserved.
// </copyright>

namespace NFTCreater.NFT.Services.Metadata
{
    using System.Collections.Generic;
    using NFTCreater.NFT.Model;

    public interface IMetadataService
    {
        void Generate(string outputFolder, List<Metadata> metadataList, int type, bool useFileExtension);

        void Update(string outputFolder, string newImageBaseUri, int type, bool useFileExtension);
    }
}
