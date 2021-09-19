using System;
using System.Collections.Generic;
using CryptoAnalytics.Entities.Dto;


namespace CryptoAnalytics.Entities.Http
{
    public class UserResponse
    {
        public bool Success { get; set; }
        public UserDto User { get; set; }
        public List<string> Errors { get; set; }
        public UserResponse()
        {
            Errors = new List<string>();
        }
    }
}