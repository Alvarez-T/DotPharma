using DotPharma.Avalonia.UI.FormGenerator.Controls;

namespace DotPharma.Avalonia.UI.FormGenerator;

public class FormCreator<T>
{
    public FormCreator<T> CreateFormFor(Action<FormGroupCreator<T>> groupExpression)
    {
        return this;
    }

    public FormCreator<T> WithSettings(Action<FormSettings> formSettings)
    {
        return this;
    }


}