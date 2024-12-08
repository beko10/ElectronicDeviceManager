using System.Configuration;

namespace ElectronicDeviceManager.DataAccessLayer.Configuration;

public class DbConfiguration
{
    private static readonly string _connectionString;

     static DbConfiguration()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }

    public static string GetConnectionString()
    {
        return _connectionString;
    }
}
