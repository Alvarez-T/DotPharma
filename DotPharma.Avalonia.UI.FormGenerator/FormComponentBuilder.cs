using DotPharma.Avalonia.UI.FormGenerator.Engine.Components;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Proxy;

namespace DotPharma.Avalonia.UI.FormGenerator;


public class FormComponentBuilder<T>(IComponentScriptRegister componentRegister)
    where T : class
{
    private List<IComponentCreator<T, IComponentScript>> _componentsToBeCreated = [];

    public FormComponentBuilder<T> CreateComboBox(Action<IComponentCreator<T, IComboBoxScript>> comboBoxCreator)
        => RegisterComponentAndSelfReturn(comboBoxCreator);

    public FormComponentBuilder<T> CreateTextBox(Action<IComponentCreator<T, ITextBoxScript>> textBoxCreator)
    {
        object obj = null;
        return   RegisterComponentAndSelfReturn(textBoxCreator);
    }

    public IComponentCreator<T, ITextBoxScript> CreateTextBox()
    {
        return CreateComponent<ITextBoxScript>();
    }

    public IComponentCreator<T, TComponent> CreateComponent<TComponent>() where TComponent : class, IComponentScript
    {
        var componentProxy = componentRegister.GenerateComponentScriptOf<TComponent>();
        var componentCreator = new ComponentCreator<T, TComponent>(componentProxy);
        _componentsToBeCreated.Add(componentCreator);
        return componentCreator;
    }


    public FormComponentBuilder<T> CreateNumericBox(Action<IComponentCreator<T, INumericBoxScript>> numericBoxCreator)
        => RegisterComponentAndSelfReturn(numericBoxCreator);

    public FormComponentBuilder<T> CreateCheckBox(Action<IComponentCreator<T, ICheckBoxScript>> checkBoxCreator)
        => RegisterComponentAndSelfReturn(checkBoxCreator);

    public FormComponentBuilder<T> CreateDateBox(Action<IComponentCreator<T, IDateBoxScript>> dateSelectionCreator)
        => RegisterComponentAndSelfReturn(dateSelectionCreator);



    private FormComponentBuilder<T> RegisterComponentAndSelfReturn<TComponent>(
        Action<IComponentCreator<T, TComponent>> componentCreatorBuild) where TComponent : class, IComponentScript
    {
        var componentProxy = componentRegister.GenerateComponentScriptOf<TComponent>();
        var componentCreator = new ComponentCreator<T, TComponent>(componentProxy);
        componentCreatorBuild(componentCreator);
        componentRegister.RegisterComponent(componentProxy);
        return this;
    }
}


