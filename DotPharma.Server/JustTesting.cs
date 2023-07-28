using Marten;
using Wolverine.Http;

namespace DotPharma.Server
{
    public record CheckProductNameIsAvailable(string Name);
    public record CheckEANIsAvailable(string EAN);

    public static class EANEndpoint
    {
        [WolverineGet("/ean")]
        public static string Get()
        {
            return "TESTE";
        }

        [WolverineGet("/ean2")]
        public static string Get2()
        {
            return "TESTE2";
        }
    }
}
