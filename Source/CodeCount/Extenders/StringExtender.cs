using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace CodeCount.Extenders
{
    public static class StringExtender
    {
        /// <summary>
        /// Counts the number of words in the string.
        /// </summary>
        public static int WordCount(this string value)
        {
            return Regex.Matches(value, "[^ ]+").Count;
        }

        /// <summary>
        /// Same as String.IsNullOrEmpty().
        /// </summary>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// Returns first part of the string (or whole string if shorter).
        /// </summary>
        /// <param name="value">String to cut.</param>
        /// <param name="length">Decides how long the result should be.</param>
        public static string Left(this string value, int length)
        {
            if (string.IsNullOrEmpty(value) || value.Length < length)
                return value;

            return value.Substring(0, length);
        }

        /// <summary>
        /// Returns last part of the string (or whole string if shorter).
        /// </summary>
        /// <param name="value">String to cut.</param>
        /// <param name="length">Decides how long the result should be.</param>
        public static string Right(this string value, int length)
        {
            if (string.IsNullOrEmpty(value) || value.Length < length)
                return value;

            return value.Substring(value.Length - length);
        }

        /// <summary>
        /// Limits string to a specified length. If longer the text is cut and an ellipsis "..." is added.
        /// </summary>
        /// <param name="value">Entered string.</param>
        /// <param name="maxLength">Sets the total length including possible ellipsis.</param>
        public static string Limit(this string value, int maxLength)
        {
            return value.Limit(maxLength, "...");
        }

        /// <summary>
        /// Limits string to a specified length. If longer the text is cut and a dot "." is added.
        /// </summary>
        /// <param name="value">Entered string.</param>
        /// <param name="maxLength">Sets the total length including possible dot.</param>
        public static string LimitShort(this string value, int maxLength)
        {
            return value.Limit(maxLength, ".");
        }

        /// <summary>
        /// Limits string to a specified length. If longer the text is cut and specified ending is added.
        /// </summary>
        /// <param name="value">Entered string.</param>
        /// <param name="maxLength">Sets the total length including possible dot.</param>
        /// <param name="ending">Wished ending to be added if text is cut.</param>
        public static string Limit(this string value, int maxLength, string ending)
        {
            if (value.IsNullOrEmpty())
                return string.Empty;

            value = value.Trim();
            if (value.Length <= maxLength)
                return value;

            return value.Substring(0, maxLength - ending.Length) + ending;
        }

        /// <summary>
        /// Returns string changed to lower case, except for first character of each word that is set to upper case.
        /// </summary>
        public static string IniCapital(this string value)
        {
            var sb = new StringBuilder();

	        // Characters following these should be converted to UpperCase
            var wordSeparators = " -".ToCharArray();

            // Prepare value
            value = value.ToLower();

            // First character should always be capital
            bool capitalize = true;

            for (int i = 0; i < value.Length; i++)
            {
                var thisChar = value[i];

                // Make capital if requested
                if (capitalize)
                    thisChar = Char.ToUpper(thisChar);

                // Append character to result
                sb.Append(thisChar);

                // Set capital status for following character
                capitalize = wordSeparators.Contains(thisChar);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Returns string where leading 0 are removed.
        /// </summary>
        public static string RemoveLeadingZeros(this string value)
        {
            // Loop to find first occurrance of other character
            for (int i = 0; i < value.Length; i++)
                if (value[i] != '0')
                    return value.Substring(i);

            // Fallback for empty strings
            return string.Empty;
        }

        /// <summary>
        /// Returns true if the string consists of "1" and "0".
        /// </summary>
        public static bool IsBinary(this string value)
        {
            char[] charArray = value.ToCharArray();

            bool check = true;
            for (int i = 0; i < value.Length; i++)
            {
                if (charArray[i] == '0' || charArray[i] == '1')
                {
                    continue;
                }
                else
                {
                    check = false;
                    break;
                }
            }
            return check;
        }

        /// <summary>
        /// Returns the enum value of a string.
        /// </summary>
        public static T ConvertToEnum<T>(this string valueToMatchEnum)
        {
            if (Enum.IsDefined(typeof(T), valueToMatchEnum) == true)
            {
                return (T)Enum.Parse(typeof(T), valueToMatchEnum, true);
            }
            else
            {
                return default(T);
            }
        }

    }
}