using System.Text.RegularExpressions;

namespace Simple_ciphers.Model.Validation
{
    /// <summary>
    /// The class allows you to change data (keys, source text) in accordance with the patterns.
    /// </summary>
    public static class Validation
    {
        private const string keyPattern = "[a-zA-ZА-Яа-я`~!@#№$%^&*()_+={}:;|<>,.?/\'\"\t\n\r\\s\\[\\]\\\\-]";
        private const string vigenerKeyPattern = "[a-zA-Z0-9`~!@#№$%^&*()_+={}:;|<>,.?/\'\"\t\n\r\\s\\[\\]\\\\-]";
        private const string engTextPattern = "[А-Яа-я0-9`~!@#№$%^&*()_+={}:;|<>,.?/\'\"\t\n\r\\s\\[\\]\\\\-]";
        private const string rusTextPattern = "[a-zA-Z0-9`~!@#№$%^&*()_+={}:;|<>,.?/\'\"\t\n\r\\s\\[\\]\\\\-]";

        /// <summary>
        /// Deletes all characters except numbers.
        /// </summary>
        /// <param name="key">The key to change according to the pattern.</param>
        /// <returns>Modified key according to pattern.</returns>
        public static string ModifyKey(string key, Ciphers.TypesOfCiphers typeOfCipher)
        {
            if (typeOfCipher == Ciphers.TypesOfCiphers.RailFence ||
                typeOfCipher == Ciphers.TypesOfCiphers.RotatingSquare)
            {
                key = Regex.Replace(key, keyPattern, string.Empty);
            }
            else
            {
                key = Regex.Replace(key, vigenerKeyPattern, string.Empty);
                key = key.ToUpper();
            }
            return key;
        }

        /// <summary>
        /// Deletes all characters except the English alphabet.
        /// </summary>
        /// <param name="text">The text to be modified according to the pattern.</param>
        /// <returns>Modified text to match the pattern.</returns>
        public static string ModifyText(string text, Ciphers.TypesOfCiphers typeOfCipher)
        {
            if (typeOfCipher == Ciphers.TypesOfCiphers.RailFence || 
                typeOfCipher == Ciphers.TypesOfCiphers.RotatingSquare)
            {
                text = Regex.Replace(text, engTextPattern, string.Empty);
            }
            else
            {
                text = Regex.Replace(text, rusTextPattern, string.Empty);
            }
            text = text.ToUpper();
            return text;
        }
    }
}
