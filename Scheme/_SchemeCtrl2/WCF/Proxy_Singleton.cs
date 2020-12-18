using System;
using System.Drawing;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;

namespace SchemeCtrl2.WCF
{
	public sealed class Proxy_Singleton : ISchemeCallback
	{
		public event Proxy_Singleton.ProxyEventHandler ProxyEvent
		{
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

		public void ReceiveObjectOnLineOnChange(int idBase, bool bool_0)
		{
			this.OnProxyCallBackEvent(new ProxyCallBackEventArgs
			{
				idObj = idBase,
				eventType = (bool_0 ? SchemeEventType.SwitchOn : SchemeEventType.SwitchOff)
			});
		}

		public void ReceiveStateOnLine(int idBase, int idRelation, int numBranch, double delta, int typeState, bool bool_0, int idLineState)
		{
			this.OnProxyCallBackEvent(new ProxyCallBackEventArgs
			{
				idObj = idBase,
				eventType = (bool_0 ? SchemeEventType.StateAdd : SchemeEventType.StateDel),
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
			this.OnProxyCallBackEvent(proxyCallBackEventArgs);
		}

		public void UserEnter(string clientID)
		{
		}

		public void UserLeave(string clientID)
		{
		}

		public void Connect(string string_0)
		{
			InstanceContext callbackInstance = new InstanceContext(this);
			this.schemeProxy_0 = new SchemeProxy(callbackInstance);
			this.schemeProxy_0.BeginJoin(string_0, new AsyncCallback(this.method_0), null);
		}

		public void Connect(string string_0, Binding binding, EndpointAddress remoteAddress)
		{
			InstanceContext callbackInstance = new InstanceContext(this);
			this.schemeProxy_0 = new SchemeProxy(callbackInstance, binding, remoteAddress);
			this.schemeProxy_0.BeginJoin(string_0, new AsyncCallback(this.method_0), null);
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

		private void OnProxyCallBackEvent(ProxyCallBackEventArgs proxyCallBackEventArgs_0)
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
			Proxy_Singleton result;
			lock (Proxy_Singleton.object_0)
			{
				if (Proxy_Singleton.proxy_Singleton_0 == null)
				{
					Proxy_Singleton.proxy_Singleton_0 = new Proxy_Singleton();
				}
				result = Proxy_Singleton.proxy_Singleton_0;
			}
			return result;
		}

		public void ObjectOnLineOnChange(int idBase, bool bool_0)
		{
			if (this.schemeProxy_0 != null)
			{
				this.schemeProxy_0.ObjectOnLineOnChange(idBase, bool_0);
			}
		}

		public void StateOnLine(int idBase, int idRelation, int numBranch, double delta, int typeState, bool bool_0, string string_0, int idLineState)
		{
			if (this.schemeProxy_0 != null)
			{
				this.schemeProxy_0.StateOnLine(idBase, idRelation, numBranch, delta, typeState, bool_0, string_0, idLineState);
			}
		}

		public void NodeChange(int idBase, int idAction, string text, PointF point, Color color)
		{
			if (this.schemeProxy_0 != null)
			{
				this.schemeProxy_0.NodeChange(idBase, idAction, text, point, color);
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

		private static Proxy_Singleton proxy_Singleton_0 = null;

		private static readonly object object_0 = new object();

		private SchemeProxy schemeProxy_0;

		private Proxy_Singleton.ProxyEventHandler proxyEventHandler_0;

		private Proxy_Singleton.ProxyCallBackEventHandler proxyCallBackEventHandler_0;

		private delegate void Delegate31(string[] string_0);

		private delegate void Delegate32();

		public delegate void ProxyEventHandler(object sender, bool bool_0);

		public delegate void ProxyCallBackEventHandler(object sender, ProxyCallBackEventArgs e);
	}
}
