using System;

namespace OfficeLB.Word
{
	public class Bookmarks : Base
	{
		public Bookmarks()
		{
			
			
		}

		public Bookmarks(object oBookmarks)
		{
			
			base.ctor(oBookmarks);
		}

		public Bookmark Add(string text)
		{
			return new Bookmark(this.InvokeReturn("Add", new object[]
			{
				text
			}));
		}

		public Bookmark Add(string text, Range range)
		{
			return new Bookmark(this.InvokeReturn("Add", new object[]
			{
				text,
				range
			}));
		}

		public bool Exists(string name)
		{
			return (bool)this.InvokeReturn("Exists", new object[]
			{
				name
			});
		}

		public Application Application
		{
			get
			{
				return (Application)this.GetProperty("Application", null);
			}
		}

		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
		}

		public Bookmark this[int index]
		{
			get
			{
				return new Bookmark(this.InvokeReturn("Item", new object[]
				{
					index
				}));
			}
		}

		public Bookmark this[string name]
		{
			get
			{
				return new Bookmark(this.InvokeReturn("Item", new object[]
				{
					name
				}));
			}
		}

		public int Creator
		{
			get
			{
				return (int)this.GetProperty("Creator", null);
			}
		}

		public WdBookmarkSortBy DefaultSorting
		{
			get
			{
				return (WdBookmarkSortBy)this.GetProperty("DefaultSorting", null);
			}
			set
			{
				this.SetProperty("DefaultSorting", new object[]
				{
					value
				});
			}
		}

		public object Parent
		{
			get
			{
				return this.GetProperty("Parent", null);
			}
		}

		public bool ShowHidden
		{
			get
			{
				return (bool)this.GetProperty("ShowHidden", null);
			}
			set
			{
				this.SetProperty("ShowHidden", new object[]
				{
					value
				});
			}
		}
	}
}
