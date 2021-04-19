using Azure;
using Azure.Search.Documents;
using Azure.Search.Documents.Indexes.Models;
using Azure.Search.Documents.Indexes;
using Azure.Search.Documents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace AzureSearchApp
{
    internal sealed class SearchClientWrapper
    {
        internal SearchClient SearchClient { get; }
        internal SearchIndexClient SearchIndexClient { get; }

        private readonly string _indexName;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchClientWrapper"/> class.
        /// </summary>
        /// <param name="options"></param>
        public SearchClientWrapper()
        {
            SearchIndexClient = new SearchIndexClient(
                new Uri(SearchEnvironment.Instance.SearchEndPoint),
                new AzureKeyCredential(SearchEnvironment.Instance.SearchAccountKey));
            // Microsoft.Extensions.Configuration.ConfigurationExtensions.AddUserSecrets()
            // IConfigurationBuilder

            _indexName = "oil-gas-index"; // "hotels-sample-index"; // Guid.NewGuid().ToString();
            SearchClient = SearchIndexClient.GetSearchClient(_indexName);
        }

        ///// <inheritdoc/>
        //public async Task SetupAsync()
        //{
        //    SearchIndex index = new(_indexName)
        //    {
        //        Fields = new FieldBuilder().Build(typeof(Hotel)),
        //        Suggesters = { new SearchSuggester("sg", new string[] { nameof(Hotel.Description), nameof(Hotel.HotelName) }) }
        //    };

        //    await _searchIndexClient.CreateIndexAsync(index);
        //}

        ///// <inheritdoc/>
        //public async Task CleanupAsync()
        //{
        //    await _searchIndexClient.DeleteIndexAsync(_indexName);
        //}
    }
}
