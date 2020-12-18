using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using ControlsLbr;
using FormLbr;
using FormLbr.Classes;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.Ercloud
{
	public partial class FormSwitchShowDataErcloud : FormBase
	{
		public FormSwitchShowDataErcloud()
		{
			this.method_10();
		}

		public FormSwitchShowDataErcloud(DrawObjectBase drawObjectBase_1)
		{
			this.method_10();
			this.drawObjectBase_0 = drawObjectBase_1;
			this.textBox_1.Text = drawObjectBase_1.Text;
			this.textBox_0.Text = drawObjectBase_1.IdBase.ToString();
			this.dateTimePicker_0.Value = DateTime.Now.Date;
			this.dateTimePicker_1.Value = DateTime.Now.Date.AddDays(1.0).AddSeconds(-1.0);
		}

		private void FormSwitchShowDataErcloud_Load(object sender, EventArgs e)
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
			this.class90_0 = new Class90();
			this.class90_0.Id = Convert.ToInt32(this.nullable_0);
			this.class90_0.method_1(this.nullable_1);
			XmlDocument xmlDocument = this.method_4(this.ercloudConnect_0.User, "", this.nullable_0.ToString(), "0", "5", this.ercloudConnect_0.Password, null, null, null);
			string xml = this.method_6(this.ercloudConnect_0, xmlDocument);
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
						this.class90_0.Name = (this.textBox_2.Text = xmlNode2.InnerText);
						if (xmlNode2.Attributes["UID_OBJ"] != null)
						{
							this.nullable_1 = new int?(Convert.ToInt32(xmlNode2.Attributes["UID_OBJ"].Value));
						}
						break;
					}
				}
			}
			xmlDocument = this.method_4(this.ercloudConnect_0.User, "", this.nullable_0.ToString(), "0", "6", this.ercloudConnect_0.Password, new bool?(false), null, null);
			xml = this.method_6(this.ercloudConnect_0, xmlDocument);
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
								this.class90_0.method_3(Convert.ToInt32(xmlNode5.InnerText));
							}
						}
						break;
					}
				}
			}
			if (this.nullable_1 != null)
			{
				xmlDocument = this.method_4(this.ercloudConnect_0.User, this.nullable_1.ToString(), "", "0", "4", this.ercloudConnect_0.Password, null, null, null);
				xml = this.method_6(this.ercloudConnect_0, xmlDocument);
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

		private void method_2(Dictionary<DateTime, List<Class94>> dictionary_0, List<int> list_0)
		{
			FormSwitchShowDataErcloud.Class3 @class = new FormSwitchShowDataErcloud.Class3();
			@class.list_0 = list_0;
			List<DateTime> list = dictionary_0.Keys.ToList<DateTime>();
			list.Sort();
			foreach (DateTime dateTime in list)
			{
				object[] array = new object[@class.list_0.Count<int>() + 1];
				object[] array2 = new object[@class.list_0.Count<int>() + 1];
				object[] array3 = new object[@class.list_0.Count<int>() + 1];
				object[] array4 = new object[@class.list_0.Count<int>() + 1];
				array[0] = (array2[0] = (array3[0] = (array4[0] = dateTime)));
				List<Class94> list2 = dictionary_0[dateTime];
				Func<Class94, bool> func = null;
				FormSwitchShowDataErcloud.Class4 class2 = new FormSwitchShowDataErcloud.Class4();
				class2.class3_0 = @class;
				class2.int_0 = 0;
				while (class2.int_0 < @class.list_0.Count<int>())
				{
					IEnumerable<Class94> source = list2;
					if (func == null)
					{
						func = new Func<Class94, bool>(class2.method_0);
					}
					IEnumerable<Class94> source2 = source.Where(func);
					if (source2.Count<Class94>() > 0)
					{
						int num = 1;
						if (this.checkBox_0.Checked)
						{
							num = this.class90_0.method_2();
						}
						array[class2.int_0 + 1] = source2.First<Class94>().AP * (double)num;
						array2[class2.int_0 + 1] = source2.First<Class94>().AM * (double)num;
						array3[class2.int_0 + 1] = source2.First<Class94>().RP * (double)num;
						array4[class2.int_0 + 1] = source2.First<Class94>().RM * (double)num;
					}
					else
					{
						array[class2.int_0 + 1] = (array2[class2.int_0 + 1] = (array3[class2.int_0 + 1] = (array4[class2.int_0 + 1] = null)));
					}
					class2.int_0++;
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

		private void button_0_Click(object sender, EventArgs e)
		{
			XmlDocument xmlDocument = this.method_4(this.ercloudConnect_0.User, "", this.nullable_0.ToString(), "0", "7", this.ercloudConnect_0.Password, new bool?(true), new DateTime?(this.dateTimePicker_0.Value), new DateTime?(this.dateTimePicker_1.Value));
			string xml = this.method_6(this.ercloudConnect_0, xmlDocument);
			xmlDocument.LoadXml(xml);
			Dictionary<DateTime, List<Class94>> dictionary = new Dictionary<DateTime, List<Class94>>();
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
									Class94 item = new Class94(Convert.ToInt32(xmlNode4.InnerText), Convert.ToDouble(string.IsNullOrEmpty(xmlNode5.InnerText) ? "0" : xmlNode5.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode6.InnerText) ? "0" : xmlNode6.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode7.InnerText) ? "0" : xmlNode7.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode8.InnerText) ? "0" : xmlNode8.InnerText, CultureInfo.GetCultureInfo("en-US")));
									if (dictionary.ContainsKey(key))
									{
										dictionary[key].Add(item);
									}
									else
									{
										dictionary.Add(key, new List<Class94>
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
			XmlDocument xmlDocument = this.method_4(this.ercloudConnect_0.User, "", this.nullable_0.ToString(), "0", "2", this.ercloudConnect_0.Password, new bool?(true), new DateTime?(this.dateTimePicker_0.Value), new DateTime?(this.dateTimePicker_1.Value));
			string xml = this.method_6(this.ercloudConnect_0, xmlDocument);
			xmlDocument.LoadXml(xml);
			Dictionary<DateTime, List<Class94>> dictionary = new Dictionary<DateTime, List<Class94>>();
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
								Class94 item = new Class94(0, Convert.ToDouble(string.IsNullOrEmpty(xmlNode4.InnerText) ? "0" : xmlNode4.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode5.InnerText) ? "0" : xmlNode5.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode6.InnerText) ? "0" : xmlNode6.InnerText, CultureInfo.GetCultureInfo("en-US")), Convert.ToDouble(string.IsNullOrEmpty(xmlNode7.InnerText) ? "0" : xmlNode7.InnerText, CultureInfo.GetCultureInfo("en-US")));
								if (dictionary.ContainsKey(key))
								{
									dictionary[key].Add(item);
								}
								else
								{
									dictionary.Add(key, new List<Class94>
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

		private XmlDocument method_4(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, bool? nullable_2 = null, DateTime? nullable_3 = null, DateTime? nullable_4 = null)
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
			text = this.method_5(text + string_5);
			xmlNode2 = xmlDocument.CreateElement("magic_word");
			xmlNode2.InnerText = text.ToUpper();
			xmlNode.AppendChild(xmlNode2);
			return xmlDocument;
		}

		private string method_5(string input)
		{
			MD5 md = MD5.Create();
			byte[] array = md.ComputeHash(Encoding.Default.GetBytes(input));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		private string method_6(ErcloudConnect ercloudConnect_1, XmlDocument xmlDocument_0)
		{
			string result;
			try
			{
				byte[] array = new byte[1024];
				IPHostEntry hostEntry = Dns.GetHostEntry("localhost");
				IPAddress ipaddress = hostEntry.AddressList[0];
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
				XmlNode xmlNode = xmlDocument_0.SelectSingleNode("Connections");
				foreach (object obj in xmlNode.SelectNodes("ErcloudConnect"))
				{
					XmlNode xmlNode2 = (XmlNode)obj;
					try
					{
						if (Convert.ToInt32(xmlNode2.Attributes["Id"].Value) == int_0)
						{
							this.ercloudConnect_0 = new ErcloudConnect(int_0, xmlNode2.Attributes["Name"].Value, xmlNode2.Attributes["Address"].Value, Convert.ToInt32(xmlNode2.Attributes["Port"].Value), xmlNode2.Attributes["User"].Value, Crypt.Decrypt(xmlNode2.Attributes["Password"].Value, xmlNode2.Attributes["Name"].Value));
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
			this.tabPage_0 = new TabPage();
			this.tabControlVertical_0 = new TabControlVertical();
			this.tabPage_4 = new TabPage();
			this.tabPage_5 = new TabPage();
			this.chart_0 = new Chart();
			this.tabPage_1 = new TabPage();
			this.tabControlVertical_1 = new TabControlVertical();
			this.tabPage_6 = new TabPage();
			this.dataGridView_1 = new DataGridView();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.tabPage_7 = new TabPage();
			this.chart_1 = new Chart();
			this.tabPage_2 = new TabPage();
			this.tabControlVertical_2 = new TabControlVertical();
			this.tabPage_8 = new TabPage();
			this.dataGridView_2 = new DataGridView();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.tabPage_9 = new TabPage();
			this.chart_2 = new Chart();
			this.tabPage_3 = new TabPage();
			this.tabControlVertical_3 = new TabControlVertical();
			this.tabPage_10 = new TabPage();
			this.dataGridView_3 = new DataGridView();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.tabPage_11 = new TabPage();
			this.chart_3 = new Chart();
			this.button_1 = new Button();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.tabControlVertical_0.SuspendLayout();
			this.tabPage_4.SuspendLayout();
			this.tabPage_5.SuspendLayout();
			((ISupportInitialize)this.chart_0).BeginInit();
			this.tabPage_1.SuspendLayout();
			this.tabControlVertical_1.SuspendLayout();
			this.tabPage_6.SuspendLayout();
			((ISupportInitialize)this.dataGridView_1).BeginInit();
			this.tabPage_7.SuspendLayout();
			((ISupportInitialize)this.chart_1).BeginInit();
			this.tabPage_2.SuspendLayout();
			this.tabControlVertical_2.SuspendLayout();
			this.tabPage_8.SuspendLayout();
			((ISupportInitialize)this.dataGridView_2).BeginInit();
			this.tabPage_9.SuspendLayout();
			((ISupportInitialize)this.chart_2).BeginInit();
			this.tabPage_3.SuspendLayout();
			this.tabControlVertical_3.SuspendLayout();
			this.tabPage_10.SuspendLayout();
			((ISupportInitialize)this.dataGridView_3).BeginInit();
			this.tabPage_11.SuspendLayout();
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
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Controls.Add(this.tabPage_2);
			this.tabControl_0.Controls.Add(this.tabPage_3);
			this.tabControl_0.Location = new Point(0, 125);
			this.tabControl_0.Name = "tabControlEnergy";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(875, 279);
			this.tabControl_0.TabIndex = 21;
			this.tabPage_0.Controls.Add(this.tabControlVertical_0);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPageAP";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(867, 253);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Прямая активная энергия";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.tabControlVertical_0.Alignment = TabAlignment.Right;
			this.tabControlVertical_0.Controls.Add(this.tabPage_4);
			this.tabControlVertical_0.Controls.Add(this.tabPage_5);
			this.tabControlVertical_0.Dock = DockStyle.Fill;
			this.tabControlVertical_0.Location = new Point(3, 3);
			this.tabControlVertical_0.Multiline = true;
			this.tabControlVertical_0.Name = "tabControlAP";
			this.tabControlVertical_0.SelectedIndex = 0;
			this.tabControlVertical_0.Size = new Size(861, 247);
			this.tabControlVertical_0.TabIndex = 19;
			this.tabPage_4.Controls.Add(this.dataGridView_0);
			this.tabPage_4.Location = new Point(4, 4);
			this.tabPage_4.Name = "tabPageDgvAP";
			this.tabPage_4.Padding = new Padding(3);
			this.tabPage_4.Size = new Size(834, 239);
			this.tabPage_4.TabIndex = 0;
			this.tabPage_4.Text = "Таблица";
			this.tabPage_4.UseVisualStyleBackColor = true;
			this.tabPage_5.Controls.Add(this.chart_0);
			this.tabPage_5.Location = new Point(4, 4);
			this.tabPage_5.Name = "tabPageChartAP";
			this.tabPage_5.Padding = new Padding(3);
			this.tabPage_5.Size = new Size(834, 187);
			this.tabPage_5.TabIndex = 1;
			this.tabPage_5.Text = "График";
			this.tabPage_5.UseVisualStyleBackColor = true;
			chartArea.Name = "ChartArea1";
			this.chart_0.ChartAreas.Add(chartArea);
			this.chart_0.Dock = DockStyle.Fill;
			legend.Name = "Legend1";
			legend2.Name = "Legend2";
			this.chart_0.Legends.Add(legend);
			this.chart_0.Legends.Add(legend2);
			this.chart_0.Location = new Point(3, 3);
			this.chart_0.Name = "chartAP";
			this.chart_0.Size = new Size(828, 181);
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
			this.tabControlVertical_1.Controls.Add(this.tabPage_6);
			this.tabControlVertical_1.Controls.Add(this.tabPage_7);
			this.tabControlVertical_1.Dock = DockStyle.Fill;
			this.tabControlVertical_1.Location = new Point(3, 3);
			this.tabControlVertical_1.Multiline = true;
			this.tabControlVertical_1.Name = "tabControlAM";
			this.tabControlVertical_1.SelectedIndex = 0;
			this.tabControlVertical_1.Size = new Size(861, 247);
			this.tabControlVertical_1.TabIndex = 20;
			this.tabPage_6.Controls.Add(this.dataGridView_1);
			this.tabPage_6.Location = new Point(4, 4);
			this.tabPage_6.Name = "tabPage1";
			this.tabPage_6.Padding = new Padding(3);
			this.tabPage_6.Size = new Size(834, 239);
			this.tabPage_6.TabIndex = 0;
			this.tabPage_6.Text = "Таблица";
			this.tabPage_6.UseVisualStyleBackColor = true;
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
			this.tabPage_7.Controls.Add(this.chart_1);
			this.tabPage_7.Location = new Point(4, 4);
			this.tabPage_7.Name = "tabPage2";
			this.tabPage_7.Padding = new Padding(3);
			this.tabPage_7.Size = new Size(834, 187);
			this.tabPage_7.TabIndex = 1;
			this.tabPage_7.Text = "График";
			this.tabPage_7.UseVisualStyleBackColor = true;
			chartArea2.Name = "ChartArea1";
			this.chart_1.ChartAreas.Add(chartArea2);
			this.chart_1.Dock = DockStyle.Fill;
			legend3.Name = "Legend1";
			legend4.Name = "Legend2";
			this.chart_1.Legends.Add(legend3);
			this.chart_1.Legends.Add(legend4);
			this.chart_1.Location = new Point(3, 3);
			this.chart_1.Name = "chartAM";
			this.chart_1.Size = new Size(828, 181);
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
			this.tabControlVertical_2.Controls.Add(this.tabPage_8);
			this.tabControlVertical_2.Controls.Add(this.tabPage_9);
			this.tabControlVertical_2.Dock = DockStyle.Fill;
			this.tabControlVertical_2.Location = new Point(0, 0);
			this.tabControlVertical_2.Multiline = true;
			this.tabControlVertical_2.Name = "tabControlVertical1";
			this.tabControlVertical_2.SelectedIndex = 0;
			this.tabControlVertical_2.Size = new Size(867, 253);
			this.tabControlVertical_2.TabIndex = 21;
			this.tabPage_8.Controls.Add(this.dataGridView_2);
			this.tabPage_8.Location = new Point(4, 4);
			this.tabPage_8.Name = "tabPage3";
			this.tabPage_8.Padding = new Padding(3);
			this.tabPage_8.Size = new Size(840, 245);
			this.tabPage_8.TabIndex = 0;
			this.tabPage_8.Text = "Таблица";
			this.tabPage_8.UseVisualStyleBackColor = true;
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
			this.tabPage_9.Controls.Add(this.chart_2);
			this.tabPage_9.Location = new Point(4, 4);
			this.tabPage_9.Name = "tabPage4";
			this.tabPage_9.Padding = new Padding(3);
			this.tabPage_9.Size = new Size(840, 193);
			this.tabPage_9.TabIndex = 1;
			this.tabPage_9.Text = "График";
			this.tabPage_9.UseVisualStyleBackColor = true;
			chartArea3.Name = "ChartArea1";
			this.chart_2.ChartAreas.Add(chartArea3);
			this.chart_2.Dock = DockStyle.Fill;
			legend5.Name = "Legend1";
			legend6.Name = "Legend2";
			this.chart_2.Legends.Add(legend5);
			this.chart_2.Legends.Add(legend6);
			this.chart_2.Location = new Point(3, 3);
			this.chart_2.Name = "chartRP";
			this.chart_2.Size = new Size(834, 187);
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
			this.tabControlVertical_3.Controls.Add(this.tabPage_10);
			this.tabControlVertical_3.Controls.Add(this.tabPage_11);
			this.tabControlVertical_3.Dock = DockStyle.Fill;
			this.tabControlVertical_3.Location = new Point(0, 0);
			this.tabControlVertical_3.Multiline = true;
			this.tabControlVertical_3.Name = "tabControlVertical2";
			this.tabControlVertical_3.SelectedIndex = 0;
			this.tabControlVertical_3.Size = new Size(867, 253);
			this.tabControlVertical_3.TabIndex = 21;
			this.tabPage_10.Controls.Add(this.dataGridView_3);
			this.tabPage_10.Location = new Point(4, 4);
			this.tabPage_10.Name = "tabPage5";
			this.tabPage_10.Padding = new Padding(3);
			this.tabPage_10.Size = new Size(840, 245);
			this.tabPage_10.TabIndex = 0;
			this.tabPage_10.Text = "Таблица";
			this.tabPage_10.UseVisualStyleBackColor = true;
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
			this.tabPage_11.Controls.Add(this.chart_3);
			this.tabPage_11.Location = new Point(4, 4);
			this.tabPage_11.Name = "tabPage6";
			this.tabPage_11.Padding = new Padding(3);
			this.tabPage_11.Size = new Size(840, 245);
			this.tabPage_11.TabIndex = 1;
			this.tabPage_11.Text = "График";
			this.tabPage_11.UseVisualStyleBackColor = true;
			chartArea4.Name = "ChartArea1";
			this.chart_3.ChartAreas.Add(chartArea4);
			this.chart_3.Dock = DockStyle.Fill;
			legend7.Name = "Legend1";
			legend8.Name = "Legend2";
			this.chart_3.Legends.Add(legend7);
			this.chart_3.Legends.Add(legend8);
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
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(874, 445);
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
			base.Load += this.FormSwitchShowDataErcloud_Load;
			((ISupportInitialize)this.dataGridView_0).EndInit();
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tabControlVertical_0.ResumeLayout(false);
			this.tabPage_4.ResumeLayout(false);
			this.tabPage_5.ResumeLayout(false);
			((ISupportInitialize)this.chart_0).EndInit();
			this.tabPage_1.ResumeLayout(false);
			this.tabControlVertical_1.ResumeLayout(false);
			this.tabPage_6.ResumeLayout(false);
			((ISupportInitialize)this.dataGridView_1).EndInit();
			this.tabPage_7.ResumeLayout(false);
			((ISupportInitialize)this.chart_1).EndInit();
			this.tabPage_2.ResumeLayout(false);
			this.tabControlVertical_2.ResumeLayout(false);
			this.tabPage_8.ResumeLayout(false);
			((ISupportInitialize)this.dataGridView_2).EndInit();
			this.tabPage_9.ResumeLayout(false);
			((ISupportInitialize)this.chart_2).EndInit();
			this.tabPage_3.ResumeLayout(false);
			this.tabControlVertical_3.ResumeLayout(false);
			this.tabPage_10.ResumeLayout(false);
			((ISupportInitialize)this.dataGridView_3).EndInit();
			this.tabPage_11.ResumeLayout(false);
			((ISupportInitialize)this.chart_3).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private DrawObjectBase drawObjectBase_0;

		private ErcloudConnect ercloudConnect_0;

		private Class90 class90_0;

		private int? nullable_0 = null;

		private int? nullable_1 = null;

		private DataTable dataTable_0 = new DataTable();

		private DataTable dataTable_1 = new DataTable();

		private DataTable dataTable_2 = new DataTable();

		private DataTable dataTable_3 = new DataTable();

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

		private TabPage tabPage_4;

		private TabPage tabPage_5;

		private TabControlVertical tabControlVertical_1;

		private TabPage tabPage_6;

		private DataGridView dataGridView_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private TabPage tabPage_7;

		private Chart chart_1;

		private TabControlVertical tabControlVertical_2;

		private TabPage tabPage_8;

		private DataGridView dataGridView_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private TabPage tabPage_9;

		private Chart chart_2;

		private TabControlVertical tabControlVertical_3;

		private TabPage tabPage_10;

		private DataGridView dataGridView_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private TabPage tabPage_11;

		private Chart chart_3;

		private Button button_1;

		[CompilerGenerated]
		private sealed class Class3
		{
			public List<int> list_0;
		}

		[CompilerGenerated]
		private sealed class Class4
		{
			public bool method_0(Class94 class94_0)
			{
				return class94_0.Tarif == this.class3_0.list_0[this.int_0];
			}

			public FormSwitchShowDataErcloud.Class3 class3_0;

			public int int_0;
		}
	}
}
