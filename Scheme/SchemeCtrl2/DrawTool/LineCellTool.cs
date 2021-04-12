using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool.FormsObj;
using SchemeCtrl2.Layers;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.DrawTool
{
	public class LineCellTool : LineTool
	{
		public override LineToolType Type
		{
			get
			{
				using (IEnumerator<PointTool> enumerator = base.Ends.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						PointTool pointTool = enumerator.Current;
						if (pointTool.Parent is ShinaTool)
						{
							eTypeShinaTool typeShinaTool = ((ShinaTool)pointTool.Parent).TypeShinaTool;
							if (typeShinaTool <= eTypeShinaTool.Shina_6)
							{
								if (typeShinaTool == eTypeShinaTool.Shina_04)
								{
									return LineToolType.CellLine_04;
								}
								if (typeShinaTool != eTypeShinaTool.Shina_6)
								{
									break;
								}
								return LineToolType.CellLine_6;
							}
							else
							{
								if (typeShinaTool == eTypeShinaTool.Shina_023)
								{
									return LineToolType.CellLine_023;
								}
								if (typeShinaTool != eTypeShinaTool.Shina_10)
								{
									break;
								}
								return LineToolType.CellLine_10;
							}
						}
					}
					goto IL_96;
				}
				LineToolType result;
				return result;
				IL_96:
				return this.lineToolType_0;
			}
			set
			{
				this.lineToolType_0 = value;
			}
		}

		public bool IsTransformer
		{
			get
			{
				foreach (Branch branch in base.Branches)
				{
					using (IEnumerator<DrawObjectBase> enumerator2 = branch.ChildObjects.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.GetType() == typeof(TransformerTool))
							{
								return true;
							}
						}
					}
				}
				return false;
			}
		}

		public LineCellTool()
		{
			
			this.lineToolType_0 = LineToolType.CellLine_10;
			this.color_4 = Color.White;
			
		}

		public LineCellTool(DataRow r, DrawingLayer l):base(r, l)
        {
			
			this.lineToolType_0 = LineToolType.CellLine_10;
			this.color_4 = Color.White;
			//base..ctor(r, l);
			foreach (PointTool pointTool in this.ends)
			{
				if (pointTool.Parent == null)
				{
					pointTool.Parent = this;
				}
			}
		}

		private ContextMenuStrip method_18()
		{
			return null;
		}

		public override void Remove(bool delSql, bool bool_8)
		{
			foreach (PointTool pointTool in this.ends)
			{
				if (pointTool.Parent != null && pointTool.Parent.GetType() == typeof(ShinaTool))
				{
					((ShinaTool)pointTool.Parent).RemoveCell((PointShinaTool)pointTool);
				}
			}
			base.Remove(delSql, bool_8);
		}

		private bool method_19(PointTool pointTool_0)
		{
			foreach (CouplingRelation couplingRelation in pointTool_0.CouplingRelations)
			{
				List<CouplingRelation> list = new List<CouplingRelation>();
				list.Add(couplingRelation);
				base.RunOnRelation(list, (couplingRelation.method_1() == pointTool_0) ? couplingRelation.method_2() : couplingRelation.method_1());
				if (this.method_20(list))
				{
					return true;
				}
			}
			return false;
		}

		private bool method_20(List<CouplingRelation> list_2)
		{
			List<PointTool> list = new List<PointTool>();
			foreach (CouplingRelation couplingRelation in list_2)
			{
				if (base.Ends.Contains(couplingRelation.method_1()))
				{
					list.Add(couplingRelation.method_1());
				}
				if (base.Ends.Contains(couplingRelation.method_2()))
				{
					list.Add(couplingRelation.method_2());
				}
			}
			bool result = true;
			foreach (PointTool pointTool in list)
			{
				if (pointTool.Parent != null && pointTool.Parent.GetType() == typeof(ShinaTool))
				{
					result = false;
				}
			}
			return result;
		}

		public override LineTool DevideLine(PointTool point)
		{
			if (point.BranchesCount == 2 && point.Branches.Last<Branch>().Parent == point.Branches.First<Branch>().Parent)
			{
				if (point.CouplingRelations.Count < 2)
				{
					CouplingRelation couplingRelation = point.Branches.First<Branch>().CouplingRelation;
					base.DevideRelation(couplingRelation, point);
				}
				LineTool lineTool = null;
				if (this.method_19(point))
				{
					lineTool = new LineTool();
				}
				else
				{
					lineTool = new LineCellTool();
					lineTool.Type = this.Type;
					lineTool.Parent = this.Parent;
				}
				lineTool.Text = this.Text;
				this.Layer.AddObject(lineTool);
				lineTool.CreateUniqueCopyName();
				foreach (Amperage amperage in this.Amperages.Values)
				{
					amperage.method_5();
				}
				List<CouplingRelation> list = new List<CouplingRelation>();
				if (lineTool.GetType() == typeof(LineCellTool))
				{
					CouplingRelation couplingRelation2 = point.CouplingRelations.First<CouplingRelation>();
					list.Add(couplingRelation2);
					base.RunOnRelation(list, (couplingRelation2.method_1() == point) ? couplingRelation2.method_2() : couplingRelation2.method_1());
					if (list.Count <= base.CouplingRelations.Count / 2)
					{
						goto IL_221;
					}
					List<CouplingRelation> list2 = new List<CouplingRelation>();
					list2.AddRange(list);
					list.Clear();
					using (List<CouplingRelation>.Enumerator enumerator2 = base.CouplingRelations.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							CouplingRelation item = enumerator2.Current;
							if (!list2.Contains(item))
							{
								list.Add(item);
							}
						}
						goto IL_221;
					}
				}
				foreach (CouplingRelation couplingRelation3 in point.CouplingRelations)
				{
					List<CouplingRelation> list3 = new List<CouplingRelation>();
					list3.Add(couplingRelation3);
					base.RunOnRelation(list3, (couplingRelation3.method_1() == point) ? couplingRelation3.method_2() : couplingRelation3.method_1());
					if (this.method_20(list3))
					{
						list.AddRange(list3);
						break;
					}
				}
				IL_221:
				foreach (CouplingRelation couplingRelation4 in list)
				{
					base.CouplingRelations.method_5(couplingRelation4);
					couplingRelation4.amperagePoint = null;
					couplingRelation4.Line = lineTool;
					lineTool.CouplingRelations.method_3(couplingRelation4);
					foreach (Branch branch in couplingRelation4.method_3())
					{
						base.Branches.Remove(branch);
						lineTool.Branches.Add(branch);
						branch.Parent = lineTool;
					}
				}
				List<PointTool> list4 = new List<PointTool>();
				list4.AddRange(this.Amperages.Keys);
				this.ends.Clear();
				base.GetPointsList();
				List<PointTool> pointsList = lineTool.GetPointsList();
				using (List<PointTool>.Enumerator enumerator4 = list4.GetEnumerator())
				{
					while (enumerator4.MoveNext())
					{
						PointTool ap = enumerator4.Current;
						if (pointsList.Contains(ap))
						{
							this.Amperages[ap].Conductor = lineTool;
							lineTool.Amperages.Add(ap, this.Amperages[ap]);
							this.Amperages.Remove(ap);
                            foreach (CouplingRelation couplingRelation4 in from obj in base.CouplingRelations
                                                                           where obj.amperagePoint == ap
                                                                           select obj)
                            {
                                couplingRelation4.amperagePoint = null;
                            }
                            //IEnumerable<CouplingRelation> couplingRelations = base.CouplingRelations;
                            //Func<CouplingRelation, bool> predicate;
                            //Func<CouplingRelation, bool> <>9__0;
                            //if ((predicate = <>9__0) == null)
                            //{
                            //	predicate = (<>9__0 = ((CouplingRelation obj) => obj.amperagePoint == ap));
                            //}
                            //foreach (CouplingRelation couplingRelation5 in couplingRelations.Where(predicate))
                            //{
                            //	couplingRelation5.amperagePoint = null;
                            //}
                        }
					}
				}
				if (this.Amperages.Count > 0)
				{
					this.vmethod_1();
				}
				if (lineTool.Amperages.Count > 0)
				{
					lineTool.vmethod_1();
				}
				return lineTool;
			}
			return null;
		}

		public override bool AddBranch(PointTool dest)
		{
			bool result = base.AddBranch(dest);
			if (this.ends.Contains(dest) && dest.Parent == null)
			{
				dest.Parent = this;
			}
			return result;
		}

		public override Branch AddBranch(PointTool src, PointTool dest)
		{
			if (src.Parent == this)
			{
				src.Parent = null;
			}
			else if (src.Parent == null)
			{
				src.Parent = this;
			}
			Branch result = base.AddBranch(src, dest);
			if (dest.Parent == null)
			{
				dest.Parent = this;
			}
			return result;
		}

		public override Branch AddBranch(PointTool src, PointTool dest, BranchType type)
		{
			if (src.Parent == this)
			{
				src.Parent = null;
			}
			else if (src.Parent == null)
			{
				src.Parent = this;
			}
			Branch result = base.AddBranch(src, dest, type);
			if (dest.Parent == null)
			{
				dest.Parent = this;
			}
			return result;
		}

		public override bool AddBranch(Branch branch)
		{
			if (branch.Source.Parent == this)
			{
				branch.Source.Parent = null;
			}
			else if (branch.Source.Parent == null)
			{
				branch.Source.Parent = this;
			}
			bool result = base.AddBranch(branch);
			if (branch.Destination.Parent == null)
			{
				branch.Destination.Parent = this;
			}
			return result;
		}

		public override bool ShowPropertyForm(Point location)
		{
			bool visible = this.TextProperty.Visible;
			if (new FormCellProperties(this, this.Layer.Parent.SqlSettings)
			{
				Location = location
			}.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
				return true;
			}
			return false;
		}

		private bool method_21(UnitPoint unitPoint_0)
		{
			if (this.Parent != null && this.Parent.GetType() == typeof(RectangleTool))
			{
				if (unitPoint_0.Point.X != ((RectangleTool)this.Parent).Rectangle.Left)
				{
					if (unitPoint_0.Point.X != ((RectangleTool)this.Parent).Rectangle.Left)
					{
						if (unitPoint_0.Point.Y == ((RectangleTool)this.Parent).Rectangle.Top || unitPoint_0.Point.Y == ((RectangleTool)this.Parent).Rectangle.Bottom)
						{
							return true;
						}
						return false;
					}
				}
				return true;
			}
			return false;
		}

		private ShinaTool method_22(UnitPoint unitPoint_0)
		{
			if (this.Parent != null)
			{
				using (IEnumerator<DrawObjectBase> enumerator = this.Parent.ChildObjects.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DrawObjectBase drawObjectBase = enumerator.Current;
						if (drawObjectBase.GetType() == typeof(ShinaTool) && drawObjectBase.PointInObject(unitPoint_0))
						{
							return (ShinaTool)drawObjectBase;
						}
					}
					goto IL_5E;
				}
				ShinaTool result;
				return result;
			}
			IL_5E:
			return null;
		}

		public override void OnMouseDown(CanvasControl canvas, UnitPoint point, ISnapPoint snappoint, MouseButtons button)
		{
			if (button != MouseButtons.Left)
			{
				if (button != MouseButtons.Right)
				{
					base.OnMouseDown(canvas, point, snappoint, button);
					return;
				}
				eCommandType eCommandType_ = canvas.eCommandType_0;
				if (eCommandType_ == eCommandType.draw)
				{
					this.CallEndDrawEvent(this);
					base.Branches[base.Branches.Count - 1].Destination.Parent = this;
					return;
				}
				base.OnMouseDown(canvas, point, snappoint, button);
				return;
			}
			else
			{
				eCommandType eCommandType_ = canvas.eCommandType_0;
				if (eCommandType_ != eCommandType.draw)
				{
					base.OnMouseDown(canvas, point, snappoint, button);
					return;
				}
				if (base.Branches.Count < 1)
				{
					base.OnMouseDown(canvas, point, snappoint, button);
					return;
				}
				if (this.method_21(base.Branches[base.Branches.Count - 1].Destination.Point))
				{
					base.Branches[base.Branches.Count - 1].Destination.Parent = this;
					this.CallEndDrawEvent(this);
					return;
				}
				ShinaTool shinaTool = this.method_22(base.Branches[base.Branches.Count - 1].Destination.Point);
				PointTool pointTool = canvas.method_29(point);
				if (shinaTool != null)
				{
					foreach (PointTool pointTool2 in this.ends)
					{
						if (pointTool2.Parent != null && pointTool2.Parent == shinaTool)
						{
							shinaTool = null;
							break;
						}
					}
				}
				if (shinaTool != null)
				{
					PointShinaTool newPoint = shinaTool.AddPointShinaTool(base.Branches[base.Branches.Count - 1].Destination);
					base.RechangePointInBranch(base.Branches[base.Branches.Count - 1], newPoint, false);
					this.CallEndDrawEvent(this);
					return;
				}
				if (pointTool != null)
				{
					base.RechangePointInBranch(this.branches[this.branches.Count - 1], pointTool, false);
					base.AmperageAnalisForNewPoint(pointTool, this.branches[this.branches.Count - 1]);
					this.CallEndDrawEvent(this);
					return;
				}
				this.AddBranch(new PointTool(point));
				return;
			}
		}

		public override void OnMouseUp(CanvasControl canvas, UnitPoint point, ISnapPoint snappoint, MouseButtons button)
		{
			base.OnMouseUp(canvas, point, snappoint, button);
			if (button == MouseButtons.Left && canvas.eCommandType_0 == eCommandType.select && this.selectedPoint != null && this.selectedPoint.BranchesCount == 1)
			{
				ShinaTool shinaTool = this.method_22(this.selectedPoint.Point);
				if (shinaTool != null)
				{
					bool isSourse = true;
					if (this.selectedPoint[0].Destination == this.selectedPoint)
					{
						isSourse = false;
					}
					PointShinaTool newPoint = shinaTool.AddPointShinaTool(this.selectedPoint);
					base.RechangePointInBranch(this.selectedPoint[0], newPoint, isSourse);
					canvas.DoInvalidate(true);
				}
			}
		}

		public override void Move(UnitPoint offset, bool selectedMove)
		{
			if (!selectedMove && this.Selected)
			{
				return;
			}
			if (this.Parent != null && this.Parent.Layer != null && !this.Parent.Selected && selectedMove)
			{
				RectangleF boundingRect = this.GetBoundingRect(this.Layer.Parent, false);
				boundingRect.X += (float)offset.X;
				boundingRect.Y += (float)offset.Y;
				if (boundingRect.Bottom > ((RectangleTool)this.Parent).Rectangle.Bottom)
				{
					offset.Y -= (double)(boundingRect.Bottom - ((RectangleTool)this.Parent).Rectangle.Bottom);
				}
				if (boundingRect.Top < ((RectangleTool)this.Parent).Rectangle.Top)
				{
					offset.Y -= (double)(boundingRect.Top - ((RectangleTool)this.Parent).Rectangle.Top);
				}
				if (boundingRect.Left < ((RectangleTool)this.Parent).Rectangle.Left)
				{
					offset.X -= (double)(boundingRect.Left - ((RectangleTool)this.Parent).Rectangle.Left);
				}
				if (boundingRect.Right > ((RectangleTool)this.Parent).Rectangle.Right)
				{
					offset.X -= (double)(boundingRect.Right - ((RectangleTool)this.Parent).Rectangle.Right);
				}
			}
			base.Move(offset, selectedMove);
		}

		public override void MoveHandleTo(UnitPoint point, int handleNumber)
		{
			if (this.Parent != null && this.Parent.Layer != null)
			{
				if (point.X < (double)((RectangleTool)this.Parent).Rectangle.Left)
				{
					point.X = (double)((RectangleTool)this.Parent).Rectangle.Left;
				}
				if (point.X > (double)((RectangleTool)this.Parent).Rectangle.Right)
				{
					point.X = (double)((RectangleTool)this.Parent).Rectangle.Right;
				}
				if (point.Y < (double)((RectangleTool)this.Parent).Rectangle.Top)
				{
					point.Y = (double)((RectangleTool)this.Parent).Rectangle.Top;
				}
				if (point.Y > (double)((RectangleTool)this.Parent).Rectangle.Bottom)
				{
					point.Y = (double)((RectangleTool)this.Parent).Rectangle.Bottom;
				}
			}
			base.MoveHandleTo(point, handleNumber);
		}

		public override void vmethod_0(XmlNode xmlNode, List<PointTool> pointList)
		{
			XmlElement xmlElement = xmlNode.OwnerDocument.CreateElement("Cell");
			xmlElement.SetAttribute("ID", this.IdBase.ToString());
			xmlElement.SetAttribute("text", this.Text);
			xmlElement.SetAttribute("textVis", this.TextProperty.Visible.ToString());
			xmlElement.SetAttribute("textPos", ((int)this.TextProperty.Position).ToString());
			List<PointTool> pointsList = base.GetPointsList();
			if (!base.UseSettingColor)
			{
				xmlElement.SetAttribute("color", this.Color.Name);
			}
			else
			{
				xmlElement.SetAttribute("color", "");
			}
			if (this.TextProperty.Visible)
			{
				string value = string.Empty;
				foreach (PointTool pointTool in pointsList)
				{
					if (pointTool.TextProperty.Visible)
					{
						value = pointTool.Id;
						break;
					}
				}
				xmlElement.SetAttribute("textPoint", value);
			}
			xmlNode.AppendChild(xmlElement);
			foreach (Branch branch in this.branches)
			{
				branch.vmethod_0(xmlElement, pointList);
			}
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			LineCellTool lineCellTool = new LineCellTool();
			lineCellTool.Copy(this);
			return lineCellTool;
		}

		public override void Align()
		{
			if (this.Parent != null && this.Parent.GetType() == typeof(RectangleTool) && this.Parent.Visible)
			{
				foreach (PointTool pointTool in base.Ends)
				{
					if (pointTool.Parent != null && pointTool.Parent.GetType() == typeof(ShinaTool))
					{
						pointTool.Parent.Align();
						bool flag = ((ShinaTool)pointTool.Parent).P1.X == ((ShinaTool)pointTool.Parent).P2.X;
						if (base.Branches.Count == 1)
						{
							PointTool pointTool2 = (base.Branches[0].Destination == pointTool) ? base.Branches[0].Source : base.Branches[0].Destination;
							if (this.TextProperty.Visible)
							{
								pointTool.TextProperty.Visible = false;
								pointTool2.TextProperty.Visible = true;
							}
							if (flag)
							{
								if (pointTool2.Point.X > ((ShinaTool)pointTool.Parent).P1.X)
								{
									pointTool2.Point = new UnitPoint((double)((RectangleTool)this.Parent).Rectangle.Right, pointTool.Point.Y);
									pointTool2.TextProperty.Position = ePositionText.LT;
								}
								else
								{
									pointTool2.Point = new UnitPoint((double)((RectangleTool)this.Parent).Rectangle.Left, pointTool.Point.Y);
									pointTool2.TextProperty.Position = ePositionText.RT;
								}
							}
							else if (pointTool2.Point.Y > ((ShinaTool)pointTool.Parent).P1.Y)
							{
								pointTool2.Point = new UnitPoint(pointTool.Point.X, (double)((RectangleTool)this.Parent).Rectangle.Bottom);
								pointTool2.TextProperty.Position = ePositionText.LB;
							}
							else
							{
								pointTool2.Point = new UnitPoint(pointTool.Point.X, (double)((RectangleTool)this.Parent).Rectangle.Top);
								pointTool2.TextProperty.Position = ePositionText.LT;
							}
						}
					}
				}
				foreach (Branch branch in base.Branches)
				{
					List<ObjectOnLine> list = (from obj in branch.ChildObjects
					where obj is ObjectOnLine
					select (ObjectOnLine)obj).ToList<ObjectOnLine>();
					list.Sort(new Comparison<ObjectOnLine>(LineCellTool.smethod_0));
					int num = 1;
					foreach (ObjectOnLine objectOnLine in list)
					{
						objectOnLine.Delta = (double)((float)num / (float)(list.Count + 1));
						objectOnLine.Align();
						num++;
					}
				}
				this.Layer.Parent.DoInvalidate(true);
				return;
			}
		}

		private static int smethod_0(ObjectOnLine objectOnLine_0, ObjectOnLine objectOnLine_1)
		{
			if (objectOnLine_0 == null)
			{
				if (objectOnLine_1 == null)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (objectOnLine_1 == null)
				{
					return 1;
				}
				if (objectOnLine_0.Delta == objectOnLine_1.Delta)
				{
					return 0;
				}
				if (objectOnLine_0.Delta < objectOnLine_1.Delta)
				{
					return -1;
				}
				return 1;
			}
		}

		public bool CheckShinaParent(ShinaTool shina)
		{
			foreach (PointTool pointTool in base.Ends)
			{
				if (pointTool.GetType() == typeof(PointShinaTool) && pointTool.Parent != null && pointTool.Parent == shina)
				{
					return true;
				}
			}
			return false;
		}

		public virtual ShinaTool GetParentShina()
		{
			foreach (PointTool pointTool in base.Ends)
			{
				if (pointTool.GetType() == typeof(PointShinaTool) && pointTool.Parent != null && pointTool.Parent is ShinaTool)
				{
					return (ShinaTool)pointTool.Parent;
				}
			}
			return null;
		}

		public override string GetFullName()
		{
			return this.Parent.GetFullName() + ": Ячейка-" + this.ToString();
		}

		private LineToolType lineToolType_0;

		private Color color_4;
	}
}
