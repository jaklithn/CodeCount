using System.Text;


namespace CodeCount.Extenders
{
    public static class StringBuilderExtender
    {
        /// <summary>
        /// Append with format string.
        /// </summary>
        public static StringBuilder Append(this StringBuilder sb, string format, params object[] args)
        {
            return sb.Append(string.Format(format, args));
        }

        /// <summary>
        /// Append line with format string.
        /// </summary>
        public static StringBuilder AppendLine(this StringBuilder sb, string format, params object[] args)
        {
            return sb.AppendLine(string.Format(format, args));
        }

        /// <summary>
        /// Append text with separator between each section.
        /// </summary>
        public static StringBuilder AppendComment(this StringBuilder sb, string format, params object[] args)
        {
            // Add separator between each ´section
            if (sb.Length > 0)
                sb.Append(", ");
            return sb.AppendLine(string.Format(format, args));
        }
    }
}