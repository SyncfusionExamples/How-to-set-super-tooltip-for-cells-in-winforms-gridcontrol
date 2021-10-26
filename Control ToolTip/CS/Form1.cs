using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Grid;

namespace GC_SuperTooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int hoverRow = -1;
        private int hoverCol = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gridControl1.ColCount = 6;
            this.gridControl1.RowCount = 10;
           
        }

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
    }
}