using Avalonia.Layout;
using DotPharma.Avalonia.UI.FormGenerator.Common;
using DotPharma.Avalonia.UI.FormGenerator.Components;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Extensions;
using DotPharma.Avalonia.UI.FormGenerator.Engine.Components.Scripts;

namespace DotPharma.Avalonia.UI.FormGenerator;

public class Test
{
    public Test()
    {
        object t = null;
        var component = (IComponentCreator<>)t;
        component.Ah(new Model())
        var component2 = (IComponentCreator<ITextBoxScript>)t!;

        component2.Ah()
            .SetHeader("test");

        var formBuilder = new FormCreator<Model>();

        var test = new CollectionComponentCreator<Model>();
        test.SetDisplayMemberPath(m => m.Children, c => c.Name);

        formBuilder
            .CreateFormFor(groupBuilder =>
            {
                groupBuilder
                    .CreateGroupFor(contentBuilder =>
                    {
                        contentBuilder
                            .CreateTextBoxFor(m => m.Name, "Nome:")
                            .CreateTextBoxFor(m => m.Description, "Descrição:");
                    }).WithHeader("Informações Gerais")
                    .CreateGroupFor(contentBuilder =>
                    {
                        contentBuilder
                            .CreateNumericBoxFor(m => m.Age, "Idade:")
                            .CreateDateSelectionFor(m => m.DateRegistered, "Data de Cadastro:")
                            .CreateCheckBoxFor(m => m.IsActive, "Está ativo?")
                            .CreateComboBox(comboBoxBuilder =>
                            {
                                comboBoxBuilder
                                    .SetProperty(m => m.Children)
                                    .SetHeader("Children")
                                    .SetDisplayMemberPath(m => m.Children, c => c.Name);
                            });
                    }).WithHeader("Complementares");
            }).WithSettings(settings =>
            {
                settings.LabelPosition = LabelPosition.Left;
            });
    }
}