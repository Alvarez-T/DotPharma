using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace DotControls.WPF;

public sealed class Menu : ItemsControl
{
    public Menu()
    {
        this.DefaultStyleKey = typeof(Menu);
    }
}
