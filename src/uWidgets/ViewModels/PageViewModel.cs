﻿using System;
using Avalonia.Media;
using uWidgets.Core.Models;

namespace uWidgets.ViewModels;

public record PageViewModel(Type? Type, StreamGeometry? Icon, string Text, AssemblyInfo? AssemblyInfo = null)
{
    public bool IsSeparator => Type == null;
    public bool IsNotSeparator => !IsSeparator;
}