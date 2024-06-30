using System.Linq.Expressions;
using DotPharma.Avalonia.UI.FormGenerator.Components;
using DotPharma.Avalonia.UI.FormGenerator.Helpers;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;

public interface IComponentCreator<out TComponent>
{
    TComponent Component { get; }
}

public interface IComponentCreator<in TModel, out TComponent> : IComponentCreator<TComponent>
    where TModel : class
{

}

public static class ComponentScriptExtensions
{
    public static TComponentCreator SetHeader<TComponentCreator>(this TComponentCreator creator, string header)
        where TComponentCreator : IComponentCreator<IHeaderComponentScript>
    {
        creator.Component.Header = header;

        return creator;
    }

    public static TComponentCreator  SetProperty<TComponentCreator, TModel, TProperty>(this TComponentCreator creator,
        Expression<Func<TModel, TProperty>> memberAccessExpression)
        where TModel : class
        where TComponentCreator : IComponentCreator<TModel, IBindingComponentScript>
    {
        ExpressionsHelpers.EnsureAccessPropertyExpression(memberAccessExpression);
        creator.Component.MemberToBinding = (memberAccessExpression.Body as MemberExpression)!;

        return creator;
    }

    public static IComponentCreator<TModel, IBindingComponentScript> SetProperty<TModel, TProperty>(this IComponentCreator<TModel, IBindingComponentScript> creator,
        Expression<Func<TModel, TProperty>> memberAccessExpression)
        where TModel : class
    {
        return creator;
    }



    public static TComponentCreator SetDisplayMemberPath<TComponentCreator, TModel, TProperty, TMember>(
        this TComponentCreator creator,
        Func<TModel, IEnumerable<TProperty>> collectionAccess,
        Expression<Func<TProperty, TMember>> memberPathExpression)
        where TComponentCreator : IComponentCreator<ICollectionComponentScript>
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