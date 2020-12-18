using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;

namespace SchemeCtrl2.WCF
{
	public sealed class Proxy_Singleton : ISchemeCallback
	{
		public event Proxy_Singleton.ProxyEventHandler ProxyEvent
		{
			[CompilerGenerated]
			add
			{
				Proxy_Singleton.ProxyEventHandler proxyEventHandler = this.proxyEventHandler_0;
				Proxy_Singleton.ProxyEventHandler proxyEventHandler2;
				do
				{
					proxyEventHandler2 = proxyEventHandler;
					Proxy_Singleton.ProxyEventHandler value2 = (Proxy_Singleton.ProxyEventHandler)Delegate.Combine(proxyEventHandler2, value);
					proxyEventHandler = Interlocked.CompareExchange<Proxy_Singleton.ProxyEventHandler>(ref this.proxyEventHandler_0, value2, proxyEventHandler2);
				}
				while (proxyEventHandler != proxyEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				Proxy_Singleton.ProxyEventHandler proxyEventHandler = this.proxyEventHandler_0;
				Proxy_Singleton.ProxyEventHandler proxyEventHandler2;
				do
				{
					proxyEventHandler2 = proxyEventHandler;
					Proxy_Singleton.ProxyEventHandler value2 = (Proxy_Singleton.ProxyEventHandler)Delegate.Remove(proxyEventHandler2, value);
					proxyEventHandler = Interlocked.CompareExchange<Proxy_Singleton.ProxyEventHandler>(ref this.proxyEventHandler_0, value2, proxyEventHandler2);
				}
				while (proxyEventHandler != proxyEventHandler2);
			}
		}

		public event Proxy_Singleton.ProxyCallBackEventHandler ProxyCallBackEvent
		{
			[CompilerGenerated]
			add
			{
				Proxy_Singleton.ProxyCallBackEventHandler proxyCallBackEventHandler = this.proxyCallBackEventHandler_0;
				Proxy_Singleton.ProxyCallBackEventHandler proxyCallBackEventHandler2;
				do
				{
					proxyCallBackEventHandler2 = proxyCallBackEventHandler;
					Proxy_Singleton.ProxyCallBackEventHandler value2 = (Proxy_Singleton.ProxyCallBackEventHandler)Delegate.Combine(proxyCallBackEventHandler2, value);
					proxyCallBackEventHandler = Interlocked.CompareExchange<Proxy_Singleton.ProxyCallBackEventHandler>(ref this.proxyCallBackEventHandler_0, value2, proxyCallBackEventHandler2);
				}
				while (proxyCallBackEventHandler != proxyCallBackEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				Proxy_Singleton.ProxyCallBackEventHandler proxyCallBackEventHandler = this.proxyCallBackEventHandler_0;
				Proxy_Singleton.ProxyCallBackEventHandler proxyCallBackEventHandler2;
				do
				{
					proxyCallBackEventHandler2 = proxyCallBackEventHandler;
					Proxy_Singleton.ProxyCallBackEventHandler value2 = (Proxy_Singleton.ProxyCallBackEventHandler)Delegate.Remove(proxyCallBackEventHandler2, value);
					proxyCallBackEventHandler = Interlocked.CompareExchange<Proxy_Singleton.ProxyCallBackEventHandler>(ref this.proxyCallBackEventHandler_0, value2, proxyCallBackEventHandler2);
				}
				while (proxyCallBackEventHandler != proxyCallBackEventHandler2);
			}
		}

		private Proxy_Singleton()
		{
			
			
		}

		public void ReceiveObjectOnLineOnChange(int idBase, bool on, int[] idConsumers, Guid databaseGuid)
		{
			this.method_2(new ProxyCallBackEventArgs
			{
				idObj = idBase,
				eventType = (on ? SchemeEventType.SwitchOn : SchemeEventType.SwitchOff)
			});
		}

		public void ReceiveStateOnLine(int idBase, int idRelation, int numBranch, double delta, int typeState, bool add, int idLineState, int[] idConsumers, Guid databaseGuid)
		{
			this.method_2(new ProxyCallBackEventArgs
			{
				idObj = idBase,
				eventType = (add ? SchemeEventType.StateAdd : SchemeEventType.StateDel),
				idRelation = idRelation,
				numBranch = numBranch,
				delta = delta,
				typeState = typeState,
				idLineState = idLineState
			});
		}

		public void ReceiveNodeChange(int idBase, int idAction, string text, PointF point, Color color)
		{
			ProxyCallBackEventArgs proxyCallBackEventArgs = new ProxyCallBackEventArgs();
			proxyCallBackEventArgs.idObj = idBase;
			switch (idAction)
			{
			case 1:
				proxyCallBackEventArgs.eventType = SchemeEventType.NodeAdd;
				break;
			case 2:
				proxyCallBackEventArgs.eventType = SchemeEventType.NodeDel;
				break;
			case 3:
				proxyCallBackEventArgs.eventType = SchemeEventType.NodeChange;
				break;
			}
			proxyCallBackEventArgs.text = text;
			proxyCallBackEventArgs.point = point;
			proxyCallBackEventArgs.color = color;
			this.method_2(proxyCallBackEventArgs);
		}

		public void UserEnter(string clientID)
		{
		}

		public void UserLeave(string clientID)
		{
		}

		public void Connect(string p, Guid databaseGuid)
		{
			InstanceContext callbackInstance = new InstanceContext(this);
			this.schemeProxy_0 = new SchemeProxy(callbackInstance);
			this.schemeProxy_0.BeginJoin(p, databaseGuid, new AsyncCallback(this.method_0), null);
		}

		public void Connect(string p, Binding binding, EndpointAddress remoteAddress, Guid databaseGuid)
		{
			InstanceContext callbackInstance = new InstanceContext(this);
			this.schemeProxy_0 = new SchemeProxy(callbackInstance, binding, remoteAddress);
			this.schemeProxy_0.BeginJoin(p, databaseGuid, new AsyncCallback(this.method_0), null);
		}

		public bool Check()
		{
			return this.schemeProxy_0.Check();
		}

		private void method_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				bool bool_ = this.schemeProxy_0.EndJoin(iasyncResult_0);
				this.method_1(bool_);
			}
			catch
			{
				this.method_1(false);
			}
		}

		private void method_1(bool bool_0)
		{
			this.method_3(bool_0);
		}

		private void method_2(ProxyCallBackEventArgs proxyCallBackEventArgs_0)
		{
			if (this.proxyCallBackEventHandler_0 != null)
			{
				this.proxyCallBackEventHandler_0(this, proxyCallBackEventArgs_0);
			}
		}

		private void method_3(bool bool_0)
		{
			if (this.proxyEventHandler_0 != null)
			{
				this.proxyEventHandler_0(this, bool_0);
			}
		}

		public static Proxy_Singleton GetInstance()
		{
			object obj = Proxy_Singleton.object_0;
			Proxy_Singleton result;
			lock (obj)
			{
				if (Proxy_Singleton.proxy_Singleton_0 == null)
				{
					Proxy_Singleton.proxy_Singleton_0 = new Proxy_Singleton();
				}
				result = Proxy_Singleton.proxy_Singleton_0;
			}
			return result;
		}

		public void ObjectOnLineOnChange(int idBase, bool on, Guid databaseGuid)
		{
			if (this.schemeProxy_0 != null)
			{
				this.schemeProxy_0.ObjectOnLineOnChange(idBase, on, databaseGuid);
			}
		}

		public void StateOnLine(int idBase, int idRelation, int numBranch, double delta, int typeState, bool add, string id, int idLineState, Guid databaseGuid)
		{
			if (this.schemeProxy_0 != null)
			{
				this.schemeProxy_0.StateOnLine(idBase, idRelation, numBranch, delta, typeState, add, id, idLineState, databaseGuid);
			}
		}

		public void NodeChange(int idBase, int idAction, string text, PointF point, Color color, Guid databaseGuid)
		{
			if (this.schemeProxy_0 != null)
			{
				this.schemeProxy_0.NodeChange(idBase, idAction, text, point, color, databaseGuid);
			}
		}

		public void ExitChatSession()
		{
			if (this.schemeProxy_0 != null)
			{
				try
				{
					this.schemeProxy_0.Leave();
				}
				catch
				{
				}
				finally
				{
					this.AbortProxy();
				}
			}
		}

		public void AbortProxy()
		{
			if (this.schemeProxy_0 != null)
			{
				this.schemeProxy_0.Abort();
				this.schemeProxy_0.Close();
				this.schemeProxy_0 = null;
			}
		}

		public void ConsumersStateChanged(int[] cunsumersId, bool on)
		{
		}

		// Note: this type is marked as 'beforefieldinit'.
		static Proxy_Singleton()
		{
			
			Proxy_Singleton.proxy_Singleton_0 = null;
			Proxy_Singleton.object_0 = new object();
		}

		private static Proxy_Singleton proxy_Singleton_0;

		private static readonly object object_0;

		private SchemeProxy schemeProxy_0;

		[CompilerGenerated]
		private Proxy_Singleton.ProxyEventHandler proxyEventHandler_0;

		[CompilerGenerated]
		private Proxy_Singleton.ProxyCallBackEventHandler proxyCallBackEventHandler_0;

		private delegate void Delegate0(string[] list);

		private delegate void Delegate1();

		public delegate void ProxyEventHandler(object sender, bool e);

		public delegate void ProxyCallBackEventHandler(object sender, ProxyCallBackEventArgs e);
	}
}
