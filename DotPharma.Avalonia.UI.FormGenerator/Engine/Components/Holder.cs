using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components;

internal interface IComponentSettingsHolder<out T> where T : IComponentSetting;
internal record ComponentSettingHolder<T>() : IComponentSettingsHolder<T> where T : IComponentSetting;
internal interface IComponentTypeHolder<out T> where T : IComponentScript;
internal record ComponentTypeHolder<T>() : IComponentTypeHolder<T> where T : IComponentScript;