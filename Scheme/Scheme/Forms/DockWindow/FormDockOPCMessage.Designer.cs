using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using Scheme.Classes;
using Scheme.Forms;
using Scheme.Forms.LinkSchmTelemetry;
using Scheme.Properties;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using Telemetry;
using WinFormsUI.Docking;

internal class FormDockOPCMessage : DockContent
{
	[CompilerGenerated]
	internal void method_0(Delegate1 delegate1_1)
	{
		Delegate1 @delegate = this.delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_1);
			@delegate = Interlocked.CompareExchange<Delegate1>(ref this.delegate1_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	[CompilerGenerated]
	internal void method_1(Delegate1 delegate1_1)
	{
		Delegate1 @delegate = this.delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Remove(delegate2, delegate1_1);
			@delegate = Interlocked.CompareExchange<Delegate1>(ref this.delegate1_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	internal FormDockOPCMessage()
	{
		
		
		this.method_19();
		GeneralFormSettings.FontSizeChanged(new EventHandler(this.method_2));
		this.tabControl_0.TabPages.Remove(this.tabPage_2);
	}

	private void method_2(object sender, EventArgs e)
	{
		this.Font = new Font(this.Font.Name, GeneralFormSettings.FontSize);
	}

	internal DataGridViewSelectedRowCollection method_3()
	{
		if (this.tabControl_0.SelectedTab == this.tabPage_0)
		{
			return this.dataGridViewExcelFilter_0.SelectedRows;
		}
		return this.dataGridViewExcelFilter_1.SelectedRows;
	}

	internal void method_4(OPCMessage opcmessage_0, eMessageType eMessageType_0)
	{
		if (eMessageType_0 == eMessageType.OPCEvent && opcmessage_0.Acknowledged)
		{
			using (IEnumerator enumerator = this.dataSet_0.Tables["tableEvent"].Rows.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					OPCMessage opcmessage = (OPCMessage)dataRow["TelemetryMessage"];
					if (opcmessage.Cookie == opcmessage_0.Cookie && opcmessage.ServerID == opcmessage_0.ServerID)
					{
						dataRow["Acknowledged"] = true;
					}
					return;
				}
			}
		}
		DataRow dataRow2;
		if (eMessageType_0 == eMessageType.OPCEvent)
		{
			dataRow2 = this.dataSet_0.Tables["tableEvent"].NewRow();
		}
		else
		{
			dataRow2 = this.dataSet_0.Tables["tableItem"].NewRow();
		}
		dataRow2["TelemetryMessage"] = opcmessage_0;
		dataRow2["ObjectId"] = opcmessage_0.ObjectId;
		dataRow2["Icon"] = this.method_7(opcmessage_0.Icon);
		dataRow2["TimeOPC"] = opcmessage_0.TimeOPC;
		dataRow2["ObjectName"] = opcmessage_0.ObjName;
		dataRow2["Source"] = opcmessage_0.Source;
		dataRow2["Message"] = opcmessage_0.Message;
		dataRow2["Acknowledged"] = opcmessage_0.Acknowledged;
		dataRow2["pDescription"] = opcmessage_0.pDescription;
		if (eMessageType_0 == eMessageType.OPCEvent)
		{
			this.method_9(dataRow2);
			return;
		}
		this.method_10(dataRow2);
	}

	internal void method_5(OPCMessage opcmessage_0, ObjectOnLine objectOnLine_0)
	{
		DataRow[] array = this.dataSet_0.Tables["tableSwitch"].Select(string.Format("ObjectId = {0}", objectOnLine_0.IdBase));
		if (array.Length > 1)
		{
			for (int i = array.Length - 1; i > 1; i--)
			{
				this.method_12(array[i]);
			}
		}
		if (array.Length != 1)
		{
			if (array.Length == 0 && !string.IsNullOrEmpty(opcmessage_0.Value) && objectOnLine_0.On != Convert.ToBoolean(opcmessage_0.Value))
			{
				DataRow dataRow = this.dataSet_0.Tables["tableSwitch"].NewRow();
				dataRow["TelemetryMessage"] = opcmessage_0;
				dataRow["ObjectId"] = opcmessage_0.ObjectId;
				dataRow["TimeOPC"] = opcmessage_0.TimeOPC;
				dataRow["ObjectName"] = objectOnLine_0.GetFullName();
				dataRow["SwitchValue"] = objectOnLine_0.On;
				dataRow["TelemetryValue"] = Convert.ToBoolean(opcmessage_0.Value);
				dataRow["SwitchValueDescr"] = (((bool)dataRow["SwitchValue"]) ? "Вкл" : "Выкл");
				dataRow["TelemetryValueDescr"] = (((bool)dataRow["TelemetryValue"]) ? "Вкл" : "Выкл");
				objectOnLine_0.OnChanged += this.method_6;
				this.method_11(dataRow);
			}
			return;
		}
		DataRow dataRow2 = array[0];
		if (objectOnLine_0.On == Convert.ToBoolean(opcmessage_0.Value))
		{
			objectOnLine_0.OnChanged -= this.method_6;
			this.method_12(dataRow2);
			return;
		}
		if ((bool)dataRow2["SwitchValue"] != objectOnLine_0.On)
		{
			dataRow2["SwitchValue"] = objectOnLine_0.On;
			dataRow2["SwitchValueDescr"] = (((bool)dataRow2["SwitchValue"]) ? "Вкл" : "Выкл");
			return;
		}
		dataRow2["TelemetryValue"] = Convert.ToBoolean(opcmessage_0.Value);
		dataRow2["TelemetryValueDescr"] = (((bool)dataRow2["TelemetryValue"]) ? "Вкл" : "Выкл");
	}

	private void method_6(object sender, EventArgs e)
	{
		ObjectOnLine objectOnLine = (ObjectOnLine)sender;
		objectOnLine.OnChanged -= this.method_6;
		DataRow[] array = this.dataSet_0.Tables["tableSwitch"].Select(string.Format("ObjectId = {0}", objectOnLine.IdBase));
		bool flag = true;
		if (array.Length != 0)
		{
			for (int i = array.Length - 1; i >= 0; i--)
			{
				if ((bool)array[i]["TelemetryValue"] != objectOnLine.On)
				{
					flag = false;
					array[i]["SwitchValue"] = objectOnLine.On;
					array[i]["SwitchValueDescr"] = (((bool)array[i]["SwitchValue"]) ? "Вкл" : "Выкл");
				}
				else
				{
					this.method_12(array[i]);
				}
			}
		}
		if (flag)
		{
			objectOnLine.OnChanged -= this.method_6;
		}
	}

	internal byte[] method_7(Image image_0)
	{
		if (image_0 != null)
		{
			MemoryStream memoryStream = new MemoryStream();
			image_0.Save(memoryStream, ImageFormat.Jpeg);
			return memoryStream.ToArray();
		}
		return null;
	}

	private DataGridViewImageCell method_8(OPCMessage opcmessage_0)
	{
		DataGridViewImageCell dataGridViewImageCell = new DataGridViewImageCell();
		if (opcmessage_0.Icon != null)
		{
			dataGridViewImageCell.Value = opcmessage_0.Icon;
			dataGridViewImageCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
		}
		if (opcmessage_0.Audio != null && opcmessage_0.Audio.Length != 0)
		{
			new SoundPlayer(new MemoryStream(opcmessage_0.Audio, true)).Play();
		}
		return dataGridViewImageCell;
	}

	private void method_9(DataRow dataRow_0)
	{
		if (base.InvokeRequired)
		{
			FormDockOPCMessage.Delegate2 method = new FormDockOPCMessage.Delegate2(this.method_9);
			base.Invoke(method, new object[]
			{
				dataRow_0
			});
			return;
		}
		this.dataSet_0.Tables["tableEvent"].Rows.InsertAt(dataRow_0, 0);
	}

	private void method_10(DataRow dataRow_0)
	{
		if (base.InvokeRequired)
		{
			try
			{
				FormDockOPCMessage.Delegate2 method = new FormDockOPCMessage.Delegate2(this.method_10);
				base.Invoke(method, new object[]
				{
					dataRow_0
				});
				return;
			}
			catch
			{
				return;
			}
		}
		this.dataSet_0.Tables["tableItem"].Rows.InsertAt(dataRow_0, 0);
	}

	private void method_11(DataRow dataRow_0)
	{
		if (base.InvokeRequired)
		{
			try
			{
				FormDockOPCMessage.Delegate2 method = new FormDockOPCMessage.Delegate2(this.method_11);
				base.Invoke(method, new object[]
				{
					dataRow_0
				});
				return;
			}
			catch
			{
				return;
			}
		}
		this.dataSet_0.Tables["tableSwitch"].Rows.InsertAt(dataRow_0, 0);
	}

	private void method_12(DataRow dataRow_0)
	{
		if (base.InvokeRequired)
		{
			try
			{
				FormDockOPCMessage.Delegate2 method = new FormDockOPCMessage.Delegate2(this.method_12);
				base.Invoke(method, new object[]
				{
					dataRow_0
				});
				return;
			}
			catch
			{
				return;
			}
		}
		this.dataSet_0.Tables["tableSwitch"].Rows.Remove(dataRow_0);
	}

	private void eibJldGmxh(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && this.method_3().Count > 0 && this.delegate1_0 != null)
		{
			DataGridViewRow dataGridViewRow = ((DataGridView)sender).Rows[e.RowIndex];
			OPCMessage opcmessage = new OPCMessage();
			opcmessage.ObjectId = (int)dataGridViewRow.Cells[1].Value;
			this.delegate1_0(opcmessage);
		}
	}

	private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			if (this.dataGridViewExcelFilter_0["objectIdDataGridViewTextBoxColumn", e.RowIndex].Value == null || (int)this.dataGridViewExcelFilter_0["objectIdDataGridViewTextBoxColumn", e.RowIndex].Value <= 0)
			{
				e.CellStyle.ForeColor = Color.Red;
			}
			if (!Convert.ToBoolean(this.dataGridViewExcelFilter_0["AcknowledgedColumn", e.RowIndex].Value))
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
			}
		}
	}

	private void dataGridViewExcelFilter_0_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
	{
		if (this.dataGridViewExcelFilter_0.RowCount > 0 && e.ColumnIndex == this.dataGridViewExcelFilter_0.Columns["columnImageEvent"].Index)
		{
			OPCMessage opcmessage = (OPCMessage)this.dataGridViewExcelFilter_0["telemetryMessageDgvTxtColumn", e.RowIndex].Value;
			e.Value = opcmessage.Icon;
		}
	}

	private void dataGridViewExcelFilter_1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex >= 0 && (this.dataGridViewExcelFilter_1["objectIdDgvColumn", e.RowIndex].Value == null || (int)this.dataGridViewExcelFilter_1["objectIdDgvColumn", e.RowIndex].Value <= 0))
		{
			e.CellStyle.ForeColor = Color.Red;
		}
	}

	[CompilerGenerated]
	public void method_13(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = this.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	[CompilerGenerated]
	public void method_14(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = this.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	[CompilerGenerated]
	public void method_15(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = this.eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	[CompilerGenerated]
	public void method_16(EventHandler eventHandler_2)
	{
		EventHandler eventHandler = this.eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(null, EventArgs.Empty);
		}
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		if (this.eventHandler_1 != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
		{
			List<OPCMessage> list = new List<OPCMessage>();
			foreach (object obj in this.dataGridViewExcelFilter_0.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				list.Add((OPCMessage)dataGridViewRow.Cells["telemetryMessageDgvTxtColumn"].Value);
			}
			this.eventHandler_1(list, EventArgs.Empty);
		}
	}

	private void dataGridViewExcelFilter_0_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
		{
			this.dataGridViewExcelFilter_0.Rows[e.RowIndex].Selected = true;
			int num = e.Location.X + this.dataGridViewExcelFilter_0.RowHeadersWidth;
			int num2 = e.Location.Y + this.dataGridViewExcelFilter_0.ColumnHeadersHeight;
			for (int i = this.dataGridViewExcelFilter_0.FirstDisplayedCell.ColumnIndex; i < e.ColumnIndex; i++)
			{
				if (this.dataGridViewExcelFilter_0.Columns[i].Visible)
				{
					num += this.dataGridViewExcelFilter_0.Columns[i].Width;
				}
			}
			for (int j = this.dataGridViewExcelFilter_0.FirstDisplayedCell.RowIndex; j < e.RowIndex; j++)
			{
				num2 += this.dataGridViewExcelFilter_0.Rows[j].Height;
			}
			this.contextMenuStrip_0.Tag = this.dataGridViewExcelFilter_0.Rows[e.RowIndex];
			this.contextMenuStrip_0.Show(this.dataGridViewExcelFilter_0.PointToScreen(new Point(num, num2)));
		}
	}

	private void method_17(object sender, DataGridViewCellMouseEventArgs e)
	{
	}

	private void contextMenuStrip_0_Opening(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		DrawObjectBase drawObjectBase = ((FormGeneralScheme2)base.DockPanel.Parent.Parent.Parent).ActiveCanvas.SelectedObjects.First<DrawObjectBase>();
		DataGridViewRow dataGridViewRow = (DataGridViewRow)((ToolStripMenuItem)sender).Owner.Tag;
		if (dataGridViewRow.DataGridView == this.dataGridViewExcelFilter_1)
		{
			return;
		}
		SQLSettings sqlSettings = ((FormGeneralScheme2)base.DockPanel.Parent.Parent.Parent).SqlSettings;
		OPCMessage opcmessage = (OPCMessage)dataGridViewRow.Cells[7].Value;
		if (dataGridViewRow.DataGridView == this.dataGridViewExcelFilter_0)
		{
			this.method_18(sqlSettings, drawObjectBase.IdBase, opcmessage.ObjName, opcmessage.Source);
		}
	}

	private void method_18(SQLSettings sqlsettings_0, int int_0, string string_0, string string_1)
	{
		string text = "SELECT id, objectId, ParameterId, ItemName, Source, Area FROM [OPC_Config].[dbo].[Tags] WHERE ";
		if (string_1 == string.Empty)
		{
			return;
		}
		text = string.Concat(new string[]
		{
			text,
			"[Area] like '",
			string_0,
			"' and [Source] like '",
			string_1,
			"'"
		});
		SqlConnection sqlConnection = new SqlConnection(sqlsettings_0.GetConnectionString());
		SqlCommand sqlCommand = new SqlCommand(text, sqlConnection);
		sqlConnection.Open();
		SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
		if (!sqlDataReader.Read())
		{
			MessageBox.Show("Данное событие отсутствует в таблице тегов", "Ошибка привязки");
			return;
		}
		int num = (int)sqlDataReader[0];
		int num2 = -1;
		if (sqlDataReader[2] == null)
		{
			FormParameterChoice formParameterChoice = new FormParameterChoice(sqlsettings_0, int_0);
			formParameterChoice.ShowDialog();
			num2 = formParameterChoice.ParameterId;
		}
		else if (sqlDataReader[1] != null && MessageBox.Show("Данная строка уже привязана к объекту схемы. В процессе выполнения данная связь будет утеряна. Продолжать выполнение процесса привязки?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
		{
			return;
		}
		sqlDataReader.Close();
		text = "UPDATE [OPC_Config].[dbo].[Tags] set objectId = " + int_0.ToString();
		if (num2 > -1)
		{
			text = text + ", ParameterId = " + num2.ToString();
		}
		text = text + "WHERE id = " + num.ToString();
		sqlCommand.CommandText = text;
		sqlCommand.ExecuteNonQuery();
		sqlConnection.Close();
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(bool_0);
	}

	private void method_19()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDockOPCMessage));
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
		this.toolStrip_0 = new ToolStrip();
		this.imageList_0 = new ImageList(this.icontainer_0);
		this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
		this.tabControl_0 = new TabControl();
		this.tabPage_0 = new TabPage();
		this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
		this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		this.dataGridViewImageColumnNotNull_1 = new DataGridViewImageColumnNotNull();
		this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.dataSet_0 = new DataSet();
		this.dataTable_0 = new DataTable();
		this.dataColumn_0 = new DataColumn();
		this.dataColumn_1 = new DataColumn();
		this.dataColumn_2 = new DataColumn();
		this.dataColumn_3 = new DataColumn();
		this.dataColumn_4 = new DataColumn();
		this.dataColumn_5 = new DataColumn();
		this.QutQyjmKyM = new DataColumn();
		this.dataColumn_6 = new DataColumn();
		this.dataColumn_15 = new DataColumn();
		this.dataColumn_17 = new DataColumn();
		this.dataTable_1 = new DataTable();
		this.dataColumn_7 = new DataColumn();
		this.dataColumn_8 = new DataColumn();
		this.dataColumn_9 = new DataColumn();
		this.dataColumn_10 = new DataColumn();
		this.dataColumn_11 = new DataColumn();
		this.dataColumn_12 = new DataColumn();
		this.dataColumn_13 = new DataColumn();
		this.dataColumn_14 = new DataColumn();
		this.dataColumn_16 = new DataColumn();
		this.dataColumn_18 = new DataColumn();
		this.dataTable_2 = new DataTable();
		this.dataColumn_19 = new DataColumn();
		this.dataColumn_20 = new DataColumn();
		this.dataColumn_21 = new DataColumn();
		this.dataColumn_22 = new DataColumn();
		this.dataColumn_23 = new DataColumn();
		this.dataColumn_24 = new DataColumn();
		this.dataColumn_25 = new DataColumn();
		this.dataColumn_26 = new DataColumn();
		this.tabPage_1 = new TabPage();
		this.dataGridViewExcelFilter_1 = new DataGridViewExcelFilter();
		this.dataGridViewImageColumnNotNull_2 = new DataGridViewImageColumnNotNull();
		this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
		this.dataGridViewImageColumnNotNull_3 = new DataGridViewImageColumnNotNull();
		this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
		this.bindingSource_1 = new BindingSource(this.icontainer_0);
		this.tabPage_2 = new TabPage();
		this.dataGridViewExcelFilter_2 = new DataGridViewExcelFilter();
		this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
		this.bindingSource_2 = new BindingSource(this.icontainer_0);
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.toolStrip_1 = new ToolStrip();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripButton_1 = new ToolStripButton();
		this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_0 = new ToolStripMenuItem();
		this.tabControl_0.SuspendLayout();
		this.tabPage_0.SuspendLayout();
		this.dataGridViewExcelFilter_0.BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		((ISupportInitialize)this.dataSet_0).BeginInit();
		((ISupportInitialize)this.dataTable_0).BeginInit();
		((ISupportInitialize)this.dataTable_1).BeginInit();
		((ISupportInitialize)this.dataTable_2).BeginInit();
		this.tabPage_1.SuspendLayout();
		this.dataGridViewExcelFilter_1.BeginInit();
		((ISupportInitialize)this.bindingSource_1).BeginInit();
		this.tabPage_2.SuspendLayout();
		this.dataGridViewExcelFilter_2.BeginInit();
		((ISupportInitialize)this.bindingSource_2).BeginInit();
		this.toolStrip_1.SuspendLayout();
		this.contextMenuStrip_0.SuspendLayout();
		base.SuspendLayout();
		this.toolStrip_0.Location = new Point(0, 0);
		this.toolStrip_0.Name = "toolStrip";
		this.toolStrip_0.Size = new Size(748, 25);
		this.toolStrip_0.TabIndex = 0;
		this.toolStrip_0.Text = "toolStrip1";
		this.toolStrip_0.Visible = false;
		this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListDgv.ImageStream");
		this.imageList_0.TransparentColor = Color.Transparent;
		this.imageList_0.Images.SetKeyName(0, "Fire");
		this.imageList_0.Images.SetKeyName(1, "Error");
		this.imageList_0.Images.SetKeyName(2, "Information");
		this.imageList_0.Images.SetKeyName(3, "Warning");
		this.imageList_0.Images.SetKeyName(4, "LinkAdd");
		this.imageList_0.Images.SetKeyName(5, "Linkbreak");
		this.imageList_0.Images.SetKeyName(6, "DoorClose");
		this.imageList_0.Images.SetKeyName(7, "DoorOpen");
		this.dataGridViewFilterTextBoxColumn_0.HeaderText = "ТП";
		this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewFilterTextBoxColumn1";
		this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Source";
		this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn2";
		this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Message";
		this.dataGridViewFilterTextBoxColumn_2.Name = "dataGridViewFilterTextBoxColumn3";
		this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
		this.tabControl_0.Controls.Add(this.tabPage_0);
		this.tabControl_0.Controls.Add(this.tabPage_1);
		this.tabControl_0.Controls.Add(this.tabPage_2);
		this.tabControl_0.Dock = DockStyle.Fill;
		this.tabControl_0.Location = new Point(32, 0);
		this.tabControl_0.Name = "tabControlOPC";
		this.tabControl_0.SelectedIndex = 0;
		this.tabControl_0.Size = new Size(716, 251);
		this.tabControl_0.TabIndex = 2;
		this.tabPage_0.Controls.Add(this.dataGridViewExcelFilter_0);
		this.tabPage_0.Location = new Point(4, 22);
		this.tabPage_0.Name = "tabPageEvents";
		this.tabPage_0.Padding = new Padding(3);
		this.tabPage_0.Size = new Size(716, 225);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "События";
		this.tabPage_0.UseVisualStyleBackColor = true;
		this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
		this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
		this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewImageColumnNotNull_0,
			this.dataGridViewTextBoxColumn_6,
			this.dataGridViewImageColumnNotNull_1,
			this.dataGridViewTextBoxColumn_7,
			this.dataGridViewTextBoxColumn_8,
			this.dataGridViewTextBoxColumn_9,
			this.dataGridViewTextBoxColumn_10,
			this.dataGridViewTextBoxColumn_11,
			this.dataGridViewTextBoxColumn_12,
			this.dataGridViewCheckBoxColumn_0,
			this.dataGridViewTextBoxColumn_13
		});
		this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
		this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_0.Location = new Point(3, 3);
		this.dataGridViewExcelFilter_0.MultiSelect = false;
		this.dataGridViewExcelFilter_0.Name = "dgvOPCEvent";
		this.dataGridViewExcelFilter_0.ReadOnly = true;
		this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_0.Size = new Size(710, 219);
		this.dataGridViewExcelFilter_0.TabIndex = 2;
		this.dataGridViewExcelFilter_0.VirtualMode = true;
		this.dataGridViewExcelFilter_0.CellClick += this.eibJldGmxh;
		this.dataGridViewExcelFilter_0.CellFormatting += this.dataGridViewExcelFilter_0_CellFormatting;
		this.dataGridViewExcelFilter_0.CellMouseDown += this.dataGridViewExcelFilter_0_CellMouseDown;
		this.dataGridViewExcelFilter_0.CellValueNeeded += this.dataGridViewExcelFilter_0_CellValueNeeded;
		this.dataGridViewImageColumnNotNull_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		dataGridViewCellStyle.NullValue = null;
		this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = dataGridViewCellStyle;
		this.dataGridViewImageColumnNotNull_0.Frozen = true;
		this.dataGridViewImageColumnNotNull_0.HeaderText = "";
		this.dataGridViewImageColumnNotNull_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
		this.dataGridViewImageColumnNotNull_0.Name = "columnImageEvent";
		this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
		this.dataGridViewImageColumnNotNull_0.Resizable = DataGridViewTriState.False;
		this.dataGridViewImageColumnNotNull_0.Width = 5;
		this.dataGridViewTextBoxColumn_6.DataPropertyName = "ObjectId";
		this.dataGridViewTextBoxColumn_6.HeaderText = "ObjectId";
		this.dataGridViewTextBoxColumn_6.Name = "objectIdDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.Visible = false;
		this.dataGridViewImageColumnNotNull_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		this.dataGridViewImageColumnNotNull_1.DataPropertyName = "Icon";
		dataGridViewCellStyle2.NullValue = null;
		this.dataGridViewImageColumnNotNull_1.DefaultCellStyle = dataGridViewCellStyle2;
		this.dataGridViewImageColumnNotNull_1.HeaderText = "";
		this.dataGridViewImageColumnNotNull_1.ImageLayout = DataGridViewImageCellLayout.Zoom;
		this.dataGridViewImageColumnNotNull_1.Name = "iconDataGridViewImageColumn";
		this.dataGridViewImageColumnNotNull_1.ReadOnly = true;
		this.dataGridViewImageColumnNotNull_1.Resizable = DataGridViewTriState.False;
		this.dataGridViewImageColumnNotNull_1.Visible = false;
		this.dataGridViewTextBoxColumn_7.DataPropertyName = "TimeOPC";
		this.dataGridViewTextBoxColumn_7.HeaderText = "Время OPC";
		this.dataGridViewTextBoxColumn_7.Name = "timeOPCDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewTextBoxColumn_8.DataPropertyName = "ObjectName";
		this.dataGridViewTextBoxColumn_8.HeaderText = "Имя объекта";
		this.dataGridViewTextBoxColumn_8.Name = "objectNameDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_8.ReadOnly = true;
		this.dataGridViewTextBoxColumn_9.DataPropertyName = "Source";
		this.dataGridViewTextBoxColumn_9.HeaderText = "Действие";
		this.dataGridViewTextBoxColumn_9.Name = "sourceDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_9.ReadOnly = true;
		this.dataGridViewTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_10.DataPropertyName = "Message";
		this.dataGridViewTextBoxColumn_10.HeaderText = "Сообщение";
		this.dataGridViewTextBoxColumn_10.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn_10.Name = "messageDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_10.ReadOnly = true;
		this.dataGridViewTextBoxColumn_11.DataPropertyName = "TelemetryMessage";
		this.dataGridViewTextBoxColumn_11.HeaderText = "TelemetryMessage";
		this.dataGridViewTextBoxColumn_11.Name = "telemetryMessageDgvTxtColumn";
		this.dataGridViewTextBoxColumn_11.ReadOnly = true;
		this.dataGridViewTextBoxColumn_11.Visible = false;
		this.dataGridViewTextBoxColumn_12.DataPropertyName = "Objects";
		this.dataGridViewTextBoxColumn_12.HeaderText = "Objects";
		this.dataGridViewTextBoxColumn_12.Name = "objectsEventDgvColumn";
		this.dataGridViewTextBoxColumn_12.ReadOnly = true;
		this.dataGridViewTextBoxColumn_12.Visible = false;
		this.dataGridViewCheckBoxColumn_0.DataPropertyName = "Acknowledged";
		this.dataGridViewCheckBoxColumn_0.HeaderText = "Acknowledged";
		this.dataGridViewCheckBoxColumn_0.Name = "AcknowledgedColumn";
		this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_0.Visible = false;
		this.dataGridViewTextBoxColumn_13.DataPropertyName = "pDescription";
		this.dataGridViewTextBoxColumn_13.HeaderText = "pDescription";
		this.dataGridViewTextBoxColumn_13.Name = "pDescription";
		this.dataGridViewTextBoxColumn_13.ReadOnly = true;
		this.dataGridViewTextBoxColumn_13.Visible = false;
		this.bindingSource_0.DataMember = "tableEvent";
		this.bindingSource_0.DataSource = this.dataSet_0;
		this.dataSet_0.DataSetName = "NewDataSet";
		this.dataSet_0.Tables.AddRange(new DataTable[]
		{
			this.dataTable_0,
			this.dataTable_1,
			this.dataTable_2
		});
		this.dataTable_0.Columns.AddRange(new DataColumn[]
		{
			this.dataColumn_0,
			this.dataColumn_1,
			this.dataColumn_2,
			this.dataColumn_3,
			this.dataColumn_4,
			this.dataColumn_5,
			this.QutQyjmKyM,
			this.dataColumn_6,
			this.dataColumn_15,
			this.dataColumn_17
		});
		this.dataTable_0.TableName = "tableEvent";
		this.dataColumn_0.ColumnName = "TelemetryMessage";
		this.dataColumn_0.DataType = typeof(object);
		this.dataColumn_1.ColumnName = "ObjectId";
		this.dataColumn_1.DataType = typeof(int);
		this.dataColumn_2.ColumnName = "Objects";
		this.dataColumn_2.DataType = typeof(object);
		this.dataColumn_3.ColumnName = "Icon";
		this.dataColumn_3.DataType = typeof(byte[]);
		this.dataColumn_4.ColumnName = "TimeOPC";
		this.dataColumn_4.DataType = typeof(DateTime);
		this.dataColumn_5.ColumnName = "ObjectName";
		this.QutQyjmKyM.ColumnName = "Source";
		this.dataColumn_6.ColumnName = "Message";
		this.dataColumn_15.ColumnName = "Acknowledged";
		this.dataColumn_15.DataType = typeof(bool);
		this.dataColumn_17.ColumnName = "pDescription";
		this.dataTable_1.Columns.AddRange(new DataColumn[]
		{
			this.dataColumn_7,
			this.dataColumn_8,
			this.dataColumn_9,
			this.dataColumn_10,
			this.dataColumn_11,
			this.dataColumn_12,
			this.dataColumn_13,
			this.dataColumn_14,
			this.dataColumn_16,
			this.dataColumn_18
		});
		this.dataTable_1.TableName = "tableItem";
		this.dataColumn_7.ColumnName = "TelemetryMessage";
		this.dataColumn_7.DataType = typeof(object);
		this.dataColumn_8.ColumnName = "ObjectId";
		this.dataColumn_8.DataType = typeof(int);
		this.dataColumn_9.ColumnName = "Objects";
		this.dataColumn_9.DataType = typeof(object);
		this.dataColumn_10.ColumnName = "Icon";
		this.dataColumn_10.DataType = typeof(byte[]);
		this.dataColumn_11.ColumnName = "TimeOPC";
		this.dataColumn_11.DataType = typeof(DateTime);
		this.dataColumn_12.ColumnName = "ObjectName";
		this.dataColumn_13.ColumnName = "Source";
		this.dataColumn_14.ColumnName = "Message";
		this.dataColumn_16.ColumnName = "Acknowledged";
		this.dataColumn_16.DataType = typeof(bool);
		this.dataColumn_18.ColumnName = "pDescription";
		this.dataTable_2.Columns.AddRange(new DataColumn[]
		{
			this.dataColumn_19,
			this.dataColumn_20,
			this.dataColumn_21,
			this.dataColumn_22,
			this.dataColumn_23,
			this.dataColumn_24,
			this.dataColumn_25,
			this.dataColumn_26
		});
		this.dataTable_2.TableName = "tableSwitch";
		this.dataColumn_19.ColumnName = "TelemetryMessage";
		this.dataColumn_19.DataType = typeof(object);
		this.dataColumn_20.ColumnName = "ObjectId";
		this.dataColumn_20.DataType = typeof(int);
		this.dataColumn_21.ColumnName = "TimeOPC";
		this.dataColumn_22.ColumnName = "ObjectName";
		this.dataColumn_23.ColumnName = "SwitchValueDescr";
		this.dataColumn_24.ColumnName = "TelemetryValueDescr";
		this.dataColumn_25.ColumnName = "SwitchValue";
		this.dataColumn_25.DataType = typeof(bool);
		this.dataColumn_25.DefaultValue = false;
		this.dataColumn_26.ColumnName = "TelemetryValue";
		this.dataColumn_26.DataType = typeof(bool);
		this.dataColumn_26.DefaultValue = false;
		this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_1);
		this.tabPage_1.Location = new Point(4, 22);
		this.tabPage_1.Name = "tabPageItem";
		this.tabPage_1.Padding = new Padding(3);
		this.tabPage_1.Size = new Size(716, 225);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "Текущие значения";
		this.tabPage_1.UseVisualStyleBackColor = true;
		this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_1.BackgroundColor = Color.White;
		this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_1.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewImageColumnNotNull_2,
			this.dataGridViewTextBoxColumn_14,
			this.dataGridViewImageColumnNotNull_3,
			this.dataGridViewTextBoxColumn_15,
			this.dataGridViewTextBoxColumn_16,
			this.dataGridViewTextBoxColumn_17,
			this.dataGridViewTextBoxColumn_18,
			this.dataGridViewTextBoxColumn_19
		});
		this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
		this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_1.Location = new Point(3, 3);
		this.dataGridViewExcelFilter_1.MultiSelect = false;
		this.dataGridViewExcelFilter_1.Name = "dgvOPCItem";
		this.dataGridViewExcelFilter_1.ReadOnly = true;
		this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_1.Size = new Size(710, 219);
		this.dataGridViewExcelFilter_1.TabIndex = 3;
		this.dataGridViewExcelFilter_1.VirtualMode = true;
		this.dataGridViewExcelFilter_1.CellClick += this.eibJldGmxh;
		this.dataGridViewExcelFilter_1.CellFormatting += this.dataGridViewExcelFilter_1_CellFormatting;
		this.dataGridViewImageColumnNotNull_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		dataGridViewCellStyle3.NullValue = null;
		this.dataGridViewImageColumnNotNull_2.DefaultCellStyle = dataGridViewCellStyle3;
		this.dataGridViewImageColumnNotNull_2.Frozen = true;
		this.dataGridViewImageColumnNotNull_2.HeaderText = "";
		this.dataGridViewImageColumnNotNull_2.ImageLayout = DataGridViewImageCellLayout.Zoom;
		this.dataGridViewImageColumnNotNull_2.Name = "dataGridViewImageColumnNotNull2";
		this.dataGridViewImageColumnNotNull_2.ReadOnly = true;
		this.dataGridViewImageColumnNotNull_2.Resizable = DataGridViewTriState.False;
		this.dataGridViewImageColumnNotNull_2.Width = 5;
		this.dataGridViewTextBoxColumn_14.DataPropertyName = "ObjectId";
		this.dataGridViewTextBoxColumn_14.HeaderText = "ObjectId";
		this.dataGridViewTextBoxColumn_14.Name = "objectIdDgvColumn";
		this.dataGridViewTextBoxColumn_14.ReadOnly = true;
		this.dataGridViewTextBoxColumn_14.Visible = false;
		this.dataGridViewImageColumnNotNull_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		this.dataGridViewImageColumnNotNull_3.DataPropertyName = "Icon";
		dataGridViewCellStyle4.NullValue = null;
		this.dataGridViewImageColumnNotNull_3.DefaultCellStyle = dataGridViewCellStyle4;
		this.dataGridViewImageColumnNotNull_3.HeaderText = "";
		this.dataGridViewImageColumnNotNull_3.ImageLayout = DataGridViewImageCellLayout.Zoom;
		this.dataGridViewImageColumnNotNull_3.Name = "dataGridViewImageColumnNotNull3";
		this.dataGridViewImageColumnNotNull_3.ReadOnly = true;
		this.dataGridViewImageColumnNotNull_3.Resizable = DataGridViewTriState.False;
		this.dataGridViewImageColumnNotNull_3.Visible = false;
		this.dataGridViewTextBoxColumn_15.DataPropertyName = "TimeOPC";
		this.dataGridViewTextBoxColumn_15.HeaderText = "Время OPC";
		this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn12";
		this.dataGridViewTextBoxColumn_15.ReadOnly = true;
		this.dataGridViewTextBoxColumn_16.DataPropertyName = "ObjectName";
		this.dataGridViewTextBoxColumn_16.HeaderText = "Имя объекта";
		this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn13";
		this.dataGridViewTextBoxColumn_16.ReadOnly = true;
		this.dataGridViewTextBoxColumn_17.DataPropertyName = "pDescription";
		this.dataGridViewTextBoxColumn_17.HeaderText = "Действие";
		this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn14";
		this.dataGridViewTextBoxColumn_17.ReadOnly = true;
		this.dataGridViewTextBoxColumn_18.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_18.DataPropertyName = "Message";
		this.dataGridViewTextBoxColumn_18.HeaderText = "Сообщение";
		this.dataGridViewTextBoxColumn_18.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn15";
		this.dataGridViewTextBoxColumn_18.ReadOnly = true;
		this.dataGridViewTextBoxColumn_19.DataPropertyName = "Objects";
		this.dataGridViewTextBoxColumn_19.HeaderText = "Objects";
		this.dataGridViewTextBoxColumn_19.Name = "objectsItemDgvColumn";
		this.dataGridViewTextBoxColumn_19.ReadOnly = true;
		this.dataGridViewTextBoxColumn_19.Visible = false;
		this.bindingSource_1.DataMember = "tableItem";
		this.bindingSource_1.DataSource = this.dataSet_0;
		this.tabPage_2.Controls.Add(this.dataGridViewExcelFilter_2);
		this.tabPage_2.Location = new Point(4, 22);
		this.tabPage_2.Name = "tabPageSwitchError";
		this.tabPage_2.Padding = new Padding(3);
		this.tabPage_2.Size = new Size(708, 225);
		this.tabPage_2.TabIndex = 2;
		this.tabPage_2.Text = "Комутационные аппараты";
		this.tabPage_2.UseVisualStyleBackColor = true;
		this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_2.BackgroundColor = Color.White;
		this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_2.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_20,
			this.dataGridViewTextBoxColumn_21,
			this.dataGridViewTextBoxColumn_22,
			this.dataGridViewTextBoxColumn_23,
			this.dataGridViewTextBoxColumn_24
		});
		this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
		this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_2.Location = new Point(3, 3);
		this.dataGridViewExcelFilter_2.MultiSelect = false;
		this.dataGridViewExcelFilter_2.Name = "dataGridViewExcelFilter1";
		this.dataGridViewExcelFilter_2.ReadOnly = true;
		this.dataGridViewExcelFilter_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_2.Size = new Size(702, 219);
		this.dataGridViewExcelFilter_2.TabIndex = 4;
		this.dataGridViewExcelFilter_2.VirtualMode = true;
		this.dataGridViewExcelFilter_2.CellClick += this.eibJldGmxh;
		this.dataGridViewTextBoxColumn_20.DataPropertyName = "TelemetryMessage";
		this.dataGridViewTextBoxColumn_20.HeaderText = "TelemetryMessage";
		this.dataGridViewTextBoxColumn_20.Name = "TelemetryMessage";
		this.dataGridViewTextBoxColumn_20.ReadOnly = true;
		this.dataGridViewTextBoxColumn_20.Visible = false;
		this.dataGridViewTextBoxColumn_21.DataPropertyName = "ObjectId";
		this.dataGridViewTextBoxColumn_21.HeaderText = "ObjectId";
		this.dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_21.ReadOnly = true;
		this.dataGridViewTextBoxColumn_21.Visible = false;
		this.dataGridViewTextBoxColumn_22.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_22.DataPropertyName = "ObjectName";
		this.dataGridViewTextBoxColumn_22.HeaderText = "Имя объекта";
		this.dataGridViewTextBoxColumn_22.MinimumWidth = 140;
		this.dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn3";
		this.dataGridViewTextBoxColumn_22.ReadOnly = true;
		this.dataGridViewTextBoxColumn_23.DataPropertyName = "SwitchValueDescr";
		this.dataGridViewTextBoxColumn_23.HeaderText = "Значение на схеме";
		this.dataGridViewTextBoxColumn_23.Name = "SwitchValueD";
		this.dataGridViewTextBoxColumn_23.ReadOnly = true;
		this.dataGridViewTextBoxColumn_23.Width = 140;
		this.dataGridViewTextBoxColumn_24.DataPropertyName = "TelemetryValueDescr";
		this.dataGridViewTextBoxColumn_24.HeaderText = "Значение в телеметрии";
		this.dataGridViewTextBoxColumn_24.Name = "TelemetryValueD";
		this.dataGridViewTextBoxColumn_24.ReadOnly = true;
		this.dataGridViewTextBoxColumn_24.Width = 150;
		this.bindingSource_2.DataMember = "tableSwitch";
		this.bindingSource_2.DataSource = this.dataSet_0;
		this.dataGridViewTextBoxColumn_0.DataPropertyName = "TelemetryMessage";
		this.dataGridViewTextBoxColumn_0.HeaderText = "TelemetryMessage";
		this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn5";
		this.dataGridViewTextBoxColumn_0.Visible = false;
		this.dataGridViewTextBoxColumn_1.DataPropertyName = "Objects";
		this.dataGridViewTextBoxColumn_1.HeaderText = "Objects";
		this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn6";
		this.dataGridViewTextBoxColumn_1.Visible = false;
		this.dataGridViewTextBoxColumn_2.DataPropertyName = "TelemetryMessage";
		this.dataGridViewTextBoxColumn_2.HeaderText = "TelemetryMessage";
		this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn7";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewTextBoxColumn_2.Visible = false;
		this.dataGridViewTextBoxColumn_3.DataPropertyName = "Objects";
		this.dataGridViewTextBoxColumn_3.HeaderText = "Objects";
		this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn8";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		this.dataGridViewTextBoxColumn_3.Visible = false;
		this.dataGridViewTextBoxColumn_4.DataPropertyName = "TelemetryMessage";
		this.dataGridViewTextBoxColumn_4.HeaderText = "TelemetryMessage";
		this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn9";
		this.dataGridViewTextBoxColumn_4.Visible = false;
		this.dataGridViewTextBoxColumn_5.DataPropertyName = "Objects";
		this.dataGridViewTextBoxColumn_5.HeaderText = "Objects";
		this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn10";
		this.dataGridViewTextBoxColumn_5.Visible = false;
		this.toolStrip_1.Dock = DockStyle.Left;
		this.toolStrip_1.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_0,
			this.toolStripButton_1
		});
		this.toolStrip_1.Location = new Point(0, 0);
		this.toolStrip_1.Name = "toolStripTelemetry";
		this.toolStrip_1.Size = new Size(32, 251);
		this.toolStrip_1.TabIndex = 3;
		this.toolStrip_1.Text = "toolStrip1";
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = Resources.smethod_37();
		this.toolStripButton_0.ImageTransparentColor = Color.Transparent;
		this.toolStripButton_0.Name = "toolBtnGetAllItem";
		this.toolStripButton_0.Size = new Size(29, 20);
		this.toolStripButton_0.Text = "Получить все телемеханические значения";
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = Resources.smethod_8();
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolBtnAcknowledge";
		this.toolStripButton_1.Size = new Size(29, 20);
		this.toolStripButton_1.Text = "Квитировать";
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripMenuItem_0
		});
		this.contextMenuStrip_0.Name = "contextMenuStrip1";
		this.contextMenuStrip_0.Size = new Size(258, 26);
		this.contextMenuStrip_0.Opening += this.contextMenuStrip_0_Opening;
		this.toolStripMenuItem_0.Name = "toolStripMenuItemLinkToObject";
		this.toolStripMenuItem_0.Size = new Size(257, 22);
		this.toolStripMenuItem_0.Text = "Связать с выделенным объектом";
		this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
		base.AccessibleRole = AccessibleRole.None;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(748, 251);
		base.Controls.Add(this.tabControl_0);
		base.Controls.Add(this.toolStrip_1);
		base.Controls.Add(this.toolStrip_0);
		base.DockAreas = 31;
		this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Name = "FormDockOPCMessage";
		this.Text = "Телеметрия";
		this.tabControl_0.ResumeLayout(false);
		this.tabPage_0.ResumeLayout(false);
		this.dataGridViewExcelFilter_0.EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		((ISupportInitialize)this.dataSet_0).EndInit();
		((ISupportInitialize)this.dataTable_0).EndInit();
		((ISupportInitialize)this.dataTable_1).EndInit();
		((ISupportInitialize)this.dataTable_2).EndInit();
		this.tabPage_1.ResumeLayout(false);
		this.dataGridViewExcelFilter_1.EndInit();
		((ISupportInitialize)this.bindingSource_1).EndInit();
		this.tabPage_2.ResumeLayout(false);
		this.dataGridViewExcelFilter_2.EndInit();
		((ISupportInitialize)this.bindingSource_2).EndInit();
		this.toolStrip_1.ResumeLayout(false);
		this.toolStrip_1.PerformLayout();
		this.contextMenuStrip_0.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private Delegate1 delegate1_0;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	private IContainer icontainer_0;

	private ToolStrip toolStrip_0;

	private ImageList imageList_0;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private DataSet dataSet_0;

	private DataTable dataTable_0;

	private DataColumn dataColumn_0;

	private DataColumn dataColumn_1;

	private DataColumn dataColumn_2;

	private DataColumn dataColumn_3;

	private DataColumn dataColumn_4;

	private DataColumn dataColumn_5;

	private DataColumn QutQyjmKyM;

	private DataColumn dataColumn_6;

	private DataGridViewExcelFilter dataGridViewExcelFilter_0;

	private BindingSource bindingSource_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataTable dataTable_1;

	private DataColumn dataColumn_7;

	private DataColumn dataColumn_8;

	private DataColumn dataColumn_9;

	private DataColumn dataColumn_10;

	private DataColumn dataColumn_11;

	private DataColumn dataColumn_12;

	private DataGridViewExcelFilter dataGridViewExcelFilter_1;

	private DataColumn dataColumn_13;

	private DataColumn dataColumn_14;

	private BindingSource bindingSource_1;

	private ToolStrip toolStrip_1;

	private ToolStripButton toolStripButton_0;

	private DataColumn dataColumn_15;

	private DataColumn dataColumn_16;

	private ToolStripButton toolStripButton_1;

	private DataColumn dataColumn_17;

	private DataColumn dataColumn_18;

	private ContextMenuStrip contextMenuStrip_0;

	private ToolStripMenuItem toolStripMenuItem_0;

	private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

	private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

	private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

	private TabPage tabPage_2;

	private DataGridViewExcelFilter dataGridViewExcelFilter_2;

	private DataTable dataTable_2;

	private DataColumn dataColumn_19;

	private DataColumn dataColumn_20;

	private DataColumn dataColumn_21;

	private DataColumn dataColumn_22;

	private DataColumn dataColumn_23;

	private DataColumn dataColumn_24;

	private DataColumn dataColumn_25;

	private DataColumn dataColumn_26;

	private BindingSource bindingSource_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

	private delegate void Delegate2(DataRow r);
}
