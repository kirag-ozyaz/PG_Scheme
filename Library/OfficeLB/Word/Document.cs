using System;

namespace OfficeLB.Word
{
	public class Document : Base
	{
		public Document()
		{
			
			
		}

		public Document(object oDocument)
		{
			
			base.ctor(oDocument);
		}

		public Range Content
		{
			get
			{
				return new Range(this.GetProperty("Content", null));
			}
		}

		public bool ConfirmConversions
		{
			get
			{
				return bool.Parse(this.GetProperty("ConfirmConversions", null).ToString());
			}
			set
			{
				this.SetProperty("ConfirmConversions", new object[]
				{
					value
				});
			}
		}

		public bool AddToRecentFiles
		{
			get
			{
				return bool.Parse(this.GetProperty("AddToRecentFiles", null).ToString());
			}
			set
			{
				this.SetProperty("AddToRecentFiles", new object[]
				{
					value
				});
			}
		}

		public bool ReadOnly
		{
			get
			{
				return bool.Parse(this.GetProperty("ReadOnly", null).ToString());
			}
			set
			{
				this.SetProperty("ReadOnly", new object[]
				{
					value
				});
			}
		}

		public bool Revert
		{
			get
			{
				return bool.Parse(this.GetProperty("Revert", null).ToString());
			}
			set
			{
				this.SetProperty("Revert", new object[]
				{
					value
				});
			}
		}

		public string FullName
		{
			get
			{
				return this.GetProperty("FullName", null).ToString();
			}
		}

		public string Name
		{
			get
			{
				return this.GetProperty("Name", null).ToString();
			}
		}

		public Paragraphs Paragraphs
		{
			get
			{
				return new Paragraphs(this.GetProperty("Paragraphs", null));
			}
		}

		public string Password
		{
			get
			{
				return this.GetProperty("Password", null).ToString();
			}
			set
			{
				this.SetProperty("Password", new object[]
				{
					value
				});
			}
		}

		public string Path
		{
			get
			{
				return this.GetProperty("Path", null).ToString();
			}
		}

		public bool PrintPreview
		{
			get
			{
				return bool.Parse(this.GetProperty("PrintPreview", null).ToString());
			}
			set
			{
				this.SetProperty("PrintPreview", new object[]
				{
					value
				});
			}
		}

		public Range Range
		{
			get
			{
				return new Range(this.InvokeReturn("Range", null));
			}
		}

		public Range Range
		{
			get
			{
				return new Range(this.InvokeReturn("Range", new object[]
				{
					startPos,
					endPos
				}));
			}
		}

		public bool Saved
		{
			get
			{
				return bool.Parse(this.GetProperty("Saved", null).ToString());
			}
			set
			{
				this.SetProperty("Saved", new object[]
				{
					value
				});
			}
		}

		public string SaveFormat
		{
			get
			{
				return this.GetProperty("SaveFormat", null).ToString();
			}
		}

		public Sections Sections
		{
			get
			{
				return new Sections(this.GetProperty("Sections", null));
			}
		}

		public Sentences Sentences
		{
			get
			{
				return new Sentences(this.GetProperty("Sentences", null));
			}
		}

		public Tables Tables
		{
			get
			{
				return new Tables(this.GetProperty("Tables", null));
			}
		}

		public void Undo(int count)
		{
			this.InvokeMethod("Undo", new object[]
			{
				3
			});
		}

		public object Variables
		{
			get
			{
				return this.GetProperty("Variables", null);
			}
		}

		public void Add()
		{
			this.InvokeMethod("Add", null);
		}

		public void Add(string fileName)
		{
			this.InvokeMethod("Add", new object[]
			{
				fileName
			});
		}

		public void Open(string fileName)
		{
			this.InvokeMethod("Open", new object[]
			{
				fileName
			});
		}

		public void PrintOut()
		{
			this.InvokeMethod("PrintOut", null);
		}

		public void Protect()
		{
			this.InvokeMethod("Protect", null);
		}

		public void Unprotect()
		{
			this.InvokeMethod("Unprotect", null);
		}

		public void SendMail(string Recipients, string Subject, bool ReturnReceipt)
		{
			this.InvokeMethod("SendMail", new object[]
			{
				Recipients,
				Subject,
				ReturnReceipt
			});
		}

		public void Save()
		{
			this.InvokeMethod("Save", null);
		}

		public void SaveAs(string fileName)
		{
			this.InvokeMethod("SaveAs", new object[]
			{
				fileName
			});
		}

		public void SetBackgroundPicture(string fileName)
		{
			this.InvokeMethod("SetBackgroundPicture", new object[]
			{
				fileName
			});
		}
	}
}
