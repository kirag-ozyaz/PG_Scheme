using System;

namespace OfficeLB.Word
{
	public class Replacement : Base
	{
		public Replacement()
		{
			
			
		}

		public Replacement(object oReplacement)
		{
			
			base.ctor(oReplacement);
		}

		public Application Application
		{
			get
			{
				return (Application)this.GetProperty("Application", null);
			}
		}

		public Font Font
		{
			get
			{
				return new Font(this.GetProperty("Font", null));
			}
		}

		public Frame Frame
		{
			get
			{
				return new Frame(this.GetProperty("Frame", null));
			}
		}

		public ParagraphFormat ParagraphFormat
		{
			get
			{
				return new ParagraphFormat(this.GetProperty("ParagraphFormat", null));
			}
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

		public bool Highlight
		{
			get
			{
				return (bool)this.GetProperty("Highlight", null);
			}
			set
			{
				this.SetProperty("Highlight", new object[]
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

		public WdLanguageID LanguageIDFarEast
		{
			get
			{
				return (WdLanguageID)this.GetProperty("LanguageIDFarEast", null);
			}
			set
			{
				this.SetProperty("LanguageIDFarEast", new object[]
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

		public object Style
		{
			get
			{
				return this.GetProperty("Style", null);
			}
			set
			{
				this.SetProperty("Style", new object[]
				{
					value
				});
			}
		}

		public string Text
		{
			get
			{
				return this.GetProperty("Text", null).ToString();
			}
			set
			{
				this.SetProperty("Text", new object[]
				{
					value
				});
			}
		}

		public void ClearFormatting()
		{
			this.InvokeMethod("ClearFormatting", null);
		}
	}
}
