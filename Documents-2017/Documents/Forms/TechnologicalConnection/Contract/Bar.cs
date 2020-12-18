namespace Documents.Forms.TechnologicalConnection.Contract
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public static class Bar
    {
        public static void PintaDegradado(Color oColor, DataGridViewCellPaintingEventArgs dataGridViewCellPaintingEventArgs_0)
        {
            PintaDegradado(oColor, dataGridViewCellPaintingEventArgs_0, -1);
        }

        public static void PintaDegradado(Color oColor, DataGridViewCellPaintingEventArgs dataGridViewCellPaintingEventArgs_0, int iPorcentaje)
        {
            Color[] colorArray = new Color[] { oColor };
            int[] numArray = new int[] { iPorcentaje };
            if (iPorcentaje == -1)
            {
                int[] numArray2 = new int[0];
                smethod_0(colorArray, dataGridViewCellPaintingEventArgs_0, numArray2);
            }
            else
            {
                smethod_0(colorArray, dataGridViewCellPaintingEventArgs_0, numArray);
            }
        }

        public static void PintaDegradado(Color oColor, DataGridViewCellPaintingEventArgs dataGridViewCellPaintingEventArgs_0, int iPorcentaje, int iObjetivo, Color oColorObjetivo)
        {
            Color[] colorArray = new Color[] { oColor, oColorObjetivo };
            int[] numArray = new int[] { iPorcentaje, iObjetivo };
            smethod_0(colorArray, dataGridViewCellPaintingEventArgs_0, numArray);
        }

        private static void smethod_0(Color[] color_0, DataGridViewCellPaintingEventArgs dataGridViewCellPaintingEventArgs_0, int[] int_0)
        {
            LinearGradientBrush brush = null;
            LinearGradientBrush brush2 = null;
            LinearGradientBrush brush3 = null;
            Color baseColor = color_0[0];
            try
            {
                Rectangle clipBounds = new Rectangle(dataGridViewCellPaintingEventArgs_0.CellBounds.X - 1, dataGridViewCellPaintingEventArgs_0.CellBounds.Y - 1, dataGridViewCellPaintingEventArgs_0.CellBounds.Width, dataGridViewCellPaintingEventArgs_0.CellBounds.Height);
                for (int i = 0; i < int_0.Length; i++)
                {
                    if (int_0[i] > 100)
                    {
                        int_0[i] = 100;
                    }
                }
                Rectangle rect = new Rectangle();
                Rectangle rectangle3 = new Rectangle();
                Rectangle rectangle4 = new Rectangle();
                Rectangle rectangle5 = new Rectangle();
                Rectangle rectangle6 = new Rectangle();
                int num = 0;
                bool flag = false;
                if (int_0.Length != 0)
                {
                    flag = true;
                    num = int_0[0];
                    if (num > 0)
                    {
                        int width = Convert.ToInt32(Math.Round((double) ((((clipBounds.Width - 7) * num) * 0.01) + 0.49)));
                        rect = new Rectangle(clipBounds.X + 4, clipBounds.Y + 4, width, (int) Math.Round((double) (((double) (clipBounds.Height - 8)) / 2.0)));
                        if (rect.Width > (clipBounds.Width - 7))
                        {
                            rect.Width = clipBounds.Width - 7;
                        }
                        rectangle3 = new Rectangle(clipBounds.X + 4, rect.Bottom - 1, rect.Width, (clipBounds.Height - 6) - rect.Height);
                        rectangle5 = new Rectangle(clipBounds.X + 4, clipBounds.Y + 4, clipBounds.Width - 7, clipBounds.Height - 7);
                        brush = new LinearGradientBrush(rect, Color.White, Color.FromArgb(180, baseColor), LinearGradientMode.Vertical);
                        brush2 = new LinearGradientBrush(rectangle3, baseColor, Color.FromArgb(70, baseColor), LinearGradientMode.Vertical);
                    }
                    if (int_0.Length > 1)
                    {
                        int num3 = int_0[1];
                        int num4 = (clipBounds.X + 4) + Convert.ToInt32(Math.Round((double) ((((clipBounds.Width - 7) * num3) * 0.01) + 0.49)));
                        int x = num4 - 20;
                        if (x < (clipBounds.X + 4))
                        {
                            x = clipBounds.X + 4;
                        }
                        rectangle4 = new Rectangle(x, clipBounds.Y + 2, num4 - x, clipBounds.Height - 4);
                        brush3 = new LinearGradientBrush(rectangle4, Color.FromArgb(0, color_0[1]), color_0[1], LinearGradientMode.Horizontal);
                    }
                    rectangle6 = new Rectangle(clipBounds.X + 3, clipBounds.Y + 3, clipBounds.Width - 6, clipBounds.Height - 6);
                }
                else
                {
                    rect = new Rectangle(clipBounds.X + 1, clipBounds.Y + 1, clipBounds.Width - 1, Convert.ToInt32(Math.Round((double) (((double) clipBounds.Height) / 2.0))));
                    rectangle3 = new Rectangle(clipBounds.X + 1, rect.Bottom - 1, clipBounds.Width - 1, clipBounds.Height - rect.Height);
                    rectangle5 = new Rectangle(clipBounds.X + 1, clipBounds.Y + 1, clipBounds.Width - 1, clipBounds.Height);
                    brush = new LinearGradientBrush(rect, Color.White, Color.FromArgb(180, baseColor), LinearGradientMode.Vertical);
                    brush2 = new LinearGradientBrush(rectangle3, baseColor, Color.FromArgb(70, baseColor), LinearGradientMode.Vertical);
                }
                dataGridViewCellPaintingEventArgs_0.PaintBackground(dataGridViewCellPaintingEventArgs_0.CellBounds, true);
                if (flag)
                {
                    dataGridViewCellPaintingEventArgs_0.Graphics.DrawRectangle(Pens.DimGray, rectangle6);
                }
                if (brush != null)
                {
                    dataGridViewCellPaintingEventArgs_0.Graphics.FillRectangle(Brushes.White, rectangle5);
                    dataGridViewCellPaintingEventArgs_0.Graphics.FillRectangle(brush, rect);
                    dataGridViewCellPaintingEventArgs_0.Graphics.FillRectangle(brush2, rectangle3);
                }
                if (brush3 != null)
                {
                    dataGridViewCellPaintingEventArgs_0.Graphics.FillRectangle(brush3, rectangle4);
                }
                dataGridViewCellPaintingEventArgs_0.PaintContent(clipBounds);
                dataGridViewCellPaintingEventArgs_0.Paint(clipBounds, DataGridViewPaintParts.Border);
                dataGridViewCellPaintingEventArgs_0.Handled = true;
            }
            catch (Exception)
            {
            }
            finally
            {
                if (brush != null)
                {
                    brush.Dispose();
                    brush = null;
                }
                if (brush2 != null)
                {
                    brush2.Dispose();
                    brush2 = null;
                }
                if (brush3 != null)
                {
                    brush3.Dispose();
                    brush3 = null;
                }
            }
        }
    }
}

