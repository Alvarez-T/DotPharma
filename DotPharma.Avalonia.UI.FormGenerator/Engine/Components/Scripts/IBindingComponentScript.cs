using System.Linq.Expressions;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;

public interface IBindingComponentScript : IComponentScript
{
    public MemberExpression MemberToBinding { get; set; }
}