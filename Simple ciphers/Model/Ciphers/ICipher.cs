using System;

namespace Simple_ciphers.Model.Ciphers
{
    /// <summary>
    /// An interface that includes encryption and decryption methods.
    /// </summary>
    public interface ICipher
    {
        string Encrypt(string plaintext, string key);

        string Decrypt(string ciphertext, string key);
    }
}
