using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Passport.Forms
{
	public class Columns
	{
		public Columns()
		{
			this.ColumnList = new List<Column>();
		}

		public Column this[int index]
		{
			get
			{
				Columns.Class127 @class = new Columns.Class127();
				@class.int_0 = index;
				return this.ColumnList.Where(new Func<Column, bool>(@class.method_0)).First<Column>();
			}
		}

		public int Count
		{
			get
			{
				return this.ColumnList.Count;
			}
		}

		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		public IEnumerator GetEnumerator()
		{
			return this.ColumnList.GetEnumerator();
		}

		public void Add(Column newColumn)
		{
			this.ColumnList.Add(newColumn);
		}

		[XmlArray("ColumnListing")]
		[XmlArrayItem("Columns", typeof(Column))]
		public List<Column> ColumnList;

		[CompilerGenerated]
		private sealed class Class127
		{
			internal bool method_0(Column column_0)
			{
				return column_0.Index == this.int_0;
			}

			public int int_0;
		}
	}
}
