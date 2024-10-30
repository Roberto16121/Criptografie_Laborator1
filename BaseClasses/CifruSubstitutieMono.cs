using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto_01.BaseClasses
{
    class CifruSubstitutieMono : SubstitutiePolialfabetica
    {
        protected int lenght;

        public CifruSubstitutieMono(string plainText, int n) : base(plainText)
        {
            lenght = n;
            GenerateKeys();
            Encrypt();
            Decrypt();

        }
        protected override void GenerateKeys()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < alphabet.Length; i++)
            {
                encryptionKey.Add(new Dictionary<char, char> { { (char)alphabet[i], (char)alphabet[(i + lenght) % 26] } });
                decryptionKey.Add(new Dictionary<char, char> { { (char)alphabet[(i + lenght) % 26], (char)alphabet[i] } });
            }
        }

        protected override void Encrypt()
        {
            cipherText = string.Empty;
            for (int i = 0; i < plainText.Length; i++)
            {
                cipherText += encryptionKey[((int)plainText[i] - 65)][plainText[i]];
            }
        }

        protected override void Decrypt()
        {
            plainText = string.Empty;
            for (int i = 0; i < cipherText.Length; i++)
            {
                plainText += decryptionKey[((int)cipherText[i] + 65 - lenght)%26][cipherText[i]];
            }
        }


    }
}
