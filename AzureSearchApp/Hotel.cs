using System;
using System.Text.Json.Serialization;
using Azure.Search.Documents.Indexes;
 
namespace AzureSearchApp
{
    /// <summary>
    /// Hotel.
    /// </summary>
    public class Hotel
    {
        /// <summary>
        /// HotelId.
        /// </summary>
        [SimpleField(IsKey = true)]
        public string HotelId { get; set; }

        /// <summary>
        /// HotelName.
        /// </summary>
        [SearchableField(IsSortable = true)]
        public string HotelName { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        [SearchableField(AnalyzerName = "en.microsoft")]
        public string Description { get; set; }

        /// <summary>
        /// DescriptionFr.
        /// </summary>
        [SearchableField(AnalyzerName = "fr.lucene")]
        public string DescriptionFr { get; set; }

        /// <summary>
        /// Category.
        /// </summary>
        [SearchableField(IsFilterable = true, IsSortable = true, IsFacetable = true)]
        public string Category { get; set; }

        /// <summary>
        /// Tags.
        /// </summary>
        [SearchableField(IsFilterable = true, IsFacetable = true)]
        public string[] Tags { get; set; }

        /// <summary>
        /// ParkingIncluded.
        /// </summary>
        [SimpleField(IsFilterable = true, IsSortable = true, IsFacetable = true)]
        public bool ParkingIncluded { get; set; }

        /// <summary>
        /// LastRenovationDate.
        /// </summary>
        [SimpleField(IsFilterable = true, IsSortable = true, IsFacetable = true)]
        public DateTimeOffset LastRenovationDate { get; set; }

/// <summary>
/// Rating.
/// </summary>
        [SimpleField(IsFilterable = true, IsSortable = true, IsFacetable = true)]
        public double Rating { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        public HotelAddress Address { get; set; }

        public HotelRoom[] Rooms { get; set; } = new HotelRoom[] { };
    }
}
