using System;

namespace OfficeLB.Word
{
	public class Paragraphs : Base
	{
		public Paragraphs()
		{
			
			
		}

		public Paragraphs(object oParagraphs)
		{
			
			base.ctor(oParagraphs);
		}

		public Paragraph Add()
		{
			return new Paragraph(this.InvokeReturn("Add", null));
		}

		public Paragraph Add(string text)
		{
			return new Paragraph(this.InvokeReturn("Add", new object[]
			{
				text
			}));
		}

		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
		}

		public void First()
		{
			this.InvokeMethod("First", null);
		}

		public void Last()
		{
			this.InvokeMethod("Last", null);
		}

		public Paragraph this[int index]
		{
			get
			{
				return new Paragraph(this.InvokeReturn("Item", new object[]
				{
					index
				}));
			}
		}
	}
}
