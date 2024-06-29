using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components;

public interface IComponentScriptProvider<out T> : IReadOnlyList<T>
    where T : IComponentScript;