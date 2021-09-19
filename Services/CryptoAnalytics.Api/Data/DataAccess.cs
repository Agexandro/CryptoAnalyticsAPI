using CryptoAnalytics.Api.Data.Interfaces;
using System.Data.Common;
using MySqlConnector;
using Microsoft.Extensions.Configuration;


namespace CryptoAnalytics.Api.Data
{
    public class DataAccess : IData
    {
        private readonly IConfiguration _config;
        private MySqlConnection _connection;
        DbConnection IData.Connection
        {
            get
            {
                if (_connection == null)
                {
                    var strConnection = _config.GetConnectionString("DefaultConnection");
                    _connection = new MySqlConnection(strConnection);
                }
                return _connection;
            }
        }

        public DataAccess(IConfiguration config)
        {
            _config = config;
        }
    }
}