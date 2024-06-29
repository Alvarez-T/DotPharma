namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components;

public interface IComponentSetting
{

}

public interface IPlaceholderSetting : IComponentSetting
{
    public bool UsePlaceholder { get; set; }
    public string PlaceholderContent { get; set; }

}