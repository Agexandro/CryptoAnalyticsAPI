using System.Data.Common;

namespace CryptoAnalytics.Api.Data.Interfaces
{
    public interface IData
    {
        DbConnection Connection { get; }
    }
}