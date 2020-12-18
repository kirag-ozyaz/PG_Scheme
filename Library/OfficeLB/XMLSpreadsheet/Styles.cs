using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	[DesignerCategory("code")]
	[XmlRoot("Styles")]
	[DebuggerStepThrough]
	[Serializable]
	public class Styles
	{
		[XmlElement("Style", typeof(Style))]
		public Style[] Style
		{
			get
			{
				return this.style_0;
			}
			set
			{
				this.style_0 = value;
			}
		}

		public Styles()
		{
			
			
		}

		private Style[] style_0;
	}
}
