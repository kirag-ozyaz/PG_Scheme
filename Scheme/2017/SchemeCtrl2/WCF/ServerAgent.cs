using System;
using System.Runtime.CompilerServices;
using System.Threading;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.WCF
{
	public static class ServerAgent
	{
		public static event ObjectOnLineOnChangeHandler ObjectOnLineOnChangeEvent
		{
			[CompilerGenerated]
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
			[CompilerGenerated]
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
			[CompilerGenerated]
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
			[CompilerGenerated]
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

		public static event GDelegate1 DOBMoveEvent
		{
			[CompilerGenerated]
			add
			{
				GDelegate1 gdelegate = ServerAgent.gdelegate1_0;
				GDelegate1 gdelegate2;
				do
				{
					gdelegate2 = gdelegate;
					GDelegate1 value2 = (GDelegate1)Delegate.Combine(gdelegate2, value);
					gdelegate = Interlocked.CompareExchange<GDelegate1>(ref ServerAgent.gdelegate1_0, value2, gdelegate2);
				}
				while (gdelegate != gdelegate2);
			}
			[CompilerGenerated]
			remove
			{
				GDelegate1 gdelegate = ServerAgent.gdelegate1_0;
				GDelegate1 gdelegate2;
				do
				{
					gdelegate2 = gdelegate;
					GDelegate1 value2 = (GDelegate1)Delegate.Remove(gdelegate2, value);
					gdelegate = Interlocked.CompareExchange<GDelegate1>(ref ServerAgent.gdelegate1_0, value2, gdelegate2);
				}
				while (gdelegate != gdelegate2);
			}
		}

		public static void DOBMove(int id, UnitPoint offset, bool selectedMove)
		{
			ServerAgent.gdelegate1_0(id, offset, selectedMove);
		}

		public static void ObjectOnLineOnChange(int id, bool on)
		{
			if (ServerAgent.objectOnLineOnChangeHandler_0 != null)
			{
				ServerAgent.objectOnLineOnChangeHandler_0(id, on);
			}
		}

		public static void LineStateOnChange(int idBase, int idRelation, int numBranch, double delta, States state, bool add)
		{
			if (ServerAgent.lineStateOnChangeHandler_0 != null)
			{
				ServerAgent.lineStateOnChangeHandler_0(idBase, idRelation, numBranch, delta, state, add);
			}
		}

		[CompilerGenerated]
		private static ObjectOnLineOnChangeHandler objectOnLineOnChangeHandler_0;

		[CompilerGenerated]
		private static LineStateOnChangeHandler lineStateOnChangeHandler_0;

		[CompilerGenerated]
		private static GDelegate1 gdelegate1_0;
	}
}
