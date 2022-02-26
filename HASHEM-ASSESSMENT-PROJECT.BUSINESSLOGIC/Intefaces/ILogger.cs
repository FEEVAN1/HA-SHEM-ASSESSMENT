using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Intefaces
{
   public interface ILogger
    {
        Task LogMessage(string Logmessage, string location, string logtype);
    }
}
