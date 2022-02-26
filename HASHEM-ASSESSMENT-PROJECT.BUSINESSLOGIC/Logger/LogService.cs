using HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Intefaces;
using HASHEM_ASSESSMENT_PROJECT.DATA.Models;
using System;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Logger
{
    public class LogService : ILogger
    {
        DbContextClass _dxt;
        public LogService(DbContextClass dxt)
        {
            _dxt = dxt;
        }
      
        public async Task LogMessage(string Logmessage, string location, string logtype)
        {
           await _dxt.Logs.AddAsync(new Logs() { LogTime = DateTime.Now, Location = location, Details = Logmessage, Type = logtype });
           await _dxt.SaveChangesAsync();
        }
    }
}
