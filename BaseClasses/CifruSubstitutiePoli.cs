using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto_01.BaseClasses
{
    class CifruSubstitutiePoli : SubstitutiePolialfabetica
    {
        protected int n;
        protected string key;

        public CifruSubstitutiePoli(string plainText, int n, string key) : base(plainText)
        {
            this.n = n;
            this.key = CompleteKey(key.ToUpper());
            GenerateKeys();
            Encrypt();
            Decrypt();
        }

        private string CompleteKey(string key)
        {
            int length = plainText.Length - key.Length;
            for (int i=0; i < length; i++)
                key += key[i % key.Length];
            
            return key;
        }

        
        protected override void GenerateKeys()
        {    
            for (int i = 0; i < n; i++)
            {
                var encryptDictionary = new Dictionary<char, char>();
                var decryptDictionary = new Dictionary<char, char>();
                for (int j = 0; j < n; j++)
                {
                    encryptDictionary.Add((char)('A' + j), (char)('A' + (j + i) % 26));
                    decryptDictionary.Add((char)('A' + (j + i) % 26), (char)('A' + j));
                }
                encryptionKey.Add(encryptDictionary);
                decryptionKey.Add(decryptDictionary);

            }
            
        }

        protected override void Encrypt()
        {
            cipherText = string.Empty;
            for (int i = 0; i < plainText.Length; i++)
            {
                cipherText += encryptionKey[(int)key[i] - 65][plainText[i]];
            }
        }

        protected override void Decrypt()
        {
            plainText = string.Empty;
            for (int i = 0; i < cipherText.Length; i++)
            {
                plainText += decryptionKey[(int)key[i] - 65][cipherText[i]];
            }
        }


    }
}
