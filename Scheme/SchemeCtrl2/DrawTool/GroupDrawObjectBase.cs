using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using DataSql;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class GroupDrawObjectBase : IEnumerable<DrawObjectBase>, IEnumerable
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
			DataSetScheme @class = new DataSetScheme();
			sqlDataCommand.UpdateSqlData(@class.tSchm_ObjList, " set [idGroup] = null ", " WHERE [ID] = " + item.IdBase.ToString());
		}

		public void Remove(int index)
		{
			DrawObjectBase drawObjectBase = this.list_0[index];
			this.list_0.Remove(drawObjectBase);
			drawObjectBase.Group = null;
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.list_0[0].Layer.Parent.SqlSettings);
			DataSetScheme @class = new DataSetScheme();
			sqlDataCommand.UpdateSqlData(@class.tSchm_ObjList, " set [idGroup] = null ", " WHERE [ID] = " + drawObjectBase.IdBase.ToString());
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

		public void method_2()
		{
			if (this.list_0.Count == 0)
			{
				return;
			}
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.list_0[0].Layer.Parent.SqlSettings);
			DataSetScheme @class = new DataSetScheme();
			if (this.Id == 0)
			{
				DataRow dataRow = @class.DataTableCollection_0["tSchm_ObjList"].NewRow();
				dataRow["Name"] = this.Name;
				dataRow["TypeCodeId"] = 940;
				@class.DataTableCollection_0["tSchm_ObjList"].Rows.Add(dataRow);
				this.Id = sqlDataCommand.InsertSqlDataOneRow(@class.DataTableCollection_0["tSchm_ObjList"]);
			}
			else
			{
				sqlDataCommand.SelectSqlData(@class.tSchm_ObjList, true, " where id = " + this.Id.ToString(), null, false, 0);
				if (@class.tSchm_ObjList.Rows.Count == 0)
				{
					DataRow dataRow2 = @class.DataTableCollection_0["tSchm_ObjList"].NewRow();
					dataRow2["Name"] = this.Name;
					dataRow2["TypeCodeId"] = 940;
					@class.DataTableCollection_0["tSchm_ObjList"].Rows.Add(dataRow2);
					this.Id = sqlDataCommand.InsertSqlDataOneRow(@class.DataTableCollection_0["tSchm_ObjList"]);
				}
				else
				{
					if (@class.tSchm_ObjList.Rows[0]["Name"].ToString() != this.Name)
					{
						@class.tSchm_ObjList.Rows[0]["Name"] = this.Name;
					}
					if ((int)@class.tSchm_ObjList.Rows[0]["TypeCodeId"] != 940)
					{
						@class.tSchm_ObjList.Rows[0]["TypeCodeId"] = 940;
					}
					@class.tSchm_ObjList.Rows[0].EndEdit();
					sqlDataCommand.UpdateSqlData(@class, @class.tSchm_ObjList);
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
			sqlDataCommand.SelectSqlData(@class.tSchm_ObjList, true, " where id in (" + text + ")", null, false, 0);
			foreach (object obj in @class.tSchm_ObjList.Rows)
			{
				((DataRow)obj)["idGroup"] = this.Id;
			}
			sqlDataCommand.UpdateSqlData(@class, @class.tSchm_ObjList);
		}

		public void Remove()
		{
			if (this.Id == 0)
			{
				return;
			}
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.list_0[0].Layer.Parent.SqlSettings);
			DataSetScheme @class = new DataSetScheme();
			sqlDataCommand.UpdateSqlData(@class.tSchm_ObjList, " set [DELETED] = 1 ", " WHERE [ID] = " + this.Id.ToString());
			string text = string.Empty;
			foreach (DrawObjectBase drawObjectBase in this.list_0)
			{
				if (text.Length > 0)
				{
					text += ", ";
				}
				text += drawObjectBase.IdBase;
			}
			sqlDataCommand.SelectSqlData(@class.tSchm_ObjList, true, " where id in (" + text + ")", null, false, 0);
			foreach (object obj in @class.tSchm_ObjList.Rows)
			{
				((DataRow)obj)["idGroup"] = DBNull.Value;
			}
			sqlDataCommand.UpdateSqlData(@class, @class.tSchm_ObjList);
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

		public GroupDrawObjectBase()
		{
			
			this.list_0 = new List<DrawObjectBase>();
			
		}

		private List<DrawObjectBase> list_0;

		private bool bool_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private GroupDrawObjectBase groupDrawObjectBase_0;
	}
}
