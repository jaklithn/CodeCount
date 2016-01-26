using System;
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
        const string ExtensionSeparators = " ,;|";

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


                var codeCount = CountFiles(Settings.Default.CodeExtensions);
                var clientCodeCount = CountFiles(Settings.Default.ClientCodeExtensions);
                var sqlCount = CountFiles(Settings.Default.SqlExtensions);
                var layoutCount = CountFiles(Settings.Default.LayoutExtensions);

                var countTotal = Convert.ToDouble(codeCount.Total + clientCodeCount.Total + sqlCount.Total + layoutCount.Total);
                var commentTotal = codeCount.Comment + clientCodeCount.Comment + sqlCount.Comment + layoutCount.Comment;

                var sb = new StringBuilder();
                sb.AppendLine("{0,-40}({1})", Settings.Default.BaseDirectory.Split(@"\".ToCharArray()).Last(), DateTime.Now.ToShortDateString());
                sb.AppendLine("====================================================");
                sb.AppendLine("Code        {0,10:N0}{1,10:P0}", codeCount.Code, codeCount.Code / countTotal);
                sb.AppendLine("Client code {0,10:N0}{1,10:P0}", clientCodeCount.Code, clientCodeCount.Code / countTotal);
                sb.AppendLine("SQL         {0,10:N0}{1,10:P0}", sqlCount.Code, sqlCount.Code / countTotal);
                sb.AppendLine("Layout      {0,10:N0}{1,10:P0}", layoutCount.Code, layoutCount.Code / countTotal);
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

        private static CountResult CountFiles(string extensionString)
        {
            var extensions = extensionString.Split(ExtensionSeparators.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var skipPatterns = Settings.Default.SkipPatterns.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var commentIndicators = Settings.Default.CommentIndicators.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var countResult = new CountResult();
            foreach (var extension in extensions)
            {
                var files = Directory.GetFiles(Settings.Default.BaseDirectory, "*." + extension, SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    if (skipPatterns.Any(s => file.Contains(s)))
                    {
                        continue;
                    }

                    foreach (var line in File.ReadAllLines(file))
                    {
                        if (line.IsNullOrEmpty())
                        {
                        }
                        else if (commentIndicators.Any(c => line.Trim().StartsWith(c)))
                        {
                            countResult.Comment += 1;
                        }
                        else
                        {
                            countResult.Code += 1;
                        }
                    }
                }
            }

            return countResult;
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