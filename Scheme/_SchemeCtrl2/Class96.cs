using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using DataSql;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

internal static class Class96
{
	[CompilerGenerated]
	internal static SQLSettings smethod_0()
	{
		return Class96.sqlsettings_0;
	}

	[CompilerGenerated]
	internal static void smethod_1(SQLSettings sqlsettings_1)
	{
		Class96.sqlsettings_0 = sqlsettings_1;
	}

	internal static bool smethod_2(List<DrawObjectBase> list_0, List<DrawObjectBase> list_1, Dictionary<DrawObjectBase, int> dictionary_0, SqlCommand sqlCommand_0)
	{
		Func<DrawObjectBase, bool> func = null;
		Func<DrawObjectBase, bool> func2 = null;
		Class96.Class97 @class = new Class96.Class97();
		@class.list_0 = list_1;
		if (sqlCommand_0.Connection != null)
		{
			if (sqlCommand_0.Connection.State == ConnectionState.Open)
			{
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase_ in list_0)
				{
					list.AddRange(Class96.smethod_19(drawObjectBase_));
				}
				foreach (DrawObjectBase item in list)
				{
					if (!list_0.Contains(item))
					{
						list_0.Add(item);
					}
				}
				list.Clear();
				list.AddRange(list_0.Where(new Func<DrawObjectBase, bool>(@class.method_0)));
				foreach (DrawObjectBase drawObjectBase in list)
				{
					Class96.smethod_4(sqlCommand_0, drawObjectBase, dictionary_0);
					@class.list_0.Add(drawObjectBase);
				}
				list.Clear();
				list.AddRange(list_0.Where(new Func<DrawObjectBase, bool>(@class.method_1)));
				foreach (DrawObjectBase drawObjectBase2 in list)
				{
					Class96.smethod_3(sqlCommand_0, drawObjectBase2);
					IEnumerable<DrawObjectBase> childObjects = drawObjectBase2.ChildObjects;
					if (func == null)
					{
						func = new Func<DrawObjectBase, bool>(@class.method_2);
					}
					foreach (DrawObjectBase drawObjectBase3 in childObjects.Where(func))
					{
						Class96.smethod_4(sqlCommand_0, drawObjectBase3, dictionary_0);
						@class.list_0.Add(drawObjectBase3);
					}
					sqlCommand_0.CommandText = Class96.smethod_9(drawObjectBase2);
					sqlCommand_0.ExecuteNonQuery();
					@class.list_0.Add(drawObjectBase2);
				}
				list.Clear();
				list.AddRange(list_0.Where(new Func<DrawObjectBase, bool>(@class.method_3)));
				foreach (DrawObjectBase drawObjectBase4 in list)
				{
					Class96.smethod_3(sqlCommand_0, drawObjectBase4);
					foreach (CouplingRelation couplingRelation in ((LineTool)drawObjectBase4).CouplingRelations)
					{
						if (!@class.list_0.Contains(couplingRelation.Vertex1))
						{
							Class96.smethod_4(sqlCommand_0, couplingRelation.Vertex1, dictionary_0);
							@class.list_0.Add(couplingRelation.Vertex1);
						}
						if (!@class.list_0.Contains(couplingRelation.Vertex2))
						{
							Class96.smethod_4(sqlCommand_0, couplingRelation.Vertex2, dictionary_0);
							@class.list_0.Add(couplingRelation.Vertex2);
						}
						sqlCommand_0.CommandText = Class96.smethod_18(couplingRelation);
						sqlCommand_0.ExecuteNonQuery();
						if (couplingRelation.Id == 0)
						{
							sqlCommand_0.CommandText = "select IDENT_CURRENT('tSchm_Relation')";
							couplingRelation.Id = Convert.ToInt32(sqlCommand_0.ExecuteScalar());
						}
						foreach (Branch branch in couplingRelation.Branches)
						{
							IEnumerable<DrawObjectBase> childObjects2 = branch.ChildObjects;
							if (func2 == null)
							{
								func2 = new Func<DrawObjectBase, bool>(@class.method_4);
							}
							foreach (DrawObjectBase drawObjectBase5 in childObjects2.Where(func2))
							{
								Class96.smethod_4(sqlCommand_0, drawObjectBase5, dictionary_0);
								@class.list_0.Add(drawObjectBase5);
							}
						}
					}
					if (dictionary_0.ContainsKey(drawObjectBase4))
					{
						sqlCommand_0.CommandText = Class96.smethod_10(drawObjectBase4, dictionary_0[drawObjectBase4]);
					}
					else
					{
						sqlCommand_0.CommandText = Class96.smethod_9(drawObjectBase4);
					}
					sqlCommand_0.ExecuteNonQuery();
					@class.list_0.Add(drawObjectBase4);
				}
				list.Clear();
				list.AddRange(list_0.Where(new Func<DrawObjectBase, bool>(@class.method_5)));
				foreach (DrawObjectBase drawObjectBase6 in list)
				{
					Class96.smethod_4(sqlCommand_0, drawObjectBase6, dictionary_0);
					@class.list_0.Add(drawObjectBase6);
				}
				list.Clear();
				list.AddRange(list_0.Where(new Func<DrawObjectBase, bool>(@class.method_6)));
				foreach (DrawObjectBase drawObjectBase7 in list)
				{
					if (drawObjectBase7.GetType() != typeof(ArrowTool))
					{
						Class96.smethod_4(sqlCommand_0, drawObjectBase7, dictionary_0);
						@class.list_0.Add(drawObjectBase7);
					}
				}
				list.Clear();
				list.AddRange(list_0.Where(new Func<DrawObjectBase, bool>(@class.method_7)));
				using (List<DrawObjectBase>.Enumerator enumerator12 = list.GetEnumerator())
				{
					while (enumerator12.MoveNext())
					{
						DrawObjectBase drawObjectBase8 = enumerator12.Current;
						sqlCommand_0.CommandText = Class96.smethod_8((LabelTool)drawObjectBase8);
						sqlCommand_0.ExecuteNonQuery();
						if (drawObjectBase8.IdBase == 0)
						{
							sqlCommand_0.CommandText = "select IDENT_CURRENT('tSchm_ObjList')";
							drawObjectBase8.IdBase = Convert.ToInt32(sqlCommand_0.ExecuteScalar());
						}
						@class.list_0.Add(drawObjectBase8);
					}
					goto IL_57E;
				}
				goto IL_573;
				IL_57E:
				list.Clear();
				return false;
			}
		}
		IL_573:
		throw new Exception("Объект SqlCommand не подготовлен");
	}

	private static void smethod_3(SqlCommand sqlCommand_0, DrawObjectBase drawObjectBase_0)
	{
		if (sqlCommand_0.Connection != null)
		{
			if (sqlCommand_0.Connection.State == ConnectionState.Open)
			{
				sqlCommand_0.CommandText = Class96.smethod_7(drawObjectBase_0);
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

	private static void smethod_4(SqlCommand sqlCommand_0, DrawObjectBase drawObjectBase_0, Dictionary<DrawObjectBase, int> dictionary_0)
	{
		if (sqlCommand_0.Connection != null)
		{
			if (sqlCommand_0.Connection.State == ConnectionState.Open)
			{
				try
				{
					Class96.smethod_3(sqlCommand_0, drawObjectBase_0);
					if (dictionary_0.ContainsKey(drawObjectBase_0))
					{
						sqlCommand_0.CommandText = Class96.smethod_10(drawObjectBase_0, dictionary_0[drawObjectBase_0]);
					}
					else
					{
						sqlCommand_0.CommandText = Class96.smethod_9(drawObjectBase_0);
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

	internal static void smethod_5(DrawObjectBase drawObjectBase_0)
	{
		Class96.smethod_6(new List<DrawObjectBase>
		{
			drawObjectBase_0
		});
	}

	internal static void smethod_6(List<DrawObjectBase> list_0)
	{
		Class96.Class98 @class = new Class96.Class98();
		if (list_0.Count > 0 && list_0.First<DrawObjectBase>().Layer != null && list_0.First<DrawObjectBase>().Layer.Parent != null && list_0.First<DrawObjectBase>().Layer.Parent.SqlSettings != null)
		{
			Class96.smethod_1(list_0.First<DrawObjectBase>().Layer.Parent.SqlSettings);
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			@class.list_0 = new List<DrawObjectBase>();
			Dictionary<DrawObjectBase, int> dictionary = new Dictionary<DrawObjectBase, int>();
			SqlConnection sqlConnection = new SqlConnection(Class96.smethod_0().GetConnectionString());
			SqlCommand sqlCommand = new SqlCommand();
			foreach (DrawObjectBase drawObjectBase in list_0)
			{
				List<DrawObjectBase> list2 = Class96.smethod_19(drawObjectBase);
				foreach (DrawObjectBase drawObjectBase2 in list2)
				{
					if (drawObjectBase2 is LineTool)
					{
						list.AddRange(Class96.smethod_20((LineTool)drawObjectBase2));
					}
				}
				if (drawObjectBase is LineTool)
				{
					list.AddRange(Class96.smethod_20((LineTool)drawObjectBase));
				}
				if (drawObjectBase is ObjectOnLine && drawObjectBase.IdBase == -1 && drawObjectBase.Parent != null && drawObjectBase.Parent.Parent != null && !list.Contains(drawObjectBase.Parent.Parent))
				{
					list.Add(drawObjectBase.Parent.Parent);
				}
				list.AddRange(list2);
			}
			foreach (DrawObjectBase item in list)
			{
				if (!list_0.Contains(item))
				{
					list_0.Add(item);
				}
			}
			list.Clear();
			sqlCommand.Connection = sqlConnection;
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable, "SaveSchemaObj");
			sqlCommand.Transaction = sqlTransaction;
			Class96.smethod_11(list_0, dictionary, sqlCommand);
			foreach (DrawObjectBase drawObjectBase3 in list_0)
			{
				if (drawObjectBase3.IdBase == 0)
				{
					list.Add(drawObjectBase3);
				}
				else if (drawObjectBase3 is LineTool)
				{
					foreach (CouplingRelation couplingRelation in ((LineTool)drawObjectBase3).CouplingRelations)
					{
						if (couplingRelation.Id == 0)
						{
							list.Add(drawObjectBase3);
							break;
						}
					}
				}
			}
			Class96.smethod_2(list, @class.list_0, dictionary, sqlCommand);
			list.Clear();
			list.AddRange(list_0.Where(new Func<DrawObjectBase, bool>(@class.method_0)));
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			foreach (DrawObjectBase drawObjectBase4 in list)
			{
				stringBuilder.AppendLine(Class96.smethod_7(drawObjectBase4));
				num++;
				if (dictionary.ContainsKey(drawObjectBase4))
				{
					stringBuilder.AppendLine(Class96.smethod_10(drawObjectBase4, dictionary[drawObjectBase4]));
				}
				else
				{
					stringBuilder.AppendLine(Class96.smethod_9(drawObjectBase4));
				}
				num++;
				if (drawObjectBase4 is LineTool)
				{
					foreach (CouplingRelation couplingRelation_ in ((LineTool)drawObjectBase4).CouplingRelations)
					{
						stringBuilder.AppendLine(Class96.smethod_18(couplingRelation_));
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

	private static string smethod_7(DrawObjectBase drawObjectBase_0)
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
			result = string.Format("UPDATE [tSchm_ObjList]\r\n                                           SET [Name] = '{0}'\r\n                                              ,[TypeCodeId] = {1}\r\n                                              ,[IdParent] = {2}\r\n                                              ,[OnOff] = {3}\r\n                                              ,[idParentAddl] = {4}\r\n                                         WHERE id = {5}", new object[]
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

	private static string smethod_8(LabelTool labelTool_0)
	{
		string result = string.Empty;
		if (labelTool_0.IdBase > 0)
		{
			result = string.Format("UPDATE [tSchm_Label]\r\n               " +
                "                            SET [Name] = {0}\r\n    " +
                "                                          ,[TypeLabel] = {1}\r\n   " +
                "                                           ,[idParent] = {2}\r\n   " +
                "                                           ,[XmlCoords] = {3}\r\n  " +
                "                                            ,[Tag] = {4}\r\n       " +
                "                                  WHERE id = {5}", new object[]

			{
				labelTool_0.Text,
				labelTool_0.GetTypeObject().ToString(),
				(labelTool_0.Parent != null) ? labelTool_0.Parent.IdBase.ToString() : "NULL",
				Class96.smethod_17(labelTool_0),
				(labelTool_0.Layer.Parent.IdRect > 0) ? labelTool_0.Layer.Parent.IdRect.ToString() : "NULL",
				labelTool_0.IdBase.ToString()
			});
		}
		else
		{
			result = string.Format("INSERT INTO [tSchm_Label]\r\n   " +
                "                                            ([Name]\r\n  " +
                "                                             ,[TypeLabel]\r\n   " +
                "                                            ,[idParent]\r\n     " +
                "                                          ,[XmlCoords]\r\n      " +
                "                                         ,[Tag])\r\n            " +
                "                             VALUES\r\n                         " +
                "                      ({0}\r\n                                  " +
                "             ,{1}\r\n                                           " +
                "    ,{2}\r\n      ,{3}\r\n              ,{4})", new object[]
			{
				labelTool_0.Text,
				labelTool_0.GetTypeObject().ToString(),
				(labelTool_0.Parent != null) ? labelTool_0.Parent.IdBase.ToString() : "NULL",
				Class96.smethod_17(labelTool_0),
				(labelTool_0.Layer.Parent.IdRect > 0) ? labelTool_0.Layer.Parent.IdRect.ToString() : "NULL"
			});
		}
		return result;
	}

	private static string smethod_9(DrawObjectBase drawObjectBase_0)
	{
		string empty = string.Empty;
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
			text2 = Class96.smethod_12((RectangleTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0.GetType() == typeof(ShinaTool))
		{
			text2 = Class96.smethod_13((ShinaTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is LineTool)
		{
			text2 = Class96.smethod_16((LineTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is PointTool)
		{
			text2 = Class96.smethod_14((PointTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is ObjectOnLine && drawObjectBase_0.GetType() != typeof(ArrowTool))
		{
			text2 = Class96.smethod_15((ObjectOnLine)drawObjectBase_0);
		}
		return string.Format("INSERT INTO [tSchm_Xml]\r\n                                        ([ObjId]\r\n                                        ,[TypeSchema]\r\n                                        ,[SchemaXml]\r\n                                        ,[Tag])\r\n                                    VALUES\r\n                                        ({0}\r\n                                        ,{1}\r\n                                        ,'{2}'\r\n                                        ,{3})", new object[]
		{
			drawObjectBase_0.IdBase,
			((int)drawObjectBase_0.Layer.Parent.TypeCanvas).ToString(),
			text2,
			text
		});
	}

	private static string smethod_10(DrawObjectBase drawObjectBase_0, int int_1)
	{
		string empty = string.Empty;
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
			arg2 = Class96.smethod_12((RectangleTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0.GetType() == typeof(ShinaTool))
		{
			arg2 = Class96.smethod_13((ShinaTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is LineTool)
		{
			arg2 = Class96.smethod_16((LineTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is PointTool)
		{
			arg2 = Class96.smethod_14((PointTool)drawObjectBase_0);
		}
		else if (drawObjectBase_0 is ObjectOnLine && drawObjectBase_0.GetType() != typeof(ArrowTool))
		{
			arg2 = Class96.smethod_15((ObjectOnLine)drawObjectBase_0);
		}
		return string.Format("UPDATE [tSchm_Xml]\r\n                                        SET [SchemaXml] = '{0}'\r\n                                            ,[Tag] = {1}\r\n                                        WHERE id  = {2}", arg2, arg, int_1.ToString());
	}

	private static void smethod_11(List<DrawObjectBase> list_0, Dictionary<DrawObjectBase, int> dictionary_0, SqlCommand sqlCommand_0)
	{
		Func<DrawObjectBase, bool> func = null;
		Class96.Class99 @class = new Class96.Class99();
		string text = string.Empty;
		int num = -1;
		int num2 = -1;
		foreach (DrawObjectBase drawObjectBase in list_0)
		{
			RectangleTool rectangleTool = null;
			if (drawObjectBase.Layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
			{
				foreach (DrawObjectBase drawObjectBase2 in drawObjectBase.Layer.Objects)
				{
					if (drawObjectBase2 is RectangleTool)
					{
						rectangleTool = (RectangleTool)drawObjectBase2;
						break;
					}
				}
			}
			if (rectangleTool != null)
			{
				if (num2 == -1)
				{
					num2 = rectangleTool.IdBase;
				}
				else if (num2 != rectangleTool.IdBase)
				{
					throw new Exception(string.Format("Индификатор подстанции ({0}) которой принадлежит схема не соответствует устатновленному ранее ({1}). Объект:{2}", rectangleTool.IdBase, num2, drawObjectBase.IdBase));
				}
			}
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
				if (text != string.Empty)
				{
					text += ", ";
				}
				text += drawObjectBase.IdBase.ToString();
			}
		}
		if (text == string.Empty)
		{
			return;
		}
		sqlCommand_0.CommandText = string.Format("SELECT [id]\r\n                                                  ,[ObjId]\r\n                                                  ,[TypeSchema]                                                  \r\n                                                  ,[Tag]\r\n                                              FROM [tSchm_Xml]\r\n                                              WHERE [ObjId] in ({0}) and [TypeSchema] = {1} and ([Tag] = {2} or [Tag] is null)", text, num.ToString(), num2.ToString());
		@class.sqlDataReader_0 = sqlCommand_0.ExecuteReader();
		while (@class.sqlDataReader_0.Read())
		{
			if (func == null)
			{
				func = new Func<DrawObjectBase, bool>(@class.method_0);
			}
			DrawObjectBase key = list_0.First(func);
			dictionary_0.Add(key, (int)@class.sqlDataReader_0[0]);
		}
		@class.sqlDataReader_0.Close();
	}

	private static string smethod_12(RectangleTool rectangleTool_0)
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

	private static string smethod_13(ShinaTool shinaTool_0)
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

	private static string smethod_14(PointTool pointTool_0)
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

	private static string smethod_15(ObjectOnLine objectOnLine_0)
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

	private static string smethod_16(LineTool lineTool_0)
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

	private static string smethod_17(LabelTool labelTool_0)
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
			return string.Format("INSERT INTO [tSchm_Relation]\r\n                                                               ([SourceObj]\r\n                                                               ,[DestObj]\r\n                                                               ,[Edge])\r\n                                                         VALUES\r\n                                                               ({0}\r\n                                                               ,{1}\r\n                                                               ,{2})", couplingRelation_0.Vertex1.IdBase.ToString(), couplingRelation_0.Vertex2.IdBase.ToString(), couplingRelation_0.Line.IdBase.ToString());
		}
		return string.Format("UPDATE [tSchm_Relation]\r\n                                                           SET [SourceObj] = {1}\r\n                                                              ,[DestObj] = {2}\r\n                                                              ,[Edge] = {3}\r\n                                                         WHERE id = {0}", new object[]
		{
			couplingRelation_0.Id,
			couplingRelation_0.Vertex1.IdBase.ToString(),
			couplingRelation_0.Vertex2.IdBase.ToString(),
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
						list.AddRange(Class96.smethod_19(drawObjectBase));
					}
				}
				return list;
			}
		}
		foreach (DrawObjectBase drawObjectBase2 in drawObjectBase_0.ChildObjects)
		{
			list.Add(drawObjectBase2);
			list.AddRange(Class96.smethod_19(drawObjectBase2));
		}
		return list;
	}

	private static List<DrawObjectBase> smethod_20(LineTool lineTool_0)
	{
		List<DrawObjectBase> list = new List<DrawObjectBase>();
		foreach (CouplingRelation couplingRelation in lineTool_0.CouplingRelations)
		{
			list.Add(couplingRelation.Vertex1);
			list.Add(couplingRelation.Vertex2);
		}
		return list;
	}

	private const int int_0 = 1000;

	private const string string_0 = "SaveSchemaObj";

	[CompilerGenerated]
	private static SQLSettings sqlsettings_0;

	[CompilerGenerated]
	private sealed class Class97
	{
		public bool method_0(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool) && !this.list_0.Contains(drawObjectBase_0);
		}

		public bool method_1(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(ShinaTool) && !this.list_0.Contains(drawObjectBase_0);
		}

		public bool method_2(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(PointShinaTool) && !this.list_0.Contains(drawObjectBase_0);
		}

		public bool method_3(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0 is LineTool && !this.list_0.Contains(drawObjectBase_0);
		}

		public bool method_4(DrawObjectBase drawObjectBase_0)
		{
			return !this.list_0.Contains(drawObjectBase_0) && drawObjectBase_0.IdBase == 0;
		}

		public bool method_5(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0 is PointTool && !this.list_0.Contains(drawObjectBase_0);
		}

		public bool method_6(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0 is ObjectOnLine && !this.list_0.Contains(drawObjectBase_0);
		}

		public bool method_7(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0 is LabelTool && !this.list_0.Contains(drawObjectBase_0);
		}

		public List<DrawObjectBase> list_0;
	}

	[CompilerGenerated]
	private sealed class Class98
	{
		public bool method_0(DrawObjectBase drawObjectBase_0)
		{
			return !this.list_0.Contains(drawObjectBase_0) && drawObjectBase_0.IdBase > -1;
		}

		public List<DrawObjectBase> list_0;
	}

	[CompilerGenerated]
	private sealed class Class99
	{
		public bool method_0(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.IdBase == (int)this.sqlDataReader_0[1];
		}

		public SqlDataReader sqlDataReader_0;
	}
}
