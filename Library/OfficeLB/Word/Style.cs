using System;

namespace OfficeLB.Word
{
	public class Style : Base
	{
		public Style()
		{
			
			
		}

		public Style(object oStyle)
		{
			
			base.ctor(oStyle);
		}

		public bool AutomaticallyUpdate
		{
			get
			{
				return (bool)this.GetProperty("AutomaticallyUpdate", null);
			}
			set
			{
				this.SetProperty("AutomaticallyUpdate", new object[]
				{
					value
				});
			}
		}

		public Borders Borders
		{
			get
			{
				return new Borders(this.GetProperty("Borders", null));
			}
		}

		public bool BuiltIn
		{
			get
			{
				return (bool)this.GetProperty("BuiltIn", null);
			}
			set
			{
				this.SetProperty("BuiltIn", new object[]
				{
					value
				});
			}
		}

		public string Description
		{
			get
			{
				return this.GetProperty("Description", null).ToString();
			}
		}

		public Font Font
		{
			get
			{
				return new Font(this.GetProperty("Font", null));
			}
			set
			{
				this.SetProperty("Font", new object[]
				{
					value
				});
			}
		}

		public Frame Frame
		{
			get
			{
				return new Frame(this.GetProperty("Frame", null));
			}
		}

		public bool InUse
		{
			get
			{
				return (bool)this.GetProperty("InUse", null);
			}
			set
			{
				this.SetProperty("InUse", new object[]
				{
					value
				});
			}
		}

		public WdLanguageID LanguageID
		{
			get
			{
				return (WdLanguageID)this.GetProperty("LanguageID", null);
			}
			set
			{
				this.SetProperty("LanguageID", new object[]
				{
					value
				});
			}
		}

		public string NameLocal
		{
			get
			{
				return this.GetProperty("NameLocal", null).ToString();
			}
			set
			{
				this.GetProperty("NameLocal", new object[]
				{
					value
				});
			}
		}

		public bool NoProofing
		{
			get
			{
				return (bool)this.GetProperty("NoProofing", null);
			}
			set
			{
				this.SetProperty("NoProofing", new object[]
				{
					value
				});
			}
		}

		public bool NoSpaceBetween
		{
			get
			{
				return (bool)this.GetProperty("NoSpaceBetween", null);
			}
			set
			{
				this.SetProperty("NoSpaceBetween", new object[]
				{
					value
				});
			}
		}

		public ParagraphFormat ParagraphFormat
		{
			get
			{
				return new ParagraphFormat(this.GetProperty("ParagraphFormat", null));
			}
			set
			{
				this.SetProperty("ParagraphFormat", new object[]
				{
					value
				});
			}
		}

		public Shading Shading
		{
			get
			{
				return new Shading(this.GetProperty("Shading", null));
			}
		}

		public WdStyleType Type
		{
			get
			{
				return (WdStyleType)this.GetProperty("Type", null);
			}
			set
			{
				this.SetProperty("Type", new object[]
				{
					value
				});
			}
		}
	}
}
