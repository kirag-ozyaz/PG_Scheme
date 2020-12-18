using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool.FormsObj;

namespace SchemeCtrl2.DrawTool
{
	public class Branch : DrawObjectBase
	{
		public CouplingRelation CouplingRelation
		{
			get
			{
				return this.couplingRelation_0;
			}
			set
			{
				if (this.couplingRelation_0 != null && this.couplingRelation_0.method_3().Contains(this))
				{
					if (this.couplingRelation_0.method_3().Count == 1 && ((LineTool)this.Parent).CouplingRelations.Contains(this.couplingRelation_0))
					{
						((LineTool)this.Parent).CouplingRelations.method_5(this.couplingRelation_0);
					}
					this.couplingRelation_0.method_3().Remove(this);
				}
				this.couplingRelation_0 = value;
				if (this.couplingRelation_0 != null)
				{
					this.couplingRelation_0.method_3().Add(this);
				}
			}
		}

		internal bool method_7()
		{
			return this.bool_7;
		}

		internal void method_8(bool value)
		{
			this.bool_7 = value;
		}

		public PointTool Source
		{
			get
			{
				return this.pointTool_0;
			}
			set
			{
				if (this.pointTool_0 != null)
				{
					this.pointTool_0.ChangePoint -= this.method_10;
				}
				this.pointTool_0 = value;
				if (this.pointTool_0 != null)
				{
					this.pointTool_0.ChangePoint += this.method_10;
				}
			}
		}

		public PointTool Destination
		{
			get
			{
				return this.pointTool_1;
			}
			set
			{
				if (this.pointTool_1 != null)
				{
					this.pointTool_1.ChangePoint -= this.method_11;
				}
				this.pointTool_1 = value;
				if (this.pointTool_1 != null)
				{
					this.pointTool_1.ChangePoint += this.method_11;
				}
			}
		}

		public BranchType Type
		{
			get
			{
				return this.branchType_0;
			}
			set
			{
				this.branchType_0 = value;
			}
		}

		public override bool Selected
		{
			get
			{
				if (this.Parent != null && this.Parent.Selected)
				{
					return this.Parent.Selected;
				}
				return base.Selected;
			}
			set
			{
				base.Selected = value;
			}
		}

		public override DrawObjectBase Parent
		{
			get
			{
				if (this.lineTool_0 != null)
				{
					return this.lineTool_0;
				}
				return base.Parent;
			}
			set
			{
				if (value == null)
				{
					if (this.lineTool_0 != null)
					{
						this.lineTool_0.RemoveChildObject(this);
						this.lineTool_0 = null;
						return;
					}
				}
				else
				{
					if (value is LineTool)
					{
						this.lineTool_0 = (LineTool)value;
						return;
					}
					base.Parent = value;
				}
			}
		}

		public override Color SelectedColor
		{
			get
			{
				if (this.Parent != null && this.useParentColor)
				{
					return this.Parent.SelectedColor;
				}
				return base.SelectedColor;
			}
			set
			{
				base.SelectedColor = value;
			}
		}

		public override Color Color
		{
			get
			{
				if (this.Parent != null && this.useParentColor)
				{
					return this.Parent.Color;
				}
				return base.Color;
			}
		}

		public Color ColorOff
		{
			get
			{
				if (this.Parent != null && this.useParentColor)
				{
					if (this.Parent is SplitterShinaTool)
					{
						return ((SplitterShinaTool)this.Parent).ColorOff;
					}
					if (this.Parent.GetType() == typeof(LineTool) || this.Parent.GetType().BaseType == typeof(LineTool))
					{
						return ((LineTool)this.Parent).ColorOff;
					}
				}
				return base.Color;
			}
		}

		public ObjectOnLine SelectedSwitch
		{
			get
			{
				return this.objectOnLine_0;
			}
			set
			{
				this.objectOnLine_0 = value;
			}
		}

		public bool On
		{
			get
			{
				bool result = true;
				foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
				{
					if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine))
					{
						ObjectOnLine objectOnLine = (ObjectOnLine)drawObjectBase;
						if (objectOnLine.GetType() != typeof(GroundingTool) && !objectOnLine.On)
						{
							result = false;
							break;
						}
					}
				}
				return result;
			}
		}

		public override bool Deleted
		{
			get
			{
				if (this.lineTool_0 != null)
				{
					return this.lineTool_0.Deleted;
				}
				return base.Deleted;
			}
			set
			{
				base.Deleted = value;
			}
		}

		public Branch()
		{
			Class90.TDroV38zslI2T();
			this.branchType_0 = BranchType.CabelLine;
			this.enum3_0 = (Branch.Enum3)2;
			this.useParentColor = true;
			base..ctor();
		}

		public Branch(PointTool src, PointTool dest)
		{
			Class90.TDroV38zslI2T();
			this.branchType_0 = BranchType.CabelLine;
			this.enum3_0 = (Branch.Enum3)2;
			this.useParentColor = true;
			base..ctor();
			this.Source = src;
			this.Destination = dest;
			this.Source.AddBranch(this);
			this.Destination.AddBranch(this);
		}

		public Branch(LineTool line, PointTool src, PointTool dest)
		{
			Class90.TDroV38zslI2T();
			this.branchType_0 = BranchType.CabelLine;
			this.enum3_0 = (Branch.Enum3)2;
			this.useParentColor = true;
			base..ctor();
			this.lineTool_0 = line;
			this.Source = src;
			this.Destination = dest;
			this.Source.AddBranch(this);
			this.Destination.AddBranch(this);
			this.lineTool_0.Branches.Add(this);
		}

		public Branch(LineTool line, PointTool src, PointTool dest, BranchType type)
		{
			Class90.TDroV38zslI2T();
			this.branchType_0 = BranchType.CabelLine;
			this.enum3_0 = (Branch.Enum3)2;
			this.useParentColor = true;
			base..ctor();
			this.lineTool_0 = line;
			this.Source = src;
			this.Destination = dest;
			this.branchType_0 = type;
			this.Source.AddBranch(this);
			this.Destination.AddBranch(this);
			this.lineTool_0.Branches.Add(this);
		}

		public Branch(LineTool lineTool, PointTool src, PointTool dest, BranchType type, CouplingRelation couplingRelation)
		{
			Class90.TDroV38zslI2T();
			this.branchType_0 = BranchType.CabelLine;
			this.enum3_0 = (Branch.Enum3)2;
			this.useParentColor = true;
			base..ctor();
			this.lineTool_0 = lineTool;
			this.Source = src;
			this.Destination = dest;
			this.branchType_0 = type;
			this.CouplingRelation = couplingRelation;
			this.Source.AddBranch(this);
			this.Destination.AddBranch(this);
		}

		public void AlignBy(Alignment alignment)
		{
			PointTool pointTool = null;
			switch (alignment)
			{
			case Alignment.R:
				pointTool = ((this.pointTool_0.Point.X > this.pointTool_1.Point.X) ? this.pointTool_0 : this.pointTool_1);
				break;
			case Alignment.L:
				pointTool = ((this.pointTool_0.Point.X < this.pointTool_1.Point.X) ? this.pointTool_0 : this.pointTool_1);
				break;
			case Alignment.T:
				pointTool = ((this.pointTool_0.Point.Y > this.pointTool_1.Point.Y) ? this.pointTool_0 : this.pointTool_1);
				break;
			case Alignment.B:
				pointTool = ((this.pointTool_0.Point.Y < this.pointTool_1.Point.Y) ? this.pointTool_0 : this.pointTool_1);
				break;
			}
			if (pointTool == null)
			{
				return;
			}
			PointTool pointTool2 = (pointTool == this.pointTool_0) ? this.pointTool_1 : this.pointTool_0;
			switch (alignment)
			{
			case Alignment.R:
			case Alignment.L:
				pointTool2.Point = new UnitPoint(pointTool2.Point.X, pointTool.Point.Y);
				return;
			case Alignment.T:
			case Alignment.B:
				pointTool2.Point = new UnitPoint(pointTool.Point.X, pointTool2.Point.Y);
				return;
			default:
				return;
			}
		}

		public Color GetCurrentColor()
		{
			if (this.Selected)
			{
				return this.SelectedColor;
			}
			if (this.CouplingRelation.On && this.CouplingRelation.amperagePoint != null && ((LineTool)this.Parent).Amperages.ContainsKey(this.CouplingRelation.amperagePoint))
			{
				return this.Color;
			}
			return this.ColorOff;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			int num = 0;
			Pen pen = null;
			ObjectOnLine objectOnLine = null;
			ObjectOnLine objectOnLine2 = null;
			if (this.Highlighted)
			{
				base.Width += 0.2f;
			}
			using (Pen pen2 = new Pen(this.Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width)))
			{
				if (canvas.method_90() > 1)
				{
					if (pen2.Width == 0f)
					{
						pen2.Width = (float)canvas.method_90();
					}
					else
					{
						pen2.Width *= (float)canvas.method_90();
					}
				}
				if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
				{
					if (this.Selected && (drawMode & eDrawMode.Print) != eDrawMode.Print)
					{
						pen2.Color = this.SelectedColor;
					}
					else if ((this.Parent.Bookmark != null || base.Bookmark != null) && (drawMode & eDrawMode.Print) != eDrawMode.Print)
					{
						pen2.Color = canvas.Settings.MarkedObjColor;
					}
					else if (this.couplingRelation_0 != null)
					{
						if (this.couplingRelation_0.On && this.couplingRelation_0.amperagePoint != null && ((LineTool)this.Parent).Amperages.ContainsKey(this.couplingRelation_0.amperagePoint))
						{
							pen2.Color = this.Color;
							if ((from o in this.ChildObjects
							where o.GetType() == typeof(TransformerTool)
							select o).Count<DrawObjectBase>() == 1 && this.Source.Parent != null && this.Source.Parent.GetType() == typeof(LineCellTool) && this.Destination.Parent != null && this.Destination.Parent.GetType() == typeof(LineCellTool) && ((LineCellTool)this.Source.Parent).Type != ((LineCellTool)this.Destination.Parent).Type)
							{
								objectOnLine = (ObjectOnLine)this.ChildObjects.First((DrawObjectBase o) => o.GetType() == typeof(TransformerTool));
								pen2.Color = ((LineCellTool)this.Source.Parent).Color;
								pen = new Pen(((LineCellTool)this.Destination.Parent).Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
								num = 2;
							}
						}
						else if (!this.couplingRelation_0.On && this.couplingRelation_0.amperagePoint != null && ((LineTool)this.Parent).Amperages.ContainsKey(this.couplingRelation_0.amperagePoint))
						{
							num = this.method_9();
							if (num != 0)
							{
								if (this.On)
								{
									pen2.Color = this.Color;
									goto IL_624;
								}
								if (num == 0)
								{
									pen2.Color = this.ColorOff;
									goto IL_624;
								}
								if (num == 3)
								{
									if (this.ChildObjects.Count<DrawObjectBase>() > 1)
									{
										pen = new Pen(this.Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
										pen2.Color = this.ColorOff;
										double num2 = 2.0;
										foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
										{
											if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine) && drawObjectBase.GetType() != typeof(GroundingTool))
											{
												ObjectOnLine objectOnLine3 = (ObjectOnLine)drawObjectBase;
												if (!objectOnLine3.On && objectOnLine3.Delta < num2)
												{
													objectOnLine = objectOnLine3;
													num2 = objectOnLine.Delta;
												}
											}
										}
										double num3 = -1.0;
										using (IEnumerator<DrawObjectBase> enumerator = this.ChildObjects.GetEnumerator())
										{
											while (enumerator.MoveNext())
											{
												DrawObjectBase drawObjectBase2 = enumerator.Current;
												if (drawObjectBase2.GetType().BaseType == typeof(ObjectOnLine) && drawObjectBase2.GetType() != typeof(GroundingTool))
												{
													ObjectOnLine objectOnLine4 = (ObjectOnLine)drawObjectBase2;
													if (!objectOnLine4.On && objectOnLine4.Delta > num3)
													{
														objectOnLine2 = objectOnLine4;
														num3 = objectOnLine.Delta;
													}
												}
											}
											goto IL_624;
										}
									}
									pen2.Color = this.Color;
									goto IL_624;
								}
								pen = new Pen(this.Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
								pen2.Color = this.ColorOff;
								if (num == 1)
								{
									double num4 = 2.0;
									using (IEnumerator<DrawObjectBase> enumerator = this.ChildObjects.GetEnumerator())
									{
										while (enumerator.MoveNext())
										{
											DrawObjectBase drawObjectBase3 = enumerator.Current;
											if (drawObjectBase3.GetType().BaseType == typeof(ObjectOnLine) && drawObjectBase3.GetType() != typeof(GroundingTool))
											{
												ObjectOnLine objectOnLine5 = (ObjectOnLine)drawObjectBase3;
												if (!objectOnLine5.On && objectOnLine5.Delta < num4)
												{
													objectOnLine = objectOnLine5;
													num4 = objectOnLine.Delta;
												}
											}
										}
										goto IL_624;
									}
								}
								if (num != 2)
								{
									goto IL_624;
								}
								double num5 = -1.0;
								using (IEnumerator<DrawObjectBase> enumerator = this.ChildObjects.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										DrawObjectBase drawObjectBase4 = enumerator.Current;
										if (drawObjectBase4.GetType().BaseType == typeof(ObjectOnLine) && drawObjectBase4.GetType() != typeof(GroundingTool))
										{
											ObjectOnLine objectOnLine6 = (ObjectOnLine)drawObjectBase4;
											if (!objectOnLine6.On && objectOnLine6.Delta > num5)
											{
												objectOnLine = objectOnLine6;
												num5 = objectOnLine.Delta;
											}
										}
									}
									goto IL_624;
								}
							}
							pen2.Color = this.ColorOff;
						}
						else
						{
							pen2.Color = this.ColorOff;
						}
					}
					else
					{
						if (this.lineTool_0 != null)
						{
							throw new Exception("Ветка принадлежит линии но без связи. ID=" + this.lineTool_0.IdBase.ToString());
						}
						if (this.Parent == null)
						{
							throw new Exception("Ветка без родительского объекта");
						}
						pen2.Color = this.ColorOff;
					}
					IL_624:
					if (this.Flashing && canvas.ConvertColorFlash && (drawMode & eDrawMode.Print) != eDrawMode.Print)
					{
						if (pen != null)
						{
							pen.Color = canvas.Settings.BackFlashingColor;
						}
						pen2.Color = canvas.Settings.BackFlashingColor;
					}
				}
				else if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
				{
					pen2.Color = Color.Black;
				}
				else
				{
					if (this.Selected)
					{
						pen2.Color = Color.Gray;
					}
					else if (this.Parent.Bookmark != null || base.Bookmark != null)
					{
						pen2.Color = Color.LightGray;
					}
					if (this.Flashing && canvas.ConvertColorFlash)
					{
						pen2.Color = Color.White;
					}
				}
				BranchType branchType = this.branchType_0;
				if (branchType != BranchType.AirLine)
				{
					if (branchType == BranchType.AirLineProtected)
					{
						pen2.DashStyle = DashStyle.Custom;
						pen2.DashPattern = new float[]
						{
							8f,
							3f,
							1f,
							3f
						};
						if (pen != null)
						{
							pen.DashStyle = DashStyle.Custom;
							pen.DashPattern = new float[]
							{
								8f,
								3f,
								1f,
								3f
							};
						}
					}
				}
				else if (this.branchType_0 == BranchType.AirLine)
				{
					pen2.DashStyle = DashStyle.Custom;
					pen2.DashPattern = new float[]
					{
						5f,
						3f
					};
					if (pen != null)
					{
						pen.DashStyle = DashStyle.Custom;
						pen.DashPattern = new float[]
						{
							5f,
							3f
						};
					}
				}
				pen2.EndCap = LineCap.Round;
				pen2.StartCap = LineCap.Round;
				PointF pt = ConvertCanvas.ConvertToScreen(canvas, this.Source.Point);
				PointF pt2 = ConvertCanvas.ConvertToScreen(canvas, this.Destination.Point);
				if (pen != null)
				{
					pen.EndCap = LineCap.Round;
					pen.StartCap = LineCap.Round;
					if (objectOnLine != null)
					{
						PointF pointF = ConvertCanvas.ConvertToScreen(canvas, objectOnLine.CenterPoint);
						if (num == 1)
						{
							canvas.Graphics.DrawLine(pen, pt, pointF);
							canvas.Graphics.DrawLine(pen2, pointF, pt2);
						}
						else if (num == 2)
						{
							canvas.Graphics.DrawLine(pen2, pt, pointF);
							canvas.Graphics.DrawLine(pen, pointF, pt2);
						}
						else
						{
							PointF pointF2 = ConvertCanvas.ConvertToScreen(canvas, objectOnLine2.CenterPoint);
							canvas.Graphics.DrawLine(pen, pt, pointF);
							canvas.Graphics.DrawLine(pen2, pointF, pointF2);
							canvas.Graphics.DrawLine(pen, pointF2, pt2);
						}
					}
					pen.Dispose();
				}
				else
				{
					canvas.Graphics.DrawLine(pen2, pt, pt2);
				}
				if (this.pointTool_0.Parent == null || this.pointTool_0.Parent == this.Parent)
				{
					this.pointTool_0.Draw(canvas, unitrect, drawMode);
				}
				if (this.pointTool_1.Parent == null || this.pointTool_1.Parent == this.Parent)
				{
					this.pointTool_1.Draw(canvas, unitrect, drawMode);
				}
			}
		}

		private int method_9()
		{
			PointTool source = this.Source;
			if (this.CouplingRelation.amperagePoint == null)
			{
				return 0;
			}
			bool flag = ((LineTool)this.Parent).Amperages.ContainsKey(this.Source) || Branch.smethod_0(this.Source, this);
			bool flag2 = ((LineTool)this.Parent).Amperages.ContainsKey(this.Destination) || Branch.smethod_0(this.Destination, this);
			if (flag && flag2)
			{
				return 3;
			}
			if (flag)
			{
				return 1;
			}
			if (flag2)
			{
				return 2;
			}
			return 0;
		}

		private static bool smethod_0(PointTool pointTool_2, Branch branch_0)
		{
			CouplingRelation couplingRelation = branch_0.CouplingRelation;
			while (!((LineTool)branch_0.Parent).Amperages.ContainsKey(pointTool_2))
			{
				if (pointTool_2.Branches.Count<Branch>() <= 1)
				{
					return false;
				}
				if (pointTool_2.CouplingRelations.Count != 0)
				{
					foreach (CouplingRelation couplingRelation2 in pointTool_2.CouplingRelations)
					{
						if (couplingRelation2 != couplingRelation && couplingRelation2.On && couplingRelation2.amperagePoint != null)
						{
							return true;
						}
					}
					return false;
				}
				using (IEnumerator<Branch> enumerator2 = pointTool_2.Branches.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Branch branch = enumerator2.Current;
						if (branch_0 != branch)
						{
							branch_0 = branch;
							break;
						}
					}
					goto IL_97;
				}
				goto IL_7A;
				IL_88:
				PointTool pointTool;
				pointTool_2 = pointTool;
				if (!branch_0.On)
				{
					return false;
				}
				continue;
				IL_7A:
				pointTool = branch_0.Source;
				goto IL_88;
				IL_97:
				if (pointTool_2 != branch_0.Source)
				{
					goto IL_7A;
				}
				pointTool = branch_0.Destination;
				goto IL_88;
			}
			return true;
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			using (Pen pen = new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width)))
			{
				if (this.branchType_0 == BranchType.AirLine)
				{
					pen.DashStyle = DashStyle.Custom;
					pen.DashPattern = new float[]
					{
						5f,
						3f
					};
				}
				pen.EndCap = LineCap.Round;
				pen.StartCap = LineCap.Round;
				PointF pt = ConvertCanvas.ConvertToScreen(canvas, this.Source.Point);
				PointF pt2 = ConvertCanvas.ConvertToScreen(canvas, this.Destination.Point);
				g.DrawLine(pen, pt, pt2);
				if (this.pointTool_0.Parent == null || this.pointTool_0.Parent == this.Parent)
				{
					this.pointTool_0.DrawPrint(canvas, g, false);
				}
				if (this.pointTool_1.Parent == null || this.pointTool_1.Parent == this.Parent)
				{
					this.pointTool_1.DrawPrint(canvas, g, false);
				}
			}
		}

		public override bool PointInObject(UnitPoint uPoint)
		{
			if (this.Parent.Layer == null)
			{
				return false;
			}
			CanvasControl parent = this.Parent.Layer.Parent;
			float num = base.ThresholdWidth(parent, base.Width);
			this.objectOnLine_0 = null;
			new UnitPoint(ConvertCanvas.ConvertToScreen(parent, uPoint));
			if (this.pointTool_1.Point.Y != this.pointTool_0.Point.Y)
			{
				float num2 = Convert.ToSingle((uPoint.Y - this.pointTool_0.Point.Y) * (this.pointTool_1.Point.X - this.pointTool_0.Point.X) / (this.pointTool_1.Point.Y - this.pointTool_0.Point.Y) + this.pointTool_0.Point.X);
				if (Math.Abs(uPoint.X - (double)num2) <= (double)num && Math.Min(this.pointTool_1.Point.Y, this.pointTool_0.Point.Y) - (double)num <= uPoint.Y && Math.Max(this.pointTool_1.Point.Y, this.pointTool_0.Point.Y) + (double)num >= uPoint.Y)
				{
					return true;
				}
			}
			if (this.pointTool_1.Point.X != this.pointTool_0.Point.X)
			{
				float num3 = Convert.ToSingle((uPoint.X - this.pointTool_0.Point.X) * (this.pointTool_1.Point.Y - this.pointTool_0.Point.Y) / (this.pointTool_1.Point.X - this.pointTool_0.Point.X) + this.pointTool_0.Point.Y);
				if (Math.Abs(uPoint.Y - (double)num3) <= (double)num && Math.Min(this.pointTool_1.Point.X, this.pointTool_0.Point.X) - (double)num <= uPoint.X && Math.Max(this.pointTool_1.Point.X, this.pointTool_0.Point.X) + (double)num >= uPoint.X)
				{
					return true;
				}
			}
			return this.pointTool_1.Point.Y == this.pointTool_0.Point.Y && this.pointTool_1.Point.X == this.pointTool_0.Point.X && Class79.XrgxasnnaZ(this.pointTool_0.Point, base.ThresholdWidth(parent, base.Width), uPoint);
		}

		public bool CheckVoltageInPoint(UnitPoint unitPoint)
		{
			if (!this.PointInObject(unitPoint))
			{
				return false;
			}
			if (this.couplingRelation_0.amperagePoint == null)
			{
				return false;
			}
			int num = this.method_9();
			if (num == 0)
			{
				return false;
			}
			double num2 = Math.Sqrt(Math.Pow(this.Source.Point.X - unitPoint.X, 2.0) + Math.Pow(this.Source.Point.Y - unitPoint.Y, 2.0)) / Math.Sqrt(Math.Pow(this.Source.Point.X - this.Destination.Point.X, 2.0) + Math.Pow(this.Source.Point.Y - this.Destination.Point.Y, 2.0));
			if (num == 1)
			{
				foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
				{
					if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine) && drawObjectBase.GetType() != typeof(GroundingTool) && ((ObjectOnLine)drawObjectBase).Delta < num2 && !((ObjectOnLine)drawObjectBase).On)
					{
						return false;
					}
				}
				return true;
			}
			if (num == 2)
			{
				foreach (DrawObjectBase drawObjectBase2 in this.ChildObjects)
				{
					if (drawObjectBase2.GetType().BaseType == typeof(ObjectOnLine) && drawObjectBase2.GetType() != typeof(GroundingTool) && ((ObjectOnLine)drawObjectBase2).Delta > num2 && !((ObjectOnLine)drawObjectBase2).On)
					{
						return false;
					}
				}
				return true;
			}
			if (num == 3)
			{
				bool flag = false;
				bool flag2 = false;
				foreach (DrawObjectBase drawObjectBase3 in this.ChildObjects)
				{
					if (drawObjectBase3.GetType().BaseType == typeof(ObjectOnLine) && drawObjectBase3.GetType() != typeof(GroundingTool))
					{
						if (((ObjectOnLine)drawObjectBase3).Delta < num2 && !((ObjectOnLine)drawObjectBase3).On)
						{
							flag = true;
						}
						if (((ObjectOnLine)drawObjectBase3).Delta > num2 && !((ObjectOnLine)drawObjectBase3).On)
						{
							flag2 = true;
						}
					}
				}
				return !flag || !flag2;
			}
			return false;
		}

		public override int HitTest(CanvasControl canvas, PointF point)
		{
			UnitPoint point2 = ConvertCanvas.ConvertToUnit(canvas, point);
			if (this.pointTool_0.PointInObject(point2))
			{
				return 1;
			}
			if (this.pointTool_1.PointInObject(point2))
			{
				return 2;
			}
			if (this.PointInObject(point2))
			{
				return 0;
			}
			return -1;
		}

		public override bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			return Class79.smethod_0(this.pointTool_0.Point, this.pointTool_1.Point, rect);
		}

		public override bool ShowPropertyForm(Point location)
		{
			if (new BranchPropertyesForm(this).ShowDialog() == DialogResult.OK)
			{
				this.Parent.Layer.Parent.DoInvalidate(true);
				this.Parent.SaveXmlToSql();
				return true;
			}
			return false;
		}

		public override RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			float num = base.ThresholdWidth(canvas, base.Width);
			UnitPoint unitPoint = default(UnitPoint);
			UnitPoint unitPoint2 = default(UnitPoint);
			if (this.Source.Point.X < this.Destination.Point.X)
			{
				unitPoint.X = this.Source.Point.X;
				unitPoint2.X = this.Destination.Point.X;
			}
			else
			{
				unitPoint.X = this.Destination.Point.X;
				unitPoint2.X = this.Source.Point.X;
			}
			if (this.Source.Point.Y < this.Destination.Point.Y)
			{
				unitPoint.Y = this.Source.Point.Y;
				unitPoint2.Y = this.Destination.Point.Y;
			}
			else
			{
				unitPoint.Y = this.Destination.Point.Y;
				unitPoint2.Y = this.Source.Point.Y;
			}
			RectangleF result = new RectangleF(unitPoint.Point.X, unitPoint.Point.Y, unitPoint2.Point.X - unitPoint.Point.X, unitPoint2.Point.Y - unitPoint.Point.Y);
			if (inflate)
			{
				result.Inflate(num, num);
			}
			return result;
		}

		public override string GetFullName()
		{
			if (this.lineTool_0 != null)
			{
				return this.lineTool_0.GetFullName();
			}
			return base.GetFullName();
		}

		public ObjectOnLine AddSwitchTool(TypeSwitch typeSwitch, UnitPoint pointClick)
		{
			ObjectOnLine objectOnLine = ObjectOnLine.CreateObjectOnLine(typeSwitch, this);
			objectOnLine.CenterPoint = Class79.smethod_4(this.Source.Point, this.Destination.Point, pointClick);
			objectOnLine.Delta = Math.Sqrt(Math.Pow(this.Source.Point.X - objectOnLine.CenterPoint.X, 2.0) + Math.Pow(this.Source.Point.Y - objectOnLine.CenterPoint.Y, 2.0)) / Math.Sqrt(Math.Pow(this.Source.Point.X - this.Destination.Point.X, 2.0) + Math.Pow(this.Source.Point.Y - this.Destination.Point.Y, 2.0));
			this.AddSwitchTool(objectOnLine);
			objectOnLine.RecalcAngle();
			return objectOnLine;
		}

		public ObjectOnLine AddSwitchTool(ObjectOnLine switchTool, double delta)
		{
			double num = Math.Sqrt(Math.Pow(this.Source.Point.X - this.Destination.Point.X, 2.0) + Math.Pow(this.Source.Point.Y - this.Destination.Point.Y, 2.0));
			switchTool.Delta = delta;
			double delta2 = switchTool.Delta;
			double num2 = num * delta2;
			if (this.Destination.Point.X == this.Source.Point.X)
			{
				switchTool.CenterPoint = new UnitPoint(this.Destination.Point.X, this.Source.Point.Y + delta2 * (this.Destination.Point.Y - this.Source.Point.Y));
			}
			if (this.Destination.Point.Y == this.Source.Point.Y)
			{
				switchTool.CenterPoint = new UnitPoint(this.Source.Point.X + delta2 * (this.Destination.Point.X - this.Source.Point.X), this.Destination.Point.Y);
			}
			if (this.Destination.Point.X != this.Source.Point.X && this.Destination.Point.Y != this.Source.Point.Y)
			{
				double num3 = 1.0 / (Math.Sqrt(Math.Pow((this.Destination.Point.Y - this.Source.Point.Y) / (this.Destination.Point.X - this.Source.Point.X), 2.0) + 1.0) / num2);
				if (this.Destination.Point.X < this.Source.Point.X)
				{
					num3 *= -1.0;
				}
				double num4 = 1.0 / (Math.Sqrt(Math.Pow((this.Destination.Point.X - this.Source.Point.X) / (this.Destination.Point.Y - this.Source.Point.Y), 2.0) + 1.0) / num2);
				if (this.Destination.Point.Y < this.Source.Point.Y)
				{
					num4 *= -1.0;
				}
				switchTool.CenterPoint = new UnitPoint(this.Source.Point.X + num3, this.Source.Point.Y + num4);
			}
			this.AddSwitchTool(switchTool);
			switchTool.RecalcAngle();
			return switchTool;
		}

		public ObjectOnLine AddSwitchTool(TypeSwitch typeSwitch, double delta)
		{
			ObjectOnLine objectOnLine = ObjectOnLine.CreateObjectOnLine(typeSwitch, this);
			double num = Math.Sqrt(Math.Pow(this.Source.Point.X - this.Destination.Point.X, 2.0) + Math.Pow(this.Source.Point.Y - this.Destination.Point.Y, 2.0));
			objectOnLine.Delta = delta;
			double delta2 = objectOnLine.Delta;
			double num2 = num * delta2;
			if (this.Destination.Point.X == this.Source.Point.X)
			{
				objectOnLine.CenterPoint = new UnitPoint(this.Destination.Point.X, this.Source.Point.Y + delta2 * (this.Destination.Point.Y - this.Source.Point.Y));
			}
			if (this.Destination.Point.Y == this.Source.Point.Y)
			{
				objectOnLine.CenterPoint = new UnitPoint(this.Source.Point.X + delta2 * (this.Destination.Point.X - this.Source.Point.X), this.Destination.Point.Y);
			}
			if (this.Destination.Point.X != this.Source.Point.X && this.Destination.Point.Y != this.Source.Point.Y)
			{
				double num3 = 1.0 / (Math.Sqrt(Math.Pow((this.Destination.Point.Y - this.Source.Point.Y) / (this.Destination.Point.X - this.Source.Point.X), 2.0) + 1.0) / num2);
				if (this.Destination.Point.X < this.Source.Point.X)
				{
					num3 *= -1.0;
				}
				double num4 = 1.0 / (Math.Sqrt(Math.Pow((this.Destination.Point.X - this.Source.Point.X) / (this.Destination.Point.Y - this.Source.Point.Y), 2.0) + 1.0) / num2);
				if (this.Destination.Point.Y < this.Source.Point.Y)
				{
					num4 *= -1.0;
				}
				objectOnLine.CenterPoint = new UnitPoint(this.Source.Point.X + num3, this.Source.Point.Y + num4);
			}
			this.AddSwitchTool(objectOnLine);
			return objectOnLine;
		}

		public ObjectOnLine AddSwitchTool(TypeSwitch typeSwitch, DataRow r)
		{
			int num = (int)r["id"];
			ObjectOnLine objectOnLine = ObjectOnLine.CreateObjectOnLine(typeSwitch, r, this);
			objectOnLine.RecalcAngle();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)r["SchemaXml"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			XmlAttribute xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("gorMirror");
			if (xmlAttribute != null)
			{
				objectOnLine.GorMirror = Convert.ToBoolean(xmlAttribute.Value);
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("vertMirror");
			if (xmlAttribute != null)
			{
				objectOnLine.VertMirror = Convert.ToBoolean(xmlAttribute.Value);
			}
			this.AddSwitchTool(objectOnLine);
			return objectOnLine;
		}

		public void AddSwitchTool(ObjectOnLine switchTool, UnitPoint pointClick)
		{
			this.AddSwitchTool(switchTool);
			switchTool.CenterPoint = Class79.smethod_4(this.Source.Point, this.Destination.Point, pointClick);
			switchTool.Delta = Math.Sqrt(Math.Pow(this.Source.Point.X - switchTool.CenterPoint.X, 2.0) + Math.Pow(this.Source.Point.Y - switchTool.CenterPoint.Y, 2.0)) / Math.Sqrt(Math.Pow(this.Source.Point.X - this.Destination.Point.X, 2.0) + Math.Pow(this.Source.Point.Y - this.Destination.Point.Y, 2.0));
			switchTool.RecalcAngle();
		}

		public void AddSwitchTool(ObjectOnLine switchTool)
		{
			if (switchTool.Parent != this)
			{
				switchTool.Parent = this;
			}
			LineTool lineTool = (LineTool)this.Parent;
			if (this.CouplingRelation.amperagePoint != null)
			{
				PointTool amperagePoint = this.CouplingRelation.amperagePoint;
				lineTool.Amperages[amperagePoint].method_5();
				foreach (CouplingRelation couplingRelation in lineTool.CouplingRelations)
				{
					if (couplingRelation.amperagePoint == amperagePoint)
					{
						couplingRelation.amperagePoint = null;
					}
				}
				lineTool.method_13(amperagePoint);
			}
		}

		public override void vmethod_0(XmlNode xmlNode, List<PointTool> pointList)
		{
			XmlElement xmlElement = xmlNode.OwnerDocument.CreateElement("Branch");
			xmlElement.SetAttribute("ID", this.IdBase.ToString());
			BranchType type = this.Type;
			xmlElement.SetAttribute("Type", ((int)this.Type).ToString());
			xmlElement.SetAttribute("srcID", this.pointTool_0.Id);
			xmlElement.SetAttribute("destID", this.pointTool_1.Id);
			xmlNode.AppendChild(xmlElement);
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				drawObjectBase.vmethod_0(xmlElement, pointList);
			}
			if (!pointList.Contains(this.Source))
			{
				pointList.Add(this.Source);
			}
			if (!pointList.Contains(this.Destination))
			{
				pointList.Add(this.Destination);
			}
		}

		public override void Remove(bool delSql, bool bool_8)
		{
			base.Remove(delSql, bool_8);
		}

		private void method_10(DrawObjectBase drawObjectBase_2, PointToolEvetsArgs pointToolEvetsArgs_0)
		{
			this.ReCalcSwitchCoords(this.Destination.Point, pointToolEvetsArgs_0.oldPoint, pointToolEvetsArgs_0.newPoint);
		}

		private void method_11(DrawObjectBase drawObjectBase_2, PointToolEvetsArgs pointToolEvetsArgs_0)
		{
			this.ReCalcSwitchCoords(this.Source.Point, pointToolEvetsArgs_0.oldPoint, pointToolEvetsArgs_0.newPoint);
		}

		public void ReCalcSwitchCoords(UnitPoint point0, UnitPoint point1, UnitPoint newPoint)
		{
			if (this.ChildObjects.Count<DrawObjectBase>() != 0)
			{
				bool flag = true;
				if (point1 != newPoint)
				{
					flag = true;
				}
				double num = Math.Sqrt(Math.Pow(point0.X - newPoint.X, 2.0) + Math.Pow(point0.Y - newPoint.Y, 2.0));
				float num2 = 0f;
				if (flag)
				{
					num2 = Convert.ToSingle(Math.Atan(Math.Abs(this.Source.Point.X - this.Destination.Point.X) / Math.Abs(this.Source.Point.Y - this.Destination.Point.Y)) * 57.295779513082323);
					if (this.Source.Point.X > this.Destination.Point.X && this.Source.Point.Y > this.Destination.Point.Y)
					{
						num2 += 180f;
					}
					else if (this.Source.Point.Y > this.Destination.Point.Y)
					{
						num2 = 90f - (num2 - 90f);
					}
					else if (this.Source.Point.X > this.Destination.Point.X)
					{
						num2 = 270f - (num2 - 90f);
					}
				}
				foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
				{
					if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine))
					{
						ObjectOnLine objectOnLine = (ObjectOnLine)drawObjectBase;
						double num3 = objectOnLine.Delta;
						if (point0 == this.Destination.Point)
						{
							num3 = 1.0 - objectOnLine.Delta;
						}
						double num4 = num * num3;
						if (newPoint.X == point0.X)
						{
							objectOnLine.CenterPoint = new UnitPoint(newPoint.X, point0.Y + num3 * (newPoint.Y - point0.Y));
						}
						if (newPoint.Y == point0.Y)
						{
							objectOnLine.CenterPoint = new UnitPoint(point0.X + num3 * (newPoint.X - point0.X), newPoint.Y);
						}
						if (newPoint.X != point0.X && newPoint.Y != point0.Y)
						{
							double num5 = 1.0 / (Math.Sqrt(Math.Pow((newPoint.Y - point0.Y) / (newPoint.X - point0.X), 2.0) + 1.0) / num4);
							if (newPoint.X < point0.X)
							{
								num5 *= -1.0;
							}
							double num6 = 1.0 / (Math.Sqrt(Math.Pow((newPoint.X - point0.X) / (newPoint.Y - point0.Y), 2.0) + 1.0) / num4);
							if (newPoint.Y < point0.Y)
							{
								num6 *= -1.0;
							}
							objectOnLine.CenterPoint = new UnitPoint(point0.X + num5, point0.Y + num6);
						}
						if (flag)
						{
							objectOnLine.Angle = num2;
						}
					}
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (!this.disposed && disposing)
			{
				this.lineTool_0 = null;
				this.couplingRelation_0 = null;
				this.objectOnLine_0 = null;
			}
			base.Dispose(disposing);
		}

		private BranchType branchType_0;

		private PointTool pointTool_0;

		private PointTool pointTool_1;

		private LineTool lineTool_0;

		private CouplingRelation couplingRelation_0;

		private ObjectOnLine objectOnLine_0;

		internal Branch.Enum3 enum3_0;

		public bool useParentColor;

		private bool bool_7;

		internal enum Enum3
		{

		}
	}
}
