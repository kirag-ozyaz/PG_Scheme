using System;

namespace OfficeLB.Word
{
	public class FileSearch : Base
	{
		public FileSearch()
		{
			
			
		}

		public FileSearch(object oFileSearch)
		{
			
			base.ctor(oFileSearch);
		}

		public string FileName
		{
			get
			{
				return this.GetProperty("FileName", null).ToString();
			}
			set
			{
				this.SetProperty("FileName", new object[]
				{
					value
				});
			}
		}

		public string LookIn
		{
			get
			{
				return this.GetProperty("LookIn", null).ToString();
			}
			set
			{
				this.SetProperty("LookIn", new object[]
				{
					value
				});
			}
		}

		public FoundFiles FoundFiles
		{
			get
			{
				return new FoundFiles(this.GetProperty("FoundFiles", null));
			}
		}

		public bool SearchSubFolders
		{
			get
			{
				return bool.Parse(this.GetProperty("SearchSubFolders", null).ToString());
			}
			set
			{
				this.SetProperty("SearchSubFolders", new object[]
				{
					value
				});
			}
		}

		public int Execute()
		{
			return (int)this.InvokeReturn("Execute", null);
		}

		public int Execute(MsoSortBy sort, MsoSortOrder order, bool state)
		{
			return (int)this.InvokeReturn("Execute", new object[]
			{
				sort,
				order,
				state
			});
		}
	}
}
