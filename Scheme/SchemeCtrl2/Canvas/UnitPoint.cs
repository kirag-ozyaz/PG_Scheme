using System;
using System.Drawing;
using System.Xml;

namespace SchemeCtrl2.Canvas
{
	[Serializable]
	public struct UnitPoint
	{
		static UnitPoint()
		{
			
			UnitPoint.Empty = default(UnitPoint);
			UnitPoint.Empty.double_0 = double.NaN;
			UnitPoint.Empty.double_1 = double.NaN;
		}

		public UnitPoint(double x, double y)
		{
			
			this.double_0 = x;
			this.double_1 = y;
		}

		public UnitPoint(PointF p)
		{
			
			this.double_0 = (double)p.X;
			this.double_1 = (double)p.Y;
		}

		public static bool operator !=(UnitPoint left, UnitPoint right)
		{
			return !(left == right);
		}

		public static bool operator ==(UnitPoint left, UnitPoint right)
		{
			if (left.X == right.X)
			{
				return left.Y == right.Y;
			}
			return left.IsEmpty && right.IsEmpty;
		}

		public static UnitPoint operator +(UnitPoint left, UnitPoint right)
		{
			left.X += right.X;
			left.Y += right.Y;
			return left;
		}

		public static UnitPoint operator -(UnitPoint left, UnitPoint right)
		{
			left.X -= right.X;
			left.Y -= right.Y;
			return left;
		}

		public bool IsEmpty
		{
			get
			{
				return double.IsNaN(this.X) && double.IsNaN(this.Y);
			}
		}

		public double X
		{
			get
			{
				return this.double_0;
			}
			set
			{
				this.double_0 = value;
			}
		}

		public double Y
		{
			get
			{
				return this.double_1;
			}
			set
			{
				this.double_1 = value;
			}
		}

		public PointF Point
		{
			get
			{
				return new PointF((float)this.double_0, (float)this.double_1);
			}
			set
			{
				PointF pointF = value;
				this.double_0 = (double)pointF.X;
				this.double_1 = (double)pointF.Y;
			}
		}

		public override string ToString()
		{
			return string.Format("{{X={0}, Y={1}}}", XmlConvert.ToString(Math.Round(this.X, 8)), XmlConvert.ToString(Math.Round(this.Y, 8)));
		}

		public override bool Equals(object obj)
		{
			return obj is UnitPoint && this == (UnitPoint)obj;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public string PosAsString()
		{
			return string.Format("[{0:f4}, {1:f4}]", this.X, this.Y);
		}

		private double double_0;

		private double double_1;

		public static UnitPoint Empty;
	}
}
