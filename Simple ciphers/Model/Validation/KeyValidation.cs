using System.Text.RegularExpressions;
using Simple_ciphers.Model.Ciphers;

namespace Simple_ciphers.Model.Validation
{
    public static class KeyValidation
    {
        private const string KeyPattern = "[a-zA-ZА-Яа-я`~!@#№$%^&*()_+={}:;|<>,.?/\'\"\t\n\r\\s\\[\\]\\\\-]";
        private const string VigenerKeyPattern = "[a-zA-Z0-9`~!@#№$%^&*()_+={}:;|<>,.?/\'\"\t\n\r\\s\\[\\]\\\\-]";

        /// <summary>
        /// Deletes the corresponding characters according to the selected pattern.
        /// </summary>
        /// <param name="key">The key to change according to the pattern.</param>
        /// <returns>Modified key according to pattern.</returns>
        public static string ModifyKey(string key, TypesOfCiphers typeOfCipher)
        {
            if (typeOfCipher == TypesOfCiphers.RailFence ||
                typeOfCipher == TypesOfCiphers.RotatingSquare)
            {
                key = Regex.Replace(key, KeyPattern, string.Empty);
            }
            else
            {
                key = Regex.Replace(key, VigenerKeyPattern, string.Empty);
                key = key.ToUpper();
            }
            return key;
        }

    }
}
