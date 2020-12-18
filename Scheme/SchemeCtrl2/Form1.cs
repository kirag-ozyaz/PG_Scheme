using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using ControlsLbr;
using FormLbr;
using FormLbr.Classes;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Ercloud;

internal partial class Form1 : FormBase
{
	internal Form1()
	{
		
		this.dataTable_0 = new DataTable();
		this.dataTable_1 = new DataTable();
		this.dataTable_2 = new DataTable();
		this.dataTable_3 = new DataTable();
		
		this.method_10();
	}

	internal Form1(DrawObjectBase drawObjectBase_1)
	{
		
		this.dataTable_0 = new DataTable();
		this.dataTable_1 = new DataTable();
		this.dataTable_2 = new DataTable();
		this.dataTable_3 = new DataTable();
		
		this.method_10();
		this.drawObjectBase_0 = drawObjectBase_1;
		this.textBox_1.Text = drawObjectBase_1.Text;
		this.textBox_0.Text = drawObjectBase_1.IdBase.ToString();
		this.dateTimePicker_0.Value = DateTime.Now.Date;
		this.dateTimePicker_1.Value = DateTime.Now.Date.AddDays(1.0).AddSeconds(-1.0);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (this.drawObjectBase_0 != null)
		{
			DataTable dataTable = base.SelectSqlData("tSchm_Ercloud", true, " where idSchmObj = " + this.drawObjectBase_0.IdBase.ToString());
			if (dataTable.Rows.Count <= 0)
			{
				throw new Exception("Нет связи");
			}
			int int_ = Convert.ToInt32(dataTable.Rows[0]["idConnect"]);
			this.nullable_0 = new int?(Convert.ToInt32(dataTable.Rows[0]["idErcloudObj"]));
			this.method_7(int_);
		}
		this.method_0();
	}

	private void method_0()
	{
		this.class10_0 = new Class10();
		this.class10_0.Id = Convert.ToInt32(this.nullable_0);
		this.class10_0.IdParent = this.nullable_1;
		XmlDocument xmlDocument = this.method_5(this.ercloudConnect_0.User, "", this.nullable_0.ToString(), "0", "5", this.ercloudConnect_0.Password, null, null, null);
		string xml = this.jMtPuOdDiK(this.ercloudConnect_0, xmlDocument);
		xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(xml);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("document");
		if (xmlNode != null)
		{
			foreach (object obj in xmlNode.SelectNodes("PU"))
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				if (xmlNode2.Attributes["UID"] != null && this.nullable_0 == Convert.ToInt32(xmlNode2.Attributes["UID"].Value))
				{
					this.class10_0.Name = (this.textBox_2.Text = xmlNode2.InnerText);
					if (xmlNode2.Attributes["UID_OBJ"] != null)
					{
						this.nullable_1 = new int?(Convert.ToInt32(xmlNode2.Attributes["UID_OBJ"].Value));
						break;
					}
					break;
				}
			}
		}
		xmlDocument = this.method_5(this.ercloudConnect_0.User, "", this.nullable_0.ToString(), "0", "6", this.ercloudConnect_0.Password, new bool?(false), null, null);
		xml = this.jMtPuOdDiK(this.ercloudConnect_0, xmlDocument);
		xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(xml);
		xmlNode = xmlDocument.SelectSingleNode("document");
		if (xmlNode != null)
		{
			foreach (object obj2 in xmlNode.SelectNodes("PU"))
			{
				XmlNode xmlNode3 = (XmlNode)obj2;
				if (xmlNode3.Attributes["UID"] != null && this.nullable_0 == Convert.ToInt32(xmlNode3.Attributes["UID"].Value))
				{
					XmlNode xmlNode4 = xmlNode3.SelectSingleNode("RECORD");
					if (xmlNode4 != null)
					{
						XmlNode xmlNode5 = xmlNode4.SelectSingleNode("KOEF_TRANSFORM");
						if (xmlNode5 != null && !string.IsNullOrEmpty(xmlNode5.InnerText))
						{
							this.class10_0.method_1(Convert.ToInt32(xmlNode5.InnerText));
						}
					}
					break;
				}
			}
		}
		if (this.nullable_1 != null)
		{
			xmlDocument = this.method_5(this.ercloudConnect_0.User, this.nullable_1.ToString(), "", "0", "4", this.ercloudConnect_0.Password, null, null, null);
			xml = this.jMtPuOdDiK(this.ercloudConnect_0, xmlDocument);
			xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			xmlNode = xmlDocument.SelectSingleNode("document");
			if (xmlNode != null)
			{
				foreach (object obj3 in xmlNode.SelectNodes("OBJECT"))
				{
					XmlNode xmlNode6 = (XmlNode)obj3;
					if (xmlNode6.Attributes["UID"] != null && this.nullable_1 == Convert.ToInt32(xmlNode6.Attributes["UID"].Value))
					{
						this.textBox_3.Text = xmlNode6.InnerText;
						break;
					}
				}
			}
		}
	}

	private void method_1(List<int> list_0)
	{
		Dictionary<DataGridView, DataTable> dictionary = new Dictionary<DataGridView, DataTable>();
		dictionary.Add(this.dataGridView_0, this.dataTable_0);
		dictionary.Add(this.dataGridView_1, this.dataTable_1);
		dictionary.Add(this.dataGridView_2, this.dataTable_2);
		dictionary.Add(this.dataGridView_3, this.dataTable_3);
		foreach (DataGridView dataGridView in dictionary.Keys)
		{
			dataGridView.Rows.Clear();
			dataGridView.Columns.Clear();
			DataTable dataTable = dictionary[dataGridView];
			dataTable.Rows.Clear();
			dataTable.Columns.Clear();
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn.HeaderText = "Дата";
			dataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns.Add(dataGridViewTextBoxColumn);
			list_0.Sort();
			dataTable.Columns.Add(new DataColumn("Date", typeof(DateTime)));
			foreach (int num in list_0)
			{
				dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
				if (num == 0)
				{
					dataGridViewTextBoxColumn.HeaderText = "Σ";
					dataTable.Columns.Add(new DataColumn("Tariff_All", typeof(double)));
				}
				else
				{
					dataGridViewTextBoxColumn.HeaderText = "Тариф " + num.ToString();
					dataTable.Columns.Add(new DataColumn("Tariff_" + num.ToString(), typeof(double)));
				}
				dataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dataGridView.Columns.Add(dataGridViewTextBoxColumn);
			}
		}
	}

	private void method_2(Dictionary<DateTime, List<Class11>> dictionary_0, List<int> list_0)
	{
		List<DateTime> list = dictionary_0.Keys.ToList<DateTime>();
		list.Sort();
		foreach (DateTime dateTime in list)
		{
			object[] array = new object[list_0.Count<int>() + 1];
			object[] array2 = new object[list_0.Count<int>() + 1];
			object[] array3 = new object[list_0.Count<int>() + 1];
			object[] array4 = new object[list_0.Count<int>() + 1];
			array[0] = (array2[0] = (array3[0] = (array4[0] = dateTime)));
			List<Class11> source = dictionary_0[dateTime];
			int j;
			int i;
			for (i = 0; i < list_0.Count<int>(); i = j + 1)
			{
				IEnumerable<Class11> source2 = from obj in source
				where obj.method_0() == list_0[i]
				select obj;
				if (source2.Count<Class11>() > 0)
				{
					int num = 1;
					if (this.checkBox_0.Checked)
					{
						num = this.class10_0.method_0();
					}
					array[i + 1] = source2.First<Class11>().AP * (double)num;
					array2[i + 1] = source2.First<Class11>().AM * (double)num;
					array3[i + 1] = source2.First<Class11>().RP * (double)num;
					array4[i + 1] = source2.First<Class11>().RM * (double)num;
				}
				else
				{
					array[i + 1] = (array2[i + 1] = (array3[i + 1] = (array4[i + 1] = null)));
				}
				j = i;
			}
			this.dataGridView_0.Rows.Add(array);
			this.dataTable_0.Rows.Add(array);
			this.dataGridView_1.Rows.Add(array2);
			this.dataTable_1.Rows.Add(array2);
			this.dataGridView_2.Rows.Add(array3);
			this.dataTable_2.Rows.Add(array3);
			this.dataGridView_3.Rows.Add(array4);
			this.dataTable_3.Rows.Add(array4);
		}
	}

	private void method_3()
	{
		Dictionary<DataTable, Chart> dictionary = new Dictionary<DataTable, Chart>();
		dictionary.Add(this.dataTable_0, this.chart_0);
		dictionary.Add(this.dataTable_1, this.chart_1);
		dictionary.Add(this.dataTable_2, this.chart_2);
		dictionary.Add(this.dataTable_3, this.chart_3);
		foreach (DataTable dataTable in dictionary.Keys)
		{
			Chart chart = dictionary[dataTable];
			chart.Series.Clear();
			chart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
			for (int i = 1; i < dataTable.Columns.Count; i++)
			{
				string columnName = dataTable.Columns[i].ColumnName;
				chart.Series.Add(columnName);
				chart.Series[columnName].ChartType = SeriesChartType.Line;
				chart.Series[columnName].XValueType = ChartValueType.DateTime;
				chart.Series[columnName].YValueType = ChartValueType.Double;
			}
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				DateTime dateTime = Convert.ToDateTime(dataRow["Date"]);
				for (int j = 1; j < dataTable.Columns.Count; j++)
				{
					string text = dataTable.Columns[j].ColumnName;
					double num = Convert.ToDouble(dataRow[text]);
					text = text.Substring(3);
					chart.Series[j - 1].Points.AddXY(dateTime, new object[]
					{
						num
					});
				}
			}
		}
	}

	private void method_4()
	{
		this.chart_4.Series.Clear();
		this.chart_4.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
		for (int i = 1; i < this.dataTable_4.Columns.Count; i++)
		{
			string columnName = this.dataTable_4.Columns[i].ColumnName;
			this.chart_4.Series.Add(columnName);
			this.chart_4.Series[columnName].ChartType = SeriesChartType.Line;
			this.chart_4.Series[columnName].XValueType = ChartValueType.DateTime;
			this.chart_4.Series[columnName].YValueType = ChartValueType.Double;
		}
		foreach (object obj in this.dataTable_4.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			DateTime dateTime = Convert.ToDateTime(dataRow["DT"]);
			for (int j = 1; j < this.dataTable_4.Columns.Count; j++)
			{
				string columnName2 = this.dataTable_4.Columns[j].ColumnName;
				double num = Convert.ToDouble(dataRow[columnName2]);
				this.chart_4.Series[j - 1].Points.AddXY(dateTime, new object[]
				{
					num
				});
			}
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		XmlDocument xmlDocument = this.method_5(this.ercloudConnect_0.User, "", this.nullable_0.ToString(), "0", "7", this.ercloudConnect_0.Password, new bool?(true), new DateTime?(this.dateTimePicker_0.Value), new DateTime?(this.dateTimePicker_1.Value));
		string xml = this.jMtPuOdDiK(this.ercloudConnect_0, xmlDocument);
		xmlDocument.LoadXml(xml);
		Dictionary<DateTime, List<Class11>> dictionary = new Dictionary<DateTime, List<Class11>>();
		List<int> list = new List<int>();
		XmlNode xmlNode = xmlDocument.SelectSingleNode("document");
		if (xmlNode != null)
		{
			foreach (object obj in xmlNode.SelectNodes("PU"))
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				try
				{
					if (!(this.nullable_0 != Convert.ToInt32(xmlNode2.Attributes["UID"].Value)))
					{
						foreach (object obj2 in xmlNode2.SelectNodes("RECORD"))
						{
							XmlNode xmlNode3 = (XmlNode)obj2;
							DateTime key = Convert.ToDateTime(xmlNode3.Attributes["DT"].Value);
							XmlNode xmlNode4 = xmlNode3.SelectSingleNode("TARIF_ZONA");
							if (!list.Contains(Convert.ToInt32(xmlNode4.InnerText)))
							{
								list.Add(Convert.ToInt32(xmlNode4.InnerText));
							}
							if (xmlNode4 != null)
							{
								XmlNode xmlNode5 = xmlNode3.SelectSingleNode("AP");
								XmlNode xmlNode6 = xmlNode3.SelectSingleNode("AM");
								XmlNode xmlNode7 = xmlNode3.SelectSingleNode("RP");
								XmlNode xmlNode8 = xmlNode3.SelectSingleNode("RM");
								Class11 item = new Class11(Convert.ToInt32(xmlNode4.InnerText), Convert.ToDouble(string.IsNullOrEmpty(xmlNode5.InnerText) ? "0" : xmlNode5.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode6.InnerText) ? "0" : xmlNode6.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode7.InnerText) ? "0" : xmlNode7.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode8.InnerText) ? "0" : xmlNode8.InnerText, CultureInfo.GetCultureInfo("en-US")));
								if (dictionary.ContainsKey(key))
								{
									dictionary[key].Add(item);
								}
								else
								{
									dictionary.Add(key, new List<Class11>
									{
										item
									});
								}
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
		this.method_1(list);
		this.method_2(dictionary, list);
		this.method_3();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		XmlDocument xmlDocument = this.method_5(this.ercloudConnect_0.User, "", this.nullable_0.ToString(), "0", "2", this.ercloudConnect_0.Password, new bool?(true), new DateTime?(this.dateTimePicker_0.Value), new DateTime?(this.dateTimePicker_1.Value));
		string xml = this.jMtPuOdDiK(this.ercloudConnect_0, xmlDocument);
		xmlDocument.LoadXml(xml);
		Dictionary<DateTime, List<Class11>> dictionary = new Dictionary<DateTime, List<Class11>>();
		List<int> list = new List<int>();
		XmlNode xmlNode = xmlDocument.SelectSingleNode("document");
		if (xmlNode != null)
		{
			foreach (object obj in xmlNode.SelectNodes("PU"))
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				try
				{
					if (!(this.nullable_0 != Convert.ToInt32(xmlNode2.Attributes["UID"].Value)))
					{
						list.Add(0);
						foreach (object obj2 in xmlNode2.SelectNodes("RECORD"))
						{
							XmlNode xmlNode3 = (XmlNode)obj2;
							DateTime key = Convert.ToDateTime(xmlNode3.Attributes["DT"].Value);
							XmlNode xmlNode4 = xmlNode3.SelectSingleNode("Pplus");
							XmlNode xmlNode5 = xmlNode3.SelectSingleNode("Pminus");
							XmlNode xmlNode6 = xmlNode3.SelectSingleNode("Qplus");
							XmlNode xmlNode7 = xmlNode3.SelectSingleNode("Qminus");
							Class11 item = new Class11(0, Convert.ToDouble(string.IsNullOrEmpty(xmlNode4.InnerText) ? "0" : xmlNode4.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode5.InnerText) ? "0" : xmlNode5.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode6.InnerText) ? "0" : xmlNode6.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode7.InnerText) ? "0" : xmlNode7.InnerText, CultureInfo.GetCultureInfo("en-US")));
							if (dictionary.ContainsKey(key))
							{
								dictionary[key].Add(item);
							}
							else
							{
								dictionary.Add(key, new List<Class11>
								{
									item
								});
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
		this.method_1(list);
		this.method_2(dictionary, list);
		this.method_3();
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		this.dataTable_4.Clear();
		XmlDocument xmlDocument = this.method_5(this.ercloudConnect_0.User, "", this.nullable_0.ToString(), "0", "1", this.ercloudConnect_0.Password, new bool?(true), new DateTime?(this.dateTimePicker_0.Value), new DateTime?(this.dateTimePicker_1.Value));
		string xml = this.jMtPuOdDiK(this.ercloudConnect_0, xmlDocument);
		xmlDocument.LoadXml(xml);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("document");
		if (xmlNode != null)
		{
			foreach (object obj in xmlNode.SelectNodes("PU"))
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				try
				{
					if (!(this.nullable_0 != Convert.ToInt32(xmlNode2.Attributes["UID"].Value)))
					{
						foreach (object obj2 in xmlNode2.SelectNodes("RECORD"))
						{
							XmlNode xmlNode3 = (XmlNode)obj2;
							DataRow dataRow = this.dataTable_4.NewRow();
							dataRow["DT"] = Convert.ToDateTime(xmlNode3.Attributes["DT"].Value);
							XmlNode xmlNode4 = xmlNode3.SelectSingleNode("U1");
							dataRow["U1"] = Convert.ToDouble(string.IsNullOrEmpty(xmlNode4.InnerText) ? "0" : xmlNode4.InnerText, CultureInfo.GetCultureInfo("en-US"));
							XmlNode xmlNode5 = xmlNode3.SelectSingleNode("U2");
							dataRow["U2"] = Convert.ToDouble(string.IsNullOrEmpty(xmlNode5.InnerText) ? "0" : xmlNode5.InnerText, CultureInfo.GetCultureInfo("en-US"));
							XmlNode xmlNode6 = xmlNode3.SelectSingleNode("U3");
							dataRow["U3"] = Convert.ToDouble(string.IsNullOrEmpty(xmlNode6.InnerText) ? "0" : xmlNode6.InnerText, CultureInfo.GetCultureInfo("en-US"));
							XmlNode xmlNode7 = xmlNode3.SelectSingleNode("I1");
							dataRow["I1"] = Convert.ToDouble(string.IsNullOrEmpty(xmlNode7.InnerText) ? "0" : xmlNode7.InnerText, CultureInfo.GetCultureInfo("en-US"));
							XmlNode xmlNode8 = xmlNode3.SelectSingleNode("I2");
							dataRow["I2"] = Convert.ToDouble(string.IsNullOrEmpty(xmlNode8.InnerText) ? "0" : xmlNode8.InnerText, CultureInfo.GetCultureInfo("en-US"));
							XmlNode xmlNode9 = xmlNode3.SelectSingleNode("I3");
							dataRow["I3"] = Convert.ToDouble(string.IsNullOrEmpty(xmlNode9.InnerText) ? "0" : xmlNode9.InnerText, CultureInfo.GetCultureInfo("en-US"));
							this.dataTable_4.Rows.Add(dataRow);
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
		this.method_4();
	}

	private XmlDocument method_5(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, bool? nullable_2 = null, DateTime? nullable_3 = null, DateTime? nullable_4 = null)
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode xmlNode = xmlDocument.CreateElement("document");
		xmlDocument.AppendChild(xmlNode);
		XmlNode xmlNode2 = xmlDocument.CreateElement("idUser");
		xmlNode2.InnerText = string_0;
		xmlNode.AppendChild(xmlNode2);
		if (!string.IsNullOrEmpty(string_1))
		{
			xmlNode2 = xmlDocument.CreateElement("idObject");
			xmlNode2.InnerText = string_1;
			xmlNode.AppendChild(xmlNode2);
		}
		if (!string.IsNullOrEmpty(string_2))
		{
			xmlNode2 = xmlDocument.CreateElement("idDevice");
			xmlNode2.InnerText = string_2;
			xmlNode.AppendChild(xmlNode2);
		}
		xmlNode2 = xmlDocument.CreateElement("trUniq");
		xmlNode2.InnerText = string_3;
		xmlNode.AppendChild(xmlNode2);
		xmlNode2 = xmlDocument.CreateElement("typeQuery");
		xmlNode2.InnerText = string_4;
		xmlNode.AppendChild(xmlNode2);
		if (nullable_2 != null)
		{
			xmlNode2 = xmlDocument.CreateElement("typeRes");
			xmlNode2.InnerText = Convert.ToInt32(nullable_2).ToString();
			xmlNode.AppendChild(xmlNode2);
		}
		if (nullable_3 != null)
		{
			xmlNode2 = xmlDocument.CreateElement("data_beg");
			xmlNode2.InnerText = Convert.ToDateTime(nullable_3).ToString("dd.MM.yyyy HH:mm:ss");
			xmlNode.AppendChild(xmlNode2);
		}
		if (nullable_4 != null)
		{
			xmlNode2 = xmlDocument.CreateElement("data_end");
			xmlNode2.InnerText = Convert.ToDateTime(nullable_4).ToString("dd.MM.yyyy HH:mm:ss");
			xmlNode.AppendChild(xmlNode2);
		}
		string text = "";
		for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
		{
			if (!string.IsNullOrEmpty(xmlNode.ChildNodes[i].InnerText))
			{
				text += xmlNode.ChildNodes[i].InnerText;
			}
		}
		text = this.method_6(text + string_5);
		xmlNode2 = xmlDocument.CreateElement("magic_word");
		xmlNode2.InnerText = text.ToUpper();
		xmlNode.AppendChild(xmlNode2);
		return xmlDocument;
	}

	private string method_6(string string_0)
	{
		byte[] array = MD5.Create().ComputeHash(Encoding.Default.GetBytes(string_0));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	private string jMtPuOdDiK(ErcloudConnect ercloudConnect_1, XmlDocument xmlDocument_0)
	{
		string result;
		try
		{
			byte[] array = new byte[1024];
			IPAddress ipaddress = Dns.GetHostEntry("localhost").AddressList[0];
			IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(ercloudConnect_1.AddressServer), ercloudConnect_1.Port);
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket.Connect(remoteEP);
			byte[] bytes = Encoding.GetEncoding("windows-1251").GetBytes(xmlDocument_0.InnerXml);
			socket.Send(bytes);
			string text = "";
			int num;
			do
			{
				num = socket.Receive(array);
				text += Encoding.GetEncoding("windows-1251").GetString(array, 0, num);
			}
			while (text.IndexOf("</documnet>") < 0 && num > 0);
			result = text;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source);
			result = "";
		}
		return result;
	}

	private void method_7(int int_0)
	{
		DataTable dataTable = base.SelectSqlData("tSettings", true, " where Module = 'Ercloud'");
		if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Settings"] != DBNull.Value)
		{
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.LoadXml(dataTable.Rows[0]["Settings"].ToString());
				this.method_8(xmlDocument, int_0);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}
	}

	private void method_8(XmlDocument xmlDocument_0, int int_0)
	{
		try
		{
			foreach (object obj in xmlDocument_0.SelectSingleNode("Connections").SelectNodes("ErcloudConnect"))
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					if (Convert.ToInt32(xmlNode.Attributes["Id"].Value) == int_0)
					{
						this.ercloudConnect_0 = new ErcloudConnect(int_0, xmlNode.Attributes["Name"].Value, xmlNode.Attributes["Address"].Value, Convert.ToInt32(xmlNode.Attributes["Port"].Value), xmlNode.Attributes["User"].Value, Crypt.Decrypt(xmlNode.Attributes["Password"].Value, xmlNode.Attributes["Name"].Value));
						break;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
				}
			}
		}
		catch (Exception ex2)
		{
			MessageBox.Show(ex2.Message, ex2.Source);
		}
	}

	private void method_9(object sender, ToolTipEventArgs e)
	{
		if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
		{
			int pointIndex = e.HitTestResult.PointIndex;
			DataPoint dataPoint = e.HitTestResult.Series.Points[pointIndex];
			e.Text = string.Format("{0:F1}, {1:F1}", DateTime.FromOADate(dataPoint.XValue).ToString(), dataPoint.YValues[0]);
		}
	}

	private void method_10()
	{
		ChartArea chartArea = new ChartArea();
		Legend legend = new Legend();
		Legend legend2 = new Legend();
		ChartArea chartArea2 = new ChartArea();
		Legend legend3 = new Legend();
		Legend legend4 = new Legend();
		ChartArea chartArea3 = new ChartArea();
		Legend legend5 = new Legend();
		Legend legend6 = new Legend();
		ChartArea chartArea4 = new ChartArea();
		Legend legend7 = new Legend();
		Legend legend8 = new Legend();
		ChartArea chartArea5 = new ChartArea();
		Legend legend9 = new Legend();
		Legend legend10 = new Legend();
		this.textBox_0 = new TextBox();
		this.label_0 = new Label();
		this.textBox_1 = new TextBox();
		this.label_1 = new Label();
		this.button_0 = new Button();
		this.textBox_2 = new TextBox();
		this.textBox_3 = new TextBox();
		this.label_2 = new Label();
		this.label_3 = new Label();
		this.dateTimePicker_0 = new DateTimePicker();
		this.dateTimePicker_1 = new DateTimePicker();
		this.dataGridView_0 = new DataGridView();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.label_4 = new Label();
		this.label_5 = new Label();
		this.checkBox_0 = new CheckBox();
		this.tabControl_0 = new TabControl();
		this.tabPage_11 = new TabPage();
		this.tabControlVertical_4 = new TabControlVertical();
		this.tabPage_12 = new TabPage();
		this.dataGridView_4 = new DataGridView();
		this.AaXwEasGyJ = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
		this.dataSet_0 = new DataSet();
		this.dataTable_4 = new DataTable();
		this.dataColumn_0 = new DataColumn();
		this.dataColumn_1 = new DataColumn();
		this.dataColumn_2 = new DataColumn();
		this.dataColumn_3 = new DataColumn();
		this.dataColumn_4 = new DataColumn();
		this.dataColumn_5 = new DataColumn();
		this.dataColumn_6 = new DataColumn();
		this.tabPage_13 = new TabPage();
		this.chart_4 = new Chart();
		this.tabPage_0 = new TabPage();
		this.tabControlVertical_0 = new TabControlVertical();
		this.XmIwfYoMg6 = new TabPage();
		this.tabPage_4 = new TabPage();
		this.chart_0 = new Chart();
		this.tabPage_1 = new TabPage();
		this.tabControlVertical_1 = new TabControlVertical();
		this.tabPage_5 = new TabPage();
		this.dataGridView_1 = new DataGridView();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.tabPage_6 = new TabPage();
		this.chart_1 = new Chart();
		this.tabPage_2 = new TabPage();
		this.tabControlVertical_2 = new TabControlVertical();
		this.tabPage_7 = new TabPage();
		this.dataGridView_2 = new DataGridView();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.tabPage_8 = new TabPage();
		this.chart_2 = new Chart();
		this.tabPage_3 = new TabPage();
		this.tabControlVertical_3 = new TabControlVertical();
		this.tabPage_9 = new TabPage();
		this.dataGridView_3 = new DataGridView();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		this.tabPage_10 = new TabPage();
		this.chart_3 = new Chart();
		this.button_1 = new Button();
		this.button_2 = new Button();
		((ISupportInitialize)this.dataGridView_0).BeginInit();
		this.tabControl_0.SuspendLayout();
		this.tabPage_11.SuspendLayout();
		this.tabControlVertical_4.SuspendLayout();
		this.tabPage_12.SuspendLayout();
		((ISupportInitialize)this.dataGridView_4).BeginInit();
		((ISupportInitialize)this.dataSet_0).BeginInit();
		((ISupportInitialize)this.dataTable_4).BeginInit();
		this.tabPage_13.SuspendLayout();
		((ISupportInitialize)this.chart_4).BeginInit();
		this.tabPage_0.SuspendLayout();
		this.tabControlVertical_0.SuspendLayout();
		this.XmIwfYoMg6.SuspendLayout();
		this.tabPage_4.SuspendLayout();
		((ISupportInitialize)this.chart_0).BeginInit();
		this.tabPage_1.SuspendLayout();
		this.tabControlVertical_1.SuspendLayout();
		this.tabPage_5.SuspendLayout();
		((ISupportInitialize)this.dataGridView_1).BeginInit();
		this.tabPage_6.SuspendLayout();
		((ISupportInitialize)this.chart_1).BeginInit();
		this.tabPage_2.SuspendLayout();
		this.tabControlVertical_2.SuspendLayout();
		this.tabPage_7.SuspendLayout();
		((ISupportInitialize)this.dataGridView_2).BeginInit();
		this.tabPage_8.SuspendLayout();
		((ISupportInitialize)this.chart_2).BeginInit();
		this.tabPage_3.SuspendLayout();
		this.tabControlVertical_3.SuspendLayout();
		this.tabPage_9.SuspendLayout();
		((ISupportInitialize)this.dataGridView_3).BeginInit();
		this.tabPage_10.SuspendLayout();
		((ISupportInitialize)this.chart_3).BeginInit();
		base.SuspendLayout();
		this.textBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.textBox_0.Location = new Point(778, 25);
		this.textBox_0.Name = "txtIdSchmObj";
		this.textBox_0.ReadOnly = true;
		this.textBox_0.Size = new Size(84, 20);
		this.textBox_0.TabIndex = 8;
		this.label_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(775, 9);
		this.label_0.Name = "label2";
		this.label_0.Size = new Size(61, 13);
		this.label_0.TabIndex = 7;
		this.label_0.Text = "Id объекта";
		this.textBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.textBox_1.Location = new Point(12, 25);
		this.textBox_1.Name = "txtNameSchmObj";
		this.textBox_1.ReadOnly = true;
		this.textBox_1.Size = new Size(760, 20);
		this.textBox_1.TabIndex = 6;
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(12, 9);
		this.label_1.Name = "label1";
		this.label_1.Size = new Size(74, 13);
		this.label_1.TabIndex = 5;
		this.label_1.Text = "Имя объекта";
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.button_0.Location = new Point(15, 410);
		this.button_0.Name = "button1";
		this.button_0.Size = new Size(195, 23);
		this.button_0.TabIndex = 9;
		this.button_0.Text = "Значение энергии по тарифам";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_0_Click;
		this.textBox_2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.textBox_2.BackColor = SystemColors.Window;
		this.textBox_2.Location = new Point(93, 77);
		this.textBox_2.Name = "txtNameErcloudDevice";
		this.textBox_2.ReadOnly = true;
		this.textBox_2.Size = new Size(769, 20);
		this.textBox_2.TabIndex = 11;
		this.textBox_3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.textBox_3.BackColor = SystemColors.Window;
		this.textBox_3.Location = new Point(93, 51);
		this.textBox_3.Name = "txtNameErcloudGroup";
		this.textBox_3.ReadOnly = true;
		this.textBox_3.Size = new Size(769, 20);
		this.textBox_3.TabIndex = 12;
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(12, 54);
		this.label_2.Name = "label3";
		this.label_2.Size = new Size(45, 13);
		this.label_2.TabIndex = 13;
		this.label_2.Text = "Объект";
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(12, 80);
		this.label_3.Name = "label4";
		this.label_3.Size = new Size(75, 13);
		this.label_3.TabIndex = 14;
		this.label_3.Text = "Прибор учета";
		this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm:ss";
		this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
		this.dateTimePicker_0.Location = new Point(93, 103);
		this.dateTimePicker_0.Name = "dtpBegin";
		this.dateTimePicker_0.Size = new Size(200, 20);
		this.dateTimePicker_0.TabIndex = 15;
		this.dateTimePicker_1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
		this.dateTimePicker_1.Format = DateTimePickerFormat.Custom;
		this.dateTimePicker_1.Location = new Point(394, 103);
		this.dateTimePicker_1.Name = "dtpEnd";
		this.dateTimePicker_1.Size = new Size(200, 20);
		this.dateTimePicker_1.TabIndex = 16;
		this.dataGridView_0.AllowUserToAddRows = false;
		this.dataGridView_0.AllowUserToDeleteRows = false;
		this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_0
		});
		this.dataGridView_0.Dock = DockStyle.Fill;
		this.dataGridView_0.Location = new Point(3, 3);
		this.dataGridView_0.Name = "dgvAP";
		this.dataGridView_0.ReadOnly = true;
		this.dataGridView_0.Size = new Size(828, 233);
		this.dataGridView_0.TabIndex = 17;
		this.dataGridViewTextBoxColumn_0.HeaderText = "Column1";
		this.dataGridViewTextBoxColumn_0.Name = "Column1";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.label_4.AutoSize = true;
		this.label_4.Location = new Point(12, 109);
		this.label_4.Name = "label5";
		this.label_4.Size = new Size(71, 13);
		this.label_4.TabIndex = 18;
		this.label_4.Text = "Дата начала";
		this.label_5.AutoSize = true;
		this.label_5.Location = new Point(299, 109);
		this.label_5.Name = "label6";
		this.label_5.Size = new Size(89, 13);
		this.label_5.TabIndex = 19;
		this.label_5.Text = "Дата окончания";
		this.checkBox_0.AutoSize = true;
		this.checkBox_0.Checked = true;
		this.checkBox_0.CheckState = CheckState.Checked;
		this.checkBox_0.Location = new Point(609, 106);
		this.checkBox_0.Name = "checkBoxKoefTr";
		this.checkBox_0.Size = new Size(187, 17);
		this.checkBox_0.TabIndex = 20;
		this.checkBox_0.Text = "Учитывать коэффициент из БД";
		this.checkBox_0.UseVisualStyleBackColor = true;
		this.tabControl_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.tabControl_0.Controls.Add(this.tabPage_11);
		this.tabControl_0.Controls.Add(this.tabPage_0);
		this.tabControl_0.Controls.Add(this.tabPage_1);
		this.tabControl_0.Controls.Add(this.tabPage_2);
		this.tabControl_0.Controls.Add(this.tabPage_3);
		this.tabControl_0.Location = new Point(0, 125);
		this.tabControl_0.Name = "tabControlEnergy";
		this.tabControl_0.SelectedIndex = 0;
		this.tabControl_0.Size = new Size(875, 279);
		this.tabControl_0.TabIndex = 21;
		this.tabPage_11.Controls.Add(this.tabControlVertical_4);
		this.tabPage_11.Location = new Point(4, 22);
		this.tabPage_11.Name = "tabPageCurrentValue";
		this.tabPage_11.Size = new Size(867, 253);
		this.tabPage_11.TabIndex = 4;
		this.tabPage_11.Text = "Текущие мгновенные значения";
		this.tabPage_11.UseVisualStyleBackColor = true;
		this.tabControlVertical_4.Alignment = TabAlignment.Right;
		this.tabControlVertical_4.Controls.Add(this.tabPage_12);
		this.tabControlVertical_4.Controls.Add(this.tabPage_13);
		this.tabControlVertical_4.Dock = DockStyle.Fill;
		this.tabControlVertical_4.Location = new Point(0, 0);
		this.tabControlVertical_4.Multiline = true;
		this.tabControlVertical_4.Name = "tabControlCurrentValues";
		this.tabControlVertical_4.SelectedIndex = 0;
		this.tabControlVertical_4.Size = new Size(867, 253);
		this.tabControlVertical_4.TabIndex = 20;
		this.tabPage_12.Controls.Add(this.dataGridView_4);
		this.tabPage_12.Location = new Point(4, 4);
		this.tabPage_12.Name = "tabPage7";
		this.tabPage_12.Padding = new Padding(3);
		this.tabPage_12.Size = new Size(840, 245);
		this.tabPage_12.TabIndex = 0;
		this.tabPage_12.Text = "Таблица";
		this.tabPage_12.UseVisualStyleBackColor = true;
		this.dataGridView_4.AllowUserToAddRows = false;
		this.dataGridView_4.AllowUserToDeleteRows = false;
		this.dataGridView_4.AutoGenerateColumns = false;
		this.dataGridView_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_4.Columns.AddRange(new DataGridViewColumn[]
		{
			this.AaXwEasGyJ,
			this.dataGridViewTextBoxColumn_4,
			this.dataGridViewTextBoxColumn_5,
			this.dataGridViewTextBoxColumn_6,
			this.dataGridViewTextBoxColumn_7,
			this.dataGridViewTextBoxColumn_8,
			this.dataGridViewTextBoxColumn_9
		});
		this.dataGridView_4.DataMember = "dtCurrentValue";
		this.dataGridView_4.DataSource = this.dataSet_0;
		this.dataGridView_4.Dock = DockStyle.Fill;
		this.dataGridView_4.Location = new Point(3, 3);
		this.dataGridView_4.Name = "dataGridView1";
		this.dataGridView_4.ReadOnly = true;
		this.dataGridView_4.Size = new Size(834, 239);
		this.dataGridView_4.TabIndex = 17;
		this.AaXwEasGyJ.DataPropertyName = "DT";
		this.AaXwEasGyJ.HeaderText = "Дата";
		this.AaXwEasGyJ.Name = "dTDataGridViewTextBoxColumn";
		this.AaXwEasGyJ.ReadOnly = true;
		this.AaXwEasGyJ.Width = 80;
		this.dataGridViewTextBoxColumn_4.DataPropertyName = "U1";
		this.dataGridViewTextBoxColumn_4.HeaderText = "Фазное напряжение по фазе 1";
		this.dataGridViewTextBoxColumn_4.Name = "u1DataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_4.ReadOnly = true;
		this.dataGridViewTextBoxColumn_5.DataPropertyName = "U2";
		this.dataGridViewTextBoxColumn_5.HeaderText = "Фазное напряжение по фазе 2";
		this.dataGridViewTextBoxColumn_5.Name = "u2DataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_5.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.DataPropertyName = "U3";
		this.dataGridViewTextBoxColumn_6.HeaderText = "Фазное напряжение по фазе 3";
		this.dataGridViewTextBoxColumn_6.Name = "u3DataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewTextBoxColumn_7.DataPropertyName = "I1";
		this.dataGridViewTextBoxColumn_7.HeaderText = "Сила тока по фазе 1";
		this.dataGridViewTextBoxColumn_7.Name = "i1DataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewTextBoxColumn_8.DataPropertyName = "I2";
		this.dataGridViewTextBoxColumn_8.HeaderText = "Сила тока по фазе 2";
		this.dataGridViewTextBoxColumn_8.Name = "i2DataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_8.ReadOnly = true;
		this.dataGridViewTextBoxColumn_9.DataPropertyName = "I3";
		this.dataGridViewTextBoxColumn_9.HeaderText = "Сила тока по фазе 3";
		this.dataGridViewTextBoxColumn_9.Name = "i3DataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_9.ReadOnly = true;
		this.dataSet_0.DataSetName = "NewDataSet";
		this.dataSet_0.Tables.AddRange(new DataTable[]
		{
			this.dataTable_4
		});
		this.dataTable_4.Columns.AddRange(new DataColumn[]
		{
			this.dataColumn_0,
			this.dataColumn_1,
			this.dataColumn_2,
			this.dataColumn_3,
			this.dataColumn_4,
			this.dataColumn_5,
			this.dataColumn_6
		});
		this.dataTable_4.TableName = "dtCurrentValue";
		this.dataColumn_0.ColumnName = "DT";
		this.dataColumn_0.DataType = typeof(DateTime);
		this.dataColumn_1.ColumnName = "U1";
		this.dataColumn_1.DataType = typeof(double);
		this.dataColumn_2.ColumnName = "U2";
		this.dataColumn_2.DataType = typeof(double);
		this.dataColumn_3.ColumnName = "U3";
		this.dataColumn_4.ColumnName = "I1";
		this.dataColumn_4.DataType = typeof(double);
		this.dataColumn_5.ColumnName = "I2";
		this.dataColumn_5.DataType = typeof(double);
		this.dataColumn_6.ColumnName = "I3";
		this.dataColumn_6.DataType = typeof(double);
		this.tabPage_13.Controls.Add(this.chart_4);
		this.tabPage_13.Location = new Point(4, 4);
		this.tabPage_13.Name = "tabPage8";
		this.tabPage_13.Padding = new Padding(3);
		this.tabPage_13.Size = new Size(840, 245);
		this.tabPage_13.TabIndex = 1;
		this.tabPage_13.Text = "График";
		this.tabPage_13.UseVisualStyleBackColor = true;
		chartArea.Name = "ChartArea1";
		this.chart_4.ChartAreas.Add(chartArea);
		this.chart_4.Dock = DockStyle.Fill;
		legend.Name = "Legend1";
		legend2.Name = "Legend2";
		this.chart_4.Legends.Add(legend);
		this.chart_4.Legends.Add(legend2);
		this.chart_4.Location = new Point(3, 3);
		this.chart_4.Name = "chartCurrentValue";
		this.chart_4.Size = new Size(834, 239);
		this.chart_4.TabIndex = 18;
		this.chart_4.Text = "chart1";
		this.tabPage_0.Controls.Add(this.tabControlVertical_0);
		this.tabPage_0.Location = new Point(4, 22);
		this.tabPage_0.Name = "tabPageAP";
		this.tabPage_0.Padding = new Padding(3);
		this.tabPage_0.Size = new Size(867, 253);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "Прямая активная энергия";
		this.tabPage_0.UseVisualStyleBackColor = true;
		this.tabControlVertical_0.Alignment = TabAlignment.Right;
		this.tabControlVertical_0.Controls.Add(this.XmIwfYoMg6);
		this.tabControlVertical_0.Controls.Add(this.tabPage_4);
		this.tabControlVertical_0.Dock = DockStyle.Fill;
		this.tabControlVertical_0.Location = new Point(3, 3);
		this.tabControlVertical_0.Multiline = true;
		this.tabControlVertical_0.Name = "tabControlAP";
		this.tabControlVertical_0.SelectedIndex = 0;
		this.tabControlVertical_0.Size = new Size(861, 247);
		this.tabControlVertical_0.TabIndex = 19;
		this.XmIwfYoMg6.Controls.Add(this.dataGridView_0);
		this.XmIwfYoMg6.Location = new Point(4, 4);
		this.XmIwfYoMg6.Name = "tabPageDgvAP";
		this.XmIwfYoMg6.Padding = new Padding(3);
		this.XmIwfYoMg6.Size = new Size(834, 239);
		this.XmIwfYoMg6.TabIndex = 0;
		this.XmIwfYoMg6.Text = "Таблица";
		this.XmIwfYoMg6.UseVisualStyleBackColor = true;
		this.tabPage_4.Controls.Add(this.chart_0);
		this.tabPage_4.Location = new Point(4, 4);
		this.tabPage_4.Name = "tabPageChartAP";
		this.tabPage_4.Padding = new Padding(3);
		this.tabPage_4.Size = new Size(834, 239);
		this.tabPage_4.TabIndex = 1;
		this.tabPage_4.Text = "График";
		this.tabPage_4.UseVisualStyleBackColor = true;
		chartArea2.Name = "ChartArea1";
		this.chart_0.ChartAreas.Add(chartArea2);
		this.chart_0.Dock = DockStyle.Fill;
		legend3.Name = "Legend1";
		legend4.Name = "Legend2";
		this.chart_0.Legends.Add(legend3);
		this.chart_0.Legends.Add(legend4);
		this.chart_0.Location = new Point(3, 3);
		this.chart_0.Name = "chartAP";
		this.chart_0.Size = new Size(828, 233);
		this.chart_0.TabIndex = 18;
		this.chart_0.Text = "chart1";
		this.chart_0.GetToolTipText += this.method_9;
		this.tabPage_1.Controls.Add(this.tabControlVertical_1);
		this.tabPage_1.Location = new Point(4, 22);
		this.tabPage_1.Name = "tabPageAM";
		this.tabPage_1.Padding = new Padding(3);
		this.tabPage_1.Size = new Size(867, 253);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "Обратная активная энергия";
		this.tabPage_1.UseVisualStyleBackColor = true;
		this.tabControlVertical_1.Alignment = TabAlignment.Right;
		this.tabControlVertical_1.Controls.Add(this.tabPage_5);
		this.tabControlVertical_1.Controls.Add(this.tabPage_6);
		this.tabControlVertical_1.Dock = DockStyle.Fill;
		this.tabControlVertical_1.Location = new Point(3, 3);
		this.tabControlVertical_1.Multiline = true;
		this.tabControlVertical_1.Name = "tabControlAM";
		this.tabControlVertical_1.SelectedIndex = 0;
		this.tabControlVertical_1.Size = new Size(861, 247);
		this.tabControlVertical_1.TabIndex = 20;
		this.tabPage_5.Controls.Add(this.dataGridView_1);
		this.tabPage_5.Location = new Point(4, 4);
		this.tabPage_5.Name = "tabPage1";
		this.tabPage_5.Padding = new Padding(3);
		this.tabPage_5.Size = new Size(834, 239);
		this.tabPage_5.TabIndex = 0;
		this.tabPage_5.Text = "Таблица";
		this.tabPage_5.UseVisualStyleBackColor = true;
		this.dataGridView_1.AllowUserToAddRows = false;
		this.dataGridView_1.AllowUserToDeleteRows = false;
		this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_1
		});
		this.dataGridView_1.Dock = DockStyle.Fill;
		this.dataGridView_1.Location = new Point(3, 3);
		this.dataGridView_1.Name = "dgvAM";
		this.dataGridView_1.ReadOnly = true;
		this.dataGridView_1.Size = new Size(828, 233);
		this.dataGridView_1.TabIndex = 17;
		this.dataGridViewTextBoxColumn_1.HeaderText = "Column1";
		this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_1.ReadOnly = true;
		this.tabPage_6.Controls.Add(this.chart_1);
		this.tabPage_6.Location = new Point(4, 4);
		this.tabPage_6.Name = "tabPage2";
		this.tabPage_6.Padding = new Padding(3);
		this.tabPage_6.Size = new Size(834, 239);
		this.tabPage_6.TabIndex = 1;
		this.tabPage_6.Text = "График";
		this.tabPage_6.UseVisualStyleBackColor = true;
		chartArea3.Name = "ChartArea1";
		this.chart_1.ChartAreas.Add(chartArea3);
		this.chart_1.Dock = DockStyle.Fill;
		legend5.Name = "Legend1";
		legend6.Name = "Legend2";
		this.chart_1.Legends.Add(legend5);
		this.chart_1.Legends.Add(legend6);
		this.chart_1.Location = new Point(3, 3);
		this.chart_1.Name = "chartAM";
		this.chart_1.Size = new Size(828, 233);
		this.chart_1.TabIndex = 18;
		this.chart_1.Text = "chart1";
		this.tabPage_2.Controls.Add(this.tabControlVertical_2);
		this.tabPage_2.Location = new Point(4, 22);
		this.tabPage_2.Name = "tabPageRP";
		this.tabPage_2.Size = new Size(867, 253);
		this.tabPage_2.TabIndex = 2;
		this.tabPage_2.Text = "Прямая реактивная энергия";
		this.tabPage_2.UseVisualStyleBackColor = true;
		this.tabControlVertical_2.Alignment = TabAlignment.Right;
		this.tabControlVertical_2.Controls.Add(this.tabPage_7);
		this.tabControlVertical_2.Controls.Add(this.tabPage_8);
		this.tabControlVertical_2.Dock = DockStyle.Fill;
		this.tabControlVertical_2.Location = new Point(0, 0);
		this.tabControlVertical_2.Multiline = true;
		this.tabControlVertical_2.Name = "tabControlVertical1";
		this.tabControlVertical_2.SelectedIndex = 0;
		this.tabControlVertical_2.Size = new Size(867, 253);
		this.tabControlVertical_2.TabIndex = 21;
		this.tabPage_7.Controls.Add(this.dataGridView_2);
		this.tabPage_7.Location = new Point(4, 4);
		this.tabPage_7.Name = "tabPage3";
		this.tabPage_7.Padding = new Padding(3);
		this.tabPage_7.Size = new Size(840, 245);
		this.tabPage_7.TabIndex = 0;
		this.tabPage_7.Text = "Таблица";
		this.tabPage_7.UseVisualStyleBackColor = true;
		this.dataGridView_2.AllowUserToAddRows = false;
		this.dataGridView_2.AllowUserToDeleteRows = false;
		this.dataGridView_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_2.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_2
		});
		this.dataGridView_2.Dock = DockStyle.Fill;
		this.dataGridView_2.Location = new Point(3, 3);
		this.dataGridView_2.Name = "dgvRP";
		this.dataGridView_2.ReadOnly = true;
		this.dataGridView_2.Size = new Size(834, 239);
		this.dataGridView_2.TabIndex = 17;
		this.dataGridViewTextBoxColumn_2.HeaderText = "Column1";
		this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn2";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.tabPage_8.Controls.Add(this.chart_2);
		this.tabPage_8.Location = new Point(4, 4);
		this.tabPage_8.Name = "tabPage4";
		this.tabPage_8.Padding = new Padding(3);
		this.tabPage_8.Size = new Size(840, 245);
		this.tabPage_8.TabIndex = 1;
		this.tabPage_8.Text = "График";
		this.tabPage_8.UseVisualStyleBackColor = true;
		chartArea4.Name = "ChartArea1";
		this.chart_2.ChartAreas.Add(chartArea4);
		this.chart_2.Dock = DockStyle.Fill;
		legend7.Name = "Legend1";
		legend8.Name = "Legend2";
		this.chart_2.Legends.Add(legend7);
		this.chart_2.Legends.Add(legend8);
		this.chart_2.Location = new Point(3, 3);
		this.chart_2.Name = "chartRP";
		this.chart_2.Size = new Size(834, 239);
		this.chart_2.TabIndex = 18;
		this.chart_2.Text = "chart1";
		this.tabPage_3.Controls.Add(this.tabControlVertical_3);
		this.tabPage_3.Location = new Point(4, 22);
		this.tabPage_3.Name = "tabPageRM";
		this.tabPage_3.Size = new Size(867, 253);
		this.tabPage_3.TabIndex = 3;
		this.tabPage_3.Text = "Обратная реактивная энергия";
		this.tabPage_3.UseVisualStyleBackColor = true;
		this.tabControlVertical_3.Alignment = TabAlignment.Right;
		this.tabControlVertical_3.Controls.Add(this.tabPage_9);
		this.tabControlVertical_3.Controls.Add(this.tabPage_10);
		this.tabControlVertical_3.Dock = DockStyle.Fill;
		this.tabControlVertical_3.Location = new Point(0, 0);
		this.tabControlVertical_3.Multiline = true;
		this.tabControlVertical_3.Name = "tabControlVertical2";
		this.tabControlVertical_3.SelectedIndex = 0;
		this.tabControlVertical_3.Size = new Size(867, 253);
		this.tabControlVertical_3.TabIndex = 21;
		this.tabPage_9.Controls.Add(this.dataGridView_3);
		this.tabPage_9.Location = new Point(4, 4);
		this.tabPage_9.Name = "tabPage5";
		this.tabPage_9.Padding = new Padding(3);
		this.tabPage_9.Size = new Size(840, 245);
		this.tabPage_9.TabIndex = 0;
		this.tabPage_9.Text = "Таблица";
		this.tabPage_9.UseVisualStyleBackColor = true;
		this.dataGridView_3.AllowUserToAddRows = false;
		this.dataGridView_3.AllowUserToDeleteRows = false;
		this.dataGridView_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_3.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_3
		});
		this.dataGridView_3.Dock = DockStyle.Fill;
		this.dataGridView_3.Location = new Point(3, 3);
		this.dataGridView_3.Name = "dgvRM";
		this.dataGridView_3.ReadOnly = true;
		this.dataGridView_3.Size = new Size(834, 239);
		this.dataGridView_3.TabIndex = 17;
		this.dataGridViewTextBoxColumn_3.HeaderText = "Column1";
		this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn3";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		this.tabPage_10.Controls.Add(this.chart_3);
		this.tabPage_10.Location = new Point(4, 4);
		this.tabPage_10.Name = "tabPage6";
		this.tabPage_10.Padding = new Padding(3);
		this.tabPage_10.Size = new Size(840, 245);
		this.tabPage_10.TabIndex = 1;
		this.tabPage_10.Text = "График";
		this.tabPage_10.UseVisualStyleBackColor = true;
		chartArea5.Name = "ChartArea1";
		this.chart_3.ChartAreas.Add(chartArea5);
		this.chart_3.Dock = DockStyle.Fill;
		legend9.Name = "Legend1";
		legend10.Name = "Legend2";
		this.chart_3.Legends.Add(legend9);
		this.chart_3.Legends.Add(legend10);
		this.chart_3.Location = new Point(3, 3);
		this.chart_3.Name = "chartRM";
		this.chart_3.Size = new Size(834, 239);
		this.chart_3.TabIndex = 18;
		this.chart_3.Text = "chart1";
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.button_1.Location = new Point(216, 410);
		this.button_1.Name = "button2";
		this.button_1.Size = new Size(195, 23);
		this.button_1.TabIndex = 22;
		this.button_1.Text = "Массив профиля мощности";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.button_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.button_2.Location = new Point(428, 410);
		this.button_2.Name = "buttonCurrentInstantValues";
		this.button_2.Size = new Size(216, 23);
		this.button_2.TabIndex = 23;
		this.button_2.Text = "Текущие мгновенные значения";
		this.button_2.UseVisualStyleBackColor = true;
		this.button_2.Click += this.button_2_Click;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(874, 445);
		base.Controls.Add(this.button_2);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.tabControl_0);
		base.Controls.Add(this.checkBox_0);
		base.Controls.Add(this.label_5);
		base.Controls.Add(this.label_4);
		base.Controls.Add(this.dateTimePicker_1);
		base.Controls.Add(this.dateTimePicker_0);
		base.Controls.Add(this.label_3);
		base.Controls.Add(this.label_2);
		base.Controls.Add(this.textBox_3);
		base.Controls.Add(this.textBox_2);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.textBox_0);
		base.Controls.Add(this.label_0);
		base.Controls.Add(this.textBox_1);
		base.Controls.Add(this.label_1);
		base.Name = "FormSwitchShowDataErcloud";
		this.Text = "FormSwitchShowDataErcloud";
		base.Load += this.Form1_Load;
		((ISupportInitialize)this.dataGridView_0).EndInit();
		this.tabControl_0.ResumeLayout(false);
		this.tabPage_11.ResumeLayout(false);
		this.tabControlVertical_4.ResumeLayout(false);
		this.tabPage_12.ResumeLayout(false);
		((ISupportInitialize)this.dataGridView_4).EndInit();
		((ISupportInitialize)this.dataSet_0).EndInit();
		((ISupportInitialize)this.dataTable_4).EndInit();
		this.tabPage_13.ResumeLayout(false);
		((ISupportInitialize)this.chart_4).EndInit();
		this.tabPage_0.ResumeLayout(false);
		this.tabControlVertical_0.ResumeLayout(false);
		this.XmIwfYoMg6.ResumeLayout(false);
		this.tabPage_4.ResumeLayout(false);
		((ISupportInitialize)this.chart_0).EndInit();
		this.tabPage_1.ResumeLayout(false);
		this.tabControlVertical_1.ResumeLayout(false);
		this.tabPage_5.ResumeLayout(false);
		((ISupportInitialize)this.dataGridView_1).EndInit();
		this.tabPage_6.ResumeLayout(false);
		((ISupportInitialize)this.chart_1).EndInit();
		this.tabPage_2.ResumeLayout(false);
		this.tabControlVertical_2.ResumeLayout(false);
		this.tabPage_7.ResumeLayout(false);
		((ISupportInitialize)this.dataGridView_2).EndInit();
		this.tabPage_8.ResumeLayout(false);
		((ISupportInitialize)this.chart_2).EndInit();
		this.tabPage_3.ResumeLayout(false);
		this.tabControlVertical_3.ResumeLayout(false);
		this.tabPage_9.ResumeLayout(false);
		((ISupportInitialize)this.dataGridView_3).EndInit();
		this.tabPage_10.ResumeLayout(false);
		((ISupportInitialize)this.chart_3).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	internal static void t0bGPq5CfZ8239aTOSl(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private DrawObjectBase drawObjectBase_0;

	private ErcloudConnect ercloudConnect_0;

	private Class10 class10_0;

	private int? nullable_0;

	private int? nullable_1;

	private DataTable dataTable_0;

	private DataTable dataTable_1;

	private DataTable dataTable_2;

	private DataTable dataTable_3;

	private TextBox textBox_0;

	private Label label_0;

	private TextBox textBox_1;

	private Label label_1;

	private Button button_0;

	private TextBox textBox_2;

	private TextBox textBox_3;

	private Label label_2;

	private Label label_3;

	private DateTimePicker dateTimePicker_0;

	private DateTimePicker dateTimePicker_1;

	private DataGridView dataGridView_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private Label label_4;

	private Label label_5;

	private CheckBox checkBox_0;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private TabPage tabPage_2;

	private TabPage tabPage_3;

	private Chart chart_0;

	private TabControlVertical tabControlVertical_0;

	private TabPage XmIwfYoMg6;

	private TabPage tabPage_4;

	private TabControlVertical tabControlVertical_1;

	private TabPage tabPage_5;

	private DataGridView dataGridView_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private TabPage tabPage_6;

	private Chart chart_1;

	private TabControlVertical tabControlVertical_2;

	private TabPage tabPage_7;

	private DataGridView dataGridView_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private TabPage tabPage_8;

	private Chart chart_2;

	private TabControlVertical tabControlVertical_3;

	private TabPage tabPage_9;

	private DataGridView dataGridView_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private TabPage tabPage_10;

	private Chart chart_3;

	private Button button_1;

	private Button button_2;

	private TabPage tabPage_11;

	private TabControlVertical tabControlVertical_4;

	private TabPage tabPage_12;

	private DataGridView dataGridView_4;

	private TabPage tabPage_13;

	private Chart chart_4;

	private DataSet dataSet_0;

	private DataTable dataTable_4;

	private DataColumn dataColumn_0;

	private DataColumn dataColumn_1;

	private DataColumn dataColumn_2;

	private DataColumn dataColumn_3;

	private DataColumn dataColumn_4;

	private DataColumn dataColumn_5;

	private DataColumn dataColumn_6;

	private DataGridViewTextBoxColumn AaXwEasGyJ;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
}
