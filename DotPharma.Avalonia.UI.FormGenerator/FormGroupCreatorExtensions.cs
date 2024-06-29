namespace DotPharma.Avalonia.UI.FormGenerator;

public static class FormGroupCreatorExtensions
{
    public static FormGroupHeaderCreator<T> WithHeader<T>(this FormGroupCreator<T> groupCreator, string header)
    {
        return new FormGroupHeaderCreator<T>(groupCreator)
            .WithHeader(header);
    }
}