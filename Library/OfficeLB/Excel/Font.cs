using System;

namespace OfficeLB.Excel
{
	public class Font : Base
	{
		public double Size
		{
			get
			{
				return (double)this.GetProperty("Size", null);
			}
			set
			{
				this.SetProperty("Size", new object[]
				{
					value
				});
			}
		}

		public string FontStyle
		{
			get
			{
				return (string)this.GetProperty("FontStyle", null);
			}
			set
			{
				this.SetProperty("FontStyle", new object[]
				{
					value
				});
			}
		}

		public bool Strikethrough
		{
			get
			{
				return (bool)this.GetProperty("Strikethrough", null);
			}
			set
			{
				this.SetProperty("Strikethrough", new object[]
				{
					value
				});
			}
		}

		public bool Superscript
		{
			get
			{
				return (bool)this.GetProperty("Superscript", null);
			}
			set
			{
				this.SetProperty("Superscript", new object[]
				{
					value
				});
			}
		}

		public bool Subscript
		{
			get
			{
				return (bool)this.GetProperty("Subscript", null);
			}
			set
			{
				this.SetProperty("Subscript", new object[]
				{
					value
				});
			}
		}

		public bool OutlineFont
		{
			get
			{
				return (bool)this.GetProperty("OutlineFont", null);
			}
			set
			{
				this.SetProperty("OutlineFont", new object[]
				{
					value
				});
			}
		}

		public bool Shadow
		{
			get
			{
				return (bool)this.GetProperty("Shadow", null);
			}
			set
			{
				this.SetProperty("Shadow", new object[]
				{
					value
				});
			}
		}

		public Font()
		{
			
			
		}

		public Font(object oFont)
		{
			
			base.ctor(oFont);
		}
	}
}
