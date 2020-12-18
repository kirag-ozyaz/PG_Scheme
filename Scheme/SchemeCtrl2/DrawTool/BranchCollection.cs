using System;
using System.Collections.Generic;
using System.Drawing;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Layers;

namespace SchemeCtrl2.DrawTool
{
	public class BranchCollection : DrawObjectBase
	{
		public override DrawingLayer Layer
		{
			get
			{
				if (this.list_2.Count > 0)
				{
					return this.list_2[0].Parent.Layer;
				}
				return null;
			}
			set
			{
			}
		}

		public override bool Selected
		{
			get
			{
				return base.Selected;
			}
			set
			{
				base.Selected = value;
				foreach (Branch branch in this.list_2)
				{
					branch.Selected = value;
				}
			}
		}

		public override bool Flashing
		{
			get
			{
				return base.Flashing;
			}
			set
			{
				base.Flashing = value;
				foreach (Branch branch in this.list_2)
				{
					branch.Flashing = value;
				}
			}
		}

		public IEnumerable<Branch> Collection
		{
			get
			{
				return this.list_2;
			}
		}

		public override DrawObjectBase Parent
		{
			get
			{
				if (this.list_2 != null && this.list_2.Count > 0)
				{
					return this.list_2[0].Parent;
				}
				return null;
			}
			set
			{
			}
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			foreach (Branch branch in this.list_2)
			{
				branch.Draw(canvas, unitrect, drawMode);
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			foreach (Branch branch in this.list_2)
			{
				branch.DrawPrint(canvas, g, false);
			}
		}

		public void Add(Branch branch)
		{
			this.list_2.Add(branch);
		}

		public void AddRange(IEnumerable<Branch> collection)
		{
			this.list_2.AddRange(collection);
		}

		public bool Conteins(Branch branch)
		{
			return this.list_2.Contains(branch);
		}

		public bool Remove(Branch branch)
		{
			return this.list_2.Remove(branch);
		}

		public static BranchCollection operator +(BranchCollection bc1, BranchCollection bc2)
		{
			BranchCollection branchCollection = new BranchCollection();
			branchCollection.AddRange(bc1.Collection);
			foreach (Branch branch in bc2.Collection)
			{
				if (!branchCollection.Conteins(branch))
				{
					branchCollection.Add(branch);
				}
			}
			return branchCollection;
		}

		public override RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			if (this.list_2.Count > 0)
			{
				float num = base.ThresholdWidth(canvas, base.Width);
				UnitPoint point = this.list_2[0].Source.Point;
				UnitPoint point2 = this.list_2[0].Source.Point;
				foreach (Branch branch in this.list_2)
				{
					if (branch.Source.Point.X < point.X)
					{
						point.X = branch.Source.Point.X;
					}
					if (branch.Source.Point.Y < point.Y)
					{
						point.Y = branch.Source.Point.Y;
					}
					if (branch.Destination.Point.X < point.X)
					{
						point.X = branch.Destination.Point.X;
					}
					if (branch.Destination.Point.Y < point.Y)
					{
						point.Y = branch.Destination.Point.Y;
					}
					if (branch.Source.Point.X > point2.X)
					{
						point2.X = branch.Source.Point.X;
					}
					if (branch.Source.Point.Y > point2.Y)
					{
						point2.Y = branch.Source.Point.Y;
					}
					if (branch.Destination.Point.X > point2.X)
					{
						point2.X = branch.Destination.Point.X;
					}
					if (branch.Destination.Point.Y > point2.Y)
					{
						point2.Y = branch.Destination.Point.Y;
					}
				}
				RectangleF result = new RectangleF(point.Point.X, point.Point.Y, point2.Point.X - point.Point.X, point2.Point.Y - point.Point.Y);
				if (inflate)
				{
					result.Inflate(num, num);
				}
				return result;
			}
			return Rectangle.Empty;
		}

		public override string ToString()
		{
			if (this.Parent == null)
			{
				return base.ToString();
			}
			return this.Parent.ToString();
		}

		public BranchCollection()
		{
			
			this.list_2 = new List<Branch>();
			
		}

		private List<Branch> list_2;
	}
}
