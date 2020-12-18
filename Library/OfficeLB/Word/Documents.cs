using System;

namespace OfficeLB.Word
{
	public class Documents : Base
	{
		public Documents()
		{
			
			
		}

		public Documents(object oDocuments)
		{
			
			base.ctor(oDocuments);
		}

		public Application Application
		{
			get
			{
				return (Application)this.GetProperty("Application", null);
			}
		}

		public Document Add()
		{
			return new Document(this.InvokeReturn("Add", null));
		}

		public Document Add(string fileName)
		{
			return new Document(this.InvokeReturn("Add", new object[]
			{
				fileName
			}));
		}

		public Document Open(string fileName)
		{
			return new Document(this.InvokeReturn("Open", new object[]
			{
				fileName
			}));
		}

		public Document Open(string fileName, bool readOnly)
		{
			return new Document(this.InvokeReturn("Open", new object[]
			{
				fileName,
				readOnly
			}));
		}

		public Document this[int index]
		{
			get
			{
				return new Document(this.InvokeReturn("Item", new object[]
				{
					index
				}));
			}
		}

		public Document this[string name]
		{
			get
			{
				return new Document(this.InvokeReturn("Item", new object[]
				{
					name
				}));
			}
		}

		public Document Document(int index)
		{
			return new Document(this.GetProperty("Item", new object[]
			{
				index
			}));
		}

		public Document Document(string name)
		{
			return new Document(this.GetProperty("Item", new object[]
			{
				name
			}));
		}

		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
		}

		public void Close(WdSaveOptions option, WdOriginalFormat format, bool routeDocument)
		{
			this.InvokeMethod("Close", new object[]
			{
				option,
				format,
				routeDocument
			});
		}

		public void Save(bool save, WdOriginalFormat format)
		{
			this.InvokeMethod("Save", new object[]
			{
				save,
				format
			});
		}

		public bool CanCheckOut
		{
			get
			{
				return (bool)this.GetProperty("CanCheckOut", null);
			}
			set
			{
				this.SetProperty("CanCheckOut", new object[]
				{
					value
				});
			}
		}

		public void CheckOut(string fileNmame)
		{
			this.InvokeMethod("CheckOut", new object[]
			{
				fileNmame
			});
		}

		public object Parent
		{
			get
			{
				return this.GetProperty("Parent", null);
			}
		}

		public int Creator
		{
			get
			{
				return (int)this.GetProperty("Creator", null);
			}
		}

		public void AddBlogDocument(string providerID, string postURL, string blogName, string postID)
		{
			this.InvokeMethod("AddBlogDocument", new object[]
			{
				providerID,
				postURL,
				blogName,
				postID
			});
		}
	}
}
