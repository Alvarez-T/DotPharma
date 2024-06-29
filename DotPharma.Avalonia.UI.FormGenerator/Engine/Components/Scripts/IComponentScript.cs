using System.Linq.Expressions;
using DotPharma.Avalonia.UI.FormGenerator.Components;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;

public interface IComponentCreator<out T>
{

}

public static class TestComponntExtensions
{
    

    public static IComponentCreator<ITextBoxScript> Ah<TComp>(this TComp test)
        where TComp : class, IComponentCreator<ITextBoxScript>
    {
        return test;
    }

    public static TComp SetHeader<TComp>(this TComp comp, string test)
        where TComp : IComponentCreator<IHeaderComponentScript>
    {
        return comp;
    }

    
}

public interface IComponentScript
{
    internal List<IComponentSettingsHolder<IComponentSetting>> Settings { get; }
}