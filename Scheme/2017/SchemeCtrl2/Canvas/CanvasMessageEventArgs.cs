﻿using System;
using System.Collections.Generic;
using System.Data;
using SchemeCtrl2.DrawTool;
using Telemetry;

namespace SchemeCtrl2.Canvas
{
	public class CanvasMessageEventArgs : EventArgs
	{
		public CanvasMessageEventArgs(string messageText, eMessageType messageType)
		{
			Class90.TDroV38zslI2T();
			this.list_0 = new List<DrawObjectBase>();
			this.string_0 = string.Empty;
			base..ctor();
			this.string_0 = messageText;
			this.eMessageType_0 = messageType;
		}

		public CanvasMessageEventArgs(DrawObjectBase messageObject, string messageText, eMessageType messageType)
		{
			Class90.TDroV38zslI2T();
			this.list_0 = new List<DrawObjectBase>();
			this.string_0 = string.Empty;
			base..ctor();
			this.list_0.Add(messageObject);
			this.string_0 = messageText;
			this.eMessageType_0 = messageType;
		}

		public CanvasMessageEventArgs(List<DrawObjectBase> messageObjects, string messageText, eMessageType messageType)
		{
			Class90.TDroV38zslI2T();
			this.list_0 = new List<DrawObjectBase>();
			this.string_0 = string.Empty;
			base..ctor();
			this.list_0 = messageObjects;
			this.string_0 = messageText;
			this.eMessageType_0 = messageType;
		}

		public CanvasMessageEventArgs(List<DrawObjectBase> messageObjects, eMessageType messageType, OPCMessage telemetryMessage)
		{
			Class90.TDroV38zslI2T();
			this.list_0 = new List<DrawObjectBase>();
			this.string_0 = string.Empty;
			base..ctor();
			this.list_0 = messageObjects;
			this.eMessageType_0 = messageType;
			this.opcmessage_0 = telemetryMessage;
		}

		public CanvasMessageEventArgs(DrawObjectBase messageObject, string messageText, eMessageType messageType, DataTable logDispather)
		{
			Class90.TDroV38zslI2T();
			this.list_0 = new List<DrawObjectBase>();
			this.string_0 = string.Empty;
			base..ctor();
			this.list_0.Clear();
			this.list_0.Add(messageObject);
			this.string_0 = messageText;
			this.eMessageType_0 = messageType;
			this.dataTable_0 = logDispather;
		}

		public List<DrawObjectBase> MessageObjects
		{
			get
			{
				return this.list_0;
			}
		}

		public string MessageText
		{
			get
			{
				return this.string_0;
			}
		}

		public eMessageType MessageType
		{
			get
			{
				return this.eMessageType_0;
			}
		}

		public OPCMessage TelemetryMessage
		{
			get
			{
				return this.opcmessage_0;
			}
			set
			{
				this.opcmessage_0 = value;
			}
		}

		public DataTable LogDispatcher
		{
			get
			{
				return this.dataTable_0;
			}
		}

		public override string ToString()
		{
			return this.string_0;
		}

		private List<DrawObjectBase> list_0;

		private string string_0;

		private eMessageType eMessageType_0;

		private OPCMessage opcmessage_0;

		private DataTable dataTable_0;
	}
}
