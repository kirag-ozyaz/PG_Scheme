using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.Canvas
{
	public static class CopyPasteCanvasObjects
	{
		public static bool IsPasteInObjects(List<DrawObjectBase> destinationObjects, List<DrawObjectBase> copyObj)
		{
			if (destinationObjects.Count == 0)
			{
				return false;
			}
			Type type = destinationObjects[0].GetType();
			foreach (DrawObjectBase drawObjectBase in destinationObjects)
			{
				if (drawObjectBase.LimitedEditing)
				{
					return false;
				}
				if ((type == typeof(RectangleTool) || type == typeof(ShinaTool)) && type != drawObjectBase.GetType())
				{
					return false;
				}
				if ((type == typeof(LineTool) || type.BaseType == typeof(LineTool)) && drawObjectBase.GetType() != typeof(LineTool) && drawObjectBase.GetType().BaseType != typeof(LineTool))
				{
					return false;
				}
			}
			if ((from obj in copyObj
			where obj.GetType() == typeof(RectangleTool)
			select obj).Count<DrawObjectBase>() > 0)
			{
				return false;
			}
			IEnumerable<DrawObjectBase> source = from obj in copyObj
			where obj.GetType() == typeof(ShinaTool)
			select obj;
			if (source.Count<DrawObjectBase>() > 0 && type != typeof(RectangleTool))
			{
				return false;
			}
			if (type == typeof(RectangleTool) && source.Count<DrawObjectBase>() == 0)
			{
				return false;
			}
			from obj in copyObj
			where obj.GetType() == typeof(LineCellTool)
			select obj;
			from obj in copyObj
			where obj.GetType() == typeof(Class14)
			select obj;
			if (copyObj.Count((DrawObjectBase obj) => obj.GetType() == typeof(LineTool)) > 0)
			{
				return false;
			}
			IEnumerable<DrawObjectBase> source2 = from obj in copyObj
			where obj.GetType() == typeof(ObjectOnLine) || obj.GetType().BaseType == typeof(ObjectOnLine) || obj.GetType() == typeof(TextBranchTool)
			select obj;
			if (type != typeof(LineTool) && type != typeof(LineCellTool))
			{
				if (type != typeof(Class14))
				{
					if (source2.Count<DrawObjectBase>() == copyObj.Count)
					{
						return false;
					}
					return true;
				}
			}
			if (source2.Count<DrawObjectBase>() < copyObj.Count)
			{
				return false;
			}
			return true;
		}

		public static List<DrawObjectBase> PasteInObjects(List<DrawObjectBase> destinationObjects, List<DrawObjectBase> copyObj)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			if (CopyPasteCanvasObjects.IsPasteInObjects(destinationObjects, copyObj))
			{
				foreach (DrawObjectBase drawObjectBase in destinationObjects)
				{
					Dictionary<DrawObjectBase, DrawObjectBase> dictionary = new Dictionary<DrawObjectBase, DrawObjectBase>();
					foreach (DrawObjectBase drawObjectBase2 in copyObj)
					{
						if (drawObjectBase2.GetType().BaseType != typeof(ObjectOnLine) && drawObjectBase2.GetType() != typeof(TextBranchTool))
						{
							dictionary.Add(drawObjectBase2, drawObjectBase2.Clone(false));
						}
					}
					foreach (object obj in from obj1 in dictionary.Values
					where obj1.GetType() == typeof(LineTool) || obj1.GetType() == typeof(LineCellTool) || obj1.GetType() == typeof(Class14)
					select obj1)
					{
						foreach (CouplingRelation couplingRelation in ((LineTool)((DrawObjectBase)obj)).CouplingRelations)
						{
							couplingRelation.Id = 0;
							couplingRelation.method_1().IdBase = 0;
							couplingRelation.method_2().IdBase = 0;
						}
					}
					Type type = destinationObjects[0].GetType();
					if (type == typeof(RectangleTool))
					{
						int num = 0;
						IEnumerable enumerable = from obj1 in dictionary.Values
						where obj1.GetType() == typeof(ShinaTool)
						select obj1;
						Dictionary<ShinaTool, UnitPoint> dictionary2 = new Dictionary<ShinaTool, UnitPoint>();
						foreach (object obj2 in enumerable)
						{
							DrawObjectBase drawObjectBase3 = (DrawObjectBase)obj2;
							if (drawObjectBase3 is ShinaTool)
							{
								drawObjectBase3.Parent = drawObjectBase;
								ShinaTool shinaTool = (ShinaTool)drawObjectBase3;
								bool flag = true;
								if (shinaTool.P1.Y == shinaTool.P2.Y || Math.Abs(shinaTool.P1.X - shinaTool.P2.X) > Math.Abs(shinaTool.P1.Y - shinaTool.P2.Y))
								{
									flag = false;
								}
								UnitPoint unitPoint = new UnitPoint(shinaTool.P1.X, shinaTool.P1.Y);
								UnitPoint empty = UnitPoint.Empty;
								if (flag)
								{
									empty = new UnitPoint((double)(((RectangleTool)drawObjectBase).Rectangle.X + ((RectangleTool)drawObjectBase).Rectangle.Width / 2f) + (double)((float)num) * 0.5, (double)((RectangleTool)drawObjectBase).Rectangle.Y);
								}
								else
								{
									empty = new UnitPoint((double)((RectangleTool)drawObjectBase).Rectangle.X, (double)(((RectangleTool)drawObjectBase).Rectangle.Y + ((RectangleTool)drawObjectBase).Rectangle.Height / 2f) + (double)((float)num) * 0.5);
								}
								drawObjectBase3.Move(new UnitPoint(empty.X - unitPoint.X, empty.Y - unitPoint.Y), true);
								drawObjectBase3.MoveHandleTo(((ShinaTool)drawObjectBase3).P2, 2);
								drawObjectBase3.MoveHandleTo(((ShinaTool)drawObjectBase3).P1, 1);
								UnitPoint value = new UnitPoint(shinaTool.P1.X - unitPoint.X, shinaTool.P1.Y - unitPoint.Y);
								dictionary2.Add(shinaTool, value);
								num++;
								drawObjectBase3.Align();
							}
						}
						for (int i = 0; i < dictionary.Values.Count; i++)
						{
							DrawObjectBase drawObjectBase4 = dictionary.Values.ToArray<DrawObjectBase>()[i];
							DrawObjectBase key = CopyPasteCanvasObjects.smethod_0(dictionary, drawObjectBase4);
							if (drawObjectBase4.GetType() == typeof(LineCellTool))
							{
								bool flag2 = false;
								foreach (PointTool pointTool in ((LineCellTool)drawObjectBase4).Ends)
								{
									if (pointTool.Master != null && pointTool.Master.GetType() == typeof(PointShinaTool) && pointTool.Master.Parent != null && dictionary.ContainsKey(pointTool.Master.Parent))
									{
										pointTool.IdBase = 0;
										drawObjectBase4.Parent = drawObjectBase;
										if (dictionary2.ContainsKey((ShinaTool)dictionary[pointTool.Master.Parent]) && !flag2)
										{
											drawObjectBase4.Move(dictionary2[(ShinaTool)dictionary[pointTool.Master.Parent]], true);
										}
										pointTool.Parent = dictionary[pointTool.Master.Parent];
										((PointShinaTool)pointTool).Delta = ((PointShinaTool)pointTool.Master).Delta;
										drawObjectBase4.Align();
										flag2 = true;
									}
								}
								if (!flag2)
								{
									dictionary.Remove(key);
									i--;
								}
							}
						}
					}
					if (type == typeof(ShinaTool))
					{
						ShinaTool shinaTool2 = (ShinaTool)drawObjectBase;
						for (int j = 0; j < dictionary.Values.Count; j++)
						{
							DrawObjectBase drawObjectBase5 = dictionary.Values.ToArray<DrawObjectBase>()[j];
							DrawObjectBase key2 = CopyPasteCanvasObjects.smethod_0(dictionary, drawObjectBase5);
							if (drawObjectBase5.GetType() == typeof(LineCellTool))
							{
								bool flag3 = false;
								foreach (PointTool pointTool2 in ((LineCellTool)drawObjectBase5).Ends)
								{
									if (pointTool2.Master != null && pointTool2.Master.GetType() == typeof(PointShinaTool) && pointTool2.Master.Parent != null)
									{
										pointTool2.IdBase = 0;
										drawObjectBase5.Parent = drawObjectBase.Parent;
										ShinaTool shinaTool3 = (ShinaTool)pointTool2.Master.Parent;
										UnitPoint offset = new UnitPoint(shinaTool2.P1.X - shinaTool3.P1.X, shinaTool2.P1.Y - shinaTool3.P1.Y);
										if (!flag3)
										{
											drawObjectBase5.Move(offset, true);
										}
										pointTool2.Parent = drawObjectBase;
										((PointShinaTool)pointTool2).Delta = ((PointShinaTool)pointTool2.Master).Delta;
										UnitPoint point = pointTool2.Point;
										bool flag4;
										do
										{
											flag4 = false;
											using (IEnumerator<DrawObjectBase> enumerator6 = pointTool2.Parent.ChildObjects.GetEnumerator())
											{
												while (enumerator6.MoveNext())
												{
													DrawObjectBase drawObjectBase6 = enumerator6.Current;
													if (drawObjectBase6.GetType() == typeof(PointShinaTool) && pointTool2 != drawObjectBase6 && ((PointShinaTool)pointTool2).Delta == ((PointShinaTool)drawObjectBase6).Delta)
													{
														((PointShinaTool)pointTool2).Delta += 0.1f;
														if (((PointShinaTool)pointTool2).Delta >= 1f)
														{
															((PointShinaTool)pointTool2).Delta = 0.5f;
															flag4 = false;
															break;
														}
														flag4 = true;
													}
												}
												goto IL_829;
											}
											break;
											IL_829:;
										}
										while (flag4);
										IL_79A:
										if (point != pointTool2.Point)
										{
											foreach (PointTool pointTool3 in ((LineCellTool)drawObjectBase5).GetPointsList())
											{
												if (pointTool3.Parent == null || !(pointTool3.Parent is ShinaTool))
												{
													pointTool3.Point += pointTool2.Point - point;
												}
											}
										}
										drawObjectBase5.Align();
										flag3 = true;
										continue;
										goto IL_79A;
									}
								}
								if (!flag3)
								{
									dictionary.Remove(key2);
									j--;
								}
							}
						}
					}
					if (type == typeof(LineTool) || type == typeof(LineCellTool) || type == typeof(Class14))
					{
						foreach (DrawObjectBase drawObjectBase7 in copyObj)
						{
							dictionary.Add(drawObjectBase7, drawObjectBase7.Clone(false));
						}
						LineTool lineTool = (LineTool)drawObjectBase;
						Branch branch = lineTool.SelectedBranch;
						if (branch == null && lineTool.SelectedPoint != null)
						{
							branch = lineTool.SelectedPoint.Branches.First<Branch>();
						}
						if (branch == null)
						{
							branch = lineTool.Branches[0];
						}
						if (branch != null)
						{
							foreach (DrawObjectBase drawObjectBase8 in dictionary.Values)
							{
								drawObjectBase8.IdBase = 0;
								if (drawObjectBase8 is ObjectOnLine)
								{
									branch.AddSwitchTool((ObjectOnLine)drawObjectBase8, ((ObjectOnLine)drawObjectBase8).Delta);
								}
								drawObjectBase8.Parent = branch;
								list.Add(drawObjectBase8);
							}
						}
					}
					foreach (DrawObjectBase drawObjectBase9 in from o in dictionary.Values
					where o.GetType() == typeof(ShinaTool)
					select o)
					{
						drawObjectBase9.IdBase = 0;
						foreach (DrawObjectBase drawObjectBase10 in drawObjectBase9.ChildObjects)
						{
							drawObjectBase10.IdBase = 0;
						}
						list.Add(drawObjectBase9);
					}
					foreach (DrawObjectBase drawObjectBase11 in from o in dictionary.Values
					where o.GetType() == typeof(LineTool) || o.GetType().BaseType == typeof(LineTool)
					select o)
					{
						drawObjectBase11.IdBase = 0;
						list.Add(drawObjectBase11);
						foreach (Branch branch2 in ((LineTool)drawObjectBase11).Branches)
						{
							foreach (DrawObjectBase drawObjectBase12 in branch2.ChildObjects)
							{
								drawObjectBase12.IdBase = 0;
								list.Add(drawObjectBase12);
							}
						}
					}
					foreach (DrawObjectBase drawObjectBase13 in from o in dictionary.Values
					where o.GetType() == typeof(ShinaTool)
					select o)
					{
						if (drawObjectBase13.Parent != null && drawObjectBase13.Parent.GetType() == typeof(RectangleTool) && ((RectangleTool)drawObjectBase13.Parent).TypeRectnagleTool == eTypeRectangleTool.CP)
						{
							((ShinaTool)drawObjectBase13).OnAmperage = true;
						}
					}
				}
			}
			return list;
		}

		public static List<DrawObjectBase> PasteSelectedObjects(List<DrawObjectBase> copyObj, UnitPoint pointPaste)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			Dictionary<DrawObjectBase, DrawObjectBase> dictionary = new Dictionary<DrawObjectBase, DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in copyObj)
			{
				if (drawObjectBase.GetType().BaseType != typeof(ObjectOnLine))
				{
					dictionary.Add(drawObjectBase, drawObjectBase.Clone(false));
				}
			}
			foreach (object obj3 in from obj1 in dictionary.Values
			where obj1.GetType() == typeof(LineTool) || obj1.GetType() == typeof(LineCellTool) || obj1.GetType() == typeof(Class14)
			select obj1)
			{
				foreach (CouplingRelation couplingRelation in ((LineTool)((DrawObjectBase)obj3)).CouplingRelations)
				{
					couplingRelation.Id = 0;
					couplingRelation.method_1().IdBase = 0;
					couplingRelation.method_2().IdBase = 0;
				}
			}
			UnitPoint empty = UnitPoint.Empty;
			for (int i = 0; i < dictionary.Values.Count; i++)
			{
				DrawObjectBase obj = dictionary.Values.ToArray<DrawObjectBase>()[i];
				DrawObjectBase drawObjectBase2 = CopyPasteCanvasObjects.smethod_0(dictionary, obj);
				if (obj is RectangleTool)
				{
					if (empty.IsEmpty)
					{
						empty = new UnitPoint((double)((RectangleTool)obj).Rectangle.X, (double)((RectangleTool)obj).Rectangle.Bottom);
					}
					else
					{
						if (empty.X > (double)((RectangleTool)obj).Rectangle.X)
						{
							empty.X = (double)((RectangleTool)obj).Rectangle.X;
						}
						if (empty.Y < (double)((RectangleTool)obj).Rectangle.Bottom)
						{
							empty.Y = (double)((RectangleTool)obj).Rectangle.Bottom;
						}
					}
				}
				if (obj is ShinaTool)
				{
					if (drawObjectBase2.Parent != null && dictionary.ContainsKey(drawObjectBase2.Parent))
					{
						obj.Parent = dictionary[drawObjectBase2.Parent];
						if (empty.IsEmpty)
						{
							empty = new UnitPoint(((ShinaTool)obj).P1.X, ((ShinaTool)obj).P1.Y);
						}
						else
						{
							if (empty.X > ((ShinaTool)obj).P1.X)
							{
								empty.X = ((ShinaTool)obj).P1.X;
							}
							if (empty.Y < ((ShinaTool)obj).P1.Y)
							{
								empty.Y = ((ShinaTool)obj).P1.X;
							}
						}
					}
					else
					{
						dictionary.Remove(drawObjectBase2);
						i--;
					}
				}
				if (obj.GetType() == typeof(LineCellTool))
				{
					if (drawObjectBase2.Parent != null && dictionary.ContainsKey(drawObjectBase2.Parent))
					{
						obj.Parent = dictionary[drawObjectBase2.Parent];
						bool flag = false;
						foreach (PointTool pointTool in ((LineCellTool)obj).Ends)
						{
							if (pointTool.Master != null && pointTool.Master.GetType() == typeof(PointShinaTool) && pointTool.Master.Parent != null && dictionary.ContainsKey(pointTool.Master.Parent))
							{
								pointTool.IdBase = 0;
								pointTool.Parent = dictionary[pointTool.Master.Parent];
								flag = true;
							}
						}
						if (!flag)
						{
							dictionary.Remove(drawObjectBase2);
							i--;
						}
						else
						{
							double num = ((LineCellTool)obj).GetPointsList().Min((PointTool o) => o.Point.X);
							double num2 = ((LineCellTool)obj).GetPointsList().Max((PointTool o) => o.Point.Y);
							if (empty.IsEmpty)
							{
								empty = new UnitPoint(num, num2);
							}
							else
							{
								if (empty.X > num)
								{
									empty.X = num;
								}
								if (empty.Y < num2)
								{
									empty.Y = num2;
								}
							}
						}
					}
					else
					{
						dictionary.Remove(drawObjectBase2);
						i--;
					}
				}
				if (obj.GetType() == typeof(LineTool))
				{
					IEnumerable enumerable = from obj1 in dictionary.Values
					where obj1 != obj && (obj1.GetType() == typeof(LineTool) || obj1.GetType() == typeof(LineCellTool))
					select obj1;
					PointTool[] array = ((LineTool)obj).Ends.ToArray<PointTool>();
					for (int j = 0; j < array.Length; j++)
					{
						PointTool pointTool2 = array[j];
						foreach (object obj2 in enumerable)
						{
							foreach (PointTool pointTool3 in ((LineTool)((DrawObjectBase)obj2)).Ends)
							{
								if (pointTool2.Master == pointTool3.Master && pointTool2 != pointTool3)
								{
									DrawObjectBase drawObjectBase3 = pointTool2;
									pointTool3.IdBase = 0;
									drawObjectBase3.IdBase = 0;
									Branch branch = array[j].Branches.First<Branch>();
									((LineTool)obj).RechangePointInBranch(branch, pointTool3, pointTool2 == branch.Source);
								}
							}
						}
					}
					double num3 = ((LineTool)obj).GetPointsList().Min((PointTool o) => o.Point.X);
					double num4 = ((LineTool)obj).GetPointsList().Max((PointTool o) => o.Point.Y);
					if (empty.IsEmpty)
					{
						empty = new UnitPoint(num3, num4);
					}
					else
					{
						if (empty.X > num3)
						{
							empty.X = num3;
						}
						if (empty.Y < num4)
						{
							empty.Y = num4;
						}
					}
				}
			}
			foreach (DrawObjectBase drawObjectBase4 in from o in dictionary.Values
			where o.GetType() == typeof(RectangleTool)
			select o)
			{
				drawObjectBase4.IdBase = 0;
				list.Add(drawObjectBase4);
				if (pointPaste.IsEmpty)
				{
					drawObjectBase4.Move(new UnitPoint(1.0, 1.0), true);
				}
				else
				{
					drawObjectBase4.Move(new UnitPoint(pointPaste.X - empty.X, pointPaste.Y - empty.Y), true);
				}
			}
			foreach (DrawObjectBase drawObjectBase5 in from o in dictionary.Values
			where o.GetType() == typeof(ShinaTool)
			select o)
			{
				drawObjectBase5.IdBase = 0;
				foreach (DrawObjectBase drawObjectBase6 in drawObjectBase5.ChildObjects)
				{
					drawObjectBase6.IdBase = 0;
				}
				list.Add(drawObjectBase5);
			}
			foreach (DrawObjectBase drawObjectBase7 in from o in dictionary.Values
			where o.GetType() == typeof(LineTool) || o.GetType().BaseType == typeof(LineTool)
			select o)
			{
				drawObjectBase7.IdBase = 0;
				list.Add(drawObjectBase7);
				foreach (Branch branch2 in ((LineTool)drawObjectBase7).Branches)
				{
					foreach (DrawObjectBase drawObjectBase8 in branch2.ChildObjects)
					{
						drawObjectBase8.IdBase = 0;
						list.Add(drawObjectBase8);
					}
				}
				if (drawObjectBase7.Parent == null)
				{
					if (pointPaste.IsEmpty)
					{
						drawObjectBase7.Move(new UnitPoint(1.0, 1.0), true);
					}
					else
					{
						drawObjectBase7.Move(new UnitPoint(pointPaste.X - empty.X, pointPaste.Y - empty.Y), true);
					}
				}
			}
			foreach (DrawObjectBase drawObjectBase9 in from o in dictionary.Values
			where o.GetType() == typeof(ShinaTool)
			select o)
			{
				if (drawObjectBase9.Parent != null && drawObjectBase9.Parent.GetType() == typeof(RectangleTool) && ((RectangleTool)drawObjectBase9.Parent).TypeRectnagleTool == eTypeRectangleTool.CP)
				{
					((ShinaTool)drawObjectBase9).OnAmperage = true;
				}
			}
			return list;
		}

		private static DrawObjectBase smethod_0(Dictionary<DrawObjectBase, DrawObjectBase> dictionary_0, DrawObjectBase drawObjectBase_0)
		{
			foreach (KeyValuePair<DrawObjectBase, DrawObjectBase> keyValuePair in dictionary_0)
			{
				if (keyValuePair.Value.Equals(drawObjectBase_0))
				{
					return keyValuePair.Key;
				}
			}
			return null;
		}
	}
}
