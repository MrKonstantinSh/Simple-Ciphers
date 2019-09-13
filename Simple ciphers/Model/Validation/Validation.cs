using System;
using System.Text.RegularExpressions;

namespace Simple_ciphers.Model.Validation
{
    /// <summary>
    /// The class allows you to change data (keys, source text) in accordance with the patterns.
    /// </summary>
    public static class Validation
    {
        private const string keyPattern = "[a-zA-ZА-Яа-я`~!@#№$%^&*()_+={}:;|<>,.?/\'\"\t\n\r\\s\\[\\]\\\\-]";
        private const string textPattern = "[А-Яа-я0-9`~!@#№$%^&*()_+={}:;|<>,.?/\'\"\t\n\r\\s\\[\\]\\\\-]";

        /// <summary>
        /// Deletes all characters except numbers.
        /// </summary>
        /// <param name="key">The key to change according to the pattern.</param>
        /// <returns>Modified key according to pattern.</returns>
        public static int ModifyKey(string key)
        {
            key = Regex.Replace(key, keyPattern, string.Empty);
            int.TryParse(key, out int numericKey);
            return numericKey;
        }

        /// <summary>
        /// Deletes all characters except the English alphabet.
        /// </summary>
        /// <param name="text">The text to be modified according to the pattern.</param>
        /// <returns>Modified text to match the pattern.</returns>
        public static string ModifyText(string text)
        {
            text = Regex.Replace(text, textPattern, string.Empty);
            return text;
        }
    }
}
