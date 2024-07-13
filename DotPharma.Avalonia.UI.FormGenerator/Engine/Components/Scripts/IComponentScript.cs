using System.Linq.Expressions;
using DotPharma.Avalonia.UI.FormGenerator.Helpers;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;

public interface IComponentCreator;

public interface IComponentCreator<out TComponent> : IComponentCreator
{
    TComponent Component { get; }
}

public interface IComponentCreator<TModel, TComponent> : IComponentCreator<TModel, TComponent, IComponentCreator<TModel, TComponent>>
{

}

public interface IComponentCreator<in TModel, out TComponent, TSelf>
    where TSelf : IComponentCreator<TModel, TComponent, TSelf>;

public static class ComponentScriptExtensions
{
    public static TComponentCreator SetHeader<TComponentCreator>(this TComponentCreator creator, string header)
        where TComponentCreator : IComponentCreator<IHeaderComponentScript>
    {
        creator.Component.Header = header;

        return creator;
    }

    public static TComponentCreator SetBinding<TComponentCreator, TModel, TProperty>(this TComponentCreator creator,
        Expression<Func<TModel, TProperty>> memberAccessExpression)
        where TModel : class
        where TComponentCreator : IComponentCreator<TModel, IBindingComponentScript>
    {
        ExpressionsHelpers.EnsureAccessPropertyExpression(memberAccessExpression);
        creator.Component.MemberToBinding = (memberAccessExpression.Body as MemberExpression)!;

        return creator;
    }


    public static TComponentScript Test<TComponentScript, TProperty>(this TComponentScript script, Expression<Func<TComponentScript, TProperty>> memberAccessExpression)
        where TComponentScript : IComponentScript<TComponentScript>
    {

    }

    public static IComponentCreator<TModel, IBindingComponentScript> SetProperty<TModel, TProperty>(this IComponentCreator<TModel, IBindingComponentScript> creator,
        Expression<Func<TModel, TProperty>> memberAccessExpression)
        where TModel : class
    {
        return creator;
    }

    public static IComponentCreator<TModel, ICollectionComponentScript> SetDisplayMemberPath<TModel, TProperty, TMember>(
        this IComponentCreator<TModel, ICollectionComponentScript> creator,
        Func<TModel, IEnumerable<TProperty>> collectionAccess,
        Expression<Func<TProperty, TMember>> memberPathExpression)
    {
        ExpressionsHelpers.EnsureAccessPropertyExpression(memberPathExpression);
        creator.Component.DisplayMemberPath = ExpressionsHelpers.BuildMemberPath(memberPathExpression);

        return creator;
    }
}

public interface IComponentScript : IBindingComponentScript
{
    internal List<IComponentSettingsHolder<IComponentSetting>> Settings { get; }
}

public interface IComponentScript<T>
{

}

public class TestComponent
{
    public TestComponent()
    {
        object obj = null;
        var teste = (IComponentScript<Model>)obj;
        teste.Test(m => m.)
}