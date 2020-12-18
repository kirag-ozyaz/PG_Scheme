using System;
using System.Drawing;

namespace SchemeCtrl2.WCF
{
	public class ProxyCallBackEventArgs : EventArgs
	{
		public string clientId;

		public SchemeEventType eventType;

		public int idObj;

		public int idRelation;

		public int numBranch;

		public double delta;

		public int typeState;

		public string text;

		public PointF point;

		public Color color;

		public int idLineState;
	}
}
