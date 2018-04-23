Imports Microsoft.VisualBasic
Imports System
Namespace ScrollGroups
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.btnScrollUp = New DevExpress.XtraEditors.SimpleButton()
			Me.btnScrollDown = New DevExpress.XtraEditors.SimpleButton()
			Me.btnScrollToGroup = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup1
			Me.navBarControl1.ContentButtonHint = Nothing
			Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1})
			Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.Size = New System.Drawing.Size(140, 315)
			Me.navBarControl1.TabIndex = 0
			Me.navBarControl1.Text = "navBarControl1"
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "navBarGroup1"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' btnScrollUp
			' 
			Me.btnScrollUp.Location = New System.Drawing.Point(191, 21)
			Me.btnScrollUp.Name = "btnScrollUp"
			Me.btnScrollUp.Size = New System.Drawing.Size(195, 23)
			Me.btnScrollUp.TabIndex = 1
			Me.btnScrollUp.Text = "Scroll up"
'			Me.btnScrollUp.Click += New System.EventHandler(Me.btnScrollUp_Click);
			' 
			' btnScrollDown
			' 
			Me.btnScrollDown.Location = New System.Drawing.Point(191, 50)
			Me.btnScrollDown.Name = "btnScrollDown"
			Me.btnScrollDown.Size = New System.Drawing.Size(195, 23)
			Me.btnScrollDown.TabIndex = 2
			Me.btnScrollDown.Text = "Scroll down"
'			Me.btnScrollDown.Click += New System.EventHandler(Me.btnScrollDown_Click);
			' 
			' btnScrollToGroup
			' 
			Me.btnScrollToGroup.Location = New System.Drawing.Point(191, 79)
			Me.btnScrollToGroup.Name = "btnScrollToGroup"
			Me.btnScrollToGroup.Size = New System.Drawing.Size(195, 23)
			Me.btnScrollToGroup.TabIndex = 3
			Me.btnScrollToGroup.Text = "Scroll to group #3"
'			Me.btnScrollToGroup.Click += New System.EventHandler(Me.btnScrollToGroup_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(468, 315)
			Me.Controls.Add(Me.btnScrollToGroup)
			Me.Controls.Add(Me.btnScrollDown)
			Me.Controls.Add(Me.btnScrollUp)
			Me.Controls.Add(Me.navBarControl1)
			Me.Name = "Form1"
			Me.Text = "Scroll NavBar Explorer View In Code"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private WithEvents btnScrollUp As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnScrollDown As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnScrollToGroup As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

