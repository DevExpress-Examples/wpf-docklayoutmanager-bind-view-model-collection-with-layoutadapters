Imports DevExpress.Mvvm
Imports System
Imports System.Collections.ObjectModel

Namespace DXSample.ViewModels
	Public Class MainViewModel
		Inherits ViewModelBase

		Public Property Panels() As ObservableCollection(Of PanelViewModel)
			Get
				Return GetValue(Of ObservableCollection(Of PanelViewModel))()
			End Get
			Set(ByVal value As ObservableCollection(Of PanelViewModel))
				SetValue(value)
			End Set
		End Property

		Public Sub New()
			Panels = New ObservableCollection(Of PanelViewModel)() From {
				New PanelViewModel() With {
					.Caption = "One",
					.Content = "A regular panel",
					.State = State.Regular
				},
				New PanelViewModel() With {
					.Caption = "Two",
					.Content = "A regular panel",
					.State = State.Regular
				},
				New PanelViewModel() With {
					.Caption = "Three",
					.Content = "A regular panel",
					.State = State.Regular
				},
				New PanelViewModel() With {
					.Caption = "Four",
					.Content = "A float panel",
					.State = State.Float
				},
				New PanelViewModel() With {
					.Caption = "Five",
					.Content = "A panel",
					.ParentName = "layoutGroup"
				}
			}
		End Sub
	End Class
	Public Enum State
		None
		Float
		Regular
	End Enum

	Public Class PanelViewModel
		Inherits ViewModelBase

		Public Property Caption() As String
			Get
				Return GetValue(Of String)()
			End Get
			Set(ByVal value As String)
				SetValue(value)
			End Set
		End Property
		Public Property Content() As String
			Get
				Return GetValue(Of String)()
			End Get
			Set(ByVal value As String)
				SetValue(value)
			End Set
		End Property
		Public Property State() As State
			Get
				Return GetValue(Of State)()
			End Get
			Set(ByVal value As State)
				SetValue(value)
			End Set
		End Property
		Public Property ParentName() As String
			Get
				Return GetValue(Of String)()
			End Get
			Set(ByVal value As String)
				SetValue(value)
			End Set
		End Property
	End Class
End Namespace