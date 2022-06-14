// <copyright file="ImageEventArgs.cs" company="Tedeschi">
// Copyright (c) Tedeschi. All rights reserved.
// </copyright>

namespace NFTCreater.NFT.Event
{
    using System;

    public class ImageEventArgs : EventArgs
    {
        public int CollectionItemId { get; set; }
        public int Percentage { get; set; }
        public int CompleteCount { get; set; }
        public int TotalCount { get; set; }

        public int CollectionItemName { get; set; }
    }
}
