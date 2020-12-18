using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using DataSql;
using FormLbr;
using FormLbr.Classes;
using netDxf;
using Passport.Classes;
using Passport.Controls;
using Passport.Forms;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas.Forms;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.DrawTool.FormsObj;
using SchemeCtrl2.Layers;
using SchemeCtrl2.Properties;
using SchemeCtrl2.SnapPoint;
using SchemeCtrl2.WCF;
using SchemeModel;
using SchemeModel.Calculations;
using Telemetry;
using WinFormsUI.Docking;

namespace SchemeCtrl2.Canvas
{
	public class CanvasControl : UserControl, IDisposable
	{
		[Description("Происходит после добавления объекта на канвас")]
		[Category("Objects")]
		public event DrawObjectEventHandler ObjectsAdded
		{
			[CompilerGenerated]
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_0;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_0, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_0;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_0, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Description("Происходит после удаления объекта из канваса")]
		[Category("Objects")]
		public event DrawObjectEventHandler ObjectsRemoved
		{
			[CompilerGenerated]
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_1;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_1, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_1;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_1, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Description("Происходит после измениния размеров объектов")]
		[Category("Objects")]
		public event DrawObjectEventHandler ObjectsResized
		{
			[CompilerGenerated]
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_2;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_2, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_2;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_2, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит при клике по объекту")]
		public event DrawObjectEventHandler ObjectClicked
		{
			[CompilerGenerated]
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_3;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_3, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_3;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_3, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Description("Происходит после смены выделенного объекта")]
		[Category("Objects")]
		public event DrawObjectEventHandler SelectedObjectChanged
		{
			[CompilerGenerated]
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_4;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_4, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_4;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_4, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Description("Происходит при движении выделенного объекта")]
		[Category("Objects")]
		public event DrawObjectEventHandler SelectedObjectMoved
		{
			[CompilerGenerated]
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_5;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_5, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_5;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_5, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Description("Происходит при редактировании выделенного объекта")]
		[Category("Objects")]
		public event DrawObjectEventHandler SelectedObjectEdited
		{
			[CompilerGenerated]
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_6;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_6, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_6;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_6, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит при завершении рисования объекта")]
		public event DrawObjectEventHandler DrawingCompleted
		{
			[CompilerGenerated]
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_7;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_7, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_7;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_7, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Description("Происходит при показе контестного меню")]
		[Category("Objects")]
		public event ShowContextMenuCanvasEventHandler ShowContextMenuCanvasEvent
		{
			[CompilerGenerated]
			add
			{
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler = this.showContextMenuCanvasEventHandler_0;
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler2;
				do
				{
					showContextMenuCanvasEventHandler2 = showContextMenuCanvasEventHandler;
					ShowContextMenuCanvasEventHandler value2 = (ShowContextMenuCanvasEventHandler)Delegate.Combine(showContextMenuCanvasEventHandler2, value);
					showContextMenuCanvasEventHandler = Interlocked.CompareExchange<ShowContextMenuCanvasEventHandler>(ref this.showContextMenuCanvasEventHandler_0, value2, showContextMenuCanvasEventHandler2);
				}
				while (showContextMenuCanvasEventHandler != showContextMenuCanvasEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler = this.showContextMenuCanvasEventHandler_0;
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler2;
				do
				{
					showContextMenuCanvasEventHandler2 = showContextMenuCanvasEventHandler;
					ShowContextMenuCanvasEventHandler value2 = (ShowContextMenuCanvasEventHandler)Delegate.Remove(showContextMenuCanvasEventHandler2, value);
					showContextMenuCanvasEventHandler = Interlocked.CompareExchange<ShowContextMenuCanvasEventHandler>(ref this.showContextMenuCanvasEventHandler_0, value2, showContextMenuCanvasEventHandler2);
				}
				while (showContextMenuCanvasEventHandler != showContextMenuCanvasEventHandler2);
			}
		}

		[Description("Происходит при закрытии контестного меню")]
		[Category("Objects")]
		public event ShowContextMenuCanvasEventHandler HideContextMenuCanvasEvent
		{
			[CompilerGenerated]
			add
			{
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler = this.showContextMenuCanvasEventHandler_1;
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler2;
				do
				{
					showContextMenuCanvasEventHandler2 = showContextMenuCanvasEventHandler;
					ShowContextMenuCanvasEventHandler value2 = (ShowContextMenuCanvasEventHandler)Delegate.Combine(showContextMenuCanvasEventHandler2, value);
					showContextMenuCanvasEventHandler = Interlocked.CompareExchange<ShowContextMenuCanvasEventHandler>(ref this.showContextMenuCanvasEventHandler_1, value2, showContextMenuCanvasEventHandler2);
				}
				while (showContextMenuCanvasEventHandler != showContextMenuCanvasEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler = this.showContextMenuCanvasEventHandler_1;
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler2;
				do
				{
					showContextMenuCanvasEventHandler2 = showContextMenuCanvasEventHandler;
					ShowContextMenuCanvasEventHandler value2 = (ShowContextMenuCanvasEventHandler)Delegate.Remove(showContextMenuCanvasEventHandler2, value);
					showContextMenuCanvasEventHandler = Interlocked.CompareExchange<ShowContextMenuCanvasEventHandler>(ref this.showContextMenuCanvasEventHandler_1, value2, showContextMenuCanvasEventHandler2);
				}
				while (showContextMenuCanvasEventHandler != showContextMenuCanvasEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит после добавления объектов в мерцающие объекты на канвас")]
		public event DrawObjectEventHandler FlashObjectsAdded
		{
			[CompilerGenerated]
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_8;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_8, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_8;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_8, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит после удаления объектов с мерцающих объектов")]
		public event DrawObjectEventHandler FlashObjectsRemoved
		{
			[CompilerGenerated]
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_9;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_9, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_9;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_9, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		public event EventHandler SaveProcessChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		public event CanvasMessageEventHandler CanvasMessage
		{
			[CompilerGenerated]
			add
			{
				CanvasMessageEventHandler canvasMessageEventHandler = this.canvasMessageEventHandler_0;
				CanvasMessageEventHandler canvasMessageEventHandler2;
				do
				{
					canvasMessageEventHandler2 = canvasMessageEventHandler;
					CanvasMessageEventHandler value2 = (CanvasMessageEventHandler)Delegate.Combine(canvasMessageEventHandler2, value);
					canvasMessageEventHandler = Interlocked.CompareExchange<CanvasMessageEventHandler>(ref this.canvasMessageEventHandler_0, value2, canvasMessageEventHandler2);
				}
				while (canvasMessageEventHandler != canvasMessageEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				CanvasMessageEventHandler canvasMessageEventHandler = this.canvasMessageEventHandler_0;
				CanvasMessageEventHandler canvasMessageEventHandler2;
				do
				{
					canvasMessageEventHandler2 = canvasMessageEventHandler;
					CanvasMessageEventHandler value2 = (CanvasMessageEventHandler)Delegate.Remove(canvasMessageEventHandler2, value);
					canvasMessageEventHandler = Interlocked.CompareExchange<CanvasMessageEventHandler>(ref this.canvasMessageEventHandler_0, value2, canvasMessageEventHandler2);
				}
				while (canvasMessageEventHandler != canvasMessageEventHandler2);
			}
		}

		[Description("Происходит при добавлении статуса линии")]
		[Category("Objects")]
		public event LineToolEventHandler StateAdded
		{
			[CompilerGenerated]
			add
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_0;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Combine(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_0, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_0;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Remove(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_0, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
		}

		[Description("Происходит при удалении статуса линии")]
		[Category("Objects")]
		public event LineToolEventHandler StateRemoved
		{
			[CompilerGenerated]
			add
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_1;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Combine(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_1, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_1;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Remove(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_1, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
		}

		[Description("Происходит при включении/выключении объекта на линии")]
		[Category("Objects")]
		public event EventHandler ObjectOnLinePropertyOnCanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		[Category("Схема")]
		[Description("Происходит при изменении режима схемы")]
		public event EventHandler CanvasModeChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		[Description("Происходит при изменении уровня доступа схемы")]
		[Category("Схема")]
		public event EventHandler CanvasMaxModeChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		public eCanvasEditingMode MaxMode
		{
			get
			{
				return this.eCanvasEditingMode_1;
			}
			set
			{
				if (value == this.eCanvasEditingMode_1)
				{
					return;
				}
				this.eCanvasEditingMode_1 = value;
				if (this.Mode > this.eCanvasEditingMode_1)
				{
					this.Mode = this.eCanvasEditingMode_1;
				}
				if (this.eventHandler_3 != null)
				{
					this.eventHandler_3(this, new EventArgs());
				}
			}
		}

		public eCommandType CanvasCommandType
		{
			get
			{
				return this.eCommandType_0;
			}
		}

		public bool LineInformationVisible { get; set; }

		public bool TelemetryLabelVisible { get; set; }

		public bool MeasurementLabelVisible { get; set; }

		public EndpointAddress Endpoint
		{
			get
			{
				return this.endpointAddress_0;
			}
			set
			{
				if (this.endpointAddress_0 != null)
				{
					this.method_0();
				}
				this.endpointAddress_0 = value;
				if (this.endpointAddress_0 != null)
				{
					this.method_1();
				}
			}
		}

		private void method_0()
		{
			IPAddress ipaddress = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];
			this.proxy_Singleton_0.ExitChatSession();
			this.method_2(false);
		}

		private void method_1()
		{
			try
			{
				IPAddress ipaddress = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];
				NetTcpBinding netTcpBinding = new NetTcpBinding(SecurityMode.None);
				netTcpBinding.Security.Mode = SecurityMode.None;
				netTcpBinding.SendTimeout = TimeSpan.FromSeconds(10.0);
				netTcpBinding.ReliableSession.Enabled = true;
				this.proxy_Singleton_0.ProxyEvent -= this.proxy_Singleton_0_ProxyEvent;
				this.proxy_Singleton_0.ProxyCallBackEvent -= this.proxy_Singleton_0_ProxyCallBackEvent;
				this.proxy_Singleton_0.ProxyEvent += this.proxy_Singleton_0_ProxyEvent;
				this.proxy_Singleton_0.Connect(ipaddress.ToString() + Environment.UserName + "_" + Process.GetCurrentProcess().Id.ToString(), netTcpBinding, this.endpointAddress_0, Class18.smethod_3());
				this.proxy_Singleton_0.ProxyCallBackEvent += this.proxy_Singleton_0_ProxyCallBackEvent;
			}
			catch
			{
			}
		}

		private void proxy_Singleton_0_ProxyEvent(object object_0, bool bool_12)
		{
			this.Connected = bool_12;
			if (!this.timer_0.Enabled)
			{
				this.method_2(true);
			}
		}

		private void method_2(bool bool_12)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new Action<bool>(this.method_91), new object[]
				{
					bool_12
				});
				return;
			}
			this.method_3(bool_12);
		}

		private void method_3(bool bool_12)
		{
			this.timer_0.Enabled = bool_12;
		}

		private void proxy_Singleton_0_ProxyCallBackEvent(object sender, ProxyCallBackEventArgs e)
		{
			switch (e.eventType)
			{
			case SchemeEventType.SwitchOn:
				this.method_6(e.idObj, true);
				return;
			case SchemeEventType.SwitchOff:
				this.method_6(e.idObj, false);
				return;
			case SchemeEventType.StateAdd:
				this.method_5(e.idObj, e.idRelation, e.numBranch, e.delta, e.typeState, true, e.idLineState);
				return;
			case SchemeEventType.StateDel:
				this.method_5(e.idObj, e.idRelation, e.numBranch, e.delta, e.typeState, false, e.idLineState);
				return;
			case SchemeEventType.UserEnter:
			case SchemeEventType.UserLeave:
				break;
			case SchemeEventType.NodeAdd:
				this.method_4(e.idObj, 1, e.text, e.point, e.color);
				return;
			case SchemeEventType.NodeDel:
				this.method_4(e.idObj, 2, e.text, e.point, e.color);
				break;
			case SchemeEventType.NodeChange:
				this.method_4(e.idObj, 3, e.text, e.point, e.color);
				return;
			default:
				return;
			}
		}

		private void method_4(int int_9, int int_10, string string_5, PointF pointF_3, Color color_0)
		{
			DrawObjectBase drawObjectBase = this.FindObjectById(int_9);
			switch (int_10)
			{
			case 1:
			{
				if (drawObjectBase != null && drawObjectBase is NodeTool)
				{
					return;
				}
				NodeTool nodeTool = new NodeTool();
				nodeTool.IdBase = int_9;
				nodeTool.Text = string_5;
				nodeTool.Location = new UnitPoint(pointF_3);
				if (color_0 != Color.Empty)
				{
					nodeTool.UseSettingColor = false;
					nodeTool.Color = color_0;
				}
				this.AddObject(this.ActiveLayer, nodeTool);
				this.DoInvalidate(true);
				return;
			}
			case 2:
				if (drawObjectBase is NodeTool)
				{
					this.DeleteObjects(new List<DrawObjectBase>
					{
						drawObjectBase
					}, false);
				}
				this.DoInvalidate(true);
				return;
			case 3:
				if (drawObjectBase is NodeTool)
				{
					((NodeTool)drawObjectBase).Text = string_5;
					((NodeTool)drawObjectBase).Location = new UnitPoint(pointF_3);
					if (color_0 != Color.Empty)
					{
						((NodeTool)drawObjectBase).UseSettingColor = false;
						((NodeTool)drawObjectBase).Color = color_0;
					}
				}
				this.DoInvalidate(true);
				return;
			default:
				return;
			}
		}

		private void method_5(int int_9, int int_10, int int_11, double double_0, int int_12, bool bool_12, int int_13)
		{
			DrawObjectBase drawObjectBase = this.FindObjectById(int_9);
			if (drawObjectBase != null && drawObjectBase is LineTool)
			{
				Branch branch = ((LineTool)drawObjectBase).FindBranch(int_10, int_11);
				if (branch != null)
				{
					if (bool_12)
					{
						LineToolState lineToolState = new LineToolState(branch, double_0, (States)int_12);
						((LineTool)drawObjectBase).AddState(lineToolState);
						lineToolState.Mapping.IdBase = int_13;
					}
					else
					{
						List<LineToolState> list = new List<LineToolState>();
						foreach (DrawObjectBase drawObjectBase2 in branch.ChildObjects)
						{
							if (drawObjectBase2 is ObjectOnLine && ((ObjectOnLine)drawObjectBase2).MappingState)
							{
								list.Add(((ObjectOnLine)drawObjectBase2).State);
							}
						}
						LineToolState lineToolState2 = null;
						double num = 1.0;
						if (int_13 > 0)
						{
							using (List<LineToolState>.Enumerator enumerator2 = list.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									LineToolState lineToolState3 = enumerator2.Current;
									if (lineToolState3.Mapping.IdBase == int_13)
									{
										lineToolState2 = lineToolState3;
									}
								}
								goto IL_171;
							}
						}
						foreach (LineToolState lineToolState4 in list)
						{
							if (Math.Abs(lineToolState4.Mapping.Delta - double_0) < num)
							{
								num = Math.Abs(lineToolState4.Mapping.Delta - double_0);
								lineToolState2 = lineToolState4;
							}
						}
						IL_171:
						if (lineToolState2 != null)
						{
							lineToolState2.Remove(false);
						}
					}
				}
				this.DoInvalidate(true);
			}
		}

		private void method_6(int int_9, bool bool_12)
		{
			DrawObjectBase drawObjectBase = this.FindObjectById(int_9);
			if (drawObjectBase != null && drawObjectBase is ObjectOnLine)
			{
				((ObjectOnLine)drawObjectBase).On = bool_12;
				this.DoInvalidate(true);
			}
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			try
			{
				if (this.Connected)
				{
					this.proxy_Singleton_0.Check();
				}
				else
				{
					this.method_1();
				}
			}
			catch
			{
				this.Connected = false;
				this.method_1();
			}
		}

		private void method_7(object sender, EventArgs e)
		{
			MessageBox.Show("Упало соединение\n" + e.ToString());
		}

		public bool Connected
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				this.bool_4 = value;
				if (this.bool_4)
				{
					if (this.imageList_0.Images.Count > 0)
					{
						this.toolStripStatusLabelConnected.Image = this.imageList_0.Images[0];
						return;
					}
				}
				else if (this.imageList_0.Images.Count > 1)
				{
					this.toolStripStatusLabelConnected.Image = this.imageList_0.Images[1];
				}
			}
		}

		public int WorkerCounter
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
				this.eventHandler_0(this.int_2, new EventArgs());
			}
		}

		private void method_8(bool bool_12)
		{
			if (base.InvokeRequired)
			{
				CanvasControl.Delegate31 method = new CanvasControl.Delegate31(this.method_8);
				base.Invoke(method, new object[]
				{
					bool_12
				});
				return;
			}
			this.toolProgressBarSave.Visible = bool_12;
			this.labelProgressBar.Visible = bool_12;
		}

		public bool VisibleSaveProgressBar
		{
			get
			{
				return this.toolProgressBarSave.Visible;
			}
			set
			{
				this.method_8(value);
			}
		}

		public Graphics Graphics
		{
			get
			{
				return this.graphics_0;
			}
			set
			{
				this.graphics_0 = value;
			}
		}

		public ICanvasLayer BackgroundLayer
		{
			get
			{
				return this.backgroundLayer_0;
			}
		}

		public ICanvasLayer GridLayer
		{
			get
			{
				return this.gridLayer_0;
			}
		}

		[XmlArray]
		[XmlArrayItem(typeof(ICanvasLayer))]
		public IEnumerable<ICanvasLayer> Layers
		{
			get
			{
				return this.list_0;
			}
		}

		public ICanvasLayer ActiveLayer
		{
			get
			{
				if (this.icanvasLayer_0 == null && this.list_0.Count > 0)
				{
					this.icanvasLayer_0 = this.list_0[0];
				}
				return this.icanvasLayer_0;
			}
			set
			{
				this.icanvasLayer_0 = value;
			}
		}

		public float Zoom
		{
			get
			{
				return this.float_0;
			}
			set
			{
				this.float_0 = value;
				if (this.float_0 < 0.001f)
				{
					this.float_0 = 0.001f;
				}
				if (this.float_0 > 100f)
				{
					this.float_0 = 100f;
				}
				this.toolBtnZoom.Text = Math.Round((double)(this.float_0 * 100f), 2).ToString() + "%";
			}
		}

		[Browsable(false)]
		[XmlArrayItem(typeof(DrawObjectBase))]
		public IEnumerable<DrawObjectBase> SelectedObjects
		{
			get
			{
				return this.list_1;
			}
		}

		[XmlArrayItem(typeof(DrawObjectBase))]
		[Browsable(false)]
		public IEnumerable<DrawObjectBase> CopiedObjects
		{
			get
			{
				return this.list_7;
			}
		}

		[Browsable(false)]
		[XmlArrayItem(typeof(DrawObjectBase))]
		public IEnumerable<DrawObjectBase> FlashingObjects
		{
			get
			{
				return this.list_3;
			}
		}

		[Browsable(false)]
		public int SelectedCount
		{
			get
			{
				return this.list_1.Count;
			}
		}

		public eMetric CurrentMetric
		{
			get
			{
				return this.eMetric_0;
			}
			set
			{
				this.eMetric_0 = value;
			}
		}

		[Browsable(false)]
		public PointF DeltaPoint
		{
			get
			{
				PointF result = this.pointF_1;
				result.X += this.pointF_2.X;
				result.Y += this.pointF_2.Y;
				return result;
			}
			set
			{
				this.pointF_1 = value;
				this.pointF_2 = new PointF(0f, 0f);
				this.method_46();
			}
		}

		public SQLSettings SqlSettings
		{
			get
			{
				return this.sqlsettings_0;
			}
			set
			{
				this.sqlsettings_0 = value;
				Class18.smethod_2(this.sqlsettings_0);
			}
		}

		public string SchemeName
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		public bool UseObjectFromDB { get; set; }

		public virtual bool StatusStripVisible
		{
			get
			{
				return this.statusStrip.Visible;
			}
			set
			{
				this.statusStrip.Visible = value;
				this.DoInvalidate(true);
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public CanvasSettings Settings
		{
			get
			{
				return this.canvasSettings_0;
			}
			set
			{
				this.canvasSettings_0 = value;
			}
		}

		public eTypeCanvas TypeCanvas
		{
			get
			{
				return this.eTypeCanvas_0;
			}
			set
			{
				if (this.eTypeCanvas_0 == value)
				{
					return;
				}
				this.eTypeCanvas_0 = value;
				switch (this.eTypeCanvas_0)
				{
				case eTypeCanvas.SchemeMain:
					this.MaxMode = eCanvasEditingMode.Edit;
					return;
				case eTypeCanvas.SchemeSecond:
					this.MaxMode = eCanvasEditingMode.Edit;
					return;
				case eTypeCanvas.SchemaClone:
					this.MaxMode = eCanvasEditingMode.Dispatcher;
					return;
				default:
					return;
				}
			}
		}

		public eSimulationMode SimulationMode
		{
			get
			{
				return this.eSimulationMode_0;
			}
			set
			{
				if (this.eSimulationMode_0 == value)
				{
					return;
				}
				switch (this.eSimulationMode_0)
				{
				case eSimulationMode.Training:
					if (this.icanvasLayer_0 != null)
					{
						this.icanvasLayer_0.Objects.Count<DrawObjectBase>();
					}
					break;
				}
				this.eSimulationMode_0 = value;
				switch (this.eSimulationMode_0)
				{
				case eSimulationMode.Online:
					this.MaxMode = eCanvasEditingMode.Edit;
					if (this.icanvasLayer_0 != null && this.icanvasLayer_0.Objects.Count<DrawObjectBase>() != 0)
					{
						this.OffSimulate();
						foreach (DrawObjectBase drawObjectBase in (from obj in this.icanvasLayer_0.Objects
						where obj is ObjectOnLine
						select obj).Reverse<DrawObjectBase>())
						{
							((ObjectOnLine)drawObjectBase).NormalSectionModeOn = false;
						}
						this.OnSimulate();
						return;
					}
					break;
				case eSimulationMode.Normal:
					this.MaxMode = eCanvasEditingMode.ReadOnly;
					if (this.icanvasLayer_0 != null && this.icanvasLayer_0.Objects.Count<DrawObjectBase>() != 0)
					{
						this.OffSimulate();
						foreach (DrawObjectBase drawObjectBase2 in (from obj in this.icanvasLayer_0.Objects
						where obj is ObjectOnLine
						select obj).Reverse<DrawObjectBase>())
						{
							((ObjectOnLine)drawObjectBase2).NormalSectionModeOn = true;
						}
						this.OnSimulate();
					}
					break;
				case eSimulationMode.Training:
					this.MaxMode = eCanvasEditingMode.Dispatcher;
					return;
				default:
					return;
				}
			}
		}

		public eCanvasEditingMode Mode
		{
			get
			{
				return this.eCanvasEditingMode_0;
			}
			set
			{
				if (this.eCanvasEditingMode_0 != value && value <= this.MaxMode)
				{
					if (value != eCanvasEditingMode.Edit)
					{
						if (this.Monopoly)
						{
							this.method_53();
						}
						this.eCanvasEditingMode_0 = value;
					}
					else if (this.Monopoly)
					{
						if (this.method_52())
						{
							this.eCanvasEditingMode_0 = value;
						}
					}
					else if (this.TypeCanvas != eTypeCanvas.SchemeMain)
					{
						this.eCanvasEditingMode_0 = value;
					}
					else if (!this.method_51())
					{
						this.eCanvasEditingMode_0 = value;
					}
					if (this.eventHandler_2 != null)
					{
						this.eventHandler_2(this, new EventArgs());
					}
					return;
				}
			}
		}

		public bool Monopoly
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		public bool VisibleCanvasSchemeMap
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				if (value && this.control0_0 == null)
				{
					this.method_43();
				}
				if (!value && this.control0_0 != null)
				{
					this.method_44();
				}
				this.bool_2 = value;
			}
		}

		public IEnumerable<LineToolState> States
		{
			get
			{
				return this.list_4;
			}
		}

		public CanvasControl()
		{
			Class90.TDroV38zslI2T();
			this.int_0 = -1;
			this.proxy_Singleton_0 = Proxy_Singleton.GetInstance();
			this.dictionary_0 = new Dictionary<int, GroupDrawObjectBase>();
			this.list_0 = new List<ICanvasLayer>();
			this.float_0 = 1f;
			this.list_1 = new List<DrawObjectBase>();
			this.list_2 = new List<DrawObjectBase>();
			this.list_3 = new List<DrawObjectBase>();
			this.bool_0 = true;
			this.eMetric_0 = eMetric.sm;
			this.string_0 = string.Empty;
			this.staticRepaint = true;
			this.class1_0 = new Class1();
			this.string_1 = "schema1";
			this.globalPointsList = new List<PointTool>();
			this.eTypeCanvas_0 = eTypeCanvas.SchemeMain;
			this.eSimulationMode_0 = eSimulationMode.Online;
			this.eCanvasEditingMode_0 = eCanvasEditingMode.ReadOnly;
			this.bool_1 = true;
			this.rectangleF_0 = RectangleF.Empty;
			this.list_4 = new List<LineToolState>();
			this.list_5 = new List<DrawObjectBase>();
			this.list_6 = new List<List<DrawObjectBase>>();
			this.list_7 = new List<DrawObjectBase>();
			this.timer_0 = new System.Windows.Forms.Timer();
			this.eCanvasEditingMode_1 = eCanvasEditingMode.Edit;
			this.panelPassport_0 = new PanelPassport();
			this.tFlash = new System.Windows.Forms.Timer();
			this.list_8 = new List<int>();
			this.loadedPoints = new Dictionary<int, PointTool>();
			this.class19_0 = new Class19();
			this.isPrintFrame = true;
			this.int_5 = 1;
			this.int_6 = 1;
			this.enum4_0 = (Enum4)2;
			this.int_8 = 1;
			base..ctor();
			this.timer_0.Interval = 10000;
			this.timer_0.Tick += this.timer_0_Tick;
			CanvasControl.dictionary_1["Rectangle"] = new RectangleTool();
			CanvasControl.dictionary_1["Shina"] = new ShinaTool();
			CanvasControl.dictionary_1["Line"] = new LineTool();
			CanvasControl.dictionary_1["Text"] = new LabelTool();
			this.InitializeComponent();
			this.method_86();
			base.Controls.Add(this.panelPassport_0);
			this.panelPassport_0.Visible = false;
			this.canvasSettings_0 = new CanvasSettings();
			this.backgroundLayer_0 = new BackgroundLayer(this);
			this.gridLayer_0 = new GridLayer(this);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.pointF_0 = PointF.Empty;
			this.pointF_1 = new PointF(0f, 0f);
			this.pointF_2 = PointF.Empty;
			this.SetCenter(new UnitPoint(0.0, 0.0));
			this.method_25();
			this.SaveProcessChanged += this.CanvasControl_SaveProcessChanged;
			this.CanvasMessage += this.CanvasControl_CanvasMessage;
			this.ShowContextMenuCanvasEvent += this.CanvasControl_ShowContextMenuCanvasEvent;
			this.ObjectClicked += this.CanvasControl_ObjectClicked;
			this.SelectedObjectChanged += this.CanvasControl_SelectedObjectChanged;
			this.SelectedObjectMoved += this.CanvasControl_SelectedObjectMoved;
			this.StateAdded += this.CanvasControl_StateAdded;
			this.StateRemoved += this.CanvasControl_StateRemoved;
			if (base.GetType() == typeof(CanvasControl) && this.bool_2)
			{
				this.method_43();
			}
			this.undoRedoManager = new UndoRedoManager(this);
			this.method_75();
			this.method_50();
		}

		private void CanvasControl_StateRemoved(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
		}

		private void CanvasControl_StateAdded(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
		}

		private void CanvasControl_SelectedObjectMoved(CanvasControl canvasControl_1, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
		}

		private void CanvasControl_SelectedObjectChanged(CanvasControl canvasControl_1, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
		}

		private void CanvasControl_ObjectClicked(CanvasControl canvasControl_1, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
		}

		private void method_9(CanvasControl.AsyncAction asyncAction_0)
		{
			if (!base.InvokeRequired)
			{
				asyncAction_0();
				return;
			}
			base.Invoke(new CanvasControl.DispatcherInvoker(this.method_9), new object[]
			{
				asyncAction_0
			});
		}

		private void CanvasControl_ShowContextMenuCanvasEvent(ContextMenuStrip contextMenuStrip_0, List<object> list_9)
		{
		}

		private void CanvasControl_CanvasMessage(CanvasControl canvasControl_1, CanvasMessageEventArgs canvasMessageEventArgs_0)
		{
		}

		private void CanvasControl_SaveProcessChanged(object sender, EventArgs e)
		{
			if ((int)sender == 0)
			{
				this.VisibleSaveProgressBar = false;
				return;
			}
			this.VisibleSaveProgressBar = true;
			this.toolProgressBarSave.Value = 10;
		}

		public virtual void OnSelectedObjectEdited(DrawObjectsEventArgs e)
		{
			if (this.drawObjectEventHandler_6 != null)
			{
				this.drawObjectEventHandler_6(this, e);
			}
		}

		public virtual void OnDrawingCompleted(DrawObjectsEventArgs e)
		{
			if (this.drawObjectEventHandler_7 != null)
			{
				this.drawObjectEventHandler_7(this, e);
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Rectangle clipRectangle = e.ClipRectangle;
			if (this.staticImage == null)
			{
				if (base.ClientRectangle.Width == 0 || base.ClientRectangle.Height == 0)
				{
					return;
				}
				this.staticImage = new Bitmap(base.ClientRectangle.Width, base.ClientRectangle.Height);
				this.staticRepaint = true;
			}
			this.rectangleF_1 = ConvertCanvas.ConvertToUnitNormalized(this, clipRectangle);
			if (this.staticRepaint)
			{
				this.graphics_0 = Graphics.FromImage(this.staticImage);
				this.graphics_0.SmoothingMode = this.Settings.QualityImage;
				this.staticRepaint = false;
				this.BackgroundLayer.Draw(this, this.rectangleF_1);
				if (this.GridLayer.Enabled)
				{
					this.GridLayer.Draw(this, this.rectangleF_1);
				}
				PointF pointF = ConvertCanvas.ConvertToScreen(this, new UnitPoint(0.0, 0.0));
				float num = 10f * this.Zoom;
				this.Graphics.DrawLine(Pens.Blue, pointF.X - num, pointF.Y, pointF.X + num, pointF.Y);
				this.Graphics.DrawLine(Pens.Blue, pointF.X, pointF.Y - num, pointF.X, pointF.Y + num);
				if (base.Enabled)
				{
					for (int i = this.list_0.Count - 1; i >= 0; i--)
					{
						if (this.list_0[i] != this.ActiveLayer && this.list_0[i].Visible)
						{
							this.list_0[i].Draw(this, this.rectangleF_1);
						}
					}
					try
					{
						if (this.ActiveLayer != null)
						{
							this.ActiveLayer.Draw(this, this.rectangleF_1);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source);
					}
				}
			}
			e.Graphics.DrawImage(this.staticImage, clipRectangle, clipRectangle, GraphicsUnit.Pixel);
			this.graphics_0 = e.Graphics;
			if (this.drawObjectBase_0 != null)
			{
				this.drawObjectBase_0.Draw(this, this.rectangleF_1, eDrawMode.Color);
			}
			if (this.drawObjectBase_1 != null)
			{
				this.drawObjectBase_1.Draw(this, this.rectangleF_1, eDrawMode.Color);
			}
			if (this.isnapPoint_0 != null)
			{
				this.isnapPoint_0.Draw(this);
			}
			foreach (DrawObjectBase drawObjectBase in this.list_3)
			{
				drawObjectBase.Draw(this, this.rectangleF_1, eDrawMode.Color);
			}
			if (this.selectionRectangle_0 != null)
			{
				Rectangle rectangle = this.selectionRectangle_0.ScreenRect();
				if (rectangle != Rectangle.Empty)
				{
					ControlPaint.DrawFocusRectangle(this.graphics_0, rectangle, Color.Black, Color.Transparent);
				}
			}
			if ((this.eCommandType_0 == eCommandType.drawframe || this.eCommandType_0 == eCommandType.frame) && this.canvasFrame_0 != null)
			{
				PointF pointF2 = ConvertCanvas.ConvertToScreen(this, new UnitPoint(this.canvasFrame_0.Rectangle.Location));
				PointF pointF3 = ConvertCanvas.ConvertToScreen(this, new UnitPoint((double)this.canvasFrame_0.Rectangle.Right, (double)this.canvasFrame_0.Rectangle.Bottom));
				float num2 = Math.Min(pointF2.X, pointF3.X);
				float num3 = Math.Min(pointF2.Y, pointF3.Y);
				float num4 = Math.Max(pointF2.X, pointF3.X);
				float num5 = Math.Max(pointF2.Y, pointF3.Y);
				e.Graphics.DrawRectangle(new Pen(Brushes.White), num2, num3, num4 - num2, num5 - num3);
				for (int j = 1; j <= this.canvasFrame_0.NodeCount; j++)
				{
					e.Graphics.FillRectangle(Brushes.White, this.canvasFrame_0.GetNodeRectangle(this, j));
				}
				SolidBrush solidBrush = new SolidBrush(Color.FromArgb(100, Color.LightGray));
				e.Graphics.FillRectangle(solidBrush, new Rectangle(base.ClientRectangle.X, base.ClientRectangle.Y, (int)num2 - base.ClientRectangle.X, base.ClientRectangle.Height));
				e.Graphics.FillRectangle(solidBrush, new Rectangle((int)num4, base.ClientRectangle.Y, base.ClientRectangle.Right - (int)num4, base.ClientRectangle.Height));
				e.Graphics.FillRectangle(solidBrush, new Rectangle((int)num2, base.ClientRectangle.Y, (int)num4 - (int)num2, (int)num3 - base.ClientRectangle.Y));
				e.Graphics.FillRectangle(solidBrush, new Rectangle((int)num2, (int)num5, (int)num4 - (int)num2, base.ClientRectangle.Bottom - (int)num5));
				solidBrush.Dispose();
			}
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (!base.Enabled)
			{
				return;
			}
			this.panelPassport_0.Visible = false;
			this.unitPoint_2 = ConvertCanvas.ConvertToUnit(this, new PointF((float)e.X, (float)e.Y));
			this.pointF_0 = new PointF((float)e.X, (float)e.Y);
			this.pointF_2 = new PointF(0f, 0f);
			UnitPoint point = ConvertCanvas.ConvertToUnit(this, this.pointF_0);
			if (this.isnapPoint_0 != null)
			{
				point = this.isnapPoint_0.SnapPoint;
			}
			MouseButtons button = e.Button;
			if (button != MouseButtons.Left)
			{
				if (button != MouseButtons.Right)
				{
					if (button == MouseButtons.Middle)
					{
						this.Cursor = this.class1_0.method_1(eCommandType.pan);
					}
				}
				else
				{
					eCommandType eCommandType = this.eCommandType_0;
					if (eCommandType != eCommandType.select)
					{
						if (eCommandType == eCommandType.draw && this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_0 != null)
						{
							this.drawObjectBase_0.OnMouseDown(this, point, this.isnapPoint_0, e.Button);
						}
					}
					else if (this.list_1.Count == 1)
					{
						DrawObjectBase drawObjectBase = this.SelectedObjects.First<DrawObjectBase>();
						if (drawObjectBase.PointInObject(point))
						{
							drawObjectBase.OnMouseDown(this, point, null, e.Button);
						}
					}
				}
			}
			else
			{
				switch (this.eCommandType_0)
				{
				case eCommandType.select:
					if (this.control0_0 != null)
					{
						if (Class79.XrgxasnnaZ(new UnitPoint(this.control0_0.Location), 3f, new UnitPoint((double)e.X, (double)e.Y)))
						{
							this.Cursor = Cursors.SizeNWSE;
							this.control0_0.Cursor = Cursors.SizeNWSE;
							this.eCommandType_0 = eCommandType.select;
							break;
						}
						this.control0_0.Cursor = Cursors.Default;
					}
					foreach (DrawObjectBase drawObjectBase2 in this.SelectedObjects)
					{
						int num = drawObjectBase2.HitTest(this, new PointF((float)e.X, (float)e.Y));
						if (num > 0)
						{
							this.eCommandType_0 = eCommandType.resizeObj;
							this.drawObjectBase_1 = drawObjectBase2;
							this.int_1 = num;
							this.ClearSelectedObjects();
							this.SelectObject(drawObjectBase2);
							this.bool_3 = true;
							break;
						}
					}
					if (this.eCommandType_0 == eCommandType.select)
					{
						List<DrawObjectBase> hitObjects = this.GetHitObjects(point);
						if (hitObjects.Count > 0)
						{
							this.eCommandType_0 = eCommandType.move;
							this.unitPoint_1 = point;
							if (this.list_1.Count > 0 && this.SelectedObjects.Contains(hitObjects[0]) && Control.ModifierKeys != Keys.Control)
							{
								if (this.Mode == eCanvasEditingMode.Edit)
								{
									this.Cursor = Cursors.SizeAll;
								}
								this.bool_3 = true;
								return;
							}
							List<DrawObjectBase> list = new List<DrawObjectBase>();
							if (hitObjects.Count > 0)
							{
								list.Add(hitObjects[0]);
								Color color = hitObjects[0].Color;
								this.drawObjectEventHandler_3(this, new DrawObjectsEventArgs(hitObjects[0]));
							}
							this.HandleSelection(list);
							if (this.Mode == eCanvasEditingMode.Edit)
							{
								this.Cursor = Cursors.SizeAll;
							}
							this.bool_3 = true;
						}
					}
					if (this.eCommandType_0 == eCommandType.select)
					{
						this.eCommandType_0 = eCommandType.netSelect;
					}
					this.selectionRectangle_0 = new SelectionRectangle(this.pointF_0);
					break;
				case eCommandType.draw:
					if (this.Mode == eCanvasEditingMode.Edit)
					{
						if (this.drawObjectBase_0 == null)
						{
							this.drawObjectBase_0 = this.CreateObject(this.string_0, point, null);
							if (this.drawObjectBase_0 != null)
							{
								this.ClearSelectedObjects();
								UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(new List<DrawObjectBase>
								{
									this.drawObjectBase_0
								}, UndoRedoManager.ChangesMode.AddObject);
								this.undoRedoManager.HappenedChange(changes);
								this.AddObject(this.ActiveLayer, this.drawObjectBase_0);
								this.DoInvalidate(true);
							}
						}
						if (this.drawObjectBase_0 != null)
						{
							this.drawObjectBase_0.OnMouseDown(this, point, this.isnapPoint_0, e.Button);
						}
					}
					break;
				case eCommandType.pattern:
					if (this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_0 == null)
					{
						this.drawObjectBase_0 = this.CreateObject("Rectangle", point, null);
						if (this.drawObjectBase_0 != null)
						{
							this.ClearSelectedObjects();
							this.AddObject(this.ActiveLayer, this.drawObjectBase_0);
							this.DoInvalidate(true);
						}
					}
					break;
				case eCommandType.zoomWindow:
					this.selectionRectangle_0 = new SelectionRectangle(this.pointF_0);
					break;
				case eCommandType.frame:
					if (this.canvasFrame_0 != null)
					{
						this.int_0 = this.canvasFrame_0.HitTest(this, point);
						if (this.int_0 == -1)
						{
							this.CommandDrawFrame();
							this.canvasFrame_0 = new CanvasFrame(point);
						}
						if (this.int_0 == 0)
						{
							this.unitPoint_1 = point;
						}
					}
					break;
				case eCommandType.drawframe:
					this.canvasFrame_0 = new CanvasFrame(point);
					break;
				}
			}
			base.OnMouseDown(e);
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			this.eMouseControlState_0 = eMouseControlState.OnControl;
			base.OnMouseMove(e);
			this.unitPoint_2 = ConvertCanvas.ConvertToUnit(this, new PointF((float)e.X, (float)e.Y));
			this.labelMousePosition.Text = string.Format("X={0:F};Y={1:F}", this.unitPoint_2.X, this.unitPoint_2.Y);
			MouseButtons button = e.Button;
			if (button <= MouseButtons.Left)
			{
				if (button != MouseButtons.None)
				{
					if (button == MouseButtons.Left)
					{
						switch (this.eCommandType_0)
						{
						case eCommandType.select:
							if (this.control0_0 != null)
							{
								Point point_ = new Point(e.X, e.Y);
								if (point_.X < 0)
								{
									point_.X = 0;
								}
								if (point_.X > base.Width)
								{
									point_.X = base.Width;
								}
								if (point_.Y < 0)
								{
									point_.Y = 0;
								}
								if (point_.Y > base.Height)
								{
									point_.Y = base.Height;
								}
								this.control0_0.method_111(point_);
							}
							break;
						case eCommandType.netSelect:
							this.selectionRectangle_0.SetMousePoint(this.graphics_0, new PointF((float)e.X, (float)e.Y));
							this.DoInvalidate(false);
							break;
						case eCommandType.pan:
							this.pointF_2.X = -(this.pointF_0.X - (float)e.X);
							this.pointF_2.Y = -(this.pointF_0.Y - (float)e.Y);
							this.unitPoint_0 = this.CenterPointUnit();
							this.DoInvalidate(true);
							break;
						case eCommandType.move:
							if (this.Mode == eCanvasEditingMode.Edit)
							{
								if (this.bool_3)
								{
									UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(this.SelectedObjects.ToList<DrawObjectBase>(), this.unitPoint_1, this.unitPoint_2);
									this.undoRedoManager.HappenedChange(changes);
								}
								else
								{
									this.undoRedoManager.ChangeNewValueInLastChange(this.unitPoint_2);
								}
								this.HandleMouseMoveForMove(this.unitPoint_2);
								this.DoInvalidate(true);
							}
							this.bool_3 = false;
							break;
						case eCommandType.draw:
							if (this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_0 != null)
							{
								this.method_27(this.unitPoint_2);
								if (this.isnapPoint_0 != null)
								{
									this.unitPoint_2 = this.isnapPoint_0.SnapPoint;
								}
								this.graphics_0 = Graphics.FromHwnd(base.Handle);
								this.drawObjectBase_0.OnMouseMove(this, this.unitPoint_2, e.Button);
							}
							break;
						case eCommandType.resizeObj:
							if (this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_1 != null)
							{
								if (this.bool_3)
								{
									UndoRedoManager.RegistrarOfChanges changes2 = new UndoRedoManager.RegistrarOfChanges(this.drawObjectBase_1, this.int_1, this.unitPoint_2, this.unitPoint_2);
									this.undoRedoManager.HappenedChange(changes2);
								}
								else
								{
									this.undoRedoManager.ChangeNewValueInLastChange(this.unitPoint_2);
								}
								this.method_27(this.unitPoint_2);
								if (this.isnapPoint_0 != null)
								{
									this.unitPoint_2 = this.isnapPoint_0.SnapPoint;
								}
								if (Control.ModifierKeys == Keys.Shift)
								{
									UnitPoint unitPoint = ConvertCanvas.ConvertToUnit(this, this.pointF_0);
									double value = unitPoint.X - this.unitPoint_2.X;
									double value2 = unitPoint.Y - this.unitPoint_2.Y;
									if (Math.Abs(value) > Math.Abs(value2))
									{
										this.unitPoint_2 = new UnitPoint(this.unitPoint_2.X, unitPoint.Y);
									}
									else if (Math.Abs(value) < Math.Abs(value2))
									{
										this.unitPoint_2 = new UnitPoint(unitPoint.X, this.unitPoint_2.Y);
									}
								}
								this.drawObjectBase_1.MoveHandleTo(this.unitPoint_2, this.int_1);
								this.DoInvalidate(true);
							}
							this.bool_3 = false;
							break;
						case eCommandType.pattern:
							if (this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_0 != null)
							{
								this.method_27(this.unitPoint_2);
								if (this.isnapPoint_0 != null)
								{
									this.unitPoint_2 = this.isnapPoint_0.SnapPoint;
								}
								this.graphics_0 = Graphics.FromHwnd(base.Handle);
								RectangleF unitrect = ConvertCanvas.ConvertToScreenNormalized(this, this.drawObjectBase_0.GetBoundingRect(this, true));
								unitrect.Inflate(2f, 2f);
								this.method_21(new Rectangle((int)unitrect.X, (int)unitrect.Y, (int)unitrect.Width, (int)unitrect.Height));
								this.drawObjectBase_0.MoveHandleTo(this.unitPoint_2, 5);
								this.drawObjectBase_0.Draw(this, unitrect, eDrawMode.Color);
							}
							break;
						case eCommandType.zoomWindow:
							this.selectionRectangle_0.SetMousePoint(this.graphics_0, new PointF((float)e.X, (float)e.Y));
							this.DoInvalidate(false);
							break;
						case eCommandType.frame:
							if (this.int_0 == 0)
							{
								double x = this.unitPoint_2.X - this.unitPoint_1.X;
								double y = this.unitPoint_2.Y - this.unitPoint_1.Y;
								UnitPoint offset = new UnitPoint(x, y);
								this.unitPoint_1 = this.unitPoint_2;
								this.canvasFrame_0.Move(offset);
								this.DoInvalidate(true);
							}
							else if (this.int_0 > 0)
							{
								this.canvasFrame_0.MoveHandleTo(this.unitPoint_2, this.int_0);
								this.DoInvalidate(true);
							}
							break;
						case eCommandType.drawframe:
							this.canvasFrame_0.MoveHandleTo(this.unitPoint_2, 5);
							this.DoInvalidate(true);
							break;
						}
					}
				}
				else
				{
					eCommandType eCommandType = this.eCommandType_0;
					if (eCommandType != eCommandType.select)
					{
						if (eCommandType != eCommandType.draw)
						{
							if (eCommandType == eCommandType.frame)
							{
								if (this.canvasFrame_0 != null)
								{
									int handleNumber = this.canvasFrame_0.HitTest(this, this.unitPoint_2);
									switch (handleNumber)
									{
									case -1:
										this.Cursor = Cursors.Arrow;
										break;
									case 0:
										this.Cursor = Cursors.SizeAll;
										break;
									case 1:
									case 2:
									case 3:
									case 4:
									case 5:
									case 6:
									case 7:
									case 8:
										this.Cursor = this.canvasFrame_0.GetHandleCursor(handleNumber);
										break;
									}
								}
							}
						}
						else if (this.Mode == eCanvasEditingMode.Edit)
						{
							this.method_27(this.unitPoint_2);
							if (this.isnapPoint_0 != null)
							{
								this.unitPoint_2 = this.isnapPoint_0.SnapPoint;
							}
							if (this.drawObjectBase_0 != null)
							{
								this.drawObjectBase_0.OnMouseMove(this, this.unitPoint_2, e.Button);
							}
						}
					}
					else
					{
						Cursor cursor = null;
						foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
						{
							int num = drawObjectBase.HitTest(this, new PointF((float)e.X, (float)e.Y));
							if (num > 0)
							{
								cursor = drawObjectBase.GetHandleCursor(num);
								break;
							}
						}
						if (cursor == null)
						{
							this.method_24();
						}
						else
						{
							this.Cursor = cursor;
						}
						if (this.control0_0 != null)
						{
							if (Class79.XrgxasnnaZ(new UnitPoint(this.control0_0.Location), 3f, new UnitPoint((double)e.X, (double)e.Y)))
							{
								this.Cursor = Cursors.SizeNWSE;
							}
							else
							{
								this.Cursor = cursor;
							}
						}
					}
				}
			}
			else if (button != MouseButtons.Right)
			{
				if (button == MouseButtons.Middle)
				{
					this.pointF_2.X = -(this.pointF_0.X - (float)e.X);
					this.pointF_2.Y = -(this.pointF_0.Y - (float)e.Y);
					this.unitPoint_0 = this.CenterPointUnit();
					this.DoInvalidate(true);
				}
			}
			if (!this.timer_1.Enabled)
			{
				this.timer_1.Start();
			}
			this.point_0 = new Point(e.X, e.Y);
			if (this.point_0 != this.xFfsyLeRmd)
			{
				this.panelPassport_0.Visible = false;
				this.tbPopup.Visible = false;
			}
			this.int_3 = 0;
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			UnitPoint mousePoint = ConvertCanvas.ConvertToUnit(this, e.Location);
			MouseButtons button = e.Button;
			if (button != MouseButtons.Left)
			{
				if (button != MouseButtons.Right)
				{
					if (button == MouseButtons.Middle)
					{
						this.pointF_1.X = this.pointF_1.X + this.pointF_2.X;
						this.pointF_1.Y = this.pointF_1.Y + this.pointF_2.Y;
						this.pointF_2 = new PointF(0f, 0f);
						this.method_46();
						this.method_24();
					}
				}
				else
				{
					eCommandType eCommandType = this.eCommandType_0;
					if (eCommandType != eCommandType.select)
					{
						if (eCommandType == eCommandType.frame)
						{
							if (this.canvasFrame_0 != null && this.canvasFrame_0.HitTest(this, mousePoint) >= 0)
							{
								this.contextMenuFrame.Show(Cursor.Position);
							}
						}
					}
					else
					{
						if (this.list_1.Count == 1)
						{
							DrawObjectBase drawObjectBase = this.SelectedObjects.First<DrawObjectBase>();
							if (drawObjectBase.PointInObject(mousePoint))
							{
								List<object> list = new List<object>();
								list.Add(drawObjectBase);
								ContextMenuStrip contextMenuByObject = this.GetContextMenuByObject(drawObjectBase);
								if (contextMenuByObject != null)
								{
									contextMenuByObject.Tag = drawObjectBase;
									this.showContextMenuCanvasEventHandler_0(contextMenuByObject, list);
									contextMenuByObject.Show(Cursor.Position);
									goto IL_936;
								}
								goto IL_936;
							}
						}
						else if ((from o in this.SelectedObjects
						where o.PointInObject(mousePoint)
						select o).Count<DrawObjectBase>() > 0)
						{
							this.contextMenuSelectedObjects.Tag = this.SelectedObjects;
							this.contextMenuSelectedObjects.Show(Cursor.Position);
							goto IL_936;
						}
						this.contextMenuCanvas.Tag = mousePoint;
						this.contextMenuCanvas.Show(Cursor.Position);
					}
				}
			}
			else
			{
				switch (this.eCommandType_0)
				{
				case eCommandType.netSelect:
					if (this.selectionRectangle_0 != null)
					{
						List<DrawObjectBase> selected = null;
						RectangleF rectangleF = this.selectionRectangle_0.Selection(this);
						if (rectangleF != RectangleF.Empty)
						{
							this.graphics_0 = Graphics.FromHwnd(base.Handle);
							selected = this.GetHitObjects(this, rectangleF, this.selectionRectangle_0.AnyPoint());
							this.DoInvalidate(true);
						}
						this.HandleSelection(selected);
					}
					this.eCommandType_0 = eCommandType.select;
					this.selectionRectangle_0 = null;
					this.method_24();
					break;
				case eCommandType.pan:
					this.pointF_1.X = this.pointF_1.X + this.pointF_2.X;
					this.pointF_1.Y = this.pointF_1.Y + this.pointF_2.Y;
					this.pointF_2 = new PointF(0f, 0f);
					this.method_46();
					break;
				case eCommandType.move:
					if (this.Mode == eCanvasEditingMode.Edit && this.pointF_0 != new PointF((float)e.X, (float)e.Y))
					{
						this.method_10();
					}
					foreach (DrawObjectBase drawObjectBase2 in from o in this.SelectedObjects
					where o is NodeTool
					select o)
					{
						try
						{
							if (this.Connected)
							{
								this.proxy_Singleton_0.NodeChange(drawObjectBase2.IdBase, 3, drawObjectBase2.Text, ((NodeTool)drawObjectBase2).Location.Point, drawObjectBase2.Color, Class18.smethod_3());
							}
						}
						catch (Exception ex)
						{
							this.SendMessage(ex.Message, eMessageType.Error);
						}
					}
					this.eCommandType_0 = eCommandType.select;
					this.method_24();
					break;
				case eCommandType.draw:
					if (this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_0 != null)
					{
						this.drawObjectBase_0.OnMouseUp(this, new UnitPoint((double)e.X, (double)e.Y), null, e.Button);
					}
					break;
				case eCommandType.resizeObj:
					if (this.Mode == eCanvasEditingMode.Edit)
					{
						if (!this.drawObjectBase_1.LimitedEditing && this.drawObjectBase_1 is LineTool && ((LineTool)this.drawObjectBase_1).Ends.Contains(((LineTool)this.drawObjectBase_1).SelectedPoint))
						{
							PointTool pointTool = this.method_29(mousePoint);
							if (pointTool != null)
							{
								PointTool pointTool2 = ((LineTool)this.drawObjectBase_1).GetPointsList()[this.int_1 - 1];
								bool flag = false;
								if (!(flag = ((pointTool2.Parent != null && pointTool2.Parent is ShinaTool) || (pointTool.Parent != null && pointTool.Parent is ShinaTool))))
								{
									using (IEnumerator<Branch> enumerator2 = pointTool.Branches.GetEnumerator())
									{
										while (enumerator2.MoveNext())
										{
											if (enumerator2.Current.Parent.LimitedEditing)
											{
												flag = true;
												break;
											}
										}
									}
								}
								if (!flag && ((LineTool)this.drawObjectBase_1).Ends.Contains(pointTool2) && !((LineTool)this.drawObjectBase_1).Ends.Contains(pointTool) && pointTool2 != pointTool)
								{
									Branch branch = pointTool2[0];
									bool isSourse = pointTool2[0].Source == pointTool2;
									((LineTool)this.drawObjectBase_1).RechangePointInBranch(branch, pointTool, isSourse);
									((LineTool)this.drawObjectBase_1).AmperageAnalisForNewPoint(pointTool, branch);
								}
								Class18.smethod_6(this.drawObjectBase_1);
							}
							else if (this.drawObjectBase_1.GetType() == typeof(LineCellTool) && !(((LineTool)this.drawObjectBase_1).SelectedPoint.Parent is ShinaTool))
							{
								ShinaTool shinaTool = null;
								foreach (DrawObjectBase drawObjectBase3 in this.drawObjectBase_1.Parent.ChildObjects)
								{
									if (drawObjectBase3.GetType() == typeof(ShinaTool) && drawObjectBase3.PointInObject(((LineTool)this.drawObjectBase_1).SelectedPoint.Point))
									{
										shinaTool = (ShinaTool)drawObjectBase3;
										break;
									}
								}
								if (shinaTool != null)
								{
									foreach (PointTool pointTool3 in ((LineCellTool)this.drawObjectBase_1).Ends)
									{
										if (pointTool3.Parent != null && pointTool3.Parent == shinaTool)
										{
											shinaTool = null;
											break;
										}
									}
									if (shinaTool != null)
									{
										PointShinaTool newPoint = shinaTool.AddPointShinaTool(((LineTool)this.drawObjectBase_1).SelectedPoint.Point);
										Branch branch2 = null;
										using (IEnumerator<Branch> enumerator2 = ((LineTool)this.drawObjectBase_1).SelectedPoint.Branches.GetEnumerator())
										{
											if (enumerator2.MoveNext())
											{
												Branch branch3 = enumerator2.Current;
												if (branch3.Parent == this.drawObjectBase_1)
												{
													branch2 = branch3;
												}
											}
										}
										if (branch2 != null)
										{
											((LineTool)this.drawObjectBase_1).RechangePointInBranch(branch2, newPoint, branch2.Source == ((LineTool)this.drawObjectBase_1).SelectedPoint);
											Class18.smethod_6(this.drawObjectBase_1);
										}
									}
								}
							}
							else
							{
								Class18.smethod_6(this.drawObjectBase_1);
							}
						}
						else
						{
							this.drawObjectBase_1.Normalize();
							Class18.smethod_6(this.drawObjectBase_1);
						}
						this.OnObjectsResized(new DrawObjectsEventArgs(this.drawObjectBase_1));
					}
					this.eCommandType_0 = eCommandType.select;
					this.drawObjectBase_1 = null;
					break;
				case eCommandType.pattern:
					if (this.Mode == eCanvasEditingMode.Edit)
					{
						this.drawingLayer_0.AddObject(this.drawObjectBase_0);
						((PatternTP)this.drawingLayer_0).ShowFormSettings(this.SqlSettings);
						this.ClearSelectedObjects();
						this.ClearFlashingObjects();
						((DrawingLayer)this.ActiveLayer).RemoveObject(this.drawObjectBase_0);
						if (this.drawingLayer_0.ObjectsCount > 0)
						{
							UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(this.drawingLayer_0.Objects.ToList<DrawObjectBase>(), UndoRedoManager.ChangesMode.AddObject);
							this.undoRedoManager.HappenedChange(changes);
							DrawObjectBase drawObjectBase4 = null;
							foreach (DrawObjectBase drawObjectBase5 in this.drawingLayer_0.Objects)
							{
								this.AddObject(this.ActiveLayer, drawObjectBase5);
								this.SelectObject(drawObjectBase5);
								if (drawObjectBase5.GetType() == typeof(RectangleTool))
								{
									if (!this.ValidateToUnique(drawObjectBase5))
									{
										drawObjectBase5.CreateUniqueCopyName();
									}
									drawObjectBase4 = drawObjectBase5;
								}
								if (drawObjectBase5.GetType() == typeof(ShinaTool) && drawObjectBase5.Parent != null && ((RectangleTool)drawObjectBase5.Parent).TypeRectnagleTool == SchemeCtrl2.DrawTool.eTypeRectangleTool.CP)
								{
									((ShinaTool)drawObjectBase5).OnAmperage = true;
								}
							}
							if (drawObjectBase4 != null)
							{
								Class18.smethod_6(drawObjectBase4);
							}
						}
						this.CommandEscape();
					}
					break;
				case eCommandType.zoomWindow:
					this.method_28(this.selectionRectangle_0.Selection(this), true);
					this.eCommandType_0 = eCommandType.select;
					this.selectionRectangle_0 = null;
					this.method_24();
					break;
				case eCommandType.drawframe:
					this.CommandFrame();
					break;
				}
			}
			IL_936:
			this.isnapPoint_0 = null;
		}

		public ContextMenuStrip GetContextMenuByObject(DrawObjectBase obj)
		{
			ContextMenuStrip result = null;
			if (obj.GetType() == typeof(RectangleTool))
			{
				result = this.ContextMenuRectangle;
			}
			if (obj.GetType() == typeof(ShinaTool) || obj.GetType() == typeof(SplitterShinaTool))
			{
				result = this.ContextMenuShina;
			}
			if (obj is ObjectOnLine)
			{
				result = this.ContextMenuSwitchTool;
			}
			if (obj.GetType() == typeof(LineTool) || obj.GetType() == typeof(LineCellTool) || obj.GetType() == typeof(Class14))
			{
				result = this.ContextMenuLineTool;
			}
			if (obj is LabelTool)
			{
				result = this.contextMenuLabelTool;
			}
			if (obj.GetType() == typeof(PointShinaTool) && ((PointShinaTool)obj).CouplingRelations.Count == 0)
			{
				result = this.contextMenuStripWhitePoint;
			}
			if (obj.GetType() == typeof(TextBranchTool))
			{
				result = this.contextMenuTextBranchTool;
			}
			return result;
		}

		private void method_10()
		{
			if (this.Mode == eCanvasEditingMode.Edit)
			{
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += this.method_11;
				backgroundWorker.RunWorkerCompleted += this.method_12;
				StringBuilder stringBuilder = new StringBuilder();
				List<int> id = new List<int>();
				foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
				{
					stringBuilder.Append(drawObjectBase.GetUpdateScriptXML(true, id));
				}
				if (!string.IsNullOrEmpty(stringBuilder.ToString()))
				{
					this.rFaFrHyEir();
				}
				if (!string.IsNullOrEmpty(stringBuilder.ToString()))
				{
					stringBuilder.Insert(0, "BEGIN TRANSACTION t1; set transaction isolation level SERIALIZABLE;  select id from tSChm_ObjList (UPDLOCK)  select id from tSChm_Xml (UPDLOCK) ");
					stringBuilder.Append(" COMMIT TRANSACTION t1; ");
					int workerCounter = this.WorkerCounter;
					this.WorkerCounter = workerCounter + 1;
					backgroundWorker.RunWorkerAsync(stringBuilder);
				}
			}
		}

		private void method_11(object sender, DoWorkEventArgs e)
		{
			string cmdText = e.Argument.ToString();
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			sqlDataConnect.OpenConnection(this.SqlSettings);
			try
			{
				new SqlCommand(cmdText, sqlDataConnect.Connection)
				{
					CommandTimeout = 0
				}.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
		}

		private void method_12(object sender, RunWorkerCompletedEventArgs e)
		{
			int workerCounter = this.WorkerCounter;
			this.WorkerCounter = workerCounter - 1;
		}

		protected override void OnMouseWheel(MouseEventArgs e)
		{
			UnitPoint point = ConvertCanvas.ConvertToUnit(this, new PointF((float)e.X, (float)e.Y));
			float num = 120f;
			float num2 = (float)Math.Abs(e.Delta) / num;
			if (e.Delta < 0)
			{
				if (this.Zoom > 0.25f)
				{
					this.Zoom -= 0.25f;
				}
				else
				{
					this.Zoom /= 2f;
				}
				if (this.Zoom < 0.001f)
				{
					this.Zoom = 0.001f;
				}
			}
			else
			{
				if (this.Zoom < 0.25f)
				{
					if (this.Zoom > 0.125f)
					{
						this.Zoom = 0.25f;
					}
					else
					{
						this.Zoom *= 2f;
					}
				}
				else
				{
					this.Zoom += 0.25f;
				}
				if (this.Zoom > 100f)
				{
					this.Zoom = 100f;
				}
			}
			if (point.X < (double)this.rectangleF_0.X)
			{
				point.X = (double)this.rectangleF_0.X;
			}
			if (point.Y < (double)this.rectangleF_0.Y)
			{
				point.Y = (double)this.rectangleF_0.Y;
			}
			if (point.X > (double)this.rectangleF_0.Right)
			{
				point.X = (double)this.rectangleF_0.Right;
			}
			if (point.Y > (double)this.rectangleF_0.Bottom)
			{
				point.Y = (double)this.rectangleF_0.Bottom;
			}
			PointF pointF = ConvertCanvas.ConvertToScreen(this, point);
			this.pointF_1.X = this.pointF_1.X + ((float)e.X - pointF.X);
			this.pointF_1.Y = this.pointF_1.Y + ((float)e.Y - pointF.Y);
			this.DoInvalidate(true);
			this.panelPassport_0.Visible = false;
		}

		protected override void OnMouseDoubleClick(MouseEventArgs e)
		{
			UnitPoint point = ConvertCanvas.ConvertToUnit(this, new PointF((float)e.X, (float)e.Y));
			MouseButtons button = e.Button;
			if (button != MouseButtons.Left)
			{
				if (button == MouseButtons.Middle)
				{
					switch (this.eCommandType_0)
					{
					case eCommandType.select:
					case eCommandType.netSelect:
					case eCommandType.move:
					case eCommandType.resizeObj:
						this.FitToScreen();
						break;
					}
				}
			}
			else
			{
				switch (this.eCommandType_0)
				{
				case eCommandType.select:
				case eCommandType.netSelect:
				case eCommandType.move:
				case eCommandType.resizeObj:
				{
					List<DrawObjectBase> hitObjects = this.GetHitObjects(point);
					if (hitObjects.Count > 0)
					{
						hitObjects[0].OnMouseDoubleClick(this, point, e.Button);
					}
					break;
				}
				}
			}
			this.panelPassport_0.Visible = false;
		}

		protected override void OnMouseHover(EventArgs e)
		{
			this.eMouseControlState_0 = eMouseControlState.OnControl;
			base.OnMouseHover(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.eMouseControlState_0 = eMouseControlState.IsLeave;
			this.labelMousePosition.Text = "";
		}

		protected override void OnDragOver(DragEventArgs drgevent)
		{
			DrawObjectBase drawObjectBase = null;
			Point point = base.PointToClient(new Point(drgevent.X, drgevent.Y));
			UnitPoint point2 = ConvertCanvas.ConvertToUnit(this, new PointF((float)point.X, (float)point.Y));
			foreach (DrawObjectBase drawObjectBase2 in this.GetHitObjects(point2))
			{
				if (drawObjectBase2.GetType() != typeof(LineTool))
				{
					if (drawObjectBase2.GetType() != typeof(LineCellTool))
					{
						continue;
					}
				}
				drawObjectBase = drawObjectBase2;
				break;
			}
			if (drgevent.Data.GetDataPresent(typeof(GroundingTool)) && drawObjectBase != null)
			{
				drgevent.Effect = DragDropEffects.Move;
			}
			else
			{
				drgevent.Effect = DragDropEffects.None;
			}
			base.OnDragOver(drgevent);
		}

		protected override void OnDragDrop(DragEventArgs drgevent)
		{
			DrawObjectBase drawObjectBase = null;
			Point point = base.PointToClient(new Point(drgevent.X, drgevent.Y));
			UnitPoint unitPoint = ConvertCanvas.ConvertToUnit(this, new PointF((float)point.X, (float)point.Y));
			foreach (DrawObjectBase drawObjectBase2 in this.GetHitObjects(unitPoint))
			{
				if (drawObjectBase2.GetType() != typeof(LineTool))
				{
					if (drawObjectBase2.GetType() != typeof(LineCellTool))
					{
						continue;
					}
				}
				drawObjectBase = ((LineTool)drawObjectBase2).GetHitBranch(unitPoint);
				break;
			}
			if (drgevent.Data.GetDataPresent(typeof(GroundingTool)) && drawObjectBase != null && drawObjectBase.GetType() == typeof(Branch))
			{
				GroundingTool groundingTool = (GroundingTool)drgevent.Data.GetData(typeof(GroundingTool));
				Branch branch = (Branch)drawObjectBase;
				branch.AddSwitchTool(groundingTool, unitPoint);
				groundingTool.Parent = branch;
				((DrawingLayer)this.icanvasLayer_0).AddObject(groundingTool);
			}
			this.DoInvalidate(true);
			base.OnDragDrop(drgevent);
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this.unitPoint_0 != UnitPoint.Empty && base.Width != 0)
			{
				this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, this.unitPoint_0), false);
			}
			this.unitPoint_0 = this.CenterPointUnit();
			this.staticImage = null;
			this.DoInvalidate(true);
			if (base.GetType() == typeof(CanvasControl))
			{
				this.method_45();
			}
		}

		protected override bool IsInputKey(Keys keyData)
		{
			switch (keyData)
			{
			case Keys.Left:
			case Keys.Up:
			case Keys.Right:
			case Keys.Down:
				return true;
			default:
				return base.IsInputKey(keyData);
			}
		}

		public void RemoveSelectedObjects()
		{
			if (this.Mode == eCanvasEditingMode.Edit)
			{
				if (this.list_1 != null && MessageBox.Show("Удалить выделенные объекты из базы данных?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
				{
					List<DrawObjectBase> delTransList = new List<DrawObjectBase>();
					List<DrawObjectBase> delwithPassp = new List<DrawObjectBase>();
					List<DrawObjectBase> delwithMeas = new List<DrawObjectBase>();
					List<DrawObjectBase> list = new List<DrawObjectBase>();
					List<DrawObjectBase> delLimEdObj = new List<DrawObjectBase>();
					List<DrawObjectBase> list2 = new List<DrawObjectBase>();
					foreach (DrawObjectBase drawObjectBase in from d in this.list_1
					where d is LineTool
					select d)
					{
						IEnumerable<DrawObjectBase> collection = drawObjectBase.ChildObjects.Where((DrawObjectBase d) => d.GetType() == typeof(TransformerTool));
						list2.AddRange(collection);
					}
					this.list_1.AddRange(list2);
					delTransList.AddRange(from o in this.list_1
					where o.GetType() == typeof(TransformerTool)
					select o);
					list.AddRange(from o in this.list_1
					where !delTransList.Contains(o)
					select o);
					delLimEdObj.AddRange(from o in list
					where o.LimitedEditing
					select o);
					list2.Clear();
					list2.AddRange(list);
					list.Clear();
					list.AddRange(from o in list2
					where !delLimEdObj.Contains(o)
					select o);
					string text = string.Empty;
					foreach (DrawObjectBase drawObjectBase2 in from o in list
					where o.IdBase > 0 && !o.LimitedEditing
					select o)
					{
						if (text != string.Empty)
						{
							text += ", ";
						}
						text += drawObjectBase2.IdBase;
					}
					SqlConnection sqlConnection = new SqlConnection(this.sqlsettings_0.GetConnectionString());
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand();
					DataTable dataTable = new DataTable();
					sqlCommand.Connection = sqlConnection;
					if (text != string.Empty)
					{
						sqlCommand.CommandText = string.Format("SELECT distinct [idObjList] FROM [tP_Passport] \r\n                                                        where deleted = 0 and isActive = 1 and idObjList in ({0})", text);
						SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
						dataTable.Load(sqlDataReader);
						sqlDataReader.Close();
						using (IEnumerator enumerator2 = dataTable.Rows.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								DataRow dr = (DataRow)enumerator2.Current;
								delwithPassp.Add(list.First((DrawObjectBase o) => o.IdBase == (int)dr[0]));
							}
						}
						dataTable.Clear();
						list2.Clear();
						list2.AddRange(list);
						list.Clear();
						list.AddRange(from o in list2
						where !delwithPassp.Contains(o)
						select o);
						text = string.Empty;
						foreach (DrawObjectBase drawObjectBase3 in from o in list
						where o.IdBase > 0 && !o.LimitedEditing
						select o)
						{
							if (text != string.Empty)
							{
								text += ", ";
							}
							text += drawObjectBase3.IdBase;
						}
					}
					if (text != string.Empty)
					{
						sqlCommand.CommandText = string.Format("SELECT  idObjList FROM tJ_Measurement where deleted = 0 and idObjList in ({0})\r\n                                                           union \r\n                                                           SELECT idBus as idObjList from tJ_MeasCable where deleted = 0 and idBus in ({0})\r\n                                                           union \r\n                                                           SELECT idCell as idObjList from tJ_MeasCable where deleted = 0 and idcell in ({0})\r\n                                                           union \r\n                                                           SELECT idBus as idObjList from tJ_MeasAmperageTransf where deleted = 0  and idBus in ({0})\r\n                                                           union \r\n                                                           SELECT idBus as idObjList from tJ_MeasCell where deleted = 0  and idBus in ({0})\r\n                                                           union \r\n                                                           SELECT idCell as idObjList from tJ_MeasCell where deleted = 0  and idcell in ({0})\r\n                                                           union \r\n                                                           SELECT idBus as idObjList from tJ_MeasVoltageTransf where deleted = 0 and idBus in ({0})", text);
						SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
						dataTable.Load(sqlDataReader);
						sqlDataReader.Close();
						using (IEnumerator enumerator2 = dataTable.Rows.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								DataRow dr = (DataRow)enumerator2.Current;
								delwithMeas.Add(list.First((DrawObjectBase o) => o.IdBase == (int)dr[0]));
							}
						}
						dataTable.Clear();
						list2.Clear();
						list2.AddRange(list);
						list.Clear();
						list.AddRange(from o in list2
						where !delwithMeas.Contains(o)
						select o);
					}
					sqlConnection.Close();
					FormCanvasRemoveTransformer formCanvasRemoveTransformer = new FormCanvasRemoveTransformer();
					if (delLimEdObj.Count > 0)
					{
						string arg = string.Empty;
						if (this.TypeCanvas == eTypeCanvas.SchemeSecond)
						{
							arg = "первого уровня и будет перезагружен после перезапуска";
						}
						else
						{
							arg = "другого уровня";
						}
						bool flag = false;
						formCanvasRemoveTransformer.All = false;
						formCanvasRemoveTransformer.button_3 = false;
						DialogResult dialogResult = DialogResult.None;
						for (int i = delLimEdObj.Count - 1; i >= 0; i--)
						{
							if (!flag)
							{
								formCanvasRemoveTransformer.Caption = string.Format("Удаляемый объект {1} был прогружен с {2}.\n\rПодобных объектов: {0}", i, delLimEdObj[i].GetFullName(), arg);
								dialogResult = formCanvasRemoveTransformer.ShowDialog();
								flag = formCanvasRemoveTransformer.All;
							}
							if (dialogResult != DialogResult.Yes)
							{
								delLimEdObj.RemoveAt(i);
							}
						}
						list.AddRange(delLimEdObj);
					}
					if (delTransList.Count > 0)
					{
						formCanvasRemoveTransformer.button_3 = true;
						bool flag2 = false;
						DialogResult dialogResult2 = DialogResult.None;
						Dictionary<DrawObjectBase, DrawObjectBase> dictionary = new Dictionary<DrawObjectBase, DrawObjectBase>();
						for (int j = delTransList.Count - 1; j >= 0; j--)
						{
							DrawObjectBase drawObjectBase4 = ((LineTool)delTransList[j].Parent.Parent).ParRectangle();
							if (drawObjectBase4 != null)
							{
								if (!flag2)
								{
									formCanvasRemoveTransformer.Caption = string.Format("Среди удаляемых объектов обнаружен трансформатор {1}.\n\rТрансформатор может быть удалён из базы данных или убран со схемы с возможностью востановления.\n\rПодобных объектов: {0}", j, delTransList[j].GetFullName());
									dialogResult2 = formCanvasRemoveTransformer.ShowDialog();
									flag2 = formCanvasRemoveTransformer.All;
								}
								if (dialogResult2 != DialogResult.Yes)
								{
									if (dialogResult2 == DialogResult.No)
									{
										dictionary.Add(delTransList[j], drawObjectBase4);
									}
									delTransList.RemoveAt(j);
								}
							}
						}
						list.AddRange(delTransList);
						if (dictionary.Count > 0)
						{
							sqlConnection.Open();
							StringBuilder stringBuilder = new StringBuilder();
							foreach (DrawObjectBase drawObjectBase5 in dictionary.Keys)
							{
								string value = string.Format("UPDATE tSchm_ObjList set [IdParent] = {0} WHERE [ID] = {1}", dictionary[drawObjectBase5].IdBase, drawObjectBase5.IdBase);
								stringBuilder.AppendLine(value);
							}
							sqlCommand.CommandText = stringBuilder.ToString();
							sqlCommand.ExecuteNonQuery();
							sqlConnection.Close();
							this.DeleteObjects(dictionary.Keys, false);
						}
					}
					if (delwithPassp.Count > 0)
					{
						bool flag3 = false;
						formCanvasRemoveTransformer.All = false;
						formCanvasRemoveTransformer.button_3 = false;
						DialogResult dialogResult3 = DialogResult.None;
						for (int k = delwithPassp.Count - 1; k >= 0; k--)
						{
							if (!flag3)
							{
								formCanvasRemoveTransformer.Caption = string.Format("К удаляемому объекту {1} привязан пасспорт.\n\rПасспорт будет удалён.\n\rПодобных объектов: {0}", k, delwithPassp[k].GetFullName());
								dialogResult3 = formCanvasRemoveTransformer.ShowDialog();
								flag3 = formCanvasRemoveTransformer.All;
							}
							if (dialogResult3 != DialogResult.Yes)
							{
								delwithPassp.RemoveAt(k);
							}
						}
						list.AddRange(delwithPassp);
					}
					if (delwithMeas.Count > 0)
					{
						bool flag4 = false;
						formCanvasRemoveTransformer.All = false;
						formCanvasRemoveTransformer.button_3 = false;
						DialogResult dialogResult4 = DialogResult.None;
						for (int l = delwithMeas.Count - 1; l >= 0; l--)
						{
							if (!flag4)
							{
								formCanvasRemoveTransformer.Caption = string.Format("К удаляемому объекту {1} привязаны замеры.\n\rЗамеры будут удалены.\n\rПодобных объектов: {0}", l, delwithMeas[l].GetFullName());
								dialogResult4 = formCanvasRemoveTransformer.ShowDialog();
								flag4 = formCanvasRemoveTransformer.All;
							}
							if (dialogResult4 != DialogResult.Yes)
							{
								delwithMeas.RemoveAt(l);
							}
						}
						list.AddRange(delwithMeas);
					}
					this.DeleteObjects(list, true);
				}
				this.ClearSelectedObjects();
				this.DoInvalidate(true);
				this.method_24();
			}
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			Keys keys = e.Modifiers;
			if (keys != Keys.None)
			{
				if (keys == Keys.Control)
				{
					keys = e.KeyCode;
					if (keys <= Keys.P)
					{
						if (keys <= Keys.D0)
						{
							switch (keys)
							{
							case Keys.Left:
							case Keys.Up:
							case Keys.Right:
							case Keys.Down:
								this.method_13(e);
								return;
							default:
								if (keys != Keys.D0)
								{
									return;
								}
								break;
							}
						}
						else
						{
							switch (keys)
							{
							case Keys.A:
								this.list_1.Clear();
								foreach (ICanvasLayer canvasLayer in this.list_0)
								{
									foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
									{
										if (drawObjectBase.Visible)
										{
											drawObjectBase.Selected = true;
										}
									}
								}
								this.DoInvalidate(true);
								return;
							case Keys.B:
								return;
							case Keys.C:
								this.CopySelectedObjects();
								return;
							case Keys.D:
								this.ClearSelectedObjects();
								this.DoInvalidate(true);
								return;
							default:
								if (keys == Keys.M)
								{
									this.VisibleCanvasSchemeMap = !this.VisibleCanvasSchemeMap;
									return;
								}
								if (keys != Keys.P)
								{
									return;
								}
								new Form4
								{
									Canvas = this
								}.ShowDialog();
								return;
							}
						}
					}
					else if (keys <= Keys.NumPad0)
					{
						if (keys != Keys.V)
						{
							if (keys != Keys.NumPad0)
							{
								return;
							}
						}
						else
						{
							if (this.Mode != eCanvasEditingMode.Edit)
							{
								return;
							}
							if (this.SelectedCount > 0)
							{
								this.PasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>());
								return;
							}
							this.method_26(UnitPoint.Empty);
							return;
						}
					}
					else
					{
						if (keys == Keys.Add)
						{
							this.ZoomIn();
							return;
						}
						if (keys != Keys.Subtract)
						{
							return;
						}
						this.ZoomOut();
						return;
					}
					this.FitToScreen();
					return;
				}
				if (keys != (Keys.Shift | Keys.Control))
				{
					return;
				}
				keys = e.KeyCode;
				if (keys == Keys.Add)
				{
					this.ZoomInSymbols();
					return;
				}
				if (keys != Keys.Subtract)
				{
					return;
				}
				this.ZoomOutSymbols();
				return;
			}
			else
			{
				keys = e.KeyCode;
				switch (keys)
				{
				case Keys.Left:
				case Keys.Up:
				case Keys.Right:
				case Keys.Down:
					this.method_13(e);
					break;
				default:
					if (keys == Keys.Delete && this.Mode == eCanvasEditingMode.Edit)
					{
						this.RemoveSelectedObjects();
						return;
					}
					break;
				}
			}
		}

		protected override void OnKeyUp(KeyEventArgs e)
		{
			base.OnKeyUp(e);
			Keys modifiers = e.Modifiers;
			if (modifiers != Keys.None)
			{
				if (modifiers == Keys.Control)
				{
					switch (e.KeyCode)
					{
					case Keys.Left:
					case Keys.Up:
					case Keys.Right:
					case Keys.Down:
						this.method_10();
						return;
					default:
						return;
					}
				}
			}
			else
			{
				switch (e.KeyCode)
				{
				case Keys.Left:
				case Keys.Up:
				case Keys.Right:
				case Keys.Down:
					this.method_10();
					break;
				default:
					return;
				}
			}
		}

		private void method_13(KeyEventArgs keyEventArgs_0)
		{
			int num = 10;
			if (keyEventArgs_0.Modifiers == Keys.Control)
			{
				num = 1;
			}
			if (keyEventArgs_0.Modifiers == Keys.Control || keyEventArgs_0.Modifiers == Keys.None)
			{
				if (this.Mode == eCanvasEditingMode.Edit && this.SelectedCount > 0)
				{
					UnitPoint unitPoint_ = new UnitPoint(0.0, 0.0);
					switch (keyEventArgs_0.KeyCode)
					{
					case Keys.Left:
						unitPoint_ = new UnitPoint(ConvertCanvas.ConvertToUnit(this, -1f), 0.0);
						break;
					case Keys.Up:
						unitPoint_ = new UnitPoint(0.0, ConvertCanvas.ConvertToUnit(this, 1f));
						break;
					case Keys.Right:
						unitPoint_ = new UnitPoint(ConvertCanvas.ConvertToUnit(this, 1f), 0.0);
						break;
					case Keys.Down:
						unitPoint_ = new UnitPoint(0.0, ConvertCanvas.ConvertToUnit(this, -1f));
						break;
					}
					this.method_20(unitPoint_);
					return;
				}
				switch (keyEventArgs_0.KeyCode)
				{
				case Keys.Left:
					this.pointF_1.X = this.pointF_1.X - (float)num;
					break;
				case Keys.Up:
					this.pointF_1.Y = this.pointF_1.Y - (float)num;
					break;
				case Keys.Right:
					this.pointF_1.X = this.pointF_1.X + (float)num;
					break;
				case Keys.Down:
					this.pointF_1.Y = this.pointF_1.Y + (float)num;
					break;
				}
				this.pointF_2 = new PointF(0f, 0f);
				this.unitPoint_0 = this.CenterPointUnit();
				this.DoInvalidate(true);
				this.method_46();
			}
		}

		private void method_14(LineTool lineTool_0)
		{
			this.eCommandType_0 = eCommandType.draw;
			this.drawObjectBase_0 = lineTool_0;
		}

		internal void drawObjectBase_0_DrawNewObjectEvent(DrawObjectBase drawObjectBase_2, DrawObjectBase drawObjectBase_3)
		{
			this.eCommandType_0 = eCommandType.draw;
			this.drawObjectBase_0 = drawObjectBase_3;
			this.drawObjectBase_0.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
			if (drawObjectBase_2 != drawObjectBase_3)
			{
				this.drawObjectBase_0.DrawNewObjectEvent += this.drawObjectBase_0_DrawNewObjectEvent;
			}
		}

		internal void drawObjectBase_0_EndDrawEvent(DrawObjectBase drawObjectBase_2)
		{
			drawObjectBase_2.EndDrawEvent -= this.drawObjectBase_0_EndDrawEvent;
			DrawObjectsEventArgs e = new DrawObjectsEventArgs(drawObjectBase_2);
			this.OnDrawingCompleted(e);
			this.drawObjectBase_0 = null;
			this.DoInvalidate(true);
		}

		private void method_15()
		{
			if (base.InvokeRequired)
			{
				CanvasControl.Delegate32 method = new CanvasControl.Delegate32(this.method_15);
				base.Invoke(method);
				return;
			}
			this.Graphics = Graphics.FromHwnd(base.Handle);
		}

		protected virtual void OnObjectsAdded(List<DrawObjectBase> addObjects)
		{
			if (this.drawObjectEventHandler_0 != null)
			{
				this.drawObjectEventHandler_0(this, new DrawObjectsEventArgs(addObjects));
			}
			this.method_15();
			IEnumerable<RectangleF> source = addObjects.Select(new Func<DrawObjectBase, RectangleF>(this.method_92));
			float num = source.Min((RectangleF obj) => obj.X);
			float num2 = source.Min((RectangleF obj) => obj.Y);
			float num3 = source.Max((RectangleF obj) => obj.Right);
			float num4 = source.Max((RectangleF obj) => obj.Bottom);
			RectangleF rectangleF = new RectangleF(num, num2, num3 - num, num4 - num2);
			if (this.rectangleF_0 == RectangleF.Empty)
			{
				this.rectangleF_0 = rectangleF;
			}
			else
			{
				if (this.rectangleF_0.X > rectangleF.X)
				{
					this.rectangleF_0.Width = this.rectangleF_0.Width + (this.rectangleF_0.X - rectangleF.X);
					this.rectangleF_0.X = rectangleF.X;
				}
				if (this.rectangleF_0.Y > rectangleF.Y)
				{
					this.rectangleF_0.Height = this.rectangleF_0.Height + (this.rectangleF_0.Y - rectangleF.Y);
					this.rectangleF_0.Y = rectangleF.Y;
				}
				if (this.rectangleF_0.X + this.rectangleF_0.Width < rectangleF.X + rectangleF.Width)
				{
					this.rectangleF_0.Width = this.rectangleF_0.Width + (rectangleF.X + rectangleF.Width - (this.rectangleF_0.X + this.rectangleF_0.Width));
				}
				if (this.rectangleF_0.Y + this.rectangleF_0.Height < rectangleF.Y + rectangleF.Height)
				{
					this.rectangleF_0.Height = this.rectangleF_0.Height + (rectangleF.Y + rectangleF.Height - (this.rectangleF_0.Y + this.rectangleF_0.Height));
				}
			}
			foreach (DrawObjectBase drawObjectBase in addObjects)
			{
				drawObjectBase.DrawNewObjectEvent += this.drawObjectBase_0_DrawNewObjectEvent;
				if (drawObjectBase.GetType() == typeof(LineTool))
				{
					goto IL_2D6;
				}
				if (drawObjectBase.GetType() == typeof(LineCellTool))
				{
					goto IL_2D6;
				}
				if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine))
				{
					((ObjectOnLine)drawObjectBase).OnChanged += this.method_19;
				}
				IL_306:
				drawObjectBase.ErrorEvent += this.method_16;
				drawObjectBase.SelectedChanged += this.method_30;
				continue;
				IL_2D6:
				((LineTool)drawObjectBase).StateAdded += this.method_18;
				((LineTool)drawObjectBase).StateRemoved += this.method_17;
				goto IL_306;
			}
		}

		protected virtual void OnObjectsRemoved(List<DrawObjectBase> removeObjects)
		{
			if (this.drawObjectEventHandler_1 != null)
			{
				this.drawObjectEventHandler_1(this, new DrawObjectsEventArgs(removeObjects));
			}
			foreach (DrawObjectBase drawObjectBase in removeObjects)
			{
				if (drawObjectBase.GetType() == typeof(LineTool))
				{
					goto IL_88;
				}
				if (drawObjectBase.GetType() == typeof(LineCellTool))
				{
					goto IL_88;
				}
				if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine))
				{
					((ObjectOnLine)drawObjectBase).OnChanged -= this.method_19;
				}
				IL_B6:
				drawObjectBase.ErrorEvent -= this.method_16;
				drawObjectBase.SelectedChanged -= this.method_30;
				continue;
				IL_88:
				((LineTool)drawObjectBase).StateAdded -= this.method_18;
				((LineTool)drawObjectBase).StateRemoved -= this.method_17;
				goto IL_B6;
			}
			this.rFaFrHyEir();
		}

		protected virtual void OnObjectsResized(DrawObjectsEventArgs e)
		{
			if (this.drawObjectEventHandler_2 != null)
			{
				this.drawObjectEventHandler_2(this, e);
			}
			this.method_15();
			IEnumerable<RectangleF> source = e.Objects.Select(new Func<DrawObjectBase, RectangleF>(this.method_93));
			float num = source.Min((RectangleF obj) => obj.X);
			float num2 = source.Min((RectangleF obj) => obj.Y);
			float num3 = source.Max((RectangleF obj) => obj.Right);
			float num4 = source.Max((RectangleF obj) => obj.Bottom);
			RectangleF rectangleF = new RectangleF(num, num2, num3 - num, num4 - num2);
			if (this.rectangleF_0 == RectangleF.Empty)
			{
				this.rectangleF_0 = rectangleF;
				return;
			}
			if (this.rectangleF_0.X > rectangleF.X)
			{
				this.rectangleF_0.Width = this.rectangleF_0.Width + (this.rectangleF_0.X - rectangleF.X);
				this.rectangleF_0.X = rectangleF.X;
			}
			if (this.rectangleF_0.Y > rectangleF.Y)
			{
				this.rectangleF_0.Height = this.rectangleF_0.Height + (this.rectangleF_0.Y - rectangleF.Y);
				this.rectangleF_0.Y = rectangleF.Y;
			}
			if (this.rectangleF_0.X + this.rectangleF_0.Width < rectangleF.X + rectangleF.Width)
			{
				this.rectangleF_0.Width = this.rectangleF_0.Width + (rectangleF.X + rectangleF.Width - (this.rectangleF_0.X + this.rectangleF_0.Width));
			}
			if (this.rectangleF_0.Y + this.rectangleF_0.Height < rectangleF.Y + rectangleF.Height)
			{
				this.rectangleF_0.Height = this.rectangleF_0.Height + (rectangleF.Y + rectangleF.Height - (this.rectangleF_0.Y + this.rectangleF_0.Height));
			}
		}

		internal void method_16(DrawObjectBase drawObjectBase_2)
		{
			this.list_5.Add(drawObjectBase_2);
		}

		internal void method_17(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			LineToolState state = lineToolEventArgs_0.state;
			this.list_4.Remove(state);
			this.lineToolEventHandler_1(lineTool_0, lineToolEventArgs_0);
		}

		internal void method_18(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			LineToolState state = lineToolEventArgs_0.state;
			this.list_4.Add(state);
			this.lineToolEventHandler_0(lineTool_0, lineToolEventArgs_0);
		}

		internal void method_19(object sender, EventArgs e)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(sender, e);
			}
		}

		private void rFaFrHyEir()
		{
			this.method_15();
			float num = float.NaN;
			float num2 = float.NaN;
			float num3 = float.NaN;
			float num4 = float.NaN;
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				if (canvasLayer.Objects.Count<DrawObjectBase>() != 0)
				{
					IEnumerable<RectangleF> source = (from obj in canvasLayer.Objects
					where obj.Visible
					select obj).Select(new Func<DrawObjectBase, RectangleF>(this.method_94));
					float num5 = (from obj in source
					where !float.IsNaN(obj.X)
					select obj).Min((RectangleF obj) => obj.X);
					if (float.IsNaN(num) || num > num5)
					{
						num = num5;
					}
					num5 = (from obj in source
					where !float.IsNaN(obj.Y)
					select obj).Min((RectangleF obj) => obj.Y);
					if (float.IsNaN(num2) || num2 > num5)
					{
						num2 = num5;
					}
					num5 = (from obj in source
					where !float.IsNaN(obj.Right)
					select obj).Max((RectangleF obj) => obj.Right);
					if (float.IsNaN(num3) || num3 < num5)
					{
						num3 = num5;
					}
					num5 = (from obj in source
					where !float.IsNaN(obj.Bottom)
					select obj).Max((RectangleF obj) => obj.Bottom);
					if (float.IsNaN(num4) || num4 < num5)
					{
						num4 = num5;
					}
				}
			}
			if (float.IsNaN(num))
			{
				num = 0f;
			}
			if (float.IsNaN(num2))
			{
				num2 = 0f;
			}
			if (float.IsNaN(num3))
			{
				num3 = 0f;
			}
			if (float.IsNaN(num4))
			{
				num4 = 0f;
			}
			this.rectangleF_0 = new RectangleF(num, num2, num3 - num, num4 - num2);
		}

		protected void HandleSelection(List<DrawObjectBase> selected)
		{
			bool flag = false;
			flag = true;
			if (Control.ModifierKeys != Keys.Control)
			{
				this.ClearSelectedObjects();
			}
			if (selected != null)
			{
				foreach (DrawObjectBase drawObjectBase in selected)
				{
					if (drawObjectBase.Selected)
					{
						this.DeSelectObject(drawObjectBase);
					}
					else
					{
						this.SelectObject(drawObjectBase);
					}
				}
			}
			if (flag)
			{
				this.DoInvalidate(true);
			}
		}

		private void method_20(UnitPoint unitPoint_3)
		{
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				drawObjectBase.Move(unitPoint_3, true);
			}
			this.DoInvalidate(true);
		}

		public bool HandleMouseMoveForMove(UnitPoint mouseunitpoint)
		{
			double x = mouseunitpoint.X - this.unitPoint_1.X;
			double y = mouseunitpoint.Y - this.unitPoint_1.Y;
			if (Control.ModifierKeys == Keys.Shift)
			{
				UnitPoint unitPoint = ConvertCanvas.ConvertToUnit(this, this.pointF_0);
				double value = unitPoint.X - this.unitPoint_1.X;
				double value2 = unitPoint.Y - this.unitPoint_1.Y;
				if (Math.Abs(value) > Math.Abs(value2))
				{
					y = 0.0;
				}
				else if (Math.Abs(value) < Math.Abs(value2))
				{
					x = 0.0;
				}
			}
			UnitPoint offset = new UnitPoint(x, y);
			this.unitPoint_1 = mouseunitpoint;
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				drawObjectBase.Move(offset, true);
				DrawObjectsEventArgs drawObjectsEventArgs = new DrawObjectsEventArgs(drawObjectBase);
				drawObjectsEventArgs.Offset = offset;
				drawObjectsEventArgs.ChangesMode = UndoRedoManager.ChangesMode.Move;
				drawObjectsEventArgs.SelectedMove = true;
				this.drawObjectEventHandler_5(this, drawObjectsEventArgs);
			}
			return true;
		}

		internal void method_21(RectangleF rectangleF_2)
		{
			if (this.staticImage == null)
			{
				return;
			}
			Graphics graphics = Graphics.FromHwnd(base.Handle);
			if (rectangleF_2.X < 0f)
			{
				rectangleF_2.X = 0f;
			}
			if (rectangleF_2.X > (float)this.staticImage.Width)
			{
				rectangleF_2.X = 0f;
			}
			if (rectangleF_2.Y < 0f)
			{
				rectangleF_2.Y = 0f;
			}
			if (rectangleF_2.Y > (float)this.staticImage.Height)
			{
				rectangleF_2.Y = 0f;
			}
			if (rectangleF_2.Width > (float)this.staticImage.Width || rectangleF_2.Width < 0f)
			{
				rectangleF_2.Width = (float)this.staticImage.Width;
			}
			if (rectangleF_2.Height > (float)this.staticImage.Height || rectangleF_2.Height < 0f)
			{
				rectangleF_2.Height = (float)this.staticImage.Height;
			}
			graphics.DrawImage(this.staticImage, rectangleF_2, rectangleF_2, GraphicsUnit.Pixel);
			graphics.Dispose();
		}

		private void method_22(ISnapPoint isnapPoint_1)
		{
			if (isnapPoint_1 == null)
			{
				return;
			}
			this.graphics_0 = Graphics.FromHwnd(base.Handle);
			isnapPoint_1.Draw(this);
		}

		private void method_23(DrawObjectBase drawObjectBase_2)
		{
			if (drawObjectBase_2 == null)
			{
				return;
			}
			this.graphics_0 = Graphics.FromHwnd(base.Handle);
			RectangleF unitrect = ConvertCanvas.ConvertToScreenNormalized(this, drawObjectBase_2.GetBoundingRect(this, true));
			drawObjectBase_2.Draw(this, unitrect, eDrawMode.Color);
		}

		public void CommandPan()
		{
			this.eCommandType_0 = eCommandType.pan;
			this.method_24();
		}

		public void CommandDrawTool(string drawObjectId)
		{
			this.canvasFrame_0 = null;
			this.eCommandType_0 = eCommandType.draw;
			this.string_0 = drawObjectId;
			this.method_24();
		}

		public void CommandEscape()
		{
			this.drawObjectBase_0 = null;
			this.isnapPoint_0 = null;
			this.canvasFrame_0 = null;
			this.eCommandType_0 = eCommandType.select;
			this.DoInvalidate(true);
			this.method_24();
		}

		public void CommandPattern(DrawingLayer pattern)
		{
			this.drawObjectBase_0 = null;
			this.isnapPoint_0 = null;
			this.canvasFrame_0 = null;
			this.eCommandType_0 = eCommandType.pattern;
			this.drawingLayer_0 = pattern;
			this.method_24();
		}

		public void CommandZoomWindow()
		{
			this.drawObjectBase_0 = null;
			this.isnapPoint_0 = null;
			this.eCommandType_0 = eCommandType.zoomWindow;
			this.DoInvalidate(true);
			this.method_24();
		}

		public void CommandDrawFrame()
		{
			this.drawObjectBase_0 = null;
			this.isnapPoint_0 = null;
			this.eCommandType_0 = eCommandType.drawframe;
			this.DoInvalidate(true);
			this.method_24();
		}

		public void CommandFrame()
		{
			this.drawObjectBase_0 = null;
			this.isnapPoint_0 = null;
			this.eCommandType_0 = eCommandType.frame;
			this.DoInvalidate(true);
			this.method_24();
		}

		private void method_24()
		{
			this.Cursor = this.class1_0.method_1(this.eCommandType_0);
		}

		private void method_25()
		{
			new Cursor(Resources.cursor_hand.GetHicon());
			new Cursor(Resources.cursor_drag_hand.GetHicon());
			this.class1_0.method_0(eCommandType.select, Cursors.Arrow);
			this.class1_0.method_0(eCommandType.draw, Cursors.Cross);
			this.class1_0.method_0(eCommandType.pattern, Cursors.Cross);
			this.class1_0.method_0(eCommandType.pan, Cursors.Hand);
			this.class1_0.method_0(eCommandType.move, Cursors.SizeAll);
			this.class1_0.method_0(eCommandType.resizeObj, Cursors.Cross);
			this.class1_0.method_0(eCommandType.zoomWindow, Cursors.Cross);
			this.class1_0.method_0(eCommandType.drawframe, Cursors.Cross);
			this.method_24();
		}

		public void CopySelectedObjects()
		{
			this.list_7.Clear();
			foreach (DrawObjectBase item in this.SelectedObjects)
			{
				this.list_7.Add(item);
			}
		}

		public void PasteInObjects(List<DrawObjectBase> destinationObjects)
		{
			List<DrawObjectBase> list = CopyPasteCanvasObjects.PasteInObjects(destinationObjects, this.list_7);
			if (list.Count > 0)
			{
				this.ClearSelectedObjects();
				List<DrawObjectBase> list2 = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase in list)
				{
					this.AddObject(this.ActiveLayer, drawObjectBase);
					drawObjectBase.CreateUniqueCopyName();
					drawObjectBase.SaveToSql(false, true);
					list2.Add(drawObjectBase);
				}
				UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(list2, UndoRedoManager.ChangesMode.AddObject);
				this.undoRedoManager.HappenedChange(changes);
				this.DoInvalidate(true);
			}
		}

		private void method_26(UnitPoint unitPoint_3)
		{
			List<DrawObjectBase> list = CopyPasteCanvasObjects.PasteSelectedObjects(this.list_7, unitPoint_3);
			if (list.Count > 0)
			{
				this.ClearSelectedObjects();
				List<DrawObjectBase> list2 = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase in list)
				{
					this.AddObject(this.ActiveLayer, drawObjectBase);
					drawObjectBase.CreateUniqueCopyName();
					drawObjectBase.SaveToSql(false, true);
					list2.Add(drawObjectBase);
				}
				UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(list2, UndoRedoManager.ChangesMode.AddObject);
				this.undoRedoManager.HappenedChange(changes);
				this.DoInvalidate(true);
			}
		}

		public void SaveTraining(string nameTraining)
		{
			SqlConnection connection = new SqlConnection(SqlDataConnect.GetConnectionString(this.SqlSettings));
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml("<nameTraining Name = " + nameTraining + "></nameTraining>");
			XmlNode xmlNode = xmlDocument.SelectSingleNode("nameTraining");
			foreach (DrawObjectBase drawObjectBase in from obj in this.icanvasLayer_0.Objects
			where obj is ObjectOnLine && obj.GetType().GetProperty("On").CanWrite
			select obj)
			{
				XmlElement xmlElement = xmlDocument.CreateElement("sch_switch");
				xmlElement.SetAttribute("id", drawObjectBase.IdBase.ToString());
				xmlElement.SetAttribute("On", ((ObjectOnLine)drawObjectBase).On.ToString());
				xmlNode.AppendChild(xmlElement);
			}
			string text = "select top 1 * from tSchm_TrainingSchema where = Name" + nameTraining;
			SqlCommand sqlCommand = new SqlCommand(text, connection);
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			if (sqlDataReader.Read())
			{
				text = "update tSchm_TrainingSchema set TrainingXml = '" + xmlDocument.InnerXml + "' where id = " + sqlDataReader["id"].ToString();
				sqlDataReader.Close();
				sqlCommand.CommandText = text;
				sqlCommand.ExecuteNonQuery();
				return;
			}
			sqlDataReader.Close();
			text = string.Concat(new string[]
			{
				"insert into tSchm_TrainingSchema (Name , TrainingXml) values ('",
				nameTraining,
				"', '",
				xmlDocument.InnerXml,
				"')"
			});
			sqlCommand.CommandText = text;
			sqlCommand.ExecuteNonQuery();
		}

		public void LoadTraining(string nameTraining)
		{
			SqlConnection connection = new SqlConnection(SqlDataConnect.GetConnectionString(this.SqlSettings));
			SqlDataReader sqlDataReader = new SqlCommand("select top 1 * from tSchm_TrainingSchema where = name" + nameTraining, connection).ExecuteReader();
			XmlDocument xmlDocument = new XmlDocument();
			if (sqlDataReader.Read())
			{
				xmlDocument.Load(sqlDataReader["TrainingXml"].ToString());
				foreach (object obj2 in xmlDocument.SelectSingleNode("nameTraining").SelectNodes("sch_switch"))
				{
					XmlNode xmlNode = (XmlNode)obj2;
					try
					{
						int id = Convert.ToInt32(xmlNode.Attributes["id"].Value);
						((ObjectOnLine)this.icanvasLayer_0.Objects.First((DrawObjectBase obj) => obj.IdBase == id)).On = Convert.ToBoolean(xmlNode.Attributes["On"].Value);
					}
					catch
					{
					}
				}
				return;
			}
		}

		private void method_27(UnitPoint unitPoint_3)
		{
			RectangleF rectangleF_ = Rectangle.Empty;
			ISnapPoint snapPoint = null;
			if (this.bool_0)
			{
				snapPoint = this.SnapPoint(unitPoint_3, null, null);
			}
			if (snapPoint == null && this.bool_0)
			{
				snapPoint = this.GridLayer.SnapPoint(this, unitPoint_3, null);
			}
			if (this.isnapPoint_0 != null && (snapPoint == null || snapPoint.SnapPoint != this.isnapPoint_0.SnapPoint || this.isnapPoint_0.GetType() != snapPoint.GetType()))
			{
				rectangleF_ = ConvertCanvas.ConvertToScreenNormalized(this, this.isnapPoint_0.BoundingRect);
				rectangleF_.Inflate(2f, 2f);
				this.method_21(rectangleF_);
				this.isnapPoint_0 = snapPoint;
			}
			Rectangle rc = new Rectangle((int)rectangleF_.Location.X, (int)rectangleF_.Location.Y, (int)rectangleF_.Width, (int)rectangleF_.Height);
			if (this.eCommandType_0 == eCommandType.move)
			{
				base.Invalidate(rc);
			}
			if (this.isnapPoint_0 == null)
			{
				this.isnapPoint_0 = snapPoint;
			}
			if (this.isnapPoint_0 != null)
			{
				this.method_22(this.isnapPoint_0);
			}
		}

		public void OnSimulate()
		{
			foreach (DrawObjectBase drawObjectBase in from obj in this.icanvasLayer_0.Objects
			where obj.GetType() == typeof(ShinaTool) && obj.Parent != null && obj.Parent.GetType() == typeof(RectangleTool) && ((RectangleTool)obj.Parent).TypeRectnagleTool == SchemeCtrl2.DrawTool.eTypeRectangleTool.CP
			select obj)
			{
				((ShinaTool)drawObjectBase).OnAmperage = true;
			}
		}

		public void OffSimulate()
		{
			foreach (DrawObjectBase drawObjectBase in from obj in this.icanvasLayer_0.Objects
			where obj.GetType() == typeof(ShinaTool) && obj.Parent.GetType() == typeof(RectangleTool) && ((RectangleTool)obj.Parent).TypeRectnagleTool == SchemeCtrl2.DrawTool.eTypeRectangleTool.CP
			select obj)
			{
				((ShinaTool)drawObjectBase).OnAmperage = false;
			}
		}

		public void RefreshSimulate()
		{
			this.OffSimulate();
			this.OnSimulate();
		}

		public void SendMessage(string messageText, eMessageType messageType)
		{
			this.canvasMessageEventHandler_0(this, new CanvasMessageEventArgs(messageText, messageType));
		}

		public void SendMessage(DrawObjectBase messageObject, string messageText, eMessageType messageType)
		{
			this.canvasMessageEventHandler_0(this, new CanvasMessageEventArgs(messageObject, messageText, messageType));
		}

		public void SendMessage(List<DrawObjectBase> messageObjects, string messageText, eMessageType messageType)
		{
			this.canvasMessageEventHandler_0(this, new CanvasMessageEventArgs(messageObjects, messageText, messageType));
		}

		public void SendMessage(List<DrawObjectBase> messageObjects, eMessageType messageType, OPCMessage telemetryMessage)
		{
			this.canvasMessageEventHandler_0(this, new CanvasMessageEventArgs(messageObjects, messageType, telemetryMessage));
		}

		public void SendMessage(DrawObjectBase messageObject, string messageText, DataTable logDispatcher)
		{
			this.canvasMessageEventHandler_0(this, new CanvasMessageEventArgs(messageObject, messageText, eMessageType.LogDispatcher, logDispatcher));
		}

		public ISnapPoint SnapPoint(UnitPoint point, Type[] runningsnaptypes, Type usersnaptype)
		{
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects)
				{
					if (this.drawObjectBase_0 != null && this.drawObjectBase_0 == drawObjectBase)
					{
						break;
					}
					if ((this.drawObjectBase_1 == null || this.drawObjectBase_1 != drawObjectBase) && (this.drawObjectBase_1 == null || !this.drawObjectBase_1.HaveContact(drawObjectBase)) && drawObjectBase.GetType().BaseType != typeof(ObjectOnLine))
					{
						ISnapPoint snapPoint = drawObjectBase.SnapPoint(this, point, null, runningsnaptypes, usersnaptype);
						if (snapPoint != null)
						{
							return snapPoint;
						}
					}
				}
			}
			return null;
		}

		public void DeleteObjects(IEnumerable<DrawObjectBase> objects, bool delSql)
		{
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				((DrawingLayer)canvasLayer).DeleteObjects(objects, delSql);
			}
		}

		public float ScreenHeight()
		{
			return (float)(ConvertCanvas.ConvertToUnit(this, (float)base.ClientRectangle.Height) / (double)this.Zoom);
		}

		public void SetCenter(UnitPoint unitPoint)
		{
			PointF screenPoint = ConvertCanvas.ConvertToScreen(this, unitPoint);
			this.SetCenterScreen(screenPoint, false);
		}

		protected void SetCenterScreen(PointF screenPoint, bool setCursor)
		{
			float num = (float)(base.ClientRectangle.Width / 2);
			this.pointF_1.X = this.pointF_1.X + (num - screenPoint.X);
			float num2 = (float)(this.statusStrip.Visible ? ((base.ClientRectangle.Height - this.statusStrip.Height) / 2) : (base.ClientRectangle.Height / 2));
			this.pointF_1.Y = this.pointF_1.Y + (num2 - screenPoint.Y);
			this.unitPoint_0 = this.CenterPointUnit();
			this.method_46();
			if (setCursor)
			{
				Cursor.Position = base.PointToScreen(new Point((int)num, (int)num2));
			}
			base.Invalidate();
		}

		internal void method_28(RectangleF rectangleF_2, bool bool_12)
		{
			if (rectangleF_2.Width <= 0f)
			{
				rectangleF_2.Width = 1f;
			}
			if (rectangleF_2.Height <= 0f)
			{
				rectangleF_2.Height = 1f;
			}
			if (bool_12)
			{
				RectangleF rectangleF = ConvertCanvas.ConvertToUnitNormalized(this, base.ClientRectangle);
				float num;
				if (rectangleF_2.Height / rectangleF_2.Width <= rectangleF.Height / rectangleF.Width)
				{
					num = 1.1f * rectangleF_2.Width / rectangleF.Width;
				}
				else
				{
					num = 1.1f * rectangleF_2.Height / rectangleF.Height;
				}
				this.Zoom /= num;
			}
			PointF p = new PointF(rectangleF_2.X + rectangleF_2.Width / 2f, rectangleF_2.Y + rectangleF_2.Height / 2f);
			this.SetCenter(new UnitPoint(p));
			this.DoInvalidate(true);
		}

		public bool SetObjectsInCenterScreen(List<int> idObjects, bool adaptZoom, CanvasControl.SetObjectsInCenterScreenOptions backlight)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			Func<DrawObjectBase, bool> <>9__0;
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				List<DrawObjectBase> list2 = list;
				IEnumerable<DrawObjectBase> objects = canvasLayer.Objects;
				Func<DrawObjectBase, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((DrawObjectBase dob) => idObjects.Contains(dob.IdBase)));
				}
				list2.AddRange(objects.Where(predicate));
			}
			if (list.Count > 0)
			{
				this.SetObjectsInCenterScreen(list, adaptZoom, backlight);
				return true;
			}
			return false;
		}

		public void SetObjectsInCenterScreen(List<DrawObjectBase> drawObjects, bool adaptZoom, CanvasControl.SetObjectsInCenterScreenOptions option)
		{
			if (drawObjects.Count == 0)
			{
				return;
			}
			this.Graphics = Graphics.FromHwnd(base.Handle);
			if (option != CanvasControl.SetObjectsInCenterScreenOptions.none)
			{
				this.ClearSelectedObjects();
				this.ClearFlashingObjects();
			}
			float num = float.NaN;
			float num2 = float.NaN;
			float num3 = float.NaN;
			float num4 = float.NaN;
			List<RectangleF> list = new List<RectangleF>();
			foreach (DrawObjectBase drawObjectBase in drawObjects)
			{
				if (option != CanvasControl.SetObjectsInCenterScreenOptions.select)
				{
					if (option == CanvasControl.SetObjectsInCenterScreenOptions.flashing)
					{
						this.AddFlashObject(drawObjectBase);
					}
				}
				else
				{
					this.SelectObject(drawObjectBase);
				}
				list.Add(drawObjectBase.GetBoundingRect(this, false));
				if ((drawObjectBase is ShinaTool || drawObjectBase is LineCellTool) && drawObjectBase.Parent != null && drawObjectBase.Parent.Visible)
				{
					list.Add(drawObjectBase.Parent.GetBoundingRect(this, false));
				}
			}
			float num5 = (from obj in list
			where !float.IsNaN(obj.X)
			select obj).Min((RectangleF obj) => obj.X);
			if (float.IsNaN(num) || num > num5)
			{
				num = num5;
			}
			num5 = (from obj in list
			where !float.IsNaN(obj.Y)
			select obj).Min((RectangleF obj) => obj.Y);
			if (float.IsNaN(num2) || num2 > num5)
			{
				num2 = num5;
			}
			num5 = (from obj in list
			where !float.IsNaN(obj.Right)
			select obj).Max((RectangleF obj) => obj.Right);
			if (float.IsNaN(num3) || num3 < num5)
			{
				num3 = num5;
			}
			num5 = (from obj in list
			where !float.IsNaN(obj.Bottom)
			select obj).Max((RectangleF obj) => obj.Bottom);
			if (float.IsNaN(num4) || num4 < num5)
			{
				num4 = num5;
			}
			if (float.IsNaN(num))
			{
				num = 0f;
			}
			if (float.IsNaN(num2))
			{
				num2 = 0f;
			}
			if (float.IsNaN(num3))
			{
				num3 = 0f;
			}
			if (float.IsNaN(num4))
			{
				num4 = 0f;
			}
			RectangleF rectangleF_ = new RectangleF(num, num2, num3 - num, num4 - num2);
			this.method_28(rectangleF_, adaptZoom);
		}

		public void SetObjectsInCenterScreen(DrawObjectBase drawObject, bool adaptZoom, CanvasControl.SetObjectsInCenterScreenOptions backlight)
		{
			this.SetObjectsInCenterScreen(new List<DrawObjectBase>
			{
				drawObject
			}, adaptZoom, backlight);
		}

		internal PointTool method_29(UnitPoint unitPoint_3)
		{
			foreach (ICanvasLayer canvasLayer in this.list_0.Reverse<ICanvasLayer>())
			{
				if (canvasLayer.Visible)
				{
					foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects.Reverse<DrawObjectBase>())
					{
						if (this.drawObjectBase_0 != drawObjectBase && this.drawObjectBase_1 != drawObjectBase && (drawObjectBase.GetType() == typeof(LineCellTool) || drawObjectBase.GetType() == typeof(LineTool)))
						{
							foreach (PointTool pointTool in ((LineTool)drawObjectBase).Ends)
							{
								if (pointTool.PointInObject(unitPoint_3))
								{
									return pointTool;
								}
							}
						}
					}
				}
			}
			return null;
		}

		public UnitPoint CenterPointUnit()
		{
			UnitPoint unitPoint = ConvertCanvas.ConvertToUnit(this, new PointF(0f, 0f));
			UnitPoint unitPoint2 = ConvertCanvas.ConvertToUnit(this, new PointF((float)base.ClientRectangle.Width, (float)base.ClientRectangle.Height));
			return new UnitPoint
			{
				X = (unitPoint.X + unitPoint2.X) / 2.0,
				Y = (unitPoint.Y + unitPoint2.Y) / 2.0
			};
		}

		public void FitToScreen()
		{
			this.rFaFrHyEir();
			Rectangle clientRectangle = base.ClientRectangle;
			if (this.statusStrip.Visible)
			{
				clientRectangle.Height -= this.statusStrip.Height;
			}
			RectangleF rectangleF = ConvertCanvas.ConvertToUnitNormalized(this, clientRectangle);
			float num;
			if (this.rectangleF_0.Height / this.rectangleF_0.Width <= rectangleF.Height / rectangleF.Width)
			{
				num = this.rectangleF_0.Width / rectangleF.Width;
			}
			else
			{
				num = this.rectangleF_0.Height / rectangleF.Height;
			}
			if (num != 0f)
			{
				this.Zoom /= num;
			}
			else
			{
				this.Zoom = 1f;
			}
			PointF p = new PointF(this.rectangleF_0.X + this.rectangleF_0.Width / 2f, this.rectangleF_0.Y + this.rectangleF_0.Height / 2f);
			this.SetCenter(new UnitPoint(p));
			this.DoInvalidate(true);
		}

		public void DoInvalidate(bool dostatic)
		{
			if (dostatic)
			{
				this.staticRepaint = true;
			}
			base.Invalidate();
		}

		public void DoInvalidate(bool dostatic, RectangleF rect)
		{
			if (dostatic)
			{
				this.staticRepaint = true;
			}
			base.Invalidate(new Rectangle((int)rect.Left, (int)rect.Top, (int)rect.Width, (int)rect.Height));
		}

		public static DrawObjectBase CreateObject(string objecttype)
		{
			if (CanvasControl.dictionary_1.ContainsKey(objecttype))
			{
				return CanvasControl.dictionary_1[objecttype].Clone(false);
			}
			return null;
		}

		public DrawObjectBase CreateObject(string type, UnitPoint point, ISnapPoint snappoint)
		{
			DrawingLayer drawingLayer = this.ActiveLayer as DrawingLayer;
			if (!drawingLayer.Enabled)
			{
				return null;
			}
			DrawObjectBase drawObjectBase = CanvasControl.CreateObject(type);
			if (drawObjectBase != null)
			{
				if (drawObjectBase.GetType() == typeof(ShinaTool) && drawingLayer.Parent != null && drawingLayer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
				{
					((ShinaTool)drawObjectBase).TypeShinaTool = SchemeCtrl2.DrawTool.eTypeShinaTool.Shina_04;
				}
				drawObjectBase.Layer = drawingLayer;
				drawObjectBase.InitializeFromModel(point, drawingLayer, snappoint);
				drawObjectBase.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
			}
			return drawObjectBase;
		}

		public void AddObject(ICanvasLayer layer, DrawObjectBase drawobject)
		{
			((DrawingLayer)layer).AddObject(drawobject);
			if (drawobject.Selected)
			{
				this.SelectObject(drawobject);
			}
		}

		internal void method_30(DrawObjectBase drawObjectBase_2)
		{
			if (!drawObjectBase_2.Selected && this.list_1.Contains(drawObjectBase_2))
			{
				this.list_1.Remove(drawObjectBase_2);
			}
		}

		public List<DrawObjectBase> GetHitObjects(UnitPoint point)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			this.Graphics = Graphics.FromHwnd(base.Handle);
			Func<DrawObjectBase, bool> <>9__0;
			foreach (ICanvasLayer canvasLayer in this.list_0.Reverse<ICanvasLayer>())
			{
				if (canvasLayer.Visible)
				{
					IEnumerable<DrawObjectBase> source = canvasLayer.Objects.Reverse<DrawObjectBase>();
					Func<DrawObjectBase, bool> predicate;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((DrawObjectBase obj) => obj != this.drawObjectBase_0 && obj.Visible && obj.PointInObject(point)));
					}
					IEnumerable<DrawObjectBase> collection = source.Where(predicate);
					list.AddRange(collection);
				}
			}
			return list;
		}

		public List<DrawObjectBase> GetHitObjects(CanvasControl canvas, RectangleF selection, bool anyPoint)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			Func<DrawObjectBase, bool> <>9__0;
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				if (canvasLayer.Visible)
				{
					IEnumerable<DrawObjectBase> objects = canvasLayer.Objects;
					Func<DrawObjectBase, bool> predicate;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((DrawObjectBase obj) => obj.ObjectInRectangle(canvas, selection, anyPoint)));
					}
					IEnumerable<DrawObjectBase> collection = objects.Where(predicate);
					list.AddRange(collection);
				}
			}
			return list;
		}

		public bool IsSelected(DrawObjectBase drawobject)
		{
			return this.list_1.Contains(drawobject);
		}

		public void SelectObject(DrawObjectBase drawobject)
		{
			if (!drawobject.Visible)
			{
				return;
			}
			this.DeSelectObject(drawobject);
			this.list_1.Add(drawobject);
			drawobject.Selected = true;
			this.propertyGrid1.SelectedObject = drawobject;
		}

		public void DeSelectObject(DrawObjectBase drawobject)
		{
			if (this.list_1.Contains(drawobject))
			{
				drawobject.Selected = false;
				this.list_1.Remove(drawobject);
			}
		}

		public void ClearSelectedObjects()
		{
			if (this.bool_5)
			{
				this.ClearFlashingObjects();
				this.bool_5 = false;
			}
			while (this.SelectedCount > 0)
			{
				DrawObjectBase drawObjectBase = this.SelectedObjects.First<DrawObjectBase>();
				drawObjectBase.Selected = false;
				if (drawObjectBase is BranchCollection)
				{
					this.list_1.Remove(drawObjectBase);
				}
				if (this.list_1.Contains(drawObjectBase))
				{
					this.list_1.Remove(drawObjectBase);
				}
			}
			this.list_1.Clear();
			this.propertyGrid1.SelectedObject = null;
		}

		public void AddInHightLightedList(DrawObjectBase drawobject)
		{
			if (!drawobject.Visible)
			{
				return;
			}
			this.list_2.Add(drawobject);
			drawobject.Highlighted = true;
		}

		public void ClearHightLightedList()
		{
			foreach (DrawObjectBase drawObjectBase in this.list_2)
			{
				drawObjectBase.Highlighted = false;
			}
			this.list_2.Clear();
		}

		public void AddLayer(DrawingLayer layer)
		{
			layer.Parent = this;
			this.list_0.Add(layer);
			layer.ObjectsAdded += this.method_31;
			layer.ObjectsRemoved += this.xOeFuedJon;
			if (this.ActiveLayer == null)
			{
				this.ActiveLayer = layer;
			}
		}

		public void ClearLayers()
		{
			this.list_0.Clear();
		}

		private void xOeFuedJon(List<DrawObjectBase> list_9)
		{
			this.OnObjectsRemoved(list_9);
		}

		private void method_31(List<DrawObjectBase> list_9)
		{
			this.OnObjectsAdded(list_9);
		}

		public void AddBookMark(List<DrawObjectBase> bookmark)
		{
			foreach (DrawObjectBase drawObjectBase in bookmark)
			{
				drawObjectBase.Bookmark = bookmark;
			}
			this.list_6.Add(bookmark);
		}

		public void ClearBookmarks()
		{
			if (this.list_6.Count == 0)
			{
				return;
			}
			foreach (List<DrawObjectBase> list in this.list_6)
			{
				foreach (DrawObjectBase drawObjectBase in list)
				{
					drawObjectBase.Bookmark = null;
				}
				list.Clear();
			}
			this.list_6.Clear();
			this.oaOsGeahQk = 0;
		}

		public void NextBookmark()
		{
			if (this.list_6.Count == 0)
			{
				return;
			}
			if (this.oaOsGeahQk + 1 < this.list_6.Count)
			{
				this.oaOsGeahQk++;
				List<DrawObjectBase> drawObjects = this.list_6[this.oaOsGeahQk];
				this.SetObjectsInCenterScreen(drawObjects, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
				return;
			}
			this.oaOsGeahQk = 0;
			List<DrawObjectBase> drawObjects2 = this.list_6[this.oaOsGeahQk];
			this.SetObjectsInCenterScreen(drawObjects2, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
		}

		public void PrevBookmark()
		{
			if (this.list_6.Count == 0)
			{
				return;
			}
			if (this.oaOsGeahQk == 0)
			{
				this.oaOsGeahQk = this.list_6.Count - 1;
				List<DrawObjectBase> drawObjects = this.list_6[this.oaOsGeahQk];
				this.SetObjectsInCenterScreen(drawObjects, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
				return;
			}
			if (this.oaOsGeahQk - 1 < this.list_6.Count)
			{
				this.oaOsGeahQk--;
				List<DrawObjectBase> drawObjects2 = this.list_6[this.oaOsGeahQk];
				this.SetObjectsInCenterScreen(drawObjects2, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
				return;
			}
			this.oaOsGeahQk = this.list_6.Count - 1;
			List<DrawObjectBase> drawObjects3 = this.list_6[this.oaOsGeahQk];
			this.SetObjectsInCenterScreen(drawObjects3, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
		}

		public void CurrentBookmark()
		{
			if (this.list_6.Count == 0)
			{
				return;
			}
			if (this.oaOsGeahQk < this.list_6.Count)
			{
				List<DrawObjectBase> drawObjects = this.list_6[this.oaOsGeahQk];
				this.SetObjectsInCenterScreen(drawObjects, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
				return;
			}
			this.oaOsGeahQk = this.list_6.Count - 1;
			List<DrawObjectBase> drawObjects2 = this.list_6[this.oaOsGeahQk];
			this.SetObjectsInCenterScreen(drawObjects2, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
		}

		public bool ValidateToUnique(DrawObjectBase validateObj)
		{
			if (validateObj is LabelTool)
			{
				return true;
			}
			Func<DrawObjectBase, bool> <>9__0;
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				IEnumerable<DrawObjectBase> objects = canvasLayer.Objects;
				Func<DrawObjectBase, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((DrawObjectBase objj) => objj.Parent == validateObj.Parent));
				}
				objects.Where(predicate);
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					if (validateObj != drawObjectBase)
					{
						if (validateObj is ObjectOnLine && validateObj.GetType() == drawObjectBase.GetType() && ((Branch)((ObjectOnLine)validateObj).Parent).CouplingRelation == ((Branch)((ObjectOnLine)drawObjectBase).Parent).CouplingRelation && validateObj.Text == drawObjectBase.Text)
						{
							return false;
						}
						if (validateObj.GetType() == drawObjectBase.GetType() && validateObj != null && drawObjectBase != null && validateObj.Parent == drawObjectBase.Parent && validateObj.Text == drawObjectBase.Text && (validateObj.GetType() != typeof(RectangleTool) || ((RectangleTool)validateObj).TypeRectnagleTool == ((RectangleTool)drawObjectBase).TypeRectnagleTool) && (validateObj.GetType() != typeof(ShinaTool) || ((ShinaTool)validateObj).TypeShinaTool == ((ShinaTool)drawObjectBase).TypeShinaTool))
						{
							if (validateObj.GetType() == typeof(LineCellTool))
							{
								if (((LineCellTool)validateObj).Type != ((LineCellTool)drawObjectBase).Type)
								{
									continue;
								}
							}
							return false;
						}
					}
				}
			}
			return true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.textBoxSearch.Text.Trim() == string.Empty)
			{
				return;
			}
			int id = 0;
			try
			{
				id = Convert.ToInt32(this.textBoxSearch.Text.Trim());
			}
			catch
			{
				return;
			}
			DrawObjectBase drawObjectBase = this.FindObjectById(id);
			if (drawObjectBase != null)
			{
				this.SetObjectsInCenterScreen(drawObjectBase, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
			}
		}

		private List<LineCellTool> method_32(LineTool lineTool_0, List<LineTool> list_9)
		{
			if (list_9 == null)
			{
				list_9 = new List<LineTool>();
			}
			list_9.Add(lineTool_0);
			List<LineCellTool> list = new List<LineCellTool>();
			Func<CouplingRelation, bool> <>9__1;
			foreach (PointTool pointTool in from p in lineTool_0.Ends
			where p.CouplingRelations.Count > 1
			select p)
			{
				IEnumerable<CouplingRelation> couplingRelations = pointTool.CouplingRelations;
				Func<CouplingRelation, bool> predicate;
				if ((predicate = <>9__1) == null)
				{
					predicate = (<>9__1 = ((CouplingRelation c) => !list_9.Contains(c.Line)));
				}
				foreach (CouplingRelation couplingRelation in couplingRelations.Where(predicate))
				{
					if (couplingRelation.Line.GetType() == typeof(LineCellTool))
					{
						list.Add((LineCellTool)couplingRelation.Line);
					}
					else
					{
						list.AddRange(this.method_32(couplingRelation.Line, list_9));
					}
				}
			}
			return list;
		}

		private void bigBoldButton_Click(object sender, EventArgs e)
		{
			if (this.SelectedObjects.Count<DrawObjectBase>() == 1 && this.SelectedObjects.First<DrawObjectBase>() is LineTool)
			{
				MessageBox.Show(((LineTool)this.SelectedObjects.First<DrawObjectBase>()).GenerateNameForCabelLine());
			}
			ElectricModel electricModel = new ElectricModel();
			electricModel.SqlSettings = this.sqlsettings_0;
			electricModel.LoadSchema(false);
			foreach (ElectricObject electricObject in electricModel.Objects)
			{
				int id = electricObject.Id;
			}
			this.DoInvalidate(true);
		}

		public TreeNodeObj PoweringReportForDrawObject(DrawObjectBase obj, bool forwardDirection)
		{
			if (obj is RectangleTool)
			{
				return this.method_33((RectangleTool)obj, forwardDirection);
			}
			if (obj is ShinaTool)
			{
				return this.method_34((ShinaTool)obj, forwardDirection);
			}
			if (obj is LineTool)
			{
				return this.method_35((LineTool)obj, forwardDirection);
			}
			return new TreeNodeObj
			{
				Tag = obj
			};
		}

		private TreeNodeObj method_33(RectangleTool rectangleTool_0, bool bool_12)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = rectangleTool_0;
			foreach (DrawObjectBase drawObjectBase in from obj in rectangleTool_0.ChildObjects
			where obj.GetType() == typeof(ShinaTool) && ((ShinaTool)obj).Amperage != null
			select obj)
			{
				treeNodeObj.AddNode(this.method_34((ShinaTool)drawObjectBase, bool_12));
			}
			return treeNodeObj;
		}

		private TreeNodeObj method_34(ShinaTool shinaTool_0, bool bool_12)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = shinaTool_0;
			if (shinaTool_0.Amperage == null)
			{
				return treeNodeObj;
			}
			if (bool_12)
			{
				using (List<Amperage>.Enumerator enumerator = shinaTool_0.Amperage.NextAmperages.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Amperage amperage_ = enumerator.Current;
						this.method_36(amperage_, treeNodeObj);
					}
					return treeNodeObj;
				}
			}
			List<DrawObjectBase> list = this.method_41(shinaTool_0);
			if (list == null)
			{
				return treeNodeObj;
			}
			TreeNodeObj treeNodeObj_ = treeNodeObj;
			foreach (DrawObjectBase drawObjectBase in list)
			{
				TreeNodeObj treeNodeObj2;
				if (drawObjectBase.GetType() == typeof(BranchCollection))
				{
					treeNodeObj2 = this.method_37(treeNodeObj_, ((BranchCollection)drawObjectBase).Parent);
				}
				else
				{
					treeNodeObj2 = this.method_37(treeNodeObj_, drawObjectBase);
				}
				if (treeNodeObj2 != null)
				{
					treeNodeObj_ = treeNodeObj2;
				}
			}
			return treeNodeObj;
		}

		private TreeNodeObj method_35(LineTool lineTool_0, bool bool_12)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = lineTool_0;
			foreach (Amperage amperage in lineTool_0.Amperages.Values)
			{
				if (bool_12)
				{
					using (List<Amperage>.Enumerator enumerator2 = amperage.NextAmperages.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Amperage amperage_ = enumerator2.Current;
							this.method_36(amperage_, treeNodeObj);
						}
						continue;
					}
				}
				List<DrawObjectBase> powerSource = amperage.GetPowerSource();
				TreeNodeObj treeNodeObj_ = treeNodeObj;
				foreach (DrawObjectBase drawObjectBase in powerSource)
				{
					TreeNodeObj treeNodeObj2;
					if (drawObjectBase.GetType() == typeof(BranchCollection))
					{
						treeNodeObj2 = this.method_37(treeNodeObj_, ((BranchCollection)drawObjectBase).Parent);
					}
					else
					{
						treeNodeObj2 = this.method_37(treeNodeObj_, drawObjectBase);
					}
					if (treeNodeObj2 != null)
					{
						treeNodeObj_ = treeNodeObj2;
					}
				}
			}
			return treeNodeObj;
		}

		private void method_36(Amperage amperage_0, TreeNodeObj treeNodeObj_0)
		{
			TreeNodeObj treeNodeObj = this.method_37(treeNodeObj_0, amperage_0.Conductor);
			if (treeNodeObj == null)
			{
				return;
			}
			foreach (Amperage amperage_ in amperage_0.NextAmperages)
			{
				this.method_36(amperage_, treeNodeObj);
			}
		}

		private TreeNodeObj method_37(TreeNodeObj treeNodeObj_0, DrawObjectBase drawObjectBase_2)
		{
			DrawObjectBase drawObjectBase;
			if (drawObjectBase_2.GetType() == typeof(Branch))
			{
				drawObjectBase = drawObjectBase_2.Parent;
			}
			else
			{
				drawObjectBase = drawObjectBase_2;
			}
			if (drawObjectBase != treeNodeObj_0.Tag)
			{
				TreeNodeObj treeNodeObj = treeNodeObj_0.AddNode();
				treeNodeObj.Tag = drawObjectBase;
				return treeNodeObj;
			}
			return null;
		}

		private void method_38(StreamWriter streamWriter_0, TreeNode treeNode_0, string string_5)
		{
			if (treeNode_0.Tag.GetType() == typeof(LineCellTool))
			{
				if (((DrawObjectBase)treeNode_0.Parent.Tag).GetType() == typeof(LineTool) && ((LineTool)treeNode_0.Parent.Tag).ParRectangle() == null)
				{
					if (string_5.Length > 0)
					{
						string_5 += ";";
					}
					string_5 = string_5 + ((DrawObjectBase)treeNode_0.Tag).Parent.ToString() + ":" + ((DrawObjectBase)treeNode_0.Tag).ToString();
					streamWriter_0.WriteLine(string_5);
					string_5 = string.Empty;
				}
				if (((DrawObjectBase)treeNode_0.Parent.Tag).GetType() == typeof(ShinaTool))
				{
					bool flag = false;
					foreach (object obj in treeNode_0.Nodes)
					{
						TreeNode treeNode = (TreeNode)obj;
						if (treeNode.Tag.GetType() == typeof(LineTool) && ((LineTool)treeNode.Tag).ParRectangle() == null)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						string_5 = string_5 + ((DrawObjectBase)treeNode_0.Tag).Parent.ToString() + ":" + ((DrawObjectBase)treeNode_0.Tag).ToString();
					}
				}
			}
			if (treeNode_0.Nodes.Count > 0)
			{
				foreach (object obj2 in treeNode_0.Nodes)
				{
					TreeNode treeNode_ = (TreeNode)obj2;
					this.method_38(streamWriter_0, treeNode_, string_5);
				}
			}
		}

		private TreeNode method_39(TreeView treeView_0, DrawObjectBase drawObjectBase_2)
		{
			DrawObjectBase drawObjectBase;
			if (drawObjectBase_2.GetType() == typeof(Branch))
			{
				drawObjectBase = drawObjectBase_2.Parent;
			}
			else
			{
				drawObjectBase = drawObjectBase_2;
			}
			TreeNode treeNode = treeView_0.Nodes.Add(drawObjectBase.Text);
			treeNode.Tag = drawObjectBase;
			return treeNode;
		}

		private TreeNode method_40(TreeNode treeNode_0, DrawObjectBase drawObjectBase_2)
		{
			DrawObjectBase drawObjectBase;
			if (drawObjectBase_2.GetType() == typeof(Branch))
			{
				drawObjectBase = drawObjectBase_2.Parent;
			}
			else
			{
				drawObjectBase = drawObjectBase_2;
			}
			if (drawObjectBase != treeNode_0.Tag)
			{
				TreeNode treeNode = treeNode_0.Nodes.Add(drawObjectBase.Text);
				treeNode.Tag = drawObjectBase;
				return treeNode;
			}
			return null;
		}

		private List<DrawObjectBase> method_41(ShinaTool shinaTool_0)
		{
			if (shinaTool_0.Amperage != null)
			{
				return shinaTool_0.Amperage.GetPowerSource();
			}
			return null;
		}

		private void method_42(Amperage amperage_0, TreeNode treeNode_0)
		{
			TreeNode treeNode_ = this.method_40(treeNode_0, amperage_0.Conductor);
			foreach (Amperage amperage_ in amperage_0.NextAmperages)
			{
				this.method_42(amperage_, treeNode_);
			}
		}

		public void ForBigBoldButton2()
		{
			new List<TextBranchTool>();
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects.Reverse<DrawObjectBase>())
				{
				}
			}
		}

		public void ForBigBoldButton()
		{
		}

		public void ZoomIn()
		{
			UnitPoint point = this.CenterPointUnit();
			if (this.Zoom < 0.25f)
			{
				if (this.Zoom > 0.125f)
				{
					this.Zoom = 0.25f;
				}
				else
				{
					this.Zoom *= 2f;
				}
			}
			else
			{
				this.Zoom += 0.25f;
			}
			if (point.X < (double)this.rectangleF_0.X)
			{
				point.X = (double)this.rectangleF_0.X;
			}
			if (point.Y < (double)this.rectangleF_0.Y)
			{
				point.Y = (double)this.rectangleF_0.Y;
			}
			if (point.X > (double)this.rectangleF_0.Right)
			{
				point.X = (double)this.rectangleF_0.Right;
			}
			if (point.Y > (double)this.rectangleF_0.Bottom)
			{
				point.Y = (double)this.rectangleF_0.Bottom;
			}
			this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, point), false);
			this.DoInvalidate(true);
		}

		public void ZoomOut()
		{
			UnitPoint point = this.CenterPointUnit();
			if (this.Zoom > 0.25f)
			{
				this.Zoom -= 0.25f;
			}
			else
			{
				this.Zoom /= 2f;
			}
			if (point.X < (double)this.rectangleF_0.X)
			{
				point.X = (double)this.rectangleF_0.X;
			}
			if (point.Y < (double)this.rectangleF_0.Y)
			{
				point.Y = (double)this.rectangleF_0.Y;
			}
			if (point.X > (double)this.rectangleF_0.Right)
			{
				point.X = (double)this.rectangleF_0.Right;
			}
			if (point.Y > (double)this.rectangleF_0.Bottom)
			{
				point.Y = (double)this.rectangleF_0.Bottom;
			}
			this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, point), false);
			this.DoInvalidate(true);
		}

		public void SetZoom(float newZoom)
		{
			UnitPoint point = this.CenterPointUnit();
			this.Zoom = Convert.ToSingle(newZoom);
			this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, point), false);
			this.DoInvalidate(true);
		}

		public void ZoomInSymbols()
		{
			this.Settings.ZoomInFontSize();
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects)
				{
					if (!drawObjectBase.UseSettingsText)
					{
						drawObjectBase.TextProperty.FontSize += 0.5f;
					}
				}
			}
			this.DoInvalidate(true);
		}

		public void ZoomOutSymbols()
		{
			this.Settings.ZoomOutFontSize();
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects)
				{
					if (!drawObjectBase.UseSettingsText)
					{
						drawObjectBase.TextProperty.FontSize -= 0.5f;
					}
				}
			}
			this.DoInvalidate(true);
		}

		private void method_43()
		{
			this.control0_0 = new Control0();
			this.control0_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.control0_0.BorderStyle = BorderStyle.Fixed3D;
			this.control0_0.method_104(this);
			this.control0_0.Width = (int)((float)base.Width * this.control0_0.method_107());
			this.control0_0.Height = (int)((float)base.Height * this.control0_0.method_109());
			this.control0_0.Location = new Point(base.Width - this.control0_0.Width, base.Height - this.control0_0.Height - this.statusStrip.Height);
			this.control0_0.method_106(ConvertCanvas.ConvertToUnitNormalized(this, base.ClientRectangle));
			base.Controls.Add(this.control0_0);
		}

		private void method_44()
		{
			if (this.control0_0 != null)
			{
				if (base.Controls.Contains(this.control0_0))
				{
					base.Controls.Remove(this.control0_0);
				}
				this.control0_0 = null;
			}
		}

		private void method_45()
		{
			if (this.control0_0 != null)
			{
				this.control0_0.Width = (int)((float)base.Width * this.control0_0.method_107());
				this.control0_0.Height = (int)((float)base.Height * this.control0_0.method_109());
				this.control0_0.Location = new Point(base.Width - this.control0_0.Width, base.Height - this.control0_0.Height - this.statusStrip.Height);
				this.control0_0.method_106(ConvertCanvas.ConvertToUnitNormalized(this, base.ClientRectangle));
			}
		}

		private void method_46()
		{
			if (this.control0_0 != null)
			{
				this.control0_0.method_106(ConvertCanvas.ConvertToUnitNormalized(this, base.ClientRectangle));
			}
		}

		public void CopyToImage()
		{
			if (this.SelectedCount <= 0 && this.canvasFrame_0 == null)
			{
				return;
			}
			this.method_15();
			RectangleF rectUnit;
			if (this.canvasFrame_0 == null)
			{
				float num = float.NaN;
				float num2 = float.NaN;
				float num3 = float.NaN;
				float num4 = float.NaN;
				IEnumerable<RectangleF> source = (from obj in this.SelectedObjects
				where obj.Visible
				select obj).Select(new Func<DrawObjectBase, RectangleF>(this.method_95));
				float num5 = (from obj in source
				where !float.IsNaN(obj.X)
				select obj).Min((RectangleF obj) => obj.X);
				if (float.IsNaN(num) || num > num5)
				{
					num = num5;
				}
				num5 = (from obj in source
				where !float.IsNaN(obj.Y)
				select obj).Min((RectangleF obj) => obj.Y);
				if (float.IsNaN(num2) || num2 > num5)
				{
					num2 = num5;
				}
				num5 = (from obj in source
				where !float.IsNaN(obj.Right)
				select obj).Max((RectangleF obj) => obj.Right);
				if (float.IsNaN(num3) || num3 < num5)
				{
					num3 = num5;
				}
				num5 = (from obj in source
				where !float.IsNaN(obj.Bottom)
				select obj).Max((RectangleF obj) => obj.Bottom);
				if (float.IsNaN(num4) || num4 < num5)
				{
					num4 = num5;
				}
				if (float.IsNaN(num))
				{
					num = 0f;
				}
				if (float.IsNaN(num2))
				{
					num2 = 0f;
				}
				if (float.IsNaN(num3))
				{
					num3 = 0f;
				}
				if (float.IsNaN(num4))
				{
					num4 = 0f;
				}
				rectUnit = new RectangleF(num, num2, num3 - num, num4 - num2);
			}
			else
			{
				this.canvasFrame_0.Normalize();
				rectUnit = this.canvasFrame_0.Rectangle;
			}
			RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(this, rectUnit);
			if (this.canvasFrame_0 == null)
			{
				rectUnit.Inflate(new SizeF(3f, 3f));
			}
			CanvasControl canvasControl = new CanvasControl();
			canvasControl.Size = new Size((int)rectangleF.Width, Math.Abs((int)rectangleF.Height));
			if (this.canvasFrame_0 == null)
			{
				canvasControl.SetObjectsInCenterScreen(this.SelectedObjects.ToList<DrawObjectBase>(), true, CanvasControl.SetObjectsInCenterScreenOptions.none);
			}
			else
			{
				canvasControl.method_28(rectUnit, true);
			}
			canvasControl.SetCenter(new UnitPoint((double)(rectUnit.X + rectUnit.Width / 2f), (double)(rectUnit.Y + rectUnit.Height / 2f)));
			canvasControl.DoInvalidate(true);
			Bitmap bitmap = new Bitmap((int)rectangleF.Width, Math.Abs((int)rectangleF.Height));
			canvasControl.Graphics = Graphics.FromImage(bitmap);
			canvasControl.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, (int)rectangleF.Width, (int)rectangleF.Height));
			if (this.canvasFrame_0 != null)
			{
				RectangleF rectangleF2 = ConvertCanvas.ConvertToScreenNormalized(canvasControl, rectUnit);
				canvasControl.Graphics.ExcludeClip(new Rectangle(0, 0, (int)rectangleF2.X, canvasControl.Size.Height));
				canvasControl.Graphics.ExcludeClip(new Rectangle(0, 0, canvasControl.Size.Width, (int)rectangleF2.Y));
				canvasControl.Graphics.ExcludeClip(new Rectangle((int)(rectangleF2.X + rectangleF2.Width), 0, canvasControl.Size.Width - (int)(rectangleF2.X + rectangleF2.Width), canvasControl.Size.Height));
				canvasControl.Graphics.ExcludeClip(new Rectangle(0, (int)(rectangleF2.Y + rectangleF2.Height), canvasControl.Size.Width, canvasControl.Size.Height - (int)(rectangleF2.Y + rectangleF2.Height)));
			}
			if (this.canvasFrame_0 == null)
			{
				using (IEnumerator<DrawObjectBase> enumerator = this.SelectedObjects.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DrawObjectBase drawObjectBase = enumerator.Current;
						drawObjectBase.DrawPrint(canvasControl, canvasControl.Graphics, false);
					}
					goto IL_569;
				}
			}
			Func<DrawObjectBase, bool> <>9__10;
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				IEnumerable<DrawObjectBase> objects = ((DrawingLayer)canvasLayer).Objects;
				Func<DrawObjectBase, bool> predicate;
				if ((predicate = <>9__10) == null)
				{
					predicate = (<>9__10 = ((DrawObjectBase obj) => obj != null && obj.ObjectInRectangle(this, rectUnit, true)));
				}
				foreach (DrawObjectBase drawObjectBase2 in objects.Where(predicate))
				{
					drawObjectBase2.Draw(canvasControl, rectUnit, eDrawMode.Print);
				}
			}
			IL_569:
			Clipboard.SetImage(bitmap);
			bitmap.Dispose();
		}

		public void ExportToImage(string fileName)
		{
			this.rFaFrHyEir();
			this.method_28(this.rectangleF_0, true);
			RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(this, this.rectangleF_0);
			rectangleF.Width *= 30f;
			rectangleF.Height *= 30f;
			CanvasControl canvasControl = new CanvasControl();
			canvasControl.Size = new Size((int)rectangleF.Width, Math.Abs((int)rectangleF.Height));
			canvasControl.method_28(this.rectangleF_0, true);
			canvasControl.DoInvalidate(true);
			Bitmap bitmap = new Bitmap((int)rectangleF.Width, Math.Abs((int)rectangleF.Height));
			canvasControl.Graphics = Graphics.FromImage(bitmap);
			canvasControl.BackgroundLayer.Draw(this, this.rectangleF_0);
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects)
				{
					drawObjectBase.Draw(canvasControl, this.rectangleF_0, eDrawMode.Color);
				}
			}
			bitmap.Save(fileName, ImageFormat.Jpeg);
			bitmap.Dispose();
		}

		public void ExportToImage()
		{
			if (this.canvasFrame_0 != null)
			{
				RectangleF rectangleF = ConvertCanvas.ConvertToScreen(this, this.canvasFrame_0.Rectangle);
				Size oldSizeImage = new Size((int)rectangleF.Width, (int)rectangleF.Height);
				FormExportCanvasToImage formExportCanvasToImage = new FormExportCanvasToImage();
				formExportCanvasToImage.Canvas = this;
				this.canvasFrame_0.Normalize();
				formExportCanvasToImage.RectangleIamge = this.canvasFrame_0.Rectangle;
				formExportCanvasToImage.OldSizeImage = oldSizeImage;
				formExportCanvasToImage.ShowDialog();
			}
		}

		public void method_47(string fileName)
		{
			DxfDocument dxfDocument = new DxfDocument();
			if (this.SelectedCount <= 0)
			{
				using (IEnumerator<ICanvasLayer> enumerator = this.Layers.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ICanvasLayer canvasLayer = enumerator.Current;
						foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects.Reverse<DrawObjectBase>())
						{
							this.Graphics = Graphics.FromHwnd(base.Handle);
							drawObjectBase.vmethod_3(this, dxfDocument);
						}
					}
					goto IL_C3;
				}
			}
			foreach (DrawObjectBase drawObjectBase2 in this.SelectedObjects)
			{
				this.Graphics = Graphics.FromHwnd(base.Handle);
				drawObjectBase2.vmethod_3(this, dxfDocument);
			}
			IL_C3:
			dxfDocument.Save(fileName, 1);
		}

		private void buttonCheck_Click(object sender, EventArgs e)
		{
			this.method_72();
		}

		private void method_48(Point point_1)
		{
			List<DrawObjectBase> hitObjects = this.GetHitObjects(ConvertCanvas.ConvertToUnit(this, point_1));
			if (hitObjects.Count > 0 && this.sqlsettings_0 != null)
			{
				if (hitObjects[0].GetType() == typeof(RectangleTool) && hitObjects[0].Selected)
				{
					if (!this.panelPassport_0.Visible)
					{
						this.panelPassport_0.Show(this.sqlsettings_0, hitObjects[0].IdBase, hitObjects[0].ToString() + "(" + hitObjects[0].IdBase.ToString() + ")");
						if (point_1.X + this.panelPassport_0.Width + 20 > base.Width)
						{
							this.panelPassport_0.Left = point_1.X - this.panelPassport_0.Width;
						}
						else
						{
							this.panelPassport_0.Left = point_1.X;
						}
						if (point_1.Y < this.panelPassport_0.Height)
						{
							this.panelPassport_0.Top = point_1.Y;
						}
						else
						{
							this.panelPassport_0.Top = point_1.Y - this.panelPassport_0.Height;
						}
						this.panelPassport_0.PageEndColor = Color.LightGray;
						this.panelPassport_0.PageStartColor = Color.White;
						this.panelPassport_0.Visible = true;
						this.panelPassport_0.BringToFront();
						return;
					}
				}
				else if (!this.tbPopup.Visible)
				{
					if (hitObjects[0].GetType() == typeof(LineTool))
					{
						this.tbPopup.Text = "";
						foreach (string str in ((LineTool)hitObjects[0]).GetDestinations())
						{
							Label label = this.tbPopup;
							label.Text = label.Text + str + "\n";
						}
						DrawObjectBase[] array = ((LineTool)hitObjects[0]).GetPowerSource(((LineTool)hitObjects[0]).SelectedBranch).ToArray();
						List<DrawObjectBase> list = new List<DrawObjectBase>();
						for (int i = 0; i < array.Length - 1; i++)
						{
							if (array[i].GetType() == typeof(BranchCollection))
							{
								LineTool lineTool = (LineTool)((BranchCollection)array[i]).Parent;
								if (!list.Contains(lineTool) && lineTool != null && lineTool.GetType() == typeof(LineCellTool) && array[i + 1].GetType() == typeof(ShinaTool) && (((RectangleTool)lineTool.Parent).TypeRectnagleTool == SchemeCtrl2.DrawTool.eTypeRectangleTool.RP || ((RectangleTool)lineTool.Parent).TypeRectnagleTool == SchemeCtrl2.DrawTool.eTypeRectangleTool.CP))
								{
									Label label2 = this.tbPopup;
									label2.Text += "\n";
									string str2 = string.Concat(new string[]
									{
										lineTool.Parent.ToString(),
										"  /  ",
										array[i + 1].ToString(),
										"  /  ",
										lineTool.ToString()
									});
									Label label3 = this.tbPopup;
									label3.Text += str2;
									list.Add(lineTool);
								}
							}
						}
					}
					else if (hitObjects[0].GetType() == typeof(TelemetryLabelTool))
					{
						this.tbPopup.Text = ((TelemetryLabelTool)hitObjects[0]).FullText;
						DrawObjectBase drawObjectBase = ((TelemetryLabelTool)hitObjects[0]).Layer.Parent.FindObjectById(((TelemetryLabelTool)hitObjects[0]).ObjectTelemetry);
						if (drawObjectBase != null)
						{
							this.tbPopup.Text = drawObjectBase.GetFullName() + "\r\n" + this.tbPopup.Text;
						}
					}
					else if (hitObjects[0].GetType() == typeof(NodeTool))
					{
						this.tbPopup.Text = hitObjects[0].StripText;
					}
					else
					{
						this.tbPopup.Text = hitObjects[0].StripText;
					}
					if (point_1.X + this.tbPopup.Width + 20 > base.Width)
					{
						this.tbPopup.Left = point_1.X - this.tbPopup.Width - 1;
					}
					else
					{
						this.tbPopup.Left = point_1.X + 1;
					}
					if (point_1.Y < this.tbPopup.Height + 2)
					{
						this.tbPopup.Top = point_1.Y + this.tbPopup.Height + 1;
					}
					else
					{
						this.tbPopup.Top = point_1.Y - this.tbPopup.Height - 1;
					}
					this.tbPopup.Visible = true;
					this.tbPopup.BringToFront();
				}
			}
		}

		private void method_49()
		{
			Control control = this.panelPassport_0;
			this.tbPopup.Visible = false;
			control.Visible = false;
		}

		private void timer_1_Tick(object sender, EventArgs e)
		{
			this.int_3++;
			if (this.int_3 == 1)
			{
				this.xFfsyLeRmd = this.point_0;
			}
			if (this.point_0 == this.xFfsyLeRmd && this.eMouseControlState_0 == eMouseControlState.OnControl && Control.MouseButtons == MouseButtons.None)
			{
				this.method_48(this.xFfsyLeRmd);
				if (this.timer_1.Enabled)
				{
					this.timer_1.Stop();
				}
			}
			if (this.int_3 > 1 && this.timer_1.Enabled)
			{
				this.timer_1.Stop();
			}
		}

		private void method_50()
		{
			this.tFlash.Interval = 500;
			this.tFlash.Enabled = false;
			this.tFlash.Tick += this.tFlash_Tick;
		}

		private void tFlash_Tick(object sender, EventArgs e)
		{
			this.ConvertColorFlash = !this.ConvertColorFlash;
			this.DoInvalidate(false);
		}

		public void AddFlashObject(DrawObjectBase obj)
		{
			if (!this.tFlash.Enabled)
			{
				this.tFlash.Start();
			}
			obj.Flashing = true;
			if (!this.list_3.Contains(obj))
			{
				this.list_3.Add(obj);
				if (this.drawObjectEventHandler_8 != null)
				{
					this.drawObjectEventHandler_8(this, new DrawObjectsEventArgs(obj));
				}
			}
		}

		public void ClearFlashingObjects()
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.list_3)
			{
				drawObjectBase.Flashing = false;
				list.Add(drawObjectBase);
			}
			this.list_3.Clear();
			if (this.drawObjectEventHandler_9 != null)
			{
				this.drawObjectEventHandler_9(this, new DrawObjectsEventArgs(list));
			}
			this.tFlash.Stop();
		}

		private void toolBtnZoom25_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			if (toolStripMenuItem.Tag != null)
			{
				UnitPoint point = this.CenterPointUnit();
				this.Zoom = Convert.ToSingle(toolStripMenuItem.Tag) / 100f;
				this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, point), false);
				this.DoInvalidate(true);
			}
		}

		private void toolTxtZoomChanged_KeyDown(object sender, KeyEventArgs e)
		{
			float value;
			if (e.KeyCode == Keys.Return && float.TryParse(this.toolTxtZoomChanged.Text, out value))
			{
				UnitPoint point = this.CenterPointUnit();
				this.Zoom = Convert.ToSingle(value) / 100f;
				this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, point), false);
				this.DoInvalidate(true);
				this.toolBtnZoom.HideDropDown();
			}
		}

		public static bool GetAlternativePower(DrawObjectBase dob, TreeNodeObj currentNode, Dictionary<DrawObjectBase, bool> l)
		{
			if (currentNode.Level > 700)
			{
				return false;
			}
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = dob;
			currentNode.AddNode(treeNodeObj);
			bool flag = false;
			l.Add(dob, false);
			if (dob.GetType() != typeof(LineTool))
			{
				if (dob.GetType() != typeof(LineCellTool))
				{
					if (dob.GetType() != typeof(ShinaTool))
					{
						goto IL_781;
					}
					if (((ShinaTool)dob).Amperage != null && ((ShinaTool)dob).Amperage.Source == dob)
					{
						flag = true;
						goto IL_781;
					}
					using (IEnumerator<DrawObjectBase> enumerator = (from o in ((ShinaTool)dob).ChildObjects
					where o is PointTool
					select o).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							DrawObjectBase drawObjectBase = enumerator.Current;
							PointTool pointTool = (PointTool)drawObjectBase;
							bool flag2 = false;
							foreach (Branch branch in pointTool.Branches)
							{
								if (currentNode.Level == 0 && ((ShinaTool)dob).Amperage != null)
								{
									using (IEnumerator<Amperage> enumerator3 = ((ShinaTool)dob).Amperage.method_0().GetEnumerator())
									{
										while (enumerator3.MoveNext())
										{
											Amperage amperage = enumerator3.Current;
											if (branch.Parent == amperage.Conductor)
											{
												flag2 = true;
												break;
											}
										}
										goto IL_1BF;
									}
									goto IL_16B;
									IL_1BF:
									if (flag2)
									{
										break;
									}
								}
								IL_16B:
								if (l.ContainsKey(branch.Parent))
								{
									if (l[branch.Parent] && !CanvasControl.smethod_1(branch.Parent, currentNode))
									{
										flag = true;
									}
								}
								else if (CanvasControl.GetAlternativePower(branch.Parent, treeNodeObj, l))
								{
									flag = true;
								}
							}
						}
						goto IL_781;
					}
				}
			}
			PointTool pointTool2 = null;
			Dictionary<PointTool, bool> dictionary = new Dictionary<PointTool, bool>();
			bool flag3 = false;
			foreach (PointTool pointTool3 in ((LineTool)dob).Ends)
			{
				if (pointTool3.Parent != null && pointTool3.Parent.GetType() == typeof(ShinaTool))
				{
					if (currentNode.Tag == pointTool3.Parent)
					{
						pointTool2 = pointTool3;
					}
					else
					{
						dictionary.Add(pointTool3, false);
					}
				}
				else
				{
					foreach (Branch branch2 in pointTool3.Branches)
					{
						if (branch2.Parent != dob)
						{
							if (branch2.Parent == currentNode.Tag)
							{
								pointTool2 = pointTool3;
								break;
							}
							dictionary.Add(pointTool3, false);
							break;
						}
					}
				}
			}
			if (pointTool2 != null)
			{
				List<PointTool> list = new List<PointTool>();
				list.AddRange(dictionary.Keys);
				foreach (PointTool pointTool4 in list)
				{
					foreach (Branch branch3 in ((LineTool)dob).GetWayOnLineTool(pointTool2, pointTool4).Collection)
					{
						foreach (DrawObjectBase drawObjectBase2 in branch3.ChildObjects)
						{
							if (drawObjectBase2.GetType().BaseType == typeof(ObjectOnLine) && !((ObjectOnLine)drawObjectBase2).On && ((LineTool)dob).Amperages.ContainsKey(pointTool4))
							{
								dictionary[pointTool4] = true;
								flag3 = true;
							}
							else if (drawObjectBase2.GetType().BaseType == typeof(ObjectOnLine) && !((ObjectOnLine)drawObjectBase2).On && !((LineTool)dob).Amperages.ContainsKey(pointTool4))
							{
								dictionary.Remove(pointTool4);
							}
						}
					}
				}
			}
			List<PointTool> list2 = new List<PointTool>();
			list2.AddRange(dictionary.Keys);
			foreach (PointTool pointTool5 in list2)
			{
				if (dictionary[pointTool5])
				{
					if (pointTool5.Parent != null && pointTool5.Parent.GetType() == typeof(ShinaTool) && ((ShinaTool)pointTool5.Parent).Amperage != null)
					{
						List<DrawObjectBase> powerSource = ((ShinaTool)pointTool5.Parent).Amperage.GetPowerSource();
						if (powerSource != null && powerSource.Count > 0)
						{
							TreeNodeObj treeNodeObj2 = treeNodeObj;
							foreach (DrawObjectBase drawObjectBase3 in powerSource)
							{
								TreeNodeObj treeNodeObj3 = new TreeNodeObj();
								treeNodeObj3.Tag = drawObjectBase3;
								treeNodeObj2.AddNode(treeNodeObj3);
								treeNodeObj2 = treeNodeObj3;
								l[drawObjectBase3] = true;
							}
							flag = true;
						}
						else
						{
							dictionary[pointTool5] = false;
						}
					}
					else
					{
						bool flag4 = false;
						foreach (Branch branch4 in pointTool5.Branches)
						{
							if (branch4.Parent != dob)
							{
								List<DrawObjectBase> powerSource2 = branch4.Parent.GetPowerSource();
								if (powerSource2 != null && powerSource2.Count > 0)
								{
									TreeNodeObj treeNodeObj4 = treeNodeObj;
									foreach (DrawObjectBase drawObjectBase4 in powerSource2)
									{
										TreeNodeObj treeNodeObj5 = new TreeNodeObj();
										treeNodeObj5.Tag = drawObjectBase4;
										treeNodeObj4.AddNode(treeNodeObj5);
										treeNodeObj4 = treeNodeObj5;
										l[drawObjectBase4] = true;
									}
									flag = true;
									if (!flag4)
									{
										flag4 = true;
									}
								}
							}
						}
						dictionary[pointTool5] = flag4;
					}
				}
				else if (!flag3)
				{
					if (pointTool5.Parent != null && pointTool5.Parent.GetType() == typeof(ShinaTool))
					{
						if (l.ContainsKey(pointTool5.Parent))
						{
							if (l[pointTool5.Parent] && !CanvasControl.smethod_1(pointTool5.Parent, currentNode))
							{
								dictionary[pointTool5] = true;
								flag = true;
							}
							else if (!l[pointTool5.Parent] && CanvasControl.smethod_1(pointTool5.Parent, currentNode) && ((LineTool)dob).Ends.Count<PointTool>() == 2)
							{
								l.Remove(dob);
								break;
							}
						}
						else if (CanvasControl.GetAlternativePower(pointTool5.Parent, treeNodeObj, l))
						{
							flag = true;
							dictionary[pointTool5] = true;
						}
					}
					else
					{
						foreach (Branch branch5 in pointTool5.Branches)
						{
							if (branch5.Parent == null || branch5.Parent != dob)
							{
								if (l.ContainsKey(branch5.Parent))
								{
									if (l[branch5.Parent] && !CanvasControl.smethod_1(branch5.Parent, currentNode))
									{
										dictionary[pointTool5] = true;
										flag = true;
									}
								}
								else if (CanvasControl.GetAlternativePower(branch5.Parent, treeNodeObj, l))
								{
									flag = true;
									dictionary[pointTool5] = true;
								}
							}
						}
					}
				}
			}
			IL_781:
			if (!flag)
			{
				currentNode.RemoveNode(treeNodeObj);
			}
			if (l.ContainsKey(dob))
			{
				l[dob] = flag;
			}
			return flag;
		}

		public static bool GetAllPower(DrawObjectBase dob, TreeNodeObj currentNode, Dictionary<DrawObjectBase, bool> l)
		{
			if (currentNode.Level > 700)
			{
				return false;
			}
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = dob;
			currentNode.AddNode(treeNodeObj);
			bool flag = false;
			l.Add(dob, false);
			if (dob.GetType() != typeof(LineTool))
			{
				if (dob.GetType() != typeof(LineCellTool))
				{
					if (dob.GetType() != typeof(ShinaTool))
					{
						goto IL_3A0;
					}
					if (((ShinaTool)dob).Amperage != null && ((ShinaTool)dob).Amperage.Source == dob)
					{
						flag = true;
						goto IL_3A0;
					}
					using (IEnumerator<DrawObjectBase> enumerator = ((ShinaTool)dob).ChildObjects.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							DrawObjectBase drawObjectBase = enumerator.Current;
							foreach (Branch branch in ((PointTool)drawObjectBase).Branches)
							{
								if (branch.Parent == null || branch.Parent != currentNode.Tag)
								{
									if (l.ContainsKey(branch.Parent))
									{
										if (l[branch.Parent] && !CanvasControl.smethod_1(branch.Parent, currentNode))
										{
											flag = true;
										}
									}
									else if (CanvasControl.GetAllPower(branch.Parent, treeNodeObj, l))
									{
										flag = true;
									}
								}
							}
						}
						goto IL_3A0;
					}
				}
			}
			PointTool pointTool = null;
			List<PointTool> list = new List<PointTool>();
			foreach (PointTool pointTool2 in ((LineTool)dob).Ends)
			{
				if (pointTool2.Parent != null && pointTool2.Parent.GetType() == typeof(ShinaTool))
				{
					if (currentNode.Tag == pointTool2.Parent)
					{
						pointTool = pointTool2;
					}
					else if (l.ContainsKey(pointTool2.Parent))
					{
						if (l[pointTool2.Parent] && !CanvasControl.smethod_1(pointTool2.Parent, currentNode))
						{
							list.Add(pointTool2);
							flag = true;
						}
						else if (!l[pointTool2.Parent] && CanvasControl.smethod_1(pointTool2.Parent, currentNode) && ((LineTool)dob).Ends.Count<PointTool>() == 2)
						{
							l.Remove(dob);
							break;
						}
					}
					else if (CanvasControl.GetAllPower(pointTool2.Parent, treeNodeObj, l))
					{
						flag = true;
						list.Add(pointTool2);
					}
				}
				else
				{
					foreach (Branch branch2 in pointTool2.Branches)
					{
						if (branch2.Parent == null || branch2.Parent != dob)
						{
							if (branch2.Parent == currentNode.Tag)
							{
								pointTool = pointTool2;
							}
							else if (l.ContainsKey(branch2.Parent))
							{
								if (l[branch2.Parent] && !CanvasControl.smethod_1(branch2.Parent, currentNode))
								{
									list.Add(pointTool2);
									flag = true;
								}
							}
							else if (CanvasControl.GetAllPower(branch2.Parent, treeNodeObj, l))
							{
								flag = true;
								list.Add(pointTool2);
							}
						}
					}
				}
			}
			if (pointTool == null)
			{
				treeNodeObj.Tag = dob;
			}
			else
			{
				BranchCollection branchCollection = new BranchCollection();
				foreach (PointTool pt in list)
				{
					BranchCollection wayOnLineTool = ((LineTool)dob).GetWayOnLineTool(pointTool, pt);
					branchCollection += wayOnLineTool;
				}
				treeNodeObj.Tag = branchCollection;
			}
			IL_3A0:
			if (!flag)
			{
				currentNode.RemoveNode(treeNodeObj);
			}
			if (l.ContainsKey(dob))
			{
				l[dob] = flag;
			}
			return flag;
		}

		public static List<DrawObjectBase> GetAdjacentSubstation(DrawObjectBase dob)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			if (dob.GetType() == typeof(RectangleTool))
			{
				using (IEnumerator<DrawObjectBase> enumerator = dob.ChildObjects.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DrawObjectBase drawObjectBase = enumerator.Current;
						if (drawObjectBase is LineCellTool)
						{
							list.AddRange(CanvasControl.smethod_0((LineTool)drawObjectBase, null));
						}
					}
					return list;
				}
			}
			if (dob.GetType() == typeof(ShinaTool))
			{
				foreach (DrawObjectBase drawObjectBase2 in dob.ChildObjects)
				{
					if (drawObjectBase2.GetType() == typeof(PointShinaTool) && ((PointShinaTool)drawObjectBase2).CouplingRelations.Count > 0)
					{
						LineTool lineTool = (LineTool)((PointShinaTool)drawObjectBase2).Branches.First<Branch>().Parent;
						bool flag = true;
						using (IEnumerator<PointTool> enumerator2 = lineTool.Ends.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								PointTool pointTool = enumerator2.Current;
								if (pointTool.Parent != null)
								{
									if (pointTool.Parent.GetType() == typeof(ShinaTool))
									{
										continue;
									}
								}
								flag = false;
								break;
							}
							goto IL_147;
						}
						IL_134:
						list.AddRange(CanvasControl.smethod_0(lineTool, null));
						continue;
						IL_147:
						if (!flag)
						{
							goto IL_134;
						}
					}
				}
			}
			return list;
		}

		private static List<DrawObjectBase> smethod_0(LineTool lineTool_0, PointTool pointTool_0)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (PointTool pointTool in lineTool_0.Ends)
			{
				if (pointTool != pointTool_0)
				{
					if (pointTool.Parent != null && pointTool.Parent != lineTool_0 && pointTool.Parent.Parent != null && pointTool.Parent.Parent.GetType() == typeof(RectangleTool))
					{
						list.Add(pointTool.Parent.Parent);
						list.AddRange(pointTool.Parent.Parent.ChildObjects);
						list.Add(lineTool_0);
					}
					else if (pointTool.Parent == null || pointTool.Parent == lineTool_0)
					{
						foreach (Branch branch in pointTool.Branches)
						{
							if (branch.Parent != lineTool_0)
							{
								list.AddRange(CanvasControl.smethod_0((LineTool)branch.Parent, pointTool));
							}
						}
					}
				}
			}
			return list;
		}

		private static bool smethod_1(DrawObjectBase drawObjectBase_2, TreeNodeObj treeNodeObj_0)
		{
			TreeNodeObj treeNodeObj = treeNodeObj_0;
			while (treeNodeObj.Tag != drawObjectBase_2)
			{
				if (treeNodeObj.Parent == null)
				{
					return false;
				}
				treeNodeObj = treeNodeObj.Parent;
			}
			return true;
		}

		private bool method_51()
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			sqlDataConnect.OpenConnection(this.SqlSettings);
			SqlDataReader sqlDataReader = new SqlCommand("sp_sysgetlockedtable", sqlDataConnect.Connection)
			{
				CommandType = CommandType.StoredProcedure
			}.ExecuteReader();
			while (sqlDataReader.Read())
			{
				if (sqlDataReader["ObjName"].ToString() == this.class22_0.tSchm_Lock.TableName)
				{
					MessageBox.Show("Другой пользователь находится в монопольном режиме редактирования.\nПользователь: " + sqlDataReader["LoginName"].ToString().Trim() + "\nХост: " + sqlDataReader["HostName"].ToString().Trim());
					sqlDataConnect.CloseConnection();
					return true;
				}
			}
			sqlDataConnect.CloseConnection();
			return false;
		}

		private bool method_52()
		{
			if (!this.method_51())
			{
				this.class22_0.tSchm_Lock.Clear();
				this.class22_0.tSchm_Lock.NewRow();
				this.class22_0.tSchm_Lock.Rows.Add(new object[0]);
				new SqlDataCommand(this.SqlSettings).InsertSqlData(this.class22_0, this.class22_0.tSchm_Lock);
				this.class22_0.tSchm_Lock.Clear();
				SqlDataConnect sqlDataConnect = new SqlDataConnect();
				sqlDataConnect.OpenConnection(this.SqlSettings);
				this.sqlTransaction_0 = sqlDataConnect.Connection.BeginTransaction();
				new SqlDataAdapter(new SqlCommand
				{
					Connection = sqlDataConnect.Connection,
					Transaction = this.sqlTransaction_0,
					CommandText = "SELECT * FROM tSchm_Lock WITH(Serializable)"
				}).Fill(this.class22_0, this.class22_0.tSchm_Lock.TableName);
				MessageBox.Show("Вы вошли в монопольный режим редактирования");
				return true;
			}
			return false;
		}

		private void method_53()
		{
			if (this.sqlTransaction_0 != null)
			{
				try
				{
					this.sqlTransaction_0.Commit();
				}
				catch
				{
				}
			}
		}

		internal void method_54(DrawObjectBase drawObjectBase_2, bool bool_12)
		{
			if (drawObjectBase_2.GetType().BaseType == typeof(ObjectOnLine))
			{
				ObjectOnLineServer objectOnLineServer = new ObjectOnLineServer();
				objectOnLineServer.Id = drawObjectBase_2.IdBase;
				objectOnLineServer.Delta = Convert.ToSingle(((ObjectOnLine)drawObjectBase_2).Delta);
				objectOnLineServer.On = ((ObjectOnLine)drawObjectBase_2).On;
				objectOnLineServer.GorMirror = ((ObjectOnLine)drawObjectBase_2).GorMirror;
				objectOnLineServer.VertMirror = ((ObjectOnLine)drawObjectBase_2).VertMirror;
				if (drawObjectBase_2.GetType() == typeof(DischargerTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.DischargerTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(FuseTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.FuseTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(GroundingTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.GroundingTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(LinearDisconnectorTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.LinearDisconnectorTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(LoadSwitchTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.LoadSwitchTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(LubricantSwitchTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.LubricantSwitchTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(NotPhasedTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.NotPhasedTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(OffTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.OffTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(OutsideLineDisconnectorTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.OutsideLineDisconnectorTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(TransformerTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.TransformerTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(VacuumSwitchTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.VacuumSwitchTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(VoltageLimiterTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.VoltageLimiterTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(VoltageTransformerTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.VoltageTransformerTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(DamageTool))
				{
					objectOnLineServer.TypeObjectOnLine = SchemeCtrl2.DrawTool.TypeSwitch.DamageTool;
					return;
				}
			}
			else
			{
				ObjectBaseServer objectBaseServer = new ObjectBaseServer();
				objectBaseServer.Id = drawObjectBase_2.IdBase;
				if (drawObjectBase_2.Parent != null)
				{
					objectBaseServer.Id = drawObjectBase_2.Parent.IdBase;
				}
				else
				{
					objectBaseServer.Id = -1;
				}
				if (drawObjectBase_2.GetType() != typeof(RectangleTool))
				{
					if (drawObjectBase_2.GetType() != typeof(ShinaTool))
					{
						if (drawObjectBase_2.GetType() == typeof(PointTool))
						{
							objectBaseServer.TypeTransferObject = eTypeTransferObject.Point;
							objectBaseServer.ListPoints.Add(((PointTool)drawObjectBase_2).Point);
							return;
						}
						if (drawObjectBase_2.GetType() == typeof(LineCellTool) || drawObjectBase_2.GetType() == typeof(LineTool))
						{
							if (drawObjectBase_2.GetType() == typeof(LineCellTool))
							{
								objectBaseServer.TypeTransferObject = eTypeTransferObject.Cell;
							}
							else
							{
								objectBaseServer.TypeTransferObject = eTypeTransferObject.Line;
							}
							List<PointTool> pointsList = ((LineTool)drawObjectBase_2).GetPointsList();
							foreach (PointTool pointTool in pointsList)
							{
								PointServerTool pointServerTool = new PointServerTool();
								pointServerTool.Point = pointTool.Point;
								pointServerTool.Id = pointTool.IdBase;
								objectBaseServer.ListPointsTool.Add(pointServerTool);
							}
							foreach (CouplingRelation couplingRelation in ((LineTool)drawObjectBase_2).CouplingRelations)
							{
								RelationServer item = default(RelationServer);
								item.id = couplingRelation.Id;
								item.SourcePoint = couplingRelation.method_1().IdBase;
								item.DestenationPoint = couplingRelation.method_2().IdBase;
								objectBaseServer.Relations.Add(item);
							}
							foreach (Branch branch in ((LineTool)drawObjectBase_2).Branches)
							{
								BranchServer branchServer = default(BranchServer);
								branchServer.type = branch.Type;
								branchServer.SourcePoint = pointsList.IndexOf(branch.Source);
								branchServer.DestenationPoint = pointsList.IndexOf(branch.Destination);
								branchServer.Relation = branch.CouplingRelation.Id;
								branchServer.childObjects = new List<int>();
								foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
								{
									if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine))
									{
										if (!((ObjectOnLine)drawObjectBase).MappingState)
										{
											branchServer.childObjects.Add(drawObjectBase.IdBase);
										}
										else
										{
											if (branchServer.States == null)
											{
												branchServer.States = new List<LineStateServer>();
											}
											LineStateServer item2 = default(LineStateServer);
											item2.type = (int)((ObjectOnLine)drawObjectBase).State.state;
											item2.delta = Convert.ToSingle(((ObjectOnLine)drawObjectBase).Delta);
											item2.VertMirror = ((ObjectOnLine)drawObjectBase).VertMirror;
											item2.GorMirror = ((ObjectOnLine)drawObjectBase).GorMirror;
											branchServer.States.Add(item2);
										}
									}
								}
								objectBaseServer.Branches.Add(branchServer);
							}
							return;
						}
						return;
					}
				}
				foreach (DrawObjectBase drawObjectBase2 in drawObjectBase_2.ChildObjects)
				{
					objectBaseServer.ChildrenObjects.Add(drawObjectBase2.IdBase);
				}
				if (drawObjectBase_2.GetType() == typeof(RectangleTool))
				{
					objectBaseServer.ListPoints.Add(new UnitPoint(((RectangleTool)drawObjectBase_2).Rectangle.Location));
					objectBaseServer.ListPoints.Add(new UnitPoint(((RectangleTool)drawObjectBase_2).Rectangle.Location + ((RectangleTool)drawObjectBase_2).Rectangle.Size));
					objectBaseServer.TypeRectangle = ((RectangleTool)drawObjectBase_2).TypeRectnagleTool;
					objectBaseServer.TypeTransferObject = eTypeTransferObject.Rectangle;
					return;
				}
				objectBaseServer.ListPoints.Add(((ShinaTool)drawObjectBase_2).P1);
				objectBaseServer.ListPoints.Add(((ShinaTool)drawObjectBase_2).P2);
				objectBaseServer.TypeTransferObject = eTypeTransferObject.Shina;
				objectBaseServer.TypeShina = ((ShinaTool)drawObjectBase_2).TypeShinaTool;
				return;
			}
		}

		public DrawObjectBase FindObjectById(int id)
		{
			DrawObjectBase drawObjectBase = null;
			Func<DrawObjectBase, bool> <>9__0;
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				try
				{
					IEnumerable<DrawObjectBase> objects = canvasLayer.Objects;
					Func<DrawObjectBase, bool> predicate;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((DrawObjectBase o) => o.IdBase == id));
					}
					drawObjectBase = objects.Single(predicate);
					if (drawObjectBase != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
			return drawObjectBase;
		}

		private List<DrawObjectBase> method_55(DrawObjectBase drawObjectBase_2)
		{
			List<DrawObjectBase> displayObjectList = new List<DrawObjectBase>();
			if (this.eTypeCanvas_0 != eTypeCanvas.SchemeSecond)
			{
				return displayObjectList;
			}
			if (drawObjectBase_2.LimitedEditing)
			{
				displayObjectList.Add(drawObjectBase_2.Master);
				return displayObjectList;
			}
			RectangleTool rectangleTool = null;
			using (IEnumerator<ICanvasLayer> enumerator = this.Layers.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					using (IEnumerator<DrawObjectBase> enumerator2 = (from o in ((DrawingLayer)enumerator.Current).Objects
					where o is RectangleTool
					select o).GetEnumerator())
					{
						if (enumerator2.MoveNext())
						{
							rectangleTool = (RectangleTool)enumerator2.Current;
						}
					}
					if (rectangleTool != null)
					{
						break;
					}
				}
			}
			if (rectangleTool == null || rectangleTool.Master == null)
			{
				return null;
			}
			if (rectangleTool.Master.Layer.Parent.Mode != eCanvasEditingMode.Edit)
			{
				return displayObjectList;
			}
			if (rectangleTool == drawObjectBase_2)
			{
				displayObjectList.Add(drawObjectBase_2.Master);
				return displayObjectList;
			}
			IEnumerable<DrawObjectBase> childObjects = rectangleTool.Master.ChildObjects;
			Func<DrawObjectBase, bool> <>9__1;
			Func<DrawObjectBase, bool> predicate;
			if ((predicate = <>9__1) == null)
			{
				predicate = (<>9__1 = ((DrawObjectBase o) => o.IdBase != -1 && o.IdBase == drawObjectBase_2.IdBase));
			}
			using (IEnumerator<DrawObjectBase> enumerator2 = childObjects.Where(predicate).GetEnumerator())
			{
				if (enumerator2.MoveNext())
				{
					DrawObjectBase item = enumerator2.Current;
					displayObjectList.Add(item);
					return displayObjectList;
				}
			}
			IEnumerable<DrawObjectBase> objects = rectangleTool.Master.Layer.Objects;
			Func<DrawObjectBase, bool> <>9__2;
			Func<DrawObjectBase, bool> predicate2;
			if ((predicate2 = <>9__2) == null)
			{
				predicate2 = (<>9__2 = ((DrawObjectBase o) => o.IdBase != -1 && o.IdBase == drawObjectBase_2.IdBase));
			}
			using (IEnumerator<DrawObjectBase> enumerator2 = objects.Where(predicate2).GetEnumerator())
			{
				if (enumerator2.MoveNext())
				{
					DrawObjectBase item2 = enumerator2.Current;
					displayObjectList.Add(item2);
					return displayObjectList;
				}
			}
			if (drawObjectBase_2 is ShinaTool)
			{
				if (((ShinaTool)drawObjectBase_2).TypeShinaTool == SchemeCtrl2.DrawTool.eTypeShinaTool.Shina_10 || ((ShinaTool)drawObjectBase_2).TypeShinaTool == SchemeCtrl2.DrawTool.eTypeShinaTool.Shina_6)
				{
					ShinaTool shinaTool = new ShinaTool();
					shinaTool.IdBase = drawObjectBase_2.IdBase;
					shinaTool.Text = drawObjectBase_2.Text;
					shinaTool.P1 = new UnitPoint((double)((RectangleTool)rectangleTool.Master).Rectangle.X, (double)((RectangleTool)rectangleTool.Master).Rectangle.Y);
					shinaTool.P2 = new UnitPoint((double)(((RectangleTool)rectangleTool.Master).Rectangle.X + 1f), (double)((RectangleTool)rectangleTool.Master).Rectangle.Y);
					shinaTool.Parent = rectangleTool.Master;
					shinaTool.TypeShinaTool = ((ShinaTool)drawObjectBase_2).TypeShinaTool;
					rectangleTool.Master.Layer.AddObject(shinaTool);
					shinaTool.LimitedEditing = true;
					rectangleTool.Master.Layer.Parent.DoInvalidate(true);
					displayObjectList.Add(shinaTool);
				}
				return displayObjectList;
			}
			if (drawObjectBase_2.GetType() == typeof(LineCellTool))
			{
				if (((LineCellTool)drawObjectBase_2).Type == SchemeCtrl2.DrawTool.LineToolType.CellLine_10 || ((LineCellTool)drawObjectBase_2).Type == SchemeCtrl2.DrawTool.LineToolType.CellLine_6)
				{
					LineCellTool lineCellTool = new LineCellTool();
					lineCellTool.IdBase = drawObjectBase_2.IdBase;
					lineCellTool.Text = drawObjectBase_2.Text;
					lineCellTool.Parent = rectangleTool.Master;
					lineCellTool.LimitedEditing = true;
					List<ShinaTool> list = new List<ShinaTool>();
					List<PointTool> list2 = new List<PointTool>();
					UnitPoint unitPoint = default(UnitPoint);
					Func<DrawObjectBase, bool> <>9__3;
					foreach (PointTool pointTool in ((LineCellTool)drawObjectBase_2).Ends)
					{
						if (pointTool.Parent != null && pointTool.Parent.GetType() == typeof(ShinaTool))
						{
							List<DrawObjectBase> list3 = this.method_55(pointTool.Parent);
							if (list3.Count != 0)
							{
								ShinaTool shinaTool2 = null;
								IEnumerable<DrawObjectBase> source = list3;
								Func<DrawObjectBase, bool> predicate3;
								if ((predicate3 = <>9__3) == null)
								{
									predicate3 = (<>9__3 = ((DrawObjectBase o) => !displayObjectList.Contains(o)));
								}
								foreach (DrawObjectBase drawObjectBase in source.Where(predicate3))
								{
									displayObjectList.Add(drawObjectBase);
									if (drawObjectBase.IdBase == pointTool.Parent.IdBase)
									{
										shinaTool2 = (ShinaTool)drawObjectBase;
									}
								}
								if (shinaTool2 == null)
								{
									return displayObjectList;
								}
								list.Add((ShinaTool)pointTool.Parent);
								PointShinaTool pointShinaTool = new PointShinaTool();
								pointShinaTool.IdBase = pointTool.IdBase;
								shinaTool2.AddPointShinaTool(pointShinaTool);
								pointShinaTool.Delta = 0.5f;
								list2.Add(pointShinaTool);
								if (unitPoint.X == 0.0 && unitPoint.Y == 0.0)
								{
									unitPoint = new UnitPoint(pointShinaTool.Point.X - pointTool.Point.X, pointShinaTool.Point.Y - pointTool.Point.Y);
								}
								else
								{
									unitPoint = new UnitPoint((unitPoint.X + (pointShinaTool.Point.X - pointTool.Point.X)) / 2.0, (unitPoint.Y + (pointShinaTool.Point.Y - pointTool.Point.Y)) / 2.0);
								}
							}
						}
					}
					if (list2.Count == 0)
					{
						return displayObjectList;
					}
					Dictionary<CouplingRelation, CouplingRelation> dictionary = new Dictionary<CouplingRelation, CouplingRelation>();
					using (List<CouplingRelation>.Enumerator enumerator4 = ((LineTool)drawObjectBase_2).CouplingRelations.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							CouplingRelation cr = enumerator4.Current;
							IEnumerable<PointTool> source2 = from obj in list2
							where obj.IdBase == cr.method_1().IdBase
							select obj;
							PointTool pointTool2;
							if (source2.Count<PointTool>() > 0)
							{
								pointTool2 = source2.First<PointTool>();
							}
							else
							{
								pointTool2 = new PointTool();
								pointTool2.IdBase = cr.method_1().IdBase;
								if (cr.method_1().Parent != null && cr.method_1().Parent == cr.Line)
								{
									pointTool2.Parent = lineCellTool;
								}
								pointTool2.Point = new UnitPoint(unitPoint.X + cr.method_1().Point.X, unitPoint.Y + cr.method_1().Point.Y);
								list2.Add(pointTool2);
							}
							source2 = from obj in list2
							where obj.IdBase == cr.method_2().IdBase
							select obj;
							PointTool pointTool3;
							if (source2.Count<PointTool>() > 0)
							{
								pointTool3 = source2.First<PointTool>();
							}
							else
							{
								pointTool3 = new PointTool();
								pointTool3.IdBase = cr.method_2().IdBase;
								if (cr.method_2().Parent != null && cr.method_2().Parent == cr.Line)
								{
									pointTool3.Parent = lineCellTool;
								}
								pointTool3.Point = new UnitPoint(unitPoint.X + cr.method_2().Point.X, unitPoint.Y + cr.method_2().Point.Y);
								list2.Add(pointTool3);
							}
							CouplingRelation couplingRelation = new CouplingRelation(pointTool2, pointTool3);
							couplingRelation.Id = cr.Id;
							couplingRelation.Line = lineCellTool;
							lineCellTool.CouplingRelations.method_3(couplingRelation);
							dictionary.Add(cr, couplingRelation);
						}
					}
					using (List<Branch>.Enumerator enumerator5 = ((LineTool)drawObjectBase_2).Branches.GetEnumerator())
					{
						while (enumerator5.MoveNext())
						{
							Branch br = enumerator5.Current;
							IEnumerable<PointTool> source3 = from obj in list2
							where obj.IdBase == br.Source.IdBase
							select obj;
							PointTool pointTool4;
							if (source3.Count<PointTool>() > 0)
							{
								pointTool4 = source3.First<PointTool>();
							}
							else
							{
								pointTool4 = new PointTool();
								if (br.Source.IdBase > 0)
								{
									pointTool4.IdBase = br.Source.IdBase;
								}
								if (br.Source.Parent != null && br.Source.Parent == rectangleTool)
								{
									pointTool4.Parent = rectangleTool.Master;
								}
								pointTool4.Point = new UnitPoint(unitPoint.X + br.Source.Point.X, unitPoint.Y + br.Source.Point.Y);
								list2.Add(pointTool4);
							}
							source3 = from obj in list2
							where obj.IdBase == br.Destination.IdBase
							select obj;
							PointTool pointTool5;
							if (source3.Count<PointTool>() > 0)
							{
								pointTool5 = source3.First<PointTool>();
							}
							else
							{
								pointTool5 = new PointTool();
								if (br.Destination.IdBase > 0)
								{
									pointTool5.IdBase = br.Destination.IdBase;
								}
								if (br.Destination.Parent != null && br.Destination.Parent == rectangleTool)
								{
									pointTool5.Parent = rectangleTool.Master;
								}
								pointTool5.Point = new UnitPoint(unitPoint.X + br.Destination.Point.X, unitPoint.Y + br.Destination.Point.Y);
								list2.Add(pointTool5);
							}
							Branch item3 = new Branch(lineCellTool, pointTool4, pointTool5, br.Type, dictionary[br.CouplingRelation]);
							lineCellTool.Branches.Add(item3);
						}
					}
					rectangleTool.Master.Layer.AddObject(lineCellTool);
					lineCellTool.LimitedEditing = true;
					rectangleTool.Master.Layer.Parent.DoInvalidate(true);
					displayObjectList.Add(lineCellTool);
				}
				return displayObjectList;
			}
			if (drawObjectBase_2.GetType() == typeof(LineTool))
			{
				LineTool lineTool = new LineTool();
				lineTool.IdBase = drawObjectBase_2.IdBase;
				lineTool.Text = drawObjectBase_2.Text;
				lineTool.LimitedEditing = true;
				List<LineCellTool> list4 = new List<LineCellTool>();
				List<PointTool> list5 = new List<PointTool>();
				UnitPoint unitPoint2 = default(UnitPoint);
				using (IEnumerator<PointTool> enumerator3 = ((LineTool)drawObjectBase_2).Ends.GetEnumerator())
				{
					Func<DrawObjectBase, bool> <>9__8;
					while (enumerator3.MoveNext())
					{
						PointTool pt = enumerator3.Current;
						if (pt.Parent != null && ((pt.Parent.GetType() == typeof(LineCellTool) && ((LineCellTool)pt.Parent).Type == SchemeCtrl2.DrawTool.LineToolType.CellLine_10) || ((LineCellTool)pt.Parent).Type == SchemeCtrl2.DrawTool.LineToolType.CellLine_6))
						{
							List<DrawObjectBase> list6 = this.method_55(pt.Parent);
							if (list6.Count == 0)
							{
								throw new Exception("Про не смогли отразить ячейку");
							}
							Func<DrawObjectBase, bool> predicate4;
							if ((predicate4 = <>9__8) == null)
							{
								predicate4 = (<>9__8 = ((DrawObjectBase o) => !displayObjectList.Contains(o)));
							}
							Func<PointTool, bool> <>9__9;
							foreach (DrawObjectBase drawObjectBase2 in list6.Where(predicate4))
							{
								displayObjectList.Add(drawObjectBase2);
								if (drawObjectBase2.GetType() == typeof(LineCellTool) && drawObjectBase2.IdBase == pt.Parent.IdBase)
								{
									list4.Add((LineCellTool)drawObjectBase2);
									IEnumerable<PointTool> ends = ((LineCellTool)drawObjectBase2).Ends;
									Func<PointTool, bool> predicate5;
									if ((predicate5 = <>9__9) == null)
									{
										predicate5 = (<>9__9 = ((PointTool o) => o.IdBase == pt.IdBase));
									}
									using (IEnumerator<PointTool> enumerator6 = ends.Where(predicate5).GetEnumerator())
									{
										if (enumerator6.MoveNext())
										{
											PointTool pointTool6 = enumerator6.Current;
											list5.Add(pointTool6);
											if (unitPoint2.X == 0.0 && unitPoint2.Y == 0.0)
											{
												unitPoint2 = new UnitPoint(pointTool6.Point.X - pt.Point.X, pointTool6.Point.Y - pt.Point.Y);
											}
											else
											{
												unitPoint2 = new UnitPoint((unitPoint2.X + (pointTool6.Point.X - pt.Point.X)) / 2.0, (unitPoint2.Y + (pointTool6.Point.Y - pt.Point.Y)) / 2.0);
											}
										}
									}
								}
							}
						}
					}
				}
				if (list5.Count == 0)
				{
					return displayObjectList;
				}
				Dictionary<CouplingRelation, CouplingRelation> dictionary2 = new Dictionary<CouplingRelation, CouplingRelation>();
				using (List<CouplingRelation>.Enumerator enumerator4 = ((LineTool)drawObjectBase_2).CouplingRelations.GetEnumerator())
				{
					while (enumerator4.MoveNext())
					{
						CouplingRelation cr = enumerator4.Current;
						IEnumerable<PointTool> source4 = from obj in list5
						where obj.IdBase == cr.method_1().IdBase
						select obj;
						PointTool pointTool7;
						if (source4.Count<PointTool>() > 0)
						{
							pointTool7 = source4.First<PointTool>();
						}
						else
						{
							pointTool7 = new PointTool();
							pointTool7.IdBase = cr.method_1().IdBase;
							if (cr.method_1().Parent != null && cr.method_1().Parent == rectangleTool)
							{
								pointTool7.Parent = rectangleTool.Master;
							}
							pointTool7.Point = new UnitPoint(unitPoint2.X + cr.method_1().Point.X, unitPoint2.Y + cr.method_1().Point.Y);
							list5.Add(pointTool7);
						}
						source4 = from obj in list5
						where obj.IdBase == cr.method_2().IdBase
						select obj;
						PointTool pointTool8;
						if (source4.Count<PointTool>() > 0)
						{
							pointTool8 = source4.First<PointTool>();
						}
						else
						{
							pointTool8 = new PointTool();
							pointTool8.IdBase = cr.method_2().IdBase;
							if (cr.method_2().Parent != null && cr.method_2().Parent == rectangleTool)
							{
								pointTool8.Parent = rectangleTool.Master;
							}
							pointTool8.Point = new UnitPoint(pointTool7.Point.X, pointTool7.Point.Y);
							list5.Add(pointTool8);
						}
						CouplingRelation couplingRelation2 = new CouplingRelation(pointTool7, pointTool8);
						couplingRelation2.Id = cr.Id;
						couplingRelation2.Line = lineTool;
						lineTool.CouplingRelations.method_3(couplingRelation2);
						dictionary2.Add(cr, couplingRelation2);
					}
				}
				using (List<Branch>.Enumerator enumerator5 = ((LineTool)drawObjectBase_2).Branches.GetEnumerator())
				{
					while (enumerator5.MoveNext())
					{
						Branch br = enumerator5.Current;
						IEnumerable<PointTool> source5 = from obj in list5
						where obj.IdBase == br.Source.IdBase
						select obj;
						PointTool pointTool9;
						if (source5.Count<PointTool>() > 0)
						{
							pointTool9 = source5.First<PointTool>();
						}
						else
						{
							pointTool9 = new PointTool();
							if (br.Source.IdBase > 0)
							{
								pointTool9.IdBase = br.Source.IdBase;
							}
							if (br.Source.Parent != null && br.Source.Parent == rectangleTool)
							{
								pointTool9.Parent = rectangleTool.Master;
							}
							pointTool9.Point = new UnitPoint(unitPoint2.X + br.Source.Point.X, unitPoint2.Y + br.Source.Point.Y);
							list5.Add(pointTool9);
						}
						source5 = from obj in list5
						where obj.IdBase == br.Destination.IdBase
						select obj;
						PointTool pointTool10;
						if (source5.Count<PointTool>() > 0)
						{
							pointTool10 = source5.First<PointTool>();
						}
						else
						{
							pointTool10 = new PointTool();
							if (br.Destination.IdBase > 0)
							{
								pointTool10.IdBase = br.Destination.IdBase;
							}
							if (br.Destination.Parent != null && br.Destination.Parent == rectangleTool)
							{
								pointTool10.Parent = rectangleTool.Master;
							}
							pointTool10.Point = new UnitPoint(unitPoint2.X + br.Destination.Point.X, unitPoint2.Y + br.Destination.Point.Y);
							list5.Add(pointTool10);
						}
						Branch item4 = new Branch(lineTool, pointTool9, pointTool10, br.Type, dictionary2[br.CouplingRelation]);
						lineTool.Branches.Add(item4);
					}
				}
				rectangleTool.Master.Layer.AddObject(lineTool);
				lineTool.LimitedEditing = true;
				rectangleTool.Master.Layer.Parent.DoInvalidate(true);
				displayObjectList.Add(lineTool);
				return displayObjectList;
			}
			else if (drawObjectBase_2 is ObjectOnLine)
			{
				if (drawObjectBase_2.Parent.Parent == null || drawObjectBase_2.Parent.Parent.LimitedEditing)
				{
					return null;
				}
				LineTool drawObjectBase_3 = (LineTool)drawObjectBase_2.Parent.Parent;
				displayObjectList = this.method_55(drawObjectBase_3);
				if (displayObjectList.Count == 0)
				{
					return displayObjectList;
				}
				LineTool lineTool2 = (LineTool)displayObjectList.Last<DrawObjectBase>();
				CouplingRelation couplingRelation3 = null;
				foreach (CouplingRelation couplingRelation4 in lineTool2.CouplingRelations)
				{
					if (couplingRelation4.Id == ((Branch)drawObjectBase_2.Parent).CouplingRelation.Id)
					{
						couplingRelation3 = couplingRelation4;
						break;
					}
				}
				if (couplingRelation3 != null && couplingRelation3.method_3().Count != 0)
				{
					ObjectOnLine objectOnLine = ObjectOnLine.CreateObjectOnLine(((ObjectOnLine)drawObjectBase_2).TypeSwitch, couplingRelation3.method_3().First<Branch>());
					objectOnLine.IdBase = drawObjectBase_2.IdBase;
					objectOnLine.Text = drawObjectBase_2.Text;
					objectOnLine.Delta = ((ObjectOnLine)drawObjectBase_2).Delta;
					objectOnLine.On = ((ObjectOnLine)drawObjectBase_2).On;
					objectOnLine.RecalcAngle();
					rectangleTool.Master.Layer.AddObject(objectOnLine);
					objectOnLine.LimitedEditing = true;
					rectangleTool.Master.Layer.Parent.DoInvalidate(true);
					displayObjectList.Add(objectOnLine);
					return displayObjectList;
				}
				return displayObjectList;
			}
			else
			{
				if (drawObjectBase_2.GetType() != typeof(TextBranchTool))
				{
					return displayObjectList;
				}
				if (drawObjectBase_2.Parent.Parent == null)
				{
					return null;
				}
				LineTool drawObjectBase_4 = (LineTool)drawObjectBase_2.Parent.Parent;
				displayObjectList = this.method_55(drawObjectBase_4);
				if (displayObjectList.Count == 0)
				{
					return displayObjectList;
				}
				LineTool lineTool3 = (LineTool)displayObjectList.Last<DrawObjectBase>();
				CouplingRelation couplingRelation5 = null;
				foreach (CouplingRelation couplingRelation6 in lineTool3.CouplingRelations)
				{
					if (couplingRelation6.Id == ((Branch)drawObjectBase_2.Parent).CouplingRelation.Id)
					{
						couplingRelation5 = couplingRelation6;
						break;
					}
				}
				if (couplingRelation5 != null && couplingRelation5.method_3().Count != 0)
				{
					TextBranchTool textBranchTool = new TextBranchTool
					{
						Parent = couplingRelation5.method_3().First<Branch>(),
						IdBase = ((TextBranchTool)drawObjectBase_2).IdBase,
						Text = ((TextBranchTool)drawObjectBase_2).Text,
						Delta = ((TextBranchTool)drawObjectBase_2).Delta,
						Direct = ((TextBranchTool)drawObjectBase_2).Direct
					};
					textBranchTool.TextProperty.Position = ((TextBranchTool)drawObjectBase_2).TextProperty.Position;
					rectangleTool.Master.Layer.AddObject(textBranchTool);
					displayObjectList.Add(textBranchTool);
					return displayObjectList;
				}
				return displayObjectList;
			}
			List<DrawObjectBase> result;
			return result;
		}

		private void CanvasControl_Load(object sender, EventArgs e)
		{
			this.bigBoldButton.Visible = false;
			this.propertyGrid1.Visible = false;
			this.textBoxSearch.Visible = false;
			this.button1.Visible = false;
			this.waWrHaQms2.Visible = false;
		}

		public new void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected override void Dispose(bool disposing)
		{
			this.method_0();
			this.proxy_Singleton_0.ProxyCallBackEvent -= this.proxy_Singleton_0_ProxyCallBackEvent;
			this.proxy_Singleton_0.ProxyEvent -= this.proxy_Singleton_0_ProxyEvent;
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			if (!this.bool_10)
			{
				if (disposing)
				{
					if (this.graphics_0 != null)
					{
						this.graphics_0.Dispose();
					}
					if (this.class22_0 != null)
					{
						this.class22_0.Dispose();
					}
					if (this.control0_0 != null)
					{
						this.control0_0.Dispose();
					}
					if (this.timer_0 != null)
					{
						this.timer_0.Dispose();
					}
					if (this.staticImage != null)
					{
						this.staticImage.Dispose();
					}
					if (this.list_1 != null)
					{
						this.list_1.Clear();
					}
					if (this.backgroundLayer_0 != null)
					{
						this.backgroundLayer_0.Dispose();
					}
					if (this.list_4 != null)
					{
						this.list_4.Clear();
					}
					IEnumerable<int> source = from o in this.loadedPoints
					select o.Key;
					while (source.Count<int>() > 0)
					{
						this.loadedPoints[source.First<int>()].Dispose();
						this.loadedPoints.Remove(source.First<int>());
					}
					if (this.list_0 != null)
					{
						while (this.list_0.Count > 0)
						{
							if (this.list_0[0] is IDisposable)
							{
								((IDisposable)this.list_0[0]).Dispose();
								this.list_0.RemoveAt(0);
							}
							else
							{
								this.list_0[0] = null;
								this.list_0.RemoveAt(0);
							}
						}
					}
				}
				this.bool_10 = true;
			}
			this.method_53();
			base.Dispose(disposing);
		}

		~CanvasControl()
		{
			this.Dispose(false);
		}

		public void ShowFormAbnFromOldSchema(DrawObjectBase dob, bool nextObj)
		{
			Class80 @class = new Class80(dob, nextObj, this.SqlSettings);
			new Rectangle(new Point(base.Location.X + base.Size.Width / 2 - @class.Size.Width / 2, base.Location.Y + base.Size.Height / 2 - @class.Size.Height / 2), @class.DisplayRectangle.Size);
			if (base.Parent is DockContentBase)
			{
				@class.Show(((DockContentBase)base.Parent).DockPanel);
				return;
			}
			@class.Show();
		}

		public void ShowFormSchmObjFile(DrawObjectBase obj)
		{
			FormSchmObjFile formSchmObjFile = new FormSchmObjFile(obj);
			formSchmObjFile.SqlSettings = this.SqlSettings;
			if (base.Parent is DockContentBase)
			{
				formSchmObjFile.Show(((DockContentBase)base.Parent).DockPanel);
				return;
			}
			formSchmObjFile.Show();
		}

		private void method_56(object sender, TreeNodeMouseClickEventArgs e)
		{
			DrawObjectBase drawObject = (DrawObjectBase)e.Node.Tag;
			this.SetObjectsInCenterScreen(drawObject, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
		}

		public void UpdateMeasurementForBus()
		{
			DataTable dataTable = new DataTable();
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
				{
					SqlCommand sqlCommand = new SqlCommand();
					int measurementYear = this.Settings.MeasurementYear;
					if (measurementYear != 0)
					{
						if (measurementYear != 1)
						{
							sqlCommand.CommandText = string.Concat(new object[]
							{
								"SELECT [IdBus],mat.[idObjList],(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) then max([Ia]) else case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) then max([Ic]) end end end) as I\r\n                                             FROM [tJ_MeasAmperageTransf] as mat\r\n                                             inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                                             where  mat.deleted = 0 and m.[TypeDoc] = 1192 and  ((year(m.[DateD]) = ",
								this.Settings.MeasurementYear,
								" and month(m.[DateD]) between 1 and 11)or(year(m.[DateD]) = ",
								this.Settings.MeasurementYear,
								"-1 and month(m.[DateD])=12) ) and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                                             group by mat.[IdBus],mat.[idObjList]"
							});
						}
						else
						{
							sqlCommand.CommandText = "SELECT mat.[IdBus],mat.[idObjList],(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) \r\n\t\t\t\t                                    then max([Ia]) \telse case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) \r\n\t\t\t\t\t                                else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) \r\n\t\t\t\t\t                                then max([Ic]) end end end) as I\r\n                                            FROM [tJ_MeasAmperageTransf] as mat\r\n                                                    inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                                                where  mat.deleted = 0 and m.[TypeDoc] = 1192 \r\n\t\t                                        and ((year(m.[DateD]) = (select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n\t\t\t\t\t\t\t\t\t\t                                else year(max(dateD)) end from tj_measurement mes left join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n\t\t\t\t\t\t\t\t                            where mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\tand  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)\r\n                                    \t\tand month(m.[DateD]) between 1 and 11)\t\r\n\t\t                                    or (year(m.[DateD]) =(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n\t\t\t\t\t\t\t\t\t\t                            else year(max(dateD)) end\r\n\t\t\t\t\t\t\t\t                                    from tj_measurement mes \r\n\t\t\t\t\t\t\t\t\t                            left join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n\t\t\t\t\t\t\t\t                        where mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\r\n\t\t\t\t\t\t\t\t\t                    and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)-1 and month(m.[DateD])=12)) \r\n\t\t                                                and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                                            group by mat.[IdBus],mat.[idObjList]";
						}
					}
					else
					{
						sqlCommand.CommandText = "SELECT mat.[IdBus],mat.[idObjList],(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) then max([Ia]) else case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) then max([Ic]) end end end) as I\r\n                                             FROM [tJ_MeasAmperageTransf] as mat\r\n                                             inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                                             where  mat.deleted = 0 and m.[TypeDoc] = 1192 and mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                                             group by mat.[IdBus],mat.[idObjList]";
					}
					sqlCommand.Connection = sqlConnection;
					sqlConnection.Open();
					SqlDataReader reader = sqlCommand.ExecuteReader();
					dataTable.Load(reader);
					sqlConnection.Close();
				}
				foreach (DrawObjectBase drawObjectBase in from l in this.ActiveLayer.Objects
				where l.GetType() == typeof(MeasurementLabelTool) && l.Parent != null && l.Parent.GetType() == typeof(ShinaTool)
				select l)
				{
					((MeasurementLabelTool)drawObjectBase).ClearMeasurement();
					DataRow[] array = dataTable.Select("IdBus=" + drawObjectBase.Parent.IdBase);
					if (array.Length != 0)
					{
						for (int i = 0; i < array.Length; i++)
						{
							((MeasurementLabelTool)drawObjectBase).AddMeasurement(Convert.ToInt32(array[i][1]), Convert.ToInt32(array[i][2]));
						}
					}
					else
					{
						((MeasurementLabelTool)drawObjectBase).AddMeasurement(-1, 0);
					}
				}
			}
			catch (Exception ex)
			{
				this.SendMessage(ex.Message, eMessageType.Error);
			}
		}

		private void method_57(int int_9)
		{
			DataTable dataTable = new DataTable();
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
				SqlCommand sqlCommand = new SqlCommand(string.Concat(new object[]
				{
					"SELECT [IdBus],mat.[idObjList],(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) then max([Ia]) else case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) then max([Ic]) end end end) as I\r\n                                                                                                FROM [tJ_MeasAmperageTransf] as mat\r\n                                                                                                inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                                                                                                where  mat.deleted = 0 and m.[TypeDoc] = 1192 and  mat.[IdBus] = ",
					int_9,
					" and  ((year(m.[DateD]) = ",
					this.Settings.MeasurementYear,
					" and month(m.[DateD]) between 1 and 11)or(year(m.[DateD]) = ",
					this.Settings.MeasurementYear,
					"-1 and month(m.[DateD])=12) ) and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                                                                                                group by mat.[IdBus],mat.[idObjList]"
				}));
				sqlCommand.Connection = sqlConnection;
				sqlConnection.Open();
				SqlDataReader reader = sqlCommand.ExecuteReader();
				dataTable.Load(reader);
				sqlConnection.Close();
			}
			catch
			{
			}
			IEnumerable<DrawObjectBase> objects = this.ActiveLayer.Objects;
			Func<DrawObjectBase, bool> <>9__0;
			Func<DrawObjectBase, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((DrawObjectBase l) => l.GetType() == typeof(MeasurementLabelTool) && l.Parent != null && l.Parent.GetType() == typeof(ShinaTool) && l.Parent.IdBase == int_9));
			}
			foreach (DrawObjectBase drawObjectBase in objects.Where(predicate))
			{
				((MeasurementLabelTool)drawObjectBase).ClearMeasurement();
				DataRow[] array = dataTable.Select("IdBus=" + drawObjectBase.Parent.IdBase);
				if (array.Length != 0)
				{
					for (int i = 0; i < array.Length; i++)
					{
						((MeasurementLabelTool)drawObjectBase).AddMeasurement(Convert.ToInt32(array[i][1]), Convert.ToInt32(array[i][2]));
					}
				}
				else
				{
					((MeasurementLabelTool)drawObjectBase).AddMeasurement(-1, 0);
				}
			}
		}

		private void method_58(object sender, EventArgs e)
		{
		}

		public ContextMenuStrip ContextMenuRectangle
		{
			get
			{
				return this.contextMenuRectnagle;
			}
			set
			{
				this.contextMenuRectnagle = value;
			}
		}

		public ContextMenuStrip ContextMenuShina
		{
			get
			{
				return this.contextMenuShina;
			}
			set
			{
				this.contextMenuShina = value;
			}
		}

		public ContextMenuStrip ContextMenuSwitchTool
		{
			get
			{
				return this.contextMenuSwitchTool;
			}
			set
			{
				this.contextMenuSwitchTool = value;
			}
		}

		public ContextMenuStrip ContextMenuLineTool
		{
			get
			{
				return this.contextMenuLineTool;
			}
			set
			{
				this.contextMenuLineTool = value;
			}
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				List<DrawObjectBase> powerSource = ((DrawObjectBase)contextMenu.Tag).GetPowerSource();
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase in powerSource)
				{
					list.Add(drawObjectBase);
					if (drawObjectBase is ShinaTool)
					{
						list.Add(drawObjectBase.Parent);
					}
					if (drawObjectBase is Branch)
					{
						foreach (DrawObjectBase item in drawObjectBase.ChildObjects)
						{
							list.Add(item);
						}
					}
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 1)
				{
					this.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
					return;
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 2)
				{
					this.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.flashing);
				}
			}
		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				List<DrawObjectBase> recipientsPower = ((DrawObjectBase)contextMenu.Tag).GetRecipientsPower();
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase in recipientsPower)
				{
					list.Add(drawObjectBase);
					if (drawObjectBase is ShinaTool)
					{
						list.Add(drawObjectBase.Parent);
					}
					if (drawObjectBase is LineCellTool || drawObjectBase is LineTool)
					{
						foreach (Branch branch in ((LineTool)drawObjectBase).Branches)
						{
							foreach (DrawObjectBase item in branch.ChildObjects)
							{
								list.Add(item);
							}
						}
					}
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 1)
				{
					this.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
					return;
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 2)
				{
					this.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.flashing);
				}
			}
		}

		private void reArSpApSW_Click(object sender, EventArgs e)
		{
			this.CopySelectedObjects();
		}

		private void uBbItwaYjM_Click(object sender, EventArgs e)
		{
			this.PasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>());
		}

		private void toolMenuItemTextBranchDel_Click(object sender, EventArgs e)
		{
			if (this.Mode == eCanvasEditingMode.Edit)
			{
				this.RemoveSelectedObjects();
			}
		}

		private void toolMenuItemLineFile_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				DrawObjectBase obj = (DrawObjectBase)contextMenu.Tag;
				this.ShowFormSchmObjFile(obj);
			}
		}

		private void WcgruJuvXg_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
				if (drawObjectBase.ShowPropertyForm(contextMenu.Location))
				{
					DrawObjectsEventArgs e2 = new DrawObjectsEventArgs(drawObjectBase);
					this.OnSelectedObjectEdited(e2);
				}
			}
		}

		private void toolMenuItemLineFilterAdd_Click(object sender, EventArgs e)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase is Branch)
				{
					if (drawObjectBase.Parent != null && !list.Contains(drawObjectBase.Parent))
					{
						list.Add(drawObjectBase.Parent);
					}
				}
				else if (!list.Contains(drawObjectBase))
				{
					list.Add(drawObjectBase);
				}
			}
			new FormCanvasAddDelFilter(list, 0)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void toolMenuItemLineFilterDel_Click(object sender, EventArgs e)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase is Branch)
				{
					if (drawObjectBase.Parent != null && !list.Contains(drawObjectBase.Parent))
					{
						list.Add(drawObjectBase.Parent);
					}
				}
				else if (!list.Contains(drawObjectBase))
				{
					list.Add(drawObjectBase);
				}
			}
			new FormCanvasAddDelFilter(list, 2)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void toolStripMenuItemBookmark_Click(object sender, EventArgs e)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			list.AddRange(this.SelectedObjects);
			foreach (DrawObjectBase drawObjectBase in list)
			{
				if (drawObjectBase.Bookmark != null && this.list_6.Contains(drawObjectBase.Bookmark) && drawObjectBase.Bookmark.Count == 1)
				{
					drawObjectBase.Bookmark.Clear();
					this.list_6.Remove(drawObjectBase.Bookmark);
				}
				drawObjectBase.Bookmark = list;
			}
			this.list_6.Add(list);
			this.DoInvalidate(true);
		}

		private void toolStripMenuItemRemoveBookmark_Click(object sender, EventArgs e)
		{
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase.Bookmark != null && this.list_6.Contains(drawObjectBase.Bookmark))
				{
					drawObjectBase.Bookmark.Clear();
					this.list_6.Remove(drawObjectBase.Bookmark);
					drawObjectBase.Bookmark = null;
				}
			}
			this.DoInvalidate(true);
		}

		private void contextMenuRectnagle_Opening(object sender, CancelEventArgs e)
		{
			this.toolMenuItemRectAlign.Enabled = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemRectDel.Enabled = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemRectPaste.Enabled = (this.Mode == eCanvasEditingMode.Edit && CopyPasteCanvasObjects.IsPasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>(), this.list_7));
		}

		private void toolMenuItemRectAlign_Click(object sender, EventArgs e)
		{
			if (this.ContextMenuRectangle.Tag != null)
			{
				RectangleTool rectangleTool = (RectangleTool)this.ContextMenuRectangle.Tag;
				foreach (DrawObjectBase drawObjectBase in rectangleTool.ChildObjects)
				{
					if (drawObjectBase.Layer != null)
					{
						drawObjectBase.Align();
					}
				}
				rectangleTool.method_4(false, true);
			}
		}

		private void toolStripMenuItemAdjacentSubstation2_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag == null)
			{
				return;
			}
			List<DrawObjectBase> adjacentSubstation = CanvasControl.GetAdjacentSubstation((DrawObjectBase)contextMenu.Tag);
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in adjacentSubstation)
			{
				list.Add(drawObjectBase);
				if (drawObjectBase is LineTool || drawObjectBase is LineCellTool)
				{
					foreach (Branch branch in ((LineTool)drawObjectBase).Branches)
					{
						foreach (DrawObjectBase item in branch.ChildObjects)
						{
							list.Add(item);
						}
					}
				}
			}
			this.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
		}

		private void toolStripMenuItem14_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase dob = (DrawObjectBase)contextMenu.Tag;
			this.ShowFormAbnFromOldSchema(dob, Convert.ToInt32(((ToolStripMenuItem)sender).Tag) == 1);
		}

		private void contextMenuShina_Opening(object sender, CancelEventArgs e)
		{
			this.ldtrvofZuY.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.waWrHaQms2.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaDel.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaAddChild.Visible = (this.Mode == eCanvasEditingMode.Edit || this.Mode == eCanvasEditingMode.Dispatcher);
			this.toolMenuItemShinaAddCell.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolStripSeparatorEditShina.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMeniItemShinaAddPattern.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaAddPatternAbnReserve.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaAddPatternAbn.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaAddPatternAbnAuto.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaPaste.Enabled = (this.Mode == eCanvasEditingMode.Edit && CopyPasteCanvasObjects.IsPasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>(), this.list_7));
			this.toolMenuItemShinaFilter.Visible = (this.Mode != eCanvasEditingMode.ReadOnly);
			if (((ContextMenuStrip)sender).Tag != null)
			{
				ShinaTool shinaTool = (ShinaTool)((ContextMenuStrip)sender).Tag;
				if (shinaTool.TypeShinaTool == SchemeCtrl2.DrawTool.eTypeShinaTool.Shina_6 || shinaTool.TypeShinaTool == SchemeCtrl2.DrawTool.eTypeShinaTool.Shina_10)
				{
					this.toolMeniItemShinaAddPattern.Visible = false;
				}
			}
		}

		private void toolMenuItemShinaAddCell_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				((ShinaTool)contextMenu.Tag).AddCellLineTool();
			}
		}

		private void toolMenuItemShinaBridge_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				((ShinaTool)contextMenu.Tag).AddBridgeShinaTool();
			}
		}

		private void toolMenuItemShinaSplitter_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				((ShinaTool)contextMenu.Tag).AddSplitterShinaTool();
			}
		}

		private void toolStripMenuItemAddWhitePoint_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				((ShinaTool)contextMenu.Tag).AddWhitePoint();
			}
			this.DoInvalidate(true);
		}

		private void toolStripMenuItemBusMeasurement_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ShinaTool shinaTool = (ShinaTool)contextMenu.Tag;
			if (base.Parent != null && base.Parent is DockContentBase)
			{
				Form form = base.FindForm();
				if (form is FormBase)
				{
					ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
					showFormEventArgs.TypeForm = "Documents.Forms.Measurement.FormMeasurement, Documents";
					showFormEventArgs.FormMode = 2;
					showFormEventArgs.DockPanel = ((DockContentBase)base.Parent).DockPanel;
					showFormEventArgs.Param = new object[1];
					showFormEventArgs.Param[0] = shinaTool.IdBase;
					showFormEventArgs.SQLSettings = this.SqlSettings;
					((FormBase)form).OnShowForm(showFormEventArgs);
				}
			}
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			Dictionary<DrawObjectBase, bool> l = new Dictionary<DrawObjectBase, bool>();
			treeNodeObj.Tag = drawObjectBase;
			CanvasControl.GetAllPower(drawObjectBase, treeNodeObj, l);
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			this.method_59(treeNodeObj, list);
			List<DrawObjectBase> list2 = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase2 in list)
			{
				list2.Add(drawObjectBase2);
				if (drawObjectBase2 is ShinaTool)
				{
					list2.Add(drawObjectBase2.Parent);
				}
				if (drawObjectBase2 is Branch)
				{
					foreach (DrawObjectBase item in drawObjectBase2.ChildObjects)
					{
						list2.Add(item);
					}
				}
				if (drawObjectBase2 is BranchCollection)
				{
					foreach (Branch branch in ((BranchCollection)drawObjectBase2).Collection)
					{
						foreach (DrawObjectBase item2 in branch.ChildObjects)
						{
							list2.Add(item2);
						}
					}
				}
			}
			this.SetObjectsInCenterScreen(list2, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
		}

		private void toolStripMenuItem11_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			Dictionary<DrawObjectBase, bool> l = new Dictionary<DrawObjectBase, bool>();
			treeNodeObj.Tag = drawObjectBase;
			CanvasControl.GetAlternativePower(drawObjectBase, treeNodeObj, l);
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			this.method_59(treeNodeObj, list);
			List<DrawObjectBase> list2 = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase2 in list)
			{
				list2.Add(drawObjectBase2);
				if (drawObjectBase2 is ShinaTool)
				{
					list2.Add(drawObjectBase2.Parent);
				}
				if (drawObjectBase2 is Branch)
				{
					foreach (DrawObjectBase item in drawObjectBase2.ChildObjects)
					{
						list2.Add(item);
					}
				}
				if (drawObjectBase2 is BranchCollection)
				{
					foreach (Branch branch in ((BranchCollection)drawObjectBase2).Collection)
					{
						foreach (DrawObjectBase item2 in branch.ChildObjects)
						{
							list2.Add(item2);
						}
					}
				}
				if (drawObjectBase2 is LineTool || drawObjectBase2 is LineCellTool)
				{
					foreach (Branch branch2 in ((LineTool)drawObjectBase2).Branches)
					{
						foreach (DrawObjectBase item3 in branch2.ChildObjects)
						{
							list2.Add(item3);
						}
					}
				}
			}
			this.bool_5 = true;
			this.AddFlashObject(drawObjectBase);
			list2.Remove(drawObjectBase);
			this.SetObjectsInCenterScreen(list2, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
		}

		private void method_59(TreeNodeObj treeNodeObj_0, List<DrawObjectBase> list_9)
		{
			if (treeNodeObj_0.Tag != null)
			{
				list_9.Add((DrawObjectBase)treeNodeObj_0.Tag);
			}
			foreach (TreeNodeObj treeNodeObj_ in treeNodeObj_0.Nodes)
			{
				this.method_59(treeNodeObj_, list_9);
			}
		}

		private void toolStripMenuItemHReflect_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null && contextMenu.Tag.GetType() != typeof(RectangleTool))
			{
				return;
			}
			RectangleTool rectangleTool = (RectangleTool)contextMenu.Tag;
			UnitPoint empty = UnitPoint.Empty;
			UnitPoint empty2 = UnitPoint.Empty;
			string a = ((ToolStripMenuItem)sender).Tag.ToString();
			if (!(a == "H"))
			{
				if (a == "V")
				{
					empty = new UnitPoint((double)(rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width / 2f), (double)rectangleTool.Rectangle.Y);
					empty2 = new UnitPoint((double)(rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width / 2f), (double)(rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height));
				}
			}
			else
			{
				empty = new UnitPoint((double)rectangleTool.Rectangle.X, (double)(rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height / 2f));
				empty2 = new UnitPoint((double)(rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width), (double)(rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height / 2f));
			}
			if (empty == UnitPoint.Empty)
			{
				return;
			}
			foreach (DrawObjectBase drawObjectBase in rectangleTool.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(ShinaTool))
				{
					((ShinaTool)drawObjectBase).ReflectAboutTheLine(empty, empty2);
				}
			}
		}

		private void toolMenuItemShinaAddPatternAbn_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				((ShinaTool)contextMenu.Tag).AddPatternAbn(eTypeAddShinaPatterns.Normal, null);
			}
		}

		private void toolMenuItemShinaAddPatternAbn10_Click(object sender, EventArgs e)
		{
			if (((ToolStripItem)sender).Tag != null)
			{
				int int_ = Convert.ToInt32(((ToolStripItem)sender).Tag);
				ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
				if (contextMenu == null)
				{
					return;
				}
				if (contextMenu.Tag != null)
				{
					ShinaTool shinaTool_ = (ShinaTool)contextMenu.Tag;
					this.method_60(shinaTool_, int_, eTypeAddShinaPatterns.Normal);
				}
			}
		}

		private void toolMenuItemShinaAddPatternAbnAuto10_Click(object sender, EventArgs e)
		{
			if (((ToolStripItem)sender).Tag != null)
			{
				int int_ = Convert.ToInt32(((ToolStripItem)sender).Tag);
				ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
				if (contextMenu == null)
				{
					return;
				}
				if (contextMenu.Tag != null)
				{
					ShinaTool shinaTool_ = (ShinaTool)contextMenu.Tag;
					this.method_60(shinaTool_, int_, eTypeAddShinaPatterns.Auto);
				}
			}
		}

		private void toolMenuItemShinaAddPatternAbnRPS10_Click(object sender, EventArgs e)
		{
			if (((ToolStripItem)sender).Tag != null)
			{
				int int_ = Convert.ToInt32(((ToolStripItem)sender).Tag);
				ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
				if (contextMenu == null)
				{
					return;
				}
				if (contextMenu.Tag != null)
				{
					ShinaTool shinaTool_ = (ShinaTool)contextMenu.Tag;
					this.method_60(shinaTool_, int_, eTypeAddShinaPatterns.RPS);
				}
			}
		}

		private void toolMenuItemShinaAddPatternAbnReserve10_Click(object sender, EventArgs e)
		{
			if (((ToolStripItem)sender).Tag != null)
			{
				int int_ = Convert.ToInt32(((ToolStripItem)sender).Tag);
				ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
				if (contextMenu == null)
				{
					return;
				}
				if (contextMenu.Tag != null)
				{
					ShinaTool shinaTool_ = (ShinaTool)contextMenu.Tag;
					this.method_60(shinaTool_, int_, eTypeAddShinaPatterns.Reserv);
				}
			}
		}

		private void method_60(ShinaTool shinaTool_0, int int_9, eTypeAddShinaPatterns eTypeAddShinaPatterns_0)
		{
			List<DrawObjectBase> list = (from o in shinaTool_0.ChildObjects
			where o is PointShinaTool
			select o).ToList<DrawObjectBase>();
			list.Sort((DrawObjectBase p1, DrawObjectBase p2) => ((PointShinaTool)p1).Delta.CompareTo(((PointShinaTool)p2).Delta));
			int num = 1;
			using (List<DrawObjectBase>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DrawObjectBase drawObjectBase = enumerator.Current;
					if (drawObjectBase is PointShinaTool)
					{
						float num2 = (float)((PointShinaTool)drawObjectBase).Point.X;
						((PointShinaTool)drawObjectBase).Delta = (float)num / (float)(int_9 + list.Count + 1);
						num2 -= (float)((PointShinaTool)drawObjectBase).Point.X;
						List<PointTool> list2 = new List<PointTool>();
						List<Branch> list3 = new List<Branch>();
						list2.Add((PointShinaTool)drawObjectBase);
						this.method_62(num2, list3, list2, (PointShinaTool)drawObjectBase);
						using (List<Branch>.Enumerator enumerator2 = list3.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.Parent != null)
								{
									Class18.smethod_6(shinaTool_0);
								}
							}
						}
						num++;
					}
				}
				goto IL_165;
			}
			IL_147:
			shinaTool_0.AddPatternAbn(eTypeAddShinaPatterns_0, new float?((float)num / (float)(int_9 + list.Count + 1)));
			num++;
			IL_165:
			if (num >= int_9 + list.Count + 1)
			{
				this.DoInvalidate(true);
				return;
			}
			goto IL_147;
		}

		private bool method_61(List<Branch> list_9, List<PointTool> list_10, PointTool pointTool_0)
		{
			foreach (Branch branch in pointTool_0.Branches)
			{
				if (!list_9.Contains(branch))
				{
					if (list_10.Contains(branch.Source))
					{
						if (!list_10.Contains(branch.Destination))
						{
							if (branch.Destination.Parent != null && branch.Destination.Parent is ShinaTool)
							{
								return false;
							}
							list_10.Add(branch.Destination);
							list_9.Add(branch);
							return this.method_61(list_9, list_10, branch.Destination);
						}
					}
					else
					{
						if (branch.Source.Parent != null && branch.Source.Parent is ShinaTool)
						{
							return false;
						}
						list_10.Add(branch.Source);
						list_9.Add(branch);
						return this.method_61(list_9, list_10, branch.Source);
					}
				}
			}
			return true;
		}

		private void method_62(float float_1, List<Branch> list_9, List<PointTool> list_10, PointTool pointTool_0)
		{
			foreach (Branch branch in pointTool_0.Branches)
			{
				if (!list_9.Contains(branch))
				{
					if (!list_10.Contains(branch.Source))
					{
						branch.Source.Point = new UnitPoint(branch.Source.Point.X - (double)float_1, branch.Source.Point.Y);
						list_10.Add(branch.Source);
						list_9.Add(branch);
						this.method_62(float_1, list_9, list_10, branch.Source);
					}
					if (!list_10.Contains(branch.Destination))
					{
						branch.Destination.Point = new UnitPoint(branch.Destination.Point.X - (double)float_1, branch.Destination.Point.Y);
						list_10.Add(branch.Destination);
						list_9.Add(branch);
						this.method_62(float_1, list_9, list_10, branch.Destination);
					}
				}
			}
		}

		private void toolMenuItemShinaAddPatternAbnReserve_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				((ShinaTool)contextMenu.Tag).AddPatternAbn(eTypeAddShinaPatterns.Reserv, null);
			}
		}

		private void waWrHaQms2_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
			MeasurementLabelTool measurementLabelTool = new MeasurementLabelTool();
			measurementLabelTool.Parent = drawObjectBase;
			measurementLabelTool.Location = this.unitPoint_2;
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("SELECT [id],[Name],[TypeCodeId] FROM [dbo].[fn_J_GetTransfByBusLV] ({0}) order by Name", drawObjectBase.IdBase));
			string text = string.Empty;
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				text = text + (string)dataRow["Name"] + ";";
				measurementLabelTool.AddTransformer(Convert.ToInt32(dataRow["id"]));
			}
			measurementLabelTool.Text = text;
			drawObjectBase.Layer.AddObject(measurementLabelTool);
			PointF pointF = ConvertCanvas.ConvertToScreen(this, measurementLabelTool.Location);
			Point location = base.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
			if (!measurementLabelTool.ShowPropertyForm(location))
			{
				measurementLabelTool.Remove(false, false);
			}
			this.method_57(drawObjectBase.IdBase);
		}

		private void contextMenuStripWhitePoint_Opening(object sender, CancelEventArgs e)
		{
			if (this.eCanvasEditingMode_0 == eCanvasEditingMode.ReadOnly)
			{
				e.Cancel = true;
				return;
			}
		}

		private void toolStripMenuItemRemoveWhitePoint_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				((DrawObjectBase)contextMenu.Tag).Remove(true, true);
			}
		}

		private void contextMenuSwitchTool_Opening(object sender, CancelEventArgs e)
		{
			this.toolMenuItemSwitchDel.Enabled = (this.Mode == eCanvasEditingMode.Edit);
			if (this.contextMenuSwitchTool.Tag != null)
			{
				ObjectOnLine objectOnLine = (ObjectOnLine)this.contextMenuSwitchTool.Tag;
				if (this.contextMenuSwitchTool.Tag.GetType() == typeof(OffTool))
				{
					this.toolMenuItemStateDel.Text = "Убрать отсоединение кабеля";
				}
				if (this.contextMenuSwitchTool.Tag.GetType() == typeof(NotPhasedTool))
				{
					this.toolMenuItemStateDel.Text = "Убрать отметку о несфазировании";
				}
				if (this.contextMenuSwitchTool.Tag.GetType() == typeof(DamageTool))
				{
					this.toolMenuItemStateDel.Text = "Убрать повреждение кабеля";
				}
				if (this.contextMenuSwitchTool.Tag.GetType() == typeof(GroundingTool))
				{
					this.toolMenuItemStateDel.Text = "Убрать заземление";
				}
				if (this.contextMenuSwitchTool.Tag.GetType() == typeof(ArrowTool))
				{
					this.toolMenuItemStateDel.Text = "Убрать перенос нагрузки";
				}
				this.toolMenuItemSwitchPassport.Visible = (objectOnLine is TransformerTool);
				if (!((ObjectOnLine)this.contextMenuSwitchTool.Tag).LimitedEditing && (this.contextMenuSwitchTool.Tag.GetType().GetProperty("On") == null || this.contextMenuSwitchTool.Tag.GetType().GetProperty("On").CanWrite))
				{
					this.toolMenuItemSwitchOn.Text = (((ObjectOnLine)this.contextMenuSwitchTool.Tag).On ? "Отключить" : "Включить");
				}
				else
				{
					this.toolMenuItemSwitchOn.Visible = false;
				}
				this.toolMenuItemSwitchOn.Visible = (!objectOnLine.MappingState && !objectOnLine.Parent.Parent.LimitedEditing);
				this.toolStripSeparator12.Visible = !objectOnLine.MappingState;
				this.toolMenuItemSwitchFilter.Visible = !objectOnLine.MappingState;
				this.toolMenuItemStateDel.Visible = objectOnLine.MappingState;
				this.toolMenuItemSwitchDel.Visible = !objectOnLine.MappingState;
				this.toolStripMenuItemCSRollingOut.Visible = (!objectOnLine.MappingState && !objectOnLine.LimitedEditing && objectOnLine.ComplexSwitchgear != null && objectOnLine.ComplexSwitchgear.RollingOutReason == ComplexSwitchgearTool.eRollingOutReason.None && this.Mode != eCanvasEditingMode.ReadOnly);
				this.toolStripMenuItemCSNormalMode.Visible = (!objectOnLine.MappingState && !objectOnLine.LimitedEditing && objectOnLine.ComplexSwitchgear != null && objectOnLine.ComplexSwitchgear.RollingOutReason != ComplexSwitchgearTool.eRollingOutReason.None && this.Mode != eCanvasEditingMode.ReadOnly);
				this.toolStripSeparatorCS.Visible = (!objectOnLine.MappingState && !objectOnLine.LimitedEditing && objectOnLine.ComplexSwitchgear != null && this.Mode != eCanvasEditingMode.ReadOnly);
				this.toolMenuItemSwitchOn.Enabled = (objectOnLine.ComplexSwitchgear == null || objectOnLine.ComplexSwitchgear.RollingOutReason == ComplexSwitchgearTool.eRollingOutReason.None);
				this.toolStripMenuItemCSRepairMode.Enabled = (this.toolStripMenuItemCSTestMode.Enabled = !objectOnLine.On);
				this.toolStripMenuItemSwitchAddTelemetry.Visible = (!objectOnLine.MappingState && this.Mode == eCanvasEditingMode.Edit);
				this.toolStripMenuChangeArrowDirection.Visible = (objectOnLine.GetType() == typeof(ArrowTool) && (this.Mode == eCanvasEditingMode.Dispatcher || this.Mode == eCanvasEditingMode.Edit));
				this.toolStripMenuItemOOLDisplayGrLevel.Visible = (!objectOnLine.MappingState && !objectOnLine.Parent.Parent.LimitedEditing && this.Mode == eCanvasEditingMode.Edit && this.TypeCanvas == eTypeCanvas.SchemeSecond);
				if (this.Mode == eCanvasEditingMode.ReadOnly)
				{
					this.toolMenuItemSwitchOn.Visible = false;
					this.toolMenuItemStateDel.Visible = false;
				}
			}
		}

		private void toolMenuItemStateDel_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu.Tag != null && contextMenu.Tag is ObjectOnLine)
			{
				LineToolState state = ((ObjectOnLine)contextMenu.Tag).State;
				Branch branch = (Branch)state.Mapping.Parent;
				double delta = state.Mapping.Delta;
				int idBase = state.Mapping.IdBase;
				States state2 = state.state;
				if (state2 == SchemeCtrl2.DrawTool.States.break_down || state2 == SchemeCtrl2.DrawTool.States.off)
				{
					SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
					sqlDataCommand.SelectSqlData(this.class22_0.tP_CabOperation, true, " where idObjList = " + branch.Parent.IdBase.ToString() + " order by DateDecommissioning desc", null, false, 0);
					if (state.Mapping.SearchObjectsOnLine(typeof(OffTool)).Count == 0 && state.Mapping.SearchObjectsOnLine(typeof(DamageTool)).Count == 0 && this.class22_0.tP_CabOperation.Rows.Count > 0 && this.class22_0.tP_CabOperation.Rows[0]["DateCommissioning"] == DBNull.Value)
					{
						Form2 form = new Form2();
						form.SqlSettings = this.sqlsettings_0;
						form.method_1(true);
						PointF pointF = ConvertCanvas.ConvertToScreen(this, state.Mapping.CenterPoint);
						form.Location = base.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
						Rectangle workingArea = Screen.GetWorkingArea(form.Location);
						if (form.Left + form.Width > workingArea.Left + workingArea.Width)
						{
							form.Left = form.Left - form.Width - 1;
						}
						if (form.Left < workingArea.Left)
						{
							form.Left = workingArea.Left;
						}
						if (form.Top + form.Height > workingArea.Top + workingArea.Height)
						{
							form.Top = form.Top - form.Height - 1;
						}
						if (form.Top < workingArea.Top)
						{
							form.Top = workingArea.Top;
						}
						if (form.ShowDialog() != DialogResult.OK)
						{
							return;
						}
						DateTime dateCommissioning = form.method_2();
						((Class22.Class72)this.class22_0.tP_CabOperation.Rows[0]).DateCommissioning = dateCommissioning;
						sqlDataCommand.UpdateSqlData(this.class22_0, this.class22_0.tP_CabOperation);
					}
				}
				int idBase2 = state.Mapping.IdBase;
				state.Remove(true);
				((LineTool)branch.Parent).SaveXmlToSql();
				CanvasLog.SaveLogDispatcher(this.SqlSettings, new int?(idBase2), this.method_66(false, state2), "");
				try
				{
					int num = 0;
					using (List<Branch>.Enumerator enumerator = branch.CouplingRelation.method_3().GetEnumerator())
					{
						while (enumerator.MoveNext() && enumerator.Current != branch)
						{
							num++;
						}
					}
					string id = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString() + Environment.UserName + "_" + Process.GetCurrentProcess().Id.ToString();
					this.proxy_Singleton_0.StateOnLine(branch.Parent.IdBase, branch.CouplingRelation.Id, num, delta, (int)state2, false, id, idBase, Class18.smethod_3());
				}
				catch
				{
				}
			}
		}

		private void toolStripMenuChangeArrowDirection_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null && contextMenu.Tag.GetType() == typeof(ArrowTool))
			{
				ArrowTool arrowTool = (ArrowTool)contextMenu.Tag;
				arrowTool.VertMirror = !arrowTool.VertMirror;
				if (arrowTool.Parent != null && arrowTool.Parent.Parent != null)
				{
					Class18.smethod_6(arrowTool.Parent.Parent);
				}
				this.DoInvalidate(true);
			}
		}

		private void toolMenuItemSwitchOn_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu.Tag != null && contextMenu.Tag is ObjectOnLine)
			{
				ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
				objectOnLine.On = !objectOnLine.On;
				if (this.SimulationMode == eSimulationMode.Online)
				{
					Class18.smethod_1(false);
					Class18.smethod_6(objectOnLine);
					Class18.smethod_1(true);
					CanvasLog.SaveLogDispatcher(this.SqlSettings, new int?(objectOnLine.IdBase), objectOnLine.On ? "Включен" : "Выключен", "");
					try
					{
						this.proxy_Singleton_0.ObjectOnLineOnChange(objectOnLine.IdBase, objectOnLine.On, Class18.smethod_3());
						goto IL_AF;
					}
					catch
					{
						goto IL_AF;
					}
				}
				eSimulationMode simulationMode = this.SimulationMode;
				IL_AF:
				this.DoInvalidate(true);
			}
		}

		private void toolStripMenuItemTBTDisplayGrLevel_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu.Tag != null && (contextMenu.Tag is ObjectOnLine || contextMenu.Tag.GetType() == typeof(TextBranchTool)))
			{
				DrawObjectBase drawObjectBase_ = (DrawObjectBase)contextMenu.Tag;
				List<DrawObjectBase> list = this.method_55(drawObjectBase_);
				Class18.smethod_1(false);
				Class18.smethod_7(list);
				Class18.smethod_1(true);
			}
		}

		private void toolMenuItemSwitchLogDispatcher_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			sqlDataCommand.SelectSqlData(this.class22_0.vSchm_LogDispatcher, true, string.Concat(new string[]
			{
				" where IdObj = ",
				objectOnLine.IdBase.ToString(),
				" and typeSchema = ",
				((int)this.TypeCanvas).ToString(),
				" order by dateLog desc"
			}), null, false, 0);
			object obj = sqlDataCommand.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
			{
				objectOnLine.IdBase.ToString()
			});
			this.SendMessage(objectOnLine, (obj != null) ? obj.ToString() : string.Empty, this.class22_0.vSchm_LogDispatcher);
		}

		private void toolMenuItemSwitchPassport_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			if (base.Parent != null && base.Parent is DockContentBase)
			{
				Form form = base.FindForm();
				if (form is FormBase)
				{
					ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
					showFormEventArgs.TypeForm = "Passport.Forms.FormDockPassport, Passport";
					showFormEventArgs.FormMode = 2;
					showFormEventArgs.DockPanel = ((DockContentBase)base.Parent).DockPanel;
					showFormEventArgs.Param = new object[2];
					showFormEventArgs.Param[0] = this.SqlSettings;
					showFormEventArgs.Param[1] = objectOnLine.IdBase;
					showFormEventArgs.SQLSettings = this.SqlSettings;
					((FormBase)form).OnShowForm(showFormEventArgs);
					return;
				}
				DockPanel dockPanel = ((DockContentBase)base.Parent).DockPanel;
				new FormDockPassport(this.SqlSettings, objectOnLine.IdBase).Show(dockPanel);
			}
		}

		private void ToolStripMenuItemSwitchMeasurement_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			if (base.Parent != null && base.Parent is DockContentBase)
			{
				Form form = base.FindForm();
				if (form is FormBase)
				{
					ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
					showFormEventArgs.TypeForm = "Documents.Forms.Measurement.FormMeasurement, Documents";
					showFormEventArgs.FormMode = 2;
					showFormEventArgs.DockPanel = ((DockContentBase)base.Parent).DockPanel;
					showFormEventArgs.Param = new object[1];
					showFormEventArgs.Param[0] = objectOnLine.IdBase;
					showFormEventArgs.SQLSettings = this.SqlSettings;
					((FormBase)form).OnShowForm(showFormEventArgs);
				}
			}
		}

		private void toolStripMenuItemCSRepairMode_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			if (objectOnLine.ComplexSwitchgear == null)
			{
				return;
			}
			objectOnLine.ComplexSwitchgear.RollingOutReason = ComplexSwitchgearTool.eRollingOutReason.Repair;
			Class18.smethod_6(objectOnLine);
			this.DoInvalidate(true);
		}

		private void toolStripMenuItemCSTestMode_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			if (objectOnLine.ComplexSwitchgear == null)
			{
				return;
			}
			objectOnLine.ComplexSwitchgear.RollingOutReason = ComplexSwitchgearTool.eRollingOutReason.Test;
			Class18.smethod_6(objectOnLine);
			this.DoInvalidate(true);
		}

		private void toolStripMenuItemCSNormalMode_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			if (objectOnLine.ComplexSwitchgear == null)
			{
				return;
			}
			objectOnLine.ComplexSwitchgear.RollingOutReason = ComplexSwitchgearTool.eRollingOutReason.None;
			Class18.smethod_6(objectOnLine);
			this.DoInvalidate(true);
		}

		private void toolMenuItemSwitchLinkErcloud_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			new Form0((ObjectOnLine)contextMenu.Tag)
			{
				SqlSettings = this.sqlsettings_0,
				MdiParent = ((DockContentBase)base.Parent).Parent.FindForm().MdiParent
			}.Show();
		}

		private void toolMenuItemSwitchShowDataErcloud_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			new Form1((ObjectOnLine)contextMenu.Tag)
			{
				SqlSettings = this.sqlsettings_0,
				MdiParent = ((DockContentBase)base.Parent).Parent.FindForm().MdiParent
			}.Show();
		}

		private void contextMenuLineTool_Opening(object sender, CancelEventArgs e)
		{
			this.QyjrxReCs8.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemLineAddChild.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemLineFilter.Visible = (this.eCanvasEditingMode_0 != eCanvasEditingMode.ReadOnly);
			this.toolStripSeparatorEditLine.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolStripSeparator8.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemLineTextHere.Visible = false;
			this.toolStripSeparatorLineTextHere.Visible = false;
			this.toolMenuItemLineRelayProtection.Visible = false;
			this.uBbItwaYjM.Enabled = (this.Mode == eCanvasEditingMode.Edit && CopyPasteCanvasObjects.IsPasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>(), this.list_7));
			this.toolMenuItemLineSetStatusArrow.Visible = false;
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				this.toolMenuItemLineDel.Visible = (this.Mode == eCanvasEditingMode.Edit);
				this.uBbItwaYjM.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddBranch.Visible = !lineTool.LimitedEditing;
				this.toolStripSeparatorLineAddBranchPoint.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddOutsideLineDisconnector.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddVacuumSwitch.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddTransformer.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddVoltageTransformer.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddLoadSwitch.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddLinearDisconnector.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddLinearDisconnectorWaxwork.Visible = lineTool.LimitedEditing;
				this.toolMenuItemLineAddLoadSwitch.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddLoadSwitchWaxwork.Visible = lineTool.LimitedEditing;
				this.toolMenuItemLineAddRPS.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddLubricantDisconnector.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddDischargerTool.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddVoltageLimetedTool.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddCircuitBreakerTool.Visible = !lineTool.LimitedEditing;
				this.toolStripSeparator6.Visible = !lineTool.LimitedEditing;
				this.toolStripSeparatorEditLine.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineSetStatus.Visible = !lineTool.LimitedEditing;
				this.toolStripSeparatorSetStatus.Visible = !lineTool.LimitedEditing;
				this.toolStripMenuItemAddElectricMeter.Visible = !lineTool.LimitedEditing;
				this.toolStripMenuItemAddMagneticStarterTool.Visible = !lineTool.LimitedEditing;
				bool flag = this.method_63(lineTool.IdBase);
				this.toolMenuItemLineDeLinkPassport.Visible = (this.Mode == eCanvasEditingMode.Edit && !flag);
				this.toolMenuItemLineLinkPassport.Visible = (lineTool.Type == SchemeCtrl2.DrawTool.LineToolType.CabelLine && !flag);
				this.toolMenuItemLinePassport.Visible = (lineTool.Type == SchemeCtrl2.DrawTool.LineToolType.CabelLine || lineTool.Type == SchemeCtrl2.DrawTool.LineToolType.AirLine || lineTool.Type == SchemeCtrl2.DrawTool.LineToolType.AirLineProtected);
				if (this.Mode == eCanvasEditingMode.ReadOnly)
				{
					this.toolMenuItemLineSetStatus.Visible = false;
					this.toolStripSeparatorSetStatus.Visible = false;
				}
				if (lineTool.SelectedPoint != null)
				{
					if (lineTool.SelectedPoint.BranchesCount == 2)
					{
						if (lineTool.SelectedPoint.Branches.First<Branch>().Parent == lineTool.SelectedPoint.Branches.Last<Branch>().Parent)
						{
							this.toolStripMenuItemDisconnectLine.Enabled = false;
							this.toolStripMenuItemDevideLine.Enabled = true;
						}
						else
						{
							this.toolStripMenuItemDisconnectLine.Enabled = true;
							this.toolStripMenuItemDevideLine.Enabled = false;
						}
					}
					else
					{
						this.toolStripMenuItemDevideLine.Enabled = false;
						List<LineTool> list = new List<LineTool>();
						this.toolStripMenuItemDisconnectLine.Enabled = true;
						foreach (CouplingRelation couplingRelation in lineTool.SelectedPoint.CouplingRelations)
						{
							if (list.Contains(couplingRelation.Line))
							{
								this.toolStripMenuItemDisconnectLine.Enabled = false;
								break;
							}
							list.Add(couplingRelation.Line);
						}
					}
					this.toolMenuItemLineDelPoint.Enabled = (!lineTool.LimitedEditing || lineTool.SelectedPoint.CouplingRelations.Count == 0);
					this.toolStripMenuItemDevideLine.Visible = (this.Mode == eCanvasEditingMode.Edit && !lineTool.LimitedEditing);
					this.toolStripMenuItemDisconnectLine.Visible = (this.Mode == eCanvasEditingMode.Edit && !lineTool.LimitedEditing);
					this.toolMenuItemLinePropertyPoint.Visible = true;
					this.toolMenuItemLineDelPoint.Enabled = true;
					this.toolMenuItemLineAddPoint.Enabled = false;
					this.toolMenuItemLinePropertyBranch.Visible = false;
					this.toolStripMenuItemLineAlignBranch.Visible = false;
				}
				else
				{
					this.toolStripMenuItemDevideLine.Visible = false;
					this.toolStripMenuItemDisconnectLine.Visible = false;
					this.toolMenuItemLinePropertyPoint.Visible = false;
					this.toolMenuItemLineAddPoint.Enabled = true;
					this.toolMenuItemLineDelPoint.Enabled = false;
					this.toolMenuItemLinePropertyBranch.Visible = (this.Mode == eCanvasEditingMode.Edit);
					this.toolStripMenuItemLineAlignBranch.Visible = (this.Mode == eCanvasEditingMode.Edit);
				}
				this.toolMenuItemLineSetStatusGrounding.Enabled = (lineTool.SelectedBranch != null && !lineTool.SelectedBranch.CheckVoltageInPoint(lineTool.ClickedPoint));
				if (lineTool.GetType() == typeof(LineCellTool) || lineTool.GetType() == typeof(Class14))
				{
					this.toolMenuItemLineRelayProtection.Visible = true;
					if (lineTool.SelectedPoint != null)
					{
						this.toolMenuItemLineTextHere.Visible = (this.Mode == eCanvasEditingMode.Edit);
						this.toolStripSeparatorLineTextHere.Visible = (this.Mode == eCanvasEditingMode.Edit);
					}
					bool flag2 = true;
					foreach (PointTool pointTool in lineTool.Ends)
					{
						if (pointTool.Parent != null)
						{
							if (pointTool.Parent.GetType() == typeof(ShinaTool))
							{
								continue;
							}
						}
						flag2 = false;
						break;
					}
					if (flag2)
					{
						this.toolMenuItemLineSetStatusArrow.Visible = true;
					}
				}
			}
		}

		private bool method_63(int int_9)
		{
			return new SqlDataCommand(this.SqlSettings).SelectSqlData("tP_Passport", true, "where IdObjList = " + int_9.ToString() + " and deleted =0 and isactive = 1 ", null).Rows.Count > 0;
		}

		private void toolMenuItemLineAddBranch_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				lineTool.AddBranch();
				new DrawObjectsEventArgs(lineTool);
			}
		}

		private void toolMenuItemLineAddPoint_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				lineTool.AddPointTool();
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(lineTool.GetUpdateScriptXML(true, new List<int>()));
				if (!string.IsNullOrEmpty(stringBuilder.ToString()))
				{
					BackgroundWorker backgroundWorker = new BackgroundWorker();
					backgroundWorker.DoWork += this.method_11;
					backgroundWorker.RunWorkerCompleted += this.method_12;
					stringBuilder.Insert(0, "BEGIN TRANSACTION t2; set transaction isolation level SERIALIZABLE;  select id from tSChm_ObjList (UPDLOCK) select id from tSChm_Xml (UPDLOCK)");
					stringBuilder.Append(" COMMIT TRANSACTION t2; ");
					int workerCounter = this.WorkerCounter;
					this.WorkerCounter = workerCounter + 1;
					backgroundWorker.RunWorkerAsync(stringBuilder);
				}
			}
		}

		private void method_64(object object_0, SchemeCtrl2.DrawTool.TypeSwitch typeSwitch_0)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(object_0);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				ObjectOnLine objectOnLine = lineTool.SelectedBranch.AddSwitchTool(typeSwitch_0, lineTool.ClickedPoint);
				lineTool.Layer.AddObject(objectOnLine);
				objectOnLine.EndDraw();
				this.DoInvalidate(true);
			}
		}

		private void toolMenuItemLineAddOutsideLineDisconnector_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.OutsideLineDisconnectorTool);
		}

		private void toolMenuItemLineAddVacuumSwitch_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.VacuumSwitchTool);
		}

		private void qcutbmkwQj(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.DamageTool);
		}

		private void toolMenuItemLineAddTransformer_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.TransformerTool);
		}

		private void toolMenuItemLineAddVoltageTransformer_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.VoltageTransformerTool);
		}

		private void toolStripMenuItemAddAmperageTransformerTool_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.AmperageTransformer);
		}

		private void toolMenuItemLineAddLoadSwitch_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.LoadSwitchTool);
		}

		private void toolMenuItemLineAddLoadSwitchWaxwork_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.LoadSwitchToolWaxwork);
		}

		private void toolMenuItemLineAddLinearDisconnector_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.LinearDisconnectorTool);
		}

		private void toolMenuItemLineAddLinearDisconnectorWaxwork_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.LinearDisconnectorToolWaxwork);
		}

		private void toolMenuItemLineAddSeparatorTool_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.SeparatorTool);
		}

		private void toolMenuItemLineAddRPS_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.RPSTool);
		}

		private void zdhttAlvjH(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.LubricantSwitchTool);
		}

		private void toolMenuItemLineAddFuseTool_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.FuseTool);
		}

		private void toolMenuItemLineAddDischargerTool_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.DischargerTool);
		}

		private void toolMenuItemLineAddVoltageLimetedTool_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.VoltageLimiterTool);
		}

		private void toolMenuItemLineAddEndTrim_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.EndTrimTool);
		}

		private void toolMenuItemLineAddGroundingTool_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.GroundingTool);
		}

		private void toolMenuItemLineAddCircuitBreakerTool_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.CircuitBreaker);
		}

		private void toolStripMenuItemAddMagneticStarterTool_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.MagneticStarterTool);
		}

		private void toolStripMenuItemAddElectricMeter_Click(object sender, EventArgs e)
		{
			this.method_64(sender, SchemeCtrl2.DrawTool.TypeSwitch.ElectricMeterTool);
		}

		private void toolMenuItemAddLineText_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				TextBranchTool textBranchTool = new TextBranchTool();
				textBranchTool.Text = "Текст";
				textBranchTool.Parent = lineTool.SelectedBranch;
				Form form = new FormTextBranchProperties(textBranchTool);
				lineTool.Layer.AddObject(textBranchTool);
				if (form.ShowDialog() == DialogResult.OK)
				{
					lineTool.SaveXmlToSql();
				}
				else
				{
					textBranchTool.Remove(false, false);
				}
				this.DoInvalidate(true);
			}
		}

		private void toolMenuItemLineDelPoint_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				lineTool.RemovePointTool(lineTool.SelectedPoint);
				this.DoInvalidate(true);
			}
		}

		private void toolMenuItemLinePropertyPoint_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				((LineTool)contextMenu.Tag).SelectedPoint.ShowPropertyForm(contextMenu.Location);
			}
		}

		private void toolMenuItemLinePropertyBranch_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				((LineTool)contextMenu.Tag).SelectedBranch.ShowPropertyForm(contextMenu.Location);
			}
		}

		private void method_65(object object_0, States states_0)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(object_0);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				LineToolState lineToolState = new LineToolState(states_0, lineTool.SelectedBranch, lineTool.ClickedPoint);
				if (lineToolState.state == SchemeCtrl2.DrawTool.States.break_down || lineToolState.state == SchemeCtrl2.DrawTool.States.off)
				{
					new SqlDataCommand(this.SqlSettings).SelectSqlData(this.class22_0.tP_CabOperation, true, " where idObjList = " + lineTool.IdBase.ToString() + " and deleted = 0 order by DateDecommissioning desc", null, false, 0);
					if (lineToolState.Mapping.SearchObjectsOnLine(typeof(OffTool)).Count == 0 && lineToolState.Mapping.SearchObjectsOnLine(typeof(DamageTool)).Count == 0 && (this.class22_0.tP_CabOperation.Rows.Count == 0 || this.class22_0.tP_CabOperation.Rows[0]["DateCommissioning"] != DBNull.Value))
					{
						FormDamageToolWithDefectProperty formDamageToolWithDefectProperty = new FormDamageToolWithDefectProperty(lineTool);
						formDamageToolWithDefectProperty.SqlSettings = this.SqlSettings;
						PointF pointF = ConvertCanvas.ConvertToScreen(this, lineToolState.Mapping.CenterPoint);
						formDamageToolWithDefectProperty.Location = base.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
						Rectangle workingArea = Screen.GetWorkingArea(formDamageToolWithDefectProperty.Location);
						if (formDamageToolWithDefectProperty.Left + formDamageToolWithDefectProperty.Width > workingArea.Left + workingArea.Width)
						{
							formDamageToolWithDefectProperty.Left = formDamageToolWithDefectProperty.Left - formDamageToolWithDefectProperty.Width - 1;
						}
						if (formDamageToolWithDefectProperty.Left < workingArea.Left)
						{
							formDamageToolWithDefectProperty.Left = workingArea.Left;
						}
						if (formDamageToolWithDefectProperty.Top + formDamageToolWithDefectProperty.Height > workingArea.Top + workingArea.Height)
						{
							formDamageToolWithDefectProperty.Top = formDamageToolWithDefectProperty.Top - formDamageToolWithDefectProperty.Height - 1;
						}
						if (formDamageToolWithDefectProperty.Top < workingArea.Top)
						{
							formDamageToolWithDefectProperty.Top = workingArea.Top;
						}
						if (formDamageToolWithDefectProperty.ShowDialog() != DialogResult.OK)
						{
							lineToolState.Remove(false);
							return;
						}
					}
				}
				lineTool.AddState(lineToolState);
				if (!lineToolState.Mapping.Layer.Parent.ValidateToUnique(lineToolState.Mapping))
				{
					lineToolState.Mapping.CreateUniqueCopyName();
				}
				if (this.SimulationMode == eSimulationMode.Online)
				{
					if (lineToolState.Mapping.GetType() == typeof(ArrowTool))
					{
						lineTool.SaveXmlToSql();
					}
					else if (!lineToolState.Mapping.SaveToSql(false, true))
					{
						lineTool.RemoveState(lineToolState);
						return;
					}
					if (lineToolState.state == SchemeCtrl2.DrawTool.States.Arrow)
					{
						CanvasLog.SaveLogDispatcher(this.SqlSettings, new int?(lineTool.IdBase), this.method_66(true, states_0), "");
					}
					else
					{
						CanvasLog.SaveLogDispatcher(this.SqlSettings, new int?(lineToolState.Mapping.IdBase), this.method_66(true, states_0), "");
					}
					try
					{
						int num = 0;
						using (List<Branch>.Enumerator enumerator = lineTool.SelectedBranch.CouplingRelation.method_3().GetEnumerator())
						{
							while (enumerator.MoveNext() && enumerator.Current != lineTool.SelectedBranch)
							{
								num++;
							}
						}
						string id = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString() + Environment.UserName + "_" + Process.GetCurrentProcess().Id.ToString();
						this.proxy_Singleton_0.StateOnLine(lineTool.IdBase, lineTool.SelectedBranch.CouplingRelation.Id, num, lineToolState.Mapping.Delta, (int)states_0, true, id, lineToolState.Mapping.IdBase, Class18.smethod_3());
					}
					catch
					{
					}
				}
			}
		}

		private string method_66(bool bool_12, States states_0)
		{
			string text = bool_12 ? "Добавлен " : "Удален ";
			switch (states_0)
			{
			case SchemeCtrl2.DrawTool.States.grounded:
				text += "статус \"Заземлено\"";
				break;
			case SchemeCtrl2.DrawTool.States.off:
				text += "статус \"Отсоединено\"";
				break;
			case SchemeCtrl2.DrawTool.States.break_down:
				text += "статус \"Повреждено\"";
				break;
			case SchemeCtrl2.DrawTool.States.not_phased:
				text += "статус \"Насфазировано\"";
				break;
			case SchemeCtrl2.DrawTool.States.Arrow:
				text += "перенос нагрузки";
				break;
			}
			return text;
		}

		private void toolMenuItemLineSetStatusGrounding_Click(object sender, EventArgs e)
		{
			this.method_65(sender, SchemeCtrl2.DrawTool.States.grounded);
		}

		private void toolMenuItemLineSetStatusBrakeDown_Click(object sender, EventArgs e)
		{
			this.method_65(sender, SchemeCtrl2.DrawTool.States.break_down);
		}

		private void toolMenuItemLineSetStatusOff_Click(object sender, EventArgs e)
		{
			this.method_65(sender, SchemeCtrl2.DrawTool.States.off);
		}

		private void toolMenuItemLineSetStatusNoPhased_Click(object sender, EventArgs e)
		{
			this.method_65(sender, SchemeCtrl2.DrawTool.States.not_phased);
		}

		private void toolMenuItemLineSetStatusArrow_Click(object sender, EventArgs e)
		{
			this.method_65(sender, SchemeCtrl2.DrawTool.States.Arrow);
		}

		private void toolMenuItemLineTextHere_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				if (lineTool.TextProperty.Visible)
				{
					foreach (PointTool pointTool in lineTool.GetPointsList())
					{
						pointTool.TextProperty.Visible = false;
					}
					lineTool.SelectedPoint.TextProperty.Visible = true;
					lineTool.SelectedPoint.TextProperty.Position = lineTool.TextProperty.Position;
					lineTool.SelectedPoint.Text = lineTool.Text;
					this.DoInvalidate(true);
					Class18.smethod_6(lineTool);
				}
			}
		}

		private void toolStripMenuItemAlignBranchByLeft_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			Branch selectedBranch = lineTool.SelectedBranch;
			if (selectedBranch == null)
			{
				return;
			}
			string a = ((ToolStripMenuItem)sender).Tag.ToString();
			if (!(a == "T"))
			{
				if (!(a == "B"))
				{
					if (!(a == "R"))
					{
						if (a == "L")
						{
							selectedBranch.AlignBy(Alignment.L);
						}
					}
					else
					{
						selectedBranch.AlignBy(Alignment.R);
					}
				}
				else
				{
					selectedBranch.AlignBy(Alignment.B);
				}
			}
			else
			{
				selectedBranch.AlignBy(Alignment.T);
			}
			this.DoInvalidate(true);
			Class18.smethod_6(lineTool);
		}

		private void toolStripMenuItemDisconnectLine_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool obj = (LineTool)contextMenu.Tag;
			PointTool selectedPoint = obj.SelectedPoint;
			if (selectedPoint == null)
			{
				return;
			}
			if (selectedPoint.BranchesCount < 2)
			{
				return;
			}
			List<LineTool> list = new List<LineTool>();
			foreach (CouplingRelation couplingRelation in selectedPoint.CouplingRelations)
			{
				if (list.Contains(couplingRelation.Line))
				{
					return;
				}
				list.Add(couplingRelation.Line);
			}
			PointTool newPoint = new PointTool(selectedPoint.Point, selectedPoint.Layer);
			Branch branch = null;
			IEnumerable<Branch> branches = selectedPoint.Branches;
			Func<Branch, bool> <>9__0;
			Func<Branch, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((Branch bb) => bb.Parent == obj));
			}
			using (IEnumerator<Branch> enumerator2 = branches.Where(predicate).GetEnumerator())
			{
				if (enumerator2.MoveNext())
				{
					branch = enumerator2.Current;
				}
			}
			if (branch == null)
			{
				return;
			}
			obj.RechangePointInBranch(branch, newPoint, branch.Source == selectedPoint);
			this.DoInvalidate(true);
			Class18.smethod_6(obj);
		}

		private void toolStripMenuItemDevideLine_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			PointTool selectedPoint = lineTool.SelectedPoint;
			if (selectedPoint == null)
			{
				return;
			}
			LineTool item = lineTool.DevideLine(selectedPoint);
			Class18.smethod_7(new List<DrawObjectBase>
			{
				item,
				lineTool
			});
		}

		private void toolMenuItemLineRelayProtection_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineCellTool lineCellTool = (LineCellTool)contextMenu.Tag;
			int typeRectnagleTool = (int)((RectangleTool)lineCellTool.Parent).TypeRectnagleTool;
			int idBase = lineCellTool.Parent.IdBase;
			int idBase2 = lineCellTool.GetParentShina().IdBase;
			new FormJRelayProtectionAutomationEditBySchmObj(typeRectnagleTool, idBase, idBase2, lineCellTool.IdBase)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void toolMenuItemLineLogDispatcher_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			string text = lineTool.IdBase.ToString() + ",";
			foreach (Branch branch in lineTool.Branches)
			{
				foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
				{
					if (drawObjectBase is ObjectOnLine)
					{
						text = text + drawObjectBase.IdBase.ToString() + ",";
					}
				}
			}
			text = text.Remove(text.Length - 1);
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			sqlDataCommand.SelectSqlData(this.class22_0.vSchm_LogDispatcher, true, string.Format(" where (IdObj in ({0}) or idLine in ({0})) and typeSchema = {1} order by dateLog desc", text, ((int)this.TypeCanvas).ToString()), null, false, 0);
			object obj = sqlDataCommand.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
			{
				lineTool.IdBase.ToString()
			});
			this.SendMessage(lineTool, (obj != null) ? obj.ToString() : string.Empty, this.class22_0.vSchm_LogDispatcher);
		}

		private void toolMenuItemLineLinkPassport_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			if (new Form5(lineTool)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				new SqlDataCommand(this.sqlsettings_0).SelectSqlData(this.class22_0.vSchm_CabSection, true, "", null, false, 0);
				decimal num = 0m;
				string text = string.Empty;
				SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
				SqlCommand sqlCommand = new SqlCommand("select top 1 id from tP_Passport where idObjList = " + lineTool.IdBase.ToString(), sqlConnection);
				try
				{
					sqlConnection.Open();
					int num2 = (int)sqlCommand.ExecuteScalar();
					if (num2 > -1)
					{
						sqlCommand.CommandText = "select top 1 Value from tP_ObjectChar where idObjChar = 182 and idPassport = " + num2.ToString();
						text = sqlCommand.ExecuteScalar().ToString();
					}
				}
				catch
				{
				}
				if (lineTool.CouplingRelations.Count == 1)
				{
					DataRow dataRow = null;
					IEnumerable<DataRow> enumerable = this.class22_0.vSchm_CabSection.Select("idObjList = " + lineTool.IdBase);
					if (enumerable.Count<DataRow>() > 0)
					{
						decimal d = 0m;
						dataRow = null;
						num = 0m;
						foreach (DataRow dataRow2 in enumerable)
						{
							num += Convert.ToDecimal(dataRow2[8]);
							if (dataRow == null && Convert.ToDecimal(dataRow2[8]) >= 10m)
							{
								d = Convert.ToDecimal(dataRow2[7]);
								dataRow = dataRow2;
							}
							else if (Convert.ToDecimal(dataRow2[7]) < d && Convert.ToDecimal(dataRow2[8]) >= 10m)
							{
								d = Convert.ToDecimal(dataRow2[7]);
								dataRow = dataRow2;
							}
						}
					}
					if (dataRow != null)
					{
						if (text == string.Empty)
						{
							text = Math.Round(Convert.ToDecimal(num), 0).ToString();
						}
						if (lineTool.Branches.Count == 1)
						{
							TextBranchTool textBranchTool = new TextBranchTool();
							textBranchTool.Parent = lineTool.Branches[0];
							textBranchTool.Text = string.Empty;
							lineTool.Layer.AddObject(textBranchTool);
							textBranchTool.UpdateSQLFields(dataRow, text);
							textBranchTool.Passport = true;
						}
						else
						{
							foreach (PointTool pointTool in lineTool.Ends)
							{
								foreach (Branch branch in pointTool.Branches)
								{
									if (branch.Parent == lineTool)
									{
										TextBranchTool textBranchTool2 = new TextBranchTool();
										textBranchTool2.Parent = branch;
										textBranchTool2.Text = string.Empty;
										if (pointTool == branch.Source)
										{
											textBranchTool2.Delta = 0.3f;
										}
										else if (pointTool == branch.Destination)
										{
											textBranchTool2.Delta = 0.6f;
											textBranchTool2.Direct = true;
										}
										lineTool.Layer.AddObject(textBranchTool2);
										textBranchTool2.UpdateSQLFields(dataRow, text);
										textBranchTool2.Passport = true;
									}
								}
							}
						}
					}
					lineTool.SaveXmlToSql();
					this.DoInvalidate(true);
				}
				MessageBox.Show("Паспорт успешно привязан к кабельной линии.");
			}
		}

		private void toolMenuItemLineDeLinkPassport_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			if (SchmObj.UnbindPassport(this.SqlSettings, lineTool.IdBase))
			{
				MessageBox.Show("Паспорт успешно отвязан от кабельной линии.");
			}
		}

		private void toolMenuItemLinePassportOpen_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			if (base.Parent != null && base.Parent is DockContentBase)
			{
				DockPanel dockPanel = ((DockContentBase)base.Parent).DockPanel;
				new FormDockPassport(this.SqlSettings, lineTool.IdBase).Show(dockPanel);
			}
		}

		private void QyjrxReCs8_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
			TelemetryLabelTool telemetryLabelTool = new TelemetryLabelTool();
			telemetryLabelTool.ObjectTelemetry = drawObjectBase.IdBase;
			telemetryLabelTool.Location = this.unitPoint_2;
			drawObjectBase.Layer.AddObject(telemetryLabelTool);
			PointF pointF = ConvertCanvas.ConvertToScreen(this, telemetryLabelTool.Location);
			Point location = base.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
			if (!telemetryLabelTool.ShowPropertyForm(location))
			{
				telemetryLabelTool.Remove(false, false);
			}
		}

		private void method_67(object sender, EventArgs e)
		{
		}

		private void contextMenuLineTool_Closed(object sender, ToolStripDropDownClosedEventArgs e)
		{
			if (this.showContextMenuCanvasEventHandler_1 != null)
			{
				this.showContextMenuCanvasEventHandler_1(this.contextMenuLineTool, null);
			}
		}

		private void QpatEeerlY(object sender, CancelEventArgs e)
		{
			this.toolMenuItemFilterSelectedObjects.Visible = (this.Mode != eCanvasEditingMode.ReadOnly);
			this.toolMenuItemDeleteSelectedObjects.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemSelectedAlign.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolStripMenuItemBookmark.Visible = false;
			this.toolStripMenuItemRemoveBookmark.Visible = false;
			this.toolMenuItemPasteSelectedObjects.Enabled = (this.Mode == eCanvasEditingMode.Edit && CopyPasteCanvasObjects.IsPasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>(), this.list_7));
			this.toolStripMenuItemGroupSelectedObject.Visible = false;
			this.toolStripMenuItemGroupProperty.Visible = false;
			this.toolStripSeparatorGroup.Visible = false;
			this.SelectedObjects.Count<DrawObjectBase>();
			int num = 0;
			int num2 = 0;
			List<GroupDrawObjectBase> list = new List<GroupDrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase is ShinaTool)
				{
					if (((RectangleTool)drawObjectBase.Parent).TypeRectnagleTool == SchemeCtrl2.DrawTool.eTypeRectangleTool.CP)
					{
						num2++;
					}
					else if (((RectangleTool)drawObjectBase.Parent).TypeRectnagleTool != SchemeCtrl2.DrawTool.eTypeRectangleTool.CP)
					{
						num++;
					}
				}
				if (drawObjectBase.Group != null && !list.Contains(drawObjectBase.Group))
				{
					list.Add(drawObjectBase.Group);
				}
				if (drawObjectBase.Bookmark == null)
				{
					this.toolStripMenuItemBookmark.Visible = true;
				}
				if (drawObjectBase.Bookmark != null)
				{
					this.toolStripMenuItemRemoveBookmark.Visible = true;
				}
				if (this.toolStripMenuItemBookmark.Visible && this.toolStripMenuItemRemoveBookmark.Visible)
				{
					break;
				}
			}
			if (this.Mode == eCanvasEditingMode.Edit)
			{
				if (list.Count == 0)
				{
					ToolStripItem toolStripItem = this.toolStripSeparatorGroup;
					this.toolStripMenuItemGroupSelectedObject.Visible = true;
					toolStripItem.Visible = true;
				}
				else if (list.Count == 1)
				{
					ToolStripItem toolStripItem2 = this.toolStripSeparatorGroup;
					this.toolStripMenuItemGroupProperty.Visible = true;
					toolStripItem2.Visible = true;
				}
			}
			this.toolMenuItemSelectedPowerBullshit.Visible = (num == 1 && num2 > 0);
			this.toolStripSeparator13.Visible = this.toolMenuItemSelectedPowerBullshit.Visible;
		}

		private void toolMenuItemCenterSElectedObjects_Click(object sender, EventArgs e)
		{
			this.SetObjectsInCenterScreen(this.SelectedObjects.ToList<DrawObjectBase>(), true, CanvasControl.SetObjectsInCenterScreenOptions.none);
		}

		private void toolMenuItemDeleteSelectedObjects_Click(object sender, EventArgs e)
		{
			if (this.SelectedObjects.Count<DrawObjectBase>() > 0)
			{
				this.RemoveSelectedObjects();
			}
		}

		private void toolMenuItemAddFilterSelectedObjects_Click(object sender, EventArgs e)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase is Branch)
				{
					if (drawObjectBase.Parent != null && !list.Contains(drawObjectBase.Parent))
					{
						list.Add(drawObjectBase.Parent);
					}
				}
				else if (drawObjectBase is BranchCollection)
				{
					if (((BranchCollection)drawObjectBase).Collection.Count<Branch>() > 0)
					{
						Branch branch = ((BranchCollection)drawObjectBase).Collection.First<Branch>();
						if (branch.Parent != null && !list.Contains(branch.Parent))
						{
							list.Add(branch.Parent);
						}
					}
				}
				else if (!list.Contains(drawObjectBase))
				{
					list.Add(drawObjectBase);
				}
			}
			new FormCanvasAddDelFilter(list, 0)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void toolMenuItemDeleteFilterSelectedObjects_Click(object sender, EventArgs e)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase is Branch)
				{
					if (drawObjectBase.Parent != null && !list.Contains(drawObjectBase.Parent))
					{
						list.Add(drawObjectBase.Parent);
					}
				}
				else if (!list.Contains(drawObjectBase))
				{
					list.Add(drawObjectBase);
				}
			}
			new FormCanvasAddDelFilter(list, 2)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void aqXtzFkSaU(object sender, EventArgs e)
		{
			if (this.SelectedCount != 3)
			{
				return;
			}
			new List<ShinaTool>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				ShinaTool shinaTool = drawObjectBase as ShinaTool;
			}
		}

		private void toolMenuItemSelectedAlignByVertCenter_Click(object sender, EventArgs e)
		{
			if (this.SelectedObjects.Count<DrawObjectBase>() < 2)
			{
				return;
			}
			UnitPoint empty = UnitPoint.Empty;
			this.method_15();
			DrawObjectBase drawObjectBase = this.SelectedObjects.First<DrawObjectBase>();
			if (drawObjectBase is LineTool)
			{
				return;
			}
			RectangleF boundingRect = drawObjectBase.GetBoundingRect(this, false);
			string a = ((ToolStripMenuItem)sender).Tag.ToString();
			if (!(a == "T"))
			{
				if (!(a == "B"))
				{
					if (!(a == "R"))
					{
						if (!(a == "L"))
						{
							if (!(a == "H"))
							{
								if (a == "V")
								{
									empty = new UnitPoint(0.0, (double)(boundingRect.Y + boundingRect.Height / 2f));
								}
							}
							else
							{
								empty = new UnitPoint((double)(boundingRect.X + boundingRect.Width / 2f), 0.0);
							}
						}
						else
						{
							empty = new UnitPoint((double)boundingRect.Left, 0.0);
						}
					}
					else
					{
						empty = new UnitPoint((double)boundingRect.Right, 0.0);
					}
				}
				else
				{
					empty = new UnitPoint(0.0, (double)boundingRect.Top);
				}
			}
			else
			{
				empty = new UnitPoint(0.0, (double)boundingRect.Bottom);
			}
			Type type = drawObjectBase.GetType();
			bool flag = false;
			using (IEnumerator<DrawObjectBase> enumerator = this.SelectedObjects.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetType() != type)
					{
						break;
					}
					if (flag)
					{
						return;
					}
				}
			}
			UnitPoint offset = UnitPoint.Empty;
			foreach (DrawObjectBase drawObjectBase2 in this.SelectedObjects)
			{
				if (drawObjectBase2 != drawObjectBase)
				{
					RectangleF boundingRect2 = drawObjectBase2.GetBoundingRect(this, false);
					a = ((ToolStripMenuItem)sender).Tag.ToString();
					if (!(a == "T"))
					{
						if (!(a == "B"))
						{
							if (!(a == "V"))
							{
								if (!(a == "R"))
								{
									if (!(a == "L"))
									{
										if (a == "H")
										{
											offset = new UnitPoint(empty.X - (double)(boundingRect2.X + boundingRect2.Width / 2f), 0.0);
										}
									}
									else
									{
										offset = new UnitPoint(empty.X - (double)boundingRect2.Left, 0.0);
									}
								}
								else
								{
									offset = new UnitPoint(empty.X - (double)boundingRect2.Right, 0.0);
								}
							}
							else
							{
								offset = new UnitPoint(0.0, empty.Y - (double)(boundingRect2.Y + boundingRect2.Height / 2f));
							}
						}
						else
						{
							offset = new UnitPoint(0.0, empty.Y - (double)boundingRect2.Top);
						}
					}
					else
					{
						offset = new UnitPoint(0.0, empty.Y - (double)boundingRect2.Bottom);
					}
					drawObjectBase2.Move(offset, true);
				}
			}
			this.DoInvalidate(true);
			this.method_10();
		}

		private void toolMenuItemCopySelectedObjectsToImage_Click(object sender, EventArgs e)
		{
			this.CopyToImage();
		}

		private void toolStripMenuItemGroupSelectedObject_Click(object sender, EventArgs e)
		{
			if (this.SelectedObjects.Count<DrawObjectBase>() < 2)
			{
				return;
			}
			GroupDrawObjectBase groupDrawObjectBase = new GroupDrawObjectBase();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase.Group == null)
				{
					groupDrawObjectBase.Add(drawObjectBase);
				}
			}
			if (new GroupPropertyForm(groupDrawObjectBase).ShowDialog() == DialogResult.OK)
			{
				this.dictionary_0[groupDrawObjectBase.Id] = groupDrawObjectBase;
			}
		}

		private void toolStripMenuItemGroupProperty_Click(object sender, EventArgs e)
		{
			List<GroupDrawObjectBase> list = new List<GroupDrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase.Group != null && !list.Contains(drawObjectBase.Group))
				{
					list.Add(drawObjectBase.Group);
				}
			}
			if (list.Count == 1)
			{
				new GroupPropertyForm(list[0]).ShowDialog();
			}
		}

		private void toolMenuItemExportSelectedObjectsToDXF_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "(*.dxf)|*.dxf";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.method_47(saveFileDialog.FileName);
				MessageBox.Show("Файл успешно сохранен");
			}
		}

		private void contextMenuCanvas_Opening(object sender, CancelEventArgs e)
		{
			this.toolMenuItemAddNode.Visible = (this.Mode != eCanvasEditingMode.ReadOnly && this.TypeCanvas != eTypeCanvas.SchemeSecond);
			this.toolStripMenuItemAddTelemetryLabel2Level.Visible = (this.Mode == eCanvasEditingMode.Edit && this.TypeCanvas == eTypeCanvas.SchemeSecond);
			this.toolStripMenuItemAddFreeLabel.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuCanvasPaste.Visible = (this.Mode == eCanvasEditingMode.Edit);
			bool cancel;
			if (this.Mode != eCanvasEditingMode.ReadOnly)
			{
				if (this.TypeCanvas != eTypeCanvas.SchemeSecond)
				{
					cancel = false;
					goto IL_8F;
				}
			}
			cancel = (this.Mode != eCanvasEditingMode.Edit);
			IL_8F:
			e.Cancel = cancel;
			if (this.list_7 == null || this.list_7.Count == 0)
			{
				this.toolMenuCanvasPaste.Enabled = false;
			}
		}

		private void toolMenuCanvasPaste_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu != null && contextMenu.Tag != null && contextMenu.Tag is UnitPoint)
			{
				UnitPoint unitPoint_ = (UnitPoint)contextMenu.Tag;
				this.method_26(unitPoint_);
			}
		}

		private void toolMenuItemAddNode_Click(object sender, EventArgs e)
		{
			NodeTool nodeTool = new NodeTool();
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu != null && contextMenu.Tag != null && contextMenu.Tag is UnitPoint)
			{
				UnitPoint location = (UnitPoint)contextMenu.Tag;
				nodeTool.Location = location;
				this.AddObject(this.ActiveLayer, nodeTool);
				if (!nodeTool.ShowPropertyForm(Point.Empty))
				{
					nodeTool.Remove(false, false);
				}
			}
		}

		private void toolStripMenuItemAddFreeLabel_Click(object sender, EventArgs e)
		{
			FreeLabelTool freeLabelTool = new FreeLabelTool();
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu != null && contextMenu.Tag != null && contextMenu.Tag is UnitPoint)
			{
				UnitPoint location = (UnitPoint)contextMenu.Tag;
				freeLabelTool.Location = location;
				this.AddObject(this.ActiveLayer, freeLabelTool);
				if (!freeLabelTool.ShowPropertyForm(Point.Empty))
				{
					freeLabelTool.Remove(false, false);
				}
			}
		}

		private void toolStripMenuItemAddTelemetryLabel2Level_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && this.Mode != eCanvasEditingMode.Edit && this.TypeCanvas != eTypeCanvas.SchemeSecond && this.IdRect == 0)
			{
				return;
			}
			TelemetryLabelTool telemetryLabelTool = new TelemetryLabelTool();
			telemetryLabelTool.ObjectTelemetry = this.IdRect;
			telemetryLabelTool.Location = (UnitPoint)contextMenu.Tag;
			this.AddObject(this.ActiveLayer, telemetryLabelTool);
			if (!telemetryLabelTool.ShowPropertyForm(Point.Empty))
			{
				telemetryLabelTool.Remove(false, false);
			}
		}

		private void contextMenuLabelTool_Opening(object sender, CancelEventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				if (contextMenu.Tag.GetType() != typeof(AutomaticEntryProvisionTool) && contextMenu.Tag.GetType() != typeof(SpecialLockingTool) && contextMenu.Tag.GetType() != typeof(TelemechanicsTool) && contextMenu.Tag.GetType() != typeof(TelemechanicsProtectionTool))
				{
					if (contextMenu.Tag.GetType() != typeof(ResponsibleAbonentTool))
					{
						if (contextMenu.Tag.GetType() != typeof(TelemetryLabelTool))
						{
							this.toolMenuItemLabelDel.Visible = false;
						}
						if (this.Mode == eCanvasEditingMode.ReadOnly)
						{
							this.toolMenuItemLabelDel.Visible = false;
							goto IL_EB;
						}
						this.toolMenuItemLabelDel.Visible = true;
						goto IL_EB;
					}
				}
				this.toolMenuItemLabelDel.Visible = false;
				IL_EB:
				if (contextMenu.Tag.GetType() != typeof(TelemetryLabelTool) && contextMenu.Tag.GetType() != typeof(MeasurementLabelTool))
				{
					this.toolMenuItemLabelUpdate.Visible = false;
				}
			}
		}

		private void toolMenuItemLabelDel_Click(object sender, EventArgs e)
		{
			if (this.list_1 != null)
			{
				foreach (DrawObjectBase drawObjectBase in this.list_1)
				{
					if (drawObjectBase is NodeTool)
					{
						this.proxy_Singleton_0.NodeChange(drawObjectBase.IdBase, 2, null, PointF.Empty, Color.Empty, Class18.smethod_3());
					}
				}
				UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(this.SelectedObjects.ToList<DrawObjectBase>(), UndoRedoManager.ChangesMode.DeleteObject);
				this.undoRedoManager.HappenedChange(changes);
				this.DeleteObjects(this.SelectedObjects, true);
				this.ClearSelectedObjects();
				this.DoInvalidate(true);
				this.method_24();
			}
		}

		private void toolMenuItemLabelUpdate_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null && contextMenu.Tag.GetType() == typeof(TelemetryLabelTool))
			{
				DataRow[] array = this.OpcClient.SelectFromOPCConfig(string.Concat(new string[]
				{
					"ObjectId in (",
					((TelemetryLabelTool)contextMenu.Tag).ObjectTelemetry.ToString(),
					") and ParameterId in (",
					((TelemetryLabelTool)contextMenu.Tag).TelemetryParameterId.ToString(),
					")"
				}));
				if (array.Length != 0)
				{
					if (!(array[0]["ItemName"].ToString() == string.Empty))
					{
						int[] array2 = new int[]
						{
							((TelemetryLabelTool)contextMenu.Tag).ObjectTelemetry,
							((TelemetryLabelTool)contextMenu.Tag).TelemetryParameterId
						};
						this.OpcClient.OPCAsyncSend_GetItem(array2);
						return;
					}
					DataTable dataTable = this.OpcClient.SelectFromOPCLog(string.Format("where [source] = '{0}'and [Description]= 'AREAS' and value = '[\"{1}\"]'", array[0]["Source"].ToString(), array[0]["Area"].ToString()));
					if (dataTable.Rows.Count > 0)
					{
						((TelemetryLabelTool)contextMenu.Tag).Text = dataTable.Rows[0]["Message"].ToString();
						return;
					}
				}
			}
			else if (contextMenu.Tag != null && contextMenu.Tag.GetType() == typeof(MeasurementLabelTool))
			{
				this.method_57(((MeasurementLabelTool)contextMenu.Tag).Parent.IdBase);
			}
		}

		public List<int> ApplyFilter()
		{
			List<int> list = new List<int>();
			FormCanvasFilterApply formCanvasFilterApply = new FormCanvasFilterApply(this.Settings);
			formCanvasFilterApply.SqlSettings = this.SqlSettings;
			if (formCanvasFilterApply.ShowDialog() == DialogResult.OK)
			{
				this.list_8 = formCanvasFilterApply.ListIdFilter;
				string text = "";
				foreach (int num in this.list_8)
				{
					text = text + num.ToString() + ",";
				}
				if (text.Length > 0)
				{
					text = text.Remove(text.Length - 1);
					new SqlDataCommand(this.sqlsettings_0).SelectSqlData(this.class22_0.tSchm_ObjFilter, true, "where [idFilter] in (" + text + ")", null, false, 0);
					foreach (DataRow dataRow in this.class22_0.tSchm_ObjFilter)
					{
						list.Add(Convert.ToInt32(dataRow["idObj"]));
					}
					if (!formCanvasFilterApply.IsOtherWindow)
					{
						foreach (ICanvasLayer canvasLayer in this.Layers)
						{
							((DrawingLayer)canvasLayer).ApplyFilter(list);
						}
						this.DoInvalidate(true);
						list = null;
					}
				}
				return list;
			}
			return null;
		}

		public void ApplyFilter(List<int> listIdObjects)
		{
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				((DrawingLayer)canvasLayer).ApplyFilter(listIdObjects);
			}
			this.DoInvalidate(true);
		}

		public void ClearFilter()
		{
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				((DrawingLayer)canvasLayer).ClearFilter();
			}
			this.DoInvalidate(true);
		}

		private void toolStripMenuFramePrint_Click(object sender, EventArgs e)
		{
			this.Print();
		}

		private void toolStripMenuFrameCopyToImage_Click(object sender, EventArgs e)
		{
			this.CopyToImage();
		}

		private void toolStripMenuFrameFitZoom_Click(object sender, EventArgs e)
		{
			if (this.canvasFrame_0 != null)
			{
				this.method_28(this.canvasFrame_0.Rectangle, true);
				this.eCommandType_0 = eCommandType.select;
				this.canvasFrame_0 = null;
				this.method_24();
			}
		}

		private void toolStripMenuFrameExportToImage_Click(object sender, EventArgs e)
		{
			this.ExportToImage();
		}

		public static ContextMenuStrip GetContextMenu(object sender)
		{
			if (sender == null)
			{
				return null;
			}
			if (sender is ContextMenuStrip)
			{
				return sender as ContextMenuStrip;
			}
			ToolStripItem toolStripItem = sender as ToolStripItem;
			while (toolStripItem.OwnerItem != null)
			{
				toolStripItem = toolStripItem.OwnerItem;
			}
			ContextMenuStrip contextMenuStrip = toolStripItem.Owner as ContextMenuStrip;
			if (contextMenuStrip != null)
			{
				return contextMenuStrip;
			}
			return null;
		}

		private void contextMenuTextBranchTool_Opening(object sender, CancelEventArgs e)
		{
			this.toolMenuItemTextBranchDel.Enabled = (this.Mode == eCanvasEditingMode.Edit);
			if (this.contextMenuTextBranchTool.Tag != null)
			{
				TextBranchTool textBranchTool = (TextBranchTool)this.contextMenuSwitchTool.Tag;
				this.toolStripMenuItemTBTDisplayGrLevel.Visible = (this.Mode == eCanvasEditingMode.Edit && this.TypeCanvas == eTypeCanvas.SchemeSecond);
			}
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CanvasControl));
			this.statusStrip = new StatusStrip();
			this.labelMousePosition = new ToolStripStatusLabel();
			this.toolBtnZoom = new ToolStripSplitButton();
			this.toolTxtZoomChanged = new ToolStripTextBox();
			this.toolBtnZoom800 = new ToolStripMenuItem();
			this.toolBtnZoom400 = new ToolStripMenuItem();
			this.toolBtnZoom200 = new ToolStripMenuItem();
			this.toolBtnZoom150 = new ToolStripMenuItem();
			this.toolBtnZoom125 = new ToolStripMenuItem();
			this.toolBtnZoom100 = new ToolStripMenuItem();
			this.toolBtnZoom75 = new ToolStripMenuItem();
			this.toolBtnZoom50 = new ToolStripMenuItem();
			this.toolBtnZoom25 = new ToolStripMenuItem();
			this.labelInfo = new ToolStripStatusLabel();
			this.GihsIhiuKn = new ToolStripStatusLabel();
			this.labelProgressBar = new ToolStripStatusLabel();
			this.toolProgressBarSave = new ToolStripProgressBar();
			this.toolStripStatusLabelConnected = new ToolStripStatusLabel();
			this.class22_0 = new Class22();
			this.printDocument = new PrintDocument();
			this.printDialog = new PrintDialog();
			this.pageSetupDialog_0 = new PageSetupDialog();
			this.printPreviewDialog = new PrintPreviewDialog();
			this.propertyGrid1 = new PropertyGrid();
			this.bigBoldButton = new Button();
			this.buttonCheck = new Button();
			this.timer_1 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.tbPopup = new Label();
			this.contextMenuSelectedObjects = new ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemFilterSelectedObjects = new ToolStripMenuItem();
			this.toolMenuItemAddFilterSelectedObjects = new ToolStripMenuItem();
			this.toolMenuItemDeleteFilterSelectedObjects = new ToolStripMenuItem();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.toolStripMenuItemBookmark = new ToolStripMenuItem();
			this.toolStripMenuItemRemoveBookmark = new ToolStripMenuItem();
			this.toolStripSeparator9 = new ToolStripSeparator();
			this.toolMenuItemSelectedPowerBullshit = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlign = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByTop = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByBottom = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByRigth = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByLeft = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByHorCenter = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByVertCenter = new ToolStripMenuItem();
			this.toolStripSeparator13 = new ToolStripSeparator();
			this.toolStripMenuItemGroupSelectedObject = new ToolStripMenuItem();
			this.toolStripMenuItemGroupProperty = new ToolStripMenuItem();
			this.toolStripSeparatorGroup = new ToolStripSeparator();
			this.toolMenuItemCenterSElectedObjects = new ToolStripMenuItem();
			this.toolMenuItemCopySelectedObjects = new ToolStripMenuItem();
			this.toolMenuItemCopySelectedObjectsToImage = new ToolStripMenuItem();
			this.toolMenuItemExportSelectedObjectsToDXF = new ToolStripMenuItem();
			this.toolMenuItemPasteSelectedObjects = new ToolStripMenuItem();
			this.toolMenuItemDeleteSelectedObjects = new ToolStripMenuItem();
			this.contextMenuRectnagle = new ContextMenuStrip(this.icontainer_0);
			this.twFspjsly3 = new ToolStripMenuItem();
			this.toolMenuItemRectRecipientsPower = new ToolStripMenuItem();
			this.toolStripSeparator10 = new ToolStripSeparator();
			this.toolMenuItemRectFilter = new ToolStripMenuItem();
			this.toolMenuItemRectFilterAdd = new ToolStripMenuItem();
			this.toolMenuItemRectFilterDel = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.toolMenuItemRectCopy = new ToolStripMenuItem();
			this.toolMenuItemRectPaste = new ToolStripMenuItem();
			this.toolMenuItemRectDel = new ToolStripMenuItem();
			this.toolStripMenuItemRectanglePosition = new ToolStripMenuItem();
			this.toolStripMenuItemReflect = new ToolStripMenuItem();
			this.toolStripMenuItemVReflect = new ToolStripMenuItem();
			this.toolStripMenuItemHReflect = new ToolStripMenuItem();
			this.toolStripMenuItemRotateRectangle = new ToolStripMenuItem();
			this.toolStripMenuItemRotate90 = new ToolStripMenuItem();
			this.toolStripMenuItemRotate180 = new ToolStripMenuItem();
			this.toolStripMenuItemRotate170 = new ToolStripMenuItem();
			this.toolMenuItemRectAlign = new ToolStripMenuItem();
			this.toolStripMenuItemAdjacentSubstation = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.toolMenuItemRectFile = new ToolStripMenuItem();
			this.toolMenuItemRectProperty = new ToolStripMenuItem();
			this.contextMenuShina = new ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemShinaAddChild = new ToolStripMenuItem();
			this.toolMenuItemShinaAddCell = new ToolStripMenuItem();
			this.toolMenuItemShinaBridge = new ToolStripMenuItem();
			this.toolMenuItemShinaSplitter = new ToolStripMenuItem();
			this.toolStripMenuItemAddWhitePoint = new ToolStripMenuItem();
			this.toolMeniItemShinaAddPattern = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn = new ToolStripMenuItem();
			this.oGyhJxxeRR = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn2 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn3 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn4 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn5 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn6 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn7 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn8 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn9 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn10 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto1 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto2 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto3 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto4 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto5 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto6 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto7 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto8 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto9 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto10 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve1 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve2 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve3 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve4 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve5 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve6 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve7 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve8 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve9 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve10 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS1 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS2 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS3 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS4 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS5 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS6 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS7 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS8 = new ToolStripMenuItem();
			this.EhkrgnfgYC = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS10 = new ToolStripMenuItem();
			this.toolStripSeparator7 = new ToolStripSeparator();
			this.waWrHaQms2 = new ToolStripMenuItem();
			this.ldtrvofZuY = new ToolStripMenuItem();
			this.toolMenuItemShinaCopy = new ToolStripMenuItem();
			this.toolMenuItemShinaPaste = new ToolStripMenuItem();
			this.toolMenuItemShinaDel = new ToolStripMenuItem();
			this.toolStripSeparatorEditShina = new ToolStripSeparator();
			this.toolStripMenuItemBusMeasurement = new ToolStripMenuItem();
			this.toolMenuItemShinaPowerSource = new ToolStripMenuItem();
			this.toolStripMenuItem2 = new ToolStripMenuItem();
			this.toolStripMenuItem5 = new ToolStripMenuItem();
			this.toolMenuItemShinaRecipientsPower = new ToolStripMenuItem();
			this.toolStripMenuItem3 = new ToolStripMenuItem();
			this.toolStripMenuItem4 = new ToolStripMenuItem();
			this.toolStripMenuItem11 = new ToolStripMenuItem();
			this.toolStripMenuItemAllPower = new ToolStripMenuItem();
			this.toolStripMenuItemAdjacentSubstation2 = new ToolStripMenuItem();
			this.toolStripMenuItemShinaGetOldAbn = new ToolStripMenuItem();
			this.toolStripMenuItemShinaOldAbnCurrentRect = new ToolStripMenuItem();
			this.toolStripMenuItemShinaOldAbnNextRect = new ToolStripMenuItem();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.toolMenuItemShinaFilter = new ToolStripMenuItem();
			this.toolMenuItemShinaFilterAdd = new ToolStripMenuItem();
			this.toolMenuItemShinaFilterDel = new ToolStripMenuItem();
			this.toolStripSeparator11 = new ToolStripSeparator();
			this.toolMenuItemShinaFile = new ToolStripMenuItem();
			this.toolMenuItemShinaProperty = new ToolStripMenuItem();
			this.contextMenuSwitchTool = new ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemSwitchPassport = new ToolStripMenuItem();
			this.toolMenuItemSwitchOn = new ToolStripMenuItem();
			this.toolStripMenuChangeArrowDirection = new ToolStripMenuItem();
			this.toolMenuItemSwitchFilter = new ToolStripMenuItem();
			this.toolMenuItemSwitchFilterAdd = new ToolStripMenuItem();
			this.toolMenuItemSwitchFilterDel = new ToolStripMenuItem();
			this.toolStripMenuItemOOLDisplayGrLevel = new ToolStripMenuItem();
			this.toolStripMenuItemSwitchAddTelemetry = new ToolStripMenuItem();
			this.toolMenuItemSwitchErcloud = new ToolStripMenuItem();
			this.toolMenuItemSwitchLinkErcloud = new ToolStripMenuItem();
			this.toolMenuItemSwitchShowDataErcloud = new ToolStripMenuItem();
			this.toolStripSeparator12 = new ToolStripSeparator();
			this.toolStripMenuItemCSRollingOut = new ToolStripMenuItem();
			this.toolStripMenuItemCSRepairMode = new ToolStripMenuItem();
			this.toolStripMenuItemCSTestMode = new ToolStripMenuItem();
			this.toolStripMenuItemCSNormalMode = new ToolStripMenuItem();
			this.toolStripSeparatorCS = new ToolStripSeparator();
			this.toolMenuItemStateDel = new ToolStripMenuItem();
			this.toolMenuItemSwitchCopy = new ToolStripMenuItem();
			this.toolMenuItemSwitchDel = new ToolStripMenuItem();
			this.toolStripSeparator5 = new ToolStripSeparator();
			this.ToolStripMenuItemSwitchMeasurement = new ToolStripMenuItem();
			this.toolMenuItemSwitchLogDispatcher = new ToolStripMenuItem();
			this.toolMenuItemSwitchFile = new ToolStripMenuItem();
			this.MSMZJEXRVG = new ToolStripMenuItem();
			this.contextMenuLineTool = new ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemLineAddChild = new ToolStripMenuItem();
			this.toolMenuItemLineAddBranch = new ToolStripMenuItem();
			this.toolMenuItemLineAddPoint = new ToolStripMenuItem();
			this.toolStripSeparatorLineAddBranchPoint = new ToolStripSeparator();
			this.toolMenuItemLineAddOutsideLineDisconnector = new ToolStripMenuItem();
			this.toolMenuItemLineAddVacuumSwitch = new ToolStripMenuItem();
			this.toolMenuItemLineAddTransformer = new ToolStripMenuItem();
			this.toolMenuItemLineAddVoltageTransformer = new ToolStripMenuItem();
			this.toolStripMenuItemAddAmperageTransformerTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddLoadSwitch = new ToolStripMenuItem();
			this.toolMenuItemLineAddLoadSwitchWaxwork = new ToolStripMenuItem();
			this.toolMenuItemLineAddRPS = new ToolStripMenuItem();
			this.toolMenuItemLineAddLinearDisconnector = new ToolStripMenuItem();
			this.toolMenuItemLineAddLinearDisconnectorWaxwork = new ToolStripMenuItem();
			this.toolMenuItemLineAddLubricantDisconnector = new ToolStripMenuItem();
			this.toolMenuItemLineAddFuseTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddDischargerTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddVoltageLimetedTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddEndTrim = new ToolStripMenuItem();
			this.toolMenuItemLineAddCircuitBreakerTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddGroundingTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddSeparatorTool = new ToolStripMenuItem();
			this.toolStripMenuItemAddMagneticStarterTool = new ToolStripMenuItem();
			this.toolStripMenuItemAddElectricMeter = new ToolStripMenuItem();
			this.toolStripSeparator6 = new ToolStripSeparator();
			this.toolMenuItemAddLineText = new ToolStripMenuItem();
			this.toolMenuItemLineCopy = new ToolStripMenuItem();
			this.uBbItwaYjM = new ToolStripMenuItem();
			this.toolStripMenuItemDevideLine = new ToolStripMenuItem();
			this.toolStripMenuItemDisconnectLine = new ToolStripMenuItem();
			this.toolMenuItemLineDel = new ToolStripMenuItem();
			this.toolMenuItemLineDelObj = new ToolStripMenuItem();
			this.toolMenuItemLineDelPoint = new ToolStripMenuItem();
			this.toolStripSeparatorEditLine = new ToolStripSeparator();
			this.toolMenuItemLineSetStatus = new ToolStripMenuItem();
			this.toolMenuItemLineSetStatusGrounding = new ToolStripMenuItem();
			this.toolMenuItemLineSetStatusBrakeDown = new ToolStripMenuItem();
			this.toolMenuItemLineSetStatusOff = new ToolStripMenuItem();
			this.toolMenuItemLineSetStatusNoPhased = new ToolStripMenuItem();
			this.toolMenuItemLineSetStatusArrow = new ToolStripMenuItem();
			this.toolStripSeparatorSetStatus = new ToolStripSeparator();
			this.toolMenuItemLineTextHere = new ToolStripMenuItem();
			this.toolStripSeparatorLineTextHere = new ToolStripSeparator();
			this.toolMenuItemLineFilter = new ToolStripMenuItem();
			this.toolMenuItemLineFilterAdd = new ToolStripMenuItem();
			this.toolMenuItemLineFilterDel = new ToolStripMenuItem();
			this.toolMenuItemLinePowerSource = new ToolStripSeparator();
			this.toolStripMenuItem1 = new ToolStripMenuItem();
			this.toolStripMenuItem6 = new ToolStripMenuItem();
			this.toolStripMenuItem8 = new ToolStripMenuItem();
			this.toolMenuItemLineRecipientsPower = new ToolStripMenuItem();
			this.toolStripMenuItem7 = new ToolStripMenuItem();
			this.toolStripMenuItem9 = new ToolStripMenuItem();
			this.toolStripMenuItem10 = new ToolStripMenuItem();
			this.toolStripMenuItem12 = new ToolStripMenuItem();
			this.toolStripMenuItem13 = new ToolStripMenuItem();
			this.toolStripMenuItem14 = new ToolStripMenuItem();
			this.QyjrxReCs8 = new ToolStripMenuItem();
			this.toolStripSeparator8 = new ToolStripSeparator();
			this.toolMenuItemLinePropertyPoint = new ToolStripMenuItem();
			this.toolStripMenuItemLineAlignBranch = new ToolStripMenuItem();
			this.toolStripMenuItemAlignBranchByTop = new ToolStripMenuItem();
			this.toolStripMenuItemAlignBranchByBottom = new ToolStripMenuItem();
			this.toolStripMenuItemAlignBranchByRigth = new ToolStripMenuItem();
			this.toolStripMenuItemAlignBranchByLeft = new ToolStripMenuItem();
			this.toolMenuItemLinePropertyBranch = new ToolStripMenuItem();
			this.toolStripSeparator14 = new ToolStripSeparator();
			this.toolMenuItemLineRelayProtection = new ToolStripMenuItem();
			this.toolMenuItemLineLogDispatcher = new ToolStripMenuItem();
			this.toolMenuItemLinePassport = new ToolStripMenuItem();
			this.toolMenuItemLinePassportOpen = new ToolStripMenuItem();
			this.toolMenuItemLineDeLinkPassport = new ToolStripMenuItem();
			this.toolMenuItemLineLinkPassport = new ToolStripMenuItem();
			this.toolMenuItemLineFile = new ToolStripMenuItem();
			this.toolMenuItemLineProperty = new ToolStripMenuItem();
			this.contextMenuCanvas = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItemAddFreeLabel = new ToolStripMenuItem();
			this.toolStripMenuItemAddTelemetryLabel2Level = new ToolStripMenuItem();
			this.toolMenuItemAddNode = new ToolStripMenuItem();
			this.toolMenuCanvasPaste = new ToolStripMenuItem();
			this.imageList_0 = new ImageList(this.icontainer_0);
			this.contextMenuLabelTool = new ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemLabelUpdate = new ToolStripMenuItem();
			this.toolMenuItemLabelDel = new ToolStripMenuItem();
			this.toolMenuItemLabelProperty = new ToolStripMenuItem();
			this.contextMenuStripWhitePoint = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItemRemoveWhitePoint = new ToolStripMenuItem();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.contextMenuFrame = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuFramePrint = new ToolStripMenuItem();
			this.toolStripMenuFrameCopyToImage = new ToolStripMenuItem();
			this.toolStripMenuFrameExportToImage = new ToolStripMenuItem();
			this.toolStripMenuFrameFitZoom = new ToolStripMenuItem();
			this.textBoxSearch = new TextBox();
			this.button1 = new Button();
			this.contextMenuTextBranchTool = new ContextMenuStrip(this.icontainer_0);
			this.reArSpApSW = new ToolStripMenuItem();
			this.toolStripMenuItemTBTDisplayGrLevel = new ToolStripMenuItem();
			this.toolMenuItemTextBranchDel = new ToolStripMenuItem();
			this.WcgruJuvXg = new ToolStripMenuItem();
			this.statusStrip.SuspendLayout();
			((ISupportInitialize)this.class22_0).BeginInit();
			this.contextMenuSelectedObjects.SuspendLayout();
			this.contextMenuRectnagle.SuspendLayout();
			this.contextMenuShina.SuspendLayout();
			this.contextMenuSwitchTool.SuspendLayout();
			this.contextMenuLineTool.SuspendLayout();
			this.contextMenuCanvas.SuspendLayout();
			this.contextMenuLabelTool.SuspendLayout();
			this.contextMenuStripWhitePoint.SuspendLayout();
			this.contextMenuFrame.SuspendLayout();
			this.contextMenuTextBranchTool.SuspendLayout();
			base.SuspendLayout();
			this.statusStrip.ImageScalingSize = new Size(20, 20);
			this.statusStrip.Items.AddRange(new ToolStripItem[]
			{
				this.labelMousePosition,
				this.toolBtnZoom,
				this.labelInfo,
				this.GihsIhiuKn,
				this.labelProgressBar,
				this.toolProgressBarSave,
				this.toolStripStatusLabelConnected
			});
			this.statusStrip.Location = new Point(0, 465);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new Size(754, 29);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip1";
			this.labelMousePosition.AutoSize = false;
			this.labelMousePosition.BorderSides = (ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right);
			this.labelMousePosition.Image = (Image)componentResourceManager.GetObject("labelMousePosition.Image");
			this.labelMousePosition.Name = "labelMousePosition";
			this.labelMousePosition.Size = new Size(140, 24);
			this.toolBtnZoom.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolTxtZoomChanged,
				this.toolBtnZoom800,
				this.toolBtnZoom400,
				this.toolBtnZoom200,
				this.toolBtnZoom150,
				this.toolBtnZoom125,
				this.toolBtnZoom100,
				this.toolBtnZoom75,
				this.toolBtnZoom50,
				this.toolBtnZoom25
			});
			this.toolBtnZoom.Name = "toolBtnZoom";
			this.toolBtnZoom.Size = new Size(51, 27);
			this.toolBtnZoom.Text = "100%";
			this.toolTxtZoomChanged.Name = "toolTxtZoomChanged";
			this.toolTxtZoomChanged.Size = new Size(100, 23);
			this.toolTxtZoomChanged.KeyDown += this.toolTxtZoomChanged_KeyDown;
			this.toolBtnZoom800.Name = "toolBtnZoom800";
			this.toolBtnZoom800.Size = new Size(160, 22);
			this.toolBtnZoom800.Tag = "800";
			this.toolBtnZoom800.Text = "800%";
			this.toolBtnZoom800.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom400.Name = "toolBtnZoom400";
			this.toolBtnZoom400.Size = new Size(160, 22);
			this.toolBtnZoom400.Tag = "400";
			this.toolBtnZoom400.Text = "400%";
			this.toolBtnZoom400.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom200.Name = "toolBtnZoom200";
			this.toolBtnZoom200.Size = new Size(160, 22);
			this.toolBtnZoom200.Tag = "200";
			this.toolBtnZoom200.Text = "200%";
			this.toolBtnZoom200.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom150.Name = "toolBtnZoom150";
			this.toolBtnZoom150.Size = new Size(160, 22);
			this.toolBtnZoom150.Tag = "150";
			this.toolBtnZoom150.Text = "150%";
			this.toolBtnZoom150.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom125.Name = "toolBtnZoom125";
			this.toolBtnZoom125.Size = new Size(160, 22);
			this.toolBtnZoom125.Tag = "125";
			this.toolBtnZoom125.Text = "125%";
			this.toolBtnZoom125.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom100.Name = "toolBtnZoom100";
			this.toolBtnZoom100.Size = new Size(160, 22);
			this.toolBtnZoom100.Tag = "100";
			this.toolBtnZoom100.Text = "100%";
			this.toolBtnZoom100.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom75.Name = "toolBtnZoom75";
			this.toolBtnZoom75.Size = new Size(160, 22);
			this.toolBtnZoom75.Tag = "75";
			this.toolBtnZoom75.Text = "75%";
			this.toolBtnZoom75.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom50.Name = "toolBtnZoom50";
			this.toolBtnZoom50.Size = new Size(160, 22);
			this.toolBtnZoom50.Tag = "50";
			this.toolBtnZoom50.Text = "50%";
			this.toolBtnZoom50.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom25.Name = "toolBtnZoom25";
			this.toolBtnZoom25.Size = new Size(160, 22);
			this.toolBtnZoom25.Tag = "25";
			this.toolBtnZoom25.Text = "25%";
			this.toolBtnZoom25.Click += this.toolBtnZoom25_Click;
			this.labelInfo.BorderSides = (ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new Size(17, 24);
			this.labelInfo.Text = "  ";
			this.GihsIhiuKn.Name = "toolLabelEmpty";
			this.GihsIhiuKn.Size = new Size(531, 24);
			this.GihsIhiuKn.Spring = true;
			this.labelProgressBar.BorderSides = ToolStripStatusLabelBorderSides.Left;
			this.labelProgressBar.Name = "labelProgressBar";
			this.labelProgressBar.Size = new Size(77, 24);
			this.labelProgressBar.Text = "Сохранение";
			this.labelProgressBar.Visible = false;
			this.toolProgressBarSave.Name = "toolProgressBarSave";
			this.toolProgressBarSave.Size = new Size(100, 23);
			this.toolProgressBarSave.Visible = false;
			this.toolStripStatusLabelConnected.Name = "toolStripStatusLabelConnected";
			this.toolStripStatusLabelConnected.Size = new Size(0, 24);
			this.class22_0.DataSetName = "DataSetScheme";
			this.class22_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.printDocument.DocumentName = "Sheme";
			this.printDocument.BeginPrint += this.printDocument_BeginPrint;
			this.printDocument.EndPrint += this.printDocument_EndPrint;
			this.printDocument.PrintPage += this.printDocument_PrintPage;
			this.printDialog.Document = this.printDocument;
			this.printDialog.UseEXDialog = true;
			this.pageSetupDialog_0.Document = this.printDocument;
			this.pageSetupDialog_0.EnableMetric = true;
			this.printPreviewDialog.AutoScrollMargin = new Size(0, 0);
			this.printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
			this.printPreviewDialog.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.printPreviewDialog.ClientSize = new Size(400, 300);
			this.printPreviewDialog.Document = this.printDocument;
			this.printPreviewDialog.Enabled = true;
			this.printPreviewDialog.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog.Icon");
			this.printPreviewDialog.Name = "printPreviewDialog";
			this.printPreviewDialog.Visible = false;
			this.propertyGrid1.Location = new Point(0, 32);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new Size(187, 361);
			this.propertyGrid1.TabIndex = 1;
			this.bigBoldButton.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.bigBoldButton.Location = new Point(0, 3);
			this.bigBoldButton.Name = "bigBoldButton";
			this.bigBoldButton.Size = new Size(187, 23);
			this.bigBoldButton.TabIndex = 2;
			this.bigBoldButton.Text = "BIG BOLD BUTTON";
			this.bigBoldButton.TextImageRelation = TextImageRelation.ImageAboveText;
			this.bigBoldButton.Click += this.bigBoldButton_Click;
			this.buttonCheck.Location = new Point(723, 3);
			this.buttonCheck.Name = "buttonCheck";
			this.buttonCheck.Size = new Size(47, 23);
			this.buttonCheck.TabIndex = 3;
			this.buttonCheck.Text = "Check";
			this.buttonCheck.UseVisualStyleBackColor = true;
			this.buttonCheck.Visible = false;
			this.buttonCheck.Click += this.buttonCheck_Click;
			this.timer_1.Interval = 1500;
			this.timer_1.Tick += this.timer_1_Tick;
			this.tbPopup.AutoSize = true;
			this.tbPopup.Location = new Point(648, 8);
			this.tbPopup.Name = "tbPopup";
			this.tbPopup.Size = new Size(35, 13);
			this.tbPopup.TabIndex = 4;
			this.tbPopup.Text = "label1";
			this.tbPopup.Visible = false;
			this.contextMenuSelectedObjects.ImageScalingSize = new Size(20, 20);
			this.contextMenuSelectedObjects.Items.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemFilterSelectedObjects,
				this.toolStripSeparator4,
				this.toolStripMenuItemBookmark,
				this.toolStripMenuItemRemoveBookmark,
				this.toolStripSeparator9,
				this.toolMenuItemSelectedPowerBullshit,
				this.toolMenuItemSelectedAlign,
				this.toolStripSeparator13,
				this.toolStripMenuItemGroupSelectedObject,
				this.toolStripMenuItemGroupProperty,
				this.toolStripSeparatorGroup,
				this.toolMenuItemCenterSElectedObjects,
				this.toolMenuItemCopySelectedObjects,
				this.toolMenuItemCopySelectedObjectsToImage,
				this.toolMenuItemExportSelectedObjectsToDXF,
				this.toolMenuItemPasteSelectedObjects,
				this.toolMenuItemDeleteSelectedObjects
			});
			this.contextMenuSelectedObjects.Name = "contextMenuSelectedObjects";
			this.contextMenuSelectedObjects.Size = new Size(202, 314);
			this.contextMenuSelectedObjects.Opening += this.QpatEeerlY;
			this.toolMenuItemFilterSelectedObjects.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemAddFilterSelectedObjects,
				this.toolMenuItemDeleteFilterSelectedObjects
			});
			this.toolMenuItemFilterSelectedObjects.Name = "toolMenuItemFilterSelectedObjects";
			this.toolMenuItemFilterSelectedObjects.Size = new Size(201, 22);
			this.toolMenuItemFilterSelectedObjects.Text = "Фильтр";
			this.toolMenuItemAddFilterSelectedObjects.Name = "toolMenuItemAddFilterSelectedObjects";
			this.toolMenuItemAddFilterSelectedObjects.Size = new Size(183, 22);
			this.toolMenuItemAddFilterSelectedObjects.Text = "Добавить в фильтр";
			this.toolMenuItemAddFilterSelectedObjects.Click += this.toolMenuItemAddFilterSelectedObjects_Click;
			this.toolMenuItemDeleteFilterSelectedObjects.Name = "toolMenuItemDeleteFilterSelectedObjects";
			this.toolMenuItemDeleteFilterSelectedObjects.Size = new Size(183, 22);
			this.toolMenuItemDeleteFilterSelectedObjects.Text = "Удалить из фильтра";
			this.toolMenuItemDeleteFilterSelectedObjects.Click += this.toolMenuItemDeleteFilterSelectedObjects_Click;
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new Size(198, 6);
			this.toolStripMenuItemBookmark.Name = "toolStripMenuItemBookmark";
			this.toolStripMenuItemBookmark.Size = new Size(201, 22);
			this.toolStripMenuItemBookmark.Text = "Поставить метку";
			this.toolStripMenuItemBookmark.Click += this.toolStripMenuItemBookmark_Click;
			this.toolStripMenuItemRemoveBookmark.Name = "toolStripMenuItemRemoveBookmark";
			this.toolStripMenuItemRemoveBookmark.Size = new Size(201, 22);
			this.toolStripMenuItemRemoveBookmark.Text = "Снять метку";
			this.toolStripMenuItemRemoveBookmark.Click += this.toolStripMenuItemRemoveBookmark_Click;
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new Size(198, 6);
			this.toolMenuItemSelectedPowerBullshit.Name = "toolMenuItemSelectedPowerBullshit";
			this.toolMenuItemSelectedPowerBullshit.Size = new Size(201, 22);
			this.toolMenuItemSelectedPowerBullshit.Text = "Варианты питания";
			this.toolMenuItemSelectedPowerBullshit.Visible = false;
			this.toolMenuItemSelectedPowerBullshit.Click += this.aqXtzFkSaU;
			this.toolMenuItemSelectedAlign.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemSelectedAlignByTop,
				this.toolMenuItemSelectedAlignByBottom,
				this.toolMenuItemSelectedAlignByRigth,
				this.toolMenuItemSelectedAlignByLeft,
				this.toolMenuItemSelectedAlignByHorCenter,
				this.toolMenuItemSelectedAlignByVertCenter
			});
			this.toolMenuItemSelectedAlign.Name = "toolMenuItemSelectedAlign";
			this.toolMenuItemSelectedAlign.Size = new Size(201, 22);
			this.toolMenuItemSelectedAlign.Text = "Выравнить";
			this.toolMenuItemSelectedAlignByTop.Name = "toolMenuItemSelectedAlignByTop";
			this.toolMenuItemSelectedAlignByTop.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByTop.Tag = "T";
			this.toolMenuItemSelectedAlignByTop.Text = "По верхней точке";
			this.toolMenuItemSelectedAlignByTop.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolMenuItemSelectedAlignByBottom.Name = "toolMenuItemSelectedAlignByBottom";
			this.toolMenuItemSelectedAlignByBottom.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByBottom.Tag = "B";
			this.toolMenuItemSelectedAlignByBottom.Text = "По нижней точке";
			this.toolMenuItemSelectedAlignByBottom.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolMenuItemSelectedAlignByRigth.Name = "toolMenuItemSelectedAlignByRigth";
			this.toolMenuItemSelectedAlignByRigth.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByRigth.Tag = "R";
			this.toolMenuItemSelectedAlignByRigth.Text = "По правой точке";
			this.toolMenuItemSelectedAlignByRigth.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolMenuItemSelectedAlignByLeft.Name = "toolMenuItemSelectedAlignByLeft";
			this.toolMenuItemSelectedAlignByLeft.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByLeft.Tag = "L";
			this.toolMenuItemSelectedAlignByLeft.Text = "По левой точке";
			this.toolMenuItemSelectedAlignByLeft.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolMenuItemSelectedAlignByHorCenter.Name = "toolMenuItemSelectedAlignByHorCenter";
			this.toolMenuItemSelectedAlignByHorCenter.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByHorCenter.Tag = "H";
			this.toolMenuItemSelectedAlignByHorCenter.Text = "По горизонтали";
			this.toolMenuItemSelectedAlignByHorCenter.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolMenuItemSelectedAlignByVertCenter.Name = "toolMenuItemSelectedAlignByVertCenter";
			this.toolMenuItemSelectedAlignByVertCenter.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByVertCenter.Tag = "V";
			this.toolMenuItemSelectedAlignByVertCenter.Text = "По вертикали";
			this.toolMenuItemSelectedAlignByVertCenter.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolStripSeparator13.Name = "toolStripSeparator13";
			this.toolStripSeparator13.Size = new Size(198, 6);
			this.toolStripSeparator13.Visible = false;
			this.toolStripMenuItemGroupSelectedObject.Name = "toolStripMenuItemGroupSelectedObject";
			this.toolStripMenuItemGroupSelectedObject.Size = new Size(201, 22);
			this.toolStripMenuItemGroupSelectedObject.Text = "Сгруппировать";
			this.toolStripMenuItemGroupSelectedObject.Click += this.toolStripMenuItemGroupSelectedObject_Click;
			this.toolStripMenuItemGroupProperty.Name = "toolStripMenuItemGroupProperty";
			this.toolStripMenuItemGroupProperty.Size = new Size(201, 22);
			this.toolStripMenuItemGroupProperty.Text = "Свойства группы";
			this.toolStripMenuItemGroupProperty.Click += this.toolStripMenuItemGroupProperty_Click;
			this.toolStripSeparatorGroup.Name = "toolStripSeparatorGroup";
			this.toolStripSeparatorGroup.Size = new Size(198, 6);
			this.toolMenuItemCenterSElectedObjects.Name = "toolMenuItemCenterSElectedObjects";
			this.toolMenuItemCenterSElectedObjects.Size = new Size(201, 22);
			this.toolMenuItemCenterSElectedObjects.Text = "Подогнать под размер";
			this.toolMenuItemCenterSElectedObjects.Click += this.toolMenuItemCenterSElectedObjects_Click;
			this.toolMenuItemCopySelectedObjects.Name = "toolMenuItemCopySelectedObjects";
			this.toolMenuItemCopySelectedObjects.Size = new Size(201, 22);
			this.toolMenuItemCopySelectedObjects.Text = "Копировать";
			this.toolMenuItemCopySelectedObjects.Click += this.reArSpApSW_Click;
			this.toolMenuItemCopySelectedObjectsToImage.Name = "toolMenuItemCopySelectedObjectsToImage";
			this.toolMenuItemCopySelectedObjectsToImage.Size = new Size(201, 22);
			this.toolMenuItemCopySelectedObjectsToImage.Text = "Копировать в картинку";
			this.toolMenuItemCopySelectedObjectsToImage.Click += this.toolMenuItemCopySelectedObjectsToImage_Click;
			this.toolMenuItemExportSelectedObjectsToDXF.Name = "toolMenuItemExportSelectedObjectsToDXF";
			this.toolMenuItemExportSelectedObjectsToDXF.Size = new Size(201, 22);
			this.toolMenuItemExportSelectedObjectsToDXF.Text = "Экспорт в AutoCAD";
			this.toolMenuItemExportSelectedObjectsToDXF.Click += this.toolMenuItemExportSelectedObjectsToDXF_Click;
			this.toolMenuItemPasteSelectedObjects.Name = "toolMenuItemPasteSelectedObjects";
			this.toolMenuItemPasteSelectedObjects.Size = new Size(201, 22);
			this.toolMenuItemPasteSelectedObjects.Text = "Вставить";
			this.toolMenuItemPasteSelectedObjects.Click += this.uBbItwaYjM_Click;
			this.toolMenuItemDeleteSelectedObjects.Name = "toolMenuItemDeleteSelectedObjects";
			this.toolMenuItemDeleteSelectedObjects.Size = new Size(201, 22);
			this.toolMenuItemDeleteSelectedObjects.Text = "Удалить";
			this.toolMenuItemDeleteSelectedObjects.Click += this.toolMenuItemDeleteSelectedObjects_Click;
			this.contextMenuRectnagle.ImageScalingSize = new Size(20, 20);
			this.contextMenuRectnagle.Items.AddRange(new ToolStripItem[]
			{
				this.twFspjsly3,
				this.toolMenuItemRectRecipientsPower,
				this.toolStripSeparator10,
				this.toolMenuItemRectFilter,
				this.toolStripSeparator1,
				this.toolMenuItemRectCopy,
				this.toolMenuItemRectPaste,
				this.toolMenuItemRectDel,
				this.toolStripMenuItemRectanglePosition,
				this.toolMenuItemRectAlign,
				this.toolStripMenuItemAdjacentSubstation,
				this.toolStripSeparator2,
				this.toolMenuItemRectFile,
				this.toolMenuItemRectProperty
			});
			this.contextMenuRectnagle.Name = "contextMenuRectnagle";
			this.contextMenuRectnagle.Size = new Size(198, 264);
			this.contextMenuRectnagle.Opening += this.contextMenuRectnagle_Opening;
			this.twFspjsly3.Name = "toolMenuItemRectPowerSource";
			this.twFspjsly3.Size = new Size(197, 22);
			this.twFspjsly3.Text = "Просчитать запитку";
			this.twFspjsly3.Click += this.toolStripMenuItem8_Click;
			this.toolMenuItemRectRecipientsPower.Name = "toolMenuItemRectRecipientsPower";
			this.toolMenuItemRectRecipientsPower.Size = new Size(197, 22);
			this.toolMenuItemRectRecipientsPower.Text = "Просчитать схему";
			this.toolMenuItemRectRecipientsPower.Click += this.toolStripMenuItem9_Click;
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new Size(194, 6);
			this.toolMenuItemRectFilter.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemRectFilterAdd,
				this.toolMenuItemRectFilterDel
			});
			this.toolMenuItemRectFilter.Name = "toolMenuItemRectFilter";
			this.toolMenuItemRectFilter.Size = new Size(197, 22);
			this.toolMenuItemRectFilter.Text = "Фильтр";
			this.toolMenuItemRectFilterAdd.Name = "toolMenuItemRectFilterAdd";
			this.toolMenuItemRectFilterAdd.Size = new Size(183, 22);
			this.toolMenuItemRectFilterAdd.Text = "Добавить в фильтр";
			this.toolMenuItemRectFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
			this.toolMenuItemRectFilterDel.Name = "toolMenuItemRectFilterDel";
			this.toolMenuItemRectFilterDel.Size = new Size(183, 22);
			this.toolMenuItemRectFilterDel.Text = "Удалить из фильтра";
			this.toolMenuItemRectFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(194, 6);
			this.toolMenuItemRectCopy.Name = "toolMenuItemRectCopy";
			this.toolMenuItemRectCopy.Size = new Size(197, 22);
			this.toolMenuItemRectCopy.Text = "Копировать";
			this.toolMenuItemRectCopy.Click += this.reArSpApSW_Click;
			this.toolMenuItemRectPaste.Name = "toolMenuItemRectPaste";
			this.toolMenuItemRectPaste.Size = new Size(197, 22);
			this.toolMenuItemRectPaste.Text = "Вставить";
			this.toolMenuItemRectPaste.Click += this.uBbItwaYjM_Click;
			this.toolMenuItemRectDel.Name = "toolMenuItemRectDel";
			this.toolMenuItemRectDel.Size = new Size(197, 22);
			this.toolMenuItemRectDel.Text = "Удалить";
			this.toolMenuItemRectDel.Click += this.toolMenuItemTextBranchDel_Click;
			this.toolStripMenuItemRectanglePosition.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemReflect,
				this.toolStripMenuItemRotateRectangle
			});
			this.toolStripMenuItemRectanglePosition.Name = "toolStripMenuItemRectanglePosition";
			this.toolStripMenuItemRectanglePosition.Size = new Size(197, 22);
			this.toolStripMenuItemRectanglePosition.Text = "Положение";
			this.toolStripMenuItemReflect.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemVReflect,
				this.toolStripMenuItemHReflect
			});
			this.toolStripMenuItemReflect.Name = "toolStripMenuItemReflect";
			this.toolStripMenuItemReflect.Size = new Size(133, 22);
			this.toolStripMenuItemReflect.Text = "Отразить";
			this.toolStripMenuItemVReflect.Name = "toolStripMenuItemVReflect";
			this.toolStripMenuItemVReflect.Size = new Size(163, 22);
			this.toolStripMenuItemVReflect.Tag = "V";
			this.toolStripMenuItemVReflect.Text = "По вертикали";
			this.toolStripMenuItemVReflect.Click += this.toolStripMenuItemHReflect_Click;
			this.toolStripMenuItemHReflect.Name = "toolStripMenuItemHReflect";
			this.toolStripMenuItemHReflect.Size = new Size(163, 22);
			this.toolStripMenuItemHReflect.Tag = "H";
			this.toolStripMenuItemHReflect.Text = "По горизонтали";
			this.toolStripMenuItemHReflect.Click += this.toolStripMenuItemHReflect_Click;
			this.toolStripMenuItemRotateRectangle.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemRotate90,
				this.toolStripMenuItemRotate180,
				this.toolStripMenuItemRotate170
			});
			this.toolStripMenuItemRotateRectangle.Name = "toolStripMenuItemRotateRectangle";
			this.toolStripMenuItemRotateRectangle.Size = new Size(133, 22);
			this.toolStripMenuItemRotateRectangle.Text = "Повернуть";
			this.toolStripMenuItemRotate90.Name = "toolStripMenuItemRotate90";
			this.toolStripMenuItemRotate90.Size = new Size(144, 22);
			this.toolStripMenuItemRotate90.Text = "90 градусов";
			this.toolStripMenuItemRotate180.Name = "toolStripMenuItemRotate180";
			this.toolStripMenuItemRotate180.Size = new Size(144, 22);
			this.toolStripMenuItemRotate180.Text = "180 градусов";
			this.toolStripMenuItemRotate170.Name = "toolStripMenuItemRotate170";
			this.toolStripMenuItemRotate170.Size = new Size(144, 22);
			this.toolStripMenuItemRotate170.Text = "270 градусов";
			this.toolMenuItemRectAlign.Name = "toolMenuItemRectAlign";
			this.toolMenuItemRectAlign.Size = new Size(197, 22);
			this.toolMenuItemRectAlign.Text = "Выровнить объекты";
			this.toolMenuItemRectAlign.Click += this.toolMenuItemRectAlign_Click;
			this.toolStripMenuItemAdjacentSubstation.Name = "toolStripMenuItemAdjacentSubstation";
			this.toolStripMenuItemAdjacentSubstation.Size = new Size(197, 22);
			this.toolStripMenuItemAdjacentSubstation.Text = "Смежные подстанции";
			this.toolStripMenuItemAdjacentSubstation.Click += this.toolStripMenuItemAdjacentSubstation2_Click;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(194, 6);
			this.toolMenuItemRectFile.Name = "toolMenuItemRectFile";
			this.toolMenuItemRectFile.Size = new Size(197, 22);
			this.toolMenuItemRectFile.Text = "Файлы";
			this.toolMenuItemRectFile.Click += this.toolMenuItemLineFile_Click;
			this.toolMenuItemRectProperty.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
			this.toolMenuItemRectProperty.Name = "toolMenuItemRectProperty";
			this.toolMenuItemRectProperty.Size = new Size(197, 22);
			this.toolMenuItemRectProperty.Text = "Свойства объекта";
			this.toolMenuItemRectProperty.Click += this.WcgruJuvXg_Click;
			this.contextMenuShina.ImageScalingSize = new Size(20, 20);
			this.contextMenuShina.Items.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddChild,
				this.toolMenuItemShinaCopy,
				this.toolMenuItemShinaPaste,
				this.toolMenuItemShinaDel,
				this.toolStripSeparatorEditShina,
				this.toolStripMenuItemBusMeasurement,
				this.toolMenuItemShinaPowerSource,
				this.toolMenuItemShinaRecipientsPower,
				this.toolStripMenuItem11,
				this.toolStripMenuItemAllPower,
				this.toolStripMenuItemAdjacentSubstation2,
				this.toolStripMenuItemShinaGetOldAbn,
				this.toolStripSeparator3,
				this.toolMenuItemShinaFilter,
				this.toolStripSeparator11,
				this.toolMenuItemShinaFile,
				this.toolMenuItemShinaProperty
			});
			this.contextMenuShina.Name = "contextMenuShina";
			this.contextMenuShina.Size = new Size(277, 330);
			this.contextMenuShina.Opening += this.contextMenuShina_Opening;
			this.toolMenuItemShinaAddChild.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddCell,
				this.toolMenuItemShinaBridge,
				this.toolMenuItemShinaSplitter,
				this.toolStripMenuItemAddWhitePoint,
				this.toolMeniItemShinaAddPattern,
				this.toolStripSeparator7,
				this.waWrHaQms2,
				this.ldtrvofZuY
			});
			this.toolMenuItemShinaAddChild.Name = "toolMenuItemShinaAddChild";
			this.toolMenuItemShinaAddChild.Size = new Size(276, 22);
			this.toolMenuItemShinaAddChild.Text = "Добавить";
			this.toolMenuItemShinaAddCell.Name = "toolMenuItemShinaAddCell";
			this.toolMenuItemShinaAddCell.Size = new Size(232, 22);
			this.toolMenuItemShinaAddCell.Text = "Ячейку";
			this.toolMenuItemShinaAddCell.Click += this.toolMenuItemShinaAddCell_Click;
			this.toolMenuItemShinaBridge.Name = "toolMenuItemShinaBridge";
			this.toolMenuItemShinaBridge.Size = new Size(232, 22);
			this.toolMenuItemShinaBridge.Text = "Межшинный мост";
			this.toolMenuItemShinaBridge.Visible = false;
			this.toolMenuItemShinaBridge.Click += this.toolMenuItemShinaBridge_Click;
			this.toolMenuItemShinaSplitter.Name = "toolMenuItemShinaSplitter";
			this.toolMenuItemShinaSplitter.Size = new Size(232, 22);
			this.toolMenuItemShinaSplitter.Text = "Разветвитель";
			this.toolMenuItemShinaSplitter.Visible = false;
			this.toolMenuItemShinaSplitter.Click += this.toolMenuItemShinaSplitter_Click;
			this.toolStripMenuItemAddWhitePoint.Name = "toolStripMenuItemAddWhitePoint";
			this.toolStripMenuItemAddWhitePoint.Size = new Size(232, 22);
			this.toolStripMenuItemAddWhitePoint.Text = "ВН на трансформаторе";
			this.toolStripMenuItemAddWhitePoint.Click += this.toolStripMenuItemAddWhitePoint_Click;
			this.toolMeniItemShinaAddPattern.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddPatternAbn,
				this.toolMenuItemShinaAddPatternAbnAuto,
				this.toolMenuItemShinaAddPatternAbnReserve,
				this.toolMenuItemShinaAddPatternAbnRPS
			});
			this.toolMeniItemShinaAddPattern.Name = "toolMeniItemShinaAddPattern";
			this.toolMeniItemShinaAddPattern.Size = new Size(232, 22);
			this.toolMeniItemShinaAddPattern.Text = "Шаблон";
			this.toolMenuItemShinaAddPatternAbn.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.oGyhJxxeRR,
				this.toolMenuItemShinaAddPatternAbn2,
				this.toolMenuItemShinaAddPatternAbn3,
				this.toolMenuItemShinaAddPatternAbn4,
				this.toolMenuItemShinaAddPatternAbn5,
				this.toolMenuItemShinaAddPatternAbn6,
				this.toolMenuItemShinaAddPatternAbn7,
				this.toolMenuItemShinaAddPatternAbn8,
				this.toolMenuItemShinaAddPatternAbn9,
				this.toolMenuItemShinaAddPatternAbn10
			});
			this.toolMenuItemShinaAddPatternAbn.Name = "toolMenuItemShinaAddPatternAbn";
			this.toolMenuItemShinaAddPatternAbn.Size = new Size(271, 22);
			this.toolMenuItemShinaAddPatternAbn.Text = "Выходная на потребителя(ЛР)";
			this.toolMenuItemShinaAddPatternAbn.Click += this.toolMenuItemShinaAddPatternAbn_Click;
			this.oGyhJxxeRR.Name = "toolMenuItemShinaAddPatternAbn1";
			this.oGyhJxxeRR.Size = new Size(86, 22);
			this.oGyhJxxeRR.Tag = "1";
			this.oGyhJxxeRR.Text = "1";
			this.oGyhJxxeRR.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn2.Name = "toolMenuItemShinaAddPatternAbn2";
			this.toolMenuItemShinaAddPatternAbn2.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn2.Tag = "2";
			this.toolMenuItemShinaAddPatternAbn2.Text = "2";
			this.toolMenuItemShinaAddPatternAbn2.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn3.Name = "toolMenuItemShinaAddPatternAbn3";
			this.toolMenuItemShinaAddPatternAbn3.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn3.Tag = "3";
			this.toolMenuItemShinaAddPatternAbn3.Text = "3";
			this.toolMenuItemShinaAddPatternAbn3.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn4.Name = "toolMenuItemShinaAddPatternAbn4";
			this.toolMenuItemShinaAddPatternAbn4.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn4.Tag = "4";
			this.toolMenuItemShinaAddPatternAbn4.Text = "4";
			this.toolMenuItemShinaAddPatternAbn4.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn5.Name = "toolMenuItemShinaAddPatternAbn5";
			this.toolMenuItemShinaAddPatternAbn5.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn5.Tag = "5";
			this.toolMenuItemShinaAddPatternAbn5.Text = "5";
			this.toolMenuItemShinaAddPatternAbn5.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn6.Name = "toolMenuItemShinaAddPatternAbn6";
			this.toolMenuItemShinaAddPatternAbn6.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn6.Tag = "6";
			this.toolMenuItemShinaAddPatternAbn6.Text = "6";
			this.toolMenuItemShinaAddPatternAbn6.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn7.Name = "toolMenuItemShinaAddPatternAbn7";
			this.toolMenuItemShinaAddPatternAbn7.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn7.Tag = "7";
			this.toolMenuItemShinaAddPatternAbn7.Text = "7";
			this.toolMenuItemShinaAddPatternAbn7.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn8.Name = "toolMenuItemShinaAddPatternAbn8";
			this.toolMenuItemShinaAddPatternAbn8.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn8.Tag = "8";
			this.toolMenuItemShinaAddPatternAbn8.Text = "8";
			this.toolMenuItemShinaAddPatternAbn8.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn9.Name = "toolMenuItemShinaAddPatternAbn9";
			this.toolMenuItemShinaAddPatternAbn9.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn9.Tag = "9";
			this.toolMenuItemShinaAddPatternAbn9.Text = "9";
			this.toolMenuItemShinaAddPatternAbn9.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn10.Name = "toolMenuItemShinaAddPatternAbn10";
			this.toolMenuItemShinaAddPatternAbn10.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn10.Tag = "10";
			this.toolMenuItemShinaAddPatternAbn10.Text = "10";
			this.toolMenuItemShinaAddPatternAbn10.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddPatternAbnAuto1,
				this.toolMenuItemShinaAddPatternAbnAuto2,
				this.toolMenuItemShinaAddPatternAbnAuto3,
				this.toolMenuItemShinaAddPatternAbnAuto4,
				this.toolMenuItemShinaAddPatternAbnAuto5,
				this.toolMenuItemShinaAddPatternAbnAuto6,
				this.toolMenuItemShinaAddPatternAbnAuto7,
				this.toolMenuItemShinaAddPatternAbnAuto8,
				this.toolMenuItemShinaAddPatternAbnAuto9,
				this.toolMenuItemShinaAddPatternAbnAuto10
			});
			this.toolMenuItemShinaAddPatternAbnAuto.Name = "toolMenuItemShinaAddPatternAbnAuto";
			this.toolMenuItemShinaAddPatternAbnAuto.Size = new Size(271, 22);
			this.toolMenuItemShinaAddPatternAbnAuto.Text = "Выходная на потребителя (автомат)";
			this.toolMenuItemShinaAddPatternAbnAuto1.Name = "toolMenuItemShinaAddPatternAbnAuto1";
			this.toolMenuItemShinaAddPatternAbnAuto1.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto1.Tag = "1";
			this.toolMenuItemShinaAddPatternAbnAuto1.Text = "1";
			this.toolMenuItemShinaAddPatternAbnAuto1.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto2.Name = "toolMenuItemShinaAddPatternAbnAuto2";
			this.toolMenuItemShinaAddPatternAbnAuto2.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto2.Tag = "2";
			this.toolMenuItemShinaAddPatternAbnAuto2.Text = "2";
			this.toolMenuItemShinaAddPatternAbnAuto2.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto3.Name = "toolMenuItemShinaAddPatternAbnAuto3";
			this.toolMenuItemShinaAddPatternAbnAuto3.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto3.Tag = "3";
			this.toolMenuItemShinaAddPatternAbnAuto3.Text = "3";
			this.toolMenuItemShinaAddPatternAbnAuto3.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto4.Name = "toolMenuItemShinaAddPatternAbnAuto4";
			this.toolMenuItemShinaAddPatternAbnAuto4.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto4.Tag = "4";
			this.toolMenuItemShinaAddPatternAbnAuto4.Text = "4";
			this.toolMenuItemShinaAddPatternAbnAuto4.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto5.Name = "toolMenuItemShinaAddPatternAbnAuto5";
			this.toolMenuItemShinaAddPatternAbnAuto5.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto5.Tag = "5";
			this.toolMenuItemShinaAddPatternAbnAuto5.Text = "5";
			this.toolMenuItemShinaAddPatternAbnAuto5.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto6.Name = "toolMenuItemShinaAddPatternAbnAuto6";
			this.toolMenuItemShinaAddPatternAbnAuto6.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto6.Tag = "6";
			this.toolMenuItemShinaAddPatternAbnAuto6.Text = "6";
			this.toolMenuItemShinaAddPatternAbnAuto6.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto7.Name = "toolMenuItemShinaAddPatternAbnAuto7";
			this.toolMenuItemShinaAddPatternAbnAuto7.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto7.Tag = "7";
			this.toolMenuItemShinaAddPatternAbnAuto7.Text = "7";
			this.toolMenuItemShinaAddPatternAbnAuto7.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto8.Name = "toolMenuItemShinaAddPatternAbnAuto8";
			this.toolMenuItemShinaAddPatternAbnAuto8.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto8.Tag = "8";
			this.toolMenuItemShinaAddPatternAbnAuto8.Text = "8";
			this.toolMenuItemShinaAddPatternAbnAuto8.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto9.Name = "toolMenuItemShinaAddPatternAbnAuto9";
			this.toolMenuItemShinaAddPatternAbnAuto9.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto9.Tag = "9";
			this.toolMenuItemShinaAddPatternAbnAuto9.Text = "9";
			this.toolMenuItemShinaAddPatternAbnAuto9.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto10.Name = "toolMenuItemShinaAddPatternAbnAuto10";
			this.toolMenuItemShinaAddPatternAbnAuto10.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto10.Tag = "10";
			this.toolMenuItemShinaAddPatternAbnAuto10.Text = "10";
			this.toolMenuItemShinaAddPatternAbnAuto10.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddPatternAbnReserve1,
				this.toolMenuItemShinaAddPatternAbnReserve2,
				this.toolMenuItemShinaAddPatternAbnReserve3,
				this.toolMenuItemShinaAddPatternAbnReserve4,
				this.toolMenuItemShinaAddPatternAbnReserve5,
				this.toolMenuItemShinaAddPatternAbnReserve6,
				this.toolMenuItemShinaAddPatternAbnReserve7,
				this.toolMenuItemShinaAddPatternAbnReserve8,
				this.toolMenuItemShinaAddPatternAbnReserve9,
				this.toolMenuItemShinaAddPatternAbnReserve10
			});
			this.toolMenuItemShinaAddPatternAbnReserve.Name = "toolMenuItemShinaAddPatternAbnReserve";
			this.toolMenuItemShinaAddPatternAbnReserve.Size = new Size(271, 22);
			this.toolMenuItemShinaAddPatternAbnReserve.Text = "Выходная на потребителя (резерв)";
			this.toolMenuItemShinaAddPatternAbnReserve.Click += this.toolMenuItemShinaAddPatternAbnReserve_Click;
			this.toolMenuItemShinaAddPatternAbnReserve1.Name = "toolMenuItemShinaAddPatternAbnReserve1";
			this.toolMenuItemShinaAddPatternAbnReserve1.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve1.Tag = "1";
			this.toolMenuItemShinaAddPatternAbnReserve1.Text = "1";
			this.toolMenuItemShinaAddPatternAbnReserve1.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve2.Name = "toolMenuItemShinaAddPatternAbnReserve2";
			this.toolMenuItemShinaAddPatternAbnReserve2.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve2.Tag = "2";
			this.toolMenuItemShinaAddPatternAbnReserve2.Text = "2";
			this.toolMenuItemShinaAddPatternAbnReserve2.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve3.Name = "toolMenuItemShinaAddPatternAbnReserve3";
			this.toolMenuItemShinaAddPatternAbnReserve3.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve3.Tag = "3";
			this.toolMenuItemShinaAddPatternAbnReserve3.Text = "3";
			this.toolMenuItemShinaAddPatternAbnReserve3.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve4.Name = "toolMenuItemShinaAddPatternAbnReserve4";
			this.toolMenuItemShinaAddPatternAbnReserve4.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve4.Tag = "4";
			this.toolMenuItemShinaAddPatternAbnReserve4.Text = "4";
			this.toolMenuItemShinaAddPatternAbnReserve4.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve5.Name = "toolMenuItemShinaAddPatternAbnReserve5";
			this.toolMenuItemShinaAddPatternAbnReserve5.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve5.Tag = "5";
			this.toolMenuItemShinaAddPatternAbnReserve5.Text = "5";
			this.toolMenuItemShinaAddPatternAbnReserve5.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve6.Name = "toolMenuItemShinaAddPatternAbnReserve6";
			this.toolMenuItemShinaAddPatternAbnReserve6.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve6.Tag = "6";
			this.toolMenuItemShinaAddPatternAbnReserve6.Text = "6";
			this.toolMenuItemShinaAddPatternAbnReserve6.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve7.Name = "toolMenuItemShinaAddPatternAbnReserve7";
			this.toolMenuItemShinaAddPatternAbnReserve7.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve7.Tag = "7";
			this.toolMenuItemShinaAddPatternAbnReserve7.Text = "7";
			this.toolMenuItemShinaAddPatternAbnReserve7.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve8.Name = "toolMenuItemShinaAddPatternAbnReserve8";
			this.toolMenuItemShinaAddPatternAbnReserve8.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve8.Tag = "8";
			this.toolMenuItemShinaAddPatternAbnReserve8.Text = "8";
			this.toolMenuItemShinaAddPatternAbnReserve8.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve9.Name = "toolMenuItemShinaAddPatternAbnReserve9";
			this.toolMenuItemShinaAddPatternAbnReserve9.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve9.Tag = "9";
			this.toolMenuItemShinaAddPatternAbnReserve9.Text = "9";
			this.toolMenuItemShinaAddPatternAbnReserve9.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve10.Name = "toolMenuItemShinaAddPatternAbnReserve10";
			this.toolMenuItemShinaAddPatternAbnReserve10.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve10.Tag = "10";
			this.toolMenuItemShinaAddPatternAbnReserve10.Text = "10";
			this.toolMenuItemShinaAddPatternAbnReserve10.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddPatternAbnRPS1,
				this.toolMenuItemShinaAddPatternAbnRPS2,
				this.toolMenuItemShinaAddPatternAbnRPS3,
				this.toolMenuItemShinaAddPatternAbnRPS4,
				this.toolMenuItemShinaAddPatternAbnRPS5,
				this.toolMenuItemShinaAddPatternAbnRPS6,
				this.toolMenuItemShinaAddPatternAbnRPS7,
				this.toolMenuItemShinaAddPatternAbnRPS8,
				this.EhkrgnfgYC,
				this.toolMenuItemShinaAddPatternAbnRPS10
			});
			this.toolMenuItemShinaAddPatternAbnRPS.Name = "toolMenuItemShinaAddPatternAbnRPS";
			this.toolMenuItemShinaAddPatternAbnRPS.Size = new Size(271, 22);
			this.toolMenuItemShinaAddPatternAbnRPS.Text = "Выходная на потребителя (РПС)";
			this.toolMenuItemShinaAddPatternAbnRPS.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS1.Name = "toolMenuItemShinaAddPatternAbnRPS1";
			this.toolMenuItemShinaAddPatternAbnRPS1.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS1.Tag = "1";
			this.toolMenuItemShinaAddPatternAbnRPS1.Text = "1";
			this.toolMenuItemShinaAddPatternAbnRPS1.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS2.Name = "toolMenuItemShinaAddPatternAbnRPS2";
			this.toolMenuItemShinaAddPatternAbnRPS2.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS2.Tag = "2";
			this.toolMenuItemShinaAddPatternAbnRPS2.Text = "2";
			this.toolMenuItemShinaAddPatternAbnRPS2.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS3.Name = "toolMenuItemShinaAddPatternAbnRPS3";
			this.toolMenuItemShinaAddPatternAbnRPS3.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS3.Tag = "3";
			this.toolMenuItemShinaAddPatternAbnRPS3.Text = "3";
			this.toolMenuItemShinaAddPatternAbnRPS3.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS4.Name = "toolMenuItemShinaAddPatternAbnRPS4";
			this.toolMenuItemShinaAddPatternAbnRPS4.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS4.Tag = "4";
			this.toolMenuItemShinaAddPatternAbnRPS4.Text = "4";
			this.toolMenuItemShinaAddPatternAbnRPS4.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS5.Name = "toolMenuItemShinaAddPatternAbnRPS5";
			this.toolMenuItemShinaAddPatternAbnRPS5.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS5.Tag = "5";
			this.toolMenuItemShinaAddPatternAbnRPS5.Text = "5";
			this.toolMenuItemShinaAddPatternAbnRPS5.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS6.Name = "toolMenuItemShinaAddPatternAbnRPS6";
			this.toolMenuItemShinaAddPatternAbnRPS6.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS6.Tag = "6";
			this.toolMenuItemShinaAddPatternAbnRPS6.Text = "6";
			this.toolMenuItemShinaAddPatternAbnRPS6.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS7.Name = "toolMenuItemShinaAddPatternAbnRPS7";
			this.toolMenuItemShinaAddPatternAbnRPS7.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS7.Tag = "7";
			this.toolMenuItemShinaAddPatternAbnRPS7.Text = "7";
			this.toolMenuItemShinaAddPatternAbnRPS7.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS8.Name = "toolMenuItemShinaAddPatternAbnRPS8";
			this.toolMenuItemShinaAddPatternAbnRPS8.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS8.Tag = "8";
			this.toolMenuItemShinaAddPatternAbnRPS8.Text = "8";
			this.toolMenuItemShinaAddPatternAbnRPS8.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.EhkrgnfgYC.Name = "toolMenuItemShinaAddPatternAbnRPS9";
			this.EhkrgnfgYC.Size = new Size(86, 22);
			this.EhkrgnfgYC.Tag = "9";
			this.EhkrgnfgYC.Text = "9";
			this.EhkrgnfgYC.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS10.Name = "toolMenuItemShinaAddPatternAbnRPS10";
			this.toolMenuItemShinaAddPatternAbnRPS10.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS10.Tag = "10";
			this.toolMenuItemShinaAddPatternAbnRPS10.Text = "10";
			this.toolMenuItemShinaAddPatternAbnRPS10.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new Size(229, 6);
			this.waWrHaQms2.Name = "toolStripMenuItemMeasurement";
			this.waWrHaQms2.Size = new Size(232, 22);
			this.waWrHaQms2.Text = "Вывести данные о замерах";
			this.waWrHaQms2.Click += this.waWrHaQms2_Click;
			this.ldtrvofZuY.Name = "toolStripMenuItemShinaAddTelemetryLabel";
			this.ldtrvofZuY.Size = new Size(232, 22);
			this.ldtrvofZuY.Text = "Вывести данные телеметрии";
			this.ldtrvofZuY.Click += this.QyjrxReCs8_Click;
			this.toolMenuItemShinaCopy.Name = "toolMenuItemShinaCopy";
			this.toolMenuItemShinaCopy.Size = new Size(276, 22);
			this.toolMenuItemShinaCopy.Text = "Копировать";
			this.toolMenuItemShinaCopy.Click += this.reArSpApSW_Click;
			this.toolMenuItemShinaPaste.Name = "toolMenuItemShinaPaste";
			this.toolMenuItemShinaPaste.Size = new Size(276, 22);
			this.toolMenuItemShinaPaste.Text = "Вставить";
			this.toolMenuItemShinaPaste.Click += this.uBbItwaYjM_Click;
			this.toolMenuItemShinaDel.Name = "toolMenuItemShinaDel";
			this.toolMenuItemShinaDel.Size = new Size(276, 22);
			this.toolMenuItemShinaDel.Text = "Удалить";
			this.toolMenuItemShinaDel.Click += this.toolMenuItemTextBranchDel_Click;
			this.toolStripSeparatorEditShina.Name = "toolStripSeparatorEditShina";
			this.toolStripSeparatorEditShina.Size = new Size(273, 6);
			this.toolStripMenuItemBusMeasurement.Name = "toolStripMenuItemBusMeasurement";
			this.toolStripMenuItemBusMeasurement.Size = new Size(276, 22);
			this.toolStripMenuItemBusMeasurement.Text = "Замеры";
			this.toolStripMenuItemBusMeasurement.Click += this.toolStripMenuItemBusMeasurement_Click;
			this.toolMenuItemShinaPowerSource.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem2,
				this.toolStripMenuItem5
			});
			this.toolMenuItemShinaPowerSource.Name = "toolMenuItemShinaPowerSource";
			this.toolMenuItemShinaPowerSource.Size = new Size(276, 22);
			this.toolMenuItemShinaPowerSource.Text = "Просчитать запитку";
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new Size(186, 22);
			this.toolStripMenuItem2.Tag = "1";
			this.toolStripMenuItem2.Text = "Выделить";
			this.toolStripMenuItem2.Click += this.toolStripMenuItem8_Click;
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new Size(186, 22);
			this.toolStripMenuItem5.Tag = "2";
			this.toolStripMenuItem5.Text = "Выделить миганием";
			this.toolStripMenuItem5.Click += this.toolStripMenuItem8_Click;
			this.toolMenuItemShinaRecipientsPower.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem3,
				this.toolStripMenuItem4
			});
			this.toolMenuItemShinaRecipientsPower.Name = "toolMenuItemShinaRecipientsPower";
			this.toolMenuItemShinaRecipientsPower.Size = new Size(276, 22);
			this.toolMenuItemShinaRecipientsPower.Text = "Просчитать схему";
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new Size(186, 22);
			this.toolStripMenuItem3.Tag = "1";
			this.toolStripMenuItem3.Text = "Выделить";
			this.toolStripMenuItem3.Click += this.toolStripMenuItem9_Click;
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new Size(186, 22);
			this.toolStripMenuItem4.Tag = "2";
			this.toolStripMenuItem4.Text = "Выделить миганием";
			this.toolStripMenuItem4.Click += this.toolStripMenuItem9_Click;
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new Size(276, 22);
			this.toolStripMenuItem11.Text = "Альтернативные источники питания";
			this.toolStripMenuItem11.Click += this.toolStripMenuItem11_Click;
			this.toolStripMenuItemAllPower.Name = "toolStripMenuItemAllPower";
			this.toolStripMenuItemAllPower.Size = new Size(276, 22);
			this.toolStripMenuItemAllPower.Text = "Все возможные источники питания";
			this.toolStripMenuItemAllPower.Visible = false;
			this.toolStripMenuItemAllPower.Click += this.toolStripMenuItem10_Click;
			this.toolStripMenuItemAdjacentSubstation2.Name = "toolStripMenuItemAdjacentSubstation2";
			this.toolStripMenuItemAdjacentSubstation2.Size = new Size(276, 22);
			this.toolStripMenuItemAdjacentSubstation2.Text = "Смежные подстанции";
			this.toolStripMenuItemAdjacentSubstation2.Click += this.toolStripMenuItemAdjacentSubstation2_Click;
			this.toolStripMenuItemShinaGetOldAbn.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemShinaOldAbnCurrentRect,
				this.toolStripMenuItemShinaOldAbnNextRect
			});
			this.toolStripMenuItemShinaGetOldAbn.Name = "toolStripMenuItemShinaGetOldAbn";
			this.toolStripMenuItemShinaGetOldAbn.Size = new Size(276, 22);
			this.toolStripMenuItemShinaGetOldAbn.Text = "Абоненты";
			this.toolStripMenuItemShinaOldAbnCurrentRect.Name = "toolStripMenuItemShinaOldAbnCurrentRect";
			this.toolStripMenuItemShinaOldAbnCurrentRect.Size = new Size(191, 22);
			this.toolStripMenuItemShinaOldAbnCurrentRect.Text = "Текущей подстанции";
			this.toolStripMenuItemShinaOldAbnCurrentRect.Click += this.toolStripMenuItem14_Click;
			this.toolStripMenuItemShinaOldAbnNextRect.Name = "toolStripMenuItemShinaOldAbnNextRect";
			this.toolStripMenuItemShinaOldAbnNextRect.Size = new Size(191, 22);
			this.toolStripMenuItemShinaOldAbnNextRect.Tag = "1";
			this.toolStripMenuItemShinaOldAbnNextRect.Text = "По цепочке";
			this.toolStripMenuItemShinaOldAbnNextRect.Click += this.toolStripMenuItem14_Click;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size(273, 6);
			this.toolMenuItemShinaFilter.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaFilterAdd,
				this.toolMenuItemShinaFilterDel
			});
			this.toolMenuItemShinaFilter.Name = "toolMenuItemShinaFilter";
			this.toolMenuItemShinaFilter.Size = new Size(276, 22);
			this.toolMenuItemShinaFilter.Text = "Фильтр";
			this.toolMenuItemShinaFilterAdd.Name = "toolMenuItemShinaFilterAdd";
			this.toolMenuItemShinaFilterAdd.Size = new Size(183, 22);
			this.toolMenuItemShinaFilterAdd.Text = "Добавить в фильтр";
			this.toolMenuItemShinaFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
			this.toolMenuItemShinaFilterDel.Name = "toolMenuItemShinaFilterDel";
			this.toolMenuItemShinaFilterDel.Size = new Size(183, 22);
			this.toolMenuItemShinaFilterDel.Text = "Удалить из фильтра";
			this.toolMenuItemShinaFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new Size(273, 6);
			this.toolMenuItemShinaFile.Name = "toolMenuItemShinaFile";
			this.toolMenuItemShinaFile.Size = new Size(276, 22);
			this.toolMenuItemShinaFile.Text = "Файлы";
			this.toolMenuItemShinaFile.Click += this.toolMenuItemLineFile_Click;
			this.toolMenuItemShinaProperty.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
			this.toolMenuItemShinaProperty.Name = "toolMenuItemShinaProperty";
			this.toolMenuItemShinaProperty.Size = new Size(276, 22);
			this.toolMenuItemShinaProperty.Text = "Свойства объекта";
			this.toolMenuItemShinaProperty.Click += this.WcgruJuvXg_Click;
			this.contextMenuSwitchTool.ImageScalingSize = new Size(20, 20);
			this.contextMenuSwitchTool.Items.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemSwitchPassport,
				this.toolMenuItemSwitchOn,
				this.toolStripMenuChangeArrowDirection,
				this.toolMenuItemSwitchFilter,
				this.toolStripMenuItemOOLDisplayGrLevel,
				this.toolStripMenuItemSwitchAddTelemetry,
				this.toolMenuItemSwitchErcloud,
				this.toolStripSeparator12,
				this.toolStripMenuItemCSRollingOut,
				this.toolStripMenuItemCSNormalMode,
				this.toolStripSeparatorCS,
				this.toolMenuItemStateDel,
				this.toolMenuItemSwitchCopy,
				this.toolMenuItemSwitchDel,
				this.toolStripSeparator5,
				this.ToolStripMenuItemSwitchMeasurement,
				this.toolMenuItemSwitchLogDispatcher,
				this.toolMenuItemSwitchFile,
				this.MSMZJEXRVG
			});
			this.contextMenuSwitchTool.Name = "contextMenuSwitchTool";
			this.contextMenuSwitchTool.Size = new Size(251, 374);
			this.contextMenuSwitchTool.Opening += this.contextMenuSwitchTool_Opening;
			this.toolMenuItemSwitchPassport.Name = "toolMenuItemSwitchPassport";
			this.toolMenuItemSwitchPassport.Size = new Size(250, 22);
			this.toolMenuItemSwitchPassport.Text = "Паспорт";
			this.toolMenuItemSwitchPassport.Click += this.toolMenuItemSwitchPassport_Click;
			this.toolMenuItemSwitchOn.Name = "toolMenuItemSwitchOn";
			this.toolMenuItemSwitchOn.Size = new Size(250, 22);
			this.toolMenuItemSwitchOn.Text = "Включить";
			this.toolMenuItemSwitchOn.Click += this.toolMenuItemSwitchOn_Click;
			this.toolStripMenuChangeArrowDirection.Name = "toolStripMenuChangeArrowDirection";
			this.toolStripMenuChangeArrowDirection.Size = new Size(250, 22);
			this.toolStripMenuChangeArrowDirection.Text = "Изменить направление стрелки";
			this.toolStripMenuChangeArrowDirection.Click += this.toolStripMenuChangeArrowDirection_Click;
			this.toolMenuItemSwitchFilter.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemSwitchFilterAdd,
				this.toolMenuItemSwitchFilterDel
			});
			this.toolMenuItemSwitchFilter.Name = "toolMenuItemSwitchFilter";
			this.toolMenuItemSwitchFilter.Size = new Size(250, 22);
			this.toolMenuItemSwitchFilter.Text = "Фильтр";
			this.toolMenuItemSwitchFilterAdd.Name = "toolMenuItemSwitchFilterAdd";
			this.toolMenuItemSwitchFilterAdd.Size = new Size(183, 22);
			this.toolMenuItemSwitchFilterAdd.Text = "Добавить в фильтр";
			this.toolMenuItemSwitchFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
			this.toolMenuItemSwitchFilterDel.Name = "toolMenuItemSwitchFilterDel";
			this.toolMenuItemSwitchFilterDel.Size = new Size(183, 22);
			this.toolMenuItemSwitchFilterDel.Text = "Удалить из фильтра";
			this.toolMenuItemSwitchFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
			this.toolStripMenuItemOOLDisplayGrLevel.Name = "toolStripMenuItemOOLDisplayGrLevel";
			this.toolStripMenuItemOOLDisplayGrLevel.Size = new Size(250, 22);
			this.toolStripMenuItemOOLDisplayGrLevel.Text = "Отобразить на первом уровне";
			this.toolStripMenuItemOOLDisplayGrLevel.Click += this.toolStripMenuItemTBTDisplayGrLevel_Click;
			this.toolStripMenuItemSwitchAddTelemetry.Name = "toolStripMenuItemSwitchAddTelemetry";
			this.toolStripMenuItemSwitchAddTelemetry.Size = new Size(250, 22);
			this.toolStripMenuItemSwitchAddTelemetry.Text = "Вывести данные телеметрии";
			this.toolStripMenuItemSwitchAddTelemetry.Click += this.QyjrxReCs8_Click;
			this.toolMenuItemSwitchErcloud.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemSwitchLinkErcloud,
				this.toolMenuItemSwitchShowDataErcloud
			});
			this.toolMenuItemSwitchErcloud.Name = "toolMenuItemSwitchErcloud";
			this.toolMenuItemSwitchErcloud.Size = new Size(250, 22);
			this.toolMenuItemSwitchErcloud.Text = "Ercloud";
			this.toolMenuItemSwitchLinkErcloud.Name = "toolMenuItemSwitchLinkErcloud";
			this.toolMenuItemSwitchLinkErcloud.Size = new Size(221, 22);
			this.toolMenuItemSwitchLinkErcloud.Text = "Привязать объект к АСКУЭ";
			this.toolMenuItemSwitchLinkErcloud.Click += this.toolMenuItemSwitchLinkErcloud_Click;
			this.toolMenuItemSwitchShowDataErcloud.Name = "toolMenuItemSwitchShowDataErcloud";
			this.toolMenuItemSwitchShowDataErcloud.Size = new Size(221, 22);
			this.toolMenuItemSwitchShowDataErcloud.Text = "Данные АСКУЭ";
			this.toolMenuItemSwitchShowDataErcloud.Click += this.toolMenuItemSwitchShowDataErcloud_Click;
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new Size(247, 6);
			this.toolStripMenuItemCSRollingOut.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemCSRepairMode,
				this.toolStripMenuItemCSTestMode
			});
			this.toolStripMenuItemCSRollingOut.Name = "toolStripMenuItemCSRollingOut";
			this.toolStripMenuItemCSRollingOut.Size = new Size(250, 22);
			this.toolStripMenuItemCSRollingOut.Text = "Выкатить";
			this.toolStripMenuItemCSRepairMode.Name = "toolStripMenuItemCSRepairMode";
			this.toolStripMenuItemCSRepairMode.Size = new Size(136, 22);
			this.toolStripMenuItemCSRepairMode.Text = "Ремонт";
			this.toolStripMenuItemCSRepairMode.Click += this.toolStripMenuItemCSRepairMode_Click;
			this.toolStripMenuItemCSTestMode.Name = "toolStripMenuItemCSTestMode";
			this.toolStripMenuItemCSTestMode.Size = new Size(136, 22);
			this.toolStripMenuItemCSTestMode.Text = "Испытания";
			this.toolStripMenuItemCSTestMode.Click += this.toolStripMenuItemCSTestMode_Click;
			this.toolStripMenuItemCSNormalMode.Name = "toolStripMenuItemCSNormalMode";
			this.toolStripMenuItemCSNormalMode.Size = new Size(250, 22);
			this.toolStripMenuItemCSNormalMode.Text = "Рабочий режим";
			this.toolStripMenuItemCSNormalMode.Click += this.toolStripMenuItemCSNormalMode_Click;
			this.toolStripSeparatorCS.Name = "toolStripSeparatorCS";
			this.toolStripSeparatorCS.Size = new Size(247, 6);
			this.toolMenuItemStateDel.Name = "toolMenuItemStateDel";
			this.toolMenuItemStateDel.Size = new Size(250, 22);
			this.toolMenuItemStateDel.Text = "Убрать статус";
			this.toolMenuItemStateDel.Click += this.toolMenuItemStateDel_Click;
			this.toolMenuItemSwitchCopy.Name = "toolMenuItemSwitchCopy";
			this.toolMenuItemSwitchCopy.Size = new Size(250, 22);
			this.toolMenuItemSwitchCopy.Text = "Копировать";
			this.toolMenuItemSwitchCopy.Click += this.reArSpApSW_Click;
			this.toolMenuItemSwitchDel.Name = "toolMenuItemSwitchDel";
			this.toolMenuItemSwitchDel.Size = new Size(250, 22);
			this.toolMenuItemSwitchDel.Text = "Удалить";
			this.toolMenuItemSwitchDel.Click += this.toolMenuItemTextBranchDel_Click;
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new Size(247, 6);
			this.ToolStripMenuItemSwitchMeasurement.Name = "ToolStripMenuItemSwitchMeasurement";
			this.ToolStripMenuItemSwitchMeasurement.Size = new Size(250, 22);
			this.ToolStripMenuItemSwitchMeasurement.Text = "Замеры";
			this.ToolStripMenuItemSwitchMeasurement.Click += this.ToolStripMenuItemSwitchMeasurement_Click;
			this.toolMenuItemSwitchLogDispatcher.Name = "toolMenuItemSwitchLogDispatcher";
			this.toolMenuItemSwitchLogDispatcher.Size = new Size(250, 22);
			this.toolMenuItemSwitchLogDispatcher.Text = "Отчет диспетчера";
			this.toolMenuItemSwitchLogDispatcher.Click += this.toolMenuItemSwitchLogDispatcher_Click;
			this.toolMenuItemSwitchFile.Name = "toolMenuItemSwitchFile";
			this.toolMenuItemSwitchFile.Size = new Size(250, 22);
			this.toolMenuItemSwitchFile.Text = "Файлы";
			this.toolMenuItemSwitchFile.Click += this.toolMenuItemLineFile_Click;
			this.MSMZJEXRVG.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
			this.MSMZJEXRVG.Name = "toolMenuItemSwitchProperty";
			this.MSMZJEXRVG.Size = new Size(250, 22);
			this.MSMZJEXRVG.Text = "Свойства объекта";
			this.MSMZJEXRVG.Click += this.WcgruJuvXg_Click;
			this.contextMenuLineTool.ImageScalingSize = new Size(20, 20);
			this.contextMenuLineTool.Items.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLineAddChild,
				this.toolMenuItemLineCopy,
				this.uBbItwaYjM,
				this.toolStripMenuItemDevideLine,
				this.toolStripMenuItemDisconnectLine,
				this.toolMenuItemLineDel,
				this.toolStripSeparatorEditLine,
				this.toolMenuItemLineSetStatus,
				this.toolStripSeparatorSetStatus,
				this.toolMenuItemLineTextHere,
				this.toolStripSeparatorLineTextHere,
				this.toolMenuItemLineFilter,
				this.toolMenuItemLinePowerSource,
				this.toolStripMenuItem1,
				this.toolMenuItemLineRecipientsPower,
				this.toolStripMenuItem10,
				this.toolStripMenuItem12,
				this.QyjrxReCs8,
				this.toolStripSeparator8,
				this.toolMenuItemLinePropertyPoint,
				this.toolStripMenuItemLineAlignBranch,
				this.toolMenuItemLinePropertyBranch,
				this.toolStripSeparator14,
				this.toolMenuItemLineRelayProtection,
				this.toolMenuItemLineLogDispatcher,
				this.toolMenuItemLinePassport,
				this.toolMenuItemLineFile,
				this.toolMenuItemLineProperty
			});
			this.contextMenuLineTool.Name = "contextMenuLineTool";
			this.contextMenuLineTool.Size = new Size(272, 524);
			this.contextMenuLineTool.Closed += this.contextMenuLineTool_Closed;
			this.contextMenuLineTool.Opening += this.contextMenuLineTool_Opening;
			this.toolMenuItemLineAddChild.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLineAddBranch,
				this.toolMenuItemLineAddPoint,
				this.toolStripSeparatorLineAddBranchPoint,
				this.toolMenuItemLineAddOutsideLineDisconnector,
				this.toolMenuItemLineAddVacuumSwitch,
				this.toolMenuItemLineAddTransformer,
				this.toolMenuItemLineAddVoltageTransformer,
				this.toolStripMenuItemAddAmperageTransformerTool,
				this.toolMenuItemLineAddLoadSwitch,
				this.toolMenuItemLineAddLoadSwitchWaxwork,
				this.toolMenuItemLineAddRPS,
				this.toolMenuItemLineAddLinearDisconnector,
				this.toolMenuItemLineAddLinearDisconnectorWaxwork,
				this.toolMenuItemLineAddLubricantDisconnector,
				this.toolMenuItemLineAddFuseTool,
				this.toolMenuItemLineAddDischargerTool,
				this.toolMenuItemLineAddVoltageLimetedTool,
				this.toolMenuItemLineAddEndTrim,
				this.toolMenuItemLineAddCircuitBreakerTool,
				this.toolMenuItemLineAddGroundingTool,
				this.toolMenuItemLineAddSeparatorTool,
				this.toolStripMenuItemAddMagneticStarterTool,
				this.toolStripMenuItemAddElectricMeter,
				this.toolStripSeparator6,
				this.toolMenuItemAddLineText
			});
			this.toolMenuItemLineAddChild.Name = "toolMenuItemLineAddChild";
			this.toolMenuItemLineAddChild.Size = new Size(271, 22);
			this.toolMenuItemLineAddChild.Text = "Добавить";
			this.toolMenuItemLineAddBranch.Name = "toolMenuItemLineAddBranch";
			this.toolMenuItemLineAddBranch.Size = new Size(276, 22);
			this.toolMenuItemLineAddBranch.Text = "Ветку";
			this.toolMenuItemLineAddBranch.Click += this.toolMenuItemLineAddBranch_Click;
			this.toolMenuItemLineAddPoint.Name = "toolMenuItemLineAddPoint";
			this.toolMenuItemLineAddPoint.Size = new Size(276, 22);
			this.toolMenuItemLineAddPoint.Text = "Узел";
			this.toolMenuItemLineAddPoint.Click += this.toolMenuItemLineAddPoint_Click;
			this.toolStripSeparatorLineAddBranchPoint.Name = "toolStripSeparatorLineAddBranchPoint";
			this.toolStripSeparatorLineAddBranchPoint.Size = new Size(273, 6);
			this.toolMenuItemLineAddOutsideLineDisconnector.Name = "toolMenuItemLineAddOutsideLineDisconnector";
			this.toolMenuItemLineAddOutsideLineDisconnector.Size = new Size(276, 22);
			this.toolMenuItemLineAddOutsideLineDisconnector.Text = "Разъеденитель линейный наружный";
			this.toolMenuItemLineAddOutsideLineDisconnector.Click += this.toolMenuItemLineAddOutsideLineDisconnector_Click;
			this.toolMenuItemLineAddVacuumSwitch.Name = "toolMenuItemLineAddVacuumSwitch";
			this.toolMenuItemLineAddVacuumSwitch.Size = new Size(276, 22);
			this.toolMenuItemLineAddVacuumSwitch.Text = "Вакуумный выключатель";
			this.toolMenuItemLineAddVacuumSwitch.Click += this.toolMenuItemLineAddVacuumSwitch_Click;
			this.toolMenuItemLineAddTransformer.Name = "toolMenuItemLineAddTransformer";
			this.toolMenuItemLineAddTransformer.Size = new Size(276, 22);
			this.toolMenuItemLineAddTransformer.Text = "Трансформатор";
			this.toolMenuItemLineAddTransformer.Click += this.toolMenuItemLineAddTransformer_Click;
			this.toolMenuItemLineAddVoltageTransformer.Name = "toolMenuItemLineAddVoltageTransformer";
			this.toolMenuItemLineAddVoltageTransformer.Size = new Size(276, 22);
			this.toolMenuItemLineAddVoltageTransformer.Text = "Трансформатор напряжения";
			this.toolMenuItemLineAddVoltageTransformer.Click += this.toolMenuItemLineAddVoltageTransformer_Click;
			this.toolStripMenuItemAddAmperageTransformerTool.Name = "toolStripMenuItemAddAmperageTransformerTool";
			this.toolStripMenuItemAddAmperageTransformerTool.Size = new Size(276, 22);
			this.toolStripMenuItemAddAmperageTransformerTool.Text = "Трансформатор тока";
			this.toolStripMenuItemAddAmperageTransformerTool.Click += this.toolStripMenuItemAddAmperageTransformerTool_Click;
			this.toolMenuItemLineAddLoadSwitch.Name = "toolMenuItemLineAddLoadSwitch";
			this.toolMenuItemLineAddLoadSwitch.Size = new Size(276, 22);
			this.toolMenuItemLineAddLoadSwitch.Text = "Выключатель нагрузки";
			this.toolMenuItemLineAddLoadSwitch.Click += this.toolMenuItemLineAddLoadSwitch_Click;
			this.toolMenuItemLineAddLoadSwitchWaxwork.Name = "toolMenuItemLineAddLoadSwitchWaxwork";
			this.toolMenuItemLineAddLoadSwitchWaxwork.Size = new Size(276, 22);
			this.toolMenuItemLineAddLoadSwitchWaxwork.Text = "Выключатель нагрузки";
			this.toolMenuItemLineAddLoadSwitchWaxwork.Click += this.toolMenuItemLineAddLoadSwitchWaxwork_Click;
			this.toolMenuItemLineAddRPS.Name = "toolMenuItemLineAddRPS";
			this.toolMenuItemLineAddRPS.Size = new Size(276, 22);
			this.toolMenuItemLineAddRPS.Text = "РПС";
			this.toolMenuItemLineAddRPS.Click += this.toolMenuItemLineAddRPS_Click;
			this.toolMenuItemLineAddLinearDisconnector.Name = "toolMenuItemLineAddLinearDisconnector";
			this.toolMenuItemLineAddLinearDisconnector.Size = new Size(276, 22);
			this.toolMenuItemLineAddLinearDisconnector.Text = "Линейный разъеденитель";
			this.toolMenuItemLineAddLinearDisconnector.Click += this.toolMenuItemLineAddLinearDisconnector_Click;
			this.toolMenuItemLineAddLinearDisconnectorWaxwork.Name = "toolMenuItemLineAddLinearDisconnectorWaxwork";
			this.toolMenuItemLineAddLinearDisconnectorWaxwork.Size = new Size(276, 22);
			this.toolMenuItemLineAddLinearDisconnectorWaxwork.Text = "Линейный разъеденитель";
			this.toolMenuItemLineAddLinearDisconnectorWaxwork.Visible = false;
			this.toolMenuItemLineAddLinearDisconnectorWaxwork.Click += this.toolMenuItemLineAddLinearDisconnectorWaxwork_Click;
			this.toolMenuItemLineAddLubricantDisconnector.Name = "toolMenuItemLineAddLubricantDisconnector";
			this.toolMenuItemLineAddLubricantDisconnector.Size = new Size(276, 22);
			this.toolMenuItemLineAddLubricantDisconnector.Text = "Маслянный выключатель";
			this.toolMenuItemLineAddLubricantDisconnector.Click += this.zdhttAlvjH;
			this.toolMenuItemLineAddFuseTool.Name = "toolMenuItemLineAddFuseTool";
			this.toolMenuItemLineAddFuseTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddFuseTool.Text = "Предохранитель";
			this.toolMenuItemLineAddFuseTool.Click += this.toolMenuItemLineAddFuseTool_Click;
			this.toolMenuItemLineAddDischargerTool.Name = "toolMenuItemLineAddDischargerTool";
			this.toolMenuItemLineAddDischargerTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddDischargerTool.Text = "Разрядник";
			this.toolMenuItemLineAddDischargerTool.Click += this.toolMenuItemLineAddDischargerTool_Click;
			this.toolMenuItemLineAddVoltageLimetedTool.Name = "toolMenuItemLineAddVoltageLimetedTool";
			this.toolMenuItemLineAddVoltageLimetedTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddVoltageLimetedTool.Text = "Ограничитель перенапряжения";
			this.toolMenuItemLineAddVoltageLimetedTool.Click += this.toolMenuItemLineAddVoltageLimetedTool_Click;
			this.toolMenuItemLineAddEndTrim.Name = "toolMenuItemLineAddEndTrim";
			this.toolMenuItemLineAddEndTrim.Size = new Size(276, 22);
			this.toolMenuItemLineAddEndTrim.Text = "Концевая разделка";
			this.toolMenuItemLineAddEndTrim.Click += this.toolMenuItemLineAddEndTrim_Click;
			this.toolMenuItemLineAddCircuitBreakerTool.Name = "toolMenuItemLineAddCircuitBreakerTool";
			this.toolMenuItemLineAddCircuitBreakerTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddCircuitBreakerTool.Text = "Автоматический выключатель";
			this.toolMenuItemLineAddCircuitBreakerTool.Click += this.toolMenuItemLineAddCircuitBreakerTool_Click;
			this.toolMenuItemLineAddGroundingTool.Name = "toolMenuItemLineAddGroundingTool";
			this.toolMenuItemLineAddGroundingTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddGroundingTool.Text = "Заземление";
			this.toolMenuItemLineAddGroundingTool.Click += this.toolMenuItemLineAddGroundingTool_Click;
			this.toolMenuItemLineAddSeparatorTool.ImageAlign = ContentAlignment.MiddleRight;
			this.toolMenuItemLineAddSeparatorTool.Name = "toolMenuItemLineAddSeparatorTool";
			this.toolMenuItemLineAddSeparatorTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddSeparatorTool.Text = "Отделитель";
			this.toolMenuItemLineAddSeparatorTool.Click += this.toolMenuItemLineAddSeparatorTool_Click;
			this.toolStripMenuItemAddMagneticStarterTool.Name = "toolStripMenuItemAddMagneticStarterTool";
			this.toolStripMenuItemAddMagneticStarterTool.Size = new Size(276, 22);
			this.toolStripMenuItemAddMagneticStarterTool.Text = "Магнитный пускатель";
			this.toolStripMenuItemAddMagneticStarterTool.Click += this.toolStripMenuItemAddMagneticStarterTool_Click;
			this.toolStripMenuItemAddElectricMeter.Name = "toolStripMenuItemAddElectricMeter";
			this.toolStripMenuItemAddElectricMeter.Size = new Size(276, 22);
			this.toolStripMenuItemAddElectricMeter.Text = "Счётчик";
			this.toolStripMenuItemAddElectricMeter.Click += this.toolStripMenuItemAddElectricMeter_Click;
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new Size(273, 6);
			this.toolMenuItemAddLineText.Name = "toolMenuItemAddLineText";
			this.toolMenuItemAddLineText.Size = new Size(276, 22);
			this.toolMenuItemAddLineText.Text = "Текст";
			this.toolMenuItemAddLineText.Click += this.toolMenuItemAddLineText_Click;
			this.toolMenuItemLineCopy.Name = "toolMenuItemLineCopy";
			this.toolMenuItemLineCopy.Size = new Size(271, 22);
			this.toolMenuItemLineCopy.Text = "Копировать";
			this.toolMenuItemLineCopy.Click += this.reArSpApSW_Click;
			this.uBbItwaYjM.Name = "toolMenuItemLinePaste";
			this.uBbItwaYjM.Size = new Size(271, 22);
			this.uBbItwaYjM.Text = "Вставить";
			this.uBbItwaYjM.Click += this.uBbItwaYjM_Click;
			this.toolStripMenuItemDevideLine.Name = "toolStripMenuItemDevideLine";
			this.toolStripMenuItemDevideLine.Size = new Size(271, 22);
			this.toolStripMenuItemDevideLine.Text = "Разделить линию";
			this.toolStripMenuItemDevideLine.Click += this.toolStripMenuItemDevideLine_Click;
			this.toolStripMenuItemDisconnectLine.Name = "toolStripMenuItemDisconnectLine";
			this.toolStripMenuItemDisconnectLine.Size = new Size(271, 22);
			this.toolStripMenuItemDisconnectLine.Text = "Разъеденить линии";
			this.toolStripMenuItemDisconnectLine.Click += this.toolStripMenuItemDisconnectLine_Click;
			this.toolMenuItemLineDel.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLineDelObj,
				this.toolMenuItemLineDelPoint
			});
			this.toolMenuItemLineDel.Name = "toolMenuItemLineDel";
			this.toolMenuItemLineDel.Size = new Size(271, 22);
			this.toolMenuItemLineDel.Text = "Удалить";
			this.toolMenuItemLineDelObj.Name = "toolMenuItemLineDelObj";
			this.toolMenuItemLineDelObj.Size = new Size(117, 22);
			this.toolMenuItemLineDelObj.Text = "Объект ";
			this.toolMenuItemLineDelObj.Click += this.toolMenuItemTextBranchDel_Click;
			this.toolMenuItemLineDelPoint.Name = "toolMenuItemLineDelPoint";
			this.toolMenuItemLineDelPoint.Size = new Size(117, 22);
			this.toolMenuItemLineDelPoint.Text = "Узел";
			this.toolMenuItemLineDelPoint.Click += this.toolMenuItemLineDelPoint_Click;
			this.toolStripSeparatorEditLine.Name = "toolStripSeparatorEditLine";
			this.toolStripSeparatorEditLine.Size = new Size(268, 6);
			this.toolMenuItemLineSetStatus.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLineSetStatusGrounding,
				this.toolMenuItemLineSetStatusBrakeDown,
				this.toolMenuItemLineSetStatusOff,
				this.toolMenuItemLineSetStatusNoPhased,
				this.toolMenuItemLineSetStatusArrow
			});
			this.toolMenuItemLineSetStatus.Name = "toolMenuItemLineSetStatus";
			this.toolMenuItemLineSetStatus.Size = new Size(271, 22);
			this.toolMenuItemLineSetStatus.Text = "Установить статус";
			this.toolMenuItemLineSetStatusGrounding.Name = "toolMenuItemLineSetStatusGrounding";
			this.toolMenuItemLineSetStatusGrounding.Size = new Size(174, 22);
			this.toolMenuItemLineSetStatusGrounding.Text = "Заземлено";
			this.toolMenuItemLineSetStatusGrounding.Click += this.toolMenuItemLineSetStatusGrounding_Click;
			this.toolMenuItemLineSetStatusBrakeDown.Name = "toolMenuItemLineSetStatusBrakeDown";
			this.toolMenuItemLineSetStatusBrakeDown.Size = new Size(174, 22);
			this.toolMenuItemLineSetStatusBrakeDown.Text = "Повреждено";
			this.toolMenuItemLineSetStatusBrakeDown.Click += this.toolMenuItemLineSetStatusBrakeDown_Click;
			this.toolMenuItemLineSetStatusOff.Name = "toolMenuItemLineSetStatusOff";
			this.toolMenuItemLineSetStatusOff.Size = new Size(174, 22);
			this.toolMenuItemLineSetStatusOff.Text = "Отсоединено";
			this.toolMenuItemLineSetStatusOff.Click += this.toolMenuItemLineSetStatusOff_Click;
			this.toolMenuItemLineSetStatusNoPhased.Name = "toolMenuItemLineSetStatusNoPhased";
			this.toolMenuItemLineSetStatusNoPhased.Size = new Size(174, 22);
			this.toolMenuItemLineSetStatusNoPhased.Text = "Несфазированно";
			this.toolMenuItemLineSetStatusNoPhased.Click += this.toolMenuItemLineSetStatusNoPhased_Click;
			this.toolMenuItemLineSetStatusArrow.Name = "toolMenuItemLineSetStatusArrow";
			this.toolMenuItemLineSetStatusArrow.Size = new Size(174, 22);
			this.toolMenuItemLineSetStatusArrow.Text = "Перенос нагрузки";
			this.toolMenuItemLineSetStatusArrow.Click += this.toolMenuItemLineSetStatusArrow_Click;
			this.toolStripSeparatorSetStatus.Name = "toolStripSeparatorSetStatus";
			this.toolStripSeparatorSetStatus.Size = new Size(268, 6);
			this.toolMenuItemLineTextHere.Name = "toolMenuItemLineTextHere";
			this.toolMenuItemLineTextHere.Size = new Size(271, 22);
			this.toolMenuItemLineTextHere.Text = "Разместить текст здесь";
			this.toolMenuItemLineTextHere.Click += this.toolMenuItemLineTextHere_Click;
			this.toolStripSeparatorLineTextHere.Name = "toolStripSeparatorLineTextHere";
			this.toolStripSeparatorLineTextHere.Size = new Size(268, 6);
			this.toolMenuItemLineFilter.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLineFilterAdd,
				this.toolMenuItemLineFilterDel
			});
			this.toolMenuItemLineFilter.Name = "toolMenuItemLineFilter";
			this.toolMenuItemLineFilter.Size = new Size(271, 22);
			this.toolMenuItemLineFilter.Text = "Фильтр";
			this.toolMenuItemLineFilterAdd.Name = "toolMenuItemLineFilterAdd";
			this.toolMenuItemLineFilterAdd.Size = new Size(183, 22);
			this.toolMenuItemLineFilterAdd.Text = "Добавить в фильтр";
			this.toolMenuItemLineFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
			this.toolMenuItemLineFilterDel.Name = "toolMenuItemLineFilterDel";
			this.toolMenuItemLineFilterDel.Size = new Size(183, 22);
			this.toolMenuItemLineFilterDel.Text = "Удалить из фильтра";
			this.toolMenuItemLineFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
			this.toolMenuItemLinePowerSource.Name = "toolMenuItemLinePowerSource";
			this.toolMenuItemLinePowerSource.Size = new Size(268, 6);
			this.toolMenuItemLinePowerSource.Click += this.toolStripMenuItem8_Click;
			this.toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem6,
				this.toolStripMenuItem8
			});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new Size(271, 22);
			this.toolStripMenuItem1.Text = "Просчитать запитку";
			this.toolStripMenuItem1.Click += this.toolStripMenuItem8_Click;
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new Size(186, 22);
			this.toolStripMenuItem6.Tag = "1";
			this.toolStripMenuItem6.Text = "Выделить";
			this.toolStripMenuItem6.Click += this.toolStripMenuItem8_Click;
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new Size(186, 22);
			this.toolStripMenuItem8.Tag = "2";
			this.toolStripMenuItem8.Text = "Выделить миганием";
			this.toolStripMenuItem8.Click += this.toolStripMenuItem8_Click;
			this.toolMenuItemLineRecipientsPower.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem7,
				this.toolStripMenuItem9
			});
			this.toolMenuItemLineRecipientsPower.Name = "toolMenuItemLineRecipientsPower";
			this.toolMenuItemLineRecipientsPower.Size = new Size(271, 22);
			this.toolMenuItemLineRecipientsPower.Text = "Просчитать схему";
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new Size(186, 22);
			this.toolStripMenuItem7.Tag = "1";
			this.toolStripMenuItem7.Text = "Выделить";
			this.toolStripMenuItem7.Click += this.toolStripMenuItem9_Click;
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new Size(186, 22);
			this.toolStripMenuItem9.Tag = "2";
			this.toolStripMenuItem9.Text = "Выделить миганием";
			this.toolStripMenuItem9.Click += this.toolStripMenuItem9_Click;
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new Size(271, 22);
			this.toolStripMenuItem10.Text = "Все возможные источники питания";
			this.toolStripMenuItem10.Visible = false;
			this.toolStripMenuItem10.Click += this.toolStripMenuItem10_Click;
			this.toolStripMenuItem12.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem13,
				this.toolStripMenuItem14
			});
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.Size = new Size(271, 22);
			this.toolStripMenuItem12.Text = "Абоненты";
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new Size(191, 22);
			this.toolStripMenuItem13.Text = "Текущей подстанции";
			this.toolStripMenuItem13.Click += this.toolStripMenuItem14_Click;
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			this.toolStripMenuItem14.Size = new Size(191, 22);
			this.toolStripMenuItem14.Tag = "1";
			this.toolStripMenuItem14.Text = "По цепочке";
			this.toolStripMenuItem14.Click += this.toolStripMenuItem14_Click;
			this.QyjrxReCs8.Name = "toolStripMenuItemLineAddTelemertryLabel";
			this.QyjrxReCs8.Size = new Size(271, 22);
			this.QyjrxReCs8.Text = "Вывести данные телеметрии";
			this.QyjrxReCs8.Click += this.QyjrxReCs8_Click;
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new Size(268, 6);
			this.toolMenuItemLinePropertyPoint.Name = "toolMenuItemLinePropertyPoint";
			this.toolMenuItemLinePropertyPoint.Size = new Size(271, 22);
			this.toolMenuItemLinePropertyPoint.Text = "Свойства узла";
			this.toolMenuItemLinePropertyPoint.Click += this.toolMenuItemLinePropertyPoint_Click;
			this.toolStripMenuItemLineAlignBranch.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemAlignBranchByTop,
				this.toolStripMenuItemAlignBranchByBottom,
				this.toolStripMenuItemAlignBranchByRigth,
				this.toolStripMenuItemAlignBranchByLeft
			});
			this.toolStripMenuItemLineAlignBranch.Name = "toolStripMenuItemLineAlignBranch";
			this.toolStripMenuItemLineAlignBranch.Size = new Size(271, 22);
			this.toolStripMenuItemLineAlignBranch.Text = "Выровнить ветку";
			this.toolStripMenuItemAlignBranchByTop.Name = "toolStripMenuItemAlignBranchByTop";
			this.toolStripMenuItemAlignBranchByTop.Size = new Size(171, 22);
			this.toolStripMenuItemAlignBranchByTop.Tag = "T";
			this.toolStripMenuItemAlignBranchByTop.Text = "По верхней точке";
			this.toolStripMenuItemAlignBranchByTop.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
			this.toolStripMenuItemAlignBranchByBottom.Name = "toolStripMenuItemAlignBranchByBottom";
			this.toolStripMenuItemAlignBranchByBottom.Size = new Size(171, 22);
			this.toolStripMenuItemAlignBranchByBottom.Tag = "B";
			this.toolStripMenuItemAlignBranchByBottom.Text = "По нижней точке";
			this.toolStripMenuItemAlignBranchByBottom.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
			this.toolStripMenuItemAlignBranchByRigth.Name = "toolStripMenuItemAlignBranchByRigth";
			this.toolStripMenuItemAlignBranchByRigth.Size = new Size(171, 22);
			this.toolStripMenuItemAlignBranchByRigth.Tag = "R";
			this.toolStripMenuItemAlignBranchByRigth.Text = "По правой точке";
			this.toolStripMenuItemAlignBranchByRigth.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
			this.toolStripMenuItemAlignBranchByLeft.Name = "toolStripMenuItemAlignBranchByLeft";
			this.toolStripMenuItemAlignBranchByLeft.Size = new Size(171, 22);
			this.toolStripMenuItemAlignBranchByLeft.Tag = "L";
			this.toolStripMenuItemAlignBranchByLeft.Text = "По левой точке";
			this.toolStripMenuItemAlignBranchByLeft.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
			this.toolMenuItemLinePropertyBranch.Name = "toolMenuItemLinePropertyBranch";
			this.toolMenuItemLinePropertyBranch.Size = new Size(271, 22);
			this.toolMenuItemLinePropertyBranch.Text = "Свойства ветки";
			this.toolMenuItemLinePropertyBranch.Click += this.toolMenuItemLinePropertyBranch_Click;
			this.toolStripSeparator14.Name = "toolStripSeparator14";
			this.toolStripSeparator14.Size = new Size(268, 6);
			this.toolMenuItemLineRelayProtection.Name = "toolMenuItemLineRelayProtection";
			this.toolMenuItemLineRelayProtection.Size = new Size(271, 22);
			this.toolMenuItemLineRelayProtection.Text = "Уставки РЗА";
			this.toolMenuItemLineRelayProtection.Click += this.toolMenuItemLineRelayProtection_Click;
			this.toolMenuItemLineLogDispatcher.Name = "toolMenuItemLineLogDispatcher";
			this.toolMenuItemLineLogDispatcher.Size = new Size(271, 22);
			this.toolMenuItemLineLogDispatcher.Text = "Отчет диспетчера";
			this.toolMenuItemLineLogDispatcher.Click += this.toolMenuItemLineLogDispatcher_Click;
			this.toolMenuItemLinePassport.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLinePassportOpen,
				this.toolMenuItemLineDeLinkPassport,
				this.toolMenuItemLineLinkPassport
			});
			this.toolMenuItemLinePassport.Name = "toolMenuItemLinePassport";
			this.toolMenuItemLinePassport.Size = new Size(271, 22);
			this.toolMenuItemLinePassport.Text = "Паспорт";
			this.toolMenuItemLinePassport.Click += this.toolMenuItemLinePassportOpen_Click;
			this.toolMenuItemLinePassportOpen.Name = "toolMenuItemLinePassportOpen";
			this.toolMenuItemLinePassportOpen.Size = new Size(194, 22);
			this.toolMenuItemLinePassportOpen.Text = "Открыть";
			this.toolMenuItemLinePassportOpen.Click += this.toolMenuItemLinePassportOpen_Click;
			this.toolMenuItemLineDeLinkPassport.Name = "toolMenuItemLineDeLinkPassport";
			this.toolMenuItemLineDeLinkPassport.Size = new Size(194, 22);
			this.toolMenuItemLineDeLinkPassport.Text = "Отвязать от паспорта";
			this.toolMenuItemLineDeLinkPassport.Click += this.toolMenuItemLineDeLinkPassport_Click;
			this.toolMenuItemLineLinkPassport.Name = "toolMenuItemLineLinkPassport";
			this.toolMenuItemLineLinkPassport.Size = new Size(194, 22);
			this.toolMenuItemLineLinkPassport.Text = "Привязать к паспорту";
			this.toolMenuItemLineLinkPassport.Click += this.toolMenuItemLineLinkPassport_Click;
			this.toolMenuItemLineFile.Name = "toolMenuItemLineFile";
			this.toolMenuItemLineFile.Size = new Size(271, 22);
			this.toolMenuItemLineFile.Text = "Файлы";
			this.toolMenuItemLineFile.Click += this.toolMenuItemLineFile_Click;
			this.toolMenuItemLineProperty.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
			this.toolMenuItemLineProperty.Name = "toolMenuItemLineProperty";
			this.toolMenuItemLineProperty.Size = new Size(271, 22);
			this.toolMenuItemLineProperty.Text = "Свойства линии";
			this.toolMenuItemLineProperty.Click += this.WcgruJuvXg_Click;
			this.contextMenuCanvas.ImageScalingSize = new Size(20, 20);
			this.contextMenuCanvas.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemAddFreeLabel,
				this.toolStripMenuItemAddTelemetryLabel2Level,
				this.toolMenuItemAddNode,
				this.toolMenuCanvasPaste
			});
			this.contextMenuCanvas.Name = "contextMenuCanvas";
			this.contextMenuCanvas.Size = new Size(233, 92);
			this.contextMenuCanvas.Opening += this.contextMenuCanvas_Opening;
			this.toolStripMenuItemAddFreeLabel.Name = "toolStripMenuItemAddFreeLabel";
			this.toolStripMenuItemAddFreeLabel.Size = new Size(232, 22);
			this.toolStripMenuItemAddFreeLabel.Text = "Добавить текст";
			this.toolStripMenuItemAddFreeLabel.Click += this.toolStripMenuItemAddFreeLabel_Click;
			this.toolStripMenuItemAddTelemetryLabel2Level.Name = "toolStripMenuItemAddTelemetryLabel2Level";
			this.toolStripMenuItemAddTelemetryLabel2Level.Size = new Size(232, 22);
			this.toolStripMenuItemAddTelemetryLabel2Level.Text = "Вывести данные телеметрии";
			this.toolStripMenuItemAddTelemetryLabel2Level.Click += this.toolStripMenuItemAddTelemetryLabel2Level_Click;
			this.toolMenuItemAddNode.Name = "toolMenuItemAddNode";
			this.toolMenuItemAddNode.Size = new Size(232, 22);
			this.toolMenuItemAddNode.Text = "Добавить примечание";
			this.toolMenuItemAddNode.Click += this.toolMenuItemAddNode_Click;
			this.toolMenuCanvasPaste.Name = "toolMenuCanvasPaste";
			this.toolMenuCanvasPaste.Size = new Size(232, 22);
			this.toolMenuCanvasPaste.Text = "Вставить";
			this.toolMenuCanvasPaste.Click += this.toolMenuCanvasPaste_Click;
			this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListConnected.ImageStream");
			this.imageList_0.TransparentColor = Color.Transparent;
			this.imageList_0.Images.SetKeyName(0, "Connect.png");
			this.imageList_0.Images.SetKeyName(1, "NoConnect.png");
			this.contextMenuLabelTool.ImageScalingSize = new Size(20, 20);
			this.contextMenuLabelTool.Items.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLabelUpdate,
				this.toolMenuItemLabelDel,
				this.toolMenuItemLabelProperty
			});
			this.contextMenuLabelTool.Name = "contextMenuLabelTool";
			this.contextMenuLabelTool.Size = new Size(178, 70);
			this.contextMenuLabelTool.Opening += this.contextMenuLabelTool_Opening;
			this.toolMenuItemLabelUpdate.Name = "toolMenuItemLabelUpdate";
			this.toolMenuItemLabelUpdate.Size = new Size(177, 22);
			this.toolMenuItemLabelUpdate.Text = "Обновить данные";
			this.toolMenuItemLabelUpdate.Click += this.toolMenuItemLabelUpdate_Click;
			this.toolMenuItemLabelDel.Name = "toolMenuItemLabelDel";
			this.toolMenuItemLabelDel.Size = new Size(177, 22);
			this.toolMenuItemLabelDel.Text = "Удалить";
			this.toolMenuItemLabelDel.Click += this.toolMenuItemLabelDel_Click;
			this.toolMenuItemLabelProperty.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.toolMenuItemLabelProperty.Name = "toolMenuItemLabelProperty";
			this.toolMenuItemLabelProperty.Size = new Size(177, 22);
			this.toolMenuItemLabelProperty.Text = "Свойства объекта";
			this.toolMenuItemLabelProperty.Click += this.WcgruJuvXg_Click;
			this.contextMenuStripWhitePoint.ImageScalingSize = new Size(20, 20);
			this.contextMenuStripWhitePoint.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemRemoveWhitePoint,
				this.toolStripMenuItem_0
			});
			this.contextMenuStripWhitePoint.Name = "contextMenuStripWhitePoint";
			this.contextMenuStripWhitePoint.Size = new Size(128, 48);
			this.contextMenuStripWhitePoint.Opening += this.contextMenuStripWhitePoint_Opening;
			this.toolStripMenuItemRemoveWhitePoint.Name = "toolStripMenuItemRemoveWhitePoint";
			this.toolStripMenuItemRemoveWhitePoint.Size = new Size(127, 22);
			this.toolStripMenuItemRemoveWhitePoint.Text = "Удалить";
			this.toolStripMenuItemRemoveWhitePoint.Click += this.toolStripMenuItemRemoveWhitePoint_Click;
			this.toolStripMenuItem_0.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.toolStripMenuItem_0.Name = "свойстваToolStripMenuItem";
			this.toolStripMenuItem_0.Size = new Size(127, 22);
			this.toolStripMenuItem_0.Text = "Свойства";
			this.toolStripMenuItem_0.Click += this.WcgruJuvXg_Click;
			this.contextMenuFrame.ImageScalingSize = new Size(20, 20);
			this.contextMenuFrame.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuFramePrint,
				this.toolStripMenuFrameCopyToImage,
				this.toolStripMenuFrameExportToImage,
				this.toolStripMenuFrameFitZoom
			});
			this.contextMenuFrame.Name = "contextMenuFrame";
			this.contextMenuFrame.Size = new Size(202, 92);
			this.toolStripMenuFramePrint.Name = "toolStripMenuFramePrint";
			this.toolStripMenuFramePrint.Size = new Size(201, 22);
			this.toolStripMenuFramePrint.Text = "Печать";
			this.toolStripMenuFramePrint.Click += this.toolStripMenuFramePrint_Click;
			this.toolStripMenuFrameCopyToImage.Name = "toolStripMenuFrameCopyToImage";
			this.toolStripMenuFrameCopyToImage.Size = new Size(201, 22);
			this.toolStripMenuFrameCopyToImage.Text = "Копировать в картинку";
			this.toolStripMenuFrameCopyToImage.Click += this.toolStripMenuFrameCopyToImage_Click;
			this.toolStripMenuFrameExportToImage.Name = "toolStripMenuFrameExportToImage";
			this.toolStripMenuFrameExportToImage.Size = new Size(201, 22);
			this.toolStripMenuFrameExportToImage.Text = "Экспорт в картинку";
			this.toolStripMenuFrameExportToImage.Click += this.toolStripMenuFrameExportToImage_Click;
			this.toolStripMenuFrameFitZoom.Name = "toolStripMenuFrameFitZoom";
			this.toolStripMenuFrameFitZoom.Size = new Size(201, 22);
			this.toolStripMenuFrameFitZoom.Text = "Подогнать под рамку";
			this.toolStripMenuFrameFitZoom.Click += this.toolStripMenuFrameFitZoom_Click;
			this.textBoxSearch.Location = new Point(0, 399);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new Size(100, 20);
			this.textBoxSearch.TabIndex = 9;
			this.button1.Location = new Point(112, 397);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += this.button1_Click;
			this.contextMenuTextBranchTool.ImageScalingSize = new Size(20, 20);
			this.contextMenuTextBranchTool.Items.AddRange(new ToolStripItem[]
			{
				this.reArSpApSW,
				this.toolStripMenuItemTBTDisplayGrLevel,
				this.toolMenuItemTextBranchDel,
				this.WcgruJuvXg
			});
			this.contextMenuTextBranchTool.Name = "contextMenuTextBranchTool";
			this.contextMenuTextBranchTool.Size = new Size(243, 92);
			this.contextMenuTextBranchTool.Opening += this.contextMenuTextBranchTool_Opening;
			this.reArSpApSW.Name = "копироватьToolStripMenuItem";
			this.reArSpApSW.Size = new Size(242, 22);
			this.reArSpApSW.Text = "Копировать";
			this.reArSpApSW.Click += this.reArSpApSW_Click;
			this.toolStripMenuItemTBTDisplayGrLevel.Name = "toolStripMenuItemTBTDisplayGrLevel";
			this.toolStripMenuItemTBTDisplayGrLevel.Size = new Size(242, 22);
			this.toolStripMenuItemTBTDisplayGrLevel.Text = "Копировать на первый уровне";
			this.toolStripMenuItemTBTDisplayGrLevel.Click += this.toolStripMenuItemTBTDisplayGrLevel_Click;
			this.toolMenuItemTextBranchDel.Name = "toolMenuItemTextBranchDel";
			this.toolMenuItemTextBranchDel.Size = new Size(242, 22);
			this.toolMenuItemTextBranchDel.Text = "Убрать текст";
			this.toolMenuItemTextBranchDel.Click += this.toolMenuItemTextBranchDel_Click;
			this.WcgruJuvXg.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.WcgruJuvXg.Name = "toolMenuItemTextBranchProperty";
			this.WcgruJuvXg.Size = new Size(242, 22);
			this.WcgruJuvXg.Text = "Свойства текста";
			this.WcgruJuvXg.Click += this.WcgruJuvXg_Click;
			this.AllowDrop = true;
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBoxSearch);
			base.Controls.Add(this.tbPopup);
			base.Controls.Add(this.buttonCheck);
			base.Controls.Add(this.bigBoldButton);
			base.Controls.Add(this.propertyGrid1);
			base.Controls.Add(this.statusStrip);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.Name = "CanvasControl";
			base.Size = new Size(754, 494);
			base.Load += this.CanvasControl_Load;
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			((ISupportInitialize)this.class22_0).EndInit();
			this.contextMenuSelectedObjects.ResumeLayout(false);
			this.contextMenuRectnagle.ResumeLayout(false);
			this.contextMenuShina.ResumeLayout(false);
			this.contextMenuSwitchTool.ResumeLayout(false);
			this.contextMenuLineTool.ResumeLayout(false);
			this.contextMenuCanvas.ResumeLayout(false);
			this.contextMenuLabelTool.ResumeLayout(false);
			this.contextMenuStripWhitePoint.ResumeLayout(false);
			this.contextMenuFrame.ResumeLayout(false);
			this.contextMenuTextBranchTool.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public XmlDocument SaveToXmlDocument()
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml("<canvas></canvas>");
			XmlNode xmlNode = xmlDocument.SelectSingleNode("canvas");
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				((DrawingLayer)canvasLayer).method_0(xmlNode);
			}
			return xmlDocument;
		}

		public void SaveToFile(string fileName)
		{
			this.SaveToXmlDocument().Save(fileName);
		}

		public void LoadFile(string fileName)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(fileName);
			this.LoadSchemeFromXML(xmlDocument, false);
		}

		public void SaveCurrentXmlDocument()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			sqlDataCommand.SelectSqlData(this.class22_0.tSchm_Schemes, true, "where [Name]='" + this.string_1 + "'", null, false, 0);
			if (this.class22_0.tSchm_Schemes.Rows.Count == 0)
			{
				DataRow dataRow = this.class22_0.tSchm_Schemes.NewRow();
				dataRow["Name"] = this.string_1;
				dataRow["SchmDataXml"] = this.xmlDocument_0.InnerXml;
				this.class22_0.tSchm_Schemes.Rows.Add(dataRow);
				sqlDataCommand.InsertSqlDataOneRow(this.class22_0.tSchm_Schemes);
				return;
			}
			this.class22_0.tSchm_Schemes.Rows[0]["SchmDataXml"] = this.xmlDocument_0.InnerXml;
			this.class22_0.tSchm_Schemes.Rows[0].EndEdit();
			sqlDataCommand.UpdateSqlData(this.class22_0, this.class22_0.tSchm_Schemes);
		}

		public void SaveToBase()
		{
			XmlDocument xmlDocument = this.SaveToXmlDocument();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			sqlDataCommand.SelectSqlData(this.class22_0.tSchm_Schemes, true, "where [Name]='" + this.string_1 + "'", null, false, 0);
			if (this.class22_0.tSchm_Schemes.Rows.Count == 0)
			{
				DataRow dataRow = this.class22_0.tSchm_Schemes.NewRow();
				dataRow["Name"] = this.string_1;
				dataRow["SchmDataXml"] = xmlDocument.InnerXml;
				this.class22_0.tSchm_Schemes.Rows.Add(dataRow);
				sqlDataCommand.InsertSqlDataOneRow(this.class22_0.tSchm_Schemes);
				return;
			}
			this.class22_0.tSchm_Schemes.Rows[0]["SchmDataXml"] = xmlDocument.InnerXml;
			this.class22_0.tSchm_Schemes.Rows[0].EndEdit();
			sqlDataCommand.UpdateSqlData(this.class22_0, this.class22_0.tSchm_Schemes);
		}

		public void LoadScheme()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			eTypeCanvas typeCanvas = this.TypeCanvas;
			if (typeCanvas == eTypeCanvas.SchemeMain)
			{
				sqlDataCommand.SelectSqlData(this.class22_0.vSchm_ObjListXml, false, " where TypeSchema = " + 1 + " and [Deleted] = 0 ", null, false, 0);
				this.SendMessage("Объектов в базе: " + this.class22_0.vSchm_ObjListXml.Rows.Count.ToString(), eMessageType.Information);
				sqlDataCommand.SelectSqlData(this.class22_0.tSchm_Label, true, "where Tag is null", null, false, 0);
				this.SendMessage("Надписей в базе: " + this.class22_0.tSchm_Label.Rows.Count.ToString(), eMessageType.Information);
				sqlDataCommand.SelectSqlData(this.class22_0.tSchm_Relation, true, "", null, false, 0);
				this.SendMessage("Связей в базе: " + this.class22_0.tSchm_Relation.Rows.Count.ToString(), eMessageType.Information);
				sqlDataCommand.SelectSqlData(this.class22_0.vSchm_CabSection, true, " where deleted = 0 ", null, false, 0);
				sqlDataCommand.SelectSqlData(this.class22_0.tSchm_ObjList, false, " where [TypeCodeId] = 940 and [Deleted] = 0 ", null, false, 0);
				sqlDataCommand.SelectSqlData(this.class22_0.vP_PassportDataReports, true, "where typecodeid in (538,535,537,536) and [CharName] like 'Принадлежность' and [CharValue] like 'Абонентская'", null, false, 0);
				this.method_71();
				this.class22_0.vSchm_ObjListXml.Clear();
				this.class22_0.tSchm_Label.Clear();
				this.class22_0.tSchm_Relation.Clear();
				this.class22_0.vSchm_CabSection.Clear();
				this.class22_0.tSchm_ObjList.Clear();
				this.class22_0.vP_PassportDataReports.Clear();
			}
		}

		public void LoadSchemeAll()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			sqlDataCommand.SelectSqlData(this.class22_0.vSchm_ObjListXml, false, " where TypeSchema = " + 1 + " and [Deleted] = 0 union all select *  from vSChm_ObjListXml s2 where s2.typeSchema = 2 and s2.id not in (select id from vSchm_ObjListxml where typeSchema = 1) and deleted = 0", null, false, 0);
			this.SendMessage("Объектов в базе: " + this.class22_0.vSchm_ObjListXml.Rows.Count.ToString(), eMessageType.Information);
			sqlDataCommand.SelectSqlData(this.class22_0.tSchm_Relation, true, "", null, false, 0);
			this.SendMessage("Связей в базе: " + this.class22_0.tSchm_Relation.Rows.Count.ToString(), eMessageType.Information);
			this.method_71();
			this.class22_0.vSchm_ObjListXml.Clear();
			this.class22_0.tSchm_Label.Clear();
			this.class22_0.tSchm_Relation.Clear();
			this.class22_0.vSchm_CabSection.Clear();
			this.class22_0.tSchm_ObjList.Clear();
		}

		public void LoadScheme(RectangleTool subStation)
		{
			int idBase = subStation.IdBase;
			new SqlDataCommand(this.sqlsettings_0).SelectSqlData(this.class22_0.tSchm_ObjList, false, " where id = " + idBase.ToString(), null, false, 0);
			if (this.class22_0.tSchm_ObjList.Rows.Count == 0)
			{
				return;
			}
			bool flag = false;
			foreach (object obj2 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.eTypeRectangleTool)))
			{
				SchemeCtrl2.DrawTool.eTypeRectangleTool eTypeRectangleTool = (SchemeCtrl2.DrawTool.eTypeRectangleTool)obj2;
				if ((int)this.class22_0.tSchm_ObjList.Rows[0]["TypeCodeId"] == (int)eTypeRectangleTool)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				return;
			}
			this.method_69(idBase);
			this.IdRect = idBase;
			this.method_70();
			using (IEnumerator<DrawObjectBase> enumerator2 = this.icanvasLayer_0.Objects.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					DrawObjectBase l = enumerator2.Current;
					l.GetType();
					typeof(ShinaTool);
					if (l.IdBase == subStation.IdBase)
					{
						l.Master = subStation;
					}
					if (l.LimitedEditing)
					{
						IEnumerable<DrawObjectBase> source = from obj in subStation.Layer.Objects
						where obj.IdBase == l.IdBase
						select obj;
						if (source.Count<DrawObjectBase>() > 0)
						{
							l.Master = source.First<DrawObjectBase>();
							if (l is ObjectOnLine && ((ObjectOnLine)l.Master).ComplexSwitchgear != null)
							{
								ComplexSwitchgearTool complexSwitchgear = ((ObjectOnLine)l.Master).ComplexSwitchgear;
								if (((ObjectOnLine)l).ComplexSwitchgear == null)
								{
									((ObjectOnLine)l).SetComplexSwitchgear();
								}
								((ObjectOnLine)l).ComplexSwitchgear.RollingOutReason = complexSwitchgear.RollingOutReason;
							}
						}
						if (l.Master == null)
						{
							l.LimitedEditing = false;
						}
					}
				}
			}
		}

		public int IdRect { get; set; }

		private void method_68(int int_9, List<DrawObjectBase> list_9)
		{
			if (this.icanvasLayer_0 != null)
			{
				if (this.TypeCanvas == eTypeCanvas.SchemeMain)
				{
					SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
					Class22 @class = new Class22();
					IEnumerable<DrawObjectBase> enumerable = from obj in this.icanvasLayer_0.Objects
					where obj.IdBase == int_9 || (obj.Parent != null && obj.Parent.IdBase == int_9)
					select obj;
					StringBuilder stringBuilder = new StringBuilder();
					foreach (DrawObjectBase drawObjectBase in enumerable)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append(", ");
						}
						stringBuilder.Append(drawObjectBase.IdBase);
					}
					string text = "Tag = " + int_9.ToString() + " and deleted = 0";
					if (stringBuilder.Length > 0)
					{
						text = text + " and id not in (" + stringBuilder.ToString() + ")";
					}
					sqlDataCommand.SelectSqlData(@class.vSchm_ObjListXml, false, " where " + text, null, false, 0);
					DataRow[] array = @class.vSchm_ObjListXml.Select(string.Concat(new string[]
					{
						" typecodeId in (",
						676.ToString(),
						",",
						675.ToString(),
						",",
						678.ToString(),
						",",
						679.ToString(),
						",",
						547.ToString(),
						",",
						983.ToString(),
						",",
						546.ToString(),
						",",
						548.ToString(),
						")"
					}));
					if (array.Length != 0)
					{
						text = "";
						foreach (DataRow dataRow in array)
						{
							if (text.Length > 0)
							{
								text += ",";
							}
							text += dataRow["id"].ToString();
						}
						sqlDataCommand.SelectSqlData(@class.tSchm_Relation, false, " where Edge in (" + text + ")", null, false, 0);
					}
					foreach (DataRow dataRow2 in @class.vSchm_ObjListXml.Select(string.Concat(new string[]
					{
						" typecodeId in (",
						536.ToString(),
						",",
						535.ToString(),
						",",
						537.ToString(),
						",",
						538.ToString(),
						",",
						1034.ToString(),
						",",
						1275.ToString(),
						")"
					})))
					{
						RectangleTool rectangleTool = new RectangleTool();
						list_9.Add(rectangleTool);
						rectangleTool.IdBase = Convert.ToInt32(dataRow2["id"]);
						rectangleTool.Text = dataRow2["name"].ToString();
						rectangleTool.TypeRectnagleTool = (SchemeCtrl2.DrawTool.eTypeRectangleTool)Convert.ToInt32(dataRow2["typecodeId"]);
					}
					DataRow[] array3 = @class.vSchm_ObjListXml.Select(string.Concat(new string[]
					{
						" typecodeId in (",
						563.ToString(),
						",",
						540.ToString(),
						",",
						564.ToString(),
						",",
						541.ToString(),
						")"
					}));
					text = "";
					DataRow[] array2 = array3;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow r = array2[i];
						ShinaTool shinaTool = new ShinaTool();
						list_9.Add(shinaTool);
						shinaTool.IdBase = Convert.ToInt32(r["id"]);
						shinaTool.Text = r["name"].ToString();
						shinaTool.TypeShinaTool = (SchemeCtrl2.DrawTool.eTypeShinaTool)Convert.ToInt32(r["typecodeId"]);
						shinaTool.Parent = enumerable.First((DrawObjectBase obj) => obj.IdBase == Convert.ToInt32(r["idParent"]));
						if (shinaTool.Parent == null)
						{
							shinaTool.Parent = list_9.First((DrawObjectBase obj) => obj.IdBase == Convert.ToInt32(r["idParent"]));
						}
						if (text.Length > 0)
						{
							text += ",";
						}
						text += r["id"].ToString();
					}
					foreach (DrawObjectBase drawObjectBase2 in from obj in enumerable
					where obj.GetType() == typeof(ShinaTool)
					select obj)
					{
						if (text.Length > 0)
						{
							text += ",";
						}
						text += drawObjectBase2.IdBase.ToString();
					}
					array2 = @class.vSchm_ObjListXml.Select(" idParent in (" + text + ")");
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow r = array2[i];
						PointShinaTool pointShinaTool = new PointShinaTool();
						list_9.Add(pointShinaTool);
						pointShinaTool.IdBase = Convert.ToInt32(r["id"]);
						pointShinaTool.Text = r["name"].ToString();
						pointShinaTool.Parent = enumerable.First((DrawObjectBase obj) => obj.IdBase == Convert.ToInt32(r["idParent"]));
						if (pointShinaTool.Parent == null)
						{
							pointShinaTool.Parent = list_9.First((DrawObjectBase obj) => obj.IdBase == Convert.ToInt32(r["idParent"]));
						}
					}
					return;
				}
			}
		}

		private void method_69(int int_9)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			sqlDataCommand.SelectSqlData(this.class22_0.tSchm_Label, true, "where Tag = " + int_9.ToString(), null, false, 0);
			sqlDataCommand.SelectSqlData(this.class22_0.vSchm_ObjListXml, false, string.Concat(new string[]
			{
				" where (id = ",
				int_9.ToString(),
				" or idParent = ",
				int_9.ToString(),
				" or Tag = ",
				int_9.ToString(),
				") and deleted = 0"
			}), null, false, 0);
			DataRow[] array = this.class22_0.vSchm_ObjListXml.Select(string.Concat(new string[]
			{
				" typecodeId in (",
				676.ToString(),
				",",
				675.ToString(),
				",",
				678.ToString(),
				",",
				679.ToString(),
				")"
			}));
			if (array.Length != 0)
			{
				string text = "";
				foreach (DataRow dataRow in array)
				{
					text = text + dataRow["id"].ToString() + ",";
				}
				text = text.Remove(text.Length - 1);
				sqlDataCommand.SelectSqlData(this.class22_0.tSchm_Relation, false, " where Edge in (" + text + ")", null, false, 0);
				if (this.class22_0.tSchm_Relation.Rows.Count > 0)
				{
					string text2 = "";
					foreach (object obj in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.TypeSwitch)))
					{
						SchemeCtrl2.DrawTool.TypeSwitch typeSwitch = (SchemeCtrl2.DrawTool.TypeSwitch)obj;
						string str = text2;
						int i = (int)typeSwitch;
						text2 = str + i.ToString() + ",";
					}
					text2 = text2.Remove(text2.Length - 1);
					text = "";
					string text3 = "";
					foreach (object obj2 in this.class22_0.tSchm_Relation.Rows)
					{
						DataRow dataRow2 = (DataRow)obj2;
						text = text + dataRow2["id"].ToString() + ",";
						text3 = string.Concat(new string[]
						{
							text3,
							dataRow2["SourceObj"].ToString(),
							",",
							dataRow2["DestObj"].ToString(),
							","
						});
					}
					text = text.Remove(text.Length - 1);
					text3 = text3.Remove(text3.Length - 1);
					Class22 @class = new Class22();
					DataRow[] array3 = this.class22_0.vSchm_ObjListXml.Select(string.Concat(new string[]
					{
						" typecodeId in (",
						547.ToString(),
						",",
						546.ToString(),
						",",
						548.ToString(),
						",",
						983.ToString(),
						")"
					}));
					string text4 = "";
					foreach (DataRow dataRow3 in array3)
					{
						text4 = text4 + dataRow3["id"].ToString() + ",";
					}
					if (text4.Length > 0)
					{
						text4 = text4.Remove(text4.Length - 1);
						sqlDataCommand.SelectSqlData(@class.tSchm_Relation, false, " where Edge in (" + text4 + ")", null, false, 0);
						sqlDataCommand.SelectSqlData(this.class22_0.vSchm_CabSection, true, " where deleted = 0 and idObjList in (" + text4 + ")", null, false, 0);
						text4 = string.Empty;
					}
					string text5 = string.Empty;
					foreach (object obj3 in @class.tSchm_Relation.Rows)
					{
						DataRow dataRow4 = (DataRow)obj3;
						this.class22_0.tSchm_Relation.ImportRow(dataRow4);
						text4 = text4 + dataRow4["id"].ToString() + ",";
						text5 = string.Concat(new string[]
						{
							text5,
							dataRow4["SourceObj"].ToString(),
							",",
							dataRow4["DestObj"].ToString(),
							","
						});
					}
					if (text4.Length > 0)
					{
						text4 = text4.Remove(text4.Length - 1);
						text = text + "," + text4;
					}
					sqlDataCommand.SelectSqlData(@class.tSchm_Relation, false, string.Concat(new string[]
					{
						" where id not in (",
						text,
						") and (SourceObj in (",
						text3,
						") or DestObj in (",
						text3,
						"))"
					}), null, false, 0);
					text += ",";
					text4 = "";
					foreach (object obj4 in @class.tSchm_Relation.Rows)
					{
						DataRow dataRow5 = (DataRow)obj4;
						text = text + dataRow5["id"].ToString() + ",";
						text5 = string.Concat(new string[]
						{
							text5,
							dataRow5["SourceObj"].ToString(),
							",",
							dataRow5["DestObj"].ToString(),
							","
						});
						text4 = text4 + dataRow5["Edge"].ToString() + ",";
						this.class22_0.tSchm_Relation.ImportRow(dataRow5);
					}
					text = text.Remove(text.Length - 1);
					if (text5.Length > 0)
					{
						text5 = text5.Remove(text5.Length - 1);
					}
					if (text4.Length > 0)
					{
						text4 = text4.Remove(text4.Length - 1);
						sqlDataCommand.SelectSqlData(@class.vSchm_ObjListXml, false, " where Id in (" + text4 + ") and Tag is NULL and deleted = 0 ", null, false, 0);
						foreach (object obj5 in @class.vSchm_ObjListXml.Rows)
						{
							DataRow row = (DataRow)obj5;
							this.class22_0.vSchm_ObjListXml.ImportRow(row);
						}
						sqlDataCommand.SelectSqlData(@class.tSchm_Relation, false, string.Concat(new string[]
						{
							" where Edge in (",
							text4,
							") and id not in(",
							text,
							") "
						}), null, false, 0);
						text5 += ",";
						text += ",";
						foreach (object obj6 in @class.tSchm_Relation.Rows)
						{
							DataRow dataRow6 = (DataRow)obj6;
							this.class22_0.tSchm_Relation.ImportRow(dataRow6);
							text = text + dataRow6["id"].ToString() + ",";
							text5 = string.Concat(new string[]
							{
								text5,
								dataRow6["SourceObj"].ToString(),
								",",
								dataRow6["DestObj"].ToString(),
								","
							});
						}
						text = text.Remove(text.Length - 1);
						text5 = text5.Remove(text5.Length - 1);
					}
					if (text5 != string.Empty)
					{
						text3 = text3 + "," + text5;
					}
					sqlDataCommand.SelectSqlData(@class.vSchm_ObjListXml, false, string.Concat(new string[]
					{
						" where idParent in (",
						text,
						") and typecodeId in (",
						text2,
						") and typeSchema is not null and deleted = 0 "
					}), null, false, 0);
					for (int j = 0; j < @class.vSchm_ObjListXml.Rows.Count; j++)
					{
						DataRow dataRow7 = @class.vSchm_ObjListXml.Rows[j];
						if (Convert.ToInt32(dataRow7["TypeSchema"]) == 1 && @class.vSchm_ObjListXml.Select(" id  = " + dataRow7["id"].ToString() + " and TypeSchema = " + 2.ToString()).Length != 0)
						{
							@class.vSchm_ObjListXml.Rows.Remove(dataRow7);
							j--;
						}
					}
					foreach (object obj7 in @class.vSchm_ObjListXml.Rows)
					{
						DataRow row2 = (DataRow)obj7;
						this.class22_0.vSchm_ObjListXml.ImportRow(row2);
					}
					sqlDataCommand.SelectSqlData(@class.vSchm_ObjListXml, false, string.Concat(new object[]
					{
						" where id in (",
						text3,
						") and deleted = 0 and (Tag = ",
						int_9,
						" or Tag is NULL)"
					}), null, false, 0);
					foreach (object obj8 in @class.vSchm_ObjListXml.Rows)
					{
						DataRow row3 = (DataRow)obj8;
						this.class22_0.vSchm_ObjListXml.ImportRow(row3);
					}
				}
			}
		}

		private void method_70()
		{
			bool flag = false;
			this.loadedPoints.Clear();
			this.list_0.Clear();
			this.dictionary_0.Clear();
			DrawingLayer drawingLayer = new DrawingLayer("SchemaSecond", "SchemaSecond", Color.White, 0f);
			drawingLayer.Parent = this;
			this.AddLayer(drawingLayer);
			this.ActiveLayer = drawingLayer;
			int[] array = new int[]
			{
				556
			};
			DataTable journalData = PassportData.GetJournalData(this.sqlsettings_0, array);
			array = new int[]
			{
				546
			};
			DataTable journalData2 = PassportData.GetJournalData(this.sqlsettings_0, array);
			new XmlDocument();
			string text = "";
			foreach (object obj6 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.eTypeRectangleTool)))
			{
				SchemeCtrl2.DrawTool.eTypeRectangleTool eTypeRectangleTool = (SchemeCtrl2.DrawTool.eTypeRectangleTool)obj6;
				text = text + Convert.ToInt32(eTypeRectangleTool).ToString() + ",";
			}
			text = text.Remove(text.Length - 1);
			IEnumerable<DataRow> enumerable = this.class22_0.vSchm_ObjListXml.Select(string.Concat(new object[]
			{
				"TypeCodeId in (",
				text,
				") and typeSchema = ",
				(int)this.TypeCanvas
			}));
			RectangleTool rectangleTool;
			if (enumerable.Count<DataRow>() == 0)
			{
				enumerable = this.class22_0.vSchm_ObjListXml.Select(string.Concat(new object[]
				{
					"TypeCodeId in (",
					text,
					") and typeSchema = ",
					1
				}));
				rectangleTool = new RectangleTool(enumerable.First<DataRow>(), drawingLayer);
				rectangleTool.Rectangle = new RectangleF(-1000000f, -1000000f, 2000000f, 2000000f);
				rectangleTool.Visible = false;
				flag = true;
				rectangleTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
			}
			else
			{
				rectangleTool = new RectangleTool(enumerable.Where(new Func<DataRow, bool>(this.method_96)).First<DataRow>(), drawingLayer);
				foreach (DataRow dataRow in enumerable)
				{
					if (Convert.ToInt32(dataRow["Id"]) != this.IdRect)
					{
						new RectangleTool(dataRow, drawingLayer).EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
					}
				}
			}
			rectangleTool.DrawNewObjectEvent += this.drawObjectBase_0_DrawNewObjectEvent;
			UnitPoint right = UnitPoint.Empty;
			text = "";
			foreach (object obj2 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.eTypeShinaTool)))
			{
				SchemeCtrl2.DrawTool.eTypeShinaTool eTypeShinaTool = (SchemeCtrl2.DrawTool.eTypeShinaTool)obj2;
				text = text + Convert.ToInt32(eTypeShinaTool).ToString() + ",";
			}
			text = text.Remove(text.Length - 1);
			IEnumerable<DataRow> enumerable2 = this.class22_0.vSchm_ObjListXml.Select("TypeCodeId in (" + text + ")");
			using (IEnumerator<DataRow> enumerator2 = enumerable2.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					DataRow r = enumerator2.Current;
					if (!r.IsNull("TypeSchema"))
					{
						if (Convert.ToInt32(r["TypeSchema"]) == 1)
						{
							DataRow dataRow2 = null;
							try
							{
								dataRow2 = enumerable2.First((DataRow obj) => Convert.ToInt32(obj["TypeSchema"]) == 2 && Convert.ToInt32(obj["Id"]) == Convert.ToInt32(r["Id"]));
							}
							catch
							{
							}
							if (dataRow2 == null)
							{
								ShinaTool shinaTool = new ShinaTool(r, drawingLayer);
								if (right.IsEmpty)
								{
									right = new UnitPoint(0.0, 0.0) - shinaTool.P1;
								}
								shinaTool.P1 += right;
								shinaTool.P2 += right;
								shinaTool.Parent = rectangleTool;
								shinaTool.LimitedEditing = true;
								drawingLayer.AddObject(shinaTool);
								shinaTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
								DataRow[] array2 = this.class22_0.vSchm_ObjListXml.Select(string.Concat(new object[]
								{
									" IdParent = ",
									shinaTool.IdBase.ToString(),
									" and typeCodeId = ",
									111.ToString(),
									" and TypeSchema = ",
									1
								}));
								for (int i = 0; i < array2.Length; i++)
								{
									PointShinaTool pointShinaTool = new PointShinaTool(array2[i]);
									if (!right.IsEmpty)
									{
										pointShinaTool.Point += right;
									}
									pointShinaTool.Layer = drawingLayer;
									shinaTool.AddPointShinaTool(pointShinaTool);
									this.loadedPoints.Add(pointShinaTool.IdBase, pointShinaTool);
								}
								flag = true;
							}
						}
						else
						{
							try
							{
								enumerable2.First((DataRow obj) => Convert.ToInt32(obj["TypeSchema"]) == 1 && Convert.ToInt32(obj["Id"]) == Convert.ToInt32(r["Id"]));
							}
							catch
							{
							}
							ShinaTool shinaTool2 = new ShinaTool(r, drawingLayer);
							shinaTool2.Parent = (from obj in drawingLayer.Objects
							where obj.IdBase == Convert.ToInt32(r["IdParent"])
							select obj).First<DrawObjectBase>();
							foreach (DrawObjectBase drawobject in shinaTool2.splitters)
							{
								drawingLayer.AddObject(drawobject);
							}
							shinaTool2.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
							DataRow[] array3 = this.class22_0.vSchm_ObjListXml.Select(" IdParent = " + shinaTool2.IdBase.ToString() + " and typeCodeId = " + 111.ToString());
							Dictionary<int, DataRow> dictionary = new Dictionary<int, DataRow>();
							foreach (DataRow dataRow3 in array3)
							{
								if (!dictionary.ContainsKey((int)dataRow3["Id"]))
								{
									dictionary.Add((int)dataRow3["Id"], dataRow3);
								}
								else if ((int)dataRow3["TypeSchema"] == (int)this.TypeCanvas)
								{
									dictionary[(int)dataRow3["Id"]] = dataRow3;
								}
							}
							foreach (DataRow dataRow4 in dictionary.Values)
							{
								if ((int)dataRow4["TypeSchema"] == (int)this.TypeCanvas)
								{
									PointShinaTool pointShinaTool2 = new PointShinaTool(dataRow4);
									pointShinaTool2.Layer = drawingLayer;
									shinaTool2.AddPointShinaTool(pointShinaTool2);
									this.loadedPoints.Add(pointShinaTool2.IdBase, pointShinaTool2);
								}
								else
								{
									PointShinaTool pointShinaTool3 = new PointShinaTool(dataRow4);
									if (!right.IsEmpty)
									{
										pointShinaTool3.Point += right;
									}
									pointShinaTool3.Layer = drawingLayer;
									shinaTool2.AddPointShinaTool(pointShinaTool3);
									this.loadedPoints.Add(pointShinaTool3.IdBase, pointShinaTool3);
								}
							}
						}
					}
				}
			}
			text = "";
			foreach (object obj3 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.LineToolType)))
			{
				SchemeCtrl2.DrawTool.LineToolType lineToolType = (SchemeCtrl2.DrawTool.LineToolType)obj3;
				if (lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_10 || lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_6 || lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_04 || lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_023)
				{
					text = text + Convert.ToInt32(lineToolType).ToString() + ",";
				}
			}
			text = text.Remove(text.Length - 1);
			IEnumerable<DataRow> enumerable3 = this.class22_0.vSchm_ObjListXml.Select("  TypeCodeId in (" + text + ")");
			using (IEnumerator<DataRow> enumerator2 = enumerable3.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					DataRow r = enumerator2.Current;
					if (!r.IsNull("TypeSchema"))
					{
						if (!r.IsNull("TypeSchema") && Convert.ToInt32(r["TypeSchema"]) == 1)
						{
							DataRow dataRow5 = null;
							try
							{
								dataRow5 = enumerable3.First((DataRow obj) => Convert.ToInt32(obj["TypeSchema"]) == 2 && Convert.ToInt32(obj["Id"]) == Convert.ToInt32(r["Id"]));
							}
							catch
							{
							}
							if (dataRow5 == null)
							{
								LineCellTool lineCellTool = new LineCellTool(r, drawingLayer);
								lineCellTool.LimitedEditing = true;
								if (!right.IsEmpty)
								{
									foreach (PointTool pointTool in lineCellTool.GetPointsList())
									{
										if (pointTool.GetType() != typeof(PointShinaTool))
										{
											if (pointTool.IdBase > 0)
											{
												if (drawingLayer.Parent.class22_0.vSchm_ObjListXml.Select(string.Concat(new object[]
												{
													"Id = ",
													pointTool.IdBase,
													" and typeSChema = ",
													((int)drawingLayer.Parent.TypeCanvas).ToString()
												})).Length == 0)
												{
													pointTool.Point += right;
												}
											}
											else
											{
												pointTool.Point += right;
											}
										}
									}
								}
								foreach (Branch branch in lineCellTool.Branches)
								{
									foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
									{
										if (drawObjectBase.GetType() == typeof(TransformerTool))
										{
											TransformerTool transformerTool = (TransformerTool)drawObjectBase;
											DataRow[] array4 = journalData.Select("id = " + transformerTool.IdBase.ToString() + " and IdPassport is not null");
											if (array4.Length != 0)
											{
												transformerTool.passportDataRow = array4[0];
											}
										}
									}
								}
								try
								{
									lineCellTool.Parent = (from obj in drawingLayer.Objects
									where obj.IdBase == Convert.ToInt32(r["IdParent"])
									select obj).First<DrawObjectBase>();
								}
								catch
								{
									continue;
								}
								lineCellTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
								flag = true;
							}
						}
						else if (!r.IsNull("TypeSchema"))
						{
							LineCellTool lineCellTool2 = new LineCellTool(r, drawingLayer);
							foreach (CouplingRelation couplingRelation in lineCellTool2.CouplingRelations)
							{
								if (couplingRelation.method_3().Count != 0)
								{
									string text2 = string.Empty;
									foreach (SchemeCtrl2.DrawTool.TypeSwitch typeSwitch in (SchemeCtrl2.DrawTool.TypeSwitch[])Enum.GetValues(typeof(SchemeCtrl2.DrawTool.TypeSwitch)))
									{
										if (text2 != string.Empty)
										{
											text2 += ", ";
										}
										string str = text2;
										int num = (int)typeSwitch;
										text2 = str + num.ToString();
									}
									DataRow[] array2 = drawingLayer.Parent.class22_0.vSchm_ObjListXml.Select(string.Concat(new object[]
									{
										"IdParent = ",
										couplingRelation.Id,
										" and TypeCodeId in (",
										text2,
										")"
									}));
									for (int i = 0; i < array2.Length; i++)
									{
										DataRow dr = array2[i];
										if ((from obj in drawingLayer.Objects
										where obj.IdBase == (int)dr["Id"]
										select obj).Count<DrawObjectBase>() <= 0)
										{
											ObjectOnLine objectOnLine = ObjectOnLine.CreateObjectOnLine((SchemeCtrl2.DrawTool.TypeSwitch)Convert.ToInt32(dr["TypeCodeId"]), dr, couplingRelation.method_3()[0]);
											objectOnLine.LimitedEditing = lineCellTool2.LimitedEditing;
											drawingLayer.AddObject(objectOnLine);
										}
									}
								}
							}
							foreach (Branch branch2 in lineCellTool2.Branches)
							{
								foreach (DrawObjectBase drawObjectBase2 in branch2.ChildObjects)
								{
									if (drawObjectBase2.GetType() == typeof(TransformerTool))
									{
										TransformerTool transformerTool2 = (TransformerTool)drawObjectBase2;
										DataRow[] array6 = journalData.Select("id = " + transformerTool2.IdBase.ToString() + " and IdPassport is not null");
										if (array6.Length != 0)
										{
											transformerTool2.passportDataRow = array6[0];
										}
									}
								}
							}
							try
							{
								lineCellTool2.Parent = (from obj in drawingLayer.Objects
								where obj.IdBase == Convert.ToInt32(r["IdParent"])
								select obj).First<DrawObjectBase>();
							}
							catch
							{
								continue;
							}
							lineCellTool2.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						}
					}
				}
			}
			text = "";
			foreach (object obj4 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.LineToolType)))
			{
				SchemeCtrl2.DrawTool.LineToolType lineToolType2 = (SchemeCtrl2.DrawTool.LineToolType)obj4;
				if (lineToolType2 == SchemeCtrl2.DrawTool.LineToolType.AirLine || lineToolType2 == SchemeCtrl2.DrawTool.LineToolType.CabelLine || lineToolType2 == SchemeCtrl2.DrawTool.LineToolType.MixedLine || lineToolType2 == SchemeCtrl2.DrawTool.LineToolType.AirLineProtected)
				{
					text = text + Convert.ToInt32(lineToolType2).ToString() + ",";
				}
			}
			text = text.Remove(text.Length - 1);
			using (IEnumerator<DataRow> enumerator2 = ((IEnumerable<DataRow>)this.class22_0.vSchm_ObjListXml.Select("  TypeCodeId in (" + text + ")")).GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					DataRow r = enumerator2.Current;
					if (!r.IsNull("TypeSchema") && Convert.ToInt32(r["TypeSchema"]) == 1)
					{
						DataRow dataRow6 = null;
						try
						{
							dataRow6 = enumerable3.First((DataRow obj) => Convert.ToInt32(obj["TypeSchema"]) == 2 && Convert.ToInt32(obj["Id"]) == Convert.ToInt32(r["Id"]));
							goto IL_1B2C;
						}
						catch
						{
							goto IL_1B2C;
						}
						IL_EB6:
						LineTool lineTool = new LineTool();
						lineTool.IdBase = (int)r["id"];
						lineTool.Text = r["Name"].ToString();
						drawingLayer.AddObject(lineTool);
						DataRow[] array7 = drawingLayer.Parent.class22_0.tSchm_Relation.Select("Edge = " + lineTool.IdBase.ToString());
						CouplingRelation couplingRelation2 = null;
						DataRow[] array2 = array7;
						int i = 0;
						while (i < array2.Length)
						{
							DataRow dataRow7 = array2[i];
							if (this.loadedPoints.ContainsKey((int)dataRow7["SourceObj"]))
							{
								goto IL_FE4;
							}
							DataRow[] array8 = drawingLayer.Parent.class22_0.vSchm_ObjListXml.Select("Id = " + Convert.ToInt32(dataRow7["SourceObj"]));
							if (array8.Length != 0)
							{
								PointTool pointTool2 = new PointTool();
								pointTool2.IdBase = Convert.ToInt32(array8[0]["id"]);
								pointTool2.Layer = drawingLayer;
								drawingLayer.Parent.loadedPoints.Add(pointTool2.IdBase, pointTool2);
								goto IL_FE4;
							}
							IL_1123:
							i++;
							continue;
							IL_FE4:
							if (!this.loadedPoints.ContainsKey((int)dataRow7["DestObj"]))
							{
								DataRow[] array9 = drawingLayer.Parent.class22_0.vSchm_ObjListXml.Select("Id = " + Convert.ToInt32(dataRow7["DestObj"]));
								if (array9.Length == 0)
								{
									goto IL_1123;
								}
								PointTool pointTool3 = new PointTool();
								pointTool3.IdBase = Convert.ToInt32(array9[0]["id"]);
								pointTool3.Layer = drawingLayer;
								drawingLayer.Parent.loadedPoints.Add(pointTool3.IdBase, pointTool3);
							}
							PointTool pointTool4 = this.loadedPoints[(int)dataRow7["SourceObj"]];
							PointTool pointTool5 = this.loadedPoints[(int)dataRow7["DestObj"]];
							bool flag2 = pointTool4.Branches.Count<Branch>() > 0 || pointTool5.Branches.Count<Branch>() > 0;
							CouplingRelation couplingRelation3 = new CouplingRelation(pointTool4, pointTool5);
							if (flag2)
							{
								couplingRelation2 = couplingRelation3;
							}
							couplingRelation3.Id = (int)dataRow7["id"];
							couplingRelation3.Line = lineTool;
							lineTool.CouplingRelations.method_3(couplingRelation3);
							goto IL_1123;
						}
						if (couplingRelation2 != null)
						{
							PointTool pointTool6 = null;
							PointTool pointTool7 = null;
							if (couplingRelation2.method_1().Branches.Count<Branch>() > 0)
							{
								pointTool6 = couplingRelation2.method_1();
								if (couplingRelation2.method_2().Branches.Count<Branch>() > 0)
								{
									pointTool7 = couplingRelation2.method_2();
								}
							}
							else if (couplingRelation2.method_2().Branches.Count<Branch>() > 0)
							{
								pointTool6 = couplingRelation2.method_2();
							}
							if (pointTool6 != null)
							{
								LineTool lineTool2 = (LineTool)pointTool6.Branches.First<Branch>().Parent;
								ShinaTool shinaTool3 = null;
								if (pointTool7 == null)
								{
									pointTool7 = new PointTool();
								}
								foreach (PointTool pointTool8 in lineTool2.Ends)
								{
									if (pointTool8.Parent != null && pointTool8.Parent.GetType() == typeof(ShinaTool))
									{
										shinaTool3 = (ShinaTool)pointTool8.Parent;
									}
								}
								if (shinaTool3 == null)
								{
									pointTool7.Point = new UnitPoint(pointTool6.Point.X, pointTool6.Point.Y + 3.0);
								}
								else if (shinaTool3.P1.X != shinaTool3.P2.X)
								{
									if (shinaTool3.P1.Y < pointTool6.Point.Y)
									{
										pointTool7.Point = new UnitPoint(pointTool6.Point.X, pointTool6.Point.Y + 3.0);
									}
									else
									{
										pointTool7.Point = new UnitPoint(pointTool6.Point.X, pointTool6.Point.Y - 3.0);
									}
								}
								else if (shinaTool3.P1.X < pointTool6.Point.X)
								{
									pointTool7.Point = new UnitPoint(pointTool6.Point.X + 3.0, pointTool6.Point.Y);
								}
								else
								{
									pointTool7.Point = new UnitPoint(pointTool6.Point.X - 3.0, pointTool6.Point.Y);
								}
							}
							Branch branch3 = new Branch(lineTool, pointTool6, pointTool7, BranchType.CabelLine, couplingRelation2);
							lineTool.Branches.Add(branch3);
							branch3.Parent = lineTool;
							lineTool.GetPointsList();
						}
						lineTool.LimitedEditing = true;
						foreach (Branch branch4 in lineTool.Branches)
						{
							foreach (DrawObjectBase drawObjectBase3 in branch4.ChildObjects)
							{
								if (drawObjectBase3.GetType() == typeof(TextBranchTool))
								{
									TextBranchTool textBranchTool = (TextBranchTool)drawObjectBase3;
									IEnumerable<DataRow> enumerable4 = this.class22_0.vSchm_CabSection.Select("idObjList = " + lineTool.IdBase);
									if (enumerable4.Count<DataRow>() > 0)
									{
										decimal d = 0m;
										DataRow dataRow8 = null;
										decimal num2 = 0m;
										string text3 = string.Empty;
										SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
										SqlCommand sqlCommand = new SqlCommand("select top 1 id from tP_Passport where idObjList = " + lineTool.IdBase.ToString(), sqlConnection);
										try
										{
											sqlConnection.Open();
											int num3 = (int)sqlCommand.ExecuteScalar();
											if (num3 > -1)
											{
												sqlCommand.CommandText = "select top 1 Value from tP_ObjectChar where idObjChar = 182 and idPassport = " + num3.ToString();
												text3 = sqlCommand.ExecuteScalar().ToString();
											}
											goto IL_1694;
										}
										catch
										{
											goto IL_1694;
										}
										IEnumerator<DataRow> enumerator10;
										try
										{
											IL_1513:
											while (enumerator10.MoveNext())
											{
												DataRow dataRow9 = enumerator10.Current;
												num2 += Convert.ToDecimal(dataRow9[8]);
												if (dataRow8 == null && Convert.ToDecimal(dataRow9[8]) >= 10m)
												{
													d = Convert.ToDecimal(dataRow9[7]);
													dataRow8 = dataRow9;
												}
												else if (Convert.ToDecimal(dataRow9[7]) < d && Convert.ToDecimal(dataRow9[8]) >= 10m)
												{
													d = Convert.ToDecimal(dataRow9[7]);
													dataRow8 = dataRow9;
												}
											}
										}
										finally
										{
											if (enumerator10 != null)
											{
												enumerator10.Dispose();
											}
										}
										if (dataRow8 != null)
										{
											if (text3 == string.Empty)
											{
												text3 = Math.Round(Convert.ToDecimal(num2), 0).ToString();
											}
											textBranchTool.UpdateSQLFields(dataRow8, text3);
										}
										DataRow[] array10 = journalData2.Select("id = " + lineTool.IdBase.ToString());
										if (array10.Length != 0)
										{
											textBranchTool.passportDataRow = array10[0];
											continue;
										}
										continue;
										IL_1694:
										enumerator10 = enumerable4.GetEnumerator();
										goto IL_1513;
									}
									if (drawObjectBase3.GetType() == typeof(TransformerTool))
									{
										TransformerTool transformerTool3 = (TransformerTool)drawObjectBase3;
										DataRow[] array11 = journalData.Select("id = " + transformerTool3.IdBase.ToString());
										if (array11.Length != 0)
										{
											transformerTool3.passportDataRow = array11[0];
										}
									}
								}
							}
						}
						lineTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						flag = true;
						continue;
						IL_1B2C:
						if (dataRow6 == null)
						{
							goto IL_EB6;
						}
					}
					else if (!r.IsNull("TypeSchema"))
					{
						LineTool lineTool3 = new LineTool(r, drawingLayer);
						foreach (CouplingRelation couplingRelation4 in lineTool3.CouplingRelations)
						{
							if (couplingRelation4.method_3().Count != 0)
							{
								DataRow[] array2 = drawingLayer.Parent.class22_0.vSchm_ObjListXml.Select("IdParent = " + couplingRelation4.Id);
								for (int i = 0; i < array2.Length; i++)
								{
									DataRow dr = array2[i];
									if ((from obj in drawingLayer.Objects
									where obj.IdBase == (int)dr["Id"]
									select obj).Count<DrawObjectBase>() <= 0)
									{
										ObjectOnLine objectOnLine2 = ObjectOnLine.CreateObjectOnLine((SchemeCtrl2.DrawTool.TypeSwitch)Convert.ToInt32(dr["TypeCodeId"]), dr, couplingRelation4.method_3()[0]);
										objectOnLine2.LimitedEditing = lineTool3.LimitedEditing;
										drawingLayer.AddObject(objectOnLine2);
									}
								}
							}
						}
						foreach (Branch branch5 in lineTool3.Branches)
						{
							foreach (DrawObjectBase drawObjectBase4 in branch5.ChildObjects)
							{
								if (drawObjectBase4.GetType() == typeof(TextBranchTool))
								{
									TextBranchTool textBranchTool2 = (TextBranchTool)drawObjectBase4;
									IEnumerable<DataRow> enumerable5 = this.class22_0.vSchm_CabSection.Select("idObjList = " + lineTool3.IdBase);
									if (enumerable5.Count<DataRow>() > 0)
									{
										decimal d2 = 0m;
										DataRow dataRow10 = null;
										decimal num4 = 0m;
										string text4 = string.Empty;
										SqlConnection sqlConnection2 = new SqlConnection(this.SqlSettings.GetConnectionString());
										SqlCommand sqlCommand2 = new SqlCommand("select top 1 id from tP_Passport where idObjList = " + lineTool3.IdBase.ToString(), sqlConnection2);
										try
										{
											sqlConnection2.Open();
											int num5 = (int)sqlCommand2.ExecuteScalar();
											if (num5 > -1)
											{
												sqlCommand2.CommandText = "select top 1 Value from tP_ObjectChar where idObjChar = 182 and idPassport = " + num5.ToString();
												text4 = sqlCommand2.ExecuteScalar().ToString();
											}
											goto IL_1ADC;
										}
										catch
										{
											goto IL_1ADC;
										}
										IEnumerator<DataRow> enumerator10;
										try
										{
											IL_1941:
											while (enumerator10.MoveNext())
											{
												DataRow dataRow11 = enumerator10.Current;
												if (!dataRow11.IsNull(7) && !dataRow11.IsNull(8))
												{
													num4 += Convert.ToDecimal(dataRow11[8]);
													if (dataRow10 == null && Convert.ToDecimal(dataRow11[8]) >= 10m)
													{
														d2 = Convert.ToDecimal(dataRow11[7]);
														dataRow10 = dataRow11;
													}
													else if (Convert.ToDecimal(dataRow11[7]) < d2 && Convert.ToDecimal(dataRow11[8]) >= 10m)
													{
														d2 = Convert.ToDecimal(dataRow11[7]);
														dataRow10 = dataRow11;
													}
												}
											}
										}
										finally
										{
											if (enumerator10 != null)
											{
												enumerator10.Dispose();
											}
										}
										if (dataRow10 != null)
										{
											if (text4 == string.Empty)
											{
												text4 = Math.Round(Convert.ToDecimal(num4), 0).ToString();
											}
											textBranchTool2.UpdateSQLFields(dataRow10, text4);
										}
										DataRow[] array12 = journalData2.Select("id = " + lineTool3.IdBase.ToString());
										if (array12.Length != 0)
										{
											textBranchTool2.passportDataRow = array12[0];
											continue;
										}
										continue;
										IL_1ADC:
										enumerator10 = enumerable5.GetEnumerator();
										goto IL_1941;
									}
								}
								else if (drawObjectBase4.GetType() == typeof(TransformerTool))
								{
									TransformerTool transformerTool4 = (TransformerTool)drawObjectBase4;
									DataRow[] array13 = journalData.Select("id = " + transformerTool4.IdBase.ToString());
									if (array13.Length != 0)
									{
										transformerTool4.passportDataRow = array13[0];
									}
								}
							}
						}
						lineTool3.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
					}
				}
			}
			foreach (object obj5 in this.class22_0.tSchm_Label.Rows)
			{
				DataRow dataRow12 = (DataRow)obj5;
				if (dataRow12["IdParent"] != DBNull.Value && (int)dataRow12["IdParent"] == rectangleTool.IdBase)
				{
					rectangleTool.AddLabelTool(dataRow12);
				}
				else
				{
					LabelTool labelTool = LabelTool.GetLabelTool(dataRow12);
					if (labelTool != null)
					{
						this.AddObject(drawingLayer, labelTool);
					}
					if (dataRow12["IdParent"] != DBNull.Value)
					{
						int labelParentId = (int)dataRow12["IdParent"];
						IEnumerable<DrawObjectBase> source = from o in drawingLayer.Objects
						where o.IdBase == labelParentId
						select o;
						if (source.Count<DrawObjectBase>() > 0)
						{
							labelTool.Parent = source.First<DrawObjectBase>();
							this.AddObject(drawingLayer, labelTool);
						}
					}
				}
			}
			if (!this.Connected)
			{
				if (flag)
				{
					rectangleTool.method_4(false, true);
					foreach (DrawObjectBase drawObjectBase5 in drawingLayer.Objects)
					{
						if (drawObjectBase5.GetType() == typeof(LineTool))
						{
							drawObjectBase5.method_4(false, true);
						}
					}
				}
				foreach (PointTool pointTool9 in from o in this.loadedPoints.Values
				where o.NeedToPreserve > NeedToPreserveEnum.None
				select o)
				{
					NeedToPreserveEnum needToPreserve = pointTool9.NeedToPreserve;
					if (needToPreserve == NeedToPreserveEnum.const_2)
					{
						pointTool9.SaveXmlToSql();
					}
				}
			}
		}

		private void method_71()
		{
			if (this.list_4 != null)
			{
				this.list_4.Clear();
			}
			this.SendMessage("Начало очитски памяти", eMessageType.Information);
			this.loadedPoints.Clear();
			this.loadedPoints = new Dictionary<int, PointTool>();
			this.SendMessage("Почистили точки", eMessageType.Information);
			this.list_0.Clear();
			this.SendMessage("Почистили память", eMessageType.Information);
			this.dictionary_0.Clear();
			DrawingLayer drawingLayer = new DrawingLayer("SchemaMain", "SchemaMain", Color.White, 0f);
			drawingLayer.Parent = this;
			this.AddLayer(drawingLayer);
			this.ActiveLayer = drawingLayer;
			foreach (object obj7 in this.class22_0.tSchm_ObjList.Rows)
			{
				DataRow dataRow = (DataRow)obj7;
				GroupDrawObjectBase groupDrawObjectBase = new GroupDrawObjectBase();
				groupDrawObjectBase.Id = Convert.ToInt32(dataRow["id"]);
				groupDrawObjectBase.Name = dataRow["Name"].ToString();
				this.dictionary_0.Add(groupDrawObjectBase.Id, groupDrawObjectBase);
			}
			DrawingLayer obj2 = drawingLayer;
			lock (obj2)
			{
				new XmlDocument();
				string text = "";
				foreach (object obj3 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.eTypeRectangleTool)))
				{
					SchemeCtrl2.DrawTool.eTypeRectangleTool eTypeRectangleTool = (SchemeCtrl2.DrawTool.eTypeRectangleTool)obj3;
					text = text + Convert.ToInt32(eTypeRectangleTool).ToString() + ",";
				}
				text = text.Remove(text.Length - 1);
				IEnumerable<DataRow> enumerable = this.class22_0.vSchm_ObjListXml.Select("TypeCodeId in (" + text + ")");
				text = "";
				foreach (object obj4 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.eTypeShinaTool)))
				{
					SchemeCtrl2.DrawTool.eTypeShinaTool eTypeShinaTool = (SchemeCtrl2.DrawTool.eTypeShinaTool)obj4;
					text = text + Convert.ToInt32(eTypeShinaTool).ToString() + ",";
				}
				text = text.Remove(text.Length - 1);
				IEnumerable<DataRow> enumerable2 = this.class22_0.vSchm_ObjListXml.Select(" TypeCodeId in (" + text + ")");
				text = "";
				foreach (object obj5 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.LineToolType)))
				{
					SchemeCtrl2.DrawTool.LineToolType lineToolType = (SchemeCtrl2.DrawTool.LineToolType)obj5;
					if (lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_10 || lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_6 || lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_04 || lineToolType == SchemeCtrl2.DrawTool.LineToolType.CellLine_023)
					{
						text = text + Convert.ToInt32(lineToolType).ToString() + ",";
					}
				}
				text = text.Remove(text.Length - 1);
				IEnumerable<DataRow> enumerable3 = this.class22_0.vSchm_ObjListXml.Select("  TypeCodeId in (" + text + ")");
				text = "";
				foreach (object obj6 in Enum.GetValues(typeof(SchemeCtrl2.DrawTool.LineToolType)))
				{
					SchemeCtrl2.DrawTool.LineToolType lineToolType2 = (SchemeCtrl2.DrawTool.LineToolType)obj6;
					if (lineToolType2 != SchemeCtrl2.DrawTool.LineToolType.CellLine_10 && lineToolType2 != SchemeCtrl2.DrawTool.LineToolType.CellLine_6 && lineToolType2 != SchemeCtrl2.DrawTool.LineToolType.CellLine_04 && lineToolType2 != SchemeCtrl2.DrawTool.LineToolType.CellLine_023)
					{
						text = text + Convert.ToInt32(lineToolType2).ToString() + ",";
					}
				}
				text = text.Remove(text.Length - 1);
				IEnumerable<DataRow> enumerable4 = this.class22_0.vSchm_ObjListXml.Select("TypeCodeId in (" + text + ")");
				int[] array = new int[]
				{
					556
				};
				DataTable journalData = PassportData.GetJournalData(this.sqlsettings_0, array);
				array = new int[]
				{
					546
				};
				DataTable journalData2 = PassportData.GetJournalData(this.sqlsettings_0, array);
				DataTable dataTable = new DataTable();
				SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
				SqlCommand sqlCommand = new SqlCommand("select obj.id as id, objChar.Value as lineLength from tSchm_ObjList as obj inner join\r\n                                            tP_Passport on obj.id=tP_Passport.idObjList inner join\r\n                                            tP_ObjectChar as objChar on tP_Passport.id=objChar.idPassport and objChar.idObjChar=182", sqlConnection);
				try
				{
					sqlConnection.Open();
					dataTable.Load(sqlCommand.ExecuteReader());
				}
				catch
				{
				}
				Dictionary<int, DrawObjectBase> dictionary = new Dictionary<int, DrawObjectBase>();
				foreach (DataRow dataRow2 in enumerable)
				{
					try
					{
						RectangleTool rectangleTool = new RectangleTool(dataRow2, drawingLayer);
						rectangleTool.IsSubscriber = (this.class22_0.vP_PassportDataReports.Select(string.Format("[IdObj] = {0}", rectangleTool.IdBase)).Length != 0);
						dictionary.Add(rectangleTool.IdBase, rectangleTool);
						rectangleTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						if (dataRow2["idGroup"] != DBNull.Value)
						{
							int key = Convert.ToInt32(dataRow2["idGroup"]);
							if (this.dictionary_0.ContainsKey(key))
							{
								this.dictionary_0[key].Add(rectangleTool);
							}
						}
					}
					catch (Exception ex)
					{
						this.SendMessage(string.Concat(new string[]
						{
							"Не удалось загрузить подстанцию: id = ",
							dataRow2["id"].ToString(),
							" (",
							ex.Message,
							")"
						}), eMessageType.Error);
					}
				}
				this.SendMessage("Загружено подстанций: " + enumerable.Count<DataRow>(), eMessageType.Information);
				foreach (DataRow dataRow3 in enumerable2)
				{
					try
					{
						ShinaTool shinaTool = new ShinaTool(dataRow3, drawingLayer);
						shinaTool.Parent = dictionary[Convert.ToInt32(dataRow3["idParent"])];
						shinaTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						int idBase = shinaTool.IdBase;
						if (dataRow3["idGroup"] != DBNull.Value)
						{
							int key2 = Convert.ToInt32(dataRow3["idGroup"]);
							if (this.dictionary_0.ContainsKey(key2))
							{
								this.dictionary_0[key2].Add(shinaTool);
							}
						}
						DataRow[] array2 = this.class22_0.vSchm_ObjListXml.Select(" IdParent = " + shinaTool.IdBase.ToString() + " and typeCodeId = " + 111.ToString());
						for (int i = 0; i < array2.Length; i++)
						{
							PointShinaTool pointShinaTool = new PointShinaTool(array2[i]);
							pointShinaTool.Layer = drawingLayer;
							shinaTool.AddPointShinaTool(pointShinaTool);
							this.loadedPoints.Add(pointShinaTool.IdBase, pointShinaTool);
						}
					}
					catch
					{
						this.SendMessage("Не удалось загрузить шину: id = " + dataRow3["id"].ToString(), eMessageType.Error);
					}
				}
				this.SendMessage("Загружено шин: " + enumerable2.Count<DataRow>(), eMessageType.Information);
				foreach (DataRow dataRow4 in enumerable3)
				{
					try
					{
						LineCellTool lineCellTool = new LineCellTool(dataRow4, drawingLayer);
						if (dictionary.ContainsKey(Convert.ToInt32(dataRow4["IdParent"])))
						{
							lineCellTool.Parent = dictionary[Convert.ToInt32(dataRow4["IdParent"])];
							lineCellTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
							if (dataRow4["idGroup"] != DBNull.Value)
							{
								int key3 = Convert.ToInt32(dataRow4["idGroup"]);
								if (this.dictionary_0.ContainsKey(key3))
								{
									this.dictionary_0[key3].Add(lineCellTool);
								}
							}
							foreach (Branch branch in lineCellTool.Branches)
							{
								foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
								{
									if (drawObjectBase.GetType() == typeof(TransformerTool))
									{
										TransformerTool transformerTool = (TransformerTool)drawObjectBase;
										DataRow[] array3 = journalData.Select("id = " + transformerTool.IdBase.ToString() + " and IdPassport is not null");
										if (array3.Length != 0)
										{
											transformerTool.passportDataRow = array3[0];
										}
									}
								}
							}
						}
					}
					catch
					{
						this.SendMessage("Не удалось загрузить ячейку: id = " + dataRow4["id"].ToString(), eMessageType.Error);
					}
				}
				this.SendMessage("Загружено ячеек: " + enumerable3.Count<DataRow>(), eMessageType.Information);
				foreach (DataRow dataRow5 in enumerable4)
				{
					try
					{
						LineTool lineTool = new LineTool(dataRow5, drawingLayer);
						lineTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						if (lineTool.Branches.Count == 0)
						{
							lineTool.Remove(false, false);
							this.SendMessage(string.Concat(new string[]
							{
								"Линия ",
								lineTool.ToString(),
								"(id: ",
								lineTool.IdBase.ToString(),
								") вызвала ошибку при загрузке (не загружена ни одна ветка)"
							}), eMessageType.Error);
						}
						else
						{
							if (!lineTool.Validation())
							{
								this.SendMessage(lineTool, lineTool.ErrorString, eMessageType.Error);
							}
							if (dataRow5["idGroup"] != DBNull.Value)
							{
								int key4 = Convert.ToInt32(dataRow5["idGroup"]);
								if (this.dictionary_0.ContainsKey(key4))
								{
									this.dictionary_0[key4].Add(lineTool);
								}
							}
							foreach (Branch branch2 in lineTool.Branches)
							{
								foreach (DrawObjectBase drawObjectBase2 in branch2.ChildObjects)
								{
									if (drawObjectBase2.GetType() == typeof(TextBranchTool))
									{
										string text2 = string.Empty;
										DataRow[] array4 = dataTable.Select("id=" + lineTool.IdBase.ToString());
										if (array4.Length != 0)
										{
											text2 = array4[0][1].ToString();
										}
										TextBranchTool textBranchTool = (TextBranchTool)drawObjectBase2;
										IEnumerable<DataRow> enumerable5 = this.class22_0.vSchm_CabSection.Select("idObjList = " + lineTool.IdBase);
										if (enumerable5.Count<DataRow>() > 0)
										{
											decimal d = 0m;
											DataRow dataRow6 = null;
											decimal num = 0m;
											foreach (DataRow dataRow7 in enumerable5)
											{
												if (!dataRow7.IsNull("Length"))
												{
													num += Convert.ToDecimal(dataRow7["Length"]);
													if (dataRow6 == null && !dataRow7.IsNull("Length") && Convert.ToDecimal(dataRow7["Length"]) >= 10m && !dataRow7.IsNull("CrossSection"))
													{
														d = Convert.ToDecimal(dataRow7["CrossSection"]);
														dataRow6 = dataRow7;
													}
													else if (!dataRow7.IsNull("Length") && !dataRow7.IsNull("CrossSection") && Convert.ToDecimal(dataRow7["CrossSection"]) < d && Convert.ToDecimal(dataRow7["Length"]) >= 10m)
													{
														d = Convert.ToDecimal(dataRow7["CrossSection"]);
														dataRow6 = dataRow7;
													}
												}
											}
											if (dataRow6 != null)
											{
												if (text2 == string.Empty)
												{
													text2 = Math.Round(Convert.ToDecimal(num), 0).ToString();
												}
												textBranchTool.UpdateSQLFields(dataRow6, text2);
											}
										}
										DataRow[] array5 = journalData2.Select("id = " + lineTool.IdBase.ToString());
										if (array5.Length != 0)
										{
											textBranchTool.passportDataRow = array5[0];
										}
									}
									else if (drawObjectBase2.GetType() == typeof(TransformerTool))
									{
										TransformerTool transformerTool2 = (TransformerTool)drawObjectBase2;
										DataRow[] array6 = journalData.Select("id = " + transformerTool2.IdBase.ToString());
										if (array6.Length != 0)
										{
											transformerTool2.passportDataRow = array6[0];
										}
									}
								}
							}
						}
					}
					catch
					{
						this.SendMessage("Не удалось загрузить линию: id = " + dataRow5["id"].ToString(), eMessageType.Error);
					}
				}
				this.SendMessage("Загружено линий: " + enumerable4.Count<DataRow>(), eMessageType.Information);
				using (IEnumerator enumerator = this.class22_0.tSchm_Label.Rows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DataRow rLabel = (DataRow)enumerator.Current;
						if (rLabel["IdParent"] != DBNull.Value)
						{
							if (dictionary.ContainsKey(Convert.ToInt32(rLabel["idParent"])))
							{
								((RectangleTool)dictionary[Convert.ToInt32(rLabel["idParent"])]).AddLabelTool(rLabel);
							}
							else
							{
								LabelTool labelTool = LabelTool.GetLabelTool(rLabel);
								if (labelTool != null)
								{
									IEnumerable<DrawObjectBase> source = from o in this.list_0[0].Objects
									where o.IdBase == Convert.ToInt32(rLabel["idParent"])
									select o;
									if (source.Count<DrawObjectBase>() > 0)
									{
										labelTool.Parent = source.First<DrawObjectBase>();
										this.AddObject(drawingLayer, labelTool);
									}
								}
							}
						}
						else
						{
							LabelTool labelTool2 = LabelTool.GetLabelTool(rLabel);
							if (labelTool2 != null)
							{
								this.AddObject(drawingLayer, labelTool2);
							}
						}
					}
				}
				if (this.SimulationMode == eSimulationMode.Normal)
				{
					foreach (DrawObjectBase drawObjectBase3 in from obj in this.icanvasLayer_0.Objects
					where obj is ObjectOnLine
					select obj)
					{
						((ObjectOnLine)drawObjectBase3).NormalSectionModeOn = true;
					}
				}
				this.OnSimulate();
				this.DoInvalidate(true);
			}
		}

		public void LoadSchemeFromXML(XmlDocument doc, bool useObjectsFromDB)
		{
			this.xmlDocument_0 = doc;
			this.undoRedoManager.SaveChanges = false;
			this.list_0.Clear();
			this.globalPointsList.Clear();
			XmlNode xmlNode = doc.SelectSingleNode("canvas");
			XmlNodeList xmlNodeList = xmlNode.SelectNodes("layer");
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("points");
			Dictionary<int, object> dictionary = new Dictionary<int, object>();
			foreach (object obj in xmlNode2.ChildNodes)
			{
				XmlNode xmlNode3 = (XmlNode)obj;
				int key = Convert.ToInt32(xmlNode3.Attributes[0].Value);
				dictionary[key] = new UnitPoint((double)Convert.ToSingle(xmlNode3.Attributes[1].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode3.Attributes[2].Value, new CultureInfo(1033)));
			}
			foreach (object obj2 in xmlNodeList)
			{
				XmlNode xmlNode4 = (XmlNode)obj2;
				DrawingLayer drawingLayer = new DrawingLayer();
				drawingLayer.Id = xmlNode4.Attributes[0].Value;
				this.list_0.Add(drawingLayer);
				this.icanvasLayer_0 = drawingLayer;
				drawingLayer.Color = Color.White;
				drawingLayer.Parent = this;
				foreach (object obj3 in xmlNode4.SelectNodes("Group"))
				{
					XmlNode xmlNode5 = (XmlNode)obj3;
					RectangleTool rectangleTool = new RectangleTool();
					rectangleTool.Rectangle = new RectangleF(Convert.ToSingle(xmlNode5.Attributes[1].Value, new CultureInfo(1033)), Convert.ToSingle(xmlNode5.Attributes[2].Value, new CultureInfo(1033)), Convert.ToSingle(xmlNode5.Attributes[3].Value, new CultureInfo(1033)), Convert.ToSingle(xmlNode5.Attributes[4].Value, new CultureInfo(1033)));
					rectangleTool.IdBase = Convert.ToInt32(xmlNode5.Attributes[0].Value);
					rectangleTool.Text = xmlNode5.Attributes[5].Value;
					rectangleTool.TextProperty.Visible = Convert.ToBoolean(xmlNode5.Attributes[6].Value);
					rectangleTool.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode5.Attributes[7].Value);
					string value = xmlNode5.Attributes[8].Value;
					if (value != "")
					{
						rectangleTool.Color = Color.FromArgb(Convert.ToInt32(value));
					}
					rectangleTool.TypeRectnagleTool = (SchemeCtrl2.DrawTool.eTypeRectangleTool)Convert.ToInt32(xmlNode5.Attributes[9].Value);
					rectangleTool.TextProperty.FontVirtical = Convert.ToBoolean(xmlNode5.Attributes[10].Value);
					rectangleTool.Visible = Convert.ToBoolean(xmlNode5.Attributes[11].Value);
					if (useObjectsFromDB)
					{
						if (rectangleTool.IdBase <= 0)
						{
							continue;
						}
						DataRow[] array = this.class22_0.tSchm_ObjList.Select("id = " + rectangleTool.IdBase.ToString());
						if (array.Length == 0)
						{
							continue;
						}
						rectangleTool.Text = array[0]["Name"].ToString();
						rectangleTool.TypeRectnagleTool = (SchemeCtrl2.DrawTool.eTypeRectangleTool)Convert.ToInt32(array[0]["TypeCodeId"]);
					}
					drawingLayer.AddObject(rectangleTool);
					rectangleTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
					foreach (object obj4 in xmlNode5.SelectNodes("Shina"))
					{
						XmlNode xmlNode6 = (XmlNode)obj4;
						ShinaTool shinaTool = new ShinaTool();
						shinaTool.P1 = new UnitPoint((double)Convert.ToSingle(xmlNode6.Attributes[1].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode6.Attributes[2].Value, new CultureInfo(1033)));
						shinaTool.P2 = new UnitPoint((double)Convert.ToSingle(xmlNode6.Attributes[3].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode6.Attributes[4].Value, new CultureInfo(1033)));
						shinaTool.IdBase = Convert.ToInt32(xmlNode6.Attributes[0].Value);
						shinaTool.Text = xmlNode6.Attributes[5].Value;
						shinaTool.TextProperty.Visible = Convert.ToBoolean(xmlNode6.Attributes[6].Value);
						shinaTool.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode6.Attributes[7].Value);
						string value2 = xmlNode6.Attributes[8].Value;
						if (value2 != "")
						{
							shinaTool.UseSettingColor = false;
							shinaTool.Color = Color.FromArgb(Convert.ToInt32(value2));
						}
						if (xmlNode6.Attributes.Count >= 10)
						{
							shinaTool.TypeShinaTool = (SchemeCtrl2.DrawTool.eTypeShinaTool)Convert.ToInt32(xmlNode6.Attributes[9].Value);
						}
						if (xmlNode6.Attributes.Count >= 11)
						{
							shinaTool.TextVoltProperty.Visible = Convert.ToBoolean(xmlNode6.Attributes[10].Value);
						}
						if (xmlNode6.Attributes.Count >= 12)
						{
							shinaTool.TextVoltProperty.Position = (ePositionText)Convert.ToInt32(xmlNode6.Attributes[11].Value);
						}
						shinaTool.Parent = rectangleTool;
						if (useObjectsFromDB)
						{
							if (shinaTool.IdBase <= 0)
							{
								continue;
							}
							DataRow[] array2 = this.class22_0.tSchm_ObjList.Select("id = " + shinaTool.IdBase.ToString());
							if (array2.Length == 0)
							{
								continue;
							}
							shinaTool.Text = array2[0]["Name"].ToString();
							shinaTool.TypeShinaTool = (SchemeCtrl2.DrawTool.eTypeShinaTool)Convert.ToInt32(array2[0]["TypeCodeId"]);
						}
						drawingLayer.AddObject(shinaTool);
						shinaTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						foreach (object obj5 in xmlNode6.SelectNodes("point"))
						{
							XmlNode xmlNode7 = (XmlNode)obj5;
							if (xmlNode7.Attributes[0].Value != "")
							{
								int num = Convert.ToInt32(xmlNode7.Attributes[0].Value);
								if (num < dictionary.Count && dictionary[num].GetType() == typeof(UnitPoint))
								{
									dictionary[num] = shinaTool.AddPointShinaTool((UnitPoint)dictionary[num]);
								}
							}
						}
					}
					foreach (object obj6 in xmlNode5.SelectNodes("Cell"))
					{
						XmlNode xmlNode8 = (XmlNode)obj6;
						LineCellTool lineCellTool = new LineCellTool();
						drawingLayer.AddObject(lineCellTool);
						lineCellTool.Parent = rectangleTool;
						lineCellTool.IdBase = Convert.ToInt32(xmlNode8.Attributes[0].Value);
						lineCellTool.Text = xmlNode8.Attributes[1].Value;
						lineCellTool.TextProperty.Visible = Convert.ToBoolean(xmlNode8.Attributes[2].Value);
						lineCellTool.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode8.Attributes[3].Value);
						string value3 = xmlNode8.Attributes[4].Value;
						if (value3 != "")
						{
							lineCellTool.UseSettingColor = false;
							lineCellTool.Color = Color.FromName(value3);
						}
						if (useObjectsFromDB)
						{
							if (lineCellTool.IdBase <= 0)
							{
								continue;
							}
							DataRow[] array3 = this.class22_0.tSchm_ObjList.Select("id = " + lineCellTool.IdBase.ToString());
							if (array3.Length == 0)
							{
								continue;
							}
							lineCellTool.Text = array3[0]["Name"].ToString();
						}
						lineCellTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						foreach (object obj7 in xmlNode8.SelectNodes("Branch"))
						{
							XmlNode xmlNode9 = (XmlNode)obj7;
							int key2 = Convert.ToInt32(xmlNode9.Attributes[2].Value);
							if (dictionary[key2].GetType() == typeof(UnitPoint))
							{
								dictionary[key2] = new PointTool((UnitPoint)dictionary[key2]);
							}
							PointTool src = (PointTool)dictionary[key2];
							key2 = Convert.ToInt32(xmlNode9.Attributes[3].Value);
							if (dictionary[key2].GetType() == typeof(UnitPoint))
							{
								dictionary[key2] = new PointTool((UnitPoint)dictionary[key2]);
							}
							PointTool dest = (PointTool)dictionary[key2];
							Branch branch = lineCellTool.AddBranch(src, dest);
							foreach (object obj8 in xmlNode9.SelectNodes("Switch"))
							{
								XmlNode xmlNode10 = (XmlNode)obj8;
								if (!useObjectsFromDB || this.class22_0.tSchm_ObjList.Select("id = " + Convert.ToInt32(xmlNode10.Attributes[0].Value)).Length != 0)
								{
									ObjectOnLine objectOnLine = branch.AddSwitchTool((SchemeCtrl2.DrawTool.TypeSwitch)Convert.ToInt32(xmlNode10.Attributes[2].Value), (double)Convert.ToSingle(xmlNode10.Attributes[1].Value, new CultureInfo(1033)));
									objectOnLine.IdBase = Convert.ToInt32(xmlNode10.Attributes[0].Value);
									objectOnLine.On = Convert.ToBoolean(xmlNode10.Attributes[3].Value);
									objectOnLine.Text = xmlNode10.Attributes[4].Value;
									objectOnLine.TextProperty.Visible = Convert.ToBoolean(xmlNode10.Attributes[5].Value);
									objectOnLine.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode10.Attributes[6].Value);
									objectOnLine.GorMirror = Convert.ToBoolean(xmlNode10.Attributes[7].Value);
									objectOnLine.VertMirror = Convert.ToBoolean(xmlNode10.Attributes[8].Value);
									drawingLayer.AddObject(objectOnLine);
								}
							}
							foreach (object obj9 in xmlNode9.SelectNodes("TextBranch"))
							{
								XmlNode xmlNode11 = (XmlNode)obj9;
								drawingLayer.AddObject(new TextBranchTool
								{
									Parent = branch,
									Layer = drawingLayer,
									IdBase = Convert.ToInt32(xmlNode11.Attributes[0].Value),
									Text = xmlNode11.Attributes[1].Value,
									Direct = Convert.ToBoolean(xmlNode11.Attributes[2].Value),
									TextProperty = 
									{
										Position = (ePositionText)Convert.ToInt32(xmlNode11.Attributes[3].Value)
									},
									Delta = Convert.ToSingle(xmlNode11.Attributes[4].Value, new CultureInfo(1033))
								});
							}
						}
						if (lineCellTool.TextProperty.Visible)
						{
							string value4 = xmlNode8.Attributes[5].Value;
							if (value4 != "")
							{
								int key3 = Convert.ToInt32(value4);
								if (dictionary[key3].GetType() == typeof(PointTool) || dictionary[key3].GetType().BaseType == typeof(PointTool))
								{
									((PointTool)dictionary[key3]).TextProperty.Visible = true;
									((PointTool)dictionary[key3]).Text = lineCellTool.Text;
									((PointTool)dictionary[key3]).TextProperty.Position = lineCellTool.TextProperty.Position;
									lineCellTool.TextProperty.Visible = true;
								}
							}
						}
					}
				}
				foreach (object obj10 in xmlNode4.SelectNodes("Line"))
				{
					XmlNode xmlNode12 = (XmlNode)obj10;
					LineTool lineTool = new LineTool();
					lineTool.IdBase = Convert.ToInt32(xmlNode12.Attributes[0].Value);
					lineTool.Text = xmlNode12.Attributes[1].Value;
					lineTool.TextProperty.Visible = Convert.ToBoolean(xmlNode12.Attributes[2].Value);
					lineTool.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode12.Attributes[3].Value);
					string value5 = xmlNode12.Attributes[4].Value;
					if (value5 != "")
					{
						lineTool.UseSettingColor = false;
						lineTool.Color = Color.FromName(value5);
					}
					if (useObjectsFromDB)
					{
						DataRow[] array4 = this.class22_0.tSchm_ObjList.Select("id = " + lineTool.IdBase.ToString());
						if (array4.Length == 0)
						{
							continue;
						}
						lineTool.Text = array4[0]["Name"].ToString();
					}
					drawingLayer.AddObject(lineTool);
					lineTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
					lineTool.DrawNewObjectEvent += this.drawObjectBase_0_DrawNewObjectEvent;
					foreach (object obj11 in xmlNode12.SelectNodes("Branch"))
					{
						XmlNode xmlNode13 = (XmlNode)obj11;
						int key4 = Convert.ToInt32(xmlNode13.Attributes[2].Value);
						if (dictionary[key4].GetType() == typeof(UnitPoint))
						{
							dictionary[key4] = new PointTool((UnitPoint)dictionary[key4]);
						}
						PointTool src2 = (PointTool)dictionary[key4];
						key4 = Convert.ToInt32(xmlNode13.Attributes[3].Value);
						if (dictionary[key4].GetType() == typeof(UnitPoint))
						{
							dictionary[key4] = new PointTool((UnitPoint)dictionary[key4]);
						}
						PointTool dest2 = (PointTool)dictionary[key4];
						BranchType type = (BranchType)Convert.ToInt32(xmlNode13.Attributes[1].Value);
						Branch branch2 = lineTool.AddBranch(src2, dest2, type);
						foreach (object obj12 in xmlNode13.SelectNodes("Switch"))
						{
							XmlNode xmlNode14 = (XmlNode)obj12;
							if (!useObjectsFromDB || this.class22_0.tSchm_ObjList.Select("id = " + Convert.ToInt32(xmlNode14.Attributes[0].Value)).Length != 0)
							{
								ObjectOnLine objectOnLine2 = branch2.AddSwitchTool((SchemeCtrl2.DrawTool.TypeSwitch)Convert.ToInt32(xmlNode14.Attributes[2].Value), (double)Convert.ToSingle(xmlNode14.Attributes[1].Value, new CultureInfo(1033)));
								objectOnLine2.IdBase = Convert.ToInt32(xmlNode14.Attributes[0].Value);
								objectOnLine2.On = Convert.ToBoolean(xmlNode14.Attributes[3].Value);
								objectOnLine2.Text = xmlNode14.Attributes[4].Value;
								objectOnLine2.TextProperty.Visible = Convert.ToBoolean(xmlNode14.Attributes[5].Value);
								objectOnLine2.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode14.Attributes[6].Value);
								objectOnLine2.GorMirror = Convert.ToBoolean(xmlNode14.Attributes[7].Value);
								objectOnLine2.VertMirror = Convert.ToBoolean(xmlNode14.Attributes[8].Value);
								drawingLayer.AddObject(objectOnLine2);
							}
						}
						foreach (object obj13 in xmlNode13.SelectNodes("TextBranch"))
						{
							XmlNode xmlNode15 = (XmlNode)obj13;
							drawingLayer.AddObject(new TextBranchTool
							{
								Parent = branch2,
								Layer = drawingLayer,
								IdBase = Convert.ToInt32(xmlNode15.Attributes[0].Value),
								Text = xmlNode15.Attributes[1].Value,
								Direct = Convert.ToBoolean(xmlNode15.Attributes[2].Value),
								TextProperty = 
								{
									Position = (ePositionText)Convert.ToInt32(xmlNode15.Attributes[3].Value)
								},
								Delta = Convert.ToSingle(xmlNode15.Attributes[4].Value)
							});
						}
					}
				}
			}
			this.undoRedoManager.SaveChanges = true;
			this.DoInvalidate(true);
		}

		private void method_72()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			eTypeCanvas typeCanvas = this.TypeCanvas;
			if (typeCanvas == eTypeCanvas.SchemeMain)
			{
				sqlDataCommand.SelectSqlData(this.class22_0.vSchm_ObjListXml, false, " where TypeSchema = " + (int)this.TypeCanvas, null, false, 0);
			}
			List<int> list = new List<int>();
			List<DrawObjectBase> list2 = new List<DrawObjectBase>();
			List<int> list3 = new List<int>();
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					list2.Add(drawObjectBase);
					if (drawObjectBase.GetType() == typeof(LineCellTool) || drawObjectBase.GetType() == typeof(LineTool))
					{
						foreach (PointTool pointTool in ((LineTool)drawObjectBase).GetPointsList())
						{
							if (pointTool.IdBase > 0)
							{
								list3.Add(pointTool.IdBase);
							}
						}
					}
				}
			}
			int num = 0;
			using (IEnumerator enumerator4 = this.class22_0.vSchm_ObjListXml.Rows.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					DataRow r = (DataRow)enumerator4.Current;
					if (Convert.ToInt32(r["TypeCodeId"]) != 111)
					{
						if ((from obj in list2
						where obj.IdBase == Convert.ToInt32(r["id"])
						select obj).Count<DrawObjectBase>() == 0)
						{
							list.Add(Convert.ToInt32(r["id"]));
						}
					}
					else if (!list3.Contains(Convert.ToInt32(r["id"])))
					{
						list.Add(Convert.ToInt32(r["id"]));
					}
					num++;
				}
			}
			foreach (int num2 in list)
			{
				sqlDataCommand.DeleteSqlDataById(this.class22_0.tSchm_ObjList, num2);
			}
		}

		private void method_73(List<int> list_9)
		{
			if (list_9.Count < 1)
			{
				return;
			}
			string text = string.Empty;
			foreach (int num in list_9)
			{
				if (text.Length > 0)
				{
					text += ", ";
				}
				text += num.ToString();
			}
			DataTable dataTable = new SqlDataCommand(this.sqlsettings_0).SelectSqlData("vSchm_ObjListXml", false, string.Format("where id in ({0}) and deleted = 0", text), null);
			foreach (int num2 in list_9)
			{
				DrawObjectBase drawObjectBase = this.FindObjectById(num2);
				DataRow[] array = dataTable.Select(string.Format("id = {0}", num2));
				if (drawObjectBase != null && array.Length == 0)
				{
					drawObjectBase.Remove(false, true);
				}
			}
		}

		private LineTool method_74(DataRow dataRow_0, SqlDataCommand sqlDataCommand_0, LineTool lineTool_0)
		{
			LineTool lineTool = new LineTool();
			lineTool.IdBase = Convert.ToInt32(dataRow_0["Id"]);
			lineTool.Text = dataRow_0["Name"].ToString();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)dataRow_0["SchemaXml"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			XmlAttribute xmlAttribute = xmlNode.Attributes["textVis"];
			if (xmlAttribute != null)
			{
				lineTool.TextProperty.Visible = Convert.ToBoolean(xmlAttribute.Value);
				xmlAttribute = xmlNode.Attributes["textPos"];
				if (xmlAttribute != null)
				{
					lineTool.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
				}
			}
			xmlAttribute = xmlNode.Attributes["limEd"];
			if (xmlAttribute != null)
			{
				lineTool.LimitedEditing = Convert.ToBoolean(xmlAttribute.Value);
			}
			return lineTool;
		}

		public void LoadTransferObjects(List<ObjectBaseServer> points, List<ObjectBaseServer> transferObjs, List<ObjectOnLineServer> objsOnLine)
		{
			this.ClearLayers();
			DrawingLayer drawingLayer = new DrawingLayer("SchemaMain", "SchemaMain", Color.White, 0f);
			drawingLayer.Parent = this;
			this.AddLayer(drawingLayer);
			this.ActiveLayer = drawingLayer;
			this.loadedPoints.Clear();
			foreach (ObjectBaseServer objectBaseServer in from obj in transferObjs
			where obj.TypeTransferObject == eTypeTransferObject.Rectangle
			select obj)
			{
				drawingLayer.AddObject(new RectangleTool
				{
					Rectangle = new RectangleF(objectBaseServer.ListPoints[0].Point.X, objectBaseServer.ListPoints[0].Point.Y, objectBaseServer.ListPoints[1].Point.X - objectBaseServer.ListPoints[0].Point.X, objectBaseServer.ListPoints[1].Point.Y - objectBaseServer.ListPoints[0].Point.Y),
					IdBase = objectBaseServer.Id,
					TypeRectnagleTool = objectBaseServer.TypeRectangle
				});
			}
			using (IEnumerator<ObjectBaseServer> enumerator = (from obj in transferObjs
			where obj.TypeTransferObject == eTypeTransferObject.Shina
			select obj).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ObjectBaseServer obj = enumerator.Current;
					ShinaTool shinaTool = new ShinaTool();
					shinaTool.P1 = obj.ListPoints[0];
					shinaTool.P2 = obj.ListPoints[1];
					shinaTool.TypeShinaTool = obj.TypeShina;
					IEnumerable<DrawObjectBase> source = from o in drawingLayer.Objects
					where o.IdBase == obj.ParentId
					select o;
					if (source.Count<DrawObjectBase>() > 0)
					{
						shinaTool.Parent = source.First<DrawObjectBase>();
					}
					drawingLayer.AddObject(shinaTool);
					foreach (ObjectBaseServer objectBaseServer2 in from o in points
					where o.ParentId == obj.Id
					select o)
					{
						if (this.loadedPoints.ContainsKey(objectBaseServer2.Id))
						{
							PointTool pointTool = this.loadedPoints[objectBaseServer2.Id];
						}
						else
						{
							PointTool pointTool = shinaTool.AddPointShinaTool(new PointShinaTool
							{
								IdBase = objectBaseServer2.Id,
								Point = objectBaseServer2.ListPoints[0],
								Layer = drawingLayer
							});
							this.loadedPoints.Add(pointTool.IdBase, pointTool);
						}
					}
				}
			}
			foreach (ObjectBaseServer objectBaseServer3 in points)
			{
				if (!this.loadedPoints.ContainsKey(objectBaseServer3.Id))
				{
					PointTool pointTool2 = new PointTool();
					pointTool2.IdBase = objectBaseServer3.Id;
					pointTool2.Point = objectBaseServer3.ListPoints[0];
					pointTool2.Layer = drawingLayer;
					this.loadedPoints.Add(pointTool2.IdBase, pointTool2);
				}
			}
			Dictionary<int, ObjectBaseServer> dictionary = new Dictionary<int, ObjectBaseServer>();
			foreach (ObjectBaseServer objectBaseServer4 in from obj in transferObjs
			where obj.TypeTransferObject == eTypeTransferObject.ObjectOnLine
			select obj)
			{
				dictionary.Add(objectBaseServer4.Id, objectBaseServer4);
			}
			using (IEnumerator<ObjectBaseServer> enumerator = (from obj in transferObjs
			where obj.TypeTransferObject == eTypeTransferObject.Cell
			select obj).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ObjectBaseServer obj = enumerator.Current;
					LineCellTool lineCellTool = new LineCellTool();
					drawingLayer.AddObject(lineCellTool);
					List<PointTool> list = new List<PointTool>();
					foreach (PointServerTool pointServerTool in obj.ListPointsTool)
					{
						if (this.loadedPoints.ContainsKey(pointServerTool.Id))
						{
							list.Add(this.loadedPoints[pointServerTool.Id]);
						}
						else
						{
							list.Add(new PointTool(pointServerTool.Point)
							{
								IdBase = pointServerTool.Id,
								Layer = drawingLayer
							});
						}
					}
					foreach (RelationServer relationServer in obj.Relations)
					{
						PointTool vertex = this.loadedPoints[relationServer.SourcePoint];
						PointTool vertex2 = this.loadedPoints[relationServer.DestenationPoint];
						CouplingRelation couplingRelation = new CouplingRelation(vertex, vertex2);
						couplingRelation.Id = relationServer.id;
						couplingRelation.Line = lineCellTool;
						lineCellTool.CouplingRelations.method_3(couplingRelation);
					}
					using (List<BranchServer>.Enumerator enumerator6 = obj.Branches.GetEnumerator())
					{
						while (enumerator6.MoveNext())
						{
							BranchServer br = enumerator6.Current;
							CouplingRelation couplingRelation2 = lineCellTool.CouplingRelations.Single((CouplingRelation rel) => rel.Id == br.Relation);
							PointTool src = list[br.SourcePoint];
							PointTool dest = list[br.DestenationPoint];
							Branch branch = new Branch(lineCellTool, src, dest, br.type, couplingRelation2);
							lineCellTool.Branches.Add(branch);
							branch.Parent = lineCellTool;
							foreach (int key in br.childObjects)
							{
								if (dictionary.ContainsKey(key))
								{
									ObjectBaseServer objectBaseServer5 = dictionary[key];
									ObjectOnLine objectOnLine = ObjectOnLine.CreateObjectOnLine(objectBaseServer5.TypeObjectOnLine);
									objectOnLine.IdBase = objectBaseServer5.Id;
									branch.AddSwitchTool(objectOnLine);
									objectOnLine.Delta = (double)objectBaseServer5.Delta;
									objectOnLine.On = objectBaseServer5.On;
									objectOnLine.RecalcAngle();
									objectOnLine.GorMirror = objectBaseServer5.GorMirror;
									objectOnLine.VertMirror = objectBaseServer5.VertMirror;
									drawingLayer.AddObject(objectOnLine);
								}
							}
							if (br.States != null)
							{
								foreach (LineStateServer stateNode in br.States)
								{
									LineToolState state = new LineToolState(branch, stateNode);
									lineCellTool.AddState(state);
								}
							}
						}
					}
					lineCellTool.GetPointsList();
					IEnumerable<DrawObjectBase> source2 = from o in drawingLayer.Objects
					where o.IdBase == obj.ParentId
					select o;
					if (source2.Count<DrawObjectBase>() > 0)
					{
						lineCellTool.Parent = source2.First<DrawObjectBase>();
					}
					foreach (PointTool pointTool3 in lineCellTool.Ends)
					{
						if (pointTool3.Parent == null)
						{
							pointTool3.Parent = lineCellTool;
						}
					}
					lineCellTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
				}
			}
			foreach (ObjectBaseServer objectBaseServer6 in from obj in transferObjs
			where obj.TypeTransferObject == eTypeTransferObject.Line
			select obj)
			{
				LineTool lineTool = new LineTool();
				drawingLayer.AddObject(lineTool);
				List<PointTool> list2 = new List<PointTool>();
				foreach (PointServerTool pointServerTool2 in objectBaseServer6.ListPointsTool)
				{
					if (this.loadedPoints.ContainsKey(pointServerTool2.Id))
					{
						list2.Add(this.loadedPoints[pointServerTool2.Id]);
					}
					else
					{
						list2.Add(new PointTool(pointServerTool2.Point)
						{
							IdBase = pointServerTool2.Id,
							Layer = drawingLayer
						});
					}
				}
				foreach (RelationServer relationServer2 in objectBaseServer6.Relations)
				{
					PointTool vertex3 = this.loadedPoints[relationServer2.SourcePoint];
					PointTool vertex4 = this.loadedPoints[relationServer2.DestenationPoint];
					CouplingRelation couplingRelation3 = new CouplingRelation(vertex3, vertex4);
					couplingRelation3.Id = relationServer2.id;
					couplingRelation3.Line = lineTool;
					lineTool.CouplingRelations.method_3(couplingRelation3);
				}
				using (List<BranchServer>.Enumerator enumerator6 = objectBaseServer6.Branches.GetEnumerator())
				{
					while (enumerator6.MoveNext())
					{
						BranchServer br = enumerator6.Current;
						CouplingRelation couplingRelation4 = lineTool.CouplingRelations.Single((CouplingRelation rel) => rel.Id == br.Relation);
						PointTool src2 = list2[br.SourcePoint];
						PointTool dest2 = list2[br.DestenationPoint];
						Branch branch2 = new Branch(lineTool, src2, dest2, br.type, couplingRelation4);
						lineTool.Branches.Add(branch2);
						branch2.Parent = lineTool;
						foreach (int key2 in br.childObjects)
						{
							if (dictionary.ContainsKey(key2))
							{
								ObjectBaseServer objectBaseServer7 = dictionary[key2];
								ObjectOnLine objectOnLine2 = ObjectOnLine.CreateObjectOnLine(objectBaseServer7.TypeObjectOnLine);
								objectOnLine2.IdBase = objectBaseServer7.Id;
								branch2.AddSwitchTool(objectOnLine2);
								objectOnLine2.Delta = (double)objectBaseServer7.Delta;
								objectOnLine2.On = objectBaseServer7.On;
								objectOnLine2.RecalcAngle();
								objectOnLine2.GorMirror = objectBaseServer7.GorMirror;
								objectOnLine2.VertMirror = objectBaseServer7.VertMirror;
								drawingLayer.AddObject(objectOnLine2);
							}
						}
						if (br.States != null)
						{
							foreach (LineStateServer stateNode2 in br.States)
							{
								LineToolState state2 = new LineToolState(branch2, stateNode2);
								lineTool.AddState(state2);
							}
						}
					}
				}
				lineTool.GetPointsList();
				lineTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
			}
			foreach (DrawObjectBase drawObjectBase in from obj in drawingLayer.Objects
			where obj.GetType() == typeof(RectangleTool) && ((RectangleTool)obj).TypeRectnagleTool == SchemeCtrl2.DrawTool.eTypeRectangleTool.CP
			select obj)
			{
				foreach (DrawObjectBase drawObjectBase2 in drawObjectBase.ChildObjects.Where((DrawObjectBase obj) => obj.GetType() == typeof(ShinaTool)))
				{
					((ShinaTool)drawObjectBase2).OnAmperage = true;
				}
			}
		}

		public OPCClient OpcClient
		{
			get
			{
				return this.opcclient_0;
			}
			set
			{
				if (this.opcclient_0 != null)
				{
					this.opcclient_0.OnSocketEvent -= new DelegateSocketEventMethod(this.method_79);
					this.opcclient_0.OnGetEvent -= new DelegateOPCClientGetEvent(this.method_78);
					this.opcclient_0.OnGetItem -= new DelegateOPCClientGetEvents(this.method_76);
				}
				this.opcclient_0 = value;
				if (this.opcclient_0 != null)
				{
					this.opcclient_0.OnSocketEvent += new DelegateSocketEventMethod(this.method_79);
					this.opcclient_0.OnGetEvent += new DelegateOPCClientGetEvent(this.method_78);
					this.opcclient_0.OnGetItem += new DelegateOPCClientGetEvents(this.method_76);
				}
			}
		}

		private void method_75()
		{
		}

		private void method_76(List<OPCMessage> list_9)
		{
			IEnumerable<DrawObjectBase> source = null;
			IEnumerable<DrawObjectBase> source2 = null;
			if (this.list_0.Count > 0)
			{
				source2 = from o in this.list_0[0].Objects
				where o.GetType() == typeof(TelemetryLabelTool)
				select o;
				source = from o in this.list_0[0].Objects
				where o is ObjectOnLine
				select o;
				using (List<OPCMessage>.Enumerator enumerator = list_9.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						OPCMessage message = enumerator.Current;
						if (message.ObjectId > 0 && this.list_0.Count > 0)
						{
							IEnumerable<DrawObjectBase> source3 = from obj in source
							where obj.IdBase == message.ObjectId
							select obj;
							if (source3.Count<DrawObjectBase>() > 0)
							{
								source3.First<DrawObjectBase>();
							}
							foreach (DrawObjectBase drawObjectBase in from o in source2
							where ((TelemetryLabelTool)o).ObjectTelemetry == message.ObjectId && message.ParameterId == ((TelemetryLabelTool)o).TelemetryParameterId
							select o)
							{
								if (drawObjectBase.GetType() == typeof(TelemetryLabelTool))
								{
									((TelemetryLabelTool)drawObjectBase).OPCMessage_0 = message;
								}
							}
						}
					}
				}
				this.DoInvalidate(true);
			}
		}

		private void method_77(DrawObjectBase drawObjectBase_2, OPCMessage opcmessage_0)
		{
			TelemetryValues telemetryValues = (drawObjectBase_2 != null) ? drawObjectBase_2.TelemetryValues : TelemetryValues.Empty;
			PropertyInfo property = telemetryValues.GetType().GetProperty(opcmessage_0.ParameterName);
			if (property == null)
			{
				return;
			}
			if (property.PropertyType == typeof(float))
			{
				float num = Convert.ToSingle(opcmessage_0.Value, new CultureInfo(1033));
				opcmessage_0.Message = num.ToString();
				if (drawObjectBase_2 != null)
				{
					telemetryValues = drawObjectBase_2.TelemetryValues;
					object obj = telemetryValues;
					property.SetValue(obj, num, null);
					drawObjectBase_2.TelemetryValues = (TelemetryValues)obj;
				}
			}
			int num2;
			if (property.PropertyType == typeof(bool?) && opcmessage_0.ZeroNormalState <= 0 && int.TryParse(opcmessage_0.Value, out num2))
			{
				bool flag = true;
				if (opcmessage_0.ZeroNormalState == 0)
				{
					opcmessage_0.Message = ((num2 != 0) ? opcmessage_0.StateNormName : opcmessage_0.StateAbnormName);
					if (num2 == 0)
					{
						flag = false;
					}
				}
				else
				{
					opcmessage_0.Message = ((num2 == 0) ? opcmessage_0.StateNormName : opcmessage_0.StateAbnormName);
					if (num2 != 0)
					{
						flag = false;
					}
				}
				if (drawObjectBase_2 != null)
				{
					telemetryValues = drawObjectBase_2.TelemetryValues;
					object obj2 = telemetryValues;
					property.SetValue(obj2, flag, null);
					drawObjectBase_2.TelemetryValues = (TelemetryValues)obj2;
				}
			}
		}

		private void method_78(OPCMessage opcmessage_0)
		{
			if (opcmessage_0.ObjectId > 0 && this.list_0.Count > 0)
			{
				foreach (DrawObjectBase drawObjectBase in from o in this.list_0[0].Objects
				where o.GetType() == typeof(TelemetryLabelTool)
				where ((TelemetryLabelTool)o).ObjectTelemetry == opcmessage_0.ObjectId && opcmessage_0.ParameterId == ((TelemetryLabelTool)o).TelemetryParameterId
				select o)
				{
					if (drawObjectBase.GetType() == typeof(TelemetryLabelTool))
					{
						((TelemetryLabelTool)drawObjectBase).OPCMessage_0 = opcmessage_0;
					}
				}
			}
		}

		private void method_79(SocketEventTypeEnum socketEventTypeEnum_0, object object_0)
		{
			switch (socketEventTypeEnum_0)
			{
			case 1:
				this.method_9(new CanvasControl.AsyncAction(this.method_98));
				return;
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 8:
				break;
			case 7:
				this.method_9(new CanvasControl.AsyncAction(this.method_100));
				break;
			case 9:
				this.method_9(new CanvasControl.AsyncAction(this.method_99));
				return;
			case 10:
				this.method_9(new CanvasControl.AsyncAction(this.method_97));
				return;
			default:
				return;
			}
		}

		public void UpdateAllTelemetryLabels()
		{
			if (this.opcclient_0 == null)
			{
				return;
			}
			IEnumerable<DrawObjectBase> enumerable = from o in this.list_0[0].Objects
			where o.GetType() == typeof(TelemetryLabelTool)
			select o;
			List<int> list = new List<int>();
			foreach (DrawObjectBase drawObjectBase in enumerable)
			{
				list.Add(((TelemetryLabelTool)drawObjectBase).ObjectTelemetry);
				list.Add(((TelemetryLabelTool)drawObjectBase).TelemetryParameterId);
			}
			this.OpcClient.OPCAsyncSend_GetItem(list.ToArray());
		}

		public int PagesHeigth
		{
			get
			{
				return this.int_5;
			}
			set
			{
				this.int_5 = value;
			}
		}

		public int PagesWidth
		{
			get
			{
				return this.int_6;
			}
			set
			{
				this.int_6 = value;
			}
		}

		public int Pages
		{
			get
			{
				return this.int_5 * this.int_6;
			}
		}

		public WorkerCanvasPrint WorkerPrint { get; set; }

		[CompilerGenerated]
		internal string method_80()
		{
			return this.string_2;
		}

		[CompilerGenerated]
		internal void method_81(string value)
		{
			this.string_2 = value;
		}

		[CompilerGenerated]
		internal string method_82()
		{
			return this.string_3;
		}

		[CompilerGenerated]
		internal void method_83(string value)
		{
			this.string_3 = value;
		}

		[CompilerGenerated]
		internal string method_84()
		{
			return this.string_4;
		}

		[CompilerGenerated]
		internal void method_85(string value)
		{
			this.string_4 = value;
		}

		public void Print()
		{
			Form4 form = new Form4();
			form.Canvas = this;
			form.ShowDialog();
			form.Dispose();
			GC.Collect();
		}

		private void method_86()
		{
			this.printDocument.DefaultPageSettings.Margins = new Margins(39, 39, 39, 39);
		}

		public void ShowPageSetupDialog()
		{
			this.pageSetupDialog_0.ShowDialog();
		}

		private void method_87(Graphics graphics_1, string string_5, Font font_0, SolidBrush solidBrush_0, RectangleF rectangleF_2)
		{
			for (;;)
			{
				SizeF sizeF = graphics_1.MeasureString(string_5, font_0);
				if (sizeF.Width < rectangleF_2.Width)
				{
					if (sizeF.Height < rectangleF_2.Height)
					{
						break;
					}
				}
				font_0 = new Font(font_0.FontFamily, font_0.Size - 0.5f);
			}
			graphics_1.DrawString(string_5, font_0, solidBrush_0, rectangleF_2);
		}

		private void method_88(Graphics graphics_1, string string_5, Font font_0, SolidBrush solidBrush_0, RectangleF rectangleF_2, bool bool_12)
		{
			for (;;)
			{
				SizeF sizeF = graphics_1.MeasureString(string_5, font_0);
				if (sizeF.Width < rectangleF_2.Width && sizeF.Height < rectangleF_2.Height)
				{
					if (!bool_12)
					{
						break;
					}
					SizeF sizeF2 = graphics_1.MeasureString(string_5, new Font(font_0.FontFamily, font_0.Size + 1f));
					if (sizeF2.Width >= rectangleF_2.Width || sizeF2.Height >= rectangleF_2.Height)
					{
						break;
					}
					font_0 = new Font(font_0.FontFamily, font_0.Size + 1f);
				}
				else
				{
					font_0 = new Font(font_0.FontFamily, font_0.Size - 0.5f);
				}
			}
			if (bool_12)
			{
				SizeF sizeF3 = graphics_1.MeasureString(string_5, font_0);
				rectangleF_2.Y += (rectangleF_2.Height - sizeF3.Height) / 2f;
				rectangleF_2.Height = sizeF3.Height;
			}
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			graphics_1.DrawString(string_5, font_0, solidBrush_0, rectangleF_2, stringFormat);
		}

		private void method_89(Graphics graphics_1, Rectangle rectangle_0, CanvasControl canvasControl_1)
		{
			RectangleF rectangleF = ConvertCanvas.ConvertToUnitNormalized(canvasControl_1, rectangle_0);
			RectangleF unitrect = new RectangleF(rectangleF.X + rectangleF.Width - 18.5f * (float)canvasControl_1.int_8, rectangleF.Y, 18.5f * (float)canvasControl_1.int_8, (float)(4 * canvasControl_1.int_8));
			RectangleF rectangleF2 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, unitrect);
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), new PointF(rectangleF2.X, rectangleF2.Y), new PointF(rectangleF2.X, rectangleF2.Y + rectangleF2.Height));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), new PointF(rectangleF2.X, rectangleF2.Y), new PointF((float)rectangle_0.Right, rectangleF2.Y));
			graphics_1.DrawString("Изм Лист", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), new PointF(rectangleF2.X, rectangleF2.Y));
			PointF pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 1.7f * (float)canvasControl_1.int_8), (double)unitrect.Y));
			PointF pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 1.7f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), pointF, pointF2);
			graphics_1.DrawString("№ документа", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 4f * (float)canvasControl_1.int_8), (double)unitrect.Y));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 4f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), pointF, pointF2);
			graphics_1.DrawString("Подпись", new Font("Microsoft Sans Serif", 8.5f * (float)this.int_8), new SolidBrush(Color.Black), pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 5.5f * (float)canvasControl_1.int_8), (double)unitrect.Y));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 5.5f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), pointF, pointF2);
			graphics_1.DrawString("Дата", new Font("Microsoft Sans Serif", 8.5f * (float)this.int_8), new SolidBrush(Color.Black), pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 6.5f * (float)canvasControl_1.int_8), (double)unitrect.Y));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 6.5f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), pointF, pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 13.5f * (float)canvasControl_1.int_8), (double)unitrect.Y));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 13.5f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height + 0.5f * (float)canvasControl_1.int_8)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), pointF, pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 15f * (float)canvasControl_1.int_8), (double)(unitrect.Y + 2f * (float)canvasControl_1.int_8)));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 15f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), pointF, pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 16.7f * (float)canvasControl_1.int_8), (double)(unitrect.Y + 2f * (float)canvasControl_1.int_8)));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 16.7f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), pointF, pointF2);
			for (int i = 1; i < 8; i++)
			{
				pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)unitrect.X, (double)(unitrect.Y + (float)i * 0.5f * (float)canvasControl_1.int_8)));
				pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 1.7f * (float)canvasControl_1.int_8), (double)(unitrect.Y + (float)i * 0.5f * (float)canvasControl_1.int_8)));
				RectangleF rectangleF_ = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X, unitrect.Y + (float)i * 0.5f * (float)canvasControl_1.int_8 - 0.5f * (float)canvasControl_1.int_8, 1.7f * (float)canvasControl_1.int_8, 0.4f * (float)canvasControl_1.int_8));
				RectangleF rectangleF_2 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 1.7f * (float)canvasControl_1.int_8, unitrect.Y + (float)i * 0.5f * (float)canvasControl_1.int_8 - 0.5f * (float)canvasControl_1.int_8, 2.3f * (float)canvasControl_1.int_8, 0.4f * (float)canvasControl_1.int_8));
				switch (i)
				{
				case 2:
					if (this.WorkerPrint != null)
					{
						if (!string.IsNullOrEmpty(this.WorkerPrint.ChiefDistrict.Title))
						{
							this.method_87(graphics_1, this.WorkerPrint.ChiefDistrict.Title, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF_);
						}
						if (!string.IsNullOrEmpty(this.WorkerPrint.ChiefDistrict.FIO))
						{
							this.method_87(graphics_1, this.WorkerPrint.ChiefDistrict.FIO, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF_2);
						}
					}
					break;
				case 3:
					if (this.WorkerPrint != null)
					{
						if (!string.IsNullOrEmpty(this.WorkerPrint.Master.Title))
						{
							this.method_87(graphics_1, this.WorkerPrint.Master.Title, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF_);
						}
						if (!string.IsNullOrEmpty(this.WorkerPrint.Master.FIO))
						{
							this.method_87(graphics_1, this.WorkerPrint.Master.FIO, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF_2);
						}
					}
					break;
				case 4:
					if (this.WorkerPrint != null)
					{
						if (!string.IsNullOrEmpty(this.WorkerPrint.Technician.Title))
						{
							this.method_87(graphics_1, this.WorkerPrint.Technician.Title, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF_);
						}
						if (!string.IsNullOrEmpty(this.WorkerPrint.Technician.FIO))
						{
							this.method_87(graphics_1, this.WorkerPrint.Technician.FIO, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF_2);
						}
					}
					break;
				case 5:
					if (this.WorkerPrint != null)
					{
						if (!string.IsNullOrEmpty(this.WorkerPrint.ZamChief.Title))
						{
							this.method_87(graphics_1, this.WorkerPrint.ZamChief.Title, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF_);
						}
						if (!string.IsNullOrEmpty(this.WorkerPrint.ZamChief.FIO))
						{
							this.method_87(graphics_1, this.WorkerPrint.ZamChief.FIO, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF_2);
						}
					}
					break;
				case 6:
					if (this.WorkerPrint != null)
					{
						if (!string.IsNullOrEmpty(this.WorkerPrint.Electrician.Title))
						{
							this.method_87(graphics_1, this.WorkerPrint.Electrician.Title, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF_);
						}
						if (!string.IsNullOrEmpty(this.WorkerPrint.Electrician.FIO))
						{
							this.method_87(graphics_1, this.WorkerPrint.Electrician.FIO, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF_2);
						}
					}
					break;
				}
				pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 6.5f * (float)canvasControl_1.int_8), (double)(unitrect.Y + (float)i * 0.5f * (float)canvasControl_1.int_8)));
				if (i == 4)
				{
					pointF2.X = (float)rectangle_0.Right;
				}
				graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), pointF, pointF2);
			}
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 13.5f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height + 0.5f * (float)canvasControl_1.int_8)));
			pointF2 = new PointF((float)rectangle_0.Right, pointF.Y);
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), pointF, pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 13.5f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height - 0.5f * (float)canvasControl_1.int_8)));
			pointF2 = new PointF((float)rectangle_0.Right, pointF.Y);
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_8)), pointF, pointF2);
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			RectangleF rectangleF3;
			if (!string.IsNullOrEmpty(this.method_82()))
			{
				if (!string.IsNullOrEmpty(this.method_84()))
				{
					rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 6.5f * (float)canvasControl_1.int_8, unitrect.Y + 2.667f * (float)canvasControl_1.int_8, (float)(7 * canvasControl_1.int_8), 1.333f * (float)canvasControl_1.int_8));
				}
				else
				{
					rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 6.5f * (float)canvasControl_1.int_8, unitrect.Y + (float)(2 * canvasControl_1.int_8), (float)(7 * canvasControl_1.int_8), (float)(2 * canvasControl_1.int_8)));
				}
				this.method_88(graphics_1, this.method_82(), new Font("Microsoft Sans Serif", 16f * (float)canvasControl_1.int_8, FontStyle.Bold), new SolidBrush(Color.Black), rectangleF3, false);
				if (!string.IsNullOrEmpty(this.method_84()))
				{
					rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 6.5f * (float)canvasControl_1.int_8, unitrect.Y + (float)(2 * canvasControl_1.int_8), (float)(7 * canvasControl_1.int_8), 0.6667f * (float)canvasControl_1.int_8));
					this.method_88(graphics_1, this.method_84(), new Font("Microsoft Sans Serif", 16f * (float)canvasControl_1.int_8, FontStyle.Bold), new SolidBrush(Color.Black), rectangleF3, false);
				}
			}
			else if (!string.IsNullOrEmpty(this.method_84()))
			{
				rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 6.5f * (float)canvasControl_1.int_8, unitrect.Y + (float)(2 * canvasControl_1.int_8), (float)(7 * canvasControl_1.int_8), (float)(2 * canvasControl_1.int_8)));
				this.method_88(graphics_1, this.method_84(), new Font("Microsoft Sans Serif", 16f * (float)canvasControl_1.int_8, FontStyle.Bold), new SolidBrush(Color.Black), rectangleF3, false);
			}
			rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 6.5f * (float)canvasControl_1.int_8, unitrect.Y, (float)(7 * canvasControl_1.int_8), (float)(2 * canvasControl_1.int_8)));
			graphics_1.DrawString("Однолинейная схема \nэлектрических соединений_______________", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF3, stringFormat);
			rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 13.5f * (float)canvasControl_1.int_8, unitrect.Y, (float)(5 * canvasControl_1.int_8), (float)(2 * canvasControl_1.int_8)));
			if (!string.IsNullOrEmpty(this.method_80()))
			{
				this.method_88(graphics_1, this.method_80(), new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), rectangleF3, true);
			}
			rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 13.5f * (float)canvasControl_1.int_8, unitrect.Y + unitrect.Height, (float)(5 * canvasControl_1.int_8), 0.5f * (float)canvasControl_1.int_8));
			graphics_1.DrawString(DateTime.Now.ToString("dd.MM.yyyy"), new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8, FontStyle.Bold), new SolidBrush(Color.Black), rectangleF3, stringFormat);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 13.5f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawString("Стадия", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), pointF);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 15f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawString("Лист", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), pointF);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 16.7f * (float)canvasControl_1.int_8), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawString("Листов", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_8), new SolidBrush(Color.Black), pointF);
		}

		internal int method_90()
		{
			return this.int_8;
		}

		private void printDocument_BeginPrint(object sender, PrintEventArgs e)
		{
			this.int_7 = 0;
			if (sender.GetType() != typeof(PrintDocument))
			{
				e.Cancel = true;
				return;
			}
			this.canvasControl_0 = new CanvasControl();
			this.canvasControl_0.int_8 = 5 / ((this.int_5 > this.int_6) ? this.int_5 : this.int_6);
			PrintDocument printDocument = (PrintDocument)sender;
			Rectangle rectangle = new Rectangle(0, 0, (printDocument.DefaultPageSettings.Bounds.Width - (printDocument.DefaultPageSettings.Margins.Left + printDocument.DefaultPageSettings.Margins.Right)) * this.int_6 * this.canvasControl_0.int_8, (printDocument.DefaultPageSettings.Bounds.Height - (printDocument.DefaultPageSettings.Margins.Bottom + printDocument.DefaultPageSettings.Margins.Top)) * this.int_5 * this.canvasControl_0.int_8);
			this.bitmap_0 = new Bitmap(rectangle.Width, rectangle.Height);
			Graphics graphics = Graphics.FromImage(this.bitmap_0);
			graphics.Clear(Color.White);
			Rectangle rectangle_ = rectangle;
			graphics.DrawRectangle(new Pen(Color.Black, (float)(2 * this.canvasControl_0.int_8)), new Rectangle(rectangle_.X + 2 * this.canvasControl_0.int_8, rectangle_.Y + 2 * this.canvasControl_0.int_8, rectangle_.Width - 2 * this.canvasControl_0.int_8, rectangle_.Height - 2 * this.canvasControl_0.int_8));
			if (this.isPrintFrame)
			{
				this.method_89(graphics, rectangle_, this.canvasControl_0);
			}
			this.canvasControl_0.Location = rectangle_.Location;
			if (this.isPrintFrame)
			{
				int num = (int)ConvertCanvas.ConvertToScreen(this.canvasControl_0, (double)(4.5f * (float)this.canvasControl_0.int_8));
				rectangle_.Height -= num;
				graphics.ExcludeClip(new Rectangle(0, rectangle.Height - num, rectangle.Width, rectangle.Height - (rectangle.Y + rectangle.Height - num)));
			}
			this.canvasControl_0.Settings = this.canvasSettings_0.Clone();
			this.canvasControl_0.Settings.BackFlashingColor = Color.White;
			this.canvasControl_0.Settings.BackgroundColor = Color.White;
			this.canvasControl_0.Size = rectangle_.Size;
			this.canvasControl_0.Graphics = graphics;
			Rectangle clientRectangle = base.ClientRectangle;
			RectangleF rectangleF = ConvertCanvas.ConvertToUnitNormalized(this, clientRectangle);
			switch (this.enum4_0)
			{
			case (Enum4)0:
				if (this.SelectedCount > 0)
				{
					this.canvasControl_0.SetObjectsInCenterScreen(this.SelectedObjects.ToList<DrawObjectBase>(), true, CanvasControl.SetObjectsInCenterScreenOptions.none);
					this.Graphics = Graphics.FromHwnd(base.Handle);
					IEnumerable<RectangleF> source = (from obj in this.SelectedObjects
					where obj.Visible
					select obj).Select(new Func<DrawObjectBase, RectangleF>(this.method_102));
					float num2 = source.Min((RectangleF obj) => obj.X);
					float num3 = source.Min((RectangleF obj) => obj.Y);
					float num4 = source.Max((RectangleF obj) => obj.Right);
					float num5 = source.Max((RectangleF obj) => obj.Bottom);
					rectangleF = new RectangleF(num2, num3, num4 - num2, num5 - num3);
					this.canvasControl_0.SetCenter(new UnitPoint((double)(rectangleF.X + rectangleF.Width / 2f), (double)(rectangleF.Y + rectangleF.Height / 2f)));
					this.canvasControl_0.DoInvalidate(true);
				}
				break;
			case (Enum4)1:
			{
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				foreach (ICanvasLayer canvasLayer in this.Layers)
				{
					foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects)
					{
						if (drawObjectBase.Visible)
						{
							list.Add(drawObjectBase);
						}
					}
				}
				this.canvasControl_0.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
				List<DrawObjectBase> list2 = new List<DrawObjectBase>();
				foreach (ICanvasLayer canvasLayer2 in this.Layers)
				{
					DrawingLayer drawingLayer = (DrawingLayer)canvasLayer2;
					list2.AddRange(drawingLayer.Objects);
				}
				this.Graphics = Graphics.FromHwnd(base.Handle);
				IEnumerable<RectangleF> source2 = (from obj in list2
				where obj.Visible
				select obj).Select(new Func<DrawObjectBase, RectangleF>(this.method_101));
				float num6 = source2.Min((RectangleF obj) => obj.X);
				float num7 = source2.Min((RectangleF obj) => obj.Y);
				float num8 = source2.Max((RectangleF obj) => obj.Right);
				float num9 = source2.Max((RectangleF obj) => obj.Bottom);
				rectangleF = new RectangleF(num6, num7, num8 - num6, num9 - num7);
				this.canvasControl_0.SetCenter(new UnitPoint((double)(rectangleF.X + rectangleF.Width / 2f), (double)(rectangleF.Y + rectangleF.Height / 2f)));
				break;
			}
			case (Enum4)2:
				this.canvasControl_0.SetCenter(new UnitPoint((double)(rectangleF.X + rectangleF.Width / 2f), (double)(rectangleF.Y + rectangleF.Height / 2f)));
				break;
			case (Enum4)3:
				if (this.canvasFrame_0 != null)
				{
					this.canvasFrame_0.Normalize();
					rectangleF = this.canvasFrame_0.Rectangle;
					this.canvasControl_0.SetCenter(new UnitPoint((double)(rectangleF.X + rectangleF.Width / 2f), (double)(rectangleF.Y + rectangleF.Height / 2f)));
					this.canvasControl_0.DoInvalidate(true);
				}
				break;
			}
			rectangleF.Inflate(new SizeF(1f, 1f));
			rectangleF.Y += 0.2f;
			RectangleF rectangleF2 = ConvertCanvas.ConvertToUnitNormalized(this.canvasControl_0, this.canvasControl_0.ClientRectangle);
			float num10;
			if (rectangleF.Height / rectangleF.Width <= rectangleF2.Height / rectangleF2.Width)
			{
				num10 = 1f * rectangleF.Width / rectangleF2.Width;
			}
			else
			{
				num10 = 1f * rectangleF.Height / rectangleF2.Height;
			}
			this.canvasControl_0.Zoom /= num10;
			PointF p = new PointF(rectangleF.X + rectangleF.Width / 2f, rectangleF.Y + rectangleF.Height / 2f);
			this.canvasControl_0.SetCenter(new UnitPoint(p));
			this.canvasControl_0.Location = rectangle_.Location;
			this.Graphics = Graphics.FromHwnd(base.Handle);
			this.canvasControl_0.Graphics = graphics;
			RectangleF rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(this.canvasControl_0, rectangleF);
			graphics.ExcludeClip(new Rectangle(0, 0, (int)rectangleF3.X + 10 * this.canvasControl_0.int_8, rectangle.Height));
			graphics.ExcludeClip(new Rectangle(0, 0, rectangle.Width, (int)rectangleF3.Y + 10 * this.canvasControl_0.int_8));
			graphics.ExcludeClip(new Rectangle((int)(rectangleF3.X + rectangleF3.Width - (float)(10 * this.canvasControl_0.int_8)), 0, rectangle.Width - (int)(rectangleF3.X + rectangleF3.Width) + 10 * this.canvasControl_0.int_8, rectangle.Height));
			graphics.ExcludeClip(new Rectangle(0, (int)(rectangleF3.Y + rectangleF3.Height), rectangle.Width, rectangle.Height - (int)(rectangleF3.Y + rectangleF3.Height)));
			eDrawMode eDrawMode = eDrawMode.Print;
			if (this.bool_11)
			{
				eDrawMode |= eDrawMode.Color;
			}
			foreach (ICanvasLayer canvasLayer3 in this.list_0)
			{
				foreach (DrawObjectBase drawObjectBase2 in ((DrawingLayer)canvasLayer3).Objects)
				{
					switch (this.enum4_0)
					{
					case (Enum4)0:
						if (drawObjectBase2.Selected)
						{
							drawObjectBase2.Draw(this.canvasControl_0, rectangleF, eDrawMode);
						}
						break;
					case (Enum4)1:
						drawObjectBase2.Draw(this.canvasControl_0, rectangleF, eDrawMode);
						break;
					case (Enum4)2:
						if (drawObjectBase2.ObjectInRectangle(this, rectangleF, true))
						{
							drawObjectBase2.Draw(this.canvasControl_0, rectangleF, eDrawMode);
						}
						break;
					case (Enum4)3:
						if (this.canvasFrame_0 != null && drawObjectBase2.ObjectInRectangle(this, rectangleF, true))
						{
							drawObjectBase2.Draw(this.canvasControl_0, rectangleF, eDrawMode);
						}
						break;
					}
				}
			}
			graphics.Dispose();
		}

		private void printDocument_EndPrint(object sender, PrintEventArgs e)
		{
			this.bitmap_0.Dispose();
			GC.Collect();
		}

		private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.ExcludeClip(new Rectangle(0, 0, e.MarginBounds.X, e.PageBounds.Height));
			graphics.ExcludeClip(new Rectangle(0, 0, e.PageBounds.Width, e.MarginBounds.Location.Y));
			graphics.ExcludeClip(new Rectangle(e.MarginBounds.X + e.MarginBounds.Width, 0, e.PageBounds.Width - (e.MarginBounds.X + e.MarginBounds.Width), e.PageBounds.Height));
			graphics.ExcludeClip(new Rectangle(0, e.MarginBounds.Y + e.MarginBounds.Height, e.PageBounds.Width, e.PageBounds.Height - (e.MarginBounds.Y + e.MarginBounds.Height)));
			int num = this.int_7 / this.int_6;
			int num2 = this.int_7 % this.int_6;
			Point point = new Point(num2 * e.MarginBounds.Width, num * e.MarginBounds.Height);
			Size size = new Size(e.MarginBounds.Width, e.MarginBounds.Height);
			Rectangle destRect = new Rectangle(new Point(e.MarginBounds.X, e.MarginBounds.Y), size);
			Rectangle srcRect = new Rectangle(point.X * this.canvasControl_0.int_8, point.Y * this.canvasControl_0.int_8, size.Width * this.canvasControl_0.int_8, size.Height * this.canvasControl_0.int_8);
			graphics.DrawImage(this.bitmap_0, destRect, srcRect, GraphicsUnit.Pixel);
			this.int_7++;
			e.HasMorePages = (this.int_7 < this.Pages);
		}

		// Note: this type is marked as 'beforefieldinit'.
		static CanvasControl()
		{
			Class90.TDroV38zslI2T();
			CanvasControl.dictionary_1 = new Dictionary<string, DrawObjectBase>();
		}

		[CompilerGenerated]
		private void method_91(bool bool_12)
		{
			this.method_3(bool_12);
		}

		[CompilerGenerated]
		private RectangleF method_92(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		[CompilerGenerated]
		private RectangleF method_93(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		[CompilerGenerated]
		private RectangleF method_94(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		[CompilerGenerated]
		private RectangleF method_95(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		[CompilerGenerated]
		private bool method_96(DataRow dataRow_0)
		{
			return Convert.ToInt32(dataRow_0["Id"]) == this.IdRect;
		}

		[CompilerGenerated]
		private void method_97()
		{
			this.labelInfo.Text = "Соединение с OPCServer...";
		}

		[CompilerGenerated]
		private void method_98()
		{
			this.labelInfo.Text = "Соединение с OPCServer прошло успешно";
		}

		[CompilerGenerated]
		private void method_99()
		{
			this.labelInfo.Text = "Не удается соединиться с OPCServer...";
		}

		[CompilerGenerated]
		private void method_100()
		{
			this.labelInfo.Text = "Обрыв соединения с OPCServer...";
		}

		[CompilerGenerated]
		private RectangleF method_101(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		[CompilerGenerated]
		private RectangleF method_102(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		public const float ScreenResolution = 96f;

		[CompilerGenerated]
		private DrawObjectEventHandler drawObjectEventHandler_0;

		[CompilerGenerated]
		private DrawObjectEventHandler drawObjectEventHandler_1;

		[CompilerGenerated]
		private DrawObjectEventHandler drawObjectEventHandler_2;

		[CompilerGenerated]
		private DrawObjectEventHandler drawObjectEventHandler_3;

		[CompilerGenerated]
		private DrawObjectEventHandler drawObjectEventHandler_4;

		[CompilerGenerated]
		private DrawObjectEventHandler drawObjectEventHandler_5;

		[CompilerGenerated]
		private DrawObjectEventHandler drawObjectEventHandler_6;

		[CompilerGenerated]
		private DrawObjectEventHandler drawObjectEventHandler_7;

		[CompilerGenerated]
		private ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler_0;

		[CompilerGenerated]
		private ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler_1;

		[CompilerGenerated]
		private DrawObjectEventHandler drawObjectEventHandler_8;

		[CompilerGenerated]
		private DrawObjectEventHandler drawObjectEventHandler_9;

		[CompilerGenerated]
		private EventHandler eventHandler_0;

		[CompilerGenerated]
		private CanvasMessageEventHandler canvasMessageEventHandler_0;

		[CompilerGenerated]
		private LineToolEventHandler lineToolEventHandler_0;

		[CompilerGenerated]
		private LineToolEventHandler lineToolEventHandler_1;

		[CompilerGenerated]
		private EventHandler eventHandler_1;

		[CompilerGenerated]
		private EventHandler eventHandler_2;

		[CompilerGenerated]
		private EventHandler eventHandler_3;

		private CanvasFrame canvasFrame_0;

		private int int_0;

		internal Proxy_Singleton proxy_Singleton_0;

		internal Dictionary<int, GroupDrawObjectBase> dictionary_0;

		private Graphics graphics_0;

		private BackgroundLayer backgroundLayer_0;

		private GridLayer gridLayer_0;

		private List<ICanvasLayer> list_0;

		private ICanvasLayer icanvasLayer_0;

		private float float_0;

		private static Dictionary<string, DrawObjectBase> dictionary_1;

		private List<DrawObjectBase> list_1;

		private List<DrawObjectBase> list_2;

		private List<DrawObjectBase> list_3;

		private PointF pointF_0;

		private PointF pointF_1;

		private PointF pointF_2;

		private ISnapPoint isnapPoint_0;

		private bool bool_0;

		private DrawObjectBase drawObjectBase_0;

		private UnitPoint unitPoint_0;

		private UnitPoint unitPoint_1;

		private eMetric eMetric_0;

		internal eCommandType eCommandType_0;

		private string string_0;

		protected Bitmap staticImage;

		protected bool staticRepaint;

		private SelectionRectangle selectionRectangle_0;

		private Class1 class1_0;

		private DrawObjectBase drawObjectBase_1;

		private int int_1;

		private string string_1;

		private SQLSettings sqlsettings_0;

		public List<PointTool> globalPointsList;

		private UnitPoint unitPoint_2;

		private CanvasSettings canvasSettings_0;

		private XmlDocument xmlDocument_0;

		private eTypeCanvas eTypeCanvas_0;

		private eSimulationMode eSimulationMode_0;

		private int int_2;

		private eCanvasEditingMode eCanvasEditingMode_0;

		private bool bool_1;

		private Control0 control0_0;

		private bool bool_2;

		private RectangleF rectangleF_0;

		private bool bool_3;

		public UndoRedoManager undoRedoManager;

		private List<LineToolState> list_4;

		private List<DrawObjectBase> list_5;

		private List<List<DrawObjectBase>> list_6;

		private int oaOsGeahQk;

		private List<DrawObjectBase> list_7;

		private EndpointAddress endpointAddress_0;

		private bool bool_4;

		private bool bool_5;

		private System.Windows.Forms.Timer timer_0;

		private eCanvasEditingMode eCanvasEditingMode_1;

		[CompilerGenerated]
		private bool bool_6;

		[CompilerGenerated]
		private bool bool_7;

		[CompilerGenerated]
		private bool bool_8;

		public bool ConvertColorFlash;

		[CompilerGenerated]
		private bool bool_9;

		private int int_3;

		private Point point_0;

		private Point xFfsyLeRmd;

		private eMouseControlState eMouseControlState_0;

		private RectangleF rectangleF_1;

		private DrawingLayer drawingLayer_0;

		private PanelPassport panelPassport_0;

		public System.Windows.Forms.Timer tFlash;

		private SqlTransaction sqlTransaction_0;

		private bool bool_10;

		private List<int> list_8;

		private IContainer icontainer_0;

		private StatusStrip statusStrip;

		private ToolStripStatusLabel labelMousePosition;

		public PrintDocument printDocument;

		public PrintPreviewDialog printPreviewDialog;

		internal Class22 class22_0;

		private PropertyGrid propertyGrid1;

		private Button bigBoldButton;

		private ToolStripStatusLabel GihsIhiuKn;

		private ToolStripStatusLabel labelProgressBar;

		private ToolStripProgressBar toolProgressBarSave;

		private Button buttonCheck;

		private ToolStripStatusLabel labelInfo;

		private System.Windows.Forms.Timer timer_1;

		private Label tbPopup;

		private ToolStripSplitButton toolBtnZoom;

		private ToolStripMenuItem toolBtnZoom800;

		private ToolStripMenuItem toolBtnZoom400;

		private ToolStripMenuItem toolBtnZoom200;

		private ToolStripMenuItem toolBtnZoom150;

		private ToolStripMenuItem toolBtnZoom125;

		private ToolStripMenuItem toolBtnZoom100;

		private ToolStripMenuItem toolBtnZoom75;

		private ToolStripMenuItem toolBtnZoom50;

		private ToolStripMenuItem toolBtnZoom25;

		private ContextMenuStrip contextMenuSelectedObjects;

		private ToolStripMenuItem toolMenuItemDeleteSelectedObjects;

		private ToolStripMenuItem toolMenuItemFilterSelectedObjects;

		private ToolStripMenuItem toolMenuItemCenterSElectedObjects;

		private ToolStripMenuItem toolMenuItemAddFilterSelectedObjects;

		private ToolStripMenuItem toolMenuItemDeleteFilterSelectedObjects;

		private ContextMenuStrip contextMenuRectnagle;

		private ToolStripMenuItem toolMenuItemRectProperty;

		private ToolStripMenuItem twFspjsly3;

		private ToolStripMenuItem toolMenuItemRectRecipientsPower;

		private ToolStripSeparator toolStripSeparator1;

		private ToolStripMenuItem toolMenuItemRectAlign;

		private ToolStripMenuItem toolMenuItemRectDel;

		private ToolStripSeparator toolStripSeparator2;

		private ContextMenuStrip contextMenuShina;

		private ToolStripMenuItem toolMenuItemShinaPowerSource;

		private ToolStripMenuItem toolMenuItemShinaRecipientsPower;

		private ToolStripSeparator toolStripSeparator3;

		private ToolStripMenuItem toolMenuItemShinaDel;

		private ToolStripSeparator toolStripSeparatorEditShina;

		private ToolStripMenuItem toolMenuItemShinaProperty;

		private ToolStripMenuItem toolMenuItemShinaAddChild;

		private ToolStripMenuItem toolMenuItemShinaAddCell;

		private ToolStripMenuItem toolMenuItemShinaBridge;

		private ToolStripMenuItem toolMenuItemShinaSplitter;

		private ContextMenuStrip contextMenuSwitchTool;

		private ToolStripMenuItem toolMenuItemSwitchDel;

		private ToolStripSeparator toolStripSeparator5;

		private ToolStripMenuItem MSMZJEXRVG;

		private ContextMenuStrip contextMenuLineTool;

		private ToolStripMenuItem toolMenuItemLineAddChild;

		private ToolStripMenuItem toolMenuItemLineAddBranch;

		private ToolStripMenuItem toolMenuItemLineAddPoint;

		private ToolStripSeparator toolStripSeparatorLineAddBranchPoint;

		private ToolStripMenuItem toolMenuItemLineDel;

		private ToolStripMenuItem toolMenuItemLineAddOutsideLineDisconnector;

		private ToolStripMenuItem toolMenuItemLineAddVacuumSwitch;

		private ToolStripMenuItem toolMenuItemLineAddTransformer;

		private ToolStripMenuItem toolMenuItemLineAddLoadSwitch;

		private ToolStripMenuItem toolMenuItemLineAddLinearDisconnector;

		private ToolStripMenuItem toolMenuItemLineAddLubricantDisconnector;

		private ToolStripSeparator toolStripSeparator6;

		private ToolStripMenuItem toolMenuItemAddLineText;

		private ToolStripSeparator toolStripSeparatorSetStatus;

		private ToolStripMenuItem toolMenuItemLineRecipientsPower;

		private ToolStripSeparator toolStripSeparator8;

		private ToolStripMenuItem toolMenuItemLinePropertyBranch;

		private ToolStripMenuItem toolMenuItemLineProperty;

		private ToolStripSeparator toolStripSeparatorEditLine;

		private ToolStripMenuItem toolMenuItemLineSetStatus;

		private ToolStripMenuItem toolMenuItemLineSetStatusGrounding;

		private ToolStripMenuItem toolMenuItemLineSetStatusBrakeDown;

		private ToolStripMenuItem toolMenuItemLineSetStatusOff;

		private ToolStripMenuItem toolMenuItemLineSetStatusNoPhased;

		private ToolStripMenuItem toolMenuItemLineDelObj;

		private ToolStripMenuItem toolMenuItemLineDelPoint;

		private ToolStripMenuItem toolMenuItemLineTextHere;

		private ToolStripSeparator toolStripSeparatorLineTextHere;

		private ToolStripSeparator toolStripSeparator10;

		private ToolStripMenuItem toolMenuItemRectFilter;

		private ToolStripMenuItem toolMenuItemRectFilterAdd;

		private ToolStripMenuItem toolMenuItemRectFilterDel;

		private ToolStripMenuItem toolMenuItemShinaFilter;

		private ToolStripMenuItem toolMenuItemShinaFilterAdd;

		private ToolStripMenuItem toolMenuItemShinaFilterDel;

		private ToolStripSeparator toolStripSeparator11;

		private ToolStripMenuItem toolMenuItemSwitchFilter;

		private ToolStripMenuItem toolMenuItemSwitchFilterAdd;

		private ToolStripMenuItem toolMenuItemSwitchFilterDel;

		private ToolStripSeparator toolStripSeparator12;

		private ToolStripMenuItem toolMenuItemLineFilter;

		private ToolStripMenuItem toolMenuItemLineFilterAdd;

		private ToolStripMenuItem toolMenuItemLineFilterDel;

		private ToolStripSeparator toolMenuItemLinePowerSource;

		private ToolStripMenuItem toolMenuItemLinePropertyPoint;

		private ToolStripMenuItem toolMenuItemStateDel;

		private ToolStripMenuItem toolStripMenuItem1;

		private ToolStripMenuItem toolStripMenuItem2;

		private ToolStripMenuItem toolStripMenuItem3;

		private ToolStripMenuItem toolStripMenuItem5;

		private ToolStripMenuItem toolStripMenuItem4;

		private ToolStripMenuItem toolStripMenuItem6;

		private ToolStripMenuItem toolStripMenuItem8;

		private ToolStripMenuItem toolStripMenuItem7;

		private ToolStripMenuItem toolStripMenuItem9;

		private ToolStripMenuItem toolMenuItemSwitchOn;

		private ToolStripTextBox toolTxtZoomChanged;

		private ToolStripMenuItem toolStripMenuItemBookmark;

		private ToolStripMenuItem toolStripMenuItemRemoveBookmark;

		private ToolStripMenuItem toolStripMenuItemAllPower;

		private ToolStripMenuItem toolStripMenuItem10;

		private ToolStripSeparator toolStripSeparator4;

		private ToolStripSeparator toolStripSeparator9;

		private ToolStripMenuItem toolMenuItemSelectedPowerBullshit;

		private ToolStripSeparator toolStripSeparator13;

		private ToolStripMenuItem toolMenuItemCopySelectedObjects;

		private ContextMenuStrip contextMenuCanvas;

		private ToolStripMenuItem toolMenuCanvasPaste;

		private ToolStripMenuItem toolMenuItemRectCopy;

		private ToolStripMenuItem toolMenuItemShinaCopy;

		private ToolStripMenuItem toolMenuItemSwitchCopy;

		private ToolStripMenuItem toolMenuItemLineCopy;

		private ToolStripMenuItem uBbItwaYjM;

		private ToolStripMenuItem toolMenuItemPasteSelectedObjects;

		private ToolStripMenuItem toolMenuItemRectPaste;

		private ToolStripMenuItem toolMenuItemShinaPaste;

		private ToolStripMenuItem toolStripMenuItem11;

		private ToolStripMenuItem toolMenuItemLineAddFuseTool;

		private ToolStripMenuItem toolMenuItemLineAddDischargerTool;

		private ToolStripMenuItem toolMenuItemLineAddVoltageLimetedTool;

		private ToolStripMenuItem toolMenuItemLineAddVoltageTransformer;

		private ToolStripMenuItem toolStripMenuItemAdjacentSubstation;

		private ToolStripStatusLabel toolStripStatusLabelConnected;

		private ImageList imageList_0;

		private ToolStripMenuItem toolMenuItemAddNode;

		private ContextMenuStrip contextMenuLabelTool;

		private ToolStripMenuItem toolMenuItemLabelDel;

		private ToolStripMenuItem toolMenuItemLabelProperty;

		private ToolStripMenuItem toolMenuItemLineSetStatusArrow;

		private ToolStripMenuItem toolStripMenuItemAdjacentSubstation2;

		private ToolStripMenuItem toolStripMenuItemLineAlignBranch;

		private ToolStripMenuItem toolStripMenuItemAlignBranchByTop;

		private ToolStripMenuItem toolStripMenuItemAlignBranchByBottom;

		private ToolStripMenuItem toolStripMenuItemAlignBranchByRigth;

		private ToolStripMenuItem toolStripMenuItemAlignBranchByLeft;

		private ToolStripSeparator toolStripSeparator14;

		private ToolStripMenuItem toolMenuItemSelectedAlign;

		private ToolStripMenuItem toolMenuItemSelectedAlignByTop;

		private ToolStripMenuItem toolMenuItemSelectedAlignByBottom;

		private ToolStripMenuItem toolMenuItemSelectedAlignByRigth;

		private ToolStripMenuItem toolMenuItemSelectedAlignByLeft;

		private ToolStripMenuItem toolMenuItemSelectedAlignByHorCenter;

		private ToolStripMenuItem toolMenuItemSelectedAlignByVertCenter;

		private ToolStripMenuItem toolStripMenuItemAddWhitePoint;

		private ContextMenuStrip contextMenuStripWhitePoint;

		private ToolStripMenuItem toolStripMenuItemRemoveWhitePoint;

		private ToolStripMenuItem toolStripMenuItemRectanglePosition;

		private ToolStripMenuItem toolStripMenuItemReflect;

		private ToolStripMenuItem toolStripMenuItemRotateRectangle;

		private ToolStripMenuItem toolStripMenuItemRotate90;

		private ToolStripMenuItem toolStripMenuItemRotate180;

		private ToolStripMenuItem toolStripMenuItemRotate170;

		private ToolStripMenuItem toolStripMenuItemVReflect;

		private ToolStripMenuItem toolStripMenuItemHReflect;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItemDisconnectLine;

		private ToolStripMenuItem toolMenuItemLineAddEndTrim;

		private ToolStripMenuItem toolMenuItemLineAddGroundingTool;

		private ToolStripMenuItem toolMenuItemLineAddCircuitBreakerTool;

		private ToolStripMenuItem toolMeniItemShinaAddPattern;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve;

		private ToolStripMenuItem oGyhJxxeRR;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn2;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn3;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn4;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn5;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn6;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn7;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn8;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn9;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn10;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve1;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve2;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve3;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve4;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve5;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve6;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve7;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve8;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve9;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve10;

		private PageSetupDialog pageSetupDialog_0;

		public PrintDialog printDialog;

		private ToolStripMenuItem toolStripMenuItemOOLDisplayGrLevel;

		private ToolStripMenuItem toolStripMenuItemDevideLine;

		private ToolStripMenuItem toolStripMenuItemGroupProperty;

		private ToolStripSeparator toolStripSeparatorGroup;

		private ToolStripMenuItem toolStripMenuItemGroupSelectedObject;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto1;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto2;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto3;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto4;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto5;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto6;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto7;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto8;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto9;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto10;

		private ToolStripMenuItem toolMenuItemLineRelayProtection;

		private ToolStripMenuItem toolMenuItemLineAddRPS;

		private ToolStripMenuItem toolStripMenuItemAddAmperageTransformerTool;

		private ToolStripMenuItem toolMenuItemCopySelectedObjectsToImage;

		private ContextMenuStrip contextMenuFrame;

		private ToolStripMenuItem toolStripMenuFramePrint;

		private ToolStripMenuItem toolStripMenuFrameCopyToImage;

		private ToolStripMenuItem toolStripMenuFrameFitZoom;

		private ToolStripMenuItem toolMenuItemLineLogDispatcher;

		private ToolStripMenuItem toolMenuItemSwitchLogDispatcher;

		private ToolStripMenuItem toolMenuItemExportSelectedObjectsToDXF;

		private ToolStripMenuItem toolStripMenuFrameExportToImage;

		private ToolStripMenuItem toolMenuItemLineLinkPassport;

		private ToolStripMenuItem toolMenuItemLinePassport;

		private ToolStripMenuItem toolMenuItemSwitchPassport;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS1;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS2;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS3;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS4;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS5;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS6;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS7;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS8;

		private ToolStripMenuItem EhkrgnfgYC;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS10;

		private ToolStripMenuItem toolMenuItemLineAddLinearDisconnectorWaxwork;

		private ToolStripMenuItem toolMenuItemLineAddSeparatorTool;

		private ToolStripMenuItem toolStripMenuItemCSNormalMode;

		private ToolStripSeparator toolStripSeparatorCS;

		private ToolStripMenuItem toolStripMenuItemCSRollingOut;

		private ToolStripMenuItem toolStripMenuItemCSRepairMode;

		private ToolStripMenuItem toolStripMenuItemCSTestMode;

		private TextBox textBoxSearch;

		private Button button1;

		private ToolStripMenuItem toolStripMenuItemShinaGetOldAbn;

		private ToolStripMenuItem toolStripMenuItemShinaOldAbnCurrentRect;

		private ToolStripMenuItem toolStripMenuItemShinaOldAbnNextRect;

		private ToolStripMenuItem toolStripMenuItem12;

		private ToolStripMenuItem toolStripMenuItem13;

		private ToolStripMenuItem toolStripMenuItem14;

		private ToolStripMenuItem toolMenuItemRectFile;

		private ToolStripMenuItem toolMenuItemShinaFile;

		private ToolStripMenuItem toolMenuItemSwitchFile;

		private ToolStripMenuItem toolMenuItemLineFile;

		private ToolStripMenuItem toolMenuItemLineDeLinkPassport;

		private ToolStripMenuItem toolStripMenuItemAddFreeLabel;

		private ToolStripMenuItem QyjrxReCs8;

		private ToolStripMenuItem toolMenuItemLabelUpdate;

		private ToolStripMenuItem toolStripMenuItemAddTelemetryLabel2Level;

		private ToolStripMenuItem toolStripMenuItemSwitchAddTelemetry;

		private ToolStripMenuItem toolMenuItemLineAddLoadSwitchWaxwork;

		private ToolStripMenuItem ToolStripMenuItemSwitchMeasurement;

		private ContextMenuStrip contextMenuTextBranchTool;

		private ToolStripMenuItem reArSpApSW;

		private ToolStripMenuItem toolMenuItemTextBranchDel;

		private ToolStripMenuItem WcgruJuvXg;

		private ToolStripMenuItem waWrHaQms2;

		private ToolStripMenuItem ldtrvofZuY;

		private ToolStripSeparator toolStripSeparator7;

		private ToolStripMenuItem toolStripMenuItemBusMeasurement;

		private ToolStripMenuItem toolStripMenuItemAddMagneticStarterTool;

		private ToolStripMenuItem toolStripMenuItemAddElectricMeter;

		private ToolStripMenuItem toolMenuItemSwitchErcloud;

		private ToolStripMenuItem toolMenuItemSwitchLinkErcloud;

		private ToolStripMenuItem toolMenuItemSwitchShowDataErcloud;

		private ToolStripMenuItem toolStripMenuChangeArrowDirection;

		private ToolStripMenuItem toolMenuItemLinePassportOpen;

		private ToolStripMenuItem toolStripMenuItemTBTDisplayGrLevel;

		public Dictionary<int, PointTool> loadedPoints;

		[CompilerGenerated]
		private int int_4;

		private Class19 class19_0;

		private OPCClient opcclient_0;

		public bool isPrintFrame;

		internal bool bool_11;

		private int int_5;

		private int int_6;

		private int int_7;

		private Bitmap bitmap_0;

		[CompilerGenerated]
		private WorkerCanvasPrint workerCanvasPrint_0;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private string string_4;

		internal Enum4 enum4_0;

		private int int_8;

		private CanvasControl canvasControl_0;

		private delegate void Delegate31(bool visible);

		public delegate void AsyncAction();

		public delegate void DispatcherInvoker(CanvasControl.AsyncAction a);

		private delegate void Delegate32();

		public enum SetObjectsInCenterScreenOptions
		{
			none,
			select,
			flashing
		}
	}
}
