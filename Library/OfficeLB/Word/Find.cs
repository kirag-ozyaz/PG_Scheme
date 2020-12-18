using System;

namespace OfficeLB.Word
{
	public class Find : Base
	{
		public Find()
		{
			
			
		}

		public Find(object oFind)
		{
			
			base.ctor(oFind);
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

		public Replacement Replacement
		{
			get
			{
				return new Replacement(this.GetProperty("Replacement", null));
			}
		}

		public bool CorrectHangulEndings
		{
			get
			{
				return (bool)this.GetProperty("CorrectHangulEndings", null);
			}
			set
			{
				this.SetProperty("CorrectHangulEndings", new object[]
				{
					value
				});
			}
		}

		public int Creator
		{
			get
			{
				return (int)this.GetProperty("Creator", null);
			}
		}

		public bool Format
		{
			get
			{
				return (bool)this.GetProperty("Format", null);
			}
			set
			{
				this.SetProperty("Format", new object[]
				{
					value
				});
			}
		}

		public bool Forward
		{
			get
			{
				return (bool)this.GetProperty("Forward", null);
			}
			set
			{
				this.SetProperty("Forward", new object[]
				{
					value
				});
			}
		}

		public bool Found
		{
			get
			{
				return (bool)this.GetProperty("Found", null);
			}
			set
			{
				this.SetProperty("Found", new object[]
				{
					value
				});
			}
		}

		public bool HanjaPhoneticHangul
		{
			get
			{
				return (bool)this.GetProperty("HanjaPhoneticHangul", null);
			}
			set
			{
				this.SetProperty("HanjaPhoneticHangul", new object[]
				{
					value
				});
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

		public bool IgnorePunct
		{
			get
			{
				return (bool)this.GetProperty("IgnorePunct", null);
			}
			set
			{
				this.SetProperty("IgnorePunct", new object[]
				{
					value
				});
			}
		}

		public bool IgnoreSpace
		{
			get
			{
				return (bool)this.GetProperty("IgnoreSpace", null);
			}
			set
			{
				this.SetProperty("IgnoreSpace", new object[]
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

		public WdLanguageID LanguageIDOther
		{
			get
			{
				return (WdLanguageID)this.GetProperty("LanguageIDOther", null);
			}
			set
			{
				this.SetProperty("LanguageIDOther", new object[]
				{
					value
				});
			}
		}

		public bool MatchAlefHamza
		{
			get
			{
				return (bool)this.GetProperty("MatchAlefHamza", null);
			}
			set
			{
				this.SetProperty("MatchAlefHamza", new object[]
				{
					value
				});
			}
		}

		public bool MatchAllWordForms
		{
			get
			{
				return (bool)this.GetProperty("MatchAllWordForms", null);
			}
			set
			{
				this.SetProperty("MatchAllWordForms", new object[]
				{
					value
				});
			}
		}

		public bool MatchByte
		{
			get
			{
				return (bool)this.GetProperty("MatchByte", null);
			}
			set
			{
				this.SetProperty("MatchByte", new object[]
				{
					value
				});
			}
		}

		public bool MatchCase
		{
			get
			{
				return (bool)this.GetProperty("MatchCase", null);
			}
			set
			{
				this.SetProperty("MatchCase", new object[]
				{
					value
				});
			}
		}

		public bool MatchControl
		{
			get
			{
				return (bool)this.GetProperty("MatchControl", null);
			}
			set
			{
				this.SetProperty("MatchControl", new object[]
				{
					value
				});
			}
		}

		public bool MatchDiacritics
		{
			get
			{
				return (bool)this.GetProperty("MatchDiacritics", null);
			}
			set
			{
				this.SetProperty("MatchDiacritics", new object[]
				{
					value
				});
			}
		}

		public bool MatchFuzzy
		{
			get
			{
				return (bool)this.GetProperty("MatchFuzzy", null);
			}
			set
			{
				this.SetProperty("MatchFuzzy", new object[]
				{
					value
				});
			}
		}

		public bool MatchKashida
		{
			get
			{
				return (bool)this.GetProperty("MatchKashida", null);
			}
			set
			{
				this.SetProperty("MatchKashida", new object[]
				{
					value
				});
			}
		}

		public bool MatchPhrase
		{
			get
			{
				return (bool)this.GetProperty(" MatchPhrase", null);
			}
			set
			{
				this.SetProperty(" MatchPhrase", new object[]
				{
					value
				});
			}
		}

		public bool MatchPrefix
		{
			get
			{
				return (bool)this.GetProperty("MatchPrefix", null);
			}
			set
			{
				this.SetProperty("MatchPrefix", new object[]
				{
					value
				});
			}
		}

		public bool MatchSoundsLike
		{
			get
			{
				return (bool)this.GetProperty("MatchSoundsLike", null);
			}
			set
			{
				this.SetProperty("MatchSoundsLike", new object[]
				{
					value
				});
			}
		}

		public bool MatchSuffix
		{
			get
			{
				return (bool)this.GetProperty("MatchSuffix", null);
			}
			set
			{
				this.SetProperty("MatchSuffix", new object[]
				{
					value
				});
			}
		}

		public bool MatchWholeWord
		{
			get
			{
				return (bool)this.GetProperty("MatchWholeWord", null);
			}
			set
			{
				this.SetProperty("MatchWholeWord", new object[]
				{
					value
				});
			}
		}

		public bool MatchWildcards
		{
			get
			{
				return (bool)this.GetProperty("MatchWildcards", null);
			}
			set
			{
				this.SetProperty("MatchWildcards", new object[]
				{
					value
				});
			}
		}

		public bool NoProofing
		{
			get
			{
				return (bool)this.GetProperty(" NoProofing ", null);
			}
			set
			{
				this.SetProperty(" NoProofing ", new object[]
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

		public WdFindWrap Wrap
		{
			get
			{
				return (WdFindWrap)this.GetProperty("Wrap", null);
			}
			set
			{
				this.SetProperty("Wrap", new object[]
				{
					value
				});
			}
		}

		public void ClearAllFuzzyOptions()
		{
			this.InvokeMethod("ClearAllFuzzyOptions", null);
		}

		public void ClearFormatting()
		{
			this.InvokeMethod("ClearFormatting", null);
		}

		public void ClearHitHighlight()
		{
			this.InvokeMethod("ClearHitHighlight", null);
		}

		public bool Execute()
		{
			return (bool)this.InvokeReturn("Execute", null);
		}

		public bool Execute(string text, string replaceWith, WdFindWrap wrap, WdReplace replace)
		{
			return (bool)this.InvokeReturn("Execute", new object[]
			{
				text,
				false,
				true,
				false,
				false,
				false,
				true,
				wrap,
				false,
				replaceWith,
				replace,
				false,
				false,
				false,
				false
			});
		}

		public bool Execute(string FindText, bool MatchCase, bool MatchWholeWord, bool MatchWildcards, bool MatchSoundsLike, bool MatchAllWordForms, bool Forward, WdFindWrap Wrap, bool Format, string ReplaceWith, WdReplace Replace, bool MatchKashida, bool MatchDiacritics, bool MatchAlefHamza, bool MatchControl)
		{
			return (bool)this.InvokeReturn("Execute", new object[]
			{
				FindText,
				MatchCase,
				MatchWholeWord,
				MatchWildcards,
				MatchSoundsLike,
				MatchAllWordForms,
				Forward,
				Wrap,
				Format,
				ReplaceWith,
				Replace,
				MatchKashida,
				MatchDiacritics,
				MatchAlefHamza,
				MatchControl
			});
		}

		public void SetAllFuzzyOptions()
		{
			this.InvokeMethod("SetAllFuzzyOptions", null);
		}
	}
}
