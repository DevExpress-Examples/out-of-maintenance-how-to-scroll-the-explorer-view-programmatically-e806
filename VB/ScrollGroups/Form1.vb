Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports DevExpress.XtraNavBar.ViewInfo

Namespace ScrollGroups
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Const GroupCount As Integer = 7
			Const ItemCount As Integer = 10

			navBarControl1.Groups.Clear()
			For i As Integer = 0 To GroupCount - 1
				Dim group As NavBarGroup = navBarControl1.Groups.Add()
				group.Caption = "Group " & i.ToString()
				group.Expanded = True
				For j As Integer = 0 To ItemCount - 1
					Dim link As NavBarItemLink = group.AddItem()
					link.Item.Caption = "Item " & j.ToString()
				Next j
			Next i
		End Sub

		Private Function GetNavBarView(ByVal navBar As NavBarControl) As NavBarViewInfo
			Dim pi As PropertyInfo = GetType(NavBarControl).GetProperty("ViewInfo", BindingFlags.Instance Or BindingFlags.NonPublic)
			Return TryCast(pi.GetValue(navBar, Nothing), NavBarViewInfo)
		End Function

		Private Function GetExplorerNavBarView(ByVal navBar As NavBarControl) As ExplorerBarNavBarViewInfo
			Return CType(GetNavBarView(navBar), ExplorerBarNavBarViewInfo)
		End Function

		Private Const ScrollStep As Integer = 20

		Private Sub btnScrollUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScrollUp.Click
			Dim view As ExplorerBarNavBarViewInfo = GetExplorerNavBarView(navBarControl1)
			view.TopY -= ScrollStep
		End Sub

		Private Sub btnScrollDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScrollDown.Click
			Dim view As ExplorerBarNavBarViewInfo = GetExplorerNavBarView(navBarControl1)
			view.TopY += ScrollStep
		End Sub

		Private Sub btnScrollToGroup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnScrollToGroup.Click
			Dim view As ExplorerBarNavBarViewInfo = GetExplorerNavBarView(navBarControl1)
			Dim group3 As NavBarGroup = navBarControl1.Groups(3)
			view.TopY += view.GetGroupInfo(group3).Bounds.Top - view.UpButtonBounds.Bottom
		End Sub
	End Class
End Namespace