using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto_01.BaseClasses
{
    internal class CifrulCezar : CifruSubstitutieMono
    {
        public CifrulCezar(string plainText) : base(plainText, 3)
        {

        }
    }
}
