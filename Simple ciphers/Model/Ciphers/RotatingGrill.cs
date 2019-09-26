using System;
using System.Collections.Generic;

namespace Simple_ciphers.Model.Ciphers
{
    /// <summary>
    /// Class allows you to encrypt and decrypt text using a cipher "rotating grill".
    /// About cipher: https://en.wikipedia.org/wiki/Grille_(cryptography).
    /// </summary>
    public class RotatingGrill
    {
        private readonly int[][] key = new int[4][];
        private readonly int grillSize = 4;

        /// <summary>
        /// An empty class constructor. Initializes the key with a default value.
        /// </summary>
        /// <remarks>The grill is square in shape.</remarks>
        public RotatingGrill()
        {
            key[0] = new int[2] { 0, 0 };
            key[1] = new int[2] { 3, 1 };
            key[2] = new int[2] { 2, 2 };
            key[3] = new int[2] { 1, 3 };
        }

        /// <summary>
        /// Class constructor. Initializes the key and grill size.
        /// </summary>
        /// <param name="key">The position of the holes in the grill.</param>
        /// <param name="grillSize">Lattice size (height or width).</param>
        /// <remarks>The grill is square in shape.</remarks>
        public RotatingGrill(int[][] key, int grillSize)
        {
            this.key = key;
            this.grillSize = grillSize;
        }

        /// <summary>
        /// Calculates the new positions of holes in the grill when it rotates 90 degrees to the right.
        /// </summary>
        /// <param name="iteration">The iteration number of the grill rotation.</param>
        /// <returns>Array of indices of new holes in the grill.</returns>
        private int[][] GetNewHoleIndices(int iteration)
        {
            int[][] newHoleIndices =
            {
                new int[2],
                new int[2],
                new int[2],
                new int[2]
            };

            foreach (int[] elem in key)
            {
                int x;
                int y;
                if (iteration == 0 || iteration == 3)
                {
                    x = elem[0];
                }
                else
                {
                    x = grillSize - elem[0] - 1;
                }
                if (iteration <= 1)
                {
                    y = elem[1];
                }
                else
                {
                    y = grillSize - elem[1] - 1;
                }

                int[] newHoleIndex = { x, y };
                newHoleIndices[newHoleIndex[1]] = newHoleIndex;
            }
            return newHoleIndices;
        }

        /// <summary>
        /// Supplements the string with random letters of the alphabet until it becomes a multiple of grillSize^2.
        /// </summary>
        /// <param name="str">The string to be completed.</param>
        /// <returns>The extended line.</returns>
        private string ExpandString (string str)
        {
            Random rand = new Random();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            while (str.Length % 16 != 0)
            {
                str += alphabet[rand.Next(alphabet.Length)];
            }
            return str;
        }

        /// <summary>
        /// Splits a string into substrings of a specified size.
        /// </summary>
        /// <param name="str">A string to be split into strings of a specific size.</param>
        /// <param name="numberOfChar">The number of characters to be contained in the string.</param>
        /// <returns>A list of new lines of a given size.</returns>
        private List<string> Split(string str, int numberOfChar)
        {
            List<string> suitableSizeStrings = new List<string>();
            int startPos = 0;
            while (str.Length != 0)
            {
                suitableSizeStrings.Add(str.Substring(startPos, numberOfChar));
                str = str.Remove(startPos, numberOfChar);
            }
            return suitableSizeStrings;
        }

        /// <summary>
        /// Encrypts text whose size does not exceed the size of the grill.
        /// </summary>
        /// <param name="plaintext">The text to be encrypted.</param>
        /// <returns>Encrypted text.</returns>
        /// <remarks>The length of the text to be encrypted must not exceed
        /// the dimension of the grill (length x height).</remarks>
        private string EncryptSquare(string plaintext)
        {
            char[] ciphertext = new char[grillSize * grillSize];
            char[][] square =
            {
                new char[4],
                new char[4],
                new char[4],
                new char[4]
            };

            int currentIndex = 0;
            for (int i = 0; i < square.Length; i++)
            {
                int[][] newIndices = GetNewHoleIndices(i);
                foreach (int[] indices in newIndices)
                {
                    square[indices[1]][indices[0]] = plaintext[currentIndex++];
                }
            }

            int k = 0;
            for (int i = 0; i < square.Length; i++)
            {
                for (int j = 0; j < square[i].Length; j++)
                {
                    ciphertext[k] = square[i][j];
                    k++;
                }
            }
            return new string(ciphertext);
        }

        /// <summary>
        /// Decrypts text whose size does not exceed the size of the grill.
        /// </summary>
        /// <param name="ciphertext">The text to decrypt.</param>
        /// <returns>The ciphertext.</returns>
        /// <remarks>The length of the text to be decoded must not exceed
        /// the size of the lattice (length x height).</remarks>
        private string DecryptSquare(string ciphertext)
        {
            string plaintext = null;
            char[][] square =
            {
                new char[4],
                new char[4],
                new char[4],
                new char[4]
            };

            int currentIndex = 0;

            for (int i = 0; i < square.Length; i++)
            {
                for (int j = 0; j < square[i].Length; j++)
                {
                    square[i][j] = ciphertext[currentIndex++];
                }
            }

            for (int i = 0; i < square.Length; i++)
            {
                int[][] newIndices = GetNewHoleIndices(i);
                foreach (int[] indices in newIndices)
                {
                    plaintext += square[indices[1]][indices[0]];
                }
            }
            return plaintext;
        }

        /// <summary>
        /// Encrypts text using the "rotating grill" algorithm.
        /// </summary>
        /// <param name="plaintext">The text to be encrypted.</param>
        /// <returns>The ciphertext.</returns>
        public string Encrypt(string plaintext)
        {
            plaintext = ExpandString(plaintext);
            List<string> blocksOfText = Split(plaintext, 16);

            string ciphertext = null;
            foreach (string element in blocksOfText)
            {
                ciphertext += EncryptSquare(element);
            }
            return ciphertext;
        }

        /// <summary>
        /// Decrypts the text using the rotating grill algorithm.
        /// </summary>
        /// <param name="ciphertext">The text to decrypt.</param>
        /// <returns>Decrypted text.</returns>
        public string Decrypt(string ciphertext)
        {
            ciphertext = ExpandString(ciphertext);
            List<string> blocksOfText = Split(ciphertext, 16);

            string plaintext = null;
            foreach (string element in blocksOfText)
            {
                plaintext += DecryptSquare(element);
            }
            return plaintext;
        }
    }
}