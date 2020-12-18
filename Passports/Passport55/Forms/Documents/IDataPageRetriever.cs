using System;
using System.Data;

namespace Passport.Forms.Documents
{
	public interface IDataPageRetriever
	{
		DataTable SupplyPageOfData(int lowerPageBoundary, int rowsPerPage);
	}
}
