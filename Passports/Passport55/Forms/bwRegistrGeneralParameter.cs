﻿using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Passport.Forms
{
	public class bwRegistrGeneralParameter
	{
		public Columns Columns { get; set; }

		public DataTable Table { get; set; }

		public bwRegistrGeneralParameter(Columns columns, DataTable table)
		{
			this.Columns = columns;
			this.Table = table;
		}

		[CompilerGenerated]
		private Columns columns_0;

		[CompilerGenerated]
		private DataTable dataTable_0;
	}
}