using System;

namespace OfficeLB.Word
{
	public class Tables : Base
	{
		public Tables()
		{
			
			
		}

		public Tables(object oTables)
		{
			
			base.ctor(oTables);
		}

		public Table Add(Range range, int row, int column)
		{
			return new Table(this.InvokeReturn("Add", new object[]
			{
				range,
				row,
				column
			}));
		}

		public void Add(Range range, int row, int column, WdDefaultTableBehavior table_behavior, WdAutoFitBehavior fit_behavior)
		{
			this.InvokeMethod("Add", new object[]
			{
				range,
				row,
				column,
				table_behavior,
				fit_behavior
			});
		}

		public Table this[int item]
		{
			get
			{
				return new Table(this.InvokeReturn("Item", new object[]
				{
					item
				}));
			}
		}

		public bool ApplyStyleFirstColumn
		{
			get
			{
				return (bool)this.GetProperty("ApplyStyleFirstColumn", null);
			}
			set
			{
				this.SetProperty("ApplyStyleFirstColumn", new object[]
				{
					value
				});
			}
		}

		public bool ApplyStyleHeadingRows
		{
			get
			{
				return (bool)this.GetProperty("ApplyStyleHeadingRows", null);
			}
			set
			{
				this.SetProperty("ApplyStyleHeadingRows", new object[]
				{
					value
				});
			}
		}

		public bool ApplyStyleLastRow
		{
			get
			{
				return (bool)this.GetProperty("ApplyStyleLastRow", null);
			}
			set
			{
				this.SetProperty("ApplyStyleLastRow", new object[]
				{
					value
				});
			}
		}

		public bool ApplyStyleLastColumn
		{
			get
			{
				return (bool)this.GetProperty("ApplyStyleLastColumn", null);
			}
			set
			{
				this.SetProperty("ApplyStyleLastColumn", new object[]
				{
					value
				});
			}
		}

		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
			set
			{
				this.SetProperty("Count", new object[]
				{
					value
				});
			}
		}

		public Enum DefaultTableBehavior
		{
			get
			{
				return (Enum)this.GetProperty("DefaultTableBehavior", null);
			}
			set
			{
				this.SetProperty("DefaultTableBehavior", new object[]
				{
					value
				});
			}
		}

		public Cells Cells
		{
			get
			{
				return new Cells(this.GetProperty("Cells", null));
			}
		}

		public Columns Columns
		{
			get
			{
				return new Columns(this.GetProperty("Columns", null));
			}
		}

		public Rows Rows
		{
			get
			{
				return new Rows(this.GetProperty("Rows", null));
			}
		}
	}
}
