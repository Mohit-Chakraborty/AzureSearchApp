using Azure;
using Azure.Search.Documents;
using Azure.Search.Documents.Indexes;
using Azure.Search.Documents.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AzureSearchApp
{
    public sealed class SemanticSearcher
    {
        private const string SearchIndexName = "oil-gas-index";

        private SearchClient SearchClient { get; }
        private SearchIndexClient SearchIndexClient { get; }

        private SearchOptions semanticSearchOptions;

        public SemanticSearcher()
        {
            SearchIndexClient = new SearchIndexClient(
                new Uri(SearchEnvironment.Instance.SearchEndPoint),
                new AzureKeyCredential(SearchEnvironment.SearchAccountKey));

            SearchClient = SearchIndexClient.GetSearchClient(SearchIndexName);
        }

        public SemanticSearcher(SearchOptions searchOptions) : this()
        {
            semanticSearchOptions = searchOptions;
        }

        public async Task<SearchResults<SearchDocument>> SearchAsync(string searchText, CancellationToken cancellationToken)
        {
            if (semanticSearchOptions is null)
            {
                semanticSearchOptions = new SearchOptions()
                {
                    QueryType = SearchQueryType.Semantic,
                    QueryLanguage = QueryLanguage.EnUs,
                    QueryAnswer = QueryAnswer.Extractive,
                    QueryAnswerCount = 5,

                    IncludeTotalCount = true,
                };
            }

            semanticSearchOptions.SearchFields.Add("metadata_storage_name");
            semanticSearchOptions.SearchFields.Add("metadata_title");
            semanticSearchOptions.SearchFields.Add("content");

            SearchResults<SearchDocument> response =
                await SearchClient.SearchAsync<SearchDocument>(searchText, semanticSearchOptions, cancellationToken: cancellationToken);

            return response;
        }

        internal static async Task WriteToConsoleAsync(SearchResults<SearchDocument> response)
        {
            if (response.Answers is not null)
            {
                Console.WriteLine($"Answer count: {response.Answers.Count}{Environment.NewLine}");

                foreach (var answer in response.Answers)
                {
                    Console.WriteLine($"{nameof(answer.Key)}:        {answer.Key}");
                    Console.WriteLine($"{nameof(answer.Score)}:      {answer.Score}");
                    Console.WriteLine($"{nameof(answer.Text)}:       {answer.Text}");
                    Console.WriteLine($"{nameof(answer.Highlights)}: {answer.Highlights}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Answers is null");
            }

            List<SearchResult<SearchDocument>> docs = await response.GetResultsAsync().ToListAsync();

            Console.WriteLine($"Result count: {docs.Count}");
        }
    }
}
