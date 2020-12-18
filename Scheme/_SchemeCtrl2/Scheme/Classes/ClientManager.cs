using System;
using System.Collections.Generic;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;
using SchemeCtrl2.WCF;

namespace Scheme.Classes
{
	public static class ClientManager
	{
		public static bool ServerStarted
		{
			get
			{
				return ClientManager.bool_0;
			}
			set
			{
				ClientManager.bool_0 = value;
				ClientManager.smethod_0();
			}
		}

		private static void smethod_0()
		{
			if (ClientManager.canvasControl != null)
			{
				foreach (ICanvasLayer canvasLayer in ClientManager.canvasControl.Layers)
				{
					DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
					foreach (DrawObjectBase drawObjectBase in drawingLayer.Objects)
					{
						if (drawObjectBase.GetType() == typeof(RectangleTool))
						{
							RectangleServer rectangleServer = new RectangleServer();
							rectangleServer.Id = drawObjectBase.IdBase;
							rectangleServer.ListPoints.Add(new UnitPoint(((RectangleTool)drawObjectBase).Rectangle.Location));
							rectangleServer.ListPoints.Add(new UnitPoint(((RectangleTool)drawObjectBase).Rectangle.Location + ((RectangleTool)drawObjectBase).Rectangle.Size));
							foreach (DrawObjectBase drawObjectBase2 in drawObjectBase.ChildObjects)
							{
								rectangleServer.ChildrenObjects.Add(drawObjectBase2.IdBase);
							}
							ClientManager.allObj.Add(rectangleServer.Id, rectangleServer);
						}
					}
				}
			}
		}

		public static void DOBMove(int int_0, UnitPoint offset, bool selectedMove)
		{
			if (ClientManager.ServerStarted)
			{
				foreach (ICallBack callBack in ClientManager.list_1)
				{
					callBack.DrawObjectBaseMove(int_0, offset, selectedMove);
				}
			}
		}

		public static void AddClient(ICallBack callBack)
		{
			ClientManager.list_1.Add(callBack);
		}

		public static void ClientListClear()
		{
			ClientManager.list_1.Clear();
		}

		public static void Load()
		{
		}

		private static bool bool_0 = false;

		public static info[] aInfo = new info[100000];

		public static List<info> linfo = new List<info>();

		public static List<string> list_0 = new List<string>();

		private static List<ICallBack> list_1 = new List<ICallBack>();

		public static CanvasControl canvasControl;

		public static Dictionary<int, RectangleServer> allObj = new Dictionary<int, RectangleServer>();
	}
}
