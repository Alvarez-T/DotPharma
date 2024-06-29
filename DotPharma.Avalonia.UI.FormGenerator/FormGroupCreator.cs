namespace DotPharma.Avalonia.UI.FormGenerator;

public class FormGroupCreator<T>
{
    public FormGroupCreator<T> CreateGroupFor(Action<FormComponentBuilder<T>> contentExpression)
    {
        return this;
    }

}