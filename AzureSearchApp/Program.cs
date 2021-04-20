using Azure.Search.Documents.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AzureSearchApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string searchText = (args != null && args.Length > 0) ? args[0]: string.Empty;

            Console.WriteLine($"Search text: {searchText}");

            SearchResults<SearchDocument> response = await new SemanticSearcher().SearchAsync(searchText, CancellationToken.None);

            await SemanticSearcher.WriteToConsoleAsync(response);
        }
    }
}

