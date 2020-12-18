using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Rdl;

internal class Class118
{
	public List<Class120> method_0()
	{
		return this.list_0;
	}

	public void method_1(List<Class120> list_2)
	{
		this.list_0 = list_2;
	}

	public List<Class120> method_2()
	{
		return this.list_1;
	}

	public void method_3(List<Class120> list_2)
	{
		this.list_1 = list_2;
	}

	private Report method_4()
	{
		return new Report
		{
			Items = new object[]
			{
				this.method_5(),
				this.method_8(),
				this.method_11(),
				"6.5in"
			},
			ItemsElementName = new ItemsChoiceType37[]
			{
				ItemsChoiceType37.DataSources,
				ItemsChoiceType37.Body,
				ItemsChoiceType37.DataSets,
				ItemsChoiceType37.Width
			}
		};
	}

	private DataSourcesType method_5()
	{
		return new DataSourcesType
		{
			DataSource = new DataSourceType[]
			{
				this.method_6()
			}
		};
	}

	private DataSourceType method_6()
	{
		return new DataSourceType
		{
			Name = "DummyDataSource",
			Items = new object[]
			{
				this.method_7()
			}
		};
	}

	private ConnectionPropertiesType method_7()
	{
		return new ConnectionPropertiesType
		{
			Items = new object[]
			{
				"",
				"SQL"
			},
			ItemsElementName = new ItemsChoiceType[]
			{
				ItemsChoiceType.ConnectString,
				ItemsChoiceType.DataProvider
			}
		};
	}

	private BodyType method_8()
	{
		return new BodyType
		{
			Items = new object[]
			{
				this.method_9(),
				"1in"
			},
			ItemsElementName = new ItemsChoiceType30[]
			{
				ItemsChoiceType30.ReportItems,
				ItemsChoiceType30.Height
			}
		};
	}

	private ReportItemsType method_9()
	{
		ReportItemsType reportItemsType = new ReportItemsType();
		Class119 @class = new Class119();
		@class.method_1(this.list_1);
		reportItemsType.Items = new object[]
		{
			@class.method_2()
		};
		return reportItemsType;
	}

	private TableType method_10()
	{
		TableType tableType = new TableType();
		tableType.Name = "Left";
		tableType.Items = new object[]
		{
			"0.78528cm"
		};
		return new TableType();
	}

	private DataSetsType method_11()
	{
		return new DataSetsType
		{
			DataSet = new DataSetType[]
			{
				this.method_12()
			}
		};
	}

	private DataSetType method_12()
	{
		return new DataSetType
		{
			Name = "MyData",
			Items = new object[]
			{
				this.method_13(),
				this.method_14()
			}
		};
	}

	private QueryType method_13()
	{
		return new QueryType
		{
			Items = new object[]
			{
				"DummyDataSource",
				""
			},
			ItemsElementName = new ItemsChoiceType2[]
			{
				ItemsChoiceType2.DataSourceName,
				ItemsChoiceType2.CommandText
			}
		};
	}

	private FieldsType method_14()
	{
		FieldsType fieldsType = new FieldsType();
		fieldsType.Field = new FieldType[this.list_0.Count];
		for (int i = 0; i < this.list_0.Count; i++)
		{
			fieldsType.Field[i] = this.method_15(this.list_0[i]);
		}
		return fieldsType;
	}

	private FieldType method_15(Class120 class120_0)
	{
		return new FieldType
		{
			Name = class120_0.Name,
			Items = new object[]
			{
				class120_0.Name
			},
			ItemsElementName = new ItemsChoiceType1[]
			{
				ItemsChoiceType1.DataField
			}
		};
	}

	public void method_16(Stream stream_0)
	{
		new XmlSerializer(typeof(Report)).Serialize(stream_0, this.method_4());
	}

	private List<Class120> list_0;

	private List<Class120> list_1;
}
