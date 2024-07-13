using System.Linq.Expressions;

namespace DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Extensions;

public static class FormComponentBuilderExtensions
{
    public static FormComponentBuilder<T> CreateTextBoxFor<T>(this FormComponentBuilder<T> form,
        Expression<Func<T, string>> accessExpression, string header = "") where T : class
    {
        return form.CreateTextBox(creator => creator.SetBinding(accessExpression).SetHeader(header));
    }

    public static FormComponentBuilder<T> CreateNumericBoxFor<T>(this FormComponentBuilder<T> form,
        Expression<Func<T, int>> accessExpression, string header) where T : class
    {
        return form.CreateNumericBox(creator => creator.SetBinding(accessExpression).SetHeader(header));
    }

    public static FormComponentBuilder<T> CreateCheckBoxFor<T>(this FormComponentBuilder<T> form,
        Expression<Func<T, bool>> accessExpression, string header) where T : class
    {
        form.CreateCheckBox(creator => creator.SetBinding(accessExpression).SetHeader(header));
        return form;
    }

    public static FormComponentBuilder<T> CreateComboBoxFor<T, TProperty>(this FormComponentBuilder<T> form,
        Expression<Func<T, TProperty>> accessExpression, string header) where T : class
    {
        return form.CreateComboBox(creator => creator.SetBinding(accessExpression).SetHeader(header));
    }

    public static FormComponentBuilder<T> CreateDateSelectionFor<T>(this FormComponentBuilder<T> form,
        Expression<Func<T, DateTime>> accessExpression, string header) where T : class
    {
        return form.CreateDateBox(creator => creator.SetBinding(accessExpression).SetHeader(header));
    }
}