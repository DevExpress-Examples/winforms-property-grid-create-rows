Imports Microsoft.VisualBasic
Imports System
Namespace AddRowsRuntime
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
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.Location = New System.Drawing.Point(13, 13)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.Size = New System.Drawing.Size(319, 200)
			Me.propertyGridControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(523, 226)
			Me.Controls.Add(Me.propertyGridControl1)
			Me.Name = "Form1"
			Me.Text = "How to create PropertyGridControl rows at runtime"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
	End Class
End Namespace

