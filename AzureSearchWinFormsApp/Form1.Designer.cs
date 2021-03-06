
namespace AzureSearchWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.querySearchTextBox = new System.Windows.Forms.TextBox();
            this.queryLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.queryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.queryAnswerComboBox = new System.Windows.Forms.ComboBox();
            this.queryAnswerCountTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.answersListView = new System.Windows.Forms.ListView();
            this.scoreColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.keyColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.textColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.highlightsColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.showResultsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(203, 137);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 35);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(487, 137);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(110, 35);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // querySearchTextBox
            // 
            this.querySearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tableLayoutPanel1.SetColumnSpan(this.querySearchTextBox, 2);
            this.querySearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.querySearchTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.querySearchTextBox.Location = new System.Drawing.Point(203, 10);
            this.querySearchTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.querySearchTextBox.Name = "querySearchTextBox";
            this.querySearchTextBox.PlaceholderText = "Enter search string here";
            this.querySearchTextBox.Size = new System.Drawing.Size(394, 32);
            this.querySearchTextBox.TabIndex = 0;
            this.querySearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuerySearchTextBox_KeyDown);
            // 
            // queryLanguageComboBox
            // 
            this.queryLanguageComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.queryLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryLanguageComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queryLanguageComboBox.FormattingEnabled = true;
            this.queryLanguageComboBox.Location = new System.Drawing.Point(239, 56);
            this.queryLanguageComboBox.Name = "queryLanguageComboBox";
            this.queryLanguageComboBox.Size = new System.Drawing.Size(121, 33);
            this.queryLanguageComboBox.TabIndex = 2;
            // 
            // queryTypeComboBox
            // 
            this.queryTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.queryTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queryTypeComboBox.FormattingEnabled = true;
            this.queryTypeComboBox.Location = new System.Drawing.Point(39, 56);
            this.queryTypeComboBox.Name = "queryTypeComboBox";
            this.queryTypeComboBox.Size = new System.Drawing.Size(121, 33);
            this.queryTypeComboBox.TabIndex = 1;
            // 
            // queryAnswerComboBox
            // 
            this.queryAnswerComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.queryAnswerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryAnswerComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queryAnswerComboBox.FormattingEnabled = true;
            this.queryAnswerComboBox.Location = new System.Drawing.Point(454, 56);
            this.queryAnswerComboBox.Name = "queryAnswerComboBox";
            this.queryAnswerComboBox.Size = new System.Drawing.Size(91, 33);
            this.queryAnswerComboBox.TabIndex = 3;
            // 
            // queryAnswerCountTextBox
            // 
            this.queryAnswerCountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.queryAnswerCountTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queryAnswerCountTextBox.Location = new System.Drawing.Point(680, 57);
            this.queryAnswerCountTextBox.Name = "queryAnswerCountTextBox";
            this.queryAnswerCountTextBox.Size = new System.Drawing.Size(39, 32);
            this.queryAnswerCountTextBox.TabIndex = 4;
            this.queryAnswerCountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.QueryAnswerCountTextBox_Validating);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.answersListView, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.querySearchTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.queryAnswerCountTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.queryAnswerComboBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.queryLanguageComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.queryTypeComboBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.showResultsButton, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // answersListView
            // 
            this.answersListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.answersListView.AllowColumnReorder = true;
            this.answersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.scoreColumnHeader,
            this.keyColumnHeader,
            this.textColumnHeader,
            this.highlightsColumnHeader});
            this.tableLayoutPanel1.SetColumnSpan(this.answersListView, 4);
            this.answersListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answersListView.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answersListView.FullRowSelect = true;
            this.answersListView.GridLines = true;
            this.answersListView.HideSelection = false;
            this.answersListView.Location = new System.Drawing.Point(3, 185);
            this.answersListView.Name = "answersListView";
            this.answersListView.Size = new System.Drawing.Size(794, 262);
            this.answersListView.TabIndex = 8;
            this.answersListView.UseCompatibleStateImageBehavior = false;
            // 
            // scoreColumnHeader
            // 
            this.scoreColumnHeader.Text = "Score";
            this.scoreColumnHeader.Width = 90;
            // 
            // keyColumnHeader
            // 
            this.keyColumnHeader.Text = "Key";
            this.keyColumnHeader.Width = 90;
            // 
            // textColumnHeader
            // 
            this.textColumnHeader.Text = "Text";
            this.textColumnHeader.Width = 350;
            // 
            // highlightsColumnHeader
            // 
            this.highlightsColumnHeader.Text = "Highlights";
            this.highlightsColumnHeader.Width = 350;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(224, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Query Language";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(413, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Query Answer Type";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(607, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Query Answer Count";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Query Type";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(90, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search Text";
            // 
            // showResultsButton
            // 
            this.showResultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showResultsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showResultsButton.Location = new System.Drawing.Point(667, 137);
            this.showResultsButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.showResultsButton.Name = "showResultsButton";
            this.showResultsButton.Size = new System.Drawing.Size(130, 35);
            this.showResultsButton.TabIndex = 14;
            this.showResultsButton.Text = "Show results";
            this.showResultsButton.UseVisualStyleBackColor = true;
            this.showResultsButton.Click += new System.EventHandler(this.ShowResultsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Azure Cognitive Searcher";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox querySearchTextBox;
        private System.Windows.Forms.ComboBox queryLanguageComboBox;
        private System.Windows.Forms.ComboBox queryTypeComboBox;
        private System.Windows.Forms.ComboBox queryAnswerComboBox;
        private System.Windows.Forms.TextBox queryAnswerCountTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView answersListView;
        private System.Windows.Forms.ColumnHeader textColumnHeader;
        private System.Windows.Forms.ColumnHeader highlightsColumnHeader;
        private System.Windows.Forms.ColumnHeader keyColumnHeader;
        private System.Windows.Forms.ColumnHeader scoreColumnHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showResultsButton;
    }
}

