using System.Linq.Expressions;
using DotPharma.Avalonia.UI.FormGenerator.Components;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;
using DotPharma.Avalonia.UI.FormGenerator.Helpers;

namespace DotPharma.Avalonia.UI.FormGenerator;

public abstract class FluentComponentCreator<TSelf, T>(IComponentScript componentScript) : IComponentCreator<T>
    where TSelf : FluentComponentCreator<TSelf, T>
    where T : class
{
    protected readonly IComponentScript ComponentScript = componentScript;

    public TSelf SetProperty<TProperty>(Expression<Func<T, TProperty>> accessExpression)
    {
        ExpressionsHelpers.EnsureAccessPropertyExpression(accessExpression);
        ComponentScript.MemberToBinding = (accessExpression.Body as MemberExpression)!;

        return Self();
    }

    public TSelf SetHeader(string header)
    {
        ComponentScript.Header = header;

        return Self();
    }

    public TSelf RegisterAdditionalSetting<TSetting>() where TSetting : class, IComponentSetting
    {
        ComponentScript.Settings.Add(new ComponentSettingHolder<TSetting>());

        return Self();
    }

    protected TSelf Self() => (TSelf)this;
}

public class FormComponentCreator<T>(IComponentScript componentScript)
    : FluentComponentCreator<FormComponentCreator<T>, T>(componentScript) where T : class;
