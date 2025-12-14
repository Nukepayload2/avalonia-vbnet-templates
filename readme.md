# Avalonia VB Templates for `dotnet new`

For more information about `dotnet new` templates see [here](https://blogs.msdn.microsoft.com/dotnet/2017/04/02/how-to-create-your-own-templates-for-dotnet-new/).

## Installing the templates

### Dev packages
Run `install-dev-templates.ps1`

### Install from NuGet
[![NuGet version (Nukepayload2.Templates.Avalonia)](https://img.shields.io/nuget/v/Nukepayload2.Templates.Avalonia.svg?style=flat-square)](https://www.nuget.org/packages/Nukepayload2.Templates.Avalonia/)

Run from a command line (`.NET 7+`):

```powershell
dotnet new install Nukepayload2.Templates.Avalonia
```

For `.NET 6`, the argument is `--install`:
```powershell
dotnet new --install Nukepayload2.Templates.Avalonia
```

The templates should now be available in `dotnet new list`:

```
Template Name                        Short Name                 Language  Tags
-----------------------------------  -------------------------  --------  -----------------------------------------
Avalonia .NET App                    avalonia.app.vb               VB     Desktop/Xaml/Avalonia/Windows/Linux/macOS
Avalonia .NET MVVM App               avalonia.mvvm.vb              VB	  Desktop/Xaml/Avalonia/Windows/Linux/macOS
Avalonia UserControl                 avalonia.usercontrol.vb       VB	  Desktop/Xaml/Avalonia/Windows/Linux/macOS
Avalonia Window                      avalonia.window.vb            VB	  Desktop/Xaml/Avalonia/Windows/Linux/macOS
Avalonia TemplatedControl            avalonia.templatedcontrol.vb  VB	  Desktop/Xaml/Avalonia/Windows/Linux/macOS
```

The "Avalonia Cross Platform Application" template is not planned to be converted to VB. Because it has some limitations in pure VB solutions. It's recommended to create the Android and iOS parts with C# templates and use VB in other parts.

## Avalonia compatibility
### Package 1.0.0 and its prerelease versions
It's guaranteed to be compatible with `11.0.9`. Other versions may work, but they are not tested.

### Package 1.1.0
Tested with Avalonia `11.3.9` and .NET 10
