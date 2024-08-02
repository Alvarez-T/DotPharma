using System.Runtime.CompilerServices;
using DotPharma.Customer.Contracts;
using Microsoft.AspNetCore.SignalR.Client;

namespace DotPharma.Client.Hub;

public delegate Task HubMessageHandler<in TEvent>(TEvent @event) where TEvent : class;

public interface ICustomerClient : IHubClient
{
    Task OnPersonalInfoUpdated(CustomerPersonalInfoUpdated @event);
    Task OnAddressUpdated(CustomerAddressUpdated @event);
}

public abstract class HubClient : IHubClient
{
    public HubClient()
    {
        
    }
}

internal class CustomerClient : ICustomerClient
{
    private readonly Dictionary<Type, Delegate> _messageHandlers;

    public CustomerClient(Dictionary<Type, Delegate> messageHandlers)
    {
        _messageHandlers = messageHandlers;
    }

    public Task OnPersonalInfoUpdated(CustomerPersonalInfoUpdated @event)
    {
        throw new NotImplementedException();
    }

    public Task OnAddressUpdated(CustomerAddressUpdated @event)
    {
        throw new NotImplementedException();
    }
}

public class HubClientBuilder<THandler> where THandler : IHubClient
{
    private readonly Dictionary<Type, Delegate> handlers = [];
    public THandler Build()
    {
        throw new NotImplementedException();
    }

    public HubClientBuilder<THandler> AssignHandler<TMessage>(HubMessageHandler<TMessage> messageHandler)
        where TMessage : class
    {
        handlers.TryAdd(typeof(TMessage), messageHandler);
        return this;
    }
}

public static class test
{
    public static void testes()
    {
        new HubClientBuilder<ICustomerClient>()
            .AssignHandler<CustomerPersonalInfoUpdated>(p => p.)
    }

}

public interface IHubClient
{

}

