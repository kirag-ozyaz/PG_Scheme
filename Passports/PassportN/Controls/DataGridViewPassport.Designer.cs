using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Constants;
using ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty;
using DataSql;
using Passport.Classes;
using Passport.Forms;
using Passport.Forms.Classes;
using Passport.Properties;

namespace Passport.Controls
{
	public class DataGridViewPassport : DataGridView
	{
		[CompilerGenerated]
		private void method_0(DataGridViewPassport.GroupChangeEventHandler value)
		{
			DataGridViewPassport.GroupChangeEventHandler groupChangeEventHandler = this.groupChangeEventHandler_0;
			DataGridViewPassport.GroupChangeEventHandler groupChangeEventHandler2;
			do
			{
				groupChangeEventHandler2 = groupChangeEventHandler;
				DataGridViewPassport.GroupChangeEventHandler value2 = (DataGridViewPassport.GroupChangeEventHandler)Delegate.Combine(groupChangeEventHandler2, value);
				groupChangeEventHandler = Interlocked.CompareExchange<DataGridViewPassport.GroupChangeEventHandler>(ref this.groupChangeEventHandler_0, value2, groupChangeEventHandler2);
			}
			while (groupChangeEventHandler != groupChangeEventHandler2);
		}

		[CompilerGenerated]
		private void method_1(DataGridViewPassport.GroupChangeEventHandler value)
		{
			DataGridViewPassport.GroupChangeEventHandler groupChangeEventHandler = this.groupChangeEventHandler_0;
			DataGridViewPassport.GroupChangeEventHandler groupChangeEventHandler2;
			do
			{
				groupChangeEventHandler2 = groupChangeEventHandler;
				DataGridViewPassport.GroupChangeEventHandler value2 = (DataGridViewPassport.GroupChangeEventHandler)Delegate.Remove(groupChangeEventHandler2, value);
				groupChangeEventHandler = Interlocked.CompareExchange<DataGridViewPassport.GroupChangeEventHandler>(ref this.groupChangeEventHandler_0, value2, groupChangeEventHandler2);
			}
			while (groupChangeEventHandler != groupChangeEventHandler2);
		}

		[CompilerGenerated]
		private void method_2(DataGridViewPassport.GroupChangeEventHandler value)
		{
			DataGridViewPassport.GroupChangeEventHandler groupChangeEventHandler = this.groupChangeEventHandler_1;
			DataGridViewPassport.GroupChangeEventHandler groupChangeEventHandler2;
			do
			{
				groupChangeEventHandler2 = groupChangeEventHandler;
				DataGridViewPassport.GroupChangeEventHandler value2 = (DataGridViewPassport.GroupChangeEventHandler)Delegate.Combine(groupChangeEventHandler2, value);
				groupChangeEventHandler = Interlocked.CompareExchange<DataGridViewPassport.GroupChangeEventHandler>(ref this.groupChangeEventHandler_1, value2, groupChangeEventHandler2);
			}
			while (groupChangeEventHandler != groupChangeEventHandler2);
		}

		[CompilerGenerated]
		private void method_3(DataGridViewPassport.GroupChangeEventHandler value)
		{
			DataGridViewPassport.GroupChangeEventHandler groupChangeEventHandler = this.groupChangeEventHandler_1;
			DataGridViewPassport.GroupChangeEventHandler groupChangeEventHandler2;
			do
			{
				groupChangeEventHandler2 = groupChangeEventHandler;
				DataGridViewPassport.GroupChangeEventHandler value2 = (DataGridViewPassport.GroupChangeEventHandler)Delegate.Remove(groupChangeEventHandler2, value);
				groupChangeEventHandler = Interlocked.CompareExchange<DataGridViewPassport.GroupChangeEventHandler>(ref this.groupChangeEventHandler_1, value2, groupChangeEventHandler2);
			}
			while (groupChangeEventHandler != groupChangeEventHandler2);
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Enable or disable drag/drop functionality.")]
		[DefaultValue(false)]
		[Browsable(true)]
		[Category("Behavior")]
		public bool EnableDragDrop
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
				this.AllowDrop = value;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataGridViewColumnCollection Columns
		{
			get
			{
				return base.Columns;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public bool ValueVisible
		{
			get
			{
				return this.ValueChar.Visible;
			}
			set
			{
				this.ValueChar.Visible = value;
			}
		}

		[Browsable(true)]
		[Description("True, если завершить перемещение строки")]
		[DefaultValue(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Category("Behavior")]
		public bool DragDropComplite
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		public new object DataSource
		{
			get
			{
				return base.DataSource;
			}
			set
			{
				base.AutoGenerateColumns = false;
				base.DataSource = value;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new string DataMember
		{
			get
			{
				return base.DataMember;
			}
			set
			{
				base.AutoGenerateColumns = false;
				base.DataMember = value;
			}
		}

		public override ISite Site
		{
			get
			{
				return base.Site;
			}
			set
			{
				base.Site = value;
				if (value != null)
				{
					INestedContainer nestedContainer = (INestedContainer)this.Site.GetService(typeof(INestedContainer));
					if (nestedContainer != null)
					{
						nestedContainer.Add(this, "DataGridViewPassport1");
					}
				}
			}
		}

		[Description("Добавляет характеристику паспорта")]
		public void AddCharacteristic()
		{
			if (base.SelectedRows.Count > 0 && base.SelectedRows[0] != null && base.SelectedRows.GetType() != typeof(DataGridViewRow))
			{
				int id;
				if ((bool)base.SelectedRows[0].Cells["isGroupChar"].Value)
				{
					id = (int)base.SelectedRows[0].Cells["idChar"].Value;
				}
				else
				{
					id = (int)base.SelectedRows[0].Cells["ParentIdChar"].Value;
				}
				FormAddEditPassportChar formAddEditPassportChar = new FormAddEditPassportChar(this.SqlSettings, 4, id, base.RowCount + 1);
				formAddEditPassportChar.MdiParent = Application.OpenForms["MainForm"];
				if (formAddEditPassportChar.ShowDialog() == DialogResult.OK)
				{
					this.UpdateData();
					this.method_12();
					this.SelectRow(formAddEditPassportChar.Id);
				}
			}
		}

		[Description("Добавляет группу характеристик паспорта")]
		public void AddGroupCharacteristic()
		{
			FormAddEditPassportChar formAddEditPassportChar = new FormAddEditPassportChar(this.SqlSettings, 3, this.int_3, base.RowCount + 1);
			formAddEditPassportChar.MdiParent = Application.OpenForms["MainForm"];
			if (formAddEditPassportChar.ShowDialog() == DialogResult.OK)
			{
				this.createState_0 = DataGridViewPassport.CreateState.Add;
				this.int_2 = formAddEditPassportChar.Id;
				this.UpdateData();
				this.method_12();
				this.SelectRow(formAddEditPassportChar.Id);
			}
		}

		[Description("Добавляет строку с данными харвктеристики паспорта")]
		public void AddParameterRows(SQLSettings SqlSettings, string ParentKeyChar)
		{
			this.SqlSettings = SqlSettings;
			this.string_2 = ParentKeyChar;
			this.createState_0 = DataGridViewPassport.CreateState.EditChars;
			this.method_15(this.string_2);
			this.int_3 = this.method_39(this.string_2);
			if (this.ContextMenuStrip == null)
			{
				this.ContextMenuStrip = this.CreateContextMenu();
			}
		}

		[Description("Заполняет DataGridViewPassport данными для просмотра паспорта")]
		public void AddRowViewingParameters(SQLSettings Settings, int IdPassport)
		{
			this.SqlSettings = Settings;
			this.createState_0 = DataGridViewPassport.CreateState.View;
			this.int_1 = IdPassport;
			this.string_1 = string.Format("WHERE id = {0} AND CharDeleted = 0 ORDER BY TabIndex", IdPassport);
			this.string_2 = this.method_41(IdPassport);
			this.string_0 = string.Format("WHERE ParentKey LIKE '{0}%' AND ParentKey != '{0}' AND deleted = 0 ORDER BY TabIndex", this.string_2);
			this.method_16(Settings, IdPassport, this.string_1, this.string_0);
			this.Columns["ValueChar"].ReadOnly = true;
		}

		[Description("Заполняет DataGridViewPassport данными для просмотра паспорта")]
		public void AddRowViewingParameters(SQLSettings Settings, int IdPassport, int ParentIdChar, string ParentKeyChar)
		{
			this.createState_0 = DataGridViewPassport.CreateState.View;
			this.int_1 = IdPassport;
			this.SqlSettings = Settings;
			this.string_2 = ParentKeyChar;
			this.string_1 = string.Format("WHERE id = {0} AND ParentIdChar = {1} AND CharDeleted = 0 ORDER BY TabIndex", IdPassport, ParentIdChar);
			this.string_0 = string.Format("WHERE ParentKey = '{0}' AND isGroup = 0 AND deleted = 0", ParentKeyChar);
			this.method_16(Settings, IdPassport, this.string_1, this.string_0);
		}

		[Description("Заполняет DataGridViewPassport данными для добавления паспорта")]
		public void AddRowAddingParemeter(SQLSettings Settings, int IdObjList)
		{
			this.createState_0 = DataGridViewPassport.CreateState.Add;
			this.SqlSettings = Settings;
			this.int_0 = IdObjList;
			this.string_2 = this.method_37(IdObjList);
			if (this.string_2 != "")
			{
				this.method_22(Settings, this.string_2);
				this.int_3 = this.method_39(this.string_2);
				if (this.ContextMenuStrip == null)
				{
					this.ContextMenuStrip = this.CreateContextMenu();
					return;
				}
			}
			else
			{
				MessageBox.Show("Группа характеристик не привязана к объекту схемы.", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		[Description("Заполняет DataGridViewPassport данными для добавления паспорта")]
		public void AddRowAddingParemeter(int typeCodeId, SQLSettings Settings)
		{
			this.createState_0 = DataGridViewPassport.CreateState.Add;
			this.SqlSettings = Settings;
			this.string_2 = this.method_38(typeCodeId);
			if (this.string_2 == "")
			{
				MessageBox.Show("С данным типом объекта схемы не связан ни один тип характеристик оборудования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			this.method_22(Settings, this.string_2);
			this.int_3 = this.method_39(this.string_2);
			if (this.ContextMenuStrip == null)
			{
				this.ContextMenuStrip = this.CreateContextMenu();
			}
		}

		[Description("Заполняет DataGridViewPassport данными для редактирования паспорта")]
		public void AddRowEditingParameter(SQLSettings Settings, int IdPassport, DataGridViewPassport.CreateState State = DataGridViewPassport.CreateState.EditValue)
		{
			this.createState_0 = State;
			this.SqlSettings = Settings;
			this.int_1 = IdPassport;
			SqlData.SelectSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_Passport, true, "WHERE id = " + IdPassport.ToString(), true);
			if (this.class107_0.tP_Passport.Rows.Count > 0)
			{
				this.string_2 = this.method_41(IdPassport);
				this.method_22(Settings, this.method_37((int)this.class107_0.tP_Passport.Rows[0]["idObjList"]));
				this.method_25(IdPassport);
				if (this.ContextMenuStrip == null)
				{
					this.ContextMenuStrip = this.CreateContextMenu();
				}
			}
		}

		[Description("Удаление характеристики/группы характеристик паспорта")]
		public void DeleteCharacteristic()
		{
			if (base.SelectedRows != null && base.SelectedRows.GetType() != typeof(DataGridViewRow))
			{
				if ((bool)base.SelectedRows[0].Cells["isGroupChar"].Value)
				{
					if (MessageBox.Show("Вы действительно хотите удалить группу \"" + base.SelectedRows[0].Cells["NameChar"].Value.ToString() + "\"?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						SqlData.SelectSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_CharList, true, string.Format("WHERE id = {0} or ParentId = {0}", (int)base.SelectedRows[0].Cells["idChar"].Value), true);
						foreach (object obj in this.class107_0.tP_CharList.Rows)
						{
							((Class107.Class285)obj).Deleted = true;
						}
						SqlData.UpdateSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_CharList);
						this.UpdateData();
					}
				}
				else if (MessageBox.Show("Вы действительно хотите удалить характеристику \"" + base.SelectedRows[0].Cells["NameChar"].Value.ToString() + "\"?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					SqlData.SelectSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_CharList, true, "WHERE id = " + (int)base.SelectedRows[0].Cells["idChar"].Value, true);
					this.class107_0.tP_CharList.Rows[0]["Deleted"] = true;
					SqlData.UpdateSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_CharList);
					this.UpdateData();
				}
			}
			if (base.Rows.Count == 0)
			{
				this.method_14(false);
				return;
			}
			this.method_14(true);
		}

		[Description("Делает все паспорта на данное оборудование неактивными, кроме указанного")]
		public void DisablePassportActive(int idObjList, int idPassport)
		{
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand();
					string commandText = string.Format("UPDATE tP_Passport SET isActive = '0'\r\nWHERE idObjList = {0} AND id != {1}", idObjList, idPassport);
					sqlCommand.Connection = sqlConnection;
					sqlCommand.CommandType = CommandType.Text;
					sqlCommand.CommandText = commandText;
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
					sqlConnection.Close();
				}
			}
		}

		[Description("Редактирование характеристики/группы характеристик паспорта")]
		public void EditCharacteristic()
		{
			if (base.SelectedRows != null && base.SelectedRows.GetType() != typeof(DataGridViewRow))
			{
				StateFormCreate state = 6;
				if ((bool)base.SelectedRows[0].Cells["isGroupChar"].Value)
				{
					state = 5;
				}
				FormAddEditPassportChar formAddEditPassportChar = new FormAddEditPassportChar(this.SqlSettings, state, (int)base.SelectedRows[0].Cells["idChar"].Value, base.RowCount + 1);
				formAddEditPassportChar.Parent = Application.OpenForms["MainForm"];
				if (formAddEditPassportChar.ShowDialog() == DialogResult.OK)
				{
					this.UpdateData();
					this.SelectRow(formAddEditPassportChar.Id);
				}
			}
		}

		[Description("Выделяет строку по значению идентификатора")]
		public void SelectRow(int id)
		{
			foreach (object obj in ((IEnumerable)base.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if ((int)dataGridViewRow.Cells["idChar"].Value == id)
				{
					dataGridViewRow.Selected = true;
					base.FirstDisplayedScrollingRowIndex = dataGridViewRow.Index;
					break;
				}
			}
		}

		[Description("Обновляет данные в DataGridView")]
		public void UpdateData()
		{
			if (this.method_13())
			{
				this.method_12();
			}
			switch (this.createState_0)
			{
			case DataGridViewPassport.CreateState.Add:
				if (string.IsNullOrEmpty(this.string_2))
				{
					this.method_22(this.SqlSettings, this.method_40(this.int_2));
					return;
				}
				this.method_22(this.SqlSettings, this.string_2);
				return;
			case DataGridViewPassport.CreateState.EditValue:
			{
				int int_ = (int)base.SelectedRows[0].Cells["IdChar"].Value;
				int firstDisplayedScrollingRowIndex = base.FirstDisplayedScrollingRowIndex;
				this.method_22(this.SqlSettings, this.method_37((int)this.class107_0.tP_Passport.Rows[0]["idObjList"]));
				this.method_25(this.int_1);
				base.FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
				this.method_42(int_, firstDisplayedScrollingRowIndex);
				return;
			}
			case DataGridViewPassport.CreateState.EditChars:
			{
				int int_ = (int)base.SelectedRows[0].Cells["IdChar"].Value;
				int firstDisplayedScrollingRowIndex = base.FirstDisplayedScrollingRowIndex;
				this.method_15(this.string_2);
				base.FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
				this.method_42(int_, firstDisplayedScrollingRowIndex);
				return;
			}
			case DataGridViewPassport.CreateState.View:
				this.method_16(this.SqlSettings, this.int_1, this.string_1, this.string_0);
				return;
			default:
				return;
			}
		}

		[Description("Сохранение внесенных данных")]
		public void SaveInsertedData(int idObjList, DateTime datePassport, int Number = 0)
		{
			this.int_0 = idObjList;
			this.SaveInsertedData(datePassport, Number);
		}

		[Description("Сохранение внесенных данных")]
		public void SaveInsertedData(DateTime datePassport, int Number = 0)
		{
			if (this.createState_0 == DataGridViewPassport.CreateState.Add || this.createState_0 == DataGridViewPassport.CreateState.Copy)
			{
				int idEquipment = this.tdwmkIbcyiT(this.int_0);
				Class107.Class257 @class = this.class107_0.tP_Passport.method_5();
				@class.idObjList = this.int_0;
				@class.idEquipment = idEquipment;
				@class.Number = Number;
				@class.Date = datePassport;
				@class.DateIn = DateTime.Now;
				@class.isActive = true;
				@class.Deleted = false;
				this.class107_0.tP_Passport.method_0(@class);
				this.int_1 = SqlData.InsertSqlDataOneRow(this.SqlSettings, this.class107_0, this.class107_0.tP_Passport);
				Class107.Class208 class2 = this.class107_0.tP_ObjectChar.method_5();
				for (int i = 0; i < base.Rows.Count; i++)
				{
					if (!(bool)base.Rows[i].Cells["isGroupChar"].Value)
					{
						class2 = this.class107_0.tP_ObjectChar.method_5();
						class2.idPassport = this.int_1;
						class2.idObjChar = (int)base.Rows[i].Cells["idChar"].Value;
						if (base.Rows[i].Cells["ValueChar"].GetType() == typeof(DataGridViewComboBoxCell))
						{
							if (base.Rows[i].Cells["ValueChar"].Value != null)
							{
								class2.Value = base.Rows[i].Cells["ValueChar"].Value.ToString();
							}
							else
							{
								class2.Value = "-1";
							}
						}
						else if (base.Rows[i].Cells["ValueChar"].GetType() == typeof(DataGridViewCheckBoxCell))
						{
							class2.Value = (((bool)base.Rows[i].Cells["ValueChar"].Value) ? "1" : "0");
						}
						else if (base.Rows[i].Cells["ValueChar"].Value != null)
						{
							class2.Value = base.Rows[i].Cells["ValueChar"].Value.ToString();
						}
						else
						{
							class2.Value = "";
						}
						class2.Deleted = false;
						this.class107_0.tP_ObjectChar.method_0(class2);
					}
				}
				SqlData.InsertSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_ObjectChar);
				this.DisablePassportActive(this.int_0, this.int_1);
			}
		}

		[Description("Сохранение обновленных данных")]
		public void SaveUpdatedData(DateTime datePassport, int Number = 0)
		{
			this.SaveUpdatedData(datePassport, this.int_1, Number);
		}

		[Description("Сохранение обновленных данных")]
		public void SaveUpdatedData(DateTime datePassport, int idPassport, int Number = 0)
		{
			if (this.createState_0 == DataGridViewPassport.CreateState.EditValue)
			{
				SqlData.SelectSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_ObjectChar, true, string.Format("WHERE idPassport = {0}", idPassport), true);
				SqlData.SelectSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_Passport, true, string.Format("where id = '{0}'", idPassport), true);
				foreach (object obj in ((IEnumerable)base.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					if (this.list_0.Contains(dataGridViewRow.Index) && !(bool)dataGridViewRow.Cells["isGroupChar"].Value)
					{
						Class107.Class208 @class = this.method_27((int)dataGridViewRow.Cells["idChar"].Value);
						if (@class == null)
						{
							Class107.Class208 class2 = this.class107_0.tP_ObjectChar.method_5();
							class2.idPassport = idPassport;
							class2.idObjChar = (int)dataGridViewRow.Cells["idChar"].Value;
							if (dataGridViewRow.Cells["ValueChar"].GetType() == typeof(DataGridViewComboBoxCell))
							{
								if (dataGridViewRow.Cells["ValueChar"].Value != null)
								{
									class2.Value = dataGridViewRow.Cells["ValueChar"].Value.ToString();
								}
								else
								{
									class2.Value = "-1";
								}
							}
							else if (dataGridViewRow.Cells["ValueChar"].GetType() == typeof(DataGridViewCheckBoxCell))
							{
								class2.Value = (((bool)dataGridViewRow.Cells["ValueChar"].Value) ? "1" : "0");
							}
							else if (dataGridViewRow.Cells["ValueChar"].Value != null)
							{
								class2.Value = dataGridViewRow.Cells["ValueChar"].Value.ToString();
							}
							else
							{
								class2.Value = "";
							}
							class2.Deleted = false;
							this.class107_0.tP_ObjectChar.method_0(class2);
						}
						else if (dataGridViewRow.Cells["ValueChar"].GetType() == typeof(DataGridViewComboBoxCell))
						{
							DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)dataGridViewRow.Cells["ValueChar"];
							@class["Value"] = dataGridViewComboBoxCell.Value;
						}
						else if (dataGridViewRow.Cells["ValueChar"].GetType() == typeof(DataGridViewCheckBoxCell))
						{
							@class["Value"] = (((bool)dataGridViewRow.Cells["ValueChar"].Value) ? "1" : "0");
						}
						else
						{
							@class["Value"] = dataGridViewRow.Cells["ValueChar"].Value;
						}
					}
				}
				foreach (Class107.Class208 class3 in this.class107_0.tP_ObjectChar)
				{
					class3.EndEdit();
				}
				foreach (Class107.Class257 class4 in this.class107_0.tP_Passport)
				{
					class4["date"] = datePassport;
					class4["Number"] = Number;
					class4.EndEdit();
				}
				SqlData.UpdateSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_Passport);
				SqlData.InsertSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_ObjectChar);
				SqlData.UpdateSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_ObjectChar);
			}
		}

		[Description("Запуск прослушивания изменения данных в таблицах.")]
		public void TablesValuesDataChangeListenerStart(SQLSettings settings, Dictionary<string, string> tableNameWhere)
		{
			this.list_1 = new List<Class321>();
			foreach (KeyValuePair<string, string> keyValuePair in tableNameWhere)
			{
				DataTable dataTable = this.class107_0.DataTableCollection_0[keyValuePair.Key];
				Class321 @class = new Class321(settings.GetConnectionString(), ref dataTable, keyValuePair.Value, "ContractorCacheMessages", "Service=ContractorNotifications", 0);
				@class.method_0(new ChangeContractor(this.method_7));
				if (@class.method_2())
				{
					@class.method_3(false);
				}
			}
		}

		[Description("Остановка прослушивания изменения данных в таблицах.")]
		public void TablesValuesDataChangeListenerStop()
		{
			foreach (Class321 @class in this.list_1)
			{
				@class.method_4();
			}
		}

		[Description("Вызывается перед изменении группы перетаскиваемого элемента")]
		[Category("Drag Drop")]
		public event DataGridViewPassport.GroupChangeEventHandler GroupChanging
		{
			add
			{
				this.method_0(value);
			}
			remove
			{
				this.method_1(value);
			}
		}

		[Description("Вызывается после изменении группы перетаскиваемого элемента")]
		[Category("Drag Drop")]
		public event DataGridViewPassport.GroupChangeEventHandler GroupChanged
		{
			add
			{
				this.method_2(value);
			}
			remove
			{
				this.method_3(value);
			}
		}

		public DataGridViewPassport()
		{
			Class330.Mus9JxKz1CNxy();
			this.int_8 = -1;
			this.list_0 = new List<int>();
			this.contextMenuStrip1 = new ContextMenuStrip();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			base..ctor();
			this.method_43();
			this.class107_0 = new Class107();
			base.AutoGenerateColumns = false;
		}

		protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
		{
			if ((bool)base.Rows[e.RowIndex].Cells["isGroupChar"].Value)
			{
				base.Rows[e.RowIndex].ReadOnly = true;
				base.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
				base.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
				base.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = ((this.createState_0 == DataGridViewPassport.CreateState.View) ? Color.Black : Color.Blue);
				base.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
				base.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(base.DefaultCellStyle.Font.FontFamily, base.DefaultCellStyle.Font.Size, FontStyle.Bold);
			}
			base.OnRowsAdded(e);
		}

		protected override void OnEditingControlShowing(DataGridViewEditingControlShowingEventArgs e)
		{
			if (this.Columns[base.CurrentCell.ColumnIndex].Name == "ValueChar" && e.Control.GetType() == typeof(DataGridViewComboBoxEditingControl))
			{
				ComboBox comboBox = (ComboBox)e.Control;
				comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				comboBox.DropDownStyle = ComboBoxStyle.DropDown;
				comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
				comboBox.TextChanged -= this.method_4;
				comboBox.TextChanged += this.method_4;
				comboBox.KeyDown -= this.method_5;
				comboBox.KeyDown += this.method_5;
				comboBox.Validating -= new CancelEventHandler(this.method_6);
				comboBox.Validating += new CancelEventHandler(this.method_6);
			}
			base.OnEditingControlShowing(e);
		}

		private void method_4(object sender, EventArgs e)
		{
		}

		private void method_5(object sender, KeyEventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			if (e.KeyCode == Keys.Delete)
			{
				comboBox.SelectedValue = -1;
			}
			if (e.KeyCode == Keys.Down)
			{
				int num = base.Rows.Count - 1;
				int index = base.SelectedRows[0].Index;
				int index2 = (index == num) ? 0 : (index + 1);
				base.Rows[index2].Cells[5].Selected = true;
			}
			if (e.KeyCode == Keys.Up)
			{
				int num = base.Rows.Count - 1;
				int index = base.SelectedRows[0].Index;
				int index2 = (index == 0) ? num : (index - 1);
				base.Rows[index2].Cells[5].Selected = true;
			}
		}

		private void method_6(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			if (comboBox.SelectedIndex == -1)
			{
				base.CommitEdit(DataGridViewDataErrorContexts.Commit);
				base.CurrentCell.Value = DBNull.Value;
				return;
			}
			if (base.IsCurrentCellDirty)
			{
				base.CommitEdit(DataGridViewDataErrorContexts.Commit);
				base.CurrentCell.Value = comboBox.SelectedValue;
				return;
			}
		}

		private void DataGridViewPassport_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			this.list_0.Add(e.RowIndex);
		}

		private void method_7(object sender, TableDataChangeEventArgs e)
		{
			try
			{
				if (((ISynchronizeInvoke)this).InvokeRequired)
				{
					ChangeContractor method = new ChangeContractor(this.method_7);
					((ISynchronizeInvoke)this).BeginInvoke(method, new object[]
					{
						sender,
						e
					});
				}
				else
				{
					if (e.Info != SqlNotificationInfo.Invalid)
					{
						((Class321)sender).method_3(false);
					}
					this.UpdateComboboxData(e.TableName, 9999999);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			this.int_4 = base.HitTest(e.X, e.Y).RowIndex;
			if (this.int_4 != -1)
			{
				Size dragSize = SystemInformation.DragSize;
				this.rectangle_0 = new Rectangle(new Point(e.X - dragSize.Width / 2, e.Y - dragSize.Height / 2), dragSize);
			}
			else
			{
				this.rectangle_0 = Rectangle.Empty;
			}
			base.OnMouseDown(e);
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left && this.rectangle_0 != Rectangle.Empty && !this.rectangle_0.Contains(e.X, e.Y))
			{
				if (base.Rows[this.int_4].IsNewRow)
				{
					MessageBox.Show("Невозможно переместить новую неопределенную строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				if ((bool)base.Rows[this.int_4].Cells["isGroupChar"].Value)
				{
					return;
				}
				base.DoDragDrop(base.Rows[this.int_4], DragDropEffects.Move);
			}
		}

		protected override void OnDragOver(DragEventArgs drgevent)
		{
			drgevent.Effect = DragDropEffects.Move;
			this.int_6 = 15;
			this.int_7 = base.Height - 18;
			if (this.int_6 >= base.PointToClient(new Point(drgevent.X, drgevent.Y)).Y && base.FirstDisplayedScrollingRowIndex > 0)
			{
				base.FirstDisplayedScrollingRowIndex--;
			}
			if (this.int_7 <= base.PointToClient(new Point(drgevent.X, drgevent.Y)).Y)
			{
				base.FirstDisplayedScrollingRowIndex++;
			}
			Point point = base.PointToClient(new Point(drgevent.X, drgevent.Y));
			this.int_9 = base.HitTest(point.X, point.Y).RowIndex;
			if (this.int_9 != -1)
			{
				base.Rows[this.int_9].Selected = true;
			}
			base.OnDragOver(drgevent);
		}

		protected override void OnDragDrop(DragEventArgs drgevent)
		{
			Point point = base.PointToClient(new Point(drgevent.X, drgevent.Y));
			int num = 0;
			int num2 = this.method_9(this.int_4);
			int num3 = 0;
			this.int_5 = base.HitTest(point.X, point.Y).RowIndex;
			if ((int)base.Rows[this.int_4].Cells["idChar"].Value == -1)
			{
				return;
			}
			if (drgevent.Effect == DragDropEffects.Move)
			{
				DataGridViewRow dataGridViewRow = drgevent.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
				if (this.int_5 != -1 && this.int_5 < (base.AllowUserToAddRows ? (base.Rows.Count - 1) : base.Rows.Count) && !base.Rows[this.int_5].IsNewRow)
				{
					if ((bool)base.Rows[this.int_5].Cells["isGroupChar"].Value && this.int_5 == 0)
					{
						num = this.int_5 + 1;
					}
					else
					{
						num = this.int_5;
					}
					num3 = this.method_10(this.int_4, num);
				}
				else
				{
					if (this.int_6 >= base.PointToClient(new Point(drgevent.X, drgevent.Y)).Y)
					{
						num = 1;
						num3 = this.method_10(this.int_4, 1);
					}
					if (this.int_7 <= base.PointToClient(new Point(drgevent.X, drgevent.Y)).Y)
					{
						num = (base.AllowUserToAddRows ? (base.Rows.Count - 1) : base.Rows.Count);
						num3 = this.method_10(this.int_4, num);
					}
				}
				dataGridViewRow.Selected = true;
				this.bool_2 = (num2 != num3);
				DataRow[] array = this.class107_0.tP_CharList.Select("id = " + num2.ToString());
				DataRow[] array2 = this.class107_0.tP_CharList.Select("id = " + num3.ToString());
				if (array.Length == 0 || array2.Length == 0)
				{
					return;
				}
				if (this.bool_2 && this.groupChangeEventHandler_0 != null)
				{
					this.groupChangeEventHandler_0(this, new GroupChangeEventArgs(num, base.Rows[this.int_4].Cells["NameChar"].Value.ToString(), array[0]["Name"].ToString(), array2[0]["Name"].ToString()));
				}
				if (!this.bool_1)
				{
					return;
				}
				base.Rows.RemoveAt(this.int_4);
				base.Rows.Insert(num, dataGridViewRow);
				this.method_12();
				if (this.bool_2)
				{
					this.method_11((int)dataGridViewRow.Cells["idChar"].Value, num3);
				}
				if (this.bool_2 && this.groupChangeEventHandler_1 != null)
				{
					this.groupChangeEventHandler_1(this, new GroupChangeEventArgs(num, base.Rows[this.int_4].Cells["NameChar"].Value.ToString(), array[0]["Name"].ToString(), array2[0]["Name"].ToString()));
				}
				this.UpdateData();
			}
			base.OnDragDrop(drgevent);
		}

		private void method_8(DragEventArgs dragEventArgs_0)
		{
			Point point = base.PointToClient(new Point(dragEventArgs_0.X, dragEventArgs_0.Y));
			this.int_9 = base.HitTest(point.X, point.Y).RowIndex;
			if (this.int_8 != this.int_9)
			{
				if (this.int_8 != -1)
				{
					base.Rows[this.int_8].DefaultCellStyle.SelectionBackColor = Color.White;
				}
				if (this.int_9 != -1 && !base.Rows[this.int_9].IsNewRow)
				{
					base.Rows[this.int_9].DefaultCellStyle.SelectionBackColor = Color.LightBlue;
				}
				this.int_8 = this.int_9;
			}
		}

		private int method_9(int int_10)
		{
			if ((bool)base.Rows[int_10].Cells["isGroupChar"].Value)
			{
				return (int)base.Rows[int_10].Cells["idChar"].Value;
			}
			return (int)base.Rows[int_10].Cells["ParentIdChar"].Value;
		}

		private int method_10(int int_10, int int_11)
		{
			if (!(bool)base.Rows[int_11].Cells["isGroupChar"].Value)
			{
				return (int)base.Rows[int_11].Cells["ParentIdChar"].Value;
			}
			if (int_10 <= int_11 || int_11 == 0)
			{
				return (int)base.Rows[int_11].Cells["idChar"].Value;
			}
			if ((bool)base.Rows[int_11 - 1].Cells["isGroupChar"].Value)
			{
				return (int)base.Rows[int_11 - 1].Cells["idChar"].Value;
			}
			return (int)base.Rows[int_11 - 1].Cells["ParentIdChar"].Value;
		}

		private void method_11(int int_10, int int_11)
		{
			DataRow[] array = this.class107_0.tP_CharList.Select("id = " + int_11);
			DataRow[] array2 = this.class107_0.tP_CharList.Select("id = " + int_10);
			array2[0]["ParentId"] = int_11;
			array2[0]["ParentKey"] = array[0]["ParentKey"];
			SqlData.UpdateSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_CharList);
		}

		private void method_12()
		{
			foreach (object obj in ((IEnumerable)base.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				int num = (int)dataGridViewRow.Cells["idChar"].Value;
				int tabIndex = dataGridViewRow.Index + 1;
				foreach (object obj2 in this.class107_0.tP_CharList.Rows)
				{
					Class107.Class285 @class = (Class107.Class285)obj2;
					if (@class.id == num)
					{
						@class.TabIndex = tabIndex;
					}
				}
			}
			SqlData.UpdateSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_CharList);
		}

		private bool method_13()
		{
			List<Class299> list = new List<Class299>();
			foreach (object obj in ((IEnumerable)base.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				list.Add(new Class299((int)dataGridViewRow.Cells["idChar"].Value, (int)dataGridViewRow.Cells["ParentIdChar"].Value, (int)dataGridViewRow.Cells["TabIndexChar"].Value, (bool)dataGridViewRow.Cells["isGroupChar"].Value, dataGridViewRow.Cells["NameChar"].Value.ToString(), (dataGridViewRow.Cells["ValueChar"].Value == null) ? "" : dataGridViewRow.Cells["ValueChar"].Value.ToString()));
			}
			return (from tabIndex in list
			group tabIndex by tabIndex.method_2() into grp
			where grp.Count<Class299>() > 1
			select grp.Key).Count<int>() != 0;
		}

		public void CreateColunms()
		{
			if (base.ColumnCount > 0)
			{
				for (int i = base.ColumnCount - 1; i < 0; i--)
				{
					this.Columns[i].Dispose();
				}
			}
			if (base.ColumnCount == 0)
			{
				DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
				DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
				DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
				DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
				DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
				DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
				dataGridViewTextBoxColumn.Name = "dataGridViewTextBoxColumn1";
				dataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
				dataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
				dataGridViewTextBoxColumn.ReadOnly = true;
				dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
				dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.True;
				dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.Programmatic;
				dataGridViewTextBoxColumn2.ReadOnly = true;
				dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
				dataGridViewTextBoxColumn3.ReadOnly = true;
				dataGridViewCheckBoxColumn.Name = "dataGridViewCheckBoxColumn1";
				dataGridViewCheckBoxColumn.Resizable = DataGridViewTriState.True;
				dataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
				dataGridViewCheckBoxColumn.ReadOnly = true;
				dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dataGridViewTextBoxColumn4.FillWeight = 150f;
				dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
				dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.True;
				dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.Programmatic;
				dataGridViewTextBoxColumn4.ReadOnly = true;
				dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
				dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.True;
				dataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.Programmatic;
				dataGridViewTextBoxColumn5.ReadOnly = true;
				this.Columns.AddRange(new DataGridViewColumn[]
				{
					dataGridViewTextBoxColumn,
					dataGridViewTextBoxColumn2,
					dataGridViewTextBoxColumn3,
					dataGridViewCheckBoxColumn,
					dataGridViewTextBoxColumn4,
					dataGridViewTextBoxColumn5
				});
			}
		}

		public ContextMenuStrip CreateContextMenu()
		{
			this.contextMenuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_3,
				this.toolStripSeparator1,
				this.toolStripMenuItem_4
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new Size(155, 76);
			this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_2
			});
			this.toolStripMenuItem_0.Image = Resources.smethod_24();
			this.toolStripMenuItem_0.Name = "добавитьToolStripMenuItem";
			this.toolStripMenuItem_0.Size = new Size(154, 22);
			this.toolStripMenuItem_0.Text = "Добавить";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_1_Click;
			this.toolStripMenuItem_1.Name = "группуToolStripMenuItem";
			this.toolStripMenuItem_1.Size = new Size(161, 22);
			this.toolStripMenuItem_1.Text = "Группу";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolStripMenuItem_2.Name = "элементToolStripMenuItem";
			this.toolStripMenuItem_2.Size = new Size(161, 22);
			this.toolStripMenuItem_2.Text = "Характеристику";
			this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
			this.toolStripMenuItem_3.Image = Resources.smethod_26();
			this.toolStripMenuItem_3.Name = "редактироватьToolStripMenuItem";
			this.toolStripMenuItem_3.Size = new Size(154, 22);
			this.toolStripMenuItem_3.Text = "Редактировать";
			this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(151, 6);
			this.toolStripMenuItem_4.Image = Resources.smethod_25();
			this.toolStripMenuItem_4.Name = "удаитьToolStripMenuItem";
			this.toolStripMenuItem_4.Size = new Size(154, 22);
			this.toolStripMenuItem_4.Text = "Удалить";
			this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
			return this.contextMenuStrip1;
		}

		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			this.AddCharacteristic();
		}

		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			this.AddGroupCharacteristic();
		}

		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			this.EditCharacteristic();
		}

		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			this.DeleteCharacteristic();
		}

		private void method_14(bool bool_3)
		{
			this.toolStripMenuItem_2.Enabled = bool_3;
		}

		private void method_15(string string_3)
		{
			try
			{
				base.Rows.Clear();
				SqlData.SelectSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_CharList, true, string.Format("WHERE ParentKey LIKE '{0}%' AND ParentKey != '{0}' AND Deleted = ((0)) ORDER BY TabIndex", string_3), true);
				foreach (Class107.Class285 @class in from pchar in this.class107_0.tP_CharList
				orderby pchar.TabIndex
				select pchar)
				{
					base.Rows.Add(new object[]
					{
						@class.id,
						@class.ParentId,
						@class.TabIndex,
						@class.isGroup,
						@class.Name,
						""
					});
				}
			}
			catch
			{
			}
		}

		private void method_16(SQLSettings sqlsettings_0, int int_10, string string_3, string string_4)
		{
			try
			{
				base.Rows.Clear();
				this.method_18(";Passport;DataType;", ";Passport;DateFormat;", ";Passport;DigitFormat;");
				SqlData.SelectSqlData(this.SqlSettings, this.class107_0, this.class107_0.vPassportShowData, true, string_3, true);
				List<Class107.Class222> list = this.class107_0.vPassportShowData.ToList<Class107.Class222>();
				SqlData.SelectSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_CharList, true, string_4, true);
				foreach (Class107.Class285 @class in this.class107_0.tP_CharList.ToList<Class107.Class285>())
				{
					DataView defaultView = this.class107_0.vPassportShowData.DefaultView;
					defaultView.RowFilter = string.Format("idChar = '{0}'", @class.id);
					if (defaultView.Count == 0)
					{
						base.Rows.Add(new object[]
						{
							@class.id,
							@class.ParentId,
							@class.TabIndex,
							@class.isGroup,
							@class.Name,
							""
						});
					}
					else
					{
						object obj = null;
						if (@class.Type == this.method_19("Логический"))
						{
							bool flag = false;
							if (bool.TryParse(defaultView[0]["Value"].ToString(), out flag))
							{
								obj = new DataGridViewPassport.Struct2(flag).Name;
							}
						}
						else
						{
							obj = defaultView[0]["Value"];
						}
						defaultView.RowFilter = string.Empty;
						base.Rows.Add(new object[]
						{
							@class.id,
							@class.ParentId,
							@class.TabIndex,
							@class.isGroup,
							@class.Name,
							obj
						});
					}
				}
				if (list.Count > 0 && list[0]["idEquipment"] != DBNull.Value && (int)list[0]["idEquipment"] != -1)
				{
					ObjList objList = new ObjList(this.SqlSettings);
					objList.Id = list[0].idObjList;
					if (objList.GroupType == TypeObjListGroup.Lines)
					{
						this.method_17("vP_CableReference", list[0].idEquipment);
					}
					if (objList.Type == TypeObjList.SwitchTransf)
					{
						this.method_17("vP_TransfReference", list[0].idEquipment);
					}
				}
			}
			catch
			{
			}
		}

		private void method_17(string string_3, int int_10)
		{
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(string_3, true, string.Format("WHERE id = {0}", int_10), null);
			if (dataTable.Rows.Count > 0)
			{
				base.Rows.Add(new object[]
				{
					-1,
					-1,
					-1,
					true,
					"Справочник",
					""
				});
				foreach (DataRow row in dataTable.AsEnumerable())
				{
					base.Rows.Add(new object[]
					{
						-1,
						-1,
						-1,
						false,
						row.Field("Description"),
						row.Field("Value")
					});
				}
			}
		}

		private void method_18(string string_3, string string_4, string string_5)
		{
			SqlData.SelectSqlDataTableOther(this.SqlSettings, this.class107_0, this.class107_0.tR_ParameterTypes, "tR_Classifier", true, "WHERE ParentKey LIKE '" + string_3 + "%' AND isGroup = ((0)) AND Deleted = ((0))");
			SqlData.SelectSqlDataTableOther(this.SqlSettings, this.class107_0, this.class107_0.tR_DateFormats, "tR_Classifier", true, "WHERE ParentKey LIKE '" + string_4 + "%' AND isGroup = ((0)) AND Deleted = ((0))");
			SqlData.SelectSqlDataTableOther(this.SqlSettings, this.class107_0, this.class107_0.tR_ParameterFormat, "tR_Classifier", true, "WHERE ParentKey LIKE '" + string_5 + "%' AND isGroup = ((0)) AND Deleted = ((0))");
		}

		private int method_19(string string_3)
		{
			foreach (object obj in this.class107_0.tR_ParameterTypes.Rows)
			{
				Class107.Class221 @class = (Class107.Class221)obj;
				if (@class.Name == string_3.Trim())
				{
					return @class.Id;
				}
			}
			return -1;
		}

		private int method_20(string string_3)
		{
			foreach (object obj in this.class107_0.tR_DateFormats.Rows)
			{
				Class107.Class249 @class = (Class107.Class249)obj;
				if (@class.Name == string_3.Trim())
				{
					return @class.Id;
				}
			}
			return -1;
		}

		private int method_21(int int_10)
		{
			DataView defaultView = this.class107_0.tR_ParameterFormat.DefaultView;
			defaultView.RowFilter = "id = " + int_10.ToString();
			if (defaultView.Count > 0)
			{
				return Convert.ToInt32(Math.Truncate(Convert.ToDecimal(defaultView[0]["Value"])));
			}
			return 0;
		}

		private void method_22(SQLSettings sqlsettings_0, string string_3)
		{
			this.SqlSettings = sqlsettings_0;
			this.method_18(";Passport;DataType;", ";Passport;DateFormat;", ";Passport;DigitFormat;");
			string where = string.Format("WHERE ParentKey LIKE '{0}%' AND ParentKey != '{0}' AND Deleted = 0 ORDER BY TabIndex ASC, isGroup DESC", string_3);
			if (base.Rows.Count > 0)
			{
				base.Rows.Clear();
			}
			SqlData.SelectSqlData(this.SqlSettings, this.class107_0, this.class107_0.tP_CharList, true, where, false);
			try
			{
				foreach (Class107.Class285 @class in this.class107_0.tP_CharList)
				{
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					if (@class.Type == this.method_19("Список"))
					{
						if (@class.idValueList != this.method_24("(Отсутствует)"))
						{
							dataGridViewRow = this.method_36(@class.id, @class.ParentId, @class.TabIndex, @class.isGroup, @class.Name, this.class107_0, this.method_23(this.class107_0.vP_GetValueList, @class.idValueList, @class.TableName), @class.ReadOnly);
						}
						else
						{
							dataGridViewRow = this.method_28(@class.id, @class.ParentId, @class.TabIndex, @class.isGroup, @class.Name, new DataGridViewTextBoxCell());
						}
					}
					if (@class.Type == this.method_19("Логический"))
					{
						BindingList<DataGridViewPassport.Struct2> bindingList = new BindingList<DataGridViewPassport.Struct2>();
						bindingList.Add(new DataGridViewPassport.Struct2(true));
						bindingList.Add(new DataGridViewPassport.Struct2(false));
						BindingSource bindingSource = new BindingSource();
						bindingSource.DataSource = bindingList;
						dataGridViewRow = this.hYamkGjYwEn(@class.id, @class.ParentId, @class.TabIndex, @class.isGroup, @class.Name, bindingSource, null, @class.ReadOnly);
					}
					if (@class.Type == this.method_19("Текст"))
					{
						dataGridViewRow = this.method_28(@class.id, @class.ParentId, @class.TabIndex, @class.isGroup, @class.Name, new DataGridViewTextBoxCell());
					}
					if (@class.Type == this.method_19("Дата") && @class.Format == this.method_20("ДД/ММ/ГГГГ"))
					{
						dataGridViewRow = this.method_31(@class.id, @class.ParentId, @class.TabIndex, @class.isGroup, @class.Name, 0, @class.ReadOnly);
					}
					if (@class.Type == this.method_19("Дата") && @class.Format == this.method_20("ГГГГ"))
					{
						dataGridViewRow = this.method_31(@class.id, @class.ParentId, @class.TabIndex, @class.isGroup, @class.Name, 1, @class.ReadOnly);
					}
					if (@class.Type == this.method_19("(Отсутствует)"))
					{
						dataGridViewRow = this.method_28(@class.id, @class.ParentId, @class.TabIndex, @class.isGroup, @class.Name, new DataGridViewTextBoxCell());
					}
					if (@class.Type == this.method_19("Числовой"))
					{
						int int_ = this.method_21(@class.Format);
						dataGridViewRow = this.method_30(@class.id, @class.ParentId, @class.TabIndex, @class.isGroup, @class.Name, int_, @class.ReadOnly);
					}
					dataGridViewRow.ReadOnly = @class.ReadOnly;
					base.Rows.Add(dataGridViewRow);
				}
			}
			catch
			{
			}
		}

		private DataTable method_23(Class107.Class178 class178_0, int int_10, string string_3)
		{
			string text = "Table_" + string_3 + "_" + int_10.ToString();
			if (!this.method_26(this.class107_0, text))
			{
				DataTable dataTable = new Class107.Class178();
				dataTable.TableName = text;
				this.class107_0.DataTableCollection_0.Add(dataTable);
			}
			if (this.class107_0.DataTableCollection_0[text].Rows.Count == 0)
			{
				SqlData.SelectSqlDataTableOther(this.SqlSettings, this.class107_0, this.class107_0.DataTableCollection_0[text], "vP_GetValueList", true, string.Format("WHERE ParentId = {0} AND TableName = '{1}' AND isGroup = ((0)) AND Deleted = ((0)) ORDER BY Name", int_10, string_3));
			}
			return this.class107_0.DataTableCollection_0[text];
		}

		public void UpdateComboboxData(string tableName, int parentId)
		{
			if (this.createState_0 == DataGridViewPassport.CreateState.Add || this.createState_0 == DataGridViewPassport.CreateState.EditValue)
			{
				if (base.InvokeRequired)
				{
					base.Invoke(new Action<string, int>(this.UpdateComboboxData), new object[]
					{
						tableName,
						parentId
					});
					return;
				}
				DataTable dataTable = this.class107_0.DataTableCollection_0["Table_" + tableName + "_" + parentId.ToString()];
				if (dataTable != null && dataTable.TableName.Contains("Table_" + tableName))
				{
					SqlData.SelectSqlDataTableOther(this.SqlSettings, this.class107_0, this.class107_0.DataTableCollection_0[dataTable.TableName], "vP_GetValueList", true, string.Format("WHERE ParentId = {0} AND TableName = '{1}' AND isGroup = ((0)) AND Deleted = ((0)) ORDER BY Name", parentId, tableName));
				}
			}
		}

		protected override void OnControlRemoved(ControlEventArgs e)
		{
			SqlDependency.Stop(this.SqlSettings.GetConnectionString());
			base.OnControlRemoved(e);
		}

		private int method_24(string string_3)
		{
			return (int)SqlData.CallSQLScalarFunction(this.SqlSettings, "dbo.fn_GetIdValueGroupByName", new string[]
			{
				string_3
			});
		}

		private void method_25(int int_10)
		{
			SqlData.SelectSqlData(this.SqlSettings, this.class107_0, this.class107_0.vPassportShowEditData, true, string.Format("WHERE id = {0} AND isActive = 1 AND Deleted = 0", int_10), true);
			OrderedEnumerableRowCollection<Class107.Class236> orderedEnumerableRowCollection = from pvalue in this.class107_0.vPassportShowEditData
			orderby pvalue.TabIndex
			select pvalue;
			for (int i = 0; i < base.RowCount; i++)
			{
				foreach (Class107.Class236 @class in orderedEnumerableRowCollection)
				{
					if (base.Rows[i].Cells["idChar"].Value != null && (int)base.Rows[i].Cells["idChar"].Value == @class.idChar)
					{
						if (base.Rows[i].Cells["ValueChar"].GetType() == typeof(DataGridViewCheckBoxCell))
						{
							base.Rows[i].Cells["ValueChar"].Value = (@class.value == "1");
						}
						else if (base.Rows[i].Cells["ValueChar"].GetType() == typeof(DataGridViewComboBoxCell))
						{
							bool flag = false;
							int num;
							if (int.TryParse(@class.value, out num) && num != -1)
							{
								base.Rows[i].Cells["ValueChar"].Value = num;
							}
							else if (bool.TryParse(@class.value, out flag))
							{
								base.Rows[i].Cells["ValueChar"].Value = new DataGridViewPassport.Struct2(flag).id;
							}
							else
							{
								base.Rows[i].Cells["ValueChar"].Value = null;
							}
						}
						else if (base.Rows[i].Cells["ValueChar"].GetType() == typeof(Class2))
						{
							DateTime dateTime;
							if (DateTime.TryParse(@class.value, out dateTime))
							{
								base.Rows[i].Cells["ValueChar"].Value = dateTime.Date;
							}
							else
							{
								base.Rows[i].Cells["ValueChar"].Value = null;
							}
						}
						else
						{
							base.Rows[i].Cells["ValueChar"].Value = @class.value;
						}
					}
				}
			}
		}

		private bool method_26(DataSet dataSet_0, string string_3)
		{
			return dataSet_0.Tables.Contains(string_3);
		}

		private Class107.Class208 method_27(int int_10)
		{
			EnumerableRowCollection<Class107.Class208> source = from ids in this.class107_0.tP_ObjectChar
			where ids.idObjChar == int_10
			select ids;
			if (source.Count<Class107.Class208>() == 0)
			{
				return null;
			}
			return source.First<Class107.Class208>();
		}

		private DataGridViewRow method_28(int int_10, int int_11, int int_12, bool bool_3, string string_3, DataGridViewCell dataGridViewCell_0)
		{
			DataGridViewRow dataGridViewRow = new DataGridViewRow();
			DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
			dataGridViewTextBoxCell.Value = int_10;
			dataGridViewRow.Cells.Insert(0, dataGridViewTextBoxCell);
			DataGridViewTextBoxCell dataGridViewTextBoxCell2 = new DataGridViewTextBoxCell();
			dataGridViewTextBoxCell2.Value = int_11;
			dataGridViewRow.Cells.Insert(1, dataGridViewTextBoxCell2);
			DataGridViewTextBoxCell dataGridViewTextBoxCell3 = new DataGridViewTextBoxCell();
			dataGridViewTextBoxCell3.Value = int_12;
			dataGridViewRow.Cells.Insert(2, dataGridViewTextBoxCell3);
			DataGridViewCheckBoxCell dataGridViewCheckBoxCell = new DataGridViewCheckBoxCell();
			dataGridViewCheckBoxCell.Value = bool_3;
			dataGridViewRow.Cells.Insert(3, dataGridViewCheckBoxCell);
			DataGridViewTextBoxCell dataGridViewTextBoxCell4 = new DataGridViewTextBoxCell();
			dataGridViewTextBoxCell4.Value = string_3;
			dataGridViewRow.Cells.Insert(4, dataGridViewTextBoxCell4);
			dataGridViewRow.Cells.Insert(5, dataGridViewCell_0);
			return dataGridViewRow;
		}

		private DataGridViewRow method_29(int int_10, int int_11, int int_12, bool bool_3, string string_3, object object_0, bool bool_4)
		{
			return this.method_28(int_10, int_11, int_12, bool_3, string_3, new DataGridViewTextBoxCell
			{
				ReadOnly = bool_4,
				Value = object_0
			});
		}

		private DataGridViewRow method_30(int int_10, int int_11, int int_12, bool bool_3, string string_3, int int_13, bool bool_4)
		{
			new DataGridViewRow();
			return this.method_28(int_10, int_11, int_12, bool_3, string_3, new DataGridViewNumericCell
			{
				ShowNullWhenZero = true,
				DecimalLength = int_13,
				ReadOnly = bool_4
			});
		}

		private DataGridViewRow method_31(int int_10, int int_11, int int_12, bool bool_3, string string_3, DateFormat dateFormat_0, bool bool_4)
		{
			DataGridViewRow result = new DataGridViewRow();
			if (dateFormat_0 != null)
			{
				if (dateFormat_0 == 1)
				{
					DataTable dataTable = new DataTable();
					dataTable.Columns.Add("Id");
					dataTable.Columns.Add("Name");
					for (int i = 0; i < 200; i++)
					{
						dataTable.Rows.Add(new object[]
						{
							1900 + i,
							1900 + i
						});
					}
					DataGridViewComboBoxCell dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
					BindingSource bindingSource = new BindingSource();
					bindingSource.DataSource = dataTable;
					bindingSource.Position = bindingSource.Find("id", DateTime.Now.Year);
					dataGridViewComboBoxCell.DataSource = bindingSource;
					dataGridViewComboBoxCell.ReadOnly = bool_4;
					dataGridViewComboBoxCell.DisplayMember = "Name";
					dataGridViewComboBoxCell.ValueMember = "id";
					result = this.method_28(int_10, int_11, int_12, bool_3, string_3, dataGridViewComboBoxCell);
				}
			}
			else
			{
				result = this.method_28(int_10, int_11, int_12, bool_3, string_3, new Class2
				{
					ReadOnly = bool_4
				});
			}
			return result;
		}

		private DataGridViewRow hYamkGjYwEn(int int_10, int int_11, int int_12, bool bool_3, string string_3, BindingSource bindingSource_1, string string_4, bool bool_4)
		{
			DataGridViewComboBoxCell dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
			dataGridViewComboBoxCell.ReadOnly = false;
			bindingSource_1.Sort = string_4;
			dataGridViewComboBoxCell.DataSource = bindingSource_1;
			dataGridViewComboBoxCell.ReadOnly = bool_4;
			dataGridViewComboBoxCell.DisplayMember = "Name";
			dataGridViewComboBoxCell.ValueMember = "id";
			return this.method_28(int_10, int_11, int_12, bool_3, string_3, dataGridViewComboBoxCell);
		}

		private DataGridViewRow method_32(int int_10, int int_11, int int_12, bool bool_3, string string_3, DataTable dataTable_0, bool bool_4)
		{
			return this.method_28(int_10, int_11, int_12, bool_3, string_3, new DataGridViewComboBoxCell
			{
				ReadOnly = false,
				DataSource = dataTable_0,
				ReadOnly = bool_4,
				DisplayMember = "Name",
				ValueMember = "id"
			});
		}

		private DataGridViewRow method_33(int int_10, int int_11, int int_12, bool bool_3, string string_3, DataSet dataSet_0, DataTable dataTable_0, string string_4, bool bool_4)
		{
			SqlData.SelectSqlData(this.SqlSettings, dataSet_0, dataTable_0, true, string_4, true);
			return this.method_28(int_10, int_11, int_12, bool_3, string_3, new DataGridViewComboBoxCell
			{
				DataSource = dataTable_0,
				ReadOnly = bool_4,
				DisplayMember = "Name",
				ValueMember = "id"
			});
		}

		private DataGridViewRow method_34(int int_10, int int_11, int int_12, bool bool_3, string string_3, DataSet dataSet_0, DataTable dataTable_0, string string_4, string string_5, bool bool_4)
		{
			return this.method_35(int_10, int_11, int_12, bool_3, string_3, dataSet_0, dataTable_0, "Name", string_4, string_5, bool_4);
		}

		private DataGridViewRow method_35(int int_10, int int_11, int int_12, bool bool_3, string string_3, DataSet dataSet_0, DataTable dataTable_0, string string_4, string string_5, string string_6, bool bool_4)
		{
			SqlData.SelectSqlDataTableOther(this.SqlSettings, dataSet_0, dataTable_0, string_5, true, string_6);
			return this.method_28(int_10, int_11, int_12, bool_3, string_3, new DataGridViewComboBoxCell
			{
				DataSource = dataTable_0,
				ReadOnly = bool_4,
				DisplayMember = string_4,
				ValueMember = "id"
			});
		}

		private DataGridViewRow method_36(int int_10, int int_11, int int_12, bool bool_3, string string_3, DataSet dataSet_0, DataTable dataTable_0, bool bool_4)
		{
			return this.method_28(int_10, int_11, int_12, bool_3, string_3, new DataGridViewComboBoxCell
			{
				DataSource = dataTable_0,
				ReadOnly = bool_4,
				DisplayMember = "Name",
				ValueMember = "id"
			});
		}

		private string method_37(int int_10)
		{
			return Convert.ToString(SqlData.CallSQLScalarFunction(this.SqlSettings, "dbo.fn_GetCharListKey", new string[]
			{
				int_10.ToString()
			}));
		}

		private string method_38(int int_10)
		{
			return Convert.ToString(SqlData.CallSQLScalarFunction(this.SqlSettings, "dbo.fn_GetCharListTypeCodeId", new string[]
			{
				int_10.ToString()
			}));
		}

		private int method_39(string string_3)
		{
			return Convert.ToInt32(SqlData.CallSQLScalarFunction(this.SqlSettings, "dbo.fn_GetIdCharByParentKey", new string[]
			{
				string_3
			}));
		}

		private string method_40(int int_10)
		{
			DataTable dataTable = new DataTable();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			string text = string.Format("Select ParentKey From tP_CharList Where id = (Select ParentId From tP_CharList where id = '{0}')", int_10);
			dataTable = sqlDataCommand.SelectSqlData(text);
			if (dataTable.Rows.Count > 0)
			{
				return dataTable.Rows[0]["ParentKey"].ToString();
			}
			return string.Empty;
		}

		private string method_41(int int_10)
		{
			return Convert.ToString(SqlData.CallSQLScalarFunction(this.SqlSettings, "dbo.fn_GetCharListKeyByPassport", new string[]
			{
				int_10.ToString()
			}));
		}

		private int tdwmkIbcyiT(int int_10)
		{
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData("SELECT idEquipment FROM tP_Passport WHERE isActive = ((1)) AND Deleted = ((0)) AND idObjList = " + int_10.ToString());
			if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["IdEquipment"] is int)
			{
				return (int)dataTable.Rows[0]["IdEquipment"];
			}
			return -1;
		}

		private void DataGridViewPassport_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				DataGridView.HitTestInfo hitTestInfo = base.HitTest(e.X, e.Y);
				int rowIndex = hitTestInfo.RowIndex;
				int columnIndex = hitTestInfo.ColumnIndex;
				if (rowIndex != -1)
				{
					if (columnIndex != -1)
					{
						base.CurrentCell = null;
						base.CurrentCell = base.Rows[rowIndex].Cells[columnIndex];
						return;
					}
				}
				return;
			}
		}

		private void DataGridViewPassport_KeyDown(object sender, KeyEventArgs e)
		{
			if (base.SelectedRows != null && base.SelectedRows.Count > 0 && base.SelectedRows[0].Cells["ValueChar"].GetType() == typeof(DataGridViewComboBoxCell) && e.KeyCode == Keys.Delete)
			{
				base.SelectedRows[0].Cells["ValueChar"].Value = -1;
			}
		}

		private void method_42(int int_10, int int_11)
		{
			foreach (object obj in ((IEnumerable)base.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if ((int)dataGridViewRow.Cells["idChar"].Value == int_10)
				{
					base.FirstDisplayedScrollingRowIndex = int_11;
					dataGridViewRow.Selected = true;
					break;
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_43()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DataGridViewPassport));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.idChar = new DataGridViewTextBoxColumn();
			this.ParentIdChar = new DataGridViewTextBoxColumn();
			this.TabIndexChar = new DataGridViewTextBoxColumn();
			this.isGroupChar = new DataGridViewCheckBoxColumn();
			this.NameChar = new DataGridViewTextBoxColumn();
			this.ValueChar = new DataGridViewTextBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.idChar, "idChar");
			this.idChar.Name = "idChar";
			this.idChar.ReadOnly = true;
			this.idChar.SortMode = DataGridViewColumnSortMode.Programmatic;
			componentResourceManager.ApplyResources(this.ParentIdChar, "ParentIdChar");
			this.ParentIdChar.Name = "ParentIdChar";
			this.ParentIdChar.ReadOnly = true;
			this.ParentIdChar.SortMode = DataGridViewColumnSortMode.Programmatic;
			componentResourceManager.ApplyResources(this.TabIndexChar, "TabIndexChar");
			this.TabIndexChar.Name = "TabIndexChar";
			this.TabIndexChar.ReadOnly = true;
			componentResourceManager.ApplyResources(this.isGroupChar, "isGroupChar");
			this.isGroupChar.Name = "isGroupChar";
			this.isGroupChar.ReadOnly = true;
			this.isGroupChar.Resizable = DataGridViewTriState.True;
			this.isGroupChar.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.NameChar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.NameChar.FillWeight = 150f;
			componentResourceManager.ApplyResources(this.NameChar, "NameChar");
			this.NameChar.Name = "NameChar";
			this.NameChar.ReadOnly = true;
			this.NameChar.Resizable = DataGridViewTriState.True;
			this.NameChar.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.ValueChar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			componentResourceManager.ApplyResources(this.ValueChar, "ValueChar");
			this.ValueChar.Name = "ValueChar";
			this.ValueChar.Resizable = DataGridViewTriState.True;
			this.ValueChar.SortMode = DataGridViewColumnSortMode.Programmatic;
			base.AllowUserToAddRows = false;
			base.AllowUserToDeleteRows = false;
			base.AllowUserToResizeRows = false;
			base.AutoGenerateColumns = false;
			base.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			base.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.Columns.AddRange(new DataGridViewColumn[]
			{
				this.idChar,
				this.ParentIdChar,
				this.TabIndexChar,
				this.isGroupChar,
				this.NameChar,
				this.ValueChar
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.White;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = Color.White;
			dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			base.DefaultCellStyle = dataGridViewCellStyle2;
			base.EditMode = DataGridViewEditMode.EditOnEnter;
			base.MultiSelect = false;
			base.RowHeadersVisible = false;
			base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			base.CellValueChanged += this.DataGridViewPassport_CellValueChanged;
			base.KeyDown += this.DataGridViewPassport_KeyDown;
			base.MouseDown += this.DataGridViewPassport_MouseDown;
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		private Class107 class107_0;

		private DataGridViewPassport.CreateState createState_0;

		public SQLSettings SqlSettings;

		private int int_0;

		private int int_1;

		private string string_0;

		private string string_1;

		private string string_2;

		private bool bool_0;

		private bool bool_1;

		private bool bool_2;

		private Rectangle rectangle_0;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private List<int> list_0;

		private List<Class321> list_1;

		[CompilerGenerated]
		private DataGridViewPassport.GroupChangeEventHandler groupChangeEventHandler_0;

		[CompilerGenerated]
		private DataGridViewPassport.GroupChangeEventHandler groupChangeEventHandler_1;

		private ContextMenuStrip contextMenuStrip1;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItem_1;

		private ToolStripMenuItem toolStripMenuItem_2;

		private ToolStripMenuItem toolStripMenuItem_3;

		private ToolStripSeparator toolStripSeparator1;

		private ToolStripMenuItem toolStripMenuItem_4;

		private IContainer icontainer_0;

		private DataGridViewTextBoxColumn idChar;

		private DataGridViewTextBoxColumn ParentIdChar;

		private DataGridViewTextBoxColumn TabIndexChar;

		private DataGridViewCheckBoxColumn isGroupChar;

		private DataGridViewTextBoxColumn NameChar;

		private DataGridViewTextBoxColumn ValueChar;

		private BindingSource bindingSource_0;

		public enum CreateState
		{
			Add,
			EditValue,
			EditChars,
			View,
			Copy
		}

		public enum DataCells
		{
			Id,
			ParentId,
			TabIndex,
			IsGroup,
			Name,
			Value
		}

		public enum Identifier
		{
			TypeCode,
			ObjList,
			Passport
		}

		private enum Enum8
		{

		}

		public delegate void GroupChangeEventHandler(object sender, GroupChangeEventArgs e);

		private struct Struct2
		{
			public bool id
			{
				get
				{
					return this.bool_0;
				}
			}

			public string Name
			{
				get
				{
					return this.string_0;
				}
			}

			public Struct2(bool bool_1)
			{
				Class330.Mus9JxKz1CNxy();
				if (bool_1)
				{
					this.bool_0 = true;
					this.string_0 = "Да";
					return;
				}
				this.bool_0 = false;
				this.string_0 = "Нет";
			}

			private bool bool_0;

			private string string_0;
		}
	}
}
