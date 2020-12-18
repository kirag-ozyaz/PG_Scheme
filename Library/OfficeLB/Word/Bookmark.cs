using System;

namespace OfficeLB.Word
{
	public class Bookmark : Base
	{
		public Bookmark()
		{
			
			
		}

		public Bookmark(object oBookmark)
		{
			
			base.ctor(oBookmark);
		}

		public Bookmark Copy(string text)
		{
			return new Bookmark(this.InvokeReturn("Copy", new object[]
			{
				text
			}));
		}

		public void Delete()
		{
			this.InvokeMethod("Delete", null);
		}

		public void Select()
		{
			this.InvokeMethod("Select", null);
		}

		public Application Application
		{
			get
			{
				return (Application)this.GetProperty("Application", null);
			}
		}

		public bool Column
		{
			get
			{
				return (bool)this.GetProperty("Column", null);
			}
		}

		public int Creator
		{
			get
			{
				return (int)this.GetProperty("Creator", null);
			}
		}

		public bool Empty
		{
			get
			{
				return (bool)this.GetProperty("Empty", null);
			}
		}

		public int End
		{
			get
			{
				return (int)this.GetProperty("End", null);
			}
			set
			{
				this.SetProperty("End", new object[]
				{
					value
				});
			}
		}

		public string Name
		{
			get
			{
				return this.GetProperty("Name", null).ToString();
			}
		}

		public object Parent
		{
			get
			{
				return this.GetProperty("Parent", null);
			}
		}

		public Range Range
		{
			get
			{
				return new Range(this.GetProperty("Range", null));
			}
		}

		public int Start
		{
			get
			{
				return (int)this.GetProperty("Start", null);
			}
			set
			{
				this.SetProperty("Start", new object[]
				{
					value
				});
			}
		}

		public WdStoryType StoryType
		{
			get
			{
				return (WdStoryType)this.GetProperty("StoryType", null);
			}
		}
	}
}
