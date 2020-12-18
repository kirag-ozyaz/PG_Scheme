using System;
using System.Collections.Generic;
using Passport.DataSets;

internal class Class4 : IEqualityComparer<dsPassport.Class5>
{
	public bool Equals(dsPassport.Class5 class5_0, dsPassport.Class5 class5_1)
	{
		return class5_0 == class5_1 || (class5_0 != null && class5_1 != null && (class5_0.Id == class5_1.Id && class5_0.IdParent == class5_1.IdParent && class5_0.Name == class5_1.Name && class5_0.ParentKey == class5_1.ParentKey) && class5_0.TypeCodeId == class5_1.TypeCodeId);
	}

	public int GetHashCode(dsPassport.Class5 data)
	{
		if (data == null)
		{
			return 0;
		}
		int num = (data.Name == null) ? 0 : data.Name.GetHashCode();
		int hashCode = data.Id.GetHashCode();
		return num ^ hashCode;
	}
}
