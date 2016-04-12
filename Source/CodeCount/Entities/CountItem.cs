using System;

namespace CodeCount.Entities
{
    public class CountItem
    {
        private const string ExtensionSeparators = " ,;|";

        public string[] Extensions { get; }
        public int CodeCount { get; set; }
        public int CommentCount { get; set; }

        public int Total
        {
            get { return CodeCount + CommentCount; }
        }

        public CountItem(string extensions)
        {
            Extensions = extensions.Split(ExtensionSeparators.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            EnsureDots();
        }

        private void EnsureDots()
        {
            for (var i = 0; i < Extensions.Length; i++)
            {
                if (!Extensions[i].StartsWith("."))
                    Extensions[i] = "." + Extensions[i];
            }
        }

        public void SetCount(int codeCount, int commentCount)
        {
            CodeCount = codeCount;
            CommentCount = commentCount;
        }
    }
}