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
					foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects)
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

		public static void DOBMove(int id, UnitPoint offset, bool selectedMove)
		{
			if (ClientManager.bool_0)
			{
				foreach (ICallBack callBack in ClientManager.list_0)
				{
					callBack.DrawObjectBaseMove(id, offset, selectedMove);
				}
			}
		}

		public static void AddClient(ICallBack callBack)
		{
			ClientManager.list_0.Add(callBack);
		}

		public static void ClientListClear()
		{
			ClientManager.list_0.Clear();
		}

		public static void Load()
		{
		}

		// Note: this type is marked as 'beforefieldinit'.
		static ClientManager()
		{
			
			ClientManager.bool_0 = false;
			ClientManager.aInfo = new info[100000];
			ClientManager.linfo = new List<info>();
			ClientManager.ss = new List<string>();
			ClientManager.list_0 = new List<ICallBack>();
			ClientManager.allObj = new Dictionary<int, RectangleServer>();
		}

		private static bool bool_0;

		public static info[] aInfo;

		public static List<info> linfo;

		public static List<string> ss;

		private static List<ICallBack> list_0;

		public static CanvasControl canvasControl;

		public static Dictionary<int, RectangleServer> allObj;
	}
}
