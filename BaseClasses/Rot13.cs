using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto_01.BaseClasses
{
    internal class Rot13 : CifruSubstitutieMono
    {
        public Rot13(string plainText) : base(plainText, 13)
        {

        }
    }
    
}
