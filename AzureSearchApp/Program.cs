using Azure;
using Azure.Search.Documents;
using Azure.Search.Documents.Indexes.Models;
using Azure.Search.Documents.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AzureSearchApp
{
    class Program
    {
        // private static List<Hotel> _hotels;
        private static SearchClientWrapper SearchClientWrapper { get; set; }

        static async Task Main(string[] args)
        {
// _hotels = DocumentGenerator.GenerateHotels(5, smallDocumentSize: true);
//SearchClientWrapper = new SearchClientWrapper();

//await RunAsync(args, cancellationToken: CancellationToken.None);

            string searchText = (args != null && args.Length > 0) ? args[0]: "when was the warm-back test performed";

            Console.WriteLine($"Search text: {searchText}");

            SearchResults<SearchDocument> response = await new SemanticSearcher().SearchAsync(searchText, CancellationToken.None);

            await SemanticSearcher.WriteToConsoleAsync(response);
        }

        /// <summary>
        /// Indexes documents by calling <see cref="SearchClient.IndexDocumentsAsync{T}(IndexDocumentsBatch{T}, IndexDocumentsOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="cancellationToken">The token used to signal cancellation request.</param>
        public static async Task RunAsync(string[] args, CancellationToken cancellationToken)
        {
            //await SearchClientWrapper.SetupAsync();
            //await SearchClientWrapper._searchClient.IndexDocumentsAsync(
            //    IndexDocumentsBatch.Upload(_hotels),
            //    new IndexDocumentsOptions() { ThrowOnAnyError = true },
            //    cancellationToken);

            // SearchIndex result = (await SearchClientWrapper.SearchIndexClient.GetIndexAsync("hotels-sample-index")).Value;

            //SearchClientWrapper.SearchClient.ver

            string searchText = (args != null && args.Length > 0) ? args[0] : "How to estimate injection profile"; // "does the hotel have tv";

            var semanticSearchOptions = new SearchOptions()
            {
                QueryType = SearchQueryType.Semantic,
                QueryLanguage = QueryLanguage.EnUs,
                QueryAnswer = QueryAnswer.Extractive,
                QueryAnswerCount = 5,
                IncludeTotalCount = true,
                //HighlightPreTag = "<b>",
                //HighlightPostTag = "</b>",
            };

            //semanticSearchOptions.HighlightFields.Add("Category");
            semanticSearchOptions.SearchFields.Add("metadata_storage_name"); // Description");
            semanticSearchOptions.SearchFields.Add("metadata_title"); // Category");
            semanticSearchOptions.SearchFields.Add("content"); // Tags");

            // semanticSearchOptions.Select.Add("pointKey");

            Console.WriteLine($"Search text: {searchText}");

            SearchResults<SearchDocument> response = 
                await SearchClientWrapper.SearchClient.SearchAsync<SearchDocument>(searchText, semanticSearchOptions);

            // Debug.Assert(response.Answers != null);

            if (response.Answers is not null)
            {
                Console.WriteLine($"Answer count: {response.Answers.Count}");

                foreach (var answer in response.Answers)
                {
                    Console.WriteLine($"{nameof(answer.Key)}: {answer.Key}");
                    Console.WriteLine($"{nameof(answer.Score)}: {answer.Score}");
                    Console.WriteLine($"{nameof(answer.Text)}: {answer.Text}");
                    Console.WriteLine($"{nameof(answer.Highlights)}: {answer.Highlights}");
                    Console.WriteLine();
                }
            }

            List<SearchResult<SearchDocument>> docs = await response.GetResultsAsync().ToListAsync();

            Console.WriteLine($"Result count: {docs.Count}");

            foreach (var doc in docs)
            {
                Debug.Assert(doc.Captions != null);
                //doc.Document.GetPoint()

                foreach (var caption in doc.Captions)
                {
                    Debug.Assert(caption.Text != null);
                    // Debug.Assert(caption.Highlights != null);
                }

                Debug.Assert(doc.RerankerScore != null);
            }
        }
    }
}

