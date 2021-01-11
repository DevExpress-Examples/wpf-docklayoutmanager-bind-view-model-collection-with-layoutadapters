Imports System
Imports System.Linq
Imports DevExpress.Xpf.Docking
Imports DXSample.ViewModels

Namespace DXSample.Common

	Public Class LayoutAdapter
		Implements ILayoutAdapter

		Public Function Resolve(ByVal owner As DockLayoutManager, ByVal item As Object) As String
			Dim tempVar As Boolean = TypeOf item Is PanelViewModel
			Dim panelViewModel As PanelViewModel = If(tempVar, CType(item, PanelViewModel), Nothing)
			If tempVar Then
				Select Case panelViewModel.State
					Case State.Float
						Dim floatGroup As New FloatGroup() With {.Name = $"floatGroup{owner.FloatGroups.Count}"}
						owner.FloatGroups.Add(floatGroup)
						Return floatGroup.Name
					Case State.Regular
						Return "documentGroup"
					Case Else
						Return panelViewModel.ParentName
				End Select
			End If
			Return String.Empty
		End Function
	End Class
End Namespace
