using System.Linq.Expressions;
using Avalonia.Controls;
using Avalonia.Media;

namespace DotPharma.Avalonia.UI.FormGenerator.Components;

public interface IBindingMediator<T>
{

}

public interface IComponent
{
    void ConfigureDefaults<T, TComponent>(ComponentConfiguration<T, TComponent> componentConfiguration)
        where T : IComponent;
}

public interface ITextBoxComponent : IComponent
{

}

public interface IDateComponent: IComponent
{

}

public interface IComboBoxComponent: IComponent
{

}

public interface INumericBoxComponent : IComponent
{

}

public class TestComponent
{
    public TestComponent()
    {
        var builder = new ComponentBuilder();

        builder.Component<ITextBoxComponent, TextBox>()
            .SetMainBindingProperty(t => t.Text)
            .SetDefaults(t =>
            {
                t.Background = Brushes.AliceBlue;
            });
    }
}

public class ComponentConfiguration<T, TComponent>
    where T : IComponent
{
    public ComponentConfiguration<T, TComponent> SetMainBindingProperty<TProperty>(Expression<Func<TComponent, TProperty>> bindingAccessExpression)
    {
        
    }

    public ComponentConfiguration<T, TComponent> SetDefaults(Action<TComponent> creatingDefault)
    {

    }
}

public class ComponentBuilder
{
    public ComponentConfiguration<T, TComponent> Component<T, TComponent>()
        where T : IComponent
    {

    }

}


