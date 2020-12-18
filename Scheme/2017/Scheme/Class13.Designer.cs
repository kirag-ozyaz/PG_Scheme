using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataSql;
using Scheme.Properties;
using SchemeCtrl2.DrawTool;
using WinFormsUI.Docking;

internal class Class13 : DockContentBase
{
	internal Class13()
	{
		Class63.AGd1PxHzk5wxP();
		this.dictionary_0 = new Dictionary<DrawObjectBase, Series>();
		this.dictionary_1 = new Dictionary<Class13.Class14, ChartArea>();
		this.stack_0 = new Stack<Color>();
		this.list_0 = new List<DrawObjectBase>();
		this.series_0 = new Series();
		base..ctor();
		this.method_18();
		this.method_0();
	}

	internal Class13(SQLSettings sqlsettings_0, DrawObjectBase drawObjectBase_0)
	{
		Class63.AGd1PxHzk5wxP();
		this.dictionary_0 = new Dictionary<DrawObjectBase, Series>();
		this.dictionary_1 = new Dictionary<Class13.Class14, ChartArea>();
		this.stack_0 = new Stack<Color>();
		this.list_0 = new List<DrawObjectBase>();
		this.series_0 = new Series();
		base..ctor();
		this.method_18();
		this.method_0();
		this.SqlSettings = sqlsettings_0;
		this.method_5(drawObjectBase_0);
		string text = string.Empty;
		if (drawObjectBase_0.GetType() == typeof(RectangleTool))
		{
			text = "Подстанция";
		}
		else if (drawObjectBase_0.GetType() == typeof(ShinaTool))
		{
			text = "Секция шин";
		}
		else if (drawObjectBase_0.GetType() == typeof(LineCellTool))
		{
			text = "Ячейка";
		}
		else if (drawObjectBase_0.GetType() == typeof(TransformerTool))
		{
			text = "Трансформатор";
		}
		else if (drawObjectBase_0.GetType() == typeof(ObjectOnLine) && drawObjectBase_0.GetType().GetProperty("On").CanWrite)
		{
			text = "Коммутационный аппарат";
		}
		if (text == string.Empty)
		{
			return;
		}
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
		{
			DataTable dataTable = new DataTable();
			try
			{
				SqlCommand sqlCommand = new SqlCommand("SELECT [Id]\r\n                                     ,[Description]\r\n                               FROM [OPC_Config].[dbo].[Parameters]\r\n                               WHERE measure  is not null and ObjectDescription LIKE '" + text + "'", sqlConnection);
				sqlConnection.Open();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				dataTable.Load(sqlDataReader);
				sqlDataReader.Close();
				sqlConnection.Close();
			}
			catch
			{
			}
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				Class13.Class14 item = new Class13.Class14((int)dataRow[0], dataRow[1].ToString());
				this.checkedListBox_0.Items.Add(item);
			}
		}
		this.printDocument_0.DefaultPageSettings.Landscape = true;
		this.chart_0.Printing.PrintDocument.PrintPage += this.method_17;
		this.series_0.Name = "combiner";
		this.series_0.LegendText = "Сумматор";
		this.series_0.Legend = this.chart_0.Legends[0].Name;
		this.series_0.Tag = this.list_0;
		this.series_0.ChartType = SeriesChartType.StepLine;
		this.series_0.Color = Color.Black;
		this.series_0.BorderWidth = 2;
		this.comboBox_0.SelectedIndex = 0;
	}

	private void method_0()
	{
		this.stack_0.Push(Color.LightGreen);
		this.stack_0.Push(Color.Olive);
		this.stack_0.Push(Color.Purple);
		this.stack_0.Push(Color.LightBlue);
		this.stack_0.Push(Color.Yellow);
		this.stack_0.Push(Color.Aqua);
		this.stack_0.Push(Color.Orange);
		this.stack_0.Push(Color.Red);
		this.stack_0.Push(Color.Green);
		this.stack_0.Push(Color.Blue);
	}

	public Type method_1()
	{
		if (this.dictionary_0.Count > 0)
		{
			return this.dictionary_0.Keys.First<DrawObjectBase>().GetType();
		}
		return null;
	}

	public IEnumerable<DrawObjectBase> method_2()
	{
		return this.dictionary_0.Keys;
	}

	internal bool method_3(DrawObjectBase drawObjectBase_0)
	{
		return (drawObjectBase_0.GetType() == this.method_1() || this.method_1() == null) && this.stack_0.Count > 0 && !this.method_2().Contains(drawObjectBase_0) && !this.list_0.Contains(drawObjectBase_0);
	}

	internal SeriesChartType method_4()
	{
		SeriesChartType result = SeriesChartType.StepLine;
		int selectedIndex = this.comboBox_0.SelectedIndex;
		if (selectedIndex != 1)
		{
			if (selectedIndex == 2)
			{
				result = SeriesChartType.Column;
			}
		}
		else
		{
			result = SeriesChartType.Line;
		}
		return result;
	}

	internal void method_5(DrawObjectBase drawObjectBase_0)
	{
		if (!this.method_3(drawObjectBase_0))
		{
			return;
		}
		ListViewItem listViewItem = new ListViewItem(drawObjectBase_0.GetFullName());
		listViewItem.Tag = drawObjectBase_0;
		this.listView_0.Items.Add(listViewItem);
		Series series = new Series();
		series.Name = drawObjectBase_0.IdBase.ToString();
		series.LegendText = drawObjectBase_0.GetFullName();
		series.Legend = this.chart_0.Legends[0].Name;
		series.Tag = drawObjectBase_0;
		series.ChartType = this.method_4();
		series.Color = this.stack_0.Pop();
		series.BorderWidth = 2;
		this.dictionary_0.Add(drawObjectBase_0, series);
		foreach (ChartArea chartArea in this.chart_0.ChartAreas)
		{
			this.method_9(drawObjectBase_0, chartArea);
			this.yYmvytrRgl(drawObjectBase_0, (Class13.Class14)chartArea.Tag);
		}
	}

	private void method_6(DrawObjectBase drawObjectBase_0)
	{
		if (this.dictionary_0.Count <= 0)
		{
			return;
		}
		List<string> list = new List<string>();
		IEnumerable<Series> series = this.chart_0.Series;
		Func<Series, bool> <>9__0;
		Func<Series, bool> predicate;
		if ((predicate = <>9__0) == null)
		{
			predicate = (<>9__0 = ((Series s) => s.Tag == drawObjectBase_0));
		}
		foreach (Series series2 in series.Where(predicate))
		{
			list.Add(series2.Name);
		}
		foreach (string name in list)
		{
			Series item = this.chart_0.Series[name];
			this.chart_0.Series.Remove(item);
		}
		(from s in this.chart_0.Series
		where s.Tag == drawObjectBase_0
		select s).Count<Series>();
		this.stack_0.Push(this.dictionary_0[drawObjectBase_0].Color);
		this.dictionary_0.Remove(drawObjectBase_0);
	}

	private void method_7(Class13.Class14 class14_0)
	{
		ChartArea chartArea = new ChartArea();
		chartArea.Tag = class14_0;
		this.chart_0.ChartAreas.Add(chartArea);
		this.dictionary_1.Add(class14_0, chartArea);
		foreach (DrawObjectBase drawObjectBase_ in this.dictionary_0.Keys)
		{
			this.method_9(drawObjectBase_, chartArea);
		}
		this.method_10(chartArea);
		this.method_12();
	}

	private void method_8(Class13.Class14 class14_0)
	{
		ChartArea chartArea = this.dictionary_1[class14_0];
		List<string> list = new List<string>();
		foreach (Series series in from s in this.chart_0.Series
		where s.ChartArea == chartArea.Name
		select s)
		{
			list.Add(series.Name);
		}
		foreach (string name in list)
		{
			this.chart_0.Series.Remove(this.chart_0.Series[name]);
		}
		this.chart_0.ChartAreas.Remove(chartArea);
		this.dictionary_1.Remove(class14_0);
	}

	private void method_9(DrawObjectBase drawObjectBase_0, ChartArea chartArea_0)
	{
		Series series = new Series();
		series.Name = this.method_11(this.dictionary_0[drawObjectBase_0].Name);
		series.LegendText = this.dictionary_0[drawObjectBase_0].LegendText;
		series.Legend = this.dictionary_0[drawObjectBase_0].Legend;
		series.Tag = this.dictionary_0[drawObjectBase_0].Tag;
		series.ChartType = this.dictionary_0[drawObjectBase_0].ChartType;
		series.ChartArea = chartArea_0.Name;
		series.BorderWidth = this.dictionary_0[drawObjectBase_0].BorderWidth;
		this.chart_0.Series.Add(series);
		series.Color = this.dictionary_0[drawObjectBase_0].Color;
		if (this.chart_0.Series.Count(new Func<Series, bool>(this.method_19)) > 1)
		{
			series.IsVisibleInLegend = false;
		}
	}

	private void method_10(ChartArea chartArea_0)
	{
		if (this.list_0.Count == 0)
		{
			return;
		}
		int num = this.chart_0.Series.Where(new Func<Series, bool>(this.method_20)).Count<Series>() + 1;
		Series series = new Series();
		series.Name = this.series_0.Name + num.ToString();
		series.LegendText = this.series_0.LegendText;
		series.Legend = this.series_0.Legend;
		series.Tag = this.series_0.Tag;
		series.ChartType = this.method_4();
		series.ChartArea = chartArea_0.Name;
		series.BorderWidth = this.series_0.BorderWidth;
		this.chart_0.Series.Add(series);
		series.Color = this.series_0.Color;
		if (num > 1)
		{
			series.IsVisibleInLegend = false;
		}
	}

	private string method_11(string string_0)
	{
		int c = 1;
		if (this.chart_0.Series.Count((Series s) => s.Name == string_0 + c.ToString()) > 0)
		{
			while (this.chart_0.Series.Count((Series s) => s.Name == string_0 + c.ToString()) > 0)
			{
				int c2 = c;
				c = c2 + 1;
			}
		}
		return string_0 + c.ToString();
	}

	private void method_12()
	{
		foreach (Series series in this.chart_0.Series)
		{
			series.Points.Clear();
		}
		foreach (Class13.Class14 class14_ in this.dictionary_1.Keys)
		{
			this.method_13(class14_);
		}
	}

	private void method_13(Class13.Class14 class14_0)
	{
		foreach (DrawObjectBase drawObjectBase_ in this.dictionary_0.Keys)
		{
			this.yYmvytrRgl(drawObjectBase_, class14_0);
		}
		if (this.list_0.Count == 0)
		{
			return;
		}
		object[,] object_ = class14_0.method_0(this.SqlSettings, this.list_0, this.dateTimePicker_1.Value, this.dateTimePicker_0.Value);
		ChartArea chartArea = this.dictionary_1[class14_0];
		if (chartArea == null)
		{
			return;
		}
		Series series_ = this.chart_0.Series.First((Series s) => s.Tag == this.list_0 && s.ChartArea == chartArea.Name);
		this.method_14(object_, chartArea, series_);
	}

	private void yYmvytrRgl(DrawObjectBase drawObjectBase_0, Class13.Class14 class14_0)
	{
		object[,] object_ = class14_0.method_1(this.SqlSettings, drawObjectBase_0, this.dateTimePicker_1.Value, this.dateTimePicker_0.Value);
		ChartArea chartArea = this.dictionary_1[class14_0];
		if (chartArea == null)
		{
			return;
		}
		Series series = this.chart_0.Series.First((Series s) => s.Tag == drawObjectBase_0 && s.ChartArea == chartArea.Name);
		if (series == null)
		{
			return;
		}
		this.method_14(object_, chartArea, series);
	}

	private void method_14(object[,] object_0, ChartArea chartArea_0, Series series_1)
	{
		if (chartArea_0 == null)
		{
			return;
		}
		if (series_1 == null)
		{
			return;
		}
		chartArea_0.Axes[0].Title = object_0[0, 0].ToString();
		chartArea_0.Axes[1].Title = object_0[0, 1].ToString();
		chartArea_0.Axes[0].IntervalType = DateTimeIntervalType.Hours;
		chartArea_0.Axes[0].IntervalAutoMode = IntervalAutoMode.VariableCount;
		chartArea_0.Axes[1].IntervalAutoMode = IntervalAutoMode.VariableCount;
		series_1.XValueType = ChartValueType.DateTime;
		series_1.YValueType = ChartValueType.Double;
		if (object_0.Length <= 2)
		{
			return;
		}
		for (int i = 1; i < object_0.Length / 2; i++)
		{
			series_1.Points.AddXY(Convert.ToDateTime(object_0[i, 0]), new object[]
			{
				Convert.ToDouble(object_0[i, 1])
			});
		}
	}

	internal void method_15(object object_0)
	{
		this.method_16();
		List<string> list = new List<string>();
		IEnumerable<Series> series = this.chart_0.Series;
		Func<Series, bool> <>9__0;
		Func<Series, bool> predicate;
		if ((predicate = <>9__0) == null)
		{
			predicate = (<>9__0 = ((Series s) => s.Tag == object_0 && s.ChartArea != string.Empty));
		}
		foreach (Series series2 in series.Where(predicate))
		{
			list.Add(series2.Name);
		}
		foreach (string name in list)
		{
			Series series3 = this.chart_0.Series[name];
			ChartArea chartArea = this.chart_0.ChartAreas[series3.ChartArea];
			Series series4 = new Series();
			if (object_0 is DrawObjectBase)
			{
				DrawObjectBase key = (DrawObjectBase)object_0;
				series4.Name = this.dictionary_0[key].Name + "Select" + chartArea.Name;
				series4.LegendText = this.dictionary_0[key].LegendText;
				series4.Legend = this.dictionary_0[key].Legend;
				series4.Color = this.dictionary_0[key].Color;
				series4.Tag = this.dictionary_0[key].Tag;
			}
			else
			{
				series4.Name = this.series_0.Name + "Select" + chartArea.Name;
				series4.LegendText = this.series_0.LegendText;
				series4.Legend = this.series_0.Legend;
				series4.Color = this.series_0.Color;
				series4.Tag = this.series_0.Tag;
			}
			series4.IsVisibleInLegend = false;
			series4.ChartType = SeriesChartType.Point;
			series4.ChartArea = chartArea.Name;
			if (!this.chart_0.Series.Contains(series4))
			{
				this.chart_0.Series.Add(series4);
			}
			foreach (DataPoint dataPoint in series3.Points)
			{
				DataPoint item = new DataPoint(dataPoint.XValue, dataPoint.YValues);
				series4.Points.Add(item);
			}
		}
	}

	internal void method_16()
	{
		List<string> list = new List<string>();
		foreach (Series series in from s in this.chart_0.Series
		where s.ChartType == SeriesChartType.Point
		select s)
		{
			list.Add(series.Name);
		}
		foreach (string name in list)
		{
			this.chart_0.Series.Remove(this.chart_0.Series[name]);
		}
	}

	private void method_17(object sender, PrintPageEventArgs e)
	{
	}

	protected override void OnLoad(EventArgs eventArgs_0)
	{
		this.dateTimePicker_1.Value = this.dateTimePicker_0.Value.AddDays(-1.0);
	}

	private void exLvOsrwCM(object sender, ItemCheckEventArgs e)
	{
		if (this.dictionary_0.Count == 0)
		{
			return;
		}
		if (e.NewValue == CheckState.Checked)
		{
			Class13.Class14 class14_ = (Class13.Class14)this.checkedListBox_0.Items[e.Index];
			this.method_7(class14_);
			return;
		}
		Class13.Class14 class14_2 = (Class13.Class14)this.checkedListBox_0.Items[e.Index];
		this.method_8(class14_2);
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		this.method_12();
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		if (this.listView_0.FocusedItem == null)
		{
			return;
		}
		this.method_6((DrawObjectBase)this.listView_0.FocusedItem.Tag);
		this.listView_0.Items.Remove(this.listView_0.FocusedItem);
	}

	private void listView_0_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Right && this.listView_0.FocusedItem.Bounds.Contains(e.Location))
		{
			this.contextMenuStrip_0.Show(System.Windows.Forms.Cursor.Position);
		}
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		foreach (Series series in this.chart_0.Series)
		{
			series.IsValueShownAsLabel = this.checkBox_0.Checked;
		}
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		this.method_16();
		if (this.printDialog_0.ShowDialog() == DialogResult.OK)
		{
			this.printDocument_0.Print();
		}
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		this.method_16();
		this.printPreviewDialog_0.ShowDialog();
	}

	private void printDocument_0_PrintPage(object sender, PrintPageEventArgs e)
	{
		this.method_16();
		this.chart_0.Printing.PrintPaint(e.Graphics, e.MarginBounds);
	}

	private void toolStripButton_3_Click(object sender, EventArgs e)
	{
		this.pageSetupDialog_0.ShowDialog();
	}

	private void listView_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.listView_0.SelectedItems.Count == 0)
		{
			this.method_16();
			return;
		}
		this.method_15(this.listView_0.FocusedItem.Tag);
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (this.listView_0.SelectedItems.Count == 0)
		{
			return;
		}
		ListViewItem focusedItem = this.listView_0.FocusedItem;
		if (!(focusedItem.Tag is DrawObjectBase))
		{
			return;
		}
		this.list_0.Add((DrawObjectBase)focusedItem.Tag);
		if (this.list_0.Count == 1)
		{
			ListViewItem listViewItem = new ListViewItem("Сумматор");
			listViewItem.Tag = this.list_0;
			this.listView_0.Items.Add(listViewItem);
			foreach (ChartArea chartArea_ in this.chart_0.ChartAreas)
			{
				this.method_10(chartArea_);
			}
		}
		this.method_6((DrawObjectBase)focusedItem.Tag);
		this.listView_0.Items.Remove(focusedItem);
		this.listView_1.Items.Add(focusedItem);
		if (this.dictionary_1.Keys.Count == 0)
		{
			return;
		}
		this.method_12();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		if (this.listView_1.SelectedItems.Count == 0)
		{
			return;
		}
		ListViewItem focusedItem = this.listView_1.FocusedItem;
		if (!(focusedItem.Tag is DrawObjectBase))
		{
			return;
		}
		this.list_0.Remove((DrawObjectBase)focusedItem.Tag);
		if (this.list_0.Count == 0)
		{
			foreach (object obj in this.listView_0.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				if (listViewItem.Tag == this.list_0)
				{
					this.listView_0.Items.Remove(listViewItem);
					break;
				}
			}
			List<string> list = new List<string>();
			foreach (Series series in this.chart_0.Series.Where(new Func<Series, bool>(this.method_21)))
			{
				list.Add(series.Name);
			}
			foreach (string name in list)
			{
				this.chart_0.Series.Remove(this.chart_0.Series[name]);
			}
		}
		this.method_5((DrawObjectBase)focusedItem.Tag);
		this.listView_1.Items.Remove(focusedItem);
		if (this.dictionary_1.Keys.Count == 0)
		{
			return;
		}
		this.method_12();
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		SeriesChartType chartType = this.method_4();
		foreach (Series series in from ss in this.chart_0.Series
		where ss.ChartType > SeriesChartType.Point
		select ss)
		{
			series.ChartType = chartType;
		}
		foreach (Series series2 in this.dictionary_0.Values)
		{
			series2.ChartType = chartType;
		}
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Class13.dNNNjuPJZlhZuPttKKD(this, bool_0);
	}

	private void method_18()
	{
		this.icontainer_0 = new Container();
		Legend legend = new Legend();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Class13));
		this.toolStrip_0 = new ToolStrip();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripSeparator_0 = new ToolStripSeparator();
		this.toolStripButton_1 = new ToolStripButton();
		this.toolStripButton_2 = new ToolStripButton();
		this.toolStripButton_3 = new ToolStripButton();
		this.chart_0 = new Chart();
		this.groupBox_0 = new GroupBox();
		this.label_0 = new Label();
		this.label_1 = new Label();
		this.dateTimePicker_0 = new DateTimePicker();
		this.dateTimePicker_1 = new DateTimePicker();
		this.checkedListBox_0 = new CheckedListBox();
		this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_0 = new ToolStripMenuItem();
		this.listView_0 = new ListView();
		this.columnHeader_0 = new ColumnHeader();
		this.printDocument_0 = new PrintDocument();
		this.printDialog_0 = new PrintDialog();
		this.printPreviewDialog_0 = new PrintPreviewDialog();
		this.pageSetupDialog_0 = new PageSetupDialog();
		this.groupBox_1 = new GroupBox();
		this.checkBox_0 = new CheckBox();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.listView_1 = new ListView();
		this.columnHeader_1 = new ColumnHeader();
		this.comboBox_0 = new ComboBox();
		this.toolStrip_0.SuspendLayout();
		((ISupportInitialize)this.chart_0).BeginInit();
		this.groupBox_0.SuspendLayout();
		this.contextMenuStrip_0.SuspendLayout();
		this.groupBox_1.SuspendLayout();
		base.SuspendLayout();
		this.toolStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_0,
			this.toolStripSeparator_0,
			this.toolStripButton_1,
			this.toolStripButton_2,
			this.toolStripButton_3
		});
		this.toolStrip_0.Location = new Point(0, 0);
		this.toolStrip_0.Name = "toolStrip1";
		this.toolStrip_0.Size = new Size(1159, 25);
		this.toolStrip_0.TabIndex = 2;
		this.toolStrip_0.Text = "toolStrip1";
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = Resources.smethod_51();
		this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_0.Name = "toolStripButton1";
		this.toolStripButton_0.Size = new Size(23, 22);
		this.toolStripButton_0.Text = "toolStripButton1";
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.toolStripSeparator_0.Name = "toolStripSeparator1";
		this.toolStripSeparator_0.Size = new Size(6, 25);
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = Resources.smethod_47();
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolStripButtonPrint";
		this.toolStripButton_1.Size = new Size(23, 22);
		this.toolStripButton_1.Text = "Печать";
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_2.Image = Resources.smethod_49();
		this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_2.Name = "toolStripButtonPrintPreview";
		this.toolStripButton_2.Size = new Size(23, 22);
		this.toolStripButton_2.Text = "Предпросмотр";
		this.toolStripButton_2.Click += this.toolStripButton_2_Click;
		this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_3.Image = Resources.smethod_45();
		this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_3.Name = "toolStripButtonPageSetup";
		this.toolStripButton_3.Size = new Size(23, 22);
		this.toolStripButton_3.Text = "Настройки страницы";
		this.toolStripButton_3.Click += this.toolStripButton_3_Click;
		this.chart_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		legend.Name = "Legend1";
		this.chart_0.Legends.Add(legend);
		this.chart_0.Location = new Point(180, 28);
		this.chart_0.Name = "chart1";
		this.chart_0.Size = new Size(799, 463);
		this.chart_0.TabIndex = 3;
		this.chart_0.Text = "chart1";
		this.groupBox_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.groupBox_0.Controls.Add(this.label_0);
		this.groupBox_0.Controls.Add(this.label_1);
		this.groupBox_0.Controls.Add(this.dateTimePicker_0);
		this.groupBox_0.Controls.Add(this.dateTimePicker_1);
		this.groupBox_0.Location = new Point(6, 397);
		this.groupBox_0.Name = "groupBox1";
		this.groupBox_0.Size = new Size(174, 100);
		this.groupBox_0.TabIndex = 4;
		this.groupBox_0.TabStop = false;
		this.groupBox_0.Text = "Период";
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(6, 55);
		this.label_0.Name = "label2";
		this.label_0.Size = new Size(42, 13);
		this.label_0.TabIndex = 7;
		this.label_0.Text = "После:";
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(6, 16);
		this.label_1.Name = "label1";
		this.label_1.Size = new Size(23, 13);
		this.label_1.TabIndex = 6;
		this.label_1.Text = "От:";
		this.dateTimePicker_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.dateTimePicker_0.Location = new Point(6, 71);
		this.dateTimePicker_0.Name = "dateTimePickerTill";
		this.dateTimePicker_0.Size = new Size(162, 20);
		this.dateTimePicker_0.TabIndex = 0;
		this.dateTimePicker_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.dateTimePicker_1.Location = new Point(6, 32);
		this.dateTimePicker_1.Name = "dateTimePickerFrom";
		this.dateTimePicker_1.Size = new Size(162, 20);
		this.dateTimePicker_1.TabIndex = 0;
		this.checkedListBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
		this.checkedListBox_0.CheckOnClick = true;
		this.checkedListBox_0.FormattingEnabled = true;
		this.checkedListBox_0.Location = new Point(979, 28);
		this.checkedListBox_0.Name = "checkedListBoxParameters";
		this.checkedListBox_0.Size = new Size(180, 364);
		this.checkedListBox_0.TabIndex = 5;
		this.checkedListBox_0.ItemCheck += this.exLvOsrwCM;
		this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripMenuItem_0
		});
		this.contextMenuStrip_0.Name = "contextMenuStripObj";
		this.contextMenuStrip_0.Size = new Size(119, 26);
		this.toolStripMenuItem_0.Name = "удалитьToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new Size(118, 22);
		this.toolStripMenuItem_0.Text = "Удалить";
		this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
		this.listView_0.Activation = ItemActivation.OneClick;
		this.listView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
		this.listView_0.Columns.AddRange(new ColumnHeader[]
		{
			this.columnHeader_0
		});
		this.listView_0.FullRowSelect = true;
		this.listView_0.HeaderStyle = ColumnHeaderStyle.None;
		this.listView_0.Location = new Point(0, 28);
		this.listView_0.MultiSelect = false;
		this.listView_0.Name = "listViewParametrs";
		this.listView_0.Size = new Size(180, 236);
		this.listView_0.TabIndex = 7;
		this.listView_0.UseCompatibleStateImageBehavior = false;
		this.listView_0.View = View.Details;
		this.listView_0.SelectedIndexChanged += this.listView_0_SelectedIndexChanged;
		this.listView_0.MouseClick += this.listView_0_MouseClick;
		this.columnHeader_0.Width = 176;
		this.printDocument_0.PrintPage += this.printDocument_0_PrintPage;
		this.printDialog_0.Document = this.printDocument_0;
		this.printDialog_0.UseEXDialog = true;
		this.printPreviewDialog_0.AutoScrollMargin = new Size(0, 0);
		this.printPreviewDialog_0.AutoScrollMinSize = new Size(0, 0);
		this.printPreviewDialog_0.ClientSize = new Size(400, 300);
		this.printPreviewDialog_0.Document = this.printDocument_0;
		this.printPreviewDialog_0.Enabled = true;
		this.printPreviewDialog_0.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		this.printPreviewDialog_0.Name = "printPreviewDialog1";
		this.printPreviewDialog_0.UseAntiAlias = true;
		this.printPreviewDialog_0.Visible = false;
		this.pageSetupDialog_0.Document = this.printDocument_0;
		this.groupBox_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.groupBox_1.Controls.Add(this.comboBox_0);
		this.groupBox_1.Controls.Add(this.checkBox_0);
		this.groupBox_1.Location = new Point(979, 397);
		this.groupBox_1.Name = "groupBox2";
		this.groupBox_1.Size = new Size(174, 100);
		this.groupBox_1.TabIndex = 8;
		this.groupBox_1.TabStop = false;
		this.groupBox_1.Text = "Настройка";
		this.checkBox_0.AutoSize = true;
		this.checkBox_0.Location = new Point(6, 19);
		this.checkBox_0.Name = "checkBoxWriteValues";
		this.checkBox_0.Size = new Size(131, 17);
		this.checkBox_0.TabIndex = 0;
		this.checkBox_0.Text = "Подписать значения";
		this.checkBox_0.UseVisualStyleBackColor = true;
		this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.button_0.Location = new Point(0, 262);
		this.button_0.Name = "button1";
		this.button_0.Size = new Size(88, 23);
		this.button_0.TabIndex = 9;
		this.button_0.Text = "▼";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_0_Click;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.button_1.Location = new Point(92, 262);
		this.button_1.Name = "button2";
		this.button_1.Size = new Size(88, 23);
		this.button_1.TabIndex = 10;
		this.button_1.Text = "▲";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.listView_1.Activation = ItemActivation.OneClick;
		this.listView_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.listView_1.Columns.AddRange(new ColumnHeader[]
		{
			this.columnHeader_1
		});
		this.listView_1.FullRowSelect = true;
		this.listView_1.HeaderStyle = ColumnHeaderStyle.None;
		this.listView_1.Location = new Point(0, 284);
		this.listView_1.MultiSelect = false;
		this.listView_1.Name = "listViewCombiner";
		this.listView_1.Size = new Size(180, 108);
		this.listView_1.TabIndex = 11;
		this.listView_1.UseCompatibleStateImageBehavior = false;
		this.listView_1.View = View.Details;
		this.columnHeader_1.Width = 176;
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Items.AddRange(new object[]
		{
			"Ступенчатый график",
			"Линейная аппроксимация",
			"Столбцы"
		});
		this.comboBox_0.Location = new Point(6, 42);
		this.comboBox_0.Name = "comboBoxChartType";
		this.comboBox_0.Size = new Size(121, 21);
		this.comboBox_0.TabIndex = 1;
		this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(1159, 503);
		base.Controls.Add(this.listView_1);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.groupBox_1);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.checkedListBox_0);
		base.Controls.Add(this.groupBox_0);
		base.Controls.Add(this.chart_0);
		base.Controls.Add(this.listView_0);
		base.Controls.Add(this.toolStrip_0);
		base.DockAreas = 32;
		this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		this.MinimumSize = new Size(1175, 541);
		base.Name = "FormTelemetryChart";
		this.Text = "FormTelemetryChart";
		this.toolStrip_0.ResumeLayout(false);
		this.toolStrip_0.PerformLayout();
		((ISupportInitialize)this.chart_0).EndInit();
		this.groupBox_0.ResumeLayout(false);
		this.groupBox_0.PerformLayout();
		this.contextMenuStrip_0.ResumeLayout(false);
		this.groupBox_1.ResumeLayout(false);
		this.groupBox_1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private bool method_19(Series series_1)
	{
		return series_1.Tag == this.list_0 && series_1.ChartType == SeriesChartType.StepLine;
	}

	[CompilerGenerated]
	private bool method_20(Series series_1)
	{
		return series_1.Tag == this.list_0 && series_1.ChartType == SeriesChartType.StepLine;
	}

	[CompilerGenerated]
	private bool method_21(Series series_1)
	{
		return series_1.Tag == this.list_0 && series_1.ChartArea != string.Empty;
	}

	internal static void dNNNjuPJZlhZuPttKKD(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private Dictionary<DrawObjectBase, Series> dictionary_0;

	private Dictionary<Class13.Class14, ChartArea> dictionary_1;

	private Stack<Color> stack_0;

	private List<DrawObjectBase> list_0;

	private Series series_0;

	internal int int_0;

	private IContainer icontainer_0;

	private ToolStrip toolStrip_0;

	private Chart chart_0;

	private GroupBox groupBox_0;

	private DateTimePicker dateTimePicker_0;

	private DateTimePicker dateTimePicker_1;

	private ToolStripButton toolStripButton_0;

	private CheckedListBox checkedListBox_0;

	private Label label_0;

	private Label label_1;

	private ContextMenuStrip contextMenuStrip_0;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ListView listView_0;

	private ColumnHeader columnHeader_0;

	private ToolStripSeparator toolStripSeparator_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private PrintDocument printDocument_0;

	private PrintDialog printDialog_0;

	private PrintPreviewDialog printPreviewDialog_0;

	private ToolStripButton toolStripButton_3;

	private PageSetupDialog pageSetupDialog_0;

	private GroupBox groupBox_1;

	private CheckBox checkBox_0;

	private Button button_0;

	private Button button_1;

	private ListView listView_1;

	private ColumnHeader columnHeader_1;

	private ComboBox comboBox_0;

	private class Class14
	{
		public Class14(int int_1, string string_1)
		{
			Class63.AGd1PxHzk5wxP();
			base..ctor();
			this.Id = int_1;
			this.Description = string_1;
		}

		public int Id { get; set; }

		public string Description { get; set; }

		public override string ToString()
		{
			return this.Description;
		}

		public object[,] method_0(SQLSettings sqlsettings_0, List<DrawObjectBase> list_0, DateTime dateTime_0, DateTime dateTime_1)
		{
			List<object[,]> list = new List<object[,]>();
			string text = string.Empty;
			foreach (DrawObjectBase drawObjectBase_ in list_0)
			{
				list.Add(this.method_1(sqlsettings_0, drawObjectBase_, dateTime_0, dateTime_1));
			}
			if (list.Count > 0)
			{
				text = list[0][0, 1].ToString();
			}
			List<DateTime> list2 = new List<DateTime>();
			List<double> list3 = new List<double>();
			foreach (object[,] array in list)
			{
				for (int i = 1; i < array.Length / 2; i++)
				{
					if (list2.Count == 0)
					{
						list2.Add((DateTime)array[i, 0]);
						list3.Add((double)array[i, 1]);
					}
					else if (!list2.Contains((DateTime)array[i, 0], new Class13.Class16()))
					{
						bool flag = false;
						int j = 0;
						while (j < list2.Count)
						{
							if (!(list2[j] > (DateTime)array[i, 0]))
							{
								j++;
							}
							else
							{
								list2.Insert(j, (DateTime)array[i, 0]);
								flag = true;
								IL_13A:
								if (!flag)
								{
									list2.Add((DateTime)array[i, 0]);
									goto IL_153;
								}
								goto IL_153;
							}
						}
						goto IL_13A;
					}
					IL_153:;
				}
			}
			object[,] array2 = new object[list2.Count + 1, 2];
			array2[0, 0] = "Дата";
			array2[0, 1] = text;
			for (int k = 1; k < array2.Length / 2; k++)
			{
				array2[k, 0] = list2[k - 1];
			}
			for (int l = 1; l < array2.Length / 2; l++)
			{
				DateTime t = (DateTime)array2[l, 0];
				foreach (object[,] array3 in list)
				{
					int m = 1;
					while (m < array3.Length / 2)
					{
						DateTime t2 = (DateTime)array3[m, 0];
						if (t.Year == t2.Year && t.Month == t2.Month && t.Day == t2.Day && t.Hour == t2.Hour && t.Minute == t2.Minute)
						{
							if (array2[l, 1] == null)
							{
								array2[l, 1] = (double)array3[m, 1];
								break;
							}
							array2[l, 1] = (double)array2[l, 1] + (double)array3[m, 1];
							break;
						}
						else if (!(t2 > t))
						{
							m++;
						}
						else
						{
							if (m <= 1)
							{
								break;
							}
							if (array2[l, 1] == null)
							{
								array2[l, 1] = (double)array3[m - 1, 1];
								break;
							}
							array2[l, 1] = (double)array2[l, 1] + (double)array3[m - 1, 1];
							break;
						}
					}
				}
			}
			return array2;
		}

		internal object[,] method_1(SQLSettings sqlsettings_0, DrawObjectBase drawObjectBase_0, DateTime dateTime_0, DateTime dateTime_1)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			DataTable dataTable = new DataTable();
			using (SqlConnection sqlConnection = new SqlConnection(sqlsettings_0.GetConnectionString()))
			{
				try
				{
					string text3 = string.Concat(new object[]
					{
						"SELECT [ItemName]\r\n                                        ,[pDescription]\r\n                                        ,[Measure]\r\n                               FROM [OPC_Config].[dbo].[vParametersTags]\r\n                               WHERE [ObjectId] = ",
						drawObjectBase_0.IdBase,
						" and [ParameterId] = ",
						this.Id
					});
					SqlCommand sqlCommand = new SqlCommand(text3, sqlConnection);
					sqlConnection.Open();
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					if (sqlDataReader.Read())
					{
						text = sqlDataReader[0].ToString();
						text2 = sqlDataReader[1].ToString() + "(" + sqlDataReader[2].ToString() + ")";
					}
					sqlDataReader.Close();
					text3 = string.Concat(new string[]
					{
						"SELECT [Value]\r\n                                  ,[DateIns]\r\n                              FROM [OPC_Log].[dbo].[OpcDataLog]\r\n                              WHERE [ItemName] like '",
						text,
						"' and [DateIns] > '",
						dateTime_0.ToString("yyyyMMdd"),
						"' and [DateIns] < '",
						dateTime_1.ToString("yyyyMMdd"),
						"' \r\n                              ORDER BY [DateIns]"
					});
					sqlCommand.CommandText = text3;
					sqlDataReader = sqlCommand.ExecuteReader();
					dataTable.Load(sqlDataReader);
					sqlConnection.Close();
				}
				catch
				{
				}
			}
			object[,] array = new object[dataTable.Rows.Count + 1, 2];
			array[0, 0] = "Дата";
			array[0, 1] = text2;
			int num = 1;
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				array[num, 0] = Convert.ToDateTime(dataRow[1]);
				array[num, 1] = Convert.ToDouble(dataRow[0], new CultureInfo(1033));
				num++;
			}
			return array;
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;
	}

	private class Class15
	{
		public IEnumerable<DrawObjectBase> method_0()
		{
			return this.list_0;
		}

		public void method_1(DrawObjectBase drawObjectBase_0)
		{
			this.list_0.Add(drawObjectBase_0);
		}

		public Class15()
		{
			Class63.AGd1PxHzk5wxP();
			this.list_0 = new List<DrawObjectBase>();
			base..ctor();
		}

		private List<DrawObjectBase> list_0;
	}

	private class Class16 : IEqualityComparer<DateTime>
	{
		bool IEqualityComparer<DateTime>.Equals(DateTime x, DateTime y)
		{
			return x.Year == y.Year && x.Month == y.Month && x.Day == y.Day && x.Hour == y.Hour && x.Minute == y.Minute;
		}

		int IEqualityComparer<DateTime>.GetHashCode(DateTime obj)
		{
			return obj.GetHashCode();
		}

		public Class16()
		{
			Class63.AGd1PxHzk5wxP();
			base..ctor();
		}
	}
}
