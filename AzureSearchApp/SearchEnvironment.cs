using System;

namespace AzureSearchApp
{
    internal sealed class SearchEnvironment
    {
        private const string SearchAccountNameVariableName = "AZURE_SEARCH_ACCOUNT_NAME";
        private const string SearchAccountKeyVariableName = "AZURE_SEARCH_ACCOUNT_KEY";

        /// <summary>
        /// The shared instance of the <see cref="PerfTestEnvironment"/> to be used during test runs.
        /// </summary>
        public static SearchEnvironment Instance { get; } = new SearchEnvironment();

        /// <summary>
        /// The name of the Azure Search account to test against.
        /// </summary>
        /// <value>The Azure Search account name, read from the "AZURE_SEARCH_ACCOUNT_NAME" environment variable.</value>
        public static string SearchAccountName => GetVariable("AZURE_SEARCH_ACCOUNT_NAME");

        /// <summary>
        /// The shared access key of the Search account to test against.
        /// </summary>
        /// <value>The Search account key, read from the "AZURE_SEARCH_ACCOUNT_KEY" environment variable.</value>
        public static string SearchAccountKey => GetVariable("AZURE_SEARCH_ACCOUNT_KEY");

        /// <summary>
        /// The connection string for accessing the Files Shares storage account used for testing.
        /// </summary>
        public string SearchConnectionString { get; }

        public string SearchEndPoint { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerfTestEnvironment"/> class.
        /// </summary>
        public SearchEnvironment()
        {
            SearchEndPoint = $"{Uri.UriSchemeHttps}://{SearchAccountName}.search.windows.net";
        }

        /// <summary>
        /// Returns an environment variable value.
        /// Throws when variable is not found.
        /// </summary>
        public static string GetVariable(string name)
        {
            var value = GetOptionalVariable(name);
            EnsureValue(name, value);

            return value;
        }

        /// <summary>
        /// Returns an environment variable value or null when variable is not found.
        /// </summary>
        public static string GetOptionalVariable(string name)
        {
            if (SearchAccountNameVariableName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return "semantic-eus2-demo-luisca"; // "semantic-search";
            }

            if (SearchAccountKeyVariableName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return "CDEAA47FF55E16DF4895521B7BF981CD"; //  "AC5484B8165BAAE1B02CB9BCB62F65FA";
            }

            return Environment.GetEnvironmentVariable(name);
        }

        private static void EnsureValue(string name, string value)
        {
            if (value == null)
            {
                throw new InvalidOperationException(
                    $"Unable to find environment variable {name} required by test." + Environment.NewLine +
                    "Make sure the test environment was initialized using eng/common/TestResources/New-TestResources.ps1 script.");
            }
        }
    }

}
