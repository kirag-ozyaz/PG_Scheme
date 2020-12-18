using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Layers;

namespace SchemeCtrl2.DrawTool
{
	public class TransformerPointTool : PointTool
	{
		public TransformerPointTool(PointTool pointTool)
		{
			
			this.list_2 = new List<UnitPoint>();
			
			this.list_2.Add(new UnitPoint(0.0, 0.15));
			this.list_2.Add(new UnitPoint(0.0, -0.15));
			base.ChangePoint += base.PointTool_ChangePoint;
			base.AddBranchEvent += new PointToolEventHandle(base.PointTool_AddBranchEvent);
			base.RemoveBranchEvent += new PointToolEventHandle(base.PointTool_RemoveBranchEvent);
			using (IEnumerator<Branch> enumerator = pointTool.Branches.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Branch branch = enumerator.Current;
					if (pointTool == branch.Source)
					{
						branch.Source = this;
					}
					else if (pointTool == branch.Destination)
					{
						branch.Destination = this;
					}
					this.src.Add(branch);
					if (((LineTool)branch.Parent).Ends.Contains(pointTool))
					{
						((List<PointTool>)((LineTool)branch.Parent).Ends).Remove(pointTool);
						((List<PointTool>)((LineTool)branch.Parent).Ends).Add(this);
					}
				}
				goto IL_150;
			}
			IL_13D:
			pointTool.CouplingRelations[0].method_5(pointTool, this);
			IL_150:
			if (pointTool.CouplingRelations.Count <= 0)
			{
				this.Text = pointTool.Text;
				base.TypePoint = pointTool.TypePoint;
				this.point = pointTool.Point;
				this.Parent = pointTool.Parent;
				pointTool.Parent = null;
				this.Layer = pointTool.Layer;
				pointTool.Layer = null;
				return;
			}
			goto IL_13D;
		}

		public TransformerPointTool(DataRow r)
		{
			
			this.list_2 = new List<UnitPoint>();
			
			this.list_2.Add(new UnitPoint(0.0, 0.15));
			this.list_2.Add(new UnitPoint(0.0, -0.15));
			this.Color = Color.White;
		}

		public new static string ObjectType
		{
			get
			{
				return "TransformerPoint";
			}
		}

		public override int GetTypeObject()
		{
			return 556;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			Pen pen;
			using (SolidBrush solidBrush = new SolidBrush(((BackgroundLayer)this.Layer.Parent.BackgroundLayer).Color))
			{
				if (this.Selected)
				{
					pen = new Pen(Color.Red, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
				}
				else
				{
					pen = new Pen(this.Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
				}
				if (this.Flashing && canvas.ConvertColorFlash)
				{
					pen = (pen = new Pen(((BackgroundLayer)canvas.BackgroundLayer).Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width)));
				}
				RectangleF rectangleF = new RectangleF(new PointF(this.list_2[0].Point.X + this.point.Point.X - 0.2f, this.list_2[0].Point.Y + this.point.Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
				RectangleF rectangleF2 = new RectangleF(new PointF(this.list_2[1].Point.X + this.point.Point.X - 0.2f, this.list_2[1].Point.Y + this.point.Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
				rectangleF = ConvertCanvas.ConvertToScreen(canvas, rectangleF);
				rectangleF2 = ConvertCanvas.ConvertToScreen(canvas, rectangleF2);
				canvas.Graphics.FillEllipse(solidBrush, rectangleF);
				canvas.Graphics.FillEllipse(solidBrush, rectangleF2);
				canvas.Graphics.DrawEllipse(pen, rectangleF);
				canvas.Graphics.DrawEllipse(pen, rectangleF2);
			}
			pen.Dispose();
		}

		public override bool PointInObject(UnitPoint uPoint)
		{
			return this.Layer != null && (Class79.XrgxasnnaZ(this.list_2[0] + this.point, 0.2f, uPoint) || Class79.XrgxasnnaZ(this.list_2[1] + this.point, 0.2f, uPoint));
		}

		private List<UnitPoint> list_2;

		public const int TYPE_TRANSFORMERPOINT = 556;
	}
}
