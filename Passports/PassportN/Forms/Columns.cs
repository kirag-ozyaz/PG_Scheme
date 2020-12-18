using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Passport.Forms
{
	public class Columns
	{
		public Columns()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.ColumnList = new List<Column>();
		}

		public Column this[int index]
		{
			get
			{
				return (from row in this.ColumnList
				where row.Index == index
				select row).First<Column>();
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
	}
}
