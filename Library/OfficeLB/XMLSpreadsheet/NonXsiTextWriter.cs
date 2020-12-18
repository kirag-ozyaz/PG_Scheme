using System;
using System.IO;
using System.Text;
using System.Xml;

namespace OfficeLB.XMLSpreadsheet
{
	public class NonXsiTextWriter : XmlTextWriter
	{
		public NonXsiTextWriter(TextWriter w)
		{
			
			base.ctor(w);
		}

		public NonXsiTextWriter(Stream w, Encoding encoding)
		{
			
			base.ctor(w, encoding);
		}

		public NonXsiTextWriter(string filename, Encoding encoding)
		{
			
			base.ctor(filename, encoding);
		}

		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (prefix == "xmlns" && (localName == "xsd" || localName == "xsi"))
			{
				this.bool_0 = true;
				return;
			}
			base.WriteStartAttribute(prefix, localName, ns);
		}

		public override void WriteString(string text)
		{
			if (this.bool_0)
			{
				return;
			}
			base.WriteString(text);
		}

		public override void WriteEndAttribute()
		{
			if (this.bool_0)
			{
				this.bool_0 = false;
				return;
			}
			base.WriteEndAttribute();
		}

		private bool bool_0;
	}
}
