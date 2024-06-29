using Castle.DynamicProxy;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Proxy;

internal class ComponentScriptInterceptor : IInterceptor
{
    private readonly Dictionary<string, object> _properties = new Dictionary<string, object>();

    public void Intercept(IInvocation invocation)
    {
        if (invocation.Method.Name.StartsWith("get_"))
        {
            var propName = invocation.Method.Name.Substring(4);
            if (_properties.TryGetValue(propName, out var value))
            {
                invocation.ReturnValue = value;
            }
        }
        else if (invocation.Method.Name.StartsWith("set_"))
        {
            var propName = invocation.Method.Name.Substring(4);
            _properties[propName] = invocation.Arguments[0];
        }
    }
}