using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
			if (CopyPasteCanvasObjects.func_0 == null)
			{
				CopyPasteCanvasObjects.func_0 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_1);
			}
			IEnumerable<DrawObjectBase> source = copyObj.Where(CopyPasteCanvasObjects.func_0);
			if (source.Count<DrawObjectBase>() > 0)
			{
				return false;
			}
			if (CopyPasteCanvasObjects.func_1 == null)
			{
				CopyPasteCanvasObjects.func_1 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_2);
			}
			IEnumerable<DrawObjectBase> source2 = copyObj.Where(CopyPasteCanvasObjects.func_1);
			if (source2.Count<DrawObjectBase>() > 0 && type != typeof(RectangleTool))
			{
				return false;
			}
			if (type == typeof(RectangleTool) && source2.Count<DrawObjectBase>() == 0)
			{
				return false;
			}
			if (CopyPasteCanvasObjects.func_2 == null)
			{
				CopyPasteCanvasObjects.func_2 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_3);
			}
			copyObj.Where(CopyPasteCanvasObjects.func_2);
			if (CopyPasteCanvasObjects.func_3 == null)
			{
				CopyPasteCanvasObjects.func_3 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_4);
			}
			copyObj.Where(CopyPasteCanvasObjects.func_3);
			if (CopyPasteCanvasObjects.func_4 == null)
			{
				CopyPasteCanvasObjects.func_4 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_5);
			}
			if (copyObj.Count(CopyPasteCanvasObjects.func_4) > 0)
			{
				return false;
			}
			if (CopyPasteCanvasObjects.func_5 == null)
			{
				CopyPasteCanvasObjects.func_5 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_6);
			}
			IEnumerable<DrawObjectBase> source3 = copyObj.Where(CopyPasteCanvasObjects.func_5);
			if (type != typeof(LineTool) && type != typeof(LineCellTool))
			{
				if (type != typeof(Class74))
				{
					if (source3.Count<DrawObjectBase>() == copyObj.Count)
					{
						return false;
					}
					return true;
				}
			}
			if (source3.Count<DrawObjectBase>() < copyObj.Count)
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
					IEnumerable<DrawObjectBase> values = dictionary.Values;
					if (CopyPasteCanvasObjects.func_6 == null)
					{
						CopyPasteCanvasObjects.func_6 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_7);
					}
					IEnumerable enumerable = values.Where(CopyPasteCanvasObjects.func_6);
					foreach (object obj in enumerable)
					{
						DrawObjectBase drawObjectBase3 = (DrawObjectBase)obj;
						foreach (CouplingRelation couplingRelation in ((LineTool)drawObjectBase3).CouplingRelations)
						{
							couplingRelation.Id = 0;
							couplingRelation.Vertex1.IdBase = 0;
							couplingRelation.Vertex2.IdBase = 0;
						}
					}
					Type type = destinationObjects[0].GetType();
					if (type == typeof(RectangleTool))
					{
						int num = 0;
						IEnumerable<DrawObjectBase> values2 = dictionary.Values;
						if (CopyPasteCanvasObjects.func_7 == null)
						{
							CopyPasteCanvasObjects.func_7 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_8);
						}
						IEnumerable enumerable2 = values2.Where(CopyPasteCanvasObjects.func_7);
						Dictionary<ShinaTool, UnitPoint> dictionary2 = new Dictionary<ShinaTool, UnitPoint>();
						foreach (object obj2 in enumerable2)
						{
							DrawObjectBase drawObjectBase4 = (DrawObjectBase)obj2;
							if (drawObjectBase4 is ShinaTool)
							{
								drawObjectBase4.Parent = drawObjectBase;
								ShinaTool shinaTool = (ShinaTool)drawObjectBase4;
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
								drawObjectBase4.Move(new UnitPoint(empty.X - unitPoint.X, empty.Y - unitPoint.Y), true);
								drawObjectBase4.MoveHandleTo(((ShinaTool)drawObjectBase4).P2, 2);
								drawObjectBase4.MoveHandleTo(((ShinaTool)drawObjectBase4).P1, 1);
								UnitPoint value = new UnitPoint(shinaTool.P1.X - unitPoint.X, shinaTool.P1.Y - unitPoint.Y);
								dictionary2.Add(shinaTool, value);
								num++;
								drawObjectBase4.Align();
							}
						}
						for (int i = 0; i < dictionary.Values.Count; i++)
						{
							DrawObjectBase drawObjectBase5 = dictionary.Values.ToArray<DrawObjectBase>()[i];
							DrawObjectBase key = CopyPasteCanvasObjects.smethod_0(dictionary, drawObjectBase5);
							if (drawObjectBase5.GetType() == typeof(LineCellTool))
							{
								bool flag2 = false;
								foreach (PointTool pointTool in ((LineCellTool)drawObjectBase5).Ends)
								{
									if (pointTool.Master != null && pointTool.Master.GetType() == typeof(PointShinaTool) && pointTool.Master.Parent != null && dictionary.ContainsKey(pointTool.Master.Parent))
									{
										pointTool.IdBase = 0;
										drawObjectBase5.Parent = drawObjectBase;
										if (dictionary2.ContainsKey((ShinaTool)dictionary[pointTool.Master.Parent]) && !flag2)
										{
											drawObjectBase5.Move(dictionary2[(ShinaTool)dictionary[pointTool.Master.Parent]], true);
										}
										pointTool.Parent = dictionary[pointTool.Master.Parent];
										((PointShinaTool)pointTool).Delta = ((PointShinaTool)pointTool.Master).Delta;
										drawObjectBase5.Align();
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
							DrawObjectBase drawObjectBase6 = dictionary.Values.ToArray<DrawObjectBase>()[j];
							DrawObjectBase key2 = CopyPasteCanvasObjects.smethod_0(dictionary, drawObjectBase6);
							if (drawObjectBase6.GetType() == typeof(LineCellTool))
							{
								bool flag3 = false;
								foreach (PointTool pointTool2 in ((LineCellTool)drawObjectBase6).Ends)
								{
									if (pointTool2.Master != null && pointTool2.Master.GetType() == typeof(PointShinaTool) && pointTool2.Master.Parent != null)
									{
										pointTool2.IdBase = 0;
										drawObjectBase6.Parent = drawObjectBase.Parent;
										ShinaTool shinaTool3 = (ShinaTool)pointTool2.Master.Parent;
										UnitPoint offset = new UnitPoint(shinaTool2.P1.X - shinaTool3.P1.X, shinaTool2.P1.Y - shinaTool3.P1.Y);
										if (!flag3)
										{
											drawObjectBase6.Move(offset, true);
										}
										pointTool2.Parent = drawObjectBase;
										((PointShinaTool)pointTool2).Delta = ((PointShinaTool)pointTool2.Master).Delta;
										UnitPoint point = pointTool2.Point;
										bool flag4;
										do
										{
											flag4 = false;
											foreach (DrawObjectBase drawObjectBase7 in pointTool2.Parent.ChildObjects)
											{
												if (drawObjectBase7.GetType() == typeof(PointShinaTool) && pointTool2 != drawObjectBase7 && ((PointShinaTool)pointTool2).Delta == ((PointShinaTool)drawObjectBase7).Delta)
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
										}
										while (flag4);
										if (point != pointTool2.Point)
										{
											foreach (PointTool pointTool3 in ((LineCellTool)drawObjectBase6).GetPointsList())
											{
												if (pointTool3.Parent == null || !(pointTool3.Parent is ShinaTool))
												{
													pointTool3.Point += pointTool2.Point - point;
												}
											}
										}
										drawObjectBase6.Align();
										flag3 = true;
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
					if (type == typeof(LineTool) || type == typeof(LineCellTool) || type == typeof(Class74))
					{
						foreach (DrawObjectBase drawObjectBase8 in copyObj)
						{
							dictionary.Add(drawObjectBase8, drawObjectBase8.Clone(false));
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
							foreach (DrawObjectBase drawObjectBase9 in dictionary.Values)
							{
								drawObjectBase9.IdBase = 0;
								if (drawObjectBase9 is ObjectOnLine)
								{
									branch.AddSwitchTool((ObjectOnLine)drawObjectBase9, ((ObjectOnLine)drawObjectBase9).Delta);
								}
								drawObjectBase9.Parent = branch;
								list.Add(drawObjectBase9);
							}
						}
					}
					IEnumerable<DrawObjectBase> values3 = dictionary.Values;
					if (CopyPasteCanvasObjects.func_8 == null)
					{
						CopyPasteCanvasObjects.func_8 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_9);
					}
					foreach (DrawObjectBase drawObjectBase10 in values3.Where(CopyPasteCanvasObjects.func_8))
					{
						drawObjectBase10.IdBase = 0;
						foreach (DrawObjectBase drawObjectBase11 in drawObjectBase10.ChildObjects)
						{
							drawObjectBase11.IdBase = 0;
						}
						list.Add(drawObjectBase10);
					}
					IEnumerable<DrawObjectBase> values4 = dictionary.Values;
					if (CopyPasteCanvasObjects.func_9 == null)
					{
						CopyPasteCanvasObjects.func_9 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_10);
					}
					foreach (DrawObjectBase drawObjectBase12 in values4.Where(CopyPasteCanvasObjects.func_9))
					{
						drawObjectBase12.IdBase = 0;
						list.Add(drawObjectBase12);
						foreach (Branch branch2 in ((LineTool)drawObjectBase12).Branches)
						{
							foreach (DrawObjectBase drawObjectBase13 in branch2.ChildObjects)
							{
								drawObjectBase13.IdBase = 0;
								list.Add(drawObjectBase13);
							}
						}
					}
					IEnumerable<DrawObjectBase> values5 = dictionary.Values;
					if (CopyPasteCanvasObjects.func_10 == null)
					{
						CopyPasteCanvasObjects.func_10 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_11);
					}
					foreach (DrawObjectBase drawObjectBase14 in values5.Where(CopyPasteCanvasObjects.func_10))
					{
						if (drawObjectBase14.Parent != null && drawObjectBase14.Parent.GetType() == typeof(RectangleTool) && ((RectangleTool)drawObjectBase14.Parent).TypeRectnagleTool == eTypeRectangleTool.CP)
						{
							((ShinaTool)drawObjectBase14).OnAmperage = true;
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
			IEnumerable<DrawObjectBase> values = dictionary.Values;
			if (CopyPasteCanvasObjects.func_11 == null)
			{
				CopyPasteCanvasObjects.func_11 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_12);
			}
			IEnumerable enumerable = values.Where(CopyPasteCanvasObjects.func_11);
			foreach (object obj in enumerable)
			{
				DrawObjectBase drawObjectBase2 = (DrawObjectBase)obj;
				foreach (CouplingRelation couplingRelation in ((LineTool)drawObjectBase2).CouplingRelations)
				{
					couplingRelation.Id = 0;
					couplingRelation.Vertex1.IdBase = 0;
					couplingRelation.Vertex2.IdBase = 0;
				}
			}
			UnitPoint empty = UnitPoint.Empty;
			for (int i = 0; i < dictionary.Values.Count; i++)
			{
				Func<DrawObjectBase, bool> func = null;
				CopyPasteCanvasObjects.Class44 @class = new CopyPasteCanvasObjects.Class44();
				@class.drawObjectBase_0 = dictionary.Values.ToArray<DrawObjectBase>()[i];
				DrawObjectBase drawObjectBase3 = CopyPasteCanvasObjects.smethod_0(dictionary, @class.drawObjectBase_0);
				if (@class.drawObjectBase_0 is RectangleTool)
				{
					if (empty.IsEmpty)
					{
						empty = new UnitPoint((double)((RectangleTool)@class.drawObjectBase_0).Rectangle.X, (double)((RectangleTool)@class.drawObjectBase_0).Rectangle.Bottom);
					}
					else
					{
						if (empty.X > (double)((RectangleTool)@class.drawObjectBase_0).Rectangle.X)
						{
							empty.X = (double)((RectangleTool)@class.drawObjectBase_0).Rectangle.X;
						}
						if (empty.Y < (double)((RectangleTool)@class.drawObjectBase_0).Rectangle.Bottom)
						{
							empty.Y = (double)((RectangleTool)@class.drawObjectBase_0).Rectangle.Bottom;
						}
					}
				}
				if (@class.drawObjectBase_0 is ShinaTool)
				{
					if (drawObjectBase3.Parent != null && dictionary.ContainsKey(drawObjectBase3.Parent))
					{
						@class.drawObjectBase_0.Parent = dictionary[drawObjectBase3.Parent];
						if (empty.IsEmpty)
						{
							empty = new UnitPoint(((ShinaTool)@class.drawObjectBase_0).P1.X, ((ShinaTool)@class.drawObjectBase_0).P1.Y);
						}
						else
						{
							if (empty.X > ((ShinaTool)@class.drawObjectBase_0).P1.X)
							{
								empty.X = ((ShinaTool)@class.drawObjectBase_0).P1.X;
							}
							if (empty.Y < ((ShinaTool)@class.drawObjectBase_0).P1.Y)
							{
								empty.Y = ((ShinaTool)@class.drawObjectBase_0).P1.X;
							}
						}
					}
					else
					{
						dictionary.Remove(drawObjectBase3);
						i--;
					}
				}
				if (@class.drawObjectBase_0.GetType() == typeof(LineCellTool))
				{
					if (drawObjectBase3.Parent != null && dictionary.ContainsKey(drawObjectBase3.Parent))
					{
						@class.drawObjectBase_0.Parent = dictionary[drawObjectBase3.Parent];
						bool flag = false;
						foreach (PointTool pointTool in ((LineCellTool)@class.drawObjectBase_0).Ends)
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
							dictionary.Remove(drawObjectBase3);
							i--;
						}
						else
						{
							IEnumerable<PointTool> pointsList = ((LineCellTool)@class.drawObjectBase_0).GetPointsList();
							if (CopyPasteCanvasObjects.func_12 == null)
							{
								CopyPasteCanvasObjects.func_12 = new Func<PointTool, double>(CopyPasteCanvasObjects.smethod_13);
							}
							double num = pointsList.Min(CopyPasteCanvasObjects.func_12);
							IEnumerable<PointTool> pointsList2 = ((LineCellTool)@class.drawObjectBase_0).GetPointsList();
							if (CopyPasteCanvasObjects.func_13 == null)
							{
								CopyPasteCanvasObjects.func_13 = new Func<PointTool, double>(CopyPasteCanvasObjects.smethod_14);
							}
							double num2 = pointsList2.Max(CopyPasteCanvasObjects.func_13);
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
						dictionary.Remove(drawObjectBase3);
						i--;
					}
				}
				if (@class.drawObjectBase_0.GetType() == typeof(LineTool))
				{
					IEnumerable<DrawObjectBase> values2 = dictionary.Values;
					if (func == null)
					{
						func = new Func<DrawObjectBase, bool>(@class.method_0);
					}
					IEnumerable enumerable2 = values2.Where(func);
					PointTool[] array = ((LineTool)@class.drawObjectBase_0).Ends.ToArray<PointTool>();
					for (int j = 0; j < array.Length; j++)
					{
						PointTool pointTool2 = array[j];
						foreach (object obj2 in enumerable2)
						{
							DrawObjectBase drawObjectBase4 = (DrawObjectBase)obj2;
							foreach (PointTool pointTool3 in ((LineTool)drawObjectBase4).Ends)
							{
								if (pointTool2.Master == pointTool3.Master && pointTool2 != pointTool3)
								{
									DrawObjectBase drawObjectBase5 = pointTool2;
									pointTool3.IdBase = 0;
									drawObjectBase5.IdBase = 0;
									Branch branch = array[j].Branches.First<Branch>();
									((LineTool)@class.drawObjectBase_0).RechangePointInBranch(branch, pointTool3, pointTool2 == branch.Source);
								}
							}
						}
					}
					IEnumerable<PointTool> pointsList3 = ((LineTool)@class.drawObjectBase_0).GetPointsList();
					if (CopyPasteCanvasObjects.func_14 == null)
					{
						CopyPasteCanvasObjects.func_14 = new Func<PointTool, double>(CopyPasteCanvasObjects.smethod_15);
					}
					double num3 = pointsList3.Min(CopyPasteCanvasObjects.func_14);
					IEnumerable<PointTool> pointsList4 = ((LineTool)@class.drawObjectBase_0).GetPointsList();
					if (CopyPasteCanvasObjects.func_15 == null)
					{
						CopyPasteCanvasObjects.func_15 = new Func<PointTool, double>(CopyPasteCanvasObjects.smethod_16);
					}
					double num4 = pointsList4.Max(CopyPasteCanvasObjects.func_15);
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
			IEnumerable<DrawObjectBase> values3 = dictionary.Values;
			if (CopyPasteCanvasObjects.func_16 == null)
			{
				CopyPasteCanvasObjects.func_16 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_17);
			}
			foreach (DrawObjectBase drawObjectBase6 in values3.Where(CopyPasteCanvasObjects.func_16))
			{
				drawObjectBase6.IdBase = 0;
				list.Add(drawObjectBase6);
				if (pointPaste.IsEmpty)
				{
					drawObjectBase6.Move(new UnitPoint(1.0, 1.0), true);
				}
				else
				{
					drawObjectBase6.Move(new UnitPoint(pointPaste.X - empty.X, pointPaste.Y - empty.Y), true);
				}
			}
			IEnumerable<DrawObjectBase> values4 = dictionary.Values;
			if (CopyPasteCanvasObjects.func_17 == null)
			{
				CopyPasteCanvasObjects.func_17 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_18);
			}
			foreach (DrawObjectBase drawObjectBase7 in values4.Where(CopyPasteCanvasObjects.func_17))
			{
				drawObjectBase7.IdBase = 0;
				foreach (DrawObjectBase drawObjectBase8 in drawObjectBase7.ChildObjects)
				{
					drawObjectBase8.IdBase = 0;
				}
				list.Add(drawObjectBase7);
			}
			IEnumerable<DrawObjectBase> values5 = dictionary.Values;
			if (CopyPasteCanvasObjects.func_18 == null)
			{
				CopyPasteCanvasObjects.func_18 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_19);
			}
			foreach (DrawObjectBase drawObjectBase9 in values5.Where(CopyPasteCanvasObjects.func_18))
			{
				drawObjectBase9.IdBase = 0;
				list.Add(drawObjectBase9);
				foreach (Branch branch2 in ((LineTool)drawObjectBase9).Branches)
				{
					foreach (DrawObjectBase drawObjectBase10 in branch2.ChildObjects)
					{
						drawObjectBase10.IdBase = 0;
						list.Add(drawObjectBase10);
					}
				}
				if (drawObjectBase9.Parent == null)
				{
					if (pointPaste.IsEmpty)
					{
						drawObjectBase9.Move(new UnitPoint(1.0, 1.0), true);
					}
					else
					{
						drawObjectBase9.Move(new UnitPoint(pointPaste.X - empty.X, pointPaste.Y - empty.Y), true);
					}
				}
			}
			IEnumerable<DrawObjectBase> values6 = dictionary.Values;
			if (CopyPasteCanvasObjects.func_19 == null)
			{
				CopyPasteCanvasObjects.func_19 = new Func<DrawObjectBase, bool>(CopyPasteCanvasObjects.smethod_20);
			}
			foreach (DrawObjectBase drawObjectBase11 in values6.Where(CopyPasteCanvasObjects.func_19))
			{
				if (drawObjectBase11.Parent != null && drawObjectBase11.Parent.GetType() == typeof(RectangleTool) && ((RectangleTool)drawObjectBase11.Parent).TypeRectnagleTool == eTypeRectangleTool.CP)
				{
					((ShinaTool)drawObjectBase11).OnAmperage = true;
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

		[CompilerGenerated]
		private static bool smethod_1(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool);
		}

		[CompilerGenerated]
		private static bool smethod_2(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(ShinaTool);
		}

		[CompilerGenerated]
		private static bool smethod_3(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(LineCellTool);
		}

		[CompilerGenerated]
		private static bool smethod_4(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(Class74);
		}

		[CompilerGenerated]
		private static bool smethod_5(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(LineTool);
		}

		[CompilerGenerated]
		private static bool smethod_6(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(ObjectOnLine) || drawObjectBase_0.GetType().BaseType == typeof(ObjectOnLine) || drawObjectBase_0.GetType() == typeof(TextBranchTool);
		}

		[CompilerGenerated]
		private static bool smethod_7(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(LineTool) || drawObjectBase_0.GetType() == typeof(LineCellTool) || drawObjectBase_0.GetType() == typeof(Class74);
		}

		[CompilerGenerated]
		private static bool smethod_8(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(ShinaTool);
		}

		[CompilerGenerated]
		private static bool smethod_9(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(ShinaTool);
		}

		[CompilerGenerated]
		private static bool smethod_10(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(LineTool) || drawObjectBase_0.GetType().BaseType == typeof(LineTool);
		}

		[CompilerGenerated]
		private static bool smethod_11(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(ShinaTool);
		}

		[CompilerGenerated]
		private static bool smethod_12(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(LineTool) || drawObjectBase_0.GetType() == typeof(LineCellTool) || drawObjectBase_0.GetType() == typeof(Class74);
		}

		[CompilerGenerated]
		private static double smethod_13(PointTool pointTool_0)
		{
			return pointTool_0.Point.X;
		}

		[CompilerGenerated]
		private static double smethod_14(PointTool pointTool_0)
		{
			return pointTool_0.Point.Y;
		}

		[CompilerGenerated]
		private static double smethod_15(PointTool pointTool_0)
		{
			return pointTool_0.Point.X;
		}

		[CompilerGenerated]
		private static double smethod_16(PointTool pointTool_0)
		{
			return pointTool_0.Point.Y;
		}

		[CompilerGenerated]
		private static bool smethod_17(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool);
		}

		[CompilerGenerated]
		private static bool smethod_18(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(ShinaTool);
		}

		[CompilerGenerated]
		private static bool smethod_19(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(LineTool) || drawObjectBase_0.GetType().BaseType == typeof(LineTool);
		}

		[CompilerGenerated]
		private static bool smethod_20(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(ShinaTool);
		}

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_0;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_1;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_2;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_3;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_4;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_5;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_6;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_7;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_8;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_9;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_10;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_11;

		[CompilerGenerated]
		private static Func<PointTool, double> func_12;

		[CompilerGenerated]
		private static Func<PointTool, double> func_13;

		[CompilerGenerated]
		private static Func<PointTool, double> func_14;

		[CompilerGenerated]
		private static Func<PointTool, double> func_15;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_16;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_17;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_18;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_19;

		[CompilerGenerated]
		private sealed class Class44
		{
			public bool method_0(DrawObjectBase drawObjectBase_1)
			{
				return drawObjectBase_1 != this.drawObjectBase_0 && (drawObjectBase_1.GetType() == typeof(LineTool) || drawObjectBase_1.GetType() == typeof(LineCellTool));
			}

			public DrawObjectBase drawObjectBase_0;
		}
	}
}
