using System;
using System.Threading;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.WCF
{
	public static class ServerAgent
	{
		public static event ObjectOnLineOnChangeHandler ObjectOnLineOnChangeEvent
		{
			add
			{
				ObjectOnLineOnChangeHandler objectOnLineOnChangeHandler = ServerAgent.objectOnLineOnChangeHandler_0;
				ObjectOnLineOnChangeHandler objectOnLineOnChangeHandler2;
				do
				{
					objectOnLineOnChangeHandler2 = objectOnLineOnChangeHandler;
					ObjectOnLineOnChangeHandler value2 = (ObjectOnLineOnChangeHandler)Delegate.Combine(objectOnLineOnChangeHandler2, value);
					objectOnLineOnChangeHandler = Interlocked.CompareExchange<ObjectOnLineOnChangeHandler>(ref ServerAgent.objectOnLineOnChangeHandler_0, value2, objectOnLineOnChangeHandler2);
				}
				while (objectOnLineOnChangeHandler != objectOnLineOnChangeHandler2);
			}
			remove
			{
				ObjectOnLineOnChangeHandler objectOnLineOnChangeHandler = ServerAgent.objectOnLineOnChangeHandler_0;
				ObjectOnLineOnChangeHandler objectOnLineOnChangeHandler2;
				do
				{
					objectOnLineOnChangeHandler2 = objectOnLineOnChangeHandler;
					ObjectOnLineOnChangeHandler value2 = (ObjectOnLineOnChangeHandler)Delegate.Remove(objectOnLineOnChangeHandler2, value);
					objectOnLineOnChangeHandler = Interlocked.CompareExchange<ObjectOnLineOnChangeHandler>(ref ServerAgent.objectOnLineOnChangeHandler_0, value2, objectOnLineOnChangeHandler2);
				}
				while (objectOnLineOnChangeHandler != objectOnLineOnChangeHandler2);
			}
		}

		public static event LineStateOnChangeHandler LineStateOnChangeEvent
		{
			add
			{
				LineStateOnChangeHandler lineStateOnChangeHandler = ServerAgent.lineStateOnChangeHandler_0;
				LineStateOnChangeHandler lineStateOnChangeHandler2;
				do
				{
					lineStateOnChangeHandler2 = lineStateOnChangeHandler;
					LineStateOnChangeHandler value2 = (LineStateOnChangeHandler)Delegate.Combine(lineStateOnChangeHandler2, value);
					lineStateOnChangeHandler = Interlocked.CompareExchange<LineStateOnChangeHandler>(ref ServerAgent.lineStateOnChangeHandler_0, value2, lineStateOnChangeHandler2);
				}
				while (lineStateOnChangeHandler != lineStateOnChangeHandler2);
			}
			remove
			{
				LineStateOnChangeHandler lineStateOnChangeHandler = ServerAgent.lineStateOnChangeHandler_0;
				LineStateOnChangeHandler lineStateOnChangeHandler2;
				do
				{
					lineStateOnChangeHandler2 = lineStateOnChangeHandler;
					LineStateOnChangeHandler value2 = (LineStateOnChangeHandler)Delegate.Remove(lineStateOnChangeHandler2, value);
					lineStateOnChangeHandler = Interlocked.CompareExchange<LineStateOnChangeHandler>(ref ServerAgent.lineStateOnChangeHandler_0, value2, lineStateOnChangeHandler2);
				}
				while (lineStateOnChangeHandler != lineStateOnChangeHandler2);
			}
		}

		public static event DOBMoveEventHandler DOBMoveEvent
		{
			add
			{
				DOBMoveEventHandler dobmoveEventHandler = ServerAgent.dobmoveEventHandler_0;
				DOBMoveEventHandler dobmoveEventHandler2;
				do
				{
					dobmoveEventHandler2 = dobmoveEventHandler;
					DOBMoveEventHandler value2 = (DOBMoveEventHandler)Delegate.Combine(dobmoveEventHandler2, value);
					dobmoveEventHandler = Interlocked.CompareExchange<DOBMoveEventHandler>(ref ServerAgent.dobmoveEventHandler_0, value2, dobmoveEventHandler2);
				}
				while (dobmoveEventHandler != dobmoveEventHandler2);
			}
			remove
			{
				DOBMoveEventHandler dobmoveEventHandler = ServerAgent.dobmoveEventHandler_0;
				DOBMoveEventHandler dobmoveEventHandler2;
				do
				{
					dobmoveEventHandler2 = dobmoveEventHandler;
					DOBMoveEventHandler value2 = (DOBMoveEventHandler)Delegate.Remove(dobmoveEventHandler2, value);
					dobmoveEventHandler = Interlocked.CompareExchange<DOBMoveEventHandler>(ref ServerAgent.dobmoveEventHandler_0, value2, dobmoveEventHandler2);
				}
				while (dobmoveEventHandler != dobmoveEventHandler2);
			}
		}

		public static void DOBMove(int int_0, UnitPoint offset, bool selectedMove)
		{
			ServerAgent.dobmoveEventHandler_0(int_0, offset, selectedMove);
		}

		public static void ObjectOnLineOnChange(int int_0, bool bool_0)
		{
			if (ServerAgent.objectOnLineOnChangeHandler_0 != null)
			{
				ServerAgent.objectOnLineOnChangeHandler_0(int_0, bool_0);
			}
		}

		public static void LineStateOnChange(int idBase, int idRelation, int numBranch, double delta, States state, bool bool_0)
		{
			if (ServerAgent.lineStateOnChangeHandler_0 != null)
			{
				ServerAgent.lineStateOnChangeHandler_0(idBase, idRelation, numBranch, delta, state, bool_0);
			}
		}

		private static ObjectOnLineOnChangeHandler objectOnLineOnChangeHandler_0;

		private static LineStateOnChangeHandler lineStateOnChangeHandler_0;

		private static DOBMoveEventHandler dobmoveEventHandler_0;
	}
}
