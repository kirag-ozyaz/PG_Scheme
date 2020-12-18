using System;
using System.Drawing;

namespace SchemeCtrl2.Canvas
{
	public class ConvertCanvas
	{
		private static float smethod_0(float float_0, eMetric eMetric_0)
		{
			switch (eMetric_0)
			{
			case eMetric.const_0:
				return float_0 * 2.54f * 100f;
			case eMetric.const_1:
				return float_0 * 2.54f;
			case eMetric.const_2:
				return float_0 * 2.54f / 100f;
			case eMetric.const_3:
				return float_0 * 2.54f / 100000f;
			case eMetric.inch:
				return float_0;
			default:
				return float_0;
			}
		}

		private static float smethod_1(float float_0, eMetric eMetric_0)
		{
			switch (eMetric_0)
			{
			case eMetric.const_0:
				return float_0 / 2.54f * 100f;
			case eMetric.const_1:
				return float_0 / 2.54f;
			case eMetric.const_2:
				return float_0 / 2.54f / 100f;
			case eMetric.const_3:
				return float_0 / 2.54f / 100000f;
			case eMetric.inch:
				return float_0;
			default:
				return float_0;
			}
		}

		public static PointF ConvertToScreen(CanvasControl canvas, UnitPoint point)
		{
			PointF point2 = point.Point;
			point2.Y = canvas.ScreenHeight() - point2.Y;
			point2.Y *= ConvertCanvas.smethod_1(96f * canvas.Zoom, canvas.CurrentMetric);
			point2.X *= ConvertCanvas.smethod_1(96f * canvas.Zoom, canvas.CurrentMetric);
			point2.X += canvas.DeltaPoint.X;
			point2.Y += canvas.DeltaPoint.Y;
			return point2;
		}

		public static PointF[] ConvertToScreen(CanvasControl canvas, UnitPoint[] points)
		{
			PointF[] array = new PointF[points.Length];
			int num = 0;
			foreach (UnitPoint unitPoint in points)
			{
				PointF point = unitPoint.Point;
				point.Y = canvas.ScreenHeight() - point.Y;
				point.Y *= ConvertCanvas.smethod_1(96f * canvas.Zoom, canvas.CurrentMetric);
				point.X *= ConvertCanvas.smethod_1(96f * canvas.Zoom, canvas.CurrentMetric);
				point.X += canvas.DeltaPoint.X;
				point.Y += canvas.DeltaPoint.Y;
				array[num] = point;
				num++;
			}
			return array;
		}

		public static float ConvertToScreen(CanvasControl canvas, double unitValue)
		{
			return (float)(unitValue * (double)ConvertCanvas.smethod_1(96f * canvas.Zoom, canvas.CurrentMetric));
		}

		public static RectangleF ConvertToScreen(CanvasControl canvas, RectangleF unitrect)
		{
			return new RectangleF
			{
				Location = ConvertCanvas.ConvertToScreen(canvas, new UnitPoint(unitrect.Location)),
				Width = (float)Math.Round((double)ConvertCanvas.ConvertToScreen(canvas, (double)unitrect.Width)),
				Height = (float)Math.Round((double)ConvertCanvas.ConvertToScreen(canvas, (double)unitrect.Height))
			};
		}

		public static RectangleF ConvertToScreenNormalized(CanvasControl canvas, RectangleF unitrect)
		{
			RectangleF result = ConvertCanvas.ConvertToScreen(canvas, unitrect);
			result.Y -= result.Height;
			return result;
		}

		public static double ConvertToUnit(CanvasControl canvas, float screenvalue)
		{
			return (double)ConvertCanvas.smethod_0(screenvalue / (96f * canvas.Zoom), canvas.CurrentMetric);
		}

		public static UnitPoint ConvertToUnit(CanvasControl canvas, PointF screenpoint)
		{
			float num = ConvertCanvas.smethod_0((screenpoint.X - canvas.DeltaPoint.X) / (96f * canvas.Zoom), canvas.CurrentMetric);
			float num2 = canvas.ScreenHeight() - ConvertCanvas.smethod_0((screenpoint.Y - canvas.DeltaPoint.Y) / (96f * canvas.Zoom), canvas.CurrentMetric);
			return new UnitPoint((double)num, (double)num2);
		}

		public static RectangleF ConvertToUnitNormalized(CanvasControl canvas, Rectangle screenrect)
		{
			UnitPoint unitPoint = ConvertCanvas.ConvertToUnit(canvas, screenrect.Location);
			SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, (float)screenrect.Width), (float)ConvertCanvas.ConvertToUnit(canvas, (float)screenrect.Height));
			RectangleF result = new RectangleF(unitPoint.Point, size);
			result.Y -= result.Height;
			return result;
		}

		public static RectangleF ConvertToUnitNormalized(CanvasControl canvas, RectangleF screenrect)
		{
			UnitPoint unitPoint = ConvertCanvas.ConvertToUnit(canvas, screenrect.Location);
			SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, screenrect.Width), (float)ConvertCanvas.ConvertToUnit(canvas, screenrect.Height));
			RectangleF result = new RectangleF(unitPoint.Point, size);
			result.Y -= result.Height;
			return result;
		}
	}
}
