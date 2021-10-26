# How to set super tooltip for cells in winforms gridcontrol?
This example describes how to set super tooltip for cells in winforms gridcontrol.

## Set SuperToolTip

To set the SuperToolTip for each cell in a GridControl, you can use MouseMove event. By using this event, you can set the tooltip to get the corresponding row and column index by setting the PointToRowCol method.
The following code example explains how to set SuperToolTip for each cell in a GridControl by using MouseMove event.
``` C#
private void gridControl1_MouseMove(object sender, MouseEventArgs e)
{
    int row, col;
    GridCurrentCell cc = this.gridControl1.CurrentCell;
    if (this.gridControl1.PointToRowCol(new Point(e.X, e.Y), out row, out col) && (col != hoverCol || row != hoverRow)) 
    {
        hoverCol = col;
        hoverRow = row;

        Rectangle rect = this.gridControl1.GetCellRenderer(row, col).GetCellBoundsCore(row, col, false);
        Point screenPoint = this.gridControl1.PointToScreen(new Point(rect.Left, rect.Top));

        ToolTipInfo tinfo = new ToolTipInfo();
        tinfo.Header.Text = string.Format(" row {0}, column {1}", hoverRow, hoverCol);
        superToolTip1.Show(tinfo, screenPoint);
    }
}
```

``` VB
Private Sub gridControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
Dim superToolTip1 As New SuperToolTip()  
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
```

