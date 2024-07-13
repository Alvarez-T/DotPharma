using System.Linq.Expressions;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;
using DotPharma.Avalonia.UI.FormGenerator.Helpers;

namespace DotPharma.Avalonia.UI.FormGenerator;

public class FluentComponentCreator<T, TComponent, TSelf>
    where TComponent : IComponentScript
    where TSelf : FluentComponentCreator<T, TComponent, TSelf>

public class ComponentCreator<T, TComponent> : IComponentCreator<T, TComponent>
    where TComponent : IComponentScript
{
    protected readonly IComponentScript ComponentScript;

    public ComponentCreator(TComponent componentScript)
    {
        ComponentScript = componentScript;
    }

    public TComponent Component { get; }

    public ComponentCreator<T, TComponent> SetBinding<TProperty>(
        Expression<Func<T, TProperty>> memberAccessExpression)
    {
        ExpressionsHelpers.EnsureAccessPropertyExpression(memberAccessExpression);
        Component.MemberToBinding = (memberAccessExpression.Body as MemberExpression)!;

        return creator;
    }
}
