using System.Collections.Generic;

namespace CryptoAnalytics.Entities.Http
{
    public class BitsoResponse<T>
    {
        public bool Succes { get; set; }
        public T Payload { get; set; }
    }
}