using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components;

public interface IComponentScriptRegister : IScriptRegister
{
    public void RegisterComponent<TComponent>(TComponent script) where TComponent : class, IComponentScript;
}