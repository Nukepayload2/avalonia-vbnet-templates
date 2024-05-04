#If CommunityToolkitChosen Then
Imports CommunityToolkit.Mvvm.ComponentModel
#ElseIf ReactiveUIToolkitChosen Then
Imports ReactiveUI
#End If

Namespace ViewModels

#If CommunityToolkitChosen Then
	Public Class ViewModelBase
		Inherits ObservableObject
#ElseIf ReactiveUIToolkitChosen Then
	Public Class ViewModelBase
		Inherits ReactiveObject
#Else
	Public Class ViewModelBase
#End If
	End Class

End Namespace
