Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Grid

Namespace GC_SuperTooltip
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private hoverRow As Integer = -1
		Private hoverCol As Integer = -1

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.gridControl1.ColCount = 6
			Me.gridControl1.RowCount = 10

		End Sub

		Private Sub gridControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridControl1.MouseMove
			Dim row, col As Integer
			Dim cc As GridCurrentCell = Me.gridControl1.CurrentCell
			If Me.gridControl1.PointToRowCol(New Point(e.X, e.Y), row, col) AndAlso (col <> hoverCol OrElse row <> hoverRow) Then
				hoverCol = col
				hoverRow = row

				Dim rect As Rectangle = Me.gridControl1.GetCellRenderer(row, col).GetCellBoundsCore(row, col, False)
				Dim screenPoint As Point = Me.gridControl1.PointToScreen(New Point(rect.Left, rect.Top))

				Dim tinfo As New ToolTipInfo()
				tinfo.Header.Text = String.Format(" row {0}, column {1}", hoverRow, hoverCol)
				superToolTip1.Show(tinfo, screenPoint)
			End If
		End Sub

	End Class
End Namespace