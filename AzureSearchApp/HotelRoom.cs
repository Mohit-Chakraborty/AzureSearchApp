using Azure.Search.Documents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzureSearchApp
{
    public sealed class HotelRoom
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("descriptionFr")]
        public string DescriptionFr { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("baseRate")]
        public double? BaseRate { get; set; }

        [JsonPropertyName("bedOptions")]
        public string BedOptions { get; set; }

        [JsonPropertyName("sleepsCount")]
        public int? SleepsCount { get; set; }

        [JsonPropertyName("smokingAllowed")]
        public bool? SmokingAllowed { get; set; }

        [JsonPropertyName("tags")]
        // TODO: #10596 - Investigate JsonConverter for null arrays
        public string[] Tags { get; set; } = new string[] { };
    }
}
