using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using DataSql;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Data;

namespace SchemeCtrl2.DrawTool
{
	public class GroupDrawObjectBase : IEnumerable<DrawObjectBase>
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public GroupDrawObjectBase Group { get; set; }

		public int Count
		{
			get
			{
				return this.list_0.Count;
			}
		}

		private CanvasControl Canvas
		{
			get
			{
				if (this.list_0.Count > 0)
				{
					return this.list_0[0].Layer.Parent;
				}
				return null;
			}
		}

		public DrawObjectBase this[int index]
		{
			get
			{
				return this.list_0[index];
			}
		}

		public bool Selected
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 != value)
				{
					this.bool_0 = value;
					if (this.bool_0)
					{
						foreach (DrawObjectBase drawobject in this.list_0)
						{
							this.Canvas.SelectObject(drawobject);
						}
					}
				}
			}
		}

		public void Add(DrawObjectBase item)
		{
			this.list_0.Add(item);
			item.Group = this;
		}

		public void Remove(DrawObjectBase item)
		{
			this.list_0.Remove(item);
			item.Group = null;
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.list_0[0].Layer.Parent.SqlSettings);
			DataSetScheme dataSetScheme = new DataSetScheme();
			sqlDataCommand.UpdateSqlData(dataSetScheme.tSchm_ObjList, " set [idGroup] = null ", " WHERE [ID] = " + item.IdBase.ToString());
		}

		public void Remove(int index)
		{
			DrawObjectBase drawObjectBase = this.list_0[index];
			this.list_0.Remove(drawObjectBase);
			drawObjectBase.Group = null;
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.list_0[0].Layer.Parent.SqlSettings);
			DataSetScheme dataSetScheme = new DataSetScheme();
			sqlDataCommand.UpdateSqlData(dataSetScheme.tSchm_ObjList, " set [idGroup] = null ", " WHERE [ID] = " + drawObjectBase.IdBase.ToString());
		}

		private void method_0(DrawObjectBase drawObjectBase_0)
		{
			this.list_0.Remove(drawObjectBase_0);
			drawObjectBase_0.Group = null;
		}

		private void method_1()
		{
			while (this.list_0.Count > 0)
			{
				this.method_0(this.list_0[0]);
			}
		}

		public void SaveToSQL()
		{
			if (this.list_0.Count == 0)
			{
				return;
			}
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.list_0[0].Layer.Parent.SqlSettings);
			DataSetScheme dataSetScheme = new DataSetScheme();
			if (this.Id == 0)
			{
				DataRow dataRow = dataSetScheme.Tables["tSchm_ObjList"].NewRow();
				dataRow["Name"] = this.Name;
				dataRow["TypeCodeId"] = 940;
				dataSetScheme.Tables["tSchm_ObjList"].Rows.Add(dataRow);
				this.Id = sqlDataCommand.InsertSqlDataOneRow(dataSetScheme, dataSetScheme.Tables["tSchm_ObjList"]);
			}
			else
			{
				sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_ObjList, true, " where id = " + this.Id.ToString());
				if (dataSetScheme.tSchm_ObjList.Rows.Count == 0)
				{
					DataRow dataRow2 = dataSetScheme.Tables["tSchm_ObjList"].NewRow();
					dataRow2["Name"] = this.Name;
					dataRow2["TypeCodeId"] = 940;
					dataSetScheme.Tables["tSchm_ObjList"].Rows.Add(dataRow2);
					this.Id = sqlDataCommand.InsertSqlDataOneRow(dataSetScheme, dataSetScheme.Tables["tSchm_ObjList"]);
				}
				else
				{
					if (dataSetScheme.tSchm_ObjList.Rows[0]["Name"].ToString() != this.Name)
					{
						dataSetScheme.tSchm_ObjList.Rows[0]["Name"] = this.Name;
					}
					if ((int)dataSetScheme.tSchm_ObjList.Rows[0]["TypeCodeId"] != 940)
					{
						dataSetScheme.tSchm_ObjList.Rows[0]["TypeCodeId"] = 940;
					}
					dataSetScheme.tSchm_ObjList.Rows[0].EndEdit();
					sqlDataCommand.UpdateSqlData(dataSetScheme, dataSetScheme.tSchm_ObjList);
				}
			}
			string text = string.Empty;
			foreach (DrawObjectBase drawObjectBase in this.list_0)
			{
				if (text.Length > 0)
				{
					text += ", ";
				}
				text += drawObjectBase.IdBase;
			}
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_ObjList, true, " where id in (" + text + ")");
			foreach (object obj in dataSetScheme.tSchm_ObjList.Rows)
			{
				DataRow dataRow3 = (DataRow)obj;
				dataRow3["idGroup"] = this.Id;
			}
			sqlDataCommand.UpdateSqlData(dataSetScheme, dataSetScheme.tSchm_ObjList);
		}

		public void Remove()
		{
			if (this.Id == 0)
			{
				return;
			}
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.list_0[0].Layer.Parent.SqlSettings);
			DataSetScheme dataSetScheme = new DataSetScheme();
			sqlDataCommand.UpdateSqlData(dataSetScheme.tSchm_ObjList, " set [DELETED] = 1 ", " WHERE [ID] = " + this.Id.ToString());
			string text = string.Empty;
			foreach (DrawObjectBase drawObjectBase in this.list_0)
			{
				if (text.Length > 0)
				{
					text += ", ";
				}
				text += drawObjectBase.IdBase;
			}
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_ObjList, true, " where id in (" + text + ")");
			foreach (object obj in dataSetScheme.tSchm_ObjList.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				dataRow["idGroup"] = DBNull.Value;
			}
			sqlDataCommand.UpdateSqlData(dataSetScheme, dataSetScheme.tSchm_ObjList);
			this.method_1();
		}

		public IEnumerator<DrawObjectBase> GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		private const int int_0 = 940;

		private List<DrawObjectBase> list_0 = new List<DrawObjectBase>();

		private bool bool_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private GroupDrawObjectBase groupDrawObjectBase_0;
	}
}
