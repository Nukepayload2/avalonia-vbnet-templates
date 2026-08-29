Imports Avalonia
Imports Avalonia.Controls.ApplicationLifetimes
#If CommunityToolkitChosen Then
#If AvaloniaVersionIsAtLeast12 Then
	' Avalonia 12 no longer exposes the public BindingPlugins API, so the imports below are
	' only needed for Avalonia 11 and older.
#Else
Imports Avalonia.Data.Core
Imports Avalonia.Data.Core.Plugins
#End If
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
	#If AvaloniaVersionIsAtLeast12 Then
			' Avalonia 12 no longer exposes the public BindingPlugins API,
			' so the duplicate-validation removal is omitted.
	#Else
			' Line below is needed to remove Avalonia data validation.
			' Without this line you will get duplicate validations from both Avalonia and CT
		#If AvaloniaStableChosen Then
			BindingPlugins.DataValidators.RemoveAt(0)
		#Else
			ExpressionObserver.DataValidators.RemoveAll(Function(x) TypeOf x Is DataAnnotationsValidationPlugin)
		#End If
	#End If
#End If
            desktop.MainWindow = New MainWindow With {.DataContext = New MainWindowViewModel}
        End If

        MyBase.OnFrameworkInitializationCompleted()
    End Sub
End Class
