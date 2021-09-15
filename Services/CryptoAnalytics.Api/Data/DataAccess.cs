using CryptoAnalytics.Api.Data.Interfaces;
using System.Data.Common;
using MySqlConnector;

namespace CryptoAnalytics.Api.Data
{
    public class DataAccess : IData
    {
        private MySqlConnection _connection;
        DbConnection IData.Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new MySqlConnection("server=192.168.1.69;user=testguy;password=root;database=crypto;port=3306");
                }
                return _connection;
            }
        }
    }
}