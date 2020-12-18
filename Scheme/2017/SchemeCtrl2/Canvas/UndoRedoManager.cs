using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using DataSql;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;

namespace SchemeCtrl2.Canvas
{
	public class UndoRedoManager
	{
		public UndoRedoManager(CanvasControl canvas)
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			UndoRedoManager.canvasControl_0 = canvas;
			this.CanUndoRedoEvent += this.UndoRedoManager_CanUndoRedoEvent;
		}

		private void UndoRedoManager_CanUndoRedoEvent(UndoRedoManager.TypeAction typeAction_0, bool bool_2)
		{
		}

		private bool method_0()
		{
			return UndoRedoManager.canvasControl_0 != null;
		}

		public event UndoRedoManager.CanUndoRedoEventHandler CanUndoRedoEvent
		{
			[CompilerGenerated]
			add
			{
				UndoRedoManager.CanUndoRedoEventHandler canUndoRedoEventHandler = this.canUndoRedoEventHandler_0;
				UndoRedoManager.CanUndoRedoEventHandler canUndoRedoEventHandler2;
				do
				{
					canUndoRedoEventHandler2 = canUndoRedoEventHandler;
					UndoRedoManager.CanUndoRedoEventHandler value2 = (UndoRedoManager.CanUndoRedoEventHandler)Delegate.Combine(canUndoRedoEventHandler2, value);
					canUndoRedoEventHandler = Interlocked.CompareExchange<UndoRedoManager.CanUndoRedoEventHandler>(ref this.canUndoRedoEventHandler_0, value2, canUndoRedoEventHandler2);
				}
				while (canUndoRedoEventHandler != canUndoRedoEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				UndoRedoManager.CanUndoRedoEventHandler canUndoRedoEventHandler = this.canUndoRedoEventHandler_0;
				UndoRedoManager.CanUndoRedoEventHandler canUndoRedoEventHandler2;
				do
				{
					canUndoRedoEventHandler2 = canUndoRedoEventHandler;
					UndoRedoManager.CanUndoRedoEventHandler value2 = (UndoRedoManager.CanUndoRedoEventHandler)Delegate.Remove(canUndoRedoEventHandler2, value);
					canUndoRedoEventHandler = Interlocked.CompareExchange<UndoRedoManager.CanUndoRedoEventHandler>(ref this.canUndoRedoEventHandler_0, value2, canUndoRedoEventHandler2);
				}
				while (canUndoRedoEventHandler != canUndoRedoEventHandler2);
			}
		}

		public bool SaveChanges
		{
			get
			{
				return UndoRedoManager.bool_0;
			}
			set
			{
				UndoRedoManager.bool_0 = value;
			}
		}

		public void HappenedChange(DrawObjectBase drawObjectBase, string nameOfProperty, object oldValue)
		{
			if (!this.method_0())
			{
				throw new Exception("UndoRedoManager don`t initialized");
			}
			if (UndoRedoManager.bool_0)
			{
				if (this.CanRedo() && UndoRedoManager.bool_1)
				{
					UndoRedoManager.stack_1.Clear();
					this.canUndoRedoEventHandler_0(UndoRedoManager.TypeAction.Redo, this.CanRedo());
				}
				UndoRedoManager.stack_0.Push(new UndoRedoManager.RegistrarOfChanges(drawObjectBase, nameOfProperty, oldValue));
				this.canUndoRedoEventHandler_0(UndoRedoManager.TypeAction.Undo, this.CanUndo());
			}
		}

		public void HappenedChange(UndoRedoManager.RegistrarOfChanges changes)
		{
			if (!this.method_0())
			{
				throw new Exception("UndoRedoManager don`t initialized");
			}
			if (UndoRedoManager.bool_0)
			{
				if (this.CanRedo() && UndoRedoManager.bool_1)
				{
					UndoRedoManager.stack_1.Clear();
					this.canUndoRedoEventHandler_0(UndoRedoManager.TypeAction.Redo, this.CanRedo());
				}
				UndoRedoManager.stack_0.Push(changes);
				this.canUndoRedoEventHandler_0(UndoRedoManager.TypeAction.Undo, this.CanUndo());
			}
		}

		public bool CanUndo()
		{
			return UndoRedoManager.stack_0.Count > 0;
		}

		public bool CanRedo()
		{
			return UndoRedoManager.stack_1.Count > 0;
		}

		public bool Undo()
		{
			if (!this.method_0())
			{
				throw new Exception("UndoRedoManager don`t initialized");
			}
			if (this.CanUndo())
			{
				UndoRedoManager.bool_0 = false;
				UndoRedoManager.RegistrarOfChanges registrarOfChanges = UndoRedoManager.stack_0.Pop();
				registrarOfChanges.Undo();
				UndoRedoManager.stack_1.Push(registrarOfChanges);
				this.canUndoRedoEventHandler_0(UndoRedoManager.TypeAction.Undo, this.CanUndo());
				this.canUndoRedoEventHandler_0(UndoRedoManager.TypeAction.Redo, this.CanRedo());
				UndoRedoManager.bool_0 = true;
				return true;
			}
			return false;
		}

		public bool Redo()
		{
			if (!this.method_0())
			{
				throw new Exception("UndoRedoManager don`t initialized");
			}
			if (this.CanRedo())
			{
				UndoRedoManager.bool_0 = false;
				UndoRedoManager.bool_1 = false;
				UndoRedoManager.RegistrarOfChanges registrarOfChanges = UndoRedoManager.stack_1.Pop();
				registrarOfChanges.Undo();
				UndoRedoManager.stack_0.Push(registrarOfChanges);
				UndoRedoManager.bool_1 = true;
				UndoRedoManager.bool_0 = true;
				this.canUndoRedoEventHandler_0(UndoRedoManager.TypeAction.Undo, this.CanUndo());
				this.canUndoRedoEventHandler_0(UndoRedoManager.TypeAction.Redo, this.CanRedo());
				return true;
			}
			return false;
		}

		public void ChangeNewValueInLastChange(object newValue)
		{
			if (!this.method_0())
			{
				throw new Exception("UndoRedoManager don`t initialized");
			}
			UndoRedoManager.stack_0.Peek().ChangeNewValue(newValue);
		}

		// Note: this type is marked as 'beforefieldinit'.
		static UndoRedoManager()
		{
			Class90.TDroV38zslI2T();
			UndoRedoManager.stack_0 = new Stack<UndoRedoManager.RegistrarOfChanges>();
			UndoRedoManager.stack_1 = new Stack<UndoRedoManager.RegistrarOfChanges>();
			UndoRedoManager.bool_0 = true;
			UndoRedoManager.bool_1 = true;
		}

		private static Stack<UndoRedoManager.RegistrarOfChanges> stack_0;

		private static Stack<UndoRedoManager.RegistrarOfChanges> stack_1;

		private static bool bool_0;

		private static bool bool_1;

		private static CanvasControl canvasControl_0;

		[CompilerGenerated]
		private UndoRedoManager.CanUndoRedoEventHandler canUndoRedoEventHandler_0;

		public delegate void CanUndoRedoEventHandler(UndoRedoManager.TypeAction rm, bool can);

		public enum TypeAction
		{
			Undo,
			Redo
		}

		public enum ChangesMode
		{
			PropertyChanged,
			Move,
			PointMove,
			AddObject,
			DeleteObject
		}

		public class RegistrarOfChanges
		{
			public RegistrarOfChanges(DrawObjectBase changedObject, string nameChangedProperty, object oldValue)
			{
				Class90.TDroV38zslI2T();
				base..ctor();
				this.changedObject = changedObject;
				this.nameChangedProperty = nameChangedProperty;
				this.oldValue = oldValue;
				this.changesMode_0 = UndoRedoManager.ChangesMode.PropertyChanged;
			}

			public RegistrarOfChanges(DrawObjectBase obj, int numPoint, UnitPoint oldPoint, UnitPoint newpoint)
			{
				Class90.TDroV38zslI2T();
				base..ctor();
				this.changedObject = obj;
				this.int_0 = numPoint;
				this.oldValue = oldPoint;
				this.newValue = newpoint;
				this.changesMode_0 = UndoRedoManager.ChangesMode.PointMove;
			}

			public RegistrarOfChanges(List<DrawObjectBase> changetObjects, UnitPoint oldPoint, UnitPoint newPoint)
			{
				Class90.TDroV38zslI2T();
				base..ctor();
				this.changedObjects = changetObjects;
				this.oldValue = oldPoint;
				this.newValue = newPoint;
				this.changesMode_0 = UndoRedoManager.ChangesMode.Move;
			}

			public RegistrarOfChanges(List<DrawObjectBase> drawObject, UndoRedoManager.ChangesMode cm)
			{
				Class90.TDroV38zslI2T();
				base..ctor();
				this.changesMode_0 = cm;
				this.changedObjects = drawObject;
			}

			public void Undo()
			{
				switch (this.changesMode_0)
				{
				case UndoRedoManager.ChangesMode.PropertyChanged:
					if (this.changedObject.GetType().GetProperty(this.nameChangedProperty).PropertyType == typeof(Amperage) && this.oldValue == null)
					{
						((Amperage)this.changedObject.GetType().GetProperty(this.nameChangedProperty).GetValue(this.changedObject, null)).method_4();
						return;
					}
					this.changedObject.GetType().GetProperty(this.nameChangedProperty).SetValue(this.changedObject, this.oldValue, null);
					return;
				case UndoRedoManager.ChangesMode.Move:
				{
					UnitPoint unitPoint = (UnitPoint)this.newValue;
					UnitPoint unitPoint2 = (UnitPoint)this.oldValue;
					double x = unitPoint2.X - unitPoint.X;
					double y = unitPoint2.Y - unitPoint.Y;
					UnitPoint offset = new UnitPoint(x, y);
					foreach (DrawObjectBase drawObjectBase in this.changedObjects)
					{
						drawObjectBase.Move(offset, true);
					}
					UndoRedoManager.canvasControl_0.DoInvalidate(true);
					object obj = this.oldValue;
					this.oldValue = this.newValue;
					this.newValue = obj;
					return;
				}
				case UndoRedoManager.ChangesMode.PointMove:
				{
					this.changedObject.MoveHandleTo((UnitPoint)this.oldValue, this.int_0);
					UndoRedoManager.canvasControl_0.DoInvalidate(true);
					object obj = this.oldValue;
					this.oldValue = this.newValue;
					this.newValue = obj;
					return;
				}
				case UndoRedoManager.ChangesMode.AddObject:
					UndoRedoManager.canvasControl_0.DeleteObjects(this.changedObjects, UndoRedoManager.canvasControl_0.UseObjectFromDB);
					UndoRedoManager.canvasControl_0.DoInvalidate(true);
					this.changesMode_0 = UndoRedoManager.ChangesMode.DeleteObject;
					return;
				case UndoRedoManager.ChangesMode.DeleteObject:
					foreach (DrawObjectBase drawObjectBase_ in this.changedObjects)
					{
						this.method_0(drawObjectBase_);
					}
					UndoRedoManager.canvasControl_0.DoInvalidate(true);
					this.changesMode_0 = UndoRedoManager.ChangesMode.AddObject;
					return;
				default:
					return;
				}
			}

			private void method_0(DrawObjectBase drawObjectBase_0)
			{
				if (drawObjectBase_0.IdBase == 0)
				{
					return;
				}
				((DrawingLayer)UndoRedoManager.canvasControl_0.ActiveLayer).AddObject(drawObjectBase_0);
				drawObjectBase_0.EndDrawEvent += UndoRedoManager.canvasControl_0.drawObjectBase_0_EndDrawEvent;
				drawObjectBase_0.DrawNewObjectEvent += UndoRedoManager.canvasControl_0.drawObjectBase_0_DrawNewObjectEvent;
				if (drawObjectBase_0.GetType() != typeof(LineTool))
				{
					if (drawObjectBase_0.GetType() != typeof(LineCellTool))
					{
						if (drawObjectBase_0.GetType().BaseType == typeof(ObjectOnLine))
						{
							((ObjectOnLine)drawObjectBase_0).OnChanged += UndoRedoManager.canvasControl_0.method_19;
							goto IL_DD;
						}
						goto IL_DD;
					}
				}
				((LineTool)drawObjectBase_0).StateAdded += UndoRedoManager.canvasControl_0.method_18;
				((LineTool)drawObjectBase_0).StateRemoved += UndoRedoManager.canvasControl_0.method_17;
				IL_DD:
				drawObjectBase_0.ErrorEvent += UndoRedoManager.canvasControl_0.method_16;
				drawObjectBase_0.SelectedChanged += UndoRedoManager.canvasControl_0.method_30;
				SqlDataCommand sqlDataCommand = new SqlDataCommand(UndoRedoManager.canvasControl_0.SqlSettings);
				drawObjectBase_0.Deleted = !sqlDataCommand.UpdateSqlData(UndoRedoManager.canvasControl_0.class22_0.tSchm_ObjList, " set [DELETED] = 0 ", " WHERE [ID] = " + drawObjectBase_0.IdBase.ToString());
				if (drawObjectBase_0.Parent != null && !drawObjectBase_0.Parent.ChildObjects.Contains(drawObjectBase_0))
				{
					DrawObjectBase parent = drawObjectBase_0.Parent;
					drawObjectBase_0.Parent = null;
					drawObjectBase_0.Parent = parent;
				}
				foreach (DrawObjectBase drawObjectBase_ in drawObjectBase_0.ChildObjects)
				{
					this.method_0(drawObjectBase_);
				}
				if (drawObjectBase_0.GetType() != typeof(LineTool))
				{
					if (drawObjectBase_0.GetType() != typeof(LineCellTool))
					{
						if (drawObjectBase_0.GetType() == typeof(LineTool))
						{
							drawObjectBase_0.vmethod_1();
							return;
						}
						return;
					}
				}
				foreach (Branch branch in ((LineTool)drawObjectBase_0).Branches)
				{
					foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
					{
						ObjectOnLine drawObjectBase_2 = (ObjectOnLine)drawObjectBase;
						this.method_0(drawObjectBase_2);
					}
				}
				foreach (PointTool pointTool in ((LineTool)drawObjectBase_0).Ends)
				{
					if (pointTool.Deleted)
					{
						this.method_0(pointTool);
					}
					foreach (Branch branch2 in ((LineTool)drawObjectBase_0).Branches)
					{
						if (branch2.Source == pointTool || branch2.Destination == pointTool)
						{
							pointTool.AddBranch(branch2);
							((LineTool)drawObjectBase_0).AmperageAnalisForNewPoint(pointTool, branch2);
						}
					}
				}
			}

			public void ChangeNewValue(object newValue)
			{
				this.newValue = newValue;
			}

			public DrawObjectBase changedObject;

			public Type typeChangetObject;

			public List<DrawObjectBase> changedObjects;

			public string nameChangedProperty;

			public object oldValue;

			public object newValue;

			private int int_0;

			private UndoRedoManager.ChangesMode changesMode_0;
		}
	}
}
