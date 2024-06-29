using System.Collections;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components;

internal class ComponentScriptProvider<T> : IComponentScriptProvider<T>, IComponentScriptRegister
    where T : IComponentScript
{
    private readonly List<IComponentScript> _components = [];

    public int Count => _components.Count;

    public T this[int index] => throw new NotImplementedException();

    public void RegisterComponent<TComponent>(TComponent script) where TComponent : class, IComponentScript 
        => _components.Add(script);

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var component in _components)
        {
            if (component is IComponentTypeHolder<T> holder)
            {
                yield return default;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}