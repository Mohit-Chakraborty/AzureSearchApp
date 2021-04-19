using Azure.Search.Documents;
using Azure.Search.Documents.Models;
using AzureSearchApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureSearchWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            queryTypeComboBox.Items.AddRange(new object[] { string.Empty, SearchQueryType.Full, SearchQueryType.Semantic, SearchQueryType.Simple });
            queryLanguageComboBox.Items.AddRange(new object[] { string.Empty, QueryLanguage.EnUs, QueryLanguage.None });
            queryAnswerComboBox.Items.AddRange(new object[] { string.Empty, QueryAnswer.Extractive, QueryAnswer.None });

            answersListView.View = View.Details;
        }

        private async Task RunSearchAsync()
        {
            SearchOptions searchOptions = new();

            if (queryTypeComboBox.SelectedIndex > 0)
            {
                searchOptions.QueryType = (SearchQueryType)queryTypeComboBox.SelectedItem;
            }

            if (queryLanguageComboBox.SelectedIndex > 0)
            {
                searchOptions.QueryLanguage = (QueryLanguage)queryLanguageComboBox.SelectedItem;
            }

            if (queryAnswerComboBox.SelectedIndex > 0)
            {
                searchOptions.QueryAnswer = (QueryAnswer)queryAnswerComboBox.SelectedItem;
            }

            if ((queryAnswerCountTextBox.Text is not null) &&
                uint.TryParse(queryAnswerCountTextBox.Text, out uint queryAnswerCount))
            {
                searchOptions.QueryAnswerCount = queryAnswerCount;
            }

            try
            {
                var response = await new SemanticSearcher(searchOptions).SearchAsync(querySearchTextBox.Text, CancellationToken.None);
                PopulateWithResponseData(response);
            }
            catch (Exception ex)
            {
                ListViewItem item = new(new string[] { ex.GetType().ToString(), ex.Message, ex.InnerException?.GetType().ToString(), ex.InnerException?.Message })
                {
                    ForeColor = Color.Red
                };

                answersListView.Items.Add(item);
                answersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            //var task = new SemanticSearcher(searchOptions).SearchAsync(querySearchTextBox.Text, CancellationToken.None);
            //task.Wait();
        }

        private void PopulateWithResponseData(SearchResults<SearchDocument> response)
        {
            answersListView.BeginUpdate();

            if (response.Answers is null)
            {
                answersListView.Items.Add(new ListViewItem(new string[] { "Response.Answers is null" }) { ForeColor = Color.Red });
                answersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else if (response.Answers.Count == 0)
            {
                answersListView.Items.Add(new ListViewItem(new string[] { "Response.Answers is empty" }) { ForeColor = Color.Blue });
                answersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else
            {
                foreach (var result in response.Answers)
                {
                    answersListView.Items.Add(new ListViewItem(new string[] { result.Score?.ToString(), result.Key, result.Text, result.Highlights }));
                }
            }

            answersListView.Items.Add(new ListViewItem(Array.Empty<string>()));

            IEnumerable<SearchResult<SearchDocument>> docs = response.GetResults().Take(10);

            foreach (var doc in docs)
            {
                answersListView.Items.Add(new ListViewItem(new string[] { doc.RerankerScore?.ToString() }));

                foreach (var caption in doc.Captions)
                {
                    answersListView.Items.Add(new ListViewItem(new string[] { caption.Text, caption.Highlights }));
                }
            }

            // answersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            answersListView.EndUpdate();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            answersListView.Items.Clear();

            try
            {
                UseWaitCursor = true;
                _ = RunSearchAsync();
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private void QueryAnswerCountTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                e.Cancel = !uint.TryParse(textBox.Text, out uint _);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            answersListView.Items.Clear();

            queryTypeComboBox.SelectedIndex = 0;
            queryLanguageComboBox.SelectedIndex = 0;
            queryAnswerComboBox.SelectedIndex = 0;
            queryAnswerCountTextBox.Text = null;
        }
    }
}
