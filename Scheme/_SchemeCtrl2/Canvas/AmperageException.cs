using System;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.Canvas
{
	public class AmperageException : Exception
	{
		public AmperageException(string message, DrawObjectBase sourceException) : base(message)
		{
			this.drawObjectBase_0 = sourceException;
		}

		public DrawObjectBase SourceException
		{
			get
			{
				return this.drawObjectBase_0;
			}
		}

		private DrawObjectBase drawObjectBase_0;
	}
}
