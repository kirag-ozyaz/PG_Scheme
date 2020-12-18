using System;
using System.Collections.Generic;
using Rdl;

internal class Class327
{
	public List<Class328> method_0()
	{
		return this.list_0;
	}

	public void method_1(List<Class328> list_1)
	{
		this.list_0 = list_1;
	}

	public TableType method_2()
	{
		return new TableType
		{
			Name = "Table1",
			Items = new object[]
			{
				this.method_19(),
				this.method_3(),
				this.method_11()
			},
			ItemsElementName = new ItemsChoiceType21[]
			{
				ItemsChoiceType21.TableColumns,
				ItemsChoiceType21.Header,
				ItemsChoiceType21.Details
			}
		};
	}

	private HeaderType method_3()
	{
		return new HeaderType
		{
			Items = new object[]
			{
				this.method_4()
			},
			ItemsElementName = new ItemsChoiceType20[]
			{
				ItemsChoiceType20.TableRows
			}
		};
	}

	private TableRowsType method_4()
	{
		return new TableRowsType
		{
			TableRow = new TableRowType[]
			{
				this.method_5()
			}
		};
	}

	private TableRowType method_5()
	{
		return new TableRowType
		{
			Items = new object[]
			{
				this.method_6(),
				"0.25in"
			}
		};
	}

	private TableCellsType method_6()
	{
		TableCellsType tableCellsType = new TableCellsType();
		tableCellsType.TableCell = new TableCellType[this.list_0.Count];
		for (int i = 0; i < this.list_0.Count; i++)
		{
			tableCellsType.TableCell[i] = this.method_7(this.list_0[i]);
		}
		return tableCellsType;
	}

	private TableCellType method_7(Class328 class328_0)
	{
		return new TableCellType
		{
			Items = new object[]
			{
				this.method_8(class328_0)
			}
		};
	}

	private ReportItemsType method_8(Class328 class328_0)
	{
		return new ReportItemsType
		{
			Items = new object[]
			{
				this.method_9(class328_0)
			}
		};
	}

	private TextboxType method_9(Class328 class328_0)
	{
		return new TextboxType
		{
			Name = class328_0.Name + "_Header",
			Items = new object[]
			{
				class328_0.method_0(),
				this.method_10(),
				true
			},
			ItemsElementName = new ItemsChoiceType14[]
			{
				ItemsChoiceType14.Value,
				ItemsChoiceType14.Style,
				ItemsChoiceType14.CanGrow
			}
		};
	}

	private StyleType method_10()
	{
		return new StyleType
		{
			Items = new object[]
			{
				"500",
				"12pt"
			},
			ItemsElementName = new ItemsChoiceType5[]
			{
				ItemsChoiceType5.FontWeight,
				ItemsChoiceType5.FontSize
			}
		};
	}

	private DetailsType method_11()
	{
		return new DetailsType
		{
			Items = new object[]
			{
				this.method_12()
			}
		};
	}

	private TableRowsType method_12()
	{
		return new TableRowsType
		{
			TableRow = new TableRowType[]
			{
				this.method_13()
			}
		};
	}

	private TableRowType method_13()
	{
		return new TableRowType
		{
			Items = new object[]
			{
				this.method_14(),
				"0.2in"
			}
		};
	}

	private TableCellsType method_14()
	{
		TableCellsType tableCellsType = new TableCellsType();
		tableCellsType.TableCell = new TableCellType[this.list_0.Count];
		for (int i = 0; i < this.list_0.Count; i++)
		{
			tableCellsType.TableCell[i] = this.method_15(this.list_0[i]);
		}
		return tableCellsType;
	}

	private TableCellType method_15(Class328 class328_0)
	{
		return new TableCellType
		{
			Items = new object[]
			{
				this.method_16(class328_0)
			}
		};
	}

	private ReportItemsType method_16(Class328 class328_0)
	{
		return new ReportItemsType
		{
			Items = new object[]
			{
				this.method_17(class328_0)
			}
		};
	}

	private TextboxType method_17(Class328 class328_0)
	{
		return new TextboxType
		{
			Name = class328_0.Name,
			Items = new object[]
			{
				"=Fields!" + class328_0.Name + ".Value",
				this.method_18(),
				true
			},
			ItemsElementName = new ItemsChoiceType14[]
			{
				ItemsChoiceType14.Value,
				ItemsChoiceType14.Style,
				ItemsChoiceType14.CanGrow
			}
		};
	}

	private StyleType method_18()
	{
		return new StyleType
		{
			Items = new object[]
			{
				"=iif(RowNumber(Nothing) mod 2, \"AliceBlue\", \"White\")",
				"Left"
			},
			ItemsElementName = new ItemsChoiceType5[]
			{
				ItemsChoiceType5.BackgroundColor,
				ItemsChoiceType5.TextAlign
			}
		};
	}

	private TableColumnsType method_19()
	{
		TableColumnsType tableColumnsType = new TableColumnsType();
		tableColumnsType.TableColumn = new TableColumnType[this.list_0.Count];
		for (int i = 0; i < this.list_0.Count; i++)
		{
			tableColumnsType.TableColumn[i] = this.gppataQnRys();
		}
		return tableColumnsType;
	}

	private TableColumnType gppataQnRys()
	{
		return new TableColumnType
		{
			Items = new object[]
			{
				"1in"
			}
		};
	}

	public Class327()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
	}

	private List<Class328> list_0;
}
