using System.Collections.Generic;
using ReactiveUI;
using uWidgets.Core.Interfaces;

namespace uWidgets.ViewModels;

public class AdvancedViewModel(IAppSettingsProvider appSettingsProvider) : ReactiveObject
{
    public List<string> Fonts => ["Inter", "Segoe UI", "Microsoft YaHei"];

    public string Font
    {
        get => appSettingsProvider.Get().Theme.FontFamily;
        set
        {
            var settings = appSettingsProvider.Get();
            var theme = settings.Theme with { FontFamily = value };
            var newSettings = settings with { Theme = theme };
            appSettingsProvider.Save(newSettings);
        }
    }

    public bool UseNativeFrame
    {
        get => appSettingsProvider.Get().Theme.UseNativeFrame;
        set
        {
            var settings = appSettingsProvider.Get();
            var theme = settings.Theme with { UseNativeFrame = value };
            var newSettings = settings with { Theme = theme };
            appSettingsProvider.Save(newSettings);
        }        
    }
    
    public int Size
    {
        get => appSettingsProvider.Get().Dimensions.Size;
        set
        {
            var settings = appSettingsProvider.Get();
            var dimensions = settings.Dimensions with { Size = value };
            var newSettings = settings with { Dimensions = dimensions };
            appSettingsProvider.Save(newSettings);
        }
    }
    
    public int Margin
    {
        get => appSettingsProvider.Get().Dimensions.Margin;
        set
        {
            var settings = appSettingsProvider.Get();
            var dimensions = settings.Dimensions with { Margin = value };
            var newSettings = settings with { Dimensions = dimensions };
            appSettingsProvider.Save(newSettings);
        }
    }
    
    public int Radius
    {
        get => appSettingsProvider.Get().Dimensions.Radius;
        set
        {
            var settings = appSettingsProvider.Get();
            var dimensions = settings.Dimensions with { Radius = value };
            var newSettings = settings with { Dimensions = dimensions };
            appSettingsProvider.Save(newSettings);
        }
    }
    
    public bool SnapPosition
    {
        get => appSettingsProvider.Get().Layout.SnapPosition;
        set
        {
            var settings = appSettingsProvider.Get();
            var newLayout = settings.Layout with { SnapPosition = value };
            var newSettings = settings with { Layout = newLayout };
            appSettingsProvider.Save(newSettings);
        }
    }
    
    public bool SnapSize 
    {
        get => appSettingsProvider.Get().Layout.SnapSize;
        set
        {
            var settings = appSettingsProvider.Get();
            var newLayout = settings.Layout with { SnapSize = value };
            var newSettings = settings with { Layout = newLayout };
            appSettingsProvider.Save(newSettings);
        }
    }
    
    public bool LockPosition
    {
        get => appSettingsProvider.Get().Layout.LockPosition;
        set
        {
            var settings = appSettingsProvider.Get();
            var newLayout = settings.Layout with { LockPosition = value };
            var newSettings = settings with { Layout = newLayout };
            appSettingsProvider.Save(newSettings);
        }
    }
    
    public bool LockSize
    {
        get => appSettingsProvider.Get().Layout.LockSize;
        set
        {
            var settings = appSettingsProvider.Get();
            var newLayout = settings.Layout with { LockSize = value };
            var newSettings = settings with { Layout = newLayout };
            appSettingsProvider.Save(newSettings);
        }
    }
}