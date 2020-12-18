using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Data;


namespace Legal.Classes
{
    internal class MultiColumnComboBoxExt: ControlsLbr.MultiColumnComboBox
    {
        private int OldIndex = -1;

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
   			base.OnDrawItem(e);

			if (DesignMode)
				return;

			e.DrawBackground();

			Rectangle boundsRect = e.Bounds;
			int lastRight = 0;

			Color brushForeColor;

            DataRowView currIntemDRView = (DataRowView)Items[e.Index];
            bool type = (bool)currIntemDRView.Row["Deleted"];

            if (type == false)
            {
                brushForeColor = Color.Black;
            }
            else
                brushForeColor = Color.Gray;

            using (Pen linePen = new Pen(SystemColors.GrayText))
            {
                using (SolidBrush brush = new SolidBrush(brushForeColor))
                {
                    if (!Convert.ToBoolean(ColumnNameCollection.Count))
                        e.Graphics.DrawString(Convert.ToString(Items[e.Index]), Font, brush, boundsRect);
                    else
                    {
                        for (int colIndex = 0; colIndex < ColumnNameCollection.Count; colIndex++)
                        {
                            if (Convert.ToBoolean(ColumnWidthCollection[colIndex]))
                            {
                                string item = Convert.ToString(FilterItemOnProperty(Items[e.Index], ColumnNameCollection[colIndex]));

                                boundsRect.X = lastRight;
                                boundsRect.Width = (int)ColumnWidthCollection[colIndex];
                                lastRight = boundsRect.Right;
                                e.Graphics.DrawString(item, Font, brush, boundsRect);

                                if (colIndex < ColumnNameCollection.Count - 1)
                                {
                                    e.Graphics.DrawLine(linePen, boundsRect.Right, boundsRect.Top, boundsRect.Right, boundsRect.Bottom);
                                }
                            }
                        }
                    }
                }
            }
        }

        protected override void OnSelectedValueChanged(EventArgs e)
        {
            base.OnSelectedValueChanged(e);
            if (SelectedIndex > 0)
            {
                DataRowView currIntemDRView = (DataRowView)Items[SelectedIndex];
                bool type = (bool)currIntemDRView.Row["Deleted"];

                if (type == true)
                    if (OldIndex != -1) 
                        SelectedIndex = OldIndex;
            }

        }

        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            OldIndex = SelectedIndex;
        }



	}


    
}
