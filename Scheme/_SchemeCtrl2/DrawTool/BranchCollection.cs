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
				if (this.list_1.Count > 0)
				{
					return this.list_1[0].Parent.Layer;
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
				foreach (Branch branch in this.list_1)
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
				foreach (Branch branch in this.list_1)
				{
					branch.Flashing = value;
				}
			}
		}

		public IEnumerable<Branch> Collection
		{
			get
			{
				return this.list_1;
			}
		}

		public override DrawObjectBase Parent
		{
			get
			{
				if (this.list_1 != null && this.list_1.Count > 0)
				{
					return this.list_1[0].Parent;
				}
				return null;
			}
			set
			{
			}
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			foreach (Branch branch in this.list_1)
			{
				branch.Draw(canvas, unitrect, drawMode);
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics graphics_0, bool isColor = false)
		{
			foreach (Branch branch in this.list_1)
			{
				branch.DrawPrint(canvas, graphics_0, false);
			}
		}

		public void Add(Branch branch)
		{
			this.list_1.Add(branch);
		}

		public void AddRange(IEnumerable<Branch> collection)
		{
			this.list_1.AddRange(collection);
		}

		public bool Conteins(Branch branch)
		{
			return this.list_1.Contains(branch);
		}

		public bool Remove(Branch branch)
		{
			return this.list_1.Remove(branch);
		}

		public static BranchCollection operator +(BranchCollection branchCollection_0, BranchCollection branchCollection_1)
		{
			BranchCollection branchCollection = new BranchCollection();
			branchCollection.AddRange(branchCollection_0.Collection);
			foreach (Branch branch in branchCollection_1.Collection)
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
			if (this.list_1.Count > 0)
			{
				float num = base.ThresholdWidth(canvas, base.Width);
				UnitPoint point = this.list_1[0].Source.Point;
				UnitPoint point2 = this.list_1[0].Source.Point;
				foreach (Branch branch in this.list_1)
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

		private List<Branch> list_1 = new List<Branch>();
	}
}
