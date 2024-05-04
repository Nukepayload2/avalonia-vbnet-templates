Imports Avalonia
Imports Avalonia.Controls.ApplicationLifetimes
Imports Avalonia.Markup.Xaml

Partial Public Class App
	Inherits Application

	Public Overrides Sub Initialize()
		AvaloniaXamlLoader.Load(Me)
	End Sub

	Public Overrides Sub OnFrameworkInitializationCompleted()
		Dim desktop = TryCast(ApplicationLifetime, IClassicDesktopStyleApplicationLifetime)
		If desktop IsNot Nothing Then
			desktop.MainWindow = New MainWindow
		End If

		MyBase.OnFrameworkInitializationCompleted()
	End Sub
End Class
