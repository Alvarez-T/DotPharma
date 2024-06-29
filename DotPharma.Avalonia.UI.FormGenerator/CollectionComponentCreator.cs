using System.Linq.Expressions;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;
using DotPharma.Avalonia.UI.FormGenerator.Helpers;

namespace DotPharma.Avalonia.UI.FormGenerator;

public class CollectionComponentCreator<T>(IComponentScript componentScript) : FormComponentCreator<T>(componentScript) where T : class
{
    protected ICollectionComponentScript CollectionScript =>
        (ICollectionComponentScript)ComponentScript;

    public CollectionComponentCreator<T> SetDisplayMemberPath<TProperty, TElement>(Func<T, IEnumerable<TProperty>> collectionAccess,
        Expression<Func<TProperty, TElement>> memberPathExpression)
    {
        ExpressionsHelpers.EnsureAccessPropertyExpression(memberPathExpression);
        CollectionScript.DisplayMemberPath = ExpressionsHelpers.BuildMemberPath(memberPathExpression);
        return Self();
    }
}