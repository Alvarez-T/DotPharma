using Castle.DynamicProxy;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Proxy;

internal static class ProxiesExtensions
{
    private static T GenerateAnonymousProxyOf<T>(IInterceptor interceptor) where T : class
        => new ProxyGenerator().CreateInterfaceProxyWithoutTarget<T>(interceptor);

    public static TComponent GenerateComponentScriptOf<TComponent>(this IComponentScriptRegister register) where TComponent : class, IComponentScript 
        => (TComponent)GenerateAnonymousProxyOf<TComponent>(new ComponentScriptInterceptor());
}