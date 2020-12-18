using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Passport.Classes
{
	public class DataGridViewParse
	{
		[Description("Получает массив видимых заголовков.")]
		public string[] ObjectColumnVisibleHeaders
		{
			get
			{
				return this.string_0;
			}
		}

		[Description("Получает количество видимых столбцов.")]
		public int ColumnVisibleCount
		{
			get
			{
				if (this.string_0 != null)
				{
					return this.string_0.Length;
				}
				return -1;
			}
		}

		[Description("Получает количество строк.")]
		public int RowCount
		{
			get
			{
				return this.int_1;
			}
		}

		[Description("Получает массив отображаемых данных.")]
		public object[,] ObjectVisibleData
		{
			get
			{
				return this.object_0;
			}
		}

		[Description("Получает массив с шириной видимых колонок.")]
		public int[] ColunmWidths
		{
			get
			{
				return this.int_0;
			}
		}

		public DataGridViewParse(DataGridView dgv, bool selected, string no_column_name)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			DateTime dateTime = default(DateTime);
			this.dataGridView_0 = dgv;
			string text = "";
			for (int i = 0; i < this.dataGridView_0.ColumnCount; i++)
			{
				if (this.dataGridView_0.Columns[i].Visible && this.dataGridView_0.Columns[i].Name != no_column_name)
				{
					text = text + this.dataGridView_0.Columns[i].HeaderText + "%";
				}
			}
			this.string_0 = text.Remove(text.LastIndexOf('%')).Split(new char[]
			{
				'%'
			});
			DataGridViewSelectedRowCollection selectedRows = dgv.SelectedRows;
			if (selected)
			{
				this.object_0 = new object[selectedRows.Count, this.string_0.Length];
				this.int_0 = new int[this.string_0.Length];
				for (int j = 0; j < selectedRows.Count; j++)
				{
					int num = 0;
					for (int k = 0; k < this.dataGridView_0.ColumnCount; k++)
					{
						if (this.dataGridView_0.Columns[k].Visible && this.dataGridView_0.Columns[k].Name != no_column_name)
						{
							if (this.dataGridView_0.Rows[j].Cells[k].Value == null)
							{
								this.dataGridView_0.Rows[j].Cells[k].Value = "";
							}
							this.object_0[j, num] = ((!DateTime.TryParse(this.dataGridView_0.Rows[j].Cells[k].Value.ToString(), out dateTime)) ? this.dataGridView_0.Rows[j].Cells[k].Value : dateTime.ToShortDateString());
							this.int_0[num] = this.dataGridView_0.Columns[k].Width;
							num++;
						}
					}
				}
				this.int_1 = selectedRows.Count;
				return;
			}
			this.object_0 = new object[this.dataGridView_0.RowCount, this.string_0.Length];
			this.int_0 = new int[this.string_0.Length];
			for (int l = 0; l < this.dataGridView_0.RowCount; l++)
			{
				int num2 = 0;
				for (int m = 0; m < this.dataGridView_0.ColumnCount; m++)
				{
					if (this.dataGridView_0.Columns[m].Visible && this.dataGridView_0.Columns[m].Name != no_column_name)
					{
						if (this.dataGridView_0.Rows[l].Cells[m].Value == null)
						{
							this.dataGridView_0.Rows[l].Cells[m].Value = "";
						}
						this.object_0[l, num2] = ((!DateTime.TryParse(this.dataGridView_0.Rows[l].Cells[m].Value.ToString(), out dateTime)) ? this.dataGridView_0.Rows[l].Cells[m].Value : dateTime.ToShortDateString());
						this.int_0[num2] = this.dataGridView_0.Columns[m].Width;
						num2++;
					}
				}
			}
			this.int_1 = dgv.RowCount;
		}

		private DataGridView dataGridView_0;

		private string[] string_0;

		private int[] int_0;

		private object[,] object_0;

		private int int_1;
	}
}
