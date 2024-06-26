using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using AvaloniaAppTemplate.ViewModels;

namespace AvaloniaAppTemplate;

public class ViewLocator : IDataTemplate
{
#if (AvaloniaStableChosen)
    public Control? Build(object? data)
#else
    public IControl Build(object data)
#endif
    {
        if (data is null)
            return null;
        
        var name = data.GetType().FullName!.Replace("ViewModel", "View", StringComparison.Ordinal);
        var type = Type.GetType(name);

        if (type != null)
        {
            var control = (Control)Activator.CreateInstance(type)!;
            control.DataContext = data;
            return control;
        }
        
        return new TextBlock { Text = "Not Found: " + name };
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}
