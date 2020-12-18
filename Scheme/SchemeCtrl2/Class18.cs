using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using DataSql;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

internal static class Class18
{
	public static bool smethod_0()
	{
		return Class18.bool_0;
	}

	public static void smethod_1(bool bool_1)
	{
		Class18.bool_0 = bool_1;
	}

	internal static void smethod_2(SQLSettings sqlsettings_1)
	{
		Class18.sqlsettings_0 = sqlsettings_1;
		Class18.Rrmfvsystf();
	}

	internal static Guid smethod_3()
	{
		return Class18.guid_0;
	}

	private static void Rrmfvsystf()
	{
		if (Class18.sqlsettings_0 == null)
		{
			Class18.guid_0 = Guid.Empty;
			return;
		}
		SqlConnection sqlConnection = new SqlConnection(Class18.sqlsettings_0.GetConnectionString());
		SqlCommand sqlCommand = new SqlCommand(string.Format("SELECT [database_guid] FROM sys.databases INNER JOIN sys.database_recovery_status ON sys.database_recovery_status.database_id = sys.databases.database_id WHERE [name] = '{0}'", Class18.sqlsettings_0.DBName), sqlConnection);
		try
		{
			sqlConnection.Open();
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			if (sqlDataReader.Read())
			{
				Class18.guid_0 = (Guid)sqlDataReader[0];
			}
			else
			{
				Class18.guid_0 = Guid.Empty;
			}
		}
		catch
		{
			Class18.guid_0 = Guid.Empty;
		}
	}

	internal static bool smethod_4(List<DrawObjectBase> list_0, List<DrawObjectBase> list_1, Dictionary<DrawObjectBase, int> dictionary_0, SqlCommand sqlCommand_0)
	{
		if (sqlCommand_0.Connection != null)
		{
			if (sqlCommand_0.Connection.State == ConnectionState.Open)
			{
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase_ in list_0)
				{
					list.AddRange(Class18.smethod_19(drawObjectBase_));
				}
				foreach (DrawObjectBase item in list)
				{
					if (!list_0.Contains(item))
					{
						list_0.Add(item);
					}
				}
				list.Clear();
				list.AddRange(from d in list_0
				            where d.GetType() == typeof(RectangleTool) && !list_1.Contains(d)
				            select d);
				foreach (DrawObjectBase drawObjectBase in list)
				{
					Class18.UajfmJacjY(sqlCommand_0, drawObjectBase, dictionary_0);
					list_1.Add(drawObjectBase);
				}
				list.Clear();
				list.AddRange(from d in list_0
				where d.GetType() == typeof(ShinaTool) && !list_1.Contains(d)
				select d);
				Func<DrawObjectBase, bool> C9__2 = null;
				foreach (DrawObjectBase drawObjectBase2 in list)
				{
					Class18.smethod_5(sqlCommand_0, drawObjectBase2);
					IEnumerable<DrawObjectBase> childObjects = drawObjectBase2.ChildObjects;
					Func<DrawObjectBase, bool> predicate;
					if ((predicate = C9__2) == null)
					{
						predicate = (C9__2 = ((DrawObjectBase d) => d.GetType() == typeof(PointShinaTool) && !list_1.Contains(d)));
					}
					foreach (DrawObjectBase drawObjectBase3 in childObjects.Where(predicate))
					{
						Class18.UajfmJacjY(sqlCommand_0, drawObjectBase3, dictionary_0);
						list_1.Add(drawObjectBase3);
					}
					sqlCommand_0.CommandText = Class18.smethod_10(drawObjectBase2);
					sqlCommand_0.ExecuteNonQuery();
					list_1.Add(drawObjectBase2);
				}
				list.Clear();
				list.AddRange(from d in list_0
				where d is LineTool && !list_1.Contains(d)
				select d);
				Func<DrawObjectBase, bool> C9__4 = null;
				foreach (DrawObjectBase drawObjectBase4 in list)
				{
					Class18.smethod_5(sqlCommand_0, drawObjectBase4);
					foreach (CouplingRelation couplingRelation in ((LineTool)drawObjectBase4).CouplingRelations)
					{
						if (!list_1.Contains(couplingRelation.method_1()))
						{
							Class18.UajfmJacjY(sqlCommand_0, couplingRelation.method_1(), dictionary_0);
							list_1.Add(couplingRelation.method_1());
						}
						if (!list_1.Contains(couplingRelation.method_2()))
						{
							Class18.UajfmJacjY(sqlCommand_0, couplingRelation.method_2(), dictionary_0);
							list_1.Add(couplingRelation.method_2());
						}
						sqlCommand_0.CommandText = Class18.smethod_18(couplingRelation);
						sqlCommand_0.ExecuteNonQuery();
						if (couplingRelation.Id == 0)
						{
							sqlCommand_0.CommandText = "select IDENT_CURRENT('tSchm_Relation')";
							couplingRelation.Id = Convert.ToInt32(sqlCommand_0.ExecuteScalar());
						}
						foreach (Branch branch in couplingRelation.method_3())
						{
							IEnumerable<DrawObjectBase> childObjects2 = branch.ChildObjects;
							Func<DrawObjectBase, bool> predicate2 = null;
							if ((predicate2 = C9__4) == null)
							{
								predicate2 = (C9__4 = ((DrawObjectBase o) => !list_1.Contains(o) && o.IdBase == 0));
							}
							foreach (DrawObjectBase drawObjectBase5 in childObjects2.Where(predicate2))
							{
								Class18.UajfmJacjY(sqlCommand_0, drawObjectBase5, dictionary_0);
								list_1.Add(drawObjectBase5);
							}
						}
					}
					if (dictionary_0.ContainsKey(drawObjectBase4))
					{
						sqlCommand_0.CommandText = Class18.smethod_11(drawObjectBase4, dictionary_0[drawObjectBase4]);
					}
					else
					{
						sqlCommand_0.CommandText = Class18.smethod_10(drawObjectBase4);
					}
					sqlCommand_0.ExecuteNonQuery();
					list_1.Add(drawObjectBase4);
				}
				list.Clear();
				list.AddRange(from d in list_0
				where d is PointTool && !list_1.Contains(d)
				select d);
				foreach (DrawObjectBase drawObjectBase6 in list)
				{
					Class18.UajfmJacjY(sqlCommand_0, drawObjectBase6, dictionary_0);
					list_1.Add(drawObjectBase6);
				}
				list.Clear();
				list.AddRange(from d in list_0
				where d is ObjectOnLine && !list_1.Contains(d)
				select d);
				foreach (DrawObjectBase drawObjectBase7 in list)
				{
					if (drawObjectBase7.GetType() != typeof(ArrowTool))
					{
						Class18.UajfmJacjY(sqlCommand_0, drawObjectBase7, dictionary_0);
						list_1.Add(drawObjectBase7);
					}
				}
				list.Clear();
				list.AddRange(from d in list_0
				where d is LabelTool && !list_1.Contains(d)
				select d);
				using (List<DrawObjectBase>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DrawObjectBase drawObjectBase8 = enumerator.Current;
						sqlCommand_0.CommandText = Class18.smethod_9((LabelTool)drawObjectBase8);
						sqlCommand_0.ExecuteNonQuery();
						if (drawObjectBase8.IdBase == 0)
						{
							sqlCommand_0.CommandText = "select IDENT_CURRENT('tSchm_ObjList')";
							drawObjectBase8.IdBase = Convert.ToInt32(sqlCommand_0.ExecuteScalar());
						}
						list_1.Add(drawObjectBase8);
					}
					goto IL_577;
				}
				goto IL_56C;
				IL_577:
				list.Clear();
				return false;
			}
		}
		IL_56C:
		throw new Exception("Объект SqlCommand не подготовлен");
	}

	private static void smethod_5(SqlCommand sqlCommand_0, DrawObjectBase drawObjectBase_0)
	{
		if (sqlCommand_0.Connection != null)
		{
			if (sqlCommand_0.Connection.State == ConnectionState.Open)
			{
				sqlCommand_0.CommandText = Class18.smethod_8(drawObjectBase_0);
				sqlCommand_0.ExecuteNonQuery();
				if (drawObjectBase_0.IdBase < 1)
				{
					sqlCommand_0.CommandText = "select IDENT_CURRENT('tSchm_ObjList')";
					drawObjectBase_0.IdBase = Convert.ToInt32(sqlCommand_0.ExecuteScalar());
				}
				return;
			}
		}
		throw new Exception("Объект SqlCommand не подготовлен");
	}

	private static void UajfmJacjY(SqlCommand sqlCommand_0, DrawObjectBase drawObjectBase_0, Dictionary<DrawObjectBase, int> dictionary_0)
	{
		if (sqlCommand_0.Connection != null)
		{
			if (sqlCommand_0.Connection.State == ConnectionState.Open)
			{
				try
				{
					Class18.smethod_5(sqlCommand_0, drawObjectBase_0);
					if (dictionary_0.ContainsKey(drawObjectBase_0))
					{
						sqlCommand_0.CommandText = Class18.smethod_11(drawObjectBase_0, dictionary_0[drawObjectBase_0]);
					}
					else
					{
						sqlCommand_0.CommandText = Class18.smethod_10(drawObjectBase_0);
					}
					sqlCommand_0.ExecuteNonQuery();
					return;
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}
		}
		throw new Exception("Объект SqlCommand не подготовлен");
	}

	internal static void smethod_6(DrawObjectBase drawObjectBase_0)
	{
		Class18.smethod_7(new List<DrawObjectBase>
		{
			drawObjectBase_0
		});
	}

	internal static void smethod_7(List<DrawObjectBase> list_0)
	{
		if (list_0.Count > 0 && list_0.First<DrawObjectBase>().Layer != null && list_0.First<DrawObjectBase>().Layer.Parent != null && list_0.First<DrawObjectBase>().Layer.Parent.SqlSettings != null)
		{
			Class18.smethod_2(list_0.First<DrawObjectBase>().Layer.Parent.SqlSettings);
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			List<DrawObjectBase> saved = new List<DrawObjectBase>();
			Dictionary<DrawObjectBase, int> dictionary = new Dictionary<DrawObjectBase, int>();
			SqlConnection sqlConnection = new SqlConnection(Class18.sqlsettings_0.GetConnectionString());
			SqlCommand sqlCommand = new SqlCommand();
			foreach (DrawObjectBase drawObjectBase in from o in list_0
			where o is LineTool
			select o)
			{
				foreach (CouplingRelation couplingRelation in ((LineTool)drawObjectBase).CouplingRelations)
				{
					if (!list.Contains(couplingRelation.method_1()))
					{
						list.Add(couplingRelation.method_1());
					}
					if (!list.Contains(couplingRelation.method_2()))
					{
						list.Add(couplingRelation.method_2());
					}
				}
			}
			foreach (DrawObjectBase item in list)
			{
				if (!list_0.Contains(item))
				{
					list_0.Add(item);
				}
			}
			list.Clear();
			if (Class18.bool_0)
			{
				foreach (DrawObjectBase drawObjectBase2 in list_0)
				{
					List<DrawObjectBase> list2 = Class18.smethod_19(drawObjectBase2);
					foreach (DrawObjectBase drawObjectBase3 in list2)
					{
						if (drawObjectBase3 is LineTool)
						{
							list.AddRange(Class18.smethod_20((LineTool)drawObjectBase3));
						}
					}
					if (drawObjectBase2 is LineTool)
					{
						list.AddRange(Class18.smethod_20((LineTool)drawObjectBase2));
					}
					if (drawObjectBase2 is ObjectOnLine && drawObjectBase2.IdBase == -1 && drawObjectBase2.Parent != null && drawObjectBase2.Parent.Parent != null && !list.Contains(drawObjectBase2.Parent.Parent))
					{
						list.Add(drawObjectBase2.Parent.Parent);
					}
					list.AddRange(list2);
				}
				foreach (DrawObjectBase item2 in list)
				{
					if (!list_0.Contains(item2))
					{
						list_0.Add(item2);
					}
				}
				list.Clear();
			}
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable, "SaveSchemaObj");
			sqlCommand.Transaction = sqlTransaction;
			Class18.smethod_12(list_0, dictionary, sqlCommand);
			foreach (DrawObjectBase drawObjectBase4 in list_0)
			{
				if (drawObjectBase4.IdBase == 0)
				{
					list.Add(drawObjectBase4);
				}
				else if (drawObjectBase4 is LineTool)
				{
					using (List<CouplingRelation>.Enumerator enumerator2 = ((LineTool)drawObjectBase4).CouplingRelations.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.Id == 0)
							{
								list.Add(drawObjectBase4);
								break;
							}
						}
					}
				}
			}
			Class18.smethod_4(list, saved, dictionary, sqlCommand);
			list.Clear();
			list.AddRange(from d in list_0
			where !saved.Contains(d) && d.IdBase > -1
			select d);
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			foreach (DrawObjectBase drawObjectBase5 in list)
			{
				stringBuilder.AppendLine(Class18.smethod_8(drawObjectBase5));
				num++;
				if (dictionary.ContainsKey(drawObjectBase5))
				{
					stringBuilder.AppendLine(Class18.smethod_11(drawObjectBase5, dictionary[drawObjectBase5]));
				}
				else
				{
					stringBuilder.AppendLine(Class18.smethod_10(drawObjectBase5));
				}
				num++;
				if (drawObjectBase5 is LineTool)
				{
					foreach (CouplingRelation couplingRelation_ in ((LineTool)drawObjectBase5).CouplingRelations)
					{
						stringBuilder.AppendLine(Class18.smethod_18(couplingRelation_));
						num++;
					}
				}
				if (num >= 1000)
				{
					sqlCommand.CommandText = stringBuilder.ToString();
					sqlCommand.ExecuteNonQuery();
					stringBuilder.Remove(0, stringBuilder.Length);
				}
			}
			if (num > 0)
			{
				sqlCommand.CommandText = stringBuilder.ToString();
				sqlCommand.ExecuteNonQuery();
				stringBuilder.Remove(0, stringBuilder.Length);
			}
			sqlTransaction.Commit();
			sqlConnection.Close();
			return;
		}
	}

	private static string smethod_8(DrawObjectBase drawObjectBase_0)
	{
		string result = string.Empty;
		string text = "NULL";
		string text2 = "NULL";
		string text3 = "NULL";
		if (drawObjectBase_0.Parent != null)
		{
			if (drawObjectBase_0 is ObjectOnLine)
			{
				text = ((Branch)drawObjectBase_0.Parent).CouplingRelation.Id.ToString();
			}
			else
			{
				text = drawObjectBase_0.Parent.IdBase.ToString();
			}
		}
		if (drawObjectBase_0.GetType() == typeof(LineTool))
		{
			DrawObjectBase drawObjectBase = ((LineTool)drawObjectBase_0).ParRectangle();
			if (drawObjectBase != null)
			{
				text2 = drawObjectBase.IdBase.ToString();
			}
		}
		if (drawObjectBase_0 is ObjectOnLine)
		{
			text3 = Convert.ToByte(((ObjectOnLine)drawObjectBase_0).On).ToString();
			if (drawObjectBase_0.GetType() == typeof(TransformerTool) && drawObjectBase_0.Parent != null)
			{
				DrawObjectBase drawObjectBase2 = ((LineTool)((Branch)drawObjectBase_0.Parent).Parent).ParRectangle();
				if (drawObjectBase2 != null)
				{
					text2 = drawObjectBase2.IdBase.ToString();
				}
			}
		}
		if (drawObjectBase_0.IdBase == 0)
		{
			result = string.Format("INSERT INTO [tSchm_ObjList]\r\n                                           ([Name]\r\n                                           ,[TypeCodeId]\r\n                                           ,[IdParent]\r\n                                           ,[OnOff]\r\n                                           ,[idParentAddl])\r\n                                     VALUES\r\n                                           ('{0}'\r\n                                           ,{1}\r\n                                           ,{2}\r\n                                           ,{3}\r\n                                           ,{4})", new object[]
			{
				drawObjectBase_0.Text,
				drawObjectBase_0.GetTypeObject(),
				text,
				text3,
				text2
			});
		}
		else
		{
			result = string.Format("UPDATE [tSchm_ObjList] SET [Name] = '{0}',[TypeCodeId] = {1},[IdParent] = {2},[OnOff] = {3},[idParentAddl] = {4} WHERE id = {5}", new object[]
			{
				drawObjectBase_0.Text,
				drawObjectBase_0.GetTypeObject(),
				text,
				text3,
				text2,
				drawObjectBase_0.IdBase.ToString()
			});
		}
		return result;
	}
    /// <summary>
    /// изменение/добавление  LabelTool в базе tSchm_Label
    /// </summary>
    /// <param name="labelTool_0"></param>
    /// <returns></returns>
	private static string smethod_9(LabelTool labelTool_0)
	{
		string result = string.Empty;
		if (labelTool_0.IdBase > 0)
		{
			result = string.Format("UPDATE [tSchm_Label] SET [Name] = {0}\r\n             " +
                "                                 ,[TypeLabel] = {1}\r\n        " +
                "                                      ,[idParent] = {2}\r\n     " +
                "                                         ,[XmlCoords] = {3}\r\n     " +
                "                                         ,[Tag] = {4}\r\n          " +
                "                               WHERE id = {5}", new object[]
			{
				labelTool_0.Text,
				labelTool_0.GetTypeObject().ToString(),
				(labelTool_0.Parent != null) ? labelTool_0.Parent.IdBase.ToString() : "NULL",
				Class18.uvZfzCawlS(labelTool_0),
				(labelTool_0.Layer.Parent.IdRect > 0) ? labelTool_0.Layer.Parent.IdRect.ToString() : "NULL",
				labelTool_0.IdBase.ToString()
			});
		}
		else
		{
			result = string.Format("INSERT INTO [tSchm_Label] ([Name],[TypeLabel],[idParent],[XmlCoords],[Tag]) VALUES ({0},{1},{2},{3},{4})", new object[]
			{
				labelTool_0.Text,
				labelTool_0.GetTypeObject().ToString(),
				(labelTool_0.Parent != null) ? labelTool_0.Parent.IdBase.ToString() : "NULL",
				Class18.uvZfzCawlS(labelTool_0),
				(labelTool_0.Layer.Parent.IdRect > 0) ? labelTool_0.Layer.Parent.IdRect.ToString() : "NULL"
			});
		}
		return result;
	}

	private static string smethod_10(DrawObjectBase drawObjectBase_0)
	{
		string text = "NULL";
		RectangleTool rectangleTool = null;
		if (drawObjectBase_0.Layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
		{
			foreach (DrawObjectBase drawObjectBase in drawObjectBase_0.Layer.Objects)
			{
				if (drawObjectBase is RectangleTool)
				{
					rectangleTool = (RectangleTool)drawObjectBase;
					break;
				}
			}
		}
		if (rectangleTool != null)
		{
			text = rectangleTool.IdBase.ToString();
		}
		string text2 = string.Empty;
		if (drawObjectBase_0.GetType() == typeof(RectangleTool))
		{
			text2 = Class18.smethod_13((RectangleTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0.GetType() == typeof(ShinaTool))
		{
			text2 = Class18.smethod_14((ShinaTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is LineTool)
		{
			text2 = Class18.smethod_17((LineTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is PointTool)
		{
			text2 = Class18.smethod_15((PointTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is ObjectOnLine && drawObjectBase_0.GetType() != typeof(ArrowTool))
		{
			text2 = Class18.smethod_16((ObjectOnLine)drawObjectBase_0);
		}
		return string.Format("INSERT INTO [tSchm_Xml] ([ObjId],[TypeSchema],[SchemaXml],[Tag]) VALUES ({0},{1},'{2}',{3})", new object[]
		{
			drawObjectBase_0.IdBase,
			((int)drawObjectBase_0.Layer.Parent.TypeCanvas).ToString(),
			text2,
			text
		});
	}

	private static string smethod_11(DrawObjectBase drawObjectBase_0, int int_0)
	{
		string arg = "NULL";
		RectangleTool rectangleTool = null;
		if (drawObjectBase_0.Layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
		{
			foreach (DrawObjectBase drawObjectBase in drawObjectBase_0.Layer.Objects)
			{
				if (drawObjectBase is RectangleTool)
				{
					rectangleTool = (RectangleTool)drawObjectBase;
					break;
				}
			}
		}
		if (rectangleTool != null)
		{
			arg = rectangleTool.IdBase.ToString();
		}
		string arg2 = string.Empty;
		if (drawObjectBase_0.GetType() == typeof(RectangleTool))
		{
			arg2 = Class18.smethod_13((RectangleTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0.GetType() == typeof(ShinaTool))
		{
			arg2 = Class18.smethod_14((ShinaTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is LineTool)
		{
			arg2 = Class18.smethod_17((LineTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is PointTool)
		{
			arg2 = Class18.smethod_15((PointTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is ObjectOnLine && drawObjectBase_0.GetType() != typeof(ArrowTool))
		{
			arg2 = Class18.smethod_16((ObjectOnLine)drawObjectBase_0);
		}
		return string.Format("UPDATE [tSchm_Xml] SET [SchemaXml] = '{0}',[Tag] = {1} WHERE id  = {2}", arg2, arg, int_0.ToString());
	}

	private static void smethod_12(List<DrawObjectBase> list_0, Dictionary<DrawObjectBase, int> dictionary_0, SqlCommand sqlCommand_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = -1;
		int num2 = -1;
		foreach (DrawObjectBase drawObjectBase in list_0)
		{
			RectangleTool rectangleTool = null;
			if (drawObjectBase.Layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
			{
				using (IEnumerator<DrawObjectBase> enumerator2 = drawObjectBase.Layer.Objects.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						DrawObjectBase drawObjectBase2 = enumerator2.Current;
						if (drawObjectBase2 is RectangleTool)
						{
							rectangleTool = (RectangleTool)drawObjectBase2;
							break;
						}
					}
					goto IL_11E;
				}
				goto IL_98;
			}
			goto IL_11E;
			IL_B2:
			if (num == -1)
			{
				num = (int)drawObjectBase.Layer.Parent.TypeCanvas;
			}
			else if (num != (int)drawObjectBase.Layer.Parent.TypeCanvas)
			{
				throw new Exception(string.Format("Тип схемы объекта {0} не соответствует устатновленному ранее", drawObjectBase.IdBase));
			}
			if (drawObjectBase.IdBase > 0)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(drawObjectBase.IdBase.ToString());
				continue;
			}
			continue;
			IL_98:
			if (num2 == -1)
			{
				num2 = rectangleTool.IdBase;
				goto IL_B2;
			}
			if (num2 != rectangleTool.IdBase)
			{
				throw new Exception(string.Format("Индификатор подстанции ({0}) которой принадлежит схема не соответствует устатновленному ранее ({1}). Объект:{2}", rectangleTool.IdBase, num2, drawObjectBase.IdBase));
			}
			goto IL_B2;
			IL_11E:
			if (rectangleTool != null)
			{
				goto IL_98;
			}
			goto IL_B2;
		}
		if (stringBuilder.Length == 0)
		{
			return;
		}
		sqlCommand_0.CommandText = string.Format("SELECT [id]\r\n                                                  ,[ObjId]\r\n                                                  ,[TypeSchema]                                                  \r\n                                                  ,[Tag]\r\n                                              FROM [tSchm_Xml]\r\n                                              WHERE [ObjId] in ({0}) and [TypeSchema] = {1} and ([Tag] = {2} or [Tag] is null)", stringBuilder.ToString(), num.ToString(), num2.ToString());
		SqlDataReader reader = sqlCommand_0.ExecuteReader();
		Func<DrawObjectBase, bool> <>9__0;
		while (reader.Read())
		{
			Func<DrawObjectBase, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((DrawObjectBase d) => d.IdBase == (int)reader[1]));
			}
			DrawObjectBase key = list_0.First(predicate);
			dictionary_0.Add(key, (int)reader[0]);
		}
		reader.Close();
	}

	private static string smethod_13(RectangleTool rectangleTool_0)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml("<Obj></Obj>");
		XmlNode xmlNode = xmlDocument.SelectSingleNode("Obj");
		((XmlElement)xmlNode).SetAttribute("X1", Math.Round((double)rectangleTool_0.Rectangle.Location.X, 4).ToString(new CultureInfo(1033)));
		((XmlElement)xmlNode).SetAttribute("Y1", Math.Round((double)rectangleTool_0.Rectangle.Location.Y, 4).ToString(new CultureInfo(1033)));
		((XmlElement)xmlNode).SetAttribute("X2", Math.Round((double)rectangleTool_0.Rectangle.Size.Width, 4).ToString(new CultureInfo(1033)));
		((XmlElement)xmlNode).SetAttribute("Y2", Math.Round((double)rectangleTool_0.Rectangle.Size.Height, 4).ToString(new CultureInfo(1033)));
		if (rectangleTool_0.IsSubscriber)
		{
			((XmlElement)xmlNode).SetAttribute("Subscriber", rectangleTool_0.IsSubscriber.ToString());
		}
		if (rectangleTool_0.TextProperty.Visible)
		{
			((XmlElement)xmlNode).SetAttribute("textVis", rectangleTool_0.TextProperty.Visible.ToString());
			((XmlElement)xmlNode).SetAttribute("textPos", ((int)rectangleTool_0.TextProperty.Position).ToString());
			((XmlElement)xmlNode).SetAttribute("fontVert", rectangleTool_0.TextProperty.FontVirtical.ToString());
		}
		if (rectangleTool_0.Visible)
		{
			((XmlElement)xmlNode).SetAttribute("Visible", rectangleTool_0.Visible.ToString());
		}
		if (!rectangleTool_0.UseSettingColor)
		{
			((XmlElement)xmlNode).SetAttribute("Color", rectangleTool_0.Color.ToArgb().ToString());
		}
		if (!rectangleTool_0.UseSettingsText)
		{
			((XmlElement)xmlNode).SetAttribute("FontName", rectangleTool_0.TextProperty.FontName);
			((XmlElement)xmlNode).SetAttribute("FontSize", rectangleTool_0.TextProperty.FontSize.ToString(new CultureInfo(1033)));
			((XmlElement)xmlNode).SetAttribute("FontBold", rectangleTool_0.TextProperty.FontBold.ToString());
			((XmlElement)xmlNode).SetAttribute("FontItalic", rectangleTool_0.TextProperty.FontItalic.ToString());
			((XmlElement)xmlNode).SetAttribute("FontUnderline", rectangleTool_0.TextProperty.FontUnderline.ToString());
			((XmlElement)xmlNode).SetAttribute("FontColor", rectangleTool_0.TextProperty.Color.ToArgb().ToString());
		}
		return xmlDocument.InnerXml;
	}

	private static string smethod_14(ShinaTool shinaTool_0)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml("<Obj></Obj>");
		XmlNode xmlNode = xmlDocument.SelectSingleNode("Obj");
		((XmlElement)xmlNode).SetAttribute("X1", Math.Round(shinaTool_0.P1.X, 4).ToString(new CultureInfo(1033)));
		((XmlElement)xmlNode).SetAttribute("Y1", Math.Round(shinaTool_0.P1.Y, 4).ToString(new CultureInfo(1033)));
		((XmlElement)xmlNode).SetAttribute("X2", Math.Round(shinaTool_0.P2.X, 4).ToString(new CultureInfo(1033)));
		((XmlElement)xmlNode).SetAttribute("Y2", Math.Round(shinaTool_0.P2.Y, 4).ToString(new CultureInfo(1033)));
		if (shinaTool_0.TextProperty.Visible)
		{
			((XmlElement)xmlNode).SetAttribute("textPos", ((int)shinaTool_0.TextProperty.Position).ToString());
		}
		if (shinaTool_0.TextVoltProperty.Visible)
		{
			((XmlElement)xmlNode).SetAttribute("TextVoltVis", shinaTool_0.TextVoltProperty.Visible.ToString());
			((XmlElement)xmlNode).SetAttribute("TextVoltPos", ((int)shinaTool_0.TextVoltProperty.Position).ToString());
		}
		if (shinaTool_0.LimitedEditing)
		{
			((XmlElement)xmlNode).SetAttribute("limEd", shinaTool_0.LimitedEditing.ToString());
		}
		foreach (DrawObjectBase drawObjectBase in shinaTool_0.ChildObjects)
		{
			if (drawObjectBase.GetType() == typeof(PointShinaTool))
			{
				if (((PointShinaTool)drawObjectBase).CouplingRelations.Count > 0)
				{
					XmlElement xmlElement = xmlDocument.CreateElement("point");
					xmlElement.SetAttribute("ID", drawObjectBase.IdBase.ToString());
					xmlNode.AppendChild(xmlElement);
				}
				else if (((PointShinaTool)drawObjectBase).Branches.Count<Branch>() == 0)
				{
					XmlElement xmlElement2 = xmlDocument.CreateElement("WP");
					PointShinaTool pointShinaTool = (PointShinaTool)drawObjectBase;
					xmlElement2.SetAttribute("X", Math.Round(pointShinaTool.Point.X, 4).ToString(new CultureInfo(1033)));
					xmlElement2.SetAttribute("Y", Math.Round(pointShinaTool.Point.Y, 4).ToString(new CultureInfo(1033)));
					if (pointShinaTool.Color != Color.White)
					{
						xmlElement2.SetAttribute("Color", pointShinaTool.Color.ToArgb().ToString());
					}
					if (!string.IsNullOrEmpty(pointShinaTool.Text))
					{
						xmlElement2.SetAttribute("text", pointShinaTool.Text);
						if (pointShinaTool.TextProperty.Visible)
						{
							xmlElement2.SetAttribute("textPos", ((int)pointShinaTool.TextProperty.Position).ToString());
						}
						if (!pointShinaTool.UseSettingsText)
						{
							xmlElement2.SetAttribute("FontName", pointShinaTool.TextProperty.FontName);
							xmlElement2.SetAttribute("FontSize", pointShinaTool.TextProperty.FontSize.ToString(new CultureInfo(1033)));
							xmlElement2.SetAttribute("FontBold", pointShinaTool.TextProperty.FontBold.ToString());
							xmlElement2.SetAttribute("FontItalic", pointShinaTool.TextProperty.FontItalic.ToString());
							xmlElement2.SetAttribute("FontUnderline", pointShinaTool.TextProperty.FontUnderline.ToString());
							xmlElement2.SetAttribute("FontColor", pointShinaTool.TextProperty.Color.ToArgb().ToString());
						}
					}
					xmlNode.AppendChild(xmlElement2);
				}
			}
		}
		return xmlDocument.InnerXml;
	}

	private static string smethod_15(PointTool pointTool_0)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml("<Obj></Obj>");
		XmlNode xmlNode = xmlDocument.SelectSingleNode("Obj");
		((XmlElement)xmlNode).SetAttribute("X", Math.Round(pointTool_0.Point.X, 4).ToString(new CultureInfo(1033)));
		((XmlElement)xmlNode).SetAttribute("Y", Math.Round(pointTool_0.Point.Y, 4).ToString(new CultureInfo(1033)));
		if (!string.IsNullOrEmpty(pointTool_0.Text))
		{
			((XmlElement)xmlNode).SetAttribute("text", pointTool_0.Text);
			((XmlElement)xmlNode).SetAttribute("textVis", pointTool_0.TextProperty.Visible.ToString());
			((XmlElement)xmlNode).SetAttribute("textPos", ((int)pointTool_0.TextProperty.Position).ToString());
			if (!pointTool_0.UseSettingsText)
			{
				((XmlElement)xmlNode).SetAttribute("FontName", pointTool_0.TextProperty.FontName);
				((XmlElement)xmlNode).SetAttribute("FontSize", pointTool_0.TextProperty.FontSize.ToString(new CultureInfo(1033)));
				((XmlElement)xmlNode).SetAttribute("FontBold", pointTool_0.TextProperty.FontBold.ToString());
				((XmlElement)xmlNode).SetAttribute("FontItalic", pointTool_0.TextProperty.FontItalic.ToString());
				((XmlElement)xmlNode).SetAttribute("FontUnderline", pointTool_0.TextProperty.FontUnderline.ToString());
				((XmlElement)xmlNode).SetAttribute("FontColor", pointTool_0.TextProperty.Color.ToArgb().ToString());
			}
		}
		return xmlDocument.InnerXml;
	}

	private static string smethod_16(ObjectOnLine objectOnLine_0)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml("<Obj></Obj>");
		XmlNode xmlNode = xmlDocument.SelectSingleNode("Obj");
		if (objectOnLine_0.GetType() != typeof(ArrowTool))
		{
			((XmlElement)xmlNode).SetAttribute("delta", Math.Round(objectOnLine_0.Delta, 4).ToString(new CultureInfo(1033)));
			if (objectOnLine_0.MappingState)
			{
				((XmlElement)xmlNode).SetAttribute("MappingState", objectOnLine_0.MappingState.ToString());
			}
			if (objectOnLine_0.IsNormalSection)
			{
				((XmlElement)xmlNode).SetAttribute("IsNormal", objectOnLine_0.IsNormalSection.ToString());
				((XmlElement)xmlNode).SetAttribute("NormalPosition", ((int)objectOnLine_0.TextPropertyNormalSection.Position).ToString());
			}
			if (objectOnLine_0.TextProperty.Visible)
			{
				((XmlElement)xmlNode).SetAttribute("textVis", objectOnLine_0.TextProperty.Visible.ToString());
				((XmlElement)xmlNode).SetAttribute("textPos", ((int)objectOnLine_0.TextProperty.Position).ToString());
			}
			if (objectOnLine_0.PositionDamage != ePositionText.None)
			{
				((XmlElement)xmlNode).SetAttribute("PosDamage", ((int)objectOnLine_0.PositionDamage).ToString());
			}
			if (objectOnLine_0.PositionKey != ePositionText.None)
			{
				((XmlElement)xmlNode).SetAttribute("PosKey", ((int)objectOnLine_0.PositionKey).ToString());
			}
			((XmlElement)xmlNode).SetAttribute("gorMirror", objectOnLine_0.GorMirror.ToString());
			((XmlElement)xmlNode).SetAttribute("vertMirror", objectOnLine_0.VertMirror.ToString());
			((XmlElement)xmlNode).SetAttribute("ComplexSwitchgear", (objectOnLine_0.ComplexSwitchgear != null).ToString());
			if (objectOnLine_0.ComplexSwitchgear != null)
			{
				((XmlElement)xmlNode).SetAttribute("ComplexSwitchgearRollingOutReason", ((int)objectOnLine_0.ComplexSwitchgear.RollingOutReason).ToString());
			}
			if (!objectOnLine_0.ContainsGrounding)
			{
				((XmlElement)xmlNode).SetAttribute("ContainsGrounding", objectOnLine_0.ContainsGrounding.ToString());
				if (objectOnLine_0.ContainsGroundingOn)
				{
					((XmlElement)xmlNode).SetAttribute("ContainsGroundingOn", objectOnLine_0.ContainsGroundingOn.ToString());
				}
			}
			if (!objectOnLine_0.UseSettingColor)
			{
				((XmlElement)xmlNode).SetAttribute("Color", objectOnLine_0.Color.ToArgb().ToString());
			}
			if (!objectOnLine_0.UseSettingsText)
			{
				((XmlElement)xmlNode).SetAttribute("FontName", objectOnLine_0.TextProperty.FontName);
				((XmlElement)xmlNode).SetAttribute("FontSize", objectOnLine_0.TextProperty.FontSize.ToString(new CultureInfo(1033)));
				((XmlElement)xmlNode).SetAttribute("FontBold", objectOnLine_0.TextProperty.FontBold.ToString());
				((XmlElement)xmlNode).SetAttribute("FontItalic", objectOnLine_0.TextProperty.FontItalic.ToString());
				((XmlElement)xmlNode).SetAttribute("FontUnderline", objectOnLine_0.TextProperty.FontUnderline.ToString());
				((XmlElement)xmlNode).SetAttribute("FontColor", objectOnLine_0.TextProperty.Color.ToArgb().ToString());
			}
		}
		return xmlDocument.InnerXml;
	}

	private static string smethod_17(LineTool lineTool_0)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml("<Obj></Obj>");
		XmlNode xmlNode = xmlDocument.SelectSingleNode("Obj");
		if (lineTool_0.TextProperty.Visible)
		{
			((XmlElement)xmlNode).SetAttribute("textVis", lineTool_0.TextProperty.Visible.ToString());
			((XmlElement)xmlNode).SetAttribute("textPos", ((int)lineTool_0.TextProperty.Position).ToString());
		}
		if (lineTool_0.LimitedEditing)
		{
			((XmlElement)xmlNode).SetAttribute("limEd", lineTool_0.LimitedEditing.ToString());
		}
		List<PointTool> pointsList = lineTool_0.GetPointsList();
		XmlElement xmlElement = xmlDocument.CreateElement("Points");
		xmlNode.AppendChild(xmlElement);
		bool flag = true;
		foreach (PointTool pointTool in pointsList)
		{
			XmlElement xmlElement2 = xmlDocument.CreateElement("Point");
			xmlElement.AppendChild(xmlElement2);
			if (pointTool.IdBase <= 0)
			{
				xmlElement2.SetAttribute("X", Math.Round(pointTool.Point.X, 4).ToString(new CultureInfo(1033)));
				xmlElement2.SetAttribute("Y", Math.Round(pointTool.Point.Y, 4).ToString(new CultureInfo(1033)));
				if (pointTool.TextProperty.Visible)
				{
					xmlElement2.SetAttribute("text", pointTool.Text);
					xmlElement2.SetAttribute("textVis", pointTool.TextProperty.Visible.ToString());
					xmlElement2.SetAttribute("textPos", ((int)pointTool.TextProperty.Position).ToString());
					if (!pointTool.UseSettingsText)
					{
						xmlElement2.SetAttribute("FontColor", pointTool.TextProperty.Color.ToArgb().ToString());
					}
				}
			}
			else
			{
				xmlElement2.SetAttribute("ID", pointTool.IdBase.ToString());
			}
			if (pointTool.TextProperty.Visible && flag)
			{
				int idBase = pointTool.IdBase;
				((XmlElement)xmlNode).SetAttribute("textPoint", idBase.ToString());
				flag = false;
			}
		}
		foreach (Branch branch in lineTool_0.Branches)
		{
			XmlElement xmlElement3 = xmlDocument.CreateElement("Branch");
			xmlElement3.SetAttribute("Type", ((int)branch.Type).ToString());
			xmlElement3.SetAttribute("srcID", pointsList.IndexOf(branch.Source).ToString());
			xmlElement3.SetAttribute("destID", pointsList.IndexOf(branch.Destination).ToString());
			if (branch.CouplingRelation != null)
			{
				xmlElement3.SetAttribute("relationId", branch.CouplingRelation.Id.ToString());
			}
			xmlNode.AppendChild(xmlElement3);
			foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
			{
				if (drawObjectBase is TextBranchTool)
				{
					XmlElement xmlElement4 = xmlDocument.CreateElement("textBranch");
					xmlElement4.SetAttribute("delta", Math.Round((double)((TextBranchTool)drawObjectBase).Delta, 4).ToString(new CultureInfo(1033)));
					xmlElement4.SetAttribute("direct", ((TextBranchTool)drawObjectBase).Direct.ToString());
					xmlElement4.SetAttribute("text", ((TextBranchTool)drawObjectBase).Text);
					xmlElement4.SetAttribute("type", ((int)((TextBranchTool)drawObjectBase).Type).ToString());
					xmlElement4.SetAttribute("TextPos", ((int)drawObjectBase.TextProperty.Position).ToString());
					xmlElement4.SetAttribute("Passport", ((TextBranchTool)drawObjectBase).Passport.ToString());
					if (!drawObjectBase.UseSettingColor)
					{
						xmlElement4.SetAttribute("Color", drawObjectBase.Color.ToArgb().ToString());
					}
					if (!drawObjectBase.UseSettingsText)
					{
						xmlElement4.SetAttribute("FontName", drawObjectBase.TextProperty.FontName);
						xmlElement4.SetAttribute("FontSize", drawObjectBase.TextProperty.FontSize.ToString(new CultureInfo(1033)));
						xmlElement4.SetAttribute("FontBold", drawObjectBase.TextProperty.FontBold.ToString());
						xmlElement4.SetAttribute("FontItalic", drawObjectBase.TextProperty.FontItalic.ToString());
						xmlElement4.SetAttribute("FontUnderline", drawObjectBase.TextProperty.FontUnderline.ToString());
					}
					xmlElement3.AppendChild(xmlElement4);
				}
				if (drawObjectBase is ObjectOnLine && !((ObjectOnLine)drawObjectBase).MappingState)
				{
					XmlElement xmlElement5 = xmlDocument.CreateElement("objOnLine");
					xmlElement5.SetAttribute("ID", drawObjectBase.IdBase.ToString());
					xmlElement3.AppendChild(xmlElement5);
				}
				else if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine))
				{
					if (drawObjectBase.IdBase > 0)
					{
						XmlElement xmlElement6 = xmlDocument.CreateElement("objOnLine");
						xmlElement6.SetAttribute("ID", drawObjectBase.IdBase.ToString());
						xmlElement3.AppendChild(xmlElement6);
					}
					else
					{
						XmlElement xmlElement7 = xmlDocument.CreateElement("state");
						xmlElement7.SetAttribute("type", Convert.ToInt32(((ObjectOnLine)drawObjectBase).State.state).ToString());
						xmlElement7.SetAttribute("delta", Math.Round(((ObjectOnLine)drawObjectBase).Delta, 4).ToString(new CultureInfo(1033)));
						xmlElement7.SetAttribute("On", ((ObjectOnLine)drawObjectBase).On.ToString());
						xmlElement7.SetAttribute("gorMirror", ((ObjectOnLine)drawObjectBase).GorMirror.ToString());
						xmlElement7.SetAttribute("vertMirror", ((ObjectOnLine)drawObjectBase).VertMirror.ToString());
						xmlElement7.SetAttribute("Text", ((ObjectOnLine)drawObjectBase).Text);
						if (drawObjectBase.TextProperty.Visible)
						{
							xmlElement7.SetAttribute("TextPos", ((int)drawObjectBase.TextProperty.Position).ToString());
						}
						if (!drawObjectBase.UseSettingColor)
						{
							xmlElement7.SetAttribute("Color", drawObjectBase.Color.ToArgb().ToString());
						}
						xmlElement3.AppendChild(xmlElement7);
					}
				}
			}
		}
		return xmlDocument.InnerXml;
	}

	private static string uvZfzCawlS(LabelTool labelTool_0)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml("<Obj></Obj>");
		XmlNode xmlNode = xmlDocument.SelectSingleNode("Obj");
		((XmlElement)xmlNode).SetAttribute("X1", Math.Round(labelTool_0.Location.X, 4).ToString(new CultureInfo(1033)));
		((XmlElement)xmlNode).SetAttribute("Y1", Math.Round(labelTool_0.Location.Y, 4).ToString(new CultureInfo(1033)));
		if (!labelTool_0.UseSettingsText)
		{
			((XmlElement)xmlNode).SetAttribute("FontName", labelTool_0.TextProperty.FontName);
			((XmlElement)xmlNode).SetAttribute("FontSize", labelTool_0.TextProperty.FontSize.ToString(new CultureInfo(1033)));
			((XmlElement)xmlNode).SetAttribute("FontBold", labelTool_0.TextProperty.FontBold.ToString());
			((XmlElement)xmlNode).SetAttribute("FontItalic", labelTool_0.TextProperty.FontItalic.ToString());
			((XmlElement)xmlNode).SetAttribute("FontUnderline", labelTool_0.TextProperty.FontUnderline.ToString());
			((XmlElement)xmlNode).SetAttribute("FontColor", labelTool_0.TextProperty.Color.ToArgb().ToString());
		}
		if (labelTool_0.TextProperty.FontVirtical)
		{
			((XmlElement)xmlNode).SetAttribute("FontVirtical", labelTool_0.TextProperty.FontVirtical.ToString());
		}
		return xmlDocument.InnerXml;
	}

	private static string smethod_18(CouplingRelation couplingRelation_0)
	{
		if (couplingRelation_0.Id == 0)
		{
			return string.Format("INSERT INTO [tSchm_Relation]\r\n                                                               ([SourceObj]\r\n                                                               ,[DestObj]\r\n                                                               ,[Edge])\r\n                                                         VALUES\r\n                                                               ({0}\r\n                                                               ,{1}\r\n                                                               ,{2})", couplingRelation_0.method_1().IdBase.ToString(), couplingRelation_0.method_2().IdBase.ToString(), couplingRelation_0.Line.IdBase.ToString());
		}
		return string.Format("UPDATE [tSchm_Relation]\r\n                                                           SET [SourceObj] = {1}\r\n                                                              ,[DestObj] = {2}\r\n                                                              ,[Edge] = {3}\r\n                                                         WHERE id = {0}", new object[]
		{
			couplingRelation_0.Id,
			couplingRelation_0.method_1().IdBase.ToString(),
			couplingRelation_0.method_2().IdBase.ToString(),
			couplingRelation_0.Line.IdBase.ToString()
		});
	}

	private static List<DrawObjectBase> smethod_19(DrawObjectBase drawObjectBase_0)
	{
		List<DrawObjectBase> list = new List<DrawObjectBase>();
		if (drawObjectBase_0 is LineTool)
		{
			using (List<Branch>.Enumerator enumerator = ((LineTool)drawObjectBase_0).Branches.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Branch branch = enumerator.Current;
					foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
					{
						list.Add(drawObjectBase);
						list.AddRange(Class18.smethod_19(drawObjectBase));
					}
				}
				return list;
			}
		}
		foreach (DrawObjectBase drawObjectBase2 in drawObjectBase_0.ChildObjects)
		{
			list.Add(drawObjectBase2);
			list.AddRange(Class18.smethod_19(drawObjectBase2));
		}
		return list;
	}

	private static List<DrawObjectBase> smethod_20(LineTool lineTool_0)
	{
		List<DrawObjectBase> list = new List<DrawObjectBase>();
		foreach (CouplingRelation couplingRelation in lineTool_0.CouplingRelations)
		{
			list.Add(couplingRelation.method_1());
			list.Add(couplingRelation.method_2());
		}
		return list;
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class18()
	{
		
		Class18.bool_0 = true;
		Class18.guid_0 = Guid.Empty;
	}

	private static bool bool_0;

	private static SQLSettings sqlsettings_0;

	private static Guid guid_0;
}
