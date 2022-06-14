// <copyright file="ILayerService.cs" company="Tedeschi">
// Copyright (c) Tedeschi. All rights reserved.
// </copyright>

namespace NFTCreater.NFT.Services.Layer
{
    using System.Collections.Generic;
    using NFTCreater.NFT.Model;

    public interface ILayerService
    {
        List<Layer> Load(string path);
    }
}
