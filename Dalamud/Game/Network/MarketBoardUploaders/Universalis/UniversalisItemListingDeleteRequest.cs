using Newtonsoft.Json;

namespace Dalamud.Game.Network.MarketBoardUploaders.Universalis
{
    /// <summary>
    /// Request payload for market board purchases.
    /// </summary>
    public class UniversalisItemListingDeleteRequest
    {
        /// <summary>
        /// Gets or sets the object ID of the retainer associated with the sale.
        /// </summary>
        [JsonProperty("retainerID")]
        public ulong RetainerId { get; set; }

        /// <summary>
        /// Gets or sets the object ID of the item listing.
        /// </summary>
        [JsonProperty("listingID")]
        public ulong ListingId { get; set; }

        /// <summary>
        /// Gets or sets the item ID of the item that was purchased.
        /// </summary>
        [JsonProperty("itemID")]
        public uint ItemId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the item that was purchased.
        /// </summary>
        [JsonProperty("quantity")]
        public uint Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the item.
        /// </summary>
        [JsonProperty("pricePerUnit")]
        public uint PricePerUnit { get; set; }

        /// <summary>
        /// Gets or sets the uploader ID.
        /// </summary>
        [JsonProperty("uploaderID")]
        public string UploaderId { get; set; }
    }
}
