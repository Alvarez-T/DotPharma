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
    public FormComponentBuilder<T> CreateComboBox(Action<IComponentCreator<T, IComboBoxScript>> comboBoxCreator)
        => RegisterComponentAndSelfReturn(comboBoxCreator);

    public FormComponentBuilder<T> CreateTextBox(Action<IComponentCreator<T, ITextBoxScript>> textBoxCreator)
    {
        object obj = null;
        return   RegisterComponentAndSelfReturn(textBoxCreator);
    }

    public FormComponentBuilder<T> CreateNumericBox(Action<IComponentCreator<T, INumericBoxScript>> numericBoxCreator)
        => RegisterComponentAndSelfReturn(numericBoxCreator);

    public FormComponentBuilder<T> CreateCheckBox(Action<IComponentCreator<T, ICheckBoxScript>> checkBoxCreator)
        => RegisterComponentAndSelfReturn(checkBoxCreator);

    public FormComponentBuilder<T> CreateDateSelection(Action<IComponentCreator<T, IDateScript>> dateSelectionCreator)
        => RegisterComponentAndSelfReturn(dateSelectionCreator);

    private FormComponentBuilder<T> RegisterComponentAndSelfReturn<TComponent>(
        Action<IComponentCreator<T, TComponent>> componentCreator) where TComponent : class, IComponentScript
    {
        var componentProxy = componentRegister.GenerateComponentScriptOf<TComponent>();
        componentRegister.RegisterComponent(componentProxy);
        componentRegister.RegisterComponent(componentProxy);
        return this;
    }



}

