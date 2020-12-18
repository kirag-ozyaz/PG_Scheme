using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataSql;

namespace Passport.Classes
{
	public static class PassportGridData
	{
		public static DataGridViewColumn[] CreateColumns()
		{
			DataGridViewColumn[] array = new DataGridViewColumn[6];
			PassportGridData.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			PassportGridData.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			PassportGridData.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			PassportGridData.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			PassportGridData.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			PassportGridData.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			PassportGridData.dataGridViewTextBoxColumn_0.Name = "idChar";
			PassportGridData.dataGridViewTextBoxColumn_0.ReadOnly = true;
			PassportGridData.dataGridViewTextBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
			array[0] = PassportGridData.dataGridViewTextBoxColumn_0;
			PassportGridData.dataGridViewTextBoxColumn_1.Name = "ParentIdChar";
			PassportGridData.dataGridViewTextBoxColumn_1.ReadOnly = true;
			PassportGridData.dataGridViewTextBoxColumn_1.SortMode = DataGridViewColumnSortMode.Programmatic;
			array[1] = PassportGridData.dataGridViewTextBoxColumn_1;
			PassportGridData.dataGridViewTextBoxColumn_2.Name = "TabIndexChar";
			PassportGridData.dataGridViewTextBoxColumn_2.ReadOnly = true;
			array[2] = PassportGridData.dataGridViewTextBoxColumn_2;
			PassportGridData.dataGridViewCheckBoxColumn_0.Name = "isGroupChar";
			PassportGridData.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			PassportGridData.dataGridViewCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
			PassportGridData.dataGridViewCheckBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
			array[3] = PassportGridData.dataGridViewCheckBoxColumn_0;
			PassportGridData.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			PassportGridData.dataGridViewTextBoxColumn_3.FillWeight = 150f;
			PassportGridData.dataGridViewTextBoxColumn_3.Name = "NameChar";
			PassportGridData.dataGridViewTextBoxColumn_3.ReadOnly = true;
			PassportGridData.dataGridViewTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			PassportGridData.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
			array[4] = PassportGridData.dataGridViewTextBoxColumn_3;
			PassportGridData.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			PassportGridData.dataGridViewTextBoxColumn_4.Name = "ValueChar";
			PassportGridData.dataGridViewTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			PassportGridData.dataGridViewTextBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
			array[5] = PassportGridData.dataGridViewTextBoxColumn_4;
			return array;
		}

		public static List<DataGridViewRow> CreateRows(SQLSettings settings, TypeObjList type)
		{
			return new List<DataGridViewRow>();
		}

		private static DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private static DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private static DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private static DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private static DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private static DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
	}
}
