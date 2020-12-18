using System;
using System.Collections.Generic;

internal class Class4 : IEqualityComparer<Class107.Class278>
{
	public bool Equals(Class107.Class278 x, Class107.Class278 y)
	{
		return x == y || (x != null && y != null && (x.Id == y.Id && x.IdParent == y.IdParent && x.Name == y.Name && x.ParentKey == y.ParentKey) && x.TypeCodeId == y.TypeCodeId);
	}

	public int GetHashCode(Class107.Class278 obj)
	{
		if (obj == null)
		{
			return 0;
		}
		int num = (obj.Name == null) ? 0 : obj.Name.GetHashCode();
		int hashCode = obj.Id.GetHashCode();
		return num ^ hashCode;
	}

	public Class4()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
	}
}
