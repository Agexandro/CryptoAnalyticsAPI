using System;
using System.Collections.Generic;
using CryptoAnalytics.Entities.Dto;

namespace CryptoAnalytics.Entities.Http
{
    public class Response<T>
    {

        public bool Success { get; set; }
        public T Data { get; set; }

        public List<string> Errors { get; set; }
        public Response()
        {
            Errors = new List<string>();
        }
    }
}