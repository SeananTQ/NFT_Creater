// <copyright file="IRarityService.cs" company="Tedeschi">
// Copyright (c) Tedeschi. All rights reserved.
// </copyright>

namespace NFTCreater.NFT.Services.Metadata
{
    using System.Collections.Generic;
    using NFTCreater.NFT.Model;

    public interface IRarityService
    {
        void Generate(string outputFolder, List<Metadata> metadataList, int type);
    }
}
