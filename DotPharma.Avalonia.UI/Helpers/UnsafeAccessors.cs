﻿using System.Runtime.CompilerServices;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;

namespace DotPharma.Avalonia.UI.Helpers;

public static class UnsafeAccessors
{
    [UnsafeAccessor(UnsafeAccessorKind.Method, Name = "get_PseudoClasses")]
    public static extern IPseudoClasses GetPseudoClasses(StyledElement @this);
}