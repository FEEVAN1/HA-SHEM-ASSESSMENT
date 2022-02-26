using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.DATA.Helper
{
    public class ConfigSettings
    {
        public static string Connect()
        {
            var configBuilder = new Microsoft.Extensions.Configuration.ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configBuilder.AddJsonFile(path, false);
            var root = configBuilder.Build();
            return root.GetSection("ConnectionStrings:DefaultConnection").Value.ToString();
        }
    }
}
