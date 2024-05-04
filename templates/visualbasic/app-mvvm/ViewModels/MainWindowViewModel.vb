Namespace ViewModels

#If CommunityToolkitChosen Then
	Partial Public Class MainWindowViewModel
		Inherits ViewModelBase
#Else
	Public Class MainWindowViewModel
		Inherits ViewModelBase
#End If
		Public ReadOnly Property Greeting As String
			Get
				Return "Welcome to Avalonia!"
			End Get
		End Property
	End Class

End Namespace
