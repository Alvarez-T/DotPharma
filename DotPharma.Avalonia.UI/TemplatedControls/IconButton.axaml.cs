using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using DotPharma.Avalonia.UI.Common;
using DotPharma.Avalonia.UI.Helpers;

namespace DotPharma.Avalonia.UI.TemplatedControls
{
    [PseudoClasses(":right", ":left", ":top", ":bottom", ":empty")]
    public class IconButton : Button
    {
        public static readonly StyledProperty<object?> IconProperty = AvaloniaProperty.Register<IconButton, object?>(
       nameof(Icon));

        public object? Icon
        {
            get => GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly StyledProperty<IDataTemplate?> IconTemplateProperty = AvaloniaProperty.Register<IconButton, IDataTemplate?>(
            nameof(IconTemplate));

        public IDataTemplate? IconTemplate
        {
            get => GetValue(IconTemplateProperty);
            set => SetValue(IconTemplateProperty, value);
        }

        public static readonly StyledProperty<bool> IsLoadingProperty = AvaloniaProperty.Register<IconButton, bool>(
            nameof(IsLoading));

        public bool IsLoading
        {
            get => GetValue(IsLoadingProperty);
            set => SetValue(IsLoadingProperty, value);
        }

        public static readonly StyledProperty<Position> IconPlacementProperty = AvaloniaProperty.Register<IconButton, Position>(
            nameof(IconPlacement), defaultValue: Position.Left);

        public Position IconPlacement
        {
            get => GetValue(IconPlacementProperty);
            set => SetValue(IconPlacementProperty, value);
        }

        static IconButton()
        {
            IconPlacementProperty.Changed.AddClassHandler<IconButton, Position>((o, e) =>
            {
                o.SetPlacement(e.NewValue.Value, o.Icon);
            });
            IconProperty.Changed.AddClassHandler<IconButton, object?>((o, e) =>
            {
                o.SetPlacement(o.IconPlacement, e.NewValue.Value);
            });
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);
            SetPlacement(IconPlacement, Icon);
        }

        private void SetPlacement(Position placement, object? icon)
        {
            this.ResetAllPseudoClasses();

            if (icon is null)
                PseudoClasses.Set(":empty", true);

            PseudoClasses.Set(GetPseudoClassByPosition(placement), true);
         }

        private string GetPseudoClassByPosition(Position placement) => placement switch
        {
                Position.Left => ":left",
                Position.Right => ":right",
                Position.Top => ":top",
                Position.Bottom => ":bottom",
                _ => throw new ArgumentOutOfRangeException(nameof(placement), placement, null)
        };
    }
}
