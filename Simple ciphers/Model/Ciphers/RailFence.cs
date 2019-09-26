using Simple_ciphers.Model.Validation;

namespace Simple_ciphers.Model.Ciphers
{
    /// <summary>
    /// Class allows you to encrypt and decrypt text using a cipher "rail fence".
    /// About cipher: https://en.wikipedia.org/wiki/Rail_fence_cipher.
    /// </summary>

    public sealed class RailFence : ICipher
    {
        /// <summary>
        /// The method calculates the index of the next cipher symbol.
        /// </summary>
        /// <param name="currentCharInStr">The number of the current character in the line.</param>
        /// <param name="rowNumber">Current line number.</param>
        /// <param name="fenceHeight">Fence height(key).</param>
        /// <returns>Next character index.</returns>
        private int GetIndexNextChar(int currentCharInStr, int rowNumber, int fenceHeight)
        {
            if (fenceHeight == 0 || fenceHeight == 1)
                return 1;

            // The maximum distance is reached on the first and last lines
            else if (rowNumber == 0 || rowNumber == fenceHeight - 1)
                return (fenceHeight - 1) * 2;
            else if (currentCharInStr % 2 == 0)
                return (fenceHeight - rowNumber - 1) * 2;
            return rowNumber * 2;
        }

        /// <summary>
        /// The method encodes plaintext with a cipher "Rail-Fence" with the specified key.
        /// </summary>
        /// <param name="plaintext">Text to be encrypted.</param>
        /// <param name="key">Fence height.</param>
        /// <returns>The ciphertext.</returns>
        public string Encrypt(string plaintext, string key)
        {

            int numericKey;
            int.TryParse(KeyValidation.ModifyKey(key, TypesOfCiphers.RailFence), out numericKey);

            if (numericKey == 0)
                numericKey = 1;

            string ciphertext = null;

            for (int rowNumber = 0; rowNumber < numericKey; rowNumber++)
            {
                for (int i = rowNumber, currentCharInStr = 0; i < plaintext.Length;
                    i += GetIndexNextChar(currentCharInStr, rowNumber, numericKey), currentCharInStr++)
                {
                    ciphertext += plaintext[i];
                }
            }

            return ciphertext;
        }

        /// <summary>
        /// The method decodes ciphertext with a cipher "Rail-Fence" with the specified key.
        /// </summary>
        /// <param name="ciphertext">Text to decrypt.</param>
        /// <param name="key">Fence height.</param>
        /// <returns>Decrypted text.</returns>
        public string Decrypt(string ciphertext, string key)
        {
            int numericKey;
            int.TryParse(KeyValidation.ModifyKey(key, TypesOfCiphers.RailFence), out numericKey);

            if (numericKey == 0)
                numericKey = 1;

            int currentPos = 0;
            char[] plaintext = new char[ciphertext.Length];

            for (int rowNumber = 0; rowNumber < numericKey; rowNumber++)
            {
                for (int i = rowNumber, currentCharInStr = 0; i < ciphertext.Length;
                    i += GetIndexNextChar(currentCharInStr, rowNumber, numericKey), currentCharInStr++)
                {
                    plaintext[i] = ciphertext[currentPos++];
                }
            }
            return new string(plaintext);
        }
    }
}