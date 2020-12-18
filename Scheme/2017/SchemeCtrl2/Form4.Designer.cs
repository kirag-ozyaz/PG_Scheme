using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using FormLbr;
using Passport.Classes;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;
using SchemeCtrl2.Properties;

internal class Form4 : FormBase
{
	internal CanvasControl Canvas
	{
		get
		{
			return this.canvasControl_0;
		}
		set
		{
			this.canvasControl_0 = value;
			this.SqlSettings = this.canvasControl_0.SqlSettings;
		}
	}

	internal Form4()
	{
		Class90.TDroV38zslI2T();
		this.printerSettings_0 = new PrinterSettings();
		this.timer_0 = new Timer();
		base..ctor();
		this.method_6();
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		if (this.canvasControl_0 != null)
		{
			if (this.canvasControl_0.SelectedCount > 0)
			{
				this.canvasControl_0.enum4_0 = (Enum4)0;
			}
			if (this.canvasControl_0.eCommandType_0 == eCommandType.frame)
			{
				this.canvasControl_0.enum4_0 = (Enum4)3;
			}
			this.printPreviewControl_0.Document = this.canvasControl_0.printDocument;
			this.method_4(this.printPreviewControl_0.Document.PrinterSettings);
			this.checkBox_0.Checked = this.canvasControl_0.isPrintFrame;
			this.numericUpDown_1.Value = this.canvasControl_0.PagesHeigth;
			this.numericUpDown_0.Value = this.canvasControl_0.PagesWidth;
			switch (this.canvasControl_0.enum4_0)
			{
			case (Enum4)0:
				this.radioButton_0.Checked = true;
				break;
			case (Enum4)1:
				this.radioButton_1.Checked = true;
				break;
			case (Enum4)2:
				this.radioButton_2.Checked = true;
				break;
			case (Enum4)3:
				this.radioButton_3.Checked = true;
				break;
			}
			if (this.canvasControl_0.TypeCanvas == eTypeCanvas.SchemeSecond)
			{
				foreach (ICanvasLayer canvasLayer in this.canvasControl_0.Layers)
				{
					foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects)
					{
						if (drawObjectBase is RectangleTool)
						{
							this.textBox_1.Text = drawObjectBase.ToString();
							DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, drawObjectBase.GetTypeObject(), "where ol.id = " + drawObjectBase.IdBase.ToString(), true);
							if (equipmentData != null && equipmentData.Rows.Count > 0)
							{
								this.textBox_2.Text = string.Format("Владелец-{0};Адрес-{1} {2}", equipmentData.Rows[0]["Владелец"], equipmentData.Rows[0]["Улица"], equipmentData.Rows[0]["Дом"]);
								break;
							}
							break;
						}
					}
				}
			}
		}
		foreach (object obj in PrinterSettings.InstalledPrinters)
		{
			string text = (string)obj;
			this.comboBox_0.Items.Add(text.ToString());
			if (new PrinterSettings
			{
				PrinterName = text.ToString()
			}.IsDefaultPrinter)
			{
				this.printerSettings_0.PrinterName = text.ToString();
				this.comboBox_0.SelectedIndex = this.comboBox_0.Items.Count - 1;
			}
		}
		this.printPreviewControl_0.AutoZoom = true;
		this.method_1();
		base.LoadFormConfig(null);
		if (string.IsNullOrEmpty(this.textBox_0.Text))
		{
			DataTable dataTable = base.SelectSqlData("vAbnType", true, "where typeKontragent = 1115");
			if (dataTable.Rows.Count > 0 && !dataTable.Rows[0].IsNull("Name"))
			{
				this.textBox_0.Text = dataTable.Rows[0]["Name"].ToString();
			}
		}
	}

	private void Form4_FormClosing(object sender, FormClosingEventArgs e)
	{
		base.SaveFormConfig(null);
	}

	private DataTable method_0()
	{
		DataTable dataTable = new DataTable("vWorkerGroup");
		DataColumn dataColumn = new DataColumn("id", Type.GetType("System.Int32"));
		dataTable.Columns.Add(dataColumn);
		DataColumn column = new DataColumn("fio", Type.GetType("System.String"));
		dataTable.Columns.Add(column);
		dataTable.PrimaryKey = new DataColumn[]
		{
			dataColumn
		};
		return dataTable;
	}

	private void method_1()
	{
		this.comboBox_7.SelectedIndex = 0;
		DataTable dataTable = this.method_0();
		base.SelectSqlData(dataTable, true, " where ParentKey in (';GroupWorker;ITR;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
		this.comboBox_1.DataSource = dataTable;
		this.comboBox_1.DisplayMember = "FIO";
		this.comboBox_1.ValueMember = "ID";
		this.comboBox_1.SelectedIndex = -1;
		this.comboBox_6.SelectedIndex = 0;
		DataTable dataTable2 = this.method_0();
		base.SelectSqlData(dataTable2, true, " where ParentKey in (';GroupWorker;ITR;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
		this.comboBox_5.DataSource = dataTable2;
		this.comboBox_5.DisplayMember = "FIO";
		this.comboBox_5.ValueMember = "ID";
		this.comboBox_5.SelectedIndex = -1;
		DataTable dataTable3 = this.method_0();
		base.SelectSqlData(dataTable3, true, " where ParentKey in (';GroupWorker;MasterNetRegion;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
		this.comboBox_3.DataSource = dataTable3;
		this.comboBox_3.DisplayMember = "FIO";
		this.comboBox_3.ValueMember = "ID";
		this.comboBox_3.SelectedIndex = -1;
		this.comboBox_8.SelectedIndex = 0;
		DataTable dataTable4 = this.method_0();
		base.SelectSqlData(dataTable4, true, " where ParentKey in (';GroupWorker;HeadRegion;')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
		this.comboBox_2.DataSource = dataTable4;
		this.comboBox_2.DisplayMember = "FIO";
		this.comboBox_2.ValueMember = "ID";
		this.comboBox_2.SelectedIndex = -1;
		this.comboBox_10.SelectedIndex = -1;
		DataTable dataTable5 = this.method_0();
		base.SelectSqlData(dataTable5, true, " where dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
		this.comboBox_9.DataSource = dataTable5;
		this.comboBox_9.DisplayMember = "FIO";
		this.comboBox_9.ValueMember = "ID";
		this.comboBox_9.SelectedIndex = -1;
		this.timer_0.Tick += this.timer_0_Tick;
		this.timer_0.Interval = 5000;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.method_2();
		this.timer_0.Stop();
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.timer_0.Stop();
		this.method_2();
	}

	private void method_2()
	{
		this.canvasControl_0.WorkerPrint = new WorkerCanvasPrint();
		this.canvasControl_0.WorkerPrint.Electrician = new WorkerTitleFIO(this.comboBox_7.Text, this.comboBox_1.Text);
		this.canvasControl_0.WorkerPrint.Technician = new WorkerTitleFIO(this.comboBox_6.Text, this.comboBox_5.Text);
		this.canvasControl_0.WorkerPrint.Master = new WorkerTitleFIO(this.comboBox_4.Text, this.comboBox_3.Text);
		this.canvasControl_0.WorkerPrint.ChiefDistrict = new WorkerTitleFIO(this.comboBox_8.Text, this.comboBox_2.Text);
		this.canvasControl_0.WorkerPrint.ZamChief = new WorkerTitleFIO(this.comboBox_10.Text, this.comboBox_9.Text);
		this.canvasControl_0.method_81(this.textBox_0.Text);
		this.canvasControl_0.method_83(this.textBox_1.Text);
		this.canvasControl_0.method_85(this.textBox_2.Text);
		this.printPreviewControl_0.InvalidatePreview();
	}

	private void comboBox_1_TextUpdate(object sender, EventArgs e)
	{
		this.timer_0.Stop();
		this.timer_0.Start();
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.printerSettings_0 = this.printPreviewControl_0.Document.PrinterSettings;
		if (this.comboBox_0.SelectedIndex >= 0)
		{
			this.printerSettings_0.PrinterName = this.comboBox_0.SelectedItem.ToString();
			this.label_1.Text = (this.printerSettings_0.IsValid ? "Готов" : "Не готов");
		}
		else
		{
			this.printerSettings_0 = new PrinterSettings();
		}
		this.printPreviewControl_0.Document.PrinterSettings = this.printerSettings_0;
		this.method_4(this.printerSettings_0);
	}

	private void printPreviewControl_0_Resize(object sender, EventArgs e)
	{
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (this.canvasControl_0 != null)
		{
			this.canvasControl_0.printDocument.Print();
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GlobalLock(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	private static extern bool GlobalUnlock(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	private static extern bool GlobalFree(IntPtr intptr_0);

	[DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
	private static extern int DocumentPropertiesW(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] string string_0, IntPtr intptr_2, IntPtr intptr_3, int int_0);

	private DialogResult method_3(PrinterSettings printerSettings_1)
	{
		DialogResult result = DialogResult.Cancel;
		IntPtr hdevmode = printerSettings_1.GetHdevmode(printerSettings_1.DefaultPageSettings);
		IntPtr intPtr = Form4.GlobalLock(hdevmode);
		IntPtr intPtr2 = Marshal.AllocHGlobal(Form4.DocumentPropertiesW(base.Handle, IntPtr.Zero, printerSettings_1.PrinterName, intPtr, intPtr, 0));
		if ((long)Form4.DocumentPropertiesW(base.Handle, IntPtr.Zero, printerSettings_1.PrinterName, intPtr2, intPtr, 14) == 1L)
		{
			result = DialogResult.OK;
			printerSettings_1.SetHdevmode(intPtr2);
			printerSettings_1.DefaultPageSettings.SetHdevmode(intPtr2);
			this.printPreviewControl_0.Document.PrinterSettings = printerSettings_1;
			this.method_4(printerSettings_1);
		}
		Form4.GlobalUnlock(hdevmode);
		Form4.GlobalFree(hdevmode);
		Marshal.FreeHGlobal(intPtr2);
		return result;
	}

	private void method_4(PrinterSettings printerSettings_1)
	{
		this.printPreviewControl_0.InvalidatePreview();
		this.printPreviewControl_0.Refresh();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		this.method_3(this.printerSettings_0);
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		this.groupBox_2.Enabled = this.checkBox_0.Checked;
		if (this.canvasControl_0 != null)
		{
			this.canvasControl_0.isPrintFrame = this.checkBox_0.Checked;
			this.method_4(this.printerSettings_0);
		}
	}

	private void radioButton_2_CheckedChanged(object sender, EventArgs e)
	{
		this.canvasControl_0.enum4_0 = (Enum4)2;
		this.method_4(this.printerSettings_0);
	}

	private void radioButton_1_CheckedChanged(object sender, EventArgs e)
	{
		this.canvasControl_0.enum4_0 = (Enum4)1;
		this.method_4(this.printerSettings_0);
	}

	private void radioButton_0_CheckedChanged(object sender, EventArgs e)
	{
		this.canvasControl_0.enum4_0 = (Enum4)0;
		this.method_4(this.printerSettings_0);
	}

	private void radioButton_3_CheckedChanged(object sender, EventArgs e)
	{
		this.canvasControl_0.enum4_0 = (Enum4)3;
		this.method_4(this.printerSettings_0);
	}

	private void numericUpDown_1_ValueChanged(object sender, EventArgs e)
	{
		this.canvasControl_0.PagesHeigth = Convert.ToInt32(this.numericUpDown_1.Value);
		this.printPreviewControl_0.Rows = this.canvasControl_0.PagesHeigth;
		this.method_4(this.printerSettings_0);
	}

	private void numericUpDown_0_ValueChanged(object sender, EventArgs e)
	{
		this.canvasControl_0.PagesWidth = Convert.ToInt32(this.numericUpDown_0.Value);
		this.printPreviewControl_0.Columns = this.canvasControl_0.PagesWidth;
		this.method_4(this.printerSettings_0);
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		this.pageSetupDialog_0.Document = this.printPreviewControl_0.Document;
		this.pageSetupDialog_0.ShowDialog();
		this.method_4(this.printerSettings_0);
	}

	private void toolStripSplitButton_0_DropDownOpening(object sender, EventArgs e)
	{
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		this.method_5((ToolStripMenuItem)sender);
		this.printPreviewControl_0.AutoZoom = true;
	}

	private void toolStripMenuItem_9_Click(object sender, EventArgs e)
	{
		this.method_5((ToolStripMenuItem)sender);
		this.printPreviewControl_0.AutoZoom = false;
		this.printPreviewControl_0.Zoom = (double)((float)Convert.ToInt32(((ToolStripMenuItem)sender).Text) / 100f);
	}

	private void method_5(ToolStripMenuItem toolStripMenuItem_10)
	{
		foreach (object obj in this.toolStripSplitButton_0.DropDownItems)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
			if (toolStripMenuItem_10 == null || toolStripMenuItem_10 != toolStripMenuItem)
			{
				toolStripMenuItem.Checked = false;
			}
		}
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		this.timer_0.Stop();
		this.timer_0.Start();
	}

	protected override XmlDocument CreateXmlConfig()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
		xmlDocument.AppendChild(newChild);
		XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
		xmlDocument.AppendChild(xmlNode);
		XmlNode xmlNode2 = xmlDocument.CreateElement("PrintSettings");
		xmlNode.AppendChild(xmlNode2);
		XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("IsPrintFrame");
		xmlAttribute.Value = this.checkBox_0.Checked.ToString();
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute(this.comboBox_7.Name);
		xmlAttribute.Value = this.comboBox_7.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute(this.comboBox_1.Name);
		xmlAttribute.Value = this.comboBox_1.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute(this.comboBox_6.Name);
		xmlAttribute.Value = this.comboBox_6.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute(this.comboBox_5.Name);
		xmlAttribute.Value = this.comboBox_5.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute(this.comboBox_4.Name);
		xmlAttribute.Value = this.comboBox_4.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute(this.comboBox_3.Name);
		xmlAttribute.Value = this.comboBox_3.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute(this.comboBox_8.Name);
		xmlAttribute.Value = this.comboBox_8.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute(this.comboBox_2.Name);
		xmlAttribute.Value = this.comboBox_2.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute(this.comboBox_10.Name);
		xmlAttribute.Value = this.comboBox_10.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute(this.comboBox_9.Name);
		xmlAttribute.Value = this.comboBox_9.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute(this.textBox_0.Name);
		xmlAttribute.Value = this.textBox_0.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("PageOrientation");
		xmlAttribute.Value = this.printPreviewControl_0.Document.DefaultPageSettings.Landscape.ToString();
		xmlNode2.Attributes.Append(xmlAttribute);
		XmlNode xmlNode3 = xmlDocument.CreateElement("MarginsDocument");
		xmlNode2.AppendChild(xmlNode3);
		xmlAttribute = xmlDocument.CreateAttribute("Left");
		xmlAttribute.Value = this.printPreviewControl_0.Document.DefaultPageSettings.Margins.Left.ToString();
		xmlNode3.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Right");
		xmlAttribute.Value = this.printPreviewControl_0.Document.DefaultPageSettings.Margins.Right.ToString();
		xmlNode3.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Top");
		xmlAttribute.Value = this.printPreviewControl_0.Document.DefaultPageSettings.Margins.Top.ToString();
		xmlNode3.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Bottom");
		xmlAttribute.Value = this.printPreviewControl_0.Document.DefaultPageSettings.Margins.Bottom.ToString();
		xmlNode3.Attributes.Append(xmlAttribute);
		return xmlDocument;
	}

	protected override void ApplyConfig(XmlDocument xmlDocument_0)
	{
		XmlNode xmlNode = xmlDocument_0.SelectSingleNode(base.Name);
		if (xmlNode != null)
		{
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("PrintSettings");
			if (xmlNode2 != null)
			{
				XmlAttribute xmlAttribute = xmlNode2.Attributes["IsPrintFrame"];
				if (xmlAttribute != null)
				{
					this.checkBox_0.Checked = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = xmlNode2.Attributes[this.comboBox_7.Name];
				if (xmlAttribute != null)
				{
					this.comboBox_7.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode2.Attributes[this.comboBox_1.Name];
				if (xmlAttribute != null)
				{
					this.comboBox_1.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode2.Attributes[this.comboBox_6.Name];
				if (xmlAttribute != null)
				{
					this.comboBox_6.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode2.Attributes[this.comboBox_5.Name];
				if (xmlAttribute != null)
				{
					this.comboBox_5.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode2.Attributes[this.comboBox_4.Name];
				if (xmlAttribute != null)
				{
					this.comboBox_4.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode2.Attributes[this.comboBox_3.Name];
				if (xmlAttribute != null)
				{
					this.comboBox_3.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode2.Attributes[this.comboBox_8.Name];
				if (xmlAttribute != null)
				{
					this.comboBox_8.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode2.Attributes[this.comboBox_2.Name];
				if (xmlAttribute != null)
				{
					this.comboBox_2.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode2.Attributes[this.comboBox_10.Name];
				if (xmlAttribute != null)
				{
					this.comboBox_10.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode2.Attributes[this.comboBox_9.Name];
				if (xmlAttribute != null)
				{
					this.comboBox_9.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode2.Attributes[this.textBox_0.Name];
				if (xmlAttribute != null)
				{
					this.textBox_0.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode2.Attributes["PageOrientation"];
				if (xmlAttribute != null)
				{
					this.printPreviewControl_0.Document.DefaultPageSettings.Landscape = Convert.ToBoolean(xmlAttribute.Value);
				}
				XmlNode xmlNode3 = xmlNode2.SelectSingleNode("MarginsDocument");
				if (xmlNode3 != null)
				{
					xmlAttribute = xmlNode3.Attributes["Left"];
					if (xmlAttribute != null)
					{
						this.printPreviewControl_0.Document.DefaultPageSettings.Margins.Left = Convert.ToInt32(xmlAttribute.Value);
					}
					xmlAttribute = xmlNode3.Attributes["Top"];
					if (xmlAttribute != null)
					{
						this.printPreviewControl_0.Document.DefaultPageSettings.Margins.Top = Convert.ToInt32(xmlAttribute.Value);
					}
					xmlAttribute = xmlNode3.Attributes["Right"];
					if (xmlAttribute != null)
					{
						this.printPreviewControl_0.Document.DefaultPageSettings.Margins.Right = Convert.ToInt32(xmlAttribute.Value);
					}
					xmlAttribute = xmlNode3.Attributes["Bottom"];
					if (xmlAttribute != null)
					{
						this.printPreviewControl_0.Document.DefaultPageSettings.Margins.Bottom = Convert.ToInt32(xmlAttribute.Value);
					}
				}
			}
		}
	}

	private void checkBox_1_CheckedChanged(object sender, EventArgs e)
	{
		if (this.canvasControl_0 != null)
		{
			this.canvasControl_0.bool_11 = this.checkBox_1.Checked;
			this.method_4(this.printerSettings_0);
		}
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(bool_0);
	}

	private void method_6()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form4));
		this.printPreviewControl_0 = new PrintPreviewControl();
		this.printDocument_0 = new PrintDocument();
		this.pageSetupDialog_0 = new PageSetupDialog();
		this.printDialog_0 = new PrintDialog();
		this.button_0 = new Button();
		this.groupBox_0 = new GroupBox();
		this.button_1 = new Button();
		this.label_1 = new Label();
		this.label_2 = new Label();
		this.label_0 = new Label();
		this.comboBox_0 = new ComboBox();
		this.checkBox_0 = new CheckBox();
		this.groupBox_1 = new GroupBox();
		this.radioButton_3 = new RadioButton();
		this.radioButton_0 = new RadioButton();
		this.radioButton_1 = new RadioButton();
		this.radioButton_2 = new RadioButton();
		this.button_2 = new Button();
		this.button_3 = new Button();
		this.toolStrip_0 = new ToolStrip();
		this.toolStripSplitButton_0 = new ToolStripSplitButton();
		this.toolStripMenuItem_0 = new ToolStripMenuItem();
		this.toolStripMenuItem_1 = new ToolStripMenuItem();
		this.toolStripMenuItem_2 = new ToolStripMenuItem();
		this.toolStripMenuItem_3 = new ToolStripMenuItem();
		this.toolStripMenuItem_4 = new ToolStripMenuItem();
		this.toolStripMenuItem_5 = new ToolStripMenuItem();
		this.toolStripMenuItem_6 = new ToolStripMenuItem();
		this.toolStripMenuItem_7 = new ToolStripMenuItem();
		this.toolStripMenuItem_8 = new ToolStripMenuItem();
		this.toolStripMenuItem_9 = new ToolStripMenuItem();
		this.groupBox_2 = new GroupBox();
		this.textBox_2 = new TextBox();
		this.label_7 = new Label();
		this.textBox_1 = new TextBox();
		this.label_4 = new Label();
		this.comboBox_9 = new ComboBox();
		this.comboBox_10 = new ComboBox();
		this.comboBox_8 = new ComboBox();
		this.comboBox_7 = new ComboBox();
		this.textBox_0 = new TextBox();
		this.label_3 = new Label();
		this.comboBox_2 = new ComboBox();
		this.comboBox_3 = new ComboBox();
		this.comboBox_4 = new ComboBox();
		this.comboBox_5 = new ComboBox();
		this.comboBox_6 = new ComboBox();
		this.comboBox_1 = new ComboBox();
		this.checkBox_1 = new CheckBox();
		this.groupBox_3 = new GroupBox();
		this.numericUpDown_0 = new NumericUpDown();
		this.numericUpDown_1 = new NumericUpDown();
		this.label_5 = new Label();
		this.label_6 = new Label();
		this.groupBox_0.SuspendLayout();
		this.groupBox_1.SuspendLayout();
		this.toolStrip_0.SuspendLayout();
		this.groupBox_2.SuspendLayout();
		this.groupBox_3.SuspendLayout();
		((ISupportInitialize)this.numericUpDown_0).BeginInit();
		((ISupportInitialize)this.numericUpDown_1).BeginInit();
		base.SuspendLayout();
		this.printPreviewControl_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.printPreviewControl_0.AutoZoom = false;
		this.printPreviewControl_0.Document = this.printDocument_0;
		this.printPreviewControl_0.Location = new Point(314, 26);
		this.printPreviewControl_0.Name = "printPreviewControl";
		this.printPreviewControl_0.Size = new Size(535, 568);
		this.printPreviewControl_0.TabIndex = 0;
		this.printPreviewControl_0.UseAntiAlias = true;
		this.printPreviewControl_0.Zoom = 0.46364414029084688;
		this.printPreviewControl_0.Resize += this.printPreviewControl_0_Resize;
		this.printDocument_0.DocumentName = "Scheme";
		this.pageSetupDialog_0.Document = this.printDocument_0;
		this.pageSetupDialog_0.EnableMetric = true;
		this.printDialog_0.Document = this.printDocument_0;
		this.printDialog_0.UseEXDialog = true;
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.button_0.Location = new Point(12, 562);
		this.button_0.Name = "buttonPrint";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 1;
		this.button_0.Text = "Печать";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_0_Click;
		this.groupBox_0.Controls.Add(this.button_1);
		this.groupBox_0.Controls.Add(this.label_1);
		this.groupBox_0.Controls.Add(this.label_2);
		this.groupBox_0.Controls.Add(this.label_0);
		this.groupBox_0.Controls.Add(this.comboBox_0);
		this.groupBox_0.Location = new Point(12, 0);
		this.groupBox_0.Name = "groupBoxPrinter";
		this.groupBox_0.Size = new Size(296, 98);
		this.groupBox_0.TabIndex = 3;
		this.groupBox_0.TabStop = false;
		this.groupBox_0.Text = "Принтер";
		this.button_1.Location = new Point(14, 71);
		this.button_1.Name = "buttonPrinterSettings";
		this.button_1.Size = new Size(117, 23);
		this.button_1.TabIndex = 10;
		this.button_1.Text = "Свойства принтера";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.label_1.Location = new Point(94, 52);
		this.label_1.Name = "labelPrinterStatus";
		this.label_1.Size = new Size(178, 13);
		this.label_1.TabIndex = 6;
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(11, 52);
		this.label_2.Name = "label2";
		this.label_2.Size = new Size(44, 13);
		this.label_2.TabIndex = 2;
		this.label_2.Text = "Статус:";
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(11, 22);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(32, 13);
		this.label_0.TabIndex = 1;
		this.label_0.Text = "Имя:";
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(97, 19);
		this.comboBox_0.Name = "cmbPrinters";
		this.comboBox_0.Size = new Size(175, 21);
		this.comboBox_0.TabIndex = 0;
		this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
		this.checkBox_0.AutoSize = true;
		this.checkBox_0.Location = new Point(12, 258);
		this.checkBox_0.Name = "checkBoxPrintFrame";
		this.checkBox_0.Size = new Size(97, 17);
		this.checkBox_0.TabIndex = 4;
		this.checkBox_0.Text = "Печать рамки";
		this.checkBox_0.UseVisualStyleBackColor = true;
		this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
		this.groupBox_1.Controls.Add(this.radioButton_3);
		this.groupBox_1.Controls.Add(this.radioButton_0);
		this.groupBox_1.Controls.Add(this.radioButton_1);
		this.groupBox_1.Controls.Add(this.radioButton_2);
		this.groupBox_1.Location = new Point(12, 125);
		this.groupBox_1.Name = "groupBoxPrintType";
		this.groupBox_1.Size = new Size(144, 116);
		this.groupBox_1.TabIndex = 5;
		this.groupBox_1.TabStop = false;
		this.groupBox_1.Text = "Печатать";
		this.radioButton_3.AutoSize = true;
		this.radioButton_3.Location = new Point(6, 88);
		this.radioButton_3.Name = "radioButtonPrintFrame";
		this.radioButton_3.Size = new Size(51, 17);
		this.radioButton_3.TabIndex = 3;
		this.radioButton_3.TabStop = true;
		this.radioButton_3.Text = "Окно";
		this.radioButton_3.UseVisualStyleBackColor = true;
		this.radioButton_3.CheckedChanged += this.radioButton_3_CheckedChanged;
		this.radioButton_0.AutoSize = true;
		this.radioButton_0.Location = new Point(6, 65);
		this.radioButton_0.Name = "radioButtonPrintSelected";
		this.radioButton_0.Size = new Size(137, 17);
		this.radioButton_0.TabIndex = 2;
		this.radioButton_0.TabStop = true;
		this.radioButton_0.Text = "Выделенные объекты";
		this.radioButton_0.UseVisualStyleBackColor = true;
		this.radioButton_0.CheckedChanged += this.radioButton_0_CheckedChanged;
		this.radioButton_1.AutoSize = true;
		this.radioButton_1.Location = new Point(6, 42);
		this.radioButton_1.Name = "radioButtonPrintAll";
		this.radioButton_1.Size = new Size(91, 17);
		this.radioButton_1.TabIndex = 1;
		this.radioButton_1.TabStop = true;
		this.radioButton_1.Text = "Все объекты";
		this.radioButton_1.UseVisualStyleBackColor = true;
		this.radioButton_1.CheckedChanged += this.radioButton_1_CheckedChanged;
		this.radioButton_2.AutoSize = true;
		this.radioButton_2.Location = new Point(6, 19);
		this.radioButton_2.Name = "radioButtonPrintScreen";
		this.radioButton_2.Size = new Size(56, 17);
		this.radioButton_2.TabIndex = 0;
		this.radioButton_2.TabStop = true;
		this.radioButton_2.Text = "Экран";
		this.radioButton_2.UseVisualStyleBackColor = true;
		this.radioButton_2.CheckedChanged += this.radioButton_2_CheckedChanged;
		this.button_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.button_2.DialogResult = DialogResult.Cancel;
		this.button_2.Location = new Point(227, 562);
		this.button_2.Name = "buttonClose";
		this.button_2.Size = new Size(75, 23);
		this.button_2.TabIndex = 6;
		this.button_2.Text = "Закрыть";
		this.button_2.UseVisualStyleBackColor = true;
		this.button_2.Click += this.button_2_Click;
		this.button_3.Location = new Point(12, 531);
		this.button_3.Name = "buttonPageSettings";
		this.button_3.Size = new Size(131, 23);
		this.button_3.TabIndex = 7;
		this.button_3.Text = "Настройка страницы";
		this.button_3.UseVisualStyleBackColor = true;
		this.button_3.Click += this.button_3_Click;
		this.toolStrip_0.Dock = DockStyle.None;
		this.toolStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripSplitButton_0
		});
		this.toolStrip_0.Location = new Point(314, 0);
		this.toolStrip_0.Name = "toolStrip1";
		this.toolStrip_0.Size = new Size(44, 25);
		this.toolStrip_0.TabIndex = 8;
		this.toolStrip_0.Text = "toolStrip1";
		this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripSplitButton_0.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.toolStripMenuItem_0,
			this.toolStripMenuItem_1,
			this.toolStripMenuItem_2,
			this.toolStripMenuItem_3,
			this.toolStripMenuItem_4,
			this.toolStripMenuItem_5,
			this.toolStripMenuItem_6,
			this.toolStripMenuItem_7,
			this.toolStripMenuItem_8,
			this.toolStripMenuItem_9
		});
		this.toolStripSplitButton_0.Image = Resources.Zoom;
		this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripSplitButton_0.Name = "toolBtnZoom";
		this.toolStripSplitButton_0.Size = new Size(32, 22);
		this.toolStripSplitButton_0.Text = "Масштаб";
		this.toolStripSplitButton_0.DropDownOpening += this.toolStripSplitButton_0_DropDownOpening;
		this.toolStripMenuItem_0.Checked = true;
		this.toolStripMenuItem_0.CheckOnClick = true;
		this.toolStripMenuItem_0.CheckState = CheckState.Checked;
		this.toolStripMenuItem_0.Name = "toolMenuZoomAuto";
		this.toolStripMenuItem_0.Size = new Size(100, 22);
		this.toolStripMenuItem_0.Text = "Авто";
		this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
		this.toolStripMenuItem_1.CheckOnClick = true;
		this.toolStripMenuItem_1.Name = "toolMenuZoom500";
		this.toolStripMenuItem_1.Size = new Size(100, 22);
		this.toolStripMenuItem_1.Text = "500";
		this.toolStripMenuItem_1.Click += this.toolStripMenuItem_9_Click;
		this.toolStripMenuItem_2.CheckOnClick = true;
		this.toolStripMenuItem_2.Name = "toolMenuZoom300";
		this.toolStripMenuItem_2.Size = new Size(100, 22);
		this.toolStripMenuItem_2.Text = "300";
		this.toolStripMenuItem_2.Click += this.toolStripMenuItem_9_Click;
		this.toolStripMenuItem_3.CheckOnClick = true;
		this.toolStripMenuItem_3.Name = "toolMenuZoom200";
		this.toolStripMenuItem_3.Size = new Size(100, 22);
		this.toolStripMenuItem_3.Text = "200";
		this.toolStripMenuItem_3.Click += this.toolStripMenuItem_9_Click;
		this.toolStripMenuItem_4.CheckOnClick = true;
		this.toolStripMenuItem_4.Name = "toolMenuZoom150";
		this.toolStripMenuItem_4.Size = new Size(100, 22);
		this.toolStripMenuItem_4.Text = "150";
		this.toolStripMenuItem_4.Click += this.toolStripMenuItem_9_Click;
		this.toolStripMenuItem_5.CheckOnClick = true;
		this.toolStripMenuItem_5.Name = "toolMenuZoom100";
		this.toolStripMenuItem_5.Size = new Size(100, 22);
		this.toolStripMenuItem_5.Text = "100";
		this.toolStripMenuItem_5.Click += this.toolStripMenuItem_9_Click;
		this.toolStripMenuItem_6.CheckOnClick = true;
		this.toolStripMenuItem_6.Name = "toolMenuZoom50";
		this.toolStripMenuItem_6.Size = new Size(100, 22);
		this.toolStripMenuItem_6.Text = "50";
		this.toolStripMenuItem_6.Click += this.toolStripMenuItem_9_Click;
		this.toolStripMenuItem_7.CheckOnClick = true;
		this.toolStripMenuItem_7.Name = "toolMenuZoom25";
		this.toolStripMenuItem_7.Size = new Size(100, 22);
		this.toolStripMenuItem_7.Text = "25";
		this.toolStripMenuItem_7.Click += this.toolStripMenuItem_9_Click;
		this.toolStripMenuItem_8.CheckOnClick = true;
		this.toolStripMenuItem_8.Name = "toolMenuZoom20";
		this.toolStripMenuItem_8.Size = new Size(100, 22);
		this.toolStripMenuItem_8.Text = "20";
		this.toolStripMenuItem_8.Click += this.toolStripMenuItem_9_Click;
		this.toolStripMenuItem_9.CheckOnClick = true;
		this.toolStripMenuItem_9.Name = "toolMenuZoom10";
		this.toolStripMenuItem_9.Size = new Size(100, 22);
		this.toolStripMenuItem_9.Text = "10";
		this.toolStripMenuItem_9.Click += this.toolStripMenuItem_9_Click;
		this.groupBox_2.Controls.Add(this.textBox_2);
		this.groupBox_2.Controls.Add(this.label_7);
		this.groupBox_2.Controls.Add(this.textBox_1);
		this.groupBox_2.Controls.Add(this.label_4);
		this.groupBox_2.Controls.Add(this.comboBox_9);
		this.groupBox_2.Controls.Add(this.comboBox_10);
		this.groupBox_2.Controls.Add(this.comboBox_8);
		this.groupBox_2.Controls.Add(this.comboBox_7);
		this.groupBox_2.Controls.Add(this.textBox_0);
		this.groupBox_2.Controls.Add(this.label_3);
		this.groupBox_2.Controls.Add(this.comboBox_2);
		this.groupBox_2.Controls.Add(this.comboBox_3);
		this.groupBox_2.Controls.Add(this.comboBox_4);
		this.groupBox_2.Controls.Add(this.comboBox_5);
		this.groupBox_2.Controls.Add(this.comboBox_6);
		this.groupBox_2.Controls.Add(this.comboBox_1);
		this.groupBox_2.Enabled = false;
		this.groupBox_2.Location = new Point(12, 281);
		this.groupBox_2.Name = "groupBoxFrame";
		this.groupBox_2.Size = new Size(296, 244);
		this.groupBox_2.TabIndex = 9;
		this.groupBox_2.TabStop = false;
		this.groupBox_2.Text = "Рамка";
		this.textBox_2.Location = new Point(117, 207);
		this.textBox_2.Name = "txtSchmComment";
		this.textBox_2.Size = new Size(173, 20);
		this.textBox_2.TabIndex = 15;
		this.textBox_2.TextChanged += this.textBox_0_TextChanged;
		this.label_7.AutoSize = true;
		this.label_7.Location = new Point(6, 210);
		this.label_7.Name = "label7";
		this.label_7.Size = new Size(77, 13);
		this.label_7.TabIndex = 14;
		this.label_7.Text = "Комментарий";
		this.textBox_1.Location = new Point(117, 181);
		this.textBox_1.Name = "txtSchmName";
		this.textBox_1.Size = new Size(173, 20);
		this.textBox_1.TabIndex = 15;
		this.textBox_1.TextChanged += this.textBox_0_TextChanged;
		this.label_4.AutoSize = true;
		this.label_4.Location = new Point(6, 184);
		this.label_4.Name = "label4";
		this.label_4.Size = new Size(65, 13);
		this.label_4.TabIndex = 14;
		this.label_4.Text = "Имя схемы";
		this.comboBox_9.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_9.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_9.FormattingEnabled = true;
		this.comboBox_9.Items.AddRange(new object[]
		{
			"техник",
			"инженер"
		});
		this.comboBox_9.Location = new Point(117, 46);
		this.comboBox_9.Name = "cmbZamChiefFIO";
		this.comboBox_9.Size = new Size(173, 21);
		this.comboBox_9.TabIndex = 13;
		this.comboBox_9.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.comboBox_9.TextUpdate += this.comboBox_1_TextUpdate;
		this.comboBox_10.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_10.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_10.FormattingEnabled = true;
		this.comboBox_10.Items.AddRange(new object[]
		{
			"техник",
			"инженер"
		});
		this.comboBox_10.Location = new Point(6, 46);
		this.comboBox_10.Name = "cmbZamChiefTitle";
		this.comboBox_10.Size = new Size(91, 21);
		this.comboBox_10.TabIndex = 12;
		this.comboBox_10.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.comboBox_10.TextUpdate += this.comboBox_1_TextUpdate;
		this.comboBox_8.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_8.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_8.FormattingEnabled = true;
		this.comboBox_8.Items.AddRange(new object[]
		{
			"Утв. нач. р-на"
		});
		this.comboBox_8.Location = new Point(6, 128);
		this.comboBox_8.Name = "cmbChiefDistrictTitle";
		this.comboBox_8.Size = new Size(91, 21);
		this.comboBox_8.TabIndex = 11;
		this.comboBox_8.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.comboBox_8.TextUpdate += this.comboBox_1_TextUpdate;
		this.comboBox_7.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_7.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_7.FormattingEnabled = true;
		this.comboBox_7.Items.AddRange(new object[]
		{
			"эл. монтер"
		});
		this.comboBox_7.Location = new Point(6, 19);
		this.comboBox_7.Name = "cmbElectricianTitle";
		this.comboBox_7.Size = new Size(91, 21);
		this.comboBox_7.TabIndex = 10;
		this.comboBox_7.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.comboBox_7.TextUpdate += this.comboBox_1_TextUpdate;
		this.textBox_0.Location = new Point(117, 155);
		this.textBox_0.Name = "textBoxOrg";
		this.textBox_0.Size = new Size(173, 20);
		this.textBox_0.TabIndex = 9;
		this.textBox_0.TextChanged += this.textBox_0_TextChanged;
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(6, 158);
		this.label_3.Name = "label3";
		this.label_3.Size = new Size(74, 13);
		this.label_3.TabIndex = 8;
		this.label_3.Text = "Организация";
		this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_2.FormattingEnabled = true;
		this.comboBox_2.Location = new Point(117, 128);
		this.comboBox_2.Name = "cmbChiefDistrict";
		this.comboBox_2.Size = new Size(173, 21);
		this.comboBox_2.TabIndex = 6;
		this.comboBox_2.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.comboBox_2.TextUpdate += this.comboBox_1_TextUpdate;
		this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_3.FormattingEnabled = true;
		this.comboBox_3.Items.AddRange(new object[]
		{
			"техник",
			"инженер"
		});
		this.comboBox_3.Location = new Point(117, 101);
		this.comboBox_3.Name = "cmbMasterFIO";
		this.comboBox_3.Size = new Size(173, 21);
		this.comboBox_3.TabIndex = 5;
		this.comboBox_3.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.comboBox_3.TextUpdate += this.comboBox_1_TextUpdate;
		this.comboBox_4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_4.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_4.FormattingEnabled = true;
		this.comboBox_4.Items.AddRange(new object[]
		{
			"Ст.мастер",
			"мастер"
		});
		this.comboBox_4.Location = new Point(6, 101);
		this.comboBox_4.Name = "cmbMasterTitle";
		this.comboBox_4.Size = new Size(91, 21);
		this.comboBox_4.TabIndex = 4;
		this.comboBox_4.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.comboBox_4.TextUpdate += this.comboBox_1_TextUpdate;
		this.comboBox_5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_5.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_5.FormattingEnabled = true;
		this.comboBox_5.Items.AddRange(new object[]
		{
			"техник",
			"инженер"
		});
		this.comboBox_5.Location = new Point(117, 73);
		this.comboBox_5.Name = "cmbTechnicalFIO";
		this.comboBox_5.Size = new Size(173, 21);
		this.comboBox_5.TabIndex = 3;
		this.comboBox_5.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.comboBox_5.TextUpdate += this.comboBox_1_TextUpdate;
		this.comboBox_6.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_6.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_6.FormattingEnabled = true;
		this.comboBox_6.Items.AddRange(new object[]
		{
			"техник",
			"инженер"
		});
		this.comboBox_6.Location = new Point(6, 73);
		this.comboBox_6.Name = "cmbTechnicalTitle";
		this.comboBox_6.Size = new Size(91, 21);
		this.comboBox_6.TabIndex = 2;
		this.comboBox_6.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.comboBox_6.TextUpdate += this.comboBox_1_TextUpdate;
		this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_1.FormattingEnabled = true;
		this.comboBox_1.Location = new Point(117, 19);
		this.comboBox_1.Name = "cmbElectician";
		this.comboBox_1.Size = new Size(173, 21);
		this.comboBox_1.TabIndex = 1;
		this.comboBox_1.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.comboBox_1.TextUpdate += this.comboBox_1_TextUpdate;
		this.checkBox_1.AutoSize = true;
		this.checkBox_1.Location = new Point(18, 104);
		this.checkBox_1.Name = "checkBoxColorPrint";
		this.checkBox_1.Size = new Size(106, 17);
		this.checkBox_1.TabIndex = 10;
		this.checkBox_1.Text = "Цветная печать";
		this.checkBox_1.UseVisualStyleBackColor = true;
		this.checkBox_1.CheckedChanged += this.checkBox_1_CheckedChanged;
		this.groupBox_3.Controls.Add(this.numericUpDown_0);
		this.groupBox_3.Controls.Add(this.numericUpDown_1);
		this.groupBox_3.Controls.Add(this.label_5);
		this.groupBox_3.Controls.Add(this.label_6);
		this.groupBox_3.Location = new Point(162, 125);
		this.groupBox_3.Name = "groupBoxPages";
		this.groupBox_3.Size = new Size(146, 116);
		this.groupBox_3.TabIndex = 11;
		this.groupBox_3.TabStop = false;
		this.groupBox_3.Text = "Количество страниц";
		this.numericUpDown_0.Location = new Point(6, 85);
		NumericUpDown numericUpDown = this.numericUpDown_0;
		int[] array = new int[4];
		array[0] = 10;
		numericUpDown.Maximum = new decimal(array);
		NumericUpDown numericUpDown2 = this.numericUpDown_0;
		int[] array2 = new int[4];
		array2[0] = 1;
		numericUpDown2.Minimum = new decimal(array2);
		this.numericUpDown_0.Name = "numericUpDownWidth";
		this.numericUpDown_0.Size = new Size(134, 20);
		this.numericUpDown_0.TabIndex = 1;
		this.numericUpDown_0.TextAlign = HorizontalAlignment.Right;
		NumericUpDown numericUpDown3 = this.numericUpDown_0;
		int[] array3 = new int[4];
		array3[0] = 1;
		numericUpDown3.Value = new decimal(array3);
		this.numericUpDown_0.ValueChanged += this.numericUpDown_0_ValueChanged;
		this.numericUpDown_1.Location = new Point(6, 42);
		NumericUpDown numericUpDown4 = this.numericUpDown_1;
		int[] array4 = new int[4];
		array4[0] = 10;
		numericUpDown4.Maximum = new decimal(array4);
		NumericUpDown numericUpDown5 = this.numericUpDown_1;
		int[] array5 = new int[4];
		array5[0] = 1;
		numericUpDown5.Minimum = new decimal(array5);
		this.numericUpDown_1.Name = "numericUpDownHeigth";
		this.numericUpDown_1.Size = new Size(134, 20);
		this.numericUpDown_1.TabIndex = 1;
		this.numericUpDown_1.TextAlign = HorizontalAlignment.Right;
		NumericUpDown numericUpDown6 = this.numericUpDown_1;
		int[] array6 = new int[4];
		array6[0] = 1;
		numericUpDown6.Value = new decimal(array6);
		this.numericUpDown_1.ValueChanged += this.numericUpDown_1_ValueChanged;
		this.label_5.AutoSize = true;
		this.label_5.Location = new Point(6, 66);
		this.label_5.Name = "label6";
		this.label_5.Size = new Size(91, 13);
		this.label_5.TabIndex = 0;
		this.label_5.Text = "По горизонтали:";
		this.label_6.AutoSize = true;
		this.label_6.Location = new Point(6, 23);
		this.label_6.Name = "label5";
		this.label_6.Size = new Size(80, 13);
		this.label_6.TabIndex = 0;
		this.label_6.Text = "По вертикали:";
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = this.button_2;
		base.ClientSize = new Size(849, 591);
		base.Controls.Add(this.groupBox_3);
		base.Controls.Add(this.checkBox_1);
		base.Controls.Add(this.groupBox_2);
		base.Controls.Add(this.toolStrip_0);
		base.Controls.Add(this.button_3);
		base.Controls.Add(this.button_2);
		base.Controls.Add(this.groupBox_1);
		base.Controls.Add(this.checkBox_0);
		base.Controls.Add(this.groupBox_0);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.printPreviewControl_0);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "FormCanvasPrint";
		this.Text = "Печать схемы";
		base.FormClosing += this.Form4_FormClosing;
		base.Load += this.Form4_Load;
		this.groupBox_0.ResumeLayout(false);
		this.groupBox_0.PerformLayout();
		this.groupBox_1.ResumeLayout(false);
		this.groupBox_1.PerformLayout();
		this.toolStrip_0.ResumeLayout(false);
		this.toolStrip_0.PerformLayout();
		this.groupBox_2.ResumeLayout(false);
		this.groupBox_2.PerformLayout();
		this.groupBox_3.ResumeLayout(false);
		this.groupBox_3.PerformLayout();
		((ISupportInitialize)this.numericUpDown_0).EndInit();
		((ISupportInitialize)this.numericUpDown_1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private PrinterSettings printerSettings_0;

	private CanvasControl canvasControl_0;

	private Timer timer_0;

	private IContainer icontainer_0;

	private PrintPreviewControl printPreviewControl_0;

	private PrintDocument printDocument_0;

	private PageSetupDialog pageSetupDialog_0;

	private PrintDialog printDialog_0;

	private Button button_0;

	private GroupBox groupBox_0;

	private ComboBox comboBox_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Button button_1;

	private CheckBox checkBox_0;

	private GroupBox groupBox_1;

	private RadioButton radioButton_0;

	private RadioButton radioButton_1;

	private RadioButton radioButton_2;

	private Button button_2;

	private Button button_3;

	private ToolStrip toolStrip_0;

	private ToolStripSplitButton toolStripSplitButton_0;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem toolStripMenuItem_7;

	private ToolStripMenuItem toolStripMenuItem_8;

	private ToolStripMenuItem toolStripMenuItem_9;

	private GroupBox groupBox_2;

	private ComboBox comboBox_1;

	private ComboBox comboBox_2;

	private ComboBox comboBox_3;

	private ComboBox comboBox_4;

	private ComboBox comboBox_5;

	private ComboBox comboBox_6;

	private RadioButton radioButton_3;

	private TextBox textBox_0;

	private Label label_3;

	private CheckBox checkBox_1;

	private ComboBox comboBox_7;

	private ComboBox comboBox_8;

	private ComboBox comboBox_9;

	private ComboBox comboBox_10;

	private TextBox textBox_1;

	private Label label_4;

	private GroupBox groupBox_3;

	private NumericUpDown numericUpDown_0;

	private NumericUpDown numericUpDown_1;

	private Label label_5;

	private Label label_6;

	private TextBox textBox_2;

	private Label label_7;
}
