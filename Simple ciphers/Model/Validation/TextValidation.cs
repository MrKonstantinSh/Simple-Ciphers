using System.Text.RegularExpressions;
using Simple_ciphers.Model.Ciphers;

namespace Simple_ciphers.Model.Validation
{
    public static class TextValidation
    {
        private const string EngTextPattern = "[А-Яа-я0-9`~!@#№$%^&*()_+={}:;|<>,.?/\'\"\t\n\r\\s\\[\\]\\\\-]";
        private const string RusTextPattern = "[a-zA-Z0-9`~!@#№$%^&*()_+={}:;|<>,.?/\'\"\t\n\r\\s\\[\\]\\\\-]";

        /// <summary>
        /// Deletes all characters except the English alphabet.
        /// </summary>
        /// <param name="text">The text to be modified according to the pattern.</param>
        /// <returns>Modified text to match the pattern.</returns>
        public static string ModifyText(string text, TypesOfCiphers typeOfCipher)
        {
            if (typeOfCipher == TypesOfCiphers.RailFence ||
                typeOfCipher == TypesOfCiphers.RotatingSquare)
            {
                text = Regex.Replace(text, EngTextPattern, string.Empty);
            }
            else
            {
                text = Regex.Replace(text, RusTextPattern, string.Empty);
            }
            text = text.ToUpper();
            return text;
        }
    }
}
