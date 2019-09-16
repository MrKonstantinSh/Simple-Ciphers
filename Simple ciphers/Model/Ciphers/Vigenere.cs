using System;

namespace Simple_ciphers.Model.Ciphers
{
    /// <summary>
    /// Class allows you to encrypt and decrypt text using a cipher "Vigenere".
    /// About cipher: https://en.wikipedia.org/wiki/Vigen%C3%A8re_cipher.
    /// </summary>
    public class Vigenere : ICipher
    {
        private readonly string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        /// <summary>
        /// An empty class constructor. Initializes the alphabet to the default value.
        /// </summary>
        public Vigenere()
        {

        }

        /// <summary>
        /// Class constructor. Initializes the alphabet.
        /// </summary>
        /// <param name="alphabet">The alphabet used in the lookup table.</param>
        public Vigenere(string alphabet)
        {
            this.alphabet = alphabet;
        }

        /// <summary>
        /// Defines the index of a character in the alphabet.
        /// </summary>
        /// <param name="chr">The character whose index you want to know.</param>
        /// <returns>Index character in the alphabet.</returns>
        private int GetCharIndexInAlphabet(char chr)
        {
            return alphabet.IndexOf(chr);
                
        }

        /// <summary>
        /// Generates a progressive key for the Vigenere cipher.
        /// </summary>
        /// <param name="key">Source key.</param>
        /// <param name="keyLength">The required key length.</param>
        /// <returns>Progressive key of the required length.</returns>
        private string GenerateProgressiveKey(string key, int keyLength)
        {
            string progressiveKey = null;

            for (int i = 0; i < keyLength; i++)
            {
                int tmp = GetCharIndexInAlphabet(key[i % key.Length]) + (i / key.Length) % alphabet.Length;
                progressiveKey += alphabet[tmp];
            }
            return progressiveKey;
        }

        /// <summary>
        /// Encrypts text using the "Vigenere" algorithm.
        /// </summary>
        /// <param name="plaintext">The text to be encrypted.</param>
        /// <param name="key">The key for the lookup table.</param>
        /// <returns>The ciphertext.</returns>
        public string Encrypt(string plaintext, string key)
        {
            string progressiveKey = GenerateProgressiveKey(key, plaintext.Length);
            char[] ciphertext = new char[plaintext.Length];


            for (int i = 0; i < plaintext.Length; i++)
            {
                int charIndex = (GetCharIndexInAlphabet(plaintext[i]) + 
                    GetCharIndexInAlphabet(progressiveKey[i])) % alphabet.Length;
                ciphertext[i] = alphabet[charIndex];
            }
            return new string(ciphertext);
        }

        /// <summary>
        /// Decrypts text using the "Vigenere" algorithm.
        /// </summary>
        /// <param name="ciphertext">The text to decrypt.</param>
        /// <param name="key">The key for the lookup table.</param>
        /// <returns>Decrypted text.</returns>
        public string Decrypt(string ciphertext, string key)
        {
            string progressiveKey = GenerateProgressiveKey(key, ciphertext.Length);
            char[] plaintext = new char[ciphertext.Length];

            for (int i = 0; i < ciphertext.Length; i++)
            {
                int charIndex = (GetCharIndexInAlphabet(ciphertext[i]) + alphabet.Length -
                    GetCharIndexInAlphabet(progressiveKey[i])) % alphabet.Length;
                plaintext[i] = alphabet[charIndex];
            }
            return new string(plaintext);
        }
    }
}
