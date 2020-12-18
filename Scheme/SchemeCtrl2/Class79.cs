using System;
using System.Drawing;
using SchemeCtrl2.Canvas;

internal class Class79
{
	public static bool smethod_0(UnitPoint unitPoint_0, UnitPoint unitPoint_1, RectangleF rectangleF_0)
	{
		if (rectangleF_0.Contains(unitPoint_0.Point))
		{
			return true;
		}
		if (rectangleF_0.Contains(unitPoint_1.Point))
		{
			return true;
		}
		if (rectangleF_0.Contains(new PointF((float)unitPoint_0.X, (float)unitPoint_1.Y)))
		{
			return true;
		}
		if (rectangleF_0.Contains(new PointF((float)unitPoint_1.X, (float)unitPoint_0.Y)))
		{
			return true;
		}
		UnitPoint unitPoint_2 = new UnitPoint((double)rectangleF_0.Left, (double)rectangleF_0.Top);
		UnitPoint unitPoint_3 = new UnitPoint((double)rectangleF_0.Left, (double)rectangleF_0.Bottom);
		if (Class79.smethod_2(unitPoint_0, unitPoint_1, unitPoint_2, unitPoint_3))
		{
			return true;
		}
		unitPoint_3.Y = (double)rectangleF_0.Top;
		unitPoint_3.X = (double)rectangleF_0.Right;
		if (Class79.smethod_2(unitPoint_0, unitPoint_1, unitPoint_2, unitPoint_3))
		{
			return true;
		}
		unitPoint_2.X = (double)rectangleF_0.Right;
		unitPoint_2.Y = (double)rectangleF_0.Top;
		unitPoint_3.X = (double)rectangleF_0.Right;
		unitPoint_3.Y = (double)rectangleF_0.Bottom;
		return Class79.smethod_2(unitPoint_0, unitPoint_1, unitPoint_2, unitPoint_3);
	}

	public static bool smethod_1(UnitPoint[] unitPoint_0, RectangleF rectangleF_0)
	{
		foreach (UnitPoint unitPoint in new UnitPoint[]
		{
			new UnitPoint(rectangleF_0.Location),
			new UnitPoint((double)rectangleF_0.Location.X, (double)(rectangleF_0.Location.Y + rectangleF_0.Size.Height)),
			new UnitPoint((double)(rectangleF_0.Location.X + rectangleF_0.Size.Width), (double)(rectangleF_0.Location.Y + rectangleF_0.Size.Height)),
			new UnitPoint((double)(rectangleF_0.Location.X + rectangleF_0.Size.Width), (double)rectangleF_0.Location.Y)
		})
		{
			bool flag = false;
			int j = 0;
			int num = unitPoint_0.Length - 1;
			while (j < unitPoint_0.Length)
			{
				if (((unitPoint_0[j].Y <= unitPoint.Y && unitPoint.Y < unitPoint_0[num].Y) || (unitPoint_0[num].Y <= unitPoint.Y && unitPoint.Y < unitPoint_0[j].Y)) && unitPoint.X > (unitPoint_0[num].X - unitPoint_0[j].X) * (unitPoint.Y - unitPoint_0[j].Y) / (unitPoint_0[num].Y - unitPoint_0[j].Y) + unitPoint_0[j].X)
				{
					flag = !flag;
				}
				num = j++;
			}
			if (flag)
			{
				return true;
			}
		}
		foreach (UnitPoint unitPoint2 in unitPoint_0)
		{
			if (rectangleF_0.Contains(unitPoint2.Point))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_2(UnitPoint unitPoint_0, UnitPoint unitPoint_1, UnitPoint unitPoint_2, UnitPoint unitPoint_3)
	{
		double num = 0.0;
		double num2 = 0.0;
		return Class79.smethod_3(unitPoint_0, unitPoint_1, unitPoint_2, unitPoint_3, ref num, ref num2, false, false, false);
	}

	private static bool smethod_3(UnitPoint unitPoint_0, UnitPoint unitPoint_1, UnitPoint unitPoint_2, UnitPoint unitPoint_3, ref double double_0, ref double double_1, bool bool_0, bool bool_1, bool bool_2)
	{
		double x = unitPoint_0.X;
		double x2 = unitPoint_1.X;
		double x3 = unitPoint_2.X;
		double x4 = unitPoint_3.X;
		double y = unitPoint_0.Y;
		double y2 = unitPoint_1.Y;
		double y3 = unitPoint_2.Y;
		double y4 = unitPoint_3.Y;
		double num = (y4 - y3) * (x2 - x) - (x4 - x3) * (y2 - y);
		if (num == 0.0)
		{
			return false;
		}
		double num2 = (x4 - x3) * (y - y3) - (y4 - y3) * (x - x3);
		double num3 = (x2 - x) * (y - y3) - (y2 - y) * (x - x3);
		double num4 = num2 / num;
		double num5 = num3 / num;
		if (!bool_1 && (num4 < 0.0 || num4 > 1.0))
		{
			return false;
		}
		if (!bool_2 && (num5 < 0.0 || num5 > 1.0))
		{
			return false;
		}
		if (bool_1 || bool_2)
		{
			double_0 = x + num4 * (x2 - x);
			double_1 = y + num4 * (y2 - y);
			return true;
		}
		if (num4 >= 0.0 && num4 <= 1.0 && num5 >= 0.0 && num5 <= 1.0)
		{
			if (bool_0)
			{
				double_0 = x + num4 * (x2 - x);
				double_1 = y + num4 * (y2 - y);
			}
			return true;
		}
		return false;
	}

	public static bool XrgxasnnaZ(UnitPoint unitPoint_0, float float_0, UnitPoint unitPoint_1)
	{
		double num = unitPoint_0.X - (double)float_0;
		double num2 = unitPoint_0.X + (double)float_0;
		if (unitPoint_1.X >= num && unitPoint_1.X <= num2)
		{
			double num3 = unitPoint_0.Y - (double)float_0;
			double num4 = unitPoint_0.Y + (double)float_0;
			return unitPoint_1.Y >= num3 && unitPoint_1.Y <= num4;
		}
		return false;
	}

	public static UnitPoint smethod_4(UnitPoint unitPoint_0, UnitPoint unitPoint_1, UnitPoint unitPoint_2)
	{
		double num;
		double y;
		if (unitPoint_1.X == unitPoint_0.X)
		{
			num = unitPoint_1.X;
			y = unitPoint_2.Y;
		}
		else if (unitPoint_1.Y == unitPoint_0.Y)
		{
			num = unitPoint_2.X;
			y = unitPoint_1.Y;
		}
		else
		{
			num = ((unitPoint_1.X - unitPoint_0.X) * (unitPoint_1.Y - unitPoint_0.Y) * (unitPoint_2.Y - unitPoint_0.Y) + unitPoint_0.X * Math.Pow(unitPoint_1.Y - unitPoint_0.Y, 2.0) + unitPoint_2.X * Math.Pow(unitPoint_1.X - unitPoint_0.X, 2.0)) / (Math.Pow(unitPoint_1.Y - unitPoint_0.Y, 2.0) + Math.Pow(unitPoint_1.X - unitPoint_0.X, 2.0));
			y = (unitPoint_1.Y - unitPoint_0.Y) * (num - unitPoint_0.X) / (unitPoint_1.X - unitPoint_0.X) + unitPoint_0.Y;
		}
		return new UnitPoint(num, y);
	}

	public static float smethod_5(UnitPoint unitPoint_0, UnitPoint unitPoint_1)
	{
		double x = unitPoint_0.X - unitPoint_1.X;
		double x2 = unitPoint_0.Y - unitPoint_1.Y;
		return Convert.ToSingle(Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(x2, 2.0)));
	}

	public static bool smethod_6(UnitPoint unitPoint_0, RectangleF rectangleF_0)
	{
		return unitPoint_0.X >= (double)rectangleF_0.Left && unitPoint_0.X <= (double)rectangleF_0.Right && (unitPoint_0.Y >= (double)rectangleF_0.Top && unitPoint_0.Y <= (double)rectangleF_0.Bottom);
	}

	public static UnitPoint smethod_7(UnitPoint unitPoint_0, UnitPoint unitPoint_1)
	{
		return new UnitPoint
		{
			X = (unitPoint_0.X + unitPoint_1.X) / 2.0,
			Y = (unitPoint_0.Y + unitPoint_1.Y) / 2.0
		};
	}

	public static bool smethod_8(UnitPoint unitPoint_0, UnitPoint[] unitPoint_1)
	{
		bool flag = false;
		int i = 0;
		int num = unitPoint_1.Length - 1;
		while (i < unitPoint_1.Length)
		{
			if (((unitPoint_1[i].Y <= unitPoint_0.Y && unitPoint_0.Y < unitPoint_1[num].Y) || (unitPoint_1[num].Y <= unitPoint_0.Y && unitPoint_0.Y < unitPoint_1[i].Y)) && unitPoint_0.X > (unitPoint_1[num].X - unitPoint_1[i].X) * (unitPoint_0.Y - unitPoint_1[i].Y) / (unitPoint_1[num].Y - unitPoint_1[i].Y) + unitPoint_1[i].X)
			{
				flag = !flag;
			}
			num = i++;
		}
		return flag;
	}

	public Class79()
	{
		
		
	}
}
