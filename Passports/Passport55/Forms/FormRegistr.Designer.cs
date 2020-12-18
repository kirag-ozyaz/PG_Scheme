using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Constants;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.Forms;
using DataSql;
using FormLbr;
using FormLbr.Classes;
using OfficeLB.Excel;
using OfficeLB.XMLSpreadsheet;
using Passport.Classes;
using Passport.DataSets;
using Passport.EIA;
using Passport.Forms.AirLine;
using Passport.Forms.Cable;
using Passport.Forms.Cable.Report;
using Passport.Forms.Documents.Acts;
using Passport.Forms.Reports;
using Passport.Forms.Transf;
using Passport.Properties;
using Reference.Forms;

namespace Passport.Forms
{
	public class FormRegistr : FormBase
	{
		private event GoToSchemaEventHandler onGoToSchema
		{
			[CompilerGenerated]
			add
			{
				GoToSchemaEventHandler goToSchemaEventHandler = this.goToSchemaEventHandler_0;
				GoToSchemaEventHandler goToSchemaEventHandler2;
				do
				{
					goToSchemaEventHandler2 = goToSchemaEventHandler;
					GoToSchemaEventHandler value2 = (GoToSchemaEventHandler)Delegate.Combine(goToSchemaEventHandler2, value);
					goToSchemaEventHandler = Interlocked.CompareExchange<GoToSchemaEventHandler>(ref this.goToSchemaEventHandler_0, value2, goToSchemaEventHandler2);
				}
				while (goToSchemaEventHandler != goToSchemaEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				GoToSchemaEventHandler goToSchemaEventHandler = this.goToSchemaEventHandler_0;
				GoToSchemaEventHandler goToSchemaEventHandler2;
				do
				{
					goToSchemaEventHandler2 = goToSchemaEventHandler;
					GoToSchemaEventHandler value2 = (GoToSchemaEventHandler)Delegate.Remove(goToSchemaEventHandler2, value);
					goToSchemaEventHandler = Interlocked.CompareExchange<GoToSchemaEventHandler>(ref this.goToSchemaEventHandler_0, value2, goToSchemaEventHandler2);
				}
				while (goToSchemaEventHandler != goToSchemaEventHandler2);
			}
		}

		public event GoToSchemaEventHandler GoToSchema
		{
			add
			{
				this.onGoToSchema += value;
			}
			remove
			{
				this.onGoToSchema -= value;
			}
		}

		public FormRegistr()
		{
			this.method_89();
		}

		public FormRegistr(SQLSettings SqlSettings)
		{
			this.method_89();
			this.SqlSettings = SqlSettings;
		}

		private void FormRegistr_Load(object sender, EventArgs e)
		{
			this.formProgressBar_0.FormClosing += this.formProgressBar_0_FormClosing;
			this.method_6(this.equipmentDocType_0);
			this.dateTimePicker_0 = new DateTimePicker();
			this.toolStripControlHost_0 = new ToolStripControlHost(this.dateTimePicker_0);
			this.toolStripControlHost_0.Name = "dtTSCabOperationDate";
			this.toolStrip_9.Items.Insert(0, this.toolStripControlHost_0);
			this.comboBox_0 = new ComboBox();
			this.toolStripControlHost_1 = new ToolStripControlHost(this.comboBox_0);
			this.toolStripControlHost_1.Name = "dtTSCabOperationReason";
			this.toolStrip_9.Items.Insert(1, this.toolStripControlHost_1);
			this.formRegistrSettings_0 = this.method_84();
			this.method_14(this.dataTable_0, new Columns());
			this.method_18();
			this.formProgressBar_0.TopMost = true;
		}

		private void FormRegistr_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.method_85(this.formRegistrSettings_0);
			Class110.smethod_1(this.SqlSettings, this.int_0);
			this.formProgressBar_0.Close();
		}

		private void formProgressBar_0_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.backgroundWorker_0.CancelAsync();
		}

		private void FormRegistr_Shown(object sender, EventArgs e)
		{
			this.int_0 = Class110.smethod_0(this.SqlSettings, base.Name);
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			FormRegistr.Class122 @class = new FormRegistr.Class122();
			@class.formRegistr_0 = this;
			Columns columns = new Columns();
			@class.int_0 = new int[]
			{
				-1
			};
			@class.equipmentDocType_0 = EquipmentDocType.Substation;
			SQLSettings sqlsettings = (SQLSettings)e.Argument;
			new dsPassport();
			new SqlDataCommand(sqlsettings);
			if (this.toolStripComboBox_0.Control.InvokeRequired)
			{
				Dispatcher.Invoke(this, new AsyncAction(@class.method_0));
			}
			else
			{
				@class.equipmentDocType_0 = (EquipmentDocType)this.toolStripComboBox_0.SelectedIndex;
			}
			TypeObjListGroup typeObjListGroup = this.typeObjListGroup_0;
			switch (typeObjListGroup)
			{
			case TypeObjListGroup.Substations:
			case TypeObjListGroup.AirLines:
				if (this.toolStripComboBox_1.Control.InvokeRequired)
				{
					Dispatcher.Invoke(this, new AsyncAction(@class.method_1));
					if (this.formRegistrSettings_0 != null)
					{
						columns = this.formRegistrSettings_0.AirLineColumns;
					}
				}
				else
				{
					@class.int_0 = new int[]
					{
						(int)((ComboBox)this.toolStripComboBox_1.Control).SelectedValue
					};
					if (@class.int_0[0] == -1)
					{
						@class.int_0 = this.method_0(this.typeObjListGroup_0);
					}
				}
				if (this.formRegistrSettings_0 != null)
				{
					columns = this.formRegistrSettings_0.SubstationColumns;
				}
				break;
			case TypeObjListGroup.Clutches:
			case TypeObjListGroup.Lines:
				return;
			case TypeObjListGroup.CableLines:
				@class.int_0 = new int[]
				{
					546
				};
				if (this.formRegistrSettings_0 != null)
				{
					columns = this.formRegistrSettings_0.CableLineColumns;
				}
				break;
			default:
				if (typeObjListGroup != TypeObjListGroup.Switches)
				{
					if (typeObjListGroup != TypeObjListGroup.VoltageTransformer)
					{
						return;
					}
					@class.int_0 = new int[]
					{
						603
					};
					if (this.formRegistrSettings_0 != null)
					{
						columns = this.formRegistrSettings_0.VoltageTransformerColumns;
					}
				}
				else
				{
					FormRegistr.Class122 class2 = @class;
					int[] array;
					if (@class.equipmentDocType_0 != EquipmentDocType.PowerTransformer)
					{
						if (@class.equipmentDocType_0 != EquipmentDocType.VoltageTransformer)
						{
							(array = new int[1])[0] = -1;
						}
						else
						{
							(array = new int[1])[0] = 603;
						}
					}
					else
					{
						(array = new int[1])[0] = 556;
					}
					class2.int_0 = array;
					if (this.formRegistrSettings_0 != null)
					{
						columns = ((@class.equipmentDocType_0 == EquipmentDocType.PowerTransformer) ? this.formRegistrSettings_0.TransformerColumns : ((@class.equipmentDocType_0 == EquipmentDocType.VoltageTransformer) ? this.formRegistrSettings_0.VoltageTransformerColumns : new Columns()));
					}
				}
				break;
			}
			Dispatcher.Invoke(this, new AsyncAction(this.method_90));
			e.Result = new bwRegistrGeneralParameter(columns, PassportData.GetJournalData(this.SqlSettings, @class.int_0));
			if (this.backgroundWorker_0.CancellationPending)
			{
				e.Cancel = true;
				return;
			}
			Dispatcher.Invoke(this, new AsyncAction(this.method_91));
		}

		private int[] method_0(TypeObjListGroup typeObjListGroup_1)
		{
			string arg = string.Join(",", ObjList.GetGroupValue(typeObjListGroup_1).Select(new Func<decimal, string>(FormRegistr.<>c.<>9.method_0)).ToArray<string>());
			DataTable dataTable = base.SelectSqlData("tR_Classifier", true, string.Format("WHERE Parentkey = '{0}' AND Value IN ({1}) AND isGroup = ((0)) AND Deleted = ((0))", ObjList.GetGroupParentKey(typeObjListGroup_1), arg));
			int[] array = new int[dataTable.Rows.Count];
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				array[i] = (int)dataTable.Rows[i]["id"];
			}
			return array;
		}

		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			bwRegistrGeneralParameter bwRegistrGeneralParameter = (bwRegistrGeneralParameter)e.Result;
			Columns columns = bwRegistrGeneralParameter.Columns;
			this.dataTable_0 = bwRegistrGeneralParameter.Table;
			this.method_14(this.dataTable_0, columns);
			if (this.dataTable_0.Rows.Count > 0)
			{
				BindingSource bindingSource = new BindingSource();
				bindingSource.DataSource = this.dataTable_0;
				if (this.bool_1)
				{
					bindingSource.Filter = this.string_1;
					bindingSource.Sort = this.string_0;
					this.bool_1 = false;
				}
				this.dataGridViewExcelFilter_0.DataSource = bindingSource;
				this.method_19();
				this.method_18();
				if (this.bool_0)
				{
					this.method_27(this.dataGridViewExcelFilter_0, "Id", this.int_1, this.int_2);
					this.bool_0 = false;
				}
				if (this.method_28("FormSearch"))
				{
					this.formSearch_0.dataGridView = this.dataGridViewExcelFilter_0;
				}
			}
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.RowCount > 0)
			{
				new FormReports(this.dataGridViewExcelFilter_0.ToDataTable(true))
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.dataGridViewExcelFilter_0.RowCount > 0)
				{
					FormRegistr.Class123 @class = new FormRegistr.Class123();
					@class.formRegistr_0 = this;
					@class.dataGridViewParse_0 = new DataGridViewParse(this.dataGridViewExcelFilter_0, false, "IdObj");
					Thread thread = new Thread(new ThreadStart(@class.method_0));
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			this.toolStripButton_2.Enabled = false;
			if (this.toolStripComboBox_0.SelectedIndex >= 0)
			{
				this.Text = "Журнал оборудования : " + this.toolStripComboBox_0.Text + (this.toolStripComboBox_1.Visible ? (" - " + this.toolStripComboBox_1.Text) : "");
				this.equipmentDocType_0 = (EquipmentDocType)this.toolStripComboBox_0.SelectedIndex;
				this.method_6(this.equipmentDocType_0);
				this.backgroundWorker_0.RunWorkerAsync(this.SqlSettings);
				this.dataGridViewExcelFilter_0.Focus();
			}
		}

		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.Rows.Count > 0)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					if (form is FormSearch)
					{
						form.Activate();
						return;
					}
				}
				this.formSearch_0 = new FormSearch(this.dataGridViewExcelFilter_0);
				this.formSearch_0.Show();
			}
		}

		private void toolStripButton_6_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				int int_ = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value;
				this.method_26(int_);
				return;
			}
			this.method_25(true);
		}

		private void toolStripMenuItem_37_Click(object sender, EventArgs e)
		{
			if (new FormAddTransfPassport(this.SqlSettings, true).ShowDialog() == DialogResult.OK)
			{
				this.method_25(false);
			}
		}

		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				this.method_1();
			}
		}

		private void method_1()
		{
			ObjList objList = new ObjList(this.SqlSettings);
			objList.Id = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value;
			StateFormCreate stateFormCreate;
			if (objList.IdPassport != -1)
			{
				stateFormCreate = 1;
			}
			else
			{
				stateFormCreate = 0;
			}
			if (new FormAddEditValuePassportChars(this.SqlSettings, stateFormCreate, objList.Id, objList.IdPassport).ShowDialog() == DialogResult.OK)
			{
				this.method_26(objList.Id);
				Class110.smethod_2(this.SqlSettings, this.int_0, stateFormCreate);
			}
		}

		private void toolStripMenuItem_38_Click(object sender, EventArgs e)
		{
			FormTransfRename formTransfRename = new FormTransfRename(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			if (formTransfRename.ShowDialog() == DialogResult.OK)
			{
				this.method_26(formTransfRename.Id);
				Class110.smethod_2(this.SqlSettings, this.int_0, 1);
			}
		}

		private void toolStripMenuItem_65_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormTransfMove formTransfMove = new FormTransfMove();
				formTransfMove.SqlSettings = this.SqlSettings;
				formTransfMove.IdObjList = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value;
				formTransfMove.Direction = this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Расположение"].Value.ToString();
				if (formTransfMove.ShowDialog() == DialogResult.OK)
				{
					this.method_26(formTransfMove.IdObjList);
					Class110.smethod_2(this.SqlSettings, this.int_0, 8);
				}
			}
		}

		private void toolStripMenuItem_40_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				int num = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value;
				SchmObj.UnbindPassport(this.SqlSettings, num);
				this.method_26(num);
				Class110.smethod_2(this.SqlSettings, this.int_0, 10);
			}
		}

		private void toolStripMenuItem_41_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				int num = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value;
				if (new FormUnbindCablePassport(this.SqlSettings, num).ShowDialog() == DialogResult.OK)
				{
					this.method_26(num);
					Class110.smethod_2(this.SqlSettings, this.int_0, 9);
				}
			}
		}

		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить паспорт?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.bool_1 = true;
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_Passport, true, string.Format("where id = {0} and isActive = 1", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["IdPassport"].Value), true);
				this.dsPassport_0.tP_Passport.Rows[0]["Deleted"] = true;
				this.dsPassport_0.tP_Passport.Rows[0]["IsActive"] = false;
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_Passport);
				this.method_25(true);
				Class110.smethod_2(this.SqlSettings, this.int_0, 2);
			}
		}

		private void toolStripMenuItem_55_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы действительно хотите удалить трансформатор?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.bool_1 = true;
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tSchm_ObjList, true, string.Format("where id = {0}", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value), true);
				this.dsPassport_0.tSchm_ObjList.Rows[0]["Deleted"] = true;
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tSchm_ObjList);
				this.method_25(true);
				Class110.smethod_2(this.SqlSettings, this.int_0, 2);
			}
		}

		private void toolStripButton_62_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value is int)
			{
				FormLoadOldCablePassport formLoadOldCablePassport = new FormLoadOldCablePassport(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
				formLoadOldCablePassport.MdiParent = base.MdiParent;
				formLoadOldCablePassport.FormClosing += this.method_2;
				formLoadOldCablePassport.Show();
			}
		}

		private void method_2(object sender, FormClosingEventArgs e)
		{
			this.method_25(true);
		}

		private void toolStripMenuItem_60_Click(object sender, EventArgs e)
		{
			if (this.equipmentDocType_0 == EquipmentDocType.Cable && this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormCable formCable = new FormCable();
				formCable.FormClosed += this.method_4;
				formCable.MdiParent = base.MdiParent;
				formCable.SqlSettings = this.SqlSettings;
				formCable.ViewButtons = true;
				formCable.Show();
			}
			if (this.equipmentDocType_0 == EquipmentDocType.PowerTransformer && this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormTrasformer formTrasformer = new FormTrasformer();
				formTrasformer.FormClosed += this.method_3;
				formTrasformer.MdiParent = base.MdiParent;
				formTrasformer.SqlSettings = this.SqlSettings;
				formTrasformer.ViewButtons = true;
				formTrasformer.Show();
			}
		}

		private void method_3(object sender, FormClosedEventArgs e)
		{
			FormTrasformer formTrasformer = (FormTrasformer)sender;
			if (formTrasformer.DialogResult == DialogResult.OK)
			{
				int num = this.method_5(formTrasformer.Id);
				DataTable dataTable = base.SelectSqlData("vP_ReferenceToPassport", true, "WHERE id = " + formTrasformer.Id.ToString());
				Class114.smethod_5(this.SqlSettings, num, 92, dataTable.Rows[0]["Type"].ToString());
				Class114.smethod_5(this.SqlSettings, num, 93, dataTable.Rows[0]["Power"].ToString());
				Class114.smethod_5(this.SqlSettings, num, 96, dataTable.Rows[0]["HighVoltage"].ToString());
				Class114.smethod_5(this.SqlSettings, num, 97, dataTable.Rows[0]["LowVoltage"].ToString());
				Class114.smethod_6(this.SqlSettings, num, 253, dataTable.Rows[0]["RatedAmperHV"].ToString(), false);
				Class114.smethod_6(this.SqlSettings, num, 228, dataTable.Rows[0]["RatedAmperLV"].ToString(), false);
				Class114.smethod_5(this.SqlSettings, num, 99, dataTable.Rows[0]["GroupWindings"].ToString());
				Class114.smethod_5(this.SqlSettings, num, 254, dataTable.Rows[0]["ShortCircuitVolt"].ToString());
				Class114.smethod_5(this.SqlSettings, num, 255, dataTable.Rows[0]["ShortCircuitLoss"].ToString());
				Class114.smethod_5(this.SqlSettings, num, 256, dataTable.Rows[0]["NoLoadLoss"].ToString());
				this.method_25(true);
			}
		}

		private void method_4(object sender, FormClosedEventArgs e)
		{
			FormCable formCable = (FormCable)sender;
			if (formCable.DialogResult == DialogResult.OK)
			{
				this.method_5(formCable.Id);
				this.method_25(true);
			}
		}

		private int method_5(int int_5)
		{
			int idObjList = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value;
			int num = (this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["IdPassport"].Value == DBNull.Value || !(this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["IdPassport"].Value is int)) ? -1 : ((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["IdPassport"].Value);
			if (num != -1)
			{
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_Passport, true, "WHERE id = " + num.ToString());
				dsPassport.Class62 @class = this.dsPassport_0.tP_Passport.First<dsPassport.Class62>();
				@class.idEquipment = int_5;
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_Passport);
				num = @class.Int32_0;
			}
			else
			{
				dsPassport.Class62 class2 = this.dsPassport_0.tP_Passport.method_5();
				class2.idEquipment = int_5;
				class2.idObjList = idObjList;
				class2.Number = 0;
				class2.Date = DateTime.Now;
				class2.DateIn = DateTime.Now;
				class2.isActive = true;
				class2.Deleted = false;
				this.dsPassport_0.tP_Passport.method_0(class2);
				num = base.InsertSqlDataOneRow(this.dsPassport_0, this.dsPassport_0.tP_Passport);
			}
			return num;
		}

		private bool TypeSubsVisible
		{
			get
			{
				return this.toolStripComboBox_1.Visible;
			}
			set
			{
				ToolStripItem toolStripItem = this.toolStripSeparator_5;
				this.toolStripComboBox_1.Visible = value;
				toolStripItem.Visible = value;
			}
		}

		private void method_6(EquipmentDocType equipmentDocType_1)
		{
			this.toolStripMenuItem_60.Visible = (equipmentDocType_1 == EquipmentDocType.Cable || equipmentDocType_1 == EquipmentDocType.PowerTransformer);
			this.toolStripSeparator_0.Visible = (equipmentDocType_1 == EquipmentDocType.PowerTransformer || equipmentDocType_1 == EquipmentDocType.Cable);
			this.toolStripMenuItem_1.Visible = (this.toolStripMenuItem_37.Visible = (equipmentDocType_1 == EquipmentDocType.PowerTransformer));
			this.toolStripMenuItem_41.Visible = (this.toolStripMenuItem_40.Visible = (this.toolStripButton_62.Visible = (this.toolStripMenuItem_59.Visible = (equipmentDocType_1 == EquipmentDocType.Cable))));
			this.TotalVisible = (equipmentDocType_1 == EquipmentDocType.Substation);
			this.toolStripButton_21.Visible = (equipmentDocType_1 == EquipmentDocType.Substation);
			this.toolStripButton_20.Visible = (equipmentDocType_1 == EquipmentDocType.Substation);
			switch (equipmentDocType_1)
			{
			case EquipmentDocType.None:
				break;
			case EquipmentDocType.Substation:
				this.VisibleTabRange(this.tabControl_0, this.method_7());
				return;
			case EquipmentDocType.PowerTransformer:
				this.VisibleTabRange(this.tabControl_0, this.method_8());
				return;
			case EquipmentDocType.Cable:
				this.VisibleTabRange(this.tabControl_0, this.method_9());
				return;
			case EquipmentDocType.AirLine:
				this.VisibleTabRange(this.tabControl_0, this.method_10());
				return;
			case EquipmentDocType.VoltageTransformer:
				this.VisibleTabRange(this.tabControl_0, this.method_11());
				break;
			default:
				return;
			}
		}

		public void VisibleTabRange(TabControl control, IEnumerable<TabPage> page)
		{
			foreach (object obj in control.TabPages)
			{
				((TabPage)obj).Parent = null;
			}
			foreach (TabPage tabPage in page)
			{
				if (tabPage.Parent == null)
				{
					tabPage.Parent = control;
				}
			}
		}

		private List<TabPage> method_7()
		{
			return new List<TabPage>
			{
				this.tabPage_0,
				this.tabPage_3,
				this.tabPage_4
			};
		}

		private List<TabPage> method_8()
		{
			return new List<TabPage>
			{
				this.tabPage_5,
				this.tabPage_0
			};
		}

		private List<TabPage> method_9()
		{
			return new List<TabPage>
			{
				this.tabPage_1,
				this.tabPage_2,
				this.tabPage_12,
				this.tabPage_8,
				this.tabPage_7,
				this.tabPage_6,
				this.tabPage_3,
				this.tabPage_9
			};
		}

		private List<TabPage> method_10()
		{
			return new List<TabPage>
			{
				this.tabPage_10,
				this.tabPage_11,
				this.tabPage_3
			};
		}

		private List<TabPage> method_11()
		{
			return new List<TabPage>
			{
				this.tabPage_0,
				this.tabPage_3
			};
		}

		private void method_12(TypeObjListGroup typeObjListGroup_1)
		{
			this.dsPassport_0.tR_Classifier.Rows.Clear();
			string arg = string.Join(",", ObjList.GetGroupValue(typeObjListGroup_1).Select(new Func<decimal, string>(FormRegistr.<>c.<>9.method_1)).ToArray<string>());
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tR_Classifier, true, string.Format("WHERE Parentkey = '{0}' AND Value IN ({1}) AND isGroup = ((0)) AND Deleted = ((0))", ObjList.GetGroupParentKey(typeObjListGroup_1), arg));
			dsPassport.Class25 @class = this.dsPassport_0.tR_Classifier.method_5();
			@class.Id = -1;
			@class.Name = "Все";
			@class.method_5(false);
			@class.method_7(false);
			this.dsPassport_0.tR_Classifier.Rows.InsertAt(@class, 0);
			ComboBox comboBox = (ComboBox)this.toolStripComboBox_1.Control;
			comboBox.DataSource = this.dsPassport_0.tR_Classifier;
			comboBox.DisplayMember = "Name";
			comboBox.ValueMember = "id";
		}

		private bool method_13(string string_2)
		{
			bool result = false;
			for (int i = 0; i < string_2.Length; i++)
			{
				result = ((string_2[i] >= 'a' && string_2[i] <= 'z') || (string_2[i] >= 'A' && string_2[i] <= 'Z'));
			}
			return result;
		}

		private void method_14(DataTable dataTable_1, Columns columns_0)
		{
			bool flag = true;
			int index = 0;
			this.dataGridViewExcelFilter_0.DataSource = null;
			this.dataGridViewExcelFilter_0.Columns.Clear();
			this.dataGridView_4.Rows.Clear();
			this.dataGridView_4.Columns.Clear();
			this.dataGridView_4.RowHeadersWidth = this.dataGridViewExcelFilter_0.RowHeadersWidth;
			if (dataTable_1.Rows.Count == 0)
			{
				this.method_15();
			}
			else
			{
				if (columns_0 != null && columns_0.Count > 0)
				{
					using (IEnumerator enumerator = columns_0.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							Column column = (Column)obj;
							this.method_16(ref flag, ref index, dataTable_1.Columns[columns_0[index].Name]);
						}
						goto IL_10F;
					}
				}
				foreach (object obj2 in dataTable_1.Columns)
				{
					DataColumn dataColumn_ = (DataColumn)obj2;
					this.method_16(ref flag, ref index, dataColumn_);
				}
			}
			IL_10F:
			foreach (object obj3 in dataTable_1.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj3;
				dataColumn.ColumnName = dataColumn.ColumnName.Replace(",", "");
			}
		}

		private void method_15()
		{
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn.HeaderText = "Нет данных";
			dataGridViewTextBoxColumn.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewTextBoxColumn.ReadOnly = true;
			dataGridViewTextBoxColumn.Visible = true;
			this.dataGridView_4.Columns.Add((DataGridViewTextBoxColumn)dataGridViewTextBoxColumn.Clone());
			this.dataGridViewExcelFilter_0.Columns.Add(dataGridViewTextBoxColumn);
		}

		private void method_16(ref bool bool_3, ref int int_5, DataColumn dataColumn_0)
		{
			DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn = new DataGridViewFilterTextBoxColumn();
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = (DataGridViewTextBoxColumn)dataGridViewFilterTextBoxColumn.Clone();
			dataGridViewFilterTextBoxColumn.DataPropertyName = dataColumn_0.ColumnName.Replace(",", "");
			dataGridViewFilterTextBoxColumn.Visible = !this.method_13(dataColumn_0.Caption);
			dataGridViewTextBoxColumn.Visible = !this.method_13(dataColumn_0.Caption);
			if (bool_3 && dataGridViewFilterTextBoxColumn.Visible)
			{
				bool_3 = false;
				dataGridViewFilterTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				dataGridViewFilterTextBoxColumn.Width = 110;
				dataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				dataGridViewTextBoxColumn.Width = 110;
				this.int_3 = int_5;
			}
			else
			{
				dataGridViewFilterTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			}
			dataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dataGridViewFilterTextBoxColumn.HeaderText = dataColumn_0.Caption;
			dataGridViewFilterTextBoxColumn.Name = dataColumn_0.ColumnName;
			dataGridViewTextBoxColumn.Name = dataColumn_0.ColumnName;
			dataGridViewFilterTextBoxColumn.Tag = this.method_17(dataColumn_0);
			dataGridViewFilterTextBoxColumn.ReadOnly = true;
			dataGridViewTextBoxColumn.ReadOnly = true;
			this.dataGridView_4.Columns.Add(dataGridViewTextBoxColumn);
			this.dataGridViewExcelFilter_0.Columns.Add(dataGridViewFilterTextBoxColumn);
			int_5++;
		}

		private int method_17(DataColumn dataColumn_0)
		{
			string columnName = dataColumn_0.ColumnName;
			if (!(columnName == "Количество ВН") && !(columnName == "Количество МВ") && !(columnName == "Количество ячеек 0,4 кВ") && !(columnName == "Количество РВ") && !(columnName == "Количество ячеек 6-10 кВ") && !(columnName == "Количество ВВ"))
			{
				return 0;
			}
			return 1;
		}

		private void method_18()
		{
			if (this.dataGridView_4.Columns.Count > 1 && this.TotalVisible)
			{
				if (this.dataGridView_4.Rows.Count == 0)
				{
					this.dataGridView_4.Rows.Add();
				}
				this.dataGridView_4.RowHeadersWidth = this.dataGridViewExcelFilter_0.RowHeadersWidth;
				this.dataGridView_4.BorderStyle = BorderStyle.None;
				this.dataGridView_4.Rows[0].HeaderCell.Value = "Итого: ";
				int width = TextRenderer.MeasureText(this.dataGridView_4.Rows[0].HeaderCell.Value.ToString(), this.dataGridView_4.RowHeadersDefaultCellStyle.Font).Width;
				this.dataGridView_4.RowHeadersWidth += width;
				this.dataGridView_4.Columns[this.int_3].Width = this.dataGridViewExcelFilter_0.RowHeadersWidth + this.dataGridViewExcelFilter_0.Columns[this.int_3].Width - this.dataGridView_4.RowHeadersWidth;
			}
		}

		private void method_19()
		{
			if (this.dataGridViewExcelFilter_0.RowCount > 0 && this.TotalVisible)
			{
				if (this.dataGridView_4.Rows.Count == 0)
				{
					this.dataGridView_4.Rows.Add();
				}
				foreach (object obj in this.dataGridViewExcelFilter_0.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					if ((int)dataGridViewColumn.Tag == 1)
					{
						int num = 0;
						foreach (object obj2 in ((IEnumerable)this.dataGridViewExcelFilter_0.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
							if ((int)dataGridViewColumn.Tag == 1)
							{
								int num2 = 0;
								if (int.TryParse(dataGridViewRow.Cells[dataGridViewColumn.Index].Value.ToString(), out num2))
								{
									num += num2;
								}
							}
						}
						this.dataGridView_4.Rows[0].Cells[dataGridViewColumn.Index].Value = num;
					}
				}
			}
		}

		private void dataGridViewExcelFilter_0_Scroll(object sender, ScrollEventArgs e)
		{
			this.dataGridView_4.HorizontalScrollingOffset = this.dataGridViewExcelFilter_0.HorizontalScrollingOffset;
		}

		private void dataGridViewExcelFilter_0_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			if (e.Column.Index == this.int_3 && this.TotalVisible)
			{
				this.method_18();
				return;
			}
			this.dataGridView_4.Columns[e.Column.Index].Width = e.Column.Width;
		}

		private void dataGridViewExcelFilter_0_RowHeadersWidthChanged(object sender, EventArgs e)
		{
			this.method_18();
		}

		private void dataGridViewExcelFilter_0_BindingContextChanged(object sender, EventArgs e)
		{
			this.method_19();
		}

		private void dataGridViewExcelFilter_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.method_19();
		}

		private void dataGridViewExcelFilter_0_SelectionChanged(object sender, EventArgs e)
		{
			this.method_23();
			this.method_24();
		}

		private bool TotalVisible
		{
			get
			{
				return this.tableLayoutPanel_6.RowStyles[1].Height == 28f;
			}
			set
			{
				this.tableLayoutPanel_6.RowStyles[1].Height = (value ? 28f : 0f);
			}
		}

		public void DataToExcel(object[] _caption, object[,] _data, int _rowCount, int _columnCount, int[] _headerWidth)
		{
			try
			{
				Application application = null;
				try
				{
					application = new Application();
					application.ScreenUpdating = false;
					new Workbooks();
					Workbooks bookCollection = application.BookCollection;
					Workbook workbook = new Workbook();
					workbook = bookCollection.Add();
					new Worksheets();
					Worksheets worksheets = workbook.Worksheets;
					Worksheet worksheet = new Worksheet();
					worksheet = worksheets[1];
					worksheet.Name = "Test";
					new Rows();
					worksheet.Rows(1, 1).RowHeight = 73.5;
					new Columns();
					new Range();
					for (int i = 1; i < _columnCount + 1; i++)
					{
						worksheet.Columns(i, i).ColumnWidth = (double)_headerWidth[i - 1] / 7.5;
						Range range = worksheet.Range(i, 1);
						range.RowHeight = 80.0;
						range.Orientation = 90.0;
						range.Value = _caption[i - 1];
						range.HorizontalAlignment = 3;
						range.VerticalAlignment = 2;
						range.Borders.Weight = 2;
						range.WrapText = true;
						range.Font.FontStyle = "полужирный";
					}
					new Range();
					Range range2 = worksheet.Range(1, 2, _columnCount, _rowCount + 1);
					range2.Value = _data;
					range2.Font.Size = 8.25;
					range2.WrapText = true;
					range2.Borders.Weight = 2;
					new PageSetup(workbook.ActiveSheet.PageSetup);
					application.Visible = true;
					application.ScreenUpdating = true;
				}
				catch (Exception)
				{
					throw new Exception("Ошибка формирования отчета в Excel.");
				}
				finally
				{
					application.Dispose();
				}
			}
			catch (Exception)
			{
				this.DataToXMLSpreadsheet(_caption, _headerWidth, _data, _rowCount, _columnCount);
			}
		}

		public void DataToXMLSpreadsheet(object[] _caption, int[] columnWidth, object[,] _data, int _rowCount, int _columnCount)
		{
			FormRegistr.Class124 @class = new FormRegistr.Class124();
			@class.formRegistr_0 = this;
			@class.xmlSpreadsheet_0 = new XmlSpreadsheet();
			if (this.toolStripComboBox_0.Control.InvokeRequired)
			{
				Dispatcher.Invoke(this, new AsyncAction(@class.method_0));
			}
			else
			{
				@class.xmlSpreadsheet_0.SheetName = this.toolStripComboBox_0.SelectedItem.ToString();
			}
			string value = @class.xmlSpreadsheet_0.GenerateSpreadsheet(_caption, columnWidth, _data, _columnCount, _rowCount);
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Report.xls";
			using (TextWriter textWriter = new StreamWriter(text))
			{
				textWriter.Write(value);
			}
			Process.Start(text);
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private bool method_20(int int_5)
		{
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_Passport, true, "where idObjList = " + int_5.ToString());
			return this.dsPassport_0.tP_Passport.Rows.Count > 0;
		}

		private bool method_21(int int_5)
		{
			return base.SelectSqlData("tSchm_ObjList", true, " INNER JOIN tR_Classifier AS ctr ON tSchm_ObjList.TypeCodeId = ctr.id AND ctr.ParentKey = ';SCM;INLINE_OBJ;SWITCH;' AND Value = 11 LEFT JOIN tR_Classifier AS c ON tSchm_ObjList.[Location] = c.id LEFT JOIN tSchm_Xml AS x ON tSchm_ObjList.id = x.ObjId WHERE tSchm_ObjList.Deleted = 0 AND (x.id IS NULL OR tSchm_ObjList.idParent IS NULL) AND tSchm_ObjList.id = " + int_5.ToString()).Rows.Count > 0;
		}

		private void method_22(int int_5, int int_6)
		{
			FormRegistr.Class125 @class = new FormRegistr.Class125();
			@class.int_0 = int_5;
			SqlConnection sqlConnection = new SqlConnection();
			SqlCommand sqlCommand = new SqlCommand();
			try
			{
				sqlConnection.ConnectionString = "Data Source=192.168.8.252;Initial Catalog=GES;Integrated Security=True";
				sqlConnection.Open();
				string commandText = "SELECT TOP 1 p_xml.SchemaXml FROM [tSchm_ObjList] obj INNER JOIN tSchm_Relation AS rel ON obj.IdParent = rel.Id INNER JOIN tSchm_Xml AS p_xml ON rel.Edge = p_xml.ObjId WHERE obj.Id = @ID";
				sqlCommand.CommandText = commandText;
				sqlCommand.Connection = sqlConnection;
				sqlCommand.Parameters.AddWithValue("@ID", @class.int_0);
				XmlReader xmlReader = sqlCommand.ExecuteXmlReader();
				if (xmlReader.Read())
				{
					XDocument xdocument = XDocument.Load(xmlReader);
					foreach (XAttribute xattribute in xdocument.Root.Descendants("objOnLine").Where(new Func<XElement, bool>(@class.method_0)).Select(new Func<XElement, XAttribute>(FormRegistr.<>c.<>9.method_2)))
					{
						xattribute.Value = int_6.ToString();
					}
					sqlCommand = new SqlCommand("Update Setting set SettingXml=@Settingxml where settingId=5", sqlConnection);
					sqlCommand.Parameters.Add(new SqlParameter("@SettingXml", SqlDbType.Xml)).Value = xdocument;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				sqlCommand.Dispose();
				sqlConnection.Close();
			}
		}

		private void method_23()
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				int num = -1;
				bool flag = this.equipmentDocType_0 == EquipmentDocType.Cable && this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["IdPassport"].Value != null && int.TryParse(this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["IdPassport"].Value.ToString(), out num);
				this.toolStripMenuItem_41.Visible = !flag;
				this.toolStripMenuItem_40.Visible = flag;
			}
		}

		private void method_24()
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0 && this.tabControl_0.SelectedTab != null)
			{
				string name = this.tabControl_0.SelectedTab.Name;
				uint num = Class121.smethod_0(name);
				if (num <= 2595791151u)
				{
					if (num <= 800545201u)
					{
						if (num != 631819020u)
						{
							if (num != 764423950u)
							{
								if (num != 800545201u)
								{
									return;
								}
								if (!(name == "tpClutchEnd"))
								{
									return;
								}
								this.dataGridView_11.DataSource = Clutch.GetData(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, TypeObjList.ClutchEnd, false);
								if (this.dataGridView_11.ColumnCount != 0)
								{
									if (this.dataGridView_11.Columns.Contains("Id"))
									{
										this.dataGridView_11.Columns["Id"].Visible = false;
									}
									if (this.dataGridView_11.Columns.Contains("IdObjList"))
									{
										this.dataGridView_11.Columns["IdObjList"].Visible = false;
									}
									if (this.dataGridView_11.Columns.Contains("Name"))
									{
										this.dataGridView_11.Columns["Name"].HeaderText = "Наименование";
									}
									if (this.dataGridView_11.Columns.Contains("idEquipment"))
									{
										this.dataGridView_11.Columns["idEquipment"].Visible = false;
										return;
									}
								}
							}
							else
							{
								if (!(name == "tpCableTesting"))
								{
									return;
								}
								base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
								this.dataGridView_9.DataSource = this.bindingSource_6;
								return;
							}
						}
						else
						{
							if (!(name == "tpClutchConnection"))
							{
								return;
							}
							this.dataGridView_2.DataSource = Clutch.GetData(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, TypeObjList.ClutchConnecting, false);
							if (this.dataGridView_2.ColumnCount != 0)
							{
								if (this.dataGridView_2.Columns.Contains("Id"))
								{
									this.dataGridView_2.Columns["Id"].Visible = false;
								}
								if (this.dataGridView_2.Columns.Contains("IdObjList"))
								{
									this.dataGridView_2.Columns["IdObjList"].Visible = false;
								}
								if (this.dataGridView_2.Columns.Contains("Name"))
								{
									this.dataGridView_2.Columns["Name"].HeaderText = "Наименование";
									return;
								}
							}
						}
					}
					else if (num != 2146558549u)
					{
						if (num != 2204269024u)
						{
							if (num != 2595791151u)
							{
								return;
							}
							if (!(name == "tpAirLinePole"))
							{
								return;
							}
							this.method_68((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
							return;
						}
						else
						{
							if (!(name == "tpRepair"))
							{
								return;
							}
							this.method_35();
							return;
						}
					}
					else
					{
						if (!(name == "tpCabSections"))
						{
							return;
						}
						this.method_42();
						return;
					}
				}
				else if (num <= 3484434301u)
				{
					if (num != 2780731656u)
					{
						if (num != 2937142895u)
						{
							if (num != 3484434301u)
							{
								return;
							}
							if (!(name == "tpAirLineSpan"))
							{
								return;
							}
							this.method_74((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
							return;
						}
						else
						{
							if (!(name == "tpBalance"))
							{
								return;
							}
							this.method_46();
							return;
						}
					}
					else
					{
						if (!(name == "tpTehConnect"))
						{
							return;
						}
						this.method_81();
					}
				}
				else if (num <= 3571902120u)
				{
					if (num != 3546228653u)
					{
						if (num != 3571902120u)
						{
							return;
						}
						if (!(name == "tpMove"))
						{
							return;
						}
						this.method_31((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
						return;
					}
					else
					{
						if (!(name == "tpCabProtocol"))
						{
							return;
						}
						base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
						this.bindingSource_4.ResetBindings(false);
						this.dataGridView_7.DataSource = this.bindingSource_4;
						return;
					}
				}
				else if (num != 3939594295u)
				{
					if (num != 4114576574u)
					{
						return;
					}
					if (!(name == "tpBuildRepair"))
					{
						return;
					}
					this.RefreshConboBoxDataBuildRepair();
					this.dataGridView_5.DataSource = PassportData.GetBuildRepairData(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
					return;
				}
				else
				{
					if (!(name == "tpCableOperation"))
					{
						return;
					}
					this.method_62();
					base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_CabOperation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
					this.dataGridView_8.DataSource = this.bindingSource_5;
					this.method_61();
					return;
				}
			}
		}

		private void method_25(bool bool_3)
		{
			this.bool_1 = bool_3;
			this.int_2 = (bool_3 ? this.dataGridViewExcelFilter_0.FirstDisplayedScrollingRowIndex : -1);
			this.string_0 = ((BindingSource)this.dataGridViewExcelFilter_0.DataSource).Sort;
			this.string_1 = ((BindingSource)this.dataGridViewExcelFilter_0.DataSource).Filter;
			this.backgroundWorker_0.RunWorkerAsync(this.SqlSettings);
			this.dataGridViewExcelFilter_0.Focus();
		}

		private void method_26(int int_5)
		{
			this.int_2 = this.dataGridViewExcelFilter_0.FirstDisplayedScrollingRowIndex;
			this.string_0 = ((BindingSource)this.dataGridViewExcelFilter_0.DataSource).Sort;
			this.string_1 = ((BindingSource)this.dataGridViewExcelFilter_0.DataSource).Filter;
			this.int_1 = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value;
			this.bool_0 = true;
			this.method_25(true);
		}

		private void method_27(DataGridView dataGridView_12, string string_2, int int_5, int int_6)
		{
			foreach (object obj in ((IEnumerable)dataGridView_12.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if ((int)dataGridViewRow.Cells[string_2].Value == int_5)
				{
					dataGridView_12.FirstDisplayedScrollingRowIndex = dataGridViewRow.Index;
					dataGridViewRow.Selected = true;
					break;
				}
			}
		}

		private void tabControl_0_Selected(object sender, TabControlEventArgs e)
		{
			this.method_24();
		}

		private bool method_28(string string_2)
		{
			using (IEnumerator enumerator = Application.OpenForms.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((Form)enumerator.Current).Name == string_2)
					{
						return true;
					}
				}
			}
			return false;
		}

		private void toolStripButton_28_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0 && new FormTransfMove
			{
				SqlSettings = this.SqlSettings,
				IdObjList = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value,
				AllowUserToAddMoveTransf = true
			}.ShowDialog() == DialogResult.OK)
			{
				this.method_31((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		private void toolStripButton_32_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_6.SelectedRows != null && this.dataGridView_6.SelectedRows.Count > 0 && new FormEditTransfMove(this.SqlSettings, (int)this.dataGridView_6.SelectedRows[0].Cells["IdMove"].Value).ShowDialog() == DialogResult.OK)
			{
				this.method_30((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, (int)this.dataGridView_6.SelectedRows[0].Cells["IdMove"].Value);
			}
		}

		private void toolStripButton_29_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItem_4_Click(sender, e);
		}

		private void toolStripButton_31_Click(object sender, EventArgs e)
		{
		}

		private void method_29(object sender, EventArgs e)
		{
		}

		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_6.SelectedRows != null && this.dataGridView_6.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tSchm_Move, true, string.Format("where id = {0}", (int)this.dataGridView_6.SelectedRows[0].Cells["IdMove"].Value));
				this.dsPassport_0.tSchm_Move.Rows[0]["Deleted"] = true;
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tSchm_Move);
				this.method_31((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		private void toolStripButton_30_Click(object sender, EventArgs e)
		{
			this.dataGridView_6.DataSource = Class114.smethod_0(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
		}

		private void method_30(int int_5, int int_6)
		{
			this.toolStripSeparator_34.Visible = (this.toolStripButton_31.Visible = (";SCM;INLINE_OBJ;SWITCH;" == base.CallSQLScalarFunction("dbo.fn_P_GetTypeObject", new string[]
			{
				int_5.ToString()
			}).ToString() && this.SqlSettings.ServerDB.ToUpper() == "ULGES-SQL2"));
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = (this.dataGridView_6.DataSource = Class114.smethod_0(this.SqlSettings, int_5));
			bindingSource.Position = bindingSource.Find("Id", int_6);
			this.dataGridView_6.DataSource = bindingSource;
		}

		private void method_31(int int_5)
		{
			if (this.dataGridView_6.SelectedRows != null && this.dataGridView_6.SelectedRows.Count > 0)
			{
				int int_6 = (int)this.dataGridView_6.SelectedRows[0].Cells["idMove"].Value;
				this.method_30(int_5, int_6);
				return;
			}
			this.dataGridView_6.DataSource = Class114.smethod_0(this.SqlSettings, int_5);
		}

		private void toolStripButton_13_Click(object sender, EventArgs e)
		{
			this.method_32();
		}

		private void toolStripButton_4_Click(object sender, EventArgs e)
		{
			this.method_33();
		}

		private void toolStripButton_5_Click(object sender, EventArgs e)
		{
			this.method_34();
		}

		private void toolStripButton_14_Click(object sender, EventArgs e)
		{
			this.method_35();
		}

		private void toolStripButton_20_Click(object sender, EventArgs e)
		{
		}

		private void toolStripMenuItem_8_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0)
			{
				new FormActReports(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, (int)this.dataGridView_0.SelectedRows[0].Cells["idRepair"].Value, DocumentType.ActRepairTransformator).ShowDialog();
			}
		}

		private void toolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			this.method_33();
		}

		private void toolStripMenuItem_7_Click(object sender, EventArgs e)
		{
			this.method_34();
		}

		private void toolStripMenuItem_21_Click(object sender, EventArgs e)
		{
			this.method_35();
		}

		private void method_32()
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormRegistrAddEditRepair formRegistrAddEditRepair = new FormRegistrAddEditRepair(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, 0);
				if (formRegistrAddEditRepair.ShowDialog() == DialogResult.OK)
				{
					this.method_36(formRegistrAddEditRepair.Id);
				}
			}
		}

		private void method_33()
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0)
			{
				FormRegistrAddEditRepair formRegistrAddEditRepair = new FormRegistrAddEditRepair(this.SqlSettings, (int)this.dataGridView_0.SelectedRows[0].Cells["idRepair"].Value, 1);
				if (formRegistrAddEditRepair.ShowDialog() == DialogResult.OK)
				{
					this.method_36(formRegistrAddEditRepair.Id);
				}
			}
		}

		private void method_34()
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить строку?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_DocList, true, string.Format("WHERE Id = {0}", (int)this.dataGridView_0.SelectedRows[0].Cells["idRepair"].Value));
				((dsPassport.Class53)this.dsPassport_0.tP_DocList.Rows[0]).method_15(true);
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_DocList);
				this.method_36((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		private void method_35()
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0)
				{
					int int_ = (int)this.dataGridView_0.SelectedRows[0].Cells["idRepair"].Value;
					this.method_37((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, int_);
					return;
				}
				this.method_36((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		private void method_36(int int_5)
		{
			this.dataGridView_0.DataSource = PassportData.GetRepairData(this.SqlSettings, int_5);
		}

		private void method_37(int int_5, int int_6)
		{
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = PassportData.GetRepairData(this.SqlSettings, int_5);
			bindingSource.Position = bindingSource.Find("Id", int_6);
			this.dataGridView_0.DataSource = bindingSource;
		}

		private void dataGridView_0_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
		}

		private void toolStripButton_27_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				if (!Clutch.FindEndClutches(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value) && MessageBox.Show("Отсутствует необходимое количество концевых муфт.\r\nЖелаете продолжить и добавить концевую муфту?", "Концевые муфты", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
				{
					return;
				}
				FormAddEditClutch formAddEditClutch = new FormAddEditClutch(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, 0);
				formAddEditClutch.ClutchType = TypeClutch.Connective;
				if (formAddEditClutch.ShowDialog() == DialogResult.OK)
				{
					this.method_38(formAddEditClutch.Id);
				}
			}
		}

		private void toolStripButton_10_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_2.SelectedRows != null && this.dataGridView_2.SelectedRows.Count > 0 && new FormAddEditValuePassportChars(this.SqlSettings, 1, (int)this.dataGridView_2.SelectedRows[0].Cells["IdObjList"].Value, (int)this.dataGridView_2.SelectedRows[0].Cells["Id"].Value).ShowDialog() == DialogResult.OK)
			{
				this.method_39();
			}
		}

		private void toolStripButton_11_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_2.SelectedRows != null && this.dataGridView_2.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				Clutch.Delete(this.SqlSettings, (int)this.dataGridView_2.SelectedRows[0].Cells["IdObjList"].Value);
				this.method_39();
			}
		}

		private void toolStripButton_12_Click(object sender, EventArgs e)
		{
			this.method_39();
		}

		private void method_38(int int_5)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				this.dataGridView_2.DataSource = Clutch.GetData(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, TypeObjList.ClutchConnecting, false);
				this.method_27(this.dataGridView_2, "IdObjList", int_5, -1);
			}
		}

		private void method_39()
		{
			if (this.dataGridView_2.SelectedRows != null && this.dataGridView_2.SelectedRows.Count > 0)
			{
				int int_ = (int)this.dataGridView_2.SelectedRows[0].Cells["Id"].Value;
				this.method_38(int_);
				return;
			}
			this.dataGridView_2.DataSource = Clutch.GetData(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, TypeObjList.ClutchConnecting, false);
		}

		private void toolStripButton_7_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormAddEditCabSections formAddEditCabSections = new FormAddEditCabSections(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
				if (formAddEditCabSections.ShowDialog() == DialogResult.OK)
				{
					this.method_40(formAddEditCabSections.IdCabSection);
				}
			}
		}

		private void toolStripButton_8_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_1.SelectedRows != null && this.dataGridView_1.SelectedRows.Count > 0 && new FormAddEditCabSections(this.SqlSettings, (int)this.dataGridView_1.SelectedRows[0].Cells["SectionId"].Value, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, 1).ShowDialog() == DialogResult.OK)
			{
				this.method_42();
			}
		}

		private void toolStripButton_9_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_1.SelectedRows != null && this.dataGridView_1.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				Class109.smethod_10(this.SqlSettings, (int)this.dataGridView_1.SelectedRows[0].Cells["SectionId"].Value);
				this.method_42();
			}
		}

		private void toolStripButton_19_Click(object sender, EventArgs e)
		{
			this.method_42();
		}

		private void toolStripButton_64_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_1.SelectedRows != null && this.dataGridView_1.SelectedRows.Count > 0)
			{
				new FormPassportHistory(this.SqlSettings, (int)this.dataGridView_1.SelectedRows[0].Cells["SectionId"].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void method_40(int int_5)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				this.dataGridView_1.DataSource = Class109.smethod_0(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
				this.method_27(this.dataGridView_1, "SectionId", int_5, -1);
				this.method_41();
			}
		}

		private void method_41()
		{
			decimal d = 0m;
			foreach (object obj in ((IEnumerable)this.dataGridView_1.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				decimal d2 = 0m;
				if (decimal.TryParse(dataGridViewRow.Cells["SectionLength"].Value.ToString(), out d2))
				{
					d += d2;
				}
			}
			this.toolStripLabel_1.Text = d.ToString() + " м.";
		}

		private void method_42()
		{
			if (this.dataGridView_1.SelectedRows != null && this.dataGridView_1.SelectedRows.Count > 0)
			{
				int int_ = (int)this.dataGridView_1.SelectedRows[0].Cells["SectionId"].Value;
				this.method_40(int_);
				return;
			}
			this.dataGridView_1.DataSource = Class109.smethod_0(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			this.method_41();
		}

		private void toolStripButton_15_Click(object sender, EventArgs e)
		{
			this.method_43();
		}

		private void toolStripButton_16_Click(object sender, EventArgs e)
		{
			this.method_44();
		}

		private void toolStripButton_17_Click(object sender, EventArgs e)
		{
			this.method_45();
		}

		private void toolStripButton_18_Click(object sender, EventArgs e)
		{
			this.method_46();
		}

		private void toolStripButton_21_Click(object sender, EventArgs e)
		{
		}

		private void toolStripMenuItem_22_Click(object sender, EventArgs e)
		{
			this.method_43();
		}

		private void toolStripMenuItem_23_Click(object sender, EventArgs e)
		{
			this.method_44();
		}

		private void toolStripMenuItem_24_Click(object sender, EventArgs e)
		{
			this.method_45();
		}

		private void toolStripMenuItem_25_Click(object sender, EventArgs e)
		{
			this.method_46();
		}

		private void method_43()
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormRegistrAddEditBalance formRegistrAddEditBalance = new FormRegistrAddEditBalance(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, 0);
				if (formRegistrAddEditBalance.ShowDialog() == DialogResult.OK)
				{
					this.method_47(formRegistrAddEditBalance.Id);
				}
			}
		}

		private void method_44()
		{
			if (this.dataGridView_3.SelectedRows != null && this.dataGridView_3.SelectedRows.Count > 0)
			{
				FormRegistrAddEditBalance formRegistrAddEditBalance = new FormRegistrAddEditBalance(this.SqlSettings, (int)this.dataGridView_3.SelectedRows[0].Cells["idBalance"].Value, 1);
				if (formRegistrAddEditBalance.ShowDialog() == DialogResult.OK)
				{
					this.method_47(formRegistrAddEditBalance.Id);
				}
			}
		}

		private void method_45()
		{
			if (this.dataGridView_3.SelectedRows != null && this.dataGridView_3.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить строку?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_DocList, true, string.Format("WHERE Id = {0}", (int)this.dataGridView_3.SelectedRows[0].Cells["idBalance"].Value));
				((dsPassport.Class53)this.dsPassport_0.tP_DocList.Rows[0]).method_15(true);
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_DocList);
				this.method_47((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		private void method_46()
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				if (this.dataGridView_3.SelectedRows != null && this.dataGridView_3.SelectedRows.Count > 0)
				{
					int int_ = (int)this.dataGridView_3.SelectedRows[0].Cells["idBalance"].Value;
					this.method_48((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, int_);
					return;
				}
				this.method_47((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		private void method_47(int int_5)
		{
			this.dataGridView_3.DataSource = PassportData.GetBalanceData(this.SqlSettings, int_5);
		}

		private void method_48(int int_5, int int_6)
		{
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = PassportData.GetBalanceData(this.SqlSettings, int_5);
			bindingSource.Position = bindingSource.Find("Id", int_6);
			this.dataGridView_3.DataSource = bindingSource;
		}

		private void toolStripButton_22_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				this.method_49((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		private void toolStripButton_23_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_5.SelectedRows != null && this.dataGridView_5.SelectedRows.Count > 0)
			{
				this.method_50((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, (int)this.dataGridView_5.SelectedRows[0].Cells["IdBuildRepair"].Value);
			}
		}

		private void toolStripButton_24_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_5.SelectedRows != null && this.dataGridView_5.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.method_51((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, (int)this.dataGridView_5.SelectedRows[0].Cells["IdBuildRepair"].Value);
			}
		}

		private void toolStripButton_25_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				if (this.dataGridView_5.SelectedRows != null && this.dataGridView_5.SelectedRows.Count > 0)
				{
					int int_ = (int)this.dataGridView_5.SelectedRows[0].Cells["idBuildRepair"].Value;
					this.method_53((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, int_);
					return;
				}
				this.method_52((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		private void toolStripMenuItem_26_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				this.method_49((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		private void toolStripMenuItem_27_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_5.SelectedRows != null && this.dataGridView_5.SelectedRows.Count > 0)
			{
				this.method_50((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, (int)this.dataGridView_5.SelectedRows[0].Cells["IdBuildRepair"].Value);
			}
		}

		private void toolStripMenuItem_28_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_5.SelectedRows != null && this.dataGridView_5.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.method_51((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, (int)this.dataGridView_5.SelectedRows[0].Cells["IdBuildRepair"].Value);
			}
		}

		private void toolStripMenuItem_29_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				if (this.dataGridView_5.SelectedRows != null && this.dataGridView_5.SelectedRows.Count > 0)
				{
					int int_ = (int)this.dataGridView_5.SelectedRows[0].Cells["idBuildRepair"].Value;
					this.method_53((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, int_);
					return;
				}
				this.method_52((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		public void RefreshConboBoxDataBuildRepair()
		{
		}

		private void method_49(int int_5)
		{
			FormAddEditBuildRepair formAddEditBuildRepair = new FormAddEditBuildRepair(this.SqlSettings, int_5, 0);
			if (formAddEditBuildRepair.ShowDialog() == DialogResult.OK)
			{
				this.method_53(int_5, formAddEditBuildRepair.Id);
			}
		}

		private void method_50(int int_5, int int_6)
		{
			FormAddEditBuildRepair formAddEditBuildRepair = new FormAddEditBuildRepair(this.SqlSettings, int_6, 1);
			if (formAddEditBuildRepair.ShowDialog() == DialogResult.OK)
			{
				this.method_53(int_5, formAddEditBuildRepair.Id);
			}
		}

		private void method_51(int int_5, int int_6)
		{
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_BuildSubsRepair, true, "WHERE id = " + int_6.ToString());
			if (this.dsPassport_0.tP_BuildSubsRepair.Rows.Count > 0)
			{
				((dsPassport.Class59)this.dsPassport_0.tP_BuildSubsRepair.Rows[0]).method_23(true);
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_BuildSubsRepair);
				this.method_52(int_5);
			}
		}

		private void method_52(int int_5)
		{
			this.dataGridView_5.DataSource = PassportData.GetBuildRepairData(this.SqlSettings, int_5);
		}

		private void method_53(int int_5, int int_6)
		{
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = PassportData.GetBuildRepairData(this.SqlSettings, int_5);
			bindingSource.Position = bindingSource.Find("Id", int_6);
			this.dataGridView_5.DataSource = bindingSource;
		}

		private void toolStripButton_33_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormSurveyProtocolCable formSurveyProtocolCable = new FormSurveyProtocolCable(this.SqlSettings, -1, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Наименование"].Value.ToString(), 0);
				if (formSurveyProtocolCable.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
					this.bindingSource_4.ResetBindings(false);
					this.bindingSource_4.Position = this.bindingSource_4.Find("id", formSurveyProtocolCable.IdProtocol);
					this.dataGridView_7.DataSource = this.bindingSource_4;
				}
			}
		}

		private void toolStripButton_34_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_7.SelectedRows != null && this.dataGridView_7.SelectedRows.Count > 0)
			{
				FormSurveyProtocolCable formSurveyProtocolCable = new FormSurveyProtocolCable(this.SqlSettings, (int)this.dataGridView_7.SelectedRows[0].Cells["idCabProtocol"].Value, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Наименование"].Value.ToString(), 1);
				if (formSurveyProtocolCable.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
					this.bindingSource_4.ResetBindings(false);
					this.bindingSource_4.Position = this.bindingSource_4.Find("id", formSurveyProtocolCable.IdProtocol);
					this.dataGridView_7.DataSource = this.bindingSource_4;
				}
			}
		}

		private void toolStripButton_35_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_7.SelectedRows != null && this.dataGridView_7.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol, true, string.Format("WHERE id = {0} AND Deleted = ((0))", (int)this.dataGridView_7.SelectedRows[0].Cells["idCabProtocol"].Value));
				this.dsDocuments_0.tP_CabProtocol.Rows[0]["Deleted"] = true;
				base.UpdateSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol);
				base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
				this.bindingSource_4.ResetBindings(false);
				this.dataGridView_7.DataSource = this.bindingSource_4;
			}
		}

		private void toolStripButton_36_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_7.SelectedRows != null && this.dataGridView_7.SelectedRows.Count > 0)
			{
				new FormSurveyProtocolCable(this.SqlSettings, (int)this.dataGridView_7.SelectedRows[0].Cells["idCabProtocol"].Value, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Наименование"].Value.ToString(), 7).ShowDialog();
			}
		}

		private void toolStripButton_37_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				if (this.dataGridView_7.SelectedRows != null && this.dataGridView_7.SelectedRows.Count > 0)
				{
					int num = (int)this.dataGridView_7.SelectedRows[0].Cells["idCabProtocol"].Value;
					base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
					this.bindingSource_4.ResetBindings(false);
					this.bindingSource_4.Position = this.bindingSource_4.Find("id", num);
				}
				else
				{
					base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
					this.bindingSource_4.ResetBindings(false);
				}
				this.dataGridView_7.DataSource = this.bindingSource_4;
			}
		}

		private void toolStripButton_38_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_7.SelectedRows != null && this.dataGridView_7.SelectedRows.Count > 0)
			{
				new FormCableProtocolReport(this.SqlSettings, (int)this.dataGridView_7.SelectedRows[0].Cells["idCabProtocol"].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void method_54(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormAddEditCableTesting formAddEditCableTesting = new FormAddEditCableTesting(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, 0);
				if (formAddEditCableTesting.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
					this.bindingSource_6.Position = this.bindingSource_6.Find("id", formAddEditCableTesting.IdCabtesting);
				}
			}
		}

		private void method_55(object sender, EventArgs e)
		{
			if (this.dataGridView_9.SelectedRows != null && this.dataGridView_9.SelectedRows.Count > 0)
			{
				FormAddEditCableTesting formAddEditCableTesting = new FormAddEditCableTesting(this.SqlSettings, (int)this.dataGridView_9.SelectedRows[0].Cells["idCabTesting"].Value, 1);
				if (formAddEditCableTesting.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
					this.bindingSource_6.Position = this.bindingSource_6.Find("id", formAddEditCableTesting.IdCabtesting);
				}
			}
		}

		private void method_56(object sender, EventArgs e)
		{
			if (this.dataGridView_9.SelectedRows != null && this.dataGridView_9.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabTesting, true, string.Format("WHERE id = {0} AND Deleted = ((0))", (int)this.dataGridView_9.SelectedRows[0].Cells["idCabTesting"].Value));
				this.dsPassport_0.tP_CabTesting.Rows[0]["Deleted"] = true;
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabTesting);
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
			}
		}

		private void method_57(object sender, EventArgs e)
		{
			if (this.dataGridView_9.SelectedRows != null && this.dataGridView_9.SelectedRows.Count > 0)
			{
				int num = (int)this.dataGridView_9.SelectedRows[0].Cells["idCabTesting"].Value;
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
				this.bindingSource_6.Position = this.bindingSource_6.Find("id", num);
				return;
			}
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
		}

		private void method_58(object sender, EventArgs e)
		{
			this.toolStripButton_39.Enabled = false;
			int num = -1;
			if (this.bool_2)
			{
				num = this.dsPassport_0.vP_CabOperation.OrderByDescending(new Func<dsPassport.Class69, DateTime>(FormRegistr.<>c.<>9.method_3)).First<dsPassport.Class69>().Int32_0;
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabOperation, true, "WHERE id = " + num.ToString());
				this.dsPassport_0.tP_CabOperation.Rows[0]["DateCommissioning"] = this.dateTimePicker_0.Value;
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabOperation);
			}
			else if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				dsPassport.Class67 @class = this.dsPassport_0.tP_CabOperation.method_5();
				@class.method_1((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
				@class.method_3(this.dateTimePicker_0.Value);
				@class.Reason = (int)this.comboBox_0.SelectedValue;
				@class.method_7(false);
				this.dsPassport_0.tP_CabOperation.method_0(@class);
				num = base.InsertSqlDataOneRow(this.dsPassport_0, this.dsPassport_0.tP_CabOperation);
			}
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_CabOperation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
			this.bindingSource_5.Position = this.bindingSource_5.Find("Id", num);
			this.method_61();
			this.toolStripButton_39.Enabled = true;
		}

		private void method_59(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				if (this.dataGridView_8.SelectedRows != null && this.dataGridView_8.SelectedRows.Count > 0)
				{
					base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_CabOperation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
					this.bindingSource_5.Position = this.bindingSource_5.Find("Id", (int)this.dataGridView_8.SelectedRows[0].Cells["idCabOperation"].Value);
				}
				else
				{
					base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_CabOperation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
				}
				this.method_61();
			}
		}

		private void method_60(object sender, EventArgs e)
		{
			if (this.dataGridView_8.SelectedRows != null && this.dataGridView_8.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabOperation, true, string.Format("WHERE id = {0} AND Deleted = ((0))", (int)this.dataGridView_8.SelectedRows[0].Cells["idCabOperation"].Value));
				this.dsPassport_0.tP_CabOperation.Rows[0]["Deleted"] = true;
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabOperation);
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_CabOperation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
			}
		}

		private void method_61()
		{
			if (this.dsPassport_0.vP_CabOperation.Rows.Count == 0)
			{
				this.bool_2 = false;
				this.comboBox_0.Enabled = true;
				return;
			}
			this.dateTimePicker_0.Value = DateTime.Now;
			this.int_4 = (int)base.CallSQLScalarFunction("dbo.fn_GetIsAcceptCabOperation", new string[]
			{
				this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value.ToString()
			});
			this.bool_2 = (this.dsPassport_0.vP_CabOperation.Select("id = " + this.int_4).First<DataRow>()["DateCommissioning"] == DBNull.Value);
			if (this.bool_2)
			{
				this.toolStripButton_39.Text = "Ввести";
				this.comboBox_0.Enabled = false;
				this.bool_2 = true;
				return;
			}
			this.toolStripButton_39.Text = "Вывести";
			this.comboBox_0.Enabled = true;
			this.bool_2 = false;
		}

		private void method_62()
		{
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_ValueLists, true, "WHERE ParentKey = ';Cable;Addl;TestReason;' AND Deleted = ((0))");
			this.comboBox_0.DataSource = this.bindingSource_7;
			this.comboBox_0.ValueMember = "Id";
			this.comboBox_0.DisplayMember = "Name";
		}

		private void toolStripMenuItem_43_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormAddEditCabPerambulation formAddEditCabPerambulation = new FormAddEditCabPerambulation(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, 0);
				formAddEditCabPerambulation.FormClosed += this.method_63;
				formAddEditCabPerambulation.MdiParent = base.MdiParent;
				formAddEditCabPerambulation.Show();
			}
		}

		private void toolStripMenuItem_44_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_1.SelectedRows != null && this.dataGridViewExcelFilter_1.SelectedRows.Count > 0)
			{
				FormAddEditCabPerambulation formAddEditCabPerambulation = new FormAddEditCabPerambulation();
				formAddEditCabPerambulation.SqlSettings = this.SqlSettings;
				formAddEditCabPerambulation.Id = (int)this.dataGridViewExcelFilter_1.SelectedRows[0].Cells["idPeram"].Value;
				formAddEditCabPerambulation.IdObjList = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value;
				formAddEditCabPerambulation.StateCreate = 1;
				formAddEditCabPerambulation.FormClosed += this.method_63;
				formAddEditCabPerambulation.MdiParent = base.MdiParent;
				formAddEditCabPerambulation.Show();
			}
		}

		private void toolStripMenuItem_45_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.dataGridViewExcelFilter_1.SelectedRows[0].Cells["deletedPeram"].Value = true;
				this.bindingSource_8.EndEdit();
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabPerambulation);
				this.method_64((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		private void toolStripMenuItem_46_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				if (this.dataGridViewExcelFilter_1.SelectedRows != null && this.dataGridViewExcelFilter_1.SelectedRows.Count > 0)
				{
					this.method_65((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, (int)this.dataGridViewExcelFilter_1.SelectedRows[0].Cells["idPeram"].Value);
					return;
				}
				this.method_64((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			}
		}

		private void dataGridViewExcelFilter_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewExcelFilter_1.SelectedRows != null && this.dataGridViewExcelFilter_1.SelectedRows.Count > 0)
			{
				FormAddEditCabPerambulation formAddEditCabPerambulation = new FormAddEditCabPerambulation();
				formAddEditCabPerambulation.SqlSettings = this.SqlSettings;
				formAddEditCabPerambulation.Id = (int)this.dataGridViewExcelFilter_1.SelectedRows[0].Cells["idPeram"].Value;
				formAddEditCabPerambulation.IdObjList = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value;
				formAddEditCabPerambulation.StateCreate = 1;
				formAddEditCabPerambulation.FormClosed += this.method_63;
				formAddEditCabPerambulation.MdiParent = base.MdiParent;
				formAddEditCabPerambulation.Show();
			}
		}

		private void method_63(object sender, FormClosedEventArgs e)
		{
			FormAddEditCabPerambulation formAddEditCabPerambulation = (FormAddEditCabPerambulation)sender;
			if (formAddEditCabPerambulation.DialogResult == DialogResult.OK)
			{
				this.method_65((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, formAddEditCabPerambulation.Id);
			}
		}

		private void method_64(int int_5)
		{
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabPerambulation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", int_5));
			this.bindingSource_8.ResetBindings(false);
		}

		private void method_65(int int_5, int int_6)
		{
			this.method_64(int_5);
			this.bindingSource_8.Position = this.bindingSource_8.Find("id", int_6);
		}

		private void toolStripButton_54_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormAddEditPylone formAddEditPylone = new FormAddEditPylone();
				formAddEditPylone.SqlSettings = this.SqlSettings;
				formAddEditPylone.IdAirLine = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value;
				formAddEditPylone.CreateState = 0;
				formAddEditPylone.FormClosed += this.method_66;
				formAddEditPylone.MdiParent = base.MdiParent;
				formAddEditPylone.Show();
			}
		}

		private void toolStripButton_55_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_10.SelectedRows != null && this.dataGridView_10.SelectedRows.Count > 0)
			{
				FormAddEditPylone formAddEditPylone = new FormAddEditPylone();
				formAddEditPylone.SqlSettings = this.SqlSettings;
				formAddEditPylone.IdAirLine = (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value;
				formAddEditPylone.IdPole = (int)this.dataGridView_10.SelectedRows[0].Cells["idObjListPole"].Value;
				formAddEditPylone.CreateState = 1;
				formAddEditPylone.FormClosed += this.method_66;
				formAddEditPylone.MdiParent = base.MdiParent;
				formAddEditPylone.Show();
			}
		}

		private void toolStripButton_56_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable("tP_CabSection");
			base.SelectSqlData(dataTable, true, string.Format("where ([idClutchFirst] = '{0}' or [idClutchSecond] = '{0}') and deleted = '0'", (int)this.dataGridView_10.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_212.Name].Value), false);
			if (dataTable.Rows.Count > 0)
			{
				string text = string.Empty;
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					text = text + "," + dataRow["idObjList"].ToString();
				}
				text = text.Remove(0, 1);
				DataTable dataTable2 = new DataTable("vSchm_ObjList");
				base.SelectSqlData(dataTable2, true, string.Format("where id in ({0})", text), false);
				string text2 = string.Empty;
				foreach (object obj2 in dataTable2.Rows)
				{
					DataRow dataRow2 = (DataRow)obj2;
					text2 = string.Concat(new string[]
					{
						text2,
						", ",
						dataRow2["typeCodeSocr"].ToString(),
						"-",
						dataRow2["Name"].ToString()
					});
				}
				text2 = text2.Remove(0, 2);
				MessageBox.Show("Невозможно удалить опору, так как она привязана к пролету на линиях: " + text2, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (this.dataGridView_10.SelectedRows != null && this.dataGridView_10.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tSchm_ObjList, true, "WHERE id = " + this.dataGridView_10.SelectedRows[0].Cells["idObjListPole"].Value.ToString());
				if (this.dsPassport_0.tSchm_ObjList.Rows.Count > 0)
				{
					this.dsPassport_0.tSchm_ObjList.Rows[0]["Deleted"] = true;
					base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tSchm_ObjList);
					this.method_68((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
				}
			}
		}

		private void toolStripButton_57_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_10.SelectedRows != null && this.dataGridView_10.SelectedRows.Count > 0)
			{
				this.method_67((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, (int)this.dataGridView_10.SelectedRows[0].Cells["idObjListPole"].Value);
				return;
			}
			this.method_68((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
		}

		private void toolStripButton_68_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_10.SelectedRows != null && this.dataGridView_10.SelectedRows.Count > 0)
			{
				new FormPassportHistory(this.SqlSettings, (int)this.dataGridView_10.SelectedRows[0].Cells["idObjListPole"].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void method_66(object sender, FormClosedEventArgs e)
		{
			FormAddEditPylone formAddEditPylone = (FormAddEditPylone)sender;
			if (formAddEditPylone.DialogResult == DialogResult.OK)
			{
				this.method_67((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, formAddEditPylone.IdPole);
			}
		}

		private void method_67(int int_5, int int_6)
		{
			this.method_68((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
			foreach (object obj in ((IEnumerable)this.dataGridView_10.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if ((int)dataGridViewRow.Cells["idObjListPole"].Value == int_6)
				{
					dataGridViewRow.Selected = true;
					this.dataGridView_10.FirstDisplayedScrollingRowIndex = dataGridViewRow.Index;
				}
			}
		}

		private void method_68(int int_5)
		{
			string text = string.Empty;
			using (DataTable dataTable = base.SelectSqlData("tr_Classifier", true, "WHERE ParentKey = ';SCM;Pole;' and isGroup = 0"))
			{
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (text != string.Empty)
					{
						text += ",";
					}
					text += dataRow["id"].ToString();
				}
			}
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;Pole;", 1m), string.Format("WHERE (ol.id in (select [idclutchFirst] as pylon from tP_CabSection where idObjList = {0} and deleted = '0'  union select [idclutchsecond] as pylon from tP_CabSection where idObjList = {0} and deleted = '0'))", int_5) + ((text != string.Empty) ? string.Format(" OR (ol.IdParent = {0} and ol.Deleted = 0 AND ol.TypeCodeId in ({1}))", int_5, text) : ""), false);
			string text2 = "select cb.idPole, COUNT(Distinct cb.id) as CountBranch, COUNT(br.idObj) as CountObjBranch\r\nfrom tP_CabBranches as cb join\r\ntP_BranchObjRelation as br on br.idCabBranch = cb.id\r\n" + string.Format("where cb.idPole in (select [idclutchFirst] as pylon from tP_CabSection where idObjList = '{0}' and deleted = '0'\r\nunion select [idclutchsecond] as pylon from tP_CabSection where idObjList = '{0}' and Deleted = '0')\r\n", int_5) + "group by cb.idPole";
			DataTable dataTable2 = new SqlDataCommand(this.SqlSettings).SelectSqlData(text2);
			equipmentData.Columns.Add("countBranch", typeof(int));
			equipmentData.Columns.Add("countObjBranch", typeof(int));
			foreach (object obj2 in dataTable2.Rows)
			{
				DataRow dataRow2 = (DataRow)obj2;
				DataView dataView = new DataView(equipmentData);
				dataView.RowFilter = "idObjList = " + dataRow2["idPole"].ToString();
				dataView[0]["countBranch"] = dataRow2["countBranch"];
				dataView[0]["countObjBranch"] = dataRow2["countObjBranch"];
			}
			this.dataGridView_10.DataSource = equipmentData;
		}

		private void method_69(object sender, EventArgs e)
		{
		}

		private void toolStripMenuItem_47_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormAddEditAirLineSpan formAddEditAirLineSpan = new FormAddEditAirLineSpan(this.SqlSettings, -1, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, 0);
				formAddEditAirLineSpan.MdiParent = base.MdiParent;
				formAddEditAirLineSpan.FormClosed += this.method_70;
				formAddEditAirLineSpan.Show();
			}
		}

		private void toolStripMenuItem_48_Click(object sender, EventArgs e)
		{
			if (this.treeDataGridView_0.CurrentNode != null && this.treeDataGridView_0.CurrentNode.Cells[0].Value is int)
			{
				FormAddEditAirLineSpan formAddEditAirLineSpan = new FormAddEditAirLineSpan(this.SqlSettings, (int)this.treeDataGridView_0.CurrentNode.Cells[0].Value, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, 1);
				formAddEditAirLineSpan.MdiParent = base.MdiParent;
				formAddEditAirLineSpan.FormClosed += this.method_70;
				formAddEditAirLineSpan.Show();
			}
		}

		private void toolStripButton_67_Click(object sender, EventArgs e)
		{
			if (this.treeDataGridView_0.CurrentNode != null && this.treeDataGridView_0.CurrentNode.Cells[0].Value is int)
			{
				new FormPassportHistory(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void method_70(object sender, FormClosedEventArgs e)
		{
			FormAddEditAirLineSpan formAddEditAirLineSpan = (FormAddEditAirLineSpan)sender;
			if (formAddEditAirLineSpan.DialogResult == DialogResult.OK)
			{
				this.method_71((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, formAddEditAirLineSpan.IdSpan);
			}
		}

		private void method_71(int int_5, int int_6)
		{
			this.method_74(int_5);
			List<TreeDataGridViewNode> list_ = new List<TreeDataGridViewNode>();
			list_ = this.method_72(this.treeDataGridView_0.Nodes, list_);
			TreeDataGridViewNode treeDataGridViewNode = this.method_73(list_, int_6);
			if (treeDataGridViewNode != null)
			{
				treeDataGridViewNode.Selected = true;
			}
		}

		private List<TreeDataGridViewNode> method_72(TreeDataGridViewNodeCollection treeDataGridViewNodeCollection_0, List<TreeDataGridViewNode> list_1)
		{
			foreach (TreeDataGridViewNode treeDataGridViewNode in treeDataGridViewNodeCollection_0)
			{
				list_1.Add(treeDataGridViewNode);
				list_1 = this.method_72(treeDataGridViewNode.Nodes, list_1);
			}
			return list_1;
		}

		private TreeDataGridViewNode method_73(List<TreeDataGridViewNode> list_1, int int_5)
		{
			foreach (TreeDataGridViewNode treeDataGridViewNode in list_1)
			{
				if ((int)treeDataGridViewNode.Cells[0].Value == int_5)
				{
					return treeDataGridViewNode;
				}
			}
			return null;
		}

		private void method_74(int int_5)
		{
			this.treeDataGridView_0.Nodes.Clear();
			this.list_0 = new List<int>();
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_Spans, true, string.Format("WHERE Deleted = ((0)) AND idObjList = {0} ORDER BY Number ASC", (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
			if (this.dsPassport_0.vP_Spans.Rows.Count > 0)
			{
				bool flag = false;
				bool flag2 = false;
				for (;;)
				{
					dsPassport.Class84 @class = null;
					if (flag && !flag2)
					{
						this.treeDataGridView_0.Nodes.Add(new object[]
						{
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value
						});
						flag2 = true;
					}
					using (IEnumerator enumerator = this.dsPassport_0.vP_Spans.Rows.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							dsPassport.Class84 class2 = (dsPassport.Class84)obj;
							if (!this.list_0.Contains(class2.Int32_0))
							{
								@class = class2;
								break;
							}
						}
						goto IL_292;
					}
					IL_F7:
					TreeDataGridViewNode treeDataGridViewNode = this.treeDataGridView_0.Nodes.Add(new object[]
					{
						@class.Int32_0,
						@class["idObjList"],
						@class["idPoleFirst"],
						@class["idPoleSecond"],
						@class["Number"],
						@class["NamePoleFirst"],
						@class["NamePoleSecond"],
						@class["CableMakeup"],
						@class["Voltage"],
						@class["Wires"],
						@class["CrossSection"],
						@class["Length"],
						@class.YearCommissioning.ToShortDateString()
					});
					treeDataGridViewNode.Expand();
					this.list_0.Add(@class.Int32_0);
					this.method_75(treeDataGridViewNode, this.dsPassport_0.vP_Spans);
					flag = true;
					continue;
					IL_292:
					if (@class == null)
					{
						break;
					}
					goto IL_F7;
				}
				this.list_0.Clear();
			}
		}

		private void method_75(TreeDataGridViewNode treeDataGridViewNode_0, dsPassport.vP_SpansDataTable vP_SpansDataTable_0)
		{
			FormRegistr.Class126 @class = new FormRegistr.Class126();
			@class.treeDataGridViewNode_0 = treeDataGridViewNode_0;
			if (@class.treeDataGridViewNode_0.Cells[3].Value != null)
			{
				IEnumerable<dsPassport.Class84> enumerable = this.dsPassport_0.vP_Spans.Rows.Cast<dsPassport.Class84>().Where(new Func<dsPassport.Class84, bool>(@class.method_0));
				bool flag = true;
				foreach (dsPassport.Class84 class2 in enumerable)
				{
					if (!this.list_0.Contains(class2.Int32_0))
					{
						this.list_0.Add(class2.Int32_0);
						TreeDataGridViewNode treeDataGridViewNode;
						if (flag)
						{
							treeDataGridViewNode = @class.treeDataGridViewNode_0.Parent.Nodes.Add(new object[]
							{
								class2.Int32_0,
								class2.idObjList,
								class2["idPoleFirst"],
								class2["idPoleSecond"],
								class2["Number"],
								class2["NamePoleFirst"],
								class2["NamePoleSecond"],
								class2["CableMakeup"],
								class2["Voltage"],
								class2["Wires"],
								class2["CrossSection"],
								class2["Length"],
								(!class2.IsNull("YearCommissioning")) ? class2.YearCommissioning.ToShortDateString() : ""
							});
							flag = false;
						}
						else
						{
							treeDataGridViewNode = @class.treeDataGridViewNode_0.Nodes.Add(new object[]
							{
								class2.Int32_0,
								class2.idObjList,
								class2["idPoleFirst"],
								class2["idPoleSecond"],
								class2["Number"],
								class2["NamePoleFirst"],
								class2["NamePoleSecond"],
								class2["CableMakeup"],
								class2["Voltage"],
								class2["Wires"],
								class2["CrossSection"],
								class2["Length"],
								(!class2.IsNull("YearCommissioning")) ? class2.YearCommissioning.ToShortDateString() : ""
							});
						}
						treeDataGridViewNode.Expand();
						this.method_75(treeDataGridViewNode, this.dsPassport_0.vP_Spans);
					}
				}
			}
		}

		private void toolStripMenuItem_49_Click(object sender, EventArgs e)
		{
			if (this.treeDataGridView_0.CurrentNode != null && this.treeDataGridView_0.CurrentNode.Cells[0].Value is int && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabSection, true, "WHERE id = " + this.treeDataGridView_0.CurrentNode.Cells[0].Value.ToString());
				if (this.dsPassport_0.tP_CabSection.Rows.Count > 0)
				{
					this.dsPassport_0.tP_CabSection.Rows[0]["Deleted"] = true;
					base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_CabSection);
					this.method_74((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
				}
			}
		}

		private void toolStripMenuItem_50_Click(object sender, EventArgs e)
		{
			if (this.treeDataGridView_0.CurrentNode != null && this.treeDataGridView_0.CurrentNode.Cells[0].Value is int)
			{
				this.method_71((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, (int)this.treeDataGridView_0.CurrentNode.Cells[0].Value);
				return;
			}
			this.method_74((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
		}

		private void treeDataGridView_0_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
			if (e.RowIndex < 0 || e.ColumnIndex < 0)
			{
				return;
			}
			if (e.ColumnIndex == 4)
			{
				e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
				return;
			}
			e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
		}

		private void method_76(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				int idSubstation = (this.equipmentDocType_0 == EquipmentDocType.Substation) ? ((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value) : -1;
				int idTransformer = (this.equipmentDocType_0 == EquipmentDocType.PowerTransformer) ? ((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value) : -1;
				FormTehConnectAddEdit formTehConnectAddEdit = new FormTehConnectAddEdit(this.SqlSettings, idSubstation, idTransformer);
				formTehConnectAddEdit.MdiParent = base.MdiParent;
				formTehConnectAddEdit.FormClosed += this.method_80;
				formTehConnectAddEdit.Show();
				return;
			}
			MessageBox.Show("Внимание.", "Выберите подстанцию или трансформатор в дереве объектов", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void method_77(object sender, EventArgs e)
		{
			if (this.bindingSource_9.Current != null)
			{
				FormTehConnectAddEdit formTehConnectAddEdit = new FormTehConnectAddEdit(this.SqlSettings, (int)((DataRowView)this.bindingSource_9.Current)["Id"]);
				formTehConnectAddEdit.MdiParent = base.MdiParent;
				formTehConnectAddEdit.FormClosed += this.method_80;
				formTehConnectAddEdit.Show();
			}
		}

		private void method_78(object sender, EventArgs e)
		{
			if (this.bindingSource_9.Current != null && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_EESConnectPower, true, "where id = " + ((DataRowView)this.bindingSource_9.Current)["Id"].ToString());
				this.dsPassport_0.tP_EESConnectPower.First<dsPassport.Class88>().Deleted = true;
				base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_EESConnectPower);
				this.method_81();
			}
		}

		private void method_79(object sender, EventArgs e)
		{
			if (this.bindingSource_9.Current != null)
			{
				this.method_81();
				return;
			}
			this.method_82((int)((DataRowView)this.bindingSource_9.Current)["Id"]);
		}

		private void method_80(object sender, FormClosedEventArgs e)
		{
			FormTehConnectAddEdit formTehConnectAddEdit = (FormTehConnectAddEdit)sender;
			if (formTehConnectAddEdit.DialogResult == DialogResult.OK)
			{
				this.method_82(formTehConnectAddEdit.IdTehConnect);
			}
		}

		private void method_81()
		{
			string text = ((this.equipmentDocType_0 == EquipmentDocType.Substation) ? ("where idSubstation = " + this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value.ToString()) : ((this.equipmentDocType_0 == EquipmentDocType.PowerTransformer) ? ("where idTransf = " + this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value.ToString()) : "")) + " AND Deleted = ((0)) Order By NameTransf";
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.vP_TehConnect, true, text);
		}

		private void method_82(int int_5)
		{
			this.method_81();
			this.bindingSource_9.Position = this.bindingSource_9.Find("Id", int_5);
		}

		private void toolStripComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.TotalVisible = (this.toolStripComboBox_0.SelectedIndex == 0);
			this.typeObjListGroup_0 = this.method_83((EquipmentDocType)this.toolStripComboBox_0.SelectedIndex);
			this.TypeSubsVisible = (this.typeObjListGroup_0 == TypeObjListGroup.Substations || this.typeObjListGroup_0 == TypeObjListGroup.AirLines);
			if (this.TypeSubsVisible)
			{
				this.method_12(this.typeObjListGroup_0);
			}
		}

		private TypeObjListGroup method_83(EquipmentDocType equipmentDocType_1)
		{
			switch (equipmentDocType_1)
			{
			default:
				return TypeObjListGroup.None;
			case EquipmentDocType.Substation:
				return TypeObjListGroup.Substations;
			case EquipmentDocType.PowerTransformer:
			case EquipmentDocType.VoltageTransformer:
				return TypeObjListGroup.Switches;
			case EquipmentDocType.Cable:
				return TypeObjListGroup.CableLines;
			case EquipmentDocType.AirLine:
				return TypeObjListGroup.AirLines;
			}
		}

		private void dataGridViewExcelFilter_0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0 && e.RowIndex != -1)
			{
				this.method_1();
			}
		}

		private void toolStripButton_63_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0 && this.goToSchemaEventHandler_0 != null)
			{
				this.goToSchemaEventHandler_0.Invoke(this, new GoToSchemaEventArgs((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value));
			}
		}

		private FormRegistrSettings method_84()
		{
			string str = base.Name + ".config";
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EIS" + "\\" + str;
			FormRegistrSettings result = new FormRegistrSettings();
			if (File.Exists(path))
			{
				using (FileStream fileStream = new FileStream(path, FileMode.Open))
				{
					XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fileStream, Encoding.UTF8, new XmlDictionaryReaderQuotas(), null);
					result = (FormRegistrSettings)new DataContractSerializer(typeof(FormRegistrSettings)).ReadObject(reader);
				}
			}
			return result;
		}

		private void method_85(FormRegistrSettings formRegistrSettings_1)
		{
			string str = base.Name + ".config";
			XmlTextWriter xmlTextWriter = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EIS" + "\\" + str, Encoding.UTF8);
			xmlTextWriter.Formatting = Formatting.Indented;
			XmlDictionaryWriter xmlDictionaryWriter = XmlDictionaryWriter.CreateDictionaryWriter(xmlTextWriter);
			new DataContractSerializer(typeof(FormRegistrSettings)).WriteObject(xmlDictionaryWriter, formRegistrSettings_1);
			xmlDictionaryWriter.Close();
			xmlTextWriter.Close();
		}

		private void method_86()
		{
			Columns columns = new Columns();
			EquipmentDocType selectedIndex = (EquipmentDocType)this.toolStripComboBox_0.SelectedIndex;
			if (this.dataGridViewExcelFilter_0.Columns.Count > 1)
			{
				for (int i = 0; i < this.dataGridViewExcelFilter_0.ColumnCount; i++)
				{
					columns.Add(new Column(this.dataGridViewExcelFilter_0.Columns[i].DisplayIndex, this.dataGridViewExcelFilter_0.Columns[i].Name));
				}
			}
			switch (selectedIndex)
			{
			case EquipmentDocType.Substation:
				this.formRegistrSettings_0.SubstationColumns = columns;
				return;
			case EquipmentDocType.PowerTransformer:
				this.formRegistrSettings_0.TransformerColumns = columns;
				return;
			case EquipmentDocType.Cable:
				this.formRegistrSettings_0.CableLineColumns = columns;
				return;
			default:
				return;
			}
		}

		private void dataGridViewExcelFilter_0_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
		{
			this.method_86();
		}

		private void contextMenuStrip_0_Opening(object sender, CancelEventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				bool visible = this.method_21((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value);
				this.toolStripMenuItem_55.Visible = visible;
			}
		}

		private void toolStripButton_58_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_11.Rows.Count < 2 && this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormAddEditClutch formAddEditClutch = new FormAddEditClutch(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, 0);
				formAddEditClutch.ClutchType = TypeClutch.End;
				if (formAddEditClutch.ShowDialog() == DialogResult.OK)
				{
					this.method_87(formAddEditClutch.Id);
				}
			}
		}

		private void toolStripButton_59_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_11.SelectedRows != null && this.dataGridView_11.SelectedRows.Count > 0 && new FormAddEditValuePassportChars(this.SqlSettings, 1, (int)this.dataGridView_11.SelectedRows[0].Cells["IdObjList"].Value, (int)this.dataGridView_11.SelectedRows[0].Cells["Id"].Value).ShowDialog() == DialogResult.OK)
			{
				this.method_88();
			}
		}

		private void toolStripButton_61_Click(object sender, EventArgs e)
		{
			this.method_88();
		}

		private void toolStripButton_66_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_11.SelectedRows != null && this.dataGridView_11.SelectedRows.Count > 0)
			{
				new FormPassportHistory(this.SqlSettings, (int)this.dataGridView_11.SelectedRows[0].Cells["IdObjList"].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void method_87(int int_5)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				this.dataGridView_11.DataSource = Clutch.GetData(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, TypeObjList.ClutchEnd, false);
				this.method_27(this.dataGridView_11, "IdObjList", int_5, -1);
			}
		}

		private void method_88()
		{
			if (this.dataGridView_11.SelectedRows != null && this.dataGridView_11.SelectedRows.Count > 0)
			{
				int int_ = (int)this.dataGridView_11.SelectedRows[0].Cells["Id"].Value;
				this.method_87(int_);
				return;
			}
			this.dataGridView_11.DataSource = Clutch.GetData(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["Id"].Value, TypeObjList.ClutchEnd, false);
		}

		private void toolStripButton_65_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_2.SelectedRows != null && this.dataGridView_2.SelectedRows.Count > 0)
			{
				new FormPassportHistory(this.SqlSettings, (int)this.dataGridView_2.SelectedRows[0].Cells["IdObjList"].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void dataGridViewExcelFilter_0_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (this.toolTip_0 != null)
			{
				this.toolTip_0.Hide(this.tableLayoutPanel_6);
			}
			if (e.RowIndex != -1 && e.ColumnIndex != -1 && this.dataGridViewExcelFilter_0.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Yellow)
			{
				this.toolTip_0 = new ToolTip();
				Point location = this.dataGridViewExcelFilter_0.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
				location.Offset(0, -20);
				this.toolTip_0.Show("Не привязан к справочнику.", this.tableLayoutPanel_6, location, 2500);
			}
		}

		private void toolStripButton_73_Click(object sender, EventArgs e)
		{
			foreach (object obj in ((IEnumerable)this.dataGridViewExcelFilter_0.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				int num;
				if (dataGridViewRow.Cells["idEquipment"].Value != null && int.TryParse(dataGridViewRow.Cells["idEquipment"].Value.ToString(), out num))
				{
					int num2 = (int)dataGridViewRow.Cells["idPassport"].Value;
					DataTable dataTable = base.SelectSqlData("vP_ReferenceToPassport", true, "WHERE id = " + num.ToString());
					Class114.smethod_5(this.SqlSettings, num2, 92, dataTable.Rows[0]["Type"].ToString());
					Class114.smethod_5(this.SqlSettings, num2, 93, dataTable.Rows[0]["Power"].ToString());
					Class114.smethod_5(this.SqlSettings, num2, 96, dataTable.Rows[0]["HighVoltage"].ToString());
					Class114.smethod_5(this.SqlSettings, num2, 97, dataTable.Rows[0]["LowVoltage"].ToString());
					Class114.smethod_6(this.SqlSettings, num2, 253, dataTable.Rows[0]["RatedAmperHV"].ToString(), false);
					Class114.smethod_6(this.SqlSettings, num2, 228, dataTable.Rows[0]["RatedAmperLV"].ToString(), false);
					Class114.smethod_5(this.SqlSettings, num2, 99, dataTable.Rows[0]["GroupWindings"].ToString());
					Class114.smethod_5(this.SqlSettings, num2, 254, dataTable.Rows[0]["ShortCircuitVolt"].ToString());
					Class114.smethod_5(this.SqlSettings, num2, 255, dataTable.Rows[0]["ShortCircuitLoss"].ToString());
					Class114.smethod_5(this.SqlSettings, num2, 256, dataTable.Rows[0]["NoLoadLoss"].ToString());
				}
			}
		}

		private void dataGridViewExcelFilter_0_Sorted(object sender, EventArgs e)
		{
		}

		private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				if (this.toolStripComboBox_0.SelectedIndex == 1)
				{
					if (this.dataGridViewExcelFilter_0.Rows[e.RowIndex].Cells["idEquipment"].Value != DBNull.Value)
					{
						if ((int)this.dataGridViewExcelFilter_0.Rows[e.RowIndex].Cells["idEquipment"].Value != -1)
						{
							this.dataGridViewExcelFilter_0.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
							goto IL_D4;
						}
					}
					new ToolTip();
					this.dataGridViewExcelFilter_0.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
				}
				IL_D4:
				if (this.dataGridViewExcelFilter_0.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.GetType() == typeof(DateTime))
				{
					this.dataGridViewExcelFilter_0.Columns[e.ColumnIndex].DefaultCellStyle.Format = "dd.MM.yyyy";
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

		private void method_89()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormRegistr));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle51 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle52 = new DataGridViewCellStyle();
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_37 = new ToolStripMenuItem();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_38 = new ToolStripMenuItem();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripMenuItem_61 = new ToolStripMenuItem();
			this.toolStripMenuItem_62 = new ToolStripMenuItem();
			this.toolStripMenuItem_40 = new ToolStripMenuItem();
			this.toolStripMenuItem_41 = new ToolStripMenuItem();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.toolStripMenuItem_42 = new ToolStripMenuItem();
			this.toolStripMenuItem_55 = new ToolStripMenuItem();
			this.toolStripMenuItem_59 = new ToolStripMenuItem();
			this.toolStripMenuItem_60 = new ToolStripMenuItem();
			this.contextMenuStrip_1 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.toolStripMenuItem_63 = new ToolStripMenuItem();
			this.toolStripMenuItem_64 = new ToolStripMenuItem();
			this.toolStripMenuItem_39 = new ToolStripMenuItem();
			this.toolStripSeparator_2 = new ToolStripSeparator();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			this.toolStripSeparator_21 = new ToolStripSeparator();
			this.toolStripMenuItem_19 = new ToolStripMenuItem();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripSeparator_3 = new ToolStripSeparator();
			this.toolStripSeparator_4 = new ToolStripSeparator();
			this.toolStripLabel_0 = new ToolStripLabel();
			this.toolStripComboBox_0 = new ToolStripComboBox();
			this.toolStripSeparator_5 = new ToolStripSeparator();
			this.toolStripComboBox_1 = new ToolStripComboBox();
			this.toolStripSeparator_6 = new ToolStripSeparator();
			this.tableLayoutPanel_1 = new TableLayoutPanel();
			this.toolStrip_1 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripSeparator_9 = new ToolStripSeparator();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripSeparator_11 = new ToolStripSeparator();
			this.toolStripButton_6 = new ToolStripButton();
			this.toolStripSeparator_60 = new ToolStripSeparator();
			this.toolStripButton_62 = new ToolStripButton();
			this.toolStripButton_63 = new ToolStripButton();
			this.toolStripButton_73 = new ToolStripButton();
			this.splitContainer_0 = new SplitContainer();
			this.tableLayoutPanel_6 = new TableLayoutPanel();
			this.dataGridView_4 = new DataGridView();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.tabControl_0 = new TabControl();
			this.tabPage_5 = new TabPage();
			this.tableLayoutPanel_8 = new TableLayoutPanel();
			this.toolStrip_7 = new ToolStrip();
			this.toolStripSplitButton_0 = new ToolStripSplitButton();
			this.toolStripMenuItem_65 = new ToolStripMenuItem();
			this.toolStripMenuItem_66 = new ToolStripMenuItem();
			this.toolStripButton_32 = new ToolStripButton();
			this.toolStripButton_28 = new ToolStripButton();
			this.toolStripSeparator_32 = new ToolStripSeparator();
			this.toolStripButton_29 = new ToolStripButton();
			this.toolStripSeparator_33 = new ToolStripSeparator();
			this.toolStripButton_30 = new ToolStripButton();
			this.toolStripSeparator_34 = new ToolStripSeparator();
			this.toolStripButton_31 = new ToolStripButton();
			this.dataGridView_6 = new DataGridView();
			this.dataGridViewTextBoxColumn_204 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_205 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_206 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_207 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_208 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_209 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_210 = new DataGridViewTextBoxColumn();
			this.tabPage_1 = new TabPage();
			this.tableLayoutPanel_3 = new TableLayoutPanel();
			this.dataGridView_1 = new DataGridView();
			this.dataGridViewTextBoxColumn_94 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_95 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_96 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_97 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_98 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_99 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_100 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_101 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_102 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_103 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_104 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_105 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_106 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_107 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_108 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_109 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_110 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_111 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_3 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_18 = new ToolStripMenuItem();
			this.toolStripMenuItem_11 = new ToolStripMenuItem();
			this.toolStripSeparator_13 = new ToolStripSeparator();
			this.toolStripMenuItem_9 = new ToolStripMenuItem();
			this.toolStripMenuItem_13 = new ToolStripMenuItem();
			this.toolStripMenuItem_10 = new ToolStripMenuItem();
			this.toolStripMenuItem_14 = new ToolStripMenuItem();
			this.toolStripMenuItem_15 = new ToolStripMenuItem();
			this.toolStripMenuItem_16 = new ToolStripMenuItem();
			this.toolStripMenuItem_17 = new ToolStripMenuItem();
			this.toolStripSeparator_16 = new ToolStripSeparator();
			this.toolStripMenuItem_12 = new ToolStripMenuItem();
			this.toolStripSeparator_22 = new ToolStripSeparator();
			this.toolStripMenuItem_20 = new ToolStripMenuItem();
			this.toolStrip_3 = new ToolStrip();
			this.toolStripButton_7 = new ToolStripButton();
			this.toolStripButton_8 = new ToolStripButton();
			this.toolStripSeparator_12 = new ToolStripSeparator();
			this.toolStripButton_9 = new ToolStripButton();
			this.toolStripSeparator_20 = new ToolStripSeparator();
			this.toolStripButton_19 = new ToolStripButton();
			this.toolStripSeparator_61 = new ToolStripSeparator();
			this.toolStripButton_64 = new ToolStripButton();
			this.toolStripSeparator_44 = new ToolStripSeparator();
			this.toolStripLabel_1 = new ToolStripLabel();
			this.tabPage_2 = new TabPage();
			this.tableLayoutPanel_4 = new TableLayoutPanel();
			this.dataGridView_2 = new DataGridView();
			this.contextMenuStrip_6 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_30 = new ToolStripMenuItem();
			this.toolStripMenuItem_31 = new ToolStripMenuItem();
			this.toolStripMenuItem_32 = new ToolStripMenuItem();
			this.toolStripMenuItem_33 = new ToolStripMenuItem();
			this.toolStripMenuItem_34 = new ToolStripMenuItem();
			this.toolStripSeparator_30 = new ToolStripSeparator();
			this.toolStripMenuItem_35 = new ToolStripMenuItem();
			this.toolStripSeparator_31 = new ToolStripSeparator();
			this.toolStripMenuItem_36 = new ToolStripMenuItem();
			this.toolStrip_4 = new ToolStrip();
			this.toolStripButton_27 = new ToolStripButton();
			this.toolStripButton_10 = new ToolStripButton();
			this.toolStripSeparator_14 = new ToolStripSeparator();
			this.toolStripButton_11 = new ToolStripButton();
			this.toolStripSeparator_15 = new ToolStripSeparator();
			this.toolStripButton_12 = new ToolStripButton();
			this.toolStripSeparator_62 = new ToolStripSeparator();
			this.toolStripButton_65 = new ToolStripButton();
			this.tabPage_12 = new TabPage();
			this.tableLayoutPanel_15 = new TableLayoutPanel();
			this.dataGridView_11 = new DataGridView();
			this.contextMenuStrip_10 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_56 = new ToolStripMenuItem();
			this.toolStripMenuItem_57 = new ToolStripMenuItem();
			this.toolStripSeparator_59 = new ToolStripSeparator();
			this.toolStripMenuItem_58 = new ToolStripMenuItem();
			this.toolStrip_14 = new ToolStrip();
			this.toolStripButton_58 = new ToolStripButton();
			this.toolStripButton_59 = new ToolStripButton();
			this.toolStripSeparator_57 = new ToolStripSeparator();
			this.toolStripButton_60 = new ToolStripButton();
			this.toolStripSeparator_58 = new ToolStripSeparator();
			this.toolStripButton_61 = new ToolStripButton();
			this.toolStripSeparator_63 = new ToolStripSeparator();
			this.toolStripButton_66 = new ToolStripButton();
			this.tabPage_0 = new TabPage();
			this.tableLayoutPanel_2 = new TableLayoutPanel();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_2 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_8 = new ToolStripMenuItem();
			this.toolStripSeparator_8 = new ToolStripSeparator();
			this.toolStripMenuItem_5 = new ToolStripMenuItem();
			this.toolStripMenuItem_6 = new ToolStripMenuItem();
			this.toolStripSeparator_7 = new ToolStripSeparator();
			this.toolStripMenuItem_7 = new ToolStripMenuItem();
			this.toolStripSeparator_23 = new ToolStripSeparator();
			this.toolStripMenuItem_21 = new ToolStripMenuItem();
			this.toolStrip_2 = new ToolStrip();
			this.toolStripButton_13 = new ToolStripButton();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripSeparator_10 = new ToolStripSeparator();
			this.toolStripButton_5 = new ToolStripButton();
			this.toolStripSeparator_17 = new ToolStripSeparator();
			this.toolStripButton_14 = new ToolStripButton();
			this.toolStripButton_20 = new ToolStripButton();
			this.tabPage_3 = new TabPage();
			this.tableLayoutPanel_5 = new TableLayoutPanel();
			this.dataGridView_3 = new DataGridView();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_4 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_22 = new ToolStripMenuItem();
			this.toolStripMenuItem_23 = new ToolStripMenuItem();
			this.toolStripSeparator_24 = new ToolStripSeparator();
			this.toolStripMenuItem_24 = new ToolStripMenuItem();
			this.toolStripSeparator_25 = new ToolStripSeparator();
			this.toolStripMenuItem_25 = new ToolStripMenuItem();
			this.toolStrip_5 = new ToolStrip();
			this.toolStripButton_15 = new ToolStripButton();
			this.toolStripButton_16 = new ToolStripButton();
			this.toolStripSeparator_18 = new ToolStripSeparator();
			this.toolStripButton_17 = new ToolStripButton();
			this.toolStripSeparator_19 = new ToolStripSeparator();
			this.toolStripButton_18 = new ToolStripButton();
			this.toolStripButton_21 = new ToolStripButton();
			this.tabPage_4 = new TabPage();
			this.tableLayoutPanel_7 = new TableLayoutPanel();
			this.dataGridView_5 = new DataGridView();
			this.dataGridViewTextBoxColumn_80 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_81 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_82 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_83 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_84 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_85 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_86 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_87 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_88 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_89 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_90 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_91 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_92 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_93 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_5 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_26 = new ToolStripMenuItem();
			this.toolStripMenuItem_27 = new ToolStripMenuItem();
			this.toolStripSeparator_28 = new ToolStripSeparator();
			this.toolStripMenuItem_28 = new ToolStripMenuItem();
			this.toolStripSeparator_29 = new ToolStripSeparator();
			this.toolStripMenuItem_29 = new ToolStripMenuItem();
			this.toolStrip_6 = new ToolStrip();
			this.toolStripButton_22 = new ToolStripButton();
			this.toolStripButton_23 = new ToolStripButton();
			this.toolStripSeparator_26 = new ToolStripSeparator();
			this.toolStripButton_24 = new ToolStripButton();
			this.toolStripSeparator_27 = new ToolStripSeparator();
			this.toolStripButton_25 = new ToolStripButton();
			this.toolStripButton_26 = new ToolStripButton();
			this.tabPage_6 = new TabPage();
			this.tableLayoutPanel_9 = new TableLayoutPanel();
			this.dataGridView_7 = new DataGridView();
			this.dataGridViewTextBoxColumn_124 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_125 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_126 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_127 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_128 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_129 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_130 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_131 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_132 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_133 = new DataGridViewTextBoxColumn();
			this.toolStrip_8 = new ToolStrip();
			this.toolStripButton_33 = new ToolStripButton();
			this.toolStripButton_34 = new ToolStripButton();
			this.toolStripSeparator_35 = new ToolStripSeparator();
			this.toolStripButton_35 = new ToolStripButton();
			this.toolStripSeparator_36 = new ToolStripSeparator();
			this.toolStripButton_36 = new ToolStripButton();
			this.toolStripSeparator_37 = new ToolStripSeparator();
			this.toolStripButton_37 = new ToolStripButton();
			this.toolStripSeparator_38 = new ToolStripSeparator();
			this.toolStripButton_38 = new ToolStripButton();
			this.tabPage_7 = new TabPage();
			this.tableLayoutPanel_10 = new TableLayoutPanel();
			this.dataGridView_8 = new DataGridView();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_134 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_135 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_136 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_137 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_138 = new DataGridViewTextBoxColumn();
			this.bindingSource_5 = new BindingSource(this.icontainer_0);
			this.dsPassport_0 = new dsPassport();
			this.toolStrip_9 = new ToolStrip();
			this.toolStripSeparator_39 = new ToolStripSeparator();
			this.toolStripButton_39 = new ToolStripButton();
			this.toolStripSeparator_40 = new ToolStripSeparator();
			this.toolStripButton_40 = new ToolStripButton();
			this.toolStripSeparator_41 = new ToolStripSeparator();
			this.toolStripButton_41 = new ToolStripButton();
			this.tabPage_8 = new TabPage();
			this.tableLayoutPanel_11 = new TableLayoutPanel();
			this.dataGridView_9 = new DataGridView();
			this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_139 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_140 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_141 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_142 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_143 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_144 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_145 = new DataGridViewTextBoxColumn();
			this.bindingSource_6 = new BindingSource(this.icontainer_0);
			this.toolStrip_10 = new ToolStrip();
			this.toolStripButton_42 = new ToolStripButton();
			this.toolStripButton_43 = new ToolStripButton();
			this.toolStripSeparator_42 = new ToolStripSeparator();
			this.toolStripButton_44 = new ToolStripButton();
			this.toolStripSeparator_43 = new ToolStripSeparator();
			this.toolStripButton_45 = new ToolStripButton();
			this.tabPage_9 = new TabPage();
			this.toolStrip_11 = new ToolStrip();
			this.toolStripButton_46 = new ToolStripButton();
			this.toolStripButton_47 = new ToolStripButton();
			this.toolStripSeparator_45 = new ToolStripSeparator();
			this.toolStripButton_48 = new ToolStripButton();
			this.toolStripSeparator_46 = new ToolStripSeparator();
			this.toolStripButton_49 = new ToolStripButton();
			this.tableLayoutPanel_12 = new TableLayoutPanel();
			this.dataGridViewExcelFilter_1 = new DataGridViewExcelFilter();
			this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_159 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_160 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_161 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_162 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_163 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_164 = new DataGridViewTextBoxColumn();
			this.bindingSource_8 = new BindingSource(this.icontainer_0);
			this.tabPage_10 = new TabPage();
			this.tableLayoutPanel_13 = new TableLayoutPanel();
			this.toolStrip_12 = new ToolStrip();
			this.toolStripButton_50 = new ToolStripButton();
			this.toolStripButton_51 = new ToolStripButton();
			this.toolStripSeparator_49 = new ToolStripSeparator();
			this.toolStripButton_52 = new ToolStripButton();
			this.toolStripSeparator_50 = new ToolStripSeparator();
			this.toolStripButton_53 = new ToolStripButton();
			this.toolStripSeparator_64 = new ToolStripSeparator();
			this.toolStripButton_67 = new ToolStripButton();
			this.treeDataGridView_0 = new TreeDataGridView();
			this.treeGridColumn_0 = new TreeGridColumn();
			this.treeGridColumn_1 = new TreeGridColumn();
			this.treeGridColumn_2 = new TreeGridColumn();
			this.treeGridColumn_3 = new TreeGridColumn();
			this.treeGridColumn_4 = new TreeGridColumn();
			this.dataGridViewTextBoxColumn_165 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_166 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_167 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_168 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_169 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_170 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_171 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_172 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_173 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_174 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_8 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_47 = new ToolStripMenuItem();
			this.toolStripMenuItem_48 = new ToolStripMenuItem();
			this.toolStripSeparator_53 = new ToolStripSeparator();
			this.toolStripMenuItem_49 = new ToolStripMenuItem();
			this.toolStripSeparator_54 = new ToolStripSeparator();
			this.toolStripMenuItem_50 = new ToolStripMenuItem();
			this.tabPage_11 = new TabPage();
			this.tableLayoutPanel_14 = new TableLayoutPanel();
			this.dataGridView_10 = new DataGridView();
			this.dataGridViewTextBoxColumn_211 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_212 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_213 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_214 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_215 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_216 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_9 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_51 = new ToolStripMenuItem();
			this.toolStripMenuItem_52 = new ToolStripMenuItem();
			this.toolStripSeparator_55 = new ToolStripSeparator();
			this.toolStripMenuItem_53 = new ToolStripMenuItem();
			this.toolStripSeparator_56 = new ToolStripSeparator();
			this.toolStripMenuItem_54 = new ToolStripMenuItem();
			this.toolStrip_13 = new ToolStrip();
			this.toolStripButton_54 = new ToolStripButton();
			this.toolStripButton_55 = new ToolStripButton();
			this.toolStripSeparator_51 = new ToolStripSeparator();
			this.toolStripButton_56 = new ToolStripButton();
			this.toolStripSeparator_52 = new ToolStripSeparator();
			this.toolStripButton_57 = new ToolStripButton();
			this.toolStripSeparator_65 = new ToolStripSeparator();
			this.toolStripButton_68 = new ToolStripButton();
			this.tabPage_13 = new TabPage();
			this.toolStrip_15 = new ToolStrip();
			this.toolStripButton_69 = new ToolStripButton();
			this.toolStripButton_70 = new ToolStripButton();
			this.toolStripSeparator_66 = new ToolStripSeparator();
			this.toolStripButton_71 = new ToolStripButton();
			this.toolStripSeparator_67 = new ToolStripSeparator();
			this.toolStripButton_72 = new ToolStripButton();
			this.tableLayoutPanel_16 = new TableLayoutPanel();
			this.dataGridViewExcelFilter_2 = new DataGridViewExcelFilter();
			this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_175 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_176 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_177 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_178 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_179 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_180 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_181 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_182 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_183 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_184 = new DataGridViewTextBoxColumn();
			this.bindingSource_9 = new BindingSource(this.icontainer_0);
			this.contextMenuStrip_7 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_43 = new ToolStripMenuItem();
			this.toolStripMenuItem_44 = new ToolStripMenuItem();
			this.toolStripSeparator_47 = new ToolStripSeparator();
			this.toolStripMenuItem_45 = new ToolStripMenuItem();
			this.toolStripSeparator_48 = new ToolStripSeparator();
			this.toolStripMenuItem_46 = new ToolStripMenuItem();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dsDocuments_0 = new dsDocuments();
			this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
			this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.bindingSource_3 = new BindingSource(this.icontainer_0);
			this.bindingSource_4 = new BindingSource(this.icontainer_0);
			this.bindingSource_7 = new BindingSource(this.icontainer_0);
			this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_69 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_70 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_71 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_72 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_73 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_74 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_75 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_76 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_77 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_78 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_79 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_112 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_113 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_114 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_115 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_116 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_117 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_118 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_119 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_120 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_121 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_122 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_123 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_146 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_147 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_148 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_149 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_150 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_151 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_152 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_153 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_154 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_155 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_156 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_157 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_158 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_185 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_186 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_187 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_188 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_189 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_190 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_191 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_192 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_193 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_194 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_195 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_196 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_197 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_198 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_199 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_200 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_201 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_202 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_203 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_217 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_0.SuspendLayout();
			this.contextMenuStrip_1.SuspendLayout();
			this.tableLayoutPanel_0.SuspendLayout();
			this.tableLayoutPanel_1.SuspendLayout();
			this.toolStrip_1.SuspendLayout();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			this.tableLayoutPanel_6.SuspendLayout();
			((ISupportInitialize)this.dataGridView_4).BeginInit();
			this.dataGridViewExcelFilter_0.BeginInit();
			this.tabControl_0.SuspendLayout();
			this.tabPage_5.SuspendLayout();
			this.tableLayoutPanel_8.SuspendLayout();
			this.toolStrip_7.SuspendLayout();
			((ISupportInitialize)this.dataGridView_6).BeginInit();
			this.tabPage_1.SuspendLayout();
			this.tableLayoutPanel_3.SuspendLayout();
			((ISupportInitialize)this.dataGridView_1).BeginInit();
			this.contextMenuStrip_3.SuspendLayout();
			this.toolStrip_3.SuspendLayout();
			this.tabPage_2.SuspendLayout();
			this.tableLayoutPanel_4.SuspendLayout();
			((ISupportInitialize)this.dataGridView_2).BeginInit();
			this.contextMenuStrip_6.SuspendLayout();
			this.toolStrip_4.SuspendLayout();
			this.tabPage_12.SuspendLayout();
			this.tableLayoutPanel_15.SuspendLayout();
			((ISupportInitialize)this.dataGridView_11).BeginInit();
			this.contextMenuStrip_10.SuspendLayout();
			this.toolStrip_14.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.tableLayoutPanel_2.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			this.contextMenuStrip_2.SuspendLayout();
			this.toolStrip_2.SuspendLayout();
			this.tabPage_3.SuspendLayout();
			this.tableLayoutPanel_5.SuspendLayout();
			((ISupportInitialize)this.dataGridView_3).BeginInit();
			this.contextMenuStrip_4.SuspendLayout();
			this.toolStrip_5.SuspendLayout();
			this.tabPage_4.SuspendLayout();
			this.tableLayoutPanel_7.SuspendLayout();
			((ISupportInitialize)this.dataGridView_5).BeginInit();
			this.contextMenuStrip_5.SuspendLayout();
			this.toolStrip_6.SuspendLayout();
			this.tabPage_6.SuspendLayout();
			this.tableLayoutPanel_9.SuspendLayout();
			((ISupportInitialize)this.dataGridView_7).BeginInit();
			this.toolStrip_8.SuspendLayout();
			this.tabPage_7.SuspendLayout();
			this.tableLayoutPanel_10.SuspendLayout();
			((ISupportInitialize)this.dataGridView_8).BeginInit();
			((ISupportInitialize)this.bindingSource_5).BeginInit();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			this.toolStrip_9.SuspendLayout();
			this.tabPage_8.SuspendLayout();
			this.tableLayoutPanel_11.SuspendLayout();
			((ISupportInitialize)this.dataGridView_9).BeginInit();
			((ISupportInitialize)this.bindingSource_6).BeginInit();
			this.toolStrip_10.SuspendLayout();
			this.tabPage_9.SuspendLayout();
			this.toolStrip_11.SuspendLayout();
			this.tableLayoutPanel_12.SuspendLayout();
			this.dataGridViewExcelFilter_1.BeginInit();
			((ISupportInitialize)this.bindingSource_8).BeginInit();
			this.tabPage_10.SuspendLayout();
			this.tableLayoutPanel_13.SuspendLayout();
			this.toolStrip_12.SuspendLayout();
			this.treeDataGridView_0.BeginInit();
			this.contextMenuStrip_8.SuspendLayout();
			this.tabPage_11.SuspendLayout();
			this.tableLayoutPanel_14.SuspendLayout();
			((ISupportInitialize)this.dataGridView_10).BeginInit();
			this.contextMenuStrip_9.SuspendLayout();
			this.toolStrip_13.SuspendLayout();
			this.tabPage_13.SuspendLayout();
			this.toolStrip_15.SuspendLayout();
			this.tableLayoutPanel_16.SuspendLayout();
			this.dataGridViewExcelFilter_2.BeginInit();
			((ISupportInitialize)this.bindingSource_9).BeginInit();
			this.contextMenuStrip_7.SuspendLayout();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			((ISupportInitialize)this.bindingSource_3).BeginInit();
			((ISupportInitialize)this.bindingSource_4).BeginInit();
			((ISupportInitialize)this.bindingSource_7).BeginInit();
			base.SuspendLayout();
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_37,
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_38,
				this.toolStripSeparator_0,
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_40,
				this.toolStripMenuItem_41,
				this.toolStripSeparator_1,
				this.toolStripMenuItem_2,
				this.toolStripMenuItem_42,
				this.toolStripMenuItem_55,
				this.toolStripMenuItem_59,
				this.toolStripMenuItem_60
			});
			this.contextMenuStrip_0.Name = "cmsGeneral";
			this.contextMenuStrip_0.Size = new Size(216, 258);
			this.contextMenuStrip_0.Text = "Контекстное меню";
			this.contextMenuStrip_0.Opening += this.contextMenuStrip_0_Opening;
			this.toolStripMenuItem_37.Image = Resources.ElementAdd;
			this.toolStripMenuItem_37.Name = "tsmiTransfAdd";
			this.toolStripMenuItem_37.Size = new Size(215, 22);
			this.toolStripMenuItem_37.Text = "Добавить";
			this.toolStripMenuItem_37.Click += this.toolStripMenuItem_37_Click;
			this.toolStripMenuItem_0.Image = Resources.ElementEdit;
			this.toolStripMenuItem_0.Name = "tsmiEdit";
			this.toolStripMenuItem_0.Size = new Size(215, 22);
			this.toolStripMenuItem_0.Text = "Редактировать";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
			this.toolStripMenuItem_38.Image = Resources.rename;
			this.toolStripMenuItem_38.Name = "toolStripMenuItem1";
			this.toolStripMenuItem_38.Size = new Size(215, 22);
			this.toolStripMenuItem_38.Text = "Переименовать";
			this.toolStripMenuItem_38.Click += this.toolStripMenuItem_38_Click;
			this.toolStripSeparator_0.Name = "tssMove";
			this.toolStripSeparator_0.Size = new Size(212, 6);
			this.toolStripMenuItem_1.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_61,
				this.toolStripMenuItem_62
			});
			this.toolStripMenuItem_1.Name = "tsmiMove";
			this.toolStripMenuItem_1.Size = new Size(215, 22);
			this.toolStripMenuItem_1.Text = "Перемещение";
			this.toolStripMenuItem_61.Name = "tsmiToMove";
			this.toolStripMenuItem_61.Size = new Size(146, 22);
			this.toolStripMenuItem_61.Text = "Переместить";
			this.toolStripMenuItem_61.ToolTipText = "Переместить трансформатор";
			this.toolStripMenuItem_61.Click += this.toolStripMenuItem_65_Click;
			this.toolStripMenuItem_62.Name = "tsmiToAddMove";
			this.toolStripMenuItem_62.Size = new Size(146, 22);
			this.toolStripMenuItem_62.Text = "Документ";
			this.toolStripMenuItem_62.ToolTipText = "Добавить документ";
			this.toolStripMenuItem_62.Click += this.toolStripButton_28_Click;
			this.toolStripMenuItem_40.Image = Resources.chain_unchain;
			this.toolStripMenuItem_40.Name = "tsmiUnbind";
			this.toolStripMenuItem_40.Size = new Size(215, 22);
			this.toolStripMenuItem_40.Text = "Отвязать";
			this.toolStripMenuItem_40.Click += this.toolStripMenuItem_40_Click;
			this.toolStripMenuItem_41.Image = Resources.chain;
			this.toolStripMenuItem_41.Name = "tsmiBind";
			this.toolStripMenuItem_41.Size = new Size(215, 22);
			this.toolStripMenuItem_41.Text = "Привязать";
			this.toolStripMenuItem_41.Click += this.toolStripMenuItem_41_Click;
			this.toolStripSeparator_1.Name = "tssDelete";
			this.toolStripSeparator_1.Size = new Size(212, 6);
			this.toolStripMenuItem_2.Image = Resources.ElementDel;
			this.toolStripMenuItem_2.Name = "tsmiDelete";
			this.toolStripMenuItem_2.Size = new Size(215, 22);
			this.toolStripMenuItem_2.Text = "Удалить";
			this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
			this.toolStripMenuItem_42.Image = Resources.mapGo;
			this.toolStripMenuItem_42.Name = "tsmiMapGo";
			this.toolStripMenuItem_42.Size = new Size(215, 22);
			this.toolStripMenuItem_42.Text = "Переход на схему";
			this.toolStripMenuItem_42.Click += this.toolStripButton_63_Click;
			this.toolStripMenuItem_55.Image = Resources.Trash;
			this.toolStripMenuItem_55.Name = "tsmiTransfDelete";
			this.toolStripMenuItem_55.Size = new Size(215, 22);
			this.toolStripMenuItem_55.Text = "Удалить трансформатор";
			this.toolStripMenuItem_55.Click += this.toolStripMenuItem_55_Click;
			this.toolStripMenuItem_59.Image = Resources._1352700444_table_row_insert;
			this.toolStripMenuItem_59.Name = "tsmiLoadOldPassport";
			this.toolStripMenuItem_59.Size = new Size(215, 22);
			this.toolStripMenuItem_59.Text = "Загрузить из старой БД";
			this.toolStripMenuItem_59.Click += this.toolStripButton_62_Click;
			this.toolStripMenuItem_60.Name = "tsmiBindReference";
			this.toolStripMenuItem_60.Size = new Size(215, 22);
			this.toolStripMenuItem_60.Text = "Привязать к справочнику";
			this.toolStripMenuItem_60.Click += this.toolStripMenuItem_60_Click;
			this.contextMenuStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_3,
				this.toolStripMenuItem_39,
				this.toolStripSeparator_2,
				this.toolStripMenuItem_4,
				this.toolStripSeparator_21,
				this.toolStripMenuItem_19
			});
			this.contextMenuStrip_1.Name = "cmsMoveTransf";
			this.contextMenuStrip_1.Size = new Size(155, 104);
			this.toolStripMenuItem_3.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_63,
				this.toolStripMenuItem_64
			});
			this.toolStripMenuItem_3.Image = Resources.ElementAdd;
			this.toolStripMenuItem_3.Name = "tsmiAddMove";
			this.toolStripMenuItem_3.Size = new Size(154, 22);
			this.toolStripMenuItem_3.Text = "Перемещение";
			this.toolStripMenuItem_63.Name = "tlsmiAddMoveTransf";
			this.toolStripMenuItem_63.Size = new Size(146, 22);
			this.toolStripMenuItem_63.Text = "Переместить";
			this.toolStripMenuItem_63.Click += this.toolStripMenuItem_65_Click;
			this.toolStripMenuItem_64.Name = "tsmiAddMoveTransfDoc";
			this.toolStripMenuItem_64.Size = new Size(146, 22);
			this.toolStripMenuItem_64.Text = "Документ";
			this.toolStripMenuItem_64.Click += this.toolStripButton_28_Click;
			this.toolStripMenuItem_39.Image = Resources.ElementEdit;
			this.toolStripMenuItem_39.Name = "редактироватьToolStripMenuItem";
			this.toolStripMenuItem_39.Size = new Size(154, 22);
			this.toolStripMenuItem_39.Text = "Редактировать";
			this.toolStripMenuItem_39.Click += this.toolStripButton_32_Click;
			this.toolStripSeparator_2.Name = "tssiDeleteMove";
			this.toolStripSeparator_2.Size = new Size(151, 6);
			this.toolStripMenuItem_4.Image = Resources.ElementDel;
			this.toolStripMenuItem_4.Name = "tsmiDeleteMove";
			this.toolStripMenuItem_4.Size = new Size(154, 22);
			this.toolStripMenuItem_4.Text = "Удалить";
			this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
			this.toolStripSeparator_21.Name = "tssiRefreshMove";
			this.toolStripSeparator_21.Size = new Size(151, 6);
			this.toolStripMenuItem_19.Image = Resources.refresh_16;
			this.toolStripMenuItem_19.Name = "tsmiRefreshMove";
			this.toolStripMenuItem_19.Size = new Size(154, 22);
			this.toolStripMenuItem_19.Text = "Обновить";
			this.backgroundWorker_0.WorkerReportsProgress = true;
			this.backgroundWorker_0.WorkerSupportsCancellation = true;
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98f));
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(3, 527);
			this.tableLayoutPanel_0.Name = "tlpButton";
			this.tableLayoutPanel_0.RowCount = 1;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Size = new Size(778, 32);
			this.tableLayoutPanel_0.TabIndex = 2;
			this.button_0.Location = new Point(683, 3);
			this.button_0.Name = "btnClose";
			this.button_0.Size = new Size(85, 25);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.toolStrip_0.AutoSize = false;
			this.toolStrip_0.CanOverflow = false;
			this.toolStrip_0.Dock = DockStyle.None;
			this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_0.Location = new Point(441, 3);
			this.toolStrip_0.Name = "miniToolStrip";
			this.toolStrip_0.Size = new Size(784, 25);
			this.toolStrip_0.TabIndex = 1;
			this.toolStripSeparator_3.Name = "tssExcel";
			this.toolStripSeparator_3.Size = new Size(6, 25);
			this.toolStripSeparator_4.Name = "tssPasportType";
			this.toolStripSeparator_4.Size = new Size(6, 25);
			this.toolStripLabel_0.Name = "toolStripLabel1";
			this.toolStripLabel_0.Size = new Size(50, 22);
			this.toolStripLabel_0.Text = "Реестр: ";
			this.toolStripComboBox_0.BackColor = SystemColors.Window;
			this.toolStripComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.toolStripComboBox_0.Items.AddRange(new object[]
			{
				"Подстанция",
				"Трансформатор",
				"Кабельная линия",
				"Воздушная линия",
				"Трансформаторы напряжения"
			});
			this.toolStripComboBox_0.Name = "tscbPasportType";
			this.toolStripComboBox_0.Size = new Size(230, 25);
			this.toolStripComboBox_0.SelectedIndexChanged += this.toolStripComboBox_0_SelectedIndexChanged;
			this.toolStripSeparator_5.Name = "tssTypeSubs";
			this.toolStripSeparator_5.Size = new Size(6, 25);
			this.toolStripSeparator_5.Visible = false;
			this.toolStripComboBox_1.BackColor = SystemColors.Window;
			this.toolStripComboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.toolStripComboBox_1.Name = "tscbTypeSubs";
			this.toolStripComboBox_1.Size = new Size(121, 25);
			this.toolStripComboBox_1.Visible = false;
			this.toolStripSeparator_6.Name = "tssComplit";
			this.toolStripSeparator_6.Size = new Size(6, 25);
			this.tableLayoutPanel_1.ColumnCount = 1;
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.Controls.Add(this.toolStrip_1, 0, 0);
			this.tableLayoutPanel_1.Controls.Add(this.tableLayoutPanel_0, 0, 3);
			this.tableLayoutPanel_1.Controls.Add(this.splitContainer_0, 0, 2);
			this.tableLayoutPanel_1.Dock = DockStyle.Fill;
			this.tableLayoutPanel_1.Location = new Point(0, 0);
			this.tableLayoutPanel_1.Name = "tlpGeneral";
			this.tableLayoutPanel_1.RowCount = 4;
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38f));
			this.tableLayoutPanel_1.Size = new Size(784, 562);
			this.tableLayoutPanel_1.TabIndex = 1;
			this.toolStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripSeparator_3,
				this.toolStripButton_1,
				this.toolStripSeparator_4,
				this.toolStripLabel_0,
				this.toolStripComboBox_0,
				this.toolStripSeparator_5,
				this.toolStripComboBox_1,
				this.toolStripSeparator_6,
				this.toolStripButton_2,
				this.toolStripSeparator_9,
				this.toolStripButton_3,
				this.toolStripSeparator_11,
				this.toolStripButton_6,
				this.toolStripSeparator_60,
				this.toolStripButton_62,
				this.toolStripButton_63,
				this.toolStripButton_73
			});
			this.toolStrip_1.Location = new Point(0, 0);
			this.toolStrip_1.Name = "tsGeneral";
			this.toolStrip_1.Size = new Size(784, 25);
			this.toolStrip_1.TabIndex = 1;
			this.toolStrip_1.Text = "toolStrip1";
			this.toolStripButton_0.Checked = true;
			this.toolStripButton_0.CheckState = CheckState.Checked;
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.check_all;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "tsbViewReport";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Выбор полей";
			this.toolStripButton_0.Visible = false;
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.microsoftoffice2007excel_7581;
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "tsbExcel";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Экпорт в Excel";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_2.Image = (Image)componentResourceManager.GetObject("tsbComplit.Image");
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "tsbComplit";
			this.toolStripButton_2.Size = new Size(73, 22);
			this.toolStripButton_2.Text = "Выполнить";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.toolStripSeparator_9.Name = "tssSearch";
			this.toolStripSeparator_9.Size = new Size(6, 25);
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = Resources.Find;
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "tsbSearch";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Поиск";
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.toolStripSeparator_11.Name = "toolStripSeparator7";
			this.toolStripSeparator_11.Size = new Size(6, 25);
			this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_6.Image = Resources.refresh_16;
			this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_6.Name = "tsbRefresh";
			this.toolStripButton_6.Size = new Size(23, 22);
			this.toolStripButton_6.Text = "Обновить";
			this.toolStripButton_6.Click += this.toolStripButton_6_Click;
			this.toolStripSeparator_60.Name = "toolStripSeparator18";
			this.toolStripSeparator_60.Size = new Size(6, 25);
			this.toolStripButton_62.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_62.Image = Resources._1352700444_table_row_insert;
			this.toolStripButton_62.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_62.Name = "tsbLoadOldCablePassport";
			this.toolStripButton_62.Size = new Size(23, 22);
			this.toolStripButton_62.Text = "Загрузить из старой БД";
			this.toolStripButton_62.Click += this.toolStripButton_62_Click;
			this.toolStripButton_63.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_63.Image = Resources.mapGo;
			this.toolStripButton_63.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_63.Name = "tsbMapGo";
			this.toolStripButton_63.Size = new Size(23, 22);
			this.toolStripButton_63.Text = "Переход на схему";
			this.toolStripButton_63.Click += this.toolStripButton_63_Click;
			this.toolStripButton_73.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_73.Image = (Image)componentResourceManager.GetObject("toolStripButton1.Image");
			this.toolStripButton_73.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_73.Name = "toolStripButton1";
			this.toolStripButton_73.Size = new Size(184, 22);
			this.toolStripButton_73.Text = "Обновить привязанные трансы";
			this.toolStripButton_73.Visible = false;
			this.toolStripButton_73.Click += this.toolStripButton_73_Click;
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.Location = new Point(3, 48);
			this.splitContainer_0.Name = "splitContainer1";
			this.splitContainer_0.Orientation = Orientation.Horizontal;
			this.splitContainer_0.Panel1.Controls.Add(this.tableLayoutPanel_6);
			this.splitContainer_0.Panel2.Controls.Add(this.tabControl_0);
			this.splitContainer_0.Size = new Size(778, 473);
			this.splitContainer_0.SplitterDistance = 235;
			this.splitContainer_0.TabIndex = 4;
			this.tableLayoutPanel_6.ColumnCount = 2;
			this.tableLayoutPanel_6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 17f));
			this.tableLayoutPanel_6.Controls.Add(this.dataGridView_4, 0, 1);
			this.tableLayoutPanel_6.Controls.Add(this.dataGridViewExcelFilter_0, 0, 0);
			this.tableLayoutPanel_6.Dock = DockStyle.Fill;
			this.tableLayoutPanel_6.Location = new Point(0, 0);
			this.tableLayoutPanel_6.Name = "tlp";
			this.tableLayoutPanel_6.RowCount = 2;
			this.tableLayoutPanel_6.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_6.RowStyles.Add(new RowStyle(SizeType.Absolute, 28f));
			this.tableLayoutPanel_6.Size = new Size(778, 235);
			this.tableLayoutPanel_6.TabIndex = 0;
			this.dataGridView_4.AllowUserToAddRows = false;
			this.dataGridView_4.AllowUserToDeleteRows = false;
			this.dataGridView_4.AllowUserToResizeColumns = false;
			this.dataGridView_4.AllowUserToResizeRows = false;
			this.dataGridView_4.BackgroundColor = SystemColors.Control;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridView_4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_4.ColumnHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridView_4.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_4.Dock = DockStyle.Fill;
			this.dataGridView_4.Location = new Point(3, 210);
			this.dataGridView_4.Name = "dgvTotal";
			this.dataGridView_4.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridView_4.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_4.RowHeadersWidth = 20;
			this.dataGridView_4.ScrollBars = ScrollBars.None;
			this.dataGridView_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_4.Size = new Size(755, 22);
			this.dataGridView_4.TabIndex = 6;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
			this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = SystemColors.Control;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableLayoutPanel_6.SetColumnSpan(this.dataGridViewExcelFilter_0, 2);
			this.dataGridViewExcelFilter_0.ContextMenuStrip = this.contextMenuStrip_0;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Window;
			dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_0.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(3, 3);
			this.dataGridViewExcelFilter_0.MultiSelect = false;
			this.dataGridViewExcelFilter_0.Name = "dgvGeneral";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = SystemColors.Control;
			dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewExcelFilter_0.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_0.Size = new Size(772, 201);
			this.dataGridViewExcelFilter_0.TabIndex = 5;
			this.dataGridViewExcelFilter_0.RowHeadersWidthChanged += this.dataGridViewExcelFilter_0_RowHeadersWidthChanged;
			this.dataGridViewExcelFilter_0.CellFormatting += this.dataGridViewExcelFilter_0_CellFormatting;
			this.dataGridViewExcelFilter_0.CellMouseDoubleClick += this.dataGridViewExcelFilter_0_CellMouseDoubleClick;
			this.dataGridViewExcelFilter_0.CellMouseEnter += this.dataGridViewExcelFilter_0_CellMouseEnter;
			this.dataGridViewExcelFilter_0.ColumnDisplayIndexChanged += this.dataGridViewExcelFilter_0_ColumnDisplayIndexChanged;
			this.dataGridViewExcelFilter_0.ColumnWidthChanged += this.dataGridViewExcelFilter_0_ColumnWidthChanged;
			this.dataGridViewExcelFilter_0.RowsAdded += this.dataGridViewExcelFilter_0_RowsAdded;
			this.dataGridViewExcelFilter_0.Scroll += this.dataGridViewExcelFilter_0_Scroll;
			this.dataGridViewExcelFilter_0.SelectionChanged += this.dataGridViewExcelFilter_0_SelectionChanged;
			this.dataGridViewExcelFilter_0.Sorted += this.dataGridViewExcelFilter_0_Sorted;
			this.dataGridViewExcelFilter_0.BindingContextChanged += this.dataGridViewExcelFilter_0_BindingContextChanged;
			this.tabControl_0.Controls.Add(this.tabPage_5);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Controls.Add(this.tabPage_2);
			this.tabControl_0.Controls.Add(this.tabPage_12);
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_3);
			this.tabControl_0.Controls.Add(this.tabPage_4);
			this.tabControl_0.Controls.Add(this.tabPage_6);
			this.tabControl_0.Controls.Add(this.tabPage_7);
			this.tabControl_0.Controls.Add(this.tabPage_8);
			this.tabControl_0.Controls.Add(this.tabPage_9);
			this.tabControl_0.Controls.Add(this.tabPage_10);
			this.tabControl_0.Controls.Add(this.tabPage_11);
			this.tabControl_0.Controls.Add(this.tabPage_13);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(0, 0);
			this.tabControl_0.Name = "tcGeneral";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(778, 234);
			this.tabControl_0.TabIndex = 5;
			this.tabControl_0.Selected += this.tabControl_0_Selected;
			this.tabPage_5.Controls.Add(this.tableLayoutPanel_8);
			this.tabPage_5.Location = new Point(4, 22);
			this.tabPage_5.Name = "tpMove";
			this.tabPage_5.Padding = new Padding(3);
			this.tabPage_5.Size = new Size(770, 208);
			this.tabPage_5.TabIndex = 0;
			this.tabPage_5.Text = "Перемещение";
			this.tabPage_5.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_8.ColumnCount = 1;
			this.tableLayoutPanel_8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_8.Controls.Add(this.toolStrip_7, 0, 0);
			this.tableLayoutPanel_8.Controls.Add(this.dataGridView_6, 0, 1);
			this.tableLayoutPanel_8.Dock = DockStyle.Fill;
			this.tableLayoutPanel_8.Location = new Point(3, 3);
			this.tableLayoutPanel_8.Name = "tlpMove";
			this.tableLayoutPanel_8.RowCount = 2;
			this.tableLayoutPanel_8.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_8.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_8.Size = new Size(764, 202);
			this.tableLayoutPanel_8.TabIndex = 0;
			this.toolStrip_7.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripSplitButton_0,
				this.toolStripButton_32,
				this.toolStripButton_28,
				this.toolStripSeparator_32,
				this.toolStripButton_29,
				this.toolStripSeparator_33,
				this.toolStripButton_30,
				this.toolStripSeparator_34,
				this.toolStripButton_31
			});
			this.toolStrip_7.Location = new Point(0, 0);
			this.toolStrip_7.Name = "tsMove";
			this.toolStrip_7.Size = new Size(764, 25);
			this.toolStrip_7.TabIndex = 0;
			this.toolStrip_7.Text = "toolStrip3";
			this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_65,
				this.toolStripMenuItem_66
			});
			this.toolStripSplitButton_0.Image = Resources.ElementAdd;
			this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButton_0.Name = "tsbAdd";
			this.toolStripSplitButton_0.Size = new Size(32, 22);
			this.toolStripSplitButton_0.Text = "Добавить перемещение";
			this.toolStripMenuItem_65.Name = "toolBtnItemAddMove";
			this.toolStripMenuItem_65.Size = new Size(217, 22);
			this.toolStripMenuItem_65.Text = "Переместить";
			this.toolStripMenuItem_65.ToolTipText = "Переместить трансформатор";
			this.toolStripMenuItem_65.Click += this.toolStripMenuItem_65_Click;
			this.toolStripMenuItem_66.Name = "toolBtnItemAddMoveDoc";
			this.toolStripMenuItem_66.Size = new Size(217, 22);
			this.toolStripMenuItem_66.Text = "Перемещение (документ)";
			this.toolStripMenuItem_66.ToolTipText = "Добавить документ";
			this.toolStripMenuItem_66.Click += this.toolStripButton_28_Click;
			this.toolStripButton_32.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_32.Image = Resources.ElementEdit;
			this.toolStripButton_32.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_32.Name = "tsbEditMove";
			this.toolStripButton_32.Size = new Size(23, 22);
			this.toolStripButton_32.Text = "Редактировать перемещение";
			this.toolStripButton_32.Click += this.toolStripButton_32_Click;
			this.toolStripButton_28.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_28.Image = Resources.ElementAdd;
			this.toolStripButton_28.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_28.Name = "tsbAddMove";
			this.toolStripButton_28.Size = new Size(23, 22);
			this.toolStripButton_28.Text = "Добавить перемещение";
			this.toolStripButton_28.Visible = false;
			this.toolStripButton_28.Click += this.toolStripButton_28_Click;
			this.toolStripSeparator_32.Name = "tssDeleteMove";
			this.toolStripSeparator_32.Size = new Size(6, 25);
			this.toolStripButton_29.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_29.Image = Resources.ElementDel;
			this.toolStripButton_29.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_29.Name = "tsbDeleteMove";
			this.toolStripButton_29.Size = new Size(23, 22);
			this.toolStripButton_29.Text = "Удалить перемещение";
			this.toolStripButton_29.Click += this.toolStripButton_29_Click;
			this.toolStripSeparator_33.Name = "tssRefreshMove";
			this.toolStripSeparator_33.Size = new Size(6, 25);
			this.toolStripButton_30.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_30.Image = Resources.refresh_16;
			this.toolStripButton_30.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_30.Name = "tsbRefreshMove";
			this.toolStripButton_30.Size = new Size(23, 22);
			this.toolStripButton_30.Text = "Обновить";
			this.toolStripButton_30.Click += this.toolStripButton_30_Click;
			this.toolStripSeparator_34.Name = "tssLoadOld";
			this.toolStripSeparator_34.Size = new Size(6, 25);
			this.toolStripButton_31.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_31.Image = (Image)componentResourceManager.GetObject("tsbLoadOld.Image");
			this.toolStripButton_31.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_31.Name = "tsbLoadOld";
			this.toolStripButton_31.Size = new Size(151, 22);
			this.toolStripButton_31.Text = "Загрузить из старой базы";
			this.toolStripButton_31.Visible = false;
			this.toolStripButton_31.Click += this.toolStripButton_31_Click;
			this.dataGridView_6.AllowUserToAddRows = false;
			this.dataGridView_6.AllowUserToDeleteRows = false;
			this.dataGridView_6.AllowUserToOrderColumns = true;
			this.dataGridView_6.AllowUserToResizeRows = false;
			this.dataGridView_6.BackgroundColor = Color.White;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = SystemColors.Control;
			dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			this.dataGridView_6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView_6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_6.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_204,
				this.dataGridViewTextBoxColumn_205,
				this.dataGridViewTextBoxColumn_206,
				this.dataGridViewTextBoxColumn_207,
				this.dataGridViewTextBoxColumn_208,
				this.dataGridViewTextBoxColumn_209,
				this.dataGridViewTextBoxColumn_210
			});
			this.dataGridView_6.ContextMenuStrip = this.contextMenuStrip_1;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = SystemColors.Window;
			dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			this.dataGridView_6.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridView_6.Dock = DockStyle.Fill;
			this.dataGridView_6.Location = new Point(3, 28);
			this.dataGridView_6.MultiSelect = false;
			this.dataGridView_6.Name = "dgvMoveTrans";
			this.dataGridView_6.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = SystemColors.Control;
			dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			this.dataGridView_6.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridView_6.RowHeadersVisible = false;
			this.dataGridView_6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_6.Size = new Size(758, 171);
			this.dataGridView_6.TabIndex = 3;
			this.dataGridViewTextBoxColumn_204.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_204.HeaderText = "idMove";
			this.dataGridViewTextBoxColumn_204.Name = "idMove";
			this.dataGridViewTextBoxColumn_204.ReadOnly = true;
			this.dataGridViewTextBoxColumn_204.Visible = false;
			this.dataGridViewTextBoxColumn_205.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_205.HeaderText = "idObjList";
			this.dataGridViewTextBoxColumn_205.Name = "idObjList";
			this.dataGridViewTextBoxColumn_205.ReadOnly = true;
			this.dataGridViewTextBoxColumn_205.Visible = false;
			this.dataGridViewTextBoxColumn_206.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_206.HeaderText = "Deleted";
			this.dataGridViewTextBoxColumn_206.Name = "Deleted";
			this.dataGridViewTextBoxColumn_206.ReadOnly = true;
			this.dataGridViewTextBoxColumn_206.Visible = false;
			this.dataGridViewTextBoxColumn_207.DataPropertyName = "Data";
			dataGridViewCellStyle10.Format = "d";
			dataGridViewCellStyle10.NullValue = null;
			this.dataGridViewTextBoxColumn_207.DefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridViewTextBoxColumn_207.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_207.Name = "DateMove";
			this.dataGridViewTextBoxColumn_207.ReadOnly = true;
			this.dataGridViewTextBoxColumn_208.DataPropertyName = "Action";
			this.dataGridViewTextBoxColumn_208.HeaderText = "Действие";
			this.dataGridViewTextBoxColumn_208.Name = "Action";
			this.dataGridViewTextBoxColumn_208.ReadOnly = true;
			this.dataGridViewTextBoxColumn_208.Width = 110;
			this.dataGridViewTextBoxColumn_209.DataPropertyName = "Direction";
			this.dataGridViewTextBoxColumn_209.HeaderText = "Направление";
			this.dataGridViewTextBoxColumn_209.Name = "Direction";
			this.dataGridViewTextBoxColumn_209.ReadOnly = true;
			this.dataGridViewTextBoxColumn_209.Width = 120;
			this.dataGridViewTextBoxColumn_210.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_210.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_210.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_210.Name = "Comment";
			this.dataGridViewTextBoxColumn_210.ReadOnly = true;
			this.tabPage_1.Controls.Add(this.tableLayoutPanel_3);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tpCabSections";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(770, 208);
			this.tabPage_1.TabIndex = 2;
			this.tabPage_1.Text = "Участки";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_3.ColumnCount = 1;
			this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_3.Controls.Add(this.dataGridView_1, 0, 1);
			this.tableLayoutPanel_3.Controls.Add(this.toolStrip_3, 0, 0);
			this.tableLayoutPanel_3.Dock = DockStyle.Fill;
			this.tableLayoutPanel_3.Location = new Point(3, 3);
			this.tableLayoutPanel_3.Name = "tlpSections";
			this.tableLayoutPanel_3.RowCount = 2;
			this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_3.Size = new Size(764, 202);
			this.tableLayoutPanel_3.TabIndex = 0;
			this.dataGridView_1.AllowUserToAddRows = false;
			this.dataGridView_1.AllowUserToDeleteRows = false;
			this.dataGridView_1.AllowUserToResizeRows = false;
			this.dataGridView_1.BackgroundColor = Color.White;
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = SystemColors.Control;
			dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
			this.dataGridView_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_94,
				this.dataGridViewTextBoxColumn_95,
				this.dataGridViewTextBoxColumn_96,
				this.dataGridViewTextBoxColumn_97,
				this.dataGridViewTextBoxColumn_98,
				this.dataGridViewTextBoxColumn_99,
				this.dataGridViewTextBoxColumn_100,
				this.dataGridViewTextBoxColumn_101,
				this.dataGridViewTextBoxColumn_102,
				this.dataGridViewTextBoxColumn_103,
				this.dataGridViewTextBoxColumn_104,
				this.dataGridViewTextBoxColumn_105,
				this.dataGridViewTextBoxColumn_106,
				this.dataGridViewTextBoxColumn_107,
				this.dataGridViewTextBoxColumn_108,
				this.dataGridViewTextBoxColumn_109,
				this.dataGridViewTextBoxColumn_110,
				this.dataGridViewTextBoxColumn_111
			});
			this.dataGridView_1.ContextMenuStrip = this.contextMenuStrip_3;
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = SystemColors.Window;
			dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
			this.dataGridView_1.DefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridView_1.Dock = DockStyle.Fill;
			this.dataGridView_1.Location = new Point(3, 28);
			this.dataGridView_1.MultiSelect = false;
			this.dataGridView_1.Name = "dgvCabSections";
			this.dataGridView_1.ReadOnly = true;
			dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = SystemColors.Control;
			dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
			this.dataGridView_1.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridView_1.RowHeadersVisible = false;
			this.dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_1.Size = new Size(758, 171);
			this.dataGridView_1.TabIndex = 1;
			this.dataGridViewTextBoxColumn_94.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_94.HeaderText = "SectionId";
			this.dataGridViewTextBoxColumn_94.Name = "SectionId";
			this.dataGridViewTextBoxColumn_94.ReadOnly = true;
			this.dataGridViewTextBoxColumn_94.Visible = false;
			this.dataGridViewTextBoxColumn_95.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_95.HeaderText = "SectionIdObjList";
			this.dataGridViewTextBoxColumn_95.Name = "SectionIdObjList";
			this.dataGridViewTextBoxColumn_95.ReadOnly = true;
			this.dataGridViewTextBoxColumn_95.Visible = false;
			this.dataGridViewTextBoxColumn_96.DataPropertyName = "idPassport";
			this.dataGridViewTextBoxColumn_96.HeaderText = "SectionIdPassport";
			this.dataGridViewTextBoxColumn_96.Name = "SectionIdPassport";
			this.dataGridViewTextBoxColumn_96.ReadOnly = true;
			this.dataGridViewTextBoxColumn_96.Visible = false;
			this.dataGridViewTextBoxColumn_97.DataPropertyName = "Number";
			this.dataGridViewTextBoxColumn_97.HeaderText = "Номер участка";
			this.dataGridViewTextBoxColumn_97.Name = "SectionNumber";
			this.dataGridViewTextBoxColumn_97.ReadOnly = true;
			this.dataGridViewTextBoxColumn_97.Width = 60;
			this.dataGridViewTextBoxColumn_98.DataPropertyName = "ClutchFirst";
			this.dataGridViewTextBoxColumn_98.HeaderText = "Муфта";
			this.dataGridViewTextBoxColumn_98.Name = "SectionClutchFirst";
			this.dataGridViewTextBoxColumn_98.ReadOnly = true;
			this.dataGridViewTextBoxColumn_98.Width = 60;
			this.dataGridViewTextBoxColumn_99.DataPropertyName = "ClutchSecond";
			this.dataGridViewTextBoxColumn_99.HeaderText = "Муфта";
			this.dataGridViewTextBoxColumn_99.Name = "SectionClutchSecond";
			this.dataGridViewTextBoxColumn_99.ReadOnly = true;
			this.dataGridViewTextBoxColumn_99.Width = 60;
			this.dataGridViewTextBoxColumn_100.DataPropertyName = "makeup";
			this.dataGridViewTextBoxColumn_100.HeaderText = "Марка";
			this.dataGridViewTextBoxColumn_100.Name = "SectionMakeup";
			this.dataGridViewTextBoxColumn_100.ReadOnly = true;
			this.dataGridViewTextBoxColumn_101.DataPropertyName = "voltage";
			this.dataGridViewTextBoxColumn_101.HeaderText = "Рабочее напряжение";
			this.dataGridViewTextBoxColumn_101.Name = "SectionVoltage";
			this.dataGridViewTextBoxColumn_101.ReadOnly = true;
			this.dataGridViewTextBoxColumn_101.Width = 70;
			this.dataGridViewTextBoxColumn_102.DataPropertyName = "wires";
			this.dataGridViewTextBoxColumn_102.HeaderText = "Количество жил";
			this.dataGridViewTextBoxColumn_102.Name = "SectionWires";
			this.dataGridViewTextBoxColumn_102.ReadOnly = true;
			this.dataGridViewTextBoxColumn_102.Width = 70;
			this.dataGridViewTextBoxColumn_103.DataPropertyName = "crossSection";
			this.dataGridViewTextBoxColumn_103.HeaderText = "Сечение жил";
			this.dataGridViewTextBoxColumn_103.Name = "SectionCrossSection";
			this.dataGridViewTextBoxColumn_103.ReadOnly = true;
			this.dataGridViewTextBoxColumn_103.Width = 60;
			this.dataGridViewTextBoxColumn_104.DataPropertyName = "length";
			this.dataGridViewTextBoxColumn_104.HeaderText = "Длина";
			this.dataGridViewTextBoxColumn_104.Name = "SectionLength";
			this.dataGridViewTextBoxColumn_104.ReadOnly = true;
			this.dataGridViewTextBoxColumn_104.Width = 60;
			this.dataGridViewTextBoxColumn_105.DataPropertyName = "CONDITIONS";
			this.dataGridViewTextBoxColumn_105.HeaderText = "Условия прокладки";
			this.dataGridViewTextBoxColumn_105.Name = "SectionConditions";
			this.dataGridViewTextBoxColumn_105.ReadOnly = true;
			this.dataGridViewTextBoxColumn_106.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn_106.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn_106.Name = "SectionCount";
			this.dataGridViewTextBoxColumn_106.ReadOnly = true;
			this.dataGridViewTextBoxColumn_106.Width = 70;
			this.dataGridViewTextBoxColumn_107.DataPropertyName = "yearLaying";
			this.dataGridViewTextBoxColumn_107.HeaderText = "Год прокладки";
			this.dataGridViewTextBoxColumn_107.Name = "SectionYearLaying";
			this.dataGridViewTextBoxColumn_107.ReadOnly = true;
			this.dataGridViewTextBoxColumn_107.Width = 80;
			this.dataGridViewTextBoxColumn_108.DataPropertyName = "yearCommissioning";
			this.dataGridViewTextBoxColumn_108.HeaderText = "Год ввода в эксплуатацию";
			this.dataGridViewTextBoxColumn_108.Name = "SectionYearCommisioning";
			this.dataGridViewTextBoxColumn_108.ReadOnly = true;
			this.dataGridViewTextBoxColumn_108.Width = 90;
			this.dataGridViewTextBoxColumn_109.DataPropertyName = "yearRenovation";
			this.dataGridViewTextBoxColumn_109.HeaderText = "Год реконструкции";
			this.dataGridViewTextBoxColumn_109.Name = "SectionRenovation";
			this.dataGridViewTextBoxColumn_109.ReadOnly = true;
			this.dataGridViewTextBoxColumn_109.Width = 90;
			this.dataGridViewTextBoxColumn_110.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_110.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_110.Name = "SectionComment";
			this.dataGridViewTextBoxColumn_110.ReadOnly = true;
			this.dataGridViewTextBoxColumn_111.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_111.HeaderText = "SectionDeleted";
			this.dataGridViewTextBoxColumn_111.Name = "SectionDeleted";
			this.dataGridViewTextBoxColumn_111.ReadOnly = true;
			this.dataGridViewTextBoxColumn_111.Visible = false;
			this.contextMenuStrip_3.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_18,
				this.toolStripMenuItem_11,
				this.toolStripSeparator_13,
				this.toolStripMenuItem_9,
				this.toolStripMenuItem_14,
				this.toolStripMenuItem_17,
				this.toolStripSeparator_16,
				this.toolStripMenuItem_12,
				this.toolStripSeparator_22,
				this.toolStripMenuItem_20
			});
			this.contextMenuStrip_3.Name = "cmsSection";
			this.contextMenuStrip_3.Size = new Size(155, 176);
			this.toolStripMenuItem_18.Image = Resources.ElementAdd;
			this.toolStripMenuItem_18.Name = "tsmiAddSection";
			this.toolStripMenuItem_18.Size = new Size(154, 22);
			this.toolStripMenuItem_18.Text = "Добавить";
			this.toolStripMenuItem_18.Click += this.toolStripButton_7_Click;
			this.toolStripMenuItem_11.Image = Resources.ElementEdit;
			this.toolStripMenuItem_11.Name = "tsmiEditSection";
			this.toolStripMenuItem_11.Size = new Size(154, 22);
			this.toolStripMenuItem_11.Text = "Редактировать";
			this.toolStripMenuItem_11.Click += this.toolStripButton_8_Click;
			this.toolStripSeparator_13.Name = "toolStripSeparator9";
			this.toolStripSeparator_13.Size = new Size(151, 6);
			this.toolStripSeparator_13.Visible = false;
			this.toolStripMenuItem_9.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_13,
				this.toolStripMenuItem_10
			});
			this.toolStripMenuItem_9.Image = Resources._1352700444_table_row_insert;
			this.toolStripMenuItem_9.Name = "tsmiInsert";
			this.toolStripMenuItem_9.Size = new Size(154, 22);
			this.toolStripMenuItem_9.Text = "Вставить";
			this.toolStripMenuItem_9.Visible = false;
			this.toolStripMenuItem_13.Name = "tsmiInsertClutch";
			this.toolStripMenuItem_13.Size = new Size(118, 22);
			this.toolStripMenuItem_13.Text = "Муфту";
			this.toolStripMenuItem_10.Name = "tsmiInsertSection";
			this.toolStripMenuItem_10.Size = new Size(118, 22);
			this.toolStripMenuItem_10.Text = "Участок";
			this.toolStripMenuItem_14.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_15,
				this.toolStripMenuItem_16
			});
			this.toolStripMenuItem_14.Image = Resources.arrow_divide_2725;
			this.toolStripMenuItem_14.Name = "tsmiSplit";
			this.toolStripMenuItem_14.Size = new Size(154, 22);
			this.toolStripMenuItem_14.Text = "Разделить";
			this.toolStripMenuItem_14.Visible = false;
			this.toolStripMenuItem_15.Name = "tsmiSplitClutch";
			this.toolStripMenuItem_15.Size = new Size(127, 22);
			this.toolStripMenuItem_15.Text = "Муфтой";
			this.toolStripMenuItem_16.Name = "tsmiSplitSection";
			this.toolStripMenuItem_16.Size = new Size(127, 22);
			this.toolStripMenuItem_16.Text = "Участком";
			this.toolStripMenuItem_17.Image = Resources._1352700290_table_replace;
			this.toolStripMenuItem_17.Name = "tsmiReplaceSection";
			this.toolStripMenuItem_17.Size = new Size(154, 22);
			this.toolStripMenuItem_17.Text = "Заменить";
			this.toolStripMenuItem_17.Visible = false;
			this.toolStripSeparator_16.Name = "toolStripSeparator13";
			this.toolStripSeparator_16.Size = new Size(151, 6);
			this.toolStripMenuItem_12.Image = Resources.ElementDel;
			this.toolStripMenuItem_12.Name = "удалитьToolStripMenuItem";
			this.toolStripMenuItem_12.Size = new Size(154, 22);
			this.toolStripMenuItem_12.Text = "Удалить";
			this.toolStripMenuItem_12.Click += this.toolStripButton_9_Click;
			this.toolStripSeparator_22.Name = "tssRefreshSection";
			this.toolStripSeparator_22.Size = new Size(151, 6);
			this.toolStripMenuItem_20.Image = Resources.refresh_16;
			this.toolStripMenuItem_20.Name = "tsmiRefreshSection";
			this.toolStripMenuItem_20.Size = new Size(154, 22);
			this.toolStripMenuItem_20.Text = "Обновить";
			this.toolStripMenuItem_20.Click += this.toolStripButton_19_Click;
			this.toolStrip_3.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_7,
				this.toolStripButton_8,
				this.toolStripSeparator_12,
				this.toolStripButton_9,
				this.toolStripSeparator_20,
				this.toolStripButton_19,
				this.toolStripSeparator_61,
				this.toolStripButton_64,
				this.toolStripSeparator_44,
				this.toolStripLabel_1
			});
			this.toolStrip_3.Location = new Point(0, 0);
			this.toolStrip_3.Name = "tsCabSection";
			this.toolStrip_3.Size = new Size(764, 25);
			this.toolStrip_3.TabIndex = 0;
			this.toolStrip_3.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_7.Image = Resources.ElementAdd;
			this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_7.Name = "tsbAddSection";
			this.toolStripButton_7.Size = new Size(23, 22);
			this.toolStripButton_7.Text = "Добавить";
			this.toolStripButton_7.Click += this.toolStripButton_7_Click;
			this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_8.Image = Resources.ElementEdit;
			this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_8.Name = "tsbEditSection";
			this.toolStripButton_8.Size = new Size(23, 22);
			this.toolStripButton_8.Text = "Редактировать";
			this.toolStripButton_8.Click += this.toolStripButton_8_Click;
			this.toolStripSeparator_12.Name = "tssDeleteSection";
			this.toolStripSeparator_12.Size = new Size(6, 25);
			this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_9.Image = Resources.ElementDel;
			this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_9.Name = "tsbDeleteSection";
			this.toolStripButton_9.Size = new Size(23, 22);
			this.toolStripButton_9.Text = "Удалить";
			this.toolStripButton_9.Click += this.toolStripButton_9_Click;
			this.toolStripSeparator_20.Name = "tssRefreshSector";
			this.toolStripSeparator_20.Size = new Size(6, 25);
			this.toolStripButton_19.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_19.Image = Resources.refresh_16;
			this.toolStripButton_19.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_19.Name = "tsbRefreshSection";
			this.toolStripButton_19.Size = new Size(23, 22);
			this.toolStripButton_19.Text = "Обновить";
			this.toolStripButton_19.Click += this.toolStripButton_19_Click;
			this.toolStripSeparator_61.Name = "toolStripSeparator20";
			this.toolStripSeparator_61.Size = new Size(6, 25);
			this.toolStripButton_64.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_64.Image = Resources.Gurnal;
			this.toolStripButton_64.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_64.Name = "tsbSectionHistory";
			this.toolStripButton_64.Size = new Size(23, 22);
			this.toolStripButton_64.Text = "История паспортов объекта";
			this.toolStripButton_64.Click += this.toolStripButton_64_Click;
			this.toolStripSeparator_44.Name = "tssCabSectionLength";
			this.toolStripSeparator_44.Size = new Size(6, 25);
			this.toolStripLabel_1.Name = "tslCabSectionLength";
			this.toolStripLabel_1.Size = new Size(28, 22);
			this.toolStripLabel_1.Text = "0 м.";
			this.tabPage_2.Controls.Add(this.tableLayoutPanel_4);
			this.tabPage_2.Location = new Point(4, 22);
			this.tabPage_2.Name = "tpClutchConnection";
			this.tabPage_2.Padding = new Padding(3);
			this.tabPage_2.Size = new Size(770, 208);
			this.tabPage_2.TabIndex = 3;
			this.tabPage_2.Text = "Муфты";
			this.tabPage_2.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_4.ColumnCount = 1;
			this.tableLayoutPanel_4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_4.Controls.Add(this.dataGridView_2, 0, 1);
			this.tableLayoutPanel_4.Controls.Add(this.toolStrip_4, 0, 0);
			this.tableLayoutPanel_4.Dock = DockStyle.Fill;
			this.tableLayoutPanel_4.Location = new Point(3, 3);
			this.tableLayoutPanel_4.Name = "tlpClutchConnection";
			this.tableLayoutPanel_4.RowCount = 2;
			this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_4.Size = new Size(764, 202);
			this.tableLayoutPanel_4.TabIndex = 0;
			this.dataGridView_2.AllowUserToAddRows = false;
			this.dataGridView_2.AllowUserToDeleteRows = false;
			this.dataGridView_2.AllowUserToResizeRows = false;
			this.dataGridView_2.BackgroundColor = Color.White;
			dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.BackColor = SystemColors.Control;
			dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
			this.dataGridView_2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dataGridView_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_2.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_217
			});
			this.dataGridView_2.ContextMenuStrip = this.contextMenuStrip_6;
			dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = SystemColors.Window;
			dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
			this.dataGridView_2.DefaultCellStyle = dataGridViewCellStyle15;
			this.dataGridView_2.Dock = DockStyle.Fill;
			this.dataGridView_2.Location = new Point(3, 28);
			this.dataGridView_2.MultiSelect = false;
			this.dataGridView_2.Name = "dgvClutchConnection";
			this.dataGridView_2.ReadOnly = true;
			dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.BackColor = SystemColors.Control;
			dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
			this.dataGridView_2.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dataGridView_2.RowHeadersVisible = false;
			this.dataGridView_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_2.Size = new Size(758, 171);
			this.dataGridView_2.TabIndex = 1;
			this.contextMenuStrip_6.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_30,
				this.toolStripMenuItem_31,
				this.toolStripMenuItem_34,
				this.toolStripSeparator_30,
				this.toolStripMenuItem_35,
				this.toolStripSeparator_31,
				this.toolStripMenuItem_36
			});
			this.contextMenuStrip_6.Name = "cmsBuildRepair";
			this.contextMenuStrip_6.Size = new Size(203, 126);
			this.toolStripMenuItem_30.Image = Resources.ElementAdd;
			this.toolStripMenuItem_30.Name = "tsmiAddClutch";
			this.toolStripMenuItem_30.Size = new Size(202, 22);
			this.toolStripMenuItem_30.Text = "Добавить";
			this.toolStripMenuItem_30.Click += this.toolStripButton_27_Click;
			this.toolStripMenuItem_31.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_32,
				this.toolStripMenuItem_33
			});
			this.toolStripMenuItem_31.Image = Resources.ElementAdd;
			this.toolStripMenuItem_31.Name = "добавитьВиртуальнуюToolStripMenuItem";
			this.toolStripMenuItem_31.Size = new Size(202, 22);
			this.toolStripMenuItem_31.Text = "Добавить виртуальную";
			this.toolStripMenuItem_31.Visible = false;
			this.toolStripMenuItem_32.Name = "tsmiAddVirtFirst";
			this.toolStripMenuItem_32.Size = new Size(134, 22);
			this.toolStripMenuItem_32.Text = "Начальная";
			this.toolStripMenuItem_33.Name = "tsmiAddVirtLast";
			this.toolStripMenuItem_33.Size = new Size(134, 22);
			this.toolStripMenuItem_33.Text = "Конечная";
			this.toolStripMenuItem_34.Image = Resources.ElementEdit;
			this.toolStripMenuItem_34.Name = "tsmiEditClutch";
			this.toolStripMenuItem_34.Size = new Size(202, 22);
			this.toolStripMenuItem_34.Text = "Редактировать";
			this.toolStripMenuItem_34.Click += this.toolStripButton_10_Click;
			this.toolStripSeparator_30.Name = "toolStripSeparator1";
			this.toolStripSeparator_30.Size = new Size(199, 6);
			this.toolStripMenuItem_35.Image = Resources.ElementDel;
			this.toolStripMenuItem_35.Name = "tsmiDeleteClutch";
			this.toolStripMenuItem_35.Size = new Size(202, 22);
			this.toolStripMenuItem_35.Text = "Удалить";
			this.toolStripMenuItem_35.Click += this.toolStripButton_11_Click;
			this.toolStripSeparator_31.Name = "toolStripSeparator4";
			this.toolStripSeparator_31.Size = new Size(199, 6);
			this.toolStripMenuItem_36.Image = Resources.refresh_16;
			this.toolStripMenuItem_36.Name = "tsmiRefreshClutch";
			this.toolStripMenuItem_36.Size = new Size(202, 22);
			this.toolStripMenuItem_36.Text = "Обновить";
			this.toolStripMenuItem_36.Click += this.toolStripButton_12_Click;
			this.toolStrip_4.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_27,
				this.toolStripButton_10,
				this.toolStripSeparator_14,
				this.toolStripButton_11,
				this.toolStripSeparator_15,
				this.toolStripButton_12,
				this.toolStripSeparator_62,
				this.toolStripButton_65
			});
			this.toolStrip_4.Location = new Point(0, 0);
			this.toolStrip_4.Name = "tsClutchConnection";
			this.toolStrip_4.Size = new Size(764, 25);
			this.toolStrip_4.TabIndex = 0;
			this.toolStrip_4.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_27.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_27.Image = Resources.ElementAdd;
			this.toolStripButton_27.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_27.Name = "tsbClutchConnectionAdd";
			this.toolStripButton_27.Size = new Size(23, 22);
			this.toolStripButton_27.Text = "Добавить";
			this.toolStripButton_27.Click += this.toolStripButton_27_Click;
			this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_10.Image = Resources.ElementEdit;
			this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_10.Name = "tsbClutchConnectionEdit";
			this.toolStripButton_10.Size = new Size(23, 22);
			this.toolStripButton_10.Text = "Редактировать";
			this.toolStripButton_10.Click += this.toolStripButton_10_Click;
			this.toolStripSeparator_14.Name = "toolStripSeparator11";
			this.toolStripSeparator_14.Size = new Size(6, 25);
			this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_11.Image = Resources.ElementDel;
			this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_11.Name = "tsbClutchConnectionDelete";
			this.toolStripButton_11.Size = new Size(23, 22);
			this.toolStripButton_11.Text = "Удалить";
			this.toolStripButton_11.Click += this.toolStripButton_11_Click;
			this.toolStripSeparator_15.Name = "toolStripSeparator12";
			this.toolStripSeparator_15.Size = new Size(6, 25);
			this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_12.Image = Resources.refresh_16;
			this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_12.Name = "tsbClutchConnectionRefresh";
			this.toolStripButton_12.Size = new Size(23, 22);
			this.toolStripButton_12.Text = "Обновить";
			this.toolStripButton_12.Click += this.toolStripButton_12_Click;
			this.toolStripSeparator_62.Name = "toolStripSeparator21";
			this.toolStripSeparator_62.Size = new Size(6, 25);
			this.toolStripButton_65.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_65.Image = Resources.Gurnal;
			this.toolStripButton_65.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_65.Name = "tsbClutchConnectionHistory";
			this.toolStripButton_65.Size = new Size(23, 22);
			this.toolStripButton_65.Text = "История паспортов объекта";
			this.toolStripButton_65.Click += this.toolStripButton_65_Click;
			this.tabPage_12.Controls.Add(this.tableLayoutPanel_15);
			this.tabPage_12.Location = new Point(4, 22);
			this.tabPage_12.Name = "tpClutchEnd";
			this.tabPage_12.Padding = new Padding(3);
			this.tabPage_12.Size = new Size(770, 208);
			this.tabPage_12.TabIndex = 16;
			this.tabPage_12.Text = "Концевые разделки";
			this.tabPage_12.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_15.ColumnCount = 1;
			this.tableLayoutPanel_15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_15.Controls.Add(this.dataGridView_11, 0, 1);
			this.tableLayoutPanel_15.Controls.Add(this.toolStrip_14, 0, 0);
			this.tableLayoutPanel_15.Dock = DockStyle.Fill;
			this.tableLayoutPanel_15.Location = new Point(3, 3);
			this.tableLayoutPanel_15.Name = "tlpClutchEnd";
			this.tableLayoutPanel_15.RowCount = 2;
			this.tableLayoutPanel_15.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_15.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_15.Size = new Size(764, 202);
			this.tableLayoutPanel_15.TabIndex = 0;
			this.dataGridView_11.AllowUserToAddRows = false;
			this.dataGridView_11.AllowUserToDeleteRows = false;
			this.dataGridView_11.AllowUserToResizeRows = false;
			this.dataGridView_11.BackgroundColor = Color.White;
			dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.BackColor = SystemColors.Control;
			dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
			this.dataGridView_11.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dataGridView_11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_11.ContextMenuStrip = this.contextMenuStrip_10;
			dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = SystemColors.Window;
			dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
			this.dataGridView_11.DefaultCellStyle = dataGridViewCellStyle18;
			this.dataGridView_11.Dock = DockStyle.Fill;
			this.dataGridView_11.Location = new Point(3, 28);
			this.dataGridView_11.MultiSelect = false;
			this.dataGridView_11.Name = "dgvClutchEnd";
			this.dataGridView_11.ReadOnly = true;
			dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle19.BackColor = SystemColors.Control;
			dataGridViewCellStyle19.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
			this.dataGridView_11.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
			this.dataGridView_11.RowHeadersVisible = false;
			this.dataGridView_11.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_11.Size = new Size(758, 171);
			this.dataGridView_11.TabIndex = 1;
			this.contextMenuStrip_10.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_56,
				this.toolStripMenuItem_57,
				this.toolStripSeparator_59,
				this.toolStripMenuItem_58
			});
			this.contextMenuStrip_10.Name = "cmsBuildRepair";
			this.contextMenuStrip_10.Size = new Size(155, 76);
			this.toolStripMenuItem_56.Image = Resources.ElementAdd;
			this.toolStripMenuItem_56.Name = "tsmiClutchEndAdd";
			this.toolStripMenuItem_56.Size = new Size(154, 22);
			this.toolStripMenuItem_56.Text = "Добавить";
			this.toolStripMenuItem_56.Click += this.toolStripButton_58_Click;
			this.toolStripMenuItem_57.Image = Resources.ElementEdit;
			this.toolStripMenuItem_57.Name = "tsmiClutchEndEdit";
			this.toolStripMenuItem_57.Size = new Size(154, 22);
			this.toolStripMenuItem_57.Text = "Редактировать";
			this.toolStripMenuItem_57.Click += this.toolStripButton_59_Click;
			this.toolStripSeparator_59.Name = "toolStripSeparator19";
			this.toolStripSeparator_59.Size = new Size(151, 6);
			this.toolStripMenuItem_58.Image = Resources.refresh_16;
			this.toolStripMenuItem_58.Name = "tsmiClutchEndRefresh";
			this.toolStripMenuItem_58.Size = new Size(154, 22);
			this.toolStripMenuItem_58.Text = "Обновить";
			this.toolStripMenuItem_58.Click += this.toolStripButton_61_Click;
			this.toolStrip_14.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_58,
				this.toolStripButton_59,
				this.toolStripSeparator_57,
				this.toolStripButton_60,
				this.toolStripSeparator_58,
				this.toolStripButton_61,
				this.toolStripSeparator_63,
				this.toolStripButton_66
			});
			this.toolStrip_14.Location = new Point(0, 0);
			this.toolStrip_14.Name = "tsClutchEnd";
			this.toolStrip_14.Size = new Size(764, 25);
			this.toolStrip_14.TabIndex = 0;
			this.toolStrip_14.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_58.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_58.Image = Resources.ElementAdd;
			this.toolStripButton_58.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_58.Name = "tsbClutchEndAdd";
			this.toolStripButton_58.Size = new Size(23, 22);
			this.toolStripButton_58.Text = "Добавить";
			this.toolStripButton_58.Click += this.toolStripButton_58_Click;
			this.toolStripButton_59.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_59.Image = Resources.ElementEdit;
			this.toolStripButton_59.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_59.Name = "tsbClutchEndEdit";
			this.toolStripButton_59.Size = new Size(23, 22);
			this.toolStripButton_59.Text = "Редактировать";
			this.toolStripButton_59.Click += this.toolStripButton_59_Click;
			this.toolStripSeparator_57.Name = "toolStripSeparator16";
			this.toolStripSeparator_57.Size = new Size(6, 25);
			this.toolStripSeparator_57.Visible = false;
			this.toolStripButton_60.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_60.Image = Resources.ElementDel;
			this.toolStripButton_60.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_60.Name = "tsbClutchEndDelete";
			this.toolStripButton_60.Size = new Size(23, 22);
			this.toolStripButton_60.Text = "Удалить";
			this.toolStripButton_60.Visible = false;
			this.toolStripSeparator_58.Name = "toolStripSeparator17";
			this.toolStripSeparator_58.Size = new Size(6, 25);
			this.toolStripButton_61.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_61.Image = Resources.refresh_16;
			this.toolStripButton_61.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_61.Name = "tsbClutchEndRefresh";
			this.toolStripButton_61.Size = new Size(23, 22);
			this.toolStripButton_61.Text = "Обновить";
			this.toolStripButton_61.Click += this.toolStripButton_61_Click;
			this.toolStripSeparator_63.Name = "toolStripSeparator22";
			this.toolStripSeparator_63.Size = new Size(6, 25);
			this.toolStripButton_66.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_66.Image = Resources.Gurnal;
			this.toolStripButton_66.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_66.Name = "tsbClutchEndHistory";
			this.toolStripButton_66.Size = new Size(23, 22);
			this.toolStripButton_66.Text = "История паспортов объекта";
			this.toolStripButton_66.Click += this.toolStripButton_66_Click;
			this.tabPage_0.Controls.Add(this.tableLayoutPanel_2);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tpRepair";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(770, 208);
			this.tabPage_0.TabIndex = 1;
			this.tabPage_0.Text = "Ремонт";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_2.ColumnCount = 1;
			this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_2.Controls.Add(this.dataGridView_0, 0, 1);
			this.tableLayoutPanel_2.Controls.Add(this.toolStrip_2, 0, 0);
			this.tableLayoutPanel_2.Dock = DockStyle.Fill;
			this.tableLayoutPanel_2.Location = new Point(3, 3);
			this.tableLayoutPanel_2.Name = "tlpRepair";
			this.tableLayoutPanel_2.RowCount = 2;
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_2.Size = new Size(764, 202);
			this.tableLayoutPanel_2.TabIndex = 0;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToResizeRows = false;
			this.dataGridView_0.BackgroundColor = Color.White;
			dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle20.BackColor = SystemColors.Control;
			dataGridViewCellStyle20.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle20.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12
			});
			this.dataGridView_0.ContextMenuStrip = this.contextMenuStrip_2;
			dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle21.BackColor = SystemColors.Window;
			dataGridViewCellStyle21.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle21.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle21.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle21;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(3, 28);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "dgvRepair";
			this.dataGridView_0.ReadOnly = true;
			dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle22.BackColor = SystemColors.Control;
			dataGridViewCellStyle22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(758, 171);
			this.dataGridView_0.TabIndex = 1;
			this.dataGridView_0.DataError += this.dataGridView_0_DataError;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_3.HeaderText = "idRepair";
			this.dataGridViewTextBoxColumn_3.Name = "idRepair";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Visible = false;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_4.HeaderText = "ParentIdRepair";
			this.dataGridViewTextBoxColumn_4.Name = "ParentIdRepair";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_5.HeaderText = "idObjListRepair";
			this.dataGridViewTextBoxColumn_5.Name = "idObjListRepair";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_6.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_6.Name = "DateDocRepair";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Width = 130;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_7.HeaderText = "NumberDocRepair";
			this.dataGridViewTextBoxColumn_7.Name = "NumberDocRepair";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_7.Width = 150;
			this.dataGridViewTextBoxColumn_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_8.HeaderText = "Работа";
			this.dataGridViewTextBoxColumn_8.Name = "CommentRepair";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "Comment2";
			this.dataGridViewTextBoxColumn_9.HeaderText = "Comment2Repair";
			this.dataGridViewTextBoxColumn_9.Name = "Comment2Repair";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_10.HeaderText = "TypeDocRepair";
			this.dataGridViewTextBoxColumn_10.Name = "TypeDocRepair";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "isActive";
			this.dataGridViewTextBoxColumn_11.HeaderText = "isActiveRepair";
			this.dataGridViewTextBoxColumn_11.Name = "isActiveRepair";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_12.HeaderText = "DeletedRepair";
			this.dataGridViewTextBoxColumn_12.Name = "DeletedRepair";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.contextMenuStrip_2.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_8,
				this.toolStripSeparator_8,
				this.toolStripMenuItem_5,
				this.toolStripMenuItem_6,
				this.toolStripSeparator_7,
				this.toolStripMenuItem_7,
				this.toolStripSeparator_23,
				this.toolStripMenuItem_21
			});
			this.contextMenuStrip_2.Name = "cmsMoveTransf";
			this.contextMenuStrip_2.Size = new Size(155, 132);
			this.toolStripMenuItem_8.Image = Resources.report_1914;
			this.toolStripMenuItem_8.Name = "tsmiViewDoc";
			this.toolStripMenuItem_8.Size = new Size(154, 22);
			this.toolStripMenuItem_8.Text = "Открыть";
			this.toolStripMenuItem_8.Visible = false;
			this.toolStripMenuItem_8.Click += this.toolStripMenuItem_8_Click;
			this.toolStripSeparator_8.Name = "toolStripSeparator3";
			this.toolStripSeparator_8.Size = new Size(151, 6);
			this.toolStripSeparator_8.Visible = false;
			this.toolStripMenuItem_5.Image = Resources.ElementAdd;
			this.toolStripMenuItem_5.Name = "tsmiAddDoc";
			this.toolStripMenuItem_5.Size = new Size(154, 22);
			this.toolStripMenuItem_5.Text = "Добавить";
			this.toolStripMenuItem_6.Image = Resources.ElementEdit;
			this.toolStripMenuItem_6.Name = "tsmiEditDoc";
			this.toolStripMenuItem_6.Size = new Size(154, 22);
			this.toolStripMenuItem_6.Text = "Редактировать";
			this.toolStripMenuItem_6.Click += this.toolStripMenuItem_6_Click;
			this.toolStripSeparator_7.Name = "toolStripSeparator2";
			this.toolStripSeparator_7.Size = new Size(151, 6);
			this.toolStripMenuItem_7.Image = Resources.ElementDel;
			this.toolStripMenuItem_7.Name = "tsmiDeleteDoc";
			this.toolStripMenuItem_7.Size = new Size(154, 22);
			this.toolStripMenuItem_7.Text = "Удалить";
			this.toolStripMenuItem_7.Click += this.toolStripMenuItem_7_Click;
			this.toolStripSeparator_23.Name = "tssiRefreshRepair";
			this.toolStripSeparator_23.Size = new Size(151, 6);
			this.toolStripMenuItem_21.Image = Resources.refresh_16;
			this.toolStripMenuItem_21.Name = "tsmiRefreshRepair";
			this.toolStripMenuItem_21.Size = new Size(154, 22);
			this.toolStripMenuItem_21.Text = "Обновить";
			this.toolStripMenuItem_21.Click += this.toolStripMenuItem_21_Click;
			this.toolStrip_2.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_13,
				this.toolStripButton_4,
				this.toolStripSeparator_10,
				this.toolStripButton_5,
				this.toolStripSeparator_17,
				this.toolStripButton_14,
				this.toolStripButton_20
			});
			this.toolStrip_2.Location = new Point(0, 0);
			this.toolStrip_2.Name = "tsRepair";
			this.toolStrip_2.Size = new Size(764, 25);
			this.toolStrip_2.TabIndex = 0;
			this.toolStrip_2.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_13.Image = Resources.ElementAdd;
			this.toolStripButton_13.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_13.Name = "tssbAddRepair";
			this.toolStripButton_13.Size = new Size(23, 22);
			this.toolStripButton_13.Text = "Добавить";
			this.toolStripButton_13.Click += this.toolStripButton_13_Click;
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = Resources.ElementEdit;
			this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_4.Name = "tsbEditRepair";
			this.toolStripButton_4.Size = new Size(23, 22);
			this.toolStripButton_4.Text = "Редактировать";
			this.toolStripButton_4.Click += this.toolStripButton_4_Click;
			this.toolStripSeparator_10.Name = "toolStripSeparator5";
			this.toolStripSeparator_10.Size = new Size(6, 25);
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = Resources.ElementDel;
			this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_5.Name = "tsbDeleteRepair";
			this.toolStripButton_5.Size = new Size(23, 22);
			this.toolStripButton_5.Text = "Удалить";
			this.toolStripButton_5.Click += this.toolStripButton_5_Click;
			this.toolStripSeparator_17.Name = "tssRefreshRepair";
			this.toolStripSeparator_17.Size = new Size(6, 25);
			this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_14.Image = Resources.refresh_16;
			this.toolStripButton_14.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_14.Name = "tspRefreshRepair";
			this.toolStripButton_14.Size = new Size(23, 22);
			this.toolStripButton_14.Text = "Обновить";
			this.toolStripButton_14.Click += this.toolStripButton_14_Click;
			this.toolStripButton_20.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_20.Image = (Image)componentResourceManager.GetObject("tsbLoadOldRepair.Image");
			this.toolStripButton_20.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_20.Name = "tsbLoadOldRepair";
			this.toolStripButton_20.Size = new Size(151, 22);
			this.toolStripButton_20.Text = "Загрузить из старой базы";
			this.toolStripButton_20.Visible = false;
			this.toolStripButton_20.Click += this.toolStripButton_20_Click;
			this.tabPage_3.Controls.Add(this.tableLayoutPanel_5);
			this.tabPage_3.Location = new Point(4, 22);
			this.tabPage_3.Name = "tpBalance";
			this.tabPage_3.Size = new Size(770, 208);
			this.tabPage_3.TabIndex = 4;
			this.tabPage_3.Text = "Принятие на баланс";
			this.tabPage_3.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_5.ColumnCount = 1;
			this.tableLayoutPanel_5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_5.Controls.Add(this.dataGridView_3, 0, 1);
			this.tableLayoutPanel_5.Controls.Add(this.toolStrip_5, 0, 0);
			this.tableLayoutPanel_5.Dock = DockStyle.Fill;
			this.tableLayoutPanel_5.Location = new Point(0, 0);
			this.tableLayoutPanel_5.Name = "tlpBalance";
			this.tableLayoutPanel_5.RowCount = 2;
			this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_5.Size = new Size(770, 208);
			this.tableLayoutPanel_5.TabIndex = 1;
			this.dataGridView_3.AllowUserToAddRows = false;
			this.dataGridView_3.AllowUserToDeleteRows = false;
			this.dataGridView_3.AllowUserToResizeRows = false;
			this.dataGridView_3.BackgroundColor = Color.White;
			dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle23.BackColor = SystemColors.Control;
			dataGridViewCellStyle23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle23.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
			this.dataGridView_3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
			this.dataGridView_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_3.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_13,
				this.dataGridViewTextBoxColumn_14,
				this.dataGridViewTextBoxColumn_15,
				this.dataGridViewTextBoxColumn_16,
				this.dataGridViewTextBoxColumn_17,
				this.dataGridViewTextBoxColumn_18,
				this.dataGridViewTextBoxColumn_19,
				this.dataGridViewTextBoxColumn_20,
				this.dataGridViewTextBoxColumn_21,
				this.dataGridViewTextBoxColumn_22
			});
			this.dataGridView_3.ContextMenuStrip = this.contextMenuStrip_4;
			dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle24.BackColor = SystemColors.Window;
			dataGridViewCellStyle24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle24.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle24.WrapMode = DataGridViewTriState.False;
			this.dataGridView_3.DefaultCellStyle = dataGridViewCellStyle24;
			this.dataGridView_3.Dock = DockStyle.Fill;
			this.dataGridView_3.Location = new Point(3, 28);
			this.dataGridView_3.MultiSelect = false;
			this.dataGridView_3.Name = "dgvBalance";
			this.dataGridView_3.ReadOnly = true;
			dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle25.BackColor = SystemColors.Control;
			dataGridViewCellStyle25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle25.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
			this.dataGridView_3.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
			this.dataGridView_3.RowHeadersVisible = false;
			this.dataGridView_3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_3.Size = new Size(764, 177);
			this.dataGridView_3.TabIndex = 1;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_13.HeaderText = "idBalance";
			this.dataGridViewTextBoxColumn_13.Name = "idBalance";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_14.HeaderText = "ParentIdBalance";
			this.dataGridViewTextBoxColumn_14.Name = "ParentIdBalance";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_15.HeaderText = "idObjListBalance";
			this.dataGridViewTextBoxColumn_15.Name = "idObjListBalance";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.Visible = false;
			this.dataGridViewTextBoxColumn_16.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_16.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_16.Name = "DateDocBalance";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.Width = 130;
			this.dataGridViewTextBoxColumn_17.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_17.HeaderText = "Номер приказа";
			this.dataGridViewTextBoxColumn_17.Name = "NumberDocBalance";
			this.dataGridViewTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewTextBoxColumn_17.Width = 150;
			this.dataGridViewTextBoxColumn_18.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_18.HeaderText = "От кого";
			this.dataGridViewTextBoxColumn_18.Name = "CommentBalance";
			this.dataGridViewTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_19.DataPropertyName = "Comment2";
			this.dataGridViewTextBoxColumn_19.HeaderText = "Оборудование";
			this.dataGridViewTextBoxColumn_19.Name = "Comment2Balance";
			this.dataGridViewTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewTextBoxColumn_20.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_20.HeaderText = "TypeDocBalance";
			this.dataGridViewTextBoxColumn_20.Name = "TypeDocBalance";
			this.dataGridViewTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewTextBoxColumn_20.Visible = false;
			this.dataGridViewTextBoxColumn_21.DataPropertyName = "isActive";
			this.dataGridViewTextBoxColumn_21.HeaderText = "isActiveBalance";
			this.dataGridViewTextBoxColumn_21.Name = "isActiveBalance";
			this.dataGridViewTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewTextBoxColumn_21.Visible = false;
			this.dataGridViewTextBoxColumn_22.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_22.HeaderText = "DeletedBalance";
			this.dataGridViewTextBoxColumn_22.Name = "DeletedBalance";
			this.dataGridViewTextBoxColumn_22.ReadOnly = true;
			this.dataGridViewTextBoxColumn_22.Visible = false;
			this.contextMenuStrip_4.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_22,
				this.toolStripMenuItem_23,
				this.toolStripSeparator_24,
				this.toolStripMenuItem_24,
				this.toolStripSeparator_25,
				this.toolStripMenuItem_25
			});
			this.contextMenuStrip_4.Name = "cmsBalance";
			this.contextMenuStrip_4.Size = new Size(155, 104);
			this.toolStripMenuItem_22.Image = Resources.ElementAdd;
			this.toolStripMenuItem_22.Name = "tsmiAddBalance";
			this.toolStripMenuItem_22.Size = new Size(154, 22);
			this.toolStripMenuItem_22.Text = "Добавить";
			this.toolStripMenuItem_22.Click += this.toolStripMenuItem_22_Click;
			this.toolStripMenuItem_23.Image = Resources.ElementEdit;
			this.toolStripMenuItem_23.Name = "tsmiEditBalance";
			this.toolStripMenuItem_23.Size = new Size(154, 22);
			this.toolStripMenuItem_23.Text = "Редактировать";
			this.toolStripMenuItem_23.Click += this.toolStripMenuItem_23_Click;
			this.toolStripSeparator_24.Name = "tssiDeleteBalance";
			this.toolStripSeparator_24.Size = new Size(151, 6);
			this.toolStripMenuItem_24.Image = Resources.ElementDel;
			this.toolStripMenuItem_24.Name = "tsmiDeleteBalance";
			this.toolStripMenuItem_24.Size = new Size(154, 22);
			this.toolStripMenuItem_24.Text = "Удалить";
			this.toolStripMenuItem_24.Click += this.toolStripMenuItem_24_Click;
			this.toolStripSeparator_25.Name = "tssiRefreshBalance";
			this.toolStripSeparator_25.Size = new Size(151, 6);
			this.toolStripMenuItem_25.Image = Resources.refresh_16;
			this.toolStripMenuItem_25.Name = "tsmiRefreshBalance";
			this.toolStripMenuItem_25.Size = new Size(154, 22);
			this.toolStripMenuItem_25.Text = "Обновить";
			this.toolStripMenuItem_25.Click += this.toolStripMenuItem_25_Click;
			this.toolStrip_5.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_15,
				this.toolStripButton_16,
				this.toolStripSeparator_18,
				this.toolStripButton_17,
				this.toolStripSeparator_19,
				this.toolStripButton_18,
				this.toolStripButton_21
			});
			this.toolStrip_5.Location = new Point(0, 0);
			this.toolStrip_5.Name = "tsBalance";
			this.toolStrip_5.Size = new Size(770, 25);
			this.toolStrip_5.TabIndex = 0;
			this.toolStrip_5.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_15.Image = Resources.ElementAdd;
			this.toolStripButton_15.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_15.Name = "tsbAddBalance";
			this.toolStripButton_15.Size = new Size(23, 22);
			this.toolStripButton_15.Text = "Добавить";
			this.toolStripButton_15.Click += this.toolStripButton_15_Click;
			this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_16.Image = Resources.ElementEdit;
			this.toolStripButton_16.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_16.Name = "tsbEditBalance";
			this.toolStripButton_16.Size = new Size(23, 22);
			this.toolStripButton_16.Text = "Редактировать";
			this.toolStripButton_16.Click += this.toolStripButton_16_Click;
			this.toolStripSeparator_18.Name = "tssDeleteBalance";
			this.toolStripSeparator_18.Size = new Size(6, 25);
			this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_17.Image = Resources.ElementDel;
			this.toolStripButton_17.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_17.Name = "tsbDeleteBalance";
			this.toolStripButton_17.Size = new Size(23, 22);
			this.toolStripButton_17.Text = "Удалить";
			this.toolStripButton_17.Click += this.toolStripButton_17_Click;
			this.toolStripSeparator_19.Name = "tssRefreshBalance";
			this.toolStripSeparator_19.Size = new Size(6, 25);
			this.toolStripButton_18.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_18.Image = Resources.refresh_16;
			this.toolStripButton_18.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_18.Name = "tsbRefreshBalance";
			this.toolStripButton_18.Size = new Size(23, 22);
			this.toolStripButton_18.Text = "Обновить";
			this.toolStripButton_18.Click += this.toolStripButton_18_Click;
			this.toolStripButton_21.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_21.Image = (Image)componentResourceManager.GetObject("tsbLoadOldBalance.Image");
			this.toolStripButton_21.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_21.Name = "tsbLoadOldBalance";
			this.toolStripButton_21.Size = new Size(151, 22);
			this.toolStripButton_21.Text = "Загрузить из старой базы";
			this.toolStripButton_21.Visible = false;
			this.toolStripButton_21.Click += this.toolStripButton_21_Click;
			this.tabPage_4.Controls.Add(this.tableLayoutPanel_7);
			this.tabPage_4.Location = new Point(4, 22);
			this.tabPage_4.Name = "tpBuildRepair";
			this.tabPage_4.Padding = new Padding(3);
			this.tabPage_4.Size = new Size(770, 208);
			this.tabPage_4.TabIndex = 5;
			this.tabPage_4.Text = "Ремонт строительной части";
			this.tabPage_4.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_7.ColumnCount = 1;
			this.tableLayoutPanel_7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_7.Controls.Add(this.dataGridView_5, 0, 1);
			this.tableLayoutPanel_7.Controls.Add(this.toolStrip_6, 0, 0);
			this.tableLayoutPanel_7.Dock = DockStyle.Fill;
			this.tableLayoutPanel_7.Location = new Point(3, 3);
			this.tableLayoutPanel_7.Name = "tlpBuildRepair";
			this.tableLayoutPanel_7.RowCount = 2;
			this.tableLayoutPanel_7.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_7.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_7.Size = new Size(764, 202);
			this.tableLayoutPanel_7.TabIndex = 0;
			this.dataGridView_5.AllowUserToAddRows = false;
			this.dataGridView_5.AllowUserToDeleteRows = false;
			this.dataGridView_5.AllowUserToResizeRows = false;
			this.dataGridView_5.BackgroundColor = Color.White;
			dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle26.BackColor = SystemColors.Control;
			dataGridViewCellStyle26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle26.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
			this.dataGridView_5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
			this.dataGridView_5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_5.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_80,
				this.dataGridViewTextBoxColumn_81,
				this.dataGridViewTextBoxColumn_82,
				this.dataGridViewTextBoxColumn_83,
				this.dataGridViewTextBoxColumn_84,
				this.dataGridViewTextBoxColumn_85,
				this.dataGridViewTextBoxColumn_86,
				this.dataGridViewTextBoxColumn_87,
				this.dataGridViewTextBoxColumn_88,
				this.dataGridViewTextBoxColumn_89,
				this.dataGridViewTextBoxColumn_90,
				this.dataGridViewTextBoxColumn_91,
				this.dataGridViewTextBoxColumn_92,
				this.dataGridViewTextBoxColumn_93
			});
			this.dataGridView_5.ContextMenuStrip = this.contextMenuStrip_5;
			dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle27.BackColor = SystemColors.Window;
			dataGridViewCellStyle27.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle27.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle27.WrapMode = DataGridViewTriState.False;
			this.dataGridView_5.DefaultCellStyle = dataGridViewCellStyle27;
			this.dataGridView_5.Dock = DockStyle.Fill;
			this.dataGridView_5.Location = new Point(3, 28);
			this.dataGridView_5.MultiSelect = false;
			this.dataGridView_5.Name = "dgvBuildRepair";
			this.dataGridView_5.ReadOnly = true;
			dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle28.BackColor = SystemColors.Control;
			dataGridViewCellStyle28.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle28.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle28.WrapMode = DataGridViewTriState.True;
			this.dataGridView_5.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
			this.dataGridView_5.RowHeadersVisible = false;
			this.dataGridView_5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_5.Size = new Size(758, 171);
			this.dataGridView_5.TabIndex = 1;
			this.dataGridViewTextBoxColumn_80.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_80.HeaderText = "idBuildRepair";
			this.dataGridViewTextBoxColumn_80.Name = "idBuildRepair";
			this.dataGridViewTextBoxColumn_80.ReadOnly = true;
			this.dataGridViewTextBoxColumn_80.Visible = false;
			this.dataGridViewTextBoxColumn_81.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_81.HeaderText = "idObjListBuildRepair";
			this.dataGridViewTextBoxColumn_81.Name = "idObjListBuildRepair";
			this.dataGridViewTextBoxColumn_81.ReadOnly = true;
			this.dataGridViewTextBoxColumn_81.Visible = false;
			this.dataGridViewTextBoxColumn_82.DataPropertyName = "DateFactRepair";
			this.dataGridViewTextBoxColumn_82.HeaderText = "Дата ремонта (факт.)";
			this.dataGridViewTextBoxColumn_82.Name = "dateFactRepairBuildRepair";
			this.dataGridViewTextBoxColumn_82.ReadOnly = true;
			this.dataGridViewTextBoxColumn_82.Width = 140;
			this.dataGridViewTextBoxColumn_83.DataPropertyName = "DateFactRepairComm";
			this.dataGridViewTextBoxColumn_83.HeaderText = "Комментарий (факт.)";
			this.dataGridViewTextBoxColumn_83.Name = "DateFactRepairCommBuildRepair";
			this.dataGridViewTextBoxColumn_83.ReadOnly = true;
			this.dataGridViewTextBoxColumn_84.DataPropertyName = "DateHousetopRepair";
			this.dataGridViewTextBoxColumn_84.HeaderText = "Дата ремонта крыши";
			this.dataGridViewTextBoxColumn_84.Name = "idHousetopRepairBuildRepair";
			this.dataGridViewTextBoxColumn_84.ReadOnly = true;
			this.dataGridViewTextBoxColumn_84.Width = 140;
			this.dataGridViewTextBoxColumn_85.DataPropertyName = "dateHousetopRepairComm";
			this.dataGridViewTextBoxColumn_85.HeaderText = "Комментарий (крыша.)";
			this.dataGridViewTextBoxColumn_85.Name = "dateHousetopRepairCommBuildRepair";
			this.dataGridViewTextBoxColumn_85.ReadOnly = true;
			this.dataGridViewTextBoxColumn_86.DataPropertyName = "DatePlanRepair";
			this.dataGridViewTextBoxColumn_86.HeaderText = "Дата ремонта (план.)";
			this.dataGridViewTextBoxColumn_86.Name = "datePlanRepairBuildRepair";
			this.dataGridViewTextBoxColumn_86.ReadOnly = true;
			this.dataGridViewTextBoxColumn_86.Width = 140;
			this.dataGridViewTextBoxColumn_87.DataPropertyName = "datePlanRepairComm";
			this.dataGridViewTextBoxColumn_87.HeaderText = "Комментарий (план.) ";
			this.dataGridViewTextBoxColumn_87.Name = "datePlanRepairCommBuildRepair";
			this.dataGridViewTextBoxColumn_87.ReadOnly = true;
			this.dataGridViewTextBoxColumn_88.DataPropertyName = "DoorType";
			this.dataGridViewTextBoxColumn_88.HeaderText = "Тип двери";
			this.dataGridViewTextBoxColumn_88.Name = "DoorTypeBuildRepair";
			this.dataGridViewTextBoxColumn_88.ReadOnly = true;
			this.dataGridViewTextBoxColumn_88.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_88.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_89.DataPropertyName = "DoorRepair";
			this.dataGridViewTextBoxColumn_89.HeaderText = "Ремонт двери";
			this.dataGridViewTextBoxColumn_89.Name = "DoorRepairBuildRepair";
			this.dataGridViewTextBoxColumn_89.ReadOnly = true;
			this.dataGridViewTextBoxColumn_89.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_89.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_90.DataPropertyName = "OtmostRepair";
			this.dataGridViewTextBoxColumn_90.HeaderText = "Ремонт отмоста";
			this.dataGridViewTextBoxColumn_90.Name = "OtmostRepairBuildRepair";
			this.dataGridViewTextBoxColumn_90.ReadOnly = true;
			this.dataGridViewTextBoxColumn_91.DataPropertyName = "Company";
			this.dataGridViewTextBoxColumn_91.HeaderText = "Организация-подрядчик";
			this.dataGridViewTextBoxColumn_91.Name = "CompanyBuildRepair";
			this.dataGridViewTextBoxColumn_91.ReadOnly = true;
			this.dataGridViewTextBoxColumn_91.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_91.Width = 140;
			this.dataGridViewTextBoxColumn_92.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_92.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_92.Name = "CommentBuildRepair";
			this.dataGridViewTextBoxColumn_92.ReadOnly = true;
			this.dataGridViewTextBoxColumn_93.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_93.HeaderText = "deletedBuildRepair";
			this.dataGridViewTextBoxColumn_93.Name = "deletedBuildRepair";
			this.dataGridViewTextBoxColumn_93.ReadOnly = true;
			this.dataGridViewTextBoxColumn_93.Visible = false;
			this.contextMenuStrip_5.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_26,
				this.toolStripMenuItem_27,
				this.toolStripSeparator_28,
				this.toolStripMenuItem_28,
				this.toolStripSeparator_29,
				this.toolStripMenuItem_29
			});
			this.contextMenuStrip_5.Name = "cmsBuildRepair";
			this.contextMenuStrip_5.Size = new Size(155, 104);
			this.toolStripMenuItem_26.Image = Resources.ElementAdd;
			this.toolStripMenuItem_26.Name = "tsmiAddBuildRepair";
			this.toolStripMenuItem_26.Size = new Size(154, 22);
			this.toolStripMenuItem_26.Text = "Добавить";
			this.toolStripMenuItem_26.Click += this.toolStripMenuItem_26_Click;
			this.toolStripMenuItem_27.Image = Resources.ElementEdit;
			this.toolStripMenuItem_27.Name = "tsmiEditBuildRepair";
			this.toolStripMenuItem_27.Size = new Size(154, 22);
			this.toolStripMenuItem_27.Text = "Редактировать";
			this.toolStripMenuItem_27.Click += this.toolStripMenuItem_27_Click;
			this.toolStripSeparator_28.Name = "tssDeleteBuildRepair";
			this.toolStripSeparator_28.Size = new Size(151, 6);
			this.toolStripMenuItem_28.Image = Resources.ElementDel;
			this.toolStripMenuItem_28.Name = "tsmiDeleteBuildRepair";
			this.toolStripMenuItem_28.Size = new Size(154, 22);
			this.toolStripMenuItem_28.Text = "Удалить";
			this.toolStripMenuItem_28.Click += this.toolStripMenuItem_28_Click;
			this.toolStripSeparator_29.Name = "tssiRefreshBuildRepair";
			this.toolStripSeparator_29.Size = new Size(151, 6);
			this.toolStripMenuItem_29.Image = Resources.refresh_16;
			this.toolStripMenuItem_29.Name = "tsmiRefreshBuildRepair";
			this.toolStripMenuItem_29.Size = new Size(154, 22);
			this.toolStripMenuItem_29.Text = "Обновить";
			this.toolStripMenuItem_29.Click += this.toolStripMenuItem_29_Click;
			this.toolStrip_6.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_22,
				this.toolStripButton_23,
				this.toolStripSeparator_26,
				this.toolStripButton_24,
				this.toolStripSeparator_27,
				this.toolStripButton_25,
				this.toolStripButton_26
			});
			this.toolStrip_6.Location = new Point(0, 0);
			this.toolStrip_6.Name = "tsBuildRepair";
			this.toolStrip_6.Size = new Size(764, 25);
			this.toolStrip_6.TabIndex = 0;
			this.toolStrip_6.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_22.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_22.Image = Resources.ElementAdd;
			this.toolStripButton_22.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_22.Name = "tsbAddBuildRepair";
			this.toolStripButton_22.Size = new Size(23, 22);
			this.toolStripButton_22.Text = "Добавить";
			this.toolStripButton_22.Click += this.toolStripButton_22_Click;
			this.toolStripButton_23.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_23.Image = Resources.ElementEdit;
			this.toolStripButton_23.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_23.Name = "tsbEditBuildRepair";
			this.toolStripButton_23.Size = new Size(23, 22);
			this.toolStripButton_23.Text = "Редактировать";
			this.toolStripButton_23.Click += this.toolStripButton_23_Click;
			this.toolStripSeparator_26.Name = "tssDeletedBuildRepair";
			this.toolStripSeparator_26.Size = new Size(6, 25);
			this.toolStripButton_24.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_24.Image = Resources.ElementDel;
			this.toolStripButton_24.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_24.Name = "tsbDeleteBuildRepair";
			this.toolStripButton_24.Size = new Size(23, 22);
			this.toolStripButton_24.Text = "Удалить";
			this.toolStripButton_24.Click += this.toolStripButton_24_Click;
			this.toolStripSeparator_27.Name = "tssRefreshBuildRepair";
			this.toolStripSeparator_27.Size = new Size(6, 25);
			this.toolStripButton_25.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_25.Image = Resources.refresh_16;
			this.toolStripButton_25.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_25.Name = "tsbRefreshBuildRepair";
			this.toolStripButton_25.Size = new Size(23, 22);
			this.toolStripButton_25.Text = "Обновить";
			this.toolStripButton_25.Click += this.toolStripButton_25_Click;
			this.toolStripButton_26.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_26.Image = (Image)componentResourceManager.GetObject("tsbLoadOldBuildRepair.Image");
			this.toolStripButton_26.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_26.Name = "tsbLoadOldBuildRepair";
			this.toolStripButton_26.Size = new Size(151, 22);
			this.toolStripButton_26.Text = "Загрузить из старой базы";
			this.toolStripButton_26.Visible = false;
			this.tabPage_6.Controls.Add(this.tableLayoutPanel_9);
			this.tabPage_6.Location = new Point(4, 22);
			this.tabPage_6.Name = "tpCabProtocol";
			this.tabPage_6.Padding = new Padding(3);
			this.tabPage_6.Size = new Size(770, 208);
			this.tabPage_6.TabIndex = 10;
			this.tabPage_6.Text = "Протокол";
			this.tabPage_6.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_9.ColumnCount = 1;
			this.tableLayoutPanel_9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_9.Controls.Add(this.dataGridView_7, 0, 1);
			this.tableLayoutPanel_9.Controls.Add(this.toolStrip_8, 0, 0);
			this.tableLayoutPanel_9.Dock = DockStyle.Fill;
			this.tableLayoutPanel_9.Location = new Point(3, 3);
			this.tableLayoutPanel_9.Name = "tlpProtocol";
			this.tableLayoutPanel_9.RowCount = 2;
			this.tableLayoutPanel_9.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_9.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_9.Size = new Size(764, 202);
			this.tableLayoutPanel_9.TabIndex = 0;
			this.dataGridView_7.AllowUserToAddRows = false;
			this.dataGridView_7.AllowUserToDeleteRows = false;
			this.dataGridView_7.AllowUserToResizeRows = false;
			this.dataGridView_7.BackgroundColor = Color.White;
			dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle29.BackColor = SystemColors.Control;
			dataGridViewCellStyle29.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle29.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
			this.dataGridView_7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
			this.dataGridView_7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_7.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_124,
				this.dataGridViewTextBoxColumn_125,
				this.dataGridViewTextBoxColumn_126,
				this.dataGridViewTextBoxColumn_127,
				this.dataGridViewTextBoxColumn_128,
				this.dataGridViewTextBoxColumn_129,
				this.dataGridViewTextBoxColumn_130,
				this.dataGridViewTextBoxColumn_131,
				this.dataGridViewTextBoxColumn_132,
				this.dataGridViewTextBoxColumn_133
			});
			dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle30.BackColor = SystemColors.Window;
			dataGridViewCellStyle30.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle30.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle30.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle30.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle30.WrapMode = DataGridViewTriState.False;
			this.dataGridView_7.DefaultCellStyle = dataGridViewCellStyle30;
			this.dataGridView_7.Dock = DockStyle.Fill;
			this.dataGridView_7.Location = new Point(3, 28);
			this.dataGridView_7.MultiSelect = false;
			this.dataGridView_7.Name = "dgvCabProtocol";
			this.dataGridView_7.ReadOnly = true;
			dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle31.BackColor = SystemColors.Control;
			dataGridViewCellStyle31.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle31.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle31.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle31.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle31.WrapMode = DataGridViewTriState.True;
			this.dataGridView_7.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
			this.dataGridView_7.RowHeadersVisible = false;
			this.dataGridView_7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_7.Size = new Size(758, 171);
			this.dataGridView_7.TabIndex = 1;
			this.dataGridViewTextBoxColumn_124.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn_124.HeaderText = "idCabProtocol";
			this.dataGridViewTextBoxColumn_124.Name = "idCabProtocol";
			this.dataGridViewTextBoxColumn_124.ReadOnly = true;
			this.dataGridViewTextBoxColumn_124.Visible = false;
			this.dataGridViewTextBoxColumn_125.DataPropertyName = "ProtocolN";
			this.dataGridViewTextBoxColumn_125.HeaderText = "№ ";
			this.dataGridViewTextBoxColumn_125.Name = "ProtocolNCabProtocol";
			this.dataGridViewTextBoxColumn_125.ReadOnly = true;
			this.dataGridViewTextBoxColumn_125.Width = 50;
			this.dataGridViewTextBoxColumn_126.DataPropertyName = "ProtocolTip";
			this.dataGridViewTextBoxColumn_126.HeaderText = "Тип";
			this.dataGridViewTextBoxColumn_126.Name = "ProtocolTipCabProtocol";
			this.dataGridViewTextBoxColumn_126.ReadOnly = true;
			this.dataGridViewTextBoxColumn_127.DataPropertyName = "PovregTip";
			this.dataGridViewTextBoxColumn_127.HeaderText = "Повреждение";
			this.dataGridViewTextBoxColumn_127.Name = "PovregTip";
			this.dataGridViewTextBoxColumn_127.ReadOnly = true;
			this.dataGridViewTextBoxColumn_128.DataPropertyName = "PovregVid";
			this.dataGridViewTextBoxColumn_128.HeaderText = "Вид повреждения";
			this.dataGridViewTextBoxColumn_128.Name = "PovregVid";
			this.dataGridViewTextBoxColumn_128.ReadOnly = true;
			this.dataGridViewTextBoxColumn_129.DataPropertyName = "PovregData";
			this.dataGridViewTextBoxColumn_129.HeaderText = "Дата поврежд.";
			this.dataGridViewTextBoxColumn_129.Name = "PovregData";
			this.dataGridViewTextBoxColumn_129.ReadOnly = true;
			this.dataGridViewTextBoxColumn_129.Width = 70;
			this.dataGridViewTextBoxColumn_130.DataPropertyName = "RemontData";
			this.dataGridViewTextBoxColumn_130.HeaderText = "Дата ремонта";
			this.dataGridViewTextBoxColumn_130.Name = "RemontData";
			this.dataGridViewTextBoxColumn_130.ReadOnly = true;
			this.dataGridViewTextBoxColumn_130.Width = 70;
			this.dataGridViewTextBoxColumn_131.DataPropertyName = "NaimKL";
			this.dataGridViewTextBoxColumn_131.HeaderText = "Наименование кабеля";
			this.dataGridViewTextBoxColumn_131.Name = "NaimKL";
			this.dataGridViewTextBoxColumn_131.ReadOnly = true;
			this.dataGridViewTextBoxColumn_132.DataPropertyName = "UchN";
			this.dataGridViewTextBoxColumn_132.HeaderText = "№ участка";
			this.dataGridViewTextBoxColumn_132.Name = "UchN";
			this.dataGridViewTextBoxColumn_132.ReadOnly = true;
			this.dataGridViewTextBoxColumn_133.DataPropertyName = "MuftaN";
			this.dataGridViewTextBoxColumn_133.HeaderText = "№ муфты";
			this.dataGridViewTextBoxColumn_133.Name = "MuftaN";
			this.dataGridViewTextBoxColumn_133.ReadOnly = true;
			this.toolStrip_8.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_33,
				this.toolStripButton_34,
				this.toolStripSeparator_35,
				this.toolStripButton_35,
				this.toolStripSeparator_36,
				this.toolStripButton_36,
				this.toolStripSeparator_37,
				this.toolStripButton_37,
				this.toolStripSeparator_38,
				this.toolStripButton_38
			});
			this.toolStrip_8.Location = new Point(0, 0);
			this.toolStrip_8.Name = "tsProtocol";
			this.toolStrip_8.Size = new Size(764, 25);
			this.toolStrip_8.TabIndex = 0;
			this.toolStrip_8.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_33.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_33.Image = Resources.ElementAdd;
			this.toolStripButton_33.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_33.Name = "tsbCabProtocolAdd";
			this.toolStripButton_33.Size = new Size(23, 22);
			this.toolStripButton_33.Text = "Добавить";
			this.toolStripButton_33.Click += this.toolStripButton_33_Click;
			this.toolStripButton_34.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_34.Image = Resources.ElementEdit;
			this.toolStripButton_34.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_34.Name = "tsbCabProtocolEdit";
			this.toolStripButton_34.Size = new Size(23, 22);
			this.toolStripButton_34.Text = "Редактировать";
			this.toolStripButton_34.Click += this.toolStripButton_34_Click;
			this.toolStripSeparator_35.Name = "tssCabProtocolDelete";
			this.toolStripSeparator_35.Size = new Size(6, 25);
			this.toolStripButton_35.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_35.Image = Resources.ElementDel;
			this.toolStripButton_35.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_35.Name = "tsbCabProtocolDelete";
			this.toolStripButton_35.Size = new Size(23, 22);
			this.toolStripButton_35.Text = "Удалить";
			this.toolStripButton_35.Click += this.toolStripButton_35_Click;
			this.toolStripSeparator_36.Name = "tssCabProtocolView";
			this.toolStripSeparator_36.Size = new Size(6, 25);
			this.toolStripButton_36.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_36.Image = Resources.report_1914;
			this.toolStripButton_36.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_36.Name = "tsbCabProtocolView";
			this.toolStripButton_36.Size = new Size(23, 22);
			this.toolStripButton_36.Text = "Просмотреть";
			this.toolStripButton_36.Click += this.toolStripButton_36_Click;
			this.toolStripSeparator_37.Name = "tssCabProtocolRefresh";
			this.toolStripSeparator_37.Size = new Size(6, 25);
			this.toolStripButton_37.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_37.Image = Resources.refresh_16;
			this.toolStripButton_37.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_37.Name = "tsbCabProtocolRefresh";
			this.toolStripButton_37.Size = new Size(23, 22);
			this.toolStripButton_37.Text = "Обновить";
			this.toolStripButton_37.Click += this.toolStripButton_37_Click;
			this.toolStripSeparator_38.Name = "toolStripSeparator6";
			this.toolStripSeparator_38.Size = new Size(6, 25);
			this.toolStripButton_38.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_38.Image = Resources.Print;
			this.toolStripButton_38.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_38.Name = "tsbCabProtocolShow";
			this.toolStripButton_38.Size = new Size(23, 22);
			this.toolStripButton_38.Text = "Печать";
			this.toolStripButton_38.Click += this.toolStripButton_38_Click;
			this.tabPage_7.Controls.Add(this.tableLayoutPanel_10);
			this.tabPage_7.Location = new Point(4, 22);
			this.tabPage_7.Name = "tpCableOperation";
			this.tabPage_7.Padding = new Padding(3);
			this.tabPage_7.Size = new Size(770, 208);
			this.tabPage_7.TabIndex = 11;
			this.tabPage_7.Text = "Эксплуатация";
			this.tabPage_7.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_10.ColumnCount = 1;
			this.tableLayoutPanel_10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_10.Controls.Add(this.dataGridView_8, 0, 1);
			this.tableLayoutPanel_10.Controls.Add(this.toolStrip_9, 0, 0);
			this.tableLayoutPanel_10.Dock = DockStyle.Fill;
			this.tableLayoutPanel_10.Location = new Point(3, 3);
			this.tableLayoutPanel_10.Name = "tlpCableOperation";
			this.tableLayoutPanel_10.RowCount = 2;
			this.tableLayoutPanel_10.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_10.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_10.Size = new Size(764, 202);
			this.tableLayoutPanel_10.TabIndex = 0;
			this.dataGridView_8.AllowUserToAddRows = false;
			this.dataGridView_8.AllowUserToDeleteRows = false;
			this.dataGridView_8.AllowUserToResizeRows = false;
			this.dataGridView_8.AutoGenerateColumns = false;
			this.dataGridView_8.BackgroundColor = Color.White;
			dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle32.BackColor = SystemColors.Control;
			dataGridViewCellStyle32.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle32.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle32.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle32.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle32.WrapMode = DataGridViewTriState.True;
			this.dataGridView_8.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
			this.dataGridView_8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_8.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewTextBoxColumn_134,
				this.dataGridViewTextBoxColumn_135,
				this.dataGridViewTextBoxColumn_136,
				this.dataGridViewTextBoxColumn_137,
				this.dataGridViewTextBoxColumn_138
			});
			this.dataGridView_8.DataSource = this.bindingSource_5;
			dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle33.BackColor = SystemColors.Window;
			dataGridViewCellStyle33.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle33.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle33.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle33.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle33.WrapMode = DataGridViewTriState.False;
			this.dataGridView_8.DefaultCellStyle = dataGridViewCellStyle33;
			this.dataGridView_8.Dock = DockStyle.Fill;
			this.dataGridView_8.Location = new Point(3, 28);
			this.dataGridView_8.MultiSelect = false;
			this.dataGridView_8.Name = "dgvCableOperation";
			this.dataGridView_8.ReadOnly = true;
			dataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle34.BackColor = SystemColors.Control;
			dataGridViewCellStyle34.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle34.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle34.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle34.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle34.WrapMode = DataGridViewTriState.True;
			this.dataGridView_8.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
			this.dataGridView_8.RowHeadersVisible = false;
			this.dataGridView_8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_8.Size = new Size(758, 171);
			this.dataGridView_8.TabIndex = 1;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "DeletedCabOperation";
			this.dataGridViewCheckBoxColumn_0.Name = "deletedCabOperation";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_134.DataPropertyName = "DateDecommissioning";
			this.dataGridViewTextBoxColumn_134.HeaderText = "Дата вывода";
			this.dataGridViewTextBoxColumn_134.Name = "DateDecommissioningCabOperation";
			this.dataGridViewTextBoxColumn_134.ReadOnly = true;
			this.dataGridViewTextBoxColumn_135.DataPropertyName = "DateCommissioning";
			this.dataGridViewTextBoxColumn_135.HeaderText = "Дата ввода";
			this.dataGridViewTextBoxColumn_135.Name = "DateCommissioningCabOperation";
			this.dataGridViewTextBoxColumn_135.ReadOnly = true;
			this.dataGridViewTextBoxColumn_136.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_136.HeaderText = "idCabOperation";
			this.dataGridViewTextBoxColumn_136.Name = "idCabOperation";
			this.dataGridViewTextBoxColumn_136.ReadOnly = true;
			this.dataGridViewTextBoxColumn_136.Visible = false;
			this.dataGridViewTextBoxColumn_137.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_137.HeaderText = "idObjListCabOperation";
			this.dataGridViewTextBoxColumn_137.Name = "idObjListCabOperation";
			this.dataGridViewTextBoxColumn_137.ReadOnly = true;
			this.dataGridViewTextBoxColumn_137.Visible = false;
			this.dataGridViewTextBoxColumn_138.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_138.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_138.HeaderText = "Причина";
			this.dataGridViewTextBoxColumn_138.Name = "nameCabOperation";
			this.dataGridViewTextBoxColumn_138.ReadOnly = true;
			this.bindingSource_5.DataMember = "vP_CabOperation";
			this.bindingSource_5.DataSource = this.dsPassport_0;
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.toolStrip_9.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripSeparator_39,
				this.toolStripButton_39,
				this.toolStripSeparator_40,
				this.toolStripButton_40,
				this.toolStripSeparator_41,
				this.toolStripButton_41
			});
			this.toolStrip_9.Location = new Point(0, 0);
			this.toolStrip_9.Name = "tsCableOperation";
			this.toolStrip_9.Size = new Size(764, 25);
			this.toolStrip_9.TabIndex = 2;
			this.toolStripSeparator_39.Name = "tssCabOperationAccept";
			this.toolStripSeparator_39.Size = new Size(6, 25);
			this.toolStripButton_39.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_39.Image = (Image)componentResourceManager.GetObject("tsbCabOperationAccept.Image");
			this.toolStripButton_39.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_39.Name = "tsbCabOperationAccept";
			this.toolStripButton_39.Size = new Size(57, 22);
			this.toolStripButton_39.Text = "Вывести";
			this.toolStripButton_39.TextImageRelation = TextImageRelation.ImageAboveText;
			this.toolStripSeparator_40.Name = "tssCabOperationDelete";
			this.toolStripSeparator_40.Size = new Size(6, 25);
			this.toolStripButton_40.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_40.Image = Resources.ElementDel;
			this.toolStripButton_40.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_40.Name = "tsbcabOperationDelete";
			this.toolStripButton_40.Size = new Size(23, 22);
			this.toolStripButton_40.Text = "Удаленить";
			this.toolStripSeparator_41.Name = "tssCabOperationRefresh";
			this.toolStripSeparator_41.Size = new Size(6, 25);
			this.toolStripButton_41.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_41.Image = Resources.refresh_16;
			this.toolStripButton_41.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_41.Name = "tsbCabOperationRefresh";
			this.toolStripButton_41.Size = new Size(23, 22);
			this.toolStripButton_41.Text = "Обновление";
			this.tabPage_8.Controls.Add(this.tableLayoutPanel_11);
			this.tabPage_8.Location = new Point(4, 22);
			this.tabPage_8.Name = "tpCableTesting";
			this.tabPage_8.Padding = new Padding(3);
			this.tabPage_8.Size = new Size(770, 208);
			this.tabPage_8.TabIndex = 12;
			this.tabPage_8.Text = "Испытание кабеля";
			this.tabPage_8.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_11.ColumnCount = 1;
			this.tableLayoutPanel_11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_11.Controls.Add(this.dataGridView_9, 0, 1);
			this.tableLayoutPanel_11.Controls.Add(this.toolStrip_10, 0, 0);
			this.tableLayoutPanel_11.Dock = DockStyle.Fill;
			this.tableLayoutPanel_11.Location = new Point(3, 3);
			this.tableLayoutPanel_11.Name = "tlpCableTesting";
			this.tableLayoutPanel_11.RowCount = 2;
			this.tableLayoutPanel_11.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_11.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_11.Size = new Size(764, 202);
			this.tableLayoutPanel_11.TabIndex = 0;
			this.dataGridView_9.AllowUserToAddRows = false;
			this.dataGridView_9.AllowUserToDeleteRows = false;
			this.dataGridView_9.AllowUserToResizeRows = false;
			this.dataGridView_9.AutoGenerateColumns = false;
			this.dataGridView_9.BackgroundColor = Color.White;
			dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle35.BackColor = SystemColors.Control;
			dataGridViewCellStyle35.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle35.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle35.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle35.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle35.WrapMode = DataGridViewTriState.True;
			this.dataGridView_9.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
			this.dataGridView_9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_9.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_1,
				this.dataGridViewTextBoxColumn_139,
				this.dataGridViewTextBoxColumn_140,
				this.dataGridViewTextBoxColumn_141,
				this.dataGridViewTextBoxColumn_142,
				this.dataGridViewTextBoxColumn_143,
				this.dataGridViewTextBoxColumn_144,
				this.dataGridViewTextBoxColumn_145
			});
			this.dataGridView_9.DataSource = this.bindingSource_6;
			dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle36.BackColor = SystemColors.Window;
			dataGridViewCellStyle36.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle36.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle36.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle36.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle36.WrapMode = DataGridViewTriState.False;
			this.dataGridView_9.DefaultCellStyle = dataGridViewCellStyle36;
			this.dataGridView_9.Dock = DockStyle.Fill;
			this.dataGridView_9.Location = new Point(3, 28);
			this.dataGridView_9.MultiSelect = false;
			this.dataGridView_9.Name = "dgvCableTesting";
			this.dataGridView_9.ReadOnly = true;
			dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle37.BackColor = SystemColors.Control;
			dataGridViewCellStyle37.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle37.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle37.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle37.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle37.WrapMode = DataGridViewTriState.True;
			this.dataGridView_9.RowHeadersDefaultCellStyle = dataGridViewCellStyle37;
			this.dataGridView_9.RowHeadersVisible = false;
			this.dataGridView_9.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_9.Size = new Size(758, 171);
			this.dataGridView_9.TabIndex = 1;
			this.dataGridViewCheckBoxColumn_1.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_1.HeaderText = "DeletedCabTesting";
			this.dataGridViewCheckBoxColumn_1.Name = "deletedCabTesting";
			this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_139.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_139.HeaderText = "idCabTesting";
			this.dataGridViewTextBoxColumn_139.Name = "idCabTesting";
			this.dataGridViewTextBoxColumn_139.ReadOnly = true;
			this.dataGridViewTextBoxColumn_139.Visible = false;
			this.dataGridViewTextBoxColumn_140.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_140.HeaderText = "idObjListCabTesting";
			this.dataGridViewTextBoxColumn_140.Name = "idObjListCabTesting";
			this.dataGridViewTextBoxColumn_140.ReadOnly = true;
			this.dataGridViewTextBoxColumn_140.Visible = false;
			this.dataGridViewTextBoxColumn_141.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn_141.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_141.Name = "DateCabTesting";
			this.dataGridViewTextBoxColumn_141.ReadOnly = true;
			this.dataGridViewTextBoxColumn_142.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_142.HeaderText = "Причина";
			this.dataGridViewTextBoxColumn_142.Name = "NameCabTesting";
			this.dataGridViewTextBoxColumn_142.ReadOnly = true;
			this.dataGridViewTextBoxColumn_143.DataPropertyName = "Voltage";
			this.dataGridViewTextBoxColumn_143.HeaderText = "Напряжение";
			this.dataGridViewTextBoxColumn_143.Name = "VoltageCabTesting";
			this.dataGridViewTextBoxColumn_143.ReadOnly = true;
			this.dataGridViewTextBoxColumn_144.DataPropertyName = "Duration";
			this.dataGridViewTextBoxColumn_144.HeaderText = "Продолжительность";
			this.dataGridViewTextBoxColumn_144.Name = "DurationCabTesting";
			this.dataGridViewTextBoxColumn_144.ReadOnly = true;
			this.dataGridViewTextBoxColumn_144.Width = 140;
			this.dataGridViewTextBoxColumn_145.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_145.DataPropertyName = "Conclusion";
			this.dataGridViewTextBoxColumn_145.HeaderText = "Заключение";
			this.dataGridViewTextBoxColumn_145.Name = "ConclusionCabTesting";
			this.dataGridViewTextBoxColumn_145.ReadOnly = true;
			this.bindingSource_6.DataMember = "vP_CabTesting";
			this.bindingSource_6.DataSource = this.dsPassport_0;
			this.bindingSource_6.Sort = "Date";
			this.toolStrip_10.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_42,
				this.toolStripButton_43,
				this.toolStripSeparator_42,
				this.toolStripButton_44,
				this.toolStripSeparator_43,
				this.toolStripButton_45
			});
			this.toolStrip_10.Location = new Point(0, 0);
			this.toolStrip_10.Name = "tsCableTesting";
			this.toolStrip_10.Size = new Size(764, 25);
			this.toolStrip_10.TabIndex = 0;
			this.toolStrip_10.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_42.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_42.Image = Resources.ElementAdd;
			this.toolStripButton_42.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_42.Name = "tsbCableTestAdd";
			this.toolStripButton_42.Size = new Size(23, 22);
			this.toolStripButton_42.Text = "Добавить";
			this.toolStripButton_43.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_43.Image = Resources.ElementEdit;
			this.toolStripButton_43.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_43.Name = "tsbCableTestEdit";
			this.toolStripButton_43.Size = new Size(23, 22);
			this.toolStripButton_43.Text = "Редактировать";
			this.toolStripSeparator_42.Name = "toolStripSeparator8";
			this.toolStripSeparator_42.Size = new Size(6, 25);
			this.toolStripButton_44.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_44.Image = Resources.ElementDel;
			this.toolStripButton_44.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_44.Name = "tsbCableTestDelete";
			this.toolStripButton_44.Size = new Size(23, 22);
			this.toolStripButton_44.Text = "Удалить";
			this.toolStripSeparator_43.Name = "toolStripSeparator10";
			this.toolStripSeparator_43.Size = new Size(6, 25);
			this.toolStripButton_45.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_45.Image = Resources.refresh_16;
			this.toolStripButton_45.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_45.Name = "tsbCableTestRefresh";
			this.toolStripButton_45.Size = new Size(23, 22);
			this.toolStripButton_45.Text = "Обновить";
			this.tabPage_9.Controls.Add(this.toolStrip_11);
			this.tabPage_9.Controls.Add(this.tableLayoutPanel_12);
			this.tabPage_9.Location = new Point(4, 22);
			this.tabPage_9.Name = "tpPerambulation";
			this.tabPage_9.Padding = new Padding(3);
			this.tabPage_9.Size = new Size(770, 208);
			this.tabPage_9.TabIndex = 13;
			this.tabPage_9.Text = "Обход трассы";
			this.tabPage_9.UseVisualStyleBackColor = true;
			this.toolStrip_11.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_46,
				this.toolStripButton_47,
				this.toolStripSeparator_45,
				this.toolStripButton_48,
				this.toolStripSeparator_46,
				this.toolStripButton_49
			});
			this.toolStrip_11.Location = new Point(3, 3);
			this.toolStrip_11.Name = "tsPerambulation";
			this.toolStrip_11.Size = new Size(764, 25);
			this.toolStrip_11.TabIndex = 1;
			this.toolStrip_11.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_46.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_46.Image = Resources.ElementAdd;
			this.toolStripButton_46.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_46.Name = "tsbAddPeram";
			this.toolStripButton_46.Size = new Size(23, 22);
			this.toolStripButton_46.Text = "Добавить";
			this.toolStripButton_46.Click += this.toolStripMenuItem_43_Click;
			this.toolStripButton_47.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_47.Image = Resources.ElementEdit;
			this.toolStripButton_47.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_47.Name = "tsbEditPeram";
			this.toolStripButton_47.Size = new Size(23, 22);
			this.toolStripButton_47.Text = "Редактировать";
			this.toolStripButton_47.Click += this.toolStripMenuItem_44_Click;
			this.toolStripSeparator_45.Name = "tssDeletePeram";
			this.toolStripSeparator_45.Size = new Size(6, 25);
			this.toolStripButton_48.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_48.Image = Resources.ElementDel;
			this.toolStripButton_48.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_48.Name = "tsbDeletePeram";
			this.toolStripButton_48.Size = new Size(23, 22);
			this.toolStripButton_48.Text = "Удалить";
			this.toolStripButton_48.Click += this.toolStripMenuItem_45_Click;
			this.toolStripSeparator_46.Name = "tssRefreshPeram";
			this.toolStripSeparator_46.Size = new Size(6, 25);
			this.toolStripButton_49.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_49.Image = Resources.refresh_16;
			this.toolStripButton_49.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_49.Name = "tsbRefreshPeram";
			this.toolStripButton_49.Size = new Size(23, 22);
			this.toolStripButton_49.Text = "Обновить";
			this.toolStripButton_49.Click += this.toolStripMenuItem_46_Click;
			this.tableLayoutPanel_12.ColumnCount = 1;
			this.tableLayoutPanel_12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_12.Controls.Add(this.dataGridViewExcelFilter_1, 0, 1);
			this.tableLayoutPanel_12.Dock = DockStyle.Fill;
			this.tableLayoutPanel_12.Location = new Point(3, 3);
			this.tableLayoutPanel_12.Name = "tlpPerambulation";
			this.tableLayoutPanel_12.RowCount = 2;
			this.tableLayoutPanel_12.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.tableLayoutPanel_12.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_12.Size = new Size(764, 202);
			this.tableLayoutPanel_12.TabIndex = 0;
			this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_1.BackgroundColor = Color.White;
			dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle38.BackColor = SystemColors.Control;
			dataGridViewCellStyle38.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle38.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle38.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle38.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle38.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
			this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_2,
				this.dataGridViewTextBoxColumn_159,
				this.dataGridViewTextBoxColumn_160,
				this.dataGridViewTextBoxColumn_161,
				this.dataGridViewTextBoxColumn_162,
				this.dataGridViewTextBoxColumn_163,
				this.dataGridViewTextBoxColumn_164
			});
			this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_8;
			dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle39.BackColor = SystemColors.Window;
			dataGridViewCellStyle39.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle39.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle39.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle39.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle39.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_1.DefaultCellStyle = dataGridViewCellStyle39;
			this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_1.Location = new Point(3, 25);
			this.dataGridViewExcelFilter_1.MultiSelect = false;
			this.dataGridViewExcelFilter_1.Name = "dgvPerambulation";
			this.dataGridViewExcelFilter_1.ReadOnly = true;
			dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle40.BackColor = SystemColors.Control;
			dataGridViewCellStyle40.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle40.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle40.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle40.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle40.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_1.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
			this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_1.Size = new Size(758, 174);
			this.dataGridViewExcelFilter_1.TabIndex = 1;
			this.dataGridViewExcelFilter_1.CellContentClick += this.dataGridViewExcelFilter_1_CellContentClick;
			this.dataGridViewCheckBoxColumn_2.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_2.HeaderText = "DeletedPeram";
			this.dataGridViewCheckBoxColumn_2.Name = "deletedPeram";
			this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_159.DataPropertyName = "id";
			dataGridViewCellStyle41.Format = "D";
			dataGridViewCellStyle41.NullValue = null;
			this.dataGridViewTextBoxColumn_159.DefaultCellStyle = dataGridViewCellStyle41;
			this.dataGridViewTextBoxColumn_159.HeaderText = "idPeram";
			this.dataGridViewTextBoxColumn_159.Name = "idPeram";
			this.dataGridViewTextBoxColumn_159.ReadOnly = true;
			this.dataGridViewTextBoxColumn_159.Visible = false;
			this.dataGridViewTextBoxColumn_160.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_160.HeaderText = "idObjListPeram";
			this.dataGridViewTextBoxColumn_160.Name = "idObjListPeram";
			this.dataGridViewTextBoxColumn_160.ReadOnly = true;
			this.dataGridViewTextBoxColumn_160.Visible = false;
			this.dataGridViewTextBoxColumn_161.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn_161.HeaderText = "Дата обхода";
			this.dataGridViewTextBoxColumn_161.Name = "datePeram";
			this.dataGridViewTextBoxColumn_161.ReadOnly = true;
			this.dataGridViewTextBoxColumn_162.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_162.DataPropertyName = "Defect";
			this.dataGridViewTextBoxColumn_162.HeaderText = "Обнаружение неисправности";
			this.dataGridViewTextBoxColumn_162.Name = "defectPeram";
			this.dataGridViewTextBoxColumn_162.ReadOnly = true;
			this.dataGridViewTextBoxColumn_163.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_163.DataPropertyName = "Repair";
			this.dataGridViewTextBoxColumn_163.HeaderText = "Меры, принятые по устранению неисправности";
			this.dataGridViewTextBoxColumn_163.Name = "repairPeram";
			this.dataGridViewTextBoxColumn_163.ReadOnly = true;
			this.dataGridViewTextBoxColumn_164.DataPropertyName = "DateIn";
			this.dataGridViewTextBoxColumn_164.HeaderText = "DateInPeram";
			this.dataGridViewTextBoxColumn_164.Name = "dateInPeram";
			this.dataGridViewTextBoxColumn_164.ReadOnly = true;
			this.dataGridViewTextBoxColumn_164.Visible = false;
			this.bindingSource_8.DataMember = "tP_CabPerambulation";
			this.bindingSource_8.DataSource = this.dsPassport_0;
			this.tabPage_10.Controls.Add(this.tableLayoutPanel_13);
			this.tabPage_10.Location = new Point(4, 22);
			this.tabPage_10.Name = "tpAirLineSpan";
			this.tabPage_10.Padding = new Padding(3);
			this.tabPage_10.Size = new Size(770, 208);
			this.tabPage_10.TabIndex = 14;
			this.tabPage_10.Text = "Пролеты";
			this.tabPage_10.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_13.ColumnCount = 1;
			this.tableLayoutPanel_13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_13.Controls.Add(this.toolStrip_12, 0, 0);
			this.tableLayoutPanel_13.Controls.Add(this.treeDataGridView_0, 0, 1);
			this.tableLayoutPanel_13.Dock = DockStyle.Fill;
			this.tableLayoutPanel_13.Location = new Point(3, 3);
			this.tableLayoutPanel_13.Name = "tlpLineSpan";
			this.tableLayoutPanel_13.RowCount = 2;
			this.tableLayoutPanel_13.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_13.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_13.Size = new Size(764, 202);
			this.tableLayoutPanel_13.TabIndex = 9;
			this.toolStrip_12.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_50,
				this.toolStripButton_51,
				this.toolStripSeparator_49,
				this.toolStripButton_52,
				this.toolStripSeparator_50,
				this.toolStripButton_53,
				this.toolStripSeparator_64,
				this.toolStripButton_67
			});
			this.toolStrip_12.Location = new Point(0, 0);
			this.toolStrip_12.Name = "tsLineSpan";
			this.toolStrip_12.Size = new Size(764, 25);
			this.toolStrip_12.TabIndex = 0;
			this.toolStrip_12.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_50.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_50.Image = Resources.ElementAdd;
			this.toolStripButton_50.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_50.Name = "tsbAddLineSpan";
			this.toolStripButton_50.Size = new Size(23, 22);
			this.toolStripButton_50.Text = "Добавить";
			this.toolStripButton_50.Click += this.toolStripMenuItem_47_Click;
			this.toolStripButton_51.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_51.Image = Resources.ElementEdit;
			this.toolStripButton_51.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_51.Name = "tsbEditLineSpan";
			this.toolStripButton_51.Size = new Size(23, 22);
			this.toolStripButton_51.Text = "Редактировать";
			this.toolStripButton_51.Click += this.toolStripMenuItem_48_Click;
			this.toolStripSeparator_49.Name = "tssDeleteLineSpan";
			this.toolStripSeparator_49.Size = new Size(6, 25);
			this.toolStripButton_52.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_52.Image = Resources.ElementDel;
			this.toolStripButton_52.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_52.Name = "tsbDeleteLineSpan";
			this.toolStripButton_52.Size = new Size(23, 22);
			this.toolStripButton_52.Text = "Удалить";
			this.toolStripButton_52.Click += this.toolStripMenuItem_49_Click;
			this.toolStripSeparator_50.Name = "tssRefreshLineSpan";
			this.toolStripSeparator_50.Size = new Size(6, 25);
			this.toolStripButton_53.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_53.Image = Resources.refresh_16;
			this.toolStripButton_53.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_53.Name = "tsbRefreshLineSpan";
			this.toolStripButton_53.Size = new Size(23, 22);
			this.toolStripButton_53.Text = "Обновить";
			this.toolStripButton_53.Click += this.toolStripMenuItem_50_Click;
			this.toolStripSeparator_64.Name = "toolStripSeparator23";
			this.toolStripSeparator_64.Size = new Size(6, 25);
			this.toolStripButton_67.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_67.Image = Resources.Gurnal;
			this.toolStripButton_67.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_67.Name = "tsbLineSpanHistory";
			this.toolStripButton_67.Size = new Size(23, 22);
			this.toolStripButton_67.Text = "История паспортов объекта";
			this.toolStripButton_67.Click += this.toolStripButton_67_Click;
			this.treeDataGridView_0.AllowUserToAddRows = false;
			this.treeDataGridView_0.AllowUserToDeleteRows = false;
			this.treeDataGridView_0.BackgroundColor = Color.White;
			dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle42.BackColor = SystemColors.Control;
			dataGridViewCellStyle42.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle42.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle42.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle42.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
			this.treeDataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
			this.treeDataGridView_0.ColumnHeadersHeight = 34;
			this.treeDataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.treeGridColumn_0,
				this.treeGridColumn_1,
				this.treeGridColumn_2,
				this.treeGridColumn_3,
				this.treeGridColumn_4,
				this.dataGridViewTextBoxColumn_165,
				this.dataGridViewTextBoxColumn_166,
				this.dataGridViewTextBoxColumn_167,
				this.dataGridViewTextBoxColumn_168,
				this.dataGridViewTextBoxColumn_169,
				this.dataGridViewTextBoxColumn_170,
				this.dataGridViewTextBoxColumn_171,
				this.dataGridViewTextBoxColumn_172,
				this.dataGridViewTextBoxColumn_173,
				this.dataGridViewTextBoxColumn_174
			});
			this.treeDataGridView_0.ContextMenuStrip = this.contextMenuStrip_8;
			dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle43.BackColor = SystemColors.Window;
			dataGridViewCellStyle43.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle43.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle43.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle43.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle43.WrapMode = DataGridViewTriState.True;
			this.treeDataGridView_0.DefaultCellStyle = dataGridViewCellStyle43;
			this.treeDataGridView_0.Dock = DockStyle.Fill;
			this.treeDataGridView_0.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.treeDataGridView_0.ImageList = null;
			this.treeDataGridView_0.Location = new Point(3, 28);
			this.treeDataGridView_0.MultiSelect = false;
			this.treeDataGridView_0.Name = "trvDgvSpan";
			dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle44.BackColor = SystemColors.Control;
			dataGridViewCellStyle44.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle44.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle44.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle44.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle44.WrapMode = DataGridViewTriState.True;
			this.treeDataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
			this.treeDataGridView_0.RowHeadersVisible = false;
			this.treeDataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.treeDataGridView_0.Size = new Size(758, 171);
			this.treeDataGridView_0.TabIndex = 1;
			this.treeDataGridView_0.CellPainting += this.treeDataGridView_0_CellPainting;
			this.treeGridColumn_0.DataPropertyName = "id";
			this.treeGridColumn_0.DefaultNodeImage = null;
			this.treeGridColumn_0.HeaderText = "idSpan";
			this.treeGridColumn_0.Name = "idSpan";
			this.treeGridColumn_0.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_0.Visible = false;
			this.treeGridColumn_1.DataPropertyName = "idObjList";
			this.treeGridColumn_1.DefaultNodeImage = null;
			this.treeGridColumn_1.HeaderText = "idObjListSpan";
			this.treeGridColumn_1.Name = "idObjListSpan";
			this.treeGridColumn_1.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_1.Visible = false;
			this.treeGridColumn_2.DataPropertyName = "idPoleFirst";
			this.treeGridColumn_2.DefaultNodeImage = null;
			this.treeGridColumn_2.HeaderText = "idPoleFirstSpan";
			this.treeGridColumn_2.Name = "idPoleFirstSpan";
			this.treeGridColumn_2.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_2.Visible = false;
			this.treeGridColumn_3.DataPropertyName = "idPoleSecond";
			this.treeGridColumn_3.DefaultNodeImage = null;
			this.treeGridColumn_3.HeaderText = "idPoleSecondSpan";
			this.treeGridColumn_3.Name = "idPoleSecondSpan";
			this.treeGridColumn_3.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_3.Visible = false;
			this.treeGridColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.treeGridColumn_4.DataPropertyName = "Number";
			this.treeGridColumn_4.DefaultNodeImage = null;
			this.treeGridColumn_4.HeaderText = "Номер пролета";
			this.treeGridColumn_4.Name = "NumberSpan";
			this.treeGridColumn_4.Resizable = DataGridViewTriState.True;
			this.treeGridColumn_4.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_4.Width = 82;
			this.dataGridViewTextBoxColumn_165.DataPropertyName = "NamePoleFirst";
			this.dataGridViewTextBoxColumn_165.HeaderText = "Опора";
			this.dataGridViewTextBoxColumn_165.Name = "NamePoleFirstSpan";
			this.dataGridViewTextBoxColumn_165.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_165.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_165.Width = 80;
			this.dataGridViewTextBoxColumn_166.DataPropertyName = "NamePoleSecond";
			this.dataGridViewTextBoxColumn_166.HeaderText = "Опора";
			this.dataGridViewTextBoxColumn_166.Name = "NamePoleSecondSpan";
			this.dataGridViewTextBoxColumn_166.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_166.Width = 80;
			this.dataGridViewTextBoxColumn_167.DataPropertyName = "CableMakeup";
			this.dataGridViewTextBoxColumn_167.HeaderText = "Марка провода";
			this.dataGridViewTextBoxColumn_167.Name = "CableMakeupSpan";
			this.dataGridViewTextBoxColumn_167.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_168.DataPropertyName = "Voltage";
			this.dataGridViewTextBoxColumn_168.HeaderText = "Рабочее напряжение";
			this.dataGridViewTextBoxColumn_168.Name = "VoltageSpan";
			this.dataGridViewTextBoxColumn_168.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_168.Width = 70;
			this.dataGridViewTextBoxColumn_169.DataPropertyName = "Wires";
			this.dataGridViewTextBoxColumn_169.HeaderText = "Количество жил";
			this.dataGridViewTextBoxColumn_169.Name = "WiresSpan";
			this.dataGridViewTextBoxColumn_169.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_169.Width = 70;
			this.dataGridViewTextBoxColumn_170.DataPropertyName = "CrossSection";
			this.dataGridViewTextBoxColumn_170.HeaderText = "Сечение жил";
			this.dataGridViewTextBoxColumn_170.Name = "CrossSectionSpan";
			this.dataGridViewTextBoxColumn_170.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_170.Width = 60;
			this.dataGridViewTextBoxColumn_171.DataPropertyName = "Length";
			this.dataGridViewTextBoxColumn_171.HeaderText = "Длина";
			this.dataGridViewTextBoxColumn_171.Name = "LengthSpan";
			this.dataGridViewTextBoxColumn_171.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_171.Width = 60;
			this.dataGridViewTextBoxColumn_172.DataPropertyName = "YearCommissioning";
			this.dataGridViewTextBoxColumn_172.HeaderText = "Год ввода в эксплуатацию";
			this.dataGridViewTextBoxColumn_172.Name = "YearCommissioningSpan";
			this.dataGridViewTextBoxColumn_172.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_173.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_173.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_173.Name = "CommentSpan";
			this.dataGridViewTextBoxColumn_173.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_173.Visible = false;
			this.dataGridViewTextBoxColumn_174.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_174.HeaderText = "DeletedSpan";
			this.dataGridViewTextBoxColumn_174.Name = "DeletedSpan";
			this.dataGridViewTextBoxColumn_174.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_174.Visible = false;
			this.contextMenuStrip_8.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_47,
				this.toolStripMenuItem_48,
				this.toolStripSeparator_53,
				this.toolStripMenuItem_49,
				this.toolStripSeparator_54,
				this.toolStripMenuItem_50
			});
			this.contextMenuStrip_8.Name = "cmsBuildRepair";
			this.contextMenuStrip_8.Size = new Size(155, 104);
			this.toolStripMenuItem_47.Image = Resources.ElementAdd;
			this.toolStripMenuItem_47.Name = "tsmiAirLineSpanAdd";
			this.toolStripMenuItem_47.Size = new Size(154, 22);
			this.toolStripMenuItem_47.Text = "Добавить";
			this.toolStripMenuItem_47.Click += this.toolStripMenuItem_47_Click;
			this.toolStripMenuItem_48.Image = Resources.ElementEdit;
			this.toolStripMenuItem_48.Name = "tsmiAirLineSpanEdit";
			this.toolStripMenuItem_48.Size = new Size(154, 22);
			this.toolStripMenuItem_48.Text = "Редактировать";
			this.toolStripMenuItem_48.Click += this.toolStripMenuItem_48_Click;
			this.toolStripSeparator_53.Name = "tssAirLineSpanDelete";
			this.toolStripSeparator_53.Size = new Size(151, 6);
			this.toolStripMenuItem_49.Image = Resources.ElementDel;
			this.toolStripMenuItem_49.Name = "tsmiAirLineSpanDelete";
			this.toolStripMenuItem_49.Size = new Size(154, 22);
			this.toolStripMenuItem_49.Text = "Удалить";
			this.toolStripMenuItem_49.Click += this.toolStripMenuItem_49_Click;
			this.toolStripSeparator_54.Name = "tssAirLineSpanRefresh";
			this.toolStripSeparator_54.Size = new Size(151, 6);
			this.toolStripMenuItem_50.Image = Resources.refresh_16;
			this.toolStripMenuItem_50.Name = "tsmiAirLineSpanRefresh";
			this.toolStripMenuItem_50.Size = new Size(154, 22);
			this.toolStripMenuItem_50.Text = "Обновить";
			this.toolStripMenuItem_50.Click += this.toolStripMenuItem_50_Click;
			this.tabPage_11.Controls.Add(this.tableLayoutPanel_14);
			this.tabPage_11.Location = new Point(4, 22);
			this.tabPage_11.Name = "tpAirLinePole";
			this.tabPage_11.Padding = new Padding(3);
			this.tabPage_11.Size = new Size(770, 208);
			this.tabPage_11.TabIndex = 15;
			this.tabPage_11.Text = "Опоры";
			this.tabPage_11.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_14.ColumnCount = 1;
			this.tableLayoutPanel_14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_14.Controls.Add(this.dataGridView_10, 0, 1);
			this.tableLayoutPanel_14.Controls.Add(this.toolStrip_13, 0, 0);
			this.tableLayoutPanel_14.Dock = DockStyle.Fill;
			this.tableLayoutPanel_14.Location = new Point(3, 3);
			this.tableLayoutPanel_14.Name = "tlpLinePole";
			this.tableLayoutPanel_14.RowCount = 2;
			this.tableLayoutPanel_14.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_14.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_14.Size = new Size(764, 202);
			this.tableLayoutPanel_14.TabIndex = 10;
			this.dataGridView_10.AllowUserToAddRows = false;
			this.dataGridView_10.AllowUserToDeleteRows = false;
			this.dataGridView_10.AllowUserToResizeRows = false;
			this.dataGridView_10.BackgroundColor = Color.White;
			dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle45.BackColor = SystemColors.Control;
			dataGridViewCellStyle45.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle45.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle45.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle45.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle45.WrapMode = DataGridViewTriState.True;
			this.dataGridView_10.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
			this.dataGridView_10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_10.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_211,
				this.dataGridViewTextBoxColumn_212,
				this.dataGridViewTextBoxColumn_213,
				this.dataGridViewTextBoxColumn_214,
				this.dataGridViewTextBoxColumn_215,
				this.dataGridViewTextBoxColumn_216
			});
			this.dataGridView_10.ContextMenuStrip = this.contextMenuStrip_9;
			dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle46.BackColor = SystemColors.Window;
			dataGridViewCellStyle46.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle46.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle46.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle46.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle46.WrapMode = DataGridViewTriState.True;
			this.dataGridView_10.DefaultCellStyle = dataGridViewCellStyle46;
			this.dataGridView_10.Dock = DockStyle.Fill;
			this.dataGridView_10.Location = new Point(3, 28);
			this.dataGridView_10.MultiSelect = false;
			this.dataGridView_10.Name = "dgvLinePole";
			this.dataGridView_10.ReadOnly = true;
			dataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle47.BackColor = SystemColors.Control;
			dataGridViewCellStyle47.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle47.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle47.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle47.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle47.WrapMode = DataGridViewTriState.True;
			this.dataGridView_10.RowHeadersDefaultCellStyle = dataGridViewCellStyle47;
			this.dataGridView_10.RowHeadersVisible = false;
			this.dataGridView_10.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_10.Size = new Size(758, 171);
			this.dataGridView_10.TabIndex = 1;
			this.dataGridViewTextBoxColumn_211.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_211.HeaderText = "idPole";
			this.dataGridViewTextBoxColumn_211.Name = "idPole";
			this.dataGridViewTextBoxColumn_211.ReadOnly = true;
			this.dataGridViewTextBoxColumn_211.Visible = false;
			this.dataGridViewTextBoxColumn_212.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_212.HeaderText = "idObjListPole";
			this.dataGridViewTextBoxColumn_212.Name = "idObjListPole";
			this.dataGridViewTextBoxColumn_212.ReadOnly = true;
			this.dataGridViewTextBoxColumn_212.Visible = false;
			this.dataGridViewTextBoxColumn_213.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_213.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_213.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_213.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn_213.Name = "NamePole";
			this.dataGridViewTextBoxColumn_213.ReadOnly = true;
			this.dataGridViewTextBoxColumn_214.DataPropertyName = "idEquipment";
			this.dataGridViewTextBoxColumn_214.HeaderText = "idEquipment";
			this.dataGridViewTextBoxColumn_214.Name = "idEquipmentdgvLinePole";
			this.dataGridViewTextBoxColumn_214.ReadOnly = true;
			this.dataGridViewTextBoxColumn_214.Visible = false;
			this.dataGridViewTextBoxColumn_215.DataPropertyName = "countBranch";
			this.dataGridViewTextBoxColumn_215.HeaderText = "Кол-во отводов";
			this.dataGridViewTextBoxColumn_215.MinimumWidth = 20;
			this.dataGridViewTextBoxColumn_215.Name = "countBranchDgvLinePole";
			this.dataGridViewTextBoxColumn_215.ReadOnly = true;
			this.dataGridViewTextBoxColumn_216.DataPropertyName = "countObjBranch";
			this.dataGridViewTextBoxColumn_216.HeaderText = "Кол-во отбъектов на отводах";
			this.dataGridViewTextBoxColumn_216.MinimumWidth = 20;
			this.dataGridViewTextBoxColumn_216.Name = "countObjBranchDgvLinePole";
			this.dataGridViewTextBoxColumn_216.ReadOnly = true;
			this.contextMenuStrip_9.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_51,
				this.toolStripMenuItem_52,
				this.toolStripSeparator_55,
				this.toolStripMenuItem_53,
				this.toolStripSeparator_56,
				this.toolStripMenuItem_54
			});
			this.contextMenuStrip_9.Name = "cmsBuildRepair";
			this.contextMenuStrip_9.Size = new Size(155, 104);
			this.toolStripMenuItem_51.Image = Resources.ElementAdd;
			this.toolStripMenuItem_51.Name = "tsmiAirLinePoleAdd";
			this.toolStripMenuItem_51.Size = new Size(154, 22);
			this.toolStripMenuItem_51.Text = "Добавить";
			this.toolStripMenuItem_51.Click += this.toolStripButton_54_Click;
			this.toolStripMenuItem_52.Image = Resources.ElementEdit;
			this.toolStripMenuItem_52.Name = "tsmiAirLinePoleEdit";
			this.toolStripMenuItem_52.Size = new Size(154, 22);
			this.toolStripMenuItem_52.Text = "Редактировать";
			this.toolStripMenuItem_52.Click += this.toolStripButton_55_Click;
			this.toolStripSeparator_55.Name = "tssAirLinePoleDelete";
			this.toolStripSeparator_55.Size = new Size(151, 6);
			this.toolStripMenuItem_53.Image = Resources.ElementDel;
			this.toolStripMenuItem_53.Name = "tsmiAirLinePoleDelete";
			this.toolStripMenuItem_53.Size = new Size(154, 22);
			this.toolStripMenuItem_53.Text = "Удалить";
			this.toolStripMenuItem_53.Click += this.toolStripButton_56_Click;
			this.toolStripSeparator_56.Name = "tssAirLinePoleRefresh";
			this.toolStripSeparator_56.Size = new Size(151, 6);
			this.toolStripMenuItem_54.Image = Resources.refresh_16;
			this.toolStripMenuItem_54.Name = "tsmiAirLinePoleRefresh";
			this.toolStripMenuItem_54.Size = new Size(154, 22);
			this.toolStripMenuItem_54.Text = "Обновить";
			this.toolStripMenuItem_54.Click += this.toolStripButton_57_Click;
			this.toolStrip_13.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_54,
				this.toolStripButton_55,
				this.toolStripSeparator_51,
				this.toolStripButton_56,
				this.toolStripSeparator_52,
				this.toolStripButton_57,
				this.toolStripSeparator_65,
				this.toolStripButton_68
			});
			this.toolStrip_13.Location = new Point(0, 0);
			this.toolStrip_13.Name = "tsLinePole";
			this.toolStrip_13.Size = new Size(764, 25);
			this.toolStrip_13.TabIndex = 0;
			this.toolStrip_13.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_54.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_54.Image = Resources.ElementAdd;
			this.toolStripButton_54.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_54.Name = "tsbAddLinePole";
			this.toolStripButton_54.Size = new Size(23, 22);
			this.toolStripButton_54.Text = "Добавить";
			this.toolStripButton_54.Click += this.toolStripButton_54_Click;
			this.toolStripButton_55.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_55.Image = Resources.ElementEdit;
			this.toolStripButton_55.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_55.Name = "tsbEditLinePole";
			this.toolStripButton_55.Size = new Size(23, 22);
			this.toolStripButton_55.Text = "Редактировать";
			this.toolStripButton_55.Click += this.toolStripButton_55_Click;
			this.toolStripSeparator_51.Name = "tssDeleteLinePole";
			this.toolStripSeparator_51.Size = new Size(6, 25);
			this.toolStripButton_56.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_56.Image = Resources.ElementDel;
			this.toolStripButton_56.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_56.Name = "tsbDeleteLinePole";
			this.toolStripButton_56.Size = new Size(23, 22);
			this.toolStripButton_56.Text = "Удалить";
			this.toolStripButton_56.Click += this.toolStripButton_56_Click;
			this.toolStripSeparator_52.Name = "tssRefreshLinePole";
			this.toolStripSeparator_52.Size = new Size(6, 25);
			this.toolStripButton_57.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_57.Image = Resources.refresh_16;
			this.toolStripButton_57.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_57.Name = "tsbRefreshLinePole";
			this.toolStripButton_57.Size = new Size(23, 22);
			this.toolStripButton_57.Text = "Обновить";
			this.toolStripButton_57.Click += this.toolStripButton_57_Click;
			this.toolStripSeparator_65.Name = "toolStripSeparator24";
			this.toolStripSeparator_65.Size = new Size(6, 25);
			this.toolStripButton_68.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_68.Image = Resources.Gurnal;
			this.toolStripButton_68.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_68.Name = "tsbLinePoleHistory";
			this.toolStripButton_68.Size = new Size(23, 22);
			this.toolStripButton_68.Text = "История паспортов объекта";
			this.toolStripButton_68.Click += this.toolStripButton_68_Click;
			this.tabPage_13.Controls.Add(this.toolStrip_15);
			this.tabPage_13.Controls.Add(this.tableLayoutPanel_16);
			this.tabPage_13.Location = new Point(4, 22);
			this.tabPage_13.Name = "tpTehConnect";
			this.tabPage_13.Padding = new Padding(3);
			this.tabPage_13.Size = new Size(770, 208);
			this.tabPage_13.TabIndex = 17;
			this.tabPage_13.Text = "Тех. присоединение";
			this.tabPage_13.UseVisualStyleBackColor = true;
			this.toolStrip_15.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_69,
				this.toolStripButton_70,
				this.toolStripSeparator_66,
				this.toolStripButton_71,
				this.toolStripSeparator_67,
				this.toolStripButton_72
			});
			this.toolStrip_15.Location = new Point(3, 3);
			this.toolStrip_15.Name = "tsTehConnect";
			this.toolStrip_15.Size = new Size(764, 25);
			this.toolStrip_15.TabIndex = 1;
			this.toolStrip_15.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_69.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_69.Image = Resources.ElementAdd;
			this.toolStripButton_69.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_69.Name = "tsbTehConnectAdd";
			this.toolStripButton_69.Size = new Size(23, 22);
			this.toolStripButton_69.Text = "Добавить";
			this.toolStripButton_70.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_70.Image = Resources.ElementEdit;
			this.toolStripButton_70.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_70.Name = "tsbTehConnectEdit";
			this.toolStripButton_70.Size = new Size(23, 22);
			this.toolStripButton_70.Text = "Редактировать";
			this.toolStripSeparator_66.Name = "toolStripSeparator25";
			this.toolStripSeparator_66.Size = new Size(6, 25);
			this.toolStripButton_71.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_71.Image = Resources.ElementDel;
			this.toolStripButton_71.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_71.Name = "tsbTehConnectDelete";
			this.toolStripButton_71.Size = new Size(23, 22);
			this.toolStripButton_71.Text = "Удалить";
			this.toolStripSeparator_67.Name = "toolStripSeparator26";
			this.toolStripSeparator_67.Size = new Size(6, 25);
			this.toolStripButton_72.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_72.Image = Resources.refresh_16;
			this.toolStripButton_72.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_72.Name = "tsbTehConnectRefresh";
			this.toolStripButton_72.Size = new Size(23, 22);
			this.toolStripButton_72.Text = "Обновить";
			this.tableLayoutPanel_16.ColumnCount = 1;
			this.tableLayoutPanel_16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_16.Controls.Add(this.dataGridViewExcelFilter_2, 0, 1);
			this.tableLayoutPanel_16.Dock = DockStyle.Fill;
			this.tableLayoutPanel_16.Location = new Point(3, 3);
			this.tableLayoutPanel_16.Name = "tlpTehConnect";
			this.tableLayoutPanel_16.RowCount = 2;
			this.tableLayoutPanel_16.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.tableLayoutPanel_16.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_16.Size = new Size(764, 202);
			this.tableLayoutPanel_16.TabIndex = 0;
			this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_2.BackgroundColor = Color.White;
			dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle48.BackColor = SystemColors.Control;
			dataGridViewCellStyle48.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle48.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle48.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle48.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle48.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle48;
			this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_2.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_3,
				this.dataGridViewTextBoxColumn_175,
				this.dataGridViewTextBoxColumn_176,
				this.dataGridViewTextBoxColumn_177,
				this.dataGridViewTextBoxColumn_178,
				this.dataGridViewTextBoxColumn_179,
				this.dataGridViewTextBoxColumn_180,
				this.dataGridViewTextBoxColumn_181,
				this.dataGridViewTextBoxColumn_182,
				this.dataGridViewTextBoxColumn_183,
				this.dataGridViewTextBoxColumn_184
			});
			this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_9;
			dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle49.BackColor = SystemColors.Window;
			dataGridViewCellStyle49.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle49.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle49.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle49.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle49.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_2.DefaultCellStyle = dataGridViewCellStyle49;
			this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_2.Location = new Point(3, 25);
			this.dataGridViewExcelFilter_2.MultiSelect = false;
			this.dataGridViewExcelFilter_2.Name = "dgvTehConnect";
			this.dataGridViewExcelFilter_2.ReadOnly = true;
			dataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle50.BackColor = SystemColors.Control;
			dataGridViewCellStyle50.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle50.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle50.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle50.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle50.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_2.RowHeadersDefaultCellStyle = dataGridViewCellStyle50;
			this.dataGridViewExcelFilter_2.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_2.Size = new Size(758, 174);
			this.dataGridViewExcelFilter_2.TabIndex = 0;
			this.dataGridViewCheckBoxColumn_3.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_3.HeaderText = "Deleted";
			this.dataGridViewCheckBoxColumn_3.Name = "deletedDataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_3.Visible = false;
			this.dataGridViewTextBoxColumn_175.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_175.HeaderText = "id";
			this.dataGridViewTextBoxColumn_175.Name = "idDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_175.ReadOnly = true;
			this.dataGridViewTextBoxColumn_175.Visible = false;
			this.dataGridViewTextBoxColumn_176.DataPropertyName = "idSubstation";
			this.dataGridViewTextBoxColumn_176.HeaderText = "idSubstation";
			this.dataGridViewTextBoxColumn_176.Name = "idSubstationDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_176.ReadOnly = true;
			this.dataGridViewTextBoxColumn_176.Visible = false;
			this.dataGridViewTextBoxColumn_177.DataPropertyName = "NameSubstation";
			this.dataGridViewTextBoxColumn_177.HeaderText = "Подстанция";
			this.dataGridViewTextBoxColumn_177.Name = "nameSubstationDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_177.ReadOnly = true;
			this.dataGridViewTextBoxColumn_178.DataPropertyName = "idTransf";
			this.dataGridViewTextBoxColumn_178.HeaderText = "idTransf";
			this.dataGridViewTextBoxColumn_178.Name = "idTransfDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_178.ReadOnly = true;
			this.dataGridViewTextBoxColumn_178.Visible = false;
			this.dataGridViewTextBoxColumn_179.DataPropertyName = "NameTransf";
			this.dataGridViewTextBoxColumn_179.HeaderText = "Трансформатор";
			this.dataGridViewTextBoxColumn_179.Name = "nameTransfDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_179.ReadOnly = true;
			this.dataGridViewTextBoxColumn_180.DataPropertyName = "Dogovor";
			this.dataGridViewTextBoxColumn_180.HeaderText = "Номер договора";
			this.dataGridViewTextBoxColumn_180.Name = "dogovorDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_180.ReadOnly = true;
			this.dataGridViewTextBoxColumn_181.DataPropertyName = "dateBegin";
			this.dataGridViewTextBoxColumn_181.HeaderText = "Дата закл. договора";
			this.dataGridViewTextBoxColumn_181.Name = "dateBeginDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_181.ReadOnly = true;
			this.dataGridViewTextBoxColumn_182.DataPropertyName = "dateEnd";
			this.dataGridViewTextBoxColumn_182.HeaderText = "Дата окон. договора";
			this.dataGridViewTextBoxColumn_182.Name = "dateEndDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_182.ReadOnly = true;
			this.dataGridViewTextBoxColumn_183.DataPropertyName = "Company";
			this.dataGridViewTextBoxColumn_183.HeaderText = "Наименование потребителя";
			this.dataGridViewTextBoxColumn_183.Name = "companyDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_183.ReadOnly = true;
			this.dataGridViewTextBoxColumn_184.DataPropertyName = "MaxPower";
			this.dataGridViewTextBoxColumn_184.HeaderText = "Максимальная мощность, кВА";
			this.dataGridViewTextBoxColumn_184.Name = "maxPowerDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_184.ReadOnly = true;
			this.dataGridViewTextBoxColumn_184.Width = 110;
			this.bindingSource_9.DataMember = "vP_TehConnect";
			this.bindingSource_9.DataSource = this.dsPassport_0;
			this.contextMenuStrip_7.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_43,
				this.toolStripMenuItem_44,
				this.toolStripSeparator_47,
				this.toolStripMenuItem_45,
				this.toolStripSeparator_48,
				this.toolStripMenuItem_46
			});
			this.contextMenuStrip_7.Name = "cmsBuildRepair";
			this.contextMenuStrip_7.Size = new Size(155, 104);
			this.toolStripMenuItem_43.Image = Resources.ElementAdd;
			this.toolStripMenuItem_43.Name = "tsmiAddPeram";
			this.toolStripMenuItem_43.Size = new Size(154, 22);
			this.toolStripMenuItem_43.Text = "Добавить";
			this.toolStripMenuItem_43.Click += this.toolStripMenuItem_43_Click;
			this.toolStripMenuItem_44.Image = Resources.ElementEdit;
			this.toolStripMenuItem_44.Name = "tsmiEditPeram";
			this.toolStripMenuItem_44.Size = new Size(154, 22);
			this.toolStripMenuItem_44.Text = "Редактировать";
			this.toolStripMenuItem_44.Click += this.toolStripMenuItem_44_Click;
			this.toolStripSeparator_47.Name = "toolStripSeparator14";
			this.toolStripSeparator_47.Size = new Size(151, 6);
			this.toolStripMenuItem_45.Image = Resources.ElementDel;
			this.toolStripMenuItem_45.Name = "tsmiDeletePeram";
			this.toolStripMenuItem_45.Size = new Size(154, 22);
			this.toolStripMenuItem_45.Text = "Удалить";
			this.toolStripMenuItem_45.Click += this.toolStripMenuItem_45_Click;
			this.toolStripSeparator_48.Name = "toolStripSeparator15";
			this.toolStripSeparator_48.Size = new Size(151, 6);
			this.toolStripMenuItem_46.Image = Resources.refresh_16;
			this.toolStripMenuItem_46.Name = "tsmiRefreshPeram";
			this.toolStripMenuItem_46.Size = new Size(154, 22);
			this.toolStripMenuItem_46.Text = "Обновить";
			this.toolStripMenuItem_46.Click += this.toolStripMenuItem_46_Click;
			this.bindingSource_1.DataMember = "tP_BuildSubsRepair";
			this.bindingSource_1.DataSource = this.bindingSource_0;
			this.bindingSource_0.DataSource = this.dsPassport_0;
			this.bindingSource_0.Position = 0;
			this.dsDocuments_0.DataSetName = "dsDocuments";
			this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dataGridViewComboBoxColumn_0.DataPropertyName = "DoorType";
			this.dataGridViewComboBoxColumn_0.DataSource = this.dsPassport_0;
			this.dataGridViewComboBoxColumn_0.DisplayMember = "tP_ValueList.Name";
			this.dataGridViewComboBoxColumn_0.HeaderText = "Тип двери";
			this.dataGridViewComboBoxColumn_0.Name = "dataGridViewComboBoxColumn1";
			this.dataGridViewComboBoxColumn_0.ValueMember = "tP_ValueList.id";
			this.dataGridViewComboBoxColumn_1.DataPropertyName = "Company";
			this.dataGridViewComboBoxColumn_1.DataSource = this.dsPassport_0;
			this.dataGridViewComboBoxColumn_1.DisplayMember = "tAbn.Name";
			this.dataGridViewComboBoxColumn_1.HeaderText = "Организация-подрядчик";
			this.dataGridViewComboBoxColumn_1.Name = "dataGridViewComboBoxColumn2";
			this.dataGridViewComboBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewComboBoxColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewComboBoxColumn_1.ValueMember = "tAbn.id";
			this.dataGridViewComboBoxColumn_1.Width = 140;
			this.bindingSource_2.DataMember = "tP_ValueList";
			this.bindingSource_2.DataSource = this.dsPassport_0;
			this.bindingSource_2.Sort = "Name";
			this.bindingSource_3.DataMember = "tAbn";
			this.bindingSource_3.DataSource = this.dsPassport_0;
			this.bindingSource_4.DataMember = "tP_CabProtocol";
			this.bindingSource_4.DataSource = this.dsDocuments_0;
			this.bindingSource_7.DataMember = "tP_ValueLists";
			this.bindingSource_7.DataSource = this.dsPassport_0;
			this.bindingSource_7.Sort = "Name";
			this.dataGridViewTextBoxColumn_23.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_23.HeaderText = "idMove";
			this.dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_23.ReadOnly = true;
			this.dataGridViewTextBoxColumn_23.Visible = false;
			this.dataGridViewTextBoxColumn_24.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_24.HeaderText = "idObjList";
			this.dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_24.ReadOnly = true;
			this.dataGridViewTextBoxColumn_24.Visible = false;
			this.dataGridViewTextBoxColumn_25.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_25.HeaderText = "Deleted";
			this.dataGridViewTextBoxColumn_25.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_25.ReadOnly = true;
			this.dataGridViewTextBoxColumn_25.Visible = false;
			this.dataGridViewTextBoxColumn_26.DataPropertyName = "Data";
			dataGridViewCellStyle51.Format = "d";
			dataGridViewCellStyle51.NullValue = null;
			this.dataGridViewTextBoxColumn_26.DefaultCellStyle = dataGridViewCellStyle51;
			this.dataGridViewTextBoxColumn_26.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_26.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_26.ReadOnly = true;
			this.dataGridViewTextBoxColumn_27.DataPropertyName = "Action";
			this.dataGridViewTextBoxColumn_27.HeaderText = "Действие";
			this.dataGridViewTextBoxColumn_27.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_27.ReadOnly = true;
			this.dataGridViewTextBoxColumn_27.Width = 110;
			this.dataGridViewTextBoxColumn_28.DataPropertyName = "Direction";
			this.dataGridViewTextBoxColumn_28.HeaderText = "Направление";
			this.dataGridViewTextBoxColumn_28.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_28.ReadOnly = true;
			this.dataGridViewTextBoxColumn_28.Width = 120;
			this.dataGridViewTextBoxColumn_29.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_29.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_29.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_29.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_29.ReadOnly = true;
			this.dataGridViewTextBoxColumn_30.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_30.HeaderText = "SectionId";
			this.dataGridViewTextBoxColumn_30.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_30.ReadOnly = true;
			this.dataGridViewTextBoxColumn_30.Visible = false;
			this.dataGridViewTextBoxColumn_31.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_31.HeaderText = "SectionIdObjList";
			this.dataGridViewTextBoxColumn_31.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn_31.ReadOnly = true;
			this.dataGridViewTextBoxColumn_31.Visible = false;
			this.dataGridViewTextBoxColumn_32.DataPropertyName = "idPassport";
			this.dataGridViewTextBoxColumn_32.HeaderText = "SectionIdPassport";
			this.dataGridViewTextBoxColumn_32.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn_32.ReadOnly = true;
			this.dataGridViewTextBoxColumn_32.Visible = false;
			this.dataGridViewTextBoxColumn_33.DataPropertyName = "Number";
			this.dataGridViewTextBoxColumn_33.HeaderText = "Номер участка";
			this.dataGridViewTextBoxColumn_33.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn_33.ReadOnly = true;
			this.dataGridViewTextBoxColumn_33.Width = 60;
			this.dataGridViewTextBoxColumn_34.DataPropertyName = "ClutchFirst";
			this.dataGridViewTextBoxColumn_34.HeaderText = "Муфта";
			this.dataGridViewTextBoxColumn_34.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn_34.ReadOnly = true;
			this.dataGridViewTextBoxColumn_34.Width = 60;
			this.dataGridViewTextBoxColumn_35.DataPropertyName = "ClutchSecond";
			this.dataGridViewTextBoxColumn_35.HeaderText = "Муфта";
			this.dataGridViewTextBoxColumn_35.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn_35.ReadOnly = true;
			this.dataGridViewTextBoxColumn_35.Width = 60;
			this.dataGridViewTextBoxColumn_36.DataPropertyName = "makeup";
			this.dataGridViewTextBoxColumn_36.HeaderText = "Марка";
			this.dataGridViewTextBoxColumn_36.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn_36.ReadOnly = true;
			this.dataGridViewTextBoxColumn_37.DataPropertyName = "voltage";
			this.dataGridViewTextBoxColumn_37.HeaderText = "Рабочее напряжение";
			this.dataGridViewTextBoxColumn_37.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn_37.ReadOnly = true;
			this.dataGridViewTextBoxColumn_37.Width = 70;
			this.dataGridViewTextBoxColumn_38.DataPropertyName = "wires";
			this.dataGridViewTextBoxColumn_38.HeaderText = "Количество жил";
			this.dataGridViewTextBoxColumn_38.Name = "dataGridViewTextBoxColumn16";
			this.dataGridViewTextBoxColumn_38.ReadOnly = true;
			this.dataGridViewTextBoxColumn_38.Width = 70;
			this.dataGridViewTextBoxColumn_39.DataPropertyName = "crossSection";
			this.dataGridViewTextBoxColumn_39.HeaderText = "Сечение жил";
			this.dataGridViewTextBoxColumn_39.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn_39.ReadOnly = true;
			this.dataGridViewTextBoxColumn_39.Width = 60;
			this.dataGridViewTextBoxColumn_40.DataPropertyName = "length";
			this.dataGridViewTextBoxColumn_40.HeaderText = "Длина";
			this.dataGridViewTextBoxColumn_40.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn_40.ReadOnly = true;
			this.dataGridViewTextBoxColumn_40.Width = 60;
			this.dataGridViewTextBoxColumn_41.DataPropertyName = "Сonditions";
			this.dataGridViewTextBoxColumn_41.HeaderText = "Условия прокладки";
			this.dataGridViewTextBoxColumn_41.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn_41.ReadOnly = true;
			this.dataGridViewTextBoxColumn_42.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn_42.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn_42.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn_42.ReadOnly = true;
			this.dataGridViewTextBoxColumn_42.Width = 70;
			this.dataGridViewTextBoxColumn_43.DataPropertyName = "yearLaying";
			this.dataGridViewTextBoxColumn_43.HeaderText = "Год прокладки";
			this.dataGridViewTextBoxColumn_43.Name = "dataGridViewTextBoxColumn21";
			this.dataGridViewTextBoxColumn_43.ReadOnly = true;
			this.dataGridViewTextBoxColumn_43.Width = 80;
			this.dataGridViewTextBoxColumn_44.DataPropertyName = "yearCommissioning";
			this.dataGridViewTextBoxColumn_44.HeaderText = "Год ввода в эксплуатацию";
			this.dataGridViewTextBoxColumn_44.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn_44.ReadOnly = true;
			this.dataGridViewTextBoxColumn_44.Width = 90;
			this.dataGridViewTextBoxColumn_45.DataPropertyName = "yearRenovation";
			this.dataGridViewTextBoxColumn_45.HeaderText = "Год реконструкции";
			this.dataGridViewTextBoxColumn_45.Name = "dataGridViewTextBoxColumn23";
			this.dataGridViewTextBoxColumn_45.ReadOnly = true;
			this.dataGridViewTextBoxColumn_45.Width = 90;
			this.dataGridViewTextBoxColumn_46.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_46.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_46.Name = "dataGridViewTextBoxColumn24";
			this.dataGridViewTextBoxColumn_46.ReadOnly = true;
			this.dataGridViewTextBoxColumn_47.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_47.HeaderText = "SectionDeleted";
			this.dataGridViewTextBoxColumn_47.Name = "dataGridViewTextBoxColumn25";
			this.dataGridViewTextBoxColumn_47.ReadOnly = true;
			this.dataGridViewTextBoxColumn_47.Visible = false;
			this.dataGridViewTextBoxColumn_48.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_48.HeaderText = "idRepair";
			this.dataGridViewTextBoxColumn_48.Name = "dataGridViewTextBoxColumn26";
			this.dataGridViewTextBoxColumn_48.ReadOnly = true;
			this.dataGridViewTextBoxColumn_48.Visible = false;
			this.dataGridViewTextBoxColumn_49.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_49.HeaderText = "ParentIdRepair";
			this.dataGridViewTextBoxColumn_49.Name = "dataGridViewTextBoxColumn27";
			this.dataGridViewTextBoxColumn_49.ReadOnly = true;
			this.dataGridViewTextBoxColumn_49.Visible = false;
			this.dataGridViewTextBoxColumn_50.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_50.HeaderText = "idObjListRepair";
			this.dataGridViewTextBoxColumn_50.Name = "dataGridViewTextBoxColumn28";
			this.dataGridViewTextBoxColumn_50.ReadOnly = true;
			this.dataGridViewTextBoxColumn_50.Visible = false;
			this.dataGridViewTextBoxColumn_51.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_51.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_51.Name = "dataGridViewTextBoxColumn29";
			this.dataGridViewTextBoxColumn_51.ReadOnly = true;
			this.dataGridViewTextBoxColumn_51.Width = 130;
			this.dataGridViewTextBoxColumn_52.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_52.HeaderText = "NumberDocRepair";
			this.dataGridViewTextBoxColumn_52.Name = "dataGridViewTextBoxColumn30";
			this.dataGridViewTextBoxColumn_52.ReadOnly = true;
			this.dataGridViewTextBoxColumn_52.Visible = false;
			this.dataGridViewTextBoxColumn_52.Width = 150;
			this.dataGridViewTextBoxColumn_53.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_53.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_53.HeaderText = "Работа";
			this.dataGridViewTextBoxColumn_53.Name = "dataGridViewTextBoxColumn31";
			this.dataGridViewTextBoxColumn_53.ReadOnly = true;
			this.dataGridViewTextBoxColumn_54.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_54.HeaderText = "TypeDocRepair";
			this.dataGridViewTextBoxColumn_54.Name = "dataGridViewTextBoxColumn32";
			this.dataGridViewTextBoxColumn_54.ReadOnly = true;
			this.dataGridViewTextBoxColumn_54.Visible = false;
			this.dataGridViewTextBoxColumn_55.DataPropertyName = "isActive";
			this.dataGridViewTextBoxColumn_55.HeaderText = "isActiveRepair";
			this.dataGridViewTextBoxColumn_55.Name = "dataGridViewTextBoxColumn33";
			this.dataGridViewTextBoxColumn_55.ReadOnly = true;
			this.dataGridViewTextBoxColumn_55.Visible = false;
			this.dataGridViewTextBoxColumn_56.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_56.HeaderText = "DeletedRepair";
			this.dataGridViewTextBoxColumn_56.Name = "dataGridViewTextBoxColumn34";
			this.dataGridViewTextBoxColumn_56.ReadOnly = true;
			this.dataGridViewTextBoxColumn_56.Visible = false;
			this.dataGridViewTextBoxColumn_57.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_57.HeaderText = "idBalance";
			this.dataGridViewTextBoxColumn_57.Name = "dataGridViewTextBoxColumn35";
			this.dataGridViewTextBoxColumn_57.ReadOnly = true;
			this.dataGridViewTextBoxColumn_57.Visible = false;
			this.dataGridViewTextBoxColumn_58.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_58.HeaderText = "ParentIdBalance";
			this.dataGridViewTextBoxColumn_58.Name = "dataGridViewTextBoxColumn36";
			this.dataGridViewTextBoxColumn_58.ReadOnly = true;
			this.dataGridViewTextBoxColumn_58.Visible = false;
			this.dataGridViewTextBoxColumn_59.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_59.HeaderText = "idObjListBalance";
			this.dataGridViewTextBoxColumn_59.Name = "dataGridViewTextBoxColumn37";
			this.dataGridViewTextBoxColumn_59.ReadOnly = true;
			this.dataGridViewTextBoxColumn_59.Visible = false;
			this.dataGridViewTextBoxColumn_60.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_60.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_60.Name = "dataGridViewTextBoxColumn38";
			this.dataGridViewTextBoxColumn_60.ReadOnly = true;
			this.dataGridViewTextBoxColumn_60.Visible = false;
			this.dataGridViewTextBoxColumn_60.Width = 130;
			this.dataGridViewTextBoxColumn_61.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_61.HeaderText = "Номер приказа";
			this.dataGridViewTextBoxColumn_61.Name = "dataGridViewTextBoxColumn39";
			this.dataGridViewTextBoxColumn_61.ReadOnly = true;
			this.dataGridViewTextBoxColumn_61.Width = 150;
			this.dataGridViewTextBoxColumn_62.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_62.HeaderText = "От кого";
			this.dataGridViewTextBoxColumn_62.Name = "dataGridViewTextBoxColumn40";
			this.dataGridViewTextBoxColumn_62.ReadOnly = true;
			this.dataGridViewTextBoxColumn_62.Width = 150;
			this.dataGridViewTextBoxColumn_63.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_63.DataPropertyName = "Comment2";
			this.dataGridViewTextBoxColumn_63.HeaderText = "Оборудование";
			this.dataGridViewTextBoxColumn_63.Name = "dataGridViewTextBoxColumn41";
			this.dataGridViewTextBoxColumn_63.ReadOnly = true;
			this.dataGridViewTextBoxColumn_64.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_64.DataPropertyName = "isActive";
			this.dataGridViewTextBoxColumn_64.HeaderText = "isActiveBalance";
			this.dataGridViewTextBoxColumn_64.Name = "dataGridViewTextBoxColumn42";
			this.dataGridViewTextBoxColumn_64.ReadOnly = true;
			this.dataGridViewTextBoxColumn_64.Visible = false;
			this.dataGridViewTextBoxColumn_65.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_65.HeaderText = "DeletedBalance";
			this.dataGridViewTextBoxColumn_65.Name = "dataGridViewTextBoxColumn43";
			this.dataGridViewTextBoxColumn_65.ReadOnly = true;
			this.dataGridViewTextBoxColumn_65.Visible = false;
			this.dataGridViewTextBoxColumn_66.DataPropertyName = "isActive";
			this.dataGridViewTextBoxColumn_66.HeaderText = "isActiveBalance";
			this.dataGridViewTextBoxColumn_66.Name = "dataGridViewTextBoxColumn44";
			this.dataGridViewTextBoxColumn_66.ReadOnly = true;
			this.dataGridViewTextBoxColumn_66.Visible = false;
			this.dataGridViewTextBoxColumn_67.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_67.HeaderText = "DeletedBalance";
			this.dataGridViewTextBoxColumn_67.Name = "dataGridViewTextBoxColumn45";
			this.dataGridViewTextBoxColumn_67.ReadOnly = true;
			this.dataGridViewTextBoxColumn_67.Visible = false;
			this.dataGridViewTextBoxColumn_69.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_69.HeaderText = "idBuildRepair";
			this.dataGridViewTextBoxColumn_69.Name = "dataGridViewTextBoxColumn46";
			this.dataGridViewTextBoxColumn_69.ReadOnly = true;
			this.dataGridViewTextBoxColumn_69.Visible = false;
			this.dataGridViewTextBoxColumn_70.DataPropertyName = "idDocList";
			this.dataGridViewTextBoxColumn_70.HeaderText = "idDocListBuildRepair";
			this.dataGridViewTextBoxColumn_70.Name = "dataGridViewTextBoxColumn47";
			this.dataGridViewTextBoxColumn_70.ReadOnly = true;
			this.dataGridViewTextBoxColumn_70.Visible = false;
			this.dataGridViewTextBoxColumn_71.DataPropertyName = "DateFactRepair";
			this.dataGridViewTextBoxColumn_71.HeaderText = "Дата ремонта (факт.)";
			this.dataGridViewTextBoxColumn_71.Name = "dataGridViewTextBoxColumn48";
			this.dataGridViewTextBoxColumn_71.ReadOnly = true;
			this.dataGridViewTextBoxColumn_71.Width = 140;
			this.dataGridViewTextBoxColumn_72.DataPropertyName = "DateHousetopRepair";
			this.dataGridViewTextBoxColumn_72.HeaderText = "Дата ремонта крыши";
			this.dataGridViewTextBoxColumn_72.Name = "dataGridViewTextBoxColumn49";
			this.dataGridViewTextBoxColumn_72.ReadOnly = true;
			this.dataGridViewTextBoxColumn_72.Width = 140;
			this.dataGridViewTextBoxColumn_73.DataPropertyName = "DatePlanRepair";
			this.dataGridViewTextBoxColumn_73.HeaderText = "Дата ремонта (план.)";
			this.dataGridViewTextBoxColumn_73.Name = "dataGridViewTextBoxColumn50";
			this.dataGridViewTextBoxColumn_73.ReadOnly = true;
			this.dataGridViewTextBoxColumn_73.Width = 140;
			this.dataGridViewTextBoxColumn_74.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_74.HeaderText = "deletedBuildRepair";
			this.dataGridViewTextBoxColumn_74.Name = "dataGridViewTextBoxColumn51";
			this.dataGridViewTextBoxColumn_74.ReadOnly = true;
			this.dataGridViewTextBoxColumn_74.Visible = false;
			this.dataGridViewTextBoxColumn_75.DataPropertyName = "DatePlanRepair";
			this.dataGridViewTextBoxColumn_75.HeaderText = "Дата ремонта (план.)";
			this.dataGridViewTextBoxColumn_75.Name = "dataGridViewTextBoxColumn52";
			this.dataGridViewTextBoxColumn_75.ReadOnly = true;
			this.dataGridViewTextBoxColumn_75.Width = 140;
			this.dataGridViewTextBoxColumn_76.DataPropertyName = "datePlanRepairComm";
			this.dataGridViewTextBoxColumn_76.HeaderText = "Комментарий (план.) ";
			this.dataGridViewTextBoxColumn_76.Name = "dataGridViewTextBoxColumn53";
			this.dataGridViewTextBoxColumn_76.ReadOnly = true;
			this.dataGridViewTextBoxColumn_77.DataPropertyName = "DoorRepair";
			this.dataGridViewTextBoxColumn_77.HeaderText = "Ремонт двери";
			this.dataGridViewTextBoxColumn_77.Name = "dataGridViewTextBoxColumn54";
			this.dataGridViewTextBoxColumn_77.ReadOnly = true;
			this.dataGridViewTextBoxColumn_77.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_77.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_78.DataPropertyName = "OtmostRepair";
			this.dataGridViewTextBoxColumn_78.HeaderText = "Ремонт отмоста";
			this.dataGridViewTextBoxColumn_78.Name = "dataGridViewTextBoxColumn55";
			this.dataGridViewTextBoxColumn_78.ReadOnly = true;
			this.dataGridViewTextBoxColumn_78.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_78.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_79.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_79.HeaderText = "deletedBuildRepair";
			this.dataGridViewTextBoxColumn_79.Name = "dataGridViewTextBoxColumn56";
			this.dataGridViewTextBoxColumn_79.ReadOnly = true;
			this.dataGridViewTextBoxColumn_79.Visible = false;
			this.dataGridViewTextBoxColumn_112.DataPropertyName = "Company";
			this.dataGridViewTextBoxColumn_112.HeaderText = "Организация-подрядчик";
			this.dataGridViewTextBoxColumn_112.Name = "dataGridViewTextBoxColumn57";
			this.dataGridViewTextBoxColumn_112.ReadOnly = true;
			this.dataGridViewTextBoxColumn_112.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_112.Width = 140;
			this.dataGridViewTextBoxColumn_113.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_113.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_113.Name = "dataGridViewTextBoxColumn58";
			this.dataGridViewTextBoxColumn_113.ReadOnly = true;
			this.dataGridViewTextBoxColumn_114.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_114.HeaderText = "deletedBuildRepair";
			this.dataGridViewTextBoxColumn_114.Name = "dataGridViewTextBoxColumn59";
			this.dataGridViewTextBoxColumn_114.ReadOnly = true;
			this.dataGridViewTextBoxColumn_114.Visible = false;
			this.dataGridViewTextBoxColumn_115.DataPropertyName = "ProtocolN";
			this.dataGridViewTextBoxColumn_115.HeaderText = "№ ";
			this.dataGridViewTextBoxColumn_115.Name = "dataGridViewTextBoxColumn60";
			this.dataGridViewTextBoxColumn_115.ReadOnly = true;
			this.dataGridViewTextBoxColumn_115.Visible = false;
			this.dataGridViewTextBoxColumn_115.Width = 50;
			this.dataGridViewTextBoxColumn_116.DataPropertyName = "ProtocolTip";
			this.dataGridViewTextBoxColumn_116.HeaderText = "Тип";
			this.dataGridViewTextBoxColumn_116.Name = "dataGridViewTextBoxColumn61";
			this.dataGridViewTextBoxColumn_116.ReadOnly = true;
			this.dataGridViewTextBoxColumn_116.Width = 50;
			this.dataGridViewTextBoxColumn_117.DataPropertyName = "PovregTip";
			this.dataGridViewTextBoxColumn_117.HeaderText = "Повреждение";
			this.dataGridViewTextBoxColumn_117.Name = "dataGridViewTextBoxColumn62";
			this.dataGridViewTextBoxColumn_117.ReadOnly = true;
			this.dataGridViewTextBoxColumn_118.DataPropertyName = "PovregVid";
			this.dataGridViewTextBoxColumn_118.HeaderText = "Вид повреждения";
			this.dataGridViewTextBoxColumn_118.Name = "dataGridViewTextBoxColumn63";
			this.dataGridViewTextBoxColumn_118.ReadOnly = true;
			this.dataGridViewTextBoxColumn_119.DataPropertyName = "PovregData";
			this.dataGridViewTextBoxColumn_119.HeaderText = "Дата поврежд.";
			this.dataGridViewTextBoxColumn_119.Name = "dataGridViewTextBoxColumn64";
			this.dataGridViewTextBoxColumn_119.ReadOnly = true;
			this.dataGridViewTextBoxColumn_119.Width = 70;
			this.dataGridViewTextBoxColumn_120.DataPropertyName = "RemontData";
			this.dataGridViewTextBoxColumn_120.HeaderText = "Дата ремонта";
			this.dataGridViewTextBoxColumn_120.Name = "dataGridViewTextBoxColumn65";
			this.dataGridViewTextBoxColumn_120.ReadOnly = true;
			this.dataGridViewTextBoxColumn_120.Width = 70;
			this.dataGridViewTextBoxColumn_121.DataPropertyName = "NaimKL";
			this.dataGridViewTextBoxColumn_121.HeaderText = "Наименование кабеля";
			this.dataGridViewTextBoxColumn_121.Name = "dataGridViewTextBoxColumn66";
			this.dataGridViewTextBoxColumn_121.ReadOnly = true;
			this.dataGridViewTextBoxColumn_121.Width = 70;
			this.dataGridViewTextBoxColumn_122.DataPropertyName = "UchN";
			this.dataGridViewTextBoxColumn_122.HeaderText = "№ участка";
			this.dataGridViewTextBoxColumn_122.Name = "dataGridViewTextBoxColumn67";
			this.dataGridViewTextBoxColumn_122.ReadOnly = true;
			this.dataGridViewTextBoxColumn_123.DataPropertyName = "MuftaN";
			this.dataGridViewTextBoxColumn_123.HeaderText = "№ муфты";
			this.dataGridViewTextBoxColumn_123.Name = "dataGridViewTextBoxColumn68";
			this.dataGridViewTextBoxColumn_123.ReadOnly = true;
			this.dataGridViewTextBoxColumn_146.DataPropertyName = "MuftaN";
			this.dataGridViewTextBoxColumn_146.HeaderText = "№ муфты";
			this.dataGridViewTextBoxColumn_146.Name = "dataGridViewTextBoxColumn69";
			this.dataGridViewTextBoxColumn_146.ReadOnly = true;
			this.dataGridViewTextBoxColumn_147.DataPropertyName = "DateDecommissioning";
			this.dataGridViewTextBoxColumn_147.HeaderText = "Дата вывода";
			this.dataGridViewTextBoxColumn_147.Name = "dataGridViewTextBoxColumn70";
			this.dataGridViewTextBoxColumn_147.ReadOnly = true;
			this.dataGridViewTextBoxColumn_148.DataPropertyName = "DateCommissioning";
			this.dataGridViewTextBoxColumn_148.HeaderText = "Дата ввода";
			this.dataGridViewTextBoxColumn_148.Name = "dataGridViewTextBoxColumn71";
			this.dataGridViewTextBoxColumn_148.ReadOnly = true;
			this.dataGridViewTextBoxColumn_149.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_149.HeaderText = "idCabOperation";
			this.dataGridViewTextBoxColumn_149.Name = "dataGridViewTextBoxColumn72";
			this.dataGridViewTextBoxColumn_149.ReadOnly = true;
			this.dataGridViewTextBoxColumn_149.Visible = false;
			this.dataGridViewTextBoxColumn_150.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_150.HeaderText = "idObjListCabOperation";
			this.dataGridViewTextBoxColumn_150.Name = "dataGridViewTextBoxColumn73";
			this.dataGridViewTextBoxColumn_150.ReadOnly = true;
			this.dataGridViewTextBoxColumn_150.Visible = false;
			this.dataGridViewTextBoxColumn_151.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_151.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_151.HeaderText = "Причина";
			this.dataGridViewTextBoxColumn_151.Name = "dataGridViewTextBoxColumn74";
			this.dataGridViewTextBoxColumn_151.ReadOnly = true;
			this.dataGridViewTextBoxColumn_152.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_152.HeaderText = "idCabTesting";
			this.dataGridViewTextBoxColumn_152.Name = "dataGridViewTextBoxColumn75";
			this.dataGridViewTextBoxColumn_152.ReadOnly = true;
			this.dataGridViewTextBoxColumn_152.Visible = false;
			this.dataGridViewTextBoxColumn_153.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_153.HeaderText = "idObjListCabTesting";
			this.dataGridViewTextBoxColumn_153.Name = "dataGridViewTextBoxColumn76";
			this.dataGridViewTextBoxColumn_153.ReadOnly = true;
			this.dataGridViewTextBoxColumn_153.Visible = false;
			this.dataGridViewTextBoxColumn_154.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn_154.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_154.Name = "dataGridViewTextBoxColumn77";
			this.dataGridViewTextBoxColumn_154.ReadOnly = true;
			this.dataGridViewTextBoxColumn_155.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_155.HeaderText = "Причина";
			this.dataGridViewTextBoxColumn_155.Name = "dataGridViewTextBoxColumn78";
			this.dataGridViewTextBoxColumn_155.ReadOnly = true;
			this.dataGridViewTextBoxColumn_156.DataPropertyName = "Voltage";
			this.dataGridViewTextBoxColumn_156.HeaderText = "Напряжение";
			this.dataGridViewTextBoxColumn_156.Name = "dataGridViewTextBoxColumn79";
			this.dataGridViewTextBoxColumn_156.ReadOnly = true;
			this.dataGridViewTextBoxColumn_157.DataPropertyName = "Duration";
			this.dataGridViewTextBoxColumn_157.HeaderText = "Продолжительность";
			this.dataGridViewTextBoxColumn_157.Name = "dataGridViewTextBoxColumn80";
			this.dataGridViewTextBoxColumn_157.ReadOnly = true;
			this.dataGridViewTextBoxColumn_157.Width = 140;
			this.dataGridViewTextBoxColumn_158.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_158.DataPropertyName = "Conclusion";
			this.dataGridViewTextBoxColumn_158.HeaderText = "Заключение";
			this.dataGridViewTextBoxColumn_158.Name = "dataGridViewTextBoxColumn81";
			this.dataGridViewTextBoxColumn_158.ReadOnly = true;
			this.dataGridViewTextBoxColumn_185.DataPropertyName = "id";
			dataGridViewCellStyle52.Format = "D";
			dataGridViewCellStyle52.NullValue = null;
			this.dataGridViewTextBoxColumn_185.DefaultCellStyle = dataGridViewCellStyle52;
			this.dataGridViewTextBoxColumn_185.HeaderText = "idPeram";
			this.dataGridViewTextBoxColumn_185.Name = "dataGridViewTextBoxColumn82";
			this.dataGridViewTextBoxColumn_185.Visible = false;
			this.dataGridViewTextBoxColumn_186.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_186.HeaderText = "idObjListPeram";
			this.dataGridViewTextBoxColumn_186.Name = "dataGridViewTextBoxColumn83";
			this.dataGridViewTextBoxColumn_186.Visible = false;
			this.dataGridViewTextBoxColumn_187.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn_187.HeaderText = "Дата обхода";
			this.dataGridViewTextBoxColumn_187.Name = "dataGridViewTextBoxColumn84";
			this.dataGridViewTextBoxColumn_188.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_188.DataPropertyName = "Defect";
			this.dataGridViewTextBoxColumn_188.HeaderText = "Обнаружение неисправности";
			this.dataGridViewTextBoxColumn_188.Name = "dataGridViewTextBoxColumn85";
			this.dataGridViewTextBoxColumn_189.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_189.DataPropertyName = "Repair";
			this.dataGridViewTextBoxColumn_189.HeaderText = "Меры, принятые по устранению неисправности";
			this.dataGridViewTextBoxColumn_189.Name = "dataGridViewTextBoxColumn86";
			this.dataGridViewTextBoxColumn_190.DataPropertyName = "DateIn";
			this.dataGridViewTextBoxColumn_190.HeaderText = "DateInPeram";
			this.dataGridViewTextBoxColumn_190.Name = "dataGridViewTextBoxColumn87";
			this.dataGridViewTextBoxColumn_190.Visible = false;
			this.dataGridViewTextBoxColumn_191.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_191.HeaderText = "idPole";
			this.dataGridViewTextBoxColumn_191.Name = "dataGridViewTextBoxColumn88";
			this.dataGridViewTextBoxColumn_191.Visible = false;
			this.dataGridViewTextBoxColumn_192.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_192.HeaderText = "idObjListPole";
			this.dataGridViewTextBoxColumn_192.Name = "dataGridViewTextBoxColumn89";
			this.dataGridViewTextBoxColumn_192.Visible = false;
			this.dataGridViewTextBoxColumn_193.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_193.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_193.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_193.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn_193.Name = "dataGridViewTextBoxColumn90";
			this.dataGridViewTextBoxColumn_194.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_194.HeaderText = "id";
			this.dataGridViewTextBoxColumn_194.Name = "dataGridViewTextBoxColumn91";
			this.dataGridViewTextBoxColumn_194.Visible = false;
			this.dataGridViewTextBoxColumn_195.DataPropertyName = "idSubstation";
			this.dataGridViewTextBoxColumn_195.HeaderText = "idSubstation";
			this.dataGridViewTextBoxColumn_195.Name = "dataGridViewTextBoxColumn92";
			this.dataGridViewTextBoxColumn_195.Visible = false;
			this.dataGridViewTextBoxColumn_196.DataPropertyName = "NameSubstation";
			this.dataGridViewTextBoxColumn_196.HeaderText = "Подстанция";
			this.dataGridViewTextBoxColumn_196.Name = "dataGridViewTextBoxColumn93";
			this.dataGridViewTextBoxColumn_197.DataPropertyName = "idTransf";
			this.dataGridViewTextBoxColumn_197.HeaderText = "idTransf";
			this.dataGridViewTextBoxColumn_197.Name = "dataGridViewTextBoxColumn94";
			this.dataGridViewTextBoxColumn_197.Visible = false;
			this.dataGridViewTextBoxColumn_198.DataPropertyName = "NameTransf";
			this.dataGridViewTextBoxColumn_198.HeaderText = "Трансформатор";
			this.dataGridViewTextBoxColumn_198.Name = "dataGridViewTextBoxColumn95";
			this.dataGridViewTextBoxColumn_199.DataPropertyName = "Dogovor";
			this.dataGridViewTextBoxColumn_199.HeaderText = "Номер договора";
			this.dataGridViewTextBoxColumn_199.Name = "dataGridViewTextBoxColumn96";
			this.dataGridViewTextBoxColumn_200.DataPropertyName = "dateBegin";
			this.dataGridViewTextBoxColumn_200.HeaderText = "Дата закл. договора";
			this.dataGridViewTextBoxColumn_200.Name = "dataGridViewTextBoxColumn97";
			this.dataGridViewTextBoxColumn_201.DataPropertyName = "dateEnd";
			this.dataGridViewTextBoxColumn_201.HeaderText = "Дата окон. договора";
			this.dataGridViewTextBoxColumn_201.Name = "dataGridViewTextBoxColumn98";
			this.dataGridViewTextBoxColumn_202.DataPropertyName = "Company";
			this.dataGridViewTextBoxColumn_202.HeaderText = "Наименование потребителя";
			this.dataGridViewTextBoxColumn_202.Name = "dataGridViewTextBoxColumn99";
			this.dataGridViewTextBoxColumn_203.DataPropertyName = "MaxPower";
			this.dataGridViewTextBoxColumn_203.HeaderText = "Максимальная мощность, кВА";
			this.dataGridViewTextBoxColumn_203.Name = "dataGridViewTextBoxColumn100";
			this.dataGridViewTextBoxColumn_203.Width = 110;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "IdObj";
			this.dataGridViewTextBoxColumn_0.HeaderText = "IdObj";
			this.dataGridViewTextBoxColumn_0.Name = "IdObj";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "TypeCodeId";
			this.dataGridViewTextBoxColumn_1.HeaderText = "TypeCodeId";
			this.dataGridViewTextBoxColumn_1.Name = "TypeCodeId";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_2.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn_2.Name = "NameObj";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_217.DataPropertyName = "idEquipment";
			this.dataGridViewTextBoxColumn_217.HeaderText = "idEquipment";
			this.dataGridViewTextBoxColumn_217.Name = "idEquipmentDgvClutchConn";
			this.dataGridViewTextBoxColumn_217.ReadOnly = true;
			this.dataGridViewTextBoxColumn_217.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(784, 562);
			base.Controls.Add(this.tableLayoutPanel_1);
			base.Name = "FormRegistr";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Журнал оборудования";
			base.FormClosing += this.FormRegistr_FormClosing;
			base.Load += this.FormRegistr_Load;
			base.Shown += this.FormRegistr_Shown;
			this.contextMenuStrip_0.ResumeLayout(false);
			this.contextMenuStrip_1.ResumeLayout(false);
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_1.ResumeLayout(false);
			this.tableLayoutPanel_1.PerformLayout();
			this.toolStrip_1.ResumeLayout(false);
			this.toolStrip_1.PerformLayout();
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			this.tableLayoutPanel_6.ResumeLayout(false);
			((ISupportInitialize)this.dataGridView_4).EndInit();
			this.dataGridViewExcelFilter_0.EndInit();
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_5.ResumeLayout(false);
			this.tableLayoutPanel_8.ResumeLayout(false);
			this.tableLayoutPanel_8.PerformLayout();
			this.toolStrip_7.ResumeLayout(false);
			this.toolStrip_7.PerformLayout();
			((ISupportInitialize)this.dataGridView_6).EndInit();
			this.tabPage_1.ResumeLayout(false);
			this.tableLayoutPanel_3.ResumeLayout(false);
			this.tableLayoutPanel_3.PerformLayout();
			((ISupportInitialize)this.dataGridView_1).EndInit();
			this.contextMenuStrip_3.ResumeLayout(false);
			this.toolStrip_3.ResumeLayout(false);
			this.toolStrip_3.PerformLayout();
			this.tabPage_2.ResumeLayout(false);
			this.tableLayoutPanel_4.ResumeLayout(false);
			this.tableLayoutPanel_4.PerformLayout();
			((ISupportInitialize)this.dataGridView_2).EndInit();
			this.contextMenuStrip_6.ResumeLayout(false);
			this.toolStrip_4.ResumeLayout(false);
			this.toolStrip_4.PerformLayout();
			this.tabPage_12.ResumeLayout(false);
			this.tableLayoutPanel_15.ResumeLayout(false);
			this.tableLayoutPanel_15.PerformLayout();
			((ISupportInitialize)this.dataGridView_11).EndInit();
			this.contextMenuStrip_10.ResumeLayout(false);
			this.toolStrip_14.ResumeLayout(false);
			this.toolStrip_14.PerformLayout();
			this.tabPage_0.ResumeLayout(false);
			this.tableLayoutPanel_2.ResumeLayout(false);
			this.tableLayoutPanel_2.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			this.contextMenuStrip_2.ResumeLayout(false);
			this.toolStrip_2.ResumeLayout(false);
			this.toolStrip_2.PerformLayout();
			this.tabPage_3.ResumeLayout(false);
			this.tableLayoutPanel_5.ResumeLayout(false);
			this.tableLayoutPanel_5.PerformLayout();
			((ISupportInitialize)this.dataGridView_3).EndInit();
			this.contextMenuStrip_4.ResumeLayout(false);
			this.toolStrip_5.ResumeLayout(false);
			this.toolStrip_5.PerformLayout();
			this.tabPage_4.ResumeLayout(false);
			this.tableLayoutPanel_7.ResumeLayout(false);
			this.tableLayoutPanel_7.PerformLayout();
			((ISupportInitialize)this.dataGridView_5).EndInit();
			this.contextMenuStrip_5.ResumeLayout(false);
			this.toolStrip_6.ResumeLayout(false);
			this.toolStrip_6.PerformLayout();
			this.tabPage_6.ResumeLayout(false);
			this.tableLayoutPanel_9.ResumeLayout(false);
			this.tableLayoutPanel_9.PerformLayout();
			((ISupportInitialize)this.dataGridView_7).EndInit();
			this.toolStrip_8.ResumeLayout(false);
			this.toolStrip_8.PerformLayout();
			this.tabPage_7.ResumeLayout(false);
			this.tableLayoutPanel_10.ResumeLayout(false);
			this.tableLayoutPanel_10.PerformLayout();
			((ISupportInitialize)this.dataGridView_8).EndInit();
			((ISupportInitialize)this.bindingSource_5).EndInit();
			((ISupportInitialize)this.dsPassport_0).EndInit();
			this.toolStrip_9.ResumeLayout(false);
			this.toolStrip_9.PerformLayout();
			this.tabPage_8.ResumeLayout(false);
			this.tableLayoutPanel_11.ResumeLayout(false);
			this.tableLayoutPanel_11.PerformLayout();
			((ISupportInitialize)this.dataGridView_9).EndInit();
			((ISupportInitialize)this.bindingSource_6).EndInit();
			this.toolStrip_10.ResumeLayout(false);
			this.toolStrip_10.PerformLayout();
			this.tabPage_9.ResumeLayout(false);
			this.tabPage_9.PerformLayout();
			this.toolStrip_11.ResumeLayout(false);
			this.toolStrip_11.PerformLayout();
			this.tableLayoutPanel_12.ResumeLayout(false);
			this.dataGridViewExcelFilter_1.EndInit();
			((ISupportInitialize)this.bindingSource_8).EndInit();
			this.tabPage_10.ResumeLayout(false);
			this.tableLayoutPanel_13.ResumeLayout(false);
			this.tableLayoutPanel_13.PerformLayout();
			this.toolStrip_12.ResumeLayout(false);
			this.toolStrip_12.PerformLayout();
			this.treeDataGridView_0.EndInit();
			this.contextMenuStrip_8.ResumeLayout(false);
			this.tabPage_11.ResumeLayout(false);
			this.tableLayoutPanel_14.ResumeLayout(false);
			this.tableLayoutPanel_14.PerformLayout();
			((ISupportInitialize)this.dataGridView_10).EndInit();
			this.contextMenuStrip_9.ResumeLayout(false);
			this.toolStrip_13.ResumeLayout(false);
			this.toolStrip_13.PerformLayout();
			this.tabPage_13.ResumeLayout(false);
			this.tabPage_13.PerformLayout();
			this.toolStrip_15.ResumeLayout(false);
			this.toolStrip_15.PerformLayout();
			this.tableLayoutPanel_16.ResumeLayout(false);
			this.dataGridViewExcelFilter_2.EndInit();
			((ISupportInitialize)this.bindingSource_9).EndInit();
			this.contextMenuStrip_7.ResumeLayout(false);
			((ISupportInitialize)this.bindingSource_1).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			((ISupportInitialize)this.bindingSource_3).EndInit();
			((ISupportInitialize)this.bindingSource_4).EndInit();
			((ISupportInitialize)this.bindingSource_7).EndInit();
			base.ResumeLayout(false);
		}

		[CompilerGenerated]
		private void method_90()
		{
			this.formProgressBar_0.Show();
		}

		[CompilerGenerated]
		private void method_91()
		{
			this.formProgressBar_0.Hide();
			this.toolStripButton_2.Enabled = true;
		}

		[CompilerGenerated]
		private GoToSchemaEventHandler goToSchemaEventHandler_0;

		private TypeObjListGroup typeObjListGroup_0 = TypeObjListGroup.None;

		private FormRegistrSettings formRegistrSettings_0 = new FormRegistrSettings();

		private FormProgressBar formProgressBar_0 = new FormProgressBar();

		private ToolStripControlHost toolStripControlHost_0;

		private DateTimePicker dateTimePicker_0;

		private ToolStripControlHost toolStripControlHost_1;

		private ComboBox comboBox_0;

		private DataTable dataTable_0 = new DataTable();

		private FormSearch formSearch_0;

		private int int_0;

		private int int_1;

		private int int_2;

		private bool bool_0;

		private string string_0;

		private string string_1;

		private bool bool_1;

		private int int_3;

		private bool bool_2;

		private int int_4;

		private EquipmentDocType equipmentDocType_0 = EquipmentDocType.None;

		private List<int> list_0;

		private ToolTip toolTip_0;

		private IContainer icontainer_0;

		private dsPassport dsPassport_0;

		private BackgroundWorker backgroundWorker_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private ContextMenuStrip contextMenuStrip_0;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripMenuItem toolStripMenuItem_1;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripMenuItem toolStripMenuItem_2;

		private ContextMenuStrip contextMenuStrip_1;

		private ToolStripMenuItem toolStripMenuItem_3;

		private ToolStripSeparator toolStripSeparator_2;

		private ToolStripMenuItem toolStripMenuItem_4;

		private TableLayoutPanel tableLayoutPanel_0;

		private Button button_0;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripSeparator toolStripSeparator_3;

		private ToolStripButton toolStripButton_1;

		private ToolStripSeparator toolStripSeparator_4;

		private ToolStripLabel toolStripLabel_0;

		private ToolStripComboBox toolStripComboBox_0;

		private ToolStripSeparator toolStripSeparator_5;

		private ToolStripComboBox toolStripComboBox_1;

		private ToolStripSeparator toolStripSeparator_6;

		private ToolStripButton toolStripButton_2;

		private TableLayoutPanel tableLayoutPanel_1;

		private ToolStrip toolStrip_1;

		private SplitContainer splitContainer_0;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private dsDocuments dsDocuments_0;

		private ContextMenuStrip contextMenuStrip_2;

		private ToolStripMenuItem toolStripMenuItem_5;

		private ToolStripMenuItem toolStripMenuItem_6;

		private ToolStripSeparator toolStripSeparator_7;

		private ToolStripMenuItem toolStripMenuItem_7;

		private ToolStripMenuItem toolStripMenuItem_8;

		private ToolStripSeparator toolStripSeparator_8;

		private ToolStripSeparator toolStripSeparator_9;

		private ToolStripButton toolStripButton_3;

		private TableLayoutPanel tableLayoutPanel_2;

		private DataGridView dataGridView_0;

		private ToolStrip toolStrip_2;

		private ToolStripButton toolStripButton_4;

		private ToolStripSeparator toolStripSeparator_10;

		private ToolStripButton toolStripButton_5;

		private ToolStripSeparator toolStripSeparator_11;

		private ToolStripButton toolStripButton_6;

		private TabPage tabPage_1;

		private TableLayoutPanel tableLayoutPanel_3;

		private DataGridView dataGridView_1;

		private ToolStrip toolStrip_3;

		private ToolStripButton toolStripButton_7;

		private ToolStripButton toolStripButton_8;

		private ToolStripSeparator toolStripSeparator_12;

		private ToolStripButton toolStripButton_9;

		private ContextMenuStrip contextMenuStrip_3;

		private ToolStripMenuItem toolStripMenuItem_9;

		private ToolStripMenuItem toolStripMenuItem_10;

		private ToolStripMenuItem toolStripMenuItem_11;

		private ToolStripSeparator toolStripSeparator_13;

		private ToolStripMenuItem toolStripMenuItem_12;

		private TabPage tabPage_2;

		private TableLayoutPanel tableLayoutPanel_4;

		private DataGridView dataGridView_2;

		private ToolStrip toolStrip_4;

		private ToolStripButton toolStripButton_10;

		private ToolStripSeparator toolStripSeparator_14;

		private ToolStripButton toolStripButton_11;

		private ToolStripSeparator toolStripSeparator_15;

		private ToolStripButton toolStripButton_12;

		private ToolStripMenuItem toolStripMenuItem_13;

		private ToolStripMenuItem toolStripMenuItem_14;

		private ToolStripMenuItem toolStripMenuItem_15;

		private ToolStripMenuItem toolStripMenuItem_16;

		private ToolStripMenuItem toolStripMenuItem_17;

		private ToolStripSeparator toolStripSeparator_16;

		private ToolStripMenuItem toolStripMenuItem_18;

		private TabPage tabPage_3;

		private ToolStripButton toolStripButton_13;

		private ToolStripSeparator toolStripSeparator_17;

		private ToolStripButton toolStripButton_14;

		private TableLayoutPanel tableLayoutPanel_5;

		private DataGridView dataGridView_3;

		private ToolStrip toolStrip_5;

		private ToolStripButton toolStripButton_15;

		private ToolStripButton toolStripButton_16;

		private ToolStripSeparator toolStripSeparator_18;

		private ToolStripButton toolStripButton_17;

		private ToolStripSeparator toolStripSeparator_19;

		private ToolStripButton toolStripButton_18;

		private ToolStripSeparator toolStripSeparator_20;

		private ToolStripButton toolStripButton_19;

		private ToolStripSeparator toolStripSeparator_21;

		private ToolStripMenuItem toolStripMenuItem_19;

		private ToolStripSeparator toolStripSeparator_22;

		private ToolStripMenuItem toolStripMenuItem_20;

		private ToolStripSeparator toolStripSeparator_23;

		private ToolStripMenuItem toolStripMenuItem_21;

		private ContextMenuStrip contextMenuStrip_4;

		private ToolStripMenuItem toolStripMenuItem_22;

		private ToolStripMenuItem toolStripMenuItem_23;

		private ToolStripSeparator toolStripSeparator_24;

		private ToolStripMenuItem toolStripMenuItem_24;

		private ToolStripSeparator toolStripSeparator_25;

		private ToolStripMenuItem toolStripMenuItem_25;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;

		private TableLayoutPanel tableLayoutPanel_6;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private DataGridView dataGridView_4;

		private ToolStripButton toolStripButton_20;

		private ToolStripButton toolStripButton_21;

		private TabPage tabPage_4;

		private TableLayoutPanel tableLayoutPanel_7;

		private DataGridView dataGridView_5;

		private ToolStrip toolStrip_6;

		private ToolStripButton toolStripButton_22;

		private ToolStripButton toolStripButton_23;

		private ToolStripSeparator toolStripSeparator_26;

		private ToolStripButton toolStripButton_24;

		private ToolStripSeparator toolStripSeparator_27;

		private ToolStripButton toolStripButton_25;

		private ToolStripButton toolStripButton_26;

		private BindingSource bindingSource_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;

		private BindingSource bindingSource_1;

		private ContextMenuStrip contextMenuStrip_5;

		private ToolStripMenuItem toolStripMenuItem_26;

		private ToolStripMenuItem toolStripMenuItem_27;

		private ToolStripSeparator toolStripSeparator_28;

		private ToolStripMenuItem toolStripMenuItem_28;

		private ToolStripSeparator toolStripSeparator_29;

		private ToolStripMenuItem toolStripMenuItem_29;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_70;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_71;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_72;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_73;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_74;

		private BindingSource bindingSource_2;

		private BindingSource bindingSource_3;

		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_75;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_76;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_77;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_78;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_79;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_80;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_81;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_82;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_83;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_84;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_85;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_86;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_87;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_88;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_89;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_90;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_91;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_92;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_93;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_94;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_95;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_96;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_97;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_98;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_99;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_100;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_101;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_102;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_103;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_104;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_105;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_106;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_107;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_108;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_109;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_110;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_111;

		private ToolStripButton toolStripButton_27;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_112;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_113;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_114;

		private ContextMenuStrip contextMenuStrip_6;

		private ToolStripMenuItem toolStripMenuItem_30;

		private ToolStripMenuItem toolStripMenuItem_31;

		private ToolStripMenuItem toolStripMenuItem_32;

		private ToolStripMenuItem toolStripMenuItem_33;

		private ToolStripMenuItem toolStripMenuItem_34;

		private ToolStripSeparator toolStripSeparator_30;

		private ToolStripMenuItem toolStripMenuItem_35;

		private ToolStripSeparator toolStripSeparator_31;

		private ToolStripMenuItem toolStripMenuItem_36;

		private ToolStripMenuItem toolStripMenuItem_37;

		private ToolStripMenuItem toolStripMenuItem_38;

		private TabPage tabPage_5;

		private TableLayoutPanel tableLayoutPanel_8;

		private ToolStrip toolStrip_7;

		private ToolStripButton toolStripButton_28;

		private ToolStripSeparator toolStripSeparator_32;

		private ToolStripButton toolStripButton_29;

		private ToolStripSeparator toolStripSeparator_33;

		private ToolStripButton toolStripButton_30;

		private ToolStripSeparator toolStripSeparator_34;

		private ToolStripButton toolStripButton_31;

		private DataGridView dataGridView_6;

		private ToolStripButton toolStripButton_32;

		private ToolStripMenuItem toolStripMenuItem_39;

		private TabPage tabPage_6;

		private TableLayoutPanel tableLayoutPanel_9;

		private DataGridView dataGridView_7;

		private ToolStrip toolStrip_8;

		private ToolStripButton toolStripButton_33;

		private ToolStripButton toolStripButton_34;

		private ToolStripSeparator toolStripSeparator_35;

		private ToolStripButton toolStripButton_35;

		private ToolStripSeparator toolStripSeparator_36;

		private ToolStripButton toolStripButton_36;

		private ToolStripSeparator toolStripSeparator_37;

		private ToolStripButton toolStripButton_37;

		private ToolStripSeparator toolStripSeparator_38;

		private ToolStripButton toolStripButton_38;

		private BindingSource bindingSource_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_115;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_116;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_117;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_118;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_119;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_120;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_121;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_122;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_123;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_124;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_125;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_126;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_127;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_128;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_129;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_130;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_131;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_132;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_133;

		private ToolStripMenuItem toolStripMenuItem_40;

		private ToolStripMenuItem toolStripMenuItem_41;

		private TabPage tabPage_7;

		private TableLayoutPanel tableLayoutPanel_10;

		private DataGridView dataGridView_8;

		private ToolStrip toolStrip_9;

		private ToolStripSeparator toolStripSeparator_39;

		private ToolStripButton toolStripButton_39;

		private ToolStripSeparator toolStripSeparator_40;

		private ToolStripButton toolStripButton_40;

		private ToolStripSeparator toolStripSeparator_41;

		private ToolStripButton toolStripButton_41;

		private TabPage tabPage_8;

		private TableLayoutPanel tableLayoutPanel_11;

		private DataGridView dataGridView_9;

		private ToolStrip toolStrip_10;

		private ToolStripButton toolStripButton_42;

		private ToolStripButton toolStripButton_43;

		private ToolStripSeparator toolStripSeparator_42;

		private ToolStripButton toolStripButton_44;

		private ToolStripSeparator toolStripSeparator_43;

		private ToolStripButton toolStripButton_45;

		private BindingSource bindingSource_5;

		private BindingSource bindingSource_6;

		private BindingSource bindingSource_7;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_134;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_135;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_136;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_137;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_138;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_139;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_140;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_141;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_142;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_143;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_144;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_145;

		private ToolStripSeparator toolStripSeparator_44;

		private ToolStripLabel toolStripLabel_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_146;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_147;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_148;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_149;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_150;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_151;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_152;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_153;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_154;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_155;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_156;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_157;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_158;

		private ToolStripMenuItem toolStripMenuItem_42;

		private TabPage tabPage_9;

		private ToolStrip toolStrip_11;

		private ToolStripButton toolStripButton_46;

		private ToolStripButton toolStripButton_47;

		private ToolStripSeparator toolStripSeparator_45;

		private ToolStripButton toolStripButton_48;

		private ToolStripSeparator toolStripSeparator_46;

		private ToolStripButton toolStripButton_49;

		private TableLayoutPanel tableLayoutPanel_12;

		private ContextMenuStrip contextMenuStrip_7;

		private ToolStripMenuItem toolStripMenuItem_43;

		private ToolStripMenuItem toolStripMenuItem_44;

		private ToolStripSeparator toolStripSeparator_47;

		private ToolStripMenuItem toolStripMenuItem_45;

		private ToolStripSeparator toolStripSeparator_48;

		private ToolStripMenuItem toolStripMenuItem_46;

		private BindingSource bindingSource_8;

		private DataGridViewExcelFilter dataGridViewExcelFilter_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_159;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_160;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_161;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_162;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_163;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_164;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

		private TabPage tabPage_10;

		private TabPage tabPage_11;

		private TableLayoutPanel tableLayoutPanel_13;

		private ToolStrip toolStrip_12;

		private ToolStripButton toolStripButton_50;

		private ToolStripButton toolStripButton_51;

		private ToolStripSeparator toolStripSeparator_49;

		private ToolStripButton toolStripButton_52;

		private ToolStripSeparator toolStripSeparator_50;

		private ToolStripButton toolStripButton_53;

		private TreeDataGridView treeDataGridView_0;

		private TableLayoutPanel tableLayoutPanel_14;

		private DataGridView dataGridView_10;

		private ToolStrip toolStrip_13;

		private ToolStripButton toolStripButton_54;

		private ToolStripButton toolStripButton_55;

		private ToolStripSeparator toolStripSeparator_51;

		private ToolStripButton toolStripButton_56;

		private ToolStripSeparator toolStripSeparator_52;

		private ToolStripButton toolStripButton_57;

		private TreeGridColumn treeGridColumn_0;

		private TreeGridColumn treeGridColumn_1;

		private TreeGridColumn treeGridColumn_2;

		private TreeGridColumn treeGridColumn_3;

		private TreeGridColumn treeGridColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_165;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_166;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_167;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_168;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_169;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_170;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_171;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_172;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_173;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_174;

		private ContextMenuStrip contextMenuStrip_8;

		private ToolStripMenuItem toolStripMenuItem_47;

		private ToolStripMenuItem toolStripMenuItem_48;

		private ToolStripSeparator toolStripSeparator_53;

		private ToolStripMenuItem toolStripMenuItem_49;

		private ToolStripSeparator toolStripSeparator_54;

		private ToolStripMenuItem toolStripMenuItem_50;

		private ContextMenuStrip contextMenuStrip_9;

		private ToolStripMenuItem toolStripMenuItem_51;

		private ToolStripMenuItem toolStripMenuItem_52;

		private ToolStripSeparator toolStripSeparator_55;

		private ToolStripMenuItem toolStripMenuItem_53;

		private ToolStripSeparator toolStripSeparator_56;

		private ToolStripMenuItem toolStripMenuItem_54;

		private ToolStripMenuItem toolStripMenuItem_55;

		private TabPage tabPage_12;

		private TableLayoutPanel tableLayoutPanel_15;

		private DataGridView dataGridView_11;

		private ToolStrip toolStrip_14;

		private ToolStripButton toolStripButton_58;

		private ToolStripButton toolStripButton_59;

		private ToolStripSeparator toolStripSeparator_57;

		private ToolStripButton toolStripButton_60;

		private ToolStripSeparator toolStripSeparator_58;

		private ToolStripButton toolStripButton_61;

		private ContextMenuStrip contextMenuStrip_10;

		private ToolStripMenuItem toolStripMenuItem_56;

		private ToolStripMenuItem toolStripMenuItem_57;

		private ToolStripSeparator toolStripSeparator_59;

		private ToolStripMenuItem toolStripMenuItem_58;

		private ToolStripMenuItem toolStripMenuItem_59;

		private ToolStripSeparator toolStripSeparator_60;

		private ToolStripButton toolStripButton_62;

		private ToolStripButton toolStripButton_63;

		private ToolStripSeparator toolStripSeparator_61;

		private ToolStripButton toolStripButton_64;

		private ToolStripSeparator toolStripSeparator_62;

		private ToolStripButton toolStripButton_65;

		private ToolStripSeparator toolStripSeparator_63;

		private ToolStripButton toolStripButton_66;

		private ToolStripSeparator toolStripSeparator_64;

		private ToolStripButton toolStripButton_67;

		private ToolStripSeparator toolStripSeparator_65;

		private ToolStripButton toolStripButton_68;

		private BindingSource bindingSource_9;

		private TabPage tabPage_13;

		private ToolStrip toolStrip_15;

		private ToolStripButton toolStripButton_69;

		private ToolStripButton toolStripButton_70;

		private ToolStripSeparator toolStripSeparator_66;

		private ToolStripButton toolStripButton_71;

		private ToolStripSeparator toolStripSeparator_67;

		private ToolStripButton toolStripButton_72;

		private TableLayoutPanel tableLayoutPanel_16;

		private DataGridViewExcelFilter dataGridViewExcelFilter_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_175;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_176;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_177;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_178;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_179;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_180;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_181;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_182;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_183;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_184;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;

		private ToolStripMenuItem toolStripMenuItem_60;

		private ToolStripButton toolStripButton_73;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_185;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_186;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_187;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_188;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_189;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_190;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_191;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_192;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_193;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_194;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_195;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_196;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_197;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_198;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_199;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_200;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_201;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_202;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_203;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_204;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_205;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_206;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_207;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_208;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_209;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_210;

		private ToolStripMenuItem toolStripMenuItem_61;

		private ToolStripMenuItem toolStripMenuItem_62;

		private ToolStripMenuItem toolStripMenuItem_63;

		private ToolStripMenuItem toolStripMenuItem_64;

		private ToolStripSplitButton toolStripSplitButton_0;

		private ToolStripMenuItem toolStripMenuItem_65;

		private ToolStripMenuItem toolStripMenuItem_66;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_211;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_212;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_213;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_214;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_215;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_216;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_217;

		[CompilerGenerated]
		private sealed class Class122
		{
			internal void method_0()
			{
				this.equipmentDocType_0 = (EquipmentDocType)this.formRegistr_0.toolStripComboBox_0.SelectedIndex;
			}

			internal void method_1()
			{
				this.int_0 = new int[]
				{
					(int)((ComboBox)this.formRegistr_0.toolStripComboBox_1.Control).SelectedValue
				};
				if (this.int_0[0] == -1)
				{
					this.int_0 = this.formRegistr_0.method_0(this.formRegistr_0.typeObjListGroup_0);
				}
			}

			public EquipmentDocType equipmentDocType_0;

			public int[] int_0;

			public FormRegistr formRegistr_0;
		}

		[CompilerGenerated]
		private sealed class Class123
		{
			internal void method_0()
			{
				this.formRegistr_0.DataToExcel(this.dataGridViewParse_0.ObjectColumnVisibleHeaders, this.dataGridViewParse_0.ObjectVisibleData, this.dataGridViewParse_0.RowCount, this.dataGridViewParse_0.ColumnVisibleCount, this.dataGridViewParse_0.ColunmWidths);
			}

			public DataGridViewParse dataGridViewParse_0;

			public FormRegistr formRegistr_0;
		}

		[CompilerGenerated]
		private sealed class Class124
		{
			internal void method_0()
			{
				this.xmlSpreadsheet_0.SheetName = this.formRegistr_0.toolStripComboBox_0.SelectedItem.ToString();
			}

			public XmlSpreadsheet xmlSpreadsheet_0;

			public FormRegistr formRegistr_0;
		}

		[CompilerGenerated]
		private sealed class Class125
		{
			internal bool method_0(XElement xelement_0)
			{
				return xelement_0.Attribute(XName.Get("ID")).Value == this.int_0.ToString();
			}

			public int int_0;
		}

		[CompilerGenerated]
		private sealed class Class126
		{
			internal bool method_0(dsPassport.Class84 class84_0)
			{
				return class84_0.idPoleFirst == (int)this.treeDataGridViewNode_0.Cells[3].Value;
			}

			public TreeDataGridViewNode treeDataGridViewNode_0;
		}
	}
}
