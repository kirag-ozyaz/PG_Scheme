using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Passport.Forms
{
	[XmlRoot("Settings")]
	public class FormRegistrSettings
	{
		[XmlArrayItem("TransformerColumn", typeof(Column))]
		[XmlArray("TransformerColumns")]
		public Columns TransformerColumns { get; set; }

		[XmlArrayItem("VoltageTransformerColumn", typeof(Column))]
		[XmlArray("VoltageTransformerColumns")]
		public Columns VoltageTransformerColumns { get; set; }

		[XmlArray("SubstationColumns")]
		[XmlArrayItem("SubstationColumn", typeof(Column))]
		public Columns SubstationColumns { get; set; }

		[XmlArray("CableLineColumns")]
		[XmlArrayItem("CableLineColumn", typeof(Column))]
		public Columns CableLineColumns { get; set; }

		[XmlArrayItem("AirLineColumn", typeof(Column))]
		[XmlArray("AirLineColumns")]
		public Columns AirLineColumns { get; set; }

		public FormRegistrSettings()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		[CompilerGenerated]
		private Columns toJvuYjYuQ;

		[CompilerGenerated]
		private Columns columns_0;

		[CompilerGenerated]
		private Columns columns_1;

		[CompilerGenerated]
		private Columns columns_2;

		[CompilerGenerated]
		private Columns columns_3;
	}
}
