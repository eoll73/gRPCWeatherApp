using GrpcGreeter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter.API
{
    public interface IApiService
    {
        Weather GetWeather(string token);
    }
}
