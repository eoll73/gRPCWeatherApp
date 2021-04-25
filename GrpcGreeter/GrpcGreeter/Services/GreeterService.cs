using Grpc.Core;
using GrpcGreeter.API;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly IApiService _apiService;

        private readonly string key = "accfabff0502039ff0816b0379fa1f5e";
        public GreeterService(ILogger<GreeterService> logger,IApiService apiService)
        {
            _logger = logger;
            _apiService = apiService; 
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            var resault = _apiService.GetWeather(key);
            return Task.FromResult(new HelloReply
            {
                Message =string.Format(@" 
                                         �����: {0} 
                                         ����������: ������ {1}
                                         ����������: ������� {2}
                                         �����������: {4} �������� 
                                         ������ ��� ������� ����: {3} ������
", resault.name, resault.coord.lon , resault.coord.lat, resault.main.sea_level, resault.main.temp)
                
                + request.Name
            });
        }

    }
}
