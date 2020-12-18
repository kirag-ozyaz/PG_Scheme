using System;
using System.ComponentModel;

namespace OfficeLB.Excel
{
	public class Range : Base
	{
		public Range()
		{
			
			
		}

		public Range(object oRange)
		{
			
			base.ctor(oRange);
		}

		public Range this[string cell]
		{
			get
			{
				return new Range(this.GetProperty("Range", new object[]
				{
					cell
				}));
			}
		}

		public Range this[string cell1, string cell2]
		{
			get
			{
				return new Range(this.GetProperty("Range", new object[]
				{
					cell1,
					cell2
				}));
			}
		}

		public Range this[int column, int row]
		{
			get
			{
				return new Range(this.GetProperty("Range", new object[]
				{
					Worksheet.ParseColNum(column - 1) + row.ToString()
				}));
			}
		}

		public Range this[int column1, int row1, int column2, int row2]
		{
			get
			{
				return new Range(this.GetProperty("Range", new object[]
				{
					Worksheet.ParseColNum(column1 - 1) + row1.ToString(),
					Worksheet.ParseColNum(column2 - 1) + row2.ToString()
				}));
			}
		}

		[Description("Получает активный объект Cell.")]
		public Cell ActiveCell
		{
			get
			{
				return new Cell(this.GetProperty("ActiveCell", null));
			}
		}

		[Description("Получает адрес ячейки или диапазона ячеек в виде значения типа String.")]
		public string Address
		{
			get
			{
				return this.GetProperty("Address", null).ToString();
			}
		}

		public Borders Borders
		{
			get
			{
				return new Borders(this.GetProperty("Borders", null));
			}
		}

		[Description("Получает номер первой колонки в диапазоне ячеек.")]
		public int Column
		{
			get
			{
				return (int)this.GetProperty("Column", null);
			}
		}

		[Description("Получает объект Columns.")]
		public Columns Columns
		{
			get
			{
				return new Columns(this.GetProperty("Columns", null));
			}
		}

		public double ColumnWidth
		{
			get
			{
				return (double)this.GetProperty("ColumnWidth", null);
			}
			set
			{
				this.SetProperty("ColumnWidth", new object[]
				{
					value
				});
			}
		}

		[Description("Получает количество элементов в наборе (диапазоне).")]
		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
		}

		public Font Font
		{
			get
			{
				return new Font(this.GetProperty("Font", null));
			}
		}

		public string Formula
		{
			get
			{
				return this.GetProperty("Formula", null).ToString();
			}
			set
			{
				this.SetProperty("Formula", new object[]
				{
					value
				});
			}
		}

		public string String_0
		{
			get
			{
				return this.GetProperty("FormulaR1C1", null).ToString();
			}
			set
			{
				this.SetProperty("FormulaR1C1", new object[]
				{
					value
				});
			}
		}

		[Description("Получает True, если указанная ячейка является частью массива. Массивом на рабочем листе является именованный диапазон ячеек.")]
		public bool HasArray
		{
			get
			{
				return (bool)this.GetProperty("HasArray", null);
			}
		}

		[Description("Получает True, если в указанной ячейке установлена формула.")]
		public bool HasFormula
		{
			get
			{
				return (bool)this.GetProperty("HasFormula", null);
			}
		}

		public xlHAlignment HorizontalAlignment
		{
			get
			{
				return (xlHAlignment)this.GetProperty("HorizontalAlignment", null);
			}
			set
			{
				this.SetProperty("HorizontalAlignment", new object[]
				{
					value
				});
			}
		}

		public int IndentLevel
		{
			get
			{
				return (int)this.GetProperty("IndentLevel", null);
			}
			set
			{
				this.SetProperty("IndentLevel", new object[]
				{
					value
				});
			}
		}

		public Interior Interior
		{
			get
			{
				return new Interior(this.GetProperty("Interior", null));
			}
		}

		public string Name
		{
			get
			{
				return this.GetProperty("Name", null).ToString();
			}
			set
			{
				this.SetProperty("Name", new object[]
				{
					value
				});
			}
		}

		[Description("Позволяет сориентировать текст в ячейках. Указывается угол наклона в градусах.")]
		public double Orientation
		{
			get
			{
				return (double)this.GetProperty("Orientation", null);
			}
			set
			{
				this.SetProperty("Orientation", new object[]
				{
					value
				});
			}
		}

		[Description("Позволяет программно вставить разрыв страницы.")]
		public xlPageBreak PageBreak
		{
			get
			{
				return (xlPageBreak)this.GetProperty("PageBreak", null);
			}
			set
			{
				this.SetProperty("PageBreak", new object[]
				{
					value
				});
			}
		}

		[Description("Получает номер первой строки в диапазоне ячеек.")]
		public int Row
		{
			get
			{
				return (int)this.GetProperty("Row", null);
			}
		}

		public double RowHeight
		{
			get
			{
				return (double)this.GetProperty("RowHeight", null);
			}
			set
			{
				this.SetProperty("RowHeight", new object[]
				{
					value
				});
			}
		}

		[Description("Получает объект Rows.")]
		public Rows Rows
		{
			get
			{
				return new Rows(this.GetProperty("Rows", null));
			}
		}

		[Description("Позволяет автоматически настроить размер текста в диапазоне таким образом, чтобы текст умещался в ширину столбца.")]
		public string ShrinkToFit
		{
			get
			{
				return this.GetProperty("ShrinkToFit", null).ToString();
			}
		}

		[Description("Получает объект Style, представляющий стиль для указанного диапазона.")]
		public Style Style
		{
			get
			{
				return new Style(this.GetProperty("Style", null));
			}
		}

		[Description("Получает значение первой ячейки диапазона в виде значения типа String.")]
		public string Text
		{
			get
			{
				return this.GetProperty("Text", null).ToString();
			}
		}

		[Description("Получает объект Validation, при помощи которого можно настроить проверку вводимых в диапазон данных.")]
		public Validation Validation
		{
			get
			{
				return new Validation(this.GetProperty("Validation", null));
			}
		}

		[Description("Получает или задает значение (числовое, текстовое или какое-либо другое) ячейкам диапазона.")]
		public object Value
		{
			get
			{
				return this.GetProperty("Value", null);
			}
			set
			{
				this.SetProperty("Value", new object[]
				{
					value
				});
			}
		}

		public xlVAlignment VerticalAlignment
		{
			get
			{
				return (xlVAlignment)this.GetProperty("VerticalAlignment", null);
			}
			set
			{
				this.SetProperty("VerticalAlignment", new object[]
				{
					value
				});
			}
		}

		[Description("Возможность включить/отключить перевод текста на следующую строку в ячейках диапазона.")]
		public bool WrapText
		{
			get
			{
				return (bool)this.GetProperty("WrapText", null);
			}
			set
			{
				this.SetProperty("WrapText", new object[]
				{
					value
				});
			}
		}

		[Description("Очищает указанный диапазон ячеек.")]
		public void Clear()
		{
			this.InvokeMethod("Clear", null);
		}

		[Description("Очищает формулы и значения, содержащиеся в ячейках, представляемых объектом Range, то есть очищается только содержимое ячеек, сохраняя их форматирование.")]
		public void ClearContents()
		{
			this.InvokeMethod("ClearContents", null);
		}

		[Description("Удаляет всё форматирование ячеек, сохраняя неизменными хранящиеся в них данные.")]
		public void ClearFormats()
		{
			this.InvokeMethod("ClearFormats", null);
		}

		[Description("Копирует указанный диапазон в буфер обмена.")]
		public void Copy()
		{
			this.InvokeMethod("Copy", null);
		}

		[Description("Вырезает указанный диапазон в буфер обмена.")]
		public void Cut()
		{
			this.InvokeMethod("Cut", null);
		}

		[Description("Удаляет ячейки, определяемые объектом Range.")]
		public void Delete()
		{
			this.InvokeMethod("Delete", null);
		}

		[Description("Удаляет ячейки, определяемые объектом Range.")]
		public void Delete(xlDeleteShiftDirection value)
		{
			this.InvokeMethod("Delete", new object[]
			{
				(int)value
			});
		}

		[Description("Заполняет столбцы указанного диапазона ячеек данными из первых строк каждого столбца.")]
		public void FillDown()
		{
			this.InvokeMethod("FillDown", null);
		}

		[Description("Заполняет строки указанного диапазона ячеек данными из последних столбцов каждой строки.")]
		public void FillLeft()
		{
			this.InvokeMethod("FillLeft", null);
		}

		[Description("Заполняет строки указанного диапазона ячеек данны-ми из первых столбцов каждой строки.")]
		public void FillRight()
		{
			this.InvokeMethod("FillRight", null);
		}

		[Description("Вырезает указанный диапазон в буфер обмена.")]
		public void FillUp()
		{
			this.InvokeMethod("FillUp", null);
		}

		[Description("Вставляет ячейку или диапазон ячеек.")]
		public void Insert()
		{
			this.InvokeMethod("Insert", null);
		}

		[Description("Удаляет ячейки, определяемые объектом Range.")]
		public void Insert(xlInsertShiftDirection value)
		{
			this.InvokeMethod("Insert", new object[]
			{
				(int)value
			});
		}

		[Description("Объединяет указанный диапазон ячеек.")]
		public void Merge()
		{
			this.InvokeMethod("Merge", null);
		}

		[Description("Возвращает объект Range, смещенный относительно левой верхней ячейки указанного диапазона Range.")]
		public Range Offset(int rowOffset, int columnOffset)
		{
			return new Range(this.GetProperty("Offset", new object[]
			{
				rowOffset,
				columnOffset
			}));
		}

		public void Paste()
		{
			this.InvokeMethod("Paste", null);
		}

		[Description("Вставляет в указанную ячейку данные, формулу или содержимое из буфера обмена.")]
		public void PasteSpecial()
		{
			this.InvokeMethod("PasteSpecial", null);
		}

		public void Select()
		{
			this.InvokeMethod("Select", null);
		}

		[Description("Возвращает объект Range, представляющий все ячейки, соответствующие указанному типу.")]
		public Range SpecialCells(xlCellType cellType)
		{
			return new Range(this.InvokeReturn("SpecialCells", new object[]
			{
				(int)cellType
			}));
		}

		[Description("Возвращает объект Range, представляющий все ячейки, соответствующие указанным типу и значению.")]
		public Range SpecialCells(xlCellTypeValue cellType, xlSpecialCellsValue value)
		{
			return new Range(this.InvokeReturn("SpecialCells", new object[]
			{
				(int)cellType,
				(int)value
			}));
		}

		[Description("Разъединяет указанный диапазон ячеек.")]
		public void UnMerge()
		{
			this.InvokeMethod("UnMerge", null);
		}
	}
}
