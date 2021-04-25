using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = " Вот такая погода"});
            Console.WriteLine("Weather: " + reply.Message);
            Console.WriteLine("Задача \"практически\" выполнена согласно  ТЗ...");
            Console.ReadKey();
        }
    }
}