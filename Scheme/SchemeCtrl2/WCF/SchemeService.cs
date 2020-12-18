using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace SchemeCtrl2.WCF
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
	public class SchemeService : ISchemeService
	{
		public static event SchemeService.SchemeEventHandler SchemeEvent
		{
			[CompilerGenerated]
			add
			{
				SchemeService.SchemeEventHandler schemeEventHandler = SchemeService.schemeEventHandler_0;
				SchemeService.SchemeEventHandler schemeEventHandler2;
				do
				{
					schemeEventHandler2 = schemeEventHandler;
					SchemeService.SchemeEventHandler value2 = (SchemeService.SchemeEventHandler)Delegate.Combine(schemeEventHandler2, value);
					schemeEventHandler = Interlocked.CompareExchange<SchemeService.SchemeEventHandler>(ref SchemeService.schemeEventHandler_0, value2, schemeEventHandler2);
				}
				while (schemeEventHandler != schemeEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				SchemeService.SchemeEventHandler schemeEventHandler = SchemeService.schemeEventHandler_0;
				SchemeService.SchemeEventHandler schemeEventHandler2;
				do
				{
					schemeEventHandler2 = schemeEventHandler;
					SchemeService.SchemeEventHandler value2 = (SchemeService.SchemeEventHandler)Delegate.Remove(schemeEventHandler2, value);
					schemeEventHandler = Interlocked.CompareExchange<SchemeService.SchemeEventHandler>(ref SchemeService.schemeEventHandler_0, value2, schemeEventHandler2);
				}
				while (schemeEventHandler != schemeEventHandler2);
			}
		}

		private bool method_0(string string_1)
		{
			using (Dictionary<string, SchemeService.SchemeEventHandler>.KeyCollection.Enumerator enumerator = SchemeService.dictionary_0.Keys.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Equals(string_1, StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}
			}
			return false;
		}

		private SchemeService.SchemeEventHandler method_1(string string_1)
		{
			foreach (string text in SchemeService.dictionary_0.Keys)
			{
				if (text.Equals(string_1, StringComparison.OrdinalIgnoreCase))
				{
					SchemeService.SchemeEventHandler result = null;
					SchemeService.dictionary_0.TryGetValue(text, out result);
					return result;
				}
			}
			return null;
		}

		private string method_2(string string_1)
		{
			foreach (string text in SchemeService.dictionary_0.Keys)
			{
				if (text.Equals(string_1, StringComparison.OrdinalIgnoreCase))
				{
					return text;
				}
			}
			return null;
		}

		public void Join(string clientID)
		{
			bool flag = false;
			this.schemeEventHandler_1 = new SchemeService.SchemeEventHandler(this.method_3);
			object obj = SchemeService.object_0;
			lock (obj)
			{
				if (!this.method_0(clientID) && clientID != null)
				{
					this.string_0 = clientID;
					SchemeService.dictionary_0.Add(clientID, new SchemeService.SchemeEventHandler(this.method_3));
					flag = true;
				}
			}
			if (!flag)
			{
				throw new Exception("No Client Add");
			}
			this.ischemeCallback_0 = OperationContext.Current.GetCallbackChannel<ISchemeCallback>();
			this.method_4(new SchemeEventArgs
			{
				eventType = SchemeEventType.UserEnter,
				clientId = this.string_0
			});
			SchemeService.SchemeEvent += this.schemeEventHandler_1;
		}

		public void Leave()
		{
			if (this.string_0 == null)
			{
				return;
			}
			SchemeService.SchemeEventHandler value = this.method_1(this.string_0);
			object obj = SchemeService.object_0;
			lock (obj)
			{
				SchemeService.dictionary_0.Remove(this.string_0);
			}
			SchemeService.SchemeEvent -= value;
			SchemeEventArgs schemeEventArgs = new SchemeEventArgs();
			schemeEventArgs.eventType = SchemeEventType.UserLeave;
			schemeEventArgs.clientId = this.string_0;
			this.string_0 = null;
			this.method_4(schemeEventArgs);
		}

		public void ObjectOnLineOnChange(int idBase, bool on)
		{
			this.method_4(new SchemeEventArgs
			{
				eventType = (on ? SchemeEventType.SwitchOn : SchemeEventType.SwitchOff),
				clientId = this.string_0,
				idObj = idBase
			});
		}

		public void StateOnLine(int idBase, int idRelation, int numBranch, double delta, int typeState, bool add, string id, int idLineState)
		{
			this.method_4(new SchemeEventArgs
			{
				eventType = (add ? SchemeEventType.StateAdd : SchemeEventType.StateDel),
				clientId = this.string_0,
				idObj = idBase,
				idRelation = idRelation,
				numBranch = numBranch,
				delta = delta,
				typeState = typeState,
				idLineState = idLineState
			});
		}

		private void method_3(object sender, SchemeEventArgs e)
		{
			try
			{
				switch (e.eventType)
				{
				case SchemeEventType.SwitchOn:
					this.ischemeCallback_0.ReceiveObjectOnLineOnChange(e.idObj, true, e.Consumers, e.databaseGuid);
					break;
				case SchemeEventType.SwitchOff:
					this.ischemeCallback_0.ReceiveObjectOnLineOnChange(e.idObj, false, e.Consumers, e.databaseGuid);
					break;
				case SchemeEventType.StateAdd:
					this.ischemeCallback_0.ReceiveStateOnLine(e.idObj, e.idRelation, e.numBranch, e.delta, e.typeState, true, e.idLineState, e.Consumers, e.databaseGuid);
					break;
				case SchemeEventType.StateDel:
					this.ischemeCallback_0.ReceiveStateOnLine(e.idObj, e.idRelation, e.numBranch, e.delta, e.typeState, false, e.idLineState, e.Consumers, e.databaseGuid);
					break;
				case SchemeEventType.UserEnter:
					this.ischemeCallback_0.UserEnter(e.clientId);
					break;
				case SchemeEventType.UserLeave:
					this.ischemeCallback_0.UserLeave(e.clientId);
					break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				this.Leave();
			}
		}

		private void method_4(SchemeEventArgs schemeEventArgs_0)
		{
			SchemeService.SchemeEventHandler schemeEventHandler = SchemeService.schemeEventHandler_0;
			if (schemeEventHandler != null)
			{
				Delegate[] invocationList = schemeEventHandler.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					((SchemeService.SchemeEventHandler)invocationList[i]).BeginInvoke(this, schemeEventArgs_0, new AsyncCallback(this.method_5), null);
				}
			}
		}

		private void method_5(IAsyncResult iasyncResult_0)
		{
			SchemeService.SchemeEventHandler schemeEventHandler = null;
			try
			{
				schemeEventHandler = (SchemeService.SchemeEventHandler)((AsyncResult)iasyncResult_0).AsyncDelegate;
				schemeEventHandler.EndInvoke(iasyncResult_0);
			}
			catch
			{
				SchemeService.SchemeEvent -= schemeEventHandler;
			}
		}

		public SchemeService()
		{
			
			
		}

		// Note: this type is marked as 'beforefieldinit'.
		static SchemeService()
		{
			
			SchemeService.object_0 = new object();
			SchemeService.dictionary_0 = new Dictionary<string, SchemeService.SchemeEventHandler>();
		}

		private static object object_0;

		private ISchemeCallback ischemeCallback_0;

		[CompilerGenerated]
		private static SchemeService.SchemeEventHandler schemeEventHandler_0;

		private SchemeService.SchemeEventHandler schemeEventHandler_1;

		private static Dictionary<string, SchemeService.SchemeEventHandler> dictionary_0;

		private string string_0;

		public delegate void SchemeEventHandler(object sender, SchemeEventArgs e);
	}
}
