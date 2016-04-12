using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CodeCount.Entities;
using CodeCount.Extenders;
using CodeCount.Properties;


namespace CodeCount
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadSettings();
        }


        private void SelectDirectory()
        {
            try
            {
                var d = new FolderBrowserDialog
                {
                    Description = "Choose base directory for solution calculation",
                    SelectedPath = txtDirectory.Text
                };

                if (d.ShowDialog() == DialogResult.OK && !d.SelectedPath.IsNullOrEmpty())
                {
                    txtDirectory.Text = d.SelectedPath;
                    txtResult.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {

                txtResult.Text = ex.Message;
            }
        }

        private void Calculate()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                txtResult.Text = string.Empty;
                Application.DoEvents();
                SaveSettings();

                // Set counters
                var countItems = new Dictionary<string, CountItem>
                {
                    {"Code", new CountItem( Settings.Default.CodeExtensions)},
                    {"ClientCode", new CountItem( Settings.Default.ClientCodeExtensions)},
                    {"SQL", new CountItem(Settings.Default.SqlExtensions)},
                    {"Layout", new CountItem(Settings.Default.LayoutExtensions)}
                };
                var skipPatterns = Settings.Default.SkipPatterns.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var commentIndicators = Settings.Default.CommentIndicators.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                // Calculate
                countItems = CountFiles(countItems, skipPatterns, commentIndicators);

                // Retrieve totals
                var countTotal = Convert.ToDouble(countItems.Values.Sum(x => x.Total));
                var commentTotal = Convert.ToDouble(countItems.Values.Sum(x => x.CommentCount));

                // Display result
                var sb = new StringBuilder();
                sb.AppendLine("{0,-40}({1})", Settings.Default.BaseDirectory.Split(@"\".ToCharArray()).Last(), DateTime.Now.ToShortDateString());
                sb.AppendLine("====================================================");
                sb.AppendLine("Code        {0,10:N0}{1,10:P0}", countItems["Code"].CodeCount, countItems["Code"].CodeCount / countTotal);
                sb.AppendLine("Client code {0,10:N0}{1,10:P0}", countItems["ClientCode"].CodeCount, countItems["ClientCode"].CodeCount / countTotal);
                sb.AppendLine("SQL         {0,10:N0}{1,10:P0}", countItems["SQL"].CodeCount, countItems["SQL"].CodeCount / countTotal);
                sb.AppendLine("Layout      {0,10:N0}{1,10:P0}", countItems["Layout"].CodeCount, countItems["Layout"].CodeCount / countTotal);
                sb.AppendLine("Comment     {0,10:N0}{1,10:P0}", commentTotal, commentTotal / countTotal);
                sb.AppendLine("====================================================");
                sb.AppendLine("TOTALT      {0,10:N0}{1,10:P0}", countTotal, 1D);

                txtResult.Text = sb.ToString();

            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LoadSettings()
        {
            txtDirectory.Text = Settings.Default.BaseDirectory;
            txtCodeExtensions.Text = Settings.Default.CodeExtensions;
            txtClientCodeExtensions.Text = Settings.Default.ClientCodeExtensions;
            txtSqlExtensions.Text = Settings.Default.SqlExtensions;
            txtLayoutExtensions.Text = Settings.Default.LayoutExtensions;
            txtSkipPatterns.Text = Settings.Default.SkipPatterns;
            txtCommentIndicators.Text = Settings.Default.CommentIndicators;
        }

        private void SaveSettings()
        {
            Settings.Default.BaseDirectory = txtDirectory.Text;
            Settings.Default.CodeExtensions = txtCodeExtensions.Text;
            Settings.Default.ClientCodeExtensions = txtClientCodeExtensions.Text;
            Settings.Default.SqlExtensions = txtSqlExtensions.Text;
            Settings.Default.LayoutExtensions = txtLayoutExtensions.Text;
            Settings.Default.SkipPatterns = txtSkipPatterns.Text;
            Settings.Default.CommentIndicators = txtCommentIndicators.Text;
            Settings.Default.Save();
        }

        private static Dictionary<string, CountItem> CountFiles(Dictionary<string, CountItem> countItems, string[] skipPatterns, string[] commentIndicators)
        {
            var allHandledExtensions = countItems.Values.SelectMany(x => x.Extensions).ToList();
            var directoryInfo = new DirectoryInfo(Settings.Default.BaseDirectory);
            var fileInfos = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories);
            foreach (var fileInfo in fileInfos)
            {
                // Skip if path matches any pattern we want to avoid
                if (skipPatterns.Any(s => fileInfo.FullName.Contains(s)))
                {
                    continue;
                }

                // Skip if none of the handled extensions match
                if (!allHandledExtensions.Contains(fileInfo.Extension))
                {
                    continue;
                }

                // Calculate file content and store on appropriate item
                var countItem = countItems.Single(x => x.Value.Extensions.Contains(fileInfo.Extension));
                foreach (var line in File.ReadAllLines(fileInfo.FullName))
                {
                    if (line.IsNullOrEmpty())
                    {
                    }
                    else if (commentIndicators.Any(c => line.Trim().StartsWith(c)))
                    {
                        countItem.Value.CommentCount += 1;
                    }
                    else
                    {
                        countItem.Value.CodeCount += 1;
                    }
                }
            }

            return countItems;
        }


        #region Event Handlers

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            SelectDirectory();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }


        #endregion



    }
}