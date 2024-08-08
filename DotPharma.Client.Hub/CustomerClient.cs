using Act.SignalR.Client;
using DotPharma.Customer.Contracts;
using Microsoft.AspNetCore.SignalR.Client;

namespace DotPharma.Client.Hub;

internal sealed class CustomerClient : HubClient, ICustomerClient
{
    public CustomerClient()
    {
        
    }

    public void OnPersonalInfoUpdated(CustomerPersonalInfoUpdated @event)
        => Send(@event);

    public void OnAddressUpdated(CustomerAddressUpdated @event)
        => Send(@event);
}