// See https://aka.ms/new-console-template for more information
using DNZ.Calculator.GrpcServer.Protos;
using Grpc.Net.Client;
using System;

namespace DNZ.Calculator.GprcClient
{
    class program
    {
        static void Main(string[] args)
        {
            using var grpcChannel = GrpcChannel.ForAddress("https://localhost:7289/");

            var client = new CalculatorService.CalculatorServiceClient(grpcChannel);

            SumRequest sumRequest = new()
            {
                FNumber = 1010,
                SNumber = 1010,
            };

            Sumresponse sumresponse = client.Sum(sumRequest);

            Console.WriteLine(sumresponse.Result);
            Console.ReadKey();
        }
    }
}