using Act.SignalR.Client;
using DotPharma.Pricing.Contracts;

namespace DotPharma.Client.Hub;

public interface IPricingClient : IHubClient
{
    void OnPriceIncreased(PriceIncreased @event);
    void OnPriceDecreased(PriceDecreased @event);
    void OnPriceDefined(PriceDefined @event);
}