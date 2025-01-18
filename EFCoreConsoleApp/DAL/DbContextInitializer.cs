using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCoreConsoleApp.DAL;

public class DbConfigInitalizer {
     
    public static IConfigurationRoot Configuration;

    public static void Build(){
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional:false, reloadOnChange: true);

        Configuration = builder.Build();
    }
}