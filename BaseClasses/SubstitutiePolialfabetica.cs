using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto_01.BaseClasses
{
    abstract class SubstitutiePolialfabetica
    {
        protected string plainText, cipherText;

        protected List<Dictionary<char, char>> encryptionKey;
        protected List<Dictionary<char, char>> decryptionKey;

        public SubstitutiePolialfabetica(string plainText)
        {
            this.plainText = plainText;
            encryptionKey = new();
            decryptionKey = new();
        }

        protected abstract void Encrypt();

        protected abstract void Decrypt();

        protected abstract void GenerateKeys();

        public void Print()
        {
            Console.WriteLine("Plain Text: " + plainText);
            Console.WriteLine("Cipher Text: " + cipherText);
        }

    }
}
