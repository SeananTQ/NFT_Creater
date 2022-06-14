// <copyright file="IImageService.cs" company="Tedeschi">
// Copyright (c) Tedeschi. All rights reserved.
// </copyright>

namespace NFTCreater.NFT.Services.Image
{
    using System.Drawing;

    public interface IImageService
    {
        Bitmap Combine(string[] files);
    }
}
