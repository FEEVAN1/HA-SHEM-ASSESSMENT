using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Intefaces
{
   public interface ISecure
    {
      public string EncryptString(string plainText);
      public string DecryptString(string cipherText);
    }
}
