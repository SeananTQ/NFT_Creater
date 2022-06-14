// <copyright file="RarityData.cs" company="Tedeschi">
// Copyright (c) Tedeschi. All rights reserved.
// </copyright>

namespace NFTCreater.NFT.Model
{
    using Newtonsoft.Json;

    public class RarityData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("rarity")]
        public double Rarity { get; set; }
    }
}
