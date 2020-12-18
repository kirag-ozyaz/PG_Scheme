using System;

namespace SchemeCtrl2.WCF
{
	public class SchemeEventArgs : EventArgs
	{
		public string clientId;

		public SchemeEventType eventType;

		public int idObj;

		public int idRelation;

		public int numBranch;

		public double delta;

		public int typeState;

		public int idLineState;
	}
}
