using System;
using System.Data;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class PointShinaTool : PointTool
	{
		public PointShinaTool()
		{
		}

		public PointShinaTool(DataRow dataRow_0) : base(dataRow_0)
		{
		}

		public new static string ObjectType
		{
			get
			{
				return "PointShina";
			}
		}

		public float Delta
		{
			get
			{
				return this.float_0;
			}
			set
			{
				this.float_0 = value;
				this.method_7();
			}
		}

		public override UnitPoint Point
		{
			get
			{
				return base.Point;
			}
			set
			{
				value = this.method_8(value);
				base.Point = value;
			}
		}

		private void method_7()
		{
			if (this.Parent != null && this.Parent.GetType() == typeof(ShinaTool))
			{
				ShinaTool shinaTool = (ShinaTool)this.Parent;
				double double_ = (shinaTool.P2.Y - shinaTool.P1.Y) * (double)this.Delta + shinaTool.P1.Y;
				double double_2 = (shinaTool.P2.X - shinaTool.P1.X) * (double)this.Delta + shinaTool.P1.X;
				this.Point = new UnitPoint(double_2, double_);
			}
		}

		private UnitPoint method_8(UnitPoint unitPoint_0)
		{
			if (this.Parent != null && (this.Parent.GetType() == typeof(ShinaTool) || this.Parent.GetType() == typeof(SplitterShinaTool)))
			{
				double num = Math.Min(((ShinaTool)this.Parent).P1.Y, ((ShinaTool)this.Parent).P2.Y);
				double num2 = Math.Max(((ShinaTool)this.Parent).P1.Y, ((ShinaTool)this.Parent).P2.Y);
				double num3 = Math.Min(((ShinaTool)this.Parent).P1.X, ((ShinaTool)this.Parent).P2.X);
				double num4 = Math.Max(((ShinaTool)this.Parent).P1.X, ((ShinaTool)this.Parent).P2.X);
				if (unitPoint_0.X < num3)
				{
					unitPoint_0.X = num3;
				}
				if (unitPoint_0.X > num4)
				{
					unitPoint_0.X = num4;
				}
				if (unitPoint_0.Y < num)
				{
					unitPoint_0.Y = num;
				}
				if (unitPoint_0.Y > num2)
				{
					unitPoint_0.Y = num2;
				}
				this.float_0 = (float)(Math.Sqrt(Math.Pow((double)((ShinaTool)this.Parent).P1.Point.X - unitPoint_0.X, 2.0) + Math.Pow((double)(((ShinaTool)this.Parent).P1.Point.Y - unitPoint_0.Point.Y), 2.0)) / Math.Sqrt(Math.Pow(num3 - num4, 2.0) + Math.Pow(num - num2, 2.0)));
			}
			return unitPoint_0;
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			return new PointShinaTool
			{
				Master = this,
				Color = this.Color,
				Delta = this.Delta,
				Fill = base.Fill,
				IdBase = this.IdBase,
				Point = new UnitPoint(this.point.X, this.point.Y),
				Text = this.Text,
				UseSettingColor = base.UseSettingColor,
				UseLayerWidth = base.UseLayerWidth,
				Width = base.Width
			};
		}

		private float float_0;
	}
}
