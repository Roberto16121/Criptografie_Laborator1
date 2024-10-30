using Cripto_01.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto_01
{
    internal class CifruVigenere : CifruSubstitutiePoli
    {
        public CifruVigenere(string plainText, int n, string key) : base(plainText, n, key)
        {

        }
    }
}
