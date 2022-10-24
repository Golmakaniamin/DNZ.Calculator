using DNZ.Calculator.GrpcServer.Protos;
using Grpc.Core;
using static DNZ.Calculator.GrpcServer.Protos.CalculatorService;

namespace DNZ.Calculator.GrpcServer.GrpcServices
{
    public class CalculatorGrpcService : CalculatorServiceBase
    {
        public override Task<Sumresponse> Sum(SumRequest request, ServerCallContext context)
        {
            long sum = request.FNumber + request.SNumber;

            Sumresponse sumresponse = new() { 
                Result = sum,
            };

            return Task.FromResult(sumresponse);
        }
    }
}
