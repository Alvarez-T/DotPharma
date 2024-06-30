namespace DotPharma.Avalonia.UI.FormGenerator;

public class FormGroupCreator<T>
    where T : class
{
    public FormGroupCreator<T> CreateGroupFor(Action<FormComponentBuilder<T>> contentExpression)
    {
        return this;
    }

}