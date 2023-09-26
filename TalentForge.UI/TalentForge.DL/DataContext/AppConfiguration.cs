using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentForge.DL.DataContext
{
    public class AppConfiguration
    {

        public AppConfiguration() 
        {

            var ConfigBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            var root = ConfigBuilder.Build();
            var appSetting = root.GetSection("ConnectionStrings:TalentForgeSQLConnection");
            SqlConnString = appSetting.Value;

        }

        public string SqlConnString { get; set; }

    }
}
