using System.Linq.Expressions;
using DotPharma.Avalonia.UI.FormGenerator.Components;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Extensions;

public static class FormComponentBuilderExtensions
{
    public static FormComponentBuilder<T> CreateTextBoxFor<T>(this FormComponentBuilder<T> form,
        Expression<Func<T, string>> accessExpression, string header = "") where T : class
    {
        return form.CreateTextBox(creator => creator.SetProperty(accessExpression).SetHeader(header));
    }

    public static FormComponentBuilder<T> CreateNumericBoxFor<T>(this FormComponentBuilder<T> form,
        Expression<Func<T, int>> accessExpression, string header) where T : class
    {
        return form.CreateNumericBox(creator => creator.SetProperty(accessExpression).SetHeader(header));
    }

    public static FormComponentBuilder<T> CreateCheckBoxFor<T>(this FormComponentBuilder<T> form,
        Expression<Func<T, bool>> accessExpression, string header) where T : class
    {
        return form.CreateCheckBox(creator => creator.SetProperty(accessExpression).SetHeader(header));
    }

    public static FormComponentBuilder<T> CreateComboBoxFor<T, TProperty>(this FormComponentBuilder<T> form,
        Expression<Func<T, TProperty>> accessExpression, string header) where T : class
    {
        return form.CreateComboBox(creator => creator.SetProperty(accessExpression).SetHeader(header));
    }

    public static FormComponentBuilder<T> CreateDateSelectionFor<T>(this FormComponentBuilder<T> form,
        Expression<Func<T, DateTime>> accessExpression, string header) where T : class
    {
        return form.CreateDateSelection(creator => creator.SetProperty(accessExpression).SetHeader(header));
    }
}