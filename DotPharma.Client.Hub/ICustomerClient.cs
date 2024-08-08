using System.Runtime.CompilerServices;
using Act.SignalR.Client;
using DotPharma.Customer.Contracts;
using Microsoft.AspNetCore.SignalR.Client;

namespace DotPharma.Client.Hub;

public interface ICustomerClient : IHubClient
{
    void OnPersonalInfoUpdated(CustomerPersonalInfoUpdated @event);
    void OnAddressUpdated(CustomerAddressUpdated @event);
}