using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotPharma.Avalonia.UI.FormGenerator.Components;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Proxy;
using DotPharma.Avalonia.UI.FormGenerator.Exceptions;

namespace DotPharma.Avalonia.UI.FormGenerator;

public class FormComponentBuilder<T>(IComponentScriptRegister componentRegister)
    where T : class
{
    public FormComponentBuilder<T> CreateComboBox(Action<CollectionComponentCreator<T>> comboBoxCreator)
        => RegisterComponentAndSelfReturn<IComponentScript>(comboBoxCreator)

    public FormComponentBuilder<T> CreateTextBox(Action<IComponentCreator<T>> textBoxCreator)
        => RegisterComponentAndSelfReturn<ITextBoxScript>(textBoxCreator);

    public FormComponentBuilder<T> CreateNumericBox(Action<FormComponentCreator<T>> numericBoxCreator)
        => RegisterComponentAndSelfReturn<INumericBoxScript>(numericBoxCreator);

    public FormComponentBuilder<T> CreateCheckBox(Action<FormComponentCreator<T>> checkBoxCreator)
        => RegisterComponentAndSelfReturn<ICheckBoxScript>(checkBoxCreator);

    public FormComponentBuilder<T> CreateDateSelection(Action<FormComponentCreator<T>> dateSelectionCreator)
        => RegisterComponentAndSelfReturn<IDateScript>(dateSelectionCreator);

    private FormComponentBuilder<T> RegisterComponentAndSelfReturn<TComponent>(
        Action<FormComponentCreator<T>> componentCreator) where TComponent : class, IComponentScript
    {
        var componentProxy = componentRegister.GenerateComponentScriptOf<TComponent>();
        componentRegister.RegisterComponent(componentProxy);
        componentRegister.RegisterComponent(componentProxy);
        return this;
    }


}

