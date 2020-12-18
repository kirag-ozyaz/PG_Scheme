using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;


public class SecureAES
{
        //public static void Main()
        //{
        //    string original = "Here is some data to encrypt!";

        //    // Create a new instance of the Aes
        //    // class.  This generates a new key and initialization 
        //    // vector (IV).
        //    using (Aes myAes = Aes.Create())
        //    {

        //        // Encrypt the string to an array of bytes.
        //        byte[] encrypted = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);

        //        // Decrypt the bytes to a string.
        //        string roundtrip = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

        //        //Display the original data and the decrypted data.
        //        Console.WriteLine("Original:   {0}", original);
        //        Console.WriteLine("Round Trip: {0}", roundtrip);
        //    }
        //}
        public static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
}
/// <summary>
/// шифрование и дешифрование текста для текущего пользователя
/// другой пользователь не сможет дешифровать информацию другого пользователя
/// </summary>
public static class SecureIt
{
    private static readonly byte[] entropy = Encoding.Unicode.GetBytes("Salt Is Not A Password");

    public static string EncryptString(this SecureString input)
    {
        if (input == null)
        {
            return null;
        }

        var encryptedData = ProtectedData.Protect(
            Encoding.Unicode.GetBytes(input.ToInsecureString()),
            entropy,
            DataProtectionScope.CurrentUser);

        return Convert.ToBase64String(encryptedData);
    }

    public static SecureString DecryptString(this string encryptedData)
    {
        if (encryptedData == null)
        {
            return null;
        }

        try
        {
            var decryptedData = ProtectedData.Unprotect(
                Convert.FromBase64String(encryptedData),
                entropy,
                DataProtectionScope.CurrentUser);

            return Encoding.Unicode.GetString(decryptedData).ToSecureString();
        }
        catch
        {
            return new SecureString();
        }
    }

    public static SecureString ToSecureString(this IEnumerable<char> input)
    {
        if (input == null)
        {
            return null;
        }

        var secure = new SecureString();

        foreach (var c in input)
        {
            secure.AppendChar(c);
        }

        secure.MakeReadOnly();
        return secure;
    }

    public static string ToInsecureString(this SecureString input)
    {
        if (input == null)
        {
            return null;
        }

        var ptr = Marshal.SecureStringToBSTR(input);

        try
        {
            return Marshal.PtrToStringBSTR(ptr);
        }
        finally
        {
            Marshal.ZeroFreeBSTR(ptr);
        }
    }

    public static string Расшифровать(string inStr)
    {
        string cypherText = inStr;
        string clearText;
        using (var secureString = cypherText.DecryptString())
        {
            clearText = secureString.ToInsecureString();
        }

        string outStr = clearText;
        return outStr;
    }
    public static string Зашифровать(string inStr)
    {
        string cypherText;
        using (var secureString = inStr.ToSecureString())
        {
            cypherText = secureString.EncryptString();
        }
       return cypherText.ToString();
    }

}