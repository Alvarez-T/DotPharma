using System.Linq.Expressions;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;

public interface IBindingComponentScript
{
    public MemberExpression MemberToBinding { get; set; }
}