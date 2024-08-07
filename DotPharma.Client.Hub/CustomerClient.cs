using Act.SignalR.Client;
using DotPharma.Customer.Contracts;

namespace DotPharma.Client.Hub;

internal sealed class CustomerClient : HubClient, ICustomerClient
{

    public Task OnPersonalInfoUpdated(CustomerPersonalInfoUpdated @event)
    {
        throw new NotImplementedException();
    }

    public Task OnAddressUpdated(CustomerAddressUpdated @event)
    {
        throw new NotImplementedException();
    }
}