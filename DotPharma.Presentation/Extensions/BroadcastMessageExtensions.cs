using NavigatR.CommunityToolkit;

namespace DotPharma.Presentation.Extensions;

internal static class BroadcastMessageExtensions
{ 
    public static BroadcastMessage<T> On<T, TMessage>(this BroadcastMessage<T> broadcast, )
        where T : class
        where TMessage : class;
}