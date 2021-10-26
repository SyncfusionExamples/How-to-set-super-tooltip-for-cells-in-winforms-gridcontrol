Imports Microsoft.VisualBasic
Imports System
Namespace GC_SuperTooltip
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
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.superToolTip1 = New Syncfusion.Windows.Forms.Tools.SuperToolTip(Me)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(12, 12)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(424, 293)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.Text = "gridControl1"
'			Me.gridControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.gridControl1_MouseMove)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(447, 216)
			Me.Controls.Add(Me.gridControl1)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.ShowIcon = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "GridControl-SuperToolTip"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private superToolTip1 As Syncfusion.Windows.Forms.Tools.SuperToolTip
	End Class
End Namespace

