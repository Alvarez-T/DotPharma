namespace DotPharma.Avalonia.UI.FormGenerator;

public class FormGroupHeaderCreator<T> : FormGroupCreator<T>
{
    private readonly FormGroupCreator<T> _groupCreator;

    public FormGroupHeaderCreator(FormGroupCreator<T> groupCreator)
    {
        _groupCreator = groupCreator;
    }

    public FormGroupHeaderCreator<T> WithHeader(string header)
    {
        return this;
    }
}