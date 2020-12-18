using System;

namespace SchemeCtrl2.WCF
{
	public class SchemeEventArgs : EventArgs
	{
		public SchemeEventArgs()
		{
			
			
		}

		public int[] Consumers;

		public byte[] ConsumersOn;

		public string clientId;

		public SchemeEventType eventType;

		public int idObj;

		public int idRelation;

		public int numBranch;

		public double delta;

		public int typeState;

		public int idLineState;

		public Guid databaseGuid;

		public Guid[] consumersBaseGuid;

		public bool Cancel;
	}
}
