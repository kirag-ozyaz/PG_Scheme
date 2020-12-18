using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Passport.Forms
{
	[XmlRoot("Settings")]
	public class FormRegistrSettings
	{
		[XmlArray("TransformerColumns")]
		[XmlArrayItem("TransformerColumn", typeof(Column))]
		public Columns TransformerColumns { get; set; }

		[XmlArrayItem("VoltageTransformerColumn", typeof(Column))]
		[XmlArray("VoltageTransformerColumns")]
		public Columns VoltageTransformerColumns { get; set; }

		[XmlArrayItem("SubstationColumn", typeof(Column))]
		[XmlArray("SubstationColumns")]
		public Columns SubstationColumns { get; set; }

		[XmlArray("CableLineColumns")]
		[XmlArrayItem("CableLineColumn", typeof(Column))]
		public Columns CableLineColumns { get; set; }

		[XmlArray("AirLineColumns")]
		[XmlArrayItem("AirLineColumn", typeof(Column))]
		public Columns AirLineColumns { get; set; }

		[CompilerGenerated]
		private Columns columns_0;

		[CompilerGenerated]
		private Columns columns_1;

		[CompilerGenerated]
		private Columns columns_2;

		[CompilerGenerated]
		private Columns columns_3;

		[CompilerGenerated]
		private Columns columns_4;
	}
}
