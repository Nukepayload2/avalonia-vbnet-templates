Imports Avalonia
Imports Avalonia.Controls.ApplicationLifetimes
#If CommunityToolkitChosen Then
Imports Avalonia.Data.Core
Imports Avalonia.Data.Core.Plugins
#End If
Imports Avalonia.Markup.Xaml
Imports AvaloniaAppTemplate.ViewModels
Imports AvaloniaAppTemplate.Views

Partial Public Class App
    Inherits Application

    Public Overrides Sub Initialize()
        AvaloniaXamlLoader.Load(Me)
    End Sub

    Public Overrides Sub OnFrameworkInitializationCompleted()
        Dim desktop = TryCast(ApplicationLifetime, IClassicDesktopStyleApplicationLifetime)
        If desktop IsNot Nothing Then
#If CommunityToolkitChosen Then
			' Line below is needed to remove Avalonia data validation.
			' Without this line you will get duplicate validations from both Avalonia and CT
		#If AvaloniaStableChosen Then
			BindingPlugins.DataValidators.RemoveAt(0)
		#Else
			ExpressionObserver.DataValidators.RemoveAll(Function(x) TypeOf x Is DataAnnotationsValidationPlugin)
		#End If
#End If
            desktop.MainWindow = New MainWindow With {.DataContext = New MainWindowViewModel}
        End If

        MyBase.OnFrameworkInitializationCompleted()
    End Sub
End Class
