# AzureSearchApp

This application is used to test the functionality and demonstrate the capabilities of the client SDK for [Azure Cognitive Search](https://docs.microsoft.com/azure/search/search-what-is-azure-search) service.

The repo has a -
1. [Console app](https://github.com/Mohit-Chakraborty/AzureSearchApp/tree/main/AzureSearchApp)
1. [WinForms UI app](https://github.com/Mohit-Chakraborty/AzureSearchApp/tree/main/AzureSearchWinFormsApp)

Users need to set the following environment variables when using the application -
- AZURE_SEARCH_ACCOUNT_NAME // The name of the Azure Search account to test against.
- AZURE_SEARCH_ACCOUNT_KEY  //The shared access key of the Search account to test against.
- AZURE_SEARCH_INDEX_NAME   //The name of the index to test against.

## Reading material

### Semantic search
- https://docs.microsoft.com/azure/search/semantic-search-overview
- https://docs.microsoft.com/azure/search/semantic-how-to-query-request
- https://docs.microsoft.com/azure/search/semantic-answers
