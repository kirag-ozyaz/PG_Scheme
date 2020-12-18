using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class Class0<T>
{
	public T Name
	{
		get
		{
			return this.gparam_0;
		}
	}

	[DebuggerHidden]
	public Class0(T gparam_1)
	{
		this.gparam_0 = gparam_1;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		Class0<T> @class = value as Class0<T>;
		return @class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0);
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -818244610 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Name = {0} }}";
		object[] array = new object[1];
		int num = 0;
		T t = this.gparam_0;
		ref T ptr = ref t;
		T t2 = default(T);
		object obj;
		if (t2 == null)
		{
			t2 = t;
			ptr = ref t2;
			if (t2 == null)
			{
				obj = null;
				goto IL_46;
			}
		}
		obj = ptr.ToString();
		IL_46:
		array[num] = obj;
		return string.Format(provider, format, array);
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;
}
