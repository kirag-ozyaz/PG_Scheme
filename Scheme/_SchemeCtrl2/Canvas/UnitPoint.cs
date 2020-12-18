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
			UnitPoint.Empty.m_x = double.NaN;
			UnitPoint.Empty.m_y = double.NaN;
		}

		public UnitPoint(double double_0, double double_1)
		{
			this.m_x = double_0;
			this.m_y = double_1;
		}

		public UnitPoint(PointF pointF_0)
		{
			this.m_x = (double)pointF_0.X;
			this.m_y = (double)pointF_0.Y;
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
				return this.m_x;
			}
			set
			{
				this.m_x = value;
			}
		}

		public double Y
		{
			get
			{
				return this.m_y;
			}
			set
			{
				this.m_y = value;
			}
		}

		public PointF Point
		{
			get
			{
				return new PointF((float)this.m_x, (float)this.m_y);
			}
			set
			{
				PointF pointF = value;
				this.m_x = (double)pointF.X;
				this.m_y = (double)pointF.Y;
			}
		}

		public override string ToString()
		{
			return string.Format("{{X={0}, Y={1}}}", XmlConvert.ToString(Math.Round(this.X, 8)), XmlConvert.ToString(Math.Round(this.Y, 8)));
		}

		public override bool Equals(object object_0)
		{
			return object_0 is UnitPoint && this == (UnitPoint)object_0;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public string PosAsString()
		{
			return string.Format("[{0:f4}, {1:f4}]", this.X, this.Y);
		}

		private double m_x;

		private double m_y;

		public static UnitPoint Empty = default(UnitPoint);
	}
}
