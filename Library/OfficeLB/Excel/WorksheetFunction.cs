using System;

namespace OfficeLB.Excel
{
	public class WorksheetFunction : Base
	{
		public WorksheetFunction()
		{
			
			
		}

		public WorksheetFunction(object oWorksheetFunction)
		{
			
			base.ctor(oWorksheetFunction);
		}

		public Application Application
		{
			get
			{
				return new Application(this.GetProperty("Application", null));
			}
		}

		public int Creator
		{
			get
			{
				return (int)this.GetProperty("Creator", null);
			}
		}

		public object Parent
		{
			get
			{
				return this.GetProperty("Parent", null);
			}
		}

		public double AccrInt(object Arg1, object Arg2, object Arg3, object Arg4, object Arg5, object Arg6, object Arg7)
		{
			return (double)this.InvokeReturn("AccrInt", new object[]
			{
				Arg1,
				Arg2,
				Arg3,
				Arg4,
				Arg5,
				Arg6,
				Arg7
			});
		}

		public double AccrIntM(object Arg1, object Arg2, object Arg3, object Arg4, object Arg5)
		{
			return (double)this.InvokeReturn("AccrIntM", new object[]
			{
				Arg1,
				Arg2,
				Arg3,
				Arg4,
				Arg5
			});
		}

		public double Acos(double Arg1)
		{
			return (double)this.InvokeReturn("Acos", new object[]
			{
				Arg1
			});
		}

		public void method_0()
		{
		}
	}
}
